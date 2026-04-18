using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace WillowMaze.Wasm.Decompiled;

public static class EmvCardReader
{
    private static readonly byte[] SelectPpse;
    private static readonly byte[] SelectPse;
    public static EmvCardData ReadCard(Tag tag)
    {
        // Decompiled from IL
        // Method: ReadCard IL size: 1339 bytes
        // Strings: 19, Method calls: 95, Field refs: 4
        // String: "No IsoDep tech available"
        // String: "Connected. MaxTransceiveLength="
        // String: "SELECT PPSE"
        // String: "SELECT PSE"
        // String: "No AIDs from PPSE, trying well-known AIDs"
        // String: "Trying AID: "
        // String: "SELECT AID "
        // String: "AID "
        // String: " not supported"
        // String: "AID selected: "
        // String: " ("
        // String: ")"
        // String: "GET PROCESSING OPTIONS"
        // String: "READ RECORD SFI="
        // String: " REC="
        // String: "BRUTE READ SFI="
        // String: " REC="
        // String: "Could not extract PAN from any AID"
        // String: "Exception: "
        // Calls: new:EmvCardData..ctor
        // Calls: IsoDep.Get
        // Calls: EmvCardData.get_Log
        // Calls: List<string>.Add
        // Calls: BasicTagTechnology.Connect
        // Calls: IsoDep.set_Timeout
        // Calls: new:DefaultInterpolatedStringHandler..ctor
        // Calls: DefaultInterpolatedStringHandler.AppendLiteral
        // Calls: IsoDep.get_MaxTransceiveLength
        // Calls: token:0x2B000016
        // Calls: DefaultInterpolatedStringHandler.ToStringAndClear
        // Calls: EmvCardReader.Transceive
        // Calls: EmvCardReader.IsSuccess
        // Calls: EmvCardData.set_PpseResponseHex
        // Calls: EmvCardReader.ParseAidsFromPpse
        // Calls: List<string>.get_Count
        // Calls: List<string>.AddRange
        // Calls: List<string>.GetEnumerator
        // Calls: Enumerator<string>.get_Current
        // Calls: string.Concat
        // Calls: EmvCardReader.BuildSelectApdu
        // Calls: EmvCardData.set_AidHex
        // Calls: EmvCardReader.ParseAidLabel
        // Calls: EmvCardData.set_AidLabel
        // Calls: EmvCardReader.DetectBrand
        // Calls: EmvCardData.set_CardBrand
        // Calls: DefaultInterpolatedStringHandler.AppendFormatted
        // Calls: EmvCardData.get_CardBrand
        // Calls: EmvCardReader.ParsePdol
        // Calls: EmvCardReader.BuildGpoCommand
        // Calls: EmvCardData.set_GpoResponseHex
        // Calls: EmvCardReader.ParseAfl
        // Calls: List<ValueTuple<int, int, int>>.GetEnumerator
        // Calls: Enumerator<ValueTuple<int, int, int>>.get_Current
        // Calls: Convert.ToHexString
        // Calls: EmvCardReader.ExtractCardData
        // Calls: Enumerator<ValueTuple<int, int, int>>.MoveNext
        // Calls: IDisposable.Dispose
        // Calls: EmvCardData.get_Pan
        // Calls: string.IsNullOrEmpty
        // Calls: token:0x043A2811
        // Calls: EmvCardData.set_Success
        // Calls: Enumerator<string>.MoveNext
        // Calls: BasicTagTechnology.Close
        // Field: SelectPpse
        // Field: ValueTuple<int, int, int>.Item1
        // Field: ValueTuple<int, int, int>.Item2
        // Field: ValueTuple<int, int, int>.Item3
        return default!;
    }

    private static byte[] Transceive(IsoDep P0, byte[] isoDep, EmvCardData command, string data)
    {
        // Decompiled from IL
        // Method: Transceive IL size: 139 bytes
        // Strings: 6, Method calls: 12, Field refs: 0
        // String: ">> "
        // String: ": "
        // String: "<< "
        // String: ": "
        // String: "!! "
        // String: ": "
        // Calls: Convert.ToHexString
        // Calls: EmvCardData.get_Log
        // Calls: string.Concat
        // Calls: List<string>.Add
        // Calls: IsoDep.Transceive
        // Calls: Exception.get_Message
        return default!;
    }

    private static bool IsSuccess(byte[] response)
    {
        // Decompiled from IL
        // Method: IsSuccess IL size: 53 bytes
        // Strings: 0, Method calls: 0, Field refs: 0
        return false;
    }

    private static byte[] BuildSelectApdu(string aidHex)
    {
        // Decompiled from IL
        // Method: BuildSelectApdu IL size: 75 bytes
        // Strings: 0, Method calls: 2, Field refs: 0
        // Calls: Convert.FromHexString
        // Calls: Buffer.BlockCopy
        return default!;
    }

    private static List<string> ParseAidsFromPpse(byte[] response, EmvCardData data)
    {
        // Decompiled from IL
        // Method: ParseAidsFromPpse IL size: 264 bytes
        // Strings: 2, Method calls: 14, Field refs: 0
        // String: "PPSE AID found: "
        // String: "4F"
        // Calls: new:List<string>..ctor
        // Calls: Convert.ToHexString
        // Calls: string.get_Length
        // Calls: string.Substring
        // Calls: int.TryParse
        // Calls: List<string>.Contains
        // Calls: List<string>.Add
        // Calls: EmvCardData.get_Log
        // Calls: string.Concat
        // Calls: string.IndexOf
        return default!;
    }

    private static string ParseAidLabel(byte[] response)
    {
        // Decompiled from IL
        // Method: ParseAidLabel IL size: 163 bytes
        // Strings: 1, Method calls: 10, Field refs: 0
        // String: "50"
        // Calls: Convert.ToHexString
        // Calls: string.IndexOf
        // Calls: string.get_Length
        // Calls: string.Substring
        // Calls: int.TryParse
        // Calls: Encoding.get_ASCII
        // Calls: Convert.FromHexString
        // Calls: Encoding.GetString
        return string.Empty;
    }

    private static byte[] ParsePdol(byte[] response)
    {
        // Decompiled from IL
        // Method: ParsePdol IL size: 161 bytes
        // Strings: 1, Method calls: 8, Field refs: 0
        // String: "9F38"
        // Calls: Convert.ToHexString
        // Calls: string.IndexOf
        // Calls: string.get_Length
        // Calls: string.Substring
        // Calls: int.TryParse
        // Calls: Convert.FromHexString
        return default!;
    }

    private static byte[] BuildGpoCommand(byte[] pdol)
    {
        // Decompiled from IL
        // Method: BuildGpoCommand IL size: 217 bytes
        // Strings: 0, Method calls: 2, Field refs: 0
        // Calls: RuntimeHelpers.InitializeArray
        // Calls: Buffer.BlockCopy
        return default!;
    }

    private static List<ValueTuple<int, int, int>> ParseAfl(byte[] P0, EmvCardData response)
    {
        // Decompiled from IL
        // Method: ParseAfl IL size: 263 bytes
        // Strings: 1, Method calls: 10, Field refs: 0
        // String: "77"
        // Calls: new:List<ValueTuple<int, int, int>>..ctor
        // Calls: Convert.ToHexString
        // Calls: string.Contains
        // Calls: string.Substring
        // Calls: int.TryParse
        // Calls: Convert.FromHexString
        // Calls: EmvCardReader.ParseAflBytes
        // Calls: Buffer.BlockCopy
        return default!;
    }

    private static void ParseAflBytes(byte[] aflBytes, List<ValueTuple<int, int, int>> afls, EmvCardData data)
    {
        // Decompiled from IL
        // Method: ParseAflBytes IL size: 189 bytes
        // Strings: 3, Method calls: 12, Field refs: 0
        // String: "AFL: SFI="
        // String: " records "
        // String: "-"
        // Calls: new:ValueTuple<int, int, int>..ctor
        // Calls: List<ValueTuple<int, int, int>>.Add
        // Calls: EmvCardData.get_Log
        // Calls: DefaultInterpolatedStringHandler..ctor
        // Calls: DefaultInterpolatedStringHandler.AppendLiteral
        // Calls: token:0x2B000016
        // Calls: token:0x2B000018
        // Calls: DefaultInterpolatedStringHandler.ToStringAndClear
        // Calls: List<string>.Add
    }

    private static void ExtractCardData(byte[] response, EmvCardData data)
    {
        // Decompiled from IL
        // Method: ExtractCardData IL size: 650 bytes
        // Strings: 7, Method calls: 62, Field refs: 1
        // String: "5A"
        // String: "PAN found (tag 5A): "
        // String: "57"
        // String: "PAN from Track2 (tag 57): "
        // String: " exp="
        // String: "Expiry (tag 5F24): "
        // String: "Cardholder (tag 5F20): "
        // Calls: Convert.ToHexString
        // Calls: EmvCardData.get_Pan
        // Calls: string.IsNullOrEmpty
        // Calls: EmvCardReader.FindTag
        // Calls: string.TrimEnd
        // Calls: EmvCardData.set_Pan
        // Calls: EmvCardReader.MaskPan
        // Calls: EmvCardData.set_MaskedPan
        // Calls: string.get_Length
        // Calls: string.Substring
        // Calls: EmvCardData.set_Last4
        // Calls: EmvCardData.get_Log
        // Calls: EmvCardData.get_MaskedPan
        // Calls: string.Concat
        // Calls: List<string>.Add
        // Calls: string.IndexOf
        // Calls: Math.Min
        // Calls: EmvCardData.set_Expiry
        // Calls: EmvCardData.get_Expiry
        // Calls: EmvCardData.get_CardholderName
        // Calls: Convert.FromHexString
        // Calls: Encoding.GetString
        // Calls: string.Trim
        // Calls: EmvCardData.set_CardholderName
        // Field: token:0x110A0002
    }

    private static string FindTag(string P0, string hex)
    {
        // Decompiled from IL
        // Method: FindTag IL size: 136 bytes
        // Strings: 0, Method calls: 7, Field refs: 0
        // Calls: string.IndexOf
        // Calls: string.get_Length
        // Calls: string.Substring
        // Calls: int.TryParse
        return string.Empty;
    }

    private static string MaskPan(string pan)
    {
        // Decompiled from IL
        // Method: MaskPan IL size: 106 bytes
        // Strings: 0, Method calls: 9, Field refs: 0
        // Calls: string.get_Length
        // Calls: string.Substring
        // Calls: string.Concat
        // Calls: new:string..ctor
        return string.Empty;
    }

    private static string DetectBrand(string aid)
    {
        // Decompiled from IL
        // Method: DetectBrand IL size: 190 bytes
        // Strings: 7, Method calls: 7, Field refs: 0
        // String: "A000000003"
        // String: "A000000004"
        // String: "A000000025"
        // String: "A000000065"
        // String: "A000000001"
        // String: "A000000152"
        // String: "Unknown"
        // Calls: string.ToUpperInvariant
        // Calls: string.StartsWith
        return string.Empty;
    }

    private static List<string> WellKnownAids()
    {
        // Decompiled from IL
        // Method: WellKnownAids IL size: 136 bytes
        // Strings: 8, Method calls: 11, Field refs: 0
        // String: "A0000000031010"
        // String: "A0000000032010"
        // String: "A0000000041010"
        // String: "A0000000042010"
        // String: "A00000002501"
        // String: "A0000000651010"
        // String: "A0000001523010"
        // String: "A0000000043060"
        // Calls: new:List<string>..ctor
        // Calls: token:0x2B000019
        // Calls: token:0x2B00001A
        // Calls: Span<string>.get_Item
        return default!;
    }

    private static void .cctor()
    {
        // Decompiled from IL
        // Method: .cctor IL size: 31 bytes
        // Strings: 2, Method calls: 2, Field refs: 2
        // String: "325041592E5359532E4444463031"
        // String: "315041592E5359532E4444463031"
        // Calls: EmvCardReader.BuildSelectApdu
        // Field: SelectPpse
        // Field: SelectPse
    }

}
