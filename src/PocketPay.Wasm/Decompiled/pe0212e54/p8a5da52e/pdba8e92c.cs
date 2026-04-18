namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010!\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\bf\u0018\u0000 \r2\u00020\u0001:\u0001\rJ.\u0010\u0002\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00050\u00040\u00032\b\b\u0001\u0010\u0006\u001a\u00020\u00072\b\b\u0001\u0010\b\u001a\u00020\u0007H§@¢\u0006\u0002\u0010\tJ$\u0010\n\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000b0\u00040\u00032\b\b\u0001\u0010\u0006\u001a\u00020\u0007H§@¢\u0006\u0002\u0010\f¨\u0006\u000e"}, d2 = {"Lpe0212e54/p8a5da52e/pdba8e92c;", "", "getStores", "Lretrofit2/Response;", "", "Lpe0212e54/pf5e638cc/pcf1e8c14/p170c9f21;", "userId", "", "userRole", "(Ljava/lang/string;Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getDevices", "Lpe0212e54/pf5e638cc/pcf1e8c14/p13fc8880;", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "Companion", "feature-devices-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pdba8e92c {
    public static readonly pe0212e54.p8a5da52e.pdba8e92c$p910eef8c f4bea81d4 = null;
    public static readonly pe0212e54.p8a5da52e.pdba8e92c$p910eef8c f6e7d8a48 = null;
    public static readonly pe0212e54.p8a5da52e.pdba8e92c$p910eef8c f910eef8c = pe0212e54.p8a5da52e.pdba8e92c$p910eef8c.$$INSTANCE;

    @paa20ed97.p80791b3a.p7528035a("api/v2/market/user/{userId}/devices")
    java.lang.object getDevices(@paa20ed97.p80791b3a.pac70412e("userId") java.lang.string str, kotlin.coroutines.Continuation<? super retrofit2.Response<java.util.List<pe0212e54.pf5e638cc.pcf1e8c14.p13fc8880>>> continuation);

    @paa20ed97.p80791b3a.p7528035a("api/v2/market/user/{userId}/stores")
    java.lang.object getStores(@paa20ed97.p80791b3a.pac70412e("userId") java.lang.string str, @paa20ed97.p80791b3a.p66c1b4c7("userRole") java.lang.string str2, kotlin.coroutines.Continuation<? super retrofit2.Response<java.util.List<pe0212e54.pf5e638cc.pcf1e8c14.p170c9f21>>> continuation);
}

