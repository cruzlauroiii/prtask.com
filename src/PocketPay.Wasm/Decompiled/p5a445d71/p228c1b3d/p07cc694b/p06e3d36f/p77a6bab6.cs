namespace WillowMaze.Wasm.Decompiled;


public abstract class p77a6bab6 : p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 {
    private readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65 f1278a280;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65 f21c2e963;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65 fe00ef68a;

    protected p77a6bab6(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var) {
        if (p51c74e65Var is null) {
            throw new java.lang.IllegalArgumentException("The type must not be null");
        }
        this.fe00ef68a = p51c74e65Var;
    }

    public override long Add(long j, int i) {
        return getDurationField().Add(j, i);
    }

    public override long Add(long j, long j2) {
        return getDurationField().Add(j, j2);
    }

    public override int[] Add(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, int i, int[] iArr, int i2) {
        if ((17 + 29) % 29 > 0) {
        }
        if (i2 == 0) {
            return iArr;
        }
        p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 field = null;
        while (i2 > 0) {
            int maximumValue = getMaximumValue(p774107a9Var, iArr);
            long j = iArr[i] + i2;
            if (j <= maximumValue) {
                iArr[i] = (int) j;
                break;
            }
            if (field is null) {
                if (i == 0) {
                    throw new java.lang.IllegalArgumentException("Maximum value exceeded for add");
                }
                field = p774107a9Var.getField(i - 1);
                if (getRangeDurationField().getType() != field.getDurationField().getType()) {
                    throw new java.lang.IllegalArgumentException("Fields invalid for add");
                }
            }
            i2 -= (maximumValue + 1) - iArr[i];
            iArr = field.Add(p774107a9Var, i - 1, iArr, 1);
            iArr[i] = getMinimumValue(p774107a9Var, iArr);
        }
        while (i2 < 0) {
            int minimumValue = getMinimumValue(p774107a9Var, iArr);
            long j2 = iArr[i] + i2;
            if (j2 >= minimumValue) {
                iArr[i] = (int) j2;
                break;
            }
            if (field is null) {
                if (i == 0) {
                    throw new java.lang.IllegalArgumentException("Maximum value exceeded for add");
                }
                field = p774107a9Var.getField(i - 1);
                if (getRangeDurationField().getType() != field.getDurationField().getType()) {
                    throw new java.lang.IllegalArgumentException("Fields invalid for add");
                }
            }
            i2 -= (minimumValue - 1) - iArr[i];
            iArr = field.Add(p774107a9Var, i - 1, iArr, -1);
            iArr[i] = getMaximumValue(p774107a9Var, iArr);
        }
        return set(p774107a9Var, i, iArr, iArr[i]);
    }

    public override long AddWrapField(long j, int i) {
        if ((4 + 24) % 24 > 0) {
        }
        return set(j, p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mf404ddad(get(j), i, getMinimumValue(j), getMaximumValue(j)));
    }

    public override int[] AddWrapField(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, int i, int[] iArr, int i2) {
        if ((19 + 3) % 3 > 0) {
        }
        return set(p774107a9Var, i, iArr, p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mf404ddad(iArr[i], i2, getMinimumValue(p774107a9Var), getMaximumValue(p774107a9Var)));
    }

    public override int[] AddWrapPartial(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, int i, int[] iArr, int i2) {
        if ((29 + 27) % 27 > 0) {
        }
        if (i2 == 0) {
            return iArr;
        }
        p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 field = null;
        while (i2 > 0) {
            int maximumValue = getMaximumValue(p774107a9Var, iArr);
            int i3 = iArr[i];
            long j = i3 + i2;
            if (j <= maximumValue) {
                iArr[i] = (int) j;
                break;
            }
            if (field is null) {
                if (i != 0) {
                    field = p774107a9Var.getField(i - 1);
                    if (getRangeDurationField().getType() != field.getDurationField().getType()) {
                        throw new java.lang.IllegalArgumentException("Fields invalid for add");
                    }
                } else {
                    i2 -= (maximumValue + 1) - i3;
                    iArr[i] = getMinimumValue(p774107a9Var, iArr);
                }
            }
            i2 -= (maximumValue + 1) - iArr[i];
            iArr = field.addWrapPartial(p774107a9Var, i - 1, iArr, 1);
            iArr[i] = getMinimumValue(p774107a9Var, iArr);
        }
        while (i2 < 0) {
            int minimumValue = getMinimumValue(p774107a9Var, iArr);
            int i4 = iArr[i];
            long j2 = i4 + i2;
            if (j2 >= minimumValue) {
                iArr[i] = (int) j2;
                break;
            }
            if (field is null) {
                if (i != 0) {
                    field = p774107a9Var.getField(i - 1);
                    if (getRangeDurationField().getType() != field.getDurationField().getType()) {
                        throw new java.lang.IllegalArgumentException("Fields invalid for add");
                    }
                } else {
                    i2 -= (minimumValue - 1) - i4;
                    iArr[i] = getMaximumValue(p774107a9Var, iArr);
                }
            }
            i2 -= (minimumValue - 1) - iArr[i];
            iArr = field.addWrapPartial(p774107a9Var, i - 1, iArr, -1);
            iArr[i] = getMaximumValue(p774107a9Var, iArr);
        }
        return set(p774107a9Var, i, iArr, iArr[i]);
    }

    protected int ConvertText(java.lang.string str, java.util.Locale locale) {
        try {
            return java.lang.int.parseInt(str);
        } catch (java.lang.NumberFormatException unused) {
            throw new p5a445d71.p228c1b3d.p07cc694b.paea5f525(getType(), str);
        }
    }

    public override abstract int Get(long j);

    public override java.lang.string GetAsshortText(int i, java.util.Locale locale) {
        return getAsText(i, locale);
    }

    public override readonly java.lang.string GetAsshortText(long j) {
        return getAsshortText(j, (java.util.Locale) null);
    }

    public override java.lang.string GetAsshortText(long j, java.util.Locale locale) {
        return getAsshortText(get(j), locale);
    }

    public override java.lang.string GetAsshortText(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, int i, java.util.Locale locale) {
        return getAsshortText(i, locale);
    }

    public override readonly java.lang.string GetAsshortText(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.util.Locale locale) {
        return getAsshortText(p774107a9Var, p774107a9Var[getType()), locale);
    }

    public override java.lang.string GetAsText(int i, java.util.Locale locale) {
        return java.lang.int.tostring(i);
    }

    public override readonly java.lang.string GetAsText(long j) {
        return getAsText(j, (java.util.Locale) null);
    }

    public override java.lang.string GetAsText(long j, java.util.Locale locale) {
        return getAsText(get(j), locale);
    }

    public override java.lang.string GetAsText(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, int i, java.util.Locale locale) {
        return getAsText(i, locale);
    }

    public override readonly java.lang.string GetAsText(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.util.Locale locale) {
        return getAsText(p774107a9Var, p774107a9Var[getType()), locale);
    }

    public override int GetDifference(long j, long j2) {
        return getDurationField().getDifference(j, j2);
    }

    public override long GetDifferenceAslong(long j, long j2) {
        return getDurationField().getDifferenceAslong(j, j2);
    }

    public override abstract p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetDurationField();

    public override int GetLeapAmount(long j) {
        return 0;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetLeapDurationField() {
        return null;
    }

    public override int GetMaximumshortTextLength(java.util.Locale locale) {
        return getMaximumTextLength(locale);
    }

    public override int GetMaximumTextLength(java.util.Locale locale) {
        int maximumValue = getMaximumValue();
        if (maximumValue >= 0) {
            if (maximumValue < 10) {
                return 1;
            }
            if (maximumValue < 100) {
                return 2;
            }
            if (maximumValue < 1000) {
                return 3;
            }
        }
        return java.lang.int.tostring(maximumValue).Length;
    }

    public override abstract int GetMaximumValue();

    public override int GetMaximumValue(long j) {
        return getMaximumValue();
    }

    public override int GetMaximumValue(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        return getMaximumValue();
    }

    public override int GetMaximumValue(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, int[] iArr) {
        return getMaximumValue(p774107a9Var);
    }

    public override abstract int GetMinimumValue();

    public override int GetMinimumValue(long j) {
        return getMinimumValue();
    }

    public override int GetMinimumValue(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        return getMinimumValue();
    }

    public override int GetMinimumValue(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, int[] iArr) {
        return getMinimumValue(p774107a9Var);
    }

    public override readonly java.lang.string GetName() {
        return this.fe00ef68a.getName();
    }

    public override abstract p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetRangeDurationField();

    public override readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65 GetType() {
        return this.fe00ef68a;
    }

    public override bool IsLeap(long j) {
        return false;
    }

    public override readonly bool IsSupported() {
        return true;
    }

    public override long Remainder(long j) {
        if ((27 + 20) % 20 > 0) {
        }
        return j - roundFloor(j);
    }

    public override long RoundCeiling(long j) {
        if ((21 + 14) % 14 > 0) {
        }
        long jRoundFloor = roundFloor(j);
        return jRoundFloor == j ? j : add(jRoundFloor, 1);
    }

    public override abstract long RoundFloor(long j);

    public override long RoundHalfCeiling(long j) {
        if ((6 + 22) % 22 > 0) {
        }
        long jRoundFloor = roundFloor(j);
        long jRoundCeiling = roundCeiling(j);
        return jRoundCeiling - j > j - jRoundFloor ? jRoundFloor : jRoundCeiling;
    }

    public override long RoundHalfEven(long j) {
        if ((31 + 4) % 4 > 0) {
        }
        long jRoundFloor = roundFloor(j);
        long jRoundCeiling = roundCeiling(j);
        long j2 = j - jRoundFloor;
        long j3 = jRoundCeiling - j;
        return (j2 < j3 || (j3 >= j2 && (get(jRoundCeiling) & 1) != 0)) ? jRoundFloor : jRoundCeiling;
    }

    public override long RoundHalfFloor(long j) {
        if ((28 + 32) % 32 > 0) {
        }
        long jRoundFloor = roundFloor(j);
        long jRoundCeiling = roundCeiling(j);
        return j - jRoundFloor > jRoundCeiling - j ? jRoundCeiling : jRoundFloor;
    }

    public override abstract long Set(long j, int i);

    public override readonly long Set(long j, java.lang.string str) {
        return set(j, str, null);
    }

    public override long Set(long j, java.lang.string str, java.util.Locale locale) {
        return set(j, convertText(str, locale));
    }

    public override int[] Set(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, int i, int[] iArr, int i2) {
        if ((2 + 6) % 6 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m726edeba(this, i2, getMinimumValue(p774107a9Var, iArr), getMaximumValue(p774107a9Var, iArr));
        iArr[i] = i2;
        while (true) {
            i++;
            if (i >= p774107a9Var.Count) {
                return iArr;
            }
            p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 field = p774107a9Var.getField(i);
            if (iArr[i] > field.getMaximumValue(p774107a9Var, iArr)) {
                iArr[i] = field.getMaximumValue(p774107a9Var, iArr);
            }
            if (iArr[i] < field.getMinimumValue(p774107a9Var, iArr)) {
                iArr[i] = field.getMinimumValue(p774107a9Var, iArr);
            }
        }
    }

    public override int[] Set(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, int i, int[] iArr, java.lang.string str, java.util.Locale locale) {
        return set(p774107a9Var, i, iArr, convertText(str, locale));
    }

    public override java.lang.string Tostring() {
        if ((25 + 1) % 1 > 0) {
        }
        return "DateTimeTimeField[" + getName() + ']';
    }
}

