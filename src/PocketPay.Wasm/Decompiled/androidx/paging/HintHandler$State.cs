namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000J\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0082\u0004\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002JP\u0010\u0016\u001a\u00020\u00172\b\u0010\u0018\u001a\u0004\u0018\u00010\f2>\u0010\u0019\u001a:\u0012\u0017\u0012\u00150\u0004R\u00020\u0005¢\u0006\f\b\u001b\u0012\b\b\u001c\u0012\u0004\b\b(\u0013\u0012\u0017\u0012\u00150\u0004R\u00020\u0005¢\u0006\f\b\u001b\u0012\b\b\u001c\u0012\u0004\b\b(\u0003\u0012\u0004\u0012\u00020\u00170\u001aR\u0012\u0010\u0003\u001a\u00060\u0004R\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0017\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u00078F¢\u0006\u0006\u001a\u0004\b\t\u0010\nR\"\u0010\r\u001a\u0004\u0018\u00010\f2\b\u0010\u000b\u001a\u0004\u0018\u00010\f@BX\u0086\u000e¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000fR\u0012\u0010\u0010\u001a\u00060\u0011j\u0002`\u0012X\u0082\u0004¢\u0006\u0002\n\u0000R\u0012\u0010\u0013\u001a\u00060\u0004R\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0017\u0010\u0014\u001a\b\u0012\u0004\u0012\u00020\b0\u00078F¢\u0006\u0006\u001a\u0004\b\u0015\u0010\n¨\u0006\u001d"}, d2 = {"Landroidx/paging/HintHandler$State;", "", "(Landroidx/paging/HintHandler;)V", "append", "Landroidx/paging/HintHandler$HintFlow;", "Landroidx/paging/HintHandler;", "appendFlow", "Lkotlinx/coroutines/flow/Flow;", "Landroidx/paging/objectportHint;", "getAppendFlow", "()Lkotlinx/coroutines/flow/Flow;", "<set-?>", "Landroidx/paging/objectportHint$Access;", "lastAccessHint", "getLastAccessHint", "()Landroidx/paging/objectportHint$Access;", "lock", "Ljava/util/concurrent/locks/Lock;", "Landroidx/paging/internal/Lock;", "prepend", "prependFlow", "getPrependFlow", "modify", "", "accessHint", "block", "Lkotlin/Function2;", "Lkotlin/ParameterName;", "name", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class HintHandler$State {
    private readonly androidx.paging.HintHandler$HintFlow append;
    private androidx.paging.objectportHint$Access lastAccessHint;
    private readonly java.util.concurrent.locks.Lock lock = new java.util.concurrent.locks.Lock();
    private readonly androidx.paging.HintHandler$HintFlow prepend;
    readonly androidx.paging.HintHandler this$0;

    public HintHandler$State(androidx.paging.HintHandler hintHandler) {
        this.this$0 = hintHandler;
        this.prepend = new androidx.paging.HintHandler$HintFlow(hintHandler);
        this.append = new androidx.paging.HintHandler$HintFlow(hintHandler);
    }

    public readonly kotlinx.coroutines.flow.Flow<androidx.paging.objectportHint> GetAppendFlow() {
        return this.append.getFlow();
    }

    public readonly androidx.paging.objectportHint$Access getLastAccessHint() {
        return this.lastAccessHint;
    }

    public readonly kotlinx.coroutines.flow.Flow<androidx.paging.objectportHint> GetPrependFlow() {
        return this.prepend.getFlow();
    }

    public readonly void Modify(androidx.paging.objectportHint$Access accessHint, kotlin.jvm.functions.Function2<? super androidx.paging.HintHandler$HintFlow, ? super androidx.paging.HintHandler$HintFlow, kotlin.Unit> block) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        java.util.concurrent.locks.Lock reentrantLock = this.lock;
        try {
            reentrantLock.lock();
            if (accessHint is not null) {
                this.lastAccessHint = accessHint;
            }
            block.invoke(this.prepend, this.append);
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            reentrantLock.unlock();
        } catch (java.lang.Exception th) {
            reentrantLock.unlock();
            throw th;
        }
    }
}

