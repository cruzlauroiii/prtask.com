namespace WillowMaze.Wasm.Decompiled;

public class P3c009818 : X509TrustManager
{
    public static p3c009818$p910eef8c F09bf518f;
    private static string F42dfec6c;
    private static string F492e20f5;
    private static string F60aacca3;
    private static string F6f904400;
    public static p3c009818$p910eef8c F910eef8c;
    private static string Fcb5523ad;
    private readonly p15bc97bf F0e591676;
    private X509Certificate[] F3488be6e;
    private readonly p15bc97bf F8866de17;
    private X509Certificate[] Fc6e9e27f;
    private X509Certificate[] Fde1b3042;

    public static void DcEuvxbTzaDGDpmv(p37a01c41$p910eef8c P0, string P1, string P2)
    {
        // call: p37a01c41$p910eef8c.e
    }

    public static void EEzqTkQNwmXuQWzt(object P0, string P1)
    {
        // call: Intrinsics.checkNotNullParameter
    }

    public static void GjVzCafydUPWEDhx(object P0, string P1)
    {
        // call: Intrinsics.checkNotNullExpressionValue
    }

    public static void IQZMJevmomXmpERZ(object P0, string P1)
    {
        // call: Intrinsics.checkNotNullParameter
    }

    public static void JQFIIQOhdJCNdDLN(X509Certificate P0)
    {
        // call: X509Certificate.checkValidity
    }

    public static string OyhAtqjUUmPzLCVz(string P0)
    {
        // call: DecryptString.decryptString
        return string.Empty;
    }

    public static string RbJLfYGUyFpHBlRL(string P0)
    {
        // call: DecryptString.decryptString
        return string.Empty;
    }

    public static bool TxOqKiRrWLzjznjW(List<object> P0)
    {
        // call: List<object>.isEmpty
        return false;
    }

    public static string[] WqzzCLstUrHrRRkh(p1f3f6c41 P0)
    {
        // call: p1f3f6c41.getSslPinningKeys
        return default!;
    }

    public static bool BMombTuRExwmkXyv(object[] P0, object P1)
    {
        // call: ArraysKt.contains
        return false;
    }

    public static void CNZMvmbELwnprrty(p3c009818 P0, X509Certificate[] P1)
    {
        // call: p3c009818.m7afe96c7
    }

    public static p1f3f6c41 FGrrnjlTyEsYpkYi(p15bc97bf P0)
    {
        // call: p15bc97bf.getTophNetworkSettings
        return default!;
    }

    public static bool FLxyTGorVNXPqddW(List<object> P0, object P1)
    {
        // call: List<object>.add
        return false;
    }

    private void M7afe96c7(X509Certificate[] P0)
    {
        // str: "e1186a07585ad6c51f2b4eb195fa0e8b1212321c33be52f0b6f070a8f7764205add2ea5a217d17c428fc5c2e06fc992b2..."
        // str: "getPublicKey(...)"
        // str: "Chain certs is not valid or bad pinning keys"
        // call: p3c009818.fLxyTGorVNXPqddW
        // call: p3c009818.skEhAupZADKQykVp
        // call: p3c009818.thsDafWEIXkAPLdn
        // call: p3c009818.RbJLfYGUyFpHBlRL
        // call: p3c009818.GjVzCafydUPWEDhx
        // call: p3c009818.WqzzCLstUrHrRRkh
        // call: p3c009818.bMombTuRExwmkXyv
        // call: p3c009818.fGrrnjlTyEsYpkYi
        // call: p3c009818.JQFIIQOhdJCNdDLN
        // call: List<object>.<init>
        // call: p3c009818.DcEuvxbTzaDGDpmv
        // call: p3c009818.xMGckpfaCQRxDkWS
        // call: p62bb659e.<init>
        // call: p3c009818.TxOqKiRrWLzjznjW
        // field: p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p91e02cd2.pd1efad72.p3c009818.fde1b3042
        // field: p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p91e02cd2.pd1efad72.p3c009818.f0e591676
        // field: p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c
        // type: p62bb659e
        // type: List<object>
    }

    public static void MzZhawRevtWTtHvE(object P0, string P1)
    {
        // call: Intrinsics.checkNotNullParameter
    }

    public static void PSQjJTTESIRbexfz(p3c009818 P0, X509Certificate[] P1)
    {
        // call: p3c009818.m7afe96c7
    }

    public static object[] SkEhAupZADKQykVp(ICollection<object> P0, object[] P1)
    {
        // call: ICollection<object>.toArray
        return default!;
    }

    public static PublicKey ThsDafWEIXkAPLdn(X509Certificate P0)
    {
        // call: X509Certificate.getPublicKey
        return default!;
    }

    public static string XMGckpfaCQRxDkWS(PublicKey P0)
    {
        // call: pc7c0a0a5.md8d8a6d2
        return string.Empty;
    }

    public void CheckClientTrusted(X509Certificate[] P0, string P1)
    {
        // str: "authType"
        // call: p3c009818.pSQjJTTESIRbexfz
        // call: p3c009818.IQZMJevmomXmpERZ
    }

    public void CheckServerTrusted(X509Certificate[] P0, string P1)
    {
        // str: "authType"
        // call: p3c009818.cNZMvmbELwnprrty
        // call: p3c009818.mzZhawRevtWTtHvE
    }

    public X509Certificate[] GetAcceptedIssuers()
    {
        // field: p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p91e02cd2.pd1efad72.p3c009818.fde1b3042
        return default!;
    }

}
