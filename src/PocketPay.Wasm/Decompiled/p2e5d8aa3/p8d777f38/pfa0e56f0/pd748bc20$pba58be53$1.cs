namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p2e5d8aa3.p8d777f38.pfa0e56f0.pd748bc20", m533f = "PaymentHashSettingsRepositoryImpl.kt", m534i = {0}, m535l = {72}, m536m = "getRemoteDevicesPaymentHashSettingsDictionary", m537n = {"paymentHashSettingsInfoDictionary"}, m538s = {"L$0"})
readonly class pd748bc20$pba58be53$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f2cdcf85a;
    java.lang.object f9f40795a;
    int fafb7c928;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p2e5d8aa3.p8d777f38.pfa0e56f0.pd748bc20 this$0;

    pd748bc20$pba58be53$1(p2e5d8aa3.p8d777f38.pfa0e56f0.pd748bc20 pd748bc20Var, kotlin.coroutines.Continuation<? super p2e5d8aa3.p8d777f38.pfa0e56f0.pd748bc20$pba58be53$1> continuation) {
        super(continuation);
        this.this$0 = pd748bc20Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getRemoteDevicesPaymentHashSettingsDictionary(this);
    }
}

