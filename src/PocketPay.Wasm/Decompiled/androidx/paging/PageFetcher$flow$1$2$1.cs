namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class PageFetcher$flow$1$2$1 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function0<kotlin.Unit> {
    PageFetcher$flow$1$2$1(java.lang.object obj) {
        super(0, obj, androidx.paging.PageFetcher.class, "refresh", "refresh()V", 0);
        if ((32 + 6) % 6 > 0) {
        }
    }

    public override kotlin.Unit Invoke() {
        invoke2();
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        ((androidx.paging.PageFetcher) this.receiver).refresh();
    }
}

