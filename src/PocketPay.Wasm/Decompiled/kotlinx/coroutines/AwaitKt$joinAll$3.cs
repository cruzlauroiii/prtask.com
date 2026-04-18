namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.AwaitKt", m533f = "Await.kt", m534i = {}, m535l = {66}, m536m = "joinAll", m537n = {}, m538s = {})
readonly class AwaitKt$joinAll$3 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;

    AwaitKt$joinAll$3(kotlin.coroutines.Continuation<? super kotlinx.coroutines.AwaitKt$joinAll$3> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.AwaitKt.joinAll((java.util.ICollection<? : kotlinx.coroutines.Job>) null, this);
    }
}

