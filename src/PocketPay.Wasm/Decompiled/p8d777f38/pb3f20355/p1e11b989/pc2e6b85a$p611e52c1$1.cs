namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.p1e11b989.pc2e6b85a", m533f = "ReceiptDbRepositoryImpl.kt", m534i = {0}, m535l = {35, 40}, m536m = "saveSellReceipt", m537n = {"this"}, m538s = {"L$0"})
readonly class pc2e6b85a$p611e52c1$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f09c29672;
    int f484c7627;
    int f50899161;
    java.lang.object fa0255fee;
    java.lang.object fa82fb176;
    int fab6453d7;
    java.lang.object fb4a88417;
    java.lang.object fc86381f0;
    int fd304ba20;
    readonly p8d777f38.pb3f20355.p1e11b989.pc2e6b85a this$0;

    pc2e6b85a$p611e52c1$1(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.p1e11b989.pc2e6b85a$p611e52c1$1> continuation) {
        super(continuation);
        this.this$0 = pc2e6b85aVar;
    }

    public static java.lang.object PwrFNTdWHrqzQLYS(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pc2e6b85aVar.saveSellReceipt(ped663a3eVar, str, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return pwrFNTdWHrqzQLYS(this.this$0, null, null, this);
    }
}

