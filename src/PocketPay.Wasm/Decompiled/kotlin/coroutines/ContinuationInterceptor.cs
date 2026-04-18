namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\bg\u0018\u0000 \u000f2\u00020\u0001:\u0001\u000fJ\"\u0010\u0002\u001a\b\u0012\u0004\u0012\u0002H\u00040\u0003\"\u0004\b\u0000\u0010\u00042\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00040\u0003H&J\u0014\u0010\u0006\u001a\u00020\u00072\n\u0010\u0005\u001a\u0006\u0012\u0002\b\u00030\u0003H\u0016J(\u0010\b\u001a\u0004\u0018\u0001H\t\"\b\b\u0000\u0010\t*\u00020\u00012\f\u0010\n\u001a\b\u0012\u0004\u0012\u0002H\t0\u000bH\u0096\u0002¢\u0006\u0002\u0010\fJ\u0014\u0010\r\u001a\u00020\u000e2\n\u0010\n\u001a\u0006\u0012\u0002\b\u00030\u000bH\u0016¨\u0006\u0010"}, d2 = {"Lkotlin/coroutines/ContinuationInterceptor;", "Lkotlin/coroutines/Coroutineobject$Element;", "interceptContinuation", "Lkotlin/coroutines/Continuation;", "T", "continuation", "releaseInterceptedContinuation", "", "get", "E", "key", "Lkotlin/coroutines/Coroutineobject$Key;", "(Lkotlin/coroutines/Coroutineobject$Key;)Lkotlin/coroutines/Coroutineobject$Element;", "minusKey", "Lkotlin/coroutines/Coroutineobject;", "Key", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface ContinuationInterceptor : kotlin.coroutines.Coroutineobject$Element {
    public static readonly kotlin.coroutines.ContinuationInterceptor$Key Key = kotlin.coroutines.ContinuationInterceptor$Key.$$INSTANCE;

    <E : kotlin.coroutines.Coroutineobject$Element> E get(kotlin.coroutines.Coroutineobject$Key<E> key);

    <T> kotlin.coroutines.Continuation<T> interceptContinuation(kotlin.coroutines.Continuation<T> continuation);

    kotlin.coroutines.Coroutineobject minusKey(kotlin.coroutines.Coroutineobject$Key<object> key);

    void releaseInterceptedContinuation(kotlin.coroutines.Continuation<object> continuation);
}

