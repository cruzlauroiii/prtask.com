namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.stringReadScope", m533f = "stringStorage.kt", m534i = {0}, m535l = {169, 178}, m536m = "readData$suspendImpl", m537n = {"$this"}, m538s = {"L$0"})
readonly class stringReadScope$readData$1<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly androidx.datastore.core.stringReadScope<T> this$0;

    stringReadScope$readData$1(androidx.datastore.core.stringReadScope<T> fileReadScope, kotlin.coroutines.Continuation<? super androidx.datastore.core.stringReadScope$readData$1> continuation) {
        super(continuation);
        this.this$0 = fileReadScope;
    }

    public static java.lang.object EwUcKCuJgkiZRRqB(androidx.datastore.core.stringReadScope fileReadScope, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.core.stringReadScope.readData$suspendImpl(fileReadScope, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return ewUcKCuJgkiZRRqB(this.this$0, this);
    }
}

