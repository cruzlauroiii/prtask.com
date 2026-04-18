namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.CachedPageEventFlow$downstreamFlow$1$2", m533f = "CachedPageEventFlow.kt", m534i = {0, 0}, m535l = {105}, m536m = "emit", m537n = {"this", "indexedValue"}, m538s = {"L$0", "L$1"})
readonly class CachedPageEventFlow$downstreamFlow$1$2$emit$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly androidx.paging.CachedPageEventFlow$downstreamFlow$1$2<T> this$0;

    CachedPageEventFlow$downstreamFlow$1$2$emit$1(androidx.paging.CachedPageEventFlow$downstreamFlow$1$2<T> cachedPageEventFlow$downstreamFlow$1$2, kotlin.coroutines.Continuation<? super androidx.paging.CachedPageEventFlow$downstreamFlow$1$2$emit$1> continuation) {
        super(continuation);
        this.this$0 = cachedPageEventFlow$downstreamFlow$1$2;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit((kotlin.collections.IndexedValue) null, (kotlin.coroutines.Continuation<kotlin.Unit>) this);
    }
}

