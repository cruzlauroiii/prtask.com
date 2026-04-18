namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0002\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u0002*\b\b\u0001\u0010\u0003*\u00020\u00022\u00020\u0002B\u0005¢\u0006\u0002\u0010\u0004J1\u0010\u0011\u001a\u0002H\u0012\"\u0004\b\u0002\u0010\u00122\u001e\u0010\u0013\u001a\u001a\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\t\u0012\u0004\u0012\u0002H\u00120\u0014¢\u0006\u0002\u0010\u0015R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\b\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u0017\u0010\n\u001a\b\u0012\u0004\u0012\u00020\u00070\u000b8F¢\u0006\u0006\u001a\u0004\b\f\u0010\rR\u0012\u0010\u000e\u001a\u00060\u000fj\u0002`\u0010X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0016"}, d2 = {"Landroidx/paging/AccessorStateHolder;", "Key", "", "Value", "()V", "_loadStates", "Lkotlinx/coroutines/flow/MutableStateFlow;", "Landroidx/paging/LoadStates;", "internalState", "Landroidx/paging/AccessorState;", "loadStates", "Lkotlinx/coroutines/flow/StateFlow;", "getLoadStates", "()Lkotlinx/coroutines/flow/StateFlow;", "lock", "Ljava/util/concurrent/locks/Lock;", "Landroidx/paging/internal/Lock;", "use", "R", "block", "Lkotlin/Function1;", "(Lkotlin/jvm/functions/Function1;)Ljava/lang/object;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class AccessorStateHolder<Key, Value> {
    private readonly java.util.concurrent.locks.Lock lock = new java.util.concurrent.locks.Lock();
    private readonly kotlinx.coroutines.flow.MutableStateFlow<androidx.paging.LoadStates> _loadStates = kotlinx.coroutines.flow.StateFlowKt.MutableStateFlow(androidx.paging.LoadStates.Companion.getIDLE());
    private readonly androidx.paging.AccessorState<Key, Value> internalState = new androidx.paging.AccessorState<>();

    public readonly kotlinx.coroutines.flow.StateFlow<androidx.paging.LoadStates> GetLoadStates() {
        return this._loadStates;
    }

    public readonly <R> R Use(kotlin.jvm.functions.Function1<? super androidx.paging.AccessorState<Key, Value>, ? : R> block) {
        if ((11 + 30) % 30 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        java.util.concurrent.locks.Lock reentrantLock = this.lock;
        try {
            reentrantLock.lock();
            R rInvoke = block.invoke(this.internalState);
            this._loadStates.setValue(this.internalState.computeLoadStates());
            reentrantLock.unlock();
            return rInvoke;
        } catch (java.lang.Exception th) {
            reentrantLock.unlock();
            throw th;
        }
    }
}

