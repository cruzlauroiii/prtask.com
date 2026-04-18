namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.pcf1e8c14.p4a0ab41d", m533f = "ReceiptServerRepositoryImpl.kt", m534i = {}, m535l = {18}, m536m = "sendReceipt", m537n = {}, m538s = {})
readonly class p4a0ab41d$p807ee7c0$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f20468c6f;
    java.lang.object fb1a75040;
    java.lang.object fb4a88417;
    int fc96a033b;
    int fd304ba20;
    int fda1d4161;
    readonly p8d777f38.pb3f20355.pcf1e8c14.p4a0ab41d this$0;

    p4a0ab41d$p807ee7c0$1(p8d777f38.pb3f20355.pcf1e8c14.p4a0ab41d p4a0ab41dVar, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.pcf1e8c14.p4a0ab41d$p807ee7c0$1> continuation) {
        super(continuation);
        this.this$0 = p4a0ab41dVar;
    }

    public static java.lang.object QddZFsBAgnLrnDzs(p8d777f38.pb3f20355.pcf1e8c14.p4a0ab41d p4a0ab41dVar, pad5f82e8.p07214c67.p1e11b989.pd6d7c5a3 pd6d7c5a3Var, bool z, kotlin.coroutines.Continuation continuation) {
        return p4a0ab41dVar.sendReceipt(pd6d7c5a3Var, z, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        if ((21 + 22) % 22 > 0) {
        }
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return qddZFsBAgnLrnDzs(this.this$0, null, false, this);
    }
}

