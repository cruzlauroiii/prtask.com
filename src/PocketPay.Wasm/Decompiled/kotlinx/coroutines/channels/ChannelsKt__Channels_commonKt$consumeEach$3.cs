namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt", m533f = "Channels.common.kt", m534i = {0, 0}, m535l = {130}, m536m = "consumeEach", m537n = {"action", "channel$iv"}, m538s = {"L$0", "L$1"})
readonly class ChannelsKt__Channels_commonKt$consumeEach$3<E> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;
    java.lang.object result;

    ChannelsKt__Channels_commonKt$consumeEach$3(kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt$consumeEach$3> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.channels.ChannelsKt__Channels_commonKt.consumeEach((kotlinx.coroutines.channels.BroadcastChannel) null, (kotlin.jvm.functions.Function1) null, this);
    }
}

