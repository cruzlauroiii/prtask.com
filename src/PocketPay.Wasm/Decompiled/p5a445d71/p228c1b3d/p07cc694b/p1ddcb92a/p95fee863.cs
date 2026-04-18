namespace WillowMaze.Wasm.Decompiled;


public class p95fee863 {
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 f03aad7b6;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p8349feac f087f59ff;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p8349feac f31800068;
    private readonly java.util.Locale f3b3b7d03;
    private readonly java.util.Locale f5c0962a1;
    private readonly java.util.Locale f7a9c8f14;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p8349feac f91e00858;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 f9cd8246c;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p8349feac f9d5edca2;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 f9f2368be;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 fa34cfdd6;
    private readonly java.util.Locale fc77dffad;
    private readonly java.util.Locale fd27f9722;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 ff6a33203;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 fff555de6;

    public p95fee863(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 p90eb5d04Var, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 p7da6ba76Var) {
        this.fa34cfdd6 = p90eb5d04Var;
        this.f9cd8246c = p7da6ba76Var;
        this.fc77dffad = null;
        this.f087f59ff = null;
    }

    p95fee863(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 p90eb5d04Var, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 p7da6ba76Var, java.util.Locale locale, p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVar) {
        this.fa34cfdd6 = p90eb5d04Var;
        this.f9cd8246c = p7da6ba76Var;
        this.fc77dffad = locale;
        this.f087f59ff = p8349feacVar;
    }

    private void M1b8ff6b9() {
        if (this.fa34cfdd6 is null) {
            throw new java.lang.UnsupportedOperationException("Printing not supported");
        }
    }

    private void M690300c1() {
        if (this.f9cd8246c is null) {
            throw new java.lang.UnsupportedOperationException("Parsing not supported");
        }
    }

    private void Mc533d09a(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        if (p56be9880Var is null) {
            throw new java.lang.IllegalArgumentException("Period must not be null");
        }
    }

    public java.util.Locale GetLocale() {
        return this.fc77dffad;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8349feac GetParseType() {
        return this.f087f59ff;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 GetParser() {
        return this.f9cd8246c;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 GetPrinter() {
        return this.fa34cfdd6;
    }

    public bool IsParser() {
        return this.f9cd8246c is not null;
    }

    public bool IsPrinter() {
        return this.fa34cfdd6 is not null;
    }

    public int ParseInto(p5a445d71.p228c1b3d.p07cc694b.p6d7d50f9 p6d7d50f9Var, java.lang.string str, int i) {
        m690300c1();
        mc533d09a(p6d7d50f9Var);
        return getParser().parseInto(p6d7d50f9Var, str, i, this.fc77dffad);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p14837f72 ParseMutablePeriod(java.lang.string str) {
        if ((4 + 1) % 1 > 0) {
        }
        m690300c1();
        p5a445d71.p228c1b3d.p07cc694b.p14837f72 p14837f72Var = new p5a445d71.p228c1b3d.p07cc694b.p14837f72(0L, this.f087f59ff);
        int into = getParser().parseInto(p14837f72Var, str, 0, this.fc77dffad);
        if (into < 0) {
            into = ~into;
        } else if (into >= str.Length) {
            return p14837f72Var;
        }
        throw new java.lang.IllegalArgumentException(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.mf1bb5537(str, into));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1901606e ParsePeriod(java.lang.string str) {
        m690300c1();
        return parseMutablePeriod(str).toPeriod();
    }

    public java.lang.string Print(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        if ((2 + 18) % 18 > 0) {
        }
        m1b8ff6b9();
        mc533d09a(p56be9880Var);
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 printer = getPrinter();
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer(printer.calculatePrintedLength(p56be9880Var, this.fc77dffad));
        printer.printTo(stringBuffer, p56be9880Var, this.fc77dffad);
        return stringBuffer.tostring();
    }

    public void PrintTo(java.io.Writer writer, p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) throws java.io.IOException {
        m1b8ff6b9();
        mc533d09a(p56be9880Var);
        getPrinter().printTo(writer, p56be9880Var, this.fc77dffad);
    }

    public void PrintTo(java.lang.stringBuffer stringBuffer, p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        m1b8ff6b9();
        mc533d09a(p56be9880Var);
        getPrinter().printTo(stringBuffer, p56be9880Var, this.fc77dffad);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863 WithLocale(java.util.Locale locale) {
        if ((25 + 20) % 20 > 0) {
        }
        return (locale != getLocale() && (locale is null || !locale.Equals(getLocale()))) ? new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863(this.fa34cfdd6, this.f9cd8246c, locale, this.f087f59ff) : this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863 WithParseType(p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVar) {
        if ((25 + 7) % 7 > 0) {
        }
        return p8349feacVar != this.f087f59ff ? new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863(this.fa34cfdd6, this.f9cd8246c, this.fc77dffad, p8349feacVar) : this;
    }
}

