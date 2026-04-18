namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0005\bf\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H&J\b\u0010\u0004\u001a\u00020\u0003H&J\u0010\u0010\u0005\u001a\u00020\u00032\u0006\u0010\u0006\u001a\u00020\u0007H&J\u0010\u0010\b\u001a\u00020\u00032\u0006\u0010\t\u001a\u00020\nH&J\b\u0010\u000b\u001a\u00020\u0003H&J\u0018\u0010\f\u001a\u00020\u00032\u0006\u0010\r\u001a\u00020\n2\u0006\u0010\u000e\u001a\u00020\u000fH&J\u0018\u0010\u0010\u001a\u00020\u00032\u0006\u0010\r\u001a\u00020\n2\u0006\u0010\u0011\u001a\u00020\u0001H&J\b\u0010\u0012\u001a\u00020\nH&J\b\u0010\u0013\u001a\u00020\nH&¨\u0006\u0014"}, d2 = {"Lp1e11b989/p9acb4454/pfd9160bb/pc556a05a;", "", "openReceiptStatuses", "", "backToReceiptStatuses", "openReceiptStatusesFilter", "filter", "Lp1e11b989/p9acb4454/p07214c67/pc77da2af;", "openReceiptStatusDetails", "receiptUuid", "", "back", "setResultListener", "key", "listener", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p449a7995;", "sendResult", "data", "getReceiptStatusesFilterKey", "getReceiptStatusChangedKey", "feature-receipt-status-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pc556a05a {
    void back();

    void backToReceiptStatuses();

    java.lang.string getReceiptStatusChangedKey();

    java.lang.string getReceiptStatusesFilterKey();

    void openReceiptStatusDetails(java.lang.string receiptUuid);

    void openReceiptStatuses();

    void openReceiptStatusesFilter(p1e11b989.p9acb4454.p07214c67.pc77da2af filter);

    void sendResult(java.lang.string key, java.lang.object data2);

    void setResultListener(java.lang.string key, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p449a7995 listener);
}

