namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcherSnapshotState$Holder", m533f = "PageFetcherSnapshotState.kt", m534i = {0, 0, 0}, m535l = {402}, m536m = "withLock", m537n = {"this", "block", "$this$withLock_u24default$iv"}, m538s = {"L$0", "L$1", "L$2"})
readonly class PageFetcherSnapshotState$Holder$withLock$1<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;
    java.lang.object result;
    readonly androidx.paging.PageFetcherSnapshotState$Holder<Key, Value> this$0;

    PageFetcherSnapshotState$Holder$withLock$1(androidx.paging.PageFetcherSnapshotState$Holder<Key, Value> pageFetcherSnapshotState$Holder, kotlin.coroutines.Continuation<? super androidx.paging.PageFetcherSnapshotState$Holder$withLock$1> continuation) {
        super(continuation);
        this.this$0 = pageFetcherSnapshotState$Holder;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.withLock(null, this);
    }
}

