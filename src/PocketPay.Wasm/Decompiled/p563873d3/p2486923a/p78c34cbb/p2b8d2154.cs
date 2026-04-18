namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0006\u0010\u0006\u001a\u00020\u0007R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\b"}, d2 = {"Lp563873d3/p2486923a/p78c34cbb/p2b8d2154;", "Landroidx/lifecycle/objectModel;", "registrationRouter", "Lp563873d3/pfd9160bb/p4514631e;", "<init>", "(Lp563873d3/pfd9160bb/p4514631e;)V", "openPreviousScreen", "", "feature-registration-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p2b8d2154 : androidx.lifecycle.objectModel {
    private readonly p563873d3.pfd9160bb.p4514631e f2d0befea;
    private readonly p563873d3.pfd9160bb.p4514631e f90b2d3ea;
    private readonly p563873d3.pfd9160bb.p4514631e fc0d01293;
    private readonly p563873d3.pfd9160bb.p4514631e fedbbca6d;

    public p2b8d2154(p563873d3.pfd9160bb.p4514631e registrationRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(registrationRouter, "registrationRouter");
        this.f2d0befea = registrationRouter;
    }

    public readonly void OpenPreviousScreen() {
        this.f2d0befea.back();
    }
}

