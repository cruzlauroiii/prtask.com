namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.pb5716981", m533f = "TophBatchUseCaseImpl.kt", m534i = {0, 0, 0, 0}, m535l = {32, 33}, m536m = "sendReportToEmail", m537n = {"this", "email", "dateStart", "dateEnd"}, m538s = {"L$0", "L$1", "L$2", "L$3"})
readonly class pb5716981$p815fa1a7$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object f1e26dfe4;
    java.lang.object f25106247;
    int f2dc7f54f;
    java.lang.object f87174e28;
    java.lang.object faa2395a6;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p83f5c3ad.p684019bc.pb5716981 this$0;

    pb5716981$p815fa1a7$1(p83f5c3ad.p684019bc.pb5716981 pb5716981Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.pb5716981$p815fa1a7$1> continuation) {
        super(continuation);
        this.this$0 = pb5716981Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.sendReportToEmail(null, null, null, this);
    }
}

