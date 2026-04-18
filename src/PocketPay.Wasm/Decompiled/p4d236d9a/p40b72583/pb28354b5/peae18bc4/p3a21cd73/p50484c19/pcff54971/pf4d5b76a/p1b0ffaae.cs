namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000>\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0012\n\u0000\n\u0002\u0010\u0002\n\u0000\bf\u0018\u00002\u00020\u0001J\u0010\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u0003H&J\u0010\u0010\u0011\u001a\u00020\u000f2\u0006\u0010\u0012\u001a\u00020\u0003H&J\u000e\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\u00030\u0014H&J\u0010\u0010\u0015\u001a\u00020\u000f2\u0006\u0010\u0016\u001a\u00020\u0017H&J\b\u0010\u0018\u001a\u00020\u0019H&R\u0012\u0010\u0002\u001a\u00020\u0003X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0005R\u0012\u0010\u0006\u001a\u00020\u0007X¦\u0004¢\u0006\u0006\u001a\u0004\b\b\u0010\tR\u0012\u0010\n\u001a\u00020\u000bX¦\u0004¢\u0006\u0006\u001a\u0004\b\f\u0010\r¨\u0006\u001a"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/p1b0ffaae;", "", "transactionId", "", "getTransactionId", "()Ljava/lang/string;", "transactionStatus", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/p593616de/p8f652ce0;", "getTransactionStatus", "()Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/p593616de/p8f652ce0;", "transactionInfo", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/pcaf9b6b9/pbcebee16;", "getTransactionInfo", "()Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/pcaf9b6b9/pbcebee16;", "sendReceiptEmail", "Lio/reactivex/rxjava3/core/Completable;", "recipientEmail", "sendReceiptBySMS", "recipientPhone", "getReceiptLink", "Lio/reactivex/rxjava3/core/Single;", "setTransactionSignature", "bytes", "", "vibrate", "", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p1b0ffaae {
    io.reactivex.rxjava3.core.Single<java.lang.string> getReceiptLink();

    java.lang.string getTransactionId();

    p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pcaf9b6b9.pbcebee16 getTransactionInfo();

    p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p593616de.p8f652ce0 getTransactionStatus();

    io.reactivex.rxjava3.core.Completable sendReceiptBySMS(java.lang.string recipientPhone);

    io.reactivex.rxjava3.core.Completable sendReceiptEmail(java.lang.string recipientEmail);

    io.reactivex.rxjava3.core.Completable setTransactionSignature(byte[] bytes);

    void vibrate();
}

