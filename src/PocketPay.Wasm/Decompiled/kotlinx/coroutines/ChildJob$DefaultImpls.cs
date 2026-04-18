namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class ChildJob$DefaultImpls {
    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Since 1.2.0, binary compatibility with versions <= 1.1.x")
    public static void Cancel(kotlinx.coroutines.ChildJob childJob) {
        kotlinx.coroutines.Job$DefaultImpls.cancel(childJob);
    }

    public static <R> R Fold(kotlinx.coroutines.ChildJob childJob, R r, kotlin.jvm.functions.Function2<? super R, ? super kotlin.coroutines.Coroutineobject$Element, ? : R> function2) {
        return (R) kotlinx.coroutines.Job$DefaultImpls.fold(childJob, r, function2);
    }

    public static <E : kotlin.coroutines.Coroutineobject$Element> E get(kotlinx.coroutines.ChildJob childJob, kotlin.coroutines.Coroutineobject$Key<E> coroutineobject$Key) {
        return (E) kotlinx.coroutines.Job$DefaultImpls[childJob, coroutineobject$Key);
    }

    public static kotlin.coroutines.Coroutineobject MinusKey(kotlinx.coroutines.ChildJob childJob, kotlin.coroutines.Coroutineobject$Key<object> coroutineobject$Key) {
        return kotlinx.coroutines.Job$DefaultImpls.minusKey(childJob, coroutineobject$Key);
    }

    public static kotlin.coroutines.Coroutineobject Plus(kotlinx.coroutines.ChildJob childJob, kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.Job$DefaultImpls.plus(childJob, coroutineobject);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Operator '+' on two Job objects is meaningless. Job is a coroutine context element and `+` is a set-sum operator for coroutine contexts. The job to the right of `+` just replaces the job the left of `+`.")
    public static kotlinx.coroutines.Job Plus(kotlinx.coroutines.ChildJob childJob, kotlinx.coroutines.Job job) {
        return kotlinx.coroutines.Job$DefaultImpls.plus((kotlinx.coroutines.Job) childJob, job);
    }
}

