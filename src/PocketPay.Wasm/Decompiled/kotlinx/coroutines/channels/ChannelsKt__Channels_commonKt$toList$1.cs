namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt", m533f = "Channels.common.kt", m534i = {0, 0}, m535l = {149}, m536m = "toList", m537n = {"$this$toList_u24lambda_u243", "$this$consume$iv$iv"}, m538s = {"L$1", "L$2"})
readonly class ChannelsKt__Channels_commonKt$toList$1<E> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    int label;
    java.lang.object result;

    ChannelsKt__Channels_commonKt$toList$1(kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt$toList$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.channels.ChannelsKt.toList(null, this);
    }
}

