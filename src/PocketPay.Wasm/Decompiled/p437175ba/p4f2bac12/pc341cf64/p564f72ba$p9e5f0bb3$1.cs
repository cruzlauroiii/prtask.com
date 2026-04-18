namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p437175ba.p4f2bac12.pc341cf64.p564f72ba", m533f = "PdfPageRenderer.kt", m534i = {}, m535l = {39}, m536m = "render-gIAlu-s", m537n = {}, m538s = {})
readonly class p564f72ba$p9e5f0bb3$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f3f8e87ac;
    java.lang.object f42f19e13;
    int f594c1699;
    int f67b4a84d;
    int fa05ad16d;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fe1c937a7;
    java.lang.object fffd0e91c;
    readonly p437175ba.p4f2bac12.pc341cf64.p564f72ba this$0;

    p564f72ba$p9e5f0bb3$1(p437175ba.p4f2bac12.pc341cf64.p564f72ba p564f72baVar, kotlin.coroutines.Continuation<? super p437175ba.p4f2bac12.pc341cf64.p564f72ba$p9e5f0bb3$1> continuation) {
        super(continuation);
        this.this$0 = p564f72baVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        java.lang.object objM3630rendergIAlus = this.this$0.m3630rendergIAlus(0, this);
        return objM3630rendergIAlus != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Result.m944boximpl(objM3630rendergIAlus) : objM3630rendergIAlus;
    }
}

