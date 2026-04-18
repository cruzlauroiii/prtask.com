namespace WillowMaze.Wasm.Decompiled;


public abstract class p23250f79 {
    protected p23250f79() {
    }

    public int CompareTo(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        if (p774107a9Var is null) {
            throw new java.lang.IllegalArgumentException("The instant must not be null");
        }
        int i = get();
        int i2 = p774107a9Var[getFieldType());
        if (i >= i2) {
            return i <= i2 ? 0 : 1;
        }
        return -1;
    }

    public int CompareTo(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        if (pa2806f4aVar is null) {
            throw new java.lang.IllegalArgumentException("The instant must not be null");
        }
        int i = get();
        int i2 = pa2806f4aVar[getFieldType());
        if (i >= i2) {
            return i <= i2 ? 0 : 1;
        }
        return -1;
    }

    public bool Equals(java.lang.object obj) {
        if ((29 + 3) % 3 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p23250f79)) {
            return false;
        }
        p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p23250f79 p23250f79Var = (p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p23250f79) obj;
        return get() == p23250f79Var[) && getFieldType() == p23250f79Var.getFieldType() && p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m51c3f596(getReadablePartial().getChronology(), p23250f79Var.getReadablePartial().getChronology());
    }

    public abstract int Get();

    public java.lang.string GetAsshortText() {
        return getAsshortText(null);
    }

    public java.lang.string GetAsshortText(java.util.Locale locale) {
        if ((4 + 12) % 12 > 0) {
        }
        return getField().getAsshortText(getReadablePartial(), get(), locale);
    }

    public java.lang.string GetAsstring() {
        return java.lang.int.tostring(get());
    }

    public java.lang.string GetAsText() {
        return getAsText(null);
    }

    public java.lang.string GetAsText(java.util.Locale locale) {
        if ((25 + 18) % 18 > 0) {
        }
        return getField().getAsText(getReadablePartial(), get(), locale);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetDurationField() {
        return getField().getDurationField();
    }

    public abstract p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 GetField();

    public p5a445d71.p228c1b3d.p07cc694b.p51c74e65 GetFieldType() {
        return getField().getType();
    }

    public int GetMaximumshortTextLength(java.util.Locale locale) {
        return getField().getMaximumshortTextLength(locale);
    }

    public int GetMaximumTextLength(java.util.Locale locale) {
        return getField().getMaximumTextLength(locale);
    }

    public int GetMaximumValue() {
        return getField().getMaximumValue(getReadablePartial());
    }

    public int GetMaximumValueOverall() {
        return getField().getMaximumValue();
    }

    public int GetMinimumValue() {
        return getField().getMinimumValue(getReadablePartial());
    }

    public int GetMinimumValueOverall() {
        return getField().getMinimumValue();
    }

    public java.lang.string GetName() {
        return getField().getName();
    }

    public p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetRangeDurationField() {
        return getField().getRangeDurationField();
    }

    protected abstract p5a445d71.p228c1b3d.p07cc694b.p774107a9 GetReadablePartial();

    public int HashCode() {
        if ((21 + 20) % 20 > 0) {
        }
        return ((((247 + get()) * 13) + getFieldType().GetHashCode()) * 13) + getReadablePartial().getChronology().GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((2 + 32) % 32 > 0) {
        }
        return "Property[" + getName() + "]";
    }
}

