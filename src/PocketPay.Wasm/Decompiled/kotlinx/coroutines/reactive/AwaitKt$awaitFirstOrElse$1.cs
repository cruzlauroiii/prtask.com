namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.reactive.AwaitKt", m533f = "Await.kt", m534i = {0}, m535l = {56}, m536m = "awaitFirstOrElse", m537n = {"defaultValue"}, m538s = {"L$0"})
readonly class AwaitKt$awaitFirstOrElse$1<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;

    AwaitKt$awaitFirstOrElse$1(kotlin.coroutines.Continuation<? super kotlinx.coroutines.reactive.AwaitKt$awaitFirstOrElse$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.reactive.AwaitKt.awaitFirstOrElse(null, null, this);
    }
}

