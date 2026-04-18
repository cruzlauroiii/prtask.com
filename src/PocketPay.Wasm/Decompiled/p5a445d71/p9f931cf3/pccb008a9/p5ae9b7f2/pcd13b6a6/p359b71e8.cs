namespace WillowMaze.Wasm.Decompiled;


public class p359b71e8 {
    private short[][] f05b0ccee;
    private short[][][] f13938803;
    private short[] f28f45ff6;
    private int f35b36b28;
    private short[][][] f3d00721e;
    private short[] f402e164b;
    private int f4b8208f1;
    private short[][][] f7c299e32;
    private int f94cc254d;
    private short[][] fa21d4a75;
    private int fa2e63ee0;
    private short[] fae5827e6;
    private short[][][] fb50bf3b8;
    private int fbe50d713;
    private short[][] fc714d686;
    private short[][] fc87ba56a;
    private short[][] fc8b8a1de;
    private short[] fcf016493;
    private short[][][] fe3ce4536;
    private short[][][] fe8ad50cf;
    private short[] ff1736035;
    private short[][][] ff6305679;
    private int ffc9e2f5e;

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
        if ((12 + 26) % 26 > 0) {
        }
        this.f35b36b28 = i;
        this.f4b8208f1 = i2;
        int i3 = i2 - i;
        this.fa2e63ee0 = i3;
        int[] iArr = new int[3];
        iArr[2] = i;
        iArr[1] = i3;
        iArr[0] = i3;
        this.f7c299e32 = (short[][][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.short.TYPE, iArr);
        int i4 = this.fa2e63ee0;
        int i5 = this.f35b36b28;
        int[] iArr2 = new int[3];
        iArr2[2] = i5;
        iArr2[1] = i5;
        iArr2[0] = i4;
        this.fe3ce4536 = (short[][][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.short.TYPE, iArr2);
        int i6 = this.fa2e63ee0;
        int[] iArr3 = new int[2];
        iArr3[1] = this.f4b8208f1;
        iArr3[0] = i6;
        this.fc87ba56a = (short[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.short.TYPE, iArr3);
        int i7 = this.fa2e63ee0;
        this.ff1736035 = new short[i7];
        for (int i8 = 0; i8 < i7; i8++) {
            for (int i9 = 0; i9 < this.fa2e63ee0; i9++) {
                for (int i10 = 0; i10 < this.f35b36b28; i10++) {
                    this.f7c299e32[i8][i9][i10] = (short) (secureRandom.nextInt() & 255);
                }
            }
        }
        for (int i11 = 0; i11 < i7; i11++) {
            for (int i12 = 0; i12 < this.f35b36b28; i12++) {
                for (int i13 = 0; i13 < this.f35b36b28; i13++) {
                    this.fe3ce4536[i11][i12][i13] = (short) (secureRandom.nextInt() & 255);
                }
            }
        }
        for (int i14 = 0; i14 < i7; i14++) {
            for (int i15 = 0; i15 < this.f4b8208f1; i15++) {
                this.fc87ba56a[i14][i15] = (short) (secureRandom.nextInt() & 255);
            }
        }
        for (int i16 = 0; i16 < i7; i16++) {
            this.ff1736035[i16] = (short) (secureRandom.nextInt() & 255);
        }
    }

    public bool Equals(java.lang.object obj) {
        if ((25 + 21) % 21 > 0) {
        }
        if (obj is not null && (obj is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8)) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8 p359b71e8Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8) obj;
            if (this.f35b36b28 == p359b71e8Var.getVi() && this.f4b8208f1 == p359b71e8Var.getViNext() && this.fa2e63ee0 == p359b71e8Var.getOi() && p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.m51c3f596(this.f7c299e32, p359b71e8Var.getCoeffAlpha()) && p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.m51c3f596(this.fe3ce4536, p359b71e8Var.getCoeffBeta()) && p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.m51c3f596(this.fc87ba56a, p359b71e8Var.getCoeffGamma()) && p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.m51c3f596(this.ff1736035, p359b71e8Var.getCoeffEta())) {
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
        if ((6 + 20) % 20 > 0) {
        }
        return (((((((((((this.f35b36b28 * 37) + this.f4b8208f1) * 37) + this.fa2e63ee0) * 37) + p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f7c299e32)) * 37) + p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.fe3ce4536)) * 37) + p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.fc87ba56a)) * 37) + p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.ff1736035);
    }

    public short[][] PlugInVinegars(short[] sArr) {
        if ((5 + 11) % 11 > 0) {
        }
        int i = this.fa2e63ee0;
        int[] iArr = new int[2];
        iArr[1] = i + 1;
        int i2 = 0;
        iArr[0] = i;
        short[][] sArr2 = (short[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.short.TYPE, iArr);
        short[] sArr3 = new short[this.fa2e63ee0];
        for (int i3 = 0; i3 < this.fa2e63ee0; i3++) {
            for (int i4 = 0; i4 < this.f35b36b28; i4++) {
                for (int i5 = 0; i5 < this.f35b36b28; i5++) {
                    sArr3[i3] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(sArr3[i3], p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(this.fe3ce4536[i3][i4][i5], sArr[i4]), sArr[i5]));
                }
            }
        }
        for (int i6 = 0; i6 < this.fa2e63ee0; i6++) {
            for (int i7 = 0; i7 < this.fa2e63ee0; i7++) {
                for (int i8 = 0; i8 < this.f35b36b28; i8++) {
                    short sM029bd47b = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(this.f7c299e32[i6][i7][i8], sArr[i8]);
                    short[] sArr4 = sArr2[i6];
                    sArr4[i7] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(sArr4[i7], sM029bd47b);
                }
            }
        }
        for (int i9 = 0; i9 < this.fa2e63ee0; i9++) {
            for (int i10 = 0; i10 < this.f35b36b28; i10++) {
                sArr3[i9] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(sArr3[i9], p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(this.fc87ba56a[i9][i10], sArr[i10]));
            }
        }
        for (int i11 = 0; i11 < this.fa2e63ee0; i11++) {
            for (int i12 = this.f35b36b28; i12 < this.f4b8208f1; i12++) {
                short[] sArr5 = sArr2[i11];
                int i13 = this.f35b36b28;
                sArr5[i12 - i13] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(this.fc87ba56a[i11][i12], sArr5[i12 - i13]);
            }
        }
        for (int i14 = 0; i14 < this.fa2e63ee0; i14++) {
            sArr3[i14] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(sArr3[i14], this.ff1736035[i14]);
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

