namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pe0212e54.pb3f20355.p71cd5266", m533f = "DevicesDbRepositoryImpl.kt", m534i = {0, 0}, m535l = {32, 33, 35}, m536m = "updateDevice", m537n = {"this", "device"}, m538s = {"L$0", "L$1"})
readonly class p71cd5266$p50b94136$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int f400ca529;
    int f5e55a2c4;
    java.lang.object fa13c82eb;
    int fa450ec9b;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly pe0212e54.pb3f20355.p71cd5266 this$0;

    p71cd5266$p50b94136$1(pe0212e54.pb3f20355.p71cd5266 p71cd5266Var, kotlin.coroutines.Continuation<? super pe0212e54.pb3f20355.p71cd5266$p50b94136$1> continuation) {
        super(continuation);
        this.this$0 = p71cd5266Var;
    }

    public static java.lang.object IHhydpHGFUgVmAxn(pe0212e54.pb3f20355.p71cd5266 p71cd5266Var, pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb p6285e3ebVar, kotlin.coroutines.Continuation continuation) {
        return p71cd5266Var.updateDevice(p6285e3ebVar, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return IHhydpHGFUgVmAxn(this.this$0, null, this);
    }
}

