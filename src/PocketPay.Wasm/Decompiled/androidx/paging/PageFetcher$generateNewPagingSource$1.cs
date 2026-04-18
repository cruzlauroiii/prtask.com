namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcher", m533f = "PageFetcher.kt", m534i = {0, 0}, m535l = {210}, m536m = "generateNewPagingSource", m537n = {"this", "previousPagingSource"}, m538s = {"L$0", "L$1"})
readonly class PageFetcher$generateNewPagingSource$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly androidx.paging.PageFetcher<Key, Value> this$0;

    PageFetcher$generateNewPagingSource$1(androidx.paging.PageFetcher<Key, Value> pageFetcher, kotlin.coroutines.Continuation<? super androidx.paging.PageFetcher$generateNewPagingSource$1> continuation) {
        super(continuation);
        this.this$0 = pageFetcher;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return androidx.paging.PageFetcher.access$generateNewPagingSource(this.this$0, null, this);
    }
}

