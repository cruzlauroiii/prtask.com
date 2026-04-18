namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p776ea3bf.p2486923a.p8c0b31ef", m533f = "IntegrationAuthobjectModel.kt", m534i = {0}, m535l = {221}, m536m = "openSellScreen", m537n = {"this"}, m538s = {"L$0"})
readonly class p8c0b31ef$p081e4b13$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f4692f662;
    java.lang.object f70529ce1;
    int f87e728e2;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fde6ccfc5;
    java.lang.object fe636fac3;
    readonly p776ea3bf.p2486923a.p8c0b31ef this$0;

    p8c0b31ef$p081e4b13$1(p776ea3bf.p2486923a.p8c0b31ef p8c0b31efVar, kotlin.coroutines.Continuation<? super p776ea3bf.p2486923a.p8c0b31ef$p081e4b13$1> continuation) {
        super(continuation);
        this.this$0 = p8c0b31efVar;
    }

    public static java.lang.object QhLzSQVivXoOgidk(p776ea3bf.p2486923a.p8c0b31ef p8c0b31efVar, kotlin.coroutines.Continuation continuation) {
        return p776ea3bf.p2486923a.p8c0b31ef.mb2669f27(p8c0b31efVar, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return QhLzSQVivXoOgidk(this.this$0, this);
    }
}

