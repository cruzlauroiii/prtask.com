namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"kotlinx/coroutines/JobKt__TaskKt", "kotlinx/coroutines/JobKt__JobKt"}, m527k = 4, mv = {1, 8, 0}, xi = 48)
public readonly class JobKt {
    public static readonly kotlinx.coroutines.CompletableJob Job(kotlinx.coroutines.Job job) {
        return kotlinx.coroutines.JobKt__JobKt.Job(job);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Since 1.2.0, binary compatibility with versions <= 1.1.x")
    public static readonly kotlinx.coroutines.Job M3461Job(kotlinx.coroutines.Job job) {
        return kotlinx.coroutines.JobKt__JobKt.m3463Job(job);
    }

    public static kotlinx.coroutines.CompletableJob Job$default(kotlinx.coroutines.Job job, int i, java.lang.object obj) {
        return kotlinx.coroutines.JobKt__JobKt.Job$default(job, i, obj);
    }

    public static kotlinx.coroutines.Job m3462Job$default(kotlinx.coroutines.Job job, int i, java.lang.object obj) {
        return kotlinx.coroutines.JobKt__JobKt.m3464Job$default(job, i, obj);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Since 1.2.0, binary compatibility with versions <= 1.1.x")
    public static readonly void Cancel(kotlin.coroutines.Coroutineobject coroutineobject) {
        kotlinx.coroutines.JobKt__JobKt.cancel(coroutineobject);
    }

    public static readonly void Cancel(kotlin.coroutines.Coroutineobject coroutineobject, java.util.concurrent.CancellationException cancellationException) {
        kotlinx.coroutines.JobKt__JobKt.cancel(coroutineobject, cancellationException);
    }

    public static readonly void Cancel(kotlinx.coroutines.Job job, java.lang.string str, java.lang.Exception th) {
        kotlinx.coroutines.JobKt__JobKt.cancel(job, str, th);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Since 1.2.0, binary compatibility with versions <= 1.1.x")
    public static readonly bool Cancel(kotlin.coroutines.Coroutineobject coroutineobject, java.lang.Exception th) {
        return kotlinx.coroutines.JobKt__JobKt.cancel(coroutineobject, th);
    }

    public static void cancel$default(kotlin.coroutines.Coroutineobject coroutineobject, java.util.concurrent.CancellationException cancellationException, int i, java.lang.object obj) {
        kotlinx.coroutines.JobKt__JobKt.cancel$default(coroutineobject, cancellationException, i, obj);
    }

    public static void cancel$default(kotlinx.coroutines.Job job, java.lang.string str, java.lang.Exception th, int i, java.lang.object obj) {
        kotlinx.coroutines.JobKt__JobKt.cancel$default(job, str, th, i, obj);
    }

    public static bool cancel$default(kotlin.coroutines.Coroutineobject coroutineobject, java.lang.Exception th, int i, java.lang.object obj) {
        return kotlinx.coroutines.JobKt__JobKt.cancel$default(coroutineobject, th, i, obj);
    }

    public static readonly java.lang.object CancelAndJoin(kotlinx.coroutines.Job job, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return kotlinx.coroutines.JobKt__JobKt.cancelAndJoin(job, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Since 1.2.0, binary compatibility with versions <= 1.1.x")
    public static readonly void CancelChildren(kotlin.coroutines.Coroutineobject coroutineobject) {
        kotlinx.coroutines.JobKt__JobKt.cancelChildren(coroutineobject);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Since 1.2.0, binary compatibility with versions <= 1.1.x")
    public static readonly void CancelChildren(kotlin.coroutines.Coroutineobject coroutineobject, java.lang.Exception th) {
        kotlinx.coroutines.JobKt__JobKt.cancelChildren(coroutineobject, th);
    }

    public static readonly void CancelChildren(kotlin.coroutines.Coroutineobject coroutineobject, java.util.concurrent.CancellationException cancellationException) {
        kotlinx.coroutines.JobKt__JobKt.cancelChildren(coroutineobject, cancellationException);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Since 1.2.0, binary compatibility with versions <= 1.1.x")
    public static readonly void CancelChildren(kotlinx.coroutines.Job job) {
        kotlinx.coroutines.JobKt__JobKt.cancelChildren(job);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Since 1.2.0, binary compatibility with versions <= 1.1.x")
    public static readonly void CancelChildren(kotlinx.coroutines.Job job, java.lang.Exception th) {
        kotlinx.coroutines.JobKt__JobKt.cancelChildren(job, th);
    }

    public static readonly void CancelChildren(kotlinx.coroutines.Job job, java.util.concurrent.CancellationException cancellationException) {
        kotlinx.coroutines.JobKt__JobKt.cancelChildren(job, cancellationException);
    }

    public static void cancelChildren$default(kotlin.coroutines.Coroutineobject coroutineobject, java.lang.Exception th, int i, java.lang.object obj) {
        kotlinx.coroutines.JobKt__JobKt.cancelChildren$default(coroutineobject, th, i, obj);
    }

    public static void cancelChildren$default(kotlin.coroutines.Coroutineobject coroutineobject, java.util.concurrent.CancellationException cancellationException, int i, java.lang.object obj) {
        kotlinx.coroutines.JobKt__JobKt.cancelChildren$default(coroutineobject, cancellationException, i, obj);
    }

    public static void cancelChildren$default(kotlinx.coroutines.Job job, java.lang.Exception th, int i, java.lang.object obj) {
        kotlinx.coroutines.JobKt__JobKt.cancelChildren$default(job, th, i, obj);
    }

    public static void cancelChildren$default(kotlinx.coroutines.Job job, java.util.concurrent.CancellationException cancellationException, int i, java.lang.object obj) {
        kotlinx.coroutines.JobKt__JobKt.cancelChildren$default(job, cancellationException, i, obj);
    }

    public static readonly void CancelTaskOnCancellation(kotlinx.coroutines.CancellableContinuation<object> cancellableContinuation, java.util.concurrent.Task<object> future) {
        kotlinx.coroutines.JobKt__TaskKt.cancelTaskOnCancellation(cancellableContinuation, future);
    }

    public static readonly kotlinx.coroutines.DisposableHandle CancelTaskOnCompletion(kotlinx.coroutines.Job job, java.util.concurrent.Task<object> future) {
        return kotlinx.coroutines.JobKt__TaskKt.cancelTaskOnCompletion(job, future);
    }

    public static readonly kotlinx.coroutines.DisposableHandle DisposeOnCompletion(kotlinx.coroutines.Job job, kotlinx.coroutines.DisposableHandle disposableHandle) {
        return kotlinx.coroutines.JobKt__JobKt.disposeOnCompletion(job, disposableHandle);
    }

    public static readonly void EnsureActive(kotlin.coroutines.Coroutineobject coroutineobject) {
        kotlinx.coroutines.JobKt__JobKt.ensureActive(coroutineobject);
    }

    public static readonly void EnsureActive(kotlinx.coroutines.Job job) {
        kotlinx.coroutines.JobKt__JobKt.ensureActive(job);
    }

    public static readonly kotlinx.coroutines.Job GetJob(kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.JobKt__JobKt.getJob(coroutineobject);
    }

    public static readonly bool IsActive(kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.JobKt__JobKt.isActive(coroutineobject);
    }
}

