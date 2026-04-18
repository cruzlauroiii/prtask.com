namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.selects.SelectImplementation", m533f = "Select.kt", m534i = {}, m535l = {706}, m536m = "processResultAndInvokeBlockRecoveringException", m537n = {}, m538s = {})
readonly class C0484xf491fb2a : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.selects.SelectImplementation<R> this$0;

    C0484xf491fb2a(kotlinx.coroutines.selects.SelectImplementation<R> selectImplementation, kotlin.coroutines.Continuation<kotlinx.coroutines.selects.C0484xf491fb2a> continuation) {
        super(continuation);
        this.this$0 = selectImplementation;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.selects.SelectImplementation.access$processResultAndInvokeBlockRecoveringException(this.this$0, null, null, this);
    }
}

