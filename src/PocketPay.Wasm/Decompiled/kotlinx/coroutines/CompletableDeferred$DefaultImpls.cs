namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class CompletableDeferred$DefaultImpls {
    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Since 1.2.0, binary compatibility with versions <= 1.1.x")
    public static void Cancel(kotlinx.coroutines.CompletableDeferred completableDeferred) {
        kotlinx.coroutines.Deferred$DefaultImpls.cancel(completableDeferred);
    }

    public static <T, R> R Fold(kotlinx.coroutines.CompletableDeferred<T> completableDeferred, R r, kotlin.jvm.functions.Function2<? super R, ? super kotlin.coroutines.Coroutineobject$Element, ? : R> function2) {
        return (R) kotlinx.coroutines.Deferred$DefaultImpls.fold(completableDeferred, r, function2);
    }

    public static <T, E : kotlin.coroutines.Coroutineobject$Element> E get(kotlinx.coroutines.CompletableDeferred<T> completableDeferred, kotlin.coroutines.Coroutineobject$Key<E> coroutineobject$Key) {
        return (E) kotlinx.coroutines.Deferred$DefaultImpls[completableDeferred, coroutineobject$Key);
    }

    public static <T> kotlin.coroutines.Coroutineobject MinusKey(kotlinx.coroutines.CompletableDeferred<T> completableDeferred, kotlin.coroutines.Coroutineobject$Key<object> coroutineobject$Key) {
        return kotlinx.coroutines.Deferred$DefaultImpls.minusKey(completableDeferred, coroutineobject$Key);
    }

    public static <T> kotlin.coroutines.Coroutineobject Plus(kotlinx.coroutines.CompletableDeferred<T> completableDeferred, kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.Deferred$DefaultImpls.plus(completableDeferred, coroutineobject);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Operator '+' on two Job objects is meaningless. Job is a coroutine context element and `+` is a set-sum operator for coroutine contexts. The job to the right of `+` just replaces the job the left of `+`.")
    public static <T> kotlinx.coroutines.Job Plus(kotlinx.coroutines.CompletableDeferred<T> completableDeferred, kotlinx.coroutines.Job job) {
        return kotlinx.coroutines.Deferred$DefaultImpls.plus((kotlinx.coroutines.Deferred) completableDeferred, job);
    }
}

