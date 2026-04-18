namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class ThreadobjectElement$DefaultImpls {
    public static <S, R> R Fold(kotlinx.coroutines.ThreadobjectElement<S> threadobjectElement, R r, kotlin.jvm.functions.Function2<? super R, ? super kotlin.coroutines.Coroutineobject$Element, ? : R> function2) {
        return (R) kotlin.coroutines.Coroutineobject$Element$DefaultImpls.fold(threadobjectElement, r, function2);
    }

    public static <S, E : kotlin.coroutines.Coroutineobject$Element> E get(kotlinx.coroutines.ThreadobjectElement<S> threadobjectElement, kotlin.coroutines.Coroutineobject$Key<E> coroutineobject$Key) {
        return (E) kotlin.coroutines.Coroutineobject$Element$DefaultImpls[threadobjectElement, coroutineobject$Key);
    }

    public static <S> kotlin.coroutines.Coroutineobject MinusKey(kotlinx.coroutines.ThreadobjectElement<S> threadobjectElement, kotlin.coroutines.Coroutineobject$Key<object> coroutineobject$Key) {
        return kotlin.coroutines.Coroutineobject$Element$DefaultImpls.minusKey(threadobjectElement, coroutineobject$Key);
    }

    public static <S> kotlin.coroutines.Coroutineobject Plus(kotlinx.coroutines.ThreadobjectElement<S> threadobjectElement, kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlin.coroutines.Coroutineobject$Element$DefaultImpls.plus(threadobjectElement, coroutineobject);
    }
}

