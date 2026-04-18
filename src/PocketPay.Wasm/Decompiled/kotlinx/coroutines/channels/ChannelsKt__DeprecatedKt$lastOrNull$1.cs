namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt", m533f = "Deprecated.kt", m534i = {0, 0, 1, 1, 1}, m535l = {123, 126}, m536m = "lastOrNull", m537n = {"$this$consume$iv", "iterator", "$this$consume$iv", "iterator", "last"}, m538s = {"L$0", "L$1", "L$0", "L$1", "L$2"})
readonly class ChannelsKt__DeprecatedKt$lastOrNull$1<E> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;
    java.lang.object result;

    ChannelsKt__DeprecatedKt$lastOrNull$1(kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$lastOrNull$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.channels.ChannelsKt.lastOrNull(null, this);
    }
}

