namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.pc1c16452.p32dbd090", m533f = "MarketDataRepositoryImpl.kt", m534i = {0, 0, 1, 1, 2, 2, 2}, m535l = {56, 57, 59, 73}, m536m = "updateDeviceInfo", m537n = {"this", "userId", "this", "device", "this", "device", "marketDeviceInfo"}, m538s = {"L$0", "L$1", "L$0", "L$1", "L$0", "L$1", "L$2"})
readonly class p32dbd090$p2ad2d5b1$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f01a8a55b;
    java.lang.object f178dd508;
    int f995ecc16;
    java.lang.object fb4a88417;
    java.lang.object fc5cf6dd8;
    int fd304ba20;
    int fdf7cbc3d;
    readonly p8d777f38.pb3f20355.pc1c16452.p32dbd090 this$0;

    p32dbd090$p2ad2d5b1$1(p8d777f38.pb3f20355.pc1c16452.p32dbd090 p32dbd090Var, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.pc1c16452.p32dbd090$p2ad2d5b1$1> continuation) {
        super(continuation);
        this.this$0 = p32dbd090Var;
    }

    public static java.lang.object CzVaXwgksidQLFwC(p8d777f38.pb3f20355.pc1c16452.p32dbd090 p32dbd090Var, java.lang.string str, java.lang.string str2, kotlin.coroutines.Continuation continuation) {
        return p32dbd090Var.updateDeviceInfo(str, str2, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return CzVaXwgksidQLFwC(this.this$0, null, null, this);
    }
}

