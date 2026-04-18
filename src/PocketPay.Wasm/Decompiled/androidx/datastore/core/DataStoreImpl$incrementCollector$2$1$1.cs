namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u00020\u0001H\u008a@¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "T", "it", "emit", "(Lkotlin/Unit;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class DataStoreImpl$incrementCollector$2$1$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly androidx.datastore.core.DataStoreImpl<T> this$0;

    DataStoreImpl$incrementCollector$2$1$1(androidx.datastore.core.DataStoreImpl<T> dataStoreImpl) {
        this.this$0 = dataStoreImpl;
    }

    public static androidx.datastore.core.State BxjWBMKRplWluLdt(androidx.datastore.core.DataStoreInMemoryCache dataStoreInMemoryCache) {
        return dataStoreInMemoryCache.getCurrentState();
    }

    public static java.lang.object HdDsSroFusgejUAu(androidx.datastore.core.DataStoreImpl dataStoreImpl, bool z, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.core.DataStoreImpl.access$readDataAndUpdateCache(dataStoreImpl, z, continuation);
    }

    public static java.lang.object OdZhpExFelPJprNV(androidx.datastore.core.DataStoreImpl$incrementCollector$2$1$1 dataStoreImpl$incrementCollector$2$1$1, kotlin.Unit unit, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$incrementCollector$2$1$1.emit(unit, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static androidx.datastore.core.DataStoreInMemoryCache JkVDVMMNYqgohabH(androidx.datastore.core.DataStoreImpl dataStoreImpl) {
        return androidx.datastore.core.DataStoreImpl.access$getInMemoryCache$p(dataStoreImpl);
    }

    public static java.lang.object KyBqrSJfugZFIrNy() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public override java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return OdZhpExFelPJprNV(this, (kotlin.Unit) obj, continuation);
    }

    public readonly java.lang.object Emit(kotlin.Unit unit, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if (BxjWBMKRplWluLdt(jkVDVMMNYqgohabH(this.this$0)) instanceof androidx.datastore.core.Final) {
            return kotlin.Unit.INSTANCE;
        }
        java.lang.object objHdDsSroFusgejUAu = HdDsSroFusgejUAu(this.this$0, true, continuation);
        return objHdDsSroFusgejUAu != kyBqrSJfugZFIrNy() ? kotlin.Unit.INSTANCE : objHdDsSroFusgejUAu;
    }
}

