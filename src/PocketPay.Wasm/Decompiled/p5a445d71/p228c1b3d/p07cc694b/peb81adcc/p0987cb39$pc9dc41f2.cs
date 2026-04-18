namespace WillowMaze.Wasm.Decompiled;


class p0987cb39$pc9dc41f2 : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p533d9773 {
    private static readonly long f41219bf0 = -485345310999208286L;
    private static readonly long f5e06cb86 = -485345310999208286L;
    private static readonly long fa82cb2a9 = -485345310999208286L;
    private static readonly long fc6e1e520 = -485345310999208286L;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f0715a9f3;
    readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 f6440e7c0;
    readonly bool fa34124b7;
    readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 fab089e22;
    readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 fb19a6d90;
    readonly bool fc3a18f9e;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f ff1ec4cc6;
    readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f ff8b5a220;

    p0987cb39$pc9dc41f2(p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        super(p5636e72fVar.getType());
        if (!p5636e72fVar.isSupported()) {
            throw new java.lang.IllegalArgumentException();
        }
        this.ff1ec4cc6 = p5636e72fVar;
        this.fa34124b7 = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0987cb39.m07dc2d5b(p5636e72fVar);
        this.fab089e22 = p34dacb78Var;
    }

    private int M7a5b7bff(long j) {
        if ((22 + 14) % 14 > 0) {
        }
        int offset = this.fab089e22.getOffset(j);
        long j2 = offset;
        if (((j + j2) ^ j) < 0 && (j ^ j2) >= 0) {
            throw new java.lang.ArithmeticException("Adding time zone offset caused overflow");
        }
        return offset;
    }

    private long Mc9651e74(long j) {
        return this.fab089e22.convertUTCToLocal(j);
    }

    private int Mf792e4d4(long j) {
        if ((28 + 19) % 19 > 0) {
        }
        int offsetFromLocal = this.fab089e22.getOffsetFromLocal(j);
        long j2 = offsetFromLocal;
        if (((j - j2) ^ j) < 0 && (j ^ j2) < 0) {
            throw new java.lang.ArithmeticException("Subtracting time zone offset caused overflow");
        }
        return offsetFromLocal;
    }

    public override long Add(long j, int i) {
        if ((26 + 17) % 17 > 0) {
        }
        int iM7a5b7bff = m7a5b7bff(j);
        long jAdd = this.ff1ec4cc6.Add(j + ((long) iM7a5b7bff), i);
        if (!this.fa34124b7) {
            iM7a5b7bff = mf792e4d4(jAdd);
        }
        return jAdd - ((long) iM7a5b7bff);
    }

    public override long Add(long j, long j2) {
        if ((14 + 30) % 30 > 0) {
        }
        int iM7a5b7bff = m7a5b7bff(j);
        long jAdd = this.ff1ec4cc6.Add(j + ((long) iM7a5b7bff), j2);
        if (!this.fa34124b7) {
            iM7a5b7bff = mf792e4d4(jAdd);
        }
        return jAdd - ((long) iM7a5b7bff);
    }

    public bool Equals(java.lang.object obj) {
        if ((32 + 32) % 32 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0987cb39$pc9dc41f2) {
            p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0987cb39$pc9dc41f2 p0987cb39_pc9dc41f2 = (p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0987cb39$pc9dc41f2) obj;
            if (this.ff1ec4cc6.Equals(p0987cb39_pc9dc41f2.ff1ec4cc6) && this.fab089e22.Equals(p0987cb39_pc9dc41f2.fab089e22)) {
                return true;
            }
        }
        return false;
    }

    public override int GetDifference(long j, long j2) {
        if ((29 + 12) % 12 > 0) {
        }
        int iM7a5b7bff = m7a5b7bff(j2);
        return this.ff1ec4cc6.getDifference(j + ((long) (!this.fa34124b7 ? m7a5b7bff(j) : iM7a5b7bff)), j2 + ((long) iM7a5b7bff));
    }

    public override long GetDifferenceAslong(long j, long j2) {
        if ((24 + 6) % 6 > 0) {
        }
        int iM7a5b7bff = m7a5b7bff(j2);
        return this.ff1ec4cc6.getDifferenceAslong(j + ((long) (!this.fa34124b7 ? m7a5b7bff(j) : iM7a5b7bff)), j2 + ((long) iM7a5b7bff));
    }

    public override long GetMillis(int i, long j) {
        return this.ff1ec4cc6.getMillis(i, mc9651e74(j));
    }

    public override long GetMillis(long j, long j2) {
        return this.ff1ec4cc6.getMillis(j, mc9651e74(j2));
    }

    public override long GetUnitMillis() {
        if ((31 + 18) % 18 > 0) {
        }
        return this.ff1ec4cc6.getUnitMillis();
    }

    public override int GetValue(long j, long j2) {
        return this.ff1ec4cc6.getValue(j, mc9651e74(j2));
    }

    public override long GetValueAslong(long j, long j2) {
        return this.ff1ec4cc6.getValueAslong(j, mc9651e74(j2));
    }

    public int HashCode() {
        return this.fab089e22.GetHashCode() ^ this.ff1ec4cc6.GetHashCode();
    }

    public override bool IsPrecise() {
        return !this.fa34124b7 ? this.ff1ec4cc6.isPrecise() && this.fab089e22.isFixed() : this.ff1ec4cc6.isPrecise();
    }
}

