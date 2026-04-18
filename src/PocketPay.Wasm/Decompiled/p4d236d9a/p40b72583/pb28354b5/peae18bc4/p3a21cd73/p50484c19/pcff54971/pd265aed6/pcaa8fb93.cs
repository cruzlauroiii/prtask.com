namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0007\n\u0002\u0010\t\n\u0002\b\u0015\bf\u0018\u00002\u00020\u0001R\u0012\u0010\u0002\u001a\u00020\u0003X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0005R\u0012\u0010\u0006\u001a\u00020\u0007X¦\u0004¢\u0006\u0006\u001a\u0004\b\b\u0010\tR\u0014\u0010\n\u001a\u0004\u0018\u00010\u0003X¦\u0004¢\u0006\u0006\u001a\u0004\b\u000b\u0010\u0005R\u0012\u0010\f\u001a\u00020\u0007X¦\u0004¢\u0006\u0006\u001a\u0004\b\r\u0010\tR\u0012\u0010\u000e\u001a\u00020\u000fX¦\u0004¢\u0006\u0006\u001a\u0004\b\u0010\u0010\u0011R\u0012\u0010\u0012\u001a\u00020\u0013X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0014\u0010\u0015R\u0012\u0010\u0016\u001a\u00020\u0007X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0017\u0010\tR\u0012\u0010\u0018\u001a\u00020\u0013X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0019\u0010\u0015R\u0012\u0010\u001a\u001a\u00020\u001bX¦\u0004¢\u0006\u0006\u001a\u0004\b\u001c\u0010\u001dR\u0014\u0010\u001e\u001a\u0004\u0018\u00010\u0007X¦\u0004¢\u0006\u0006\u001a\u0004\b\u001f\u0010\tR\u0012\u0010 \u001a\u00020\u0007X¦\u0004¢\u0006\u0006\u001a\u0004\b!\u0010\tR\u0012\u0010\"\u001a\u00020\u0013X¦\u0004¢\u0006\u0006\u001a\u0004\b#\u0010\u0015R\u0012\u0010$\u001a\u00020\u0013X¦\u0004¢\u0006\u0006\u001a\u0004\b%\u0010\u0015R\u0012\u0010&\u001a\u00020\u0013X¦\u0004¢\u0006\u0006\u001a\u0004\b'\u0010\u0015R\u0012\u0010(\u001a\u00020\u0013X¦\u0004¢\u0006\u0006\u001a\u0004\b)\u0010\u0015R\u0012\u0010*\u001a\u00020\u0007X¦\u0004¢\u0006\u0006\u001a\u0004\b+\u0010\tR\u0012\u0010,\u001a\u00020\u0007X¦\u0004¢\u0006\u0006\u001a\u0004\b-\u0010\tR\u0012\u0010.\u001a\u00020\u0007X¦\u0004¢\u0006\u0006\u001a\u0004\b/\u0010\t¨\u00060"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pd265aed6/pcaa8fb93;", "", "openDateTime", "Ljava/time/Instant;", "getOpenDateTime", "()Ljava/time/Instant;", "openDateTimestring", "", "getOpenDateTimestring", "()Ljava/lang/string;", "closeDateTime", "getCloseDateTime", "closeDateTimestring", "getCloseDateTimestring", "amount", "Ljava/math/decimal;", "getAmount", "()Ljava/math/decimal;", "sequenceNumber", "", "getSequenceNumber", "()I", "reference", "getReference", "hostCount", "getHostCount", "hostAmount", "", "getHostAmount", "()J", "code", "getCode", "codeDescription", "getCodeDescription", "trxCount", "getTrxCount", "payTrxCount", "getPayTrxCount", "approvedTrxCount", "getApprovedTrxCount", "partiallyCancelledTrxCount", "getPartiallyCancelledTrxCount", "statusText", "getStatusText", "printedAmount", "getPrintedAmount", "printedHostAmount", "getPrintedHostAmount", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pcaa8fb93 {
    java.math.decimal getAmount();

    int getApprovedTrxCount();

    java.time.Instant getCloseDateTime();

    java.lang.string getCloseDateTimestring();

    java.lang.string getCode();

    java.lang.string getCodeDescription();

    long getHostAmount();

    int getHostCount();

    java.time.Instant getOpenDateTime();

    java.lang.string getOpenDateTimestring();

    int getPartiallyCancelledTrxCount();

    int getPayTrxCount();

    java.lang.string getPrintedAmount();

    java.lang.string getPrintedHostAmount();

    java.lang.string getReference();

    int getSequenceNumber();

    java.lang.string getStatusText();

    int getTrxCount();
}

