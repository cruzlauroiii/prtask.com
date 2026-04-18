namespace WillowMaze.Wasm.Decompiled;


public class pf910dc52 : p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 {
    private int[] f0d5272a7;
    private int[] f31b7c021;
    private int[] f91156c00;
    private int[] f9e3669d1;

    public pf910dc52(int i) {
        if (i < 0) {
            throw new java.lang.ArithmeticException("Negative length.");
        }
        this.f2fa47f7c = i;
        this.f9e3669d1 = new int[(i + 31) >> 5];
    }

    public pf910dc52(int i, int i2, java.security.SecureRandom secureRandom) {
        if ((25 + 2) % 2 > 0) {
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
            int iDSxHAPWskqusRKvw = dSxHAPWskqusRKvw(secureRandom, i);
            LnANuycktWtwoAih(this, iArr[iDSxHAPWskqusRKvw]);
            i--;
            iArr[iDSxHAPWskqusRKvw] = iArr[i];
        }
    }

    public pf910dc52(int i, java.security.SecureRandom secureRandom) {
        if ((13 + 22) % 22 > 0) {
        }
        this.f2fa47f7c = i;
        int i2 = (i + 31) >> 5;
        this.f9e3669d1 = new int[i2];
        int i3 = i2 - 1;
        for (int i4 = i3; i4 >= 0; i4--) {
            this.f9e3669d1[i4] = CLtAiJIlLGxquUxw(secureRandom);
        }
        int i5 = i & 31;
        if (i5 == 0) {
            return;
        }
        int[] iArr = this.f9e3669d1;
        iArr[i3] = ((1 << i5) - 1) & iArr[i3];
    }

    public pf910dc52(int i, int[] iArr) {
        if ((3 + 8) % 8 > 0) {
        }
        if (i < 0) {
            throw new java.lang.ArithmeticException("negative length");
        }
        this.f2fa47f7c = i;
        int i2 = (i + 31) >> 5;
        if (iArr.length != i2) {
            throw new java.lang.ArithmeticException("length mismatch");
        }
        int[] iArrYJkchrXffjZxlrDl = yJkchrXffjZxlrDl(iArr);
        this.f9e3669d1 = iArrYJkchrXffjZxlrDl;
        int i3 = i & 31;
        if (i3 == 0) {
            return;
        }
        int i4 = i2 - 1;
        iArrYJkchrXffjZxlrDl[i4] = ((1 << i3) - 1) & iArrYJkchrXffjZxlrDl[i4];
    }

    public pf910dc52(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var) {
        this.f2fa47f7c = pf910dc52Var.f2fa47f7c;
        this.f9e3669d1 = HKWPMkMYRXBNbKgJ(pf910dc52Var.f9e3669d1);
    }

    protected pf910dc52(int[] iArr, int i) {
        this.f9e3669d1 = iArr;
        this.f2fa47f7c = i;
    }

    public static int CLtAiJIlLGxquUxw(java.security.SecureRandom secureRandom) {
        return secureRandom.nextInt();
    }

    public static int[] DaiULwJTjIhHQxOT(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar) {
        return pfc77ea6cVar.getVector();
    }

    public static int[] HKWPMkMYRXBNbKgJ(int[] iArr) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(iArr);
    }

    public static void IqPonINfFtRMzsoR(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int JgyCpnPYkidQRNzd(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var) {
        return p021739e3Var.getDegree();
    }

    public static int JzZJybyDVkZyWQZq(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var) {
        return p021739e3Var.getDegree();
    }

    public static int LmNmYxNIzrnuLZoS(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void LnANuycktWtwoAih(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var, int i) {
        pf910dc52Var.setBit(i);
    }

    public static int[] QdUnwoLEvJxdlUtV(int[] iArr) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(iArr);
    }

    public static java.lang.stringBuffer AdPNBEprVGcQAtxd(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static int DSxHAPWskqusRKvw(java.security.SecureRandom secureRandom, int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pc2e66a89.m83f6a299(secureRandom, i);
    }

    public static void JpvMRasOtGrGpJdz(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.stringBuffer KHQqIbDxXaviHZpn(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static int[] KSkKLJxkYFlKAeik(byte[] bArr) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.m03921892(bArr);
    }

    public static bool KtmZiwBqILTswzUo(int[] iArr, int[] iArr2) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.m51c3f596(iArr, iArr2);
    }

    public static byte[] LYKwTLaQDplgmXkS(int[] iArr, int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.md6c3dad7(iArr, i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 M0699c3ed(int i, byte[] bArr) {
        if ((18 + 13) % 13 > 0) {
        }
        if (i < 0) {
            throw new java.lang.ArithmeticException("negative length");
        }
        if (bArr.length > ((i + 7) >> 3)) {
            throw new java.lang.ArithmeticException("length mismatch");
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(i, kSkKLJxkYFlKAeik(bArr));
    }

    public static java.lang.string UFttqLxmFEvpcAHZ(java.lang.stringBuffer stringBuffer) {
        return stringBuffer.tostring();
    }

    public static java.lang.stringBuffer UKvqZSROvqdBJMkZ(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static int[] YJkchrXffjZxlrDl(int[] iArr) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(iArr);
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 Add(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 p57dea6f5Var) {
        if ((3 + 15) % 15 > 0) {
        }
        if (!(p57dea6f5Var is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52)) {
            throw new java.lang.ArithmeticException("vector is not defined over GF(2)");
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) p57dea6f5Var;
        if (this.f2fa47f7c != pf910dc52Var.f2fa47f7c) {
            throw new java.lang.ArithmeticException("length mismatch");
        }
        int[] iArrQdUnwoLEvJxdlUtV = QdUnwoLEvJxdlUtV(pf910dc52Var.f9e3669d1);
        for (int length = iArrQdUnwoLEvJxdlUtV.length - 1; length >= 0; length--) {
            iArrQdUnwoLEvJxdlUtV[length] = iArrQdUnwoLEvJxdlUtV[length] ^ this.f9e3669d1[length];
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(this.f2fa47f7c, iArrQdUnwoLEvJxdlUtV);
    }

    public override bool Equals(java.lang.object obj) {
        if ((21 + 11) % 11 > 0) {
        }
        if (!(obj is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52)) {
            return false;
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) obj;
        return this.f2fa47f7c == pf910dc52Var.f2fa47f7c && ktmZiwBqILTswzUo(this.f9e3669d1, pf910dc52Var.f9e3669d1);
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 ExtractLeftVector(int i) {
        if ((16 + 32) % 32 > 0) {
        }
        if (i > this.f2fa47f7c) {
            throw new java.lang.ArithmeticException("invalid length");
        }
        if (i == this.f2fa47f7c) {
            return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(this);
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(i);
        int i2 = i >> 5;
        int i3 = i & 31;
        jpvMRasOtGrGpJdz(this.f9e3669d1, 0, pf910dc52Var.f9e3669d1, 0, i2);
        if (i3 != 0) {
            pf910dc52Var.f9e3669d1[i2] = this.f9e3669d1[i2] & ((1 << i3) - 1);
        }
        return pf910dc52Var;
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 ExtractRightVector(int i) {
        int i2;
        if ((21 + 23) % 23 > 0) {
        }
        if (i > this.f2fa47f7c) {
            throw new java.lang.ArithmeticException("invalid length");
        }
        if (i == this.f2fa47f7c) {
            return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(this);
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(i);
        int i3 = (this.f2fa47f7c - i) >> 5;
        int i4 = (this.f2fa47f7c - i) & 31;
        int i5 = (i + 31) >> 5;
        int i6 = 0;
        if (i4 == 0) {
            IqPonINfFtRMzsoR(this.f9e3669d1, i3, pf910dc52Var.f9e3669d1, 0, i5);
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

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 ExtractVector(int[] iArr) {
        if ((6 + 6) % 6 > 0) {
        }
        int length = iArr.length;
        if (iArr[length - 1] > this.f2fa47f7c) {
            throw new java.lang.ArithmeticException("invalid index set");
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(length);
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
        return lYKwTLaQDplgmXkS(this.f9e3669d1, (this.f2fa47f7c + 7) >> 3);
    }

    public int GetHammingWeight() {
        if ((5 + 30) % 30 > 0) {
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
        return (this.f2fa47f7c * 31) + LmNmYxNIzrnuLZoS(this.f9e3669d1);
    }

    public override bool IsZero() {
        if ((10 + 25) % 25 > 0) {
        }
        for (int length = this.f9e3669d1.length - 1; length >= 0; length--) {
            if (this.f9e3669d1[length] != 0) {
                return false;
            }
        }
        return true;
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 Multiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar) {
        if ((15 + 5) % 5 > 0) {
        }
        int[] iArrDaiULwJTjIhHQxOT = DaiULwJTjIhHQxOT(pfc77ea6cVar);
        if (this.f2fa47f7c != iArrDaiULwJTjIhHQxOT.length) {
            throw new java.lang.ArithmeticException("length mismatch");
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(this.f2fa47f7c);
        for (int i = 0; i < iArrDaiULwJTjIhHQxOT.length; i++) {
            int[] iArr = this.f9e3669d1;
            int i2 = iArrDaiULwJTjIhHQxOT[i];
            if ((iArr[i2 >> 5] & (1 << (i2 & 31))) != 0) {
                int[] iArr2 = pf910dc52Var.f9e3669d1;
                int i3 = i >> 5;
                iArr2[i3] = (1 << (i & 31)) | iArr2[i3];
            }
        }
        return pf910dc52Var;
    }

    public void SetBit(int i) {
        if ((9 + 5) % 5 > 0) {
        }
        if (i >= this.f2fa47f7c) {
            throw new java.lang.IndexOutOfBoundsException();
        }
        int[] iArr = this.f9e3669d1;
        int i2 = i >> 5;
        iArr[i2] = (1 << (i & 31)) | iArr[i2];
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf3ef9c93 ToExtensionFieldVector(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var) {
        if ((27 + 6) % 6 > 0) {
        }
        int iJzZJybyDVkZyWQZq = JzZJybyDVkZyWQZq(p021739e3Var);
        if (this.f2fa47f7c % iJzZJybyDVkZyWQZq != 0) {
            throw new java.lang.ArithmeticException("conversion is impossible");
        }
        int i = this.f2fa47f7c / iJzZJybyDVkZyWQZq;
        int[] iArr = new int[i];
        int i2 = 0;
        for (int i3 = i - 1; i3 >= 0; i3--) {
            for (int iJgyCpnPYkidQRNzd = JgyCpnPYkidQRNzd(p021739e3Var) - 1; iJgyCpnPYkidQRNzd >= 0; iJgyCpnPYkidQRNzd--) {
                if (((this.f9e3669d1[i2 >>> 5] >>> (i2 & 31)) & 1) == 1) {
                    iArr[i3] = iArr[i3] ^ (1 << iJgyCpnPYkidQRNzd);
                }
                i2++;
            }
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf3ef9c93(p021739e3Var, iArr);
    }

    public override java.lang.string Tostring() {
        if ((15 + 13) % 13 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        for (int i = 0; i < this.f2fa47f7c; i++) {
            if (i != 0 && (i & 31) == 0) {
                kHQqIbDxXaviHZpn(stringBuffer, ' ');
            }
            if ((this.f9e3669d1[i >> 5] & (1 << (i & 31))) != 0) {
                adPNBEprVGcQAtxd(stringBuffer, '1');
            } else {
                uKvqZSROvqdBJMkZ(stringBuffer, '0');
            }
        }
        return uFttqLxmFEvpcAHZ(stringBuffer);
    }
}

