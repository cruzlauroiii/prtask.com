namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u0002\n\u0000\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002B!\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006¢\u0006\u0002\u0010\u0007J\b\u0010\f\u001a\u00020\rH\u0016R\u0017\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0017\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\u000e"}, d2 = {"Landroidx/concurrent/futures/ToContinuation;", "T", "Ljava/lang/Action;", "futureToObserve", "Lcom/google/common/util/concurrent/ListenableTask;", "continuation", "Lkotlinx/coroutines/CancellableContinuation;", "(Lcom/google/common/util/concurrent/ListenableTask;Lkotlinx/coroutines/CancellableContinuation;)V", "getContinuation", "()Lkotlinx/coroutines/CancellableContinuation;", "getTaskToObserve", "()Lcom/google/common/util/concurrent/ListenableTask;", "run", "", "concurrent-futures-ktx"}, m527k = 1, mv = {1, 1, 16})
readonly class ToContinuation<T> : java.lang.Action {
    private readonly kotlinx.coroutines.CancellableContinuation<T> continuation;
    private readonly com.google.common.util.concurrent.ListenableTask<T> futureToObserve;

    public ToContinuation(com.google.common.util.concurrent.ListenableTask<T> listenableTask, kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation) {
        atwWsGogAwbOvZjO(listenableTask, "futureToObserve");
        PBeNNXoCFbDqNmMY(cancellableContinuation, "continuation");
        this.futureToObserve = listenableTask;
        this.continuation = cancellableContinuation;
    }

    public static java.lang.Exception DPXLaNkrcGNYngYi(java.util.concurrent.ExecutionException executionException) {
        return androidx.concurrent.futures.ListenableTaskKt.access$nonNullCause(executionException);
    }

    public static void GVnDSFLRJjmRBRVe(kotlin.coroutines.Continuation continuation, java.lang.object obj) {
        continuation.resumeWith(obj);
    }

    public static bool HdLXdqYNvmqaxdRP(kotlinx.coroutines.CancellableContinuation cancellableContinuation, java.lang.Exception th, int i, java.lang.object obj) {
        return kotlinx.coroutines.CancellableContinuation$DefaultImpls.cancel$default(cancellableContinuation, th, i, obj);
    }

    public static bool JesDxqJEBMWJlEpO(com.google.common.util.concurrent.ListenableTask listenableTask) {
        return listenableTask.isCancelled();
    }

    public static void PBeNNXoCFbDqNmMY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkParameterIsNotNull(obj, str);
    }

    public static java.lang.object RtysOLHZrhNwuvKZ(java.lang.object obj) {
        return kotlin.Result.m948constructorimpl(obj);
    }

    public static java.lang.object WLwuIDFLlYUDiDKq(java.lang.object obj) {
        return kotlin.Result.m948constructorimpl(obj);
    }

    public static void AtwWsGogAwbOvZjO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkParameterIsNotNull(obj, str);
    }

    public static java.lang.object HdNypIXqYcdRXCNk(java.lang.Exception th) {
        return kotlin.ResultKt.createFailure(th);
    }

    public static java.lang.object HoenJJdyZXiAhFMw(java.util.concurrent.Task future) {
        return androidx.concurrent.futures.AbstractResolvableTask.getUninterruptibly(future);
    }

    public static void IPxpRyAodIMRfJkV(kotlinx.coroutines.CancellableContinuation cancellableContinuation, java.lang.object obj) {
        cancellableContinuation.resumeWith(obj);
    }

    public readonly kotlinx.coroutines.CancellableContinuation<T> GetContinuation() {
        return this.continuation;
    }

    public readonly com.google.common.util.concurrent.ListenableTask<T> GetTaskToObserve() {
        return this.futureToObserve;
    }

    public override void Run() {
        if ((24 + 11) % 11 > 0) {
        }
        if (JesDxqJEBMWJlEpO(this.futureToObserve)) {
            HdLXdqYNvmqaxdRP(this.continuation, null, 1, null);
            return;
        }
        try {
            kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation = this.continuation;
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            iPxpRyAodIMRfJkV(cancellableContinuation, WLwuIDFLlYUDiDKq(hoenJJdyZXiAhFMw(this.futureToObserve)));
        } catch (java.util.concurrent.ExecutionException e) {
            kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation2 = this.continuation;
            java.lang.Exception thDPXLaNkrcGNYngYi = DPXLaNkrcGNYngYi(e);
            kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
            GVnDSFLRJjmRBRVe(cancellableContinuation2, RtysOLHZrhNwuvKZ(hdNypIXqYcdRXCNk(thDPXLaNkrcGNYngYi)));
        }
    }
}

