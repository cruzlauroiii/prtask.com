namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p2e5d8aa3.p8d777f38.pfa0e56f0.pd748bc20", m533f = "PaymentHashSettingsRepositoryImpl.kt", m534i = {}, m535l = {84}, m536m = "getComboDevicePaymentHashSettings", m537n = {}, m538s = {})
readonly class pd748bc20$pb237a0b5$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int I$0;
    java.lang.object L$0;
    int f1311d873;
    int f3be477a6;
    int f531c1e88;
    java.lang.object fb4a88417;
    java.lang.object fc0048ae9;
    int fd304ba20;
    int fe3c716f1;
    readonly p2e5d8aa3.p8d777f38.pfa0e56f0.pd748bc20 this$0;

    pd748bc20$pb237a0b5$1(p2e5d8aa3.p8d777f38.pfa0e56f0.pd748bc20 pd748bc20Var, kotlin.coroutines.Continuation<? super p2e5d8aa3.p8d777f38.pfa0e56f0.pd748bc20$pb237a0b5$1> continuation) {
        super(continuation);
        this.this$0 = pd748bc20Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getComboDevicePaymentHashSettings(this);
    }
}

