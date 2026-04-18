namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\bf\u0018\u0000 \u000f2\u00020\u0001:\u0001\u000fJ\u0018\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\b\b\u0001\u0010\u0005\u001a\u00020\u0006H'J\"\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\b0\u00032\b\b\u0001\u0010\t\u001a\u00020\b2\b\b\u0001\u0010\n\u001a\u00020\u000bH'J\"\u0010\f\u001a\b\u0012\u0004\u0012\u00020\r0\u00032\b\b\u0001\u0010\t\u001a\u00020\b2\b\b\u0001\u0010\u0005\u001a\u00020\u000eH'¨\u0006\u0010"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/pa48cb05a/p024a6f84;", "", "createPINSession", "Lio/reactivex/rxjava3/core/Single;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/pa48cb05a/p07214c67/p7808c8a3;", "request", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/pa48cb05a/p07214c67/p8edba42d;", "getKey", "", "trxRef", "getKeyBody", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/pa48cb05a/p07214c67/p4879f6c0;", "completePINSession", "Lp7ddcfee1/p42c567ea;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/pa48cb05a/p07214c67/pb29faa68;", "Companion", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p024a6f84 {
    public static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pa48cb05a.p024a6f84$p910eef8c f2ac523e3 = null;
    public static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pa48cb05a.p024a6f84$p910eef8c f910eef8c = p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pa48cb05a.p024a6f84$p910eef8c.$$INSTANCE;
    public static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pa48cb05a.p024a6f84$p910eef8c fa19f621f = null;

    @kotlin.jvm.JvmStatic
    static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pa48cb05a.p024a6f84 M8bab0102(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pa48cb05a.p0e591676.p3f178564 p3f178564Var) {
        return f910eef8c.getInstance(p3f178564Var);
    }

    @p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p8a5da52e.p2e989f80(apiType = p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p407482fe.p8a5da52e.p62c91bb3.PIN)
    @p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p8a5da52e.p795e75b4(checksType = p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p407482fe.pe91e6348.p9e5254cf.RUNTIME)
    @p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p8a5da52e.pdd6eb221(keyType = p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p407482fe.p8a5da52e.p82fb9ae9.ATT_KEY)
    @paa20ed97.p80791b3a.pa02439ec("/sessions/{trxRef}/complete")
    io.reactivex.rxjava3.core.Single<p7ddcfee1.p42c567ea> completePINSession(@paa20ed97.p80791b3a.pac70412e("trxRef") java.lang.string trxRef, @paa20ed97.p80791b3a.pac101b32 p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pa48cb05a.p07214c67.pb29faa68 request);

    @p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p8a5da52e.p2e989f80(apiType = p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p407482fe.p8a5da52e.p62c91bb3.PIN)
    @p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p8a5da52e.p795e75b4(checksType = p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p407482fe.pe91e6348.p9e5254cf.RUNTIME)
    @p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p8a5da52e.pdd6eb221(keyType = p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p407482fe.p8a5da52e.p82fb9ae9.ATT_KEY)
    @paa20ed97.p80791b3a.pa02439ec("/sessions")
    io.reactivex.rxjava3.core.Single<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pa48cb05a.p07214c67.p7808c8a3> createPINSession(@paa20ed97.p80791b3a.pac101b32 p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pa48cb05a.p07214c67.p8edba42d request);

    @p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p8a5da52e.p2e989f80(apiType = p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p407482fe.p8a5da52e.p62c91bb3.PIN)
    @p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p8a5da52e.p795e75b4(checksType = p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p407482fe.pe91e6348.p9e5254cf.RUNTIME)
    @p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p8a5da52e.pdd6eb221(keyType = p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p407482fe.p8a5da52e.p82fb9ae9.PIN_KEY)
    @paa20ed97.p80791b3a.pa02439ec("/sessions/{trxRef}/zpk")
    io.reactivex.rxjava3.core.Single<java.lang.string> getKey(@paa20ed97.p80791b3a.pac70412e("trxRef") java.lang.string trxRef, @paa20ed97.p80791b3a.pac101b32 p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pa48cb05a.p07214c67.p4879f6c0 getKeyBody);
}

