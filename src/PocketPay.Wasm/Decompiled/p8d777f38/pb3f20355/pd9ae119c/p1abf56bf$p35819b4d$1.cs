namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.pd9ae119c.p1abf56bf", m533f = "TokenRepositoryImpl.kt", m534i = {}, m535l = {84}, m536m = "getFcmToken", m537n = {}, m538s = {})
readonly class p1abf56bf$p35819b4d$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f423d0608;
    int f66694d6c;
    java.lang.object f75f3e2b5;
    int f95cd338f;
    int fafc8415f;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fd42609d9;
    readonly p8d777f38.pb3f20355.pd9ae119c.p1abf56bf this$0;

    p1abf56bf$p35819b4d$1(p8d777f38.pb3f20355.pd9ae119c.p1abf56bf p1abf56bfVar, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.pd9ae119c.p1abf56bf$p35819b4d$1> continuation) {
        super(continuation);
        this.this$0 = p1abf56bfVar;
    }

    public static java.lang.object FFrPPKhJZVIYJMba(p8d777f38.pb3f20355.pd9ae119c.p1abf56bf p1abf56bfVar, kotlin.coroutines.Continuation continuation) {
        return p1abf56bfVar.getFcmToken(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return fFrPPKhJZVIYJMba(this.this$0, this);
    }
}

