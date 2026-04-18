namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.sync.MutexKt", m533f = "Mutex.kt", m534i = {0, 0, 0}, m535l = {125}, m536m = "withLock", m537n = {"$this$withLock", "owner", "action"}, m538s = {"L$0", "L$1", "L$2"})
readonly class MutexKt$withLock$1<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;
    java.lang.object result;

    MutexKt$withLock$1(kotlin.coroutines.Continuation<? super kotlinx.coroutines.sync.MutexKt$withLock$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.sync.MutexKt.withLock(null, null, null, this);
    }
}

