namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0004\bf\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H&J\b\u0010\u0004\u001a\u00020\u0005H&J\n\u0010\u0006\u001a\u0004\u0018\u00010\u0007H&J\u0010\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH&J\b\u0010\f\u001a\u00020\u0005H&J\b\u0010\n\u001a\u00020\u000bH&J\u0018\u0010\r\u001a\u00020\u00002\u0006\u0010\u000e\u001a\u00020\u00052\u0006\u0010\u000f\u001a\u00020\u0010H&J\u0018\u0010\u0011\u001a\u00020\u00002\u0006\u0010\u000e\u001a\u00020\u00052\u0006\u0010\u000f\u001a\u00020\u0010H&J\u0018\u0010\u0012\u001a\u00020\u00002\u0006\u0010\u000e\u001a\u00020\u00052\u0006\u0010\u000f\u001a\u00020\u0010H&J\b\u0010\u0013\u001a\u00020\u0005H&¨\u0006\u0014"}, d2 = {"Lp7ddcfee1/p06050a91$p53205501;", "", "call", "Lp7ddcfee1/pc3755e61;", "connectTimeoutMillis", "", "connection", "Lp7ddcfee1/pc2cc7082;", "proceed", "Lp7ddcfee1/pd64ed3e9;", "request", "Lp7ddcfee1/p15c2d85f;", "readTimeoutMillis", "withConnectTimeout", "timeout", "unit", "Ljava/util/concurrent/TimeUnit;", "withReadTimeout", "withWriteTimeout", "writeTimeoutMillis", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public interface p06050a91$p53205501 {
    p7ddcfee1.pc3755e61 call();

    int connectTimeoutMillis();

    p7ddcfee1.pc2cc7082 connection();

    p7ddcfee1.pd64ed3e9 proceed(p7ddcfee1.p15c2d85f request) throws java.io.IOException;

    int readTimeoutMillis();

    p7ddcfee1.p15c2d85f request();

    p7ddcfee1.p06050a91$p53205501 withConnectTimeout(int timeout, java.util.concurrent.TimeUnit unit);

    p7ddcfee1.p06050a91$p53205501 withReadTimeout(int timeout, java.util.concurrent.TimeUnit unit);

    p7ddcfee1.p06050a91$p53205501 withWriteTimeout(int timeout, java.util.concurrent.TimeUnit unit);

    int writeTimeoutMillis();
}

