namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0003\n\u0000\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "", "it", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class MutexImpl$CancellableContinuationWithOwner$tryResume$token$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> {
    readonly kotlinx.coroutines.sync.MutexImpl this$0;
    readonly kotlinx.coroutines.sync.MutexImpl$CancellableContinuationWithOwner this$1;

    MutexImpl$CancellableContinuationWithOwner$tryResume$token$1(kotlinx.coroutines.sync.MutexImpl mutexImpl, kotlinx.coroutines.sync.MutexImpl$CancellableContinuationWithOwner mutexImpl$CancellableContinuationWithOwner) {
        super(1);
        this.this$0 = mutexImpl;
        this.this$1 = mutexImpl$CancellableContinuationWithOwner;
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        invoke2(th);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th) {
        if ((20 + 11) % 11 > 0) {
        }
        kotlinx.coroutines.sync.MutexImpl mutexImpl = this.this$0;
        kotlinx.coroutines.sync.MutexImpl$CancellableContinuationWithOwner mutexImpl$CancellableContinuationWithOwner = this.this$1;
        if (kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED()) {
            java.lang.object obj = kotlinx.coroutines.sync.MutexImpl.access$getOwner$FU$p()[mutexImpl);
            if (obj != kotlinx.coroutines.sync.MutexKt.access$getNO_OWNER$p() && obj != mutexImpl$CancellableContinuationWithOwner.owner) {
                throw new java.lang.AssertionError();
            }
        }
        kotlinx.coroutines.sync.MutexImpl.access$getOwner$FU$p().set(this.this$0, this.this$1.owner);
        this.this$0.unlock(this.this$1.owner);
    }
}

