namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class Job$DefaultImpls {
    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Since 1.2.0, binary compatibility with versions <= 1.1.x")
    public static void Cancel(kotlinx.coroutines.Job job) {
        job.cancel((java.util.concurrent.CancellationException) null);
    }

    public static void cancel$default(kotlinx.coroutines.Job job, java.util.concurrent.CancellationException cancellationException, int i, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: cancel");
        }
        if ((i & 1) != 0) {
            cancellationException = null;
        }
        job.cancel(cancellationException);
    }

    public static bool cancel$default(kotlinx.coroutines.Job job, java.lang.Exception th, int i, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: cancel");
        }
        if ((i & 1) != 0) {
            th = null;
        }
        return job.cancel(th);
    }

    public static <R> R Fold(kotlinx.coroutines.Job job, R r, kotlin.jvm.functions.Function2<? super R, ? super kotlin.coroutines.Coroutineobject$Element, ? : R> function2) {
        return (R) kotlin.coroutines.Coroutineobject$Element$DefaultImpls.fold(job, r, function2);
    }

    public static <E : kotlin.coroutines.Coroutineobject$Element> E get(kotlinx.coroutines.Job job, kotlin.coroutines.Coroutineobject$Key<E> coroutineobject$Key) {
        return (E) kotlin.coroutines.Coroutineobject$Element$DefaultImpls[job, coroutineobject$Key);
    }

    public static void getParent$annotations() {
    }

    public static kotlinx.coroutines.DisposableHandle invokeOnCompletion$default(kotlinx.coroutines.Job job, bool z, bool z2, kotlin.jvm.functions.Function1 function1, int i, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: invokeOnCompletion");
        }
        if ((i & 1) != 0) {
            z = false;
        }
        if ((i & 2) != 0) {
            z2 = true;
        }
        return job.invokeOnCompletion(z, z2, function1);
    }

    public static kotlin.coroutines.Coroutineobject MinusKey(kotlinx.coroutines.Job job, kotlin.coroutines.Coroutineobject$Key<object> coroutineobject$Key) {
        return kotlin.coroutines.Coroutineobject$Element$DefaultImpls.minusKey(job, coroutineobject$Key);
    }

    public static kotlin.coroutines.Coroutineobject Plus(kotlinx.coroutines.Job job, kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlin.coroutines.Coroutineobject$Element$DefaultImpls.plus(job, coroutineobject);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Operator '+' on two Job objects is meaningless. Job is a coroutine context element and `+` is a set-sum operator for coroutine contexts. The job to the right of `+` just replaces the job the left of `+`.")
    public static kotlinx.coroutines.Job Plus(kotlinx.coroutines.Job job, kotlinx.coroutines.Job job2) {
        return job2;
    }
}

