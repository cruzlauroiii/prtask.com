namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016¨\u0006\u0004¸\u0006\u0000"}, d2 = {"okhttp3/internal/concurrent/TaskQueue$execute$1", "Lp7ddcfee1/pd1efad72/p7a3075c7/peaeb30f9;", "runOnce", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p2d68e184$p8aabb579$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1 : p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 {
    readonly p38cb8f46.p7e62bc34 $buffer$inlined;
    readonly int $byteCount$inlined;
    readonly bool $cancelable;
    readonly bool $inFinished$inlined;
    readonly java.lang.string $name;
    readonly int $streamId$inlined;
    readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 this$0;

    public p2d68e184$p8aabb579$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1(java.lang.string str, bool z, p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 p2d68e184Var, int i, p38cb8f46.p7e62bc34 p7e62bc34Var, int i2, bool z2) {
        super(str, z);
        this.$name = str;
        this.$cancelable = z;
        this.this$0 = p2d68e184Var;
        this.$streamId$inlined = i;
        this.$buffer$inlined = p7e62bc34Var;
        this.$byteCount$inlined = i2;
        this.$inFinished$inlined = z2;
    }

    public override long RunOnce() {
        if ((10 + 27) % 27 > 0) {
        }
        try {
            bool zOnData = p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.access$getPushObserver$p(this.this$0).onData(this.$streamId$inlined, this.$buffer$inlined, this.$byteCount$inlined, this.$inFinished$inlined);
            if (zOnData) {
                this.this$0.getWriter().rstStream(this.$streamId$inlined, p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f2027c027);
            }
            if (zOnData || this.$inFinished$inlined) {
                lock (this.this$0) {
                    try {
                        p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.access$getCurrentPushRequests$p(this.this$0).Remove(java.lang.int.valueOf(this.$streamId$inlined));
                    } catch (java.lang.Exception th) {
                        throw th;
                    }
                }
            }
        } catch (java.io.IOException unused) {
        }
        return -1L;
    }
}

