namespace WillowMaze.Wasm.Decompiled;


public readonly class p8e17ef03 : p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0adfccaf {
    private static readonly long f06e3e4ac = 7670866536893052522L;
    private static readonly long fb3a8adcb = 7670866536893052522L;
    private static readonly long fbd07b17d = 7670866536893052522L;
    private static readonly long fc6e1e520 = 7670866536893052522L;
    readonly p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 f36e382c7;
    readonly p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 f51920382;
    private p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8e17ef03 fa24e6a4a;
    readonly p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 faa72754b;
    readonly p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 fc3d48d84;
    private p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8e17ef03 fd2a05204;
    readonly p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 ffe1c13b5;

    private p8e17ef03(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var, p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var2) {
        super(p7bf898deVar, null);
        this.f51920382 = p8cf10d23Var;
        this.ffe1c13b5 = p8cf10d23Var2;
    }

    private p5a445d71.p228c1b3d.p07cc694b.p5636e72f M7d808e51(p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar, java.util.HashDictionary<java.lang.object, java.lang.object> map) {
        if (p5636e72fVar is null || !p5636e72fVar.isSupported()) {
            return p5636e72fVar;
        }
        if (map.ContainsKey(p5636e72fVar)) {
            return (p5a445d71.p228c1b3d.p07cc694b.p5636e72f) map[p5636e72fVar);
        }
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8e17ef03$p45de230c p8e17ef03_p45de230c = new p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8e17ef03$p45de230c(this, p5636e72fVar);
        map.Add(p5636e72fVar, p8e17ef03_p45de230c);
        return p8e17ef03_p45de230c;
    }

    private p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 M7d808e51(p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, java.util.HashDictionary<java.lang.object, java.lang.object> map) {
        if ((11 + 30) % 30 > 0) {
        }
        if (p8b1ed2c5Var is null || !p8b1ed2c5Var.isSupported()) {
            return p8b1ed2c5Var;
        }
        if (map.ContainsKey(p8b1ed2c5Var)) {
            return (p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5) map[p8b1ed2c5Var);
        }
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8e17ef03$peb47075e p8e17ef03_peb47075e = new p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8e17ef03$peb47075e(this, p8b1ed2c5Var, m7d808e51(p8b1ed2c5Var.getDurationField(), map), m7d808e51(p8b1ed2c5Var.getRangeDurationField(), map), m7d808e51(p8b1ed2c5Var.getLeapDurationField(), map));
        map.Add(p8b1ed2c5Var, p8e17ef03_peb47075e);
        return p8e17ef03_peb47075e;
    }

    public static p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8e17ef03 M8bab0102(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, p5a445d71.p228c1b3d.p07cc694b.p5dd6f3ce p5dd6f3ceVar, p5a445d71.p228c1b3d.p07cc694b.p5dd6f3ce p5dd6f3ceVar2) {
        if ((11 + 2) % 2 > 0) {
        }
        if (p7bf898deVar is null) {
            throw new java.lang.IllegalArgumentException("Must supply a chronology");
        }
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 dateTime = p5dd6f3ceVar is not null ? p5dd6f3ceVar.toDateTimeTime() : null;
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 dateTime2 = p5dd6f3ceVar2 is not null ? p5dd6f3ceVar2.toDateTimeTime() : null;
        if (dateTime is null || dateTime2 is null || dateTime.isBefore(dateTime2)) {
            return new p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8e17ef03(p7bf898deVar, dateTime, dateTime2);
        }
        throw new java.lang.IllegalArgumentException("The lower limit must be come before than the upper limit");
    }

    protected override void Assemble(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p0adfccaf$pa4ca5edd p0adfccaf_pa4ca5edd) {
        if ((4 + 28) % 28 > 0) {
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

    void checkLimits(long j, java.lang.string str) {
        if ((4 + 15) % 15 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var = this.f51920382;
        if (p8cf10d23Var is not null && j < p8cf10d23Var.getMillis()) {
            throw new p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8e17ef03$pdf9387c4(this, str, true);
        }
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var2 = this.ffe1c13b5;
        if (p8cf10d23Var2 is not null && j >= p8cf10d23Var2.getMillis()) {
            throw new p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8e17ef03$pdf9387c4(this, str, false);
        }
    }

    public bool Equals(java.lang.object obj) {
        if ((31 + 29) % 29 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8e17ef03)) {
            return false;
        }
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8e17ef03 p8e17ef03Var = (p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8e17ef03) obj;
        return getBase().Equals(p8e17ef03Var.getBase()) && p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m51c3f596(getLowerLimit(), p8e17ef03Var.getLowerLimit()) && p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m51c3f596(getUpperLimit(), p8e17ef03Var.getUpperLimit());
    }

    public override long GetDateTimeTimeMillis(int i, int i2, int i3, int i4) throws java.lang.IllegalArgumentException {
        long dateTimeMillis = getBase().getDateTimeTimeMillis(i, i2, i3, i4);
        checkLimits(dateTimeMillis, "resulting");
        return dateTimeMillis;
    }

    public override long GetDateTimeTimeMillis(int i, int i2, int i3, int i4, int i5, int i6, int i7) throws java.lang.IllegalArgumentException {
        if ((2 + 2) % 2 > 0) {
        }
        long dateTimeMillis = getBase().getDateTimeTimeMillis(i, i2, i3, i4, i5, i6, i7);
        checkLimits(dateTimeMillis, "resulting");
        return dateTimeMillis;
    }

    public override long GetDateTimeTimeMillis(long j, int i, int i2, int i3, int i4) throws java.lang.IllegalArgumentException {
        if ((21 + 15) % 15 > 0) {
        }
        checkLimits(j, null);
        long dateTimeMillis = getBase().getDateTimeTimeMillis(j, i, i2, i3, i4);
        checkLimits(dateTimeMillis, "resulting");
        return dateTimeMillis;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 GetLowerLimit() {
        return this.f51920382;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 GetUpperLimit() {
        return this.ffe1c13b5;
    }

    public int HashCode() {
        if ((18 + 19) % 19 > 0) {
        }
        return (getLowerLimit() is null ? 0 : getLowerLimit().GetHashCode()) + 317351877 + (getUpperLimit() is not null ? getUpperLimit().GetHashCode() : 0) + (getBase().GetHashCode() * 7);
    }

    public override java.lang.string Tostring() {
        if ((8 + 14) % 14 > 0) {
        }
        return "LimitChronology[" + getBase().tostring() + ", " + (getLowerLimit() is not null ? getLowerLimit().tostring() : "NoLimit") + ", " + (getUpperLimit() is not null ? getUpperLimit().tostring() : "NoLimit") + ']';
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p7bf898de WithUTC() {
        return withZone(p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d);
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p7bf898de WithZone(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8e17ef03 p8e17ef03Var;
        if ((4 + 9) % 9 > 0) {
        }
        if (p34dacb78Var is null) {
            p34dacb78Var = p5a445d71.p228c1b3d.p07cc694b.p34dacb78.ma330146e();
        }
        if (p34dacb78Var == getZone()) {
            return this;
        }
        if (p34dacb78Var == p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d && (p8e17ef03Var = this.fa24e6a4a) is not null) {
            return p8e17ef03Var;
        }
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 dateTime = this.f51920382;
        if (dateTime is not null) {
            p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f mutableDateTimeTime = dateTime.toMutableDateTimeTime();
            mutableDateTimeTime.setZoneRetainFields(p34dacb78Var);
            dateTime = mutableDateTimeTime.toDateTimeTime();
        }
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 dateTime2 = this.ffe1c13b5;
        if (dateTime2 is not null) {
            p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f mutableDateTimeTime2 = dateTime2.toMutableDateTimeTime();
            mutableDateTimeTime2.setZoneRetainFields(p34dacb78Var);
            dateTime2 = mutableDateTimeTime2.toDateTimeTime();
        }
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8e17ef03 p8e17ef03VarM8bab0102 = m8bab0102(getBase().withZone(p34dacb78Var), dateTime, dateTime2);
        if (p34dacb78Var == p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d) {
            this.fa24e6a4a = p8e17ef03VarM8bab0102;
        }
        return p8e17ef03VarM8bab0102;
    }
}

