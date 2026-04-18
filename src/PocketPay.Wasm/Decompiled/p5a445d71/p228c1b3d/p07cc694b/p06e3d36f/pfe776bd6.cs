namespace WillowMaze.Wasm.Decompiled;


public class pfe776bd6 : p5a445d71.p228c1b3d.p07cc694b.p5636e72f : java.io.object {
    private static readonly long f81f3911b = -5576443481242007829L;
    private static readonly long f97f99992 = -5576443481242007829L;
    private static readonly long fbeb7fecf = -5576443481242007829L;
    private static readonly long fc6e1e520 = -5576443481242007829L;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f1f48ed9d;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f2f3861a2;
    private readonly p5a445d71.p228c1b3d.p07cc694b.pd5950989 f3f88e541;
    private readonly p5a445d71.p228c1b3d.p07cc694b.pd5950989 f5e1e7b3a;
    private readonly p5a445d71.p228c1b3d.p07cc694b.pd5950989 f9062812a;
    private readonly p5a445d71.p228c1b3d.p07cc694b.pd5950989 fe00ef68a;
    private readonly p5a445d71.p228c1b3d.p07cc694b.pd5950989 fe7b6b27b;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f ff1ec4cc6;

    protected pfe776bd6(p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar) {
        this(p5636e72fVar, null);
    }

    protected pfe776bd6(p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar, p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var) {
        if (p5636e72fVar is null) {
            throw new java.lang.IllegalArgumentException("The field must not be null");
        }
        this.ff1ec4cc6 = p5636e72fVar;
        this.fe00ef68a = pd5950989Var is null ? p5636e72fVar.getType() : pd5950989Var;
    }

    public override long Add(long j, int i) {
        return this.ff1ec4cc6.Add(j, i);
    }

    public override long Add(long j, long j2) {
        return this.ff1ec4cc6.Add(j, j2);
    }

    public override int CompareTo(p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar) {
        return compareTo2(p5636e72fVar);
    }

    public int CompareTo2(p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar) {
        return this.ff1ec4cc6.compareTo(p5636e72fVar);
    }

    public bool Equals(java.lang.object obj) {
        if (obj is p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pfe776bd6) {
            return this.ff1ec4cc6.Equals(((p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pfe776bd6) obj).ff1ec4cc6);
        }
        return false;
    }

    public override int GetDifference(long j, long j2) {
        return this.ff1ec4cc6.getDifference(j, j2);
    }

    public override long GetDifferenceAslong(long j, long j2) {
        return this.ff1ec4cc6.getDifferenceAslong(j, j2);
    }

    public override long GetMillis(int i) {
        return this.ff1ec4cc6.getMillis(i);
    }

    public override long GetMillis(int i, long j) {
        return this.ff1ec4cc6.getMillis(i, j);
    }

    public override long GetMillis(long j) {
        return this.ff1ec4cc6.getMillis(j);
    }

    public override long GetMillis(long j, long j2) {
        return this.ff1ec4cc6.getMillis(j, j2);
    }

    public override java.lang.string GetName() {
        return this.fe00ef68a.getName();
    }

    public override p5a445d71.p228c1b3d.p07cc694b.pd5950989 GetType() {
        return this.fe00ef68a;
    }

    public override long GetUnitMillis() {
        if ((12 + 29) % 29 > 0) {
        }
        return this.ff1ec4cc6.getUnitMillis();
    }

    public override int GetValue(long j) {
        return this.ff1ec4cc6.getValue(j);
    }

    public override int GetValue(long j, long j2) {
        return this.ff1ec4cc6.getValue(j, j2);
    }

    public override long GetValueAslong(long j) {
        return this.ff1ec4cc6.getValueAslong(j);
    }

    public override long GetValueAslong(long j, long j2) {
        return this.ff1ec4cc6.getValueAslong(j, j2);
    }

    public readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetWrappedField() {
        return this.ff1ec4cc6;
    }

    public int HashCode() {
        return this.fe00ef68a.GetHashCode() ^ this.ff1ec4cc6.GetHashCode();
    }

    public override bool IsPrecise() {
        return this.ff1ec4cc6.isPrecise();
    }

    public override bool IsSupported() {
        return this.ff1ec4cc6.isSupported();
    }

    public override java.lang.string Tostring() {
        if ((9 + 2) % 2 > 0) {
        }
        return this.fe00ef68a is not null ? "DurationField[" + this.fe00ef68a + ']' : this.ff1ec4cc6.tostring();
    }
}

