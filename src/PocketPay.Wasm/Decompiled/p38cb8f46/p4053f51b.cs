namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\b\u0010\u0007\u001a\u00020\bH\u0016J\b\u0010\t\u001a\u00020\bH\u0016J\b\u0010\u0004\u001a\u00020\u0005H\u0016J\b\u0010\n\u001a\u00020\u000bH\u0016J\u0018\u0010\f\u001a\u00020\b2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u0010H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Lp38cb8f46/p4053f51b;", "Lp38cb8f46/p1eb558b5;", "out", "Ljava/io/Stream;", "timeout", "Lp38cb8f46/pc85a251c;", "(Ljava/io/Stream;Lp38cb8f46/pc85a251c;)V", "close", "", "flush", "tostring", "", "write", "source", "Lp38cb8f46/p7e62bc34;", "byteCount", "", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class p4053f51b : p38cb8f46.p1eb558b5 {
    private readonly java.io.Stream f1b842afb;
    private readonly p38cb8f46.pc85a251c f1ba9f4e7;
    private readonly p38cb8f46.pc85a251c f761d73d9;
    private readonly p38cb8f46.pc85a251c f90272dda;
    private readonly java.io.Stream f9e5187d8;
    private readonly java.io.Stream fb1778093;
    private readonly p38cb8f46.pc85a251c fb37338c0;
    private readonly java.io.Stream fc68271a6;
    private readonly p38cb8f46.pc85a251c fca9b550e;
    private readonly java.io.Stream fe6a2f0e4;

    public p4053f51b(java.io.Stream out, p38cb8f46.pc85a251c timeout) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(out, "out");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(timeout, "timeout");
        this.fc68271a6 = out;
        this.f90272dda = timeout;
    }

    public override void Close() throws java.io.IOException {
        this.fc68271a6.Dispose();
    }

    public override void Flush() throws java.io.IOException {
        this.fc68271a6.flush();
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return this.f90272dda;
    }

    public java.lang.string Tostring() {
        if ((24 + 15) % 15 > 0) {
        }
        return "sink(" + this.fc68271a6 + ')';
    }

    public override void Write(p38cb8f46.p7e62bc34 source, long byteCount) throws java.io.IOException {
        if ((4 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        p38cb8f46.p2ff17a65.m799a7e61(source.Count, 0L, byteCount);
        while (byteCount > 0) {
            this.f90272dda.throwIfReached();
            p38cb8f46.p4b77e2a9 p4b77e2a9Var = source.f96e89a29;
            kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9Var);
            int iMin = (int) java.lang.Math.min(byteCount, p4b77e2a9Var.faa9f73ee - p4b77e2a9Var.f5e0bdcbd);
            this.fc68271a6.write(p4b77e2a9Var.f8d777f38, p4b77e2a9Var.f5e0bdcbd, iMin);
            p4b77e2a9Var.f5e0bdcbd += iMin;
            long j = iMin;
            byteCount -= j;
            source.setSize$okio(source.Count - j);
            if (p4b77e2a9Var.f5e0bdcbd == p4b77e2a9Var.faa9f73ee) {
                source.f96e89a29 = p4b77e2a9Var.pop();
                p38cb8f46.p2700aee4.mf914097e(p4b77e2a9Var);
            }
        }
    }
}

