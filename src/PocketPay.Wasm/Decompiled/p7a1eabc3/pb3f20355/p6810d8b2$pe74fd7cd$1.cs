namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p7a1eabc3.pb3f20355.p6810d8b2", m533f = "InventoryRepositoryImpl.kt", m534i = {0, 1}, m535l = {139, 144}, m536m = "editCommodityGroup", m537n = {"this", "editedGroupCommodityFromRemote"}, m538s = {"L$0", "L$0"})
readonly class p6810d8b2$pe74fd7cd$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f971cb0e2;
    java.lang.object f9a57dc9b;
    java.lang.object fb4a88417;
    int fb7edb1d4;
    int fbdf58b25;
    int fd304ba20;
    java.lang.object fe371cf0b;
    readonly p7a1eabc3.pb3f20355.p6810d8b2 this$0;

    p6810d8b2$pe74fd7cd$1(p7a1eabc3.pb3f20355.p6810d8b2 p6810d8b2Var, kotlin.coroutines.Continuation<? super p7a1eabc3.pb3f20355.p6810d8b2$pe74fd7cd$1> continuation) {
        super(continuation);
        this.this$0 = p6810d8b2Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.editCommodityGroup(null, this);
    }
}

