namespace WillowMaze.Wasm.Decompiled;


readonly class p74cc47a4 : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.pd8f245ec {
    private static readonly long fc6e1e520 = -3857947176719041436L;
    private static readonly long ff131e0b8 = -3857947176719041436L;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f3fedc733;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f530bc86d;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 f617152b1;
    private readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 fe0db277e;

    p74cc47a4(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 p1f4bb020Var, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar) {
        super(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mce4dee25(), p5636e72fVar);
        this.f3fedc733 = p1f4bb020Var;
    }

    private java.lang.object M73fa47c3() {
        return this.f3fedc733.dayOfWeek();
    }

    protected override int ConvertText(java.lang.string str, java.util.Locale locale) {
        return p5a445d71.p228c1b3d.p07cc694b.peb81adcc.paed786bf.maeb16ab7(locale).dayOfWeekTextToValue(str);
    }

    public override int Get(long j) {
        return this.f3fedc733.getDayOfWeek(j);
    }

    public override java.lang.string GetAsshortText(int i, java.util.Locale locale) {
        return p5a445d71.p228c1b3d.p07cc694b.peb81adcc.paed786bf.maeb16ab7(locale).dayOfWeekValueToshortText(i);
    }

    public override java.lang.string GetAsText(int i, java.util.Locale locale) {
        return p5a445d71.p228c1b3d.p07cc694b.peb81adcc.paed786bf.maeb16ab7(locale).dayOfWeekValueToText(i);
    }

    public override int GetMaximumshortTextLength(java.util.Locale locale) {
        return p5a445d71.p228c1b3d.p07cc694b.peb81adcc.paed786bf.maeb16ab7(locale).getDayOfWeekMaxshortTextLength();
    }

    public override int GetMaximumTextLength(java.util.Locale locale) {
        return p5a445d71.p228c1b3d.p07cc694b.peb81adcc.paed786bf.maeb16ab7(locale).getDayOfWeekMaxTextLength();
    }

    public override int GetMaximumValue() {
        return 7;
    }

    public override int GetMinimumValue() {
        return 1;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetRangeDurationField() {
        return this.f3fedc733.weeks();
    }
}

