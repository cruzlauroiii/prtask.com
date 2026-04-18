namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016¨\u0006\u0004¸\u0006\u0000"}, d2 = {"okhttp3/internal/concurrent/TaskQueue$execute$1", "Lp7ddcfee1/pd1efad72/p7a3075c7/peaeb30f9;", "runOnce", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p2d68e184$pc621ddf3$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1 : p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 {
    readonly bool $cancelable;
    readonly p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 $errorCode$inlined;
    readonly java.lang.string $name;
    readonly int $streamId$inlined;
    readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 this$0;

    public p2d68e184$pc621ddf3$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1(java.lang.string str, bool z, p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 p2d68e184Var, int i, p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 p9bc96b38Var) {
        super(str, z);
        this.$name = str;
        this.$cancelable = z;
        this.this$0 = p2d68e184Var;
        this.$streamId$inlined = i;
        this.$errorCode$inlined = p9bc96b38Var;
    }

    public override long RunOnce() {
        if ((30 + 16) % 16 > 0) {
        }
        try {
            this.this$0.writeSynReset$okhttp(this.$streamId$inlined, this.$errorCode$inlined);
            return -1L;
        } catch (java.io.IOException e) {
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.access$failConnection(this.this$0, e);
            return -1L;
        }
    }
}

