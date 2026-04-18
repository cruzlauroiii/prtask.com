namespace WillowMaze.Wasm.Decompiled;

public class P1bc4e102 : P70f8e776, P383ecbd3, Cloneable, Object
{
    private static long F5c6663f2;
    private static long F8a7e89da;
    private static long Fc6e1e520;

    public static p1bc4e102 M2e88eca8(string P0)
    {
        // call: p1bc4e102.<init>
        // type: p1bc4e102
        return default!;
    }

    public object Clone()
    {
        // str: "Clone error"
        // call: InternalError.<init>
        // call: object.clone
        // type: InternalError
        return default!;
    }

    public p1bc4e102 Copy()
    {
        // call: p1bc4e102.clone
        return default!;
    }

    public void SetChronology(p7bf898de P0)
    {
        // call: p70f8e776.setInterval
        // call: p1bc4e102.getEndMillis
        // call: p1bc4e102.getStartMillis
    }

    public void SetDurationAfterStart(long P0)
    {
        // call: p1bc4e102.getStartMillis
        // call: p826521bc.mbbc1f185
        // call: p1bc4e102.setEndMillis
    }

    public void SetDurationAfterStart(p3f224b4c P0)
    {
        // call: pe091a7ed.m5371f9a6
        // call: p1bc4e102.setEndMillis
        // call: p1bc4e102.getStartMillis
        // call: p826521bc.mbbc1f185
    }

    public void SetDurationBeforeEnd(long P0)
    {
        // call: p1bc4e102.getEndMillis
        // call: p826521bc.mbbc1f185
        // call: p1bc4e102.setStartMillis
    }

    public void SetDurationBeforeEnd(p3f224b4c P0)
    {
        // call: pe091a7ed.m5371f9a6
        // call: p1bc4e102.getEndMillis
        // call: p826521bc.mbbc1f185
        // call: p1bc4e102.setStartMillis
    }

    public void SetEnd(pa2806f4a P0)
    {
        // call: p1bc4e102.getStartMillis
        // call: p1bc4e102.getChronology
        // call: pe091a7ed.m0cb3ed48
        // call: p70f8e776.setInterval
    }

    public void SetEndMillis(long P0)
    {
        // call: p70f8e776.setInterval
        // call: p1bc4e102.getChronology
        // call: p1bc4e102.getStartMillis
    }

    public void SetInterval(long P0, long P1)
    {
        // call: p1bc4e102.getChronology
        // call: p70f8e776.setInterval
    }

    public void SetInterval(p6fb9e512 P0)
    {
        // str: "Interval must not be null"
        // call: p6fb9e512.getEndMillis
        // call: IllegalArgumentException.<init>
        // call: p6fb9e512.getChronology
        // call: p70f8e776.setInterval
        // call: p6fb9e512.getStartMillis
        // type: IllegalArgumentException
    }

    public void SetInterval(pa2806f4a P0, pa2806f4a P1)
    {
        // call: pe091a7ed.m7d3c9eb9
        // call: p1bc4e102.setInterval
        // call: pe091a7ed.m0cb3ed48
        // call: pe091a7ed.m4ab913c2
        // call: p70f8e776.setInterval
    }

    public void SetPeriodAfterStart(p56be9880 P0)
    {
        // call: p1bc4e102.setEndMillis
        // call: p1bc4e102.getStartMillis
        // call: p1bc4e102.getChronology
        // call: p7bf898de.add
    }

    public void SetPeriodBeforeEnd(p56be9880 P0)
    {
        // call: p1bc4e102.getEndMillis
        // call: p1bc4e102.setStartMillis
        // call: p1bc4e102.getChronology
        // call: p7bf898de.add
    }

    public void SetStart(pa2806f4a P0)
    {
        // call: p1bc4e102.getChronology
        // call: pe091a7ed.m0cb3ed48
        // call: p70f8e776.setInterval
        // call: p1bc4e102.getEndMillis
    }

    public void SetStartMillis(long P0)
    {
        // call: p70f8e776.setInterval
        // call: p1bc4e102.getChronology
        // call: p1bc4e102.getEndMillis
    }

}
