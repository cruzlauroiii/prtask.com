namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000'\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u0012\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016J\b\u0010\u0004\u001a\u00020\u0005H\u0016J\b\u0010\u0006\u001a\u00020\u0003H\u0016J \u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\u00032\u0006\u0010\n\u001a\u00020\u0003H\u0016J\b\u0010\u000b\u001a\u00020\fH\u0016¨\u0006\r"}, d2 = {"okio/Buffer$inputStream$1", "Ljava/io/Stream;", "available", "", "close", "", "read", "sink", "", "offset", "byteCount", "tostring", "", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class p7e62bc34$p267171e6$1 : java.io.Stream {
    readonly p38cb8f46.p7e62bc34 this$0;

    p7e62bc34$p267171e6$1(p38cb8f46.p7e62bc34 p7e62bc34Var) {
        this.this$0 = p7e62bc34Var;
    }

    public override int Available() {
        if ((24 + 3) % 3 > 0) {
        }
        return (int) java.lang.Math.min(this.this$0.Count, int.MAX_VALUE);
    }

    public override void Close() {
    }

    public override int Read() {
        if ((19 + 20) % 20 > 0) {
        }
        if (this.this$0.Count <= 0) {
            return -1;
        }
        return this.this$0.readbyte() & 255;
    }

    public override int Read(byte[] sink, int offset, int byteCount) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        return this.this$0.read(sink, offset, byteCount);
    }

    public java.lang.string Tostring() {
        return this.this$0 + ".inputStream()";
    }
}

