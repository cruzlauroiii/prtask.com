namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p7a1eabc3.pb3f20355.p9597407d", m533f = "InventoryRemoteRepositoryImpl.kt", m534i = {0, 0}, m535l = {98, 100, 97}, m536m = "removeCommodityGroup", m537n = {"this", "productGroupId"}, m538s = {"L$0", "L$1"})
readonly class p9597407d$pfe75008f$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f7452a5ce;
    int f8295f1a4;
    int f8e8eaa3c;
    java.lang.object fb4a88417;
    int fc7498232;
    int fd304ba20;
    java.lang.object fe2fbc457;
    readonly p7a1eabc3.pb3f20355.p9597407d this$0;

    p9597407d$pfe75008f$1(p7a1eabc3.pb3f20355.p9597407d p9597407dVar, kotlin.coroutines.Continuation<? super p7a1eabc3.pb3f20355.p9597407d$pfe75008f$1> continuation) {
        super(continuation);
        this.this$0 = p9597407dVar;
    }

    public static java.lang.object XSDsWexDgKmByYqp(p7a1eabc3.pb3f20355.p9597407d p9597407dVar, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return p9597407dVar.removeCommodityGroup(str, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return xSDsWexDgKmByYqp(this.this$0, null, this);
    }
}

