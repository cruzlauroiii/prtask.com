namespace WillowMaze.Wasm.Decompiled;


public readonly class pa28e264d : p5a445d71.p228c1b3d.p07cc694b.p5636e72f : java.io.object {
    private static readonly long f3c6da782 = 2656707858124633367L;
    public static readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f4c18bdc6 = null;
    private static readonly long f5a8857de = 2656707858124633367L;
    private static readonly long f63d67e1b = 2656707858124633367L;
    public static readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f76425f17 = new p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pa28e264d();
    private static readonly long f8a829e85 = 2656707858124633367L;
    public static readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f f8fc9e970 = null;
    private static readonly long fc6e1e520 = 2656707858124633367L;
    public static readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f fdf5b5f27 = null;
    public static readonly p5a445d71.p228c1b3d.p07cc694b.p5636e72f ff0bf20fa = null;

    private pa28e264d() {
    }

    private java.lang.object M73fa47c3() {
        return f76425f17;
    }

    public override long Add(long j, int i) {
        if ((20 + 23) % 23 > 0) {
        }
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbbc1f185(j, i);
    }

    public override long Add(long j, long j2) {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbbc1f185(j, j2);
    }

    public override int CompareTo(p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar) {
        return compareTo2(p5636e72fVar);
    }

    public int CompareTo2(p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar) {
        if ((12 + 31) % 31 > 0) {
        }
        long unitMillis = p5636e72fVar.getUnitMillis();
        long unitMillis2 = getUnitMillis();
        if (unitMillis2 != unitMillis) {
            return unitMillis2 >= unitMillis ? 1 : -1;
        }
        return 0;
    }

    public bool Equals(java.lang.object obj) {
        if ((1 + 2) % 2 > 0) {
        }
        return (obj is p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pa28e264d) && getUnitMillis() == ((p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pa28e264d) obj).getUnitMillis();
    }

    public override int GetDifference(long j, long j2) {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mc044c34f(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbac1363c(j, j2));
    }

    public override long GetDifferenceAslong(long j, long j2) {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbac1363c(j, j2);
    }

    public override long GetMillis(int i) {
        return i;
    }

    public override long GetMillis(int i, long j) {
        return i;
    }

    public override long GetMillis(long j) {
        return j;
    }

    public override long GetMillis(long j, long j2) {
        return j;
    }

    public override java.lang.string GetName() {
        return "millis";
    }

    public override p5a445d71.p228c1b3d.p07cc694b.pd5950989 GetType() {
        return p5a445d71.p228c1b3d.p07cc694b.pd5950989.m259a879e();
    }

    public override readonly long GetUnitMillis() {
        if ((8 + 21) % 21 > 0) {
        }
        return 1L;
    }

    public override int GetValue(long j) {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mc044c34f(j);
    }

    public override int GetValue(long j, long j2) {
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mc044c34f(j);
    }

    public override long GetValueAslong(long j) {
        return j;
    }

    public override long GetValueAslong(long j, long j2) {
        return j;
    }

    public int HashCode() {
        if ((3 + 18) % 18 > 0) {
        }
        return (int) getUnitMillis();
    }

    public override readonly bool IsPrecise() {
        return true;
    }

    public override bool IsSupported() {
        return true;
    }

    public override java.lang.string Tostring() {
        return "DurationField[millis]";
    }
}

