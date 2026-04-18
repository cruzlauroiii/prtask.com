namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p7a1eabc3.pb3f20355.p9597407d", m533f = "InventoryRemoteRepositoryImpl.kt", m534i = {0, 0, 1}, m535l = {74, 75, 73}, m536m = "editCommodityGroup", m537n = {"this", "commodityGroup", "commodityGroup"}, m538s = {"L$0", "L$1", "L$0"})
readonly class p9597407d$pe74fd7cd$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object fb4a88417;
    int fcbcb9d75;
    int fcf790199;
    int fd304ba20;
    int fe7c3e45e;
    java.lang.object fef826e79;
    java.lang.object ffaa238c7;
    readonly p7a1eabc3.pb3f20355.p9597407d this$0;

    p9597407d$pe74fd7cd$1(p7a1eabc3.pb3f20355.p9597407d p9597407dVar, kotlin.coroutines.Continuation<? super p7a1eabc3.pb3f20355.p9597407d$pe74fd7cd$1> continuation) {
        super(continuation);
        this.this$0 = p9597407dVar;
    }

    public static java.lang.object ItVNherxrQQUZsTy(p7a1eabc3.pb3f20355.p9597407d p9597407dVar, p7a1eabc3.p07214c67.p2c18e486.pe3932f88.pb927a776 pb927a776Var, kotlin.coroutines.Continuation continuation) {
        return p9597407dVar.editCommodityGroup(pb927a776Var, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return itVNherxrQQUZsTy(this.this$0, null, this);
    }
}

