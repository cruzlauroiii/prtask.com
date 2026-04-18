namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.pc1c16452.p32dbd090", m533f = "MarketDataRepositoryImpl.kt", m534i = {}, m535l = {38}, m536m = "getName", m537n = {}, m538s = {})
readonly class p32dbd090$p32132c89$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f0e3a9c6d;
    int f90b9c76e;
    java.lang.object fb4a88417;
    int fc8e08471;
    int fd304ba20;
    java.lang.object fdb169558;
    int ff83f9cbf;
    readonly p8d777f38.pb3f20355.pc1c16452.p32dbd090 this$0;

    p32dbd090$p32132c89$1(p8d777f38.pb3f20355.pc1c16452.p32dbd090 p32dbd090Var, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.pc1c16452.p32dbd090$p32132c89$1> continuation) {
        super(continuation);
        this.this$0 = p32dbd090Var;
    }

    public static java.lang.object NjurdXKsRbNXRCSI(p8d777f38.pb3f20355.pc1c16452.p32dbd090 p32dbd090Var, kotlin.coroutines.Continuation continuation) {
        return p32dbd090Var.getName(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return NjurdXKsRbNXRCSI(this.this$0, this);
    }
}

