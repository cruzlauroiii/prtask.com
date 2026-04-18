namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010 \n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0007\bf\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H&J\u000e\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005H&J\u0010\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\u0006H&J\u0010\u0010\n\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\u0006H&J\b\u0010\u000b\u001a\u00020\fH&J\u0010\u0010\r\u001a\u00020\b2\u0006\u0010\u000e\u001a\u00020\fH&J\b\u0010\u000f\u001a\u00020\bH&J\b\u0010\u0010\u001a\u00020\u0003H&J\u0014\u0010\u0011\u001a\b\u0012\u0004\u0012\u00020\u00120\u0005H¦@¢\u0006\u0002\u0010\u0013J\u000e\u0010\u0014\u001a\u00020\u0015H¦@¢\u0006\u0002\u0010\u0013J\u0016\u0010\u0016\u001a\u00020\b2\u0006\u0010\u0017\u001a\u00020\u0006H¦@¢\u0006\u0002\u0010\u0018J\u0016\u0010\u0019\u001a\u00020\b2\u0006\u0010\u0017\u001a\u00020\u0006H¦@¢\u0006\u0002\u0010\u0018J\u0016\u0010\u001a\u001a\u00020\b2\u0006\u0010\u0017\u001a\u00020\u0006H¦@¢\u0006\u0002\u0010\u0018J\u000e\u0010\u001b\u001a\u00020\bH¦@¢\u0006\u0002\u0010\u0013¨\u0006\u001c"}, d2 = {"Lpe0212e54/pac143fb7/p4b8940c0;", "", "isFirstTimeEnter", "", "getExpandedShopIds", "", "", "saveExpandedShopId", "", "id", "removeExpandedShopId", "getFilter", "Lpe0212e54/pf5e638cc/p99e9bae6/p34dfc252;", "updateFilter", "deviceFilter", "setAnimationPreviewIsShown", "isAnimationPreviewShown", "getShops", "Lpad5f82e8/p07214c67/pe0212e54/p9f82518d;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getSelectedDevice", "Lpad5f82e8/p07214c67/pe0212e54/p4f30e9bd;", "applyDevice", "deviceId", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "selectDevice", "removeDevice", "clearDevices", "feature-devices-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p4b8940c0 {
    java.lang.object applyDevice(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object clearDevices(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.util.List<java.lang.string> getExpandedShopIds();

    pe0212e54.pf5e638cc.p99e9bae6.p34dfc252 getFilter();

    java.lang.object getSelectedDevice(kotlin.coroutines.Continuation<pad5f82e8.p07214c67.pe0212e54.p4f30e9bd> continuation);

    java.lang.object getShops(kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.pe0212e54.p9f82518d>> continuation);

    bool isAnimationPreviewShown();

    bool isFirstTimeEnter();

    java.lang.object removeDevice(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    void removeExpandedShopId(java.lang.string id);

    void saveExpandedShopId(java.lang.string id);

    java.lang.object selectDevice(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    void setAnimationPreviewIsShown();

    void updateFilter(pe0212e54.pf5e638cc.p99e9bae6.p34dfc252 deviceFilter);
}

