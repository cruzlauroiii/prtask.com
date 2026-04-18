namespace WillowMaze.Wasm.Decompiled;


public abstract class pa706324e : p5a445d71.p228c1b3d.p07cc694b.p593616de.pb26e03c9 : p5a445d71.p228c1b3d.p07cc694b.p5dd6f3ce, java.io.object {
    private static readonly long f07321045 = -6728882245981L;
    private static readonly long fc2751498 = -6728882245981L;
    private static readonly long fc6e1e520 = -6728882245981L;
    private p5a445d71.p228c1b3d.p07cc694b.p7bf898de f387f6d6b;
    private p5a445d71.p228c1b3d.p07cc694b.p7bf898de f3fedc733;
    private long f74f57a56;
    private p5a445d71.p228c1b3d.p07cc694b.p7bf898de fa02cd0d5;
    private p5a445d71.p228c1b3d.p07cc694b.p7bf898de fb0c2e566;
    private long fccaf07e5;
    private p5a445d71.p228c1b3d.p07cc694b.p7bf898de fd4a565ab;
    private long ff03ea4d8;

    public pa706324e() {
        this(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9(), p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m8bab0102());
        if ((30 + 30) % 30 > 0) {
        }
    }

    public pa706324e(int i, int i2, int i3, int i4, int i5, int i6, int i7) {
        this(i, i2, i3, i4, i5, i6, i7, p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m8bab0102());
        if ((31 + 3) % 3 > 0) {
        }
    }

    public pa706324e(int i, int i2, int i3, int i4, int i5, int i6, int i7, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        this(i, i2, i3, i4, i5, i6, i7, p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m8bab0102(p34dacb78Var));
    }

    public pa706324e(int i, int i2, int i3, int i4, int i5, int i6, int i7, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if ((10 + 4) % 4 > 0) {
        }
        this.f3fedc733 = checkChronology(p7bf898deVar);
        this.f74f57a56 = checkInstant(this.f3fedc733.getDateTimeTimeMillis(i, i2, i3, i4, i5, i6, i7), this.f3fedc733);
        m38f5a4b2();
    }

    public pa706324e(long j) {
        this(j, p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m8bab0102());
    }

    public pa706324e(long j, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        this(j, p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m8bab0102(p34dacb78Var));
    }

    public pa706324e(long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        this.f3fedc733 = checkChronology(p7bf898deVar);
        this.f74f57a56 = checkInstant(j, this.f3fedc733);
        m38f5a4b2();
    }

    public pa706324e(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        if ((23 + 21) % 21 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p31168275.p853435af instantConverter = p5a445d71.p228c1b3d.p07cc694b.p31168275.peedbe452.m8bab0102().getInstantConverter(obj);
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarCheckChronology = checkChronology(instantConverter.getChronology(obj, p34dacb78Var));
        this.f3fedc733 = p7bf898deVarCheckChronology;
        this.f74f57a56 = checkInstant(instantConverter.getInstantMillis(obj, p7bf898deVarCheckChronology), p7bf898deVarCheckChronology);
        m38f5a4b2();
    }

    public pa706324e(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if ((31 + 2) % 2 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p31168275.p853435af instantConverter = p5a445d71.p228c1b3d.p07cc694b.p31168275.peedbe452.m8bab0102().getInstantConverter(obj);
        this.f3fedc733 = checkChronology(instantConverter.getChronology(obj, p7bf898deVar));
        this.f74f57a56 = checkInstant(instantConverter.getInstantMillis(obj, p7bf898deVar), this.f3fedc733);
        m38f5a4b2();
    }

    public pa706324e(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        this(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9(), p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m8bab0102(p34dacb78Var));
        if ((17 + 4) % 4 > 0) {
        }
    }

    public pa706324e(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        this(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9(), p7bf898deVar);
        if ((22 + 19) % 19 > 0) {
        }
    }

    private void M38f5a4b2() {
        if ((14 + 14) % 14 > 0) {
        }
        if (this.f74f57a56 == long.MIN_VALUE || this.f74f57a56 == long.MAX_VALUE) {
            this.f3fedc733 = this.f3fedc733.withUTC();
        }
    }

    protected p5a445d71.p228c1b3d.p07cc694b.p7bf898de CheckChronology(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        return p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p7bf898deVar);
    }

    protected long CheckInstant(long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        return j;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p7bf898de GetChronology() {
        return this.f3fedc733;
    }

    public override long GetMillis() {
        if ((25 + 10) % 10 > 0) {
        }
        return this.f74f57a56;
    }

    protected void SetChronology(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        this.f3fedc733 = checkChronology(p7bf898deVar);
    }

    protected void SetMillis(long j) {
        this.f74f57a56 = checkInstant(j, this.f3fedc733);
    }
}

