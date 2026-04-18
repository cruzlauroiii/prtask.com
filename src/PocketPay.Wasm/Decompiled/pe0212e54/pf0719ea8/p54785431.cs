namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\b\n\n\u0002\u0010\u000e\n\u0002\b\f\bg\u0018\u00002\u00020\u0001J\u0016\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H§@¢\u0006\u0002\u0010\u0006J\u001c\u0010\u0007\u001a\u00020\u00032\f\u0010\b\u001a\b\u0012\u0004\u0012\u00020\u00050\tH§@¢\u0006\u0002\u0010\nJ\u0016\u0010\u000b\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H§@¢\u0006\u0002\u0010\u0006J\u001c\u0010\f\u001a\u00020\u00032\f\u0010\b\u001a\b\u0012\u0004\u0012\u00020\u00050\tH§@¢\u0006\u0002\u0010\nJ\u001c\u0010\r\u001a\u00020\u00032\f\u0010\b\u001a\b\u0012\u0004\u0012\u00020\u00050\tH\u0097@¢\u0006\u0002\u0010\nJ\u0014\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u00050\tH§@¢\u0006\u0002\u0010\u000fJ\u0014\u0010\u0010\u001a\b\u0012\u0004\u0012\u00020\u00050\tH§@¢\u0006\u0002\u0010\u000fJ\u0014\u0010\u0011\u001a\b\u0012\u0004\u0012\u00020\u00050\tH§@¢\u0006\u0002\u0010\u000fJ\u0018\u0010\u0012\u001a\u0004\u0018\u00010\u00052\u0006\u0010\u0013\u001a\u00020\u0014H§@¢\u0006\u0002\u0010\u0015J\u0018\u0010\u0016\u001a\u0004\u0018\u00010\u00052\u0006\u0010\u0013\u001a\u00020\u0014H§@¢\u0006\u0002\u0010\u0015J\u0016\u0010\u0017\u001a\u00020\u00142\u0006\u0010\u0018\u001a\u00020\u0014H§@¢\u0006\u0002\u0010\u0015J\u0010\u0010\u0019\u001a\u0004\u0018\u00010\u0005H§@¢\u0006\u0002\u0010\u000fJ\u0016\u0010\u001a\u001a\u00020\u00032\u0006\u0010\u0013\u001a\u00020\u0014H\u0097@¢\u0006\u0002\u0010\u0015J\u000e\u0010\u001b\u001a\u00020\u0003H§@¢\u0006\u0002\u0010\u000fJ\u0016\u0010\u001c\u001a\u00020\u00032\u0006\u0010\u0013\u001a\u00020\u0014H§@¢\u0006\u0002\u0010\u0015J\u0016\u0010\u001d\u001a\u00020\u00032\u0006\u0010\u0013\u001a\u00020\u0014H§@¢\u0006\u0002\u0010\u0015J\u000e\u0010\u001e\u001a\u00020\u0003H§@¢\u0006\u0002\u0010\u000fJ\u000e\u0010\u001f\u001a\u00020\u0003H§@¢\u0006\u0002\u0010\u000f¨\u0006 "}, d2 = {"Lpe0212e54/pf0719ea8/p54785431;", "", "insertDevice", "", "device", "Lpe0212e54/pf5e638cc/pd77d5e50/p6285e3eb;", "(Lpe0212e54/pf5e638cc/pd77d5e50/p6285e3eb;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "insertDevices", "devices", "", "(Ljava/util/List;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateDevice", "updateDevices", "updateRemoteDevices", "getAllDevices", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getRemoteDevices", "getLocalDevices", "hasDevice", "deviceId", "", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getDevice", "getDeviceIdByUuid", "deviceUuid", "getSelectedDevice", "selectDevice", "unselectDevices", "selectCurrentDevice", "removeDevice", "removeRemoteDevices", "clearDevices", "feature-devices-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p54785431 {
    java.lang.object clearDevices(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object getAllDevices(kotlin.coroutines.Continuation<? super java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb>> continuation);

    java.lang.object getDevice(java.lang.string str, kotlin.coroutines.Continuation<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb> continuation);

    java.lang.object getDeviceIdByUuid(java.lang.string str, kotlin.coroutines.Continuation<java.lang.string> continuation);

    java.lang.object getLocalDevices(kotlin.coroutines.Continuation<? super java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb>> continuation);

    java.lang.object getRemoteDevices(kotlin.coroutines.Continuation<? super java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb>> continuation);

    java.lang.object getSelectedDevice(kotlin.coroutines.Continuation<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb> continuation);

    java.lang.object hasDevice(java.lang.string str, kotlin.coroutines.Continuation<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb> continuation);

    java.lang.object insertDevice(pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb p6285e3ebVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object insertDevices(java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object removeDevice(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object removeRemoteDevices(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object selectCurrentDevice(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object selectDevice(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object unselectDevices(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateDevice(pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb p6285e3ebVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateDevices(java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateRemoteDevices(java.util.List<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

