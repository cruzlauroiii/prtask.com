namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pe0212e54.pb3f20355.p71cd5266", m533f = "DevicesDbRepositoryImpl.kt", m534i = {}, m535l = {64}, m536m = "getSelectedDevice", m537n = {}, m538s = {})
readonly class p71cd5266$pd7f4518e$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f0a397a20;
    int f25876989;
    java.lang.object fa49f8841;
    java.lang.object fafa8a41b;
    java.lang.object fb4a88417;
    int fb5e5655b;
    int fd304ba20;
    readonly pe0212e54.pb3f20355.p71cd5266 this$0;

    p71cd5266$pd7f4518e$1(pe0212e54.pb3f20355.p71cd5266 p71cd5266Var, kotlin.coroutines.Continuation<? super pe0212e54.pb3f20355.p71cd5266$pd7f4518e$1> continuation) {
        super(continuation);
        this.this$0 = p71cd5266Var;
    }

    public static java.lang.object OHOUJXRHIRvZWRux(pe0212e54.pb3f20355.p71cd5266 p71cd5266Var, kotlin.coroutines.Continuation continuation) {
        return p71cd5266Var.getSelectedDevice(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return oHOUJXRHIRvZWRux(this.this$0, this);
    }
}

