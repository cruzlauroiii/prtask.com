namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.work.impl.workers.ConstraintTrackingWorkerKt$awaitConstraintsNotMet$$inlined$filterIsInstance$1$2", m533f = "ConstraintTrackingWorker.kt", m534i = {}, m535l = {223}, m536m = "emit", m537n = {}, m538s = {})
public readonly class C0242xdb58eeaa : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly androidx.work.impl.workers.C0241xf5d6cd5d this$0;

    public C0242xdb58eeaa(androidx.work.impl.workers.C0241xf5d6cd5d c0241xf5d6cd5d, kotlin.coroutines.Continuation continuation) {
        super(continuation);
        this.this$0 = c0241xf5d6cd5d;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

