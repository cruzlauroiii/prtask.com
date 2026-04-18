using System.Text;

namespace WillowMaze.Wasm.Services;

public static class HceAppletRuntime
{
    private const int MaxEntries = 80;
    private const string DefaultResponseText = "{\"service\":\"hce_apdu\",\"message\":\"willow_maze_ready\"}";
    private static readonly object Sync = new();
    private static readonly List<string> Entries = [];
    private static readonly HashSet<string> DynamicAidHexValues = new(StringComparer.OrdinalIgnoreCase);
    private static string ResponseTextValue = DefaultResponseText;
    private static string? SelectedAidHex;

    public const string AidHex = "F0770A11B1C2D3";
    public static event EventHandler? Changed;

    public static string ResponseText
    {
        get { lock (Sync) { return ResponseTextValue; } }
    }

    public static IReadOnlyList<string> EventEntries
    {
        get { lock (Sync) { return Entries.ToArray(); } }
    }

    public static string Jsonl
    {
        get { lock (Sync) { return NfcJson.Join(Entries); } }
    }

    public static IReadOnlyList<string> EffectiveAids
    {
        get { lock (Sync) { return [AidHex, .. DynamicAidHexValues.OrderBy(static V => V, StringComparer.OrdinalIgnoreCase)]; } }
    }

    public static void UpdateResponseText(string Value)
    {
        var Next = string.IsNullOrWhiteSpace(Value) ? DefaultResponseText : Value.Trim();
        lock (Sync)
        {
            ResponseTextValue = Next;
            AppendEntry("config", "response_updated", new { selectedAidHex = SelectedAidHex, preview = Trim(Next) });
        }
        RaiseChanged();
    }

    public static void SetDynamicAids(IEnumerable<string> Aids)
    {
        lock (Sync)
        {
            DynamicAidHexValues.Clear();
            foreach (var Aid in Aids.Select(static V => NormalizeAid(V)).Where(static V => !string.IsNullOrWhiteSpace(V)))
            {
                DynamicAidHexValues.Add(Aid);
            }
            AppendEntry("config", "dynamic_aids_updated", new { aids = EffectiveAids });
        }
        RaiseChanged();
    }

    public static byte[]? ProcessCommandApdu(byte[]? CommandApdu, Action<byte[]>? SendResponse = null)
    {
        if (CommandApdu is null || CommandApdu.Length < 4)
            return StatusWord(0x67, 0x00, "apdu_error", new { reason = "malformed_apdu" });

        var CommandHex = Convert.ToHexString(CommandApdu);
        Log("command_apdu", new { commandHex = CommandHex });

        if (TryMatchSelectAid(CommandApdu, out var MatchedAidHex))
        {
            lock (Sync) { SelectedAidHex = MatchedAidHex; }
            return EncodePayloadResponse(ResponseText, "select_ok", new { aidHex = MatchedAidHex });
        }

        if (IsGetData(CommandApdu))
        {
            if (!HasSelectedAid())
                return StatusWord(0x69, 0x85, "get_data_rejected", new { reason = "conditions_not_satisfied" });
            return EncodePayloadResponse(ResponseText, "get_data_ok", new { aidHex = SelectedAidHex });
        }

        if (IsPutData(CommandApdu))
        {
            var Payload = ExtractLcPayload(CommandApdu);
            var Text = Payload.Length == 0 ? DefaultResponseText : Encoding.UTF8.GetString(Payload);
            UpdateResponseText(Text);
            return StatusWord(0x90, 0x00, "put_data_ok", new { payloadPreview = Trim(Text) });
        }

        if (IsEcho(CommandApdu))
        {
            var Payload = ExtractLcPayload(CommandApdu);
            return AppendStatus(Payload, 0x90, 0x00, "echo_ok", new { responseHex = Convert.ToHexString(Payload) });
        }

        if (IsAsyncResponse(CommandApdu))
        {
            var Payload = ExtractLcPayload(CommandApdu);
            var Text = Payload.Length == 0 ? ResponseText : Encoding.UTF8.GetString(Payload);
            SendResponse?.Invoke(AppendStatus(Encoding.UTF8.GetBytes(Text), 0x90, 0x00, "async_response_sent", new { payloadPreview = Trim(Text) }));
            Log("async_response_queued", new { payloadPreview = Trim(Text) });
            return null;
        }

        return StatusWord(0x6D, 0x00, "unsupported_apdu", new { commandHex = CommandHex });
    }

    public static void LogDeactivated(string Reason) => Log("deactivated", new { reason = Reason });

    private static bool HasSelectedAid() { lock (Sync) { return !string.IsNullOrWhiteSpace(SelectedAidHex); } }

    private static byte[] EncodePayloadResponse(string Text, string EventType, object Payload)
    {
        var Bytes = Encoding.UTF8.GetBytes(Text);
        return AppendStatus(Bytes, 0x90, 0x00, EventType, Payload);
    }

    private static bool IsGetData(byte[] Apdu) => Apdu.Length >= 4 && Apdu[0] == 0x80 && Apdu[1] == 0xCA && Apdu[2] == 0x00 && Apdu[3] == 0x00;
    private static bool IsPutData(byte[] Apdu) => Apdu.Length >= 5 && Apdu[0] == 0x80 && Apdu[1] == 0xDA && Apdu[2] == 0x00 && Apdu[3] == 0x00;
    private static bool IsEcho(byte[] Apdu) => Apdu.Length >= 5 && Apdu[0] == 0x80 && Apdu[1] == 0xEE && Apdu[2] == 0x00 && Apdu[3] == 0x00;
    private static bool IsAsyncResponse(byte[] Apdu) => Apdu.Length >= 5 && Apdu[0] == 0x80 && Apdu[1] == 0xE2 && Apdu[2] == 0x00 && Apdu[3] == 0x00;

    private static byte[] ExtractLcPayload(byte[] Apdu)
    {
        if (Apdu.Length < 5) return [];
        var Length = Apdu[4];
        if (Apdu.Length < 5 + Length) return [];
        return Apdu.Skip(5).Take(Length).ToArray();
    }

    private static bool TryMatchSelectAid(byte[] Apdu, out string MatchedAidHex)
    {
        MatchedAidHex = string.Empty;
        if (Apdu.Length < 5 || Apdu[0] != 0x00 || Apdu[1] != 0xA4 || Apdu[2] != 0x04 || Apdu[3] != 0x00) return false;
        var AidLength = Apdu[4];
        if (Apdu.Length != 5 + AidLength) return false;
        MatchedAidHex = Convert.ToHexString(Apdu, 5, AidLength);
        lock (Sync) { return string.Equals(MatchedAidHex, AidHex, StringComparison.OrdinalIgnoreCase) || DynamicAidHexValues.Contains(MatchedAidHex); }
    }

    private static string NormalizeAid(string Value) => new string(Value.Where(Uri.IsHexDigit).ToArray()).ToUpperInvariant();

    private static byte[] AppendStatus(byte[] Payload, byte Sw1, byte Sw2, string EventType, object PayloadObject)
    {
        var Combined = new byte[Payload.Length + 2];
        Payload.CopyTo(Combined, 0);
        Combined[^2] = Sw1;
        Combined[^1] = Sw2;
        Log(EventType, new { statusWord = $"{Sw1:X2}{Sw2:X2}", responseHex = Convert.ToHexString(Combined), payload = PayloadObject });
        return Combined;
    }

    private static byte[] StatusWord(byte Sw1, byte Sw2, string EventType, object Payload)
    {
        var Response = new[] { Sw1, Sw2 };
        Log(EventType, new { statusWord = $"{Sw1:X2}{Sw2:X2}", responseHex = Convert.ToHexString(Response), payload = Payload });
        return Response;
    }

    private static void Log(string EventType, object Payload) { lock (Sync) { AppendEntry("event", EventType, Payload); } RaiseChanged(); }
    private static void AppendEntry(string Stream, string EventType, object Payload) => NfcJson.Append(Entries, MaxEntries, $"hce.{Stream}", EventType, Payload);
    private static string Trim(string Value) => Value.Length <= 120 ? Value : $"{Value[..117]}...";
    private static void RaiseChanged() => Changed?.Invoke(null, EventArgs.Empty);
}
