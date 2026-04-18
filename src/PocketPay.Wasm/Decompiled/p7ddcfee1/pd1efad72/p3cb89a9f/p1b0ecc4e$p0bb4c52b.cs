namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000X\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u000e\n\u0002\u0018\u0002\n\u0002\b\u0003\bf\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H&J8\u0010\u0004\u001a\u00020\u00032\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\b2\u0006\u0010\f\u001a\u00020\u00062\u0006\u0010\r\u001a\u00020\u000eH&J(\u0010\u000f\u001a\u00020\u00032\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00020\u0006H&J \u0010\u0015\u001a\u00020\u00032\u0006\u0010\u0016\u001a\u00020\u00062\u0006\u0010\u0017\u001a\u00020\u00182\u0006\u0010\u0019\u001a\u00020\nH&J.\u0010\u001a\u001a\u00020\u00032\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u001b\u001a\u00020\u00062\f\u0010\u001c\u001a\b\u0012\u0004\u0012\u00020\u001e0\u001dH&J \u0010\u001f\u001a\u00020\u00032\u0006\u0010 \u001a\u00020\u00112\u0006\u0010!\u001a\u00020\u00062\u0006\u0010\"\u001a\u00020\u0006H&J(\u0010#\u001a\u00020\u00032\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010$\u001a\u00020\u00062\u0006\u0010%\u001a\u00020\u00062\u0006\u0010&\u001a\u00020\u0011H&J&\u0010'\u001a\u00020\u00032\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010(\u001a\u00020\u00062\f\u0010)\u001a\b\u0012\u0004\u0012\u00020\u001e0\u001dH&J\u0018\u0010*\u001a\u00020\u00032\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0017\u001a\u00020\u0018H&J\u0018\u0010+\u001a\u00020\u00032\u0006\u0010,\u001a\u00020\u00112\u0006\u0010+\u001a\u00020-H&J\u0018\u0010.\u001a\u00020\u00032\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010/\u001a\u00020\u000eH&¨\u00060"}, d2 = {"Lp7ddcfee1/pd1efad72/p3cb89a9f/p1b0ecc4e$p0bb4c52b;", "", "ackHashSettings", "", "alternateService", "streamId", "", "origin", "", "protocol", "Lp38cb8f46/p58efa9e8;", "host", "port", "maxAge", "", "data", "inFinished", "", "source", "Lp38cb8f46/pcc81e3f6;", "length", "goAway", "lastGoodStreamId", "errorCode", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p9bc96b38;", "debugData", "headers", "associatedStreamId", "headerBlock", "", "Lp7ddcfee1/pd1efad72/p3cb89a9f/pbf50d5e6;", "ping", "ack", "payload1", "payload2", "priority", "streamDependency", "weight", "exclusive", "pushPromise", "promisedStreamId", "requestHeaders", "rstStream", "settings", "clearPrevious", "Lp7ddcfee1/pd1efad72/p3cb89a9f/pf4f70727;", "windowUpdate", "windowSizeIncrement", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public interface p1b0ecc4e$p0bb4c52b {
    void ackHashSettings();

    void alternateService(int streamId, java.lang.string origin, p38cb8f46.p58efa9e8 protocol, java.lang.string host, int port, long maxAge);

    void data(bool inFinished, int streamId, p38cb8f46.pcc81e3f6 source, int length) throws java.io.IOException;

    void goAway(int lastGoodStreamId, p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 errorCode, p38cb8f46.p58efa9e8 debugData);

    void headers(bool inFinished, int streamId, int associatedStreamId, java.util.List<p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6> headerBlock);

    void ping(bool ack, int payload1, int payload2);

    void priority(int streamId, int streamDependency, int weight, bool exclusive);

    void pushPromise(int streamId, int promisedStreamId, java.util.List<p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6> requestHeaders) throws java.io.IOException;

    void rstStream(int streamId, p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 errorCode);

    void settings(bool clearPrevious, p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 settings);

    void windowUpdate(int streamId, long windowSizeIncrement);
}

