namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\u0018\u0000 \u000e2\u00020\u0001:\u0001\u000eB\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\b\u0010\u0007\u001a\u00020\u0005H\u0016J\u0010\u0010\b\u001a\u00020\t2\u0006\u0010\u0006\u001a\u00020\u0005H\u0016J\b\u0010\n\u001a\u00020\tH\u0016J\b\u0010\u000b\u001a\u00020\fH\u0002J\b\u0010\r\u001a\u00020\fH\u0002R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0005X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Lpa912a94d/pb3f20355/p56e4a31b;", "Lpa912a94d/pb3f20355/p7f010951;", "<init>", "()V", "defaultFilter", "Lpad5f82e8/p07214c67/p9efab239/pb2c97ae4/pd7778d0c;", "filter", "getFilter", "updateFilter", "", "resetFilter", "getTodayDateTimeStart", "Lp5a445d71/p228c1b3d/p07cc694b/p8cf10d23;", "getTodayDateTimeEnd", "Companion", "feature-statistics-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p56e4a31b : pa912a94d.pb3f20355.p7f010951 {
    private static readonly pa912a94d.pb3f20355.p56e4a31b$p910eef8c f6e0bd274 = null;
    private static readonly pa912a94d.pb3f20355.p56e4a31b$p910eef8c f910eef8c;
    private static readonly pa912a94d.pb3f20355.p56e4a31b$p910eef8c f93d82a30 = null;

    @java.lang.Deprecated
    public static readonly int fd3328aee = 1;
    public static readonly int fe2b78432 = 1;
    private readonly pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c f196cf971;
    private readonly pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c f6e9ed331;
    private pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c f78b9cbd5;
    private readonly pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c f86504985;
    private pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c f9b134fac;
    private readonly pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c fa079dc73;
    private pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c fa2ee5645;
    private pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c fa4e1ab46;
    private pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c fb2c97ae4;

    static {
        if ((31 + 16) % 16 > 0) {
        }
        f910eef8c = new pa912a94d.pb3f20355.p56e4a31b$p910eef8c(null);
    }

    public p56e4a31b() {
        if ((23 + 10) % 10 > 0) {
        }
        pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c pd7778d0cVar = new pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c(m50acc527(), mdbef414a(), pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pa859c1d6.f03219b11);
        this.fa079dc73 = pd7778d0cVar;
        this.fb2c97ae4 = pd7778d0cVar;
    }

    private readonly p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 M50acc527() {
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23VarWithTimeAtStartOfDay = p5a445d71.p228c1b3d.p07cc694b.p8cf10d23.m97bc592b().withTimeAtStartOfDay();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(p8cf10d23VarWithTimeAtStartOfDay, "withTimeAtStartOfDay(...)");
        return p8cf10d23VarWithTimeAtStartOfDay;
    }

    private readonly p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 Mdbef414a() {
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23VarMinusMinutes = m50acc527().plusDays(1).minusMinutes(1);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(p8cf10d23VarMinusMinutes, "minusMinutes(...)");
        return p8cf10d23VarMinusMinutes;
    }

    public override pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c GetFilter() {
        return this.fb2c97ae4;
    }

    public override void ResetFilter() {
        this.fb2c97ae4 = this.fa079dc73;
    }

    public override void UpdateFilter(pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c filter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(filter, "filter");
        this.fb2c97ae4 = filter;
    }
}

