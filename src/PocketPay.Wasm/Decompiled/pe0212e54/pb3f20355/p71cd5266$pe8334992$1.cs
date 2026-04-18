namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pe0212e54.pb3f20355.p71cd5266", m533f = "DevicesDbRepositoryImpl.kt", m534i = {}, m535l = {54}, m536m = "hasDevice", m537n = {}, m538s = {})
readonly class p71cd5266$pe8334992$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f60a5a59e;
    java.lang.object fb4a88417;
    int fb9de75bb;
    int fc78af38b;
    java.lang.object fcf94ab35;
    int fd304ba20;
    readonly pe0212e54.pb3f20355.p71cd5266 this$0;

    p71cd5266$pe8334992$1(pe0212e54.pb3f20355.p71cd5266 p71cd5266Var, kotlin.coroutines.Continuation<? super pe0212e54.pb3f20355.p71cd5266$pe8334992$1> continuation) {
        super(continuation);
        this.this$0 = p71cd5266Var;
    }

    public static java.lang.object NDklwjnZihkurfbG(pe0212e54.pb3f20355.p71cd5266 p71cd5266Var, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return p71cd5266Var.hasDevice(str, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return NDklwjnZihkurfbG(this.this$0, null, this);
    }
}

