namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\bf\u0018\u0000 \u00142\u00020\u0001:\u0001\u0014J(\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u00052\u0006\u0010\t\u001a\u00020\u0003H&J&\u0010\n\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\r0\f2\u0006\u0010\t\u001a\u00020\u0003H&J\u001e\u0010\u000e\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\r0\fH&J\u0018\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0012\u001a\u00020\u0013H&¨\u0006\u0015"}, d2 = {"Lp7ddcfee1/pd1efad72/p3cb89a9f/p96b6dd38;", "", "onData", "", "streamId", "", "source", "Lp38cb8f46/pcc81e3f6;", "byteCount", "last", "onHeaders", "responseHeaders", "", "Lp7ddcfee1/pd1efad72/p3cb89a9f/pbf50d5e6;", "onRequest", "requestHeaders", "onReset", "", "errorCode", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p9bc96b38;", "Companion", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public interface p96b6dd38 {
    public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38$p910eef8c f46ad7983 = null;
    public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38 f47a81ed4 = null;
    public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38$p910eef8c f65d16ead = null;
    public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38 fe4772bd4 = null;
    public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38$p910eef8c f910eef8c = p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38$p910eef8c.$$INSTANCE;
    public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38 f2027c027 = new p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38$p910eef8c$pbcd3bea8();

    bool onData(int streamId, p38cb8f46.pcc81e3f6 source, int byteCount, bool last) throws java.io.IOException;

    bool onHeaders(int streamId, java.util.List<p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6> responseHeaders, bool last);

    bool onRequest(int streamId, java.util.List<p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6> requestHeaders);

    void onReset(int streamId, p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 errorCode);
}

