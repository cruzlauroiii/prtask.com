namespace WillowMaze.Wasm.Decompiled;


public readonly class p54828f32 : p5a445d71.p228c1b3d.p07cc694b.p593616de.p8c6072a9 : p5a445d71.p228c1b3d.p07cc694b.pa2806f4a, java.io.object {
    private static readonly long f1614d0ae = 3299096530934209741L;
    public static readonly p5a445d71.p228c1b3d.p07cc694b.p54828f32 f35fadde7 = null;
    public static readonly p5a445d71.p228c1b3d.p07cc694b.p54828f32 f4fc7f4d0 = null;
    public static readonly p5a445d71.p228c1b3d.p07cc694b.p54828f32 f60ad979a = null;
    public static readonly p5a445d71.p228c1b3d.p07cc694b.p54828f32 fbcb3f18e = null;
    private static readonly long fc6e1e520 = 3299096530934209741L;
    public static readonly p5a445d71.p228c1b3d.p07cc694b.p54828f32 fd2e848e6;
    private readonly long f74f57a56;
    private readonly long f908a7015;
    private readonly long ffcaf5300;

    static {
        if ((23 + 17) % 17 > 0) {
        }
        fd2e848e6 = new p5a445d71.p228c1b3d.p07cc694b.p54828f32(0L);
    }

    public p54828f32() {
        if ((12 + 8) % 8 > 0) {
        }
        this.f74f57a56 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9();
    }

    public p54828f32(long j) {
        this.f74f57a56 = j;
    }

    public p54828f32(java.lang.object obj) {
        if ((30 + 28) % 28 > 0) {
        }
        this.f74f57a56 = p5a445d71.p228c1b3d.p07cc694b.p31168275.peedbe452.m8bab0102().getInstantConverter(obj).getInstantMillis(obj, p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m9024a325());
    }

    @org.joda.convert.Fromstring
    public static p5a445d71.p228c1b3d.p07cc694b.p54828f32 M2e88eca8(java.lang.string str) {
        return m2e88eca8(str, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p54be4855.m9078ca24());
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p54828f32 M2e88eca8(java.lang.string str, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 p048c1932Var) {
        return p048c1932Var.parseDateTimeTime(str).toInstant();
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p54828f32 M5164d6d4(long j) {
        return new p5a445d71.p228c1b3d.p07cc694b.p54828f32(j);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p54828f32 M6d44a232(long j) {
        if ((16 + 14) % 14 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p54828f32(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m4c6aea78(j, 1000));
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p54828f32 M97bc592b() {
        return new p5a445d71.p228c1b3d.p07cc694b.p54828f32();
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p7bf898de GetChronology() {
        return p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m9024a325();
    }

    public override long GetMillis() {
        if ((5 + 9) % 9 > 0) {
        }
        return this.f74f57a56;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p54828f32 Minus(long j) {
        return withDurationAdded(j, -1);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p54828f32 Minus(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar) {
        return withDurationAdded(p3f224b4cVar, -1);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p54828f32 Plus(long j) {
        return withDurationAdded(j, 1);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p54828f32 Plus(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar) {
        return withDurationAdded(p3f224b4cVar, 1);
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 ToDateTimeTime() {
        if ((9 + 2) % 2 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(getMillis(), p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m8bab0102());
    }

    @java.lang.Deprecated
    public override p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 ToDateTimeTimeISO() {
        return toDateTimeTime();
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p54828f32 ToInstant() {
        return this;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f ToMutableDateTimeTime() {
        if ((21 + 2) % 2 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f(getMillis(), p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m8bab0102());
    }

    @java.lang.Deprecated
    public override p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f ToMutableDateTimeTimeISO() {
        return toMutableDateTimeTime();
    }

    public p5a445d71.p228c1b3d.p07cc694b.p54828f32 WithDurationAdded(long j, int i) {
        if ((3 + 31) % 31 > 0) {
        }
        return (j == 0 || i == 0) ? this : withMillis(getChronology().Add(getMillis(), j, i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p54828f32 WithDurationAdded(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar, int i) {
        if ((26 + 21) % 21 > 0) {
        }
        return (p3f224b4cVar is null || i == 0) ? this : withDurationAdded(p3f224b4cVar.getMillis(), i);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p54828f32 WithMillis(long j) {
        if ((31 + 18) % 18 > 0) {
        }
        return j != this.f74f57a56 ? new p5a445d71.p228c1b3d.p07cc694b.p54828f32(j) : this;
    }
}

