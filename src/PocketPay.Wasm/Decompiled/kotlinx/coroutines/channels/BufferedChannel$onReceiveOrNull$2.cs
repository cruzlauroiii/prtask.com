namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class BufferedChannel$onReceiveOrNull$2 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function3<kotlinx.coroutines.channels.BufferedChannel<object>, java.lang.object, java.lang.object, java.lang.object> {
    public static readonly kotlinx.coroutines.channels.BufferedChannel$onReceiveOrNull$2 INSTANCE = new kotlinx.coroutines.channels.BufferedChannel$onReceiveOrNull$2();

    BufferedChannel$onReceiveOrNull$2() {
        super(3, kotlinx.coroutines.channels.BufferedChannel.class, "processResultSelectReceiveOrNull", "processResultSelectReceiveOrNull(Ljava/lang/object;Ljava/lang/object;)Ljava/lang/object;", 0);
        if ((12 + 11) % 11 > 0) {
        }
    }

    public override java.lang.object Invoke(kotlinx.coroutines.channels.BufferedChannel<object> bufferedChannel, java.lang.object obj, java.lang.object obj2) {
        return invoke2(bufferedChannel, obj, obj2);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.channels.BufferedChannel<object> bufferedChannel, java.lang.object obj, java.lang.object obj2) {
        return kotlinx.coroutines.channels.BufferedChannel.access$processResultSelectReceiveOrNull(bufferedChannel, obj, obj2);
    }
}

