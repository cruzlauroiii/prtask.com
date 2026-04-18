namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000L\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u0003\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\b`\u0018\u00002\u00020\u0001J\b\u0010\u0006\u001a\u00020\u0007H&J\u0010\u0010\b\u001a\u00020\u00072\u0006\u0010\t\u001a\u00020\nH&J\b\u0010\u000b\u001a\u00020\u0007H&J\u0010\u0010\f\u001a\u00020\u00072\u0006\u0010\t\u001a\u00020\rH&J\u0010\u0010\u000e\u001a\u00020\u00072\u0006\u0010\t\u001a\u00020\u000fH&J\b\u0010\u0010\u001a\u00020\u0011H&J\b\u0010\u0012\u001a\u00020\u0007H&J\u0010\u0010\u0013\u001a\u00020\u00072\u0006\u0010\u0014\u001a\u00020\u0015H&J\u0010\u0010\u0016\u001a\u00020\u00072\u0006\u0010\u0017\u001a\u00020\u0018H&J\b\u0010\u0019\u001a\u00020\u001aH&J\b\u0010\u001b\u001a\u00020\u001aH&R\u0012\u0010\u0002\u001a\u00020\u0003X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0005¨\u0006\u001c"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p8a5da52e/peb0a1917/pd5ae94bc;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p8a5da52e/p593616de/pad63a35e/p0ea295e5;", "apiMode", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p8a5da52e/peb0a1917/p407482fe/pff835616;", "getApiMode", "()Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p8a5da52e/peb0a1917/p407482fe/pff835616;", "initialize", "Lio/reactivex/rxjava3/core/Completable;", "toRequestActivationMode", "response", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p8a5da52e/p07214c67/pae5c58d3;", "toActivatedMode", "toCreateAttestationMode", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p8a5da52e/p07214c67/pdf743a5e;", "toAttestedMode", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p8a5da52e/p07214c67/p77b6e797;", "isAttestationTimeExpired", "", "resetToActivatedMode", "reset", "throwable", "", "createPinSession", "challenge", "", "startPinSession", "", "stopPinSession", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pd5ae94bc : p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p8a5da52e.p593616de.pad63a35e.p0ea295e5 {
    io.reactivex.rxjava3.core.Completable createPinSession(java.lang.string challenge);

    p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p8a5da52e.peb0a1917.p407482fe.pff835616 getApiMode();

    io.reactivex.rxjava3.core.Completable initialize();

    bool isAttestationTimeExpired();

    io.reactivex.rxjava3.core.Completable reset(java.lang.Exception throwable);

    io.reactivex.rxjava3.core.Completable resetToActivatedMode();

    void startPinSession();

    void stopPinSession();

    io.reactivex.rxjava3.core.Completable toActivatedMode();

    io.reactivex.rxjava3.core.Completable toAttestedMode(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p77b6e797 response);

    io.reactivex.rxjava3.core.Completable toCreateAttestationMode(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.pdf743a5e response);

    io.reactivex.rxjava3.core.Completable toRequestActivationMode(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.pae5c58d3 response);
}

