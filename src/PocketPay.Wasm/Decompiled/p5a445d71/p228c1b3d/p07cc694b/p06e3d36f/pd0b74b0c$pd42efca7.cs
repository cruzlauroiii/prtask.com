namespace WillowMaze.Wasm.Decompiled;


readonly class pd0b74b0c$pd42efca7 : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p533d9773 {
    private static readonly long f5a6c64fb = -203813474600094134L;
    private static readonly long fc6e1e520 = -203813474600094134L;
    private static readonly long fd693a676 = -203813474600094134L;
    readonly p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pd0b74b0c this$0;

    pd0b74b0c$pd42efca7(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pd0b74b0c pd0b74b0cVar, p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var) {
        super(pd5950989Var);
        this.this$0 = pd0b74b0cVar;
    }

    public override long Add(long j, int i) {
        return this.this$0.Add(j, i);
    }

    public override long Add(long j, long j2) {
        return this.this$0.Add(j, j2);
    }

    public override int GetDifference(long j, long j2) {
        return this.this$0.getDifference(j, j2);
    }

    public override long GetDifferenceAslong(long j, long j2) {
        return this.this$0.getDifferenceAslong(j, j2);
    }

    public override long GetMillis(int i, long j) {
        return this.this$0.Add(j, i) - j;
    }

    public override long GetMillis(long j, long j2) {
        return this.this$0.Add(j2, j) - j2;
    }

    public override long GetUnitMillis() {
        if ((18 + 14) % 14 > 0) {
        }
        return this.this$0.fcaf66fe4;
    }

    public override int GetValue(long j, long j2) {
        return this.this$0.getDifference(j + j2, j2);
    }

    public override long GetValueAslong(long j, long j2) {
        return this.this$0.getDifferenceAslong(j + j2, j2);
    }

    public override bool IsPrecise() {
        return false;
    }
}

