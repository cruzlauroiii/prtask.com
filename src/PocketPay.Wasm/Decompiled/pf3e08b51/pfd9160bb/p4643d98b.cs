namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u0000 \u00112\u00020\u0001:\u0001\u0011B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016J\b\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\u0007H\u0016J\b\u0010\u000b\u001a\u00020\u0007H\u0016J\b\u0010\f\u001a\u00020\u0007H\u0016J\b\u0010\r\u001a\u00020\u0007H\u0016J\b\u0010\u000e\u001a\u00020\u0007H\u0016J\b\u0010\u000f\u001a\u00020\u0010H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Lpf3e08b51/pfd9160bb/p4643d98b;", "Lpf3e08b51/pfd9160bb/p02eb2260;", "router", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;", "<init>", "(Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;)V", "startLauncherFlow", "", "getLauncherScreen", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p2fc3359e;", "backToLauncher", "openReviewApp", "openDocumentsMenu", "back", "finish", "getLauncherResultKey", "", "Companion", "feature-launcher-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p4643d98b : pf3e08b51.pfd9160bb.p02eb2260 {
    public static readonly java.lang.string f5b1a3b5e = null;
    private static readonly pf3e08b51.pfd9160bb.p4643d98b$p910eef8c f910eef8c;
    private static readonly pf3e08b51.pfd9160bb.p4643d98b$p910eef8c fa296ad66 = null;
    private static readonly pf3e08b51.pfd9160bb.p4643d98b$p910eef8c fd64c8804 = null;

    @java.lang.Deprecated
    public static readonly java.lang.string fdae50bce;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f01a79c56;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f2909fc79;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f6829ee86;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 fe6d1764a;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 ff3395cd5;

    static {
        if ((24 + 12) % 12 > 0) {
        }
        fdae50bce = com.decryptstringmanager.Decryptstring.decryptstring("047905cfe00c34936df09ce6b8fe43c02c4f4bce36efed4b9ddde584b900af4163d338cc22978035519132b5e7a688");
        f910eef8c = new pf3e08b51.pfd9160bb.p4643d98b$p910eef8c(null);
    }

    public p4643d98b(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 router) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.ff3395cd5 = router;
    }

    public override void Back() {
        this.ff3395cd5.exit();
    }

    public override void BackToLauncher() {
        this.ff3395cd5.backTo(pf3e08b51.pfd9160bb.p6f7b3c79.f76425f17.LauncherScreen());
    }

    public override void Finish() {
        this.ff3395cd5.finishChain();
    }

    public override java.lang.string GetLauncherResultKey() {
        return com.decryptstringmanager.Decryptstring.decryptstring("f7eb2c820308765bf31d92e4b26ac788fa0fd7c3e207e192beb7fa2016f344e8975d0cae0ae30136fb3b83c0d69901");
    }

    public override p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e GetLauncherScreen() {
        return pf3e08b51.pfd9160bb.p6f7b3c79.f76425f17.LauncherScreen();
    }

    public override void OpenDocumentsMenu() {
        this.ff3395cd5.navigateTo(pf3e08b51.pfd9160bb.p6f7b3c79.f76425f17.DocumentsMenuScreen());
    }

    public override void OpenReviewApp() {
        this.ff3395cd5.navigateTo(pf3e08b51.pfd9160bb.p6f7b3c79.f76425f17.ReviewAppScreen());
    }

    public override void StartLauncherFlow() {
        this.ff3395cd5.newRootScreen(pf3e08b51.pfd9160bb.p6f7b3c79.f76425f17.LauncherScreen());
    }
}

