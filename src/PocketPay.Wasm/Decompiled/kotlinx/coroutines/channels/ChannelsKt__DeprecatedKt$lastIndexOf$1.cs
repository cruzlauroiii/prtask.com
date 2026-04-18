namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt", m533f = "Deprecated.kt", m534i = {0, 0, 0, 0}, m535l = {487}, m536m = "lastIndexOf", m537n = {"element", "lastIndex", "index", "$this$consume$iv$iv"}, m538s = {"L$0", "L$1", "L$2", "L$3"})
readonly class ChannelsKt__DeprecatedKt$lastIndexOf$1<E> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object L$4;
    int label;
    java.lang.object result;

    ChannelsKt__DeprecatedKt$lastIndexOf$1(kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$lastIndexOf$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.channels.ChannelsKt.LastIndexOf(null, null, this);
    }
}

