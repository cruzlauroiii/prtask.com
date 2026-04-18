namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.SeparatorsKt", m533f = "Separators.kt", m534i = {0, 0, 0, 0, 0, 0}, m535l = {82}, m536m = "insertInternalSeparators", m537n = {"$this$insertInternalSeparators", "generator", "outputList", "outputIndices", "item", "i"}, m538s = {"L$0", "L$1", "L$2", "L$3", "L$4", "I$0"})
readonly class SeparatorsKt$insertInternalSeparators$1<R, T : R> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int I$0;
    int I$1;
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object L$4;
    int label;
    java.lang.object result;

    SeparatorsKt$insertInternalSeparators$1(kotlin.coroutines.Continuation<? super androidx.paging.SeparatorsKt$insertInternalSeparators$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return androidx.paging.SeparatorsKt.insertInternalSeparators(null, null, this);
    }
}

