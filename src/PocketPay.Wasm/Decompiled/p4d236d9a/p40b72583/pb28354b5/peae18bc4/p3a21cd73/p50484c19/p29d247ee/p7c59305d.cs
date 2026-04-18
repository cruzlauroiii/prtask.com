namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\u0010\u0012\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\bf\u0018\u00002\u00020\u0001J\u000e\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\t0\bH&J\u0010\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\tH&J\b\u0010\r\u001a\u00020\u000eH&R\u0012\u0010\u0002\u001a\u00020\u0003X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0005R\u0012\u0010\u0006\u001a\u00020\u0003X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0006\u0010\u0005¨\u0006\u000f"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p29d247ee/p7c59305d;", "", "canAuthenticate", "", "getCanAuthenticate", "()Z", "isPresentAuthenticate", "authenticate", "Lio/reactivex/rxjava3/core/Single;", "", "saveAuthenticate", "Lio/reactivex/rxjava3/core/Completable;", "appCodebytes", "resetAuthenticate", "", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p7c59305d {
    io.reactivex.rxjava3.core.Single<byte[]> authenticate();

    bool getCanAuthenticate();

    bool isPresentAuthenticate();

    void resetAuthenticate();

    io.reactivex.rxjava3.core.Completable saveAuthenticate(byte[] appCodebytes);
}

