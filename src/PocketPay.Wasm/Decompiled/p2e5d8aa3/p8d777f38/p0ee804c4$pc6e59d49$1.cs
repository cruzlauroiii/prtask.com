namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p2e5d8aa3.p8d777f38.p0ee804c4", m533f = "LocalHashSettingsRepositoryImpl.kt", m534i = {}, m535l = {49}, m536m = "isFastSellEnabled", m537n = {}, m538s = {})
readonly class p0ee804c4$pc6e59d49$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f26b5cf36;
    int f2f0b303b;
    java.lang.object f658aec4c;
    int f8079c5c0;
    java.lang.object f96927c84;
    java.lang.object fb4a88417;
    int fce6c94be;
    int fd304ba20;
    readonly p2e5d8aa3.p8d777f38.p0ee804c4 this$0;

    p0ee804c4$pc6e59d49$1(p2e5d8aa3.p8d777f38.p0ee804c4 p0ee804c4Var, kotlin.coroutines.Continuation<? super p2e5d8aa3.p8d777f38.p0ee804c4$pc6e59d49$1> continuation) {
        super(continuation);
        this.this$0 = p0ee804c4Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.isFastSellEnabled(null, this);
    }
}

