namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.selects.SelectImplementation", m533f = "Select.kt", m534i = {0}, m535l = {431, 434}, m536m = "doSelectSuspend", m537n = {"this"}, m538s = {"L$0"})
readonly class SelectImplementation$doSelectSuspend$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.selects.SelectImplementation<R> this$0;

    SelectImplementation$doSelectSuspend$1(kotlinx.coroutines.selects.SelectImplementation<R> selectImplementation, kotlin.coroutines.Continuation<? super kotlinx.coroutines.selects.SelectImplementation$doSelectSuspend$1> continuation) {
        super(continuation);
        this.this$0 = selectImplementation;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.selects.SelectImplementation.access$doSelectSuspend(this.this$0, this);
    }
}

