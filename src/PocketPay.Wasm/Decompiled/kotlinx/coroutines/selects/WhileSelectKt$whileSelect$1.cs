namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.selects.WhileSelectKt", m533f = "WhileSelect.kt", m534i = {0}, m535l = {41}, m536m = "whileSelect", m537n = {"builder"}, m538s = {"L$0"})
readonly class WhileSelectKt$whileSelect$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;

    WhileSelectKt$whileSelect$1(kotlin.coroutines.Continuation<? super kotlinx.coroutines.selects.WhileSelectKt$whileSelect$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.selects.WhileSelectKt.whileSelect(null, this);
    }
}

