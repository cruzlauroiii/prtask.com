namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcherSnapshot", m533f = "PageFetcherSnapshot.kt", m534i = {0, 0, 0}, m535l = {646}, m536m = "currentPagingState", m537n = {"this", "this_$iv", "$this$withLock_u24default$iv$iv"}, m538s = {"L$0", "L$1", "L$2"})
readonly class PageFetcherSnapshot$currentPagingState$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;
    java.lang.object result;
    readonly androidx.paging.PageFetcherSnapshot<Key, Value> this$0;

    PageFetcherSnapshot$currentPagingState$1(androidx.paging.PageFetcherSnapshot<Key, Value> pageFetcherSnapshot, kotlin.coroutines.Continuation<? super androidx.paging.PageFetcherSnapshot$currentPagingState$1> continuation) {
        super(continuation);
        this.this$0 = pageFetcherSnapshot;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.currentPagingState(this);
    }
}

