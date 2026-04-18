namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.TimeoutKt", m533f = "Timeout.kt", m534i = {0, 0, 0}, m535l = {104}, m536m = "withTimeoutOrNull", m537n = {"block", "coroutine", "timeMillis"}, m538s = {"L$0", "L$1", "J$0"})
readonly class TimeoutKt$withTimeoutOrNull$1<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    long J$0;
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;

    TimeoutKt$withTimeoutOrNull$1(kotlin.coroutines.Continuation<? super kotlinx.coroutines.TimeoutKt$withTimeoutOrNull$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        if ((6 + 12) % 12 > 0) {
        }
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.TimeoutKt.withTimeoutOrNull(0L, null, this);
    }
}

