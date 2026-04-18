namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000)\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u0012\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016J\b\u0010\u0004\u001a\u00020\u0003H\u0016J\b\u0010\u0005\u001a\u00020\u0006H\u0016J \u0010\u0007\u001a\u00020\u00032\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\u000bH\u0016J\u0010\u0010\u0007\u001a\u00020\u00032\u0006\u0010\r\u001a\u00020\u000bH\u0016¨\u0006\u000e"}, d2 = {"okio/RealBufferedSink$outputStream$1", "Ljava/io/Stream;", "close", "", "flush", "tostring", "", "write", "data", "", "offset", "", "byteCount", "b", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class pd84c6f13$pbe2deec2$1 : java.io.Stream {
    readonly p38cb8f46.pd84c6f13 this$0;

    pd84c6f13$pbe2deec2$1(p38cb8f46.pd84c6f13 pd84c6f13Var) {
        this.this$0 = pd84c6f13Var;
    }

    public override void Close() throws java.lang.Exception {
        this.this$0.Dispose();
    }

    public override void Flush() throws java.io.IOException {
        if (this.this$0.f349e6863) {
            return;
        }
        this.this$0.flush();
    }

    public java.lang.string Tostring() {
        return this.this$0 + ".outputStream()";
    }

    public override void Write(int b) throws java.io.IOException {
        if (this.this$0.f349e6863) {
            throw new java.io.IOException("closed");
        }
        this.this$0.ff4547fa3.writebyte((int) ((byte) b));
        this.this$0.emitCompleteSegments();
    }

    public override void Write(byte[] data2, int offset, int byteCount) throws java.io.IOException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        if (this.this$0.f349e6863) {
            throw new java.io.IOException("closed");
        }
        this.this$0.ff4547fa3.write(data2, offset, byteCount);
        this.this$0.emitCompleteSegments();
    }
}

