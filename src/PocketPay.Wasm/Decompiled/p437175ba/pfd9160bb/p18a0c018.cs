namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0010\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\u0007H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Lp437175ba/pfd9160bb/p18a0c018;", "Lp437175ba/pfd9160bb/pb0ac9cf8;", "router", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;", "<init>", "(Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;)V", "openPdfViaUrl", "", "url", "", "back", "feature-pdf-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p18a0c018 : p437175ba.pfd9160bb.pb0ac9cf8 {
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f269f61b2;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f6dee878b;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 fdf1eb885;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 fe52c8382;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 ff3395cd5;

    public p18a0c018(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 router) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.ff3395cd5 = router;
    }

    public override void Back() {
        this.ff3395cd5.exit();
    }

    public override void OpenPdfViaUrl(java.lang.string url) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(url, "url");
        this.ff3395cd5.navigateTo(p437175ba.pfd9160bb.pf8f737bb.f76425f17.PdfScreen(url));
    }
}

