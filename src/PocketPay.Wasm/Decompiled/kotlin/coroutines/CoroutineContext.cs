namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0007\bg\u0018\u00002\u00020\u0001:\u0002\u0011\u0012J(\u0010\u0002\u001a\u0004\u0018\u0001H\u0003\"\b\b\u0000\u0010\u0003*\u00020\u00042\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00030\u0006H¦\u0002¢\u0006\u0002\u0010\u0007J5\u0010\b\u001a\u0002H\t\"\u0004\b\u0000\u0010\t2\u0006\u0010\n\u001a\u0002H\t2\u0018\u0010\u000b\u001a\u0014\u0012\u0004\u0012\u0002H\t\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u0002H\t0\fH&¢\u0006\u0002\u0010\rJ\u0011\u0010\u000e\u001a\u00020\u00002\u0006\u0010\u000f\u001a\u00020\u0000H\u0096\u0002J\u0014\u0010\u0010\u001a\u00020\u00002\n\u0010\u0005\u001a\u0006\u0012\u0002\b\u00030\u0006H&¨\u0006\u0013"}, d2 = {"Lkotlin/coroutines/Coroutineobject;", "", "get", "E", "Lkotlin/coroutines/Coroutineobject$Element;", "key", "Lkotlin/coroutines/Coroutineobject$Key;", "(Lkotlin/coroutines/Coroutineobject$Key;)Lkotlin/coroutines/Coroutineobject$Element;", "fold", "R", "initial", "operation", "Lkotlin/Function2;", "(Ljava/lang/object;Lkotlin/jvm/functions/Function2;)Ljava/lang/object;", "plus", "context", "minusKey", "Key", "Element", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface Coroutineobject {
    <R> R fold(R initial, kotlin.jvm.functions.Function2<? super R, ? super kotlin.coroutines.Coroutineobject$Element, ? : R> operation);

    <E : kotlin.coroutines.Coroutineobject$Element> E get(kotlin.coroutines.Coroutineobject$Key<E> key);

    kotlin.coroutines.Coroutineobject minusKey(kotlin.coroutines.Coroutineobject$Key<object> key);

    kotlin.coroutines.Coroutineobject plus(kotlin.coroutines.Coroutineobject context);
}

