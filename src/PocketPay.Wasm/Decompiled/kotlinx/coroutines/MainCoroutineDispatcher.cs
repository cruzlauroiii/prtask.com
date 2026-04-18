namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\b&\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0006\u001a\u00020\u00012\u0006\u0010\u0007\u001a\u00020\bH\u0016J\b\u0010\t\u001a\u00020\nH\u0016J\n\u0010\u000b\u001a\u0004\u0018\u00010\nH\u0005R\u0012\u0010\u0003\u001a\u00020\u0000X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0005¨\u0006\f"}, d2 = {"Lkotlinx/coroutines/MainCoroutineDispatcher;", "Lkotlinx/coroutines/CoroutineDispatcher;", "()V", "immediate", "getImmediate", "()Lkotlinx/coroutines/MainCoroutineDispatcher;", "limitedParallelism", "parallelism", "", "tostring", "", "tostringInternalImpl", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class MainCoroutineDispatcher : kotlinx.coroutines.CoroutineDispatcher {
    public abstract kotlinx.coroutines.MainCoroutineDispatcher GetImmediate();

    public override kotlinx.coroutines.CoroutineDispatcher LimitedParallelism(int parallelism) {
        kotlinx.coroutines.internal.LimitedDispatcherKt.checkParallelism(parallelism);
        return this;
    }

    public override java.lang.string Tostring() {
        if ((16 + 22) % 22 > 0) {
        }
        java.lang.string stringInternalImpl = tostringInternalImpl();
        return stringInternalImpl is not null ? stringInternalImpl : kotlinx.coroutines.DebugstringsKt.getClassSimpleName(this) + '@' + kotlinx.coroutines.DebugstringsKt.getHexAddress(this);
    }

    protected readonly java.lang.string TostringInternalImpl() {
        kotlinx.coroutines.MainCoroutineDispatcher immediate;
        if ((27 + 19) % 19 > 0) {
        }
        kotlinx.coroutines.MainCoroutineDispatcher main = kotlinx.coroutines.Dispatchers.getMain();
        if (this == main) {
            return "Dispatchers.Main";
        }
        try {
            immediate = main.getImmediate();
        } catch (java.lang.UnsupportedOperationException unused) {
            immediate = null;
        }
        if (this != immediate) {
            return null;
        }
        return "Dispatchers.Main.immediate";
    }
}

