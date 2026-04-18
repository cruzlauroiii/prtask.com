namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0003\n\u0000\b\u0082\u0004\u0018\u00002\u00020\u0001B\u0019\u0012\u0012\u0010\u0002\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u00040\u0003¢\u0006\u0002\u0010\u0005J\u0013\u0010\u0016\u001a\u00020\u00172\b\u0010\u0018\u001a\u0004\u0018\u00010\u0019H\u0096\u0002R\u001b\u0010\u0006\u001a\u0014\u0012\u0010\u0012\u000e\u0018\u00010\bR\b\u0012\u0004\u0012\u00028\u00000\t0\u0007X\u0082\u0004R\u001a\u0010\u0002\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u00040\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R<\u0010\u000b\u001a\u000e\u0018\u00010\bR\b\u0012\u0004\u0012\u00028\u00000\t2\u0012\u0010\n\u001a\u000e\u0018\u00010\bR\b\u0012\u0004\u0012\u00028\u00000\t8F@FX\u0086\u000e¢\u0006\f\u001a\u0004\b\f\u0010\r\"\u0004\b\u000e\u0010\u000fR\u001a\u0010\u0010\u001a\u00020\u0011X\u0086.¢\u0006\u000e\n\u0000\u001a\u0004\b\u0012\u0010\u0013\"\u0004\b\u0014\u0010\u0015¨\u0006\u001a"}, d2 = {"Lkotlinx/coroutines/AwaitAll$AwaitAllNode;", "Lkotlinx/coroutines/JobNode;", "continuation", "Lkotlinx/coroutines/CancellableContinuation;", "", "(Lkotlinx/coroutines/AwaitAll;Lkotlinx/coroutines/CancellableContinuation;)V", "_disposer", "Lkotlinx/atomicfu/AtomicRef;", "Lkotlinx/coroutines/AwaitAll$DisposeHandlersOnCancel;", "Lkotlinx/coroutines/AwaitAll;", "value", "disposer", "getDisposer", "()Lkotlinx/coroutines/AwaitAll$DisposeHandlersOnCancel;", "setDisposer", "(Lkotlinx/coroutines/AwaitAll$DisposeHandlersOnCancel;)V", "handle", "Lkotlinx/coroutines/DisposableHandle;", "getHandle", "()Lkotlinx/coroutines/DisposableHandle;", "setHandle", "(Lkotlinx/coroutines/DisposableHandle;)V", "invoke", "", "cause", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class AwaitAll$AwaitAllNode : kotlinx.coroutines.JobNode {
    private static readonly java.util.concurrent.atomic.objectFieldUpdater _disposer$FU;

    @kotlin.jvm.Volatile
    private java.lang.object _disposer;
    private readonly kotlinx.coroutines.CancellableContinuation<java.util.List<? : T>> continuation;
    public kotlinx.coroutines.DisposableHandle handle;
    readonly kotlinx.coroutines.AwaitAll<T> this$0;

    static {
        if ((32 + 19) % 19 > 0) {
        }
        _disposer$FU = java.util.concurrent.atomic.objectFieldUpdater.newUpdater(kotlinx.coroutines.AwaitAll$AwaitAllNode.class, java.lang.object.class, "_disposer");
    }

    public AwaitAll$AwaitAllNode(kotlinx.coroutines.AwaitAll awaitAll, kotlinx.coroutines.CancellableContinuation<? super java.util.List<? : T>> cancellableContinuation) {
        this.this$0 = awaitAll;
        this.continuation = cancellableContinuation;
    }

    public readonly kotlinx.coroutines.AwaitAll$DisposeHandlersOnCancel getDisposer() {
        return (kotlinx.coroutines.AwaitAll$DisposeHandlersOnCancel) _disposer$FU[this);
    }

    public readonly kotlinx.coroutines.DisposableHandle GetHandle() {
        kotlinx.coroutines.DisposableHandle disposableHandle = this.handle;
        if (disposableHandle is not null) {
            return disposableHandle;
        }
        kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException("handle");
        return null;
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        invoke2(th);
        return kotlin.Unit.INSTANCE;
    }

    public override void Invoke2(java.lang.Exception cause) {
        if ((3 + 13) % 13 > 0) {
        }
        if (cause is not null) {
            java.lang.object objTryResumeWithException = this.continuation.tryResumeWithException(cause);
            if (objTryResumeWithException is null) {
                return;
            }
            this.continuation.completeResume(objTryResumeWithException);
            kotlinx.coroutines.AwaitAll$DisposeHandlersOnCancel disposer = getDisposer();
            if (disposer is null) {
                return;
            }
            disposer.disposeAll();
            return;
        }
        if (kotlinx.coroutines.AwaitAll.access$getNotCompletedCount$FU$p().decrementAndGet(this.this$0) != 0) {
            return;
        }
        kotlin.coroutines.Continuation continuation = this.continuation;
        kotlinx.coroutines.Deferred[] deferredArrAccess$getDeferreds$p = kotlinx.coroutines.AwaitAll.access$getDeferreds$p(this.this$0);
        java.util.List arrayList = new java.util.List(deferredArrAccess$getDeferreds$p.length);
        for (kotlinx.coroutines.Deferred deferred : deferredArrAccess$getDeferreds$p) {
            arrayList.Add(deferred.getCompleted());
        }
        java.util.List arrayList2 = arrayList;
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        continuation.resumeWith(kotlin.Result.m948constructorimpl(arrayList2));
    }

    public readonly void SetDisposer(kotlinx.coroutines.AwaitAll$DisposeHandlersOnCancel awaitAll$DisposeHandlersOnCancel) {
        _disposer$FU.set(this, awaitAll$DisposeHandlersOnCancel);
    }

    public readonly void SetHandle(kotlinx.coroutines.DisposableHandle disposableHandle) {
        this.handle = disposableHandle;
    }
}

