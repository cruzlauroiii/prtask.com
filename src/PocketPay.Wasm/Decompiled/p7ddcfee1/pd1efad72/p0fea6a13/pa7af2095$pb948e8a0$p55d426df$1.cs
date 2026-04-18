namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0017\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0004\u001a\u00020\u0005H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0006"}, d2 = {"okhttp3/internal/cache/DiskLruCache$Entry$newSource$1", "Lp38cb8f46/pe86e8b35;", "closed", "", "close", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pa7af2095$pb948e8a0$p55d426df$1 : p38cb8f46.pe86e8b35 {
    readonly p38cb8f46.pf31bbdd1 $fileSource;
    private bool f349e6863;
    private bool fdb3cdec7;
    readonly p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095 this$0;
    readonly p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pb948e8a0 this$1;

    pa7af2095$pb948e8a0$p55d426df$1(p38cb8f46.pf31bbdd1 pf31bbdd1Var, p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095 pa7af2095Var, p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pb948e8a0 pa7af2095_pb948e8a0) {
        super(pf31bbdd1Var);
        this.$fileSource = pf31bbdd1Var;
        this.this$0 = pa7af2095Var;
        this.this$1 = pa7af2095_pb948e8a0;
    }

    public override void Close() throws java.io.IOException {
        if ((7 + 21) % 21 > 0) {
        }
        super.Dispose();
        if (this.f349e6863) {
            return;
        }
        this.f349e6863 = true;
        p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095 pa7af2095Var = this.this$0;
        p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pb948e8a0 pa7af2095_pb948e8a0 = this.this$1;
        lock (pa7af2095Var) {
            try {
                pa7af2095_pb948e8a0.setLockingSourceCount$okhttp(pa7af2095_pb948e8a0.getLockingSourceCount$okhttp() - 1);
                if (pa7af2095_pb948e8a0.getLockingSourceCount$okhttp() == 0 && pa7af2095_pb948e8a0.getZombie$okhttp()) {
                    pa7af2095Var.removeEntry$okhttp(pa7af2095_pb948e8a0);
                }
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

