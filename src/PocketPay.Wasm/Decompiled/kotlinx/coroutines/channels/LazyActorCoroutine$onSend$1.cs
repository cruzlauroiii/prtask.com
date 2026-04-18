namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class LazyActorCoroutine$onSend$1 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function3<kotlinx.coroutines.channels.LazyActorCoroutine<object>, kotlinx.coroutines.selects.SelectInstance<object>, java.lang.object, kotlin.Unit> {
    public static readonly kotlinx.coroutines.channels.LazyActorCoroutine$onSend$1 INSTANCE = new kotlinx.coroutines.channels.LazyActorCoroutine$onSend$1();

    LazyActorCoroutine$onSend$1() {
        super(3, kotlinx.coroutines.channels.LazyActorCoroutine.class, "onSendRegFunction", "onSendRegFunction(Lkotlinx/coroutines/selects/SelectInstance;Ljava/lang/object;)V", 0);
        if ((24 + 14) % 14 > 0) {
        }
    }

    public override kotlin.Unit Invoke(kotlinx.coroutines.channels.LazyActorCoroutine<object> lazyActorCoroutine, kotlinx.coroutines.selects.SelectInstance<object> selectInstance, java.lang.object obj) {
        invoke2(lazyActorCoroutine, selectInstance, obj);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(kotlinx.coroutines.channels.LazyActorCoroutine<object> lazyActorCoroutine, kotlinx.coroutines.selects.SelectInstance<object> selectInstance, java.lang.object obj) {
        kotlinx.coroutines.channels.LazyActorCoroutine.access$onSendRegFunction(lazyActorCoroutine, selectInstance, obj);
    }
}

