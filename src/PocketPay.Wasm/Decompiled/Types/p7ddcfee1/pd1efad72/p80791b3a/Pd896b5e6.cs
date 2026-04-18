namespace WillowMaze.Wasm.Decompiled;

public class Pd896b5e6
{
    private static p58efa9e8 F0fabe32b;
    private static p58efa9e8 F2c91b8ee;
    private static p58efa9e8 F2fffa53e;
    private static p58efa9e8 F49f23385;
    private static p58efa9e8 Fa7db9981;
    private static p58efa9e8 Fadf2eb38;
    private static p58efa9e8 Fcc9d7e04;
    private static p58efa9e8 Fdefdf563;

    public static bool HasBody(pd64ed3e9 P0)
    {
        // str: "response"
        // call: Intrinsics.checkNotNullParameter
        // call: pd896b5e6.promisesBody
        return false;
    }

    public static List<object> ParseChallenges(p883d7615 P0, string P1)
    {
        // str: "Unable to parse challenge"
        // str: "<this>"
        // str: "headerName"
        // call: p419f3742.log
        // call: StringsKt.equals
        // call: p7e62bc34.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.writeUtf8
        // call: pd896b5e6.readChallengeHeader
        // call: p883d7615.name
        // call: List<object>.<init>
        // call: p419f3742$p910eef8c.get
        // call: p883d7615.size
        // call: p883d7615.value
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c
        // type: List<object>
        // type: p7e62bc34
        return default!;
    }

    public static bool PromisesBody(pd64ed3e9 P0)
    {
        // str: "Transfer-Encoding"
        // str: "<this>"
        // str: "chunked"
        // str: "HEAD"
        // call: pd64ed3e9.m28ab1449
        // call: Intrinsics.areEqual
        // call: pd64ed3e9.request
        // call: Intrinsics.checkNotNullParameter
        // call: p23e8a4b4.headersContentLength
        // call: pd64ed3e9.code
        // call: StringsKt.equals
        // call: p15c2d85f.method
        return false;
    }

    private static void ReadChallengeHeader(p7e62bc34 P0, List<object> P1)
    {
        // str: "singletonMap<String, Str…ek + \"=\".repeat(eqCount))"
        // str: "="
        // call: pd896b5e6.readToken
        // call: pb5f5623b.<init>
        // call: StringsKt.repeat
        // call: p7e62bc34.exhausted
        // call: p23e8a4b4.skipAll
        // call: Dictionary<string, object>.<init>
        // call: pd896b5e6.startsWith
        // call: pd896b5e6.skipCommasAndWhitespace
        // call: List<object>.add
        // call: Intrinsics.stringPlus
        // call: Collections.singletonMap
        // call: Intrinsics.checkNotNullExpressionValue
        // call: MapsKt.emptyMap
        // call: pd896b5e6.readQuotedString
        // call: Dictionary<string, object>.put
        // type: pb5f5623b
        // type: Dictionary<string, object>
    }

    private static string ReadQuotedString(p7e62bc34 P0)
    {
        // str: "Failed requirement."
        // call: p7e62bc34.write
        // call: p7e62bc34.<init>
        // call: p7e62bc34.readByte
        // call: IllegalArgumentException.<init>
        // call: p7e62bc34.readUtf8
        // call: object.toString
        // call: p7e62bc34.getByte
        // call: p7e62bc34.size
        // call: p7e62bc34.indexOfElement
        // field: p7ddcfee1.pd1efad72.p80791b3a.pd896b5e6.f2fffa53e
        // type: IllegalArgumentException
        // type: p7e62bc34
        return string.Empty;
    }

    private static string ReadToken(p7e62bc34 P0)
    {
        // call: p7e62bc34.size
        // call: p7e62bc34.readUtf8
        // call: p7e62bc34.indexOfElement
        // field: p7ddcfee1.pd1efad72.p80791b3a.pd896b5e6.f0fabe32b
        return string.Empty;
    }

    public static void ReceiveHeaders(p50e34df9 P0, pdfadebdd P1, p883d7615 P2)
    {
        // str: "<this>"
        // str: "url"
        // str: "headers"
        // call: Intrinsics.checkNotNullParameter
        // call: List<object>.isEmpty
        // call: p706f1088$p910eef8c.parseAll
        // call: p50e34df9.saveFromResponse
        // field: p7ddcfee1.p50e34df9.fe2224d92
        // field: p7ddcfee1.p706f1088.f910eef8c
    }

    private static bool SkipCommasAndWhitespace(p7e62bc34 P0)
    {
        // call: p7e62bc34.readByte
        // call: p7e62bc34.getByte
        // call: p7e62bc34.exhausted
        return false;
    }

    private static bool StartsWith(p7e62bc34 P0, byte P1)
    {
        // call: p7e62bc34.getByte
        // call: p7e62bc34.exhausted
        return false;
    }

}
