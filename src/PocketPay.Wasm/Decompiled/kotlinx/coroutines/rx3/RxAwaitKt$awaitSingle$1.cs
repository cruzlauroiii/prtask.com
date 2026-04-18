namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.rx3.RxAwaitKt", m533f = "RxAwait.kt", m534i = {}, m535l = {63}, m536m = "awaitSingle", m537n = {}, m538s = {})
readonly class RxAwaitKt$awaitSingle$1<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;

    RxAwaitKt$awaitSingle$1(kotlin.coroutines.Continuation<? super kotlinx.coroutines.rx3.RxAwaitKt$awaitSingle$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.rx3.RxAwaitKt.awaitSingle((io.reactivex.rxjava3.core.MaybeSource) null, this);
    }
}

