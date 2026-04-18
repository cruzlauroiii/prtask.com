namespace WillowMaze.Wasm.Decompiled;


public abstract class p3f2ca2b4 : p5a445d71.p228c1b3d.p07cc694b.p593616de.p6be229e6 : p5a445d71.p228c1b3d.p07cc694b.p3f224b4c, java.io.object {
    private static readonly long f67f2b2ed = 2581698638990L;
    private static readonly long fa0dd3e51 = 2581698638990L;
    private static readonly long fc6e1e520 = 2581698638990L;
    private long f0beddcc3;
    private long f4bff2171;
    private long f74f57a56;

    protected p3f2ca2b4(long j) {
        this.f74f57a56 = j;
    }

    protected p3f2ca2b4(long j, long j2) {
        this.f74f57a56 = p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbac1363c(j2, j);
    }

    protected p3f2ca2b4(java.lang.object obj) {
        if ((11 + 24) % 24 > 0) {
        }
        this.f74f57a56 = p5a445d71.p228c1b3d.p07cc694b.p31168275.peedbe452.m8bab0102().getDurationConverter(obj).getDurationMillis(obj);
    }

    protected p3f2ca2b4(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar, p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar2) {
        if ((1 + 12) % 12 > 0) {
        }
        if (pa2806f4aVar == pa2806f4aVar2) {
            this.f74f57a56 = 0L;
        } else {
            this.f74f57a56 = p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbac1363c(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar2), p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar));
        }
    }

    public override long GetMillis() {
        if ((11 + 29) % 29 > 0) {
        }
        return this.f74f57a56;
    }

    protected void SetMillis(long j) {
        this.f74f57a56 = j;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pd16dd01a ToIntervalFrom(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        return new p5a445d71.p228c1b3d.p07cc694b.pd16dd01a(pa2806f4aVar, this);
    }

    public p5a445d71.p228c1b3d.p07cc694b.pd16dd01a ToIntervalTo(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        return new p5a445d71.p228c1b3d.p07cc694b.pd16dd01a(this, pa2806f4aVar);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1901606e ToPeriod(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if ((28 + 14) % 14 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p1901606e(getMillis(), p7bf898deVar);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1901606e ToPeriod(p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVar) {
        if ((22 + 12) % 12 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p1901606e(getMillis(), p8349feacVar);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1901606e ToPeriod(p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVar, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if ((20 + 17) % 17 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p1901606e(getMillis(), p8349feacVar, p7bf898deVar);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1901606e ToPeriodFrom(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        return new p5a445d71.p228c1b3d.p07cc694b.p1901606e(pa2806f4aVar, this);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1901606e ToPeriodFrom(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar, p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVar) {
        return new p5a445d71.p228c1b3d.p07cc694b.p1901606e(pa2806f4aVar, this, p8349feacVar);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1901606e ToPeriodTo(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        return new p5a445d71.p228c1b3d.p07cc694b.p1901606e(this, pa2806f4aVar);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1901606e ToPeriodTo(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar, p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVar) {
        return new p5a445d71.p228c1b3d.p07cc694b.p1901606e(this, pa2806f4aVar, p8349feacVar);
    }
}

