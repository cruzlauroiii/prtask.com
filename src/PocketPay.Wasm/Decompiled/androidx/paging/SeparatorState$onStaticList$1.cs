namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.SeparatorState", m533f = "Separators.kt", m534i = {0, 0, 0, 0, 0}, m535l = {564}, m536m = "onStaticList", m537n = {"this", "event", "data", "item", "i"}, m538s = {"L$0", "L$1", "L$2", "L$3", "I$0"})
readonly class SeparatorState$onStaticList$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int I$0;
    int I$1;
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    int label;
    java.lang.object result;
    readonly androidx.paging.SeparatorState<R, T> this$0;

    SeparatorState$onStaticList$1(androidx.paging.SeparatorState<R, T> separatorState, kotlin.coroutines.Continuation<? super androidx.paging.SeparatorState$onStaticList$1> continuation) {
        super(continuation);
        this.this$0 = separatorState;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.onStaticList(null, this);
    }
}

