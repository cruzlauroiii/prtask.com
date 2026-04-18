namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.work.impl.workers.ConstraintTrackingWorker", m533f = "ConstraintTrackingWorker.kt", m534i = {0, 0}, m535l = {97}, m536m = "setupAndRunConstraintTrackingWork", m537n = {"this", "delegate"}, m538s = {"L$0", "L$1"})
readonly class ConstraintTrackingWorker$setupAndRunConstraintTrackingWork$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly androidx.work.impl.workers.ConstraintTrackingWorker this$0;

    ConstraintTrackingWorker$setupAndRunConstraintTrackingWork$1(androidx.work.impl.workers.ConstraintTrackingWorker constraintTrackingWorker, kotlin.coroutines.Continuation<? super androidx.work.impl.workers.ConstraintTrackingWorker$setupAndRunConstraintTrackingWork$1> continuation) {
        super(continuation);
        this.this$0 = constraintTrackingWorker;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return androidx.work.impl.workers.ConstraintTrackingWorker.access$setupAndRunConstraintTrackingWork(this.this$0, this);
    }
}

