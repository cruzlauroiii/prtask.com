namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\bf\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H&J\u0010\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H&J\u0010\u0010\u0007\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H&J\b\u0010\b\u001a\u00020\u0003H&J\b\u0010\t\u001a\u00020\u0003H&J\b\u0010\n\u001a\u00020\u0003H&J\u0018\u0010\u000b\u001a\u00020\u00032\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000fH&J\u0018\u0010\u0010\u001a\u00020\u00032\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u0011\u001a\u00020\u0012H&J\u0018\u0010\u0010\u001a\u00020\u00032\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u0013\u001a\u00020\u0001H&J\b\u0010\u0014\u001a\u00020\rH&J\b\u0010\u0015\u001a\u00020\rH&¨\u0006\u0016"}, d2 = {"Lpe0212e54/pfd9160bb/p4f60a022;", "", "startShopsFlow", "", "startShopsRoute", "Lpad5f82e8/p07214c67/pfd9160bb/p37893195;", "openShops", "replaceShops", "back", "backToRootScreen", "finish", "setResultListener", "key", "", "listener", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p449a7995;", "sendResult", "deviceType", "Lpad5f82e8/p07214c67/pe0212e54/p6c2f9b8a;", "data", "getOrderDeviceTypeKey", "getHasDeviceInStorageErrorKey", "feature-devices-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p4f60a022 {
    void back();

    void backToRootScreen();

    void finish();

    java.lang.string getHasDeviceInStorageErrorKey();

    java.lang.string getOrderDeviceTypeKey();

    void openShops(pad5f82e8.p07214c67.pfd9160bb.p37893195 startShopsRoute);

    void replaceShops(pad5f82e8.p07214c67.pfd9160bb.p37893195 startShopsRoute);

    void sendResult(java.lang.string key, java.lang.object data2);

    void sendResult(java.lang.string key, pad5f82e8.p07214c67.pe0212e54.p6c2f9b8a deviceType);

    void setResultListener(java.lang.string key, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p449a7995 listener);

    void startShopsFlow(pad5f82e8.p07214c67.pfd9160bb.p37893195 startShopsRoute);
}

