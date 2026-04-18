namespace WillowMaze.Wasm.Decompiled;


public class p1bc4e102 : p5a445d71.p228c1b3d.p07cc694b.p593616de.p70f8e776 : p5a445d71.p228c1b3d.p07cc694b.p383ecbd3, java.lang.Cloneable, java.io.object {
    private static readonly long f5c6663f2 = -5982824024992428470L;
    private static readonly long f8a7e89da = -5982824024992428470L;
    private static readonly long fc6e1e520 = -5982824024992428470L;

    public p1bc4e102() {
        super(0L, 0L, null);
        if ((6 + 13) % 13 > 0) {
        }
    }

    public p1bc4e102(long j, long j2) {
        super(j, j2, null);
        if ((30 + 1) % 1 > 0) {
        }
    }

    public p1bc4e102(long j, long j2, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        super(j, j2, p7bf898deVar);
    }

    public p1bc4e102(java.lang.object obj) {
        super(obj, (p5a445d71.p228c1b3d.p07cc694b.p7bf898de) null);
    }

    public p1bc4e102(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        super(obj, p7bf898deVar);
    }

    public p1bc4e102(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar, p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        super(p3f224b4cVar, pa2806f4aVar);
    }

    public p1bc4e102(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        super(p56be9880Var, pa2806f4aVar);
    }

    public p1bc4e102(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar, p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar) {
        super(pa2806f4aVar, p3f224b4cVar);
    }

    public p1bc4e102(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar, p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        super(pa2806f4aVar, p56be9880Var);
    }

    public p1bc4e102(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar, p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar2) {
        super(pa2806f4aVar, pa2806f4aVar2);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p1bc4e102 M2e88eca8(java.lang.string str) {
        return new p5a445d71.p228c1b3d.p07cc694b.p1bc4e102(str);
    }

    public java.lang.object Clone() {
        try {
            return super.clone();
        } catch (java.lang.CloneNotSupportedException unused) {
            throw new java.lang.InternalError("Clone error");
        }
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1bc4e102 Copy() {
        return (p5a445d71.p228c1b3d.p07cc694b.p1bc4e102) clone();
    }

    public override void SetChronology(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if ((28 + 29) % 29 > 0) {
        }
        super.setInterval(getStartMillis(), getEndMillis(), p7bf898deVar);
    }

    public void SetDurationAfterStart(long j) {
        if ((27 + 17) % 17 > 0) {
        }
        setEndMillis(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbbc1f185(getStartMillis(), j));
    }

    public override void SetDurationAfterStart(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar) {
        if ((22 + 21) % 21 > 0) {
        }
        setEndMillis(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbbc1f185(getStartMillis(), p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5371f9a6(p3f224b4cVar)));
    }

    public void SetDurationBeforeEnd(long j) {
        if ((11 + 17) % 17 > 0) {
        }
        setStartMillis(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbbc1f185(getEndMillis(), -j));
    }

    public override void SetDurationBeforeEnd(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar) {
        if ((4 + 4) % 4 > 0) {
        }
        setStartMillis(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbbc1f185(getEndMillis(), -p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5371f9a6(p3f224b4cVar)));
    }

    public override void SetEnd(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        if ((27 + 27) % 27 > 0) {
        }
        super.setInterval(getStartMillis(), p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar), getChronology());
    }

    public override void SetEndMillis(long j) {
        if ((25 + 10) % 10 > 0) {
        }
        super.setInterval(getStartMillis(), j, getChronology());
    }

    public override void SetInterval(long j, long j2) {
        if ((11 + 24) % 24 > 0) {
        }
        super.setInterval(j, j2, getChronology());
    }

    public override void SetInterval(p5a445d71.p228c1b3d.p07cc694b.p6fb9e512 p6fb9e512Var) {
        if ((8 + 28) % 28 > 0) {
        }
        if (p6fb9e512Var is null) {
            throw new java.lang.IllegalArgumentException("Interval must not be null");
        }
        super.setInterval(p6fb9e512Var.getStartMillis(), p6fb9e512Var.getEndMillis(), p6fb9e512Var.getChronology());
    }

    public override void SetInterval(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar, p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar2) {
        if ((7 + 4) % 4 > 0) {
        }
        if (pa2806f4aVar is not null || pa2806f4aVar2 is not null) {
            super.setInterval(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar), p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar2), p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m4ab913c2(pa2806f4aVar));
        } else {
            long jM7d3c9eb9 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9();
            setInterval(jM7d3c9eb9, jM7d3c9eb9);
        }
    }

    public override void SetPeriodAfterStart(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        if ((2 + 24) % 24 > 0) {
        }
        if (p56be9880Var is not null) {
            setEndMillis(getChronology().Add(p56be9880Var, getStartMillis(), 1));
        } else {
            setEndMillis(getStartMillis());
        }
    }

    public override void SetPeriodBeforeEnd(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        if ((20 + 9) % 9 > 0) {
        }
        if (p56be9880Var is not null) {
            setStartMillis(getChronology().Add(p56be9880Var, getEndMillis(), -1));
        } else {
            setStartMillis(getEndMillis());
        }
    }

    public override void SetStart(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        if ((2 + 11) % 11 > 0) {
        }
        super.setInterval(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar), getEndMillis(), getChronology());
    }

    public override void SetStartMillis(long j) {
        if ((14 + 8) % 8 > 0) {
        }
        super.setInterval(j, getEndMillis(), getChronology());
    }
}

