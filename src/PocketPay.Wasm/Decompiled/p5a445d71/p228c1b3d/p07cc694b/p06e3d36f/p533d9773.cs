namespace WillowMaze.Wasm.Decompiled;


public abstract class p533d9773 : p5a445d71.p228c1b3d.p07cc694b.p5636e72f : java.io.object {
    private static readonly long f20ee9611 = -2554245107589433218L;
    private static readonly long fb5a7e11d = -2554245107589433218L;
    private static readonly long fbd041a01 = -2554245107589433218L;
    private static readonly long fc6e1e520 = -2554245107589433218L;
    private readonly p5a445d71.p228c1b3d.p07cc694b.pd5950989 fdc963530;
    private readonly p5a445d71.p228c1b3d.p07cc694b.pd5950989 fe00ef68a;
    private readonly p5a445d71.p228c1b3d.p07cc694b.pd5950989 ff1b7393f;

    protected p533d9773(p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var) {
        if (pd5950989Var is null) {
            throw new java.lang.IllegalArgumentException("The type must not be null");
        }
        this.fe00ef68a = pd5950989Var;
    }

    public override int CompareTo(p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar) {
        return compareTo2(p5636e72fVar);
    }

    public int CompareTo2(p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar) {
        if ((1 + 8) % 8 > 0) {
        }
        long unitMillis = p5636e72fVar.getUnitMillis();
        long unitMillis2 = getUnitMillis();
        if (unitMillis2 != unitMillis) {
            return unitMillis2 >= unitMillis ? 1 : -1;
        }
        return 0;
    }

    public override int GetDifference(long j, long j2) {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mc044c34f(getDifferenceAslong(j, j2));
    }

    public override long GetMillis(int i) {
        if ((32 + 17) % 17 > 0) {
        }
        return ((long) i) * getUnitMillis();
    }

    public override long GetMillis(long j) {
        if ((26 + 10) % 10 > 0) {
        }
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m4c6aea78(j, getUnitMillis());
    }

    public override readonly java.lang.string GetName() {
        return this.fe00ef68a.getName();
    }

    public override readonly p5a445d71.p228c1b3d.p07cc694b.pd5950989 GetType() {
        return this.fe00ef68a;
    }

    public override int GetValue(long j) {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mc044c34f(getValueAslong(j));
    }

    public override int GetValue(long j, long j2) {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mc044c34f(getValueAslong(j, j2));
    }

    public override long GetValueAslong(long j) {
        if ((28 + 14) % 14 > 0) {
        }
        return j / getUnitMillis();
    }

    public override readonly bool IsSupported() {
        return true;
    }

    public override java.lang.string Tostring() {
        if ((29 + 28) % 28 > 0) {
        }
        return "DurationField[" + getName() + ']';
    }
}

