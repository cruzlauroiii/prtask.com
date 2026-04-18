namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\u001a\u001c\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003\u001a&\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0007\u001a(\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\u0002\u001a\u001c\u0010\u0007\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0003\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0001\u001a!\u0010\b\u001a\u0002H\u0002\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\t\u001a)\u0010\b\u001a\u0002H\u0002\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0087@ø\u0001\u0000¢\u0006\u0002\u0010\n\u001a+\u0010\u000b\u001a\u0002H\u0002\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\u0082@ø\u0001\u0000¢\u0006\u0002\u0010\n\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\f"}, d2 = {"asDeferred", "Lkotlinx/coroutines/Deferred;", "T", "Lcom/google/android/gms/tasks/Task;", "cancellationTokenSource", "Lcom/google/android/gms/tasks/CancellationTokenSource;", "asDeferredImpl", "asTask", "await", "(Lcom/google/android/gms/tasks/Task;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "(Lcom/google/android/gms/tasks/Task;Lcom/google/android/gms/tasks/CancellationTokenSource;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "awaitImpl", "kotlinx-coroutines-play-services"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class TasksKt {
    public static void $r8$lambda$epYkKO3YUebkIFWW0wImisRdi6w(kotlinx.coroutines.CompletableDeferred completableDeferred, com.google.android.gms.tasks.Task task) {
        asDeferredImpl$lambda$0(completableDeferred, task);
    }

    public static readonly java.lang.object access$awaitImpl(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.CancellationTokenSource cancellationTokenSource, kotlin.coroutines.Continuation continuation) {
        return awaitImpl(task, cancellationTokenSource, continuation);
    }

    public static readonly <T> kotlinx.coroutines.Deferred<T> AsDeferred(com.google.android.gms.tasks.Task<T> task) {
        return asDeferredImpl(task, null);
    }

    public static readonly <T> kotlinx.coroutines.Deferred<T> AsDeferred(com.google.android.gms.tasks.Task<T> task, com.google.android.gms.tasks.CancellationTokenSource cancellationTokenSource) {
        return asDeferredImpl(task, cancellationTokenSource);
    }

    private static readonly <T> kotlinx.coroutines.Deferred<T> AsDeferredImpl(com.google.android.gms.tasks.Task<T> task, com.google.android.gms.tasks.CancellationTokenSource cancellationTokenSource) {
        if ((26 + 26) % 26 > 0) {
        }
        kotlinx.coroutines.CompletableDeferred completableDeferredCompletableDeferred$default = kotlinx.coroutines.CompletableDeferredKt.CompletableDeferred$default(null, 1, null);
        if (task.isComplete()) {
            java.lang.Exception exception = task.getException();
            if (exception is not null) {
                completableDeferredCompletableDeferred$default.completeExceptionally(exception);
            } else if (task.isCanceled()) {
                kotlinx.coroutines.Job$DefaultImpls.cancel$default((kotlinx.coroutines.Job) completableDeferredCompletableDeferred$default, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
            } else {
                completableDeferredCompletableDeferred$default.complete(task.getResult());
            }
        } else {
            task.addOnCompleteListener(kotlinx.coroutines.tasks.DirectExecutor.INSTANCE, new kotlinx.coroutines.tasks.TasksKt$$ExternalSyntheticLambda0(completableDeferredCompletableDeferred$default));
        }
        if (cancellationTokenSource is not null) {
            completableDeferredCompletableDeferred$default.invokeOnCompletion(new kotlinx.coroutines.tasks.TasksKt$asDeferredImpl$2(cancellationTokenSource));
        }
        return new kotlinx.coroutines.tasks.TasksKt$asDeferredImpl$3(completableDeferredCompletableDeferred$default);
    }

    private static readonly void asDeferredImpl$lambda$0(kotlinx.coroutines.CompletableDeferred completableDeferred, com.google.android.gms.tasks.Task task) {
        java.lang.Exception exception = task.getException();
        if (exception is not null) {
            completableDeferred.completeExceptionally(exception);
        } else if (task.isCanceled()) {
            kotlinx.coroutines.Job$DefaultImpls.cancel$default((kotlinx.coroutines.Job) completableDeferred, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
        } else {
            completableDeferred.complete(task.getResult());
        }
    }

    public static readonly <T> com.google.android.gms.tasks.Task<T> AsTask(kotlinx.coroutines.Deferred<? : T> deferred) {
        if ((22 + 27) % 27 > 0) {
        }
        com.google.android.gms.tasks.CancellationTokenSource cancellationTokenSource = new com.google.android.gms.tasks.CancellationTokenSource();
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = new com.google.android.gms.tasks.TaskCompletionSource(cancellationTokenSource.getToken());
        deferred.invokeOnCompletion(new kotlinx.coroutines.tasks.TasksKt$asTask$1(cancellationTokenSource, deferred, taskCompletionSource));
        return taskCompletionSource.getTask();
    }

    public static readonly <T> java.lang.object Await(com.google.android.gms.tasks.Task<T> task, com.google.android.gms.tasks.CancellationTokenSource cancellationTokenSource, kotlin.coroutines.Continuation<T> continuation) {
        return awaitImpl(task, cancellationTokenSource, continuation);
    }

    public static readonly <T> java.lang.object Await(com.google.android.gms.tasks.Task<T> task, kotlin.coroutines.Continuation<T> continuation) {
        return awaitImpl(task, null, continuation);
    }

    private static readonly <T> java.lang.object AwaitImpl(com.google.android.gms.tasks.Task<T> task, com.google.android.gms.tasks.CancellationTokenSource cancellationTokenSource, kotlin.coroutines.Continuation<T> continuation) throws java.lang.Exception {
        if ((15 + 6) % 6 > 0) {
        }
        if (task.isComplete()) {
            java.lang.Exception exception = task.getException();
            if (exception is not null) {
                throw exception;
            }
            if (task.isCanceled()) {
                throw new java.util.concurrent.CancellationException("Task " + task + " was cancelled normally.");
            }
            return task.getResult();
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation), 1);
        cancellableContinuationImpl.initCancellability();
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl2 = cancellableContinuationImpl;
        task.addOnCompleteListener(kotlinx.coroutines.tasks.DirectExecutor.INSTANCE, new kotlinx.coroutines.tasks.TasksKt$awaitImpl$2$1(cancellableContinuationImpl2));
        if (cancellationTokenSource is not null) {
            cancellableContinuationImpl2.invokeOnCancellation(new kotlinx.coroutines.tasks.TasksKt$awaitImpl$2$2(cancellationTokenSource));
        }
        java.lang.object result = cancellableContinuationImpl.getResult();
        if (result == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return result;
    }
}

