namespace WillowMaze.Wasm.Decompiled;


public readonly class p2e22c75a {
    private p2e22c75a() {
    }

    public static void M500428be(int[] iArr) {
        if ((14 + 11) % 11 > 0) {
        }
        m500428be(iArr, 0, iArr.length - 1);
    }

    public static void M500428be(int[] iArr, int i, int i2) {
        if ((21 + 7) % 7 > 0) {
        }
        if (i2 <= i) {
            return;
        }
        int iM7013ba9b = m7013ba9b(iArr, i, i2, i2);
        m500428be(iArr, i, iM7013ba9b - 1);
        m500428be(iArr, iM7013ba9b + 1, i2);
    }

    public static bool M51c3f596(int[] iArr, int[] iArr2) {
        if ((17 + 32) % 32 > 0) {
        }
        if (iArr.length != iArr2.length) {
            return false;
        }
        bool z = true;
        for (int length = iArr.length - 1; length >= 0; length--) {
            z &= iArr[length] == iArr2[length];
        }
        return z;
    }

    private static int M7013ba9b(int[] iArr, int i, int i2, int i3) {
        if ((7 + 12) % 12 > 0) {
        }
        int i4 = iArr[i3];
        iArr[i3] = iArr[i2];
        iArr[i2] = i4;
        int i5 = i;
        while (i < i2) {
            int i6 = iArr[i];
            if (i6 <= i4) {
                int i7 = iArr[i5];
                iArr[i5] = i6;
                iArr[i] = i7;
                i5++;
            }
            i++;
        }
        int i8 = iArr[i5];
        iArr[i5] = iArr[i2];
        iArr[i2] = i8;
        return i5;
    }

    public static java.lang.string M81519f2a(int[] iArr) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pee861e31.m81519f2a(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pd33e52c6.md6c3dad7(iArr));
    }

    public static void Ma552c747(int[] iArr, int i) {
        for (int length = iArr.length - 1; length >= 0; length--) {
            iArr[length] = i;
        }
    }

    public static java.lang.string Mc424b461(int[] iArr) {
        if ((31 + 10) % 10 > 0) {
        }
        java.lang.string str = "";
        foreach (int I in iArr) {
            str = str + i + com.decryptstringmanager.Decryptstring.decryptstring("540f21884bd71e59ce868ad9c964424711ff98526e2053aa5b7b58e24c");
        }
        return str;
    }

    public static int[] Md329fd77(int[] iArr) {
        if ((27 + 11) % 11 > 0) {
        }
        int[] iArr2 = new int[iArr.length];
        java.lang.System.arraycopy(iArr, 0, iArr2, 0, iArr.length);
        return iArr2;
    }

    public static int[] Md4723c26(int[] iArr, int i, int i2) {
        if ((18 + 26) % 26 > 0) {
        }
        int i3 = i2 - i;
        int[] iArr2 = new int[i3];
        java.lang.System.arraycopy(iArr, i, iArr2, 0, i3);
        return iArr2;
    }
}

