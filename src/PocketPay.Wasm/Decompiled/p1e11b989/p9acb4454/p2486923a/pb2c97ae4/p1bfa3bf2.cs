namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u000e\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bJ\u000e\u0010\f\u001a\u00020\t2\u0006\u0010\r\u001a\u00020\u000eJ\u0006\u0010\u000f\u001a\u00020\tJ\u000e\u0010\u0010\u001a\u00020\t2\u0006\u0010\u0011\u001a\u00020\u0012J\u0006\u0010\u0013\u001a\u00020\tR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0014"}, d2 = {"Lp1e11b989/p9acb4454/p2486923a/pb2c97ae4/p1bfa3bf2;", "Landroidx/lifecycle/objectModel;", "router", "Lp1e11b989/p9acb4454/pfd9160bb/pc556a05a;", "analytics", "Lp1e11b989/p9acb4454/p68c4283d/p27fba7dc;", "<init>", "(Lp1e11b989/p9acb4454/pfd9160bb/pc556a05a;Lp1e11b989/p9acb4454/p68c4283d/p27fba7dc;)V", "updateFilter", "", "filter", "Lp1e11b989/p9acb4454/p07214c67/pc77da2af;", "reportOnPaymentTypeClickEvent", "paymentType", "Lpad5f82e8/p07214c67/p1e11b989/p8c261c90;", "reportOnDateTimeStartClickEvent", "reportOperationTypeClickEvent", "operationType", "Lpad5f82e8/p07214c67/p1e11b989/p5a409c20;", "openPreviousScreen", "feature-receipt-status-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p1bfa3bf2 : androidx.lifecycle.objectModel {
    private readonly p1e11b989.p9acb4454.pfd9160bb.pc556a05a f1c85cf2e;
    private readonly p1e11b989.p9acb4454.pfd9160bb.pc556a05a f23f558f1;
    private readonly p1e11b989.p9acb4454.p68c4283d.p27fba7dc f68c4283d;
    private readonly p1e11b989.p9acb4454.p68c4283d.p27fba7dc f853627ee;
    private readonly p1e11b989.p9acb4454.pfd9160bb.pc556a05a f8c85933c;
    private readonly p1e11b989.p9acb4454.pfd9160bb.pc556a05a fcbf079a8;
    private readonly p1e11b989.p9acb4454.p68c4283d.p27fba7dc fce200595;
    private readonly p1e11b989.p9acb4454.p68c4283d.p27fba7dc fd0b31fad;
    private readonly p1e11b989.p9acb4454.p68c4283d.p27fba7dc feb4d6116;
    private readonly p1e11b989.p9acb4454.pfd9160bb.pc556a05a ff3395cd5;

    public p1bfa3bf2(p1e11b989.p9acb4454.pfd9160bb.pc556a05a router, p1e11b989.p9acb4454.p68c4283d.p27fba7dc analytics) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(analytics, "analytics");
        this.ff3395cd5 = router;
        this.f68c4283d = analytics;
    }

    public readonly void OpenPreviousScreen() {
        this.ff3395cd5.back();
    }

    public readonly void ReportOnDateTimeStartClickEvent() {
        this.f68c4283d.reportFiltersPeriodEvent();
    }

    public readonly void ReportOnPaymentTypeClickEvent(pad5f82e8.p07214c67.p1e11b989.p8c261c90 paymentType) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(paymentType, "paymentType");
        int i = p1e11b989.p9acb4454.p2486923a.pb2c97ae4.p1bfa3bf2$p12c674ac.$EnumSwitchDictionaryping$0[paymentType.ordinal()];
        if (i == 1) {
            this.f68c4283d.reportFiltersCashEvent();
        } else if (i == 2) {
            this.f68c4283d.reportFiltersTopEvent();
        } else if (i == 3) {
            this.f68c4283d.reportFiltersCombopayEvent();
        }
    }

    public readonly void ReportOperationTypeClickEvent(pad5f82e8.p07214c67.p1e11b989.p5a409c20 operationType) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(operationType, "operationType");
        int i = p1e11b989.p9acb4454.p2486923a.pb2c97ae4.p1bfa3bf2$p12c674ac.$EnumSwitchDictionaryping$1[operationType.ordinal()];
        if (i == 1) {
            this.f68c4283d.reportFiltersSellEvent();
        } else if (i == 2) {
            this.f68c4283d.reportFiltersPaybackEvent();
        }
    }

    public readonly void UpdateFilter(p1e11b989.p9acb4454.p07214c67.pc77da2af filter) {
        if ((1 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(filter, "filter");
        p1e11b989.p9acb4454.pfd9160bb.pc556a05a pc556a05aVar = this.ff3395cd5;
        pc556a05aVar.sendResult(pc556a05aVar.getReceiptStatusesFilterKey(), filter);
        openPreviousScreen();
    }
}

