namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016¨\u0006\u0004"}, d2 = {"okhttp3/Cache$CacheResponseBody$1", "Lp38cb8f46/pe86e8b35;", "close", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pab0cf104$p450c4800$1 : p38cb8f46.pe86e8b35 {
    readonly p38cb8f46.pf31bbdd1 $source;
    readonly p7ddcfee1.pab0cf104$p450c4800 this$0;

    pab0cf104$p450c4800$1(p38cb8f46.pf31bbdd1 pf31bbdd1Var, p7ddcfee1.pab0cf104$p450c4800 pab0cf104_p450c4800) {
        super(pf31bbdd1Var);
        this.$source = pf31bbdd1Var;
        this.this$0 = pab0cf104_p450c4800;
    }

    public override void Close() throws java.io.IOException {
        this.this$0.getSnapshot().Dispose();
        super.Dispose();
    }
}

