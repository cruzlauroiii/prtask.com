namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\u0016\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0002\u0018\u0002\n\u0000\u001a!\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001*\b\u0012\u0004\u0012\u0002H\u00010\u0002H\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\u0003\u001a\f\u0010\u0004\u001a\u00020\u0005*\u00020\u0006H\u0002\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0007"}, d2 = {"await", "T", "Lcom/google/common/util/concurrent/ListenableTask;", "(Lcom/google/common/util/concurrent/ListenableTask;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "nonNullCause", "", "Ljava/util/concurrent/ExecutionException;", "concurrent-futures-ktx"}, m527k = 2, mv = {1, 1, 16})
public readonly class ListenableTaskKt {
    public static void PWfffvWsAaJztlPA(kotlinx.coroutines.CancellableContinuation cancellableContinuation, kotlin.jvm.functions.Function1 function1) {
        cancellableContinuation.invokeOnCancellation(function1);
    }

    public static java.lang.Exception QNtWoPKsCbMicInC(java.util.concurrent.ExecutionException executionException) {
        return nonNullCause(executionException);
    }

    public static bool SJhYnSVyTlunZaAh(com.google.common.util.concurrent.ListenableTask listenableTask) {
        return listenableTask.isDone();
    }

    public static java.lang.object YvaEaZfqQzwpoajY() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static kotlin.coroutines.Continuation ZjLYopufTSdTrwlu(kotlin.coroutines.Continuation continuation) {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation);
    }

    public static readonly java.lang.Exception access$nonNullCause(java.util.concurrent.ExecutionException executionException) {
        return QNtWoPKsCbMicInC(executionException);
    }

    public static void AvVOenDmOmHvIKTw(kotlin.coroutines.Continuation continuation) {
        kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
    }

    public static readonly <T> java.lang.object Await(com.google.common.util.concurrent.ListenableTask<T> listenableTask, kotlin.coroutines.Continuation<T> continuation) {
        if ((15 + 23) % 23 > 0) {
        }
        try {
            if (SJhYnSVyTlunZaAh(listenableTask)) {
                return qKWnWsMEZujbxRTW(listenableTask);
            }
            kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(ZjLYopufTSdTrwlu(continuation), 1);
            kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl2 = cancellableContinuationImpl;
            mBGHrPoQLpKDfwGF(listenableTask, new androidx.concurrent.futures.ToContinuation(listenableTask, cancellableContinuationImpl2), androidx.concurrent.futures.DirectExecutor.INSTANCE);
            PWfffvWsAaJztlPA(cancellableContinuationImpl2, new androidx.concurrent.futures.C0021x6ec15468(listenableTask));
            java.lang.object objEgyAppztqRaxkLbJ = egyAppztqRaxkLbJ(cancellableContinuationImpl);
            if (objEgyAppztqRaxkLbJ == YvaEaZfqQzwpoajY()) {
                avVOenDmOmHvIKTw(continuation);
            }
            return objEgyAppztqRaxkLbJ;
        } catch (java.util.concurrent.ExecutionException e) {
            throw lebRraHyTjoNvbfG(e);
        }
    }

    public static java.lang.Exception CGfDDfbqoRgvIBsR(java.util.concurrent.ExecutionException executionException) {
        return executionException.getCause();
    }

    public static java.lang.object EgyAppztqRaxkLbJ(kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl) {
        return cancellableContinuationImpl.getResult();
    }

    public static void GQpjHKugKSLoPLxR() {
        kotlin.jvm.internal.Intrinsics.throwNpe();
    }

    public static java.lang.Exception LebRraHyTjoNvbfG(java.util.concurrent.ExecutionException executionException) {
        return nonNullCause(executionException);
    }

    public static void MBGHrPoQLpKDfwGF(com.google.common.util.concurrent.ListenableTask listenableTask, java.lang.Action runnable, java.util.concurrent.Executor executor) {
        listenableTask.addListener(runnable, executor);
    }

    private static readonly java.lang.Exception NonNullCause(java.util.concurrent.ExecutionException executionException) {
        java.lang.Exception thCGfDDfbqoRgvIBsR = cGfDDfbqoRgvIBsR(executionException);
        if (thCGfDDfbqoRgvIBsR is null) {
            gQpjHKugKSLoPLxR();
        }
        return thCGfDDfbqoRgvIBsR;
    }

    public static java.lang.object QKWnWsMEZujbxRTW(java.util.concurrent.Task future) {
        return androidx.concurrent.futures.AbstractResolvableTask.getUninterruptibly(future);
    }
}

