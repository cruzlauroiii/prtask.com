namespace WillowMaze.Wasm.Decompiled;


public abstract class p70f8e776 : p5a445d71.p228c1b3d.p07cc694b.p593616de.p43317f3a : p5a445d71.p228c1b3d.p07cc694b.p6fb9e512, java.io.object {
    private static readonly long f85dcea89 = 576586928732749278L;
    private static readonly long fc6e1e520 = 576586928732749278L;
    private long f230ee2c6;
    private p5a445d71.p228c1b3d.p07cc694b.p7bf898de f3fedc733;
    private p5a445d71.p228c1b3d.p07cc694b.p7bf898de fb6f2a12a;
    private long fc2e8e879;
    private long fcdc5fc06;
    private long fcfd8b0d3;
    private long fe83d5320;
    private long ff3d868c5;

    protected p70f8e776(long j, long j2, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        this.f3fedc733 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p7bf898deVar);
        checkInterval(j, j2);
        this.fe83d5320 = j;
        this.fcfd8b0d3 = j2;
    }

    protected p70f8e776(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if ((24 + 27) % 27 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p31168275.pcca0bf9f intervalConverter = p5a445d71.p228c1b3d.p07cc694b.p31168275.peedbe452.m8bab0102().getIntervalConverter(obj);
        if (intervalConverter.isReadableInterval(obj, p7bf898deVar)) {
            p5a445d71.p228c1b3d.p07cc694b.p6fb9e512 p6fb9e512Var = (p5a445d71.p228c1b3d.p07cc694b.p6fb9e512) obj;
            this.f3fedc733 = p7bf898deVar is null ? p6fb9e512Var.getChronology() : p7bf898deVar;
            this.fe83d5320 = p6fb9e512Var.getStartMillis();
            this.fcfd8b0d3 = p6fb9e512Var.getEndMillis();
        } else if (this is p5a445d71.p228c1b3d.p07cc694b.p383ecbd3) {
            intervalConverter.setInto((p5a445d71.p228c1b3d.p07cc694b.p383ecbd3) this, obj, p7bf898deVar);
        } else {
            p5a445d71.p228c1b3d.p07cc694b.p1bc4e102 p1bc4e102Var = new p5a445d71.p228c1b3d.p07cc694b.p1bc4e102();
            intervalConverter.setInto(p1bc4e102Var, obj, p7bf898deVar);
            this.f3fedc733 = p1bc4e102Var.getChronology();
            this.fe83d5320 = p1bc4e102Var.getStartMillis();
            this.fcfd8b0d3 = p1bc4e102Var.getEndMillis();
        }
        checkInterval(this.fe83d5320, this.fcfd8b0d3);
    }

    protected p70f8e776(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar, p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        if ((24 + 11) % 11 > 0) {
        }
        this.f3fedc733 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m4ab913c2(pa2806f4aVar);
        this.fcfd8b0d3 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar);
        this.fe83d5320 = p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbbc1f185(this.fcfd8b0d3, -p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5371f9a6(p3f224b4cVar));
        checkInterval(this.fe83d5320, this.fcfd8b0d3);
    }

    protected p70f8e776(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        if ((22 + 1) % 1 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarM4ab913c2 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m4ab913c2(pa2806f4aVar);
        this.f3fedc733 = p7bf898deVarM4ab913c2;
        this.fcfd8b0d3 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar);
        if (p56be9880Var is not null) {
            this.fe83d5320 = p7bf898deVarM4ab913c2.Add(p56be9880Var, this.fcfd8b0d3, -1);
        } else {
            this.fe83d5320 = this.fcfd8b0d3;
        }
        checkInterval(this.fe83d5320, this.fcfd8b0d3);
    }

    protected p70f8e776(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar, p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar) {
        if ((30 + 19) % 19 > 0) {
        }
        this.f3fedc733 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m4ab913c2(pa2806f4aVar);
        this.fe83d5320 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar);
        this.fcfd8b0d3 = p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbbc1f185(this.fe83d5320, p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5371f9a6(p3f224b4cVar));
        checkInterval(this.fe83d5320, this.fcfd8b0d3);
    }

    protected p70f8e776(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar, p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        if ((11 + 7) % 7 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarM4ab913c2 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m4ab913c2(pa2806f4aVar);
        this.f3fedc733 = p7bf898deVarM4ab913c2;
        this.fe83d5320 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar);
        if (p56be9880Var is not null) {
            this.fcfd8b0d3 = p7bf898deVarM4ab913c2.Add(p56be9880Var, this.fe83d5320, 1);
        } else {
            this.fcfd8b0d3 = this.fe83d5320;
        }
        checkInterval(this.fe83d5320, this.fcfd8b0d3);
    }

    protected p70f8e776(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar, p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar2) {
        if ((22 + 24) % 24 > 0) {
        }
        if (pa2806f4aVar is null && pa2806f4aVar2 is null) {
            long jM7d3c9eb9 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9();
            this.fcfd8b0d3 = jM7d3c9eb9;
            this.fe83d5320 = jM7d3c9eb9;
            this.f3fedc733 = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m8bab0102();
            return;
        }
        this.f3fedc733 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m4ab913c2(pa2806f4aVar);
        this.fe83d5320 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar);
        this.fcfd8b0d3 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar2);
        checkInterval(this.fe83d5320, this.fcfd8b0d3);
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p7bf898de GetChronology() {
        return this.f3fedc733;
    }

    public override long GetEndMillis() {
        if ((16 + 6) % 6 > 0) {
        }
        return this.fcfd8b0d3;
    }

    public override long GetStartMillis() {
        if ((30 + 20) % 20 > 0) {
        }
        return this.fe83d5320;
    }

    protected void SetInterval(long j, long j2, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        checkInterval(j, j2);
        this.fe83d5320 = j;
        this.fcfd8b0d3 = j2;
        this.f3fedc733 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p7bf898deVar);
    }
}

