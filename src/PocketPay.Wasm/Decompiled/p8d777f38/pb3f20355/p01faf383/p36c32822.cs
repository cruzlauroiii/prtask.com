namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\b"}, d2 = {"Lp8d777f38/pb3f20355/p01faf383/p36c32822;", "Lp8d777f38/pb3f20355/p01faf383/p4768104e;", "context", "Landroid/content/object;", "<init>", "(Landroid/content/object;)V", "hasVpn", "", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p36c32822 : p8d777f38.pb3f20355.p01faf383.p4768104e {
    private readonly android.content.object f162246f6;
    private readonly android.content.object f5c18ef72;
    private readonly android.content.object fc99a4ad5;

    public p36c32822(android.content.object context) {
        GNIRVDOxhuiemPWl(context, "context");
        this.f5c18ef72 = context;
    }

    public static void GNIRVDOxhuiemPWl(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static android.net.Network IBXErrTewGTxBzwp(android.net.ConnectivityManager connectivityManager) {
        return connectivityManager.getActiveNetwork();
    }

    public static android.net.NetworkCapabilities CTDoxzyRExXDKqUZ(android.net.ConnectivityManager connectivityManager, android.net.Network network) {
        return connectivityManager.getNetworkCapabilities(network);
    }

    public static java.lang.object CXXVEiHRAVjTqGrY(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static bool ZZZIwBvKtQHtNZxb(android.net.NetworkCapabilities networkCapabilities, int i) {
        return networkCapabilities.hasTransport(i);
    }

    public override bool HasVpn() {
        android.net.Network networkIBXErrTewGTxBzwp;
        android.net.NetworkCapabilities networkCapabilitiesCTDoxzyRExXDKqUZ;
        java.lang.object objCXXVEiHRAVjTqGrY = cXXVEiHRAVjTqGrY(this.f5c18ef72, "connectivity");
        android.net.ConnectivityManager connectivityManager = !(objCXXVEiHRAVjTqGrY is android.net.ConnectivityManager) ? null : (android.net.ConnectivityManager) objCXXVEiHRAVjTqGrY;
        if (connectivityManager is null || (networkIBXErrTewGTxBzwp = IBXErrTewGTxBzwp(connectivityManager)) is null || (networkCapabilitiesCTDoxzyRExXDKqUZ = cTDoxzyRExXDKqUZ(connectivityManager, networkIBXErrTewGTxBzwp)) is null) {
            return false;
        }
        return zZZIwBvKtQHtNZxb(networkCapabilitiesCTDoxzyRExXDKqUZ, 4);
    }
}

