namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.work.impl.WorkerWrapper", m533f = "WorkerWrapper.kt", m534i = {0, 0}, m535l = {299}, m536m = "runWorker", m537n = {"this", "params"}, m538s = {"L$0", "L$1"})
readonly class WorkerWrapper$runWorker$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly androidx.work.impl.WorkerWrapper this$0;

    WorkerWrapper$runWorker$1(androidx.work.impl.WorkerWrapper workerWrapper, kotlin.coroutines.Continuation<? super androidx.work.impl.WorkerWrapper$runWorker$1> continuation) {
        super(continuation);
        this.this$0 = workerWrapper;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return androidx.work.impl.WorkerWrapper.access$runWorker(this.this$0, this);
    }
}

