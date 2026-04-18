namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.stringWriteScope", m533f = "stringStorage.kt", m534i = {0}, m535l = {201}, m536m = "writeData", m537n = {"stream"}, m538s = {"L$1"})
readonly class stringWriteScope$writeData$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly androidx.datastore.core.stringWriteScope<T> this$0;

    stringWriteScope$writeData$1(androidx.datastore.core.stringWriteScope<T> fileWriteScope, kotlin.coroutines.Continuation<? super androidx.datastore.core.stringWriteScope$writeData$1> continuation) {
        super(continuation);
        this.this$0 = fileWriteScope;
    }

    public static java.lang.object UDOAlhHUmBiDRkIO(androidx.datastore.core.stringWriteScope fileWriteScope, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return fileWriteScope.writeData(obj, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return uDOAlhHUmBiDRkIO(this.this$0, null, this);
    }
}

