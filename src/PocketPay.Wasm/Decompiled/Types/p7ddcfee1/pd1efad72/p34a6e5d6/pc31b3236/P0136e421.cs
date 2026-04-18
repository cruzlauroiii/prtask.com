namespace WillowMaze.Wasm.Decompiled;

public class P0136e421 : Pe00aacd2
{
    public static p0136e421$p910eef8c F67ac8579;
    public static p0136e421$p910eef8c F910eef8c;
    private readonly Type F06bb8a57;
    private readonly Type F0e2319ab;
    private readonly Type F1b58e072;
    private readonly Type F5829e956;
    private readonly Type F8069ba34;
    private readonly Type Fab1ed06a;
    private readonly Type Fb62a397c;
    private readonly Type Fb81d7a86;
    private readonly Type Fcb769239;

    public bool MatchesSocketFactory(SSLSocketFactory P0)
    {
        // str: "sslSocketFactory"
        // call: Intrinsics.checkNotNullParameter
        // call: Type.isInstance
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p0136e421.fcb769239
        return false;
    }

    public X509TrustManager TrustManager(SSLSocketFactory P0)
    {
        // str: "x509TrustManager"
        // str: "sslSocketFactory"
        // str: "sslParameters"
        // str: "trustManager"
        // call: p23e8a4b4.readFieldOrNull
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.checkNotNull
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p0136e421.f8069ba34
        // type: X509TrustManager
        return default!;
    }

}
