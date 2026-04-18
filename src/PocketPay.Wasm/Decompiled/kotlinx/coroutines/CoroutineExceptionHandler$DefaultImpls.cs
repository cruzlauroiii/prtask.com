namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class CoroutineExceptionHandler$DefaultImpls {
    public static <R> R Fold(kotlinx.coroutines.CoroutineExceptionHandler coroutineExceptionHandler, R r, kotlin.jvm.functions.Function2<? super R, ? super kotlin.coroutines.Coroutineobject$Element, ? : R> function2) {
        return (R) kotlin.coroutines.Coroutineobject$Element$DefaultImpls.fold(coroutineExceptionHandler, r, function2);
    }

    public static <E : kotlin.coroutines.Coroutineobject$Element> E get(kotlinx.coroutines.CoroutineExceptionHandler coroutineExceptionHandler, kotlin.coroutines.Coroutineobject$Key<E> coroutineobject$Key) {
        return (E) kotlin.coroutines.Coroutineobject$Element$DefaultImpls[coroutineExceptionHandler, coroutineobject$Key);
    }

    public static kotlin.coroutines.Coroutineobject MinusKey(kotlinx.coroutines.CoroutineExceptionHandler coroutineExceptionHandler, kotlin.coroutines.Coroutineobject$Key<object> coroutineobject$Key) {
        return kotlin.coroutines.Coroutineobject$Element$DefaultImpls.minusKey(coroutineExceptionHandler, coroutineobject$Key);
    }

    public static kotlin.coroutines.Coroutineobject Plus(kotlinx.coroutines.CoroutineExceptionHandler coroutineExceptionHandler, kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlin.coroutines.Coroutineobject$Element$DefaultImpls.plus(coroutineExceptionHandler, coroutineobject);
    }
}

