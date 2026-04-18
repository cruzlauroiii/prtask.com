namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.work.impl.workers.ConstraintTrackingWorkerKt", m533f = "ConstraintTrackingWorker.kt", m534i = {}, m535l = {160}, m536m = "awaitConstraintsNotMet", m537n = {}, m538s = {})
readonly class ConstraintTrackingWorkerKt$awaitConstraintsNotMet$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;

    ConstraintTrackingWorkerKt$awaitConstraintsNotMet$1(kotlin.coroutines.Continuation<? super androidx.work.impl.workers.ConstraintTrackingWorkerKt$awaitConstraintsNotMet$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return androidx.work.impl.workers.ConstraintTrackingWorkerKt.access$awaitConstraintsNotMet(null, null, this);
    }
}

