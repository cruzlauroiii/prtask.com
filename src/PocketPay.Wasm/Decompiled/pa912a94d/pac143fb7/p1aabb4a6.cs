namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016J\u0010\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u0007H\u0016J\b\u0010\u000b\u001a\u00020\tH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lpa912a94d/pac143fb7/p1aabb4a6;", "Lpa912a94d/pac143fb7/pf64c4fd2;", "statisticsFilterRepository", "Lpa912a94d/pb3f20355/p7f010951;", "<init>", "(Lpa912a94d/pb3f20355/p7f010951;)V", "getFilter", "Lpad5f82e8/p07214c67/p9efab239/pb2c97ae4/pd7778d0c;", "updateFilter", "", "filter", "resetFilter", "feature-statistics-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p1aabb4a6 : pa912a94d.pac143fb7.pf64c4fd2 {
    private readonly pa912a94d.pb3f20355.p7f010951 f08a036c3;
    private readonly pa912a94d.pb3f20355.p7f010951 f095a75ed;
    private readonly pa912a94d.pb3f20355.p7f010951 f5e3f6c96;
    private readonly pa912a94d.pb3f20355.p7f010951 f9e740222;

    public p1aabb4a6(pa912a94d.pb3f20355.p7f010951 statisticsFilterRepository) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(statisticsFilterRepository, "statisticsFilterRepository");
        this.f095a75ed = statisticsFilterRepository;
    }

    public override pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c GetFilter() {
        return this.f095a75ed.getFilter();
    }

    public override void ResetFilter() {
        this.f095a75ed.resetFilter();
    }

    public override void UpdateFilter(pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c filter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(filter, "filter");
        this.f095a75ed.updateFilter(filter);
    }
}

