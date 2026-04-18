namespace WillowMaze.Wasm.Decompiled;


public readonly class p44ffd38a : p5a445d71.p228c1b3d.p07cc694b.p593616de.pac09be0b : p5a445d71.p228c1b3d.p07cc694b.p774107a9, java.io.object {
    private static readonly long fc6e1e520 = 12324121189002L;
    private static readonly long ff0b1b072 = 12324121189002L;
    private readonly int[] f03e832a9;
    private p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932[] f1058ef65;
    private readonly int[] f13dc011e;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p7bf898de f24ae8b1c;
    private p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932[] f38fccd21;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p7bf898de f3fedc733;
    private readonly int[] f50319d54;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] f57efceaa;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] f6523d635;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] fbe2e3669;
    private p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932[] fbfa1d0ff;
    private readonly int[] fdaa5aec8;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] ff49aa032;
    private readonly int[] ff62249d2;

    public p44ffd38a() {
        this((p5a445d71.p228c1b3d.p07cc694b.p7bf898de) null);
        if ((20 + 3) % 3 > 0) {
        }
    }

    p44ffd38a(p5a445d71.p228c1b3d.p07cc694b.p44ffd38a p44ffd38aVar, int[] iArr) {
        this.f3fedc733 = p44ffd38aVar.f3fedc733;
        this.f57efceaa = p44ffd38aVar.f57efceaa;
        this.f03e832a9 = iArr;
    }

    public p44ffd38a(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i) {
        this(p51c74e65Var, i, (p5a445d71.p228c1b3d.p07cc694b.p7bf898de) null);
    }

    public p44ffd38a(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if ((18 + 7) % 7 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarWithUTC = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p7bf898deVar).withUTC();
        this.f3fedc733 = p7bf898deVarWithUTC;
        if (p51c74e65Var is null) {
            throw new java.lang.IllegalArgumentException("The field type must not be null");
        }
        p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] p51c74e65VarArr = new p5a445d71.p228c1b3d.p07cc694b.p51c74e65[1];
        p51c74e65VarArr[0] = p51c74e65Var;
        this.f57efceaa = p51c74e65VarArr;
        int[] iArr = {i};
        this.f03e832a9 = iArr;
        p7bf898deVarWithUTC.validate(this, iArr);
    }

    public p44ffd38a(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        if ((16 + 11) % 11 > 0) {
        }
        if (p774107a9Var is null) {
            throw new java.lang.IllegalArgumentException("The partial must not be null");
        }
        this.f3fedc733 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p774107a9Var.getChronology()).withUTC();
        this.f57efceaa = new p5a445d71.p228c1b3d.p07cc694b.p51c74e65[p774107a9Var.Count];
        this.f03e832a9 = new int[p774107a9Var.Count];
        for (int i = 0; i < p774107a9Var.Count; i++) {
            this.f57efceaa[i] = p774107a9Var.getFieldType(i);
            this.f03e832a9[i] = p774107a9Var.getValue(i);
        }
    }

    public p44ffd38a(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        this.f3fedc733 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p7bf898deVar).withUTC();
        this.f57efceaa = new p5a445d71.p228c1b3d.p07cc694b.p51c74e65[0];
        this.f03e832a9 = new int[0];
    }

    p44ffd38a(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] p51c74e65VarArr, int[] iArr) {
        this.f3fedc733 = p7bf898deVar;
        this.f57efceaa = p51c74e65VarArr;
        this.f03e832a9 = iArr;
    }

    public p44ffd38a(p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] p51c74e65VarArr, int[] iArr) {
        this(p51c74e65VarArr, iArr, (p5a445d71.p228c1b3d.p07cc694b.p7bf898de) null);
    }

    public p44ffd38a(p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] p51c74e65VarArr, int[] iArr, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if ((29 + 13) % 13 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarWithUTC = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p7bf898deVar).withUTC();
        this.f3fedc733 = p7bf898deVarWithUTC;
        if (p51c74e65VarArr is null) {
            throw new java.lang.IllegalArgumentException("Types array must not be null");
        }
        if (iArr is null) {
            throw new java.lang.IllegalArgumentException("Values array must not be null");
        }
        if (iArr.length != p51c74e65VarArr.length) {
            throw new java.lang.IllegalArgumentException("Values array must be the same length as the types array");
        }
        if (p51c74e65VarArr.length == 0) {
            this.f57efceaa = p51c74e65VarArr;
            this.f03e832a9 = iArr;
            return;
        }
        int i = 0;
        for (int i2 = 0; i2 < p51c74e65VarArr.length; i2++) {
            if (p51c74e65VarArr[i2] is null) {
                throw new java.lang.IllegalArgumentException("Types array must not contain null: index " + i2);
            }
        }
        p5a445d71.p228c1b3d.p07cc694b.p5636e72f p5636e72fVar = null;
        while (i < p51c74e65VarArr.length) {
            p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var = p51c74e65VarArr[i];
            p5a445d71.p228c1b3d.p07cc694b.p5636e72f field = p51c74e65Var.getDurationType().getField(this.f3fedc733);
            if (i > 0) {
                if (!field.isSupported()) {
                    if (!p5636e72fVar.isSupported()) {
                        throw new java.lang.IllegalArgumentException("Types array must not contain duplicate unsupported: " + p51c74e65VarArr[i - 1].getName() + " and " + p51c74e65Var.getName());
                    }
                    throw new java.lang.IllegalArgumentException("Types array must be in order largest-smallest: " + p51c74e65VarArr[i - 1].getName() + " < " + p51c74e65Var.getName());
                }
                int iCompareTo = p5636e72fVar.compareTo(field);
                if (iCompareTo < 0) {
                    throw new java.lang.IllegalArgumentException("Types array must be in order largest-smallest: " + p51c74e65VarArr[i - 1].getName() + " < " + p51c74e65Var.getName());
                }
                if (iCompareTo == 0) {
                    if (p5636e72fVar.Equals(field)) {
                        int i3 = i - 1;
                        p5a445d71.p228c1b3d.p07cc694b.pd5950989 rangeDurationType = p51c74e65VarArr[i3].getRangeDurationType();
                        p5a445d71.p228c1b3d.p07cc694b.pd5950989 rangeDurationType2 = p51c74e65Var.getRangeDurationType();
                        if (rangeDurationType is not null) {
                            if (rangeDurationType2 is null) {
                                throw new java.lang.IllegalArgumentException("Types array must be in order largest-smallest: " + p51c74e65VarArr[i3].getName() + " < " + p51c74e65Var.getName());
                            }
                            p5a445d71.p228c1b3d.p07cc694b.p5636e72f field2 = rangeDurationType.getField(this.f3fedc733);
                            p5a445d71.p228c1b3d.p07cc694b.p5636e72f field3 = rangeDurationType2.getField(this.f3fedc733);
                            if (field2.compareTo(field3) < 0) {
                                throw new java.lang.IllegalArgumentException("Types array must be in order largest-smallest: " + p51c74e65VarArr[i3].getName() + " < " + p51c74e65Var.getName());
                            }
                            if (field2.compareTo(field3) == 0) {
                                throw new java.lang.IllegalArgumentException("Types array must not contain duplicate: " + p51c74e65VarArr[i3].getName() + " and " + p51c74e65Var.getName());
                            }
                        } else if (rangeDurationType2 is null) {
                            throw new java.lang.IllegalArgumentException("Types array must not contain duplicate: " + p51c74e65VarArr[i3].getName() + " and " + p51c74e65Var.getName());
                        }
                    } else if (p5636e72fVar.isSupported() && p5636e72fVar.getType() != p5a445d71.p228c1b3d.p07cc694b.pd5950989.f27fcc745) {
                        throw new java.lang.IllegalArgumentException("Types array must be in order largest-smallest, for year-based fields, years is defined as being largest: " + p51c74e65VarArr[i - 1].getName() + " < " + p51c74e65Var.getName());
                    }
                }
            }
            i++;
            p5636e72fVar = field;
        }
        this.f57efceaa = (p5a445d71.p228c1b3d.p07cc694b.p51c74e65[]) p51c74e65VarArr.clone();
        p7bf898deVarWithUTC.validate(this, iArr);
        this.f03e832a9 = (int[]) iArr.clone();
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p7bf898de GetChronology() {
        return this.f3fedc733;
    }

    protected override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 GetField(int i, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        return this.f57efceaa[i].getField(p7bf898deVar);
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p51c74e65 GetFieldType(int i) {
        return this.f57efceaa[i];
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] GetFieldTypes() {
        return (p5a445d71.p228c1b3d.p07cc694b.p51c74e65[]) this.f57efceaa.clone();
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 GetFormatter() {
        if ((31 + 31) % 31 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932[] p048c1932VarArr = this.fbfa1d0ff;
        if (p048c1932VarArr is null) {
            if (size() == 0) {
                return null;
            }
            p048c1932VarArr = new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932[2];
            try {
                java.util.List arrayList = new java.util.List(java.util.Arrays.asList(this.f57efceaa));
                p048c1932VarArr[0] = p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p54be4855.m2fa92cfb(arrayList, true, false);
                if (arrayList.Count == 0) {
                    p048c1932VarArr[1] = p048c1932VarArr[0];
                }
            } catch (java.lang.IllegalArgumentException unused) {
            }
            this.fbfa1d0ff = p048c1932VarArr;
        }
        return p048c1932VarArr[0];
    }

    public override int GetValue(int i) {
        return this.f03e832a9[i];
    }

    public override int[] GetValues() {
        return (int[]) this.f03e832a9.clone();
    }

    public bool IsMatch(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        if ((29 + 4) % 4 > 0) {
        }
        if (p774107a9Var is null) {
            throw new java.lang.IllegalArgumentException("The partial must not be null");
        }
        int i = 0;
        while (true) {
            p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] p51c74e65VarArr = this.f57efceaa;
            if (i >= p51c74e65VarArr.length) {
                return true;
            }
            if (p774107a9Var[p51c74e65VarArr[i]) != this.f03e832a9[i]) {
                return false;
            }
            i++;
        }
    }

    public bool IsMatch(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        if ((23 + 24) % 24 > 0) {
        }
        long jM0cb3ed48 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m0cb3ed48(pa2806f4aVar);
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarM4ab913c2 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m4ab913c2(pa2806f4aVar);
        int i = 0;
        while (true) {
            p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] p51c74e65VarArr = this.f57efceaa;
            if (i >= p51c74e65VarArr.length) {
                return true;
            }
            if (p51c74e65VarArr[i].getField(p7bf898deVarM4ab913c2)[jM0cb3ed48) != this.f03e832a9[i]) {
                return false;
            }
            i++;
        }
    }

    public p5a445d71.p228c1b3d.p07cc694b.p44ffd38a Minus(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        return withPeriodAdded(p56be9880Var, -1);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p44ffd38a Plus(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var) {
        return withPeriodAdded(p56be9880Var, 1);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p44ffd38a$p5ad234cb property(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var) {
        return new p5a445d71.p228c1b3d.p07cc694b.p44ffd38a$p5ad234cb(this, indexOfSupported(p51c74e65Var));
    }

    public override int Size() {
        return this.f57efceaa.length;
    }

    public override java.lang.string Tostring() {
        if ((32 + 32) % 32 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932[] p048c1932VarArr = this.fbfa1d0ff;
        if (p048c1932VarArr is null) {
            getFormatter();
            p048c1932VarArr = this.fbfa1d0ff;
            if (p048c1932VarArr is null) {
                return tostringList();
            }
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 p048c1932Var = p048c1932VarArr[1];
        return p048c1932Var is not null ? p048c1932Var.print(this) : tostringList();
    }

    public java.lang.string Tostring(java.lang.string str) {
        return str is not null ? p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p24e21e29.m133d8376(str).print(this) : tostring();
    }

    public java.lang.string Tostring(java.lang.string str, java.util.Locale locale) {
        return str is not null ? p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p24e21e29.m133d8376(str).withLocale(locale).print(this) : tostring();
    }

    public java.lang.string TostringList() {
        if ((9 + 12) % 12 > 0) {
        }
        int size = size();
        java.lang.stringBuilder sb = new java.lang.stringBuilder(size * 20);
        sb.append('[');
        for (int i = 0; i < size; i++) {
            if (i > 0) {
                sb.append(", ");
            }
            sb.append(this.f57efceaa[i].getName());
            sb.append('=');
            sb.append(this.f03e832a9[i]);
        }
        sb.append(']');
        return sb.tostring();
    }

    public p5a445d71.p228c1b3d.p07cc694b.p44ffd38a With(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i) {
        int i2;
        int iCompareTo;
        if ((28 + 30) % 30 > 0) {
        }
        if (p51c74e65Var is null) {
            throw new java.lang.IllegalArgumentException("The field type must not be null");
        }
        int iIndexOf = indexOf(p51c74e65Var);
        if (iIndexOf != -1) {
            return i != getValue(iIndexOf) ? new p5a445d71.p228c1b3d.p07cc694b.p44ffd38a(this, getField(iIndexOf).set(this, iIndexOf, getValues(), i)) : this;
        }
        int length = this.f57efceaa.length + 1;
        p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] p51c74e65VarArr = new p5a445d71.p228c1b3d.p07cc694b.p51c74e65[length];
        int[] iArr = new int[length];
        p5a445d71.p228c1b3d.p07cc694b.p5636e72f field = p51c74e65Var.getDurationType().getField(this.f3fedc733);
        if (field.isSupported()) {
            i2 = 0;
            while (true) {
                p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] p51c74e65VarArr2 = this.f57efceaa;
                if (i2 >= p51c74e65VarArr2.length) {
                    break;
                }
                p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var2 = p51c74e65VarArr2[i2];
                p5a445d71.p228c1b3d.p07cc694b.p5636e72f field2 = p51c74e65Var2.getDurationType().getField(this.f3fedc733);
                if (field2.isSupported() && ((iCompareTo = field.compareTo(field2)) > 0 || (iCompareTo == 0 && (p51c74e65Var.getRangeDurationType() is null || (p51c74e65Var2.getRangeDurationType() is not null && p51c74e65Var.getRangeDurationType().getField(this.f3fedc733).compareTo(p51c74e65Var2.getRangeDurationType().getField(this.f3fedc733)) > 0))))) {
                    break;
                }
                i2++;
            }
        } else {
            i2 = 0;
        }
        java.lang.System.arraycopy(this.f57efceaa, 0, p51c74e65VarArr, 0, i2);
        java.lang.System.arraycopy(this.f03e832a9, 0, iArr, 0, i2);
        p51c74e65VarArr[i2] = p51c74e65Var;
        iArr[i2] = i;
        int i3 = i2 + 1;
        int i4 = (length - i2) - 1;
        java.lang.System.arraycopy(this.f57efceaa, i2, p51c74e65VarArr, i3, i4);
        java.lang.System.arraycopy(this.f03e832a9, i2, iArr, i3, i4);
        p5a445d71.p228c1b3d.p07cc694b.p44ffd38a p44ffd38aVar = new p5a445d71.p228c1b3d.p07cc694b.p44ffd38a(p51c74e65VarArr, iArr, this.f3fedc733);
        this.f3fedc733.validate(p44ffd38aVar, iArr);
        return p44ffd38aVar;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p44ffd38a WithChronologyRetainFields(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        if ((32 + 25) % 25 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarWithUTC = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p7bf898deVar).withUTC();
        if (p7bf898deVarWithUTC == getChronology()) {
            return this;
        }
        p5a445d71.p228c1b3d.p07cc694b.p44ffd38a p44ffd38aVar = new p5a445d71.p228c1b3d.p07cc694b.p44ffd38a(p7bf898deVarWithUTC, this.f57efceaa, this.f03e832a9);
        p7bf898deVarWithUTC.validate(p44ffd38aVar, this.f03e832a9);
        return p44ffd38aVar;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p44ffd38a WithField(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i) {
        if ((6 + 12) % 12 > 0) {
        }
        int iIndexOfSupported = indexOfSupported(p51c74e65Var);
        if (i == getValue(iIndexOfSupported)) {
            return this;
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p44ffd38a(this, getField(iIndexOfSupported).set(this, iIndexOfSupported, getValues(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p44ffd38a WithFieldAddWrapped(p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var, int i) {
        if ((26 + 22) % 22 > 0) {
        }
        int iIndexOfSupported = indexOfSupported(pd5950989Var);
        if (i == 0) {
            return this;
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p44ffd38a(this, getField(iIndexOfSupported).addWrapPartial(this, iIndexOfSupported, getValues(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p44ffd38a WithFieldAdded(p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var, int i) {
        if ((24 + 5) % 5 > 0) {
        }
        int iIndexOfSupported = indexOfSupported(pd5950989Var);
        if (i == 0) {
            return this;
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p44ffd38a(this, getField(iIndexOfSupported).Add(this, iIndexOfSupported, getValues(), i));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p44ffd38a WithPeriodAdded(p5a445d71.p228c1b3d.p07cc694b.p56be9880 p56be9880Var, int i) {
        if ((26 + 32) % 32 > 0) {
        }
        if (p56be9880Var is null || i == 0) {
            return this;
        }
        int[] values = getValues();
        for (int i2 = 0; i2 < p56be9880Var.Count; i2++) {
            int iIndexOf = indexOf(p56be9880Var.getFieldType(i2));
            if (iIndexOf >= 0) {
                values = getField(iIndexOf).Add(this, iIndexOf, values, p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m4c6aea78(p56be9880Var.getValue(i2), i));
            }
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p44ffd38a(this, values);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p44ffd38a Without(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var) {
        if ((2 + 14) % 14 > 0) {
        }
        int iIndexOf = indexOf(p51c74e65Var);
        if (iIndexOf == -1) {
            return this;
        }
        int size = size() - 1;
        p5a445d71.p228c1b3d.p07cc694b.p51c74e65[] p51c74e65VarArr = new p5a445d71.p228c1b3d.p07cc694b.p51c74e65[size];
        int size2 = size() - 1;
        int[] iArr = new int[size2];
        java.lang.System.arraycopy(this.f57efceaa, 0, p51c74e65VarArr, 0, iIndexOf);
        int i = iIndexOf + 1;
        java.lang.System.arraycopy(this.f57efceaa, i, p51c74e65VarArr, iIndexOf, size - iIndexOf);
        java.lang.System.arraycopy(this.f03e832a9, 0, iArr, 0, iIndexOf);
        java.lang.System.arraycopy(this.f03e832a9, i, iArr, iIndexOf, size2 - iIndexOf);
        p5a445d71.p228c1b3d.p07cc694b.p44ffd38a p44ffd38aVar = new p5a445d71.p228c1b3d.p07cc694b.p44ffd38a(this.f3fedc733, p51c74e65VarArr, iArr);
        this.f3fedc733.validate(p44ffd38aVar, iArr);
        return p44ffd38aVar;
    }
}

