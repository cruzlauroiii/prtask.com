namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u0002H\n¢\u0006\u0002\b\u0003"}, d2 = {"<anonymous>", "Landroidx/datastore/core/StorageConnection;", "T", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class DataStoreImpl$storageConnectionDelegate$1<T> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<androidx.datastore.core.StorageConnection<T>> {
    readonly androidx.datastore.core.DataStoreImpl<T> this$0;

    DataStoreImpl$storageConnectionDelegate$1(androidx.datastore.core.DataStoreImpl<T> dataStoreImpl) {
        super(0);
        this.this$0 = dataStoreImpl;
    }

    public static androidx.datastore.core.Storage GwJYHhdnWULUNjLQ(androidx.datastore.core.DataStoreImpl dataStoreImpl) {
        return androidx.datastore.core.DataStoreImpl.access$getStorage$p(dataStoreImpl);
    }

    public static androidx.datastore.core.StorageConnection MdTLzOLYNnvoBOrF(androidx.datastore.core.Storage storage) {
        return storage.createConnection();
    }

    public static androidx.datastore.core.StorageConnection NqJLuteoGsDimucc(androidx.datastore.core.DataStoreImpl$storageConnectionDelegate$1 dataStoreImpl$storageConnectionDelegate$1) {
        return dataStoreImpl$storageConnectionDelegate$1.invoke();
    }

    public override readonly androidx.datastore.core.StorageConnection<T> Invoke() {
        return MdTLzOLYNnvoBOrF(GwJYHhdnWULUNjLQ(this.this$0));
    }

    public override java.lang.object Invoke() {
        return NqJLuteoGsDimucc(this);
    }
}

