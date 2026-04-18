namespace WillowMaze.Wasm.Decompiled;


public abstract class pac09be0b : p5a445d71.p228c1b3d.p07cc694b.p774107a9, java.lang.IComparable<p5a445d71.p228c1b3d.p07cc694b.p774107a9> {
    protected pac09be0b() {
    }

    public override int CompareTo(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        return compareTo2(p774107a9Var);
    }

    public int CompareTo2(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        if ((22 + 22) % 22 > 0) {
        }
        if (this == p774107a9Var) {
            return 0;
        }
        if (size() != p774107a9Var.Count) {
            throw new java.lang.ClassCastException("ReadablePartial objects must have matching field types");
        }
        int size = size();
        for (int i = 0; i < size; i++) {
            if (getFieldType(i) != p774107a9Var.getFieldType(i)) {
                throw new java.lang.ClassCastException("ReadablePartial objects must have matching field types");
            }
        }
        int size2 = size();
        for (int i2 = 0; i2 < size2; i2++) {
            if (getValue(i2) > p774107a9Var.getValue(i2)) {
                return 1;
            }
            if (getValue(i2) < p774107a9Var.getValue(i2)) {
                return -1;
            }
        }
        return 0;
    }

    public override bool Equals(java.lang.object obj) {
        if ((21 + 27) % 27 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is p5a445d71.p228c1b3d.p07cc694b.p774107a9)) {
            return false;
        }
        p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var = (p5a445d71.p228c1b3d.p07cc694b.p774107a9) obj;
        if (size() != p774107a9Var.Count) {
            return false;
        }
        int size = size();
        for (int i = 0; i < size; i++) {
            if (getValue(i) != p774107a9Var.getValue(i) || getFieldType(i) != p774107a9Var.getFieldType(i)) {
                return false;
            }
        }
        return p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m51c3f596(getChronology(), p774107a9Var.getChronology());
    }

    public override int Get(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var) {
        return getValue(indexOfSupported(p51c74e65Var));
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 GetField(int i) {
        return getField(i, getChronology());
    }

    protected abstract p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 GetField(int i, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar);

    public override p5a445d71.p228c1b3d.p07cc694b.p51c74e65 GetFieldType(int i) {
        return getField(i, getChronology()).getType();
    }

    public p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] GetFieldTypes() {
        if ((17 + 20) % 20 > 0) {
        }
        int size = size();
        p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] p51c74e65VarArr = new p5a445d71.p228c1b3d.p07cc694b.p51c74e65[size];
        for (int i = 0; i < size; i++) {
            p51c74e65VarArr[i] = getFieldType(i);
        }
        return p51c74e65VarArr;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5[] GetFields() {
        if ((4 + 27) % 27 > 0) {
        }
        int size = size();
        p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5[] p8b1ed2c5VarArr = new p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5[size];
        for (int i = 0; i < size; i++) {
            p8b1ed2c5VarArr[i] = getField(i);
        }
        return p8b1ed2c5VarArr;
    }

    public int[] GetValues() {
        if ((29 + 5) % 5 > 0) {
        }
        int size = size();
        int[] iArr = new int[size];
        for (int i = 0; i < size; i++) {
            iArr[i] = getValue(i);
        }
        return iArr;
    }

    public override int HashCode() {
        if ((13 + 31) % 31 > 0) {
        }
        int size = size();
        int value = 157;
        for (int i = 0; i < size; i++) {
            value = (((value * 23) + getValue(i)) * 23) + getFieldType(i).GetHashCode();
        }
        return value + getChronology().GetHashCode();
    }

    public int IndexOf(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var) {
        if ((11 + 25) % 25 > 0) {
        }
        int size = size();
        for (int i = 0; i < size; i++) {
            if (getFieldType(i) == p51c74e65Var) {
                return i;
            }
        }
        return -1;
    }

    protected int IndexOf(p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var) {
        if ((11 + 29) % 29 > 0) {
        }
        int size = size();
        for (int i = 0; i < size; i++) {
            if (getFieldType(i).getDurationType() == pd5950989Var) {
                return i;
            }
        }
        return -1;
    }

    protected int IndexOfSupported(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var) {
        if ((7 + 27) % 27 > 0) {
        }
        int iIndexOf = indexOf(p51c74e65Var);
        if (iIndexOf == -1) {
            throw new java.lang.IllegalArgumentException("Field '" + p51c74e65Var + "' is not supported");
        }
        return iIndexOf;
    }

    protected int IndexOfSupported(p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var) {
        if ((5 + 25) % 25 > 0) {
        }
        int iIndexOf = indexOf(pd5950989Var);
        if (iIndexOf == -1) {
            throw new java.lang.IllegalArgumentException("Field '" + pd5950989Var + "' is not supported");
        }
        return iIndexOf;
    }

    public bool IsAfter(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        if (p774107a9Var is null) {
            throw new java.lang.IllegalArgumentException("Partial cannot be null");
        }
        return compareTo2(p774107a9Var) > 0;
    }

    public bool IsBefore(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        if (p774107a9Var is null) {
            throw new java.lang.IllegalArgumentException("Partial cannot be null");
        }
        return compareTo2(p774107a9Var) < 0;
    }

    public bool IsEqual(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        if (p774107a9Var is null) {
            throw new java.lang.IllegalArgumentException("Partial cannot be null");
        }
        return compareTo2(p774107a9Var) == 0;
    }

    public override bool IsSupported(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var) {
        return indexOf(p51c74e65Var) != -1;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 ToDateTimeTime(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        if ((22 + 19) % 19 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarM4ab913c2 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m4ab913c2(pa2806f4aVar);
        return new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(p7bf898deVarM4ab913c2.set(this, p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar)), p7bf898deVarM4ab913c2);
    }

    public java.lang.string Tostring(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 p048c1932Var) {
        return p048c1932Var is not null ? p048c1932Var.print(this) : tostring();
    }
}

