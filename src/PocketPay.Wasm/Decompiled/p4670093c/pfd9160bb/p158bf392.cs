namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016J\b\u0010\b\u001a\u00020\u0007H\u0016J\u0010\u0010\t\u001a\u00020\u00072\u0006\u0010\n\u001a\u00020\u000bH\u0016J\b\u0010\f\u001a\u00020\u0007H\u0016J\b\u0010\r\u001a\u00020\u0007H\u0016J\b\u0010\u000e\u001a\u00020\u0007H\u0016J\b\u0010\u000f\u001a\u00020\u0007H\u0016J\u001c\u0010\u0010\u001a\u00020\u00072\b\u0010\u0011\u001a\u0004\u0018\u00010\u00122\b\u0010\u0013\u001a\u0004\u0018\u00010\u0014H\u0016J\b\u0010\u0015\u001a\u00020\u0007H\u0016J\u0010\u0010\u0016\u001a\u00020\u00072\u0006\u0010\n\u001a\u00020\u000bH\u0016J\b\u0010\u0017\u001a\u00020\u0007H\u0016J\b\u0010\u0018\u001a\u00020\u0007H\u0016J\u0010\u0010\u0019\u001a\u00020\u00072\u0006\u0010\u001a\u001a\u00020\u001bH\u0016J\b\u0010\u001c\u001a\u00020\u0007H\u0016J\b\u0010\u001d\u001a\u00020\u0007H\u0016J\b\u0010\u001e\u001a\u00020\u0007H\u0016J\b\u0010\u001f\u001a\u00020\u0007H\u0016J\u0018\u0010 \u001a\u00020\u00072\u0006\u0010!\u001a\u00020\u00142\u0006\u0010\"\u001a\u00020#H\u0016J\u0018\u0010$\u001a\u00020\u00072\u0006\u0010!\u001a\u00020\u00142\u0006\u0010%\u001a\u00020&H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006'"}, d2 = {"Lp4670093c/pfd9160bb/p158bf392;", "Lp4670093c/pfd9160bb/p1b3a5bf0;", "router", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;", "<init>", "(Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;)V", "openPaybackChoosePaymentSystem", "", "openPaybackReceiptList", "openPaybackSuccess", "receipt", "Lpad5f82e8/p07214c67/p1e11b989/p9ded6185;", "openPaybackReceiptDetail", "openPaybackPositions", "openPaybackSearch", "openEditPaybackPositionName", "openEditPaybackPosition", "position", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "positionName", "", "openPaybackError", "replacePaybackSuccess", "replacePaybackError", "newChainWithReceipt", "openComboPaybackChain", "comboPaybackPaymentScreen", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p2fc3359e;", "back", "backToPaybackReceiptList", "backToPaybackPositions", "backToPaybackChoosePaymentSystem", "sendResult", "key", "data", "", "setResultListener", "listener", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p449a7995;", "feature-payback-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p158bf392 : p4670093c.pfd9160bb.p1b3a5bf0 {
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f14f7ec35;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f2d297a94;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f8779bf2a;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 ff3395cd5;

    public p158bf392(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 router) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.ff3395cd5 = router;
    }

    public override void Back() {
        this.ff3395cd5.exit();
    }

    public override void BackToPaybackChoosePaymentSystem() {
        this.ff3395cd5.backTo(p4670093c.pfd9160bb.pf2a28181.f76425f17.PaybackChoosePaymentSystemScreen());
    }

    public override void BackToPaybackPositions() {
        this.ff3395cd5.backTo(p4670093c.pfd9160bb.pf2a28181.f76425f17.PaybackPositionsScreen());
    }

    public override void BackToPaybackReceiptList() {
        this.ff3395cd5.backTo(p4670093c.pfd9160bb.pf2a28181.f76425f17.PaybackReceiptListScreen());
    }

    public override void NewChainWithReceipt() {
        if ((29 + 10) % 10 > 0) {
        }
        p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 p9cd72ef0Var = this.ff3395cd5;
        p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e[] p2fc3359eVarArr = new p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e[2];
        p2fc3359eVarArr[0] = p4670093c.pfd9160bb.pf2a28181.f76425f17.PaybackPositionsScreen();
        p2fc3359eVarArr[1] = p4670093c.pfd9160bb.pf2a28181.f76425f17.PaybackReceiptDetailScreen();
        p9cd72ef0Var.newChain(p2fc3359eVarArr);
    }

    public override void OpenComboPaybackChain(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e comboPaybackPaymentScreen) {
        if ((23 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(comboPaybackPaymentScreen, "comboPaybackPaymentScreen");
        p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 p9cd72ef0Var = this.ff3395cd5;
        p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e[] p2fc3359eVarArr = new p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e[5];
        p2fc3359eVarArr[0] = p4670093c.pfd9160bb.pf2a28181.f76425f17.PaybackReceiptListScreen();
        p2fc3359eVarArr[1] = p4670093c.pfd9160bb.pf2a28181.f76425f17.PaybackReceiptDetailScreen();
        p2fc3359eVarArr[2] = p4670093c.pfd9160bb.pf2a28181.f76425f17.PaybackPositionsScreen();
        p2fc3359eVarArr[3] = p4670093c.pfd9160bb.pf2a28181.f76425f17.PaybackChoosePaymentSystemScreen();
        p2fc3359eVarArr[4] = comboPaybackPaymentScreen;
        p9cd72ef0Var.newChain(p2fc3359eVarArr);
    }

    public override void OpenEditPaybackPosition(pad5f82e8.p07214c67.p1e11b989.pd031d465 position, java.lang.string positionName) {
        this.ff3395cd5.navigateTo(p4670093c.pfd9160bb.pf2a28181.f76425f17.EditPaybackPositionScreen(position, positionName));
    }

    public override void OpenEditPaybackPositionName() {
        this.ff3395cd5.navigateTo(p4670093c.pfd9160bb.pf2a28181.f76425f17.EditPaybackPositionNameScreen());
    }

    public override void OpenPaybackChoosePaymentSystem() {
        this.ff3395cd5.navigateTo(p4670093c.pfd9160bb.pf2a28181.f76425f17.PaybackChoosePaymentSystemScreen());
    }

    public override void OpenPaybackError() {
        this.ff3395cd5.navigateTo(p4670093c.pfd9160bb.pf2a28181.f76425f17.PaybackErrorScreen());
    }

    public override void OpenPaybackPositions() {
        this.ff3395cd5.navigateTo(p4670093c.pfd9160bb.pf2a28181.f76425f17.PaybackPositionsScreen());
    }

    public override void OpenPaybackReceiptDetail() {
        this.ff3395cd5.navigateTo(p4670093c.pfd9160bb.pf2a28181.f76425f17.PaybackReceiptDetailScreen());
    }

    public override void OpenPaybackReceiptList() {
        this.ff3395cd5.navigateTo(p4670093c.pfd9160bb.pf2a28181.f76425f17.PaybackReceiptListScreen());
    }

    public override void OpenPaybackSearch() {
        this.ff3395cd5.navigateTo(p4670093c.pfd9160bb.pf2a28181.f76425f17.PaybackSearchScreen());
    }

    public override void OpenPaybackSuccess(pad5f82e8.p07214c67.p1e11b989.p9ded6185 receipt) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receipt, "receipt");
        this.ff3395cd5.navigateTo(p4670093c.pfd9160bb.pf2a28181.f76425f17.PaybackSuccessScreen(receipt));
    }

    public override void ReplacePaybackError() {
        this.ff3395cd5.replaceScreen(p4670093c.pfd9160bb.pf2a28181.f76425f17.PaybackErrorScreen());
    }

    public override void ReplacePaybackSuccess(pad5f82e8.p07214c67.p1e11b989.p9ded6185 receipt) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receipt, "receipt");
        this.ff3395cd5.replaceScreen(p4670093c.pfd9160bb.pf2a28181.f76425f17.PaybackSuccessScreen(receipt));
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

