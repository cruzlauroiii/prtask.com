namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pad5f82e8.pac143fb7.p1e11b989.p75adeb22", m533f = "SendReceiptUseCaseImpl.kt", m534i = {}, m535l = {215, 216}, m536m = "removeCurrentReceipt", m537n = {}, m538s = {})
readonly class p75adeb22$pdddc363b$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f1c3301a6;
    java.lang.object f261cce83;
    java.lang.object f9956d107;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly pad5f82e8.pac143fb7.p1e11b989.p75adeb22 this$0;

    p75adeb22$pdddc363b$1(pad5f82e8.pac143fb7.p1e11b989.p75adeb22 p75adeb22Var, kotlin.coroutines.Continuation<? super pad5f82e8.pac143fb7.p1e11b989.p75adeb22$pdddc363b$1> continuation) {
        super(continuation);
        this.this$0 = p75adeb22Var;
    }

    public static java.lang.object FZxxfeyPOeoKnVWV(pad5f82e8.pac143fb7.p1e11b989.p75adeb22 p75adeb22Var, pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, kotlin.coroutines.Continuation continuation) {
        return pad5f82e8.pac143fb7.p1e11b989.p75adeb22.m35532eee(p75adeb22Var, p9ded6185Var, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return fZxxfeyPOeoKnVWV(this.this$0, null, this);
    }
}

