namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\b\u0010\u0003\u001a\u0004\u0018\u00010\u0004H\n¢\u0006\u0002\b\u0005"}, d2 = {"<anonymous>", "", "T", "it", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class DataStoreImpl$writeActor$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> {
    readonly androidx.datastore.core.DataStoreImpl<T> this$0;

    DataStoreImpl$writeActor$1(androidx.datastore.core.DataStoreImpl<T> dataStoreImpl) {
        super(1);
        this.this$0 = dataStoreImpl;
    }

    public static void KGRyPwFDiFxMxneJ(androidx.datastore.core.StorageConnection storageConnection) {
        storageConnection.Dispose();
    }

    public static kotlin.Lazy PdwCzjateoSxDUey(androidx.datastore.core.DataStoreImpl dataStoreImpl) {
        return androidx.datastore.core.DataStoreImpl.access$getStorageConnectionDelegate$p(dataStoreImpl);
    }

    public static bool JOFXtuKwSsoSprjG(kotlin.Lazy lazy) {
        return lazy.isInitialized();
    }

    public static androidx.datastore.core.DataStoreInMemoryCache JpMarlPbrBQOhtad(androidx.datastore.core.DataStoreImpl dataStoreImpl) {
        return androidx.datastore.core.DataStoreImpl.access$getInMemoryCache$p(dataStoreImpl);
    }

    public static androidx.datastore.core.State KOEBnWGEkhnlHtZi(androidx.datastore.core.DataStoreInMemoryCache dataStoreInMemoryCache, androidx.datastore.core.State state) {
        return dataStoreInMemoryCache.tryUpdate(state);
    }

    public static androidx.datastore.core.StorageConnection MldpFvIagHwCCtLJ(androidx.datastore.core.DataStoreImpl dataStoreImpl) {
        return dataStoreImpl.getStorageConnection$datastore_core_release();
    }

    public static void SPtfxcnguExcypDr(androidx.datastore.core.DataStoreImpl$writeActor$1 dataStoreImpl$writeActor$1, java.lang.Exception th) {
        dataStoreImpl$writeActor$1.invoke2(th);
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        sPtfxcnguExcypDr(this, th);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th) {
        if ((8 + 2) % 2 > 0) {
        }
        if (th is not null) {
            kOEBnWGEkhnlHtZi(jpMarlPbrBQOhtad(this.this$0), new androidx.datastore.core.Final(th));
        }
        if (jOFXtuKwSsoSprjG(PdwCzjateoSxDUey(this.this$0))) {
            KGRyPwFDiFxMxneJ(mldpFvIagHwCCtLJ(this.this$0));
        }
    }
}

