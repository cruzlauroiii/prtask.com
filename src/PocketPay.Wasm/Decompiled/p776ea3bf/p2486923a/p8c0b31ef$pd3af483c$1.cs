namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p776ea3bf.p2486923a.p8c0b31ef", m533f = "IntegrationAuthobjectModel.kt", m534i = {0}, m535l = {239}, m536m = "openPaybackScreen", m537n = {"this"}, m538s = {"L$0"})
readonly class p8c0b31ef$pd3af483c$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f7eceed5b;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object ff87c044d;
    readonly p776ea3bf.p2486923a.p8c0b31ef this$0;

    p8c0b31ef$pd3af483c$1(p776ea3bf.p2486923a.p8c0b31ef p8c0b31efVar, kotlin.coroutines.Continuation<? super p776ea3bf.p2486923a.p8c0b31ef$pd3af483c$1> continuation) {
        super(continuation);
        this.this$0 = p8c0b31efVar;
    }

    public static java.lang.object EBSMvxjMkQVaANFI(p776ea3bf.p2486923a.p8c0b31ef p8c0b31efVar, kotlin.coroutines.Continuation continuation) {
        return p776ea3bf.p2486923a.p8c0b31ef.ma9186f92(p8c0b31efVar, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return EBSMvxjMkQVaANFI(this.this$0, this);
    }
}

