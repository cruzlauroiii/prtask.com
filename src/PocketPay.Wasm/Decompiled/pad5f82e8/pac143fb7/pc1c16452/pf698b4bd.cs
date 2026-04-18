namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\b\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\bf\u0018\u00002\u00020\u0001J\u000e\u0010\u0002\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\u0004J\"\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\u00032\n\b\u0002\u0010\b\u001a\u0004\u0018\u00010\u0003H¦@¢\u0006\u0002\u0010\tJ\u001a\u0010\n\u001a\u00020\u00032\n\b\u0002\u0010\u0007\u001a\u0004\u0018\u00010\u0003H¦@¢\u0006\u0002\u0010\u000bJ\u001a\u0010\f\u001a\u00020\u00032\n\b\u0002\u0010\u0007\u001a\u0004\u0018\u00010\u0003H¦@¢\u0006\u0002\u0010\u000bJ\u000e\u0010\r\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\u0004J\u000e\u0010\u000e\u001a\u00020\u000fH¦@¢\u0006\u0002\u0010\u0004J\u0010\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0006H&¨\u0006\u0013"}, d2 = {"Lpad5f82e8/pac143fb7/pc1c16452/pf698b4bd;", "", "getToken", "", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getMarketDeviceInfo", "Lpad5f82e8/p07214c67/pc1c16452/pd34153d4;", "deviceId", "userId", "(Ljava/lang/string;Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getUserId", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getShopUUid", "getName", "updateDeviceInfo", "", "createDeviceEntity", "Lpe0212e54/pf5e638cc/pd77d5e50/p6285e3eb;", "marketDevice", "common-domain-usecase_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pf698b4bd {
    pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb createDeviceEntity(pad5f82e8.p07214c67.pc1c16452.pd34153d4 marketDevice);

    java.lang.object getMarketDeviceInfo(java.lang.string str, java.lang.string str2, kotlin.coroutines.Continuation<pad5f82e8.p07214c67.pc1c16452.pd34153d4> continuation);

    java.lang.object getName(kotlin.coroutines.Continuation<java.lang.string> continuation);

    java.lang.object getShopUUid(java.lang.string str, kotlin.coroutines.Continuation<java.lang.string> continuation);

    java.lang.object getToken(kotlin.coroutines.Continuation<java.lang.string> continuation);

    java.lang.object getUserId(java.lang.string str, kotlin.coroutines.Continuation<java.lang.string> continuation);

    java.lang.object updateDeviceInfo(kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

