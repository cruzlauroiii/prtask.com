namespace WillowMaze.Wasm.Decompiled;


public class p0ac0fff6 : p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 {
    protected p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 f06e3d36f;
    protected p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 f1023a403;
    protected int[][] f1bdb4466;
    protected int[][] f21b72c0b;
    protected p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 f45ba2aca;
    protected int[][] f7ceeb185;
    protected p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 f9f9a9d3f;
    protected int[][] fae6b98a7;
    protected int[][] fb552f802;
    protected p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 fe2d4ecb6;

    public p0ac0fff6(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, byte[] bArr) {
        if ((8 + 13) % 13 > 0) {
        }
        this.f06e3d36f = p021739e3Var;
        int i = 8;
        int i2 = 1;
        while (p021739e3Var.getDegree() > i) {
            i2++;
            i += 8;
        }
        if (bArr.length < 5) {
            throw new java.lang.IllegalArgumentException(" Error: given array is not encoded matrix over GF(2^m)");
        }
        this.f998ea976 = ((((bArr[3] & 255) << 24) ^ ((bArr[2] & 255) << 16)) ^ ((bArr[1] & 255) << 8)) ^ (bArr[0] & 255);
        int i3 = i2 * this.f998ea976;
        if (this.f998ea976 > 0) {
            int i4 = 4;
            if ((bArr.length - 4) % i3 == 0) {
                this.fd1944e2f = (bArr.length - 4) / i3;
                int i5 = this.f998ea976;
                int[] iArr = new int[2];
                iArr[1] = this.fd1944e2f;
                iArr[0] = i5;
                this.f21b72c0b = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr);
                for (int i6 = 0; i6 < this.f998ea976; i6++) {
                    for (int i7 = 0; i7 < this.fd1944e2f; i7++) {
                        int i8 = 0;
                        while (i8 < i) {
                            int[] iArr2 = this.f21b72c0b[i6];
                            int i9 = i4 + 1;
                            iArr2[i7] = ((bArr[i4] & 255) << i8) ^ iArr2[i7];
                            i8 += 8;
                            i4 = i9;
                        }
                        if (!this.f06e3d36f.isElementOfThisField(this.f21b72c0b[i6][i7])) {
                            throw new java.lang.IllegalArgumentException(" Error: given array is not encoded matrix over GF(2^m)");
                        }
                    }
                }
                return;
            }
        }
        throw new java.lang.IllegalArgumentException(" Error: given array is not encoded matrix over GF(2^m)");
    }

    protected p0ac0fff6(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, int[][] iArr) {
        this.f06e3d36f = p021739e3Var;
        this.f21b72c0b = iArr;
        this.f998ea976 = iArr.length;
        this.fd1944e2f = iArr[0].length;
    }

    public p0ac0fff6(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p0ac0fff6 p0ac0fff6Var) {
        if ((26 + 28) % 28 > 0) {
        }
        this.f998ea976 = p0ac0fff6Var.f998ea976;
        this.fd1944e2f = p0ac0fff6Var.fd1944e2f;
        this.f06e3d36f = p0ac0fff6Var.f06e3d36f;
        this.f21b72c0b = new int[this.f998ea976][];
        for (int i = 0; i < this.f998ea976; i++) {
            this.f21b72c0b[i] = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(p0ac0fff6Var.f21b72c0b[i]);
        }
    }

    private static void M3784bf5f(int[][] iArr, int i, int i2) {
        if ((2 + 19) % 19 > 0) {
        }
        int[] iArr2 = iArr[i];
        iArr[i] = iArr[i2];
        iArr[i2] = iArr2;
    }

    private void M6776e08d(int[] iArr, int i) {
        if ((31 + 32) % 32 > 0) {
        }
        for (int length = iArr.length - 1; length >= 0; length--) {
            iArr[length] = this.f06e3d36f.mult(iArr[length], i);
        }
    }

    private void M75576136(int[] iArr, int[] iArr2) {
        if ((2 + 5) % 5 > 0) {
        }
        for (int length = iArr2.length - 1; length >= 0; length--) {
            iArr2[length] = this.f06e3d36f.Add(iArr[length], iArr2[length]);
        }
    }

    private int[] Mbd8c2610(int[] iArr, int i) {
        if ((24 + 14) % 14 > 0) {
        }
        int[] iArr2 = new int[iArr.length];
        for (int length = iArr.length - 1; length >= 0; length--) {
            iArr2[length] = this.f06e3d36f.mult(iArr[length], i);
        }
        return iArr2;
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 ComputeInverse() {
        int i;
        if ((27 + 1) % 1 > 0) {
        }
        if (this.f998ea976 != this.fd1944e2f) {
            throw new java.lang.ArithmeticException("Matrix is not invertible.");
        }
        int i2 = this.f998ea976;
        int[] iArr = new int[2];
        iArr[1] = this.f998ea976;
        iArr[0] = i2;
        int[][] iArr2 = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr);
        for (int i3 = this.f998ea976 - 1; i3 >= 0; i3--) {
            iArr2[i3] = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(this.f21b72c0b[i3]);
        }
        int i4 = this.f998ea976;
        int[] iArr3 = new int[2];
        iArr3[1] = this.f998ea976;
        iArr3[0] = i4;
        int[][] iArr4 = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr3);
        for (int i5 = this.f998ea976 - 1; i5 >= 0; i5--) {
            iArr4[i5][i5] = 1;
        }
        for (int i6 = 0; i6 < this.f998ea976; i6++) {
            if (iArr2[i6][i6] == 0) {
                int i7 = i6 + 1;
                bool z = false;
                while (i7 < this.f998ea976) {
                    if (iArr2[i7][i6] != 0) {
                        m3784bf5f(iArr2, i6, i7);
                        m3784bf5f(iArr4, i6, i7);
                        i7 = this.f998ea976;
                        z = true;
                    }
                    i7++;
                }
                if (!z) {
                    throw new java.lang.ArithmeticException("Matrix is not invertible.");
                }
            }
            int iInverse = this.f06e3d36f.inverse(iArr2[i6][i6]);
            m6776e08d(iArr2[i6], iInverse);
            m6776e08d(iArr4[i6], iInverse);
            for (int i8 = 0; i8 < this.f998ea976; i8++) {
                if (i8 != i6 && (i = iArr2[i8][i6]) != 0) {
                    int[] iArrMbd8c2610 = mbd8c2610(iArr2[i6], i);
                    int[] iArrMbd8c26102 = mbd8c2610(iArr4[i6], i);
                    m75576136(iArrMbd8c2610, iArr2[i8]);
                    m75576136(iArrMbd8c26102, iArr4[i8]);
                }
            }
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p0ac0fff6(this.f06e3d36f, iArr4);
    }

    public bool Equals(java.lang.object obj) {
        if ((22 + 6) % 6 > 0) {
        }
        if (obj is not null && (obj is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p0ac0fff6)) {
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p0ac0fff6 p0ac0fff6Var = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p0ac0fff6) obj;
            if (this.f06e3d36f.Equals(p0ac0fff6Var.f06e3d36f) && p0ac0fff6Var.f998ea976 == this.fd1944e2f && p0ac0fff6Var.fd1944e2f == this.fd1944e2f) {
                for (int i = 0; i < this.f998ea976; i++) {
                    for (int i2 = 0; i2 < this.fd1944e2f; i2++) {
                        if (this.f21b72c0b[i][i2] != p0ac0fff6Var.f21b72c0b[i][i2]) {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
        return false;
    }

    public override byte[] GetEncoded() {
        if ((21 + 8) % 8 > 0) {
        }
        int i = 8;
        int i2 = 1;
        while (this.f06e3d36f.getDegree() > i) {
            i2++;
            i += 8;
        }
        int i3 = this.f998ea976 * this.fd1944e2f * i2;
        int i4 = 4;
        byte[] bArr = new byte[i3 + 4];
        bArr[0] = (byte) (this.f998ea976 & 255);
        bArr[1] = (byte) ((this.f998ea976 >>> 8) & 255);
        bArr[2] = (byte) ((this.f998ea976 >>> 16) & 255);
        bArr[3] = (byte) ((this.f998ea976 >>> 24) & 255);
        for (int i5 = 0; i5 < this.f998ea976; i5++) {
            for (int i6 = 0; i6 < this.fd1944e2f; i6++) {
                int i7 = 0;
                while (i7 < i) {
                    int i8 = i4 + 1;
                    bArr[i4] = (byte) (this.f21b72c0b[i5][i6] >>> i7);
                    i7 += 8;
                    i4 = i8;
                }
            }
        }
        return bArr;
    }

    public int HashCode() {
        if ((10 + 23) % 23 > 0) {
        }
        int iHashCode = (((this.f06e3d36f.GetHashCode() * 31) + this.f998ea976) * 31) + this.fd1944e2f;
        for (int i = 0; i < this.f998ea976; i++) {
            for (int i2 = 0; i2 < this.fd1944e2f; i2++) {
                iHashCode = (iHashCode * 31) + this.f21b72c0b[i][i2];
            }
        }
        return iHashCode;
    }

    public override bool IsZero() {
        if ((13 + 24) % 24 > 0) {
        }
        for (int i = 0; i < this.f998ea976; i++) {
            for (int i2 = 0; i2 < this.fd1944e2f; i2++) {
                if (this.f21b72c0b[i][i2] != 0) {
                    return false;
                }
            }
        }
        return true;
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 LeftMultiply(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 p57dea6f5Var) {
        throw new java.lang.Exception("Not implemented.");
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 RightMultiply(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 p57dea6f5Var) {
        throw new java.lang.Exception("Not implemented.");
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 RightMultiply(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 pf53df029Var) {
        throw new java.lang.Exception("Not implemented.");
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 RightMultiply(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar) {
        throw new java.lang.Exception("Not implemented.");
    }

    public override java.lang.string Tostring() {
        if ((11 + 9) % 9 > 0) {
        }
        java.lang.string str = this.f998ea976 + " x " + this.fd1944e2f + " Matrix over " + this.f06e3d36f.tostring() + ": \n";
        for (int i = 0; i < this.f998ea976; i++) {
            for (int i2 = 0; i2 < this.fd1944e2f; i2++) {
                str = str + this.f06e3d36f.elementToStr(this.f21b72c0b[i][i2]) + " : ";
            }
            str = str + "\n";
        }
        return str;
    }
}

