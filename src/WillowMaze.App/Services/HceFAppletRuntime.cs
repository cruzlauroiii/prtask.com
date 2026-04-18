using System.Text;
using Android.Nfc.CardEmulators;

namespace WillowMaze.App.Services;

internal static class HceFAppletRuntime
{
    private const int MaxEntries = 80;
    private const string DefaultResponseText = "{\"service\":\"hce_nfcf\",\"message\":\"willow_maze_ready\"}";
    private static readonly object Sync = new();
    private static readonly List<string> entries = [];
    private static string responseText = DefaultResponseText;

    public const string SystemCodeHex = "4000";
    public const string Nfcid2Hex = "02FE000000000000";
    public const string T3tPmmHex = "FFFFFFFFFFFFFFFF";

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

    public static void UpdateResponseText(string value)
    {
        var next = string.IsNullOrWhiteSpace(value) ? DefaultResponseText : value.Trim();
        lock (Sync)
        {
            responseText = next;
            Append("config", "response_updated", new
            {
                preview = Trim(next)
            });
        }

        RaiseChanged();
    }

    public static void LogStatus(string value)
    {
        lock (Sync)
        {
            Append("status", "state", new
            {
                message = value
            });
        }

        RaiseChanged();
    }

    public static byte[]? ProcessPacket(byte[]? commandPacket, Action<byte[]>? sendResponse = null)
    {
        if (commandPacket is null || commandPacket.Length < 2)
        {
            return BuildFrame(0xFF, "packet_error", new
            {
                reason = "malformed_packet"
            });
        }

        var commandHex = Convert.ToHexString(commandPacket);
        Log("command_packet", new
        {
            commandHex
        });

        var commandCode = commandPacket[1];
        if (commandCode == 0xE2)
        {
            var payload = ExtractPayload(commandPacket);
            var text = payload.Length == 0 ? ResponseText : Encoding.UTF8.GetString(payload);
            sendResponse?.Invoke(BuildFrame(0xE3, "async_response_sent", new
            {
                payloadPreview = Trim(text)
            }, text));

            Log("async_response_queued", new
            {
                payloadPreview = Trim(text)
            });

            return null;
        }

        if (commandCode == 0xDA)
        {
            var payload = ExtractPayload(commandPacket);
            var text = payload.Length == 0 ? DefaultResponseText : Encoding.UTF8.GetString(payload);
            UpdateResponseText(text);
            return BuildFrame(0xDB, "write_response_ok", new
            {
                payloadPreview = Trim(text)
            }, string.Empty);
        }

        if (commandCode == 0xCA)
        {
            return BuildFrame(0xCB, "read_response_ok", new
            {
                payloadPreview = Trim(ResponseText)
            }, ResponseText);
        }

        if (commandCode == 0xEE)
        {
            var payload = ExtractPayload(commandPacket);
            var text = payload.Length == 0 ? string.Empty : Encoding.UTF8.GetString(payload);
            return BuildFrame(0xEF, "echo_ok", new
            {
                payloadPreview = Trim(text)
            }, text);
        }

        var responseCode = unchecked((byte)(commandCode + 1));
        return BuildFrame(responseCode, "packet_reply", new
        {
            commandCode = $"0x{commandCode:X2}",
            payloadPreview = Trim(ResponseText)
        }, ResponseText);
    }

    public static void LogDeactivated(DeactivationReasonF reason)
    {
        Log("deactivated", new
        {
            reason = reason.ToString()
        });
    }

    private static byte[] ExtractPayload(byte[] packet)
    {
        if (packet.Length <= 10)
        {
            return [];
        }

        return packet.Skip(10).ToArray();
    }

    private static byte[] BuildFrame(byte responseCode, string eventType, object payload, string? responseOverride = null)
    {
        var nfcid2Bytes = Convert.FromHexString(Nfcid2Hex);
        var responseBytes = Encoding.UTF8.GetBytes(responseOverride ?? ResponseText);
        var payloadLength = Math.Min(responseBytes.Length, 244 - nfcid2Bytes.Length);

        var frame = new byte[2 + nfcid2Bytes.Length + payloadLength];
        frame[1] = responseCode;
        Buffer.BlockCopy(nfcid2Bytes, 0, frame, 2, nfcid2Bytes.Length);
        Buffer.BlockCopy(responseBytes, 0, frame, 2 + nfcid2Bytes.Length, payloadLength);
        frame[0] = (byte)frame.Length;

        Log(eventType, new
        {
            responseCode = $"0x{responseCode:X2}",
            responseHex = Convert.ToHexString(frame),
            payload
        });

        return frame;
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
        NfcJson.Append(entries, MaxEntries, $"hcef.{stream}", eventType, payload);
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
