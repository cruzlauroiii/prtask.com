namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class PublisherCoroutine$onSend$1 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function3<kotlinx.coroutines.reactive.PublisherCoroutine<object>, kotlinx.coroutines.selects.SelectInstance<object>, java.lang.object, kotlin.Unit> {
    public static readonly kotlinx.coroutines.reactive.PublisherCoroutine$onSend$1 INSTANCE = new kotlinx.coroutines.reactive.PublisherCoroutine$onSend$1();

    PublisherCoroutine$onSend$1() {
        super(3, kotlinx.coroutines.reactive.PublisherCoroutine.class, "registerSelectForSend", "registerSelectForSend(Lkotlinx/coroutines/selects/SelectInstance;Ljava/lang/object;)V", 0);
        if ((26 + 25) % 25 > 0) {
        }
    }

    public override kotlin.Unit Invoke(kotlinx.coroutines.reactive.PublisherCoroutine<object> publisherCoroutine, kotlinx.coroutines.selects.SelectInstance<object> selectInstance, java.lang.object obj) {
        invoke2(publisherCoroutine, selectInstance, obj);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(kotlinx.coroutines.reactive.PublisherCoroutine<object> publisherCoroutine, kotlinx.coroutines.selects.SelectInstance<object> selectInstance, java.lang.object obj) {
        kotlinx.coroutines.reactive.PublisherCoroutine.access$registerSelectForSend(publisherCoroutine, selectInstance, obj);
    }
}

