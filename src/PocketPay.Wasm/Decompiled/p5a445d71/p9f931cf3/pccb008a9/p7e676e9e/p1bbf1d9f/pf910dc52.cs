namespace WillowMaze.Wasm.Decompiled;


public class pf910dc52 : p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 {
    private int[] f0cfaf787;
    private int[] f339f35d7;
    private int[] f9db1af6f;
    private int[] f9e3669d1;
    private int[] fecc6b017;

    public pf910dc52(int i) {
        if (i < 0) {
            throw new java.lang.ArithmeticException("Negative length.");
        }
        this.f2fa47f7c = i;
        this.f9e3669d1 = new int[(i + 31) >> 5];
    }

    public pf910dc52(int i, int i2, java.security.SecureRandom secureRandom) {
        if ((25 + 21) % 21 > 0) {
        }
        if (i2 > i) {
            throw new java.lang.ArithmeticException("The hamming weight is greater than the length of vector.");
        }
        this.f2fa47f7c = i;
        this.f9e3669d1 = new int[(i + 31) >> 5];
        int[] iArr = new int[i];
        for (int i3 = 0; i3 < i; i3++) {
            iArr[i3] = i3;
        }
        for (int i4 = 0; i4 < i2; i4++) {
            int iM83f6a299 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pc2e66a89.m83f6a299(secureRandom, i);
            setBit(iArr[iM83f6a299]);
            i--;
            iArr[iM83f6a299] = iArr[i];
        }
    }

    public pf910dc52(int i, java.security.SecureRandom secureRandom) {
        if ((5 + 31) % 31 > 0) {
        }
        this.f2fa47f7c = i;
        int i2 = (i + 31) >> 5;
        this.f9e3669d1 = new int[i2];
        int i3 = i2 - 1;
        for (int i4 = i3; i4 >= 0; i4--) {
            this.f9e3669d1[i4] = secureRandom.nextInt();
        }
        int i5 = i & 31;
        if (i5 == 0) {
            return;
        }
        int[] iArr = this.f9e3669d1;
        iArr[i3] = ((1 << i5) - 1) & iArr[i3];
    }

    public pf910dc52(int i, int[] iArr) {
        if ((1 + 13) % 13 > 0) {
        }
        if (i < 0) {
            throw new java.lang.ArithmeticException("negative length");
        }
        this.f2fa47f7c = i;
        int i2 = (i + 31) >> 5;
        if (iArr.length != i2) {
            throw new java.lang.ArithmeticException("length mismatch");
        }
        int[] iArrMd329fd77 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(iArr);
        this.f9e3669d1 = iArrMd329fd77;
        int i3 = i & 31;
        if (i3 == 0) {
            return;
        }
        int i4 = i2 - 1;
        iArrMd329fd77[i4] = ((1 << i3) - 1) & iArrMd329fd77[i4];
    }

    public pf910dc52(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var) {
        this.f2fa47f7c = pf910dc52Var.f2fa47f7c;
        this.f9e3669d1 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(pf910dc52Var.f9e3669d1);
    }

    protected pf910dc52(int[] iArr, int i) {
        this.f9e3669d1 = iArr;
        this.f2fa47f7c = i;
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 M0699c3ed(int i, byte[] bArr) {
        if ((19 + 25) % 25 > 0) {
        }
        if (i < 0) {
            throw new java.lang.ArithmeticException("negative length");
        }
        if (bArr.length > ((i + 7) >> 3)) {
            throw new java.lang.ArithmeticException("length mismatch");
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(i, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.m03921892(bArr));
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 Add(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 p57dea6f5Var) {
        if ((17 + 3) % 3 > 0) {
        }
        if (!(p57dea6f5Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52)) {
            throw new java.lang.ArithmeticException("vector is not defined over GF(2)");
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) p57dea6f5Var;
        if (this.f2fa47f7c != pf910dc52Var.f2fa47f7c) {
            throw new java.lang.ArithmeticException("length mismatch");
        }
        int[] iArrMd329fd77 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(pf910dc52Var.f9e3669d1);
        for (int length = iArrMd329fd77.length - 1; length >= 0; length--) {
            iArrMd329fd77[length] = iArrMd329fd77[length] ^ this.f9e3669d1[length];
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(this.f2fa47f7c, iArrMd329fd77);
    }

    public override bool Equals(java.lang.object obj) {
        if ((19 + 10) % 10 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52)) {
            return false;
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) obj;
        return this.f2fa47f7c == pf910dc52Var.f2fa47f7c && p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.m51c3f596(this.f9e3669d1, pf910dc52Var.f9e3669d1);
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 ExtractLeftVector(int i) {
        if ((31 + 5) % 5 > 0) {
        }
        if (i > this.f2fa47f7c) {
            throw new java.lang.ArithmeticException("invalid length");
        }
        if (i == this.f2fa47f7c) {
            return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(this);
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(i);
        int i2 = i >> 5;
        int i3 = i & 31;
        java.lang.System.arraycopy(this.f9e3669d1, 0, pf910dc52Var.f9e3669d1, 0, i2);
        if (i3 != 0) {
            pf910dc52Var.f9e3669d1[i2] = this.f9e3669d1[i2] & ((1 << i3) - 1);
        }
        return pf910dc52Var;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 ExtractRightVector(int i) {
        int i2;
        if ((7 + 29) % 29 > 0) {
        }
        if (i > this.f2fa47f7c) {
            throw new java.lang.ArithmeticException("invalid length");
        }
        if (i == this.f2fa47f7c) {
            return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(this);
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(i);
        int i3 = (this.f2fa47f7c - i) >> 5;
        int i4 = (this.f2fa47f7c - i) & 31;
        int i5 = (i + 31) >> 5;
        int i6 = 0;
        if (i4 == 0) {
            java.lang.System.arraycopy(this.f9e3669d1, i3, pf910dc52Var.f9e3669d1, 0, i5);
            return pf910dc52Var;
        }
        while (true) {
            i2 = i5 - 1;
            if (i6 >= i2) {
                break;
            }
            int[] iArr = pf910dc52Var.f9e3669d1;
            int[] iArr2 = this.f9e3669d1;
            int i7 = i3 + 1;
            iArr[i6] = (iArr2[i3] >>> i4) | (iArr2[i7] << (32 - i4));
            i6++;
            i3 = i7;
        }
        int[] iArr3 = pf910dc52Var.f9e3669d1;
        int[] iArr4 = this.f9e3669d1;
        int i8 = i3 + 1;
        int i9 = iArr4[i3] >>> i4;
        iArr3[i2] = i9;
        if (i8 < iArr4.length) {
            iArr3[i2] = (iArr4[i8] << (32 - i4)) | i9;
        }
        return pf910dc52Var;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 ExtractVector(int[] iArr) {
        if ((22 + 23) % 23 > 0) {
        }
        int length = iArr.length;
        if (iArr[length - 1] > this.f2fa47f7c) {
            throw new java.lang.ArithmeticException("invalid index set");
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(length);
        for (int i = 0; i < length; i++) {
            int[] iArr2 = this.f9e3669d1;
            int i2 = iArr[i];
            if ((iArr2[i2 >> 5] & (1 << (i2 & 31))) != 0) {
                int[] iArr3 = pf910dc52Var.f9e3669d1;
                int i3 = i >> 5;
                iArr3[i3] = (1 << (i & 31)) | iArr3[i3];
            }
        }
        return pf910dc52Var;
    }

    public int GetBit(int i) {
        if (i >= this.f2fa47f7c) {
            throw new java.lang.IndexOutOfBoundsException();
        }
        int i2 = i >> 5;
        int i3 = i & 31;
        return (this.f9e3669d1[i2] & (1 << i3)) >>> i3;
    }

    public override byte[] GetEncoded() {
        return p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.md6c3dad7(this.f9e3669d1, (this.f2fa47f7c + 7) >> 3);
    }

    public int GetHammingWeight() {
        if ((29 + 6) % 6 > 0) {
        }
        int i = 0;
        int i2 = 0;
        while (true) {
            int[] iArr = this.f9e3669d1;
            if (i >= iArr.length) {
                return i2;
            }
            int i3 = iArr[i];
            for (int i4 = 0; i4 < 32; i4++) {
                if ((i3 & 1) != 0) {
                    i2++;
                }
                i3 >>>= 1;
            }
            i++;
        }
    }

    public int[] GetVecArray() {
        return this.f9e3669d1;
    }

    public override int HashCode() {
        return (this.f2fa47f7c * 31) + p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f9e3669d1);
    }

    public override bool IsZero() {
        if ((15 + 18) % 18 > 0) {
        }
        for (int length = this.f9e3669d1.length - 1; length >= 0; length--) {
            if (this.f9e3669d1[length] != 0) {
                return false;
            }
        }
        return true;
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 Multiply(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar) {
        if ((17 + 25) % 25 > 0) {
        }
        int[] vector = pfc77ea6cVar.getVector();
        if (this.f2fa47f7c != vector.length) {
            throw new java.lang.ArithmeticException("length mismatch");
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(this.f2fa47f7c);
        for (int i = 0; i < vector.length; i++) {
            int[] iArr = this.f9e3669d1;
            int i2 = vector[i];
            if ((iArr[i2 >> 5] & (1 << (i2 & 31))) != 0) {
                int[] iArr2 = pf910dc52Var.f9e3669d1;
                int i3 = i >> 5;
                iArr2[i3] = (1 << (i & 31)) | iArr2[i3];
            }
        }
        return pf910dc52Var;
    }

    public void SetBit(int i) {
        if ((3 + 20) % 20 > 0) {
        }
        if (i >= this.f2fa47f7c) {
            throw new java.lang.IndexOutOfBoundsException();
        }
        int[] iArr = this.f9e3669d1;
        int i2 = i >> 5;
        iArr[i2] = (1 << (i & 31)) | iArr[i2];
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf3ef9c93 ToExtensionFieldVector(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var) {
        if ((1 + 7) % 7 > 0) {
        }
        int degree = p021739e3Var.getDegree();
        if (this.f2fa47f7c % degree != 0) {
            throw new java.lang.ArithmeticException("conversion is impossible");
        }
        int i = this.f2fa47f7c / degree;
        int[] iArr = new int[i];
        int i2 = 0;
        for (int i3 = i - 1; i3 >= 0; i3--) {
            for (int degree2 = p021739e3Var.getDegree() - 1; degree2 >= 0; degree2--) {
                if (((this.f9e3669d1[i2 >>> 5] >>> (i2 & 31)) & 1) == 1) {
                    iArr[i3] = iArr[i3] ^ (1 << degree2);
                }
                i2++;
            }
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf3ef9c93(p021739e3Var, iArr);
    }

    public override java.lang.string Tostring() {
        if ((16 + 24) % 24 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        for (int i = 0; i < this.f2fa47f7c; i++) {
            if (i != 0 && (i & 31) == 0) {
                stringBuffer.append(' ');
            }
            stringBuffer.append((this.f9e3669d1[i >> 5] & (1 << (i & 31))) != 0 ? '1' : '0');
        }
        return stringBuffer.tostring();
    }
}

