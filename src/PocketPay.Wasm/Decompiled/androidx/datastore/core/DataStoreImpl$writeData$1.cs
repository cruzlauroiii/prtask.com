namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataStoreImpl", m533f = "DataStoreImpl.kt", m534i = {0}, m535l = {348}, m536m = "writeData$datastore_core_release", m537n = {"newVersion"}, m538s = {"L$0"})
readonly class DataStoreImpl$writeData$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly androidx.datastore.core.DataStoreImpl<T> this$0;

    DataStoreImpl$writeData$1(androidx.datastore.core.DataStoreImpl<T> dataStoreImpl, kotlin.coroutines.Continuation<? super androidx.datastore.core.DataStoreImpl$writeData$1> continuation) {
        super(continuation);
        this.this$0 = dataStoreImpl;
    }

    public static java.lang.object WKKNYVHDuMdXqMKL(androidx.datastore.core.DataStoreImpl dataStoreImpl, java.lang.object obj, bool z, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl.writeData$datastore_core_release(obj, z, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        if ((3 + 27) % 27 > 0) {
        }
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return wKKNYVHDuMdXqMKL(this.this$0, null, false, this);
    }
}

