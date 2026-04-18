namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pe0212e54.pb3f20355.pb43933e4", m533f = "DevicesRepositoryImpl.kt", m534i = {}, m535l = {152}, m536m = "getSelectedDevice", m537n = {}, m538s = {})
readonly class pb43933e4$pd7f4518e$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f016ccde7;
    int f1b9ec305;
    int f3d02cfb6;
    java.lang.object f654e26d1;
    int f8edf1772;
    java.lang.object f9c9cb239;
    java.lang.object fb4a88417;
    int fd304ba20;
    int ff6681113;
    readonly pe0212e54.pb3f20355.pb43933e4 this$0;

    pb43933e4$pd7f4518e$1(pe0212e54.pb3f20355.pb43933e4 pb43933e4Var, kotlin.coroutines.Continuation<? super pe0212e54.pb3f20355.pb43933e4$pd7f4518e$1> continuation) {
        super(continuation);
        this.this$0 = pb43933e4Var;
    }

    public static java.lang.object RNDwQPNosNMDIEwU(pe0212e54.pb3f20355.pb43933e4 pb43933e4Var, kotlin.coroutines.Continuation continuation) {
        return pb43933e4Var.getSelectedDevice(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return RNDwQPNosNMDIEwU(this.this$0, this);
    }
}

