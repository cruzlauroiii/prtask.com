namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.pb3f20355.p70a17ffa.pdb329010", m533f = "TophCreateOrderRepositoryImpl.kt", m534i = {}, m535l = {20}, m536m = "sendOrderTophAcquiring", m537n = {}, m538s = {})
readonly class pdb329010$pa2c7189b$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f0f39cd28;
    int f27386e0f;
    int f2db98f3a;
    java.lang.object f375473fe;
    java.lang.object f450d94fe;
    java.lang.object f998b5a5d;
    java.lang.object fb4a88417;
    int fc47efa86;
    int fd304ba20;
    int fe985b571;
    readonly p83f5c3ad.pb3f20355.p70a17ffa.pdb329010 this$0;

    pdb329010$pa2c7189b$1(p83f5c3ad.pb3f20355.p70a17ffa.pdb329010 pdb329010Var, kotlin.coroutines.Continuation<? super p83f5c3ad.pb3f20355.p70a17ffa.pdb329010$pa2c7189b$1> continuation) {
        super(continuation);
        this.this$0 = pdb329010Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        if ((2 + 22) % 22 > 0) {
        }
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.sendOrderTophAcquiring(null, null, null, null, 0, this);
    }
}

