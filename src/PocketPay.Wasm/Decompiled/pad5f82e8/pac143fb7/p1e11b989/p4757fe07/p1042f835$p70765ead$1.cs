namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pad5f82e8.pac143fb7.p1e11b989.p4757fe07.p1042f835", m533f = "PositionCreatorUseCaseImpl.kt", m534i = {0}, m535l = {60}, m536m = "createPositionWithCommodityItem", m537n = {"commodity"}, m538s = {"L$0"})
readonly class p1042f835$p70765ead$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int I$0;
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$10;
    java.lang.object L$11;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object L$4;
    java.lang.object L$5;
    java.lang.object L$6;
    java.lang.object L$7;
    java.lang.object L$8;
    java.lang.object L$9;
    java.lang.object f033fc778;
    int f0a80f006;
    java.lang.object f6cfad06e;
    java.lang.object fb4a88417;
    int fc18f3ca4;
    int fd304ba20;
    int fe77f3686;
    int fe888cfaf;
    readonly pad5f82e8.pac143fb7.p1e11b989.p4757fe07.p1042f835 this$0;

    p1042f835$p70765ead$1(pad5f82e8.pac143fb7.p1e11b989.p4757fe07.p1042f835 p1042f835Var, kotlin.coroutines.Continuation<? super pad5f82e8.pac143fb7.p1e11b989.p4757fe07.p1042f835$p70765ead$1> continuation) {
        super(continuation);
        this.this$0 = p1042f835Var;
    }

    public static java.lang.object SxgJwzHaDNjKeGyH(pad5f82e8.pac143fb7.p1e11b989.p4757fe07.p1042f835 p1042f835Var, p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160 p4cc9492b_pca87b160, java.math.decimal bigDecimal, kotlin.coroutines.Continuation continuation) {
        return p1042f835Var.createPositionWithCommodityItem(p4cc9492b_pca87b160, bigDecimal, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return sxgJwzHaDNjKeGyH(this.this$0, null, null, this);
    }
}

