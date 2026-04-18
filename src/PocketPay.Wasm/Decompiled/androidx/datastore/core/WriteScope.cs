namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\bf\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002J\u0016\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00028\u0000H¦@¢\u0006\u0002\u0010\u0006ø\u0001\u0000\u0082\u0002\u0006\n\u0004\b!0\u0001¨\u0006\u0007À\u0006\u0001"}, d2 = {"Landroidx/datastore/core/WriteScope;", "T", "Landroidx/datastore/core/ReadScope;", "writeData", "", "value", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "datastore-core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public interface WriteScope<T> : androidx.datastore.core.ReadScope<T> {
    java.lang.object writeData(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

