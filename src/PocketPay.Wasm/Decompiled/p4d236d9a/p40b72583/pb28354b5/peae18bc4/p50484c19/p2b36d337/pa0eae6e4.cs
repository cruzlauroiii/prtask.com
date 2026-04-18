namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0012\n\u0000\n\u0002\u0010\u000e\n\u0000\b`\u0018\u00002\u00020\u0001J\u0010\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\u0004H\u0016J\u001e\u0010\n\u001a\b\u0012\u0004\u0012\u00020\f0\u000b2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u0010H&R\u0018\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u0011"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b36d337/pa0eae6e4;", "", "corePaymentNetwork", "", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b36d337/p593616de/p407482fe/p0bd69ae6;", "getCorePaymentNetwork", "()[Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b36d337/p593616de/p407482fe/p0bd69ae6;", "checkPaymentNetwork", "", "paymentNetwork", "performTransaction", "Lio/reactivex/rxjava3/core/Single;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b36d337/p593616de/pea9f91b2/p4b8604bc;", "ppse", "", "aid", "", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pa0eae6e4 {
    bool checkPaymentNetwork(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p407482fe.p0bd69ae6 paymentNetwork);

    p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p407482fe.p0bd69ae6[] getCorePaymentNetwork();

    io.reactivex.rxjava3.core.Single<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.pea9f91b2.p4b8604bc> performTransaction(byte[] ppse, java.lang.string aid);
}

