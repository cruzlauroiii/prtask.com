namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.SeparatorState", m533f = "Separators.kt", m534i = {0, 1, 2}, m535l = {214, 216, 217}, m536m = "onEvent", m537n = {"this", "this", "this"}, m538s = {"L$0", "L$0", "L$0"})
readonly class SeparatorState$onEvent$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly androidx.paging.SeparatorState<R, T> this$0;

    SeparatorState$onEvent$1(androidx.paging.SeparatorState<R, T> separatorState, kotlin.coroutines.Continuation<? super androidx.paging.SeparatorState$onEvent$1> continuation) {
        super(continuation);
        this.this$0 = separatorState;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.onEvent(null, this);
    }
}

