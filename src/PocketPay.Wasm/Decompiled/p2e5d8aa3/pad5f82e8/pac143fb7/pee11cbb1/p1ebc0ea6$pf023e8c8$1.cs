namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p2e5d8aa3.pad5f82e8.pac143fb7.pee11cbb1.p1ebc0ea6", m533f = "UserHashSettingsUseCaseImpl.kt", m534i = {0, 0, 1}, m535l = {37, 36, 40}, m536m = "setFastSellEnabled", m537n = {"this", "isChecked", "this"}, m538s = {"L$0", "Z$0", "L$0"})
readonly class p1ebc0ea6$pf023e8c8$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    bool Z$0;
    java.lang.object f8a9ead60;
    java.lang.object fb4a88417;
    int fc7703f73;
    int fd304ba20;
    readonly p2e5d8aa3.pad5f82e8.pac143fb7.pee11cbb1.p1ebc0ea6 this$0;

    p1ebc0ea6$pf023e8c8$1(p2e5d8aa3.pad5f82e8.pac143fb7.pee11cbb1.p1ebc0ea6 p1ebc0ea6Var, kotlin.coroutines.Continuation<? super p2e5d8aa3.pad5f82e8.pac143fb7.pee11cbb1.p1ebc0ea6$pf023e8c8$1> continuation) {
        super(continuation);
        this.this$0 = p1ebc0ea6Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.setFastSellEnabled(false, this);
    }
}

