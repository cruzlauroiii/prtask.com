namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pe0212e54.pb3f20355.p71cd5266", m533f = "DevicesDbRepositoryImpl.kt", m534i = {0}, m535l = {71}, m536m = "getDeviceStatusByDeviceId", m537n = {"deviceId"}, m538s = {"L$0"})
readonly class p71cd5266$p20c26332$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f08ef2ead;
    java.lang.object f0ed3a0d0;
    int f3615e68c;
    java.lang.object f58b2c9ac;
    int f794674bf;
    java.lang.object f7a7b83e4;
    java.lang.object f9f91f566;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly pe0212e54.pb3f20355.p71cd5266 this$0;

    p71cd5266$p20c26332$1(pe0212e54.pb3f20355.p71cd5266 p71cd5266Var, kotlin.coroutines.Continuation<? super pe0212e54.pb3f20355.p71cd5266$p20c26332$1> continuation) {
        super(continuation);
        this.this$0 = p71cd5266Var;
    }

    public static java.lang.object DBtixpTpObpyKhWf(pe0212e54.pb3f20355.p71cd5266 p71cd5266Var, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return p71cd5266Var.getDeviceStatusByDeviceId(str, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return dBtixpTpObpyKhWf(this.this$0, null, this);
    }
}

