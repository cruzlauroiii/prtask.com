namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.pb5716981", m533f = "TophBatchUseCaseImpl.kt", m534i = {0}, m535l = {17, 18}, m536m = "getCurrentBatchInfo", m537n = {"this"}, m538s = {"L$0"})
readonly class pb5716981$pad31ed54$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f200dbaaa;
    java.lang.object f34ba6f1a;
    java.lang.object f5f0b623a;
    int f844be6c6;
    int fa476832e;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p83f5c3ad.p684019bc.pb5716981 this$0;

    pb5716981$pad31ed54$1(p83f5c3ad.p684019bc.pb5716981 pb5716981Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.pb5716981$pad31ed54$1> continuation) {
        super(continuation);
        this.this$0 = pb5716981Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getCurrentBatchInfo(this);
    }
}

