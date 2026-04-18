namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.AsyncPagingDataDiffer$special$$inlined$transform$1$1", m533f = "AsyncPagingDataDiffer.kt", m534i = {0, 0, 0, 1, 1}, m535l = {224, 225, 229}, m536m = "emit", m537n = {"this", "it", "$this$loadStateFlow_u24lambda_u242", "it", "$this$loadStateFlow_u24lambda_u242"}, m538s = {"L$0", "L$1", "L$2", "L$0", "L$1"})
public readonly class AsyncPagingDataDiffer$special$$inlined$transform$1$1$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;
    java.lang.object result;
    readonly androidx.paging.AsyncPagingDataDiffer$special$$inlined$transform$1$1 this$0;

    public AsyncPagingDataDiffer$special$$inlined$transform$1$1$1(androidx.paging.AsyncPagingDataDiffer$special$$inlined$transform$1$1 asyncPagingDataDiffer$special$$inlined$transform$1$1, kotlin.coroutines.Continuation continuation) {
        super(continuation);
        this.this$0 = asyncPagingDataDiffer$special$$inlined$transform$1$1;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

