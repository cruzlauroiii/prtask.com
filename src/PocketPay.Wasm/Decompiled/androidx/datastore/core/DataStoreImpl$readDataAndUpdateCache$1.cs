namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataStoreImpl", m533f = "DataStoreImpl.kt", m534i = {0, 0, 0, 1, 2}, m535l = {287, 296, 304}, m536m = "readDataAndUpdateCache", m537n = {"this", "currentState", "requireLock", "this", "this"}, m538s = {"L$0", "L$1", "Z$0", "L$0", "L$0"})
readonly class DataStoreImpl$readDataAndUpdateCache$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    bool Z$0;
    int label;
    java.lang.object result;
    readonly androidx.datastore.core.DataStoreImpl<T> this$0;

    DataStoreImpl$readDataAndUpdateCache$1(androidx.datastore.core.DataStoreImpl<T> dataStoreImpl, kotlin.coroutines.Continuation<? super androidx.datastore.core.DataStoreImpl$readDataAndUpdateCache$1> continuation) {
        super(continuation);
        this.this$0 = dataStoreImpl;
    }

    public static java.lang.object YgMeIJcmMiEjlzNF(androidx.datastore.core.DataStoreImpl dataStoreImpl, bool z, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.core.DataStoreImpl.access$readDataAndUpdateCache(dataStoreImpl, z, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return YgMeIJcmMiEjlzNF(this.this$0, false, this);
    }
}

