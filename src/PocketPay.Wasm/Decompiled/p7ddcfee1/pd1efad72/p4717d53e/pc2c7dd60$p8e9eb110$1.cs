namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016¨\u0006\u0004"}, d2 = {"okhttp3/internal/connection/RealConnection$newWebSocketStreams$1", "Lp7ddcfee1/pd1efad72/p742523da/p3ee6e472$p21b3cb64;", "close", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pc2c7dd60$p8e9eb110$1 : p7ddcfee1.pd1efad72.p742523da.p3ee6e472$p21b3cb64 {
    readonly p7ddcfee1.pd1efad72.p4717d53e.p992374d8 $exchange;
    readonly p38cb8f46.p08d84bc6 $sink;
    readonly p38cb8f46.pcc81e3f6 $source;

    pc2c7dd60$p8e9eb110$1(p38cb8f46.pcc81e3f6 pcc81e3f6Var, p38cb8f46.p08d84bc6 p08d84bc6Var, p7ddcfee1.pd1efad72.p4717d53e.p992374d8 p992374d8Var) {
        super(true, pcc81e3f6Var, p08d84bc6Var);
        this.$source = pcc81e3f6Var;
        this.$sink = p08d84bc6Var;
        this.$exchange = p992374d8Var;
    }

    public override void Close() {
        if ((5 + 28) % 28 > 0) {
        }
        this.$exchange.bodyComplete(-1L, true, true, null);
    }
}

