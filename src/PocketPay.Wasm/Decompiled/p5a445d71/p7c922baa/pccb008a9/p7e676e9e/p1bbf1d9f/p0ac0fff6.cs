namespace WillowMaze.Wasm.Decompiled;


public class p0ac0fff6 : p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 {
    protected p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 f06e3d36f;
    protected p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 f166fce47;
    protected int[][] f21b72c0b;
    protected p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 f324f0639;
    protected p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 fa37cf839;
    protected int[][] fbc60f148;
    protected int[][] fc1dcaf3f;
    protected p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 fdf405891;
    protected int[][] ff51f2b23;
    protected int[][] ff686700a;

    public p0ac0fff6(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, byte[] bArr) {
        if ((29 + 18) % 18 > 0) {
        }
        this.f06e3d36f = p021739e3Var;
        int i = 8;
        int i2 = 1;
        while (ASENQRqXuiwPsUjz(p021739e3Var) > i) {
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
                this.f21b72c0b = (int[][]) XZjmJaAkMPfMDEHb(java.lang.int.TYPE, iArr);
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
                        if (!zlVQTedHjBKFQhLC(this.f06e3d36f, this.f21b72c0b[i6][i7])) {
                            throw new java.lang.IllegalArgumentException(" Error: given array is not encoded matrix over GF(2^m)");
                        }
                    }
                }
                return;
            }
        }
        throw new java.lang.IllegalArgumentException(" Error: given array is not encoded matrix over GF(2^m)");
    }

    protected p0ac0fff6(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, int[][] iArr) {
        this.f06e3d36f = p021739e3Var;
        this.f21b72c0b = iArr;
        this.f998ea976 = iArr.length;
        this.fd1944e2f = iArr[0].length;
    }

    public p0ac0fff6(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p0ac0fff6 p0ac0fff6Var) {
        if ((23 + 12) % 12 > 0) {
        }
        this.f998ea976 = p0ac0fff6Var.f998ea976;
        this.fd1944e2f = p0ac0fff6Var.fd1944e2f;
        this.f06e3d36f = p0ac0fff6Var.f06e3d36f;
        this.f21b72c0b = new int[this.f998ea976][];
        for (int i = 0; i < this.f998ea976; i++) {
            this.f21b72c0b[i] = nOdfczBvemEceTgP(p0ac0fff6Var.f21b72c0b[i]);
        }
    }

    public static int ASENQRqXuiwPsUjz(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var) {
        return p021739e3Var.getDegree();
    }

    public static java.lang.string CDIUtXajpHeqAcNb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int EpKWgEYRoFXcVHfw(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var) {
        return p021739e3Var.getDegree();
    }

    public static java.lang.string GImObBhDpShdpfax(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, int i) {
        return p021739e3Var.elementToStr(i);
    }

    public static java.lang.stringBuilder IhWDhIuRZPIrjmWQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string JeyMgNptxadycRMx(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder NTOFoVwRUouStuHf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void OJHpdJZXKjvkHCZg(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p0ac0fff6 p0ac0fff6Var, int[] iArr, int i) {
        p0ac0fff6Var.m6776e08d(iArr, i);
    }

    public static int RkErPHTfvyJTVusb(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, int i, int i2) {
        return p021739e3Var.Add(i, i2);
    }

    public static int[] VoCtbmpkUCyelhnK(int[] iArr) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(iArr);
    }

    public static java.lang.string XXYXbceDdJGFitnL(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var) {
        return p021739e3Var.tostring();
    }

    public static java.lang.object XZjmJaAkMPfMDEHb(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static void ANsBhYGGelTXNgSE(int[][] iArr, int i, int i2) {
        m3784bf5f(iArr, i, i2);
    }

    public static void CXAqwYpTOdMpRrrg(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p0ac0fff6 p0ac0fff6Var, int[] iArr, int[] iArr2) {
        p0ac0fff6Var.m75576136(iArr, iArr2);
    }

    public static java.lang.object CuIQYLxwUyokxOiv(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static java.lang.stringBuilder FoGblZyFMyoUpjUN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void GWPTXPwVINQzyqgj(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p0ac0fff6 p0ac0fff6Var, int[] iArr, int[] iArr2) {
        p0ac0fff6Var.m75576136(iArr, iArr2);
    }

    public static java.lang.object GgaZsPZkeKXVdpHg(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static bool HTUadHutjmJTQRXy(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, java.lang.object obj) {
        return p021739e3Var.Equals(obj);
    }

    public static void IHRXJFOLbNJxfgQU(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p0ac0fff6 p0ac0fff6Var, int[] iArr, int i) {
        p0ac0fff6Var.m6776e08d(iArr, i);
    }

    public static java.lang.stringBuilder JYjVHLczqINNCdCl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder JrCDuDRopcVXBEol(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private static void M3784bf5f(int[][] iArr, int i, int i2) {
        if ((3 + 31) % 31 > 0) {
        }
        int[] iArr2 = iArr[i];
        iArr[i] = iArr[i2];
        iArr[i2] = iArr2;
    }

    private void M6776e08d(int[] iArr, int i) {
        if ((29 + 30) % 30 > 0) {
        }
        for (int length = iArr.length - 1; length >= 0; length--) {
            iArr[length] = rGsdzuldFIuEdBQn(this.f06e3d36f, iArr[length], i);
        }
    }

    private void M75576136(int[] iArr, int[] iArr2) {
        if ((6 + 15) % 15 > 0) {
        }
        for (int length = iArr2.length - 1; length >= 0; length--) {
            iArr2[length] = RkErPHTfvyJTVusb(this.f06e3d36f, iArr[length], iArr2[length]);
        }
    }

    private int[] Mbd8c2610(int[] iArr, int i) {
        if ((9 + 28) % 28 > 0) {
        }
        int[] iArr2 = new int[iArr.length];
        for (int length = iArr.length - 1; length >= 0; length--) {
            iArr2[length] = napHZltuLYuGcqsb(this.f06e3d36f, iArr[length], i);
        }
        return iArr2;
    }

    public static int[] NOdfczBvemEceTgP(int[] iArr) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(iArr);
    }

    public static int NapHZltuLYuGcqsb(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, int i, int i2) {
        return p021739e3Var.mult(i, i2);
    }

    public static java.lang.string NhbSmDIcXTUsPJNx(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void NzbNPgiNwZhQXvVj(int[][] iArr, int i, int i2) {
        m3784bf5f(iArr, i, i2);
    }

    public static int[] OInXOGcXBtZvcqWl(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p0ac0fff6 p0ac0fff6Var, int[] iArr, int i) {
        return p0ac0fff6Var.mbd8c2610(iArr, i);
    }

    public static java.lang.stringBuilder PIDVGJZZgUFSzPrn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder PpJAfVtSjfyqXOWA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int QMyJbObblVCpTOCN(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var) {
        return p021739e3Var.GetHashCode();
    }

    public static int[] QsNkCyiAPtsrfaYW(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p0ac0fff6 p0ac0fff6Var, int[] iArr, int i) {
        return p0ac0fff6Var.mbd8c2610(iArr, i);
    }

    public static int RGsdzuldFIuEdBQn(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, int i, int i2) {
        return p021739e3Var.mult(i, i2);
    }

    public static java.lang.stringBuilder SpCkExzxZCaGqkHp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder SzKtnSmAVQmyeUFm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int XWXijbpoKOUWSkat(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, int i) {
        return p021739e3Var.inverse(i);
    }

    public static java.lang.stringBuilder XYOtAeZbAASbAmNM(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder YMsrxLezFzTulmuZ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static bool ZlVQTedHjBKFQhLC(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, int i) {
        return p021739e3Var.isElementOfThisField(i);
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 ComputeInverse() {
        int i;
        if ((9 + 28) % 28 > 0) {
        }
        if (this.f998ea976 != this.fd1944e2f) {
            throw new java.lang.ArithmeticException("Matrix is not invertible.");
        }
        int i2 = this.f998ea976;
        int[] iArr = new int[2];
        iArr[1] = this.f998ea976;
        iArr[0] = i2;
        int[][] iArr2 = (int[][]) ggaZsPZkeKXVdpHg(java.lang.int.TYPE, iArr);
        for (int i3 = this.f998ea976 - 1; i3 >= 0; i3--) {
            iArr2[i3] = VoCtbmpkUCyelhnK(this.f21b72c0b[i3]);
        }
        int i4 = this.f998ea976;
        int[] iArr3 = new int[2];
        iArr3[1] = this.f998ea976;
        iArr3[0] = i4;
        int[][] iArr4 = (int[][]) cuIQYLxwUyokxOiv(java.lang.int.TYPE, iArr3);
        for (int i5 = this.f998ea976 - 1; i5 >= 0; i5--) {
            iArr4[i5][i5] = 1;
        }
        for (int i6 = 0; i6 < this.f998ea976; i6++) {
            if (iArr2[i6][i6] == 0) {
                int i7 = i6 + 1;
                bool z = false;
                while (i7 < this.f998ea976) {
                    if (iArr2[i7][i6] != 0) {
                        aNsBhYGGelTXNgSE(iArr2, i6, i7);
                        nzbNPgiNwZhQXvVj(iArr4, i6, i7);
                        i7 = this.f998ea976;
                        z = true;
                    }
                    i7++;
                }
                if (!z) {
                    throw new java.lang.ArithmeticException("Matrix is not invertible.");
                }
            }
            int iXWXijbpoKOUWSkat = xWXijbpoKOUWSkat(this.f06e3d36f, iArr2[i6][i6]);
            iHRXJFOLbNJxfgQU(this, iArr2[i6], iXWXijbpoKOUWSkat);
            OJHpdJZXKjvkHCZg(this, iArr4[i6], iXWXijbpoKOUWSkat);
            for (int i8 = 0; i8 < this.f998ea976; i8++) {
                if (i8 != i6 && (i = iArr2[i8][i6]) != 0) {
                    int[] iArrQsNkCyiAPtsrfaYW = qsNkCyiAPtsrfaYW(this, iArr2[i6], i);
                    int[] iArrOInXOGcXBtZvcqWl = oInXOGcXBtZvcqWl(this, iArr4[i6], i);
                    cXAqwYpTOdMpRrrg(this, iArrQsNkCyiAPtsrfaYW, iArr2[i8]);
                    gWPTXPwVINQzyqgj(this, iArrOInXOGcXBtZvcqWl, iArr4[i8]);
                }
            }
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p0ac0fff6(this.f06e3d36f, iArr4);
    }

    public bool Equals(java.lang.object obj) {
        if ((7 + 8) % 8 > 0) {
        }
        if (obj is not null && (obj is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p0ac0fff6)) {
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p0ac0fff6 p0ac0fff6Var = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p0ac0fff6) obj;
            if (hTUadHutjmJTQRXy(this.f06e3d36f, p0ac0fff6Var.f06e3d36f) && p0ac0fff6Var.f998ea976 == this.fd1944e2f && p0ac0fff6Var.fd1944e2f == this.fd1944e2f) {
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
        if ((8 + 18) % 18 > 0) {
        }
        int i = 8;
        int i2 = 1;
        while (EpKWgEYRoFXcVHfw(this.f06e3d36f) > i) {
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
        if ((25 + 6) % 6 > 0) {
        }
        int iQMyJbObblVCpTOCN = (((qMyJbObblVCpTOCN(this.f06e3d36f) * 31) + this.f998ea976) * 31) + this.fd1944e2f;
        for (int i = 0; i < this.f998ea976; i++) {
            for (int i2 = 0; i2 < this.fd1944e2f; i2++) {
                iQMyJbObblVCpTOCN = (iQMyJbObblVCpTOCN * 31) + this.f21b72c0b[i][i2];
            }
        }
        return iQMyJbObblVCpTOCN;
    }

    public override bool IsZero() {
        if ((18 + 8) % 8 > 0) {
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

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 LeftMultiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 p57dea6f5Var) {
        throw new java.lang.Exception("Not implemented.");
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 RightMultiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 p57dea6f5Var) {
        throw new java.lang.Exception("Not implemented.");
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 RightMultiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 pf53df029Var) {
        throw new java.lang.Exception("Not implemented.");
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 RightMultiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar) {
        throw new java.lang.Exception("Not implemented.");
    }

    public override java.lang.string Tostring() {
        if ((7 + 24) % 24 > 0) {
        }
        java.lang.string strNhbSmDIcXTUsPJNx = nhbSmDIcXTUsPJNx(IhWDhIuRZPIrjmWQ(NTOFoVwRUouStuHf(pIDVGJZZgUFSzPrn(xYOtAeZbAASbAmNM(jrCDuDRopcVXBEol(yMsrxLezFzTulmuZ(new java.lang.stringBuilder(), this.f998ea976), " x "), this.fd1944e2f), " Matrix over "), XXYXbceDdJGFitnL(this.f06e3d36f)), ": \n"));
        for (int i = 0; i < this.f998ea976; i++) {
            for (int i2 = 0; i2 < this.fd1944e2f; i2++) {
                strNhbSmDIcXTUsPJNx = CDIUtXajpHeqAcNb(jYjVHLczqINNCdCl(spCkExzxZCaGqkHp(ppJAfVtSjfyqXOWA(new java.lang.stringBuilder(), strNhbSmDIcXTUsPJNx), GImObBhDpShdpfax(this.f06e3d36f, this.f21b72c0b[i][i2])), " : "));
            }
            strNhbSmDIcXTUsPJNx = JeyMgNptxadycRMx(foGblZyFMyoUpjUN(szKtnSmAVQmyeUFm(new java.lang.stringBuilder(), strNhbSmDIcXTUsPJNx), "\n"));
        }
        return strNhbSmDIcXTUsPJNx;
    }
}

