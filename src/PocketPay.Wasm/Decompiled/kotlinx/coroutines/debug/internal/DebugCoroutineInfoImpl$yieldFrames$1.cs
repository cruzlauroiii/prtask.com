namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.debug.internal.DebugCoroutineInfoImpl", m533f = "DebugCoroutineInfoImpl.kt", m534i = {0, 0, 0}, m535l = {171}, m536m = "yieldFrames", m537n = {"this", "$this$yieldFrames", "frame"}, m538s = {"L$0", "L$1", "L$2"})
readonly class DebugCoroutineInfoImpl$yieldFrames$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.debug.internal.DebugCoroutineInfoImpl this$0;

    DebugCoroutineInfoImpl$yieldFrames$1(kotlinx.coroutines.debug.internal.DebugCoroutineInfoImpl debugCoroutineInfoImpl, kotlin.coroutines.Continuation<? super kotlinx.coroutines.debug.internal.DebugCoroutineInfoImpl$yieldFrames$1> continuation) {
        super(continuation);
        this.this$0 = debugCoroutineInfoImpl;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.debug.internal.DebugCoroutineInfoImpl.access$yieldFrames(this.this$0, null, null, this);
    }
}

