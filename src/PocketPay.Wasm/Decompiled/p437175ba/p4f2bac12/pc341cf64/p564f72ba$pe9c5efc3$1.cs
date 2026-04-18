namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p437175ba.p4f2bac12.pc341cf64.p564f72ba", m533f = "PdfPageRenderer.kt", m534i = {0, 0, 0, 1, 1, 1}, m535l = {83, 50}, m536m = "getBitmapAsync", m537n = {"this", "$this$withLock_u24default$iv", "position", "$this$withLock_u24default$iv", "$this$getOrPut$iv", "key$iv"}, m538s = {"L$0", "L$1", "I$0", "L$0", "L$1", "L$2"})
readonly class p564f72ba$pe9c5efc3$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int I$0;
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object f2aad5679;
    java.lang.object fa9648a02;
    java.lang.object fb4a88417;
    int fc6d45b4f;
    int fd304ba20;
    readonly p437175ba.p4f2bac12.pc341cf64.p564f72ba this$0;

    p564f72ba$pe9c5efc3$1(p437175ba.p4f2bac12.pc341cf64.p564f72ba p564f72baVar, kotlin.coroutines.Continuation<? super p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$1> continuation) {
        super(continuation);
        this.this$0 = p564f72baVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return p437175ba.p4f2bac12.pc341cf64.p564f72ba.m77225507(this.this$0, 0, this);
    }
}

