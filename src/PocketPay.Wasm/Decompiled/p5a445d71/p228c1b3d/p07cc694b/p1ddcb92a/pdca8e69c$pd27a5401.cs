namespace WillowMaze.Wasm.Decompiled;


class pdca8e69c$pd27a5401 : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 {
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863 f33ea6730;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863 f3e27b127;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863 fbfa1d0ff;

    pdca8e69c$pd27a5401(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863 p95fee863Var) {
        this.fbfa1d0ff = p95fee863Var;
    }

    private p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p90eb5d04 M13e816d9(java.util.Locale locale) {
        return (locale is null || locale.Equals(this.fbfa1d0ff.getLocale())) ? this.fbfa1d0ff.getPrinter() : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pdca8e69c.ma28f0111(locale).getPrinter();
    }

    private p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p7da6ba76 Ma08d072a(java.util.Locale locale) {
        return (locale is null || locale.Equals(this.fbfa1d0ff.getLocale())) ? this.fbfa1d0ff.getParser() : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pdca8e69c.ma28f0111(locale).getParser();
    }

    public override int CalculatePrintedLength(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, java.util.Locale locale) {
        return m13e816d9(locale).calculatePrintedLength(p56be9880Var, locale);
    }

    public override int CountFieldsToPrint(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, int i, java.util.Locale locale) {
        return m13e816d9(locale).countFieldsToPrint(p56be9880Var, i, locale);
    }

    public override int ParseInto(p5a445d71.p228c1b3d.p07cc694b.p6d7d50f9 p6d7d50f9Var, java.lang.string str, int i, java.util.Locale locale) {
        return ma08d072a(locale).parseInto(p6d7d50f9Var, str, i, locale);
    }

    public override void PrintTo(java.io.Writer writer, p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, java.util.Locale locale) throws java.io.IOException {
        m13e816d9(locale).printTo(writer, p56be9880Var, locale);
    }

    public override void PrintTo(java.lang.stringBuffer stringBuffer, p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, java.util.Locale locale) {
        m13e816d9(locale).printTo(stringBuffer, p56be9880Var, locale);
    }
}

