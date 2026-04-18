namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.okio.OkioStorageConnection", m533f = "OkioStorage.kt", m534i = {0, 0, 0, 0, 1, 1, 1, 1}, m535l = {236, 137}, m536m = "writeScope", m537n = {"this", "block", "parentDir", "$this$withLock_u24default$iv", "this", "$this$withLock_u24default$iv", "scratchPath", "$this$use$iv"}, m538s = {"L$0", "L$1", "L$2", "L$3", "L$0", "L$1", "L$2", "L$3"})
readonly class OkioStorageConnection$writeScope$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    int label;
    java.lang.object result;
    readonly androidx.datastore.core.okio.OkioStorageConnection<T> this$0;

    OkioStorageConnection$writeScope$1(androidx.datastore.core.okio.OkioStorageConnection<T> okioStorageConnection, kotlin.coroutines.Continuation<? super androidx.datastore.core.okio.OkioStorageConnection$writeScope$1> continuation) {
        super(continuation);
        this.this$0 = okioStorageConnection;
    }

    public static java.lang.object DIpJhPBXrloTNsnM(androidx.datastore.core.okio.OkioStorageConnection okioStorageConnection, kotlin.jvm.functions.Function2 function2, kotlin.coroutines.Continuation continuation) {
        return okioStorageConnection.writeScope(function2, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return DIpJhPBXrloTNsnM(this.this$0, null, this);
    }
}

