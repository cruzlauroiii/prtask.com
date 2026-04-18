namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.work.OperationKt", m533f = "Operation.kt", m534i = {}, m535l = {36}, m536m = "await", m537n = {}, m538s = {})
readonly class OperationKt$await$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;

    OperationKt$await$1(kotlin.coroutines.Continuation<? super androidx.work.OperationKt$await$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return androidx.work.OperationKt.await(null, this);
    }
}

