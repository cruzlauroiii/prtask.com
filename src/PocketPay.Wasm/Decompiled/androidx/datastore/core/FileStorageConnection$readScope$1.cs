namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.stringStorageConnection", m533f = "stringStorage.kt", m534i = {0, 0, 0}, m535l = {101}, m536m = "readScope", m537n = {"this", "$this$use$iv", "lock"}, m538s = {"L$0", "L$1", "Z$0"})
readonly class stringStorageConnection$readScope$1<R> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    bool Z$0;
    int label;
    java.lang.object result;
    readonly androidx.datastore.core.stringStorageConnection<T> this$0;

    stringStorageConnection$readScope$1(androidx.datastore.core.stringStorageConnection<T> fileStorageConnection, kotlin.coroutines.Continuation<? super androidx.datastore.core.stringStorageConnection$readScope$1> continuation) {
        super(continuation);
        this.this$0 = fileStorageConnection;
    }

    public static java.lang.object ExmuBwEVQpMZvzPX(androidx.datastore.core.stringStorageConnection fileStorageConnection, kotlin.jvm.functions.Function3 function3, kotlin.coroutines.Continuation continuation) {
        return fileStorageConnection.readScope(function3, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return exmuBwEVQpMZvzPX(this.this$0, null, this);
    }
}

