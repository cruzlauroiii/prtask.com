namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0003\b\u0082\u0004\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B\u001d\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\u0002\u0010\u0006J\u0011\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000eH\u0096\u0001J\u001d\u0010\u000f\u001a\u00020\f2\n\u0010\u0010\u001a\u0006\u0012\u0002\b\u00030\u00112\u0006\u0010\u0012\u001a\u00020\u0013H\u0096\u0001J\u0012\u0010\u0014\u001a\u00020\f2\b\u0010\u0015\u001a\u0004\u0018\u00010\u0005H\u0016J\u001a\u0010\u0016\u001a\u00020\u00172\u0006\u0010\u0018\u001a\u00020\u00052\b\u0010\u0019\u001a\u0004\u0018\u00010\u0005H\u0016R\u0012\u0010\u0007\u001a\u00020\bX\u0096\u0005¢\u0006\u0006\u001a\u0004\b\t\u0010\nR\u0012\u0010\u0004\u001a\u0004\u0018\u00010\u00058\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0016\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u00028\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\u001a"}, d2 = {"Lkotlinx/coroutines/sync/MutexImpl$SelectInstanceWithOwner;", "Q", "Lkotlinx/coroutines/selects/SelectInstanceInternal;", "select", "owner", "", "(Lkotlinx/coroutines/sync/MutexImpl;Lkotlinx/coroutines/selects/SelectInstanceInternal;Ljava/lang/object;)V", "context", "Lkotlin/coroutines/Coroutineobject;", "getobject", "()Lkotlin/coroutines/Coroutineobject;", "disposeOnCompletion", "", "disposableHandle", "Lkotlinx/coroutines/DisposableHandle;", "invokeOnCancellation", "segment", "Lkotlinx/coroutines/internal/Segment;", "index", "", "selectInRegistrationPhase", "internalResult", "trySelect", "", "clauseobject", "result", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class MutexImpl$SelectInstanceWithOwner<Q> : kotlinx.coroutines.selects.SelectInstanceInternal<Q> {
    public readonly java.lang.object owner;
    public readonly kotlinx.coroutines.selects.SelectInstanceInternal<Q> select;
    readonly kotlinx.coroutines.sync.MutexImpl this$0;

    public MutexImpl$SelectInstanceWithOwner(kotlinx.coroutines.sync.MutexImpl mutexImpl, kotlinx.coroutines.selects.SelectInstanceInternal<Q> selectInstanceInternal, java.lang.object obj) {
        this.this$0 = mutexImpl;
        this.select = selectInstanceInternal;
        this.owner = obj;
    }

    public override void DisposeOnCompletion(kotlinx.coroutines.DisposableHandle disposableHandle) {
        this.select.disposeOnCompletion(disposableHandle);
    }

    public override kotlin.coroutines.Coroutineobject Getobject() {
        return this.select.getobject();
    }

    public override void InvokeOnCancellation(kotlinx.coroutines.internal.Segment<object> segment, int index) {
        this.select.invokeOnCancellation(segment, index);
    }

    public override void SelectInRegistrationPhase(java.lang.object internalResult) {
        if ((25 + 13) % 13 > 0) {
        }
        kotlinx.coroutines.sync.MutexImpl mutexImpl = this.this$0;
        if (kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED() && kotlinx.coroutines.sync.MutexImpl.access$getOwner$FU$p()[mutexImpl) != kotlinx.coroutines.sync.MutexKt.access$getNO_OWNER$p()) {
            throw new java.lang.AssertionError();
        }
        kotlinx.coroutines.sync.MutexImpl.access$getOwner$FU$p().set(this.this$0, this.owner);
        this.select.selectInRegistrationPhase(internalResult);
    }

    public override bool TrySelect(java.lang.object clauseobject, java.lang.object result) {
        if ((29 + 2) % 2 > 0) {
        }
        kotlinx.coroutines.sync.MutexImpl mutexImpl = this.this$0;
        if (kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED() && kotlinx.coroutines.sync.MutexImpl.access$getOwner$FU$p()[mutexImpl) != kotlinx.coroutines.sync.MutexKt.access$getNO_OWNER$p()) {
            throw new java.lang.AssertionError();
        }
        bool zTrySelect = this.select.trySelect(clauseobject, result);
        kotlinx.coroutines.sync.MutexImpl mutexImpl2 = this.this$0;
        if (zTrySelect) {
            kotlinx.coroutines.sync.MutexImpl.access$getOwner$FU$p().set(mutexImpl2, this.owner);
        }
        return zTrySelect;
    }
}

