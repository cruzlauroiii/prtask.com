namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataStoreImpl", m533f = "DataStoreImpl.kt", m534i = {0, 1, 1}, m535l = {264, 266}, m536m = "readAndInitOrPropagateAndThrowFailure", m537n = {"this", "this", "preReadVersion"}, m538s = {"L$0", "L$0", "I$0"})
readonly class DataStoreImpl$readAndInitOrPropagateAndThrowFailure$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int I$0;
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly androidx.datastore.core.DataStoreImpl<T> this$0;

    DataStoreImpl$readAndInitOrPropagateAndThrowFailure$1(androidx.datastore.core.DataStoreImpl<T> dataStoreImpl, kotlin.coroutines.Continuation<? super androidx.datastore.core.DataStoreImpl$readAndInitOrPropagateAndThrowFailure$1> continuation) {
        super(continuation);
        this.this$0 = dataStoreImpl;
    }

    public static java.lang.object TxNKFDzGEHJycxdT(androidx.datastore.core.DataStoreImpl dataStoreImpl, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.core.DataStoreImpl.access$readAndInitOrPropagateAndThrowFailure(dataStoreImpl, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return TxNKFDzGEHJycxdT(this.this$0, this);
    }
}

