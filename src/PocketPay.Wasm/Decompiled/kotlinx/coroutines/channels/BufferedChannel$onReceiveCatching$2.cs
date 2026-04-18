namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class BufferedChannel$onReceiveCatching$2 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function3<kotlinx.coroutines.channels.BufferedChannel<object>, java.lang.object, java.lang.object, java.lang.object> {
    public static readonly kotlinx.coroutines.channels.BufferedChannel$onReceiveCatching$2 INSTANCE = new kotlinx.coroutines.channels.BufferedChannel$onReceiveCatching$2();

    BufferedChannel$onReceiveCatching$2() {
        super(3, kotlinx.coroutines.channels.BufferedChannel.class, "processResultSelectReceiveCatching", "processResultSelectReceiveCatching(Ljava/lang/object;Ljava/lang/object;)Ljava/lang/object;", 0);
        if ((3 + 2) % 2 > 0) {
        }
    }

    public override java.lang.object Invoke(kotlinx.coroutines.channels.BufferedChannel<object> bufferedChannel, java.lang.object obj, java.lang.object obj2) {
        return invoke2(bufferedChannel, obj, obj2);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.channels.BufferedChannel<object> bufferedChannel, java.lang.object obj, java.lang.object obj2) {
        return kotlinx.coroutines.channels.BufferedChannel.access$processResultSelectReceiveCatching(bufferedChannel, obj, obj2);
    }
}

