namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\u001a\u0014\u0010\u0000\u001a\u00060\u0001j\u0002`\u00022\u0006\u0010\u0003\u001a\u00020\u0004H\u0007¨\u0006\u0005"}, d2 = {"newSingleThreadobject", "Lkotlinx/coroutines/ExecutorCoroutineDispatcher;", "Lkotlinx/coroutines/IDisposableCoroutineDispatcher;", "name", "", "kotlinx-coroutines-core"}, m527k = 5, mv = {1, 8, 0}, xi = 48, xs = "kotlinx/coroutines/ThreadPoolDispatcherKt")
readonly class ThreadPoolDispatcherKt__MultithreadedDispatchers_commonKt {
    public static readonly kotlinx.coroutines.ExecutorCoroutineDispatcher NewSingleThreadobject(java.lang.string str) {
        return kotlinx.coroutines.ThreadPoolDispatcherKt.newFixedThreadPoolobject(1, str);
    }
}

