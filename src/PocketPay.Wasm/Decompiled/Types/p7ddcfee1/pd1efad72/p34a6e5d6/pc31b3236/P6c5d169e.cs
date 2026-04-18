namespace WillowMaze.Wasm.Decompiled;

public class P6c5d169e : P2e948d4e
{
    public static p6c5d169e$p910eef8c F910eef8c;
    public static p6c5d169e$p910eef8c Fac9e92ff;
    public static p6c5d169e$p910eef8c Fd33cf4b6;
    public static p6c5d169e$p910eef8c Fdf642878;
    private readonly X509TrustManager F1fb3b48d;
    private readonly X509TrustManagerExtensions F3d69863a;
    private readonly X509TrustManagerExtensions F49921318;
    private readonly X509TrustManagerExtensions F85edfb4f;
    private readonly X509TrustManager F8ce376c0;
    private readonly X509TrustManagerExtensions Fbe6e91de;

    public List<object> Clean(List<object> P0, string P1)
    {
        // str: "30e3268c514035d2b6192e4e79e2304c6eca905add313df64a4a19b8547639"
        // str: "x509TrustManagerExtensio…ficates, \"RSA\", hostname)"
        // str: "chain"
        // str: "null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.t..."
        // str: "hostname"
        // call: Intrinsics.checkNotNullParameter
        // call: NullPointerException.<init>
        // call: SSLPeerUnverifiedException.<init>
        // call: DecryptString.decryptString
        // call: X509TrustManagerExtensions.checkServerTrusted
        // call: Intrinsics.checkNotNullExpressionValue
        // call: SSLPeerUnverifiedException.initCause
        // call: ICollection<object>.toArray
        // call: CertificateException.getMessage
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p6c5d169e.f3d69863a
        // type: NullPointerException
        // type: SSLPeerUnverifiedException
        return default!;
    }

    public bool Equals(object P0)
    {
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p6c5d169e.f1fb3b48d
        return false;
    }

    public int HashCode()
    {
        // call: System.identityHashCode
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p6c5d169e.f1fb3b48d
        return 0;
    }

}
