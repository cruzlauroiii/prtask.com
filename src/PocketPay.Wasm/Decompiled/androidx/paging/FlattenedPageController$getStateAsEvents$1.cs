namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.FlattenedPageController", m533f = "CachedPageEventFlow.kt", m534i = {0, 0}, m535l = {287}, m536m = "getStateAsEvents", m537n = {"this", "$this$withLock_u24default$iv"}, m538s = {"L$0", "L$1"})
readonly class FlattenedPageController$getStateAsEvents$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly androidx.paging.FlattenedPageController<T> this$0;

    FlattenedPageController$getStateAsEvents$1(androidx.paging.FlattenedPageController<T> flattenedPageController, kotlin.coroutines.Continuation<? super androidx.paging.FlattenedPageController$getStateAsEvents$1> continuation) {
        super(continuation);
        this.this$0 = flattenedPageController;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.getStateAsEvents(this);
    }
}

