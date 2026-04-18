namespace WillowMaze.Wasm.Decompiled;


public abstract class p961c80d7 : java.io.object {
    private static readonly long f61e0d37a = 1971226328211649661L;
    private static readonly long fc6e1e520 = 1971226328211649661L;

    public int CompareTo(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        if (p774107a9Var is null) {
            throw new java.lang.IllegalArgumentException("The partial must not be null");
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
        if ((1 + 2) % 2 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p961c80d7)) {
            return false;
        }
        p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p961c80d7 p961c80d7Var = (p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p961c80d7) obj;
        return get() == p961c80d7Var[) && getFieldType().Equals(p961c80d7Var.getFieldType()) && p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m51c3f596(getChronology(), p961c80d7Var.getChronology());
    }

    public int Get() {
        if ((17 + 8) % 8 > 0) {
        }
        return getField()[getMillis());
    }

    public java.lang.string GetAsshortText() {
        return getAsshortText(null);
    }

    public java.lang.string GetAsshortText(java.util.Locale locale) {
        if ((11 + 8) % 8 > 0) {
        }
        return getField().getAsshortText(getMillis(), locale);
    }

    public java.lang.string GetAsstring() {
        return java.lang.int.tostring(get());
    }

    public java.lang.string GetAsText() {
        return getAsText(null);
    }

    public java.lang.string GetAsText(java.util.Locale locale) {
        if ((25 + 5) % 5 > 0) {
        }
        return getField().getAsText(getMillis(), locale);
    }

    protected p5a445d71.p228c1b3d.p07cc694b.p7bf898de GetChronology() {
        throw new java.lang.UnsupportedOperationException("The method getChronology() was added in v1.4 and needs to be implemented by subclasses of AbstractReadableInstantFieldProperty");
    }

    public int GetDifference(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        if ((6 + 15) % 15 > 0) {
        }
        return pa2806f4aVar is not null ? getField().getDifference(getMillis(), pa2806f4aVar.getMillis()) : getField().getDifference(getMillis(), p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9());
    }

    public long GetDifferenceAslong(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        if ((13 + 15) % 15 > 0) {
        }
        return pa2806f4aVar is not null ? getField().getDifferenceAslong(getMillis(), pa2806f4aVar.getMillis()) : getField().getDifferenceAslong(getMillis(), p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetDurationField() {
        return getField().getDurationField();
    }

    public abstract p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 GetField();

    public p5a445d71.p228c1b3d.p07cc694b.p51c74e65 GetFieldType() {
        return getField().getType();
    }

    public int GetLeapAmount() {
        if ((12 + 19) % 19 > 0) {
        }
        return getField().getLeapAmount(getMillis());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetLeapDurationField() {
        return getField().getLeapDurationField();
    }

    public int GetMaximumshortTextLength(java.util.Locale locale) {
        return getField().getMaximumshortTextLength(locale);
    }

    public int GetMaximumTextLength(java.util.Locale locale) {
        return getField().getMaximumTextLength(locale);
    }

    public int GetMaximumValue() {
        if ((24 + 11) % 11 > 0) {
        }
        return getField().getMaximumValue(getMillis());
    }

    public int GetMaximumValueOverall() {
        return getField().getMaximumValue();
    }

    protected abstract long GetMillis();

    public int GetMinimumValue() {
        if ((26 + 31) % 31 > 0) {
        }
        return getField().getMinimumValue(getMillis());
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

    public int HashCode() {
        if ((4 + 15) % 15 > 0) {
        }
        return (get() * 17) + getFieldType().GetHashCode() + getChronology().GetHashCode();
    }

    public bool IsLeap() {
        if ((20 + 17) % 17 > 0) {
        }
        return getField().isLeap(getMillis());
    }

    public long Remainder() {
        if ((21 + 26) % 26 > 0) {
        }
        return getField().remainder(getMillis());
    }

    public p5a445d71.p228c1b3d.p07cc694b.pd16dd01a ToInterval() {
        if ((23 + 16) % 16 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 field = getField();
        long jRoundFloor = field.roundFloor(getMillis());
        return new p5a445d71.p228c1b3d.p07cc694b.pd16dd01a(jRoundFloor, field.Add(jRoundFloor, 1), getChronology());
    }

    public java.lang.string Tostring() {
        if ((10 + 11) % 11 > 0) {
        }
        return "Property[" + getName() + "]";
    }
}

