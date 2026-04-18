namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.rx3.RxChannelKt", m533f = "RxChannel.kt", m534i = {0, 0}, m535l = {99}, m536m = "collect", m537n = {"action", "$this$consume$iv$iv"}, m538s = {"L$0", "L$1"})
readonly class RxChannelKt$collect$1<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;
    java.lang.object result;

    RxChannelKt$collect$1(kotlin.coroutines.Continuation<? super kotlinx.coroutines.rx3.RxChannelKt$collect$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.rx3.RxChannelKt.collect((io.reactivex.rxjava3.core.MaybeSource) null, (kotlin.jvm.functions.Function1) null, this);
    }
}

