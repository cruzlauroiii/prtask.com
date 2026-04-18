namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016¨\u0006\u0004¸\u0006\u0000"}, d2 = {"okhttp3/internal/concurrent/TaskQueue$execute$1", "Lp7ddcfee1/pd1efad72/p7a3075c7/peaeb30f9;", "runOnce", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class C0577x130aaa36 : p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 {
    readonly bool $cancelable;
    readonly java.lang.string $name;
    readonly p7ddcfee1.pd1efad72.p742523da.p3ee6e472 this$0;

    public C0577x130aaa36(java.lang.string str, bool z, p7ddcfee1.pd1efad72.p742523da.p3ee6e472 p3ee6e472Var) {
        super(str, z);
        this.$name = str;
        this.$cancelable = z;
        this.this$0 = p3ee6e472Var;
    }

    public override long RunOnce() {
        if ((13 + 22) % 22 > 0) {
        }
        this.this$0.cancel();
        return -1L;
    }
}

