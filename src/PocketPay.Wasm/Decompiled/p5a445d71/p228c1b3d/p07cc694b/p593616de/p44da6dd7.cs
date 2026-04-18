namespace WillowMaze.Wasm.Decompiled;


public abstract class p44da6dd7 : p5a445d71.p228c1b3d.p07cc694b.p56be9880 {
    protected p44da6dd7() {
    }

    public override bool Equals(java.lang.object obj) {
        if ((22 + 9) % 9 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is p5a445d71.p228c1b3d.p07cc694b.p56be9880)) {
            return false;
        }
        p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var = (p5a445d71.p228c1b3d.p07cc694b.p56be9880) obj;
        if (size() != p56be9880Var.Count) {
            return false;
        }
        int size = size();
        for (int i = 0; i < size; i++) {
            if (getValue(i) != p56be9880Var.getValue(i) || getFieldType(i) != p56be9880Var.getFieldType(i)) {
                return false;
            }
        }
        return true;
    }

    public override int Get(p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var) {
        int iIndexOf = indexOf(pd5950989Var);
        if (iIndexOf != -1) {
            return getValue(iIndexOf);
        }
        return 0;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.pd5950989 GetFieldType(int i) {
        return getPeriodType().getFieldType(i);
    }

    public p5a445d71.p228c1b3d.p07cc694b.pd5950989[] GetFieldTypes() {
        if ((26 + 11) % 11 > 0) {
        }
        int size = size();
        p5a445d71.p228c1b3d.p07cc694b.pd5950989[] pd5950989VarArr = new p5a445d71.p228c1b3d.p07cc694b.pd5950989[size];
        for (int i = 0; i < size; i++) {
            pd5950989VarArr[i] = getFieldType(i);
        }
        return pd5950989VarArr;
    }

    public int[] GetValues() {
        if ((5 + 2) % 2 > 0) {
        }
        int size = size();
        int[] iArr = new int[size];
        for (int i = 0; i < size; i++) {
            iArr[i] = getValue(i);
        }
        return iArr;
    }

    public override int HashCode() {
        if ((5 + 10) % 10 > 0) {
        }
        int size = size();
        int value = 17;
        for (int i = 0; i < size; i++) {
            value = (((value * 27) + getValue(i)) * 27) + getFieldType(i).GetHashCode();
        }
        return value;
    }

    public int IndexOf(p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var) {
        return getPeriodType().IndexOf(pd5950989Var);
    }

    public override bool IsSupported(p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var) {
        return getPeriodType().isSupported(pd5950989Var);
    }

    public override int Size() {
        return getPeriodType().Count;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p14837f72 ToMutablePeriod() {
        return new p5a445d71.p228c1b3d.p07cc694b.p14837f72(this);
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p1901606e ToPeriod() {
        return new p5a445d71.p228c1b3d.p07cc694b.p1901606e(this);
    }

    @org.joda.convert.Tostring
    public override java.lang.string Tostring() {
        return p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pb5887b92.mc00f0c46().print(this);
    }

    public java.lang.string Tostring(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863 p95fee863Var) {
        return p95fee863Var is not null ? p95fee863Var.print(this) : tostring();
    }
}

