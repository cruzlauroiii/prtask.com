namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\b\u0010\u0003\u001a\u0004\u0018\u00010\u0004H\n¢\u0006\u0002\b\u0005"}, d2 = {"<anonymous>", "", "T", "it", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class TasksKt$asTask$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> {
    readonly com.google.android.gms.tasks.CancellationTokenSource $cancellation;
    readonly com.google.android.gms.tasks.TaskCompletionSource<T> $source;
    readonly kotlinx.coroutines.Deferred<T> $this_asTask;

    TasksKt$asTask$1(com.google.android.gms.tasks.CancellationTokenSource cancellationTokenSource, kotlinx.coroutines.Deferred<? : T> deferred, com.google.android.gms.tasks.TaskCompletionSource<T> taskCompletionSource) {
        super(1);
        this.$cancellation = cancellationTokenSource;
        this.$this_asTask = deferred;
        this.$source = taskCompletionSource;
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        invoke2(th);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th) {
        if (th is java.util.concurrent.CancellationException) {
            this.$cancellation.cancel();
            return;
        }
        java.lang.Exception completionExceptionOrNull = this.$this_asTask.getCompletionExceptionOrNull();
        if (completionExceptionOrNull is null) {
            this.$source.setResult((T) this.$this_asTask.getCompleted());
            return;
        }
        com.google.android.gms.tasks.TaskCompletionSource<T> taskCompletionSource = this.$source;
        com.google.android.gms.tasks.RuntimeExecutionException runtimeExecutionException = !(completionExceptionOrNull is java.lang.Exception) ? null : (java.lang.Exception) completionExceptionOrNull;
        if (runtimeExecutionException is null) {
            runtimeExecutionException = new com.google.android.gms.tasks.RuntimeExecutionException(completionExceptionOrNull);
        }
        taskCompletionSource.setException(runtimeExecutionException);
    }
}

