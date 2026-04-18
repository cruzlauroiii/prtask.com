namespace WillowMaze.Wasm.Decompiled;

public class P43967033
{
    private static p4e56d02a[] F02ddd5f4;
    public static p43967033 F11bd7ded;
    public static p43967033 F1c702874;
    public static p43967033 F20d89943;
    private static p4e56d02a[] F3047a6b6;
    public static p43967033$p910eef8c F36830f53;
    public static p43967033$p910eef8c F37dff26d;
    public static p43967033 F3ac174b4;
    private static p4e56d02a[] F47437469;
    private static p4e56d02a[] F7036caf5;
    public static p43967033 F7a992407;
    public static p43967033 F7d49028f;
    public static p43967033 F87adc5f3;
    public static p43967033$p910eef8c F910eef8c;
    public static p43967033 F947e023d;
    public static p43967033 F969bbf2b;
    public static p43967033 F98e16c7f;
    private static p4e56d02a[] F99df7c1b;
    public static p43967033 F9cff5ed0;
    public static p43967033 Fa30536ef;
    public static p43967033$p910eef8c Fb0a713e6;
    private static p4e56d02a[] Fb3f1081e;
    public static p43967033$p910eef8c Fc50bbbfc;
    public static p43967033 Fc73b9b52;
    public static p43967033 Fd9ddc10e;
    private readonly string[] F09aa7d05;
    private readonly string[] F154ad161;
    private readonly string[] F23b64a7a;
    private readonly bool F3a01f145;
    private readonly bool F4a6cc1c2;
    private readonly bool F54c95501;
    private readonly bool F57d574cf;
    private readonly string[] F71a04149;
    private readonly bool F8eb24d45;
    private readonly string[] F92ff582e;
    private readonly bool F95f752e4;
    private readonly bool Fcca196e7;
    private readonly bool Ff0375887;

    public static string[] M384b5a7a(p43967033 P0)
    {
        // field: p7ddcfee1.p43967033.f23b64a7a
        return default!;
    }

    public static string[] M6428eb93(p43967033 P0)
    {
        // field: p7ddcfee1.p43967033.f71a04149
        return default!;
    }

    private p43967033 Md1c955b0(SSLSocket P0, bool P1)
    {
        // str: "supportedCipherSuites[indexOfFallbackScsv]"
        // str: "supportedCipherSuites"
        // str: "sslSocket.enabledProtocols"
        // str: "TLS_FALLBACK_SCSV"
        // str: "sslSocket.enabledCipherSuites"
        // str: "tlsVersionsIntersection"
        // str: "cipherSuitesIntersection"
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p23e8a4b4.intersect
        // call: p23e8a4b4.concat
        // call: p4e56d02a$p910eef8c.getORDER_BY_NAME$okhttp
        // call: Arrays.copyOf
        // call: p43967033$p2bd4a59b.cipherSuites
        // call: SSLSocket.getEnabledCipherSuites
        // call: SSLSocket.getSupportedCipherSuites
        // call: SSLSocket.getEnabledProtocols
        // call: p43967033$p2bd4a59b.<init>
        // call: p43967033$p2bd4a59b.build
        // call: p43967033$p2bd4a59b.tlsVersions
        // call: ComparisonsKt.naturalOrder
        // call: p23e8a4b4.indexOf
        // field: p7ddcfee1.p43967033.f71a04149
        // field: p7ddcfee1.p4e56d02a.f910eef8c
        // field: p7ddcfee1.p43967033.f23b64a7a
        // type: p43967033$p2bd4a59b
        return default!;
    }

    public List<object> -deprecated_cipherSuites()
    {
        // call: p43967033.cipherSuites
        return default!;
    }

    public bool -deprecated_supportsTlsExtensions()
    {
        // field: p7ddcfee1.p43967033.f95f752e4
        return false;
    }

    public List<object> -deprecated_tlsVersions()
    {
        // call: p43967033.tlsVersions
        return default!;
    }

    public void Apply$okhttp(SSLSocket P0, bool P1)
    {
        // str: "sslSocket"
        // call: p43967033.tlsVersions
        // call: p43967033.cipherSuites
        // call: p43967033.md1c955b0
        // call: SSLSocket.setEnabledProtocols
        // call: Intrinsics.checkNotNullParameter
        // call: SSLSocket.setEnabledCipherSuites
        // field: p7ddcfee1.p43967033.f71a04149
        // field: p7ddcfee1.p43967033.f23b64a7a
    }

    public List<object> CipherSuites()
    {
        // call: p4e56d02a$p910eef8c.forJavaName
        // call: ICollection<object>.add
        // call: List<object>.<init>
        // call: CollectionsKt.toList
        // field: p7ddcfee1.p43967033.f23b64a7a
        // field: p7ddcfee1.p4e56d02a.f910eef8c
        // type: List<object>
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: Arrays.equals
        // field: p7ddcfee1.p43967033.f71a04149
        // field: p7ddcfee1.p43967033.f8eb24d45
        // field: p7ddcfee1.p43967033.f23b64a7a
        // field: p7ddcfee1.p43967033.f95f752e4
        return false;
    }

    public int HashCode()
    {
        // call: Arrays.hashCode
        // field: p7ddcfee1.p43967033.f23b64a7a
        // field: p7ddcfee1.p43967033.f95f752e4
        // field: p7ddcfee1.p43967033.f8eb24d45
        // field: p7ddcfee1.p43967033.f71a04149
        return 0;
    }

    public bool IsCompatible(SSLSocket P0)
    {
        // str: "socket"
        // call: p23e8a4b4.hasIntersection
        // call: SSLSocket.getEnabledCipherSuites
        // call: ComparisonsKt.naturalOrder
        // call: p4e56d02a$p910eef8c.getORDER_BY_NAME$okhttp
        // call: SSLSocket.getEnabledProtocols
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.p43967033.f71a04149
        // field: p7ddcfee1.p43967033.f8eb24d45
        // field: p7ddcfee1.p4e56d02a.f910eef8c
        // field: p7ddcfee1.p43967033.f23b64a7a
        return false;
    }

    public bool IsTls()
    {
        // field: p7ddcfee1.p43967033.f8eb24d45
        return false;
    }

    public bool SupportsTlsExtensions()
    {
        // field: p7ddcfee1.p43967033.f95f752e4
        return false;
    }

    public List<object> TlsVersions()
    {
        // call: ICollection<object>.add
        // call: List<object>.<init>
        // call: p20455456$p910eef8c.forJavaName
        // call: CollectionsKt.toList
        // field: p7ddcfee1.p43967033.f71a04149
        // field: p7ddcfee1.p20455456.f910eef8c
        // type: List<object>
        return default!;
    }

    public string ToString()
    {
        // str: "[all enabled]"
        // str: ", supportsTlsExtensions="
        // str: "ConnectionSpec(cipherSuites="
        // str: ", tlsVersions="
        // str: "ConnectionSpec()"
        // call: StringBuilder.<init>
        // call: Objects.toString
        // call: p43967033.tlsVersions
        // call: StringBuilder.append
        // call: p43967033.cipherSuites
        // call: StringBuilder.toString
        // field: p7ddcfee1.p43967033.f8eb24d45
        // field: p7ddcfee1.p43967033.f95f752e4
        // type: StringBuilder
        return string.Empty;
    }

}
