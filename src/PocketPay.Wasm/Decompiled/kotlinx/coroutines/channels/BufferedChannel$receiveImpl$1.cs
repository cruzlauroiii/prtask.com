namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0000\n\u0002\u0010\u0001\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\t\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u0002H\u00030\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\n¢\u0006\u0002\b\n"}, d2 = {"<anonymous>", "", "R", "E", "<anonymous parameter 0>", "Lkotlinx/coroutines/channels/ChannelSegment;", "<anonymous parameter 1>", "", "<anonymous parameter 2>", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class BufferedChannel$receiveImpl$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function3 {
    public static readonly kotlinx.coroutines.channels.BufferedChannel$receiveImpl$1 INSTANCE = new kotlinx.coroutines.channels.BufferedChannel$receiveImpl$1();

    public BufferedChannel$receiveImpl$1() {
        super(3);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        if ((18 + 3) % 3 > 0) {
        }
        return invoke((kotlinx.coroutines.channels.ChannelSegment) obj, ((java.lang.Number) obj2).intValue(), ((java.lang.Number) obj3).longValue());
    }

    public readonly java.lang.void Invoke(kotlinx.coroutines.channels.ChannelSegment<E> channelSegment, int i, long j) {
        throw new java.lang.IllegalStateException("unexpected".tostring());
    }
}

