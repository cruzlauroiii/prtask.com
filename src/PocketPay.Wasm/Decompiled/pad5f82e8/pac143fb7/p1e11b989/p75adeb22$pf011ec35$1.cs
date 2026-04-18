namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pad5f82e8.pac143fb7.p1e11b989.p75adeb22", m533f = "SendReceiptUseCaseImpl.kt", m534i = {0, 0, 1}, m535l = {118, 119, 129}, m536m = "resendReceipt", m537n = {"this", "receipt", "this"}, m538s = {"L$0", "L$1", "L$0"})
readonly class p75adeb22$pf011ec35$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object f09b19da5;
    int f25796489;
    int f5bc696fe;
    int f73811822;
    java.lang.object faf977f94;
    java.lang.object fb4a88417;
    int fbf5d6582;
    int fd304ba20;
    java.lang.object fe2c05292;
    readonly pad5f82e8.pac143fb7.p1e11b989.p75adeb22 this$0;

    p75adeb22$pf011ec35$1(pad5f82e8.pac143fb7.p1e11b989.p75adeb22 p75adeb22Var, kotlin.coroutines.Continuation<? super pad5f82e8.pac143fb7.p1e11b989.p75adeb22$pf011ec35$1> continuation) {
        super(continuation);
        this.this$0 = p75adeb22Var;
    }

    public static java.lang.object UosLuQbcOxTLLdMh(pad5f82e8.pac143fb7.p1e11b989.p75adeb22 p75adeb22Var, pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return p75adeb22Var.resendReceipt(p9ded6185Var, str, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return UosLuQbcOxTLLdMh(this.this$0, null, null, this);
    }
}

