namespace WillowMaze.Wasm.Decompiled;

public abstract class P961c80d7 : Object
{
    private static long F61e0d37a;
    private static long Fc6e1e520;

    public int CompareTo(p774107a9 P0)
    {
        // str: "The partial must not be null"
        // call: p774107a9.get
        // call: p961c80d7.getFieldType
        // call: p961c80d7.get
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
        return 0;
    }

    public int CompareTo(pa2806f4a P0)
    {
        // str: "The instant must not be null"
        // call: IllegalArgumentException.<init>
        // call: p961c80d7.getFieldType
        // call: p961c80d7.get
        // call: pa2806f4a.get
        // type: IllegalArgumentException
        return 0;
    }

    public bool Equals(object P0)
    {
        // call: p961c80d7.getFieldType
        // call: p961c80d7.getChronology
        // call: p961c80d7.get
        // call: p826521bc.m51c3f596
        // call: object.equals
        return false;
    }

    public int Get()
    {
        // call: p8b1ed2c5.get
        // call: p961c80d7.getMillis
        // call: p961c80d7.getField
        return 0;
    }

    public string GetAsShortText()
    {
        // call: p961c80d7.getAsShortText
        return string.Empty;
    }

    public string GetAsShortText(CultureInfo P0)
    {
        // call: p961c80d7.getMillis
        // call: p961c80d7.getField
        // call: p8b1ed2c5.getAsShortText
        return string.Empty;
    }

    public string GetAsString()
    {
        // call: int.toString
        // call: p961c80d7.get
        return string.Empty;
    }

    public string GetAsText()
    {
        // call: p961c80d7.getAsText
        return string.Empty;
    }

    public string GetAsText(CultureInfo P0)
    {
        // call: p961c80d7.getField
        // call: p961c80d7.getMillis
        // call: p8b1ed2c5.getAsText
        return string.Empty;
    }

    private p7bf898de GetChronology()
    {
        // str: "The method getChronology() was added in v1.4 and needs to be implemented by subclasses of Abstrac..."
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return default!;
    }

    public int GetDifference(pa2806f4a P0)
    {
        // call: pe091a7ed.m7d3c9eb9
        // call: p961c80d7.getField
        // call: p961c80d7.getMillis
        // call: p8b1ed2c5.getDifference
        // call: pa2806f4a.getMillis
        return 0;
    }

    public long GetDifferenceAsLong(pa2806f4a P0)
    {
        // call: p961c80d7.getField
        // call: p8b1ed2c5.getDifferenceAsLong
        // call: p961c80d7.getMillis
        // call: pe091a7ed.m7d3c9eb9
        // call: pa2806f4a.getMillis
        return 0;
    }

    public p5636e72f GetDurationField()
    {
        // call: p961c80d7.getField
        // call: p8b1ed2c5.getDurationField
        return default!;
    }

    public p8b1ed2c5 GetField()
    {
        return default!;
    }

    public p51c74e65 GetFieldType()
    {
        // call: p8b1ed2c5.getType
        // call: p961c80d7.getField
        return default!;
    }

    public int GetLeapAmount()
    {
        // call: p8b1ed2c5.getLeapAmount
        // call: p961c80d7.getField
        // call: p961c80d7.getMillis
        return 0;
    }

    public p5636e72f GetLeapDurationField()
    {
        // call: p961c80d7.getField
        // call: p8b1ed2c5.getLeapDurationField
        return default!;
    }

    public int GetMaximumShortTextLength(CultureInfo P0)
    {
        // call: p8b1ed2c5.getMaximumShortTextLength
        // call: p961c80d7.getField
        return 0;
    }

    public int GetMaximumTextLength(CultureInfo P0)
    {
        // call: p961c80d7.getField
        // call: p8b1ed2c5.getMaximumTextLength
        return 0;
    }

    public int GetMaximumValue()
    {
        // call: p8b1ed2c5.getMaximumValue
        // call: p961c80d7.getField
        // call: p961c80d7.getMillis
        return 0;
    }

    public int GetMaximumValueOverall()
    {
        // call: p8b1ed2c5.getMaximumValue
        // call: p961c80d7.getField
        return 0;
    }

    private long GetMillis()
    {
        return 0;
    }

    public int GetMinimumValue()
    {
        // call: p961c80d7.getField
        // call: p961c80d7.getMillis
        // call: p8b1ed2c5.getMinimumValue
        return 0;
    }

    public int GetMinimumValueOverall()
    {
        // call: p8b1ed2c5.getMinimumValue
        // call: p961c80d7.getField
        return 0;
    }

    public string GetName()
    {
        // call: p8b1ed2c5.getName
        // call: p961c80d7.getField
        return string.Empty;
    }

    public p5636e72f GetRangeDurationField()
    {
        // call: p961c80d7.getField
        // call: p8b1ed2c5.getRangeDurationField
        return default!;
    }

    public int HashCode()
    {
        // call: p961c80d7.get
        // call: p961c80d7.getChronology
        // call: p961c80d7.getFieldType
        // call: object.hashCode
        return 0;
    }

    public bool IsLeap()
    {
        // call: p8b1ed2c5.isLeap
        // call: p961c80d7.getMillis
        // call: p961c80d7.getField
        return false;
    }

    public long Remainder()
    {
        // call: p961c80d7.getMillis
        // call: p8b1ed2c5.remainder
        // call: p961c80d7.getField
        return 0;
    }

    public pd16dd01a ToInterval()
    {
        // call: p961c80d7.getMillis
        // call: p8b1ed2c5.roundFloor
        // call: p8b1ed2c5.add
        // call: p961c80d7.getField
        // call: pd16dd01a.<init>
        // call: p961c80d7.getChronology
        // type: pd16dd01a
        return default!;
    }

    public string ToString()
    {
        // str: "]"
        // str: "Property["
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: p961c80d7.getName
        // call: StringBuilder.append
        // type: StringBuilder
        return string.Empty;
    }

}
