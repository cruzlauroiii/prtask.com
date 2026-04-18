namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.pc1c16452.p32dbd090", m533f = "MarketDataRepositoryImpl.kt", m534i = {}, m535l = {77}, m536m = "getMarketDeviceInfoFromRemote", m537n = {}, m538s = {})
readonly class p32dbd090$p2b58d113$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f21534e38;
    java.lang.object f413a271b;
    java.lang.object fad247d79;
    int faeaee641;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fee7fae40;
    readonly p8d777f38.pb3f20355.pc1c16452.p32dbd090 this$0;

    p32dbd090$p2b58d113$1(p8d777f38.pb3f20355.pc1c16452.p32dbd090 p32dbd090Var, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.pc1c16452.p32dbd090$p2b58d113$1> continuation) {
        super(continuation);
        this.this$0 = p32dbd090Var;
    }

    public static java.lang.object IrwQLGoUahmACuaY(p8d777f38.pb3f20355.pc1c16452.p32dbd090 p32dbd090Var, java.lang.string str, java.lang.string str2, kotlin.coroutines.Continuation continuation) {
        return p8d777f38.pb3f20355.pc1c16452.p32dbd090.m07708a54(p32dbd090Var, str, str2, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return irwQLGoUahmACuaY(this.this$0, null, null, this);
    }
}

