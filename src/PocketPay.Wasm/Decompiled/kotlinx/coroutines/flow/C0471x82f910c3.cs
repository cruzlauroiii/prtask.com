namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__LimitKt$transformWhile$1$invokeSuspend$$inlined$collectWhile$1", m533f = "Limit.kt", m534i = {0}, m535l = {142}, m536m = "emit", m537n = {"this"}, m538s = {"L$0"})
public readonly class C0471x82f910c3 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.C0470xdf1aa1b6 this$0;

    public C0471x82f910c3(kotlinx.coroutines.flow.C0470xdf1aa1b6 c0470xdf1aa1b6, kotlin.coroutines.Continuation continuation) {
        super(continuation);
        this.this$0 = c0470xdf1aa1b6;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

