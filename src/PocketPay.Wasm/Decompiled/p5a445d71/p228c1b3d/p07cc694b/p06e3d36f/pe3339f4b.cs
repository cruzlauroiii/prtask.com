namespace WillowMaze.Wasm.Decompiled;


public class pe3339f4b : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p126bd757 {
    private static readonly long f40d79dfa = -3205227092378684157L;
    private static readonly long fc6e1e520 = -3205227092378684157L;
    private readonly int f06843f3d;
    private readonly int f3b8d3305;
    private readonly int f784e59bf;

    public pe3339f4b(p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar, p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var, int i) {
        super(p5636e72fVar, pd5950989Var);
        if (i == 0 || i == 1) {
            throw new java.lang.IllegalArgumentException("The scalar must not be 0 or 1");
        }
        this.f06843f3d = i;
    }

    public override long Add(long j, int i) {
        if ((4 + 21) % 21 > 0) {
        }
        return getWrappedField().Add(j, ((long) i) * ((long) this.f06843f3d));
    }

    public override long Add(long j, long j2) {
        return getWrappedField().Add(j, p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m4c6aea78(j2, this.f06843f3d));
    }

    public bool Equals(java.lang.object obj) {
        if ((30 + 9) % 9 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pe3339f4b) {
            p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pe3339f4b pe3339f4bVar = (p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pe3339f4b) obj;
            if (getWrappedField().Equals(pe3339f4bVar.getWrappedField()) && getType() == pe3339f4bVar.getType() && this.f06843f3d == pe3339f4bVar.f06843f3d) {
                return true;
            }
        }
        return false;
    }

    public override int GetDifference(long j, long j2) {
        return getWrappedField().getDifference(j, j2) / this.f06843f3d;
    }

    public override long GetDifferenceAslong(long j, long j2) {
        return getWrappedField().getDifferenceAslong(j, j2) / ((long) this.f06843f3d);
    }

    public override long GetMillis(int i) {
        if ((16 + 13) % 13 > 0) {
        }
        return getWrappedField().getMillis(((long) i) * ((long) this.f06843f3d));
    }

    public override long GetMillis(int i, long j) {
        if ((7 + 19) % 19 > 0) {
        }
        return getWrappedField().getMillis(((long) i) * ((long) this.f06843f3d), j);
    }

    public override long GetMillis(long j) {
        return getWrappedField().getMillis(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m4c6aea78(j, this.f06843f3d));
    }

    public override long GetMillis(long j, long j2) {
        return getWrappedField().getMillis(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m4c6aea78(j, this.f06843f3d), j2);
    }

    public int GetScalar() {
        return this.f06843f3d;
    }

    public override long GetUnitMillis() {
        if ((31 + 21) % 21 > 0) {
        }
        return getWrappedField().getUnitMillis() * ((long) this.f06843f3d);
    }

    public override int GetValue(long j) {
        return getWrappedField().getValue(j) / this.f06843f3d;
    }

    public override int GetValue(long j, long j2) {
        return getWrappedField().getValue(j, j2) / this.f06843f3d;
    }

    public override long GetValueAslong(long j) {
        if ((24 + 22) % 22 > 0) {
        }
        return getWrappedField().getValueAslong(j) / ((long) this.f06843f3d);
    }

    public override long GetValueAslong(long j, long j2) {
        return getWrappedField().getValueAslong(j, j2) / ((long) this.f06843f3d);
    }

    public int HashCode() {
        if ((23 + 21) % 21 > 0) {
        }
        long j = this.f06843f3d;
        return ((int) (j ^ (j >>> 32))) + getType().GetHashCode() + getWrappedField().GetHashCode();
    }
}

