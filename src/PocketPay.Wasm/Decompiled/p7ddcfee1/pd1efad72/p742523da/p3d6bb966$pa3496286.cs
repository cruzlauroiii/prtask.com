namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0004\bf\u0018\u00002\u00020\u0001J\u0018\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H&J\u0010\u0010\b\u001a\u00020\u00032\u0006\u0010\t\u001a\u00020\u0007H&J\u0010\u0010\b\u001a\u00020\u00032\u0006\u0010\n\u001a\u00020\u000bH&J\u0010\u0010\f\u001a\u00020\u00032\u0006\u0010\r\u001a\u00020\u000bH&J\u0010\u0010\u000e\u001a\u00020\u00032\u0006\u0010\r\u001a\u00020\u000bH&¨\u0006\u000f"}, d2 = {"Lp7ddcfee1/pd1efad72/p742523da/p3d6bb966$pa3496286;", "", "onReadClose", "", "code", "", "reason", "", "onReadMessage", "text", "bytes", "Lp38cb8f46/p58efa9e8;", "onReadPing", "payload", "onReadPong", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public interface p3d6bb966$pa3496286 {
    void onReadClose(int code, java.lang.string reason);

    void onReadMessage(java.lang.string text) throws java.io.IOException;

    void onReadMessage(p38cb8f46.p58efa9e8 bytes) throws java.io.IOException;

    void onReadPing(p38cb8f46.p58efa9e8 payload);

    void onReadPong(p38cb8f46.p58efa9e8 payload);
}

