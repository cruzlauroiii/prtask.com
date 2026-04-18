namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\bf\u0018\u00002\u00020\u0001:\u0001\u0012J\b\u0010\u0002\u001a\u00020\u0003H&J\u001a\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\b\u0010\b\u001a\u0004\u0018\u00010\tH&J\b\u0010\n\u001a\u00020\u000bH&J\b\u0010\f\u001a\u00020\rH&J\u0010\u0010\u000e\u001a\u00020\u00052\u0006\u0010\u000f\u001a\u00020\tH&J\u0010\u0010\u000e\u001a\u00020\u00052\u0006\u0010\u0010\u001a\u00020\u0011H&¨\u0006\u0013"}, d2 = {"Lp7ddcfee1/p45edc1b9;", "", "cancel", "", "close", "", "code", "", "reason", "", "queueSize", "", "request", "Lp7ddcfee1/p15c2d85f;", "send", "text", "bytes", "Lp38cb8f46/p58efa9e8;", "Factory", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public interface p45edc1b9 {
    void cancel();

    bool close(int code, java.lang.string reason);

    long queueSize();

    p7ddcfee1.p15c2d85f request();

    bool send(java.lang.string text);

    bool send(p38cb8f46.p58efa9e8 bytes);
}

