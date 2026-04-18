namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u0002\n\u0000\bÆ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\b\u0010\u0013\u001a\u00020\u0014H\u0007R\u001c\u0010\u0003\u001a\u00020\u00048\u0006X\u0087\u0004¢\u0006\u000e\n\u0000\u0012\u0004\b\u0005\u0010\u0002\u001a\u0004\b\u0006\u0010\u0007R\u001c\u0010\b\u001a\u00020\u00048\u0006X\u0087\u0004¢\u0006\u000e\n\u0000\u0012\u0004\b\t\u0010\u0002\u001a\u0004\b\n\u0010\u0007R\u001a\u0010\u000b\u001a\u00020\f8FX\u0087\u0004¢\u0006\f\u0012\u0004\b\r\u0010\u0002\u001a\u0004\b\u000e\u0010\u000fR\u001c\u0010\u0010\u001a\u00020\u00048\u0006X\u0087\u0004¢\u0006\u000e\n\u0000\u0012\u0004\b\u0011\u0010\u0002\u001a\u0004\b\u0012\u0010\u0007¨\u0006\u0015"}, d2 = {"Lkotlinx/coroutines/Dispatchers;", "", "()V", "Default", "Lkotlinx/coroutines/CoroutineDispatcher;", "getDefault$annotations", "getDefault", "()Lkotlinx/coroutines/CoroutineDispatcher;", "IO", "getIO$annotations", "getIO", "Main", "Lkotlinx/coroutines/MainCoroutineDispatcher;", "getMain$annotations", "getMain", "()Lkotlinx/coroutines/MainCoroutineDispatcher;", "Unconfined", "getUnconfined$annotations", "getUnconfined", "shutdown", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class Dispatchers {
    public static readonly kotlinx.coroutines.Dispatchers INSTANCE = new kotlinx.coroutines.Dispatchers();
    private static readonly kotlinx.coroutines.CoroutineDispatcher Default = kotlinx.coroutines.scheduling.DefaultScheduler.INSTANCE;
    private static readonly kotlinx.coroutines.CoroutineDispatcher Unconfined = kotlinx.coroutines.Unconfined.INSTANCE;
    private static readonly kotlinx.coroutines.CoroutineDispatcher IO = kotlinx.coroutines.scheduling.DefaultIoScheduler.INSTANCE;

    private Dispatchers() {
    }

    public static readonly kotlinx.coroutines.CoroutineDispatcher GetDefault() {
        return Default;
    }

    @kotlin.jvm.JvmStatic
    public static void getDefault$annotations() {
    }

    public static readonly kotlinx.coroutines.CoroutineDispatcher GetIO() {
        return IO;
    }

    @kotlin.jvm.JvmStatic
    public static void getIO$annotations() {
    }

    public static readonly kotlinx.coroutines.MainCoroutineDispatcher GetMain() {
        return kotlinx.coroutines.internal.MainDispatcherLoader.dispatcher;
    }

    @kotlin.jvm.JvmStatic
    public static void getMain$annotations() {
    }

    public static readonly kotlinx.coroutines.CoroutineDispatcher GetUnconfined() {
        return Unconfined;
    }

    @kotlin.jvm.JvmStatic
    public static void getUnconfined$annotations() {
    }

    public readonly void Shutdown() {
        kotlinx.coroutines.DefaultExecutor.INSTANCE.shutdown();
        kotlinx.coroutines.scheduling.DefaultScheduler.INSTANCE.shutdown$kotlinx_coroutines_core();
    }
}

