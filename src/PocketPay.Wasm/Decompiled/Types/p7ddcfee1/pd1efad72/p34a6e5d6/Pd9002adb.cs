namespace WillowMaze.Wasm.Decompiled;

public class Pd9002adb : P419f3742
{
    private static bool F04a3afd8;
    public static pd9002adb$p910eef8c F53c9a785;
    public static pd9002adb$p910eef8c F55bf2ab9;
    private static bool F6208c126;
    private static bool F7794bd89;
    public static pd9002adb$p910eef8c F910eef8c;
    private readonly List<object> F16c7d849;
    private readonly List<object> F345e6484;
    private readonly List<object> Ff80d89fb;

    public static bool Access$isSupported$cp()
    {
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pd9002adb.f6208c126
        return false;
    }

    public p2e948d4e BuildCertificateChainCleaner(X509TrustManager P0)
    {
        // str: "trustManager"
        // call: p6c5d169e$p910eef8c.buildIfSupported
        // call: Intrinsics.checkNotNullParameter
        // call: p419f3742.buildCertificateChainCleaner
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p6c5d169e.f910eef8c
        return default!;
    }

    public void ConfigureTlsExtensions(SSLSocket P0, string P1, List<object> P2)
    {
        // str: "protocols"
        // str: "sslSocket"
        // call: p7e5d37b6.configureTlsExtensions
        // call: IEnumerable<object>.iterator
        // call: p7e5d37b6.matchesSocket
        // call: Intrinsics.checkNotNullParameter
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pd9002adb.f16c7d849
    }

    public string GetSelectedProtocol(SSLSocket P0)
    {
        // str: "sslSocket"
        // call: IEnumerator<object>.hasNext
        // call: IEnumerable<object>.iterator
        // call: p7e5d37b6.getSelectedProtocol
        // call: Intrinsics.checkNotNullParameter
        // call: IEnumerator<object>.next
        // call: p7e5d37b6.matchesSocket
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pd9002adb.f16c7d849
        return string.Empty;
    }

    public bool IsCleartextTrafficPermitted(string P0)
    {
        // str: "hostname"
        // call: NetworkSecurityPolicy.getInstance
        // call: Intrinsics.checkNotNullParameter
        // call: NetworkSecurityPolicy.isCleartextTrafficPermitted
        return false;
    }

    public X509TrustManager TrustManager(SSLSocketFactory P0)
    {
        // str: "sslSocketFactory"
        // call: IEnumerator<object>.hasNext
        // call: IEnumerable<object>.iterator
        // call: IEnumerator<object>.next
        // call: p7e5d37b6.matchesSocketFactory
        // call: Intrinsics.checkNotNullParameter
        // call: p7e5d37b6.trustManager
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pd9002adb.f16c7d849
        return default!;
    }

}
