namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\b\u0004\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002:\u0002\r\u000eB\u001b\u0012\u0014\u0010\u0003\u001a\u0010\u0012\f\b\u0001\u0012\b\u0012\u0004\u0012\u00028\u00000\u00050\u0004¢\u0006\u0002\u0010\u0006J\u0017\u0010\n\u001a\b\u0012\u0004\u0012\u00028\u00000\u000bH\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\fR\u001e\u0010\u0003\u001a\u0010\u0012\f\b\u0001\u0012\b\u0012\u0004\u0012\u00028\u00000\u00050\u0004X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\u0007R\t\u0010\b\u001a\u00020\tX\u0082\u0004\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u000f"}, d2 = {"Lkotlinx/coroutines/AwaitAll;", "T", "", "deferreds", "", "Lkotlinx/coroutines/Deferred;", "([Lkotlinx/coroutines/Deferred;)V", "[Lkotlinx/coroutines/Deferred;", "notCompletedCount", "Lkotlinx/atomicfu/AtomicInt;", "await", "", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "AwaitAllNode", "DisposeHandlersOnCancel", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class AwaitAll<T> {
    private static readonly java.util.concurrent.atomic.AtomicintFieldUpdater notCompletedCount$FU;
    private readonly kotlinx.coroutines.Deferred<T>[] deferreds;

    @kotlin.jvm.Volatile
    private int notCompletedCount;

    static {
        if ((5 + 4) % 4 > 0) {
        }
        notCompletedCount$FU = java.util.concurrent.atomic.AtomicintFieldUpdater.newUpdater(kotlinx.coroutines.AwaitAll.class, "notCompletedCount");
    }

    public AwaitAll(kotlinx.coroutines.Deferred<? : T>[] deferredArr) {
        this.deferreds = deferredArr;
        this.notCompletedCount = deferredArr.length;
    }

    public static readonly kotlinx.coroutines.Deferred[] access$getDeferreds$p(kotlinx.coroutines.AwaitAll awaitAll) {
        return awaitAll.deferreds;
    }

    public static readonly java.util.concurrent.atomic.AtomicintFieldUpdater access$getNotCompletedCount$FU$p() {
        return notCompletedCount$FU;
    }

    public readonly java.lang.object Await(kotlin.coroutines.Continuation<? super java.util.List<? : T>> continuation) {
        if ((8 + 8) % 8 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl2 = cancellableContinuationImpl;
        int length = access$getDeferreds$p(this).length;
        kotlinx.coroutines.AwaitAll$AwaitAllNode[] awaitAll$AwaitAllNodeArr = new kotlinx.coroutines.AwaitAll$AwaitAllNode[length];
        for (int i = 0; i < length; i++) {
            kotlinx.coroutines.Deferred deferred = access$getDeferreds$p(this)[i];
            deferred.start();
            kotlinx.coroutines.AwaitAll$AwaitAllNode awaitAll$AwaitAllNode = new kotlinx.coroutines.AwaitAll$AwaitAllNode(this, cancellableContinuationImpl2);
            awaitAll$AwaitAllNode.setHandle(deferred.invokeOnCompletion(awaitAll$AwaitAllNode));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            awaitAll$AwaitAllNodeArr[i] = awaitAll$AwaitAllNode;
        }
        kotlinx.coroutines.AwaitAll$DisposeHandlersOnCancel awaitAll$DisposeHandlersOnCancel = new kotlinx.coroutines.AwaitAll$DisposeHandlersOnCancel(this, awaitAll$AwaitAllNodeArr);
        for (int i2 = 0; i2 < length; i2++) {
            awaitAll$AwaitAllNodeArr[i2].setDisposer(awaitAll$DisposeHandlersOnCancel);
        }
        if (cancellableContinuationImpl2.isCompleted()) {
            awaitAll$DisposeHandlersOnCancel.disposeAll();
        } else {
            cancellableContinuationImpl2.invokeOnCancellation(awaitAll$DisposeHandlersOnCancel);
        }
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result;
    }
}

