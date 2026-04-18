namespace WillowMaze.Wasm.Decompiled;

public abstract class P8c6072a9 : Pa2806f4a
{
    public int CompareTo(object P0)
    {
        // call: p8c6072a9.compareTo
        return 0;
    }

    public int CompareTo(pa2806f4a P0)
    {
        // call: pa2806f4a.getMillis
        // call: p8c6072a9.getMillis
        return 0;
    }

    public bool Equals(object P0)
    {
        // call: pa2806f4a.getMillis
        // call: p8c6072a9.getChronology
        // call: p826521bc.m51c3f596
        // call: p8c6072a9.getMillis
        // call: pa2806f4a.getChronology
        return false;
    }

    public int Get(p51c74e65 P0)
    {
        // str: "The DateTimeFieldType must not be null"
        // call: p8c6072a9.getChronology
        // call: p8b1ed2c5.get
        // call: IllegalArgumentException.<init>
        // call: p8c6072a9.getMillis
        // call: p51c74e65.getField
        // type: IllegalArgumentException
        return 0;
    }

    public int Get(p8b1ed2c5 P0)
    {
        // str: "The DateTimeField must not be null"
        // call: p8b1ed2c5.get
        // call: p8c6072a9.getMillis
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
        return 0;
    }

    public p34dacb78 GetZone()
    {
        // call: p8c6072a9.getChronology
        // call: p7bf898de.getZone
        return default!;
    }

    public int HashCode()
    {
        // call: object.hashCode
        // call: p8c6072a9.getMillis
        // call: p8c6072a9.getChronology
        return 0;
    }

    public bool IsAfter(long P0)
    {
        // call: p8c6072a9.getMillis
        return false;
    }

    public bool IsAfter(pa2806f4a P0)
    {
        // call: p8c6072a9.isAfter
        // call: pe091a7ed.m0cb3ed48
        return false;
    }

    public bool IsAfterNow()
    {
        // call: p8c6072a9.isAfter
        // call: pe091a7ed.m7d3c9eb9
        return false;
    }

    public bool IsBefore(long P0)
    {
        // call: p8c6072a9.getMillis
        return false;
    }

    public bool IsBefore(pa2806f4a P0)
    {
        // call: pe091a7ed.m0cb3ed48
        // call: p8c6072a9.isBefore
        return false;
    }

    public bool IsBeforeNow()
    {
        // call: p8c6072a9.isBefore
        // call: pe091a7ed.m7d3c9eb9
        return false;
    }

    public bool IsEqual(long P0)
    {
        // call: p8c6072a9.getMillis
        return false;
    }

    public bool IsEqual(pa2806f4a P0)
    {
        // call: p8c6072a9.isEqual
        // call: pe091a7ed.m0cb3ed48
        return false;
    }

    public bool IsEqualNow()
    {
        // call: pe091a7ed.m7d3c9eb9
        // call: p8c6072a9.isEqual
        return false;
    }

    public bool IsSupported(p51c74e65 P0)
    {
        // call: p8b1ed2c5.isSupported
        // call: p51c74e65.getField
        // call: p8c6072a9.getChronology
        return false;
    }

    public DateTime ToDate()
    {
        // call: p8c6072a9.getMillis
        // call: DateTime.<init>
        // type: DateTime
        return default!;
    }

    public p8cf10d23 ToDateTime()
    {
        // call: p8cf10d23.<init>
        // call: p8c6072a9.getMillis
        // call: p8c6072a9.getZone
        // type: p8cf10d23
        return default!;
    }

    public p8cf10d23 ToDateTime(p34dacb78 P0)
    {
        // call: pe091a7ed.m5911c428
        // call: p8c6072a9.getMillis
        // call: p8cf10d23.<init>
        // call: p7bf898de.withZone
        // call: p8c6072a9.getChronology
        // type: p8cf10d23
        return default!;
    }

    public p8cf10d23 ToDateTime(p7bf898de P0)
    {
        // call: p8cf10d23.<init>
        // call: p8c6072a9.getMillis
        // type: p8cf10d23
        return default!;
    }

    public p8cf10d23 ToDateTimeISO()
    {
        // call: p8c6072a9.getMillis
        // call: p8c6072a9.getZone
        // call: p8cf10d23.<init>
        // call: p669fd5eb.m8bab0102
        // type: p8cf10d23
        return default!;
    }

    public p54828f32 ToInstant()
    {
        // call: p54828f32.<init>
        // call: p8c6072a9.getMillis
        // type: p54828f32
        return default!;
    }

    public pc2cdfc0f ToMutableDateTime()
    {
        // call: p8c6072a9.getMillis
        // call: p8c6072a9.getZone
        // call: pc2cdfc0f.<init>
        // type: pc2cdfc0f
        return default!;
    }

    public pc2cdfc0f ToMutableDateTime(p34dacb78 P0)
    {
        // call: pc2cdfc0f.<init>
        // call: p7bf898de.withZone
        // call: p8c6072a9.getChronology
        // call: pe091a7ed.m5911c428
        // call: p8c6072a9.getMillis
        // type: pc2cdfc0f
        return default!;
    }

    public pc2cdfc0f ToMutableDateTime(p7bf898de P0)
    {
        // call: pc2cdfc0f.<init>
        // call: p8c6072a9.getMillis
        // type: pc2cdfc0f
        return default!;
    }

    public pc2cdfc0f ToMutableDateTimeISO()
    {
        // call: p8c6072a9.getZone
        // call: p669fd5eb.m8bab0102
        // call: pc2cdfc0f.<init>
        // call: p8c6072a9.getMillis
        // type: pc2cdfc0f
        return default!;
    }

    public string ToString()
    {
        // call: p54be4855.mdcf569ee
        // call: p048c1932.print
        return string.Empty;
    }

    public string ToString(p048c1932 P0)
    {
        // call: p8c6072a9.toString
        // call: p048c1932.print
        return string.Empty;
    }

}
