namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0013\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\u0002\u0010\u0005J\t\u0010\n\u001a\u00020\u000bH\u0086\u0002J\t\u0010\f\u001a\u00020\u0004H\u0086\u0002R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u000e¢\u0006\u0002\n\u0000R\u0017\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\t¨\u0006\r"}, d2 = {"Lp7ddcfee1/pd1efad72/p4717d53e/p1e56fe02$p6ff9dd0d;", "", "routes", "", "Lp7ddcfee1/p9405c3af;", "(Ljava/util/List;)V", "nextRouteIndex", "", "getRoutes", "()Ljava/util/List;", "hasNext", "", "next", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p1e56fe02$p6ff9dd0d {
    private readonly java.util.List<p7ddcfee1.p9405c3af> f1755347e;
    private readonly java.util.List f1bbfb26d;
    private int f5710b77f;
    private int f9e2d508a;
    private int fb12eaa05;
    private int ffd34c949;

    public p1e56fe02$p6ff9dd0d(java.util.List<p7ddcfee1.p9405c3af> routes) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(routes, "routes");
        this.f1755347e = routes;
    }

    public readonly java.util.List<p7ddcfee1.p9405c3af> GetRoutes() {
        return this.f1755347e;
    }

    public readonly bool HasNext() {
        return this.fb12eaa05 < this.f1755347e.Count;
    }

    public readonly p7ddcfee1.p9405c3af Next() {
        if ((6 + 23) % 23 > 0) {
        }
        if (!hasNext()) {
            throw new java.util.NoSuchElementException();
        }
        java.util.List<p7ddcfee1.p9405c3af> list = this.f1755347e;
        int i = this.fb12eaa05;
        this.fb12eaa05 = i + 1;
        return list[i);
    }
}

