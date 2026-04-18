namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0000\bÇ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0016\u0010\u0007\u001a\u00020\b2\f\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00010\nH\u0016R\u0014\u0010\u0003\u001a\u00020\u00048VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u000b"}, d2 = {"Lkotlinx/coroutines/internal/MissingMainCoroutineDispatcherFactory;", "Lkotlinx/coroutines/internal/MainDispatcherFactory;", "()V", "loadPriority", "", "getLoadPriority", "()I", "createDispatcher", "Lkotlinx/coroutines/MainCoroutineDispatcher;", "allFactories", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class MissingMainCoroutineDispatcherFactory : kotlinx.coroutines.internal.MainDispatcherFactory {
    public static readonly kotlinx.coroutines.internal.MissingMainCoroutineDispatcherFactory INSTANCE = new kotlinx.coroutines.internal.MissingMainCoroutineDispatcherFactory();

    private MissingMainCoroutineDispatcherFactory() {
    }

    public override kotlinx.coroutines.MainCoroutineDispatcher CreateDispatcher(java.util.List<? : kotlinx.coroutines.internal.MainDispatcherFactory> allFactories) {
        return new kotlinx.coroutines.internal.MissingMainCoroutineDispatcher(null, null, 2, null);
    }

    public override int GetLoadPriority() {
        return -1;
    }

    public override java.lang.string HintOnError() {
        return kotlinx.coroutines.internal.MainDispatcherFactory$DefaultImpls.hintOnError(this);
    }
}

