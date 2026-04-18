namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0000\bf\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002J\u000e\u0010\u0003\u001a\u00020\u0004H¦@¢\u0006\u0002\u0010\u0005J\u0016\u0010\u0006\u001a\u00028\u00002\u0006\u0010\u0007\u001a\u00028\u0000H¦@¢\u0006\u0002\u0010\bJ\u0016\u0010\t\u001a\u00020\n2\u0006\u0010\u0007\u001a\u00028\u0000H¦@¢\u0006\u0002\u0010\bø\u0001\u0000\u0082\u0002\u0006\n\u0004\b!0\u0001¨\u0006\u000bÀ\u0006\u0001"}, d2 = {"Landroidx/datastore/core/DataMigration;", "T", "", "cleanUp", "", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "migrate", "currentData", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "shouldMigrate", "", "datastore-core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public interface DataMigration<T> {
    java.lang.object cleanUp(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object migrate(T t, kotlin.coroutines.Continuation<T> continuation);

    java.lang.object shouldMigrate(T t, kotlin.coroutines.Continuation<java.lang.bool> continuation);
}

