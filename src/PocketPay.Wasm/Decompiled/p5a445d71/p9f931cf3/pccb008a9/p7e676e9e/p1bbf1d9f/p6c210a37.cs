namespace WillowMaze.Wasm.Decompiled;


public class p6c210a37 : p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 {
    private int f0698e8c6;
    private int[][] f21b72c0b;
    private int f2fa47f7c;
    private int f3627344d;
    private int fb23385e0;
    private int[][] fc2335f28;

    public p6c210a37(int i, char c) {
        this(i, c, new java.security.SecureRandom());
    }

    public p6c210a37(int i, char c, java.security.SecureRandom secureRandom) {
        if (i <= 0) {
            throw new java.lang.ArithmeticException("Size of matrix is non-positive.");
        }
        if (c == 'I') {
            mef148984(i);
            return;
        }
        if (c == 'L') {
            m84e7e341(i, secureRandom);
            return;
        }
        if (c == 'R') {
            mb14b6096(i, secureRandom);
        } else if (c == 'U') {
            mc4380aa6(i, secureRandom);
        } else {
            if (c != 'Z') {
                throw new java.lang.ArithmeticException("Unknown matrix type.");
            }
            mc448d418(i, i);
        }
    }

    private p6c210a37(int i, int i2) {
        if (i2 <= 0 || i <= 0) {
            throw new java.lang.ArithmeticException("size of matrix is non-positive");
        }
        mc448d418(i, i2);
    }

    public p6c210a37(int i, int[][] iArr) {
        if ((28 + 7) % 7 > 0) {
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

    public p6c210a37(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var) {
        if ((25 + 17) % 17 > 0) {
        }
        this.fd1944e2f = p6c210a37Var.getNumColumns();
        this.f998ea976 = p6c210a37Var.getNumRows();
        this.f2fa47f7c = p6c210a37Var.f2fa47f7c;
        this.f21b72c0b = new int[p6c210a37Var.f21b72c0b.length][];
        int i = 0;
        while (true) {
            int[][] iArr = this.f21b72c0b;
            if (i >= iArr.length) {
                return;
            }
            iArr[i] = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(p6c210a37Var.f21b72c0b[i]);
            i++;
        }
    }

    public p6c210a37(byte[] bArr) {
        if ((16 + 1) % 1 > 0) {
        }
        if (bArr.length < 9) {
            throw new java.lang.ArithmeticException("given array is not an encoded matrix over GF(2)");
        }
        this.f998ea976 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.m3ee29737(bArr, 0);
        this.fd1944e2f = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.m3ee29737(bArr, 4);
        int i = ((this.fd1944e2f + 7) >>> 3) * this.f998ea976;
        if (this.f998ea976 > 0) {
            int i2 = 8;
            if (i == bArr.length - 8) {
                this.f2fa47f7c = (this.fd1944e2f + 31) >>> 5;
                int i3 = this.f998ea976;
                int[] iArr = new int[2];
                iArr[1] = this.f2fa47f7c;
                iArr[0] = i3;
                this.f21b72c0b = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr);
                int i4 = this.fd1944e2f >> 5;
                int i5 = this.fd1944e2f & 31;
                for (int i6 = 0; i6 < this.f998ea976; i6++) {
                    int i7 = 0;
                    while (i7 < i4) {
                        this.f21b72c0b[i6][i7] = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.m3ee29737(bArr, i2);
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

    private static void M75576136(int[] iArr, int[] iArr2, int i) {
        if ((30 + 22) % 22 > 0) {
        }
        for (int length = iArr2.length - 1; length >= i; length--) {
            iArr2[length] = iArr[length] ^ iArr2[length];
        }
    }

    private void M84e7e341(int i, java.security.SecureRandom secureRandom) {
        if ((4 + 3) % 3 > 0) {
        }
        this.f998ea976 = i;
        this.fd1944e2f = i;
        this.f2fa47f7c = (i + 31) >>> 5;
        int i2 = this.f998ea976;
        int[] iArr = new int[2];
        iArr[1] = this.f2fa47f7c;
        iArr[0] = i2;
        this.f21b72c0b = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr);
        for (int i3 = 0; i3 < this.f998ea976; i3++) {
            int i4 = i3 >>> 5;
            int i5 = i3 & 31;
            int i6 = 31 - i5;
            int i7 = 1 << i5;
            for (int i8 = 0; i8 < i4; i8++) {
                this.f21b72c0b[i3][i8] = secureRandom.nextInt();
            }
            this.f21b72c0b[i3][i4] = i7 | (secureRandom.nextInt() >>> i6);
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
        if ((25 + 32) % 32 > 0) {
        }
        int[] iArr2 = iArr[i];
        iArr[i] = iArr[i2];
        iArr[i2] = iArr2;
    }

    private void Mb14b6096(int i, java.security.SecureRandom secureRandom) {
        if ((28 + 17) % 17 > 0) {
        }
        this.f998ea976 = i;
        this.fd1944e2f = i;
        this.f2fa47f7c = (i + 31) >>> 5;
        int i2 = this.f998ea976;
        int[] iArr = new int[2];
        iArr[1] = this.f2fa47f7c;
        iArr[0] = i2;
        this.f21b72c0b = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37) new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(i, 'L', secureRandom).rightMultiply(new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(i, 'U', secureRandom));
        int[] vector = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c(i, secureRandom).getVector();
        for (int i3 = 0; i3 < i; i3++) {
            java.lang.System.arraycopy(p6c210a37Var.f21b72c0b[i3], 0, this.f21b72c0b[vector[i3]], 0, this.f2fa47f7c);
        }
    }

    private void Mc4380aa6(int i, java.security.SecureRandom secureRandom) {
        int i2;
        if ((29 + 8) % 8 > 0) {
        }
        this.f998ea976 = i;
        this.fd1944e2f = i;
        this.f2fa47f7c = (i + 31) >>> 5;
        int i3 = this.f998ea976;
        int[] iArr = new int[2];
        iArr[1] = this.f2fa47f7c;
        iArr[0] = i3;
        this.f21b72c0b = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr);
        int i4 = i & 31;
        int i5 = i4 != 0 ? (1 << i4) - 1 : -1;
        for (int i6 = 0; i6 < this.f998ea976; i6++) {
            int i7 = i6 >>> 5;
            int i8 = i6 & 31;
            for (int i9 = 0; i9 < i7; i9++) {
                this.f21b72c0b[i6][i9] = 0;
            }
            this.f21b72c0b[i6][i7] = (secureRandom.nextInt() | 1) << i8;
            while (true) {
                i7++;
                i2 = this.f2fa47f7c;
                if (i7 >= i2) {
                    break;
                } else {
                    this.f21b72c0b[i6][i7] = secureRandom.nextInt();
                }
            }
            int[] iArr2 = this.f21b72c0b[i6];
            int i10 = i2 - 1;
            iArr2[i10] = iArr2[i10] & i5;
        }
    }

    private void Mc448d418(int i, int i2) {
        if ((20 + 6) % 6 > 0) {
        }
        this.f998ea976 = i;
        this.fd1944e2f = i2;
        this.f2fa47f7c = (i2 + 31) >>> 5;
        int i3 = this.f998ea976;
        int[] iArr = new int[2];
        iArr[1] = this.f2fa47f7c;
        iArr[0] = i3;
        this.f21b72c0b = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr);
        for (int i4 = 0; i4 < this.f998ea976; i4++) {
            for (int i5 = 0; i5 < this.f2fa47f7c; i5++) {
                this.f21b72c0b[i4][i5] = 0;
            }
        }
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37[] Mee90883e(int i, java.security.SecureRandom secureRandom) {
        if ((11 + 21) % 21 > 0) {
        }
        int i2 = (i + 31) >> 5;
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(i, 'L', secureRandom);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(i, 'U', secureRandom);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var3 = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37) p6c210a37Var.rightMultiply(p6c210a37Var2);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c(i, secureRandom);
        int[] vector = pfc77ea6cVar.getVector();
        int[] iArr = new int[2];
        int i3 = 1;
        iArr[1] = i2;
        iArr[0] = i;
        int[][] iArr2 = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr);
        for (int i4 = 0; i4 < i; i4++) {
            java.lang.System.arraycopy(p6c210a37Var3.f21b72c0b[vector[i4]], 0, iArr2[i4], 0, i2);
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var4 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(i, iArr2);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var5 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(i, 'I');
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
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var6 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(i, 'I');
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
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37[]{p6c210a37Var4, (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37) p6c210a37Var6.rightMultiply(p6c210a37Var5.rightMultiply(pfc77ea6cVar))};
    }

    private void Mef148984(int i) {
        if ((2 + 14) % 14 > 0) {
        }
        this.f998ea976 = i;
        this.fd1944e2f = i;
        this.f2fa47f7c = (i + 31) >>> 5;
        int i2 = this.f998ea976;
        int[] iArr = new int[2];
        iArr[1] = this.f2fa47f7c;
        iArr[0] = i2;
        this.f21b72c0b = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr);
        for (int i3 = 0; i3 < this.f998ea976; i3++) {
            for (int i4 = 0; i4 < this.f2fa47f7c; i4++) {
                this.f21b72c0b[i3][i4] = 0;
            }
        }
        for (int i5 = 0; i5 < this.f998ea976; i5++) {
            this.f21b72c0b[i5][i5 >>> 5] = 1 << (i5 & 31);
        }
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 ComputeInverse() {
        if ((7 + 26) % 26 > 0) {
        }
        if (this.f998ea976 != this.fd1944e2f) {
            throw new java.lang.ArithmeticException("Matrix is not invertible.");
        }
        int i = this.f998ea976;
        int[] iArr = new int[2];
        iArr[1] = this.f2fa47f7c;
        iArr[0] = i;
        int[][] iArr2 = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr);
        for (int i2 = this.f998ea976 - 1; i2 >= 0; i2--) {
            iArr2[i2] = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(this.f21b72c0b[i2]);
        }
        int i3 = this.f998ea976;
        int[] iArr3 = new int[2];
        iArr3[1] = this.f2fa47f7c;
        iArr3[0] = i3;
        int[][] iArr4 = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr3);
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
                        m94b6e8ca(iArr2, i5, i8);
                        m94b6e8ca(iArr4, i5, i8);
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
                        m75576136(iArr2[i5], iArr5, i6);
                        m75576136(iArr4[i5], iArr4[i9], 0);
                    }
                }
            }
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(this.fd1944e2f, iArr4);
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 ComputeTranspose() {
        if ((17 + 31) % 31 > 0) {
        }
        int i = this.fd1944e2f;
        int[] iArr = new int[2];
        iArr[1] = (this.f998ea976 + 31) >>> 5;
        iArr[0] = i;
        int[][] iArr2 = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr);
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
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(this.f998ea976, iArr2);
    }

    public bool Equals(java.lang.object obj) {
        if ((6 + 20) % 20 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37)) {
            return false;
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37) obj;
        if (this.f998ea976 != p6c210a37Var.f998ea976 || this.fd1944e2f != p6c210a37Var.fd1944e2f || this.f2fa47f7c != p6c210a37Var.f2fa47f7c) {
            return false;
        }
        for (int i = 0; i < this.f998ea976; i++) {
            if (!p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.m51c3f596(this.f21b72c0b[i], p6c210a37Var.f21b72c0b[i])) {
                return false;
            }
        }
        return true;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 ExtendLeftCompactForm() {
        if ((21 + 18) % 18 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(this.f998ea976, this.fd1944e2f + this.f998ea976);
        int i = (this.f998ea976 - 1) + this.fd1944e2f;
        int i2 = this.f998ea976 - 1;
        while (i2 >= 0) {
            java.lang.System.arraycopy(this.f21b72c0b[i2], 0, p6c210a37Var.f21b72c0b[i2], 0, this.f2fa47f7c);
            int[] iArr = p6c210a37Var.f21b72c0b[i2];
            int i3 = i >> 5;
            iArr[i3] = iArr[i3] | (1 << (i & 31));
            i2--;
            i--;
        }
        return p6c210a37Var;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 ExtendRightCompactForm() {
        int i;
        if ((29 + 17) % 17 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(this.f998ea976, this.f998ea976 + this.fd1944e2f);
        int i2 = this.f998ea976 >> 5;
        int i3 = this.f998ea976 & 31;
        for (int i4 = this.f998ea976 - 1; i4 >= 0; i4--) {
            int[] iArr = p6c210a37Var.f21b72c0b[i4];
            int i5 = i4 >> 5;
            iArr[i5] = iArr[i5] | (1 << (i4 & 31));
            int i6 = 0;
            if (i3 == 0) {
                java.lang.System.arraycopy(this.f21b72c0b[i4], 0, iArr, i2, this.f2fa47f7c);
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
        if ((22 + 12) % 12 > 0) {
        }
        int i = 8;
        byte[] bArr = new byte[(((this.fd1944e2f + 7) >>> 3) * this.f998ea976) + 8];
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.m18d5c391(this.f998ea976, bArr, 0);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.m18d5c391(this.fd1944e2f, bArr, 4);
        int i2 = this.fd1944e2f >>> 5;
        int i3 = this.fd1944e2f & 31;
        for (int i4 = 0; i4 < this.f998ea976; i4++) {
            int i5 = 0;
            while (i5 < i2) {
                p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p63b37406.m18d5c391(this.f21b72c0b[i4][i5], bArr, i);
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
        if ((16 + 31) % 31 > 0) {
        }
        int i = this.fd1944e2f & 31;
        int i2 = this.f2fa47f7c;
        if (i != 0) {
            i2--;
        }
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

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 GetLeftSubMatrix() {
        if ((31 + 29) % 29 > 0) {
        }
        if (this.fd1944e2f <= this.f998ea976) {
            throw new java.lang.ArithmeticException("empty submatrix");
        }
        int i = (this.f998ea976 + 31) >> 5;
        int i2 = this.f998ea976;
        int[] iArr = new int[2];
        iArr[1] = i;
        iArr[0] = i2;
        int[][] iArr2 = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr);
        int i3 = (1 << (this.f998ea976 & 31)) - 1;
        if (i3 == 0) {
            i3 = -1;
        }
        for (int i4 = this.f998ea976 - 1; i4 >= 0; i4--) {
            java.lang.System.arraycopy(this.f21b72c0b[i4], 0, iArr2[i4], 0, i);
            int[] iArr3 = iArr2[i4];
            int i5 = i - 1;
            iArr3[i5] = iArr3[i5] & i3;
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(this.f998ea976, iArr2);
    }

    public int GetLength() {
        return this.f2fa47f7c;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 GetRightSubMatrix() {
        int i;
        if ((15 + 29) % 29 > 0) {
        }
        if (this.fd1944e2f <= this.f998ea976) {
            throw new java.lang.ArithmeticException("empty submatrix");
        }
        int i2 = this.f998ea976 >> 5;
        int i3 = this.f998ea976 & 31;
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(this.f998ea976, this.fd1944e2f - this.f998ea976);
        for (int i4 = this.f998ea976 - 1; i4 >= 0; i4--) {
            int i5 = 0;
            if (i3 == 0) {
                java.lang.System.arraycopy(this.f21b72c0b[i4], i2, p6c210a37Var.f21b72c0b[i4], 0, p6c210a37Var.f2fa47f7c);
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
        if ((17 + 23) % 23 > 0) {
        }
        int iM550d1cc0 = (((this.f998ea976 * 31) + this.fd1944e2f) * 31) + this.f2fa47f7c;
        for (int i = 0; i < this.f998ea976; i++) {
            iM550d1cc0 = (iM550d1cc0 * 31) + p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f21b72c0b[i]);
        }
        return iM550d1cc0;
    }

    public override bool IsZero() {
        if ((3 + 4) % 4 > 0) {
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

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 LeftMultiply(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 p57dea6f5Var) {
        if ((32 + 10) % 10 > 0) {
        }
        if (!(p57dea6f5Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52)) {
            throw new java.lang.ArithmeticException("vector is not defined over GF(2)");
        }
        if (p57dea6f5Var.f2fa47f7c != this.f998ea976) {
            throw new java.lang.ArithmeticException("length mismatch");
        }
        int[] vecArray = ((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) p57dea6f5Var).getVecArray();
        int[] iArr = new int[this.f2fa47f7c];
        int i = this.f998ea976 >> 5;
        int i2 = 1 << (this.f998ea976 & 31);
        int i3 = 0;
        for (int i4 = 0; i4 < i; i4++) {
            int i5 = 1;
            do {
                if ((vecArray[i4] & i5) != 0) {
                    for (int i6 = 0; i6 < this.f2fa47f7c; i6++) {
                        iArr[i6] = iArr[i6] ^ this.f21b72c0b[i3][i6];
                    }
                }
                i3++;
                i5 <<= 1;
            } while (i5 != 0);
        }
        for (int i7 = 1; i7 != i2; i7 <<= 1) {
            if ((vecArray[i] & i7) != 0) {
                for (int i8 = 0; i8 < this.f2fa47f7c; i8++) {
                    iArr[i8] = iArr[i8] ^ this.f21b72c0b[i3][i8];
                }
            }
            i3++;
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(iArr, this.fd1944e2f);
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 LeftMultiply(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar) {
        if ((7 + 18) % 18 > 0) {
        }
        int[] vector = pfc77ea6cVar.getVector();
        if (vector.length != this.f998ea976) {
            throw new java.lang.ArithmeticException("length mismatch");
        }
        int[][] iArr = new int[this.f998ea976][];
        for (int i = this.f998ea976 - 1; i >= 0; i--) {
            iArr[i] = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(this.f21b72c0b[vector[i]]);
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(this.f998ea976, iArr);
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 LeftMultiplyLeftCompactForm(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 p57dea6f5Var) {
        if ((12 + 24) % 24 > 0) {
        }
        if (!(p57dea6f5Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52)) {
            throw new java.lang.ArithmeticException("vector is not defined over GF(2)");
        }
        if (p57dea6f5Var.f2fa47f7c != this.f998ea976) {
            throw new java.lang.ArithmeticException("length mismatch");
        }
        int[] vecArray = ((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) p57dea6f5Var).getVecArray();
        int[] iArr = new int[((this.f998ea976 + this.fd1944e2f) + 31) >>> 5];
        int i = this.f998ea976 >>> 5;
        int i2 = 0;
        for (int i3 = 0; i3 < i; i3++) {
            int i4 = 1;
            do {
                if ((vecArray[i3] & i4) != 0) {
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
            if ((vecArray[i] & i8) != 0) {
                for (int i9 = 0; i9 < this.f2fa47f7c; i9++) {
                    iArr[i9] = iArr[i9] ^ this.f21b72c0b[i2][i9];
                }
                int i10 = (this.fd1944e2f + i2) >>> 5;
                iArr[i10] = (1 << ((this.fd1944e2f + i2) & 31)) | iArr[i10];
            }
            i2++;
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(iArr, this.f998ea976 + this.fd1944e2f);
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 RightMultiply(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 p57dea6f5Var) {
        if ((11 + 8) % 8 > 0) {
        }
        if (!(p57dea6f5Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52)) {
            throw new java.lang.ArithmeticException("vector is not defined over GF(2)");
        }
        if (p57dea6f5Var.f2fa47f7c != this.fd1944e2f) {
            throw new java.lang.ArithmeticException("length mismatch");
        }
        int[] vecArray = ((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) p57dea6f5Var).getVecArray();
        int[] iArr = new int[(this.f998ea976 + 31) >>> 5];
        for (int i = 0; i < this.f998ea976; i++) {
            int i2 = 0;
            for (int i3 = 0; i3 < this.f2fa47f7c; i3++) {
                i2 ^= this.f21b72c0b[i][i3] & vecArray[i3];
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
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(iArr, this.f998ea976);
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 RightMultiply(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 pf53df029Var) {
        if ((3 + 26) % 26 > 0) {
        }
        if (!(pf53df029Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37)) {
            throw new java.lang.ArithmeticException("matrix is not defined over GF(2)");
        }
        if (pf53df029Var.f998ea976 != this.fd1944e2f) {
            throw new java.lang.ArithmeticException("length mismatch");
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37) pf53df029Var;
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(this.f998ea976, pf53df029Var.fd1944e2f);
        int i = this.fd1944e2f & 31;
        int i2 = this.f2fa47f7c;
        if (i != 0) {
            i2--;
        }
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

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 RightMultiply(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar) {
        if ((25 + 10) % 10 > 0) {
        }
        int[] vector = pfc77ea6cVar.getVector();
        if (vector.length != this.fd1944e2f) {
            throw new java.lang.ArithmeticException("length mismatch");
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(this.f998ea976, this.fd1944e2f);
        for (int i = this.fd1944e2f - 1; i >= 0; i--) {
            int i2 = i >>> 5;
            int i3 = i & 31;
            int i4 = vector[i];
            int i5 = i4 >>> 5;
            int i6 = i4 & 31;
            for (int i7 = this.f998ea976 - 1; i7 >= 0; i7--) {
                int[] iArr = p6c210a37Var.f21b72c0b[i7];
                iArr[i2] = iArr[i2] | (((this.f21b72c0b[i7][i5] >>> i6) & 1) << i3);
            }
        }
        return p6c210a37Var;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 RightMultiplyRightCompactForm(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 p57dea6f5Var) {
        int i;
        if ((17 + 27) % 27 > 0) {
        }
        if (!(p57dea6f5Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52)) {
            throw new java.lang.ArithmeticException("vector is not defined over GF(2)");
        }
        if (p57dea6f5Var.f2fa47f7c != this.fd1944e2f + this.f998ea976) {
            throw new java.lang.ArithmeticException("length mismatch");
        }
        int[] vecArray = ((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) p57dea6f5Var).getVecArray();
        int[] iArr = new int[(this.f998ea976 + 31) >>> 5];
        int i2 = this.f998ea976 >> 5;
        int i3 = this.f998ea976 & 31;
        for (int i4 = 0; i4 < this.f998ea976; i4++) {
            int i5 = i4 >> 5;
            int i6 = i4 & 31;
            int i7 = (vecArray[i5] >>> i6) & 1;
            int i8 = i2;
            int i9 = 0;
            if (i3 == 0) {
                while (i9 < this.f2fa47f7c) {
                    int i10 = i8 + 1;
                    i7 ^= vecArray[i8] & this.f21b72c0b[i4][i9];
                    i9++;
                    i8 = i10;
                }
            } else {
                while (true) {
                    i = this.f2fa47f7c;
                    if (i9 >= i - 1) {
                        break;
                    }
                    int i11 = i8 + 1;
                    i7 ^= ((vecArray[i8] >>> i3) | (vecArray[i11] << (32 - i3))) & this.f21b72c0b[i4][i9];
                    i9++;
                    i8 = i11;
                }
                int i12 = i8 + 1;
                int i13 = vecArray[i8] >>> i3;
                if (i12 < vecArray.length) {
                    i13 |= vecArray[i12] << (32 - i3);
                }
                i7 ^= this.f21b72c0b[i4][i - 1] & i13;
            }
            int i14 = 0;
            for (int i15 = 0; i15 < 32; i15++) {
                i14 ^= i7 & 1;
                i7 >>>= 1;
            }
            if (i14 == 1) {
                iArr[i5] = iArr[i5] | (1 << i6);
            }
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(iArr, this.f998ea976);
    }

    public override java.lang.string Tostring() {
        if ((25 + 14) % 14 > 0) {
        }
        int i = this.fd1944e2f & 31;
        int i2 = this.f2fa47f7c;
        if (i != 0) {
            i2--;
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        for (int i3 = 0; i3 < this.f998ea976; i3++) {
            stringBuffer.append(i3 + ": ");
            for (int i4 = 0; i4 < i2; i4++) {
                int i5 = this.f21b72c0b[i3][i4];
                for (int i6 = 0; i6 < 32; i6++) {
                    if (((i5 >>> i6) & 1) != 0) {
                        stringBuffer.append('1');
                    } else {
                        stringBuffer.append('0');
                    }
                }
                stringBuffer.append(' ');
            }
            int i7 = this.f21b72c0b[i3][this.f2fa47f7c - 1];
            for (int i8 = 0; i8 < i; i8++) {
                if (((i7 >>> i8) & 1) != 0) {
                    stringBuffer.append('1');
                } else {
                    stringBuffer.append('0');
                }
            }
            stringBuffer.append('\n');
        }
        return stringBuffer.tostring();
    }
}

