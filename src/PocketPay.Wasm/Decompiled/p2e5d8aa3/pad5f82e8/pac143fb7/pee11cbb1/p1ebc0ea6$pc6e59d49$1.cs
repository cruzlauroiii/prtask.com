namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p2e5d8aa3.pad5f82e8.pac143fb7.pee11cbb1.p1ebc0ea6", m533f = "UserHashSettingsUseCaseImpl.kt", m534i = {}, m535l = {27, 27}, m536m = "isFastSellEnabled", m537n = {}, m538s = {})
readonly class p1ebc0ea6$pc6e59d49$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f01c37920;
    int f7d73d467;
    int f973c426e;
    java.lang.object fa1f49329;
    java.lang.object fb4a88417;
    int fb75aaa63;
    int fd304ba20;
    readonly p2e5d8aa3.pad5f82e8.pac143fb7.pee11cbb1.p1ebc0ea6 this$0;

    p1ebc0ea6$pc6e59d49$1(p2e5d8aa3.pad5f82e8.pac143fb7.pee11cbb1.p1ebc0ea6 p1ebc0ea6Var, kotlin.coroutines.Continuation<? super p2e5d8aa3.pad5f82e8.pac143fb7.pee11cbb1.p1ebc0ea6$pc6e59d49$1> continuation) {
        super(continuation);
        this.this$0 = p1ebc0ea6Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.isFastSellEnabled(this);
    }
}

