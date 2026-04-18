namespace WillowMaze.Wasm.Decompiled;

public class Pc10505ac : HostnameVerifier
{
    private static int F08f65d31;
    private static int F4304764a;
    public static pc10505ac F490998d4;
    public static pc10505ac F6e332a97;
    public static pc10505ac F76425f17;
    private static int F8e194289;
    public static pc10505ac F8e2f56b7;
    private static int F92e7e2a5;
    private static int Fdfc32271;
    public static pc10505ac Feb391229;

    private string AsciiToLowercase(string P0)
    {
        // str: "this as java.lang.String).toLowerCase(locale)"
        // str: "US"
        // call: Intrinsics.checkNotNullExpressionValue
        // call: string.toLowerCase
        // call: pc10505ac.isAscii
        // field: java.util.Locale.US
        return string.Empty;
    }

    private List<object> GetSubjectAltNames(X509Certificate P0, int P1)
    {
        // call: CollectionsKt.emptyList
        // call: X509Certificate.getSubjectAlternativeNames
        // call: List<object>.<init>
        // call: ICollection<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: List<object>.size
        // call: List<object>.get
        // call: int.valueOf
        // call: Intrinsics.areEqual
        // call: List<object>.add
        // type: List<object>
        return default!;
    }

    private bool IsAscii(string P0)
    {
        // call: string.length
        // call: p81f91ccd.mda78a0be
        return false;
    }

    private bool VerifyHostname(string P0, string P1)
    {
        // str: "*."
        // str: "this as java.lang.String).substring(startIndex)"
        // str: "*"
        // str: "c9101cb4e5c0db65217eb32f28152769aa0ce8f672a1705c1d4728e0bc"
        // str: ".."
        // call: string.substring
        // call: DecryptString.decryptString
        // call: StringsKt.startsWith$default
        // call: Intrinsics.areEqual
        // call: string.length
        // call: StringsKt.endsWith$default
        // call: StringsKt.indexOf$default
        // call: Intrinsics.stringPlus
        // call: CharSequence.length
        // call: Intrinsics.checkNotNullExpressionValue
        // call: StringsKt.contains$default
        // call: pc10505ac.asciiToLowercase
        // call: StringsKt.lastIndexOf$default
        return false;
    }

    private bool VerifyHostname(string P0, X509Certificate P1)
    {
        // call: IEnumerator<object>.next
        // call: pc10505ac.verifyHostname
        // call: IEnumerator<object>.hasNext
        // call: IEnumerable<object>.iterator
        // call: ICollection<object>.isEmpty
        // call: pc10505ac.asciiToLowercase
        // call: pc10505ac.getSubjectAltNames
        // field: p7ddcfee1.pd1efad72.pa60aeea3.pc10505ac.f76425f17
        return false;
    }

    private bool VerifyIpAddress(string P0, X509Certificate P1)
    {
        // call: Intrinsics.areEqual
        // call: ICollection<object>.isEmpty
        // call: IEnumerator<object>.next
        // call: pc10505ac.getSubjectAltNames
        // call: IEnumerator<object>.hasNext
        // call: p29d9c051.toCanonicalHost
        // call: IEnumerable<object>.iterator
        return false;
    }

    public List<object> AllSubjectAltNames(X509Certificate P0)
    {
        // str: "certificate"
        // call: CollectionsKt.plus
        // call: Intrinsics.checkNotNullParameter
        // call: pc10505ac.getSubjectAltNames
        return default!;
    }

    public bool Verify(string P0, X509Certificate P1)
    {
        // str: "host"
        // str: "certificate"
        // call: pc10505ac.verifyHostname
        // call: Intrinsics.checkNotNullParameter
        // call: p23e8a4b4.canParseAsIpAddress
        // call: pc10505ac.verifyIpAddress
        return false;
    }

    public bool Verify(string P0, SSLSession P1)
    {
        // str: "host"
        // str: "null cannot be cast to non-null type java.security.cert.X509Certificate"
        // str: "session"
        // call: Intrinsics.checkNotNullParameter
        // call: SSLSession.getPeerCertificates
        // call: pc10505ac.verify
        // call: NullPointerException.<init>
        // call: pc10505ac.isAscii
        // type: NullPointerException
        return false;
    }

}
