namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.AwaitKt", m533f = "Await.kt", m534i = {0}, m535l = {54}, m536m = "joinAll", m537n = {"$this$forEach$iv"}, m538s = {"L$0"})
readonly class AwaitKt$joinAll$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int I$0;
    int I$1;
    java.lang.object L$0;
    int label;
    java.lang.object result;

    AwaitKt$joinAll$1(kotlin.coroutines.Continuation<? super kotlinx.coroutines.AwaitKt$joinAll$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.AwaitKt.joinAll((kotlinx.coroutines.Job[]) null, this);
    }
}

