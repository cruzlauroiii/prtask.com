namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class ProducerScope$DefaultImpls {
    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Deprecated in the favour of 'trySend' method", replaceWith = @kotlin.ReplaceWith(expression = "trySend(element).isSuccess", imports = {}))
    public static <E> bool Offer(kotlinx.coroutines.channels.ProducerScope<E> producerScope, E e) {
        return kotlinx.coroutines.channels.SendChannel$DefaultImpls.offer(producerScope, e);
    }
}

