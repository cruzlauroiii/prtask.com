namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class Channel$DefaultImpls {
    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Since 1.2.0, binary compatibility with versions <= 1.1.x")
    public static void Cancel(kotlinx.coroutines.channels.Channel channel) {
        kotlinx.coroutines.channels.ReceiveChannel$DefaultImpls.cancel(channel);
    }

    public static <E> kotlinx.coroutines.selects.SelectClause1<E> GetOnReceiveOrNull(kotlinx.coroutines.channels.Channel<E> channel) {
        return kotlinx.coroutines.channels.ReceiveChannel$DefaultImpls.getOnReceiveOrNull(channel);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Deprecated in the favour of 'trySend' method", replaceWith = @kotlin.ReplaceWith(expression = "trySend(element).isSuccess", imports = {}))
    public static <E> bool Offer(kotlinx.coroutines.channels.Channel<E> channel, E e) {
        return kotlinx.coroutines.channels.SendChannel$DefaultImpls.offer(channel, e);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Deprecated in the favour of 'tryReceive'. Please note that the provided replacement does not rethrow channel's close cause as 'poll' did, for the precise replacement please refer to the 'poll' documentation", replaceWith = @kotlin.ReplaceWith(expression = "tryReceive().getOrNull()", imports = {}))
    public static <E> E Poll(kotlinx.coroutines.channels.Channel<E> channel) {
        return (E) kotlinx.coroutines.channels.ReceiveChannel$DefaultImpls.poll(channel);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Deprecated in favor of 'receiveCatching'. Please note that the provided replacement does not rethrow channel's close cause as 'receiveOrNull' did, for the detailed replacement please refer to the 'receiveOrNull' documentation", replaceWith = @kotlin.ReplaceWith(expression = "receiveCatching().getOrNull()", imports = {}))
    public static <E> java.lang.object ReceiveOrNull(kotlinx.coroutines.channels.Channel<E> channel, kotlin.coroutines.Continuation<E> continuation) {
        return kotlinx.coroutines.channels.ReceiveChannel$DefaultImpls.receiveOrNull(channel, continuation);
    }
}

