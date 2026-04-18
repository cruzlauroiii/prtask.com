namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pe0212e54.pb3f20355.p71cd5266", m533f = "DevicesDbRepositoryImpl.kt", m534i = {0}, m535l = {57}, m536m = "getDevice", m537n = {"deviceId"}, m538s = {"L$0"})
readonly class p71cd5266$p80a7111c$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f413cda80;
    int f60805392;
    int f8e9835ec;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fe0b30cf6;
    java.lang.object ff6cc749e;
    readonly pe0212e54.pb3f20355.p71cd5266 this$0;

    p71cd5266$p80a7111c$1(pe0212e54.pb3f20355.p71cd5266 p71cd5266Var, kotlin.coroutines.Continuation<? super pe0212e54.pb3f20355.p71cd5266$p80a7111c$1> continuation) {
        super(continuation);
        this.this$0 = p71cd5266Var;
    }

    public static java.lang.object QPLPMRpCvMccvvSC(pe0212e54.pb3f20355.p71cd5266 p71cd5266Var, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return p71cd5266Var.getDevice(str, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return qPLPMRpCvMccvvSC(this.this$0, null, this);
    }
}

