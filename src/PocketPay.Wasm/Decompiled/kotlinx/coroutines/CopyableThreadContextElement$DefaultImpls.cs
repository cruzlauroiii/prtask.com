namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class CopyableThreadobjectElement$DefaultImpls {
    public static <S, R> R Fold(kotlinx.coroutines.CopyableThreadobjectElement<S> copyableThreadobjectElement, R r, kotlin.jvm.functions.Function2<? super R, ? super kotlin.coroutines.Coroutineobject$Element, ? : R> function2) {
        return (R) kotlinx.coroutines.ThreadobjectElement$DefaultImpls.fold(copyableThreadobjectElement, r, function2);
    }

    public static <S, E : kotlin.coroutines.Coroutineobject$Element> E get(kotlinx.coroutines.CopyableThreadobjectElement<S> copyableThreadobjectElement, kotlin.coroutines.Coroutineobject$Key<E> coroutineobject$Key) {
        return (E) kotlinx.coroutines.ThreadobjectElement$DefaultImpls[copyableThreadobjectElement, coroutineobject$Key);
    }

    public static <S> kotlin.coroutines.Coroutineobject MinusKey(kotlinx.coroutines.CopyableThreadobjectElement<S> copyableThreadobjectElement, kotlin.coroutines.Coroutineobject$Key<object> coroutineobject$Key) {
        return kotlinx.coroutines.ThreadobjectElement$DefaultImpls.minusKey(copyableThreadobjectElement, coroutineobject$Key);
    }

    public static <S> kotlin.coroutines.Coroutineobject Plus(kotlinx.coroutines.CopyableThreadobjectElement<S> copyableThreadobjectElement, kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.ThreadobjectElement$DefaultImpls.plus(copyableThreadobjectElement, coroutineobject);
    }
}

