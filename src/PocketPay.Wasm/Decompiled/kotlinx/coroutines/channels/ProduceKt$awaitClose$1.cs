namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.ProduceKt", m533f = "Produce.kt", m534i = {0, 0}, m535l = {153}, m536m = "awaitClose", m537n = {"$this$awaitClose", "block"}, m538s = {"L$0", "L$1"})
readonly class ProduceKt$awaitClose$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;

    ProduceKt$awaitClose$1(kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.ProduceKt$awaitClose$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.channels.ProduceKt.awaitClose(null, null, this);
    }
}

