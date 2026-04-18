namespace WillowMaze.Wasm.Decompiled;

public class Pd16dd01a : P70f8e776, P6fb9e512, Object
{
    private static long F4103dc39;
    private static long F64c8ce30;
    private static long F83e65cdc;
    private static long Fbb8e08a6;
    private static long Fc6e1e520;

    public static pd16dd01a M2e88eca8(string P0)
    {
        // call: pd16dd01a.<init>
        // type: pd16dd01a
        return default!;
    }

    public static pd16dd01a M8b8b6ce4(string P0)
    {
        // str: "Format requires a '/' separator: "
        // str: "Format invalid: "
        // str: "Interval composed of two durations: "
        // call: string.charAt
        // call: p048c1932.parseDateTime
        // call: pd16dd01a.<init>
        // call: p8349feac.mc00f0c46
        // call: p95fee863.withParseType
        // call: pb5887b92.mc00f0c46
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: string.substring
        // call: StringBuilder.<init>
        // call: p95fee863.parsePeriod
        // call: string.length
        // call: IllegalArgumentException.<init>
        // call: string.indexOf
        // call: p54be4855.m9078ca24
        // call: p048c1932.withOffsetParsed
        // type: IllegalArgumentException
        // type: pd16dd01a
        // type: StringBuilder
        return default!;
    }

    public bool Abuts(p6fb9e512 P0)
    {
        // call: p6fb9e512.getEndMillis
        // call: pd16dd01a.getEndMillis
        // call: pe091a7ed.m7d3c9eb9
        // call: p6fb9e512.getStartMillis
        // call: pd16dd01a.getStartMillis
        return false;
    }

    public pd16dd01a Gap(p6fb9e512 P0)
    {
        // call: pd16dd01a.getChronology
        // call: pe091a7ed.m53784b64
        // call: p6fb9e512.getEndMillis
        // call: pd16dd01a.getEndMillis
        // call: p6fb9e512.getStartMillis
        // call: pd16dd01a.<init>
        // call: pd16dd01a.getStartMillis
        // type: pd16dd01a
        return default!;
    }

    public pd16dd01a Overlap(p6fb9e512 P0)
    {
        // call: pd16dd01a.getEndMillis
        // call: Math.max
        // call: p6fb9e512.getEndMillis
        // call: pd16dd01a.<init>
        // call: pd16dd01a.getChronology
        // call: pe091a7ed.m53784b64
        // call: pd16dd01a.getStartMillis
        // call: Math.min
        // call: pd16dd01a.overlaps
        // call: p6fb9e512.getStartMillis
        // type: pd16dd01a
        return default!;
    }

    public pd16dd01a ToInterval()
    {
        return default!;
    }

    public pd16dd01a WithChronology(p7bf898de P0)
    {
        // call: pd16dd01a.getChronology
        // call: pd16dd01a.getStartMillis
        // call: pd16dd01a.getEndMillis
        // call: pd16dd01a.<init>
        // type: pd16dd01a
        return default!;
    }

    public pd16dd01a WithDurationAfterStart(p3f224b4c P0)
    {
        // call: pd16dd01a.getStartMillis
        // call: pd16dd01a.getChronology
        // call: p7bf898de.add
        // call: pe091a7ed.m5371f9a6
        // call: pd16dd01a.<init>
        // call: pd16dd01a.toDurationMillis
        // type: pd16dd01a
        return default!;
    }

    public pd16dd01a WithDurationBeforeEnd(p3f224b4c P0)
    {
        // call: pe091a7ed.m5371f9a6
        // call: pd16dd01a.getEndMillis
        // call: p7bf898de.add
        // call: pd16dd01a.getChronology
        // call: pd16dd01a.<init>
        // call: pd16dd01a.toDurationMillis
        // type: pd16dd01a
        return default!;
    }

    public pd16dd01a WithEnd(pa2806f4a P0)
    {
        // call: pe091a7ed.m0cb3ed48
        // call: pd16dd01a.withEndMillis
        return default!;
    }

    public pd16dd01a WithEndMillis(long P0)
    {
        // call: pd16dd01a.getStartMillis
        // call: pd16dd01a.getChronology
        // call: pd16dd01a.<init>
        // call: pd16dd01a.getEndMillis
        // type: pd16dd01a
        return default!;
    }

    public pd16dd01a WithPeriodAfterStart(p56be9880 P0)
    {
        // call: pd16dd01a.getChronology
        // call: pd16dd01a.<init>
        // call: pd16dd01a.getStartMillis
        // call: p7bf898de.add
        // call: pd16dd01a.withDurationAfterStart
        // type: pd16dd01a
        return default!;
    }

    public pd16dd01a WithPeriodBeforeEnd(p56be9880 P0)
    {
        // call: pd16dd01a.<init>
        // call: pd16dd01a.getEndMillis
        // call: pd16dd01a.getChronology
        // call: pd16dd01a.withDurationBeforeEnd
        // call: p7bf898de.add
        // type: pd16dd01a
        return default!;
    }

    public pd16dd01a WithStart(pa2806f4a P0)
    {
        // call: pe091a7ed.m0cb3ed48
        // call: pd16dd01a.withStartMillis
        return default!;
    }

    public pd16dd01a WithStartMillis(long P0)
    {
        // call: pd16dd01a.getStartMillis
        // call: pd16dd01a.getEndMillis
        // call: pd16dd01a.getChronology
        // call: pd16dd01a.<init>
        // type: pd16dd01a
        return default!;
    }

}
