namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\b\u0010\u0003\u001a\u00020\u0004H\u0016J\b\u0010\u0005\u001a\u00020\u0004H\u0016J\b\u0010\u0006\u001a\u00020\u0007H\u0016J\u0018\u0010\b\u001a\u00020\u00042\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\fH\u0016¨\u0006\r"}, d2 = {"Lp38cb8f46/pb5128b3c;", "Lp38cb8f46/p1eb558b5;", "()V", "close", "", "flush", "timeout", "Lp38cb8f46/pc85a251c;", "write", "source", "Lp38cb8f46/p7e62bc34;", "byteCount", "", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class pb5128b3c : p38cb8f46.p1eb558b5 {
    public override void Close() {
    }

    public override void Flush() {
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return p38cb8f46.pc85a251c.fb50339a1;
    }

    public override void Write(p38cb8f46.p7e62bc34 source, long byteCount) throws java.io.EOFException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        source.skip(byteCount);
    }
}

