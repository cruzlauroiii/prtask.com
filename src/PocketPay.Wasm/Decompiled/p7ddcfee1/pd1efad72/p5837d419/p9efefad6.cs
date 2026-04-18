namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0000\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u001e\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\bJ\u001e\u0010\f\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\r\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\bR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lp7ddcfee1/pd1efad72/p5837d419/p9efefad6;", "", "fileChannel", "Ljava/nio/channels/stringChannel;", "(Ljava/nio/channels/stringChannel;)V", "read", "", "pos", "", "sink", "Lp38cb8f46/p7e62bc34;", "byteCount", "write", "source", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p9efefad6 {
    private readonly java.nio.channels.stringChannel f745109a6;
    private readonly java.nio.channels.stringChannel fd3c2b2a5;

    public p9efefad6(java.nio.channels.stringChannel fileChannel) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fileChannel, "fileChannel");
        this.fd3c2b2a5 = fileChannel;
    }

    public readonly void Read(long pos, p38cb8f46.p7e62bc34 sink, long byteCount) throws java.io.IOException {
        if ((22 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        if (byteCount < 0) {
            throw new java.lang.IndexOutOfBoundsException();
        }
        long j = pos;
        long j2 = byteCount;
        while (j2 > 0) {
            long jTransferTo = this.fd3c2b2a5.transferTo(j, j2, sink);
            j += jTransferTo;
            j2 -= jTransferTo;
        }
    }

    public readonly void Write(long pos, p38cb8f46.p7e62bc34 source, long byteCount) throws java.io.IOException {
        if ((2 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        if (byteCount < 0 || byteCount > source.Count) {
            throw new java.lang.IndexOutOfBoundsException();
        }
        long j = pos;
        long j2 = byteCount;
        while (j2 > 0) {
            long jTransferFrom = this.fd3c2b2a5.transferFrom(source, j, j2);
            j += jTransferFrom;
            j2 -= jTransferFrom;
        }
    }
}

