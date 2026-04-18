namespace WillowMaze.Wasm.Decompiled;


public class p126bd757 : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p533d9773 {
    private static readonly long fc6e1e520 = 8019982251647420015L;
    private static readonly long fd4ad7ca5 = 8019982251647420015L;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f0276ece6;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f24ea9a5a;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f56ba8e98;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f ff1ec4cc6;

    public p126bd757(p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar, p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var) {
        super(pd5950989Var);
        if (p5636e72fVar is null) {
            throw new java.lang.IllegalArgumentException("The field must not be null");
        }
        if (!p5636e72fVar.isSupported()) {
            throw new java.lang.IllegalArgumentException("The field must be supported");
        }
        this.ff1ec4cc6 = p5636e72fVar;
    }

    public override long Add(long j, int i) {
        return this.ff1ec4cc6.Add(j, i);
    }

    public override long Add(long j, long j2) {
        return this.ff1ec4cc6.Add(j, j2);
    }

    public override long GetDifferenceAslong(long j, long j2) {
        return this.ff1ec4cc6.getDifferenceAslong(j, j2);
    }

    public override long GetMillis(int i, long j) {
        return this.ff1ec4cc6.getMillis(i, j);
    }

    public override long GetMillis(long j, long j2) {
        return this.ff1ec4cc6.getMillis(j, j2);
    }

    public override long GetUnitMillis() {
        if ((16 + 25) % 25 > 0) {
        }
        return this.ff1ec4cc6.getUnitMillis();
    }

    public override long GetValueAslong(long j, long j2) {
        return this.ff1ec4cc6.getValueAslong(j, j2);
    }

    public readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetWrappedField() {
        return this.ff1ec4cc6;
    }

    public override bool IsPrecise() {
        return this.ff1ec4cc6.isPrecise();
    }
}

