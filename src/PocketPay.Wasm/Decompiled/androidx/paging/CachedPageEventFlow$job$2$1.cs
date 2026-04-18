namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0003\n\u0000\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\n¢\u0006\u0002\b\u0006"}, d2 = {"<anonymous>", "", "T", "", "it", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class CachedPageEventFlow$job$2$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> {
    readonly androidx.paging.CachedPageEventFlow<T> this$0;

    CachedPageEventFlow$job$2$1(androidx.paging.CachedPageEventFlow<T> cachedPageEventFlow) {
        super(1);
        this.this$0 = cachedPageEventFlow;
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        invoke2(th);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th) {
        androidx.paging.CachedPageEventFlow.access$getMutableSharedSrc$p(this.this$0).tryEmit(null);
    }
}

