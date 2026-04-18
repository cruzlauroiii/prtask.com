namespace WillowMaze.Wasm.Decompiled;

public abstract class Pac09be0b : P774107a9, Comparable
{
    public int CompareTo(object P0)
    {
        // call: pac09be0b.compareTo
        return 0;
    }

    public int CompareTo(p774107a9 P0)
    {
        // str: "ReadablePartial objects must have matching field types"
        // call: pac09be0b.getFieldType
        // call: p774107a9.getValue
        // call: p774107a9.getFieldType
        // call: pac09be0b.getValue
        // call: ClassCastException.<init>
        // call: pac09be0b.size
        // call: p774107a9.size
        // type: ClassCastException
        return 0;
    }

    public bool Equals(object P0)
    {
        // call: pac09be0b.size
        // call: pac09be0b.getValue
        // call: pac09be0b.getChronology
        // call: p774107a9.size
        // call: p826521bc.m51c3f596
        // call: p774107a9.getValue
        // call: pac09be0b.getFieldType
        // call: p774107a9.getChronology
        // call: p774107a9.getFieldType
        return false;
    }

    public int Get(p51c74e65 P0)
    {
        // call: pac09be0b.indexOfSupported
        // call: pac09be0b.getValue
        return 0;
    }

    public p8b1ed2c5 GetField(int P0)
    {
        // call: pac09be0b.getField
        // call: pac09be0b.getChronology
        return default!;
    }

    private p8b1ed2c5 GetField(int P0, p7bf898de P1)
    {
        return default!;
    }

    public p51c74e65 GetFieldType(int P0)
    {
        // call: p8b1ed2c5.getType
        // call: pac09be0b.getChronology
        // call: pac09be0b.getField
        return default!;
    }

    public p51c74e65[] GetFieldTypes()
    {
        // call: pac09be0b.getFieldType
        // call: pac09be0b.size
        return default!;
    }

    public p8b1ed2c5[] GetFields()
    {
        // call: pac09be0b.getField
        // call: pac09be0b.size
        return default!;
    }

    public int[] GetValues()
    {
        // call: pac09be0b.size
        // call: pac09be0b.getValue
        return default!;
    }

    public int HashCode()
    {
        // call: pac09be0b.getValue
        // call: pac09be0b.getChronology
        // call: pac09be0b.size
        // call: object.hashCode
        // call: pac09be0b.getFieldType
        return 0;
    }

    public int IndexOf(p51c74e65 P0)
    {
        // call: pac09be0b.getFieldType
        // call: pac09be0b.size
        return 0;
    }

    private int IndexOf(pd5950989 P0)
    {
        // call: p51c74e65.getDurationType
        // call: pac09be0b.size
        // call: pac09be0b.getFieldType
        return 0;
    }

    private int IndexOfSupported(p51c74e65 P0)
    {
        // str: "' is not supported"
        // str: "Field '"
        // call: StringBuilder.<init>
        // call: pac09be0b.indexOf
        // call: StringBuilder.append
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.toString
        // type: IllegalArgumentException
        // type: StringBuilder
        return 0;
    }

    private int IndexOfSupported(pd5950989 P0)
    {
        // str: "Field '"
        // str: "' is not supported"
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: pac09be0b.indexOf
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
        // type: StringBuilder
        return 0;
    }

    public bool IsAfter(p774107a9 P0)
    {
        // str: "Partial cannot be null"
        // call: IllegalArgumentException.<init>
        // call: pac09be0b.compareTo
        // type: IllegalArgumentException
        return false;
    }

    public bool IsBefore(p774107a9 P0)
    {
        // str: "Partial cannot be null"
        // call: pac09be0b.compareTo
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
        return false;
    }

    public bool IsEqual(p774107a9 P0)
    {
        // str: "Partial cannot be null"
        // call: IllegalArgumentException.<init>
        // call: pac09be0b.compareTo
        // type: IllegalArgumentException
        return false;
    }

    public bool IsSupported(p51c74e65 P0)
    {
        // call: pac09be0b.indexOf
        return false;
    }

    public p8cf10d23 ToDateTime(pa2806f4a P0)
    {
        // call: pe091a7ed.m0cb3ed48
        // call: p8cf10d23.<init>
        // call: p7bf898de.set
        // call: pe091a7ed.m4ab913c2
        // type: p8cf10d23
        return default!;
    }

    public string ToString(p048c1932 P0)
    {
        // call: object.toString
        // call: p048c1932.print
        return string.Empty;
    }

}
