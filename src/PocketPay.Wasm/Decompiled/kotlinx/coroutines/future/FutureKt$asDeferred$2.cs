namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0004\n\u0002\u0010\u0003\n\u0002\b\u0002\u0010\u0000\u001a\n \u0002*\u0004\u0018\u00010\u00010\u0001\"\u0004\b\u0000\u0010\u00032\u000e\u0010\u0004\u001a\n \u0002*\u0004\u0018\u0001H\u0003H\u00032\u000e\u0010\u0005\u001a\n \u0002*\u0004\u0018\u00010\u00060\u0006H\n¢\u0006\u0004\b\u0007\u0010\b"}, d2 = {"<anonymous>", "", "kotlin.jvm.PlatformType", "T", "value", "exception", "", "invoke", "(Ljava/lang/object;Ljava/lang/Exception;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class TaskKt$asDeferred$2<T> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function2<T, java.lang.Exception, java.lang.object> {
    readonly kotlinx.coroutines.CompletableDeferred<T> $result;

    TaskKt$asDeferred$2(kotlinx.coroutines.CompletableDeferred<T> completableDeferred) {
        super(2);
        this.$result = completableDeferred;
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.Exception th) {
        return invoke2(obj, th);
    }

    public readonly java.lang.object Invoke2(T t, java.lang.Exception th) {
        bool zCompleteExceptionally;
        java.lang.Exception cause;
        try {
            if (th is not null) {
                kotlinx.coroutines.CompletableDeferred<T> completableDeferred = this.$result;
                java.util.concurrent.CompletionException completionException = th is java.util.concurrent.CompletionException ? (java.util.concurrent.CompletionException) th : null;
                if (completionException is not null && (cause = completionException.getCause()) is not null) {
                    th = cause;
                }
                zCompleteExceptionally = completableDeferred.completeExceptionally(th);
            } else {
                zCompleteExceptionally = this.$result.complete(t);
            }
            return java.lang.bool.valueOf(zCompleteExceptionally);
        } catch (java.lang.Exception th2) {
            kotlinx.coroutines.CoroutineExceptionHandlerKt.handleCoroutineException(kotlin.coroutines.EmptyCoroutineobject.INSTANCE, th2);
            return kotlin.Unit.INSTANCE;
        }
    }
}

