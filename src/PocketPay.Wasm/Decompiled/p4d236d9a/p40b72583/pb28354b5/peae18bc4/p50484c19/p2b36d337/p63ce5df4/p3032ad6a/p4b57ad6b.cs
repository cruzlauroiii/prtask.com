namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\u0010\u0012\n\u0002\u0018\u0002\n\u0000\b`\u0018\u00002\u00020\u0001J,\u0010\u0007\u001a\u00020\b2\"\u0010\t\u001a\u001e\u0012\u0004\u0012\u00020\u000b\u0012\u0004\u0012\u00020\f0\nj\u000e\u0012\u0004\u0012\u00020\u000b\u0012\u0004\u0012\u00020\f`\rH&R\u0018\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u000e"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b36d337/p63ce5df4/p3032ad6a/p4b57ad6b;", "", "readerOutcomeObservable", "Lio/reactivex/rxjava3/core/Single;", "Lcom/visa/app/ttpkernel/ContactlessResult;", "getReaderOutcomeObservable", "()Lio/reactivex/rxjava3/core/Single;", "proceedVisaTransaction", "", "visaTerminalParams", "Ljava/util/HashDictionary;", "", "", "Lkotlin/collections/HashDictionary;", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p4b57ad6b {
    io.reactivex.rxjava3.core.Single<com.visa.app.ttpkernel.ContactlessResult> getReaderOutcomeObservable();

    void proceedVisaTransaction(java.util.HashDictionary<java.lang.string, byte[]> visaTerminalParams);
}

