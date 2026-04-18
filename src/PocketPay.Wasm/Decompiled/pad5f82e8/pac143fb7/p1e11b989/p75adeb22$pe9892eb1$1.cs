namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pad5f82e8.pac143fb7.p1e11b989.p75adeb22", m533f = "SendReceiptUseCaseImpl.kt", m534i = {}, m535l = {180, 186}, m536m = "saveReceiptToDb", m537n = {}, m538s = {})
readonly class p75adeb22$pe9892eb1$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f378192b8;
    java.lang.object f4177bd4d;
    int f699c6648;
    int f798b8104;
    int f89e183ec;
    java.lang.object fa75bb503;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fed7810a9;
    readonly pad5f82e8.pac143fb7.p1e11b989.p75adeb22 this$0;

    p75adeb22$pe9892eb1$1(pad5f82e8.pac143fb7.p1e11b989.p75adeb22 p75adeb22Var, kotlin.coroutines.Continuation<? super pad5f82e8.pac143fb7.p1e11b989.p75adeb22$pe9892eb1$1> continuation) {
        super(continuation);
        this.this$0 = p75adeb22Var;
    }

    public static java.lang.object MwYsdnnkGlUqxUfa(pad5f82e8.pac143fb7.p1e11b989.p75adeb22 p75adeb22Var, pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pad5f82e8.pac143fb7.p1e11b989.p75adeb22.m744e99aa(p75adeb22Var, p9ded6185Var, str, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return MwYsdnnkGlUqxUfa(this.this$0, null, null, this);
    }
}

