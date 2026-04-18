namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016J\b\u0010\b\u001a\u00020\u0007H\u0016J\b\u0010\t\u001a\u00020\u0007H\u0016J\b\u0010\n\u001a\u00020\u0007H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Lp1b856234/pf83c2a85/pfd9160bb/p7091e5bf;", "Lp1b856234/pf83c2a85/pfd9160bb/padac6c63;", "router", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;", "<init>", "(Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;)V", "replaceSellElectronPayment", "", "openSellElectronPayment", "replacePaybackElectronPayment", "back", "feature-electron-payment-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p7091e5bf : p1b856234.pf83c2a85.pfd9160bb.padac6c63 {
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 ff3395cd5;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 ffd51d586;

    public p7091e5bf(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 p9cd72ef0Var) {
        VlwwiDEPdVmQcXxp(p9cd72ef0Var, "router");
        this.ff3395cd5 = p9cd72ef0Var;
    }

    public static p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p576f3918.p00595b14 HhVIQLVkBttFAmCX(p1b856234.pf83c2a85.pfd9160bb.p1c52a133 p1c52a133Var) {
        return p1c52a133Var.SellElectronScreen();
    }

    public static void VlwwiDEPdVmQcXxp(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p576f3918.p00595b14 XIpgEMYnZggLezZz(p1b856234.pf83c2a85.pfd9160bb.p1c52a133 p1c52a133Var) {
        return p1c52a133Var.PaybackElectronScreen();
    }

    public static void CglcUUDSSHGyKXeM(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 p9cd72ef0Var, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e p2fc3359eVar) {
        p9cd72ef0Var.replaceScreen(p2fc3359eVar);
    }

    public static void DuGkfoqfeVYcmFJr(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 p9cd72ef0Var, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e p2fc3359eVar) {
        p9cd72ef0Var.navigateTo(p2fc3359eVar);
    }

    public static void FPoYgYDwnJTLcJdF(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 p9cd72ef0Var, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e p2fc3359eVar) {
        p9cd72ef0Var.replaceScreen(p2fc3359eVar);
    }

    public static p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p576f3918.p00595b14 MJlvOrupqJVUxIBv(p1b856234.pf83c2a85.pfd9160bb.p1c52a133 p1c52a133Var) {
        return p1c52a133Var.SellElectronScreen();
    }

    public static void OOXwMStyJwMFlaJl(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 p9cd72ef0Var) {
        p9cd72ef0Var.exit();
    }

    public override void Back() {
        oOXwMStyJwMFlaJl(this.ff3395cd5);
    }

    public override void OpenSellElectronPayment() {
        duGkfoqfeVYcmFJr(this.ff3395cd5, HhVIQLVkBttFAmCX(p1b856234.pf83c2a85.pfd9160bb.p1c52a133.f76425f17));
    }

    public override void ReplacePaybackElectronPayment() {
        cglcUUDSSHGyKXeM(this.ff3395cd5, XIpgEMYnZggLezZz(p1b856234.pf83c2a85.pfd9160bb.p1c52a133.f76425f17));
    }

    public override void ReplaceSellElectronPayment() {
        fPoYgYDwnJTLcJdF(this.ff3395cd5, mJlvOrupqJVUxIBv(p1b856234.pf83c2a85.pfd9160bb.p1c52a133.f76425f17));
    }
}

