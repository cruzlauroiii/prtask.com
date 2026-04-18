namespace WillowMaze.Wasm.Decompiled;


readonly class p844c7aa5 : p5a445d71.p228c1b3d.p07cc694b.peb81adcc.pa6a4c9b1 {
    private static readonly long f45c2e168 = -4748157875845286249L;
    private static readonly long fc3821174 = -4748157875845286249L;
    private static readonly long fc6e1e520 = -4748157875845286249L;
    private static readonly long fdce56a8a = -4748157875845286249L;

    p844c7aa5(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p1f4bb020 p1f4bb020Var) {
        super(p1f4bb020Var, 2);
    }

    protected override int ConvertText(java.lang.string str, java.util.Locale locale) {
        return p5a445d71.p228c1b3d.p07cc694b.peb81adcc.paed786bf.maeb16ab7(locale).monthOfYearTextToValue(str);
    }

    public override java.lang.string GetAsshortText(int i, java.util.Locale locale) {
        return p5a445d71.p228c1b3d.p07cc694b.peb81adcc.paed786bf.maeb16ab7(locale).monthOfYearValueToshortText(i);
    }

    public override java.lang.string GetAsText(int i, java.util.Locale locale) {
        return p5a445d71.p228c1b3d.p07cc694b.peb81adcc.paed786bf.maeb16ab7(locale).monthOfYearValueToText(i);
    }

    public override int GetMaximumshortTextLength(java.util.Locale locale) {
        return p5a445d71.p228c1b3d.p07cc694b.peb81adcc.paed786bf.maeb16ab7(locale).getMonthMaxshortTextLength();
    }

    public override int GetMaximumTextLength(java.util.Locale locale) {
        return p5a445d71.p228c1b3d.p07cc694b.peb81adcc.paed786bf.maeb16ab7(locale).getMonthMaxTextLength();
    }
}

