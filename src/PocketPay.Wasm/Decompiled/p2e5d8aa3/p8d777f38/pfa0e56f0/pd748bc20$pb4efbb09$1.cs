namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p2e5d8aa3.p8d777f38.pfa0e56f0.pd748bc20", m533f = "PaymentHashSettingsRepositoryImpl.kt", m534i = {}, m535l = {79}, m536m = "getDevicePaymentHashSettings", m537n = {}, m538s = {})
readonly class pd748bc20$pb4efbb09$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f57becac9;
    java.lang.object f595ce79a;
    int fb16f074e;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fdb363d02;
    int fde959c2f;
    java.lang.object ff4bbb69a;
    readonly p2e5d8aa3.p8d777f38.pfa0e56f0.pd748bc20 this$0;

    pd748bc20$pb4efbb09$1(p2e5d8aa3.p8d777f38.pfa0e56f0.pd748bc20 pd748bc20Var, kotlin.coroutines.Continuation<? super p2e5d8aa3.p8d777f38.pfa0e56f0.pd748bc20$pb4efbb09$1> continuation) {
        super(continuation);
        this.this$0 = pd748bc20Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getDevicePaymentHashSettings(this);
    }
}

