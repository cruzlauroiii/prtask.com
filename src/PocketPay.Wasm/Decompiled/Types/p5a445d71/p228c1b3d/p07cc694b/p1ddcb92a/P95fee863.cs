namespace WillowMaze.Wasm.Decompiled;

public class P95fee863
{
    private readonly p7da6ba76 F03aad7b6;
    private readonly p8349feac F087f59ff;
    private readonly p8349feac F31800068;
    private readonly CultureInfo F3b3b7d03;
    private readonly CultureInfo F5c0962a1;
    private readonly CultureInfo F7a9c8f14;
    private readonly p8349feac F91e00858;
    private readonly p7da6ba76 F9cd8246c;
    private readonly p8349feac F9d5edca2;
    private readonly p7da6ba76 F9f2368be;
    private readonly p90eb5d04 Fa34cfdd6;
    private readonly CultureInfo Fc77dffad;
    private readonly CultureInfo Fd27f9722;
    private readonly p90eb5d04 Ff6a33203;
    private readonly p7da6ba76 Fff555de6;

    private void M1b8ff6b9()
    {
        // str: "Printing not supported"
        // call: UnsupportedOperationException.<init>
        // field: p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863.fa34cfdd6
        // type: UnsupportedOperationException
    }

    private void M690300c1()
    {
        // str: "Parsing not supported"
        // call: UnsupportedOperationException.<init>
        // field: p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863.f9cd8246c
        // type: UnsupportedOperationException
    }

    private void Mc533d09a(p56be9880 P0)
    {
        // str: "Period must not be null"
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
    }

    public CultureInfo GetLocale()
    {
        // field: p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863.fc77dffad
        return default!;
    }

    public p8349feac GetParseType()
    {
        // field: p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863.f087f59ff
        return default!;
    }

    public p7da6ba76 GetParser()
    {
        // field: p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863.f9cd8246c
        return default!;
    }

    public p90eb5d04 GetPrinter()
    {
        // field: p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863.fa34cfdd6
        return default!;
    }

    public bool IsParser()
    {
        // field: p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863.f9cd8246c
        return false;
    }

    public bool IsPrinter()
    {
        // field: p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863.fa34cfdd6
        return false;
    }

    public int ParseInto(p6d7d50f9 P0, string P1, int P2)
    {
        // call: p95fee863.m690300c1
        // call: p95fee863.getParser
        // call: p95fee863.mc533d09a
        // call: p7da6ba76.parseInto
        // field: p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863.fc77dffad
        return 0;
    }

    public p14837f72 ParseMutablePeriod(string P0)
    {
        // call: p95fee863.getParser
        // call: p4e9a5fbb.mf1bb5537
        // call: p14837f72.<init>
        // call: string.length
        // call: p95fee863.m690300c1
        // call: p7da6ba76.parseInto
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863.f087f59ff
        // field: p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863.fc77dffad
        // type: IllegalArgumentException
        // type: p14837f72
        return default!;
    }

    public p1901606e ParsePeriod(string P0)
    {
        // call: p14837f72.toPeriod
        // call: p95fee863.parseMutablePeriod
        // call: p95fee863.m690300c1
        return default!;
    }

    public string Print(p56be9880 P0)
    {
        // call: StringBuilder.<init>
        // call: p90eb5d04.calculatePrintedLength
        // call: p95fee863.getPrinter
        // call: p90eb5d04.printTo
        // call: p95fee863.mc533d09a
        // call: StringBuilder.toString
        // call: p95fee863.m1b8ff6b9
        // field: p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863.fc77dffad
        // type: StringBuilder
        return string.Empty;
    }

    public void PrintTo(Writer P0, p56be9880 P1)
    {
        // call: p95fee863.m1b8ff6b9
        // call: p95fee863.mc533d09a
        // call: p95fee863.getPrinter
        // call: p90eb5d04.printTo
        // field: p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863.fc77dffad
    }

    public void PrintTo(StringBuilder P0, p56be9880 P1)
    {
        // call: p95fee863.mc533d09a
        // call: p95fee863.m1b8ff6b9
        // call: p90eb5d04.printTo
        // call: p95fee863.getPrinter
        // field: p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863.fc77dffad
    }

    public p95fee863 WithLocale(CultureInfo P0)
    {
        // call: CultureInfo.equals
        // call: p95fee863.<init>
        // call: p95fee863.getLocale
        // field: p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863.fa34cfdd6
        // field: p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863.f087f59ff
        // field: p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863.f9cd8246c
        // type: p95fee863
        return default!;
    }

    public p95fee863 WithParseType(p8349feac P0)
    {
        // call: p95fee863.<init>
        // field: p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863.f9cd8246c
        // field: p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863.f087f59ff
        // field: p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863.fc77dffad
        // field: p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863.fa34cfdd6
        // type: p95fee863
        return default!;
    }

}
