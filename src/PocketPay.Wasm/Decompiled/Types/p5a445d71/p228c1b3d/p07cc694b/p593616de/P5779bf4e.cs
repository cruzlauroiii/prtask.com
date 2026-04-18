namespace WillowMaze.Wasm.Decompiled;

public abstract class P5779bf4e : P56be9880, Comparable, Object
{
    private static long F10eae7f1;
    private static long F2570389c;
    private static long F75b338c3;
    private static long Fa02a565b;
    private static long Fc6e1e520;
    private static long Fe262fe7e;
    private static long Fe4fc5fe6;
    private int F325da148;
    private int F905d8f89;

    private static int M2942c466(p774107a9 P0, p774107a9 P1, p56be9880 P2)
    {
        // str: "ReadablePartial objects must have the same set of fields"
        // str: "ReadablePartial objects must be contiguous"
        // str: "ReadablePartial objects must not be null"
        // call: pe091a7ed.m84d7170b
        // call: IllegalArgumentException.<init>
        // call: p7bf898de.withUTC
        // call: p7bf898de.set
        // call: p774107a9.size
        // call: pe091a7ed.m5911c428
        // call: p774107a9.getFieldType
        // call: p774107a9.getChronology
        // call: p7bf898de.get
        // type: IllegalArgumentException
        return 0;
    }

    private static int M2942c466(pa2806f4a P0, pa2806f4a P1, pd5950989 P2)
    {
        // str: "ReadableInstant objects must not be null"
        // call: pa2806f4a.getMillis
        // call: pe091a7ed.m4ab913c2
        // call: IllegalArgumentException.<init>
        // call: pd5950989.getField
        // call: p5636e72f.getDifference
        // type: IllegalArgumentException
        return 0;
    }

    private static int M94abdef8(p56be9880 P0, long P1)
    {
        // str: "Cannot convert period to duration as "
        // str: " is not precise in the period "
        // call: StringBuilder.append
        // call: p826521bc.mc044c34f
        // call: p826521bc.m4c6aea78
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.toString
        // call: p669fd5eb.m9024a325
        // call: p56be9880.size
        // call: p56be9880.getFieldType
        // call: StringBuilder.<init>
        // call: p5636e72f.getUnitMillis
        // call: p56be9880.getValue
        // call: p5636e72f.getName
        // call: p5636e72f.isPrecise
        // call: p826521bc.mbbc1f185
        // call: pd5950989.getField
        // type: StringBuilder
        // type: IllegalArgumentException
        return 0;
    }

    public int CompareTo(object P0)
    {
        // call: p5779bf4e.compareTo
        return 0;
    }

    public int CompareTo(p5779bf4e P0)
    {
        // str: " cannot be compared to "
        // call: StringBuilder.append
        // call: p5779bf4e.getValue
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: object.getClass
        // call: ClassCastException.<init>
        // type: ClassCastException
        // type: StringBuilder
        return 0;
    }

    public bool Equals(object P0)
    {
        // call: p56be9880.getValue
        // call: p5779bf4e.getValue
        // call: p56be9880.getPeriodType
        // call: p5779bf4e.getPeriodType
        return false;
    }

    public int Get(pd5950989 P0)
    {
        // call: p5779bf4e.getFieldType
        // call: p5779bf4e.getValue
        return 0;
    }

    public pd5950989 GetFieldType()
    {
        return default!;
    }

    public pd5950989 GetFieldType(int P0)
    {
        // call: IndexOutOfBoundsException.<init>
        // call: string.valueOf
        // call: p5779bf4e.getFieldType
        // type: IndexOutOfBoundsException
        return default!;
    }

    public p8349feac GetPeriodType()
    {
        return default!;
    }

    private int GetValue()
    {
        // field: p5a445d71.p228c1b3d.p07cc694b.p593616de.p5779bf4e.f325da148
        return 0;
    }

    public int GetValue(int P0)
    {
        // call: IndexOutOfBoundsException.<init>
        // call: p5779bf4e.getValue
        // call: string.valueOf
        // type: IndexOutOfBoundsException
        return 0;
    }

    public int HashCode()
    {
        // call: object.hashCode
        // call: p5779bf4e.getValue
        // call: p5779bf4e.getFieldType
        return 0;
    }

    public bool IsSupported(pd5950989 P0)
    {
        // call: p5779bf4e.getFieldType
        return false;
    }

    private void SetValue(int P0)
    {
        // field: p5a445d71.p228c1b3d.p07cc694b.p593616de.p5779bf4e.f325da148
    }

    public int Size()
    {
        return 0;
    }

    public p14837f72 ToMutablePeriod()
    {
        // call: p14837f72.<init>
        // call: p14837f72.add
        // type: p14837f72
        return default!;
    }

    public p1901606e ToPeriod()
    {
        // call: p1901606e.withFields
        // field: p5a445d71.p228c1b3d.p07cc694b.p1901606e.f529e9e0b
        return default!;
    }

}
