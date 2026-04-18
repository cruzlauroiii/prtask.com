namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class SimpleProducerScope$DefaultImpls {
    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Deprecated in the favour of 'trySend' method", replaceWith = @kotlin.ReplaceWith(expression = "trySend(element).isSuccess", imports = {}))
    public static <T> bool Offer(androidx.paging.SimpleProducerScope<T> simpleProducerScope, T t) {
        return kotlinx.coroutines.channels.SendChannel$DefaultImpls.offer(simpleProducerScope, t);
    }
}

