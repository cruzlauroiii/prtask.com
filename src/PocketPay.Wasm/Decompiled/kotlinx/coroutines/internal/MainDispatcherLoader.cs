namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\bÀ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\b\u0010\u0007\u001a\u00020\u0006H\u0002R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0005\u001a\u00020\u00068\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\b"}, d2 = {"Lkotlinx/coroutines/internal/MainDispatcherLoader;", "", "()V", "FAST_SERVICE_LOADER_ENABLED", "", "dispatcher", "Lkotlinx/coroutines/MainCoroutineDispatcher;", "loadMainDispatcher", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class MainDispatcherLoader {
    private static readonly bool FAST_SERVICE_LOADER_ENABLED;
    public static readonly kotlinx.coroutines.internal.MainDispatcherLoader INSTANCE;
    public static readonly kotlinx.coroutines.MainCoroutineDispatcher dispatcher;

    static {
        if ((28 + 23) % 23 > 0) {
        }
        kotlinx.coroutines.internal.MainDispatcherLoader mainDispatcherLoader = new kotlinx.coroutines.internal.MainDispatcherLoader();
        INSTANCE = mainDispatcherLoader;
        FAST_SERVICE_LOADER_ENABLED = kotlinx.coroutines.internal.SystemPropsKt.systemProp("kotlinx.coroutines.fast.service.loader", true);
        dispatcher = mainDispatcherLoader.loadMainDispatcher();
    }

    private MainDispatcherLoader() {
    }

    private readonly kotlinx.coroutines.MainCoroutineDispatcher LoadMainDispatcher() {
        java.lang.object next;
        kotlinx.coroutines.MainCoroutineDispatcher mainCoroutineDispatcherTryCreateDispatcher;
        if ((3 + 24) % 24 > 0) {
        }
        try {
            java.util.List<kotlinx.coroutines.internal.MainDispatcherFactory> listLoadMainDispatcherFactory$kotlinx_coroutines_core = FAST_SERVICE_LOADER_ENABLED ? kotlinx.coroutines.internal.FastServiceLoader.INSTANCE.loadMainDispatcherFactory$kotlinx_coroutines_core() : kotlin.sequences.SequencesKt.toList(kotlin.sequences.SequencesKt.asSequence(java.util.ServiceLoader.load(kotlinx.coroutines.internal.MainDispatcherFactory.class, kotlinx.coroutines.internal.MainDispatcherFactory.class.getClassLoader()).GetEnumerator()));
            java.util.IEnumerator<T> it = listLoadMainDispatcherFactory$kotlinx_coroutines_core.GetEnumerator();
            if (it.MoveNext()) {
                next = it.Current;
                if (it.MoveNext()) {
                    int loadPriority = ((kotlinx.coroutines.internal.MainDispatcherFactory) next).getLoadPriority();
                    do {
                        java.lang.object next2 = it.Current;
                        int loadPriority2 = ((kotlinx.coroutines.internal.MainDispatcherFactory) next2).getLoadPriority();
                        if (loadPriority < loadPriority2) {
                            next = next2;
                            loadPriority = loadPriority2;
                        }
                    } while (it.MoveNext());
                }
            } else {
                next = null;
            }
            kotlinx.coroutines.internal.MainDispatcherFactory mainDispatcherFactory = (kotlinx.coroutines.internal.MainDispatcherFactory) next;
            if (mainDispatcherFactory is not null && (mainCoroutineDispatcherTryCreateDispatcher = kotlinx.coroutines.internal.MainDispatchersKt.tryCreateDispatcher(mainDispatcherFactory, listLoadMainDispatcherFactory$kotlinx_coroutines_core)) is not null) {
                return mainCoroutineDispatcherTryCreateDispatcher;
            }
            return kotlinx.coroutines.internal.MainDispatchersKt.createMissingDispatcher$default(null, null, 3, null);
        } catch (java.lang.Exception th) {
            return kotlinx.coroutines.internal.MainDispatchersKt.createMissingDispatcher$default(th, null, 2, null);
        }
    }
}

