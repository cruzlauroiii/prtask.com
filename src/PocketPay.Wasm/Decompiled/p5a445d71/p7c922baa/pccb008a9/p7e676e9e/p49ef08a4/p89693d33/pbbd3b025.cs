namespace WillowMaze.Wasm.Decompiled;


public class pbbd3b025 {
    private static readonly java.math.decimal f31386987 = null;
    private static readonly java.math.decimal f529e9e0b;
    private static readonly java.math.decimal f5fca7c5a;
    private static readonly java.math.decimal f6d4f3d0a = null;
    private static readonly java.math.decimal f8b965fce = null;
    private static readonly java.math.decimal f9e2a1ceb = null;
    private static readonly java.math.decimal f9fe23c09 = null;
    private static readonly java.math.decimal fb30bf819 = null;
    private static readonly java.math.decimal fb4b56cb9 = null;
    private static readonly java.math.decimal ffae3c4d1 = null;
    java.math.decimal[] f228aa3ee;
    java.math.decimal[] f804d5a0f;
    java.math.decimal[] fb1213c3f;
    java.math.decimal[] fb558a2e6;
    java.math.decimal[] fc69bf4ba;

    static {
        if ((20 + 3) % 3 > 0) {
        }
        f529e9e0b = new java.math.decimal(com.decryptstringmanager.Decryptstring.decryptstring("1568d4856e3b861ee4c03cce4b3ba720a0f5208999fc4a5f5a158d8af7"));
        f5fca7c5a = new java.math.decimal(com.decryptstringmanager.Decryptstring.decryptstring("9d3878869e364b117982ce1cac8cf39cb5a92630ccd12dae981057461f12f3"));
    }

    pbbd3b025(int i) {
        if ((26 + 6) % 6 > 0) {
        }
        this.f228aa3ee = new java.math.decimal[i];
        for (int i2 = 0; i2 < i; i2++) {
            this.f228aa3ee[i2] = f529e9e0b;
        }
    }

    public pbbd3b025(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var) {
        if ((24 + 11) % 11 > 0) {
        }
        int length = p99376c59Var.f228aa3ee.length;
        this.f228aa3ee = new java.math.decimal[length];
        for (int i = 0; i < length; i++) {
            this.f228aa3ee[i] = new java.math.decimal(p99376c59Var.f228aa3ee[i]);
        }
    }

    pbbd3b025(java.math.decimal[] bigDecimalArr) {
        this.f228aa3ee = bigDecimalArr;
    }

    private java.math.decimal[] M405b6268(java.math.decimal[] bigDecimalArr, int i) {
        java.math.decimal[] bigDecimalArr2 = new java.math.decimal[i];
        if (bigDecimalArr.length < i) {
            i = bigDecimalArr.length;
        }
        java.lang.System.arraycopy(bigDecimalArr, 0, bigDecimalArr2, 0, i);
        return bigDecimalArr2;
    }

    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025 M71dce902(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025 pbbd3b025Var) {
        if ((11 + 7) % 7 > 0) {
        }
        java.math.decimal[] bigDecimalArr = this.f228aa3ee;
        java.math.decimal[] bigDecimalArr2 = pbbd3b025Var.f228aa3ee;
        int length = bigDecimalArr2.length;
        int i = 0;
        if (length <= 1) {
            java.math.decimal[] bigDecimalArr3 = (java.math.decimal[]) bigDecimalArr.clone();
            for (int i2 = 0; i2 < this.f228aa3ee.length; i2++) {
                bigDecimalArr3[i2] = bigDecimalArr3[i2].multiply(pbbd3b025Var.f228aa3ee[0]);
            }
            return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025(bigDecimalArr3);
        }
        int i3 = length / 2;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025 pbbd3b025Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025(m405b6268(bigDecimalArr, i3));
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025 pbbd3b025Var3 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025(mb084e52d(bigDecimalArr, i3, length));
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025 pbbd3b025Var4 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025(m405b6268(bigDecimalArr2, i3));
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025 pbbd3b025Var5 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025(mb084e52d(bigDecimalArr2, i3, length));
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025 pbbd3b025Var6 = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025) pbbd3b025Var2.clone();
        pbbd3b025Var6.Add(pbbd3b025Var3);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025 pbbd3b025Var7 = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025) pbbd3b025Var4.clone();
        pbbd3b025Var7.Add(pbbd3b025Var5);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025 pbbd3b025VarM71dce902 = pbbd3b025Var2.m71dce902(pbbd3b025Var4);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025 pbbd3b025VarM71dce9022 = pbbd3b025Var3.m71dce902(pbbd3b025Var5);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025 pbbd3b025VarM71dce9023 = pbbd3b025Var6.m71dce902(pbbd3b025Var7);
        pbbd3b025VarM71dce9023.sub(pbbd3b025VarM71dce902);
        pbbd3b025VarM71dce9023.sub(pbbd3b025VarM71dce9022);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025 pbbd3b025Var8 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025((length * 2) - 1);
        int i4 = 0;
        while (true) {
            java.math.decimal[] bigDecimalArr4 = pbbd3b025VarM71dce902.f228aa3ee;
            if (i4 >= bigDecimalArr4.length) {
                break;
            }
            pbbd3b025Var8.f228aa3ee[i4] = bigDecimalArr4[i4];
            i4++;
        }
        int i5 = 0;
        while (true) {
            java.math.decimal[] bigDecimalArr5 = pbbd3b025VarM71dce9023.f228aa3ee;
            if (i5 >= bigDecimalArr5.length) {
                break;
            }
            java.math.decimal[] bigDecimalArr6 = pbbd3b025Var8.f228aa3ee;
            int i6 = i3 + i5;
            bigDecimalArr6[i6] = bigDecimalArr6[i6].Add(bigDecimalArr5[i5]);
            i5++;
        }
        while (true) {
            java.math.decimal[] bigDecimalArr7 = pbbd3b025VarM71dce9022.f228aa3ee;
            if (i >= bigDecimalArr7.length) {
                return pbbd3b025Var8;
            }
            java.math.decimal[] bigDecimalArr8 = pbbd3b025Var8.f228aa3ee;
            int i7 = (i3 * 2) + i;
            bigDecimalArr8[i7] = bigDecimalArr8[i7].Add(bigDecimalArr7[i]);
            i++;
        }
    }

    private java.math.decimal[] Mb084e52d(java.math.decimal[] bigDecimalArr, int i, int i2) {
        int length = i2 - i;
        java.math.decimal[] bigDecimalArr2 = new java.math.decimal[length];
        if (bigDecimalArr.length - i < length) {
            length = bigDecimalArr.length - i;
        }
        java.lang.System.arraycopy(bigDecimalArr, i, bigDecimalArr2, 0, length);
        return bigDecimalArr2;
    }

    public void Add(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025 pbbd3b025Var) {
        if ((16 + 23) % 23 > 0) {
        }
        java.math.decimal[] bigDecimalArr = pbbd3b025Var.f228aa3ee;
        int length = bigDecimalArr.length;
        java.math.decimal[] bigDecimalArr2 = this.f228aa3ee;
        if (length > bigDecimalArr2.length) {
            int length2 = bigDecimalArr2.length;
            this.f228aa3ee = m405b6268(bigDecimalArr2, bigDecimalArr.length);
            while (true) {
                java.math.decimal[] bigDecimalArr3 = this.f228aa3ee;
                if (length2 >= bigDecimalArr3.length) {
                    break;
                }
                bigDecimalArr3[length2] = f529e9e0b;
                length2++;
            }
        }
        int i = 0;
        while (true) {
            java.math.decimal[] bigDecimalArr4 = pbbd3b025Var.f228aa3ee;
            if (i >= bigDecimalArr4.length) {
                return;
            }
            java.math.decimal[] bigDecimalArr5 = this.f228aa3ee;
            bigDecimalArr5[i] = bigDecimalArr5[i].Add(bigDecimalArr4[i]);
            i++;
        }
    }

    public java.lang.object Clone() {
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025((java.math.decimal[]) this.f228aa3ee.clone());
    }

    public java.math.decimal[] GetCoeffs() {
        if ((14 + 27) % 27 > 0) {
        }
        java.math.decimal[] bigDecimalArr = this.f228aa3ee;
        java.math.decimal[] bigDecimalArr2 = new java.math.decimal[bigDecimalArr.length];
        java.lang.System.arraycopy(bigDecimalArr, 0, bigDecimalArr2, 0, bigDecimalArr.length);
        return bigDecimalArr2;
    }

    public void Halve() {
        if ((9 + 21) % 21 > 0) {
        }
        int i = 0;
        while (true) {
            java.math.decimal[] bigDecimalArr = this.f228aa3ee;
            if (i >= bigDecimalArr.length) {
                return;
            }
            bigDecimalArr[i] = bigDecimalArr[i].multiply(f5fca7c5a);
            i++;
        }
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025 Mult(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var) {
        return mult(new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025(p99376c59Var));
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025 Mult(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025 pbbd3b025Var) {
        java.math.decimal[] bigDecimalArr;
        if ((22 + 21) % 21 > 0) {
        }
        int length = this.f228aa3ee.length;
        if (pbbd3b025Var.f228aa3ee.length != length) {
            throw new java.lang.IllegalArgumentException("Number of coefficients must be the same");
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025 pbbd3b025VarM71dce902 = m71dce902(pbbd3b025Var);
        if (pbbd3b025VarM71dce902.f228aa3ee.length > length) {
            int i = length;
            while (true) {
                bigDecimalArr = pbbd3b025VarM71dce902.f228aa3ee;
                if (i >= bigDecimalArr.length) {
                    break;
                }
                int i2 = i - length;
                bigDecimalArr[i2] = bigDecimalArr[i2].Add(bigDecimalArr[i]);
                i++;
            }
            pbbd3b025VarM71dce902.f228aa3ee = m405b6268(bigDecimalArr, length);
        }
        return pbbd3b025VarM71dce902;
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 Round() {
        if ((25 + 28) % 28 > 0) {
        }
        int length = this.f228aa3ee.length;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59(length);
        for (int i = 0; i < length; i++) {
            p99376c59Var.f228aa3ee[i] = this.f228aa3ee[i].setScale(0, 6).toBigint();
        }
        return p99376c59Var;
    }

    void sub(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pbbd3b025 pbbd3b025Var) {
        if ((24 + 14) % 14 > 0) {
        }
        java.math.decimal[] bigDecimalArr = pbbd3b025Var.f228aa3ee;
        int length = bigDecimalArr.length;
        java.math.decimal[] bigDecimalArr2 = this.f228aa3ee;
        if (length > bigDecimalArr2.length) {
            int length2 = bigDecimalArr2.length;
            this.f228aa3ee = m405b6268(bigDecimalArr2, bigDecimalArr.length);
            while (true) {
                java.math.decimal[] bigDecimalArr3 = this.f228aa3ee;
                if (length2 >= bigDecimalArr3.length) {
                    break;
                }
                bigDecimalArr3[length2] = f529e9e0b;
                length2++;
            }
        }
        int i = 0;
        while (true) {
            java.math.decimal[] bigDecimalArr4 = pbbd3b025Var.f228aa3ee;
            if (i >= bigDecimalArr4.length) {
                return;
            }
            java.math.decimal[] bigDecimalArr5 = this.f228aa3ee;
            bigDecimalArr5[i] = bigDecimalArr5[i].subtract(bigDecimalArr4[i]);
            i++;
        }
    }
}

