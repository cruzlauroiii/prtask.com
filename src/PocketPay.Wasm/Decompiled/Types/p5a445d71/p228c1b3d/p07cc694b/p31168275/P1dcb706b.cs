namespace WillowMaze.Wasm.Decompiled;

public class P1dcb706b : Paf625b95, P853435af, P4d117938, Pa405d255, P137fe34d, Pcca0bf9f
{
    private static p1dcb706b F173c7b1e;
    private static p1dcb706b F30bed287;
    private static p1dcb706b F76425f17;
    private static p1dcb706b Fb62f2e69;

    public long GetDurationMillis(object P0)
    {
        // str: "Invalid format: \""
        // str: "000"
        // call: StringBuilder.append
        // call: string.length
        // call: int.parseInt
        // call: string.charAt
        // call: StringBuilder.<init>
        // call: string.substring
        // call: p826521bc.m4c6aea78
        // call: p826521bc.mbbc1f185
        // call: StringBuilder.toString
        // call: long.parseLong
        // call: IllegalArgumentException.<init>
        // type: StringBuilder
        // type: IllegalArgumentException
        return 0;
    }

    public long GetInstantMillis(object P0, p7bf898de P1)
    {
        // call: p048c1932.withChronology
        // call: p048c1932.parseMillis
        // call: p54be4855.m9078ca24
        return 0;
    }

    public int[] GetPartialValues(p774107a9 P0, object P1, p7bf898de P2, p048c1932 P3)
    {
        // call: p048c1932.parseMillis
        // call: p048c1932.getZone
        // call: p7bf898de.withZone
        // call: p048c1932.withChronology
        // call: p7bf898de.get
        return default!;
    }

    public Type GetSupportedType()
    {
        // type: string
        return default!;
    }

    public void SetInto(p383ecbd3 P0, object P1, p7bf898de P2)
    {
        // str: "Format requires a '/' separator: "
        // str: "Format invalid: "
        // str: "Interval composed of two durations: "
        // call: StringBuilder.append
        // call: string.charAt
        // call: IllegalArgumentException.<init>
        // call: p1dcb706b.getPeriodType
        // call: pb5887b92.mc00f0c46
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: p95fee863.parsePeriod
        // call: p048c1932.parseDateTime
        // call: p54be4855.m9078ca24
        // call: p383ecbd3.setChronology
        // call: p95fee863.withParseType
        // call: string.substring
        // call: p8cf10d23.getMillis
        // call: p7bf898de.add
        // call: p383ecbd3.setInterval
        // call: string.indexOf
        // call: p048c1932.withChronology
        // call: string.length
        // call: p8cf10d23.getChronology
        // type: StringBuilder
        // type: IllegalArgumentException
    }

    public void SetInto(p6d7d50f9 P0, object P1, p7bf898de P2)
    {
        // str: "Invalid format: \""
        // call: p6d7d50f9.clear
        // call: pb5887b92.mc00f0c46
        // call: p95fee863.withParseType
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: string.length
        // call: IllegalArgumentException.<init>
        // call: p6d7d50f9.getPeriodType
        // call: p95fee863.parseInto
        // call: p95fee863.parseMutablePeriod
        // call: StringBuilder.toString
        // type: IllegalArgumentException
        // type: StringBuilder
    }

}
