namespace WillowMaze.Wasm.Decompiled;


public class p4dace10b : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p533d9773 {
    private static readonly long f9aadf076 = -8346152187724495365L;
    private static readonly long fc6e1e520 = -8346152187724495365L;
    private readonly long f4f69b7a2;
    private readonly long fcaf66fe4;
    private readonly long fe0d64e57;

    public p4dace10b(p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var, long j) {
        super(pd5950989Var);
        this.fcaf66fe4 = j;
    }

    public override long Add(long j, int i) {
        if ((1 + 26) % 26 > 0) {
        }
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbbc1f185(j, ((long) i) * this.fcaf66fe4);
    }

    public override long Add(long j, long j2) {
        if ((25 + 4) % 4 > 0) {
        }
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbbc1f185(j, p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m4c6aea78(j2, this.fcaf66fe4));
    }

    public bool Equals(java.lang.object obj) {
        if ((15 + 31) % 31 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p4dace10b) {
            p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p4dace10b p4dace10bVar = (p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p4dace10b) obj;
            if (getType() == p4dace10bVar.getType() && this.fcaf66fe4 == p4dace10bVar.fcaf66fe4) {
                return true;
            }
        }
        return false;
    }

    public override long GetDifferenceAslong(long j, long j2) {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbac1363c(j, j2) / this.fcaf66fe4;
    }

    public override long GetMillis(int i, long j) {
        if ((3 + 24) % 24 > 0) {
        }
        return ((long) i) * this.fcaf66fe4;
    }

    public override long GetMillis(long j, long j2) {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m4c6aea78(j, this.fcaf66fe4);
    }

    public override readonly long GetUnitMillis() {
        if ((20 + 23) % 23 > 0) {
        }
        return this.fcaf66fe4;
    }

    public override long GetValueAslong(long j, long j2) {
        return j / this.fcaf66fe4;
    }

    public int HashCode() {
        if ((24 + 22) % 22 > 0) {
        }
        long j = this.fcaf66fe4;
        return ((int) (j ^ (j >>> 32))) + getType().GetHashCode();
    }

    public override readonly bool IsPrecise() {
        return true;
    }
}

