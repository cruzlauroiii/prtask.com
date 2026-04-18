namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\b"}, d2 = {"Lp8d777f38/pb3f20355/pcf1e8c14/p156a2121;", "Lp8d777f38/pb3f20355/pcf1e8c14/p69ce353b;", "context", "Landroid/content/object;", "<init>", "(Landroid/content/object;)V", "hasInternetConnection", "", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p156a2121 : p8d777f38.pb3f20355.pcf1e8c14.p69ce353b {
    private readonly android.content.object f1ab12c05;
    private readonly android.content.object f5c18ef72;
    private readonly android.content.object fe5ff6054;
    private readonly android.content.object fe772d1ff;

    public p156a2121(android.content.object context) {
        bqiqMPgWZzkbSQaM(context, "context");
        this.f5c18ef72 = context;
    }

    public static android.net.NetworkCapabilities BAjQowOsxfZMOfiY(android.net.ConnectivityManager connectivityManager, android.net.Network network) {
        return connectivityManager.getNetworkCapabilities(network);
    }

    public static android.net.Network KxEwfVqkAgFWQDWy(android.net.ConnectivityManager connectivityManager) {
        return connectivityManager.getActiveNetwork();
    }

    public static bool QGYgObNAiJFRvChu(android.net.NetworkCapabilities networkCapabilities, int i) {
        return networkCapabilities.hasCapability(i);
    }

    public static void BqiqMPgWZzkbSQaM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object ZsRBnYLTVZHaJRfI(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public override bool HasInternetConnection() {
        android.net.Network networkKxEwfVqkAgFWQDWy;
        android.net.NetworkCapabilities networkCapabilitiesBAjQowOsxfZMOfiY;
        if ((20 + 4) % 4 > 0) {
        }
        java.lang.object objZsRBnYLTVZHaJRfI = zsRBnYLTVZHaJRfI(this.f5c18ef72, "connectivity");
        android.net.ConnectivityManager connectivityManager = !(objZsRBnYLTVZHaJRfI is android.net.ConnectivityManager) ? null : (android.net.ConnectivityManager) objZsRBnYLTVZHaJRfI;
        return (connectivityManager is null || (networkKxEwfVqkAgFWQDWy = KxEwfVqkAgFWQDWy(connectivityManager)) is null || (networkCapabilitiesBAjQowOsxfZMOfiY = BAjQowOsxfZMOfiY(connectivityManager, networkKxEwfVqkAgFWQDWy)) is null || !QGYgObNAiJFRvChu(networkCapabilitiesBAjQowOsxfZMOfiY, 12)) ? false : true;
    }
}

