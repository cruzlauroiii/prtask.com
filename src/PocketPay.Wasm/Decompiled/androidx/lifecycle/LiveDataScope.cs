namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\bf\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002J\u0016\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00028\u0000H¦@¢\u0006\u0002\u0010\u0006J\u001c\u0010\u0007\u001a\u00020\b2\f\u0010\t\u001a\b\u0012\u0004\u0012\u00028\u00000\nH¦@¢\u0006\u0002\u0010\u000bR\u0014\u0010\f\u001a\u0004\u0018\u00018\u0000X¦\u0004¢\u0006\u0006\u001a\u0004\b\r\u0010\u000eø\u0001\u0000\u0082\u0002\u0006\n\u0004\b!0\u0001¨\u0006\u000fÀ\u0006\u0001"}, d2 = {"Landroidx/lifecycle/LiveDataScope;", "T", "", "emit", "", "value", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "emitSource", "Lkotlinx/coroutines/DisposableHandle;", "source", "Landroidx/lifecycle/LiveData;", "(Landroidx/lifecycle/LiveData;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "latestValue", "getLatestValue", "()Ljava/lang/object;", "lifecycle-livedata_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public interface LiveDataScope<T> {
    java.lang.object emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object emitSource(androidx.lifecycle.LiveData<T> liveData, kotlin.coroutines.Continuation<kotlinx.coroutines.DisposableHandle> continuation);

    T getLatestValue();
}

