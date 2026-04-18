namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\bf\u0018\u00002\u00020\u0001J*\u0010\n\u001a\b\u0012\u0004\u0012\u00020\u00030\u000b2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000f2\n\b\u0002\u0010\u0010\u001a\u0004\u0018\u00010\u000fH&J\b\u0010\u0011\u001a\u00020\u0012H&R\u0012\u0010\u0002\u001a\u00020\u0003X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0005R\u0012\u0010\u0006\u001a\u00020\u0007X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0006\u0010\bR\u0012\u0010\t\u001a\u00020\u0007X¦\u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\b¨\u0006\u0013"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/p24eed33e/pb0de681f;", "", "activation", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/p24eed33e/pa9a62e70;", "getActivation", "()Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/p24eed33e/pa9a62e70;", "isActivated", "", "()Z", "isReady", "performActivation", "Lio/reactivex/rxjava3/core/Single;", "activationType", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/p24eed33e/pdc33845b;", "activationstring", "", "rnsId", "resetActivation", "Lio/reactivex/rxjava3/core/Completable;", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pb0de681f {
    p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.p24eed33e.pa9a62e70 getActivation();

    bool isActivated();

    bool isReady();

    io.reactivex.rxjava3.core.Single<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.p24eed33e.pa9a62e70> performActivation(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.p24eed33e.pdc33845b activationType, java.lang.string activationstring, java.lang.string rnsId);

    io.reactivex.rxjava3.core.Completable resetActivation();
}

