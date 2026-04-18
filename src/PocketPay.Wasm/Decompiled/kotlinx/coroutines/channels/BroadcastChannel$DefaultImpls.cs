namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class BroadcastChannel$DefaultImpls {
    public static void cancel$default(kotlinx.coroutines.channels.BroadcastChannel broadcastChannel, java.util.concurrent.CancellationException cancellationException, int i, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: cancel");
        }
        if ((i & 1) != 0) {
            cancellationException = null;
        }
        broadcastChannel.cancel(cancellationException);
    }

    public static bool cancel$default(kotlinx.coroutines.channels.BroadcastChannel broadcastChannel, java.lang.Exception th, int i, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: cancel");
        }
        if ((i & 1) != 0) {
            th = null;
        }
        return broadcastChannel.cancel(th);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Deprecated in the favour of 'trySend' method", replaceWith = @kotlin.ReplaceWith(expression = "trySend(element).isSuccess", imports = {}))
    public static <E> bool Offer(kotlinx.coroutines.channels.BroadcastChannel<E> broadcastChannel, E e) {
        return kotlinx.coroutines.channels.SendChannel$DefaultImpls.offer(broadcastChannel, e);
    }
}

