namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.DelayKt", m533f = "Delay.kt", m534i = {}, m535l = {163}, m536m = "awaitCancellation", m537n = {}, m538s = {})
readonly class DelayKt$awaitCancellation$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;

    DelayKt$awaitCancellation$1(kotlin.coroutines.Continuation<? super kotlinx.coroutines.DelayKt$awaitCancellation$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.DelayKt.awaitCancellation(this);
    }
}

