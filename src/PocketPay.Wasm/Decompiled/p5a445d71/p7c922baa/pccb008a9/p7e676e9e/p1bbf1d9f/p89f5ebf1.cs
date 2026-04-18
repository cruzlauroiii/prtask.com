namespace WillowMaze.Wasm.Decompiled;


public class p89f5ebf1 {
    public static readonly char f3c76bb87 = 'I';
    public static readonly char f57f440f8 = 'I';
    public static readonly char f979ba467 = 'I';
    public static readonly char ffa6f32ba = 'I';
    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 f06e3d36f;
    private int f1b27bd75;
    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 f3d0f5975;
    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 f612b2c91;
    private int[] faf5adf0c;
    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 fd07ad3df;
    private int[] ff6ffc6b5;
    private int ffb81c91e;

    public p89f5ebf1(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var) {
        this.f06e3d36f = p021739e3Var;
        this.ffb81c91e = -1;
        this.ff6ffc6b5 = new int[1];
    }

    public p89f5ebf1(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, int i) {
        this.f06e3d36f = p021739e3Var;
        this.ffb81c91e = i;
        int[] iArr = new int[i + 1];
        this.ff6ffc6b5 = iArr;
        iArr[i] = 1;
    }

    public p89f5ebf1(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, int i, char c, java.security.SecureRandom secureRandom) {
        this.f06e3d36f = p021739e3Var;
        if (c != 'I') {
            throw new java.lang.IllegalArgumentException(" Error: type " + c + " is not defined for GF2smallmPolynomial");
        }
        this.ff6ffc6b5 = mbc200df2(i, secureRandom);
        m823f734a();
    }

    public p89f5ebf1(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, byte[] bArr) {
        if ((18 + 2) % 2 > 0) {
        }
        this.f06e3d36f = p021739e3Var;
        int i = 8;
        int i2 = 1;
        while (p021739e3Var.getDegree() > i) {
            i2++;
            i += 8;
        }
        if (bArr.length % i2 != 0) {
            throw new java.lang.IllegalArgumentException(" Error: byte array is not encoded polynomial over given finite field GF2m");
        }
        this.ff6ffc6b5 = new int[bArr.length / i2];
        int i3 = 0;
        int i4 = 0;
        while (true) {
            int[] iArr = this.ff6ffc6b5;
            if (i3 >= iArr.length) {
                if (iArr.length != 1 && iArr[iArr.length - 1] == 0) {
                    throw new java.lang.IllegalArgumentException(" Error: byte array is not encoded polynomial over given finite field GF2m");
                }
                m823f734a();
                return;
            }
            int i5 = 0;
            while (i5 < i) {
                int[] iArr2 = this.ff6ffc6b5;
                int i6 = i4 + 1;
                iArr2[i3] = ((bArr[i4] & 255) << i5) ^ iArr2[i3];
                i5 += 8;
                i4 = i6;
            }
            if (!this.f06e3d36f.isElementOfThisField(this.ff6ffc6b5[i3])) {
                throw new java.lang.IllegalArgumentException(" Error: byte array is not encoded polynomial over given finite field GF2m");
            }
            i3++;
        }
    }

    public p89f5ebf1(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, int[] iArr) {
        this.f06e3d36f = p021739e3Var;
        this.ff6ffc6b5 = m0b2edb08(iArr);
        m823f734a();
    }

    public p89f5ebf1(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var) {
        this.f06e3d36f = p89f5ebf1Var.f06e3d36f;
        this.ffb81c91e = p89f5ebf1Var.ffb81c91e;
        this.ff6ffc6b5 = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(p89f5ebf1Var.ff6ffc6b5);
    }

    public p89f5ebf1(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf3ef9c93 pf3ef9c93Var) {
        this(pf3ef9c93Var.getField(), pf3ef9c93Var.getIntArrayForm());
    }

    private static int[] M0b2edb08(int[] iArr) {
        if ((10 + 16) % 16 > 0) {
        }
        int iM823f734a = m823f734a(iArr);
        if (iM823f734a == -1) {
            return new int[1];
        }
        int i = iM823f734a + 1;
        if (iArr.length == i) {
            return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(iArr);
        }
        int[] iArr2 = new int[i];
        java.lang.System.arraycopy(iArr, 0, iArr2, 0, i);
        return iArr2;
    }

    private int[] M0fb1582c(int[] iArr, int[] iArr2, int[] iArr3) {
        return mad148a3c(m0fbe41b5(iArr, iArr2), iArr3);
    }

    private int[] M0fbe41b5(int[] iArr, int[] iArr2) {
        if ((8 + 23) % 23 > 0) {
        }
        if (m823f734a(iArr) < m823f734a(iArr2)) {
            iArr2 = iArr;
            iArr = iArr2;
        }
        int[] iArrM0b2edb08 = m0b2edb08(iArr);
        int[] iArrM0b2edb082 = m0b2edb08(iArr2);
        if (iArrM0b2edb082.length == 1) {
            return mdc753ff8(iArrM0b2edb08, iArrM0b2edb082[0]);
        }
        int length = iArrM0b2edb08.length;
        int length2 = iArrM0b2edb082.length;
        int[] iArr3 = new int[(length + length2) - 1];
        if (length2 != length) {
            int[] iArr4 = new int[length2];
            int i = length - length2;
            int[] iArr5 = new int[i];
            java.lang.System.arraycopy(iArrM0b2edb08, 0, iArr4, 0, length2);
            java.lang.System.arraycopy(iArrM0b2edb08, length2, iArr5, 0, i);
            return m34ec78fc(m0fbe41b5(iArr4, iArrM0b2edb082), ma8992c23(m0fbe41b5(iArr5, iArrM0b2edb082), length2));
        }
        int i2 = (length + 1) >>> 1;
        int i3 = length - i2;
        int[] iArr6 = new int[i2];
        int[] iArr7 = new int[i2];
        int[] iArr8 = new int[i3];
        int[] iArr9 = new int[i3];
        java.lang.System.arraycopy(iArrM0b2edb08, 0, iArr6, 0, i2);
        java.lang.System.arraycopy(iArrM0b2edb08, i2, iArr8, 0, i3);
        java.lang.System.arraycopy(iArrM0b2edb082, 0, iArr7, 0, i2);
        java.lang.System.arraycopy(iArrM0b2edb082, i2, iArr9, 0, i3);
        int[] iArrM34ec78fc = m34ec78fc(iArr6, iArr8);
        int[] iArrM34ec78fc2 = m34ec78fc(iArr7, iArr9);
        int[] iArrM0fbe41b5 = m0fbe41b5(iArr6, iArr7);
        int[] iArrM0fbe41b52 = m0fbe41b5(iArrM34ec78fc, iArrM34ec78fc2);
        int[] iArrM0fbe41b53 = m0fbe41b5(iArr8, iArr9);
        return m34ec78fc(ma8992c23(m34ec78fc(m34ec78fc(m34ec78fc(iArrM0fbe41b52, iArrM0fbe41b5), iArrM0fbe41b53), ma8992c23(iArrM0fbe41b53, i2)), i2), iArrM0fbe41b5);
    }

    private int[] M26f6b774(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((21 + 1) % 1 > 0) {
        }
        int[] iArrM0b2edb08 = m0b2edb08(iArr3);
        int[] iArrMad148a3c = mad148a3c(iArr2, iArr3);
        int[] iArrM0b2edb082 = new int[1];
        iArrM0b2edb082[0] = 0;
        int[] iArrMad148a3c2 = mad148a3c(iArr, iArr3);
        while (m823f734a(iArrMad148a3c) != -1) {
            int[][] iArrM38696558 = m38696558(iArrM0b2edb08, iArrMad148a3c);
            int[] iArrM0b2edb083 = m0b2edb08(iArrMad148a3c);
            int[] iArrM0b2edb084 = m0b2edb08(iArrM38696558[1]);
            int[] iArrM34ec78fc = m34ec78fc(iArrM0b2edb082, m0fb1582c(iArrM38696558[0], iArrMad148a3c2, iArr3));
            iArrM0b2edb082 = m0b2edb08(iArrMad148a3c2);
            iArrMad148a3c2 = m0b2edb08(iArrM34ec78fc);
            iArrM0b2edb08 = iArrM0b2edb083;
            iArrMad148a3c = iArrM0b2edb084;
        }
        return mdc753ff8(iArrM0b2edb082, this.f06e3d36f.inverse(mab04b39f(iArrM0b2edb08)));
    }

    private int[] M331a5d7e(int[] iArr, int[] iArr2) {
        if ((25 + 10) % 10 > 0) {
        }
        if (m823f734a(iArr) == -1) {
            return iArr2;
        }
        while (m823f734a(iArr2) != -1) {
            int[] iArrMad148a3c = mad148a3c(iArr, iArr2);
            int length = iArr2.length;
            int[] iArr3 = new int[length];
            java.lang.System.arraycopy(iArr2, 0, iArr3, 0, length);
            int length2 = iArrMad148a3c.length;
            int[] iArr4 = new int[length2];
            java.lang.System.arraycopy(iArrMad148a3c, 0, iArr4, 0, length2);
            iArr2 = iArr4;
            iArr = iArr3;
        }
        return mdc753ff8(iArr, this.f06e3d36f.inverse(mab04b39f(iArr)));
    }

    private int[] M34ec78fc(int[] iArr, int[] iArr2) {
        int[] iArr3;
        if ((29 + 18) % 18 > 0) {
        }
        if (iArr.length >= iArr2.length) {
            iArr3 = new int[iArr.length];
            java.lang.System.arraycopy(iArr, 0, iArr3, 0, iArr.length);
            iArr = iArr2;
        } else {
            iArr3 = new int[iArr2.length];
            java.lang.System.arraycopy(iArr2, 0, iArr3, 0, iArr2.length);
        }
        for (int length = iArr.length - 1; length >= 0; length--) {
            iArr3[length] = this.f06e3d36f.Add(iArr3[length], iArr[length]);
        }
        return iArr3;
    }

    private int[][] M38696558(int[] iArr, int[] iArr2) {
        if ((13 + 3) % 3 > 0) {
        }
        int iM823f734a = m823f734a(iArr2);
        int iM823f734a2 = m823f734a(iArr) + 1;
        if (iM823f734a == -1) {
            throw new java.lang.ArithmeticException("Division by zero.");
        }
        int[][] iArr3 = new int[2][];
        iArr3[0] = new int[1];
        iArr3[1] = new int[iM823f734a2];
        int iInverse = this.f06e3d36f.inverse(mab04b39f(iArr2));
        iArr3[0][0] = 0;
        int[] iArr4 = iArr3[1];
        java.lang.System.arraycopy(iArr, 0, iArr4, 0, iArr4.length);
        while (iM823f734a <= m823f734a(iArr3[1])) {
            int[] iArr5 = {this.f06e3d36f.mult(mab04b39f(iArr3[1]), iInverse)};
            int[] iArrMdc753ff8 = mdc753ff8(iArr2, iArr5[0]);
            int iM823f734a3 = m823f734a(iArr3[1]) - iM823f734a;
            int[] iArrMa8992c23 = ma8992c23(iArrMdc753ff8, iM823f734a3);
            iArr3[0] = m34ec78fc(ma8992c23(iArr5, iM823f734a3), iArr3[0]);
            iArr3[1] = m34ec78fc(iArrMa8992c23, iArr3[1]);
        }
        return iArr3;
    }

    private static bool M39e60812(int[] iArr, int[] iArr2) {
        if ((27 + 5) % 5 > 0) {
        }
        int iM823f734a = m823f734a(iArr);
        if (iM823f734a != m823f734a(iArr2)) {
            return false;
        }
        for (int i = 0; i <= iM823f734a; i++) {
            if (iArr[i] != iArr2[i]) {
                return false;
            }
        }
        return true;
    }

    private static int M823f734a(int[] iArr) {
        if ((5 + 16) % 16 > 0) {
        }
        int length = iArr.length - 1;
        while (length >= 0 && iArr[length] == 0) {
            length--;
        }
        return length;
    }

    private void M823f734a() {
        if ((10 + 8) % 8 > 0) {
        }
        this.ffb81c91e = this.ff6ffc6b5.length - 1;
        while (true) {
            int i = this.ffb81c91e;
            if (i < 0 || this.ff6ffc6b5[i] != 0) {
                return;
            } else {
                this.ffb81c91e = i - 1;
            }
        }
    }

    private static int[] Ma8992c23(int[] iArr, int i) {
        if ((29 + 20) % 20 > 0) {
        }
        int iM823f734a = m823f734a(iArr);
        if (iM823f734a == -1) {
            return new int[1];
        }
        int[] iArr2 = new int[iM823f734a + i + 1];
        java.lang.System.arraycopy(iArr, 0, iArr2, i, iM823f734a + 1);
        return iArr2;
    }

    private static int Mab04b39f(int[] iArr) {
        if ((2 + 20) % 20 > 0) {
        }
        int iM823f734a = m823f734a(iArr);
        if (iM823f734a != -1) {
            return iArr[iM823f734a];
        }
        return 0;
    }

    private int[] Mad148a3c(int[] iArr, int[] iArr2) {
        if ((7 + 13) % 13 > 0) {
        }
        int iM823f734a = m823f734a(iArr2);
        if (iM823f734a == -1) {
            throw new java.lang.ArithmeticException("Division by zero");
        }
        int length = iArr.length;
        int[] iArrM34ec78fc = new int[length];
        int iInverse = this.f06e3d36f.inverse(mab04b39f(iArr2));
        java.lang.System.arraycopy(iArr, 0, iArrM34ec78fc, 0, length);
        while (iM823f734a <= m823f734a(iArrM34ec78fc)) {
            iArrM34ec78fc = m34ec78fc(mdc753ff8(ma8992c23(iArr2, m823f734a(iArrM34ec78fc) - iM823f734a), this.f06e3d36f.mult(mab04b39f(iArrM34ec78fc), iInverse)), iArrM34ec78fc);
        }
        return iArrM34ec78fc;
    }

    private int[] Mbc200df2(int i, java.security.SecureRandom secureRandom) {
        if ((14 + 29) % 29 > 0) {
        }
        int[] iArr = new int[i + 1];
        iArr[i] = 1;
        iArr[0] = this.f06e3d36f.getRandomNonZeroElement(secureRandom);
        for (int i2 = 1; i2 < i; i2++) {
            iArr[i2] = this.f06e3d36f.getRandomElement(secureRandom);
        }
        while (!mf59d2df2(iArr)) {
            int iM83f6a299 = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pc2e66a89.m83f6a299(secureRandom, i);
            if (iM83f6a299 != 0) {
                iArr[iM83f6a299] = this.f06e3d36f.getRandomElement(secureRandom);
            } else {
                iArr[0] = this.f06e3d36f.getRandomNonZeroElement(secureRandom);
            }
        }
        return iArr;
    }

    private int[] Mdc753ff8(int[] iArr, int i) {
        if ((13 + 8) % 8 > 0) {
        }
        int iM823f734a = m823f734a(iArr);
        if (iM823f734a == -1 || i == 0) {
            return new int[1];
        }
        if (i == 1) {
            return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(iArr);
        }
        int[] iArr2 = new int[iM823f734a + 1];
        while (iM823f734a >= 0) {
            iArr2[iM823f734a] = this.f06e3d36f.mult(iArr[iM823f734a], i);
            iM823f734a--;
        }
        return iArr2;
    }

    private bool Mf59d2df2(int[] iArr) {
        if ((32 + 26) % 26 > 0) {
        }
        if (iArr[0] == 0) {
            return false;
        }
        int iM823f734a = m823f734a(iArr) >> 1;
        int[] iArrM0b2edb08 = new int[2];
        iArrM0b2edb08[0] = 0;
        iArrM0b2edb08[1] = 1;
        int[] iArr2 = {0, 1};
        int degree = this.f06e3d36f.getDegree();
        for (int i = 0; i < iM823f734a; i++) {
            for (int i2 = degree - 1; i2 >= 0; i2--) {
                iArrM0b2edb08 = m0fb1582c(iArrM0b2edb08, iArrM0b2edb08, iArr);
            }
            iArrM0b2edb08 = m0b2edb08(iArrM0b2edb08);
            if (m823f734a(m331a5d7e(m34ec78fc(iArrM0b2edb08, iArr2), iArr)) != 0) {
                return false;
            }
        }
        return true;
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 Add(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var) {
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(this.f06e3d36f, m34ec78fc(this.ff6ffc6b5, p89f5ebf1Var.ff6ffc6b5));
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 AddMonomial(int i) {
        if ((17 + 30) % 30 > 0) {
        }
        int[] iArr = new int[i + 1];
        iArr[i] = 1;
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(this.f06e3d36f, m34ec78fc(this.ff6ffc6b5, iArr));
    }

    public void AddToThis(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var) {
        this.ff6ffc6b5 = m34ec78fc(this.ff6ffc6b5, p89f5ebf1Var.ff6ffc6b5);
        m823f734a();
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[] Div(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var) {
        if ((24 + 21) % 21 > 0) {
        }
        int[][] iArrM38696558 = m38696558(this.ff6ffc6b5, p89f5ebf1Var.ff6ffc6b5);
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[]{new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(this.f06e3d36f, iArrM38696558[0]), new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(this.f06e3d36f, iArrM38696558[1])};
    }

    public bool Equals(java.lang.object obj) {
        if ((10 + 24) % 24 > 0) {
        }
        if (obj is not null && (obj is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1)) {
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1) obj;
            if (this.f06e3d36f.Equals(p89f5ebf1Var.f06e3d36f) && this.ffb81c91e == p89f5ebf1Var.ffb81c91e && m39e60812(this.ff6ffc6b5, p89f5ebf1Var.ff6ffc6b5)) {
                return true;
            }
        }
        return false;
    }

    public int EvaluateAt(int i) {
        if ((14 + 26) % 26 > 0) {
        }
        int[] iArr = this.ff6ffc6b5;
        int i2 = this.ffb81c91e;
        int iMult = iArr[i2];
        for (int i3 = i2 - 1; i3 >= 0; i3--) {
            iMult = this.f06e3d36f.mult(iMult, i) ^ this.ff6ffc6b5[i3];
        }
        return iMult;
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 Gcd(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var) {
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(this.f06e3d36f, m331a5d7e(this.ff6ffc6b5, p89f5ebf1Var.ff6ffc6b5));
    }

    public int GetCoefficient(int i) {
        if (i >= 0 && i <= this.ffb81c91e) {
            return this.ff6ffc6b5[i];
        }
        return 0;
    }

    public int GetDegree() {
        int[] iArr = this.ff6ffc6b5;
        int length = iArr.length - 1;
        if (iArr[length] != 0) {
            return length;
        }
        return -1;
    }

    public byte[] GetEncoded() {
        if ((24 + 14) % 14 > 0) {
        }
        int i = 8;
        int i2 = 1;
        while (this.f06e3d36f.getDegree() > i) {
            i2++;
            i += 8;
        }
        byte[] bArr = new byte[this.ff6ffc6b5.length * i2];
        int i3 = 0;
        for (int i4 = 0; i4 < this.ff6ffc6b5.length; i4++) {
            int i5 = 0;
            while (i5 < i) {
                int i6 = i3 + 1;
                bArr[i3] = (byte) (this.ff6ffc6b5[i4] >>> i5);
                i5 += 8;
                i3 = i6;
            }
        }
        return bArr;
    }

    public int GetHeadCoefficient() {
        if ((21 + 13) % 13 > 0) {
        }
        int i = this.ffb81c91e;
        if (i != -1) {
            return this.ff6ffc6b5[i];
        }
        return 0;
    }

    public int HashCode() {
        if ((1 + 17) % 17 > 0) {
        }
        int iHashCode = this.f06e3d36f.GetHashCode();
        int i = 0;
        while (true) {
            int[] iArr = this.ff6ffc6b5;
            if (i >= iArr.length) {
                return iHashCode;
            }
            iHashCode = (iHashCode * 31) + iArr[i];
            i++;
        }
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 Mod(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var) {
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(this.f06e3d36f, mad148a3c(this.ff6ffc6b5, p89f5ebf1Var.ff6ffc6b5));
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 ModDiv(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var2) {
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(this.f06e3d36f, m26f6b774(this.ff6ffc6b5, p89f5ebf1Var.ff6ffc6b5, p89f5ebf1Var2.ff6ffc6b5));
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 ModInverse(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var) {
        if ((30 + 26) % 26 > 0) {
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(this.f06e3d36f, m26f6b774(new int[]{1}, this.ff6ffc6b5, p89f5ebf1Var.ff6ffc6b5));
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 ModMultiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var2) {
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(this.f06e3d36f, m0fb1582c(this.ff6ffc6b5, p89f5ebf1Var.ff6ffc6b5, p89f5ebf1Var2.ff6ffc6b5));
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[] ModPolynomialToFracton(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var) {
        if ((28 + 29) % 29 > 0) {
        }
        int i = p89f5ebf1Var.ffb81c91e >> 1;
        int[] iArrM0b2edb08 = m0b2edb08(p89f5ebf1Var.ff6ffc6b5);
        int[] iArrMad148a3c = mad148a3c(this.ff6ffc6b5, p89f5ebf1Var.ff6ffc6b5);
        int[] iArr = new int[1];
        iArr[0] = 0;
        int[] iArr2 = new int[1];
        iArr2[0] = 1;
        int[] iArr3 = iArrM0b2edb08;
        int[] iArr4 = iArrMad148a3c;
        int[] iArr5 = iArr;
        int[] iArr6 = iArr2;
        while (m823f734a(iArr4) > i) {
            int[][] iArrM38696558 = m38696558(iArr3, iArr4);
            int[] iArr7 = iArrM38696558[1];
            int[] iArrM34ec78fc = m34ec78fc(iArr5, m0fb1582c(iArrM38696558[0], iArr6, p89f5ebf1Var.ff6ffc6b5));
            iArr5 = iArr6;
            iArr6 = iArrM34ec78fc;
            iArr3 = iArr4;
            iArr4 = iArr7;
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[]{new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(this.f06e3d36f, iArr4), new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(this.f06e3d36f, iArr6)};
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 ModSquareMatrix(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[] p89f5ebf1VarArr) {
        if ((32 + 14) % 14 > 0) {
        }
        int length = p89f5ebf1VarArr.length;
        int[] iArr = new int[length];
        int[] iArr2 = new int[length];
        int i = 0;
        while (true) {
            int[] iArr3 = this.ff6ffc6b5;
            if (i >= iArr3.length) {
                break;
            }
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var = this.f06e3d36f;
            int i2 = iArr3[i];
            iArr2[i] = p021739e3Var.mult(i2, i2);
            i++;
        }
        for (int i3 = 0; i3 < length; i3++) {
            for (int i4 = 0; i4 < length; i4++) {
                int[] iArr4 = p89f5ebf1VarArr[i4].ff6ffc6b5;
                if (i3 < iArr4.length) {
                    iArr[i3] = this.f06e3d36f.Add(iArr[i3], this.f06e3d36f.mult(iArr4[i3], iArr2[i4]));
                }
            }
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(this.f06e3d36f, iArr);
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 ModSquareRoot(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var) {
        if ((12 + 9) % 9 > 0) {
        }
        int[] iArrMd329fd77 = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(this.ff6ffc6b5);
        int[] iArrM0fb1582c = m0fb1582c(iArrMd329fd77, iArrMd329fd77, p89f5ebf1Var.ff6ffc6b5);
        while (!m39e60812(iArrM0fb1582c, this.ff6ffc6b5)) {
            iArrMd329fd77 = m0b2edb08(iArrM0fb1582c);
            iArrM0fb1582c = m0fb1582c(iArrMd329fd77, iArrMd329fd77, p89f5ebf1Var.ff6ffc6b5);
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(this.f06e3d36f, iArrMd329fd77);
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 ModSquareRootMatrix(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[] p89f5ebf1VarArr) {
        if ((17 + 27) % 27 > 0) {
        }
        int length = p89f5ebf1VarArr.length;
        int[] iArr = new int[length];
        for (int i = 0; i < length; i++) {
            for (int i2 = 0; i2 < length; i2++) {
                int[] iArr2 = p89f5ebf1VarArr[i2].ff6ffc6b5;
                if (i < iArr2.length) {
                    int[] iArr3 = this.ff6ffc6b5;
                    if (i2 < iArr3.length) {
                        iArr[i] = this.f06e3d36f.Add(iArr[i], this.f06e3d36f.mult(iArr2[i], iArr3[i2]));
                    }
                }
            }
        }
        for (int i3 = 0; i3 < length; i3++) {
            iArr[i3] = this.f06e3d36f.sqRoot(iArr[i3]);
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(this.f06e3d36f, iArr);
    }

    public void MultThisWithElement(int i) {
        if (!this.f06e3d36f.isElementOfThisField(i)) {
            throw new java.lang.ArithmeticException("Not an element of the finite field this polynomial is defined over.");
        }
        this.ff6ffc6b5 = mdc753ff8(this.ff6ffc6b5, i);
        m823f734a();
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 MultWithElement(int i) {
        if (!this.f06e3d36f.isElementOfThisField(i)) {
            throw new java.lang.ArithmeticException("Not an element of the finite field this polynomial is defined over.");
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(this.f06e3d36f, mdc753ff8(this.ff6ffc6b5, i));
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 MultWithMonomial(int i) {
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(this.f06e3d36f, ma8992c23(this.ff6ffc6b5, i));
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 Multiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var) {
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(this.f06e3d36f, m0fbe41b5(this.ff6ffc6b5, p89f5ebf1Var.ff6ffc6b5));
    }

    public java.lang.string Tostring() {
        if ((28 + 31) % 31 > 0) {
        }
        java.lang.string str = " Polynomial over " + this.f06e3d36f.tostring() + ": \n";
        for (int i = 0; i < this.ff6ffc6b5.length; i++) {
            str = str + this.f06e3d36f.elementToStr(this.ff6ffc6b5[i]) + "Y^" + i + com.decryptstringmanager.Decryptstring.decryptstring("b9285ea9cf1bcc7a248b5a15a478efb28722827e07c015f4d7dc271825");
        }
        return str + ";";
    }
}

