namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p2e5d8aa3.p8d777f38.pfa0e56f0.pd748bc20", m533f = "PaymentHashSettingsRepositoryImpl.kt", m534i = {0, 0}, m535l = {43, 44}, m536m = "setActualPaymentPriorityHashSettings", m537n = {"this", "devicePaymentHashSettings"}, m538s = {"L$0", "L$1"})
readonly class pd748bc20$p4dd6fd2b$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object f03014192;
    java.lang.object f65639b6f;
    java.lang.object f66688e8f;
    int faf00d0d3;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p2e5d8aa3.p8d777f38.pfa0e56f0.pd748bc20 this$0;

    pd748bc20$p4dd6fd2b$1(p2e5d8aa3.p8d777f38.pfa0e56f0.pd748bc20 pd748bc20Var, kotlin.coroutines.Continuation<? super p2e5d8aa3.p8d777f38.pfa0e56f0.pd748bc20$p4dd6fd2b$1> continuation) {
        super(continuation);
        this.this$0 = pd748bc20Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.setActualPaymentPriorityHashSettings(null, this);
    }
}

