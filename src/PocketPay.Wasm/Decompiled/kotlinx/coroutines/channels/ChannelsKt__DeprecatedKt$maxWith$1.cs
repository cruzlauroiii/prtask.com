namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt", m533f = "Deprecated.kt", m534i = {0, 0, 0, 1, 1, 1, 1}, m535l = {420, 422}, m536m = "maxWith", m537n = {"comparator", "$this$consume$iv", "iterator", "comparator", "$this$consume$iv", "iterator", "max"}, m538s = {"L$0", "L$1", "L$2", "L$0", "L$1", "L$2", "L$3"})
readonly class ChannelsKt__DeprecatedKt$maxWith$1<E> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    int label;
    java.lang.object result;

    ChannelsKt__DeprecatedKt$maxWith$1(kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$maxWith$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.channels.ChannelsKt.maxWith(null, null, this);
    }
}

