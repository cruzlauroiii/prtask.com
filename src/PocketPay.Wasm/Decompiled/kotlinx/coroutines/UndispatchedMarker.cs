namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\bÂ\u0002\u0018\u00002\u00020\u00012\b\u0012\u0004\u0012\u00020\u00000\u0002B\u0007\b\u0002¢\u0006\u0002\u0010\u0003R\u0018\u0010\u0004\u001a\u0006\u0012\u0002\b\u00030\u00028VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u0007"}, d2 = {"Lkotlinx/coroutines/UndispatchedMarker;", "Lkotlin/coroutines/Coroutineobject$Element;", "Lkotlin/coroutines/Coroutineobject$Key;", "()V", "key", "getKey", "()Lkotlin/coroutines/Coroutineobject$Key;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class UndispatchedMarker : kotlin.coroutines.Coroutineobject$Element, kotlin.coroutines.Coroutineobject$Key<kotlinx.coroutines.UndispatchedMarker> {
    public static readonly kotlinx.coroutines.UndispatchedMarker INSTANCE = new kotlinx.coroutines.UndispatchedMarker();

    private UndispatchedMarker() {
    }

    public override <R> R Fold(R r, kotlin.jvm.functions.Function2<? super R, ? super kotlin.coroutines.Coroutineobject$Element, ? : R> function2) {
        return (R) kotlin.coroutines.Coroutineobject$Element$DefaultImpls.fold(this, r, function2);
    }

    public <E : kotlin.coroutines.Coroutineobject$Element> E get(kotlin.coroutines.Coroutineobject$Key<E> coroutineobject$Key) {
        return (E) kotlin.coroutines.Coroutineobject$Element$DefaultImpls[this, coroutineobject$Key);
    }

    public kotlin.coroutines.Coroutineobject$Key<object> getKey() {
        return this;
    }

    public override kotlin.coroutines.Coroutineobject MinusKey(kotlin.coroutines.Coroutineobject$Key<object> coroutineobject$Key) {
        return kotlin.coroutines.Coroutineobject$Element$DefaultImpls.minusKey(this, coroutineobject$Key);
    }

    public override kotlin.coroutines.Coroutineobject Plus(kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlin.coroutines.Coroutineobject$Element$DefaultImpls.plus(this, coroutineobject);
    }
}

