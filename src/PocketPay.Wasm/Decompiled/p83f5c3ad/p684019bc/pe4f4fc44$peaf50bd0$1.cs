namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.pe4f4fc44", m533f = "TapOnPhoneInfoUseCaseImpl.kt", m534i = {0, 0}, m535l = {21, 23}, m536m = "updateTapOnPhoneQrInfo", m537n = {"this", "isQrEnabledPrev"}, m538s = {"L$0", "Z$0"})
readonly class pe4f4fc44$peaf50bd0$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    bool Z$0;
    int f139c1d2e;
    java.lang.object f9fe0eb41;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fd5cb568f;
    int ff0816cbb;
    readonly p83f5c3ad.p684019bc.pe4f4fc44 this$0;

    pe4f4fc44$peaf50bd0$1(p83f5c3ad.p684019bc.pe4f4fc44 pe4f4fc44Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.pe4f4fc44$peaf50bd0$1> continuation) {
        super(continuation);
        this.this$0 = pe4f4fc44Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.updateTapOnPhoneQrInfo(this);
    }
}

