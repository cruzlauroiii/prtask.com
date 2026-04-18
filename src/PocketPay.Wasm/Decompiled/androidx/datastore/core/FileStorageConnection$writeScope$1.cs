namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.stringStorageConnection", m533f = "stringStorage.kt", m534i = {0, 0, 0, 1, 1, 1, 1}, m535l = {214, 118}, m536m = "writeScope", m537n = {"this", "block", "$this$withLock_u24default$iv", "this", "$this$withLock_u24default$iv", "scratchstring", "$this$use$iv"}, m538s = {"L$0", "L$1", "L$2", "L$0", "L$1", "L$2", "L$3"})
readonly class stringStorageConnection$writeScope$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    int label;
    java.lang.object result;
    readonly androidx.datastore.core.stringStorageConnection<T> this$0;

    stringStorageConnection$writeScope$1(androidx.datastore.core.stringStorageConnection<T> fileStorageConnection, kotlin.coroutines.Continuation<? super androidx.datastore.core.stringStorageConnection$writeScope$1> continuation) {
        super(continuation);
        this.this$0 = fileStorageConnection;
    }

    public static java.lang.object UhYfXJjdYEarabIc(androidx.datastore.core.stringStorageConnection fileStorageConnection, kotlin.jvm.functions.Function2 function2, kotlin.coroutines.Continuation continuation) {
        return fileStorageConnection.writeScope(function2, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return UhYfXJjdYEarabIc(this.this$0, null, this);
    }
}

