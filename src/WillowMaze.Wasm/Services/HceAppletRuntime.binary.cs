using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace WillowMaze.Wasm.Services;

public static class HceAppletRuntime
{
    private const int MaxEntries = 80;
    private const string DefaultResponseText = "{\"service\":\"hce_apdu\",\"message\":\"willow_maze_ready\"}";
    private static readonly object Sync;
    private static readonly List<string> entries;
    private static readonly HashSet<string> dynamicAidHexValues;
    private static string responseText;
    private static string selectedAidHex;
    private const string AidHex = "F0770A11B1C2D3";
    private static EventHandler Changed;

    public event EventHandler? Changed;

    public string ResponseText { get; private set; }
    public IReadOnlyList<string> Entries { get; private set; }
    public string Jsonl { get; private set; }
    public IReadOnlyList<string> EffectiveAids { get; private set; }

    public static void UpdateResponseText(string value)
    {
        // Decompiled from IL
        // Method: UpdateResponseText IL size: 100 bytes
        // Strings: 3, Method calls: 6, Field refs: 3
        // String: "{"service":"hce_apdu","message":"willow_maze_ready"}"
        // String: "config"
        // String: "response_updated"
        // Calls: string.IsNullOrWhiteSpace
        // Calls: Monitor.Enter
        // Calls: HceAppletRuntime.Trim
        // Calls: new:<>f__AnonymousType0<string, string>..ctor
        // Calls: HceAppletRuntime.Append
        // Calls: HceAppletRuntime.RaiseChanged
        // Field: Sync
        // Field: responseText
        // Field: selectedAidHex
    }

    public static void SetDynamicAids(IEnumerable<string> aids)
    {
        // Decompiled from IL
        // Method: SetDynamicAids IL size: 201 bytes
        // Strings: 2, Method calls: 14, Field refs: 7
        // String: "config"
        // String: "dynamic_aids_updated"
        // Calls: Monitor.Enter
        // Calls: HashSet<string>.Clear
        // Calls: new:Func<string, string>..ctor
        // Calls: token:0x2B00001D
        // Calls: new:Func<string, bool>..ctor
        // Calls: token:0x2B00001E
        // Calls: IEnumerable<string>.GetEnumerator
        // Calls: IEnumerator<string>.get_Current
        // Calls: HashSet<string>.Add
        // Calls: IEnumerator.MoveNext
        // Calls: HceAppletRuntime.get_EffectiveAids
        // Calls: new:<>f__AnonymousType1<IReadOnlyList<string>>..ctor
        // Calls: HceAppletRuntime.Append
        // Calls: HceAppletRuntime.RaiseChanged
        // Field: Sync
        // Field: dynamicAidHexValues
        // Field: <>9__20_0
        // Field: <>9__20_1
    }

    public static byte[] ProcessCommandApdu(byte[] commandApdu, Action<byte[]> sendResponse)
    {
        // Decompiled from IL
        // Method: ProcessCommandApdu IL size: 594 bytes
        // Strings: 15, Method calls: 46, Field refs: 3
        // String: "apdu_error"
        // String: "malformed_apdu"
        // String: "command_apdu"
        // String: "SelectAid"
        // String: "select_ok"
        // String: "get_data_rejected"
        // String: "conditions_not_satisfied"
        // String: "GetData"
        // String: "get_data_ok"
        // String: "{"service":"hce_apdu","message":"willow_maze_ready"}"
        // String: "put_data_ok"
        // String: "echo_ok"
        // String: "async_response_sent"
        // String: "async_response_queued"
        // String: "unsupported_apdu"
        // Calls: new:<>f__AnonymousType2<string>..ctor
        // Calls: HceAppletRuntime.StatusWord
        // Calls: Convert.ToHexString
        // Calls: new:<>f__AnonymousType3<string>..ctor
        // Calls: HceAppletRuntime.Log
        // Calls: HceAppletRuntime.TryMatchSelectAid
        // Calls: Monitor.Enter
        // Calls: HceAppletRuntime.get_ResponseText
        // Calls: HceAppletRuntime.Trim
        // Calls: TapRelayClient.SendTap
        // Calls: new:<>f__AnonymousType4<string>..ctor
        // Calls: HceAppletRuntime.EncodePayloadResponse
        // Calls: HceAppletRuntime.IsGetData
        // Calls: HceAppletRuntime.IsPutData
        // Calls: Encoding.GetString
        // Calls: HceAppletRuntime.UpdateResponseText
        // Calls: new:<>f__AnonymousType5<string>..ctor
        // Calls: HceAppletRuntime.IsEcho
        // Calls: new:<>f__AnonymousType6<string>..ctor
        // Calls: HceAppletRuntime.AppendStatus
        // Calls: HceAppletRuntime.IsAsyncResponse
        // Calls: Encoding.get_UTF8
        // Calls: Encoding.GetBytes
        // Calls: Action<byte[]>.Invoke
        // Field: selectedAidHex
        return default!;
    }

    public static void LogDeactivated(DeactivationReason reason)
    {
        // Decompiled from IL
        // Method: LogDeactivated IL size: 31 bytes
        // Strings: 1, Method calls: 3, Field refs: 0
        // String: "deactivated"
        // Calls: object.ToString
        // Calls: new:<>f__AnonymousType2<string>..ctor
        // Calls: HceAppletRuntime.Log
    }

    public static void LogNfcInternalError(int errorCode)
    {
        // Decompiled from IL
        // Method: LogNfcInternalError IL size: 131 bytes
        // Strings: 6, Method calls: 7, Field refs: 0
        // String: "COMMAND_TIMEOUT"
        // String: "NFC_CRASH_RESTART"
        // String: "NFC_HARDWARE_ERROR"
        // String: "UNKNOWN ("
        // String: ")"
        // String: "nfc_internal_error"
        // Calls: DefaultInterpolatedStringHandler..ctor
        // Calls: DefaultInterpolatedStringHandler.AppendLiteral
        // Calls: token:0x2B000016
        // Calls: DefaultInterpolatedStringHandler.ToStringAndClear
        // Calls: new:<>f__AnonymousType7<int, string>..ctor
        // Calls: HceAppletRuntime.Log
    }

    public static void LogPollingFrames(IList<PollingFrame> frames)
    {
        // Decompiled from IL
        // Method: Logobjects IL size: 84 bytes
        // Strings: 1, Method calls: 5, Field refs: 2
        // String: "polling_frames"
        // Calls: new:Func<object, <>f__AnonymousType8<string, string, int, long, bool>>..ctor
        // Calls: token:0x2B00001F
        // Calls: token:0x2B000020
        // Calls: new:<>f__AnonymousType9<<>f__AnonymousType8<string, string, int, long, bool>[]>..ctor
        // Calls: HceAppletRuntime.Log
        // Field: <>9__24_0
    }

    private static bool HasSelectedAid()
    {
        // Decompiled from IL
        // Method: HasSelectedAid IL size: 48 bytes
        // Strings: 0, Method calls: 2, Field refs: 2
        // Calls: Monitor.Enter
        // Calls: string.IsNullOrWhiteSpace
        // Field: Sync
        // Field: selectedAidHex
        return false;
    }

    private static byte[] EncodePayloadResponse(string text, string eventType, object payload)
    {
        // Decompiled from IL
        // Method: EncodePayloadResponse IL size: 32 bytes
        // Strings: 0, Method calls: 3, Field refs: 0
        // Calls: Encoding.get_UTF8
        // Calls: Encoding.GetBytes
        // Calls: HceAppletRuntime.AppendStatus
        return default!;
    }

    private static bool IsGetData(byte[] apdu)
    {
        // Decompiled from IL
        // Method: IsGetData IL size: 46 bytes
        // Strings: 0, Method calls: 0, Field refs: 0
        return false;
    }

    private static bool IsPutData(byte[] apdu)
    {
        // Decompiled from IL
        // Method: IsPutData IL size: 46 bytes
        // Strings: 0, Method calls: 0, Field refs: 0
        return false;
    }

    private static bool IsEcho(byte[] apdu)
    {
        // Decompiled from IL
        // Method: IsEcho IL size: 46 bytes
        // Strings: 0, Method calls: 0, Field refs: 0
        return false;
    }

    private static bool IsAsyncResponse(byte[] apdu)
    {
        // Decompiled from IL
        // Method: IsAsyncResponse IL size: 46 bytes
        // Strings: 0, Method calls: 0, Field refs: 0
        return false;
    }

    private static byte[] ExtractLcPayload(byte[] apdu)
    {
        // Decompiled from IL
        // Method: ExtractLcPayload IL size: 68 bytes
        // Strings: 0, Method calls: 3, Field refs: 0
        // Calls: token:0x2B000021
        // Calls: token:0x2B000022
        // Calls: token:0x2B000023
        return default!;
    }

    private static bool TryMatchSelectAid(byte[] apdu, string& matchedAidHex)
    {
        // Decompiled from IL
        // Method: TryMatchSelectAid IL size: 156 bytes
        // Strings: 1, Method calls: 4, Field refs: 2
        // String: "F0770A11B1C2D3"
        // Calls: Convert.ToHexString
        // Calls: Monitor.Enter
        // Calls: string.Equals
        // Calls: HashSet<string>.Contains
        // Field: string.Empty
        // Field: Sync
        return false;
    }

    private static string NormalizeAid(string value)
    {
        // Decompiled from IL
        // Method: NormalizeAid IL size: 56 bytes
        // Strings: 0, Method calls: 5, Field refs: 2
        // Calls: new:Func<char, bool>..ctor
        // Calls: token:0x2B000024
        // Calls: token:0x2B000025
        // Calls: new:string..ctor
        // Calls: string.ToUpperInvariant
        // Field: <0>__IsHexDigit
        return string.Empty;
    }

    private static byte[] AppendStatus(byte[] payload, byte sw1, byte sw2, string eventType, object payloadObject)
    {
        // Decompiled from IL
        // Method: AppendStatus IL size: 107 bytes
        // Strings: 2, Method calls: 8, Field refs: 0
        // String: "X2"
        // String: "X2"
        // Calls: Array.CopyTo
        // Calls: DefaultInterpolatedStringHandler..ctor
        // Calls: token:0x2B000026
        // Calls: DefaultInterpolatedStringHandler.ToStringAndClear
        // Calls: Convert.ToHexString
        // Calls: new:<>f__AnonymousType10<string, string, object>..ctor
        // Calls: HceAppletRuntime.Log
        return default!;
    }

    private static byte[] StatusWord(byte sw1, byte sw2, string eventType, object payload)
    {
        // Decompiled from IL
        // Method: StatusWord IL size: 85 bytes
        // Strings: 2, Method calls: 7, Field refs: 0
        // String: "X2"
        // String: "X2"
        // Calls: DefaultInterpolatedStringHandler..ctor
        // Calls: token:0x2B000026
        // Calls: DefaultInterpolatedStringHandler.ToStringAndClear
        // Calls: Convert.ToHexString
        // Calls: new:<>f__AnonymousType10<string, string, object>..ctor
        // Calls: HceAppletRuntime.Log
        return default!;
    }

    private static void Log(string eventType, object payload)
    {
        // Decompiled from IL
        // Method: Log IL size: 53 bytes
        // Strings: 1, Method calls: 3, Field refs: 1
        // String: "event"
        // Calls: Monitor.Enter
        // Calls: HceAppletRuntime.Append
        // Calls: HceAppletRuntime.RaiseChanged
        // Field: Sync
    }

    private static void Append(string stream, string eventType, object payload)
    {
        // Decompiled from IL
        // Method: Append IL size: 28 bytes
        // Strings: 1, Method calls: 2, Field refs: 1
        // String: "hce."
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
        // Method: .cctor IL size: 46 bytes
        // Strings: 1, Method calls: 4, Field refs: 4
        // String: "{"service":"hce_apdu","message":"willow_maze_ready"}"
        // Calls: new:object..ctor
        // Calls: new:List<string>..ctor
        // Calls: StringComparer.get_OrdinalIgnoreCase
        // Calls: new:HashSet<string>..ctor
        // Field: Sync
        // Field: entries
        // Field: dynamicAidHexValues
        // Field: responseText
    }

}
