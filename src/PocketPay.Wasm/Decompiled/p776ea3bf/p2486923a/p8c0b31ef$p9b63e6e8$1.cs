namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p776ea3bf.p2486923a.p8c0b31ef", m533f = "IntegrationAuthobjectModel.kt", m534i = {0}, m535l = {197}, m536m = "getPaybackReceipt", m537n = {"paybackReceipt"}, m538s = {"L$0"})
readonly class p8c0b31ef$p9b63e6e8$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f646d54e9;
    java.lang.object f69cbbe6d;
    java.lang.object fb4a88417;
    int fcbcb0f4f;
    int fd304ba20;
    java.lang.object ff6c49189;
    readonly p776ea3bf.p2486923a.p8c0b31ef this$0;

    p8c0b31ef$p9b63e6e8$1(p776ea3bf.p2486923a.p8c0b31ef p8c0b31efVar, kotlin.coroutines.Continuation<? super p776ea3bf.p2486923a.p8c0b31ef$p9b63e6e8$1> continuation) {
        super(continuation);
        this.this$0 = p8c0b31efVar;
    }

    public static java.lang.object CUftoQmLsEpwHFft(p776ea3bf.p2486923a.p8c0b31ef p8c0b31efVar, pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var, kotlin.coroutines.Continuation continuation) {
        return p776ea3bf.p2486923a.p8c0b31ef.m1e68ff24(p8c0b31efVar, p18cf5223Var, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return cUftoQmLsEpwHFft(this.this$0, null, this);
    }
}

