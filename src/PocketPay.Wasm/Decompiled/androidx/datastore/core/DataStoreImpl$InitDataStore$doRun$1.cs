namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataStoreImpl$InitDataStore", m533f = "DataStoreImpl.kt", m534i = {0, 1}, m535l = {430, 434}, m536m = "doRun", m537n = {"this", "this"}, m538s = {"L$0", "L$0"})
readonly class DataStoreImpl$InitDataStore$doRun$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;

    readonly androidx.datastore.core.DataStoreImpl$InitDataStore this$0;

    DataStoreImpl$InitDataStore$doRun$1(androidx.datastore.core.DataStoreImpl$InitDataStore dataStoreImpl$InitDataStore, kotlin.coroutines.Continuation continuation) {
        super(continuation);
        this.this$0 = dataStoreImpl$InitDataStore;
    }

    public static java.lang.object SIYTpdZcTcqdIHBe(androidx.datastore.core.DataStoreImpl$InitDataStore dataStoreImpl$InitDataStore, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$InitDataStore.doRun(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return SIYTpdZcTcqdIHBe(this.this$0, this);
    }
}

