namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\bf\u0018\u00002\u00020\u00012\u00020\u0002J\b\u0010\u0003\u001a\u00020\u0004H&J\b\u0010\u0005\u001a\u00020\u0004H&J\b\u0010\u0006\u001a\u00020\u0007H&J\u0018\u0010\b\u001a\u00020\u00042\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\fH&ø\u0001\u0000\u0082\u0002\u0006\n\u0004\b!0\u0001¨\u0006\rÀ\u0006\u0001"}, d2 = {"Lp38cb8f46/p1eb558b5;", "Ljava/io/IDisposable;", "Ljava/io/Flushable;", "close", "", "flush", "timeout", "Lp38cb8f46/pc85a251c;", "write", "source", "Lp38cb8f46/p7e62bc34;", "byteCount", "", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public interface p1eb558b5 : java.io.IDisposable, java.io.Flushable {
    void close() throws java.io.IOException;

    void flush() throws java.io.IOException;

    p38cb8f46.pc85a251c timeout();

    void write(p38cb8f46.p7e62bc34 source, long byteCount) throws java.io.IOException;
}

