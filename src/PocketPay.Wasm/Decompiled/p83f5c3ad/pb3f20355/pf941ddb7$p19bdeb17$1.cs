namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.pb3f20355.pf941ddb7", m533f = "TapOnPhoneInfoRepositoryImpl.kt", m534i = {0}, m535l = {51}, m536m = "updateTapOnPhoneInfo", m537n = {"this"}, m538s = {"L$0"})
readonly class pf941ddb7$p19bdeb17$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f1d477a1f;
    int f4d690f82;
    java.lang.object f6ef64269;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fde8a192b;
    java.lang.object ffcf468c5;
    readonly p83f5c3ad.pb3f20355.pf941ddb7 this$0;

    pf941ddb7$p19bdeb17$1(p83f5c3ad.pb3f20355.pf941ddb7 pf941ddb7Var, kotlin.coroutines.Continuation<? super p83f5c3ad.pb3f20355.pf941ddb7$p19bdeb17$1> continuation) {
        super(continuation);
        this.this$0 = pf941ddb7Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.updateTapOnPhoneInfo(this);
    }
}

