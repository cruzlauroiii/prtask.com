namespace WillowMaze.Wasm.Decompiled;


public abstract class pb64d453b : p5a445d71.p228c1b3d.p07cc694b.p593616de.p44da6dd7 : p5a445d71.p228c1b3d.p07cc694b.p56be9880, java.io.object {
    private static readonly p5a445d71.p228c1b3d.p07cc694b.p56be9880 f31dac311 = new p5a445d71.p228c1b3d.p07cc694b.p593616de.pb64d453b$1();
    private static readonly p5a445d71.p228c1b3d.p07cc694b.p56be9880 f3fcf1e6e = null;
    private static readonly long f434ef74c = -2110953284060001145L;
    private static readonly long f7c039e01 = -2110953284060001145L;
    private static readonly p5a445d71.p228c1b3d.p07cc694b.p56be9880 f86a5d75e = null;
    private static readonly p5a445d71.p228c1b3d.p07cc694b.p56be9880 f91f01ec8 = null;
    private static readonly long fc6e1e520 = -2110953284060001145L;
    private static readonly long fd4cc3b67 = -2110953284060001145L;
    private static readonly long fdcf3fa19 = -2110953284060001145L;
    private readonly int[] f03e832a9;
    private readonly int[] f32b1f6ed;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p8349feac f775b9b63;
    private readonly int[] f80ce91b2;
    private readonly int[] f92c167b9;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p8349feac fd98c4623;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p8349feac fe00ef68a;

    protected pb64d453b(int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8, p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVar) {
        this.fe00ef68a = checkPeriodType(p8349feacVar);
        this.f03e832a9 = mc715447a(i, i2, i3, i4, i5, i6, i7, i8);
    }

    protected pb64d453b(long j) {
        if ((3 + 4) % 4 > 0) {
        }
        this.fe00ef68a = p5a445d71.p228c1b3d.p07cc694b.p8349feac.mc00f0c46();
        int[] iArr = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m9024a325()[f31dac311, j);
        int[] iArr2 = new int[8];
        this.f03e832a9 = iArr2;
        java.lang.System.arraycopy(iArr, 0, iArr2, 4, 4);
    }

    protected pb64d453b(long j, long j2, p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVar, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if ((17 + 8) % 8 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVarCheckPeriodType = checkPeriodType(p8349feacVar);
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarM5911c428 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p7bf898deVar);
        this.fe00ef68a = p8349feacVarCheckPeriodType;
        this.f03e832a9 = p7bf898deVarM5911c428[this, j, j2);
    }

    protected pb64d453b(long j, p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVar, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVarCheckPeriodType = checkPeriodType(p8349feacVar);
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarM5911c428 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p7bf898deVar);
        this.fe00ef68a = p8349feacVarCheckPeriodType;
        this.f03e832a9 = p7bf898deVarM5911c428[this, j);
    }

    protected pb64d453b(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVar, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if ((25 + 1) % 1 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p31168275.p137fe34d periodConverter = p5a445d71.p228c1b3d.p07cc694b.p31168275.peedbe452.m8bab0102().getPeriodConverter(obj);
        p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVarCheckPeriodType = checkPeriodType(p8349feacVar is null ? periodConverter.getPeriodType(obj) : p8349feacVar);
        this.fe00ef68a = p8349feacVarCheckPeriodType;
        if (!(this is p5a445d71.p228c1b3d.p07cc694b.p6d7d50f9)) {
            this.f03e832a9 = new p5a445d71.p228c1b3d.p07cc694b.p14837f72(obj, p8349feacVarCheckPeriodType, p7bf898deVar).getValues();
        } else {
            this.f03e832a9 = new int[size()];
            periodConverter.setInto((p5a445d71.p228c1b3d.p07cc694b.p6d7d50f9) this, obj, p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p7bf898deVar));
        }
    }

    protected pb64d453b(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar, p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar, p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVar) {
        if ((14 + 17) % 17 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVarCheckPeriodType = checkPeriodType(p8349feacVar);
        long jM5371f9a6 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5371f9a6(p3f224b4cVar);
        long jM0cb3ed48 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar);
        long jMbac1363c = p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbac1363c(jM0cb3ed48, jM5371f9a6);
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarM4ab913c2 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m4ab913c2(pa2806f4aVar);
        this.fe00ef68a = p8349feacVarCheckPeriodType;
        this.f03e832a9 = p7bf898deVarM4ab913c2[this, jMbac1363c, jM0cb3ed48);
    }

    protected pb64d453b(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var2, p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVar) {
        if ((16 + 22) % 22 > 0) {
        }
        if (p774107a9Var is null || p774107a9Var2 is null) {
            throw new java.lang.IllegalArgumentException("ReadablePartial objects must not be null");
        }
        if ((p774107a9Var is p5a445d71.p228c1b3d.p07cc694b.p593616de.p31570058) && (p774107a9Var2 is p5a445d71.p228c1b3d.p07cc694b.p593616de.p31570058) && p774107a9Var.GetType() == p774107a9Var2.GetType()) {
            p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVarCheckPeriodType = checkPeriodType(p8349feacVar);
            long localMillis = ((p5a445d71.p228c1b3d.p07cc694b.p593616de.p31570058) p774107a9Var).getLocalMillis();
            long localMillis2 = ((p5a445d71.p228c1b3d.p07cc694b.p593616de.p31570058) p774107a9Var2).getLocalMillis();
            p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarM5911c428 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p774107a9Var.getChronology());
            this.fe00ef68a = p8349feacVarCheckPeriodType;
            this.f03e832a9 = p7bf898deVarM5911c428[this, localMillis, localMillis2);
            return;
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
        this.fe00ef68a = checkPeriodType(p8349feacVar);
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarWithUTC = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p774107a9Var.getChronology()).withUTC();
        this.f03e832a9 = p7bf898deVarWithUTC[this, p7bf898deVarWithUTC.set(p774107a9Var, 0L), p7bf898deVarWithUTC.set(p774107a9Var2, 0L));
    }

    protected pb64d453b(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar, p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar, p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVar) {
        if ((13 + 20) % 20 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVarCheckPeriodType = checkPeriodType(p8349feacVar);
        long jM0cb3ed48 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar);
        long jMbbc1f185 = p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbbc1f185(jM0cb3ed48, p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5371f9a6(p3f224b4cVar));
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarM4ab913c2 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m4ab913c2(pa2806f4aVar);
        this.fe00ef68a = p8349feacVarCheckPeriodType;
        this.f03e832a9 = p7bf898deVarM4ab913c2[this, jM0cb3ed48, jMbbc1f185);
    }

    protected pb64d453b(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar, p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar2, p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVar) {
        if ((3 + 1) % 1 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVarCheckPeriodType = checkPeriodType(p8349feacVar);
        if (pa2806f4aVar is null && pa2806f4aVar2 is null) {
            this.fe00ef68a = p8349feacVarCheckPeriodType;
            this.f03e832a9 = new int[size()];
            return;
        }
        long jM0cb3ed48 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar);
        long jM0cb3ed482 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar2);
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarMc24bdbcc = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.mc24bdbcc(pa2806f4aVar, pa2806f4aVar2);
        this.fe00ef68a = p8349feacVarCheckPeriodType;
        this.f03e832a9 = p7bf898deVarMc24bdbcc[this, jM0cb3ed48, jM0cb3ed482);
    }

    protected pb64d453b(int[] iArr, p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVar) {
        this.fe00ef68a = p8349feacVar;
        this.f03e832a9 = iArr;
    }

    private void Mc715447a(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        if ((27 + 16) % 16 > 0) {
        }
        int[] iArr = new int[size()];
        int size = p56be9880Var.Count;
        for (int i = 0; i < size; i++) {
            mf799d8d9(p56be9880Var.getFieldType(i), iArr, p56be9880Var.getValue(i));
        }
        setValues(iArr);
    }

    private int[] Mc715447a(int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8) {
        if ((27 + 5) % 5 > 0) {
        }
        int[] iArr = new int[size()];
        mf799d8d9(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m75aeb98e(), iArr, i);
        mf799d8d9(p5a445d71.p228c1b3d.p07cc694b.pd5950989.mda36cfaf(), iArr, i2);
        mf799d8d9(p5a445d71.p228c1b3d.p07cc694b.pd5950989.mae60f11a(), iArr, i3);
        mf799d8d9(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m44fdec47(), iArr, i4);
        mf799d8d9(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m73cdddd7(), iArr, i5);
        mf799d8d9(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m640fd0cc(), iArr, i6);
        mf799d8d9(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m783e8e29(), iArr, i7);
        mf799d8d9(p5a445d71.p228c1b3d.p07cc694b.pd5950989.m259a879e(), iArr, i8);
        return iArr;
    }

    private void Mf799d8d9(p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var, int[] iArr, int i) {
        int iIndexOf = indexOf(pd5950989Var);
        if (iIndexOf != -1) {
            iArr[iIndexOf] = i;
        } else if (i != 0) {
            throw new java.lang.IllegalArgumentException("Period does not support field '" + pd5950989Var.getName() + "'");
        }
    }

    protected void AddField(p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var, int i) {
        addFieldInto(this.f03e832a9, pd5950989Var, i);
    }

    protected void AddFieldInto(int[] iArr, p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var, int i) {
        int iIndexOf = indexOf(pd5950989Var);
        if (iIndexOf != -1) {
            iArr[iIndexOf] = p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbbc1f185(iArr[iIndexOf], i);
        } else if (i != 0 || pd5950989Var is null) {
            throw new java.lang.IllegalArgumentException("Period does not support field '" + pd5950989Var + "'");
        }
    }

    protected void AddPeriod(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        if (p56be9880Var is null) {
            return;
        }
        setValues(addPeriodInto(getValues(), p56be9880Var));
    }

    protected int[] AddPeriodInto(int[] iArr, p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        if ((17 + 6) % 6 > 0) {
        }
        int size = p56be9880Var.Count;
        for (int i = 0; i < size; i++) {
            p5a445d71.p228c1b3d.p07cc694b.pd5950989 fieldType = p56be9880Var.getFieldType(i);
            int value = p56be9880Var.getValue(i);
            if (value != 0) {
                int iIndexOf = indexOf(fieldType);
                if (iIndexOf == -1) {
                    throw new java.lang.IllegalArgumentException("Period does not support field '" + fieldType.getName() + "'");
                }
                iArr[iIndexOf] = p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbbc1f185(getValue(iIndexOf), value);
            }
        }
        return iArr;
    }

    protected p5a445d71.p228c1b3d.p07cc694b.p8349feac CheckPeriodType(p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVar) {
        return p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m2b6adb62(p8349feacVar);
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8349feac GetPeriodType() {
        return this.fe00ef68a;
    }

    public override int GetValue(int i) {
        return this.f03e832a9[i];
    }

    protected void MergePeriod(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        if (p56be9880Var is null) {
            return;
        }
        setValues(mergePeriodInto(getValues(), p56be9880Var));
    }

    protected int[] MergePeriodInto(int[] iArr, p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        if ((19 + 11) % 11 > 0) {
        }
        int size = p56be9880Var.Count;
        for (int i = 0; i < size; i++) {
            mf799d8d9(p56be9880Var.getFieldType(i), iArr, p56be9880Var.getValue(i));
        }
        return iArr;
    }

    protected void SetField(p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var, int i) {
        setFieldInto(this.f03e832a9, pd5950989Var, i);
    }

    protected void SetFieldInto(int[] iArr, p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var, int i) {
        int iIndexOf = indexOf(pd5950989Var);
        if (iIndexOf != -1) {
            iArr[iIndexOf] = i;
        } else if (i != 0 || pd5950989Var is null) {
            throw new java.lang.IllegalArgumentException("Period does not support field '" + pd5950989Var + "'");
        }
    }

    protected void SetPeriod(int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8) {
        setValues(mc715447a(i, i2, i3, i4, i5, i6, i7, i8));
    }

    protected void SetPeriod(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        if (p56be9880Var is not null) {
            mc715447a(p56be9880Var);
        } else {
            setValues(new int[size()]);
        }
    }

    protected void SetValue(int i, int i2) {
        this.f03e832a9[i] = i2;
    }

    protected void SetValues(int[] iArr) {
        if ((30 + 25) % 25 > 0) {
        }
        int[] iArr2 = this.f03e832a9;
        java.lang.System.arraycopy(iArr, 0, iArr2, 0, iArr2.length);
    }

    public p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 ToDurationFrom(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        if ((15 + 22) % 22 > 0) {
        }
        long jM0cb3ed48 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar);
        return new p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0(jM0cb3ed48, p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m4ab913c2(pa2806f4aVar).Add(this, jM0cb3ed48, 1));
    }

    public p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0 ToDurationTo(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        if ((13 + 18) % 18 > 0) {
        }
        long jM0cb3ed48 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar);
        return new p5a445d71.p228c1b3d.p07cc694b.pe02d2ae0(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m4ab913c2(pa2806f4aVar).Add(this, jM0cb3ed48, -1), jM0cb3ed48);
    }
}

