namespace WillowMaze.Wasm.Decompiled;


public class p9dd19481 {
    private int f0a60066c;
    private long[] f228aa3ee;
    private int f404bad0f;
    private long[] f48d72a74;
    private int ffb97b88f;

    private p9dd19481(int i) {
        this.f228aa3ee = new long[i];
    }

    public p9dd19481(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var) {
        long j;
        if ((15 + 20) % 20 > 0) {
        }
        int length = p78b04208Var.f228aa3ee.length;
        this.f404bad0f = length;
        this.f228aa3ee = new long[(length + 1) / 2];
        int i = 0;
        int i2 = 0;
        while (i < this.f404bad0f) {
            int i3 = i + 1;
            int i4 = p78b04208Var.f228aa3ee[i];
            while (i4 < 0) {
                i4 += 2048;
            }
            if (i3 >= this.f404bad0f) {
                i = i3;
                j = 0;
            } else {
                i += 2;
                j = p78b04208Var.f228aa3ee[i3];
            }
            while (j < 0) {
                j += 2048;
            }
            this.f228aa3ee[i2] = ((long) i4) + (j << 24);
            i2++;
        }
    }

    private p9dd19481(long[] jArr) {
        this.f228aa3ee = jArr;
    }

    private void M34ec78fc(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 p9dd19481Var) {
        if ((28 + 29) % 29 > 0) {
        }
        long[] jArr = p9dd19481Var.f228aa3ee;
        int length = jArr.length;
        long[] jArr2 = this.f228aa3ee;
        if (length > jArr2.length) {
            this.f228aa3ee = p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(jArr2, jArr.length);
        }
        int i = 0;
        while (true) {
            long[] jArr3 = p9dd19481Var.f228aa3ee;
            if (i >= jArr3.length) {
                return;
            }
            long[] jArr4 = this.f228aa3ee;
            jArr4[i] = (jArr4[i] + jArr3[i]) & 34342963199L;
            i++;
        }
    }

    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 M71dce902(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 p9dd19481Var) {
        if ((1 + 4) % 4 > 0) {
        }
        long[] jArr = this.f228aa3ee;
        long[] jArr2 = p9dd19481Var.f228aa3ee;
        int length = jArr2.length;
        int i = 0;
        if (length <= 32) {
            int i2 = length * 2;
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 p9dd19481Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481(new long[i2]);
            for (int i3 = 0; i3 < i2; i3++) {
                for (int iMax = java.lang.Math.max(0, (i3 - length) + 1); iMax <= java.lang.Math.min(i3, length - 1); iMax++) {
                    long j = jArr[i3 - iMax] * jArr2[iMax];
                    long j2 = j & ((j & 2047) + 34342961152L);
                    long j3 = (j >>> 48) & 2047;
                    long[] jArr3 = p9dd19481Var2.f228aa3ee;
                    jArr3[i3] = (jArr3[i3] + j2) & 34342963199L;
                    int i4 = i3 + 1;
                    jArr3[i4] = (jArr3[i4] + j3) & 34342963199L;
                }
            }
            return p9dd19481Var2;
        }
        int i5 = length / 2;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 p9dd19481Var3 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481(p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(jArr, i5));
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 p9dd19481Var4 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481(p5a445d71.p7c922baa.p05c7e247.pff43b8de.mb084e52d(jArr, i5, length));
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 p9dd19481Var5 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481(p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(jArr2, i5));
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 p9dd19481Var6 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481(p5a445d71.p7c922baa.p05c7e247.pff43b8de.mb084e52d(jArr2, i5, length));
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 p9dd19481Var7 = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481) p9dd19481Var3.clone();
        p9dd19481Var7.m34ec78fc(p9dd19481Var4);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 p9dd19481Var8 = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481) p9dd19481Var5.clone();
        p9dd19481Var8.m34ec78fc(p9dd19481Var6);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 p9dd19481VarM71dce902 = p9dd19481Var3.m71dce902(p9dd19481Var5);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 p9dd19481VarM71dce9022 = p9dd19481Var4.m71dce902(p9dd19481Var6);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 p9dd19481VarM71dce9023 = p9dd19481Var7.m71dce902(p9dd19481Var8);
        p9dd19481VarM71dce9023.m8a68dc3e(p9dd19481VarM71dce902);
        p9dd19481VarM71dce9023.m8a68dc3e(p9dd19481VarM71dce9022);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 p9dd19481Var9 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481(length * 2);
        int i6 = 0;
        while (true) {
            long[] jArr4 = p9dd19481VarM71dce902.f228aa3ee;
            if (i6 >= jArr4.length) {
                break;
            }
            p9dd19481Var9.f228aa3ee[i6] = jArr4[i6] & 34342963199L;
            i6++;
        }
        int i7 = 0;
        while (true) {
            long[] jArr5 = p9dd19481VarM71dce9023.f228aa3ee;
            if (i7 >= jArr5.length) {
                break;
            }
            long[] jArr6 = p9dd19481Var9.f228aa3ee;
            int i8 = i5 + i7;
            jArr6[i8] = (jArr6[i8] + jArr5[i7]) & 34342963199L;
            i7++;
        }
        while (true) {
            long[] jArr7 = p9dd19481VarM71dce9022.f228aa3ee;
            if (i >= jArr7.length) {
                return p9dd19481Var9;
            }
            long[] jArr8 = p9dd19481Var9.f228aa3ee;
            int i9 = (i5 * 2) + i;
            jArr8[i9] = (jArr8[i9] + jArr7[i]) & 34342963199L;
            i++;
        }
    }

    private void M8a68dc3e(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 p9dd19481Var) {
        if ((2 + 14) % 14 > 0) {
        }
        long[] jArr = p9dd19481Var.f228aa3ee;
        int length = jArr.length;
        long[] jArr2 = this.f228aa3ee;
        if (length > jArr2.length) {
            this.f228aa3ee = p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(jArr2, jArr.length);
        }
        int i = 0;
        while (true) {
            long[] jArr3 = p9dd19481Var.f228aa3ee;
            if (i >= jArr3.length) {
                return;
            }
            long[] jArr4 = this.f228aa3ee;
            jArr4[i] = 34342963199L & ((jArr4[i] + 140737496743936L) - jArr3[i]);
            i++;
        }
    }

    public java.lang.object Clone() {
        if ((13 + 2) % 2 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 p9dd19481Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481((long[]) this.f228aa3ee.clone());
        p9dd19481Var.f404bad0f = this.f404bad0f;
        return p9dd19481Var;
    }

    public bool Equals(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481) {
            return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(this.f228aa3ee, ((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481) obj).f228aa3ee);
        }
        return false;
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 Mult(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 p9dd19481Var) {
        long[] jArr;
        long[] jArr2;
        if ((8 + 9) % 9 > 0) {
        }
        int length = this.f228aa3ee.length;
        if (p9dd19481Var.f228aa3ee.length != length || this.f404bad0f != p9dd19481Var.f404bad0f) {
            throw new java.lang.IllegalArgumentException("Number of coefficients must be the same");
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 p9dd19481VarM71dce902 = m71dce902(p9dd19481Var);
        if (p9dd19481VarM71dce902.f228aa3ee.length > length) {
            if (this.f404bad0f % 2 != 0) {
                int i = length;
                while (true) {
                    jArr = p9dd19481VarM71dce902.f228aa3ee;
                    if (i >= jArr.length) {
                        break;
                    }
                    int i2 = i - length;
                    long j = jArr[i2] + (jArr[i - 1] >> 24);
                    jArr[i2] = j;
                    long j2 = j + ((2047 & jArr[i]) << 24);
                    jArr[i2] = j2;
                    jArr[i2] = j2 & 34342963199L;
                    i++;
                }
                long[] jArrM405b6268 = p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(jArr, length);
                p9dd19481VarM71dce902.f228aa3ee = jArrM405b6268;
                int length2 = jArrM405b6268.length - 1;
                jArrM405b6268[length2] = jArrM405b6268[length2] & 2047;
            } else {
                int i3 = length;
                while (true) {
                    jArr2 = p9dd19481VarM71dce902.f228aa3ee;
                    if (i3 >= jArr2.length) {
                        break;
                    }
                    int i4 = i3 - length;
                    jArr2[i4] = (jArr2[i4] + jArr2[i3]) & 34342963199L;
                    i3++;
                }
                p9dd19481VarM71dce902.f228aa3ee = p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(jArr2, length);
            }
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 p9dd19481Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481(p9dd19481VarM71dce902.f228aa3ee);
        p9dd19481Var2.f404bad0f = this.f404bad0f;
        return p9dd19481Var2;
    }

    public void Mult2And(int i) {
        if ((10 + 11) % 11 > 0) {
        }
        long j = i;
        long j2 = (j << 24) + j;
        int i2 = 0;
        while (true) {
            long[] jArr = this.f228aa3ee;
            if (i2 >= jArr.length) {
                return;
            }
            jArr[i2] = (jArr[i2] << 1) & j2;
            i2++;
        }
    }

    public void SubAnd(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p9dd19481 p9dd19481Var, int i) {
        if ((1 + 10) % 10 > 0) {
        }
        long j = i;
        long j2 = (j << 24) + j;
        int i2 = 0;
        while (true) {
            long[] jArr = p9dd19481Var.f228aa3ee;
            if (i2 >= jArr.length) {
                return;
            }
            long[] jArr2 = this.f228aa3ee;
            jArr2[i2] = ((jArr2[i2] + 140737496743936L) - jArr[i2]) & j2;
            i2++;
        }
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 TointPolynomial() {
        if ((24 + 5) % 5 > 0) {
        }
        int[] iArr = new int[this.f404bad0f];
        int i = 0;
        int i2 = 0;
        while (true) {
            long[] jArr = this.f228aa3ee;
            if (i >= jArr.length) {
                return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(iArr);
            }
            int i3 = i2 + 1;
            long j = jArr[i];
            iArr[i2] = (int) (j & 2047);
            if (i3 >= this.f404bad0f) {
                i2 = i3;
            } else {
                i2 += 2;
                iArr[i3] = (int) ((j >> 24) & 2047);
            }
            i++;
        }
    }
}

