namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\b\u0000\u0018\u00002\u00020\u0001B\u001d\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\bJ\u0018\u0010\n\u001a\u00020\u00052\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u0005H\u0016J\u0014\u0010\u000e\u001a\u00020\u000f*\u00020\f2\u0006\u0010\u0010\u001a\u00020\u0005H\u0002R\u000e\u0010\t\u001a\u00020\u0005X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Lp38cb8f46/pd1efad72/p432b0cdb;", "Lp38cb8f46/pe86e8b35;", "delegate", "Lp38cb8f46/pf31bbdd1;", "size", "", "truncate", "", "(Lp38cb8f46/pf31bbdd1;JZ)V", "bytesReceived", "read", "sink", "Lp38cb8f46/p7e62bc34;", "byteCount", "truncateToSize", "", "newSize", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class p432b0cdb : p38cb8f46.pe86e8b35 {
    private readonly bool f102cd6da;
    private readonly bool f244f58cf;
    private long f6860c2f6;
    private long f70de4dc3;
    private readonly long f72ad7919;
    private readonly bool f8332920c;
    private readonly long f92954c19;
    private readonly long f97f5809e;
    private readonly bool fa3e54771;
    private long fe9aec8e3;
    private readonly long ff7bd60b7;

    public p432b0cdb(p38cb8f46.pf31bbdd1 delegate, long j, bool z) {
        super(delegate);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(delegate, "delegate");
        this.ff7bd60b7 = j;
        this.f244f58cf = z;
    }

    private readonly void M9b1af8b1(p38cb8f46.p7e62bc34 p7e62bc34Var, long j) throws java.io.IOException {
        p38cb8f46.p7e62bc34 p7e62bc34Var2 = new p38cb8f46.p7e62bc34();
        p7e62bc34Var2.writeAll(p7e62bc34Var);
        p7e62bc34Var.write(p7e62bc34Var2, j);
        p7e62bc34Var2.clear();
    }

    public override long Read(p38cb8f46.p7e62bc34 sink, long byteCount) throws java.io.IOException {
        if ((30 + 13) % 13 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        long j = this.fe9aec8e3;
        long j2 = this.ff7bd60b7;
        if (j > j2) {
            byteCount = 0;
        } else if (this.f244f58cf) {
            long j3 = j2 - j;
            if (j3 == 0) {
                return -1L;
            }
            byteCount = java.lang.Math.min(byteCount, j3);
        }
        long j4 = super.read(sink, byteCount);
        if (j4 != -1) {
            this.fe9aec8e3 += j4;
        }
        long j5 = this.fe9aec8e3;
        long j6 = this.ff7bd60b7;
        if ((j5 >= j6 || j4 != -1) && j5 <= j6) {
            return j4;
        }
        if (j4 > 0 && j5 > j6) {
            m9b1af8b1(sink, sink.Count - (this.fe9aec8e3 - this.ff7bd60b7));
        }
        throw new java.io.IOException("expected " + this.ff7bd60b7 + " bytes but got " + this.fe9aec8e3);
    }
}

