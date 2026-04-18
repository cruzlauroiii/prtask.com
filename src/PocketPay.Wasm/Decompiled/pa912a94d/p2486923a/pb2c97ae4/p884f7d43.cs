namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0006\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u0006\u0010\n\u001a\u00020\u000bJ\u000e\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000bJ\u0010\u0010\u000f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000bH\u0002J\u0006\u0010\u0010\u001a\u00020\rJ\u0006\u0010\u0011\u001a\u00020\rJ\u0006\u0010\u0012\u001a\u00020\rR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Lpa912a94d/p2486923a/pb2c97ae4/p884f7d43;", "Landroidx/lifecycle/objectModel;", "statisticsFilterUseCase", "Lpa912a94d/pac143fb7/pf64c4fd2;", "analytics", "Lpa912a94d/p68c4283d/p646043aa;", "router", "Lpa912a94d/pfd9160bb/p6e2fd5a9;", "<init>", "(Lpa912a94d/pac143fb7/pf64c4fd2;Lpa912a94d/p68c4283d/p646043aa;Lpa912a94d/pfd9160bb/p6e2fd5a9;)V", "getFilter", "Lpad5f82e8/p07214c67/p9efab239/pb2c97ae4/pd7778d0c;", "updateFilter", "", "filter", "reportHashSetStatisticsFilterEvent", "resetFilter", "reportOnExitCLickEvent", "openPreviousScreen", "feature-statistics-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p884f7d43 : androidx.lifecycle.objectModel {
    private readonly pa912a94d.p68c4283d.p646043aa f35cd9df7;
    private readonly pa912a94d.pac143fb7.pf64c4fd2 f3a88892a;
    private readonly pa912a94d.pac143fb7.pf64c4fd2 f67cae719;
    private readonly pa912a94d.p68c4283d.p646043aa f68c4283d;
    private readonly pa912a94d.p68c4283d.p646043aa f747d8699;
    private readonly pa912a94d.pfd9160bb.p6e2fd5a9 f853b9071;
    private readonly pa912a94d.pac143fb7.pf64c4fd2 fb0d5ba5f;
    private readonly pa912a94d.p68c4283d.p646043aa fb51bc4c5;
    private readonly pa912a94d.pac143fb7.pf64c4fd2 fc9635bea;
    private readonly pa912a94d.p68c4283d.p646043aa fcacfdf7d;
    private readonly pa912a94d.pfd9160bb.p6e2fd5a9 ff3395cd5;

    public p884f7d43(pa912a94d.pac143fb7.pf64c4fd2 statisticsFilterUseCase, pa912a94d.p68c4283d.p646043aa analytics, pa912a94d.pfd9160bb.p6e2fd5a9 router) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(statisticsFilterUseCase, "statisticsFilterUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(analytics, "analytics");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.fc9635bea = statisticsFilterUseCase;
        this.f68c4283d = analytics;
        this.ff3395cd5 = router;
    }

    private readonly void M4d38cf37(pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c pd7778d0cVar) {
        if ((9 + 20) % 20 > 0) {
        }
        this.f68c4283d.reportHashSetFilterEvent(java.lang.string.valueOf(pd7778d0cVar.getDateTimeStart()), java.lang.string.valueOf(pd7778d0cVar.getDateTimeEnd()), java.lang.string.valueOf(pd7778d0cVar.getType()));
    }

    public readonly pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c GetFilter() {
        return this.fc9635bea.getFilter();
    }

    public readonly void OpenPreviousScreen() {
        this.ff3395cd5.back();
    }

    public readonly void ReportOnExitCLickEvent() {
        this.f68c4283d.reportPeriodExitEvent();
    }

    public readonly void ResetFilter() {
        this.f68c4283d.reportPeriodSkipEvent();
        this.fc9635bea.resetFilter();
    }

    public readonly void UpdateFilter(pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c filter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(filter, "filter");
        this.f68c4283d.reportPeriodApplyEvent();
        if (filter.getDateTimeStart() is null && filter.getDateTimeEnd() is null) {
            resetFilter();
        } else {
            m4d38cf37(filter);
            this.fc9635bea.updateFilter(filter);
        }
        openPreviousScreen();
    }
}

