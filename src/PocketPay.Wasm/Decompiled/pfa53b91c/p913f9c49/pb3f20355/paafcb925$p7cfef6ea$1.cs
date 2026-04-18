namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pfa53b91c.p913f9c49.pb3f20355.paafcb925", m533f = "AuthDeviceRepositoryImpl.kt", m534i = {}, m535l = {11}, m536m = "sendAuthDevice", m537n = {}, m538s = {})
readonly class paafcb925$p7cfef6ea$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f18d5f647;
    int f31db8ef5;
    java.lang.object f4f676e8b;
    java.lang.object fb4a88417;
    java.lang.object fc0227710;
    int fd304ba20;
    readonly pfa53b91c.p913f9c49.pb3f20355.paafcb925 this$0;

    paafcb925$p7cfef6ea$1(pfa53b91c.p913f9c49.pb3f20355.paafcb925 paafcb925Var, kotlin.coroutines.Continuation<? super pfa53b91c.p913f9c49.pb3f20355.paafcb925$p7cfef6ea$1> continuation) {
        super(continuation);
        this.this$0 = paafcb925Var;
    }

    public static java.lang.object OWxkwglrNLpDVyFI(pfa53b91c.p913f9c49.pb3f20355.paafcb925 paafcb925Var, pfa53b91c.p913f9c49.p07214c67.p6a29c01a p6a29c01aVar, kotlin.coroutines.Continuation continuation) {
        return paafcb925Var.sendAuthDevice(p6a29c01aVar, continuation);
    }

    public static void OWxkwglrNLpDVyFI(pfa53b91c.p913f9c49.pb3f20355.paafcb925 paafcb925Var, pfa53b91c.p913f9c49.p07214c67.p6a29c01a p6a29c01aVar, kotlin.coroutines.Continuation continuation, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OWxkwglrNLpDVyFI(pfa53b91c.p913f9c49.pb3f20355.paafcb925 paafcb925Var, pfa53b91c.p913f9c49.p07214c67.p6a29c01a p6a29c01aVar, kotlin.coroutines.Continuation continuation, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OWxkwglrNLpDVyFI(pfa53b91c.p913f9c49.pb3f20355.paafcb925 paafcb925Var, pfa53b91c.p913f9c49.p07214c67.p6a29c01a p6a29c01aVar, kotlin.coroutines.Continuation continuation, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return OWxkwglrNLpDVyFI(this.this$0, null, this);
    }
}

