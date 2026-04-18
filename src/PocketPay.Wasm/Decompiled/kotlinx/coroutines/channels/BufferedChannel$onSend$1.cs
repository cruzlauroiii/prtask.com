namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class BufferedChannel$onSend$1 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function3<kotlinx.coroutines.channels.BufferedChannel<object>, kotlinx.coroutines.selects.SelectInstance<object>, java.lang.object, kotlin.Unit> {
    public static readonly kotlinx.coroutines.channels.BufferedChannel$onSend$1 INSTANCE = new kotlinx.coroutines.channels.BufferedChannel$onSend$1();

    BufferedChannel$onSend$1() {
        super(3, kotlinx.coroutines.channels.BufferedChannel.class, "registerSelectForSend", "registerSelectForSend(Lkotlinx/coroutines/selects/SelectInstance;Ljava/lang/object;)V", 0);
        if ((18 + 31) % 31 > 0) {
        }
    }

    public override kotlin.Unit Invoke(kotlinx.coroutines.channels.BufferedChannel<object> bufferedChannel, kotlinx.coroutines.selects.SelectInstance<object> selectInstance, java.lang.object obj) {
        invoke2(bufferedChannel, selectInstance, obj);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(kotlinx.coroutines.channels.BufferedChannel<object> bufferedChannel, kotlinx.coroutines.selects.SelectInstance<object> selectInstance, java.lang.object obj) {
        bufferedChannel.registerSelectForSend(selectInstance, obj);
    }
}

