using System.Text;
using Android.Nfc.CardEmulators;

namespace WillowMaze.App.Services;

internal static class HceAppletRuntime
{
    private const int MaxEntries = 80;
    private const string DefaultResponseText = "{\"service\":\"hce_apdu\",\"message\":\"willow_maze_ready\"}";
    private static readonly object Sync = new();
    private static readonly List<string> entries = [];
    private static readonly HashSet<string> dynamicAidHexValues = new(StringComparer.OrdinalIgnoreCase);

    private static string responseText = DefaultResponseText;
    private static string? selectedAidHex;

    public const string AidHex = "F0770A11B1C2D3";

    public static event EventHandler? Changed;

    public static string ResponseText
    {
        get
        {
            lock (Sync)
            {
                return responseText;
            }
        }
    }

    public static IReadOnlyList<string> Entries
    {
        get
        {
            lock (Sync)
            {
                return entries.ToArray();
            }
        }
    }

    public static string Jsonl
    {
        get
        {
            lock (Sync)
            {
                return NfcJson.Join(entries);
            }
        }
    }

    public static IReadOnlyList<string> EffectiveAids
    {
        get
        {
            lock (Sync)
            {
                return [AidHex, .. dynamicAidHexValues.OrderBy(static value => value, StringComparer.OrdinalIgnoreCase)];
            }
        }
    }

    public static void UpdateResponseText(string value)
    {
        var next = string.IsNullOrWhiteSpace(value) ? DefaultResponseText : value.Trim();
        lock (Sync)
        {
            responseText = next;
            Append("config", "response_updated", new
            {
                selectedAidHex,
                preview = Trim(next)
            });
        }

        RaiseChanged();
    }

    public static void SetDynamicAids(IEnumerable<string> aids)
    {
        lock (Sync)
        {
            dynamicAidHexValues.Clear();
            foreach (var aid in aids
                         .Select(static value => NormalizeAid(value))
                         .Where(static value => !string.IsNullOrWhiteSpace(value)))
            {
                dynamicAidHexValues.Add(aid);
            }

            Append("config", "dynamic_aids_updated", new
            {
                aids = EffectiveAids
            });
        }

        RaiseChanged();
    }

    public static byte[]? ProcessCommandApdu(byte[]? commandApdu, Action<byte[]>? sendResponse = null)
    {
        if (commandApdu is null || commandApdu.Length < 4)
        {
            return StatusWord(0x67, 0x00, "apdu_error", new { reason = "malformed_apdu" });
        }

        var commandHex = Convert.ToHexString(commandApdu);
        Log("command_apdu", new
        {
            commandHex
        });

        if (TryMatchSelectAid(commandApdu, out var matchedAidHex))
        {
            lock (Sync)
            {
                selectedAidHex = matchedAidHex;
            }

            TapRelayClient.SendTap("SelectAid", matchedAidHex, Trim(ResponseText));

            return EncodePayloadResponse(ResponseText, "select_ok", new
            {
                aidHex = matchedAidHex
            });
        }

        if (IsGetData(commandApdu))
        {
            if (!HasSelectedAid())
            {
                return StatusWord(0x69, 0x85, "get_data_rejected", new
                {
                    reason = "conditions_not_satisfied"
                });
            }

            TapRelayClient.SendTap("GetData", selectedAidHex, Trim(ResponseText));

            return EncodePayloadResponse(ResponseText, "get_data_ok", new
            {
                aidHex = selectedAidHex
            });
        }

        if (IsPutData(commandApdu))
        {
            var payload = ExtractLcPayload(commandApdu);
            var text = payload.Length == 0 ? DefaultResponseText : Encoding.UTF8.GetString(payload);
            UpdateResponseText(text);
            return StatusWord(0x90, 0x00, "put_data_ok", new
            {
                payloadPreview = Trim(text)
            });
        }

        if (IsEcho(commandApdu))
        {
            var payload = ExtractLcPayload(commandApdu);
            return AppendStatus(payload, 0x90, 0x00, "echo_ok", new
            {
                responseHex = Convert.ToHexString(payload)
            });
        }

        if (IsAsyncResponse(commandApdu))
        {
            var payload = ExtractLcPayload(commandApdu);
            var text = payload.Length == 0 ? ResponseText : Encoding.UTF8.GetString(payload);
            sendResponse?.Invoke(AppendStatus(Encoding.UTF8.GetBytes(text), 0x90, 0x00, "async_response_sent", new
            {
                payloadPreview = Trim(text)
            }));

            Log("async_response_queued", new
            {
                payloadPreview = Trim(text)
            });

            return null;
        }

        return StatusWord(0x6D, 0x00, "unsupported_apdu", new
        {
            commandHex
        });
    }

    public static void LogDeactivated(DeactivationReason reason)
    {
        Log("deactivated", new
        {
            reason = reason.ToString()
        });
    }

    public static void LogNfcInternalError(int errorCode)
    {
        var errorName = errorCode switch
        {
            1 => "COMMAND_TIMEOUT",
            2 => "NFC_CRASH_RESTART",
            3 => "NFC_HARDWARE_ERROR",
            _ => $"UNKNOWN ({errorCode})"
        };

        Log("nfc_internal_error", new
        {
            errorCode,
            errorName
        });
    }

    public static void LogPollingFrames(IList<PollingFrame>? frames)
    {
        if (frames is null || frames.Count == 0)
        {
            return;
        }

        var items = frames.Select(frame => new
        {
            type = frame.Type.ToString(),
            dataHex = Convert.ToHexString(frame.GetData() ?? []),
            vendorSpecificGain = frame.VendorSpecificGain,
            timestampMicros = frame.Timestamp,
            triggeredAutoTransact = frame.TriggeredAutoTransact
        }).ToArray();

        Log("polling_frames", new
        {
            frames = items
        });
    }

    private static bool HasSelectedAid()
    {
        lock (Sync)
        {
            return !string.IsNullOrWhiteSpace(selectedAidHex);
        }
    }

    private static byte[] EncodePayloadResponse(string text, string eventType, object payload)
    {
        var bytes = Encoding.UTF8.GetBytes(text);
        return AppendStatus(bytes, 0x90, 0x00, eventType, payload);
    }

    private static bool IsGetData(byte[] apdu)
    {
        return apdu.Length >= 4
            && apdu[0] == 0x80
            && apdu[1] == 0xCA
            && apdu[2] == 0x00
            && apdu[3] == 0x00;
    }

    private static bool IsPutData(byte[] apdu)
    {
        return apdu.Length >= 5
            && apdu[0] == 0x80
            && apdu[1] == 0xDA
            && apdu[2] == 0x00
            && apdu[3] == 0x00;
    }

    private static bool IsEcho(byte[] apdu)
    {
        return apdu.Length >= 5
            && apdu[0] == 0x80
            && apdu[1] == 0xEE
            && apdu[2] == 0x00
            && apdu[3] == 0x00;
    }

    private static bool IsAsyncResponse(byte[] apdu)
    {
        return apdu.Length >= 5
            && apdu[0] == 0x80
            && apdu[1] == 0xE2
            && apdu[2] == 0x00
            && apdu[3] == 0x00;
    }

    private static byte[] ExtractLcPayload(byte[] apdu)
    {
        if (apdu.Length < 5)
        {
            return [];
        }

        var length = apdu[4];
        if (apdu.Length < 5 + length)
        {
            return [];
        }

        return apdu.Skip(5).Take(length).ToArray();
    }

    private static bool TryMatchSelectAid(byte[] apdu, out string matchedAidHex)
    {
        matchedAidHex = string.Empty;
        if (apdu.Length < 5
            || apdu[0] != 0x00
            || apdu[1] != 0xA4
            || apdu[2] != 0x04
            || apdu[3] != 0x00)
        {
            return false;
        }

        var aidLength = apdu[4];
        if (apdu.Length != 5 + aidLength)
        {
            return false;
        }

        matchedAidHex = Convert.ToHexString(apdu, 5, aidLength);
        lock (Sync)
        {
            return string.Equals(matchedAidHex, AidHex, StringComparison.OrdinalIgnoreCase)
                || dynamicAidHexValues.Contains(matchedAidHex);
        }
    }

    private static string NormalizeAid(string value)
    {
        var cleaned = new string(value.Where(Uri.IsHexDigit).ToArray());
        return cleaned.ToUpperInvariant();
    }

    private static byte[] AppendStatus(byte[] payload, byte sw1, byte sw2, string eventType, object payloadObject)
    {
        var combined = new byte[payload.Length + 2];
        payload.CopyTo(combined, 0);
        combined[^2] = sw1;
        combined[^1] = sw2;

        Log(eventType, new
        {
            statusWord = $"{sw1:X2}{sw2:X2}",
            responseHex = Convert.ToHexString(combined),
            payload = payloadObject
        });

        return combined;
    }

    private static byte[] StatusWord(byte sw1, byte sw2, string eventType, object payload)
    {
        var response = new[] { sw1, sw2 };
        Log(eventType, new
        {
            statusWord = $"{sw1:X2}{sw2:X2}",
            responseHex = Convert.ToHexString(response),
            payload
        });

        return response;
    }

    private static void Log(string eventType, object payload)
    {
        lock (Sync)
        {
            Append("event", eventType, payload);
        }

        RaiseChanged();
    }

    private static void Append(string stream, string eventType, object payload)
    {
        NfcJson.Append(entries, MaxEntries, $"hce.{stream}", eventType, payload);
    }

    private static string Trim(string value)
    {
        return value.Length <= 120 ? value : $"{value[..117]}...";
    }

    private static void RaiseChanged()
    {
        Changed?.Invoke(null, EventArgs.Empty);
    }
}
