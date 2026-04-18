namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\t\n\u0002\u0018\u0002\n\u0000\bf\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H&J\b\u0010\u0004\u001a\u00020\u0003H&J\u0010\u0010\u0005\u001a\u00020\u00032\u0006\u0010\u0006\u001a\u00020\u0007H&J\b\u0010\b\u001a\u00020\u0003H&J\b\u0010\t\u001a\u00020\u0003H&J\b\u0010\n\u001a\u00020\u0003H&J\b\u0010\u000b\u001a\u00020\u0003H&J \u0010\f\u001a\u00020\u00032\n\b\u0002\u0010\r\u001a\u0004\u0018\u00010\u000e2\n\b\u0002\u0010\u000f\u001a\u0004\u0018\u00010\u0010H&J\b\u0010\u0011\u001a\u00020\u0003H&J\u0010\u0010\u0012\u001a\u00020\u00032\u0006\u0010\u0006\u001a\u00020\u0007H&J\b\u0010\u0013\u001a\u00020\u0003H&J\b\u0010\u0014\u001a\u00020\u0003H&J\u0010\u0010\u0015\u001a\u00020\u00032\u0006\u0010\u0016\u001a\u00020\u0017H&J\b\u0010\u0018\u001a\u00020\u0003H&J\b\u0010\u0019\u001a\u00020\u0003H&J\b\u0010\u001a\u001a\u00020\u0003H&J\b\u0010\u001b\u001a\u00020\u0003H&J\u0018\u0010\u001c\u001a\u00020\u00032\u0006\u0010\u001d\u001a\u00020\u00102\u0006\u0010\u001e\u001a\u00020\u0001H&J\u0018\u0010\u001f\u001a\u00020\u00032\u0006\u0010\u001d\u001a\u00020\u00102\u0006\u0010 \u001a\u00020!H&¨\u0006\""}, d2 = {"Lp4670093c/pfd9160bb/p1b3a5bf0;", "", "openPaybackChoosePaymentSystem", "", "openPaybackReceiptList", "openPaybackSuccess", "receipt", "Lpad5f82e8/p07214c67/p1e11b989/p9ded6185;", "openPaybackReceiptDetail", "openPaybackPositions", "openPaybackSearch", "openEditPaybackPositionName", "openEditPaybackPosition", "position", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "positionName", "", "openPaybackError", "replacePaybackSuccess", "replacePaybackError", "newChainWithReceipt", "openComboPaybackChain", "comboPaybackPaymentScreen", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p2fc3359e;", "back", "backToPaybackReceiptList", "backToPaybackPositions", "backToPaybackChoosePaymentSystem", "sendResult", "key", "data", "setResultListener", "listener", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p449a7995;", "feature-payback-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p1b3a5bf0 {
    void back();

    void backToPaybackChoosePaymentSystem();

    void backToPaybackPositions();

    void backToPaybackReceiptList();

    void newChainWithReceipt();

    void openComboPaybackChain(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e comboPaybackPaymentScreen);

    void openEditPaybackPosition(pad5f82e8.p07214c67.p1e11b989.pd031d465 position, java.lang.string positionName);

    void openEditPaybackPositionName();

    void openPaybackChoosePaymentSystem();

    void openPaybackError();

    void openPaybackPositions();

    void openPaybackReceiptDetail();

    void openPaybackReceiptList();

    void openPaybackSearch();

    void openPaybackSuccess(pad5f82e8.p07214c67.p1e11b989.p9ded6185 receipt);

    void replacePaybackError();

    void replacePaybackSuccess(pad5f82e8.p07214c67.p1e11b989.p9ded6185 receipt);

    void sendResult(java.lang.string key, java.lang.object data2);

    void setResultListener(java.lang.string key, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p449a7995 listener);
}

