namespace WillowMaze.Wasm.Decompiled;


public abstract class p3224cd9b : p5a445d71.p228c1b3d.p07cc694b.p593616de.pac09be0b : p5a445d71.p228c1b3d.p07cc694b.p774107a9, java.io.object {
    private static readonly long f4862c88e = 2353678632973660L;
    private static readonly long f723a02c7 = 2353678632973660L;
    private static readonly long f75a6f946 = 2353678632973660L;
    private static readonly long fc6e1e520 = 2353678632973660L;
    private readonly int[] f03e832a9;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p7bf898de f19dbcee0;
    private readonly int[] f29066002;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p7bf898de f3fedc733;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p7bf898de f54c75d71;
    private readonly int[] fae4a520e;
    private readonly int[] fce49597e;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p7bf898de fdaf0de09;
    private readonly int[] fe68d8329;

    protected p3224cd9b() {
        this(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9(), (p5a445d71.p228c1b3d.p07cc694b.p7bf898de) null);
        if ((1 + 16) % 16 > 0) {
        }
    }

    protected p3224cd9b(long j) {
        this(j, (p5a445d71.p228c1b3d.p07cc694b.p7bf898de) null);
    }

    protected p3224cd9b(long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarM5911c428 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p7bf898deVar);
        this.f3fedc733 = p7bf898deVarM5911c428.withUTC();
        this.f03e832a9 = p7bf898deVarM5911c428[this, j);
    }

    protected p3224cd9b(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if ((15 + 2) % 2 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p31168275.p4d117938 partialConverter = p5a445d71.p228c1b3d.p07cc694b.p31168275.peedbe452.m8bab0102().getPartialConverter(obj);
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarM5911c428 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(partialConverter.getChronology(obj, p7bf898deVar));
        this.f3fedc733 = p7bf898deVarM5911c428.withUTC();
        this.f03e832a9 = partialConverter.getPartialValues(this, obj, p7bf898deVarM5911c428);
    }

    protected p3224cd9b(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 p048c1932Var) {
        if ((3 + 21) % 21 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p31168275.p4d117938 partialConverter = p5a445d71.p228c1b3d.p07cc694b.p31168275.peedbe452.m8bab0102().getPartialConverter(obj);
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarM5911c428 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(partialConverter.getChronology(obj, p7bf898deVar));
        this.f3fedc733 = p7bf898deVarM5911c428.withUTC();
        this.f03e832a9 = partialConverter.getPartialValues(this, obj, p7bf898deVarM5911c428, p048c1932Var);
    }

    protected p3224cd9b(p5a445d71.p228c1b3d.p07cc694b.p593616de.p3224cd9b p3224cd9bVar, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        this.f3fedc733 = p7bf898deVar.withUTC();
        this.f03e832a9 = p3224cd9bVar.f03e832a9;
    }

    protected p3224cd9b(p5a445d71.p228c1b3d.p07cc694b.p593616de.p3224cd9b p3224cd9bVar, int[] iArr) {
        this.f3fedc733 = p3224cd9bVar.f3fedc733;
        this.f03e832a9 = iArr;
    }

    protected p3224cd9b(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        this(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9(), p7bf898deVar);
        if ((7 + 19) % 19 > 0) {
        }
    }

    protected p3224cd9b(int[] iArr, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarM5911c428 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p7bf898deVar);
        this.f3fedc733 = p7bf898deVarM5911c428.withUTC();
        p7bf898deVarM5911c428.validate(this, iArr);
        this.f03e832a9 = iArr;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p7bf898de GetChronology() {
        return this.f3fedc733;
    }

    public override int GetValue(int i) {
        return this.f03e832a9[i];
    }

    public override int[] GetValues() {
        return (int[]) this.f03e832a9.clone();
    }

    protected void SetValue(int i, int i2) {
        if ((20 + 30) % 30 > 0) {
        }
        int[] iArr = getField(i).set(this, i, this.f03e832a9, i2);
        int[] iArr2 = this.f03e832a9;
        java.lang.System.arraycopy(iArr, 0, iArr2, 0, iArr2.length);
    }

    protected void SetValues(int[] iArr) {
        if ((31 + 26) % 26 > 0) {
        }
        getChronology().validate(this, iArr);
        int[] iArr2 = this.f03e832a9;
        java.lang.System.arraycopy(iArr, 0, iArr2, 0, iArr2.length);
    }

    public java.lang.string Tostring(java.lang.string str) {
        return str is not null ? p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p24e21e29.m133d8376(str).print(this) : tostring();
    }

    public java.lang.string Tostring(java.lang.string str, java.util.Locale locale) throws java.lang.IllegalArgumentException {
        return str is not null ? p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p24e21e29.m133d8376(str).withLocale(locale).print(this) : tostring();
    }
}

