namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pad5f82e8.pac143fb7.p1e11b989.p4757fe07.p1042f835", m533f = "PositionCreatorUseCaseImpl.kt", m534i = {0, 0, 1, 1, 1, 2, 2, 2, 3}, m535l = {66, 67, 68, 71}, m536m = "createPaybackPositionWithCommodityItemFromBarcode", m537n = {"this", "commodity", "this", "commodity", "position", "this", "commodity", "position", "findPosition"}, m538s = {"L$0", "L$1", "L$0", "L$1", "L$2", "L$0", "L$1", "L$2", "L$0"})
readonly class p1042f835$p8b39a6e4$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object f0426014b;
    int f0f8ff75a;
    java.lang.object f1f70f7c4;
    java.lang.object f4baea6a1;
    int fa9e096c1;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly pad5f82e8.pac143fb7.p1e11b989.p4757fe07.p1042f835 this$0;

    p1042f835$p8b39a6e4$1(pad5f82e8.pac143fb7.p1e11b989.p4757fe07.p1042f835 p1042f835Var, kotlin.coroutines.Continuation<? super pad5f82e8.pac143fb7.p1e11b989.p4757fe07.p1042f835$p8b39a6e4$1> continuation) {
        super(continuation);
        this.this$0 = p1042f835Var;
    }

    public static java.lang.object BXLRGvqhNRJxiCHa(pad5f82e8.pac143fb7.p1e11b989.p4757fe07.p1042f835 p1042f835Var, p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160 p4cc9492b_pca87b160, kotlin.coroutines.Continuation continuation) {
        return p1042f835Var.createPaybackPositionWithCommodityItemFromBarcode(p4cc9492b_pca87b160, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return BXLRGvqhNRJxiCHa(this.this$0, null, this);
    }
}

