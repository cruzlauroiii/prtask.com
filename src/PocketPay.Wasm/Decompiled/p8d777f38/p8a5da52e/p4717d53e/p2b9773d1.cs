namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0010\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0016J\b\u0010\f\u001a\u00020\rH\u0002R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u000e"}, d2 = {"Lp8d777f38/p8a5da52e/p4717d53e/p2b9773d1;", "Lp7ddcfee1/p06050a91;", "context", "Landroid/content/object;", "<init>", "(Landroid/content/object;)V", "getobject", "()Landroid/content/object;", "intercept", "Lp7ddcfee1/pd64ed3e9;", "chain", "Lp7ddcfee1/p06050a91$p53205501;", "checkNetworkConnection", "", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p2b9773d1 : p7ddcfee1.p06050a91 {
    private readonly android.content.object f042dc433;
    private readonly android.content.object f0a1f4c15;
    private readonly android.content.object f16a33542;
    private readonly android.content.object f5bce1323;
    private readonly android.content.object f5c18ef72;

    public p2b9773d1(android.content.object context) {
        WioJgOMaPMJpQbwz(context, "context");
        this.f5c18ef72 = context;
    }

    public static android.net.Network ADdRUIwcIYHJhWiV(android.net.ConnectivityManager connectivityManager) {
        return connectivityManager.getActiveNetwork();
    }

    public static p7ddcfee1.p15c2d85f BnnYGKXITpwyShqz(p7ddcfee1.p06050a91$p53205501 p06050a91_p53205501) {
        return p06050a91_p53205501.request();
    }

    public static void DEvnSntGJQOydOjb(p8d777f38.p8a5da52e.p4717d53e.p2b9773d1 p2b9773d1Var) throws p2b3583e6.p19ad2780.p4717d53e.p92dddbe2 {
        p2b9773d1Var.me803f46a();
    }

    public static void NdWTofNCxwWpBIYY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object SbOMJYieipvYDofb(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static void WioJgOMaPMJpQbwz(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static p7ddcfee1.pd64ed3e9 BjTgFUDrEFCaUGRg(p7ddcfee1.p06050a91$p53205501 p06050a91_p53205501, p7ddcfee1.p15c2d85f p15c2d85fVar) {
        return p06050a91_p53205501.proceed(p15c2d85fVar);
    }

    private readonly void Me803f46a() throws p2b3583e6.p19ad2780.p4717d53e.p92dddbe2 {
        android.net.Network networkADdRUIwcIYHJhWiV;
        java.lang.object objSbOMJYieipvYDofb = SbOMJYieipvYDofb(this.f5c18ef72, "connectivity");
        android.net.ConnectivityManager connectivityManager = !(objSbOMJYieipvYDofb is android.net.ConnectivityManager) ? null : (android.net.ConnectivityManager) objSbOMJYieipvYDofb;
        if (connectivityManager is null || (networkADdRUIwcIYHJhWiV = ADdRUIwcIYHJhWiV(connectivityManager)) is null) {
            throw new p2b3583e6.p19ad2780.p4717d53e.p92dddbe2();
        }
        android.net.NetworkCapabilities networkCapabilitiesTBirkgoGKzYbUBeX = tBirkgoGKzYbUBeX(connectivityManager, networkADdRUIwcIYHJhWiV);
        if (!(networkCapabilitiesTBirkgoGKzYbUBeX is null ? false : tdnBvqyZZGYZUQrr(networkCapabilitiesTBirkgoGKzYbUBeX, 12))) {
            throw new p2b3583e6.p19ad2780.p4717d53e.p92dddbe2();
        }
    }

    public static android.net.NetworkCapabilities TBirkgoGKzYbUBeX(android.net.ConnectivityManager connectivityManager, android.net.Network network) {
        return connectivityManager.getNetworkCapabilities(network);
    }

    public static bool TdnBvqyZZGYZUQrr(android.net.NetworkCapabilities networkCapabilities, int i) {
        return networkCapabilities.hasCapability(i);
    }

    public readonly android.content.object Getobject() {
        return this.f5c18ef72;
    }

    public override p7ddcfee1.pd64ed3e9 Intercept(p7ddcfee1.p06050a91$p53205501 chain) throws p2b3583e6.p19ad2780.p4717d53e.p92dddbe2 {
        NdWTofNCxwWpBIYY(chain, "chain");
        DEvnSntGJQOydOjb(this);
        return bjTgFUDrEFCaUGRg(chain, BnnYGKXITpwyShqz(chain));
    }
}

