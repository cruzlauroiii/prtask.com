namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.okio.OkioWriteScope", m533f = "OkioStorage.kt", m534i = {0, 0, 0}, m535l = {216}, m536m = "writeData", m537n = {"$this$use$iv", "handle", "$this$use$iv"}, m538s = {"L$0", "L$1", "L$2"})
readonly class OkioWriteScope$writeData$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;
    java.lang.object result;
    readonly androidx.datastore.core.okio.OkioWriteScope<T> this$0;

    OkioWriteScope$writeData$1(androidx.datastore.core.okio.OkioWriteScope<T> okioWriteScope, kotlin.coroutines.Continuation<? super androidx.datastore.core.okio.OkioWriteScope$writeData$1> continuation) {
        super(continuation);
        this.this$0 = okioWriteScope;
    }

    public static java.lang.object ANvJhMRxmGjrGNbp(androidx.datastore.core.okio.OkioWriteScope okioWriteScope, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return okioWriteScope.writeData(obj, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return ANvJhMRxmGjrGNbp(this.this$0, null, this);
    }
}

