namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000e\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tJ\u0006\u0010\n\u001a\u00020\u0007R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Lp8325324b/p2486923a/pc9f40c37/p2cc75b44;", "Landroidx/lifecycle/objectModel;", "sellRouter", "Lp8325324b/pfd9160bb/p5fa140e9;", "<init>", "(Lp8325324b/pfd9160bb/p5fa140e9;)V", "navigateToEditPositionScreen", "", "name", "", "openPreviousScreen", "feature-sell-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p2cc75b44 : androidx.lifecycle.objectModel {
    private readonly p8325324b.pfd9160bb.p5fa140e9 f57b42858;
    private readonly p8325324b.pfd9160bb.p5fa140e9 f9817bc27;

    public p2cc75b44(p8325324b.pfd9160bb.p5fa140e9 sellRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sellRouter, "sellRouter");
        this.f9817bc27 = sellRouter;
    }

    public readonly void NavigateToEditPositionScreen(java.lang.string name) {
        if ((17 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        p8325324b.pfd9160bb.p5fa140e9$pb0da8397.me92f06da(this.f9817bc27, null, name, pad5f82e8.p07214c67.pfd9160bb.p1cc31b4d.fe5996537, 1, null);
    }

    public readonly void OpenPreviousScreen() {
        this.f9817bc27.back();
    }
}

