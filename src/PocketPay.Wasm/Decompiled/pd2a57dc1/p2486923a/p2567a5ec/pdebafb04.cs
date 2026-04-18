namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000e\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Lpd2a57dc1/p2486923a/p2567a5ec/pdebafb04;", "Landroidx/lifecycle/objectModel;", "webRouter", "Lp2567a5ec/pfd9160bb/pc1bedd57;", "<init>", "(Lp2567a5ec/pfd9160bb/pc1bedd57;)V", "getWebobjectobject", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p2fc3359e;", "url", "", "feature-app-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pdebafb04 : androidx.lifecycle.objectModel {
    private readonly p2567a5ec.pfd9160bb.pc1bedd57 f2bcd38e4;
    private readonly p2567a5ec.pfd9160bb.pc1bedd57 f322b5cb2;
    private readonly p2567a5ec.pfd9160bb.pc1bedd57 fc4135f41;
    private readonly p2567a5ec.pfd9160bb.pc1bedd57 ffd480077;

    public pdebafb04(p2567a5ec.pfd9160bb.pc1bedd57 webRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(webRouter, "webRouter");
        this.ffd480077 = webRouter;
    }

    public readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e GetWebobjectobject(java.lang.string url) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(url, "url");
        return this.ffd480077.getWebobjectScreen(url);
    }
}

