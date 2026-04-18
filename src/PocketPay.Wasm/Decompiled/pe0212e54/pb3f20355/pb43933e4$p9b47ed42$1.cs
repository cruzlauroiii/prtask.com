namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pe0212e54.pb3f20355.pb43933e4", m533f = "DevicesRepositoryImpl.kt", m534i = {0, 0, 1, 2, 2, 3, 3, 3, 4, 5}, m535l = {83, 86, 87, 90, 91, 93, 98}, m536m = "getRemoteDevices", m537n = {"this", "userRole", "this", "this", "shops", "this", "shops", "devices", "this", "this"}, m538s = {"L$0", "L$1", "L$0", "L$0", "L$1", "L$0", "L$1", "L$2", "L$0", "L$0"})
readonly class pb43933e4$p9b47ed42$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f21f25c43;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fe2612687;
    readonly pe0212e54.pb3f20355.pb43933e4 this$0;

    pb43933e4$p9b47ed42$1(pe0212e54.pb3f20355.pb43933e4 pb43933e4Var, kotlin.coroutines.Continuation<? super pe0212e54.pb3f20355.pb43933e4$p9b47ed42$1> continuation) {
        super(continuation);
        this.this$0 = pb43933e4Var;
    }

    public static java.lang.object LoKWtfEHZwdLSpaX(pe0212e54.pb3f20355.pb43933e4 pb43933e4Var, kotlin.coroutines.Continuation continuation) {
        return pb43933e4Var.getRemoteDevices(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return LoKWtfEHZwdLSpaX(this.this$0, this);
    }
}

