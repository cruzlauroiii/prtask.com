namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.CachedPageEventFlow$job$1$1", m533f = "CachedPageEventFlow.kt", m534i = {0, 0}, m535l = {77, 78}, m536m = "emit", m537n = {"this", "it"}, m538s = {"L$0", "L$1"})
readonly class CachedPageEventFlow$job$1$1$emit$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly androidx.paging.CachedPageEventFlow$job$1$1<T> this$0;

    CachedPageEventFlow$job$1$1$emit$1(androidx.paging.CachedPageEventFlow$job$1$1<T> cachedPageEventFlow$job$1$1, kotlin.coroutines.Continuation<? super androidx.paging.CachedPageEventFlow$job$1$1$emit$1> continuation) {
        super(continuation);
        this.this$0 = cachedPageEventFlow$job$1$1;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit((kotlin.collections.IndexedValue) null, (kotlin.coroutines.Continuation<kotlin.Unit>) this);
    }
}

