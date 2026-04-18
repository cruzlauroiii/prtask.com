namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.okio.OkioStorageConnection", m533f = "OkioStorage.kt", m534i = {0, 0, 0}, m535l = {113}, m536m = "readScope", m537n = {"this", "$this$use$iv", "lock"}, m538s = {"L$0", "L$1", "Z$0"})
readonly class OkioStorageConnection$readScope$1<R> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    bool Z$0;
    int label;
    java.lang.object result;
    readonly androidx.datastore.core.okio.OkioStorageConnection<T> this$0;

    OkioStorageConnection$readScope$1(androidx.datastore.core.okio.OkioStorageConnection<T> okioStorageConnection, kotlin.coroutines.Continuation<? super androidx.datastore.core.okio.OkioStorageConnection$readScope$1> continuation) {
        super(continuation);
        this.this$0 = okioStorageConnection;
    }

    public static java.lang.object DrRadqBcDVyREbbD(androidx.datastore.core.okio.OkioStorageConnection okioStorageConnection, kotlin.jvm.functions.Function3 function3, kotlin.coroutines.Continuation continuation) {
        return okioStorageConnection.readScope(function3, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return DrRadqBcDVyREbbD(this.this$0, null, this);
    }
}

