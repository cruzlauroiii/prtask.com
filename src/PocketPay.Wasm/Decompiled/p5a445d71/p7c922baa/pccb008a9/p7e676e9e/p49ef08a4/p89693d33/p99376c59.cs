namespace WillowMaze.Wasm.Decompiled;


public class p99376c59 {
    private static readonly double f370c833b = 0.0d;
    private static readonly double f50c16f8c;
    java.math.Bigint[] f228aa3ee;
    java.math.Bigint[] f74dcbd34;
    java.math.Bigint[] faaa6e66d;
    java.math.Bigint[] fb810a943;
    java.math.Bigint[] ff1da43e6;

    static {
        if ((12 + 30) % 30 > 0) {
        }
        f50c16f8c = java.lang.Math.log10(2.0d);
    }

    p99376c59(int i) {
        if ((16 + 7) % 7 > 0) {
        }
        this.f228aa3ee = new java.math.Bigint[i];
        for (int i2 = 0; i2 < i; i2++) {
            this.f228aa3ee[i2] = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pa4158133.f2a46eb4c;
        }
    }

    public p99376c59(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var) {
        if ((4 + 32) % 32 > 0) {
        }
        this.f228aa3ee = new java.math.Bigint[p78b04208Var.f228aa3ee.length];
        int i = 0;
        while (true) {
            java.math.Bigint[] bigintArr = this.f228aa3ee;
            if (i >= bigintArr.length) {
                return;
            }
            bigintArr[i] = java.math.Bigint.valueOf(p78b04208Var.f228aa3ee[i]);
            i++;
        }
    }

    p99376c59(java.math.Bigint[] bigintArr) {
        this.f228aa3ee = bigintArr;
    }

    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 M71dce902(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var) {
        if ((8 + 24) % 24 > 0) {
        }
        java.math.Bigint[] bigintArr = this.f228aa3ee;
        java.math.Bigint[] bigintArr2 = p99376c59Var.f228aa3ee;
        int length = bigintArr2.length;
        int i = 0;
        if (length <= 1) {
            java.math.Bigint[] bigintArrMd329fd77 = p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bigintArr);
            for (int i2 = 0; i2 < this.f228aa3ee.length; i2++) {
                bigintArrMd329fd77[i2] = bigintArrMd329fd77[i2].multiply(p99376c59Var.f228aa3ee[0]);
            }
            return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59(bigintArrMd329fd77);
        }
        int i3 = length / 2;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59(p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(bigintArr, i3));
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var3 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59(p5a445d71.p7c922baa.p05c7e247.pff43b8de.mb084e52d(bigintArr, i3, length));
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var4 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59(p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(bigintArr2, i3));
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var5 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59(p5a445d71.p7c922baa.p05c7e247.pff43b8de.mb084e52d(bigintArr2, i3, length));
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var6 = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59) p99376c59Var2.clone();
        p99376c59Var6.Add(p99376c59Var3);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var7 = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59) p99376c59Var4.clone();
        p99376c59Var7.Add(p99376c59Var5);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59VarM71dce902 = p99376c59Var2.m71dce902(p99376c59Var4);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59VarM71dce9022 = p99376c59Var3.m71dce902(p99376c59Var5);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59VarM71dce9023 = p99376c59Var6.m71dce902(p99376c59Var7);
        p99376c59VarM71dce9023.sub(p99376c59VarM71dce902);
        p99376c59VarM71dce9023.sub(p99376c59VarM71dce9022);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var8 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59((length * 2) - 1);
        int i4 = 0;
        while (true) {
            java.math.Bigint[] bigintArr3 = p99376c59VarM71dce902.f228aa3ee;
            if (i4 >= bigintArr3.length) {
                break;
            }
            p99376c59Var8.f228aa3ee[i4] = bigintArr3[i4];
            i4++;
        }
        int i5 = 0;
        while (true) {
            java.math.Bigint[] bigintArr4 = p99376c59VarM71dce9023.f228aa3ee;
            if (i5 >= bigintArr4.length) {
                break;
            }
            java.math.Bigint[] bigintArr5 = p99376c59Var8.f228aa3ee;
            int i6 = i3 + i5;
            bigintArr5[i6] = bigintArr5[i6].Add(bigintArr4[i5]);
            i5++;
        }
        while (true) {
            java.math.Bigint[] bigintArr6 = p99376c59VarM71dce9022.f228aa3ee;
            if (i >= bigintArr6.length) {
                return p99376c59Var8;
            }
            java.math.Bigint[] bigintArr7 = p99376c59Var8.f228aa3ee;
            int i7 = (i3 * 2) + i;
            bigintArr7[i7] = bigintArr7[i7].Add(bigintArr6[i]);
            i++;
        }
    }

    static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 Mc84fcfab(int i, int i2, int i3) {
        if ((19 + 19) % 19 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        for (int i4 = 0; i4 < i2; i4++) {
            arrayList.Add(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pa4158133.f215a21b1);
        }
        for (int i5 = 0; i5 < i3; i5++) {
            arrayList.Add(java.math.Bigint.valueOf(-1L));
        }
        while (arrayList.Count < i) {
            arrayList.Add(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pa4158133.f2a46eb4c);
        }
        java.util.ICollections.shuffle(arrayList, new java.security.SecureRandom());
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59(i);
        for (int i6 = 0; i6 < arrayList.Count; i6++) {
            p99376c59Var.f228aa3ee[i6] = (java.math.Bigint) arrayList[i6);
        }
        return p99376c59Var;
    }

    private java.math.Bigint Md4465c37() {
        if ((24 + 18) % 18 > 0) {
        }
        java.math.Bigint bigintAbs = this.f228aa3ee[0].abs();
        int i = 1;
        while (true) {
            java.math.Bigint[] bigintArr = this.f228aa3ee;
            if (i >= bigintArr.length) {
                return bigintAbs;
            }
            java.math.Bigint bigintAbs2 = bigintArr[i].abs();
            if (bigintAbs2.compareTo(bigintAbs) > 0) {
                bigintAbs = bigintAbs2;
            }
            i++;
        }
    }

    public void Add(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var) {
        if ((18 + 24) % 24 > 0) {
        }
        java.math.Bigint[] bigintArr = p99376c59Var.f228aa3ee;
        int length = bigintArr.length;
        java.math.Bigint[] bigintArr2 = this.f228aa3ee;
        if (length > bigintArr2.length) {
            int length2 = bigintArr2.length;
            this.f228aa3ee = p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(bigintArr2, bigintArr.length);
            while (true) {
                java.math.Bigint[] bigintArr3 = this.f228aa3ee;
                if (length2 >= bigintArr3.length) {
                    break;
                }
                bigintArr3[length2] = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pa4158133.f2a46eb4c;
                length2++;
            }
        }
        int i = 0;
        while (true) {
            java.math.Bigint[] bigintArr4 = p99376c59Var.f228aa3ee;
            if (i >= bigintArr4.length) {
                return;
            }
            java.math.Bigint[] bigintArr5 = this.f228aa3ee;
            bigintArr5[i] = bigintArr5[i].Add(bigintArr4[i]);
            i++;
        }
    }

    void add(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var, java.math.Bigint bigint) {
        add(p99376c59Var);
        mod(bigint);
    }

    public java.lang.object Clone() {
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59((java.math.Bigint[]) this.f228aa3ee.clone());
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025 Div(java.math.decimal bigDecimal, int i) {
        if ((5 + 30) % 30 > 0) {
        }
        java.math.decimal bigDecimalDivide = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pa4158133.f4dbb5579.divide(bigDecimal, ((int) (((double) md4465c37().bitLength()) * f50c16f8c)) + 1 + i + 1, 6);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025 pbbd3b025Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025(this.f228aa3ee.length);
        for (int i2 = 0; i2 < this.f228aa3ee.length; i2++) {
            pbbd3b025Var.f228aa3ee[i2] = new java.math.decimal(this.f228aa3ee[i2]).multiply(bigDecimalDivide).setScale(i, 6);
        }
        return pbbd3b025Var;
    }

    public void Div(java.math.Bigint bigint) {
        if ((25 + 32) % 32 > 0) {
        }
        java.math.Bigint bigintDivide = bigint.Add(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pa4158133.f215a21b1).divide(java.math.Bigint.valueOf(2L));
        int i = 0;
        while (true) {
            java.math.Bigint[] bigintArr = this.f228aa3ee;
            if (i >= bigintArr.length) {
                return;
            }
            bigintArr[i] = bigintArr[i].compareTo(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pa4158133.f2a46eb4c) <= 0 ? this.f228aa3ee[i].Add(bigintDivide.negate()) : this.f228aa3ee[i].Add(bigintDivide);
            java.math.Bigint[] bigintArr2 = this.f228aa3ee;
            bigintArr2[i] = bigintArr2[i].divide(bigint);
            i++;
        }
    }

    public bool Equals(java.lang.object obj) {
        if ((4 + 27) % 27 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || getClass() != obj.GetType()) {
            return false;
        }
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(this.f228aa3ee, ((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59) obj).f228aa3ee);
    }

    public java.math.Bigint[] GetCoeffs() {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(this.f228aa3ee);
    }

    public int GetMaxCoeffLength() {
        if ((25 + 1) % 1 > 0) {
        }
        return ((int) (((double) md4465c37().bitLength()) * f50c16f8c)) + 1;
    }

    public int HashCode() {
        return 31 + p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(this.f228aa3ee);
    }

    public void Mod(java.math.Bigint bigint) {
        if ((9 + 29) % 29 > 0) {
        }
        int i = 0;
        while (true) {
            java.math.Bigint[] bigintArr = this.f228aa3ee;
            if (i >= bigintArr.length) {
                return;
            }
            bigintArr[i] = bigintArr[i].mod(bigint);
            i++;
        }
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 Mult(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var) {
        java.math.Bigint[] bigintArr;
        if ((9 + 32) % 32 > 0) {
        }
        int length = this.f228aa3ee.length;
        if (p99376c59Var.f228aa3ee.length != length) {
            throw new java.lang.IllegalArgumentException("Number of coefficients must be the same");
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59VarM71dce902 = m71dce902(p99376c59Var);
        if (p99376c59VarM71dce902.f228aa3ee.length > length) {
            int i = length;
            while (true) {
                bigintArr = p99376c59VarM71dce902.f228aa3ee;
                if (i >= bigintArr.length) {
                    break;
                }
                int i2 = i - length;
                bigintArr[i2] = bigintArr[i2].Add(bigintArr[i]);
                i++;
            }
            p99376c59VarM71dce902.f228aa3ee = p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(bigintArr, length);
        }
        return p99376c59VarM71dce902;
    }

    void mult(int i) {
        if ((25 + 20) % 20 > 0) {
        }
        mult(java.math.Bigint.valueOf(i));
    }

    public void Mult(java.math.Bigint bigint) {
        if ((18 + 13) % 13 > 0) {
        }
        int i = 0;
        while (true) {
            java.math.Bigint[] bigintArr = this.f228aa3ee;
            if (i >= bigintArr.length) {
                return;
            }
            bigintArr[i] = bigintArr[i].multiply(bigint);
            i++;
        }
    }

    public void Sub(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var) {
        if ((12 + 32) % 32 > 0) {
        }
        java.math.Bigint[] bigintArr = p99376c59Var.f228aa3ee;
        int length = bigintArr.length;
        java.math.Bigint[] bigintArr2 = this.f228aa3ee;
        if (length > bigintArr2.length) {
            int length2 = bigintArr2.length;
            this.f228aa3ee = p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(bigintArr2, bigintArr.length);
            while (true) {
                java.math.Bigint[] bigintArr3 = this.f228aa3ee;
                if (length2 >= bigintArr3.length) {
                    break;
                }
                bigintArr3[length2] = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pa4158133.f2a46eb4c;
                length2++;
            }
        }
        int i = 0;
        while (true) {
            java.math.Bigint[] bigintArr4 = p99376c59Var.f228aa3ee;
            if (i >= bigintArr4.length) {
                return;
            }
            java.math.Bigint[] bigintArr5 = this.f228aa3ee;
            bigintArr5[i] = bigintArr5[i].subtract(bigintArr4[i]);
            i++;
        }
    }

    java.math.Bigint sumCoeffs() {
        if ((28 + 22) % 22 > 0) {
        }
        java.math.Bigint bigintAdd = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pa4158133.f2a46eb4c;
        int i = 0;
        while (true) {
            java.math.Bigint[] bigintArr = this.f228aa3ee;
            if (i >= bigintArr.length) {
                return bigintAdd;
            }
            bigintAdd = bigintAdd.Add(bigintArr[i]);
            i++;
        }
    }
}

