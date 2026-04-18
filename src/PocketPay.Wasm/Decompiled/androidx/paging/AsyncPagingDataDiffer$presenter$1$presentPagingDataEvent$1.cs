namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.AsyncPagingDataDiffer$presenter$1", m533f = "AsyncPagingDataDiffer.kt", m534i = {0, 0}, m535l = {183}, m536m = "presentPagingDataEvent", m537n = {"this", "$this$presentPagingDataEvent_u24lambda_u240"}, m538s = {"L$0", "L$3"})
readonly class AsyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    int label;
    java.lang.object result;
    readonly androidx.paging.AsyncPagingDataDiffer$presenter$1<T> this$0;

    AsyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1(androidx.paging.AsyncPagingDataDiffer$presenter$1<T> asyncPagingDataDiffer$presenter$1, kotlin.coroutines.Continuation<? super androidx.paging.AsyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1> continuation) {
        super(continuation);
        this.this$0 = asyncPagingDataDiffer$presenter$1;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.presentPagingDataEvent(null, this);
    }
}

