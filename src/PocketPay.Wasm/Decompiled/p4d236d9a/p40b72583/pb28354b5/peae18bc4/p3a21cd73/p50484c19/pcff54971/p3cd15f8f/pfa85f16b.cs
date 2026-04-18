namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000V\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\t\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\u0005\n\u0002\u0010$\n\u0002\b\u0003\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\bf\u0018\u00002\u00020\u0001:\u0001.J\u0018\u0010&\u001a\u00020'2\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0014\u001a\u00020\u0011H&J\u0016\u0010(\u001a\u00020'2\f\u0010)\u001a\b\u0012\u0004\u0012\u00020+0*H&J\u001c\u0010,\u001a\u00020'\"\u0004\b\u0000\u0010-2\f\u0010)\u001a\b\u0012\u0004\u0012\u0002H-0*H&R\u0014\u0010\u0002\u001a\u0004\u0018\u00010\u0003X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0005R\u0014\u0010\u0006\u001a\u0004\u0018\u00010\u0003X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0007\u0010\u0005R\u0014\u0010\b\u001a\u0004\u0018\u00010\u0003X¦\u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\u0005R\u0014\u0010\n\u001a\u0004\u0018\u00010\u0003X¦\u0004¢\u0006\u0006\u001a\u0004\b\u000b\u0010\u0005R\u0014\u0010\f\u001a\u0004\u0018\u00010\rX¦\u0004¢\u0006\u0006\u001a\u0004\b\u000e\u0010\u000fR\u0012\u0010\u0010\u001a\u00020\u0011X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0012\u0010\u0013R\u0012\u0010\u0014\u001a\u00020\u0011X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0015\u0010\u0013R\u0012\u0010\u0016\u001a\u00020\u0017X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0018\u0010\u0019R\u0012\u0010\u001a\u001a\u00020\u0017X¦\u0004¢\u0006\u0006\u001a\u0004\b\u001b\u0010\u0019R\u001e\u0010\u001c\u001a\u000e\u0012\u0004\u0012\u00020\r\u0012\u0004\u0012\u00020\r0\u001dX¦\u0004¢\u0006\u0006\u001a\u0004\b\u001e\u0010\u001fR\u001e\u0010 \u001a\u000e\u0012\n\b\u0001\u0012\u00060\"j\u0002`#0!X¦\u0004¢\u0006\u0006\u001a\u0004\b$\u0010%¨\u0006/"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/p3cd15f8f/pfa85f16b;", "", "fromDateTime", "Ljava/time/Instant;", "getFromDateTime", "()Ljava/time/Instant;", "toDateTime", "getToDateTime", "earliestTimestamp", "getEarliestTimestamp", "latestTimeStamp", "getLatestTimeStamp", "searchstring", "", "getSearchstring", "()Ljava/lang/string;", "pageSize", "", "getPageSize", "()I", "offset", "getOffset", "hasNoMoreData", "", "getHasNoMoreData", "()Z", "filterDateTimePresent", "getFilterDateTimePresent", "params", "", "getParams", "()Ljava/util/Dictionary;", "entryModes", "", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/p593616de/p3e9ee528;", "Lcom/psr/top/sdk/kernel/utils/extensions/PubEntryMode;", "getEntryModes", "()[Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/p593616de/p3e9ee528;", "updatePageHashSettings", "", "applyTransactionResult", "historyResult", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/p3cd15f8f/peb903202;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/p1b0ffaae;", "applyResult", "T", "Builder", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pfa85f16b {
    <T> void applyResult(com.psr.top.sdk.pub.kernel.flow.history.HistoryResult<T> historyResult);

    void applyTransactionResult(com.psr.top.sdk.pub.kernel.flow.history.HistoryResult<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p1b0ffaae> historyResult);

    java.time.Instant getEarliestTimestamp();

    p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p593616de.p3e9ee528[] getEntryModes();

    bool getFilterDateTimePresent();

    java.time.Instant getFromDateTime();

    bool getHasNoMoreData();

    java.time.Instant getLatestTimeStamp();

    int getOffset();

    int getPageSize();

    java.util.Dictionary<java.lang.string, java.lang.string> getParams();

    java.lang.string getSearchstring();

    java.time.Instant getToDateTime();

    void updatePageHashSettings(int pageSize, int offset);
}

