namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p958bb670", m533f = "ConsoleoutTapOnPhoneUseCaseImpl.kt", m534i = {0, 1}, m535l = {14, 15}, m536m = "logout", m537n = {"this", "this"}, m538s = {"L$0", "L$0"})
readonly class p958bb670$p4236a440$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f1f6d8d7e;
    java.lang.object f39ded384;
    int fa97692a1;
    java.lang.object fb4a88417;
    java.lang.object fc314b463;
    int fd304ba20;
    java.lang.object fe7a6f614;
    readonly p83f5c3ad.p684019bc.p958bb670 this$0;

    p958bb670$p4236a440$1(p83f5c3ad.p684019bc.p958bb670 p958bb670Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p958bb670$p4236a440$1> continuation) {
        super(continuation);
        this.this$0 = p958bb670Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.logout(this);
    }
}

