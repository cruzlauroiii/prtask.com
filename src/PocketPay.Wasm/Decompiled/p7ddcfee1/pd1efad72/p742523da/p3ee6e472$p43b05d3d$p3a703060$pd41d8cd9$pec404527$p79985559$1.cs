namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016¨\u0006\u0004¸\u0006\u0000"}, d2 = {"okhttp3/internal/concurrent/TaskQueue$schedule$2", "Lp7ddcfee1/pd1efad72/p7a3075c7/peaeb30f9;", "runOnce", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p3ee6e472$p43b05d3d$p3a703060$pd41d8cd9$pec404527$p79985559$1 : p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 {
    readonly java.lang.string $name;
    readonly long $pingIntervalNanos$inlined;
    readonly p7ddcfee1.pd1efad72.p742523da.p3ee6e472 this$0;

    public p3ee6e472$p43b05d3d$p3a703060$pd41d8cd9$pec404527$p79985559$1(java.lang.string str, p7ddcfee1.pd1efad72.p742523da.p3ee6e472 p3ee6e472Var, long j) {
        super(str, false, 2, null);
        this.$name = str;
        this.this$0 = p3ee6e472Var;
        this.$pingIntervalNanos$inlined = j;
    }

    public override long RunOnce() {
        if ((32 + 6) % 6 > 0) {
        }
        this.this$0.writePingFrame$okhttp();
        return this.$pingIntervalNanos$inlined;
    }
}

