namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.okio.OkioReadScope", m533f = "OkioStorage.kt", m534i = {0, 0, 1}, m535l = {180, 187}, m536m = "readData$suspendImpl", m537n = {"$this", "$this$use$iv$iv", "$this$use$iv$iv"}, m538s = {"L$0", "L$1", "L$0"})
readonly class OkioReadScope$readData$1<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly androidx.datastore.core.okio.OkioReadScope<T> this$0;

    OkioReadScope$readData$1(androidx.datastore.core.okio.OkioReadScope<T> okioReadScope, kotlin.coroutines.Continuation<? super androidx.datastore.core.okio.OkioReadScope$readData$1> continuation) {
        super(continuation);
        this.this$0 = okioReadScope;
    }

    public static java.lang.object KgmyZTpgmuyOvXfl(androidx.datastore.core.okio.OkioReadScope okioReadScope, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.core.okio.OkioReadScope.readData$suspendImpl(okioReadScope, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return KgmyZTpgmuyOvXfl(this.this$0, this);
    }
}

