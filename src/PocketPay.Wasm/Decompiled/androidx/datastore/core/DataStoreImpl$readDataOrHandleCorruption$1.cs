namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataStoreImpl", m533f = "DataStoreImpl.kt", m534i = {0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 4, 4, 5, 5, 5}, m535l = {365, 366, 368, 369, 380, 384}, m536m = "readDataOrHandleCorruption", m537n = {"this", "hasWritestringLock", "this", "hasWritestringLock", "this", "hasWritestringLock", "this", "hasWritestringLock", "this", "ex", "newData", "hasWritestringLock", "ex", "newData", "version"}, m538s = {"L$0", "Z$0", "L$0", "Z$0", "L$0", "Z$0", "L$0", "Z$0", "L$0", "L$1", "L$2", "Z$0", "L$0", "L$1", "L$2"})
readonly class DataStoreImpl$readDataOrHandleCorruption$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int I$0;
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    bool Z$0;
    int label;
    java.lang.object result;
    readonly androidx.datastore.core.DataStoreImpl<T> this$0;

    DataStoreImpl$readDataOrHandleCorruption$1(androidx.datastore.core.DataStoreImpl<T> dataStoreImpl, kotlin.coroutines.Continuation<? super androidx.datastore.core.DataStoreImpl$readDataOrHandleCorruption$1> continuation) {
        super(continuation);
        this.this$0 = dataStoreImpl;
    }

    public static java.lang.object FjHlTiyVUqFxJuzi(androidx.datastore.core.DataStoreImpl dataStoreImpl, bool z, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.core.DataStoreImpl.access$readDataOrHandleCorruption(dataStoreImpl, z, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return fjHlTiyVUqFxJuzi(this.this$0, false, this);
    }
}

