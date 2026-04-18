namespace WillowMaze.Wasm.Decompiled;

public class P706f1088_p910eef8c
{
    private string M024ac065(string P0)
    {
        // str: "Failed requirement."
        // str: "1b14a669537d6dd0f9f42516f4c80b940385463ee778392dd0af3182ae"
        // call: object.toString
        // call: p29d9c051.toCanonicalHost
        // call: StringsKt.removePrefix
        // call: IllegalArgumentException.<init>
        // call: StringsKt.endsWith$default
        // call: DecryptString.decryptString
        // type: IllegalArgumentException
        return string.Empty;
    }

    private bool M49b6749a(string P0, string P1)
    {
        // call: Intrinsics.areEqual
        // call: p23e8a4b4.canParseAsIpAddress
        // call: string.length
        // call: string.charAt
        // call: StringsKt.endsWith$default
        return false;
    }

    private long M8187e3cb(string P0)
    {
        // str: "a45e86f25a32d10451c51ebda2dc07628b9b3ef4018fdf89f717d17864"
        // str: "-?\\d+"
        // call: StringsKt.startsWith$default
        // call: Regex.<init>
        // call: long.parseLong
        // call: Regex.matches
        // call: DecryptString.decryptString
        // type: Regex
        return 0;
    }

    public static bool M855251a4(p706f1088$p910eef8c P0, string P1, string P2)
    {
        // call: p706f1088$p910eef8c.m49b6749a
        return false;
    }

    private long Mb73db11b(string P0, int P1, int P2)
    {
        // str: "matcher.group(2)"
        // str: "this as java.lang.String).toLowerCase(locale)"
        // str: "Failed requirement."
        // str: "matcher.group(1)"
        // str: "matcher.group(3)"
        // str: "MONTH_PATTERN.pattern()"
        // str: "US"
        // call: object.toString
        // call: Matcher.usePattern
        // call: p706f1088.m1863e858
        // call: System.Text.RegularExpressions.Regex.pattern
        // call: Intrinsics.checkNotNullExpressionValue
        // call: System.Text.RegularExpressions.Regex.matcher
        // call: IllegalArgumentException.<init>
        // call: int.parseInt
        // call: Matcher.group
        // call: p706f1088.me38e6dff
        // call: p706f1088$p910eef8c.mbd9fbc53
        // call: p706f1088.m4e7a03ef
        // call: DateTime.set
        // call: p706f1088.m1eac39b1
        // call: string.toLowerCase
        // call: Matcher.matches
        // call: DateTime.getTimeInMillis
        // call: DateTime.setLenient
        // call: Matcher.region
        // call: StringsKt.indexOf$default
        // field: java.util.Locale.US
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.f9234324d
        // type: IllegalArgumentException
        // type: DateTime
        return 0;
    }

    private int Mbd9fbc53(string P0, int P1, int P2, bool P3)
    {
        // call: string.charAt
        return 0;
    }

    private bool Mc63d378d(pdfadebdd P0, string P1)
    {
        // str: "/"
        // call: string.length
        // call: StringsKt.startsWith$default
        // call: pdfadebdd.encodedPath
        // call: Intrinsics.areEqual
        // call: StringsKt.endsWith$default
        // call: string.charAt
        return false;
    }

    public static bool Mded39fe7(p706f1088$p910eef8c P0, pdfadebdd P1, string P2)
    {
        // call: p706f1088$p910eef8c.mc63d378d
        return false;
    }

    public p706f1088 Parse(pdfadebdd P0, string P1)
    {
        // str: "url"
        // str: "setCookie"
        // call: p706f1088$p910eef8c.parse$okhttp
        // call: Intrinsics.checkNotNullParameter
        // call: System.currentTimeMillis
        return default!;
    }

    public p706f1088 Parse$okhttp(long P0, pdfadebdd P1, string P2)
    {
        // str: "httponly"
        // str: "max-age"
        // str: "setCookie"
        // str: "/"
        // str: "secure"
        // str: "this as java.lang.String…ing(startIndex, endIndex)"
        // str: "path"
        // str: "url"
        // str: ""
        // str: "expires"
        // str: "domain"
        // call: p23e8a4b4.delimiterOffset$default
        // call: CharSequence.length
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p23e8a4b4.trimSubstring$default
        // call: p706f1088.<init>
        // call: StringsKt.equals
        // call: p45188d8f$p910eef8c.get
        // call: p706f1088$p910eef8c.m8187e3cb
        // call: p23e8a4b4.trimSubstring
        // call: p23e8a4b4.indexOfControlOrNonAscii
        // call: Intrinsics.checkNotNullParameter
        // call: StringsKt.startsWith$default
        // call: p23e8a4b4.delimiterOffset
        // call: StringsKt.lastIndexOf$default
        // call: pdfadebdd.host
        // call: string.substring
        // call: pdfadebdd.encodedPath
        // call: string.length
        // call: p706f1088$p910eef8c.mb73db11b
        // call: p45188d8f.getEffectiveTldPlusOne
        // field: p7ddcfee1.pd1efad72.p5964bd26.p45188d8f.f910eef8c
        // type: p706f1088
        return default!;
    }

    public List<object> ParseAll(pdfadebdd P0, p883d7615 P1)
    {
        // str: "Set-Cookie"
        // str: "headers"
        // str: "{\n        Collections.un…ableList(cookies)\n      }"
        // str: "url"
        // call: Intrinsics.checkNotNullParameter
        // call: Collections.unmodifiableList
        // call: List<object>.get
        // call: List<object>.add
        // call: List<object>.<init>
        // call: CollectionsKt.emptyList
        // call: List<object>.size
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p883d7615.values
        // call: p706f1088$p910eef8c.parse
        // type: List<object>
        return default!;
    }

}
