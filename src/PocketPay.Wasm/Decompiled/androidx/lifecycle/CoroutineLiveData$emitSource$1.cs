namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 0, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.lifecycle.CoroutineLiveData", m533f = "CoroutineLiveData.kt", m534i = {0}, m535l = {219, 220}, m536m = "emitSource$lifecycle_livedata_release", m537n = {"source"}, m538s = {"L$0"})
readonly class CoroutineLiveData$emitSource$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly androidx.lifecycle.CoroutineLiveData<T> this$0;

    CoroutineLiveData$emitSource$1(androidx.lifecycle.CoroutineLiveData<T> coroutineLiveData, kotlin.coroutines.Continuation<? super androidx.lifecycle.CoroutineLiveData$emitSource$1> continuation) {
        super(continuation);
        this.this$0 = coroutineLiveData;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emitSource$lifecycle_livedata_release(null, this);
    }
}

