namespace WillowMaze.Wasm.Decompiled;

public class Pdfadebdd_p910eef8c
{
    private void M3c1f84a0(p7e62bc34 P0, string P1, int P2, int P3, string P4, bool P5, bool P6, bool P7, bool P8, System.Text.Encoding P9)
    {
        // str: "%2B"
        // str: "996d24d1853015392a4f7d15a5ded269e2539e454d2d5bb14481670e5c"
        // call: p7e62bc34.exhausted
        // call: char.charCount
        // call: p7e62bc34.writeByte
        // call: p7e62bc34.writeString
        // call: string.codePointAt
        // call: StringsKt.contains$default
        // call: p7e62bc34.writeUtf8
        // call: p7e62bc34.writeUtf8CodePoint
        // call: Intrinsics.areEqual
        // call: pdfadebdd.m5fda8f1f
        // call: p7e62bc34.readByte
        // call: DecryptString.decryptString
        // call: pdfadebdd$p910eef8c.mc51be560
        // call: p7e62bc34.<init>
        // field: java.nio.charset.StandardCharsets.UTF_8
        // type: p7e62bc34
    }

    private void M8dd597be(p7e62bc34 P0, string P1, int P2, int P3, bool P4)
    {
        // call: char.charCount
        // call: string.charAt
        // call: p7e62bc34.writeUtf8CodePoint
        // call: p23e8a4b4.parseHexDigit
        // call: p7e62bc34.writeByte
        // call: string.codePointAt
    }

    public static string Mc2d89598(pdfadebdd$p910eef8c P0, string P1, int P2, int P3, bool P4, int P5, object P6)
    {
        // call: string.length
        // call: pdfadebdd$p910eef8c.percentDecode$okhttp
        return string.Empty;
    }

    private bool Mc51be560(string P0, int P1, int P2)
    {
        // call: string.charAt
        // call: p23e8a4b4.parseHexDigit
        return false;
    }

    public static string Mca8b8fb9(pdfadebdd$p910eef8c P0, string P1, int P2, int P3, string P4, bool P5, bool P6, bool P7, bool P8, System.Text.Encoding P9, int P10, object P11)
    {
        // call: string.length
        // call: pdfadebdd$p910eef8c.canonicalize$okhttp
        return string.Empty;
    }

    public pdfadebdd -deprecated_get(string P0)
    {
        // str: "url"
        // call: pdfadebdd$p910eef8c.get
        // call: Intrinsics.checkNotNullParameter
        return default!;
    }

    public pdfadebdd -deprecated_get(Uri P0)
    {
        // str: "uri"
        // call: pdfadebdd$p910eef8c.get
        // call: Intrinsics.checkNotNullParameter
        return default!;
    }

    public pdfadebdd -deprecated_parse(string P0)
    {
        // str: "url"
        // call: pdfadebdd$p910eef8c.parse
        // call: Intrinsics.checkNotNullParameter
        return default!;
    }

    public string Canonicalize$okhttp(string P0, int P1, int P2, string P3, bool P4, bool P5, bool P6, bool P7, System.Text.Encoding P8)
    {
        // str: "this as java.lang.String…ing(startIndex, endIndex)"
        // str: "<this>"
        // str: "encodeSet"
        // call: char.charCount
        // call: Intrinsics.checkNotNullParameter
        // call: StringsKt.contains$default
        // call: string.codePointAt
        // call: pdfadebdd$p910eef8c.m3c1f84a0
        // call: p7e62bc34.<init>
        // call: Intrinsics.checkNotNullExpressionValue
        // call: pdfadebdd$p910eef8c.mc51be560
        // call: p7e62bc34.writeUtf8
        // call: p7e62bc34.readUtf8
        // call: string.substring
        // field: android.os.Build$VERSION.SDK_INT
        // type: p7e62bc34
        return string.Empty;
    }

    public int DefaultPort(string P0)
    {
        // str: "https"
        // str: "scheme"
        // str: "http"
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.areEqual
        return 0;
    }

    public pdfadebdd Get(string P0)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: pdfadebdd$p2bd4a59b.build
        // call: pdfadebdd$p2bd4a59b.parse$okhttp
        // call: pdfadebdd$p2bd4a59b.<init>
        // type: pdfadebdd$p2bd4a59b
        return default!;
    }

    public pdfadebdd Get(Uri P0)
    {
        // str: "toString()"
        // str: "<this>"
        // call: Intrinsics.checkNotNullExpressionValue
        // call: pdfadebdd$p910eef8c.parse
        // call: Uri.toString
        // call: Intrinsics.checkNotNullParameter
        return default!;
    }

    public pdfadebdd Parse(string P0)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: pdfadebdd$p910eef8c.get
        return default!;
    }

    public string PercentDecode$okhttp(string P0, int P1, int P2, bool P3)
    {
        // str: "<this>"
        // str: "this as java.lang.String…ing(startIndex, endIndex)"
        // call: pdfadebdd$p910eef8c.m8dd597be
        // call: p7e62bc34.writeUtf8
        // call: p7e62bc34.<init>
        // call: string.substring
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.readUtf8
        // call: string.charAt
        // type: p7e62bc34
        return string.Empty;
    }

    public void ToPathString$okhttp(List<object> P0, StringBuilder P1)
    {
        // str: "<this>"
        // str: "out"
        // call: Intrinsics.checkNotNullParameter
        // call: StringBuilder.append
        // call: List<object>.size
        // call: List<object>.get
    }

    public List<object> ToQueryNamesAndValues$okhttp(string P0)
    {
        // str: "<this>"
        // str: "this as java.lang.String…ing(startIndex, endIndex)"
        // call: StringsKt.indexOf$default
        // call: string.substring
        // call: List<object>.<init>
        // call: List<object>.add
        // call: Intrinsics.checkNotNullExpressionValue
        // call: string.length
        // call: Intrinsics.checkNotNullParameter
        // type: List<object>
        return default!;
    }

    public void ToQueryString$okhttp(List<object> P0, StringBuilder P1)
    {
        // str: "out"
        // str: "<this>"
        // call: IntProgression.getFirst
        // call: Intrinsics.checkNotNullParameter
        // call: IntProgression.getStep
        // call: StringBuilder.append
        // call: List<object>.size
        // call: IntProgression.getLast
        // call: RangesKt.until
        // call: List<object>.get
        // call: RangesKt.step
    }

}
