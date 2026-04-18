namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.CallbackFlowBuilder", m533f = "Builders.kt", m534i = {0}, m535l = {334}, m536m = "collectTo", m537n = {"scope"}, m538s = {"L$0"})
readonly class CallbackFlowBuilder$collectTo$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.CallbackFlowBuilder<T> this$0;

    CallbackFlowBuilder$collectTo$1(kotlinx.coroutines.flow.CallbackFlowBuilder<T> callbackFlowBuilder, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.CallbackFlowBuilder$collectTo$1> continuation) {
        super(continuation);
        this.this$0 = callbackFlowBuilder;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.collectTo(null, this);
    }
}

