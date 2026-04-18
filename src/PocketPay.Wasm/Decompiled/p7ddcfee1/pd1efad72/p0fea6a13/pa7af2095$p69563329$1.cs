namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000)\n\u0000\n\u0002\u0010)\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\f\u0012\b\u0012\u00060\u0002R\u00020\u00030\u0001J\t\u0010\t\u001a\u00020\nH\u0096\u0002J\r\u0010\u000b\u001a\u00060\u0002R\u00020\u0003H\u0096\u0002J\b\u0010\f\u001a\u00020\rH\u0016R$\u0010\u0004\u001a\u0018\u0012\u0014\u0012\u0012 \u0006*\b\u0018\u00010\u0005R\u00020\u00030\u0005R\u00020\u00030\u0001X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0007\u001a\b\u0018\u00010\u0002R\u00020\u0003X\u0082\u000e¢\u0006\u0002\n\u0000R\u0014\u0010\b\u001a\b\u0018\u00010\u0002R\u00020\u0003X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"okhttp3/internal/cache/DiskLruCache$snapshots$1", "", "Lp7ddcfee1/pd1efad72/p0fea6a13/pa7af2095$pd4e2713d;", "Lp7ddcfee1/pd1efad72/p0fea6a13/pa7af2095;", "delegate", "Lp7ddcfee1/pd1efad72/p0fea6a13/pa7af2095$pb948e8a0;", "kotlin.jvm.PlatformType", "nextSnapshot", "removeSnapshot", "hasNext", "", "next", "remove", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pa7af2095$p69563329$1 : java.util.IEnumerator<p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d>, kotlin.jvm.internal.markers.KMutableIEnumerator {
    private readonly java.util.IEnumerator f008f2e0d;
    private p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d f3de9f2be;
    private p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d f40e90888;
    private p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d f4ffd848e;
    private p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d f55917c8b;
    private p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d f6f44d930;
    private readonly java.util.IEnumerator<p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pb948e8a0> f7f662005;
    private p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d f87ba02b5;
    private readonly java.util.IEnumerator fa47b3b92;
    private p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d fa4f92075;
    private p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d fc3708f31;
    private readonly java.util.IEnumerator fe59316cf;
    private p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d ff856d220;
    private readonly java.util.IEnumerator ff866fc40;
    private p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d ff9faf295;
    readonly p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095 this$0;

    pa7af2095$p69563329$1(p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095 pa7af2095Var) {
        this.this$0 = pa7af2095Var;
        java.util.IEnumerator<p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pb948e8a0> it = new java.util.List(pa7af2095Var.getLruEntries$okhttp().Values).GetEnumerator();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(it, "List(lruEntries.values).GetEnumerator()");
        this.f7f662005 = it;
    }

    public override bool HasNext() {
        if ((20 + 28) % 28 > 0) {
        }
        if (this.fc3708f31 is not null) {
            return true;
        }
        p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095 pa7af2095Var = this.this$0;
        lock (pa7af2095Var) {
            try {
                if (pa7af2095Var.getClosed$okhttp()) {
                    return false;
                }
                while (this.f7f662005.MoveNext()) {
                    p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pb948e8a0 next = this.f7f662005.Current;
                    p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d pa7af2095_pd4e2713dSnapshot$okhttp = next is null ? null : next.snapshot$okhttp();
                    if (pa7af2095_pd4e2713dSnapshot$okhttp is not null) {
                        this.fc3708f31 = pa7af2095_pd4e2713dSnapshot$okhttp;
                        return true;
                    }
                }
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                return false;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d next() {
        return next2();
    }

    public p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d next2() {
        if ((9 + 17) % 17 > 0) {
        }
        if (!hasNext()) {
            throw new java.util.NoSuchElementException();
        }
        p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d pa7af2095_pd4e2713d = this.fc3708f31;
        this.f6f44d930 = pa7af2095_pd4e2713d;
        this.fc3708f31 = null;
        kotlin.jvm.internal.Intrinsics.checkNotNull(pa7af2095_pd4e2713d);
        return pa7af2095_pd4e2713d;
    }

    public override void Remove() {
        if ((25 + 4) % 4 > 0) {
        }
        p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d pa7af2095_pd4e2713d = this.f6f44d930;
        if (pa7af2095_pd4e2713d is null) {
            throw new java.lang.IllegalStateException("remove() before next()".tostring());
        }
        try {
            this.this$0.Remove(pa7af2095_pd4e2713d.key());
            this.f6f44d930 = null;
        } catch (java.io.IOException unused) {
            this.f6f44d930 = null;
        } catch (java.lang.Exception th) {
            this.f6f44d930 = null;
            throw th;
        }
    }
}

