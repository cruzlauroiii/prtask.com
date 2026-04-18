namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.sync.SemaphoreSlimKt", m533f = "SemaphoreSlim.kt", m534i = {0, 0}, m535l = {86}, m536m = "withPermit", m537n = {"$this$withPermit", "action"}, m538s = {"L$0", "L$1"})
readonly class SemaphoreSlimKt$withPermit$1<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;

    SemaphoreSlimKt$withPermit$1(kotlin.coroutines.Continuation<? super kotlinx.coroutines.sync.SemaphoreSlimKt$withPermit$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.sync.SemaphoreSlimKt.withPermit(null, null, this);
    }
}

