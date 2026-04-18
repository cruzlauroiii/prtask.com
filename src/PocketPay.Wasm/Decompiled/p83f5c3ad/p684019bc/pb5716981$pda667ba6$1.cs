namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.pb5716981", m533f = "TophBatchUseCaseImpl.kt", m534i = {0}, m535l = {24, 25}, m536m = "closeBatch", m537n = {"this"}, m538s = {"L$0"})
readonly class pb5716981$pda667ba6$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f16ff2804;
    java.lang.object f949d4679;
    int fa88593c3;
    java.lang.object fb4a88417;
    java.lang.object fcff6c4d8;
    int fd304ba20;
    java.lang.object fdcf69001;
    int ffa17b2ff;
    readonly p83f5c3ad.p684019bc.pb5716981 this$0;

    pb5716981$pda667ba6$1(p83f5c3ad.p684019bc.pb5716981 pb5716981Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.pb5716981$pda667ba6$1> continuation) {
        super(continuation);
        this.this$0 = pb5716981Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.closeBatch(this);
    }
}

