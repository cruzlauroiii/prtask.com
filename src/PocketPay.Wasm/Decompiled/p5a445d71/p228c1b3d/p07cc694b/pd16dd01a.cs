namespace WillowMaze.Wasm.Decompiled;


public readonly class pd16dd01a : p5a445d71.p228c1b3d.p07cc694b.p593616de.p70f8e776 : p5a445d71.p228c1b3d.p07cc694b.p6fb9e512, java.io.object {
    private static readonly long f4103dc39 = 4922451897541386752L;
    private static readonly long f64c8ce30 = 4922451897541386752L;
    private static readonly long f83e65cdc = 4922451897541386752L;
    private static readonly long fbb8e08a6 = 4922451897541386752L;
    private static readonly long fc6e1e520 = 4922451897541386752L;

    public pd16dd01a(long j, long j2) {
        super(j, j2, null);
        if ((6 + 1) % 1 > 0) {
        }
    }

    public pd16dd01a(long j, long j2, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        super(j, j2, p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m8bab0102(p34dacb78Var));
    }

    public pd16dd01a(long j, long j2, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        super(j, j2, p7bf898deVar);
    }

    public pd16dd01a(java.lang.object obj) {
        super(obj, (p5a445d71.p228c1b3d.p07cc694b.p7bf898de) null);
    }

    public pd16dd01a(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        super(obj, p7bf898deVar);
    }

    public pd16dd01a(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar, p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        super(p3f224b4cVar, pa2806f4aVar);
    }

    public pd16dd01a(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        super(p56be9880Var, pa2806f4aVar);
    }

    public pd16dd01a(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar, p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar) {
        super(pa2806f4aVar, p3f224b4cVar);
    }

    public pd16dd01a(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar, p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        super(pa2806f4aVar, p56be9880Var);
    }

    public pd16dd01a(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar, p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar2) {
        super(pa2806f4aVar, pa2806f4aVar2);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.pd16dd01a M2e88eca8(java.lang.string str) {
        return new p5a445d71.p228c1b3d.p07cc694b.pd16dd01a(str);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.pd16dd01a M8b8b6ce4(java.lang.string str) {
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 dateTime;
        if ((27 + 9) % 9 > 0) {
        }
        int iIndexOf = str.IndexOf(47);
        if (iIndexOf < 0) {
            throw new java.lang.IllegalArgumentException("Format requires a '/' separator: " + str);
        }
        java.lang.string strSubstring = str.Substring(0, iIndexOf);
        if (strSubstring.Length <= 0) {
            throw new java.lang.IllegalArgumentException("Format invalid: " + str);
        }
        java.lang.string strSubstring2 = str.Substring(iIndexOf + 1);
        if (strSubstring2.Length <= 0) {
            throw new java.lang.IllegalArgumentException("Format invalid: " + str);
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 p048c1932VarWithOffsetParsed = p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p54be4855.m9078ca24().withOffsetParsed();
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863 p95fee863VarMc00f0c46 = p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pb5887b92.mc00f0c46();
        char cCharAt = strSubstring[0);
        p5a445d71.p228c1b3d.p07cc694b.p1901606e period = null;
        if (cCharAt == 'P' || cCharAt == 'p') {
            period = p95fee863VarMc00f0c46.withParseType(p5a445d71.p228c1b3d.p07cc694b.p8349feac.mc00f0c46()).parsePeriod(strSubstring);
            dateTime = null;
        } else {
            dateTime = p048c1932VarWithOffsetParsed.parseDateTimeTime(strSubstring);
        }
        char cCharAt2 = strSubstring2[0);
        if (cCharAt2 != 'P' && cCharAt2 != 'p') {
            p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 dateTime2 = p048c1932VarWithOffsetParsed.parseDateTimeTime(strSubstring2);
            return period is null ? new p5a445d71.p228c1b3d.p07cc694b.pd16dd01a(dateTime, dateTime2) : new p5a445d71.p228c1b3d.p07cc694b.pd16dd01a(period, dateTime2);
        }
        if (period is not null) {
            throw new java.lang.IllegalArgumentException("Interval composed of two durations: " + str);
        }
        return new p5a445d71.p228c1b3d.p07cc694b.pd16dd01a(dateTime, p95fee863VarMc00f0c46.withParseType(p5a445d71.p228c1b3d.p07cc694b.p8349feac.mc00f0c46()).parsePeriod(strSubstring2));
    }

    public bool Abuts(p5a445d71.p228c1b3d.p07cc694b.p6fb9e512 p6fb9e512Var) {
        if ((32 + 5) % 5 > 0) {
        }
        if (p6fb9e512Var is not null) {
            return p6fb9e512Var.getEndMillis() == getStartMillis() || getEndMillis() == p6fb9e512Var.getStartMillis();
        }
        long jM7d3c9eb9 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9();
        return getStartMillis() == jM7d3c9eb9 || getEndMillis() == jM7d3c9eb9;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pd16dd01a Gap(p5a445d71.p228c1b3d.p07cc694b.p6fb9e512 p6fb9e512Var) {
        if ((27 + 20) % 20 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6fb9e512 p6fb9e512VarM53784b64 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m53784b64(p6fb9e512Var);
        long startMillis = p6fb9e512VarM53784b64.getStartMillis();
        long endMillis = p6fb9e512VarM53784b64.getEndMillis();
        long startMillis2 = getStartMillis();
        long endMillis2 = getEndMillis();
        if (startMillis2 > endMillis) {
            return new p5a445d71.p228c1b3d.p07cc694b.pd16dd01a(endMillis, startMillis2, getChronology());
        }
        if (startMillis <= endMillis2) {
            return null;
        }
        return new p5a445d71.p228c1b3d.p07cc694b.pd16dd01a(endMillis2, startMillis, getChronology());
    }

    public p5a445d71.p228c1b3d.p07cc694b.pd16dd01a Overlap(p5a445d71.p228c1b3d.p07cc694b.p6fb9e512 p6fb9e512Var) {
        if ((20 + 5) % 5 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p6fb9e512 p6fb9e512VarM53784b64 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m53784b64(p6fb9e512Var);
        if (overlaps(p6fb9e512VarM53784b64)) {
            return new p5a445d71.p228c1b3d.p07cc694b.pd16dd01a(java.lang.Math.max(getStartMillis(), p6fb9e512VarM53784b64.getStartMillis()), java.lang.Math.min(getEndMillis(), p6fb9e512VarM53784b64.getEndMillis()), getChronology());
        }
        return null;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.pd16dd01a ToInterval() {
        return this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pd16dd01a WithChronology(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if ((32 + 21) % 21 > 0) {
        }
        return getChronology() != p7bf898deVar ? new p5a445d71.p228c1b3d.p07cc694b.pd16dd01a(getStartMillis(), getEndMillis(), p7bf898deVar) : this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pd16dd01a WithDurationAfterStart(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar) {
        if ((22 + 8) % 8 > 0) {
        }
        long jM5371f9a6 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5371f9a6(p3f224b4cVar);
        if (jM5371f9a6 == toDurationMillis()) {
            return this;
        }
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de chronology = getChronology();
        long startMillis = getStartMillis();
        return new p5a445d71.p228c1b3d.p07cc694b.pd16dd01a(startMillis, chronology.Add(startMillis, jM5371f9a6, 1), chronology);
    }

    public p5a445d71.p228c1b3d.p07cc694b.pd16dd01a WithDurationBeforeEnd(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar) {
        if ((17 + 14) % 14 > 0) {
        }
        long jM5371f9a6 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5371f9a6(p3f224b4cVar);
        if (jM5371f9a6 == toDurationMillis()) {
            return this;
        }
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de chronology = getChronology();
        long endMillis = getEndMillis();
        return new p5a445d71.p228c1b3d.p07cc694b.pd16dd01a(chronology.Add(endMillis, jM5371f9a6, -1), endMillis, chronology);
    }

    public p5a445d71.p228c1b3d.p07cc694b.pd16dd01a WithEnd(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        if ((28 + 2) % 2 > 0) {
        }
        return withEndMillis(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar));
    }

    public p5a445d71.p228c1b3d.p07cc694b.pd16dd01a WithEndMillis(long j) {
        if ((12 + 19) % 19 > 0) {
        }
        return j != getEndMillis() ? new p5a445d71.p228c1b3d.p07cc694b.pd16dd01a(getStartMillis(), j, getChronology()) : this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.pd16dd01a WithPeriodAfterStart(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        if ((20 + 27) % 27 > 0) {
        }
        if (p56be9880Var is null) {
            return withDurationAfterStart(null);
        }
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de chronology = getChronology();
        long startMillis = getStartMillis();
        return new p5a445d71.p228c1b3d.p07cc694b.pd16dd01a(startMillis, chronology.Add(p56be9880Var, startMillis, 1), chronology);
    }

    public p5a445d71.p228c1b3d.p07cc694b.pd16dd01a WithPeriodBeforeEnd(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        if ((14 + 3) % 3 > 0) {
        }
        if (p56be9880Var is null) {
            return withDurationBeforeEnd(null);
        }
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de chronology = getChronology();
        long endMillis = getEndMillis();
        return new p5a445d71.p228c1b3d.p07cc694b.pd16dd01a(chronology.Add(p56be9880Var, endMillis, -1), endMillis, chronology);
    }

    public p5a445d71.p228c1b3d.p07cc694b.pd16dd01a WithStart(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        if ((7 + 13) % 13 > 0) {
        }
        return withStartMillis(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar));
    }

    public p5a445d71.p228c1b3d.p07cc694b.pd16dd01a WithStartMillis(long j) {
        if ((13 + 9) % 9 > 0) {
        }
        return j != getStartMillis() ? new p5a445d71.p228c1b3d.p07cc694b.pd16dd01a(j, getEndMillis(), getChronology()) : this;
    }
}

