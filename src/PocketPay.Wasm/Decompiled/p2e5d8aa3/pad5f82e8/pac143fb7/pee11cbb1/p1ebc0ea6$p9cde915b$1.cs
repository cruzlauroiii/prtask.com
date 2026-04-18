namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p2e5d8aa3.pad5f82e8.pac143fb7.pee11cbb1.p1ebc0ea6", m533f = "UserHashSettingsUseCaseImpl.kt", m534i = {}, m535l = {47, 47}, m536m = "isFirstTimeFastSellEnabled", m537n = {}, m538s = {})
readonly class p1ebc0ea6$p9cde915b$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f2b0da6fc;
    java.lang.object f4b9e6e3b;
    int f69709aaa;
    int f78d5dac8;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p2e5d8aa3.pad5f82e8.pac143fb7.pee11cbb1.p1ebc0ea6 this$0;

    p1ebc0ea6$p9cde915b$1(p2e5d8aa3.pad5f82e8.pac143fb7.pee11cbb1.p1ebc0ea6 p1ebc0ea6Var, kotlin.coroutines.Continuation<? super p2e5d8aa3.pad5f82e8.pac143fb7.pee11cbb1.p1ebc0ea6$p9cde915b$1> continuation) {
        super(continuation);
        this.this$0 = p1ebc0ea6Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.isFirstTimeFastSellEnabled(this);
    }
}

