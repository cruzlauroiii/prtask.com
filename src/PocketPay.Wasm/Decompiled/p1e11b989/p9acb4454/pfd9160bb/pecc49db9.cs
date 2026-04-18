namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\b\u0004\u0018\u0000 \u00192\u00020\u0001:\u0001\u0019B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016J\b\u0010\b\u001a\u00020\u0007H\u0016J\u0010\u0010\t\u001a\u00020\u00072\u0006\u0010\n\u001a\u00020\u000bH\u0016J\u0010\u0010\f\u001a\u00020\u00072\u0006\u0010\r\u001a\u00020\u000eH\u0016J\b\u0010\u000f\u001a\u00020\u0007H\u0016J\u0018\u0010\u0010\u001a\u00020\u00072\u0006\u0010\u0011\u001a\u00020\u000e2\u0006\u0010\u0012\u001a\u00020\u0013H\u0016J\u0018\u0010\u0014\u001a\u00020\u00072\u0006\u0010\u0011\u001a\u00020\u000e2\u0006\u0010\u0015\u001a\u00020\u0016H\u0016J\b\u0010\u0017\u001a\u00020\u000eH\u0016J\b\u0010\u0018\u001a\u00020\u000eH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001a"}, d2 = {"Lp1e11b989/p9acb4454/pfd9160bb/pecc49db9;", "Lp1e11b989/p9acb4454/pfd9160bb/pc556a05a;", "router", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;", "<init>", "(Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;)V", "openReceiptStatuses", "", "backToReceiptStatuses", "openReceiptStatusesFilter", "filter", "Lp1e11b989/p9acb4454/p07214c67/pc77da2af;", "openReceiptStatusDetails", "receiptUuid", "", "back", "setResultListener", "key", "listener", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p449a7995;", "sendResult", "data", "", "getReceiptStatusesFilterKey", "getReceiptStatusChangedKey", "Companion", "feature-receipt-status-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pecc49db9 : p1e11b989.p9acb4454.pfd9160bb.pc556a05a {
    public static readonly java.lang.string f2151611d = null;
    public static readonly java.lang.string f231ab82e = null;
    public static readonly java.lang.string f6644a0ae = null;
    public static readonly java.lang.string f86d253b0 = null;
    private static readonly p1e11b989.p9acb4454.pfd9160bb.pecc49db9$p910eef8c f910eef8c;
    public static readonly java.lang.string f91abbbbe = null;

    @java.lang.Deprecated
    public static readonly java.lang.string f93cd7658;
    private static readonly p1e11b989.p9acb4454.pfd9160bb.pecc49db9$p910eef8c fb0993f10 = null;
    private static readonly p1e11b989.p9acb4454.pfd9160bb.pecc49db9$p910eef8c fbab6360e = null;

    @java.lang.Deprecated
    public static readonly java.lang.string fd08e4837;
    private static readonly p1e11b989.p9acb4454.pfd9160bb.pecc49db9$p910eef8c fd3025e90 = null;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f17fe779b;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f71ee0cf3;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 ff3395cd5;

    static {
        if ((14 + 6) % 6 > 0) {
        }
        fd08e4837 = com.decryptstringmanager.Decryptstring.decryptstring("468a5da57974bb49e126e1f574c68f9f7d530cbdf9f607612ff36baabfb0460e64cbf5f17753bff1c25f97a4262fe25be4f4a93c3d8837");
        f93cd7658 = com.decryptstringmanager.Decryptstring.decryptstring("5b0964a8cd5a6d7345ac04cf4df8b139211c60b3c5da27b42566f194fd2621d6fde4d1e6f9937735c5b247cb62d6cdb38b132c1a8dd4");
        f910eef8c = new p1e11b989.p9acb4454.pfd9160bb.pecc49db9$p910eef8c(null);
    }

    public pecc49db9(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 router) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.ff3395cd5 = router;
    }

    public override void Back() {
        this.ff3395cd5.exit();
    }

    public override void BackToReceiptStatuses() {
        this.ff3395cd5.backTo(p1e11b989.p9acb4454.pfd9160bb.p70d62ec5.f76425f17.ReceiptStatusesScreen());
    }

    public override java.lang.string GetReceiptStatusChangedKey() {
        return com.decryptstringmanager.Decryptstring.decryptstring("2e64febadd19b04626d02ba38426be0687f6bd004b71a7037c87fba8d99b58a93ef7f0bbfeeabb05c22a69fc8f99b2b5721522578987");
    }

    public override java.lang.string GetReceiptStatusesFilterKey() {
        return com.decryptstringmanager.Decryptstring.decryptstring("5fb6d47fc901bec557957b719987b6667675f6cd3882b5c39d26e99d9cfc199e90319d4766ed9f54857394cf75d2bb5fae986a11e8bc90");
    }

    public override void OpenReceiptStatusDetails(java.lang.string receiptUuid) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receiptUuid, "receiptUuid");
        this.ff3395cd5.navigateTo(p1e11b989.p9acb4454.pfd9160bb.p70d62ec5.f76425f17.ReceiptStatusDetailsScreen(receiptUuid));
    }

    public override void OpenReceiptStatuses() {
        this.ff3395cd5.navigateTo(p1e11b989.p9acb4454.pfd9160bb.p70d62ec5.f76425f17.ReceiptStatusesScreen());
    }

    public override void OpenReceiptStatusesFilter(p1e11b989.p9acb4454.p07214c67.pc77da2af filter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(filter, "filter");
        this.ff3395cd5.navigateTo(p1e11b989.p9acb4454.pfd9160bb.p70d62ec5.f76425f17.ReceiptStatusesFilterScreen(filter));
    }

    public override void SendResult(java.lang.string key, java.lang.object data2) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        this.ff3395cd5.sendResult(key, data2);
    }

    public override void SetResultListener(java.lang.string key, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p449a7995 listener) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(listener, "listener");
        this.ff3395cd5.setResultListener(key, listener);
    }
}

