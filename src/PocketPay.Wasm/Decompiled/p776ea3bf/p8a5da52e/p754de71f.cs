namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010!\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\bf\u0018\u0000 \u000f2\u00020\u0001:\u0001\u000fJ$\u0010\u0002\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00050\u00040\u00032\b\b\u0001\u0010\u0006\u001a\u00020\u0007H§@¢\u0006\u0002\u0010\bJ(\u0010\t\u001a\b\u0012\u0004\u0012\u00020\n0\u00032\b\b\u0001\u0010\u000b\u001a\u00020\u00072\b\b\u0001\u0010\f\u001a\u00020\rH§@¢\u0006\u0002\u0010\u000e¨\u0006\u0010"}, d2 = {"Lp776ea3bf/p8a5da52e/p754de71f;", "", "getDevices", "Lretrofit2/Response;", "", "Lpe0212e54/pf5e638cc/pcf1e8c14/p13fc8880;", "userId", "", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "checkRegisteredUser", "Lp7ddcfee1/p42c567ea;", "phone", "credentials", "Lp776ea3bf/p07214c67/p1760019c;", "(Ljava/lang/string;Lp776ea3bf/p07214c67/p1760019c;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "Companion", "integration-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p754de71f {
    public static readonly p776ea3bf.p8a5da52e.p754de71f$p910eef8c f3b5f3349 = null;
    public static readonly p776ea3bf.p8a5da52e.p754de71f$p910eef8c f910eef8c = p776ea3bf.p8a5da52e.p754de71f$p910eef8c.$$INSTANCE;
    public static readonly p776ea3bf.p8a5da52e.p754de71f$p910eef8c f9d88bf16 = null;
    public static readonly p776ea3bf.p8a5da52e.p754de71f$p910eef8c fb8b90b58 = null;

    @paa20ed97.p80791b3a.pa02439ec("api/v1/check/app")
    java.lang.object checkRegisteredUser(@paa20ed97.p80791b3a.p66c1b4c7("phone") java.lang.string str, @paa20ed97.p80791b3a.pac101b32 p776ea3bf.p07214c67.p1760019c p1760019cVar, kotlin.coroutines.Continuation<? super retrofit2.Response<p7ddcfee1.p42c567ea>> continuation);

    @paa20ed97.p80791b3a.p7528035a("api/v2/market/user/{userId}/devices")
    java.lang.object getDevices(@paa20ed97.p80791b3a.pac70412e("userId") java.lang.string str, kotlin.coroutines.Continuation<? super retrofit2.Response<java.util.List<pe0212e54.pf5e638cc.pcf1e8c14.p13fc8880>>> continuation);
}

