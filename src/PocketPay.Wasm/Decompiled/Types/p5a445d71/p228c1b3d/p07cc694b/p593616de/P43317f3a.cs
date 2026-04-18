namespace WillowMaze.Wasm.Decompiled;

public abstract class P43317f3a : P6fb9e512
{
    private void CheckInterval(long P0, long P1)
    {
        // str: "The end instant must be greater than the start instant"
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
    }

    public bool Contains(long P0)
    {
        // call: p43317f3a.getEndMillis
        // call: p43317f3a.getStartMillis
        return false;
    }

    public bool Contains(p6fb9e512 P0)
    {
        // call: p43317f3a.getStartMillis
        // call: p43317f3a.getEndMillis
        // call: p6fb9e512.getEndMillis
        // call: p6fb9e512.getStartMillis
        // call: p43317f3a.containsNow
        return false;
    }

    public bool Contains(pa2806f4a P0)
    {
        // call: p43317f3a.containsNow
        // call: pa2806f4a.getMillis
        // call: p43317f3a.contains
        return false;
    }

    public bool ContainsNow()
    {
        // call: pe091a7ed.m7d3c9eb9
        // call: p43317f3a.contains
        return false;
    }

    public bool Equals(object P0)
    {
        // call: p6fb9e512.getChronology
        // call: p43317f3a.getStartMillis
        // call: p6fb9e512.getEndMillis
        // call: p43317f3a.getEndMillis
        // call: p43317f3a.getChronology
        // call: p6fb9e512.getStartMillis
        // call: p826521bc.m51c3f596
        return false;
    }

    public p8cf10d23 GetEnd()
    {
        // call: p8cf10d23.<init>
        // call: p43317f3a.getChronology
        // call: p43317f3a.getEndMillis
        // type: p8cf10d23
        return default!;
    }

    public p8cf10d23 GetStart()
    {
        // call: p8cf10d23.<init>
        // call: p43317f3a.getChronology
        // call: p43317f3a.getStartMillis
        // type: p8cf10d23
        return default!;
    }

    public int HashCode()
    {
        // call: p43317f3a.getStartMillis
        // call: p43317f3a.getChronology
        // call: p43317f3a.getEndMillis
        // call: object.hashCode
        return 0;
    }

    public bool IsAfter(long P0)
    {
        // call: p43317f3a.getStartMillis
        return false;
    }

    public bool IsAfter(p6fb9e512 P0)
    {
        // call: p43317f3a.getStartMillis
        // call: pe091a7ed.m7d3c9eb9
        // call: p6fb9e512.getEndMillis
        return false;
    }

    public bool IsAfter(pa2806f4a P0)
    {
        // call: pa2806f4a.getMillis
        // call: p43317f3a.isAfterNow
        // call: p43317f3a.isAfter
        return false;
    }

    public bool IsAfterNow()
    {
        // call: p43317f3a.isAfter
        // call: pe091a7ed.m7d3c9eb9
        return false;
    }

    public bool IsBefore(long P0)
    {
        // call: p43317f3a.getEndMillis
        return false;
    }

    public bool IsBefore(p6fb9e512 P0)
    {
        // call: p6fb9e512.getStartMillis
        // call: p43317f3a.isBefore
        // call: p43317f3a.isBeforeNow
        return false;
    }

    public bool IsBefore(pa2806f4a P0)
    {
        // call: p43317f3a.isBefore
        // call: pa2806f4a.getMillis
        // call: p43317f3a.isBeforeNow
        return false;
    }

    public bool IsBeforeNow()
    {
        // call: p43317f3a.isBefore
        // call: pe091a7ed.m7d3c9eb9
        return false;
    }

    public bool IsEqual(p6fb9e512 P0)
    {
        // call: p43317f3a.getEndMillis
        // call: p43317f3a.getStartMillis
        // call: p6fb9e512.getStartMillis
        // call: p6fb9e512.getEndMillis
        return false;
    }

    public bool Overlaps(p6fb9e512 P0)
    {
        // call: p43317f3a.getEndMillis
        // call: p43317f3a.getStartMillis
        // call: p6fb9e512.getStartMillis
        // call: p6fb9e512.getEndMillis
        // call: pe091a7ed.m7d3c9eb9
        return false;
    }

    public pe02d2ae0 ToDuration()
    {
        // call: p43317f3a.toDurationMillis
        // call: pe02d2ae0.<init>
        // field: p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0.f529e9e0b
        // type: pe02d2ae0
        return default!;
    }

    public long ToDurationMillis()
    {
        // call: p43317f3a.getStartMillis
        // call: p826521bc.mbac1363c
        // call: p43317f3a.getEndMillis
        return 0;
    }

    public pd16dd01a ToInterval()
    {
        // call: p43317f3a.getEndMillis
        // call: p43317f3a.getChronology
        // call: pd16dd01a.<init>
        // call: p43317f3a.getStartMillis
        // type: pd16dd01a
        return default!;
    }

    public p1bc4e102 ToMutableInterval()
    {
        // call: p1bc4e102.<init>
        // call: p43317f3a.getEndMillis
        // call: p43317f3a.getChronology
        // call: p43317f3a.getStartMillis
        // type: p1bc4e102
        return default!;
    }

    public p1901606e ToPeriod()
    {
        // call: p43317f3a.getEndMillis
        // call: p43317f3a.getChronology
        // call: p43317f3a.getStartMillis
        // call: p1901606e.<init>
        // type: p1901606e
        return default!;
    }

    public p1901606e ToPeriod(p8349feac P0)
    {
        // call: p43317f3a.getChronology
        // call: p43317f3a.getStartMillis
        // call: p1901606e.<init>
        // call: p43317f3a.getEndMillis
        // type: p1901606e
        return default!;
    }

    public string ToString()
    {
        // call: p54be4855.mdcf569ee
        // call: p43317f3a.getChronology
        // call: p43317f3a.getEndMillis
        // call: StringBuilder.toString
        // call: p048c1932.withChronology
        // call: p048c1932.printTo
        // call: p43317f3a.getStartMillis
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // type: StringBuilder
        return string.Empty;
    }

}
