using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace WillowMaze.Wasm.Services;

public static class HceFAppletRuntime
{
    private const int MaxEntries = 80;
    private const string DefaultResponseText = "{\"service\":\"hce_nfcf\",\"message\":\"willow_maze_ready\"}";
    private static readonly object Sync;
    private static readonly List<string> entries;
    private static string responseText;
    private const string SystemCodeHex = "4000";
    private const string Nfcid2Hex = "02FE000000000000";
    private const string T3tPmmHex = "FFFFFFFFFFFFFFFF";
    private static EventHandler Changed;

    public event EventHandler? Changed;

    public string ResponseText { get; private set; }
    public IReadOnlyList<string> Entries { get; private set; }
    public string Jsonl { get; private set; }

    public static void UpdateResponseText(string value)
    {
        // Decompiled from IL
        // Method: UpdateResponseText IL size: 95 bytes
        // Strings: 3, Method calls: 6, Field refs: 2
        // String: "{"service":"hce_nfcf","message":"willow_maze_ready"}"
        // String: "config"
        // String: "response_updated"
        // Calls: string.IsNullOrWhiteSpace
        // Calls: Monitor.Enter
        // Calls: HceFAppletRuntime.Trim
        // Calls: new:<>f__AnonymousType11<string>..ctor
        // Calls: HceFAppletRuntime.Append
        // Calls: HceFAppletRuntime.RaiseChanged
        // Field: Sync
        // Field: responseText
    }

    public static void LogStatus(string value)
    {
        // Decompiled from IL
        // Method: LogStatus IL size: 62 bytes
        // Strings: 2, Method calls: 4, Field refs: 1
        // String: "status"
        // String: "state"
        // Calls: Monitor.Enter
        // Calls: new:<>f__AnonymousType12<string>..ctor
        // Calls: HceFAppletRuntime.Append
        // Calls: HceFAppletRuntime.RaiseChanged
        // Field: Sync
    }

    public static byte[] ProcessPacket(byte[] commandPacket, Action<byte[]> sendResponse)
    {
        // Decompiled from IL
        // Method: ProcessPacket IL size: 521 bytes
        // Strings: 12, Method calls: 37, Field refs: 2
        // String: "packet_error"
        // String: "malformed_packet"
        // String: "command_packet"
        // String: "async_response_sent"
        // String: "async_response_queued"
        // String: "{"service":"hce_nfcf","message":"willow_maze_ready"}"
        // String: "write_response_ok"
        // String: "read_response_ok"
        // String: "echo_ok"
        // String: "packet_reply"
        // String: "0x"
        // String: "X2"
        // Calls: new:<>f__AnonymousType2<string>..ctor
        // Calls: HceFAppletRuntime.BuildFrame
        // Calls: Convert.ToHexString
        // Calls: new:<>f__AnonymousType3<string>..ctor
        // Calls: HceFAppletRuntime.Log
        // Calls: Encoding.GetString
        // Calls: HceFAppletRuntime.get_ResponseText
        // Calls: HceFAppletRuntime.Trim
        // Calls: new:<>f__AnonymousType5<string>..ctor
        // Calls: Action<byte[]>.Invoke
        // Calls: HceFAppletRuntime.UpdateResponseText
        // Calls: DefaultInterpolatedStringHandler..ctor
        // Calls: DefaultInterpolatedStringHandler.AppendLiteral
        // Calls: token:0x2B000026
        // Calls: DefaultInterpolatedStringHandler.ToStringAndClear
        // Calls: new:<>f__AnonymousType13<string, string>..ctor
        // Field: string.Empty
        return default!;
    }

    public static void LogDeactivated(DeactivationReasonF reason)
    {
        // Decompiled from IL
        // Method: LogDeactivated IL size: 31 bytes
        // Strings: 1, Method calls: 3, Field refs: 0
        // String: "deactivated"
        // Calls: object.ToString
        // Calls: new:<>f__AnonymousType2<string>..ctor
        // Calls: HceFAppletRuntime.Log
    }

    private static byte[] ExtractPayload(byte[] packet)
    {
        // Decompiled from IL
        // Method: ExtractPayload IL size: 42 bytes
        // Strings: 0, Method calls: 2, Field refs: 0
        // Calls: token:0x2B000021
        // Calls: token:0x2B000023
        return default!;
    }

    private static byte[] BuildFrame(byte responseCode, string eventType, object payload, string responseOverride)
    {
        // Decompiled from IL
        // Method: BuildFrame IL size: 173 bytes
        // Strings: 3, Method calls: 13, Field refs: 0
        // String: "02FE000000000000"
        // String: "0x"
        // String: "X2"
        // Calls: Convert.FromHexString
        // Calls: Encoding.get_UTF8
        // Calls: Encoding.GetBytes
        // Calls: Math.Min
        // Calls: Buffer.BlockCopy
        // Calls: DefaultInterpolatedStringHandler..ctor
        // Calls: DefaultInterpolatedStringHandler.AppendLiteral
        // Calls: token:0x2B000026
        // Calls: DefaultInterpolatedStringHandler.ToStringAndClear
        // Calls: Convert.ToHexString
        // Calls: new:<>f__AnonymousType14<string, string, object>..ctor
        // Calls: HceFAppletRuntime.Log
        return default!;
    }

    private static void Log(string eventType, object payload)
    {
        // Decompiled from IL
        // Method: Log IL size: 53 bytes
        // Strings: 1, Method calls: 3, Field refs: 1
        // String: "event"
        // Calls: Monitor.Enter
        // Calls: HceFAppletRuntime.Append
        // Calls: HceFAppletRuntime.RaiseChanged
        // Field: Sync
    }

    private static void Append(string stream, string eventType, object payload)
    {
        // Decompiled from IL
        // Method: Append IL size: 28 bytes
        // Strings: 1, Method calls: 2, Field refs: 1
        // String: "hcef."
        // Calls: string.Concat
        // Calls: NfcJson.Append
        // Field: entries
    }

    private static string Trim(string value)
    {
        // Decompiled from IL
        // Method: Trim IL size: 38 bytes
        // Strings: 1, Method calls: 2, Field refs: 0
        // String: "..."
        // Calls: string.get_Length
        // Calls: string.Concat
        return string.Empty;
    }

    private static void RaiseChanged()
    {
        // Decompiled from IL
        // Method: RaiseChanged IL size: 25 bytes
        // Strings: 0, Method calls: 1, Field refs: 2
        // Calls: EventHandler.Invoke
        // Field: Changed
        // Field: EventArgs.Empty
    }

    private static void .cctor()
    {
        // Decompiled from IL
        // Method: .cctor IL size: 31 bytes
        // Strings: 1, Method calls: 2, Field refs: 3
        // String: "{"service":"hce_nfcf","message":"willow_maze_ready"}"
        // Calls: new:object..ctor
        // Calls: new:List<string>..ctor
        // Field: Sync
        // Field: entries
        // Field: responseText
    }

}
