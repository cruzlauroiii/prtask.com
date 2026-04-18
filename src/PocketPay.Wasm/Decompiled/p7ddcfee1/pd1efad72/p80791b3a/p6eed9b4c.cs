namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000N\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\bf\u0018\u0000 \u001c2\u00020\u0001:\u0001\u001cJ\b\u0010\u0006\u001a\u00020\u0007H&J\u0018\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rH&J\b\u0010\u000e\u001a\u00020\u0007H&J\b\u0010\u000f\u001a\u00020\u0007H&J\u0010\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0013H&J\u0012\u0010\u0014\u001a\u0004\u0018\u00010\u00152\u0006\u0010\u0016\u001a\u00020\u0017H&J\u0010\u0010\u0018\u001a\u00020\r2\u0006\u0010\u0012\u001a\u00020\u0013H&J\b\u0010\u0019\u001a\u00020\u001aH&J\u0010\u0010\u001b\u001a\u00020\u00072\u0006\u0010\n\u001a\u00020\u000bH&R\u0012\u0010\u0002\u001a\u00020\u0003X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0005¨\u0006\u001d"}, d2 = {"Lp7ddcfee1/pd1efad72/p80791b3a/p6eed9b4c;", "", "connection", "Lp7ddcfee1/pd1efad72/p4717d53e/pc2c7dd60;", "getConnection", "()Lp7ddcfee1/pd1efad72/p4717d53e/pc2c7dd60;", "cancel", "", "createRequestBody", "Lp38cb8f46/p1eb558b5;", "request", "Lp7ddcfee1/p15c2d85f;", "contentLength", "", "finishRequest", "flushRequest", "openResponseBodySource", "Lp38cb8f46/pf31bbdd1;", "response", "Lp7ddcfee1/pd64ed3e9;", "readResponseHeaders", "Lp7ddcfee1/pd64ed3e9$p2bd4a59b;", "expectContinue", "", "reportedContentLength", "trailers", "Lp7ddcfee1/p883d7615;", "writeRequestHeaders", "Companion", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public interface p6eed9b4c {
    public static readonly int f0f217b88 = 100;
    public static readonly p7ddcfee1.pd1efad72.p80791b3a.p6eed9b4c$p910eef8c f1f6fa5dc = null;
    public static readonly int f2a093562 = 100;
    public static readonly int f2b389db0 = 100;
    public static readonly int f59d32f37 = 100;
    public static readonly p7ddcfee1.pd1efad72.p80791b3a.p6eed9b4c$p910eef8c f5ea4fb26 = null;
    public static readonly p7ddcfee1.pd1efad72.p80791b3a.p6eed9b4c$p910eef8c f7a3ab78f = null;
    public static readonly p7ddcfee1.pd1efad72.p80791b3a.p6eed9b4c$p910eef8c f910eef8c = p7ddcfee1.pd1efad72.p80791b3a.p6eed9b4c$p910eef8c.$$INSTANCE;
    public static readonly p7ddcfee1.pd1efad72.p80791b3a.p6eed9b4c$p910eef8c fb2f76c0d = null;
    public static readonly int fc337cd11 = 100;

    void cancel();

    p38cb8f46.p1eb558b5 createRequestBody(p7ddcfee1.p15c2d85f request, long contentLength) throws java.io.IOException;

    void finishRequest() throws java.io.IOException;

    void flushRequest() throws java.io.IOException;

    p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60 getConnection();

    p38cb8f46.pf31bbdd1 openResponseBodySource(p7ddcfee1.pd64ed3e9 response) throws java.io.IOException;

    p7ddcfee1.pd64ed3e9$p2bd4a59b readResponseHeaders(bool expectContinue) throws java.io.IOException;

    long reportedContentLength(p7ddcfee1.pd64ed3e9 response) throws java.io.IOException;

    p7ddcfee1.p883d7615 trailers() throws java.io.IOException;

    void writeRequestHeaders(p7ddcfee1.p15c2d85f request) throws java.io.IOException;
}

