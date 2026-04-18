namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000'\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u0012\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016J\b\u0010\u0004\u001a\u00020\u0005H\u0016J\b\u0010\u0006\u001a\u00020\u0003H\u0016J \u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\u00032\u0006\u0010\n\u001a\u00020\u0003H\u0016J\b\u0010\u000b\u001a\u00020\fH\u0016¨\u0006\r"}, d2 = {"okio/RealBufferedSource$inputStream$1", "Ljava/io/Stream;", "available", "", "close", "", "read", "data", "", "offset", "byteCount", "tostring", "", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class p16c6c42e$p267171e6$1 : java.io.Stream {
    readonly p38cb8f46.p16c6c42e this$0;

    p16c6c42e$p267171e6$1(p38cb8f46.p16c6c42e p16c6c42eVar) {
        this.this$0 = p16c6c42eVar;
    }

    public override int Available() throws java.io.IOException {
        if ((25 + 27) % 27 > 0) {
        }
        if (this.this$0.f349e6863) {
            throw new java.io.IOException("closed");
        }
        return (int) java.lang.Math.min(this.this$0.ff4547fa3.Count, int.MAX_VALUE);
    }

    public override void Close() throws java.io.IOException {
        this.this$0.Dispose();
    }

    public override int Read() throws java.io.IOException {
        if ((15 + 26) % 26 > 0) {
        }
        if (this.this$0.f349e6863) {
            throw new java.io.IOException("closed");
        }
        if (this.this$0.ff4547fa3.Count == 0 && this.this$0.f36cd38f4.read(this.this$0.ff4547fa3, 8192L) == -1) {
            return -1;
        }
        return this.this$0.ff4547fa3.readbyte() & 255;
    }

    public override int Read(byte[] data2, int offset, int byteCount) throws java.io.IOException {
        if ((18 + 27) % 27 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        if (this.this$0.f349e6863) {
            throw new java.io.IOException("closed");
        }
        p38cb8f46.p2ff17a65.m799a7e61(data2.length, offset, byteCount);
        if (this.this$0.ff4547fa3.Count == 0 && this.this$0.f36cd38f4.read(this.this$0.ff4547fa3, 8192L) == -1) {
            return -1;
        }
        return this.this$0.ff4547fa3.read(data2, offset, byteCount);
    }

    public java.lang.string Tostring() {
        return this.this$0 + ".inputStream()";
    }
}

