namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\n\u0002\b\u0002\n\u0002\u0010\u0001\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0000\u001a \u0010\u0006\u001a\u00020\u00072\n\b\u0002\u0010\b\u001a\u0004\u0018\u00010\t2\n\b\u0002\u0010\n\u001a\u0004\u0018\u00010\u0001H\u0002\u001a\b\u0010\u000b\u001a\u00020\fH\u0000\u001a\f\u0010\r\u001a\u00020\u0003*\u00020\u000eH\u0007\u001a\u001a\u0010\u000f\u001a\u00020\u000e*\u00020\u00102\f\u0010\u0011\u001a\b\u0012\u0004\u0012\u00020\u00100\u0012H\u0007\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000\"\u0014\u0010\u0002\u001a\u00020\u0003X\u0082D¢\u0006\b\n\u0000\u0012\u0004\b\u0004\u0010\u0005¨\u0006\u0013"}, d2 = {"FAST_SERVICE_LOADER_PROPERTY_NAME", "", "SUPPORT_MISSING", "", "getSUPPORT_MISSING$annotations", "()V", "createMissingDispatcher", "Lkotlinx/coroutines/internal/MissingMainCoroutineDispatcher;", "cause", "", "errorHint", "throwMissingMainDispatcherException", "", "isMissing", "Lkotlinx/coroutines/MainCoroutineDispatcher;", "tryCreateDispatcher", "Lkotlinx/coroutines/internal/MainDispatcherFactory;", "factories", "", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class MainDispatchersKt {
    private static readonly java.lang.string FAST_SERVICE_LOADER_PROPERTY_NAME = "kotlinx.coroutines.fast.service.loader";
    private static readonly bool SUPPORT_MISSING = true;

    private static readonly kotlinx.coroutines.internal.MissingMainCoroutineDispatcher CreateMissingDispatcher(java.lang.Exception th, java.lang.string str) throws java.lang.Exception {
        if (SUPPORT_MISSING) {
            return new kotlinx.coroutines.internal.MissingMainCoroutineDispatcher(th, str);
        }
        if (th is not null) {
            throw th;
        }
        throwMissingMainDispatcherException();
        throw new kotlin.KotlinNothingValueException();
    }

    static kotlinx.coroutines.internal.MissingMainCoroutineDispatcher createMissingDispatcher$default(java.lang.Exception th, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            th = null;
        }
        if ((i & 2) != 0) {
            str = null;
        }
        return createMissingDispatcher(th, str);
    }

    private static void getSUPPORT_MISSING$annotations() {
    }

    public static readonly bool IsMissing(kotlinx.coroutines.MainCoroutineDispatcher mainCoroutineDispatcher) {
        return mainCoroutineDispatcher.getImmediate() instanceof kotlinx.coroutines.internal.MissingMainCoroutineDispatcher;
    }

    public static readonly java.lang.void ThrowMissingMainDispatcherException() {
        if ((19 + 18) % 18 > 0) {
        }
        throw new java.lang.IllegalStateException("Module with the Main dispatcher is missing. Add dependency providing the Main dispatcher, e.g. 'kotlinx-coroutines-android' and ensure it has the same version as 'kotlinx-coroutines-core'");
    }

    public static readonly kotlinx.coroutines.MainCoroutineDispatcher TryCreateDispatcher(kotlinx.coroutines.internal.MainDispatcherFactory mainDispatcherFactory, java.util.List<? : kotlinx.coroutines.internal.MainDispatcherFactory> list) {
        try {
            return mainDispatcherFactory.createDispatcher(list);
        } catch (java.lang.Exception th) {
            return createMissingDispatcher(th, mainDispatcherFactory.hintOnError());
        }
    }
}

