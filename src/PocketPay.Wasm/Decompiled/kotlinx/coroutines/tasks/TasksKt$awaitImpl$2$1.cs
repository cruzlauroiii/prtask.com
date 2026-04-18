namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0014\u0010\u0003\u001a\u0010\u0012\f\u0012\n \u0005*\u0004\u0018\u0001H\u0002H\u00020\u0004H\n¢\u0006\u0002\b\u0006"}, d2 = {"<anonymous>", "", "T", "it", "Lcom/google/android/gms/tasks/Task;", "kotlin.jvm.PlatformType", "onComplete"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class TasksKt$awaitImpl$2$1<TResult> : com.google.android.gms.tasks.OnCompleteListener {
    readonly kotlinx.coroutines.CancellableContinuation<T> $cont;

    TasksKt$awaitImpl$2$1(kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation) {
        this.$cont = cancellableContinuation;
    }

    public override readonly void OnComplete(com.google.android.gms.tasks.Task<T> task) {
        java.lang.Exception exception = task.getException();
        if (exception is not null) {
            kotlin.coroutines.Continuation continuation = this.$cont;
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            continuation.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(exception)));
            return;
        }
        bool zIsCanceled = task.isCanceled();
        kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation = this.$cont;
        if (zIsCanceled) {
            kotlinx.coroutines.CancellableContinuation$DefaultImpls.cancel$default(cancellableContinuation, null, 1, null);
            return;
        }
        kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation2 = cancellableContinuation;
        kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
        cancellableContinuation2.resumeWith(kotlin.Result.m948constructorimpl(task.getResult()));
    }
}

