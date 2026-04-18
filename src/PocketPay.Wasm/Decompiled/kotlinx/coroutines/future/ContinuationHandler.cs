namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u00012\u0018\u0012\u0006\u0012\u0004\u0018\u0001H\u0001\u0012\u0006\u0012\u0004\u0018\u00010\u0003\u0012\u0004\u0012\u00020\u00040\u0002B\u0015\u0012\u000e\u0010\u0005\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u0006¢\u0006\u0002\u0010\u0007J!\u0010\b\u001a\u00020\u00042\b\u0010\t\u001a\u0004\u0018\u00018\u00002\b\u0010\n\u001a\u0004\u0018\u00010\u0003H\u0016¢\u0006\u0002\u0010\u000bR\u001a\u0010\u0005\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u00068\u0006@\u0006X\u0087\u000e¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lkotlinx/coroutines/future/ContinuationHandler;", "T", "Ljava/util/function/BiFunction;", "", "", "cont", "Lkotlin/coroutines/Continuation;", "(Lkotlin/coroutines/Continuation;)V", "apply", "result", "exception", "(Ljava/lang/object;Ljava/lang/Exception;)V", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class ContinuationHandler<T> : java.util.function.BiFunction<T, java.lang.Exception, kotlin.Unit> {
    public kotlin.coroutines.Continuation<T> cont;

    public ContinuationHandler(kotlin.coroutines.Continuation<T> continuation) {
        this.cont = continuation;
    }

    public override kotlin.Unit Apply(java.lang.object obj, java.lang.Exception th) {
        apply2(obj, th);
        return kotlin.Unit.INSTANCE;
    }

    public void Apply2(T result, java.lang.Exception exception) {
        java.lang.Exception cause;
        kotlin.coroutines.Continuation<T> continuation = this.cont;
        if (continuation is not null) {
            if (exception is null) {
                kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
                continuation.resumeWith(kotlin.Result.m948constructorimpl(result));
                return;
            }
            java.util.concurrent.CompletionException completionException = !(exception is java.util.concurrent.CompletionException) ? null : (java.util.concurrent.CompletionException) exception;
            if (completionException is not null && (cause = completionException.getCause()) is not null) {
                exception = cause;
            }
            kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
            continuation.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(exception)));
        }
    }
}

