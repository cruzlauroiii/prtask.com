namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\bf\u0018\u0000 \r2\u00020\u0001:\u0001\rJ\u001e\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\b\b\u0001\u0010\u0005\u001a\u00020\u0006H§@¢\u0006\u0002\u0010\u0007J\u001e\u0010\b\u001a\b\u0012\u0004\u0012\u00020\t0\u00032\b\b\u0001\u0010\n\u001a\u00020\u000bH§@¢\u0006\u0002\u0010\f¨\u0006\u000e"}, d2 = {"Lp563873d3/p8a5da52e/pf81cd0a0;", "", "getRegisteredUser", "Lretrofit2/Response;", "Lp563873d3/p07214c67/p5fbece78/p0d373cb7;", "registeredUserBody", "Lp563873d3/p07214c67/pe0f65408;", "(Lp563873d3/p07214c67/pe0f65408;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "registerUser", "Lp563873d3/p07214c67/p50385d8c;", "registerBody", "Lp563873d3/p07214c67/p40ac9761;", "(Lp563873d3/p07214c67/p40ac9761;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "Companion", "feature-registration-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pf81cd0a0 {
    public static readonly p563873d3.p8a5da52e.pf81cd0a0$p910eef8c f910eef8c = p563873d3.p8a5da52e.pf81cd0a0$p910eef8c.$$INSTANCE;
    public static readonly p563873d3.p8a5da52e.pf81cd0a0$p910eef8c fd60079be = null;

    @paa20ed97.p80791b3a.pa02439ec("api/v3/market/user/check")
    java.lang.object getRegisteredUser(@paa20ed97.p80791b3a.pac101b32 p563873d3.p07214c67.pe0f65408 pe0f65408Var, kotlin.coroutines.Continuation<? super retrofit2.Response<p563873d3.p07214c67.p5fbece78.p0d373cb7>> continuation);

    @paa20ed97.p80791b3a.pa02439ec("api/v4/market/user/create")
    java.lang.object registerUser(@paa20ed97.p80791b3a.pac101b32 p563873d3.p07214c67.p40ac9761 p40ac9761Var, kotlin.coroutines.Continuation<? super retrofit2.Response<p563873d3.p07214c67.p50385d8c>> continuation);
}

