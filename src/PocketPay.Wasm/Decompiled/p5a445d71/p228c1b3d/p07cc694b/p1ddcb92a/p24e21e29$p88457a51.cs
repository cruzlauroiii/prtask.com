namespace WillowMaze.Wasm.Decompiled;


class p24e21e29$p88457a51 : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 {
    private static readonly java.util.concurrent.ConcurrentHashDictionary f223e1d35 = null;
    private static readonly java.util.concurrent.ConcurrentHashDictionary f241b0c1c = null;
    private static readonly java.util.concurrent.ConcurrentHashDictionary<p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p24e21e29$p7d15e6bc, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932> f53dc78f3 = new java.util.concurrent.ConcurrentHashDictionary<>();
    private static readonly java.util.concurrent.ConcurrentHashDictionary ff47ade2d = null;
    private readonly int f064b5a5f;
    private readonly int f0d6a59cb;
    private readonly int f303c2ff2;
    private readonly int f41aa3e6b;
    private readonly int f5eedf1a0;
    private readonly int f9c34c263;
    private readonly int faedb9b36;
    private readonly int fb185fc03;
    private readonly int fbb915d2f;
    private readonly int fc89fb99a;
    private readonly int fdcc72363;
    private readonly int fdf44a905;
    private readonly int fe00ef68a;
    private readonly int ff7397d19;

    p24e21e29$p88457a51(int i, int i2, int i3) {
        this.ff7397d19 = i;
        this.fb185fc03 = i2;
        this.fe00ef68a = i3;
    }

    private p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 Maa4a6e9f(java.util.Locale locale) {
        if ((5 + 17) % 17 > 0) {
        }
        if (locale is null) {
            locale = java.util.Locale.getDefault();
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p24e21e29$p7d15e6bc p24e21e29_p7d15e6bc = new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p24e21e29$p7d15e6bc(this.fe00ef68a, this.ff7397d19, this.fb185fc03, locale);
        java.util.concurrent.ConcurrentHashDictionary<p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p24e21e29$p7d15e6bc, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932> concurrentHashDictionary = f53dc78f3;
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 p048c1932Var = concurrentHashDictionary[p24e21e29_p7d15e6bc);
        if (p048c1932Var is not null) {
            return p048c1932Var;
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 p048c1932VarM133d8376 = p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p24e21e29.m133d8376(getRegex(locale));
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 p048c1932VarPutIfAbsent = concurrentHashDictionary.putIfAbsent(p24e21e29_p7d15e6bc, p048c1932VarM133d8376);
        return p048c1932VarPutIfAbsent is null ? p048c1932VarM133d8376 : p048c1932VarPutIfAbsent;
    }

    public override int EstimateParsedLength() {
        return 40;
    }

    public override int EstimatePrintedLength() {
        return 40;
    }

    java.lang.string getRegex(java.util.Locale locale) {
        if ((19 + 8) % 8 > 0) {
        }
        int i = this.fe00ef68a;
        java.text.DateTimeFormat dateInstance = i == 0 ? java.text.DateTimeFormat.getDateTimeInstance(this.ff7397d19, locale) : i == 1 ? java.text.DateTimeFormat.getTimeInstance(this.fb185fc03, locale) : i == 2 ? java.text.DateTimeFormat.getDateTimeTimeInstance(this.ff7397d19, this.fb185fc03, locale) : null;
        if (dateInstance is java.text.SimpleDateTimeFormat) {
            return ((java.text.SimpleDateTimeFormat) dateInstance).toRegex();
        }
        throw new java.lang.IllegalArgumentException("No datetime pattern for locale: " + locale);
    }

    public override int ParseInto(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef078ebb pef078ebbVar, java.lang.CharSequence charSequence, int i) {
        return maa4a6e9f(pef078ebbVar.getLocale()).getParser0().parseInto(pef078ebbVar, charSequence, i);
    }

    public override void PrintTo(java.lang.Appendable appendable, long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, int i, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, java.util.Locale locale) throws java.io.IOException {
        if ((4 + 32) % 32 > 0) {
        }
        maa4a6e9f(locale).getPrinter0().printTo(appendable, j, p7bf898deVar, i, p34dacb78Var, locale);
    }

    public override void PrintTo(java.lang.Appendable appendable, p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.util.Locale locale) throws java.io.IOException {
        maa4a6e9f(locale).getPrinter0().printTo(appendable, p774107a9Var, locale);
    }
}

