namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\b\b\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0006\bf\u0018\u00002\u00020\u0001J\u001c\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005H¦@¢\u0006\u0002\u0010\u0007J\u0014\u0010\b\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005H¦@¢\u0006\u0002\u0010\tJ\u000e\u0010\n\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\tJ\u000e\u0010\u000b\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\tJ\u0016\u0010\f\u001a\u00020\u00032\u0006\u0010\r\u001a\u00020\u000eH¦@¢\u0006\u0002\u0010\u000fJ\u001c\u0010\u0010\u001a\u00020\u00032\f\u0010\u0011\u001a\b\u0012\u0004\u0012\u00020\u000e0\u0005H¦@¢\u0006\u0002\u0010\u0007J\u001c\u0010\u0012\u001a\u00020\u00032\f\u0010\u0011\u001a\b\u0012\u0004\u0012\u00020\u000e0\u0005H¦@¢\u0006\u0002\u0010\u0007J\u0014\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\u000e0\u0005H¦@¢\u0006\u0002\u0010\tJ\u0014\u0010\u0014\u001a\b\u0012\u0004\u0012\u00020\u000e0\u0005H¦@¢\u0006\u0002\u0010\tJ\u0014\u0010\u0015\u001a\b\u0012\u0004\u0012\u00020\u000e0\u0005H¦@¢\u0006\u0002\u0010\tJ\u0016\u0010\u0016\u001a\u00020\u00172\u0006\u0010\u0018\u001a\u00020\u0019H¦@¢\u0006\u0002\u0010\u001aJ\u0016\u0010\u001b\u001a\u00020\u000e2\u0006\u0010\u0018\u001a\u00020\u0019H¦@¢\u0006\u0002\u0010\u001aJ\u0016\u0010\u001c\u001a\u00020\u00192\u0006\u0010\u001d\u001a\u00020\u0019H¦@¢\u0006\u0002\u0010\u001aJ\u0016\u0010\u001e\u001a\u00020\u00032\u0006\u0010\u001f\u001a\u00020 H¦@¢\u0006\u0002\u0010!J\u0016\u0010\"\u001a\u00020 2\u0006\u0010\u0018\u001a\u00020\u0019H¦@¢\u0006\u0002\u0010\u001aJ\u0016\u0010#\u001a\u00020\u00032\u0006\u0010\u0018\u001a\u00020\u0019H¦@¢\u0006\u0002\u0010\u001aJ\u0016\u0010$\u001a\u00020\u00032\u0006\u0010\u0018\u001a\u00020\u0019H¦@¢\u0006\u0002\u0010\u001aJ\u000e\u0010%\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\t¨\u0006&"}, d2 = {"Lpe0212e54/pb3f20355/pfeb9ca41;", "Lpe0212e54/pb3f20355/p83b4b395;", "updateShops", "", "shops", "", "Lpe0212e54/pf5e638cc/pd77d5e50/p107d0d2a;", "(Ljava/util/List;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getShops", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "clearShops", "removeRemoteDevices", "updateDevice", "device", "Lpe0212e54/pf5e638cc/pd77d5e50/p6285e3eb;", "(Lpe0212e54/pf5e638cc/pd77d5e50/p6285e3eb;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateDevices", "devices", "updateRemoteDevices", "getAllDevices", "getRemoteDevices", "getLocalDevices", "hasDevice", "", "deviceId", "", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getDevice", "getDeviceIdByUuid", "deviceUuid", "updateDeviceStatus", "deviceStatus", "Lpe0212e54/pf5e638cc/pd77d5e50/p94db0041;", "(Lpe0212e54/pf5e638cc/pd77d5e50/p94db0041;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getDeviceStatusByDeviceId", "selectDevice", "removeDevice", "clearDevices", "feature-devices-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pfeb9ca41 : pe0212e54.pb3f20355.p83b4b395 {
    java.lang.object clearDevices(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object clearShops(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object getAllDevices(kotlin.coroutines.Continuation<? super java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb>> continuation);

    java.lang.object getDevice(java.lang.string str, kotlin.coroutines.Continuation<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb> continuation);

    java.lang.object getDeviceIdByUuid(java.lang.string str, kotlin.coroutines.Continuation<java.lang.string> continuation);

    java.lang.object getDeviceStatusByDeviceId(java.lang.string str, kotlin.coroutines.Continuation<pe0212e54.pf5e638cc.pd77d5e50.p94db0041> continuation);

    java.lang.object getLocalDevices(kotlin.coroutines.Continuation<? super java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb>> continuation);

    java.lang.object getRemoteDevices(kotlin.coroutines.Continuation<? super java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb>> continuation);

    java.lang.object getShops(kotlin.coroutines.Continuation<? super java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p107d0d2a>> continuation);

    java.lang.object hasDevice(java.lang.string str, kotlin.coroutines.Continuation<java.lang.bool> continuation);

    java.lang.object removeDevice(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object removeRemoteDevices(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object selectDevice(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateDevice(pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb p6285e3ebVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateDeviceStatus(pe0212e54.pf5e638cc.pd77d5e50.p94db0041 p94db0041Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateDevices(java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateRemoteDevices(java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateShops(java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p107d0d2a> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

