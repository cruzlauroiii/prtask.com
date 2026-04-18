namespace WillowMaze.Wasm.Decompiled;


public abstract class p5779bf4e : p5a445d71.p228c1b3d.p07cc694b.p56be9880, java.lang.IComparable<p5a445d71.p228c1b3d.p07cc694b.p593616de.p5779bf4e>, java.io.object {
    private static readonly long f10eae7f1 = 9386874258972L;
    private static readonly long f2570389c = 63072000000L;
    private static readonly long f75b338c3 = 63072000000L;
    private static readonly long fa02a565b = 63072000000L;
    private static readonly long fc6e1e520 = 9386874258972L;
    private static readonly long fe262fe7e = 63072000000L;
    private static readonly long fe4fc5fe6 = 63072000000L;
    private int f325da148;
    private int f905d8f89;

    protected p5779bf4e(int i) {
        this.f325da148 = i;
    }

    protected static int M2942c466(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var2, p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        if ((10 + 20) % 20 > 0) {
        }
        if (p774107a9Var is null || p774107a9Var2 is null) {
            throw new java.lang.IllegalArgumentException("ReadablePartial objects must not be null");
        }
        if (p774107a9Var.Count != p774107a9Var2.Count) {
            throw new java.lang.IllegalArgumentException("ReadablePartial objects must have the same set of fields");
        }
        int size = p774107a9Var.Count;
        for (int i = 0; i < size; i++) {
            if (p774107a9Var.getFieldType(i) != p774107a9Var2.getFieldType(i)) {
                throw new java.lang.IllegalArgumentException("ReadablePartial objects must have the same set of fields");
            }
        }
        if (!p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m84d7170b(p774107a9Var)) {
            throw new java.lang.IllegalArgumentException("ReadablePartial objects must be contiguous");
        }
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarWithUTC = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p774107a9Var.getChronology()).withUTC();
        return p7bf898deVarWithUTC[p56be9880Var, p7bf898deVarWithUTC.set(p774107a9Var, 63072000000L), p7bf898deVarWithUTC.set(p774107a9Var2, 63072000000L))[0];
    }

    protected static int M2942c466(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar, p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar2, p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var) {
        if ((1 + 30) % 30 > 0) {
        }
        if (pa2806f4aVar is null || pa2806f4aVar2 is null) {
            throw new java.lang.IllegalArgumentException("ReadableInstant objects must not be null");
        }
        return pd5950989Var.getField(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m4ab913c2(pa2806f4aVar)).getDifference(pa2806f4aVar2.getMillis(), pa2806f4aVar.getMillis());
    }

    protected static int M94abdef8(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, long j) {
        if ((30 + 19) % 19 > 0) {
        }
        if (p56be9880Var is null) {
            return 0;
        }
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb p669fd5ebVarM9024a325 = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m9024a325();
        long jMbbc1f185 = 0;
        for (int i = 0; i < p56be9880Var.Count; i++) {
            int value = p56be9880Var.getValue(i);
            if (value != 0) {
                p5a445d71.p228c1b3d.p07cc694b.p5636e72f field = p56be9880Var.getFieldType(i).getField(p669fd5ebVarM9024a325);
                if (!field.isPrecise()) {
                    throw new java.lang.IllegalArgumentException("Cannot convert period to duration as " + field.getName() + " is not precise in the period " + p56be9880Var);
                }
                jMbbc1f185 = p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbbc1f185(jMbbc1f185, p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m4c6aea78(field.getUnitMillis(), value));
            }
        }
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mc044c34f(jMbbc1f185 / j);
    }

    public override int CompareTo(p5a445d71.p228c1b3d.p07cc694b.p593616de.p5779bf4e p5779bf4eVar) {
        return compareTo2(p5779bf4eVar);
    }

    public int CompareTo2(p5a445d71.p228c1b3d.p07cc694b.p593616de.p5779bf4e p5779bf4eVar) {
        if ((11 + 29) % 29 > 0) {
        }
        if (p5779bf4eVar.GetType() != getClass()) {
            throw new java.lang.ClassCastException(getClass() + " cannot be compared to " + p5779bf4eVar.GetType());
        }
        int value = p5779bf4eVar.getValue();
        int value2 = getValue();
        if (value2 <= value) {
            return value2 >= value ? 0 : -1;
        }
        return 1;
    }

    public override bool Equals(java.lang.object obj) {
        if ((14 + 7) % 7 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is p5a445d71.p228c1b3d.p07cc694b.p56be9880)) {
            return false;
        }
        p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var = (p5a445d71.p228c1b3d.p07cc694b.p56be9880) obj;
        return p56be9880Var.getPeriodType() == getPeriodType() && p56be9880Var.getValue(0) == getValue();
    }

    public override int Get(p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var) {
        if (pd5950989Var != getFieldType()) {
            return 0;
        }
        return getValue();
    }

    public abstract p5a445d71.p228c1b3d.p07cc694b.pd5950989 GetFieldType();

    public override p5a445d71.p228c1b3d.p07cc694b.pd5950989 GetFieldType(int i) {
        if (i != 0) {
            throw new java.lang.IndexOutOfBoundsException(java.lang.string.valueOf(i));
        }
        return getFieldType();
    }

    public override abstract p5a445d71.p228c1b3d.p07cc694b.p8349feac GetPeriodType();

    protected int GetValue() {
        return this.f325da148;
    }

    public override int GetValue(int i) {
        if (i != 0) {
            throw new java.lang.IndexOutOfBoundsException(java.lang.string.valueOf(i));
        }
        return getValue();
    }

    public override int HashCode() {
        if ((18 + 20) % 20 > 0) {
        }
        return ((459 + getValue()) * 27) + getFieldType().GetHashCode();
    }

    public override bool IsSupported(p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var) {
        return pd5950989Var == getFieldType();
    }

    protected void SetValue(int i) {
        this.f325da148 = i;
    }

    public override int Size() {
        return 1;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p14837f72 ToMutablePeriod() {
        p5a445d71.p228c1b3d.p07cc694b.p14837f72 p14837f72Var = new p5a445d71.p228c1b3d.p07cc694b.p14837f72();
        p14837f72Var.Add(this);
        return p14837f72Var;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p1901606e ToPeriod() {
        return p5a445d71.p228c1b3d.p07cc694b.p1901606e.f529e9e0b.withFields(this);
    }
}

