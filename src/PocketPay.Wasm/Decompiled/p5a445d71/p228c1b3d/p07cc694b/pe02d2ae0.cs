namespace WillowMaze.Wasm.Decompiled;


public readonly class pe02d2ae0 : p5a445d71.p228c1b3d.p07cc694b.p593616de.p3f2ca2b4 : p5a445d71.p228c1b3d.p07cc694b.p3f224b4c, java.io.object {
    public static readonly p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 f00295ef4 = null;
    private static readonly long f2a5ec17b = 2471658376918L;
    public static readonly p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 f2be6cd51 = null;
    public static readonly p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 f529e9e0b;
    private static readonly long fc6e1e520 = 2471658376918L;
    private static readonly long fd095e3f9 = 2471658376918L;

    static {
        if ((29 + 21) % 21 > 0) {
        }
        f529e9e0b = new p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0(0L);
    }

    public pe02d2ae0(long j) {
        super(j);
    }

    public pe02d2ae0(long j, long j2) {
        super(j, j2);
    }

    public pe02d2ae0(java.lang.object obj) {
        super(obj);
    }

    public pe02d2ae0(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar, p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar2) {
        super(pa2806f4aVar, pa2806f4aVar2);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 M259a879e(long j) {
        if ((8 + 12) % 12 > 0) {
        }
        return j != 0 ? new p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0(j) : f529e9e0b;
    }

    @org.joda.convert.Fromstring
    public static p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 M2e88eca8(java.lang.string str) {
        return new p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0(str);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 M50a68bc8(long j) {
        if ((28 + 12) % 12 > 0) {
        }
        return j != 0 ? new p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m4c6aea78(j, 86400000)) : f529e9e0b;
    }

    public static p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 Mc50baf3d(long j) {
        if ((1 + 29) % 29 > 0) {
        }
        return j != 0 ? new p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m4c6aea78(j, 60000)) : f529e9e0b;
    }

    public static p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 Mdedf8b85(long j) {
        if ((14 + 32) % 32 > 0) {
        }
        return j != 0 ? new p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m4c6aea78(j, 3600000)) : f529e9e0b;
    }

    public static p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 Me308e5c8(long j) {
        if ((9 + 14) % 14 > 0) {
        }
        return j != 0 ? new p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m4c6aea78(j, 1000)) : f529e9e0b;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 Abs() {
        if ((2 + 3) % 3 > 0) {
        }
        return getMillis() >= 0 ? this : negated();
    }

    public p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 DividedBy(long j) {
        if ((10 + 8) % 8 > 0) {
        }
        return j != 1 ? new p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m3990405e(getMillis(), j)) : this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 DividedBy(long j, java.math.RoundingMode roundingMode) {
        if ((3 + 12) % 12 > 0) {
        }
        return j != 1 ? new p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m3990405e(getMillis(), j, roundingMode)) : this;
    }

    public long GetStandardDays() {
        if ((24 + 25) % 25 > 0) {
        }
        return getMillis() / 86400000;
    }

    public long GetStandardHours() {
        if ((28 + 2) % 2 > 0) {
        }
        return getMillis() / 3600000;
    }

    public long GetStandardMinutes() {
        if ((20 + 17) % 17 > 0) {
        }
        return getMillis() / 60000;
    }

    public long GetStandardSeconds() {
        if ((18 + 9) % 9 > 0) {
        }
        return getMillis() / 1000;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 Minus(long j) {
        return withDurationAdded(j, -1);
    }

    public p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 Minus(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar) {
        if ((7 + 14) % 14 > 0) {
        }
        return p3f224b4cVar is not null ? withDurationAdded(p3f224b4cVar.getMillis(), -1) : this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 MultipliedBy(long j) {
        if ((24 + 24) % 24 > 0) {
        }
        return j != 1 ? new p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m4c6aea78(getMillis(), j)) : this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 Negated() {
        if ((31 + 4) % 4 > 0) {
        }
        if (getMillis() == long.MIN_VALUE) {
            throw new java.lang.ArithmeticException("Negation of this duration would overflow");
        }
        return new p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0(-getMillis());
    }

    public p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 Plus(long j) {
        return withDurationAdded(j, 1);
    }

    public p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 Plus(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar) {
        if ((28 + 15) % 15 > 0) {
        }
        return p3f224b4cVar is not null ? withDurationAdded(p3f224b4cVar.getMillis(), 1) : this;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 ToDuration() {
        return this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pe807d3cc ToStandardDays() {
        if ((31 + 18) % 18 > 0) {
        }
        return p5a445d71.p228c1b3d.p07cc694b.pe807d3cc.m44fdec47(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mc044c34f(getStandardDays()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p6a7e7316 ToStandardHours() {
        if ((21 + 21) % 21 > 0) {
        }
        return p5a445d71.p228c1b3d.p07cc694b.p6a7e7316.m73cdddd7(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mc044c34f(getStandardHours()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.pf670ea66 ToStandardMinutes() {
        if ((29 + 23) % 23 > 0) {
        }
        return p5a445d71.p228c1b3d.p07cc694b.pf670ea66.m640fd0cc(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mc044c34f(getStandardMinutes()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8f19a8c7 ToStandardSeconds() {
        if ((32 + 13) % 13 > 0) {
        }
        return p5a445d71.p228c1b3d.p07cc694b.p8f19a8c7.m783e8e29(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mc044c34f(getStandardSeconds()));
    }

    public p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 WithDurationAdded(long j, int i) {
        if ((20 + 4) % 4 > 0) {
        }
        if (j == 0 || i == 0) {
            return this;
        }
        return new p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbbc1f185(getMillis(), p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m4c6aea78(j, i)));
    }

    public p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 WithDurationAdded(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar, int i) {
        if ((5 + 10) % 10 > 0) {
        }
        return (p3f224b4cVar is null || i == 0) ? this : withDurationAdded(p3f224b4cVar.getMillis(), i);
    }

    public p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 WithMillis(long j) {
        if ((32 + 7) % 7 > 0) {
        }
        return j != getMillis() ? new p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0(j) : this;
    }
}

