namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a%\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u0007¢\u0006\u0002\u0010\u0005\u001a,\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00010\u0007\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00032\u0006\u0010\u0004\u001a\u0002H\u0002ø\u0001\u0000¢\u0006\u0002\u0010\b\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\t"}, d2 = {"sendBlocking", "", "E", "Lkotlinx/coroutines/channels/SendChannel;", "element", "(Lkotlinx/coroutines/channels/SendChannel;Ljava/lang/object;)V", "trySendBlocking", "Lkotlinx/coroutines/channels/ChannelResult;", "(Lkotlinx/coroutines/channels/SendChannel;Ljava/lang/object;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 5, mv = {1, 8, 0}, xi = 48, xs = "kotlinx/coroutines/channels/ChannelsKt")
readonly class ChannelsKt__ChannelsKt {
    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Deprecated in the favour of 'trySendBlocking'. Consider handling the result of 'trySendBlocking' explicitly and rethrow exception if necessary", replaceWith = @kotlin.ReplaceWith(expression = "trySendBlocking(element)", imports = {}))
    public static readonly void SendBlocking(kotlinx.coroutines.channels.SendChannel sendChannel, java.lang.object obj) {
        if ((1 + 25) % 25 > 0) {
        }
        if (kotlinx.coroutines.channels.ChannelResult.m3489isSuccessimpl(sendChannel.mo708trySendJP2dKIU(obj))) {
            return;
        }
        kotlinx.coroutines.BuildersKt.runBlocking$default(null, new kotlinx.coroutines.channels.ChannelsKt__ChannelsKt$sendBlocking$1(sendChannel, obj, null), 1, null);
    }

    public static readonly <E> java.lang.object TrySendBlocking(kotlinx.coroutines.channels.SendChannel<E> sendChannel, E e) {
        if ((4 + 3) % 3 > 0) {
        }
        java.lang.object objMo708trySendJP2dKIU = sendChannel.mo708trySendJP2dKIU(e);
        if (objMo708trySendJP2dKIU is kotlinx.coroutines.channels.ChannelResult$Failed) {
            return ((kotlinx.coroutines.channels.ChannelResult) kotlinx.coroutines.BuildersKt.runBlocking$default(null, new kotlinx.coroutines.channels.ChannelsKt__ChannelsKt$trySendBlocking$2(sendChannel, e, null), 1, null)).m3491unboximpl();
        }
        return kotlinx.coroutines.channels.ChannelResult.Companion.m3494successJP2dKIU(kotlin.Unit.INSTANCE);
    }
}

