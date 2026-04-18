using System.Text;

namespace WillowMaze.Wasm.Services;

public static class HceFAppletRuntime
{
    private const int MaxEntries = 80;
    private const string DefaultResponseText = "{\"service\":\"hce_nfcf\",\"message\":\"willow_maze_ready\"}";
    private static readonly object Sync = new();
    private static readonly List<string> Entries = [];
    private static string ResponseTextValue = DefaultResponseText;

    public const string SystemCodeHex = "4000";
    public const string Nfcid2Hex = "02FE000000000000";
    public const string T3tPmmHex = "FFFFFFFFFFFFFFFF";

    public static event EventHandler? Changed;

    public static string ResponseText { get { lock (Sync) { return ResponseTextValue; } } }
    public static IReadOnlyList<string> EventEntries { get { lock (Sync) { return Entries.ToArray(); } } }
    public static string Jsonl { get { lock (Sync) { return NfcJson.Join(Entries); } } }

    public static void UpdateResponseText(string Value)
    {
        var Next = string.IsNullOrWhiteSpace(Value) ? DefaultResponseText : Value.Trim();
        lock (Sync)
        {
            ResponseTextValue = Next;
            AppendEntry("config", "response_updated", new { preview = Trim(Next) });
        }
        RaiseChanged();
    }

    public static void LogStatus(string Value) { lock (Sync) { AppendEntry("status", "state", new { message = Value }); } RaiseChanged(); }

    public static byte[]? ProcessPacket(byte[]? CommandPacket, Action<byte[]>? SendResponse = null)
    {
        if (CommandPacket is null || CommandPacket.Length < 2)
            return BuildFrame(0xFF, "packet_error", new { reason = "malformed_packet" });

        var CommandHex = Convert.ToHexString(CommandPacket);
        Log("command_packet", new { commandHex = CommandHex });

        var CommandCode = CommandPacket[1];
        if (CommandCode == 0xE2)
        {
            var Payload = ExtractPayload(CommandPacket);
            var Text = Payload.Length == 0 ? ResponseText : Encoding.UTF8.GetString(Payload);
            SendResponse?.Invoke(BuildFrame(0xE3, "async_response_sent", new { payloadPreview = Trim(Text) }, Text));
            Log("async_response_queued", new { payloadPreview = Trim(Text) });
            return null;
        }

        if (CommandCode == 0xDA)
        {
            var Payload = ExtractPayload(CommandPacket);
            var Text = Payload.Length == 0 ? DefaultResponseText : Encoding.UTF8.GetString(Payload);
            UpdateResponseText(Text);
            return BuildFrame(0xDB, "write_response_ok", new { payloadPreview = Trim(Text) }, string.Empty);
        }

        if (CommandCode == 0xCA)
            return BuildFrame(0xCB, "read_response_ok", new { payloadPreview = Trim(ResponseText) }, ResponseText);

        if (CommandCode == 0xEE)
        {
            var Payload = ExtractPayload(CommandPacket);
            var Text = Payload.Length == 0 ? string.Empty : Encoding.UTF8.GetString(Payload);
            return BuildFrame(0xEF, "echo_ok", new { payloadPreview = Trim(Text) }, Text);
        }

        var ResponseCode = unchecked((byte)(CommandCode + 1));
        return BuildFrame(ResponseCode, "packet_reply", new { commandCode = $"0x{CommandCode:X2}", payloadPreview = Trim(ResponseText) }, ResponseText);
    }

    public static void LogDeactivated(string Reason) => Log("deactivated", new { reason = Reason });

    private static byte[] ExtractPayload(byte[] Packet) => Packet.Length <= 10 ? [] : Packet.Skip(10).ToArray();

    private static byte[] BuildFrame(byte ResponseCode, string EventType, object Payload, string? ResponseOverride = null)
    {
        var Nfcid2Bytes = Convert.FromHexString(Nfcid2Hex);
        var ResponseBytes = Encoding.UTF8.GetBytes(ResponseOverride ?? ResponseText);
        var PayloadLength = Math.Min(ResponseBytes.Length, 244 - Nfcid2Bytes.Length);
        var Frame = new byte[2 + Nfcid2Bytes.Length + PayloadLength];
        Frame[1] = ResponseCode;
        Buffer.BlockCopy(Nfcid2Bytes, 0, Frame, 2, Nfcid2Bytes.Length);
        Buffer.BlockCopy(ResponseBytes, 0, Frame, 2 + Nfcid2Bytes.Length, PayloadLength);
        Frame[0] = (byte)Frame.Length;
        Log(EventType, new { responseCode = $"0x{ResponseCode:X2}", responseHex = Convert.ToHexString(Frame), payload = Payload });
        return Frame;
    }

    private static void Log(string EventType, object Payload) { lock (Sync) { AppendEntry("event", EventType, Payload); } RaiseChanged(); }
    private static void AppendEntry(string Stream, string EventType, object Payload) => NfcJson.Append(Entries, MaxEntries, $"hcef.{Stream}", EventType, Payload);
    private static string Trim(string Value) => Value.Length <= 120 ? Value : $"{Value[..117]}...";
    private static void RaiseChanged() => Changed?.Invoke(null, EventArgs.Empty);
}
