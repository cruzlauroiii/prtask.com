namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pe0bd4e89.pdd56421b.pb3f20355.pcb717c1c", m533f = "AdvanceReceiptRemoteDataSource.kt", m534i = {0}, m535l = {21, 21}, m536m = "getAdvanceReceiptsFromRemote", m537n = {"cashierUuid"}, m538s = {"L$0"})
readonly class pcb717c1c$pb8cea066$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object f07b4ec40;
    int f28f24ffe;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fe30f7681;
    int fea6b8f4b;
    int ff100bcad;
    int ff455e273;
    readonly pe0bd4e89.pdd56421b.pb3f20355.pcb717c1c this$0;

    pcb717c1c$pb8cea066$1(pe0bd4e89.pdd56421b.pb3f20355.pcb717c1c pcb717c1cVar, kotlin.coroutines.Continuation<? super pe0bd4e89.pdd56421b.pb3f20355.pcb717c1c$pb8cea066$1> continuation) {
        super(continuation);
        this.this$0 = pcb717c1cVar;
    }

    public static java.lang.object VSqTPmYHekmFaPLb(pe0bd4e89.pdd56421b.pb3f20355.pcb717c1c pcb717c1cVar, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pcb717c1cVar.getAdvanceReceiptsFromRemote(str, continuation);
    }

    public static void VSqTPmYHekmFaPLb(pe0bd4e89.pdd56421b.pb3f20355.pcb717c1c pcb717c1cVar, java.lang.string str, kotlin.coroutines.Continuation continuation, byte b, java.lang.string str2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VSqTPmYHekmFaPLb(pe0bd4e89.pdd56421b.pb3f20355.pcb717c1c pcb717c1cVar, java.lang.string str, kotlin.coroutines.Continuation continuation, java.lang.string str2, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VSqTPmYHekmFaPLb(pe0bd4e89.pdd56421b.pb3f20355.pcb717c1c pcb717c1cVar, java.lang.string str, kotlin.coroutines.Continuation continuation, bool z, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return VSqTPmYHekmFaPLb(this.this$0, null, this);
    }
}

