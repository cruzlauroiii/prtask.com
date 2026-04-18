namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\b\u0007\bf\u0018\u0000 \u00112\u00020\u0001:\u0001\u0011J(\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\b\b\u0001\u0010\u0005\u001a\u00020\u00062\b\b\u0001\u0010\u0007\u001a\u00020\bH§@¢\u0006\u0002\u0010\tJ0\u0010\n\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00060\u000b0\u00032\b\b\u0001\u0010\u0007\u001a\u00020\b2\n\b\u0001\u0010\f\u001a\u0004\u0018\u00010\bH§@¢\u0006\u0002\u0010\rJ\u001e\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\b\b\u0001\u0010\u000f\u001a\u00020\bH§@¢\u0006\u0002\u0010\u0010¨\u0006\u0012"}, d2 = {"Lpe0bd4e89/pdd56421b/p8a5da52e/pc3f73b82;", "", "sendAdvanceReceipt", "Lretrofit2/Response;", "Lp7ddcfee1/p42c567ea;", "advanceReceipt", "Lpe0bd4e89/pdd56421b/p07214c67/p7894f0aa;", "userId", "", "(Lpe0bd4e89/pdd56421b/p07214c67/p7894f0aa;Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getAdvanceReceipt", "", "cashierUuid", "(Ljava/lang/string;Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "deleteAdvanceReceipt", "uuid", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "Companion", "feature-advance-receipts-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pc3f73b82 {
    public static readonly pe0bd4e89.pdd56421b.p8a5da52e.pc3f73b82$p910eef8c f6191db23 = null;
    public static readonly pe0bd4e89.pdd56421b.p8a5da52e.pc3f73b82$p910eef8c f910eef8c = pe0bd4e89.pdd56421b.p8a5da52e.pc3f73b82$p910eef8c.$$INSTANCE;
    public static readonly pe0bd4e89.pdd56421b.p8a5da52e.pc3f73b82$p910eef8c f9723055b = null;
    public static readonly pe0bd4e89.pdd56421b.p8a5da52e.pc3f73b82$p910eef8c fcb3754b4 = null;
    public static readonly pe0bd4e89.pdd56421b.p8a5da52e.pc3f73b82$p910eef8c fe02bb9cb = null;

    @paa20ed97.p80791b3a.p32f68a60("api/v2/asc/delete/{uuid}")
    java.lang.object deleteAdvanceReceipt(@paa20ed97.p80791b3a.pac70412e("uuid") java.lang.string str, kotlin.coroutines.Continuation<? super retrofit2.Response<p7ddcfee1.p42c567ea>> continuation);

    @paa20ed97.p80791b3a.p7528035a("api/v2/asc/get")
    java.lang.object getAdvanceReceipt(@paa20ed97.p80791b3a.p66c1b4c7("userId") java.lang.string str, @paa20ed97.p80791b3a.p66c1b4c7("cashierUuid") java.lang.string str2, kotlin.coroutines.Continuation<? super retrofit2.Response<java.util.List<pe0bd4e89.pdd56421b.p07214c67.p7894f0aa>>> continuation);

    @paa20ed97.p80791b3a.pa02439ec("api/v2/asc/create/{userId}")
    java.lang.object sendAdvanceReceipt(@paa20ed97.p80791b3a.pac101b32 pe0bd4e89.pdd56421b.p07214c67.p7894f0aa p7894f0aaVar, @paa20ed97.p80791b3a.pac70412e("userId") java.lang.string str, kotlin.coroutines.Continuation<? super retrofit2.Response<p7ddcfee1.p42c567ea>> continuation);
}

