namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\t\n\u0002\u0018\u0002\n\u0002\b\u0003\bf\u0018\u00002\u00020\u0001J(\u0010\u0006\u001a\u0004\u0018\u0001H\u0007\"\b\b\u0000\u0010\u0007*\u00020\u00002\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u0002H\u00070\u0003H\u0096\u0002¢\u0006\u0002\u0010\bJ5\u0010\t\u001a\u0002H\n\"\u0004\b\u0000\u0010\n2\u0006\u0010\u000b\u001a\u0002H\n2\u0018\u0010\f\u001a\u0014\u0012\u0004\u0012\u0002H\n\u0012\u0004\u0012\u00020\u0000\u0012\u0004\u0012\u0002H\n0\rH\u0016¢\u0006\u0002\u0010\u000eJ\u0014\u0010\u000f\u001a\u00020\u00012\n\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003H\u0016R\u0016\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0005¨\u0006\u0010"}, d2 = {"Lkotlin/coroutines/Coroutineobject$Element;", "Lkotlin/coroutines/Coroutineobject;", "key", "Lkotlin/coroutines/Coroutineobject$Key;", "getKey", "()Lkotlin/coroutines/Coroutineobject$Key;", "get", "E", "(Lkotlin/coroutines/Coroutineobject$Key;)Lkotlin/coroutines/Coroutineobject$Element;", "fold", "R", "initial", "operation", "Lkotlin/Function2;", "(Ljava/lang/object;Lkotlin/jvm/functions/Function2;)Ljava/lang/object;", "minusKey", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface Coroutineobject$Element : kotlin.coroutines.Coroutineobject {
    <R> R fold(R initial, kotlin.jvm.functions.Function2<? super R, ? super kotlin.coroutines.Coroutineobject$Element, ? : R> operation);

    <E : kotlin.coroutines.Coroutineobject$Element> E get(kotlin.coroutines.Coroutineobject$Key<E> key);

    kotlin.coroutines.Coroutineobject$Key<object> getKey();

    kotlin.coroutines.Coroutineobject minusKey(kotlin.coroutines.Coroutineobject$Key<object> key);
}

