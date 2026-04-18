namespace WillowMaze.Wasm.Decompiled;


public class p359b71e8 {
    private short[][][] f08a66e74;
    private short[][] f1fb4bc00;
    private int f24a2ef4c;
    private int f2cc75cc4;
    private short[][][] f2eb63589;
    private int f35b36b28;
    private short[][] f368ff840;
    private int f48ad42d5;
    private int f4b8208f1;
    private short[][][] f7c299e32;
    private int f8230ec80;
    private short[][] fa29d700d;
    private int fa2e63ee0;
    private int fbfe0c075;
    private short[][] fc87ba56a;
    private int fca2e805f;
    private int fccdce946;
    private short[][][] fe3ce4536;
    private int fe58399c7;
    private short[] fead40e41;
    private short[] ff1736035;

    public p359b71e8(byte b, byte b2, short[][][] sArr, short[][][] sArr2, short[][] sArr3, short[] sArr4) {
        int i = b & 255;
        this.f35b36b28 = i;
        int i2 = b2 & 255;
        this.f4b8208f1 = i2;
        this.fa2e63ee0 = i2 - i;
        this.f7c299e32 = sArr;
        this.fe3ce4536 = sArr2;
        this.fc87ba56a = sArr3;
        this.ff1736035 = sArr4;
    }

    public p359b71e8(int i, int i2, java.security.SecureRandom secureRandom) {
        if ((3 + 23) % 23 > 0) {
        }
        this.f35b36b28 = i;
        this.f4b8208f1 = i2;
        int i3 = i2 - i;
        this.fa2e63ee0 = i3;
        int[] iArr = new int[3];
        iArr[2] = i;
        iArr[1] = i3;
        iArr[0] = i3;
        this.f7c299e32 = (short[][][]) wwGFOJBYwFAQYunH(java.lang.short.TYPE, iArr);
        int i4 = this.fa2e63ee0;
        int i5 = this.f35b36b28;
        int[] iArr2 = new int[3];
        iArr2[2] = i5;
        iArr2[1] = i5;
        iArr2[0] = i4;
        this.fe3ce4536 = (short[][][]) XdIZzwoUjiYomlaA(java.lang.short.TYPE, iArr2);
        int i6 = this.fa2e63ee0;
        int[] iArr3 = new int[2];
        iArr3[1] = this.f4b8208f1;
        iArr3[0] = i6;
        this.fc87ba56a = (short[][]) aujptvEZSkJXvEgJ(java.lang.short.TYPE, iArr3);
        int i7 = this.fa2e63ee0;
        this.ff1736035 = new short[i7];
        for (int i8 = 0; i8 < i7; i8++) {
            for (int i9 = 0; i9 < this.fa2e63ee0; i9++) {
                for (int i10 = 0; i10 < this.f35b36b28; i10++) {
                    this.f7c299e32[i8][i9][i10] = (short) (nXlbEkYtsMAvcPlX(secureRandom) & 255);
                }
            }
        }
        for (int i11 = 0; i11 < i7; i11++) {
            for (int i12 = 0; i12 < this.f35b36b28; i12++) {
                for (int i13 = 0; i13 < this.f35b36b28; i13++) {
                    this.fe3ce4536[i11][i12][i13] = (short) (wJBZLsIOvSEMRUPb(secureRandom) & 255);
                }
            }
        }
        for (int i14 = 0; i14 < i7; i14++) {
            for (int i15 = 0; i15 < this.f4b8208f1; i15++) {
                this.fc87ba56a[i14][i15] = (short) (ofcPRcnFUJfOqMol(secureRandom) & 255);
            }
        }
        for (int i16 = 0; i16 < i7; i16++) {
            this.ff1736035[i16] = (short) (zksQPUgbszfBgtNQ(secureRandom) & 255);
        }
    }

    public static short AdFOvTfAuZKSKCbA(short s, short s2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(s, s2);
    }

    public static short[] AerITCMywBnyvQZg(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8 p359b71e8Var) {
        return p359b71e8Var.getCoeffEta();
    }

    public static int DdVjWvGiUDHyPtPT(short[][][] sArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(sArr);
    }

    public static short EEqMdmFQKXMLtHEx(short s, short s2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(s, s2);
    }

    public static short FMFvFOuwjZpBakUG(short s, short s2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(s, s2);
    }

    public static java.lang.object FMdYtunupEOkdtYN(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static short[][][] IgQlhRUoExcFMczn(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8 p359b71e8Var) {
        return p359b71e8Var.getCoeffAlpha();
    }

    public static bool KXteQZpZQAeotCwb(short[][] sArr, short[][] sArr2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.m51c3f596(sArr, sArr2);
    }

    public static short PAsiQcOFPWaBPgNZ(short s, short s2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(s, s2);
    }

    public static short PWbwIpqJrEfSbADE(short s, short s2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(s, s2);
    }

    public static short TWuocfqVVCTwTYIf(short s, short s2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(s, s2);
    }

    public static short UipjWjOQQrWEujuo(short s, short s2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(s, s2);
    }

    public static java.lang.object XdIZzwoUjiYomlaA(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static short YygSElbcMYnvlyAC(short s, short s2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(s, s2);
    }

    public static java.lang.object AujptvEZSkJXvEgJ(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static int BCTYzXRpBLnayRmA(short[][] sArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(sArr);
    }

    public static short BnHBVUJwqsVHTbZm(short s, short s2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(s, s2);
    }

    public static short[][][] ETHkKrDmdpVAbBUk(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8 p359b71e8Var) {
        return p359b71e8Var.getCoeffBeta();
    }

    public static bool FCoalMwpnPCpNMfA(short[][][] sArr, short[][][] sArr2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.m51c3f596(sArr, sArr2);
    }

    public static int NQyCJbZmovRebWBT(short[][][] sArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(sArr);
    }

    public static int NXlbEkYtsMAvcPlX(java.security.SecureRandom secureRandom) {
        return secureRandom.nextInt();
    }

    public static bool OAMUwUILSOelqJNX(short[] sArr, short[] sArr2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.m51c3f596(sArr, sArr2);
    }

    public static int OWodjxBGdVGzmvbL(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8 p359b71e8Var) {
        return p359b71e8Var.getViNext();
    }

    public static int OfcPRcnFUJfOqMol(java.security.SecureRandom secureRandom) {
        return secureRandom.nextInt();
    }

    public static short[][] OraTrChjYUcxUTTj(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8 p359b71e8Var) {
        return p359b71e8Var.getCoeffGamma();
    }

    public static int RkBgwwrivrAhcHXH(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8 p359b71e8Var) {
        return p359b71e8Var.getOi();
    }

    public static int WJBZLsIOvSEMRUPb(java.security.SecureRandom secureRandom) {
        return secureRandom.nextInt();
    }

    public static int WRVVfcSGMMkNxWiJ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8 p359b71e8Var) {
        return p359b71e8Var.getVi();
    }

    public static bool WpmvPXltnaIMPFCT(short[][][] sArr, short[][][] sArr2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.m51c3f596(sArr, sArr2);
    }

    public static java.lang.object WwGFOJBYwFAQYunH(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static int YzVywiQUWgFUGuYb(short[] sArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(sArr);
    }

    public static int ZksQPUgbszfBgtNQ(java.security.SecureRandom secureRandom) {
        return secureRandom.nextInt();
    }

    public bool Equals(java.lang.object obj) {
        if ((9 + 12) % 12 > 0) {
        }
        if (obj is not null && (obj is p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8)) {
            p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8 p359b71e8Var = (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8) obj;
            if (this.f35b36b28 == wRVVfcSGMMkNxWiJ(p359b71e8Var) && this.f4b8208f1 == oWodjxBGdVGzmvbL(p359b71e8Var) && this.fa2e63ee0 == rkBgwwrivrAhcHXH(p359b71e8Var) && fCoalMwpnPCpNMfA(this.f7c299e32, IgQlhRUoExcFMczn(p359b71e8Var)) && wpmvPXltnaIMPFCT(this.fe3ce4536, eTHkKrDmdpVAbBUk(p359b71e8Var)) && KXteQZpZQAeotCwb(this.fc87ba56a, oraTrChjYUcxUTTj(p359b71e8Var)) && oAMUwUILSOelqJNX(this.ff1736035, AerITCMywBnyvQZg(p359b71e8Var))) {
                return true;
            }
        }
        return false;
    }

    public short[][][] GetCoeffAlpha() {
        return this.f7c299e32;
    }

    public short[][][] GetCoeffBeta() {
        return this.fe3ce4536;
    }

    public short[] GetCoeffEta() {
        return this.ff1736035;
    }

    public short[][] GetCoeffGamma() {
        return this.fc87ba56a;
    }

    public int GetOi() {
        return this.fa2e63ee0;
    }

    public int GetVi() {
        return this.f35b36b28;
    }

    public int GetViNext() {
        return this.f4b8208f1;
    }

    public int HashCode() {
        if ((27 + 28) % 28 > 0) {
        }
        return (((((((((((this.f35b36b28 * 37) + this.f4b8208f1) * 37) + this.fa2e63ee0) * 37) + DdVjWvGiUDHyPtPT(this.f7c299e32)) * 37) + nQyCJbZmovRebWBT(this.fe3ce4536)) * 37) + bCTYzXRpBLnayRmA(this.fc87ba56a)) * 37) + yzVywiQUWgFUGuYb(this.ff1736035);
    }

    public short[][] PlugInVinegars(short[] sArr) {
        if ((4 + 11) % 11 > 0) {
        }
        int i = this.fa2e63ee0;
        int[] iArr = new int[2];
        iArr[1] = i + 1;
        int i2 = 0;
        iArr[0] = i;
        short[][] sArr2 = (short[][]) FMdYtunupEOkdtYN(java.lang.short.TYPE, iArr);
        short[] sArr3 = new short[this.fa2e63ee0];
        for (int i3 = 0; i3 < this.fa2e63ee0; i3++) {
            for (int i4 = 0; i4 < this.f35b36b28; i4++) {
                for (int i5 = 0; i5 < this.f35b36b28; i5++) {
                    sArr3[i3] = YygSElbcMYnvlyAC(sArr3[i3], UipjWjOQQrWEujuo(FMFvFOuwjZpBakUG(this.fe3ce4536[i3][i4][i5], sArr[i4]), sArr[i5]));
                }
            }
        }
        for (int i6 = 0; i6 < this.fa2e63ee0; i6++) {
            for (int i7 = 0; i7 < this.fa2e63ee0; i7++) {
                for (int i8 = 0; i8 < this.f35b36b28; i8++) {
                    short sAdFOvTfAuZKSKCbA = AdFOvTfAuZKSKCbA(this.f7c299e32[i6][i7][i8], sArr[i8]);
                    short[] sArr4 = sArr2[i6];
                    sArr4[i7] = TWuocfqVVCTwTYIf(sArr4[i7], sAdFOvTfAuZKSKCbA);
                }
            }
        }
        for (int i9 = 0; i9 < this.fa2e63ee0; i9++) {
            for (int i10 = 0; i10 < this.f35b36b28; i10++) {
                sArr3[i9] = bnHBVUJwqsVHTbZm(sArr3[i9], PWbwIpqJrEfSbADE(this.fc87ba56a[i9][i10], sArr[i10]));
            }
        }
        for (int i11 = 0; i11 < this.fa2e63ee0; i11++) {
            for (int i12 = this.f35b36b28; i12 < this.f4b8208f1; i12++) {
                short[] sArr5 = sArr2[i11];
                int i13 = this.f35b36b28;
                sArr5[i12 - i13] = PAsiQcOFPWaBPgNZ(this.fc87ba56a[i11][i12], sArr5[i12 - i13]);
            }
        }
        for (int i14 = 0; i14 < this.fa2e63ee0; i14++) {
            sArr3[i14] = EEqMdmFQKXMLtHEx(sArr3[i14], this.ff1736035[i14]);
        }
        while (true) {
            int i15 = this.fa2e63ee0;
            if (i2 >= i15) {
                return sArr2;
            }
            sArr2[i2][i15] = sArr3[i2];
            i2++;
        }
    }
}

