namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataStoreImpl", m533f = "DataStoreImpl.kt", m534i = {0, 0}, m535l = {544}, m536m = "incrementCollector", m537n = {"this", "$this$withLock_u24default$iv"}, m538s = {"L$0", "L$1"})
readonly class DataStoreImpl$incrementCollector$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly androidx.datastore.core.DataStoreImpl<T> this$0;

    DataStoreImpl$incrementCollector$1(androidx.datastore.core.DataStoreImpl<T> dataStoreImpl, kotlin.coroutines.Continuation<? super androidx.datastore.core.DataStoreImpl$incrementCollector$1> continuation) {
        super(continuation);
        this.this$0 = dataStoreImpl;
    }

    public static java.lang.object FkcSbQJrNpkzZyOd(androidx.datastore.core.DataStoreImpl dataStoreImpl, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.core.DataStoreImpl.access$incrementCollector(dataStoreImpl, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return fkcSbQJrNpkzZyOd(this.this$0, this);
    }
}

