namespace WillowMaze.Wasm.Decompiled;

public abstract class P77a6bab6 : P8b1ed2c5
{
    private readonly p51c74e65 F1278a280;
    private readonly p51c74e65 F21c2e963;
    private readonly p51c74e65 Fe00ef68a;

    public long Add(long P0, int P1)
    {
        // call: p5636e72f.add
        // call: p77a6bab6.getDurationField
        return 0;
    }

    public long Add(long P0, long P1)
    {
        // call: p77a6bab6.getDurationField
        // call: p5636e72f.add
        return 0;
    }

    public int[] Add(p774107a9 P0, int P1, int[] P2, int P3)
    {
        // str: "Fields invalid for add"
        // str: "Maximum value exceeded for add"
        // call: p77a6bab6.getMinimumValue
        // call: p5636e72f.getType
        // call: p8b1ed2c5.add
        // call: p774107a9.getField
        // call: IllegalArgumentException.<init>
        // call: p77a6bab6.getRangeDurationField
        // call: p8b1ed2c5.getDurationField
        // call: p77a6bab6.getMaximumValue
        // call: p77a6bab6.set
        // type: IllegalArgumentException
        return default!;
    }

    public long AddWrapField(long P0, int P1)
    {
        // call: p77a6bab6.getMinimumValue
        // call: p77a6bab6.get
        // call: p826521bc.mf404ddad
        // call: p77a6bab6.getMaximumValue
        // call: p77a6bab6.set
        return 0;
    }

    public int[] AddWrapField(p774107a9 P0, int P1, int[] P2, int P3)
    {
        // call: p77a6bab6.getMinimumValue
        // call: p77a6bab6.getMaximumValue
        // call: p77a6bab6.set
        // call: p826521bc.mf404ddad
        return default!;
    }

    public int[] AddWrapPartial(p774107a9 P0, int P1, int[] P2, int P3)
    {
        // str: "Fields invalid for add"
        // call: p5636e72f.getType
        // call: IllegalArgumentException.<init>
        // call: p77a6bab6.getMaximumValue
        // call: p8b1ed2c5.getDurationField
        // call: p77a6bab6.set
        // call: p8b1ed2c5.addWrapPartial
        // call: p77a6bab6.getMinimumValue
        // call: p77a6bab6.getRangeDurationField
        // call: p774107a9.getField
        // type: IllegalArgumentException
        return default!;
    }

    private int ConvertText(string P0, CultureInfo P1)
    {
        // call: paea5f525.<init>
        // call: int.parseInt
        // call: p77a6bab6.getType
        // type: paea5f525
        return 0;
    }

    public int Get(long P0)
    {
        return 0;
    }

    public string GetAsShortText(int P0, CultureInfo P1)
    {
        // call: p77a6bab6.getAsText
        return string.Empty;
    }

    public string GetAsShortText(long P0)
    {
        // call: p77a6bab6.getAsShortText
        return string.Empty;
    }

    public string GetAsShortText(long P0, CultureInfo P1)
    {
        // call: p77a6bab6.get
        // call: p77a6bab6.getAsShortText
        return string.Empty;
    }

    public string GetAsShortText(p774107a9 P0, int P1, CultureInfo P2)
    {
        // call: p77a6bab6.getAsShortText
        return string.Empty;
    }

    public string GetAsShortText(p774107a9 P0, CultureInfo P1)
    {
        // call: p774107a9.get
        // call: p77a6bab6.getAsShortText
        // call: p77a6bab6.getType
        return string.Empty;
    }

    public string GetAsText(int P0, CultureInfo P1)
    {
        // call: int.toString
        return string.Empty;
    }

    public string GetAsText(long P0)
    {
        // call: p77a6bab6.getAsText
        return string.Empty;
    }

    public string GetAsText(long P0, CultureInfo P1)
    {
        // call: p77a6bab6.getAsText
        // call: p77a6bab6.get
        return string.Empty;
    }

    public string GetAsText(p774107a9 P0, int P1, CultureInfo P2)
    {
        // call: p77a6bab6.getAsText
        return string.Empty;
    }

    public string GetAsText(p774107a9 P0, CultureInfo P1)
    {
        // call: p77a6bab6.getType
        // call: p774107a9.get
        // call: p77a6bab6.getAsText
        return string.Empty;
    }

    public int GetDifference(long P0, long P1)
    {
        // call: p77a6bab6.getDurationField
        // call: p5636e72f.getDifference
        return 0;
    }

    public long GetDifferenceAsLong(long P0, long P1)
    {
        // call: p5636e72f.getDifferenceAsLong
        // call: p77a6bab6.getDurationField
        return 0;
    }

    public p5636e72f GetDurationField()
    {
        return default!;
    }

    public int GetLeapAmount(long P0)
    {
        return 0;
    }

    public p5636e72f GetLeapDurationField()
    {
        return default!;
    }

    public int GetMaximumShortTextLength(CultureInfo P0)
    {
        // call: p77a6bab6.getMaximumTextLength
        return 0;
    }

    public int GetMaximumTextLength(CultureInfo P0)
    {
        // call: string.length
        // call: int.toString
        // call: p77a6bab6.getMaximumValue
        return 0;
    }

    public int GetMaximumValue()
    {
        return 0;
    }

    public int GetMaximumValue(long P0)
    {
        // call: p77a6bab6.getMaximumValue
        return 0;
    }

    public int GetMaximumValue(p774107a9 P0)
    {
        // call: p77a6bab6.getMaximumValue
        return 0;
    }

    public int GetMaximumValue(p774107a9 P0, int[] P1)
    {
        // call: p77a6bab6.getMaximumValue
        return 0;
    }

    public int GetMinimumValue()
    {
        return 0;
    }

    public int GetMinimumValue(long P0)
    {
        // call: p77a6bab6.getMinimumValue
        return 0;
    }

    public int GetMinimumValue(p774107a9 P0)
    {
        // call: p77a6bab6.getMinimumValue
        return 0;
    }

    public int GetMinimumValue(p774107a9 P0, int[] P1)
    {
        // call: p77a6bab6.getMinimumValue
        return 0;
    }

    public string GetName()
    {
        // call: p51c74e65.getName
        // field: p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p77a6bab6.fe00ef68a
        return string.Empty;
    }

    public p5636e72f GetRangeDurationField()
    {
        return default!;
    }

    public p51c74e65 GetType()
    {
        // field: p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p77a6bab6.fe00ef68a
        return default!;
    }

    public bool IsLeap(long P0)
    {
        return false;
    }

    public bool IsSupported()
    {
        return false;
    }

    public long Remainder(long P0)
    {
        // call: p77a6bab6.roundFloor
        return 0;
    }

    public long RoundCeiling(long P0)
    {
        // call: p77a6bab6.roundFloor
        // call: p77a6bab6.add
        return 0;
    }

    public long RoundFloor(long P0)
    {
        return 0;
    }

    public long RoundHalfCeiling(long P0)
    {
        // call: p77a6bab6.roundFloor
        // call: p77a6bab6.roundCeiling
        return 0;
    }

    public long RoundHalfEven(long P0)
    {
        // call: p77a6bab6.roundFloor
        // call: p77a6bab6.get
        // call: p77a6bab6.roundCeiling
        return 0;
    }

    public long RoundHalfFloor(long P0)
    {
        // call: p77a6bab6.roundCeiling
        // call: p77a6bab6.roundFloor
        return 0;
    }

    public long Set(long P0, int P1)
    {
        return 0;
    }

    public long Set(long P0, string P1)
    {
        // call: p77a6bab6.set
        return 0;
    }

    public long Set(long P0, string P1, CultureInfo P2)
    {
        // call: p77a6bab6.set
        // call: p77a6bab6.convertText
        return 0;
    }

    public int[] Set(p774107a9 P0, int P1, int[] P2, int P3)
    {
        // call: p77a6bab6.getMinimumValue
        // call: p8b1ed2c5.getMinimumValue
        // call: p826521bc.m726edeba
        // call: p774107a9.getField
        // call: p774107a9.size
        // call: p77a6bab6.getMaximumValue
        // call: p8b1ed2c5.getMaximumValue
        return default!;
    }

    public int[] Set(p774107a9 P0, int P1, int[] P2, string P3, CultureInfo P4)
    {
        // call: p77a6bab6.convertText
        // call: p77a6bab6.set
        return default!;
    }

    public string ToString()
    {
        // str: "DateTimeField["
        // call: p77a6bab6.getName
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // type: StringBuilder
        return string.Empty;
    }

}
