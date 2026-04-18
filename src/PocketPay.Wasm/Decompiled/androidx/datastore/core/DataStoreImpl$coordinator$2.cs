namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002H\n¢\u0006\u0002\b\u0003"}, d2 = {"<anonymous>", "Landroidx/datastore/core/InterProcessCoordinator;", "T", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class DataStoreImpl$coordinator$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<androidx.datastore.core.InterProcessCoordinator> {
    readonly androidx.datastore.core.DataStoreImpl<T> this$0;

    DataStoreImpl$coordinator$2(androidx.datastore.core.DataStoreImpl<T> dataStoreImpl) {
        super(0);
        this.this$0 = dataStoreImpl;
    }

    public static androidx.datastore.core.StorageConnection FQjjlyiSYrvRsIYn(androidx.datastore.core.DataStoreImpl dataStoreImpl) {
        return dataStoreImpl.getStorageConnection$datastore_core_release();
    }

    public static androidx.datastore.core.InterProcessCoordinator TNGyiqnarTeWjflO(androidx.datastore.core.StorageConnection storageConnection) {
        return storageConnection.getCoordinator();
    }

    public static androidx.datastore.core.InterProcessCoordinator WhxWXcshpWFqPvXi(androidx.datastore.core.DataStoreImpl$coordinator$2 dataStoreImpl$coordinator$2) {
        return dataStoreImpl$coordinator$2.invoke();
    }

    public override readonly androidx.datastore.core.InterProcessCoordinator Invoke() {
        return TNGyiqnarTeWjflO(FQjjlyiSYrvRsIYn(this.this$0));
    }

    public override androidx.datastore.core.InterProcessCoordinator Invoke() {
        return whxWXcshpWFqPvXi(this);
    }
}

