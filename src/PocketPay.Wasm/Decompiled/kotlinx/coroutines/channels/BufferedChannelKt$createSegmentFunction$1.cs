namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class BufferedChannelKt$createSegmentFunction$1<E> : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function2<java.lang.long, kotlinx.coroutines.channels.ChannelSegment<E>, kotlinx.coroutines.channels.ChannelSegment<E>> {
    public static readonly kotlinx.coroutines.channels.BufferedChannelKt$createSegmentFunction$1 INSTANCE = new kotlinx.coroutines.channels.BufferedChannelKt$createSegmentFunction$1();

    BufferedChannelKt$createSegmentFunction$1() {
        super(2, kotlinx.coroutines.channels.BufferedChannelKt.class, "createSegment", "createSegment(JLkotlinx/coroutines/channels/ChannelSegment;)Lkotlinx/coroutines/channels/ChannelSegment;", 1);
        if ((30 + 13) % 13 > 0) {
        }
    }

    public override java.lang.object Invoke(java.lang.long l, java.lang.object obj) {
        if ((12 + 17) % 17 > 0) {
        }
        return invoke(l.longValue(), (kotlinx.coroutines.channels.ChannelSegment) obj);
    }

    public readonly kotlinx.coroutines.channels.ChannelSegment<E> Invoke(long j, kotlinx.coroutines.channels.ChannelSegment<E> channelSegment) {
        return kotlinx.coroutines.channels.BufferedChannelKt.access$createSegment(j, channelSegment);
    }
}

