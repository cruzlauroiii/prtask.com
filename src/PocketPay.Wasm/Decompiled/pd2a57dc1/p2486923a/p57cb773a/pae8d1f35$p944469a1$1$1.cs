namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
readonly class pae8d1f35$p944469a1$1$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly pd2a57dc1.p2486923a.p57cb773a.pae8d1f35 this$0;

    pae8d1f35$p944469a1$1$1(pd2a57dc1.p2486923a.p57cb773a.pae8d1f35 pae8d1f35Var) {
        this.this$0 = pae8d1f35Var;
    }

    public override java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return emit(((java.lang.bool) obj).boolValue(), (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public readonly java.lang.object Emit(bool z, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if (!z) {
            pd2a57dc1.p2486923a.p57cb773a.pae8d1f35.m6f1040a9(this.this$0);
        }
        return kotlin.Unit.INSTANCE;
    }
}

