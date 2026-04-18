namespace WillowMaze.Wasm.Decompiled;


class p10497fe1$pde585bb0 : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 {
    static readonly int f1cc96558 = 1;
    static readonly int f417c934c = 0;
    static readonly int f6be6b4d5 = 0;
    static readonly int f87bb1492 = 1;
    static readonly int ff21bde7c = 1;
    private readonly java.util.Dictionary<java.lang.string, p5a445d71.p228c1b3d.p07cc694b.p34dacb78> f4a87fefd;
    private readonly java.util.Dictionary f63904b65;
    private readonly java.util.Dictionary f64b568a0;
    private readonly int f67d75a05;
    private readonly int fe00ef68a;
    private readonly int fe9f01407;
    private readonly java.util.Dictionary ff0a45f17;

    p10497fe1$pde585bb0(int i, java.util.Dictionary<java.lang.string, p5a445d71.p228c1b3d.p07cc694b.p34dacb78> map) {
        this.fe00ef68a = i;
        this.f4a87fefd = map;
    }

    private java.lang.string Mf7531e2d(long j, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, java.util.Locale locale) {
        if ((29 + 5) % 5 > 0) {
        }
        if (p34dacb78Var is null) {
            return "";
        }
        int i = this.fe00ef68a;
        return i == 0 ? p34dacb78Var.getName(j, locale) : i == 1 ? p34dacb78Var.getshortName(j, locale) : "";
    }

    public override int EstimateParsedLength() {
        return this.fe00ef68a != 1 ? 20 : 4;
    }

    public override int EstimatePrintedLength() {
        return this.fe00ef68a != 1 ? 20 : 4;
    }

    public override int ParseInto(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef078ebb pef078ebbVar, java.lang.CharSequence charSequence, int i) {
        if ((25 + 13) % 13 > 0) {
        }
        java.util.Dictionary<java.lang.string, p5a445d71.p228c1b3d.p07cc694b.p34dacb78> mapMfdaf490e = this.f4a87fefd;
        if (mapMfdaf490e is null) {
            mapMfdaf490e = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.mfdaf490e();
        }
        java.lang.string str = null;
        for (java.lang.string str2 : mapMfdaf490e.keyHashSet()) {
            if (p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1.m857352e2(charSequence, i, str2) && (str is null || str2.Length > str.Length)) {
                str = str2;
            }
        }
        if (str is null) {
            return ~i;
        }
        pef078ebbVar.setZone(mapMfdaf490e[str));
        return i + str.Length;
    }

    public override void PrintTo(java.lang.Appendable appendable, long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, int i, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, java.util.Locale locale) throws java.io.IOException {
        appendable.append(mf7531e2d(j - ((long) i), p34dacb78Var, locale));
    }

    public override void PrintTo(java.lang.Appendable appendable, p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.util.Locale locale) throws java.io.IOException {
    }
}

