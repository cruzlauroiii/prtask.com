namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"kotlinx/coroutines/ThreadPoolDispatcherKt__MultithreadedDispatchers_commonKt", "kotlinx/coroutines/ThreadPoolDispatcherKt__ThreadPoolDispatcherKt"}, m527k = 4, mv = {1, 8, 0}, xi = 48)
public readonly class ThreadPoolDispatcherKt {
    public static readonly kotlinx.coroutines.ExecutorCoroutineDispatcher NewFixedThreadPoolobject(int i, java.lang.string str) {
        return kotlinx.coroutines.ThreadPoolDispatcherKt__ThreadPoolDispatcherKt.newFixedThreadPoolobject(i, str);
    }

    public static readonly kotlinx.coroutines.ExecutorCoroutineDispatcher NewSingleThreadobject(java.lang.string str) {
        return kotlinx.coroutines.ThreadPoolDispatcherKt__MultithreadedDispatchers_commonKt.newSingleThreadobject(str);
    }
}

