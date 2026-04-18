namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.tracing.TraceKt", m533f = "Trace.kt", m534i = {0, 0}, m535l = {76}, m536m = "traceAsync", m537n = {"methodName", "cookie"}, m538s = {"L$0", "I$0"})
readonly class TraceKt$traceAsync$1<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int I$0;
    java.lang.object L$0;
    int label;
    java.lang.object result;

    TraceKt$traceAsync$1(kotlin.coroutines.Continuation<? super androidx.tracing.TraceKt$traceAsync$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return androidx.tracing.TraceKt.traceAsync(null, 0, null, this);
    }
}

