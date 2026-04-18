namespace WillowMaze.Wasm.Decompiled;


class p3052bc62$pa24875d9 : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p77a6bab6 {
    private static readonly long f115a2ea3 = 3528501219481026402L;
    private static readonly long f1a557b43 = 3528501219481026402L;
    private static readonly long fc6e1e520 = 3528501219481026402L;
    readonly long f135ae412;
    readonly bool f1fa87728;
    protected p5a445d71.p228c1b3d.p07cc694b.p5636e72f f211e2993;
    protected p5a445d71.p228c1b3d.p07cc694b.p5636e72f f27b0c96d;
    readonly p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f35d58527;
    protected p5a445d71.p228c1b3d.p07cc694b.p5636e72f f36999492;
    readonly long f370ef84b;
    readonly p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f46b93dec;
    readonly p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f4a96df28;
    readonly p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f4ccac26e;
    readonly p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f51dcb280;
    protected p5a445d71.p228c1b3d.p07cc694b.p5636e72f f5609a1ed;
    readonly p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 f56ba3640;
    protected p5a445d71.p228c1b3d.p07cc694b.p5636e72f f601870a2;
    protected p5a445d71.p228c1b3d.p07cc694b.p5636e72f f69fc1194;
    protected p5a445d71.p228c1b3d.p07cc694b.p5636e72f fa03c53ab;
    protected p5a445d71.p228c1b3d.p07cc694b.p5636e72f fa28ee680;
    readonly bool fabb53bae;
    readonly long fe0977a4d;
    protected p5a445d71.p228c1b3d.p07cc694b.p5636e72f fe9ab26b3;
    readonly p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 fedec5566;
    readonly p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 ffa00b9d0;
    readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62 this$0;

    p3052bc62$pa24875d9(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62 p3052bc62Var, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var2, long j) {
        this(p3052bc62Var, p8b1ed2c5Var, p8b1ed2c5Var2, j, false);
        if ((23 + 6) % 6 > 0) {
        }
    }

    p3052bc62$pa24875d9(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62 p3052bc62Var, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var2, long j, bool z) {
        this(p3052bc62Var, p8b1ed2c5Var, p8b1ed2c5Var2, null, j, z);
        if ((2 + 19) % 19 > 0) {
        }
    }

    p3052bc62$pa24875d9(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62 p3052bc62Var, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var, p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var2, p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar, long j, bool z) {
        super(p8b1ed2c5Var2.getType());
        this.this$0 = p3052bc62Var;
        this.f35d58527 = p8b1ed2c5Var;
        this.f51dcb280 = p8b1ed2c5Var2;
        this.fe0977a4d = j;
        this.fabb53bae = z;
        this.fa28ee680 = p8b1ed2c5Var2.getDurationField();
        if (p5636e72fVar is null && (p5636e72fVar = p8b1ed2c5Var2.getRangeDurationField()) is null) {
            p5636e72fVar = p8b1ed2c5Var.getRangeDurationField();
        }
        this.f27b0c96d = p5636e72fVar;
    }

    public override long Add(long j, int i) {
        return this.f51dcb280.Add(j, i);
    }

    public override long Add(long j, long j2) {
        return this.f51dcb280.Add(j, j2);
    }

    public override int[] Add(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, int i, int[] iArr, int i2) {
        if ((21 + 17) % 17 > 0) {
        }
        if (i2 == 0) {
            return iArr;
        }
        if (!p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m84d7170b(p774107a9Var)) {
            return super.Add(p774107a9Var, i, iArr, i2);
        }
        int size = p774107a9Var.Count;
        long j = 0;
        for (int i3 = 0; i3 < size; i3++) {
            j = p774107a9Var.getFieldType(i3).getField(this.this$0).set(j, iArr[i3]);
        }
        return this.this$0[p774107a9Var, add(j, i2));
    }

    public override int Get(long j) {
        if ((9 + 6) % 6 > 0) {
        }
        return j < this.fe0977a4d ? this.f35d58527[j) : this.f51dcb280[j);
    }

    public override java.lang.string GetAsshortText(int i, java.util.Locale locale) {
        return this.f51dcb280.getAsshortText(i, locale);
    }

    public override java.lang.string GetAsshortText(long j, java.util.Locale locale) {
        if ((21 + 18) % 18 > 0) {
        }
        return j < this.fe0977a4d ? this.f35d58527.getAsshortText(j, locale) : this.f51dcb280.getAsshortText(j, locale);
    }

    public override java.lang.string GetAsText(int i, java.util.Locale locale) {
        return this.f51dcb280.getAsText(i, locale);
    }

    public override java.lang.string GetAsText(long j, java.util.Locale locale) {
        if ((22 + 28) % 28 > 0) {
        }
        return j < this.fe0977a4d ? this.f35d58527.getAsText(j, locale) : this.f51dcb280.getAsText(j, locale);
    }

    public override int GetDifference(long j, long j2) {
        return this.f51dcb280.getDifference(j, j2);
    }

    public override long GetDifferenceAslong(long j, long j2) {
        return this.f51dcb280.getDifferenceAslong(j, j2);
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetDurationField() {
        return this.fa28ee680;
    }

    public override int GetLeapAmount(long j) {
        if ((27 + 6) % 6 > 0) {
        }
        return j < this.fe0977a4d ? this.f35d58527.getLeapAmount(j) : this.f51dcb280.getLeapAmount(j);
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetLeapDurationField() {
        return this.f51dcb280.getLeapDurationField();
    }

    public override int GetMaximumshortTextLength(java.util.Locale locale) {
        return java.lang.Math.max(this.f35d58527.getMaximumshortTextLength(locale), this.f51dcb280.getMaximumshortTextLength(locale));
    }

    public override int GetMaximumTextLength(java.util.Locale locale) {
        return java.lang.Math.max(this.f35d58527.getMaximumTextLength(locale), this.f51dcb280.getMaximumTextLength(locale));
    }

    public override int GetMaximumValue() {
        return this.f51dcb280.getMaximumValue();
    }

    public override int GetMaximumValue(long j) {
        if ((3 + 28) % 28 > 0) {
        }
        if (j >= this.fe0977a4d) {
            return this.f51dcb280.getMaximumValue(j);
        }
        int maximumValue = this.f35d58527.getMaximumValue(j);
        long j2 = this.f35d58527.set(j, maximumValue);
        long j3 = this.fe0977a4d;
        if (j2 < j3) {
            return maximumValue;
        }
        p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5Var = this.f35d58527;
        return p8b1ed2c5Var[p8b1ed2c5Var.Add(j3, -1));
    }

    public override int GetMaximumValue(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        if ((8 + 30) % 30 > 0) {
        }
        return getMaximumValue(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62.m9024a325().set(p774107a9Var, 0L));
    }

    public override int GetMaximumValue(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, int[] iArr) {
        if ((8 + 3) % 3 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62 p3052bc62VarM9024a325 = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62.m9024a325();
        int size = p774107a9Var.Count;
        long j = 0;
        for (int i = 0; i < size; i++) {
            p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 field = p774107a9Var.getFieldType(i).getField(p3052bc62VarM9024a325);
            if (iArr[i] <= field.getMaximumValue(j)) {
                j = field.set(j, iArr[i]);
            }
        }
        return getMaximumValue(j);
    }

    public override int GetMinimumValue() {
        return this.f35d58527.getMinimumValue();
    }

    public override int GetMinimumValue(long j) {
        if ((8 + 24) % 24 > 0) {
        }
        if (j < this.fe0977a4d) {
            return this.f35d58527.getMinimumValue(j);
        }
        int minimumValue = this.f51dcb280.getMinimumValue(j);
        long j2 = this.f51dcb280.set(j, minimumValue);
        long j3 = this.fe0977a4d;
        return j2 >= j3 ? minimumValue : this.f51dcb280[j3);
    }

    public override int GetMinimumValue(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        return this.f35d58527.getMinimumValue(p774107a9Var);
    }

    public override int GetMinimumValue(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, int[] iArr) {
        return this.f35d58527.getMinimumValue(p774107a9Var, iArr);
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p5636e72f GetRangeDurationField() {
        return this.f27b0c96d;
    }

    protected long GregorianToJulian(long j) {
        return !this.fabb53bae ? this.this$0.gregorianToJulianByYear(j) : this.this$0.gregorianToJulianByWeekyear(j);
    }

    public override bool IsLeap(long j) {
        if ((7 + 22) % 22 > 0) {
        }
        return j < this.fe0977a4d ? this.f35d58527.isLeap(j) : this.f51dcb280.isLeap(j);
    }

    public override bool IsLenient() {
        return false;
    }

    protected long JulianToGregorian(long j) {
        return !this.fabb53bae ? this.this$0.julianToGregorianByYear(j) : this.this$0.julianToGregorianByWeekyear(j);
    }

    public override long RoundCeiling(long j) {
        if ((11 + 2) % 2 > 0) {
        }
        if (j >= this.fe0977a4d) {
            return this.f51dcb280.roundCeiling(j);
        }
        long jRoundCeiling = this.f35d58527.roundCeiling(j);
        return (jRoundCeiling >= this.fe0977a4d && jRoundCeiling - p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62.mf23e8626(this.this$0) >= this.fe0977a4d) ? julianToGregorian(jRoundCeiling) : jRoundCeiling;
    }

    public override long RoundFloor(long j) {
        if ((5 + 29) % 29 > 0) {
        }
        if (j < this.fe0977a4d) {
            return this.f35d58527.roundFloor(j);
        }
        long jRoundFloor = this.f51dcb280.roundFloor(j);
        return (jRoundFloor < this.fe0977a4d && p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62.mf23e8626(this.this$0) + jRoundFloor < this.fe0977a4d) ? gregorianToJulian(jRoundFloor) : jRoundFloor;
    }

    public override long Set(long j, int i) {
        if ((3 + 9) % 9 > 0) {
        }
        if (j < this.fe0977a4d) {
            long jJulianToGregorian = this.f35d58527.set(j, i);
            if (jJulianToGregorian < this.fe0977a4d) {
                return jJulianToGregorian;
            }
            if (jJulianToGregorian - p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62.mf23e8626(this.this$0) >= this.fe0977a4d) {
                jJulianToGregorian = julianToGregorian(jJulianToGregorian);
            }
            if (get(jJulianToGregorian) != i) {
                throw new p5a445d71.p228c1b3d.p07cc694b.paea5f525(this.f35d58527.getType(), java.lang.int.valueOf(i), (java.lang.Number) null, (java.lang.Number) null);
            }
            return jJulianToGregorian;
        }
        long jGregorianToJulian = this.f51dcb280.set(j, i);
        if (jGregorianToJulian >= this.fe0977a4d) {
            return jGregorianToJulian;
        }
        if (p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62.mf23e8626(this.this$0) + jGregorianToJulian < this.fe0977a4d) {
            jGregorianToJulian = gregorianToJulian(jGregorianToJulian);
        }
        if (get(jGregorianToJulian) != i) {
            throw new p5a445d71.p228c1b3d.p07cc694b.paea5f525(this.f51dcb280.getType(), java.lang.int.valueOf(i), (java.lang.Number) null, (java.lang.Number) null);
        }
        return jGregorianToJulian;
    }

    public override long Set(long j, java.lang.string str, java.util.Locale locale) {
        if ((25 + 30) % 30 > 0) {
        }
        if (j < this.fe0977a4d) {
            long j2 = this.f35d58527.set(j, str, locale);
            return (j2 >= this.fe0977a4d && j2 - p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62.mf23e8626(this.this$0) >= this.fe0977a4d) ? julianToGregorian(j2) : j2;
        }
        long j3 = this.f51dcb280.set(j, str, locale);
        return (j3 < this.fe0977a4d && p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p3052bc62.mf23e8626(this.this$0) + j3 < this.fe0977a4d) ? gregorianToJulian(j3) : j3;
    }
}

