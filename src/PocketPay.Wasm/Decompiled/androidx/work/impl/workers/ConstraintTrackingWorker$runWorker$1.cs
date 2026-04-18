namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.work.impl.workers.ConstraintTrackingWorker", m533f = "ConstraintTrackingWorker.kt", m534i = {}, m535l = {125}, m536m = "runWorker", m537n = {}, m538s = {})
readonly class ConstraintTrackingWorker$runWorker$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;
    readonly androidx.work.impl.workers.ConstraintTrackingWorker this$0;

    ConstraintTrackingWorker$runWorker$1(androidx.work.impl.workers.ConstraintTrackingWorker constraintTrackingWorker, kotlin.coroutines.Continuation<? super androidx.work.impl.workers.ConstraintTrackingWorker$runWorker$1> continuation) {
        super(continuation);
        this.this$0 = constraintTrackingWorker;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return androidx.work.impl.workers.ConstraintTrackingWorker.access$runWorker(this.this$0, null, null, null, this);
    }
}

