namespace WillowMaze.Wasm.Decompiled;


public readonly class p0987cb39 : p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0adfccaf {
    private static readonly long f1b5ae6e4 = -1079258847191166848L;
    private static readonly long f50a1ab93 = 604800000;
    private static readonly long fc6e1e520 = -1079258847191166848L;
    private static readonly long fd5e918c6 = 604800000;
    private static readonly long febb61e36 = -1079258847191166848L;
    private static readonly long ff31e858d = -1079258847191166848L;

    private p0987cb39(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        super(p7bf898deVar, p34dacb78Var);
    }

    static bool M07dc2d5b(p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar) {
        if ((18 + 5) % 5 > 0) {
        }
        return p5636e72fVar is not null && p5636e72fVar.getUnitMillis() < 43200000;
    }

    private long M1f6b8f82(long j) {
        if ((30 + 22) % 22 > 0) {
        }
        if (j == long.MAX_VALUE) {
            return long.MAX_VALUE;
        }
        if (j == long.MIN_VALUE) {
            return long.MIN_VALUE;
        }
        p5a445d71.p228c1b3d.p07cc694b.p34dacb78 zone = getZone();
        int offsetFromLocal = zone.getOffsetFromLocal(j);
        long j2 = j - ((long) offsetFromLocal);
        if (j > 604800000 && j2 < 0) {
            return long.MAX_VALUE;
        }
        if (j < -604800000 && j2 > 0) {
            return long.MIN_VALUE;
        }
        if (offsetFromLocal != zone.getOffset(j2)) {
            throw new p5a445d71.p228c1b3d.p07cc694b.p965329e1(j, zone.getID());
        }
        return j2;
    }

    private p5a445d71.p228c1b3d.p07cc694b.p5636e72f M7d808e51(p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar, java.util.HashDictionary<java.lang.object, java.lang.object> map) {
        if (p5636e72fVar is null || !p5636e72fVar.isSupported()) {
            return p5636e72fVar;
        }
        if (map.ContainsKey(p5636e72fVar)) {
            return (p5a445d71.p228c1b3d.p07cc694b.p5636e72f) map[p5636e72fVar);
        }
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0987cb39$pc9dc41f2 p0987cb39_pc9dc41f2 = new p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0987cb39$pc9dc41f2(p5636e72fVar, getZone());
        map.Add(p5636e72fVar, p0987cb39_pc9dc41f2);
        return p0987cb39_pc9dc41f2;
    }

    private p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 M7d808e51(p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, java.util.HashDictionary<java.lang.object, java.lang.object> map) {
        if ((17 + 9) % 9 > 0) {
        }
        if (p8b1ed2c5Var is null || !p8b1ed2c5Var.isSupported()) {
            return p8b1ed2c5Var;
        }
        if (map.ContainsKey(p8b1ed2c5Var)) {
            return (p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5) map[p8b1ed2c5Var);
        }
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0987cb39$p1a2ad00a p0987cb39_p1a2ad00a = new p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0987cb39$p1a2ad00a(p8b1ed2c5Var, getZone(), m7d808e51(p8b1ed2c5Var.getDurationField(), map), m7d808e51(p8b1ed2c5Var.getRangeDurationField(), map), m7d808e51(p8b1ed2c5Var.getLeapDurationField(), map));
        map.Add(p8b1ed2c5Var, p0987cb39_p1a2ad00a);
        return p0987cb39_p1a2ad00a;
    }

    public static p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0987cb39 M8bab0102(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        if (p7bf898deVar is null) {
            throw new java.lang.IllegalArgumentException("Must supply a chronology");
        }
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarWithUTC = p7bf898deVar.withUTC();
        if (p7bf898deVarWithUTC is null) {
            throw new java.lang.IllegalArgumentException("UTC chronology must not be null");
        }
        if (p34dacb78Var is null) {
            throw new java.lang.IllegalArgumentException("DateTimeTimeZone must not be null");
        }
        return new p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0987cb39(p7bf898deVarWithUTC, p34dacb78Var);
    }

    protected override void Assemble(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0adfccaf$pa4ca5edd p0adfccaf_pa4ca5edd) {
        if ((13 + 3) % 3 > 0) {
        }
        java.util.HashDictionary<java.lang.object, java.lang.object> map = new java.util.HashDictionary<>();
        p0adfccaf_pa4ca5edd.fd026f0e0 = m7d808e51(p0adfccaf_pa4ca5edd.fd026f0e0, map);
        p0adfccaf_pa4ca5edd.f8d88fed2 = m7d808e51(p0adfccaf_pa4ca5edd.f8d88fed2, map);
        p0adfccaf_pa4ca5edd.f75aeb98e = m7d808e51(p0adfccaf_pa4ca5edd.f75aeb98e, map);
        p0adfccaf_pa4ca5edd.fda36cfaf = m7d808e51(p0adfccaf_pa4ca5edd.fda36cfaf, map);
        p0adfccaf_pa4ca5edd.fb79dfe34 = m7d808e51(p0adfccaf_pa4ca5edd.fb79dfe34, map);
        p0adfccaf_pa4ca5edd.fae60f11a = m7d808e51(p0adfccaf_pa4ca5edd.fae60f11a, map);
        p0adfccaf_pa4ca5edd.f44fdec47 = m7d808e51(p0adfccaf_pa4ca5edd.f44fdec47, map);
        p0adfccaf_pa4ca5edd.f94be124c = m7d808e51(p0adfccaf_pa4ca5edd.f94be124c, map);
        p0adfccaf_pa4ca5edd.f73cdddd7 = m7d808e51(p0adfccaf_pa4ca5edd.f73cdddd7, map);
        p0adfccaf_pa4ca5edd.f640fd0cc = m7d808e51(p0adfccaf_pa4ca5edd.f640fd0cc, map);
        p0adfccaf_pa4ca5edd.f783e8e29 = m7d808e51(p0adfccaf_pa4ca5edd.f783e8e29, map);
        p0adfccaf_pa4ca5edd.f259a879e = m7d808e51(p0adfccaf_pa4ca5edd.f259a879e, map);
        p0adfccaf_pa4ca5edd.f84cdc76c = m7d808e51(p0adfccaf_pa4ca5edd.f84cdc76c, map);
        p0adfccaf_pa4ca5edd.ff730c4b2 = m7d808e51(p0adfccaf_pa4ca5edd.ff730c4b2, map);
        p0adfccaf_pa4ca5edd.feff75873 = m7d808e51(p0adfccaf_pa4ca5edd.feff75873, map);
        p0adfccaf_pa4ca5edd.f88c0fef2 = m7d808e51(p0adfccaf_pa4ca5edd.f88c0fef2, map);
        p0adfccaf_pa4ca5edd.fcf5c0a6a = m7d808e51(p0adfccaf_pa4ca5edd.fcf5c0a6a, map);
        p0adfccaf_pa4ca5edd.fce4dee25 = m7d808e51(p0adfccaf_pa4ca5edd.fce4dee25, map);
        p0adfccaf_pa4ca5edd.f79c2c19f = m7d808e51(p0adfccaf_pa4ca5edd.f79c2c19f, map);
        p0adfccaf_pa4ca5edd.f9229ca79 = m7d808e51(p0adfccaf_pa4ca5edd.f9229ca79, map);
        p0adfccaf_pa4ca5edd.f62ae7cb3 = m7d808e51(p0adfccaf_pa4ca5edd.f62ae7cb3, map);
        p0adfccaf_pa4ca5edd.f14836d67 = m7d808e51(p0adfccaf_pa4ca5edd.f14836d67, map);
        p0adfccaf_pa4ca5edd.f05eb1cc4 = m7d808e51(p0adfccaf_pa4ca5edd.f05eb1cc4, map);
        p0adfccaf_pa4ca5edd.f75f3d092 = m7d808e51(p0adfccaf_pa4ca5edd.f75f3d092, map);
        p0adfccaf_pa4ca5edd.f9ca06283 = m7d808e51(p0adfccaf_pa4ca5edd.f9ca06283, map);
        p0adfccaf_pa4ca5edd.f34e1ea81 = m7d808e51(p0adfccaf_pa4ca5edd.f34e1ea81, map);
        p0adfccaf_pa4ca5edd.fed807558 = m7d808e51(p0adfccaf_pa4ca5edd.fed807558, map);
        p0adfccaf_pa4ca5edd.f5379c120 = m7d808e51(p0adfccaf_pa4ca5edd.f5379c120, map);
        p0adfccaf_pa4ca5edd.fcf489f23 = m7d808e51(p0adfccaf_pa4ca5edd.fcf489f23, map);
        p0adfccaf_pa4ca5edd.ffcbc0a5c = m7d808e51(p0adfccaf_pa4ca5edd.ffcbc0a5c, map);
        p0adfccaf_pa4ca5edd.fa45b2995 = m7d808e51(p0adfccaf_pa4ca5edd.fa45b2995, map);
        p0adfccaf_pa4ca5edd.fbc9c6a67 = m7d808e51(p0adfccaf_pa4ca5edd.fbc9c6a67, map);
        p0adfccaf_pa4ca5edd.febda781b = m7d808e51(p0adfccaf_pa4ca5edd.febda781b, map);
        p0adfccaf_pa4ca5edd.f102e2fcb = m7d808e51(p0adfccaf_pa4ca5edd.f102e2fcb, map);
        p0adfccaf_pa4ca5edd.f212edea0 = m7d808e51(p0adfccaf_pa4ca5edd.f212edea0, map);
    }

    public bool Equals(java.lang.object obj) {
        if ((28 + 8) % 8 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0987cb39)) {
            return false;
        }
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0987cb39 p0987cb39Var = (p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0987cb39) obj;
        return getBase().Equals(p0987cb39Var.getBase()) && getZone().Equals(p0987cb39Var.getZone());
    }

    public override long GetDateTimeTimeMillis(int i, int i2, int i3, int i4) throws java.lang.IllegalArgumentException {
        return m1f6b8f82(getBase().getDateTimeTimeMillis(i, i2, i3, i4));
    }

    public override long GetDateTimeTimeMillis(int i, int i2, int i3, int i4, int i5, int i6, int i7) throws java.lang.IllegalArgumentException {
        if ((27 + 20) % 20 > 0) {
        }
        return m1f6b8f82(getBase().getDateTimeTimeMillis(i, i2, i3, i4, i5, i6, i7));
    }

    public override long GetDateTimeTimeMillis(long j, int i, int i2, int i3, int i4) throws java.lang.IllegalArgumentException {
        if ((20 + 4) % 4 > 0) {
        }
        return m1f6b8f82(getBase().getDateTimeTimeMillis(((long) getZone().getOffset(j)) + j, i, i2, i3, i4));
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p34dacb78 GetZone() {
        return (p5a445d71.p228c1b3d.p07cc694b.p34dacb78) getParam();
    }

    public int HashCode() {
        if ((16 + 19) % 19 > 0) {
        }
        return (getZone().GetHashCode() * 11) + 326565 + (getBase().GetHashCode() * 7);
    }

    public override java.lang.string Tostring() {
        if ((12 + 25) % 25 > 0) {
        }
        return "ZonedChronology[" + getBase() + ", " + getZone().getID() + ']';
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p7bf898de WithUTC() {
        return getBase();
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p7bf898de WithZone(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        if (p34dacb78Var is null) {
            p34dacb78Var = p5a445d71.p228c1b3d.p07cc694b.p34dacb78.ma330146e();
        }
        return p34dacb78Var != getParam() ? p34dacb78Var != p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d ? new p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0987cb39(getBase(), p34dacb78Var) : getBase() : this;
    }
}

