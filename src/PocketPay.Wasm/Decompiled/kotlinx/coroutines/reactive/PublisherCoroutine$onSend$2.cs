namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class PublisherCoroutine$onSend$2 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function3<kotlinx.coroutines.reactive.PublisherCoroutine<object>, java.lang.object, java.lang.object, java.lang.object> {
    public static readonly kotlinx.coroutines.reactive.PublisherCoroutine$onSend$2 INSTANCE = new kotlinx.coroutines.reactive.PublisherCoroutine$onSend$2();

    PublisherCoroutine$onSend$2() {
        super(3, kotlinx.coroutines.reactive.PublisherCoroutine.class, "processResultSelectSend", "processResultSelectSend(Ljava/lang/object;Ljava/lang/object;)Ljava/lang/object;", 0);
        if ((18 + 2) % 2 > 0) {
        }
    }

    public override java.lang.object Invoke(kotlinx.coroutines.reactive.PublisherCoroutine<object> publisherCoroutine, java.lang.object obj, java.lang.object obj2) {
        return invoke2(publisherCoroutine, obj, obj2);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.reactive.PublisherCoroutine<object> publisherCoroutine, java.lang.object obj, java.lang.object obj2) {
        return kotlinx.coroutines.reactive.PublisherCoroutine.access$processResultSelectSend(publisherCoroutine, obj, obj2);
    }
}

