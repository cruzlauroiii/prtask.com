namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 0, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.lifecycle.CoroutineLiveData", m533f = "CoroutineLiveData.kt", m534i = {}, m535l = {226}, m536m = "clearSource$lifecycle_livedata_release", m537n = {}, m538s = {})
readonly class CoroutineLiveData$clearSource$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;
    readonly androidx.lifecycle.CoroutineLiveData<T> this$0;

    CoroutineLiveData$clearSource$1(androidx.lifecycle.CoroutineLiveData<T> coroutineLiveData, kotlin.coroutines.Continuation<? super androidx.lifecycle.CoroutineLiveData$clearSource$1> continuation) {
        super(continuation);
        this.this$0 = coroutineLiveData;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.clearSource$lifecycle_livedata_release(this);
    }
}

