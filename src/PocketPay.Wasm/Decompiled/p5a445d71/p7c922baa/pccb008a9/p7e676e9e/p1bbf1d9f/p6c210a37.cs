namespace WillowMaze.Wasm.Decompiled;


public class p6c210a37 : p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 {
    private int[][] f21b72c0b;
    private int f2fa47f7c;
    private int[][] f459e8e22;
    private int[][] f5b763b3e;
    private int f637dd4c7;
    private int[][] fb36dd2e5;
    private int[][] fd188ecc8;

    public p6c210a37(int i, char c) {
        this(i, c, new java.security.SecureRandom());
    }

    public p6c210a37(int i, char c, java.security.SecureRandom secureRandom) {
        if (i <= 0) {
            throw new java.lang.ArithmeticException("Size of matrix is non-positive.");
        }
        if (c == 'I') {
            xAWbzraoblOiebLK(this, i);
            return;
        }
        if (c == 'L') {
            ZnCszBHpyDrkDbkY(this, i, secureRandom);
            return;
        }
        if (c == 'R') {
            OkLEtPGXHRYDmclJ(this, i, secureRandom);
        } else if (c == 'U') {
            EtnrgKisCYwirXap(this, i, secureRandom);
        } else {
            if (c != 'Z') {
                throw new java.lang.ArithmeticException("Unknown matrix type.");
            }
            XTaUjpPgbItApmKv(this, i, i);
        }
    }

    private p6c210a37(int i, int i2) {
        if (i2 <= 0 || i <= 0) {
            throw new java.lang.ArithmeticException("size of matrix is non-positive");
        }
        QCXsdIJrqHXgsern(this, i, i2);
    }

    public p6c210a37(int i, int[][] iArr) {
        if ((19 + 31) % 31 > 0) {
        }
        if (iArr[0].length != ((i + 31) >> 5)) {
            throw new java.lang.ArithmeticException("Int array does not match given number of columns.");
        }
        this.fd1944e2f = i;
        this.f998ea976 = iArr.length;
        this.f2fa47f7c = iArr[0].length;
        int i2 = i & 31;
        int i3 = i2 != 0 ? (1 << i2) - 1 : -1;
        for (int i4 = 0; i4 < this.f998ea976; i4++) {
            int[] iArr2 = iArr[i4];
            int i5 = this.f2fa47f7c - 1;
            iArr2[i5] = iArr2[i5] & i3;
        }
        this.f21b72c0b = iArr;
    }

    public p6c210a37(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var) {
        if ((31 + 2) % 2 > 0) {
        }
        this.fd1944e2f = aGKnEOcaISSitzSQ(p6c210a37Var);
        this.f998ea976 = lBrzbGdAMadMmtPl(p6c210a37Var);
        this.f2fa47f7c = p6c210a37Var.f2fa47f7c;
        this.f21b72c0b = new int[p6c210a37Var.f21b72c0b.length][];
        int i = 0;
        while (true) {
            int[][] iArr = this.f21b72c0b;
            if (i >= iArr.length) {
                return;
            }
            iArr[i] = OgHqiYfnUcbtywex(p6c210a37Var.f21b72c0b[i]);
            i++;
        }
    }

    public p6c210a37(byte[] bArr) {
        if ((5 + 17) % 17 > 0) {
        }
        if (bArr.length < 9) {
            throw new java.lang.ArithmeticException("given array is not an encoded matrix over GF(2)");
        }
        this.f998ea976 = bKmmnSyontvKiZwo(bArr, 0);
        this.fd1944e2f = IhYDiKUcWnhWtFZV(bArr, 4);
        int i = ((this.fd1944e2f + 7) >>> 3) * this.f998ea976;
        if (this.f998ea976 > 0) {
            int i2 = 8;
            if (i == bArr.length - 8) {
                this.f2fa47f7c = (this.fd1944e2f + 31) >>> 5;
                int i3 = this.f998ea976;
                int[] iArr = new int[2];
                iArr[1] = this.f2fa47f7c;
                iArr[0] = i3;
                this.f21b72c0b = (int[][]) UNVufvhzpwKtaBZT(java.lang.int.TYPE, iArr);
                int i4 = this.fd1944e2f >> 5;
                int i5 = this.fd1944e2f & 31;
                for (int i6 = 0; i6 < this.f998ea976; i6++) {
                    int i7 = 0;
                    while (i7 < i4) {
                        this.f21b72c0b[i6][i7] = LqaylJbAMinsEKrB(bArr, i2);
                        i7++;
                        i2 += 4;
                    }
                    int i8 = 0;
                    while (i8 < i5) {
                        int[] iArr2 = this.f21b72c0b[i6];
                        int i9 = i2 + 1;
                        iArr2[i4] = ((bArr[i2] & 255) << i8) ^ iArr2[i4];
                        i8 += 8;
                        i2 = i9;
                    }
                }
                return;
            }
        }
        throw new java.lang.ArithmeticException("given array is not an encoded matrix over GF(2)");
    }

    public static java.lang.stringBuffer ADucCuCojEgPiATh(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static java.lang.stringBuffer AiGsyBogyozolvgY(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static void AviCNkqNfaRXZIat(int i, byte[] bArr, int i2) {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.m18d5c391(i, bArr, i2);
    }

    public static java.lang.stringBuilder CxAFebDnGeyCvFno(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void EtnrgKisCYwirXap(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var, int i, java.security.SecureRandom secureRandom) {
        p6c210a37Var.mc4380aa6(i, secureRandom);
    }

    public static int[] EzdPBLnHJfxZzDOs(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar) {
        return pfc77ea6cVar.getVector();
    }

    public static int[] GZomQQwPlPHEdKQq(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var) {
        return pf910dc52Var.getVecArray();
    }

    public static int[] IIXpUFVZKygEapbO(int[] iArr) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(iArr);
    }

    public static int IhYDiKUcWnhWtFZV(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.m3ee29737(bArr, i);
    }

    public static int JnYepjgDKGMeAvKS(java.security.SecureRandom secureRandom) {
        return secureRandom.nextInt();
    }

    public static java.lang.object JtTaWpacyvTQfPHK(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static int KOpTqVruRCHnpwaQ(java.security.SecureRandom secureRandom) {
        return secureRandom.nextInt();
    }

    public static java.lang.object LAZCKFMQEyQDfNqU(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static java.lang.object LlYwesrAJNMjDsqO(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static int LqaylJbAMinsEKrB(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.m3ee29737(bArr, i);
    }

    public static java.lang.object NoJhSKKLGErBFgUC(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static java.lang.stringBuffer NsAKqjrhwrTxvYCm(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static int[] OgHqiYfnUcbtywex(int[] iArr) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(iArr);
    }

    public static void OkLEtPGXHRYDmclJ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var, int i, java.security.SecureRandom secureRandom) {
        p6c210a37Var.mb14b6096(i, secureRandom);
    }

    public static int[] OwYHkJIyRASGhpeo(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var) {
        return pf910dc52Var.getVecArray();
    }

    public static void PeouaZvNTumaFQou(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static bool PsefEFSHbpAuRoyS(int[] iArr, int[] iArr2) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.m51c3f596(iArr, iArr2);
    }

    public static void QCXsdIJrqHXgsern(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var, int i, int i2) {
        p6c210a37Var.mc448d418(i, i2);
    }

    public static java.lang.object RjRrzDMmKMWMsrpL(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static java.lang.object TioklPpGEBjLXVIM(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static java.lang.object UNVufvhzpwKtaBZT(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 UdpaxQgIYoXLrDmm(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar) {
        return p6c210a37Var.rightMultiply(pfc77ea6cVar);
    }

    public static void VwwduWmcjdDvGJEZ(int[][] iArr, int i, int i2) {
        m94b6e8ca(iArr, i, i2);
    }

    public static int[] XHEUxrIQwNmNjAoy(int[] iArr) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(iArr);
    }

    public static void XTaUjpPgbItApmKv(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var, int i, int i2) {
        p6c210a37Var.mc448d418(i, i2);
    }

    public static java.lang.object XyJdozGqKMwmwyor(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 YfaqwbrIHzbKZIvE(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 pf53df029Var) {
        return p6c210a37Var.rightMultiply(pf53df029Var);
    }

    public static void ZnCszBHpyDrkDbkY(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var, int i, java.security.SecureRandom secureRandom) {
        p6c210a37Var.m84e7e341(i, secureRandom);
    }

    public static java.lang.stringBuffer ACSGpiTeOGRAXUcg(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static int AGKnEOcaISSitzSQ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var) {
        return p6c210a37Var.getNumColumns();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 AUeegdQhwKddoRDI(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 pf53df029Var) {
        return p6c210a37Var.rightMultiply(pf53df029Var);
    }

    public static int BKmmnSyontvKiZwo(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.m3ee29737(bArr, i);
    }

    public static java.lang.string CXVBeUoVFFKjwWgo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuffer CZsOSSxZTEgDyPUC(java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return stringBuffer.append(str);
    }

    public static int[] CcGaeYNkSJWQJBxb(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar) {
        return pfc77ea6cVar.getVector();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 DpaoZJzzsLPMFPsO(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 pf53df029Var) {
        return p6c210a37Var.rightMultiply(pf53df029Var);
    }

    public static void EAbXrjrBrgTZltpb(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int[] ENhiLHadTvwYcFcB(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar) {
        return pfc77ea6cVar.getVector();
    }

    public static int[] FRNzoKDSvAGtlkSo(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var) {
        return pf910dc52Var.getVecArray();
    }

    public static java.lang.object GipBIzoCcBpTAQIU(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static void GunrBmIJBanfmMwn(int[] iArr, int[] iArr2, int i) {
        m75576136(iArr, iArr2, i);
    }

    public static int[] HSycbVXoSDTCTBvO(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar) {
        return pfc77ea6cVar.getVector();
    }

    public static java.lang.object JdXsEvfNeVeUzFgC(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static void KjcTPLonOXmQDSSV(int i, byte[] bArr, int i2) {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.m18d5c391(i, bArr, i2);
    }

    public static int LBrzbGdAMadMmtPl(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var) {
        return p6c210a37Var.getNumRows();
    }

    public static java.lang.string LHHMxYDMVayeogKk(java.lang.stringBuffer stringBuffer) {
        return stringBuffer.tostring();
    }

    public static int LUMrecSBeqqvqhHQ(java.security.SecureRandom secureRandom) {
        return secureRandom.nextInt();
    }

    private static void M75576136(int[] iArr, int[] iArr2, int i) {
        if ((12 + 22) % 22 > 0) {
        }
        for (int length = iArr2.length - 1; length >= i; length--) {
            iArr2[length] = iArr[length] ^ iArr2[length];
        }
    }

    private void M84e7e341(int i, java.security.SecureRandom secureRandom) {
        if ((16 + 9) % 9 > 0) {
        }
        this.f998ea976 = i;
        this.fd1944e2f = i;
        this.f2fa47f7c = (i + 31) >>> 5;
        int i2 = this.f998ea976;
        int[] iArr = new int[2];
        iArr[1] = this.f2fa47f7c;
        iArr[0] = i2;
        this.f21b72c0b = (int[][]) LlYwesrAJNMjDsqO(java.lang.int.TYPE, iArr);
        for (int i3 = 0; i3 < this.f998ea976; i3++) {
            int i4 = i3 >>> 5;
            int i5 = i3 & 31;
            int i6 = 31 - i5;
            int i7 = 1 << i5;
            for (int i8 = 0; i8 < i4; i8++) {
                this.f21b72c0b[i3][i8] = KOpTqVruRCHnpwaQ(secureRandom);
            }
            this.f21b72c0b[i3][i4] = i7 | (JnYepjgDKGMeAvKS(secureRandom) >>> i6);
            while (true) {
                i4++;
                if (i4 >= this.f2fa47f7c) {
                    break;
                } else {
                    this.f21b72c0b[i3][i4] = 0;
                }
            }
        }
    }

    private static void M94b6e8ca(int[][] iArr, int i, int i2) {
        if ((15 + 10) % 10 > 0) {
        }
        int[] iArr2 = iArr[i];
        iArr[i] = iArr[i2];
        iArr[i2] = iArr2;
    }

    public static void MGNtkUdipsOoNXTe(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    private void Mb14b6096(int i, java.security.SecureRandom secureRandom) {
        if ((2 + 11) % 11 > 0) {
        }
        this.f998ea976 = i;
        this.fd1944e2f = i;
        this.f2fa47f7c = (i + 31) >>> 5;
        int i2 = this.f998ea976;
        int[] iArr = new int[2];
        iArr[1] = this.f2fa47f7c;
        iArr[0] = i2;
        this.f21b72c0b = (int[][]) XyJdozGqKMwmwyor(java.lang.int.TYPE, iArr);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37) aUeegdQhwKddoRDI(new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(i, 'L', secureRandom), new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(i, 'U', secureRandom));
        int[] iArrHSycbVXoSDTCTBvO = hSycbVXoSDTCTBvO(new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c(i, secureRandom));
        for (int i3 = 0; i3 < i; i3++) {
            mGNtkUdipsOoNXTe(p6c210a37Var.f21b72c0b[i3], 0, this.f21b72c0b[iArrHSycbVXoSDTCTBvO[i3]], 0, this.f2fa47f7c);
        }
    }

    private void Mc4380aa6(int i, java.security.SecureRandom secureRandom) {
        int i2;
        if ((31 + 25) % 25 > 0) {
        }
        this.f998ea976 = i;
        this.fd1944e2f = i;
        this.f2fa47f7c = (i + 31) >>> 5;
        int i3 = this.f998ea976;
        int[] iArr = new int[2];
        iArr[1] = this.f2fa47f7c;
        iArr[0] = i3;
        this.f21b72c0b = (int[][]) LAZCKFMQEyQDfNqU(java.lang.int.TYPE, iArr);
        int i4 = i & 31;
        int i5 = i4 != 0 ? (1 << i4) - 1 : -1;
        for (int i6 = 0; i6 < this.f998ea976; i6++) {
            int i7 = i6 >>> 5;
            int i8 = i6 & 31;
            for (int i9 = 0; i9 < i7; i9++) {
                this.f21b72c0b[i6][i9] = 0;
            }
            this.f21b72c0b[i6][i7] = (lUMrecSBeqqvqhHQ(secureRandom) | 1) << i8;
            while (true) {
                i7++;
                i2 = this.f2fa47f7c;
                if (i7 >= i2) {
                    break;
                } else {
                    this.f21b72c0b[i6][i7] = qkyzWYuzyKtDoYKQ(secureRandom);
                }
            }
            int[] iArr2 = this.f21b72c0b[i6];
            int i10 = i2 - 1;
            iArr2[i10] = iArr2[i10] & i5;
        }
    }

    private void Mc448d418(int i, int i2) {
        if ((7 + 8) % 8 > 0) {
        }
        this.f998ea976 = i;
        this.fd1944e2f = i2;
        this.f2fa47f7c = (i2 + 31) >>> 5;
        int i3 = this.f998ea976;
        int[] iArr = new int[2];
        iArr[1] = this.f2fa47f7c;
        iArr[0] = i3;
        this.f21b72c0b = (int[][]) TioklPpGEBjLXVIM(java.lang.int.TYPE, iArr);
        for (int i4 = 0; i4 < this.f998ea976; i4++) {
            for (int i5 = 0; i5 < this.f2fa47f7c; i5++) {
                this.f21b72c0b[i4][i5] = 0;
            }
        }
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37[] Mee90883e(int i, java.security.SecureRandom secureRandom) {
        if ((10 + 10) % 10 > 0) {
        }
        int i2 = (i + 31) >> 5;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(i, 'L', secureRandom);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(i, 'U', secureRandom);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var3 = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37) dpaoZJzzsLPMFPsO(p6c210a37Var, p6c210a37Var2);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c(i, secureRandom);
        int[] iArrCcGaeYNkSJWQJBxb = ccGaeYNkSJWQJBxb(pfc77ea6cVar);
        int[] iArr = new int[2];
        int i3 = 1;
        iArr[1] = i2;
        iArr[0] = i;
        int[][] iArr2 = (int[][]) RjRrzDMmKMWMsrpL(java.lang.int.TYPE, iArr);
        for (int i4 = 0; i4 < i; i4++) {
            pLCGnMMcFVmPovvP(p6c210a37Var3.f21b72c0b[iArrCcGaeYNkSJWQJBxb[i4]], 0, iArr2[i4], 0, i2);
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var4 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(i, iArr2);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var5 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(i, 'I');
        int i5 = 0;
        while (i5 < i) {
            int i6 = i5 >>> 5;
            int i7 = i3 << (i5 & 31);
            int i8 = i5 + 1;
            int i9 = i8;
            while (i9 < i) {
                if ((p6c210a37Var.f21b72c0b[i9][i6] & i7) != 0) {
                    int i10 = 0;
                    while (i10 <= i6) {
                        int i11 = i3;
                        int[][] iArr3 = p6c210a37Var5.f21b72c0b;
                        int[] iArr4 = iArr3[i9];
                        iArr4[i10] = iArr4[i10] ^ iArr3[i5][i10];
                        i10++;
                        i3 = i11;
                    }
                }
                i9++;
                i3 = i3;
            }
            i5 = i8;
        }
        int i12 = i3;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var6 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(i, 'I');
        for (int i13 = i - 1; i13 >= 0; i13--) {
            int i14 = i13 >>> 5;
            int i15 = i12 << (i13 & 31);
            for (int i16 = i13 - 1; i16 >= 0; i16--) {
                if ((p6c210a37Var2.f21b72c0b[i16][i14] & i15) != 0) {
                    for (int i17 = i14; i17 < i2; i17++) {
                        int[][] iArr5 = p6c210a37Var6.f21b72c0b;
                        int[] iArr6 = iArr5[i16];
                        iArr6[i17] = iArr5[i13][i17] ^ iArr6[i17];
                    }
                }
            }
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37[]{p6c210a37Var4, (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37) YfaqwbrIHzbKZIvE(p6c210a37Var6, UdpaxQgIYoXLrDmm(p6c210a37Var5, pfc77ea6cVar))};
    }

    private void Mef148984(int i) {
        if ((3 + 14) % 14 > 0) {
        }
        this.f998ea976 = i;
        this.fd1944e2f = i;
        this.f2fa47f7c = (i + 31) >>> 5;
        int i2 = this.f998ea976;
        int[] iArr = new int[2];
        iArr[1] = this.f2fa47f7c;
        iArr[0] = i2;
        this.f21b72c0b = (int[][]) tskqDeZZwHTGiDvN(java.lang.int.TYPE, iArr);
        for (int i3 = 0; i3 < this.f998ea976; i3++) {
            for (int i4 = 0; i4 < this.f2fa47f7c; i4++) {
                this.f21b72c0b[i3][i4] = 0;
            }
        }
        for (int i5 = 0; i5 < this.f998ea976; i5++) {
            this.f21b72c0b[i5][i5 >>> 5] = 1 << (i5 & 31);
        }
    }

    public static java.lang.stringBuffer MmVGorrhiwGXnZHv(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static java.lang.stringBuffer NPQMrSeQZIrauIWN(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static java.lang.stringBuilder NaBxkpbrVvQcJbaK(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void PLCGnMMcFVmPovvP(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int[] PupNVnlchmZfDOzR(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var) {
        return pf910dc52Var.getVecArray();
    }

    public static void QUzPjACLvPcGXoar(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int QkyzWYuzyKtDoYKQ(java.security.SecureRandom secureRandom) {
        return secureRandom.nextInt();
    }

    public static java.lang.object TskqDeZZwHTGiDvN(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static void TvsTCnkJEifMImod(int[] iArr, int[] iArr2, int i) {
        m75576136(iArr, iArr2, i);
    }

    public static void UdJaDdwfGFEidfMG(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int UlkOBoLVbuUehclt(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void VQAcoKnqPJUgASIw(int[][] iArr, int i, int i2) {
        m94b6e8ca(iArr, i, i2);
    }

    public static void XAWbzraoblOiebLK(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var, int i) {
        p6c210a37Var.mef148984(i);
    }

    public static void XTTCwChuAQqpIRvI(int i, byte[] bArr, int i2) {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.m18d5c391(i, bArr, i2);
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 ComputeInverse() {
        if ((25 + 1) % 1 > 0) {
        }
        if (this.f998ea976 != this.fd1944e2f) {
            throw new java.lang.ArithmeticException("Matrix is not invertible.");
        }
        int i = this.f998ea976;
        int[] iArr = new int[2];
        iArr[1] = this.f2fa47f7c;
        iArr[0] = i;
        int[][] iArr2 = (int[][]) NoJhSKKLGErBFgUC(java.lang.int.TYPE, iArr);
        for (int i2 = this.f998ea976 - 1; i2 >= 0; i2--) {
            iArr2[i2] = IIXpUFVZKygEapbO(this.f21b72c0b[i2]);
        }
        int i3 = this.f998ea976;
        int[] iArr3 = new int[2];
        iArr3[1] = this.f2fa47f7c;
        iArr3[0] = i3;
        int[][] iArr4 = (int[][]) jdXsEvfNeVeUzFgC(java.lang.int.TYPE, iArr3);
        for (int i4 = this.f998ea976 - 1; i4 >= 0; i4--) {
            iArr4[i4][i4 >> 5] = 1 << (i4 & 31);
        }
        for (int i5 = 0; i5 < this.f998ea976; i5++) {
            int i6 = i5 >> 5;
            int i7 = 1 << (i5 & 31);
            if ((iArr2[i5][i6] & i7) == 0) {
                int i8 = i5 + 1;
                bool z = false;
                while (i8 < this.f998ea976) {
                    if ((iArr2[i8][i6] & i7) != 0) {
                        vQAcoKnqPJUgASIw(iArr2, i5, i8);
                        VwwduWmcjdDvGJEZ(iArr4, i5, i8);
                        i8 = this.f998ea976;
                        z = true;
                    }
                    i8++;
                }
                if (!z) {
                    throw new java.lang.ArithmeticException("Matrix is not invertible.");
                }
            }
            for (int i9 = this.f998ea976 - 1; i9 >= 0; i9--) {
                if (i9 != i5) {
                    int[] iArr5 = iArr2[i9];
                    if ((iArr5[i6] & i7) != 0) {
                        tvsTCnkJEifMImod(iArr2[i5], iArr5, i6);
                        gunrBmIJBanfmMwn(iArr4[i5], iArr4[i9], 0);
                    }
                }
            }
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(this.fd1944e2f, iArr4);
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 ComputeTranspose() {
        if ((24 + 18) % 18 > 0) {
        }
        int i = this.fd1944e2f;
        int[] iArr = new int[2];
        iArr[1] = (this.f998ea976 + 31) >>> 5;
        iArr[0] = i;
        int[][] iArr2 = (int[][]) JtTaWpacyvTQfPHK(java.lang.int.TYPE, iArr);
        for (int i2 = 0; i2 < this.f998ea976; i2++) {
            for (int i3 = 0; i3 < this.fd1944e2f; i3++) {
                int i4 = i2 >>> 5;
                int i5 = i2 & 31;
                if (((this.f21b72c0b[i2][i3 >>> 5] >>> (i3 & 31)) & 1) == 1) {
                    int[] iArr3 = iArr2[i3];
                    iArr3[i4] = (1 << i5) | iArr3[i4];
                }
            }
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(this.f998ea976, iArr2);
    }

    public bool Equals(java.lang.object obj) {
        if ((27 + 10) % 10 > 0) {
        }
        if (!(obj is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37)) {
            return false;
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37) obj;
        if (this.f998ea976 != p6c210a37Var.f998ea976 || this.fd1944e2f != p6c210a37Var.fd1944e2f || this.f2fa47f7c != p6c210a37Var.f2fa47f7c) {
            return false;
        }
        for (int i = 0; i < this.f998ea976; i++) {
            if (!PsefEFSHbpAuRoyS(this.f21b72c0b[i], p6c210a37Var.f21b72c0b[i])) {
                return false;
            }
        }
        return true;
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 ExtendLeftCompactForm() {
        if ((8 + 6) % 6 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(this.f998ea976, this.fd1944e2f + this.f998ea976);
        int i = (this.f998ea976 - 1) + this.fd1944e2f;
        int i2 = this.f998ea976 - 1;
        while (i2 >= 0) {
            qUzPjACLvPcGXoar(this.f21b72c0b[i2], 0, p6c210a37Var.f21b72c0b[i2], 0, this.f2fa47f7c);
            int[] iArr = p6c210a37Var.f21b72c0b[i2];
            int i3 = i >> 5;
            iArr[i3] = iArr[i3] | (1 << (i & 31));
            i2--;
            i--;
        }
        return p6c210a37Var;
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 ExtendRightCompactForm() {
        int i;
        if ((8 + 32) % 32 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(this.f998ea976, this.f998ea976 + this.fd1944e2f);
        int i2 = this.f998ea976 >> 5;
        int i3 = this.f998ea976 & 31;
        for (int i4 = this.f998ea976 - 1; i4 >= 0; i4--) {
            int[] iArr = p6c210a37Var.f21b72c0b[i4];
            int i5 = i4 >> 5;
            iArr[i5] = iArr[i5] | (1 << (i4 & 31));
            int i6 = 0;
            if (i3 == 0) {
                udJaDdwfGFEidfMG(this.f21b72c0b[i4], 0, iArr, i2, this.f2fa47f7c);
            } else {
                int i7 = i2;
                while (true) {
                    i = this.f2fa47f7c;
                    if (i6 >= i - 1) {
                        break;
                    }
                    int i8 = this.f21b72c0b[i4][i6];
                    int[] iArr2 = p6c210a37Var.f21b72c0b[i4];
                    int i9 = i7 + 1;
                    iArr2[i7] = iArr2[i7] | (i8 << i3);
                    iArr2[i9] = iArr2[i9] | (i8 >>> (32 - i3));
                    i6++;
                    i7 = i9;
                }
                int i10 = this.f21b72c0b[i4][i - 1];
                int[] iArr3 = p6c210a37Var.f21b72c0b[i4];
                int i11 = i7 + 1;
                iArr3[i7] = iArr3[i7] | (i10 << i3);
                if (i11 < p6c210a37Var.f2fa47f7c) {
                    iArr3[i11] = iArr3[i11] | (i10 >>> (32 - i3));
                }
            }
        }
        return p6c210a37Var;
    }

    public override byte[] GetEncoded() {
        if ((8 + 14) % 14 > 0) {
        }
        int i = 8;
        byte[] bArr = new byte[(((this.fd1944e2f + 7) >>> 3) * this.f998ea976) + 8];
        AviCNkqNfaRXZIat(this.f998ea976, bArr, 0);
        kjcTPLonOXmQDSSV(this.fd1944e2f, bArr, 4);
        int i2 = this.fd1944e2f >>> 5;
        int i3 = this.fd1944e2f & 31;
        for (int i4 = 0; i4 < this.f998ea976; i4++) {
            int i5 = 0;
            while (i5 < i2) {
                xTTCwChuAQqpIRvI(this.f21b72c0b[i4][i5], bArr, i);
                i5++;
                i += 4;
            }
            int i6 = 0;
            while (i6 < i3) {
                int i7 = i + 1;
                bArr[i] = (byte) ((this.f21b72c0b[i4][i2] >>> i6) & 255);
                i6 += 8;
                i = i7;
            }
        }
        return bArr;
    }

    public double GetHammingWeight() {
        if ((7 + 1) % 1 > 0) {
        }
        int i = this.fd1944e2f & 31;
        int i2 = i != 0 ? this.f2fa47f7c - 1 : this.f2fa47f7c;
        double d = 0.0d;
        double d2 = 0.0d;
        for (int i3 = 0; i3 < this.f998ea976; i3++) {
            for (int i4 = 0; i4 < i2; i4++) {
                int i5 = this.f21b72c0b[i3][i4];
                for (int i6 = 0; i6 < 32; i6++) {
                    d += (double) ((i5 >>> i6) & 1);
                    d2 += 1.0d;
                }
            }
            int i7 = this.f21b72c0b[i3][this.f2fa47f7c - 1];
            for (int i8 = 0; i8 < i; i8++) {
                d += (double) ((i7 >>> i8) & 1);
                d2 += 1.0d;
            }
        }
        return d / d2;
    }

    public int[][] GetIntArray() {
        return this.f21b72c0b;
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 GetLeftSubMatrix() {
        if ((28 + 32) % 32 > 0) {
        }
        if (this.fd1944e2f <= this.f998ea976) {
            throw new java.lang.ArithmeticException("empty submatrix");
        }
        int i = (this.f998ea976 + 31) >> 5;
        int i2 = this.f998ea976;
        int[] iArr = new int[2];
        iArr[1] = i;
        iArr[0] = i2;
        int[][] iArr2 = (int[][]) gipBIzoCcBpTAQIU(java.lang.int.TYPE, iArr);
        int i3 = (1 << (this.f998ea976 & 31)) - 1;
        if (i3 == 0) {
            i3 = -1;
        }
        for (int i4 = this.f998ea976 - 1; i4 >= 0; i4--) {
            PeouaZvNTumaFQou(this.f21b72c0b[i4], 0, iArr2[i4], 0, i);
            int[] iArr3 = iArr2[i4];
            int i5 = i - 1;
            iArr3[i5] = iArr3[i5] & i3;
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(this.f998ea976, iArr2);
    }

    public int GetLength() {
        return this.f2fa47f7c;
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 GetRightSubMatrix() {
        int i;
        if ((14 + 24) % 24 > 0) {
        }
        if (this.fd1944e2f <= this.f998ea976) {
            throw new java.lang.ArithmeticException("empty submatrix");
        }
        int i2 = this.f998ea976 >> 5;
        int i3 = this.f998ea976 & 31;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(this.f998ea976, this.fd1944e2f - this.f998ea976);
        for (int i4 = this.f998ea976 - 1; i4 >= 0; i4--) {
            int i5 = 0;
            if (i3 == 0) {
                eAbXrjrBrgTZltpb(this.f21b72c0b[i4], i2, p6c210a37Var.f21b72c0b[i4], 0, p6c210a37Var.f2fa47f7c);
            } else {
                int i6 = i2;
                while (true) {
                    i = p6c210a37Var.f2fa47f7c;
                    if (i5 >= i - 1) {
                        break;
                    }
                    int[] iArr = p6c210a37Var.f21b72c0b[i4];
                    int[] iArr2 = this.f21b72c0b[i4];
                    int i7 = i6 + 1;
                    iArr[i5] = (iArr2[i6] >>> i3) | (iArr2[i7] << (32 - i3));
                    i5++;
                    i6 = i7;
                }
                int[] iArr3 = p6c210a37Var.f21b72c0b[i4];
                int i8 = i - 1;
                int[] iArr4 = this.f21b72c0b[i4];
                int i9 = i6 + 1;
                iArr3[i8] = iArr4[i6] >>> i3;
                if (i9 < this.f2fa47f7c) {
                    int i10 = i - 1;
                    iArr3[i10] = iArr3[i10] | (iArr4[i9] << (32 - i3));
                }
            }
        }
        return p6c210a37Var;
    }

    public int[] GetRow(int i) {
        return this.f21b72c0b[i];
    }

    public int HashCode() {
        if ((19 + 6) % 6 > 0) {
        }
        int iUlkOBoLVbuUehclt = (((this.f998ea976 * 31) + this.fd1944e2f) * 31) + this.f2fa47f7c;
        for (int i = 0; i < this.f998ea976; i++) {
            iUlkOBoLVbuUehclt = (iUlkOBoLVbuUehclt * 31) + ulkOBoLVbuUehclt(this.f21b72c0b[i]);
        }
        return iUlkOBoLVbuUehclt;
    }

    public override bool IsZero() {
        if ((2 + 11) % 11 > 0) {
        }
        for (int i = 0; i < this.f998ea976; i++) {
            for (int i2 = 0; i2 < this.f2fa47f7c; i2++) {
                if (this.f21b72c0b[i][i2] != 0) {
                    return false;
                }
            }
        }
        return true;
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 LeftMultiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 p57dea6f5Var) {
        if ((32 + 3) % 3 > 0) {
        }
        if (!(p57dea6f5Var is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52)) {
            throw new java.lang.ArithmeticException("vector is not defined over GF(2)");
        }
        if (p57dea6f5Var.f2fa47f7c != this.f998ea976) {
            throw new java.lang.ArithmeticException("length mismatch");
        }
        int[] iArrPupNVnlchmZfDOzR = pupNVnlchmZfDOzR((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) p57dea6f5Var);
        int[] iArr = new int[this.f2fa47f7c];
        int i = this.f998ea976 >> 5;
        int i2 = 1 << (this.f998ea976 & 31);
        int i3 = 0;
        for (int i4 = 0; i4 < i; i4++) {
            int i5 = 1;
            do {
                if ((iArrPupNVnlchmZfDOzR[i4] & i5) != 0) {
                    for (int i6 = 0; i6 < this.f2fa47f7c; i6++) {
                        iArr[i6] = iArr[i6] ^ this.f21b72c0b[i3][i6];
                    }
                }
                i3++;
                i5 <<= 1;
            } while (i5 != 0);
        }
        for (int i7 = 1; i7 != i2; i7 <<= 1) {
            if ((iArrPupNVnlchmZfDOzR[i] & i7) != 0) {
                for (int i8 = 0; i8 < this.f2fa47f7c; i8++) {
                    iArr[i8] = iArr[i8] ^ this.f21b72c0b[i3][i8];
                }
            }
            i3++;
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(iArr, this.fd1944e2f);
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 LeftMultiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar) {
        if ((21 + 21) % 21 > 0) {
        }
        int[] iArrEzdPBLnHJfxZzDOs = EzdPBLnHJfxZzDOs(pfc77ea6cVar);
        if (iArrEzdPBLnHJfxZzDOs.length != this.f998ea976) {
            throw new java.lang.ArithmeticException("length mismatch");
        }
        int[][] iArr = new int[this.f998ea976][];
        for (int i = this.f998ea976 - 1; i >= 0; i--) {
            iArr[i] = XHEUxrIQwNmNjAoy(this.f21b72c0b[iArrEzdPBLnHJfxZzDOs[i]]);
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(this.f998ea976, iArr);
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 LeftMultiplyLeftCompactForm(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 p57dea6f5Var) {
        if ((9 + 20) % 20 > 0) {
        }
        if (!(p57dea6f5Var is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52)) {
            throw new java.lang.ArithmeticException("vector is not defined over GF(2)");
        }
        if (p57dea6f5Var.f2fa47f7c != this.f998ea976) {
            throw new java.lang.ArithmeticException("length mismatch");
        }
        int[] iArrOwYHkJIyRASGhpeo = OwYHkJIyRASGhpeo((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) p57dea6f5Var);
        int[] iArr = new int[((this.f998ea976 + this.fd1944e2f) + 31) >>> 5];
        int i = this.f998ea976 >>> 5;
        int i2 = 0;
        for (int i3 = 0; i3 < i; i3++) {
            int i4 = 1;
            do {
                if ((iArrOwYHkJIyRASGhpeo[i3] & i4) != 0) {
                    for (int i5 = 0; i5 < this.f2fa47f7c; i5++) {
                        iArr[i5] = iArr[i5] ^ this.f21b72c0b[i2][i5];
                    }
                    int i6 = (this.fd1944e2f + i2) >>> 5;
                    iArr[i6] = (1 << ((this.fd1944e2f + i2) & 31)) | iArr[i6];
                }
                i2++;
                i4 <<= 1;
            } while (i4 != 0);
        }
        int i7 = 1 << (this.f998ea976 & 31);
        for (int i8 = 1; i8 != i7; i8 <<= 1) {
            if ((iArrOwYHkJIyRASGhpeo[i] & i8) != 0) {
                for (int i9 = 0; i9 < this.f2fa47f7c; i9++) {
                    iArr[i9] = iArr[i9] ^ this.f21b72c0b[i2][i9];
                }
                int i10 = (this.fd1944e2f + i2) >>> 5;
                iArr[i10] = (1 << ((this.fd1944e2f + i2) & 31)) | iArr[i10];
            }
            i2++;
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(iArr, this.f998ea976 + this.fd1944e2f);
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 RightMultiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 p57dea6f5Var) {
        if ((28 + 1) % 1 > 0) {
        }
        if (!(p57dea6f5Var is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52)) {
            throw new java.lang.ArithmeticException("vector is not defined over GF(2)");
        }
        if (p57dea6f5Var.f2fa47f7c != this.fd1944e2f) {
            throw new java.lang.ArithmeticException("length mismatch");
        }
        int[] iArrGZomQQwPlPHEdKQq = GZomQQwPlPHEdKQq((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) p57dea6f5Var);
        int[] iArr = new int[(this.f998ea976 + 31) >>> 5];
        for (int i = 0; i < this.f998ea976; i++) {
            int i2 = 0;
            for (int i3 = 0; i3 < this.f2fa47f7c; i3++) {
                i2 ^= this.f21b72c0b[i][i3] & iArrGZomQQwPlPHEdKQq[i3];
            }
            int i4 = 0;
            for (int i5 = 0; i5 < 32; i5++) {
                i4 ^= (i2 >>> i5) & 1;
            }
            if (i4 == 1) {
                int i6 = i >>> 5;
                iArr[i6] = iArr[i6] | (1 << (i & 31));
            }
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(iArr, this.f998ea976);
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 RightMultiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 pf53df029Var) {
        if ((7 + 27) % 27 > 0) {
        }
        if (!(pf53df029Var is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37)) {
            throw new java.lang.ArithmeticException("matrix is not defined over GF(2)");
        }
        if (pf53df029Var.f998ea976 != this.fd1944e2f) {
            throw new java.lang.ArithmeticException("length mismatch");
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37) pf53df029Var;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(this.f998ea976, pf53df029Var.fd1944e2f);
        int i = this.fd1944e2f & 31;
        int i2 = i != 0 ? this.f2fa47f7c - 1 : this.f2fa47f7c;
        for (int i3 = 0; i3 < this.f998ea976; i3++) {
            int i4 = 0;
            for (int i5 = 0; i5 < i2; i5++) {
                int i6 = this.f21b72c0b[i3][i5];
                for (int i7 = 0; i7 < 32; i7++) {
                    if (((1 << i7) & i6) != 0) {
                        for (int i8 = 0; i8 < p6c210a37Var.f2fa47f7c; i8++) {
                            int[] iArr = p6c210a37Var2.f21b72c0b[i3];
                            iArr[i8] = iArr[i8] ^ p6c210a37Var.f21b72c0b[i4][i8];
                        }
                    }
                    i4++;
                }
            }
            int i9 = this.f21b72c0b[i3][this.f2fa47f7c - 1];
            for (int i10 = 0; i10 < i; i10++) {
                if (((1 << i10) & i9) != 0) {
                    for (int i11 = 0; i11 < p6c210a37Var.f2fa47f7c; i11++) {
                        int[] iArr2 = p6c210a37Var2.f21b72c0b[i3];
                        iArr2[i11] = iArr2[i11] ^ p6c210a37Var.f21b72c0b[i4][i11];
                    }
                }
                i4++;
            }
        }
        return p6c210a37Var2;
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 RightMultiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar) {
        if ((17 + 9) % 9 > 0) {
        }
        int[] iArrENhiLHadTvwYcFcB = eNhiLHadTvwYcFcB(pfc77ea6cVar);
        if (iArrENhiLHadTvwYcFcB.length != this.fd1944e2f) {
            throw new java.lang.ArithmeticException("length mismatch");
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(this.f998ea976, this.fd1944e2f);
        for (int i = this.fd1944e2f - 1; i >= 0; i--) {
            int i2 = i >>> 5;
            int i3 = i & 31;
            int i4 = iArrENhiLHadTvwYcFcB[i];
            int i5 = i4 >>> 5;
            int i6 = i4 & 31;
            for (int i7 = this.f998ea976 - 1; i7 >= 0; i7--) {
                int[] iArr = p6c210a37Var.f21b72c0b[i7];
                iArr[i2] = iArr[i2] | (((this.f21b72c0b[i7][i5] >>> i6) & 1) << i3);
            }
        }
        return p6c210a37Var;
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 RightMultiplyRightCompactForm(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 p57dea6f5Var) {
        int i;
        if ((10 + 22) % 22 > 0) {
        }
        if (!(p57dea6f5Var is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52)) {
            throw new java.lang.ArithmeticException("vector is not defined over GF(2)");
        }
        if (p57dea6f5Var.f2fa47f7c != this.fd1944e2f + this.f998ea976) {
            throw new java.lang.ArithmeticException("length mismatch");
        }
        int[] iArrFRNzoKDSvAGtlkSo = fRNzoKDSvAGtlkSo((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) p57dea6f5Var);
        int[] iArr = new int[(this.f998ea976 + 31) >>> 5];
        int i2 = this.f998ea976 >> 5;
        int i3 = this.f998ea976 & 31;
        for (int i4 = 0; i4 < this.f998ea976; i4++) {
            int i5 = i4 >> 5;
            int i6 = i4 & 31;
            int i7 = (iArrFRNzoKDSvAGtlkSo[i5] >>> i6) & 1;
            if (i3 == 0) {
                int i8 = i2;
                int i9 = 0;
                while (i9 < this.f2fa47f7c) {
                    int i10 = i8 + 1;
                    i7 ^= iArrFRNzoKDSvAGtlkSo[i8] & this.f21b72c0b[i4][i9];
                    i9++;
                    i8 = i10;
                }
            } else {
                int i11 = i2;
                int i12 = 0;
                while (true) {
                    i = this.f2fa47f7c;
                    if (i12 >= i - 1) {
                        break;
                    }
                    int i13 = i11 + 1;
                    i7 ^= ((iArrFRNzoKDSvAGtlkSo[i11] >>> i3) | (iArrFRNzoKDSvAGtlkSo[i13] << (32 - i3))) & this.f21b72c0b[i4][i12];
                    i12++;
                    i11 = i13;
                }
                int i14 = i11 + 1;
                int i15 = iArrFRNzoKDSvAGtlkSo[i11] >>> i3;
                if (i14 < iArrFRNzoKDSvAGtlkSo.length) {
                    i15 |= iArrFRNzoKDSvAGtlkSo[i14] << (32 - i3);
                }
                i7 ^= this.f21b72c0b[i4][i - 1] & i15;
            }
            int i16 = 0;
            for (int i17 = 0; i17 < 32; i17++) {
                i16 ^= i7 & 1;
                i7 >>>= 1;
            }
            if (i16 == 1) {
                iArr[i5] = iArr[i5] | (1 << i6);
            }
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(iArr, this.f998ea976);
    }

    public override java.lang.string Tostring() {
        if ((8 + 17) % 17 > 0) {
        }
        int i = this.fd1944e2f & 31;
        int i2 = i != 0 ? this.f2fa47f7c - 1 : this.f2fa47f7c;
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        for (int i3 = 0; i3 < this.f998ea976; i3++) {
            cZsOSSxZTEgDyPUC(stringBuffer, cXVBeUoVFFKjwWgo(CxAFebDnGeyCvFno(naBxkpbrVvQcJbaK(new java.lang.stringBuilder(), i3), ": ")));
            for (int i4 = 0; i4 < i2; i4++) {
                int i5 = this.f21b72c0b[i3][i4];
                for (int i6 = 0; i6 < 32; i6++) {
                    if (((i5 >>> i6) & 1) != 0) {
                        ADucCuCojEgPiATh(stringBuffer, '1');
                    } else {
                        nPQMrSeQZIrauIWN(stringBuffer, '0');
                    }
                }
                AiGsyBogyozolvgY(stringBuffer, ' ');
            }
            int i7 = this.f21b72c0b[i3][this.f2fa47f7c - 1];
            for (int i8 = 0; i8 < i; i8++) {
                if (((i7 >>> i8) & 1) != 0) {
                    aCSGpiTeOGRAXUcg(stringBuffer, '1');
                } else {
                    mmVGorrhiwGXnZHv(stringBuffer, '0');
                }
            }
            NsAKqjrhwrTxvYCm(stringBuffer, '\n');
        }
        return lHHMxYDMVayeogKk(stringBuffer);
    }
}

