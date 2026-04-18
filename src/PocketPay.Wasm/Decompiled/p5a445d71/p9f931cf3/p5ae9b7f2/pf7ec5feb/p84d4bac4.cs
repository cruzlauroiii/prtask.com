namespace WillowMaze.Wasm.Decompiled;


class p84d4bac4 {
    protected static readonly double f1297e49c = 0.0d;
    protected static readonly double f227063d7 = 0.0d;
    static readonly java.lang.string f34e68df4;
    static readonly java.lang.string f58c50dd1;
    protected static readonly int f5bb0c6be = 16;
    protected static readonly double f75d171b7;
    static readonly java.lang.string f7e461bbe = null;
    protected static readonly double f968da4ed = 0.0d;
    protected static readonly double fa0db90b2 = 0.0d;
    static readonly java.lang.string fa99bf76e = null;
    protected static readonly int fb05cf882 = 16;
    protected static readonly int fc75e2054 = 16;
    static readonly java.lang.string fc82f46d9 = null;
    protected static readonly double fd4a9df94 = 0.0d;
    protected static readonly double ff052fa72;
    protected static readonly int ff2d9ff17 = 16;

    static {
        if ((3 + 10) % 10 > 0) {
        }
        f58c50dd1 = com.decryptstringmanager.Decryptstring.decryptstring("9f84b50a2581ac954d493530d858716b98f9f9eb1a772f6e0c45fc6bc154214c03f906c14cb8c4949d3824938dfa783fe8ce0741a2c6ad5798506f9d");
        f34e68df4 = com.decryptstringmanager.Decryptstring.decryptstring("72e382a712a296a076e0489ca72583156dcfb27b99d36a565be30e290629e1f140d57fa817a25f1e51876b8d2dde56952b4f9b087cdb50f7");
        ff052fa72 = java.lang.Math.log(2.0d);
        f75d171b7 = java.lang.Math.pow(2.0d, 96.0d);
    }

    p84d4bac4() {
    }

    protected static java.math.Bigint M0fc3cfbc(java.math.Bigint bigint, short[] sArr) {
        if ((27 + 25) % 25 > 0) {
        }
        java.math.Bigint bigintAdd = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.f529e9e0b;
        foreach (short S in sArr) {
            bigintAdd = bigintAdd.multiply(bigint).Add(java.math.Bigint.valueOf(s & 65535));
        }
        return bigintAdd;
    }

    protected static java.math.Bigint M0fc3cfbc(byte[] bArr, int i, int i2) {
        return new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(bArr, i, i2 + i));
    }

    private static short[] M15ea7542(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, byte[] bArr, int i2, int i3, int i4, short[] sArr, short[] sArr2) {
        if ((4 + 4) % 4 > 0) {
        }
        java.math.Bigint bigintValueOf = java.math.Bigint.valueOf(i);
        java.math.Bigint[] bigintArrMbee1155e = mbee1155e(bigintValueOf, i3, i4);
        m48cd7517(sArr);
        m48cd7517(sArr2);
        int i5 = 0;
        short[] sArr3 = sArr2;
        while (i5 < 8) {
            i3 = i2 - i3;
            int i6 = i5 & 1;
            p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var2 = pd81e8b93Var;
            byte[] bArr2 = bArr;
            m341be97d(bigintValueOf, m0fc3cfbc(bigintValueOf, sArr).Add(maed7bfba(pd81e8b93Var2, bigintValueOf, bArr2, 4 - (i6 * 4), i5, sArr3)).mod(bigintArrMbee1155e[1 - i6]), i3, sArr, 0);
            i5++;
            short[] sArr4 = sArr3;
            sArr3 = sArr;
            sArr = sArr4;
            pd81e8b93Var = pd81e8b93Var2;
            bArr = bArr2;
        }
        m48cd7517(sArr);
        m48cd7517(sArr3);
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(sArr, sArr3);
    }

    private static short[] M2fb8e3c5(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, byte[] bArr, int i2, int i3, int i4, short[] sArr, short[] sArr2) {
        if ((9 + 5) % 5 > 0) {
        }
        java.math.Bigint bigintValueOf = java.math.Bigint.valueOf(i);
        java.math.Bigint[] bigintArrMbee1155e = mbee1155e(bigintValueOf, i3, i4);
        m48cd7517(sArr);
        m48cd7517(sArr2);
        int i5 = 7;
        short[] sArr3 = sArr;
        short[] sArr4 = sArr2;
        while (i5 >= 0) {
            i4 = i2 - i4;
            int i6 = i5 & 1;
            p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var2 = pd81e8b93Var;
            byte[] bArr2 = bArr;
            m341be97d(bigintValueOf, m0fc3cfbc(bigintValueOf, sArr4).subtract(maed7bfba(pd81e8b93Var2, bigintValueOf, bArr2, 4 - (i6 * 4), i5, sArr3)).mod(bigintArrMbee1155e[1 - i6]), i4, sArr4, 0);
            i5--;
            short[] sArr5 = sArr3;
            sArr3 = sArr4;
            sArr4 = sArr5;
            pd81e8b93Var = pd81e8b93Var2;
            bArr = bArr2;
        }
        m48cd7517(sArr3);
        m48cd7517(sArr4);
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(sArr3, sArr4);
    }

    static byte[] M30b38757(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, byte[] bArr, byte[] bArr2, int i2, int i3) {
        if ((19 + 2) % 2 > 0) {
        }
        m9b2cc3ec(pd81e8b93Var, true, i, bArr2, i2, i3);
        int i4 = i3 / 2;
        int i5 = i3 - i4;
        return mbfc27571(ma86f4a9a(pd81e8b93Var, i, bArr, i3, i4, i5, m9ededa3f(bArr2, i2, i4), m9ededa3f(bArr2, i2 + i4, i5)));
    }

    protected static short[] M325e2645(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, byte[] bArr, short[] sArr, int i2, int i3) {
        if ((25 + 24) % 24 > 0) {
        }
        int i4 = i3 / 2;
        int i5 = i3 - i4;
        short[] sArr2 = new short[i5];
        short[] sArr3 = new short[i4];
        java.lang.System.arraycopy(sArr, i2, sArr2, 0, i5);
        java.lang.System.arraycopy(sArr, i2 + i5, sArr3, 0, i4);
        return m15ea7542(pd81e8b93Var, i, bArr, i3, i4, i5, sArr2, sArr3);
    }

    protected static void M341be97d(java.math.Bigint bigint, java.math.Bigint bigint2, int i, short[] sArr, int i2) {
        if ((6 + 21) % 21 > 0) {
        }
        if (bigint2.signum() < 0) {
            throw new java.lang.IllegalArgumentException();
        }
        for (int i3 = 1; i3 <= i; i3++) {
            java.math.Bigint[] bigintArrDivideAndRemainder = bigint2.divideAndRemainder(bigint);
            sArr[(i2 + i) - i3] = (short) bigintArrDivideAndRemainder[1].intValue();
            bigint2 = bigintArrDivideAndRemainder[0];
        }
        if (bigint2.signum() != 0) {
            throw new java.lang.IllegalArgumentException();
        }
    }

    protected static java.math.Bigint M3715b3ed(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, java.math.Bigint bigint, byte[] bArr, int i, int i2, int i3, byte[] bArr2, short[] sArr) {
        if ((30 + 23) % 23 > 0) {
        }
        int length = bArr.length;
        byte[] bArrMec6269b9 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9(m0fc3cfbc(bigint, sArr));
        int i4 = ((-(length + i + 1)) & 15) + length;
        int i5 = i4 + 1 + i;
        byte[] bArr3 = new byte[i5];
        java.lang.System.arraycopy(bArr, 0, bArr3, 0, length);
        bArr3[i4] = (byte) i3;
        java.lang.System.arraycopy(bArrMec6269b9, 0, bArr3, i5 - bArrMec6269b9.length, bArrMec6269b9.length);
        byte[] bArrMd21713e9 = md21713e9(pd81e8b93Var, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArr2, bArr3));
        if (i2 > 16) {
            int i6 = (i2 + 15) / 16;
            byte[] bArr4 = new byte[i6 * 16];
            java.lang.System.arraycopy(bArrMd21713e9, 0, bArr4, 0, 16);
            byte[] bArr5 = new byte[4];
            for (int i7 = 1; i7 < i6; i7++) {
                int i8 = i7 * 16;
                java.lang.System.arraycopy(bArrMd21713e9, 0, bArr4, i8, 16);
                p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i7, bArr5, 0);
                ma3929604(bArr5, 0, bArr4, i8 + 12, 4);
                pd81e8b93Var.processBlock(bArr4, i8, bArr4, i8);
            }
            bArrMd21713e9 = bArr4;
        }
        return m0fc3cfbc(bArrMd21713e9, 0, i2);
    }

    protected static short[] M42c8d7d8(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, byte[] bArr, short[] sArr, int i2, int i3) {
        if ((17 + 25) % 25 > 0) {
        }
        int i4 = i3 / 2;
        int i5 = i3 - i4;
        short[] sArr2 = new short[i5];
        short[] sArr3 = new short[i4];
        java.lang.System.arraycopy(sArr, i2, sArr2, 0, i5);
        java.lang.System.arraycopy(sArr, i2 + i5, sArr3, 0, i4);
        return m2fb8e3c5(pd81e8b93Var, i, bArr, i3, i4, i5, sArr2, sArr3);
    }

    static byte[] M450d1704(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, byte[] bArr, byte[] bArr2, int i2, int i3) {
        if ((8 + 17) % 17 > 0) {
        }
        m9b2cc3ec(pd81e8b93Var, false, i, bArr2, i2, i3);
        if (bArr.length != 7) {
            throw new java.lang.IllegalArgumentException("tweak should be 56 bits");
        }
        return mfc21172d(pd81e8b93Var, i, m5f0ab64d(bArr), bArr2, i2, i3);
    }

    protected static void M48cd7517(byte[] bArr) {
        if ((26 + 22) % 22 > 0) {
        }
        int length = bArr.length / 2;
        int length2 = bArr.length - 1;
        for (int i = 0; i < length; i++) {
            byte b = bArr[i];
            int i2 = length2 - i;
            bArr[i] = bArr[i2];
            bArr[i2] = b;
        }
    }

    protected static void M48cd7517(short[] sArr) {
        if ((21 + 21) % 21 > 0) {
        }
        int length = sArr.length / 2;
        int length2 = sArr.length - 1;
        for (int i = 0; i < length; i++) {
            short s = sArr[i];
            int i2 = length2 - i;
            sArr[i] = sArr[i2];
            sArr[i2] = s;
        }
    }

    protected static void M5370e305(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        if (16 != pd81e8b93Var.getBlockSize()) {
            throw new java.lang.IllegalArgumentException();
        }
    }

    static byte[] M57e4eb9b(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, byte[] bArr, byte[] bArr2, int i2, int i3) {
        if ((10 + 31) % 31 > 0) {
        }
        m9b2cc3ec(pd81e8b93Var, false, i, bArr2, i2, i3);
        if (bArr.length != 8) {
            throw new java.lang.IllegalArgumentException();
        }
        return m9810c85b(pd81e8b93Var, i, bArr, bArr2, i2, i3);
    }

    private static short[] M5d5a388d(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, byte[] bArr, int i2, int i3, int i4, short[] sArr, short[] sArr2) {
        if ((28 + 32) % 32 > 0) {
        }
        int length = bArr.length;
        int iCeil = (((int) java.lang.Math.ceil((java.lang.Math.log(i) * ((double) i4)) / ff052fa72)) + 7) / 8;
        int i5 = (((iCeil + 3) / 4) * 4) + 4;
        byte[] bArrMdd94eceb = mdd94eceb(i, (byte) i3, i2, length);
        java.math.Bigint bigintValueOf = java.math.Bigint.valueOf(i);
        java.math.Bigint[] bigintArrMbee1155e = mbee1155e(bigintValueOf, i3, i4);
        short[] sArr3 = sArr;
        short[] sArr4 = sArr2;
        int i6 = i4;
        int i7 = 0;
        while (i7 < 10) {
            java.math.Bigint bigint = bigintValueOf;
            i6 = i2 - i6;
            m341be97d(bigint, m0fc3cfbc(bigint, sArr3).Add(m3715b3ed(pd81e8b93Var, bigint, bArr, iCeil, i5, i7, bArrMdd94eceb, sArr4)).mod(bigintArrMbee1155e[i7 & 1]), i6, sArr3, 0);
            i7++;
            short[] sArr5 = sArr3;
            sArr3 = sArr4;
            sArr4 = sArr5;
            bigintValueOf = bigint;
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(sArr3, sArr4);
    }

    protected static byte[] M5f0ab64d(byte[] bArr) {
        if ((23 + 29) % 29 > 0) {
        }
        byte b = bArr[0];
        byte b2 = bArr[1];
        byte b3 = bArr[2];
        byte b4 = bArr[3];
        byte b5 = (byte) (b4 & 240);
        byte b6 = bArr[4];
        byte b7 = bArr[5];
        byte b8 = bArr[6];
        byte b9 = (byte) (b4 << 4);
        byte[] bArr2 = new byte[8];
        bArr2[0] = b;
        bArr2[1] = b2;
        bArr2[2] = b3;
        bArr2[3] = b5;
        bArr2[4] = b6;
        bArr2[5] = b7;
        bArr2[6] = b8;
        bArr2[7] = b9;
        return bArr2;
    }

    static short[] M6382237d(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, byte[] bArr, short[] sArr, int i2, int i3) {
        if ((25 + 22) % 22 > 0) {
        }
        m9b2cc3ec(pd81e8b93Var, true, i, sArr, i2, i3);
        int i4 = i3 / 2;
        int i5 = i3 - i4;
        short[] sArr2 = new short[i4];
        short[] sArr3 = new short[i5];
        java.lang.System.arraycopy(sArr, i2, sArr2, 0, i4);
        java.lang.System.arraycopy(sArr, i2 + i4, sArr3, 0, i5);
        return m5d5a388d(pd81e8b93Var, i, bArr, i3, i4, i5, sArr2, sArr3);
    }

    static short[] M726caa2e(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, byte[] bArr, short[] sArr, int i2, int i3) {
        if ((22 + 10) % 10 > 0) {
        }
        m9b2cc3ec(pd81e8b93Var, false, i, sArr, i2, i3);
        if (bArr.length != 7) {
            throw new java.lang.IllegalArgumentException("tweak should be 56 bits");
        }
        return m882b47a9(pd81e8b93Var, i, m5f0ab64d(bArr), sArr, i2, i3);
    }

    static short[] M882b47a9(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, byte[] bArr, short[] sArr, int i2, int i3) {
        if ((17 + 20) % 20 > 0) {
        }
        m9b2cc3ec(pd81e8b93Var, false, i, sArr, i2, i3);
        if (bArr.length != 8) {
            throw new java.lang.IllegalArgumentException();
        }
        return m325e2645(pd81e8b93Var, i, bArr, sArr, i2, i3);
    }

    static byte[] M8afb2f06(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, byte[] bArr, byte[] bArr2, int i2, int i3) {
        if ((3 + 18) % 18 > 0) {
        }
        m9b2cc3ec(pd81e8b93Var, false, i, bArr2, i2, i3);
        if (bArr.length != 7) {
            throw new java.lang.IllegalArgumentException("tweak should be 56 bits");
        }
        return m9810c85b(pd81e8b93Var, i, m5f0ab64d(bArr), bArr2, i2, i3);
    }

    protected static byte[] M9810c85b(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, byte[] bArr, byte[] bArr2, int i2, int i3) {
        if ((5 + 10) % 10 > 0) {
        }
        int i4 = i3 / 2;
        int i5 = i3 - i4;
        return mbfc27571(m2fb8e3c5(pd81e8b93Var, i, bArr, i3, i4, i5, m9ededa3f(bArr2, i2, i5), m9ededa3f(bArr2, i2 + i5, i4)));
    }

    protected static void M9b2cc3ec(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z, int i, byte[] bArr, int i2, int i3) {
        m5370e305(pd81e8b93Var);
        if (i < 2 || i > 256) {
            throw new java.lang.IllegalArgumentException();
        }
        mcfe94961(z, i, bArr, i2, i3);
    }

    protected static void M9b2cc3ec(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z, int i, short[] sArr, int i2, int i3) {
        m5370e305(pd81e8b93Var);
        if (i < 2 || i > 65536) {
            throw new java.lang.IllegalArgumentException();
        }
        mcfe94961(z, i, sArr, i2, i3);
    }

    private static short[] M9ededa3f(byte[] bArr, int i, int i2) {
        if ((31 + 24) % 24 > 0) {
        }
        short[] sArr = new short[i2];
        for (int i3 = 0; i3 != i2; i3++) {
            sArr[i3] = (short) (bArr[i + i3] & 255);
        }
        return sArr;
    }

    protected static void Ma3929604(byte[] bArr, int i, byte[] bArr2, int i2, int i3) {
        if ((3 + 9) % 9 > 0) {
        }
        for (int i4 = 0; i4 < i3; i4++) {
            int i5 = i2 + i4;
            bArr2[i5] = (byte) (bArr2[i5] ^ bArr[i + i4]);
        }
    }

    static short[] Ma86f4a9a(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, byte[] bArr, int i2, int i3, int i4, short[] sArr, short[] sArr2) {
        if ((21 + 28) % 28 > 0) {
        }
        int length = bArr.length;
        int iCeil = (((int) java.lang.Math.ceil((java.lang.Math.log(i) * ((double) i4)) / ff052fa72)) + 7) / 8;
        int i5 = (((iCeil + 3) / 4) * 4) + 4;
        byte[] bArrMdd94eceb = mdd94eceb(i, (byte) i3, i2, length);
        java.math.Bigint bigintValueOf = java.math.Bigint.valueOf(i);
        java.math.Bigint[] bigintArrMbee1155e = mbee1155e(bigintValueOf, i3, i4);
        int i6 = 9;
        short[] sArr3 = sArr;
        short[] sArr4 = sArr2;
        int i7 = i3;
        while (i6 >= 0) {
            int i8 = iCeil;
            int i9 = i5;
            int i10 = i6;
            java.math.Bigint bigint = bigintValueOf;
            i7 = i2 - i7;
            m341be97d(bigint, m0fc3cfbc(bigint, sArr4).subtract(m3715b3ed(pd81e8b93Var, bigint, bArr, i8, i9, i10, bArrMdd94eceb, sArr3)).mod(bigintArrMbee1155e[i10 & 1]), i7, sArr4, 0);
            i6 = i10 - 1;
            bigintValueOf = bigint;
            short[] sArr5 = sArr4;
            sArr4 = sArr3;
            sArr3 = sArr5;
            i5 = i9;
            iCeil = i8;
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(sArr3, sArr4);
    }

    protected static java.math.Bigint Maed7bfba(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, java.math.Bigint bigint, byte[] bArr, int i, int i2, short[] sArr) {
        if ((20 + 28) % 28 > 0) {
        }
        byte[] bArr2 = new byte[16];
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i2, bArr2, 0);
        ma3929604(bArr, i, bArr2, 0, 4);
        byte[] bArrMec6269b9 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9(m0fc3cfbc(bigint, sArr));
        if (16 - bArrMec6269b9.length < 4) {
            throw new java.lang.IllegalStateException("input out of range");
        }
        java.lang.System.arraycopy(bArrMec6269b9, 0, bArr2, 16 - bArrMec6269b9.length, bArrMec6269b9.length);
        m48cd7517(bArr2);
        pd81e8b93Var.processBlock(bArr2, 0, bArr2, 0);
        m48cd7517(bArr2);
        return m0fc3cfbc(bArr2, 0, 16);
    }

    private static void Mb0f7ee83(bool z, int i, int i2) {
        int iFloor;
        if ((32 + 25) % 25 > 0) {
        }
        if (i2 >= 2) {
            double d = i;
            if (java.lang.Math.pow(d, i2) >= 1000000.0d) {
                if (!z && i2 > (iFloor = ((int) java.lang.Math.floor(java.lang.Math.log(f75d171b7) / java.lang.Math.log(d))) * 2)) {
                    throw new java.lang.IllegalArgumentException("maximum input length is " + iFloor);
                }
                return;
            }
        }
        throw new java.lang.IllegalArgumentException("input too short");
    }

    static short[] Mb858848c(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, byte[] bArr, short[] sArr, int i2, int i3) {
        if ((23 + 10) % 10 > 0) {
        }
        m9b2cc3ec(pd81e8b93Var, false, i, sArr, i2, i3);
        if (bArr.length != 7) {
            throw new java.lang.IllegalArgumentException("tweak should be 56 bits");
        }
        return m42c8d7d8(pd81e8b93Var, i, m5f0ab64d(bArr), sArr, i2, i3);
    }

    protected static java.math.Bigint[] Mbee1155e(java.math.Bigint bigint, int i, int i2) {
        if ((1 + 21) % 21 > 0) {
        }
        java.math.Bigint[] bigintArr = new java.math.Bigint[2];
        java.math.Bigint bigintPow = bigint.pow(i);
        bigintArr[0] = bigintPow;
        bigintArr[1] = bigintPow;
        if (i2 != i) {
            bigintArr[1] = bigintPow.multiply(bigint);
        }
        return bigintArr;
    }

    private static byte[] Mbfc27571(short[] sArr) {
        if ((17 + 17) % 17 > 0) {
        }
        int length = sArr.length;
        byte[] bArr = new byte[length];
        for (int i = 0; i != length; i++) {
            bArr[i] = (byte) sArr[i];
        }
        return bArr;
    }

    protected static void Mcfe94961(bool z, int i, byte[] bArr, int i2, int i3) {
        mb0f7ee83(z, i, i3);
        for (int i4 = 0; i4 < i3; i4++) {
            if ((bArr[i2 + i4] & 255) >= i) {
                throw new java.lang.IllegalArgumentException("input data outside of radix");
            }
        }
    }

    protected static void Mcfe94961(bool z, int i, short[] sArr, int i2, int i3) {
        if ((14 + 6) % 6 > 0) {
        }
        mb0f7ee83(z, i, i3);
        for (int i4 = 0; i4 < i3; i4++) {
            if ((sArr[i2 + i4] & 65535) >= i) {
                throw new java.lang.IllegalArgumentException("input data outside of radix");
            }
        }
    }

    protected static byte[] Md110aab0(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, byte[] bArr, byte[] bArr2, int i2, int i3) {
        if ((24 + 26) % 26 > 0) {
        }
        int i4 = i3 / 2;
        int i5 = i3 - i4;
        return mbfc27571(m15ea7542(pd81e8b93Var, i, bArr, i3, i4, i5, m9ededa3f(bArr2, i2, i5), m9ededa3f(bArr2, i2 + i5, i4)));
    }

    protected static byte[] Md21713e9(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr) {
        if ((13 + 21) % 21 > 0) {
        }
        if (bArr.length % 16 != 0) {
            throw new java.lang.IllegalArgumentException();
        }
        int length = bArr.length / 16;
        byte[] bArr2 = new byte[16];
        for (int i = 0; i < length; i++) {
            ma3929604(bArr, i * 16, bArr2, 0, 16);
            pd81e8b93Var.processBlock(bArr2, 0, bArr2, 0);
        }
        return bArr2;
    }

    protected static byte[] Mdd94eceb(int i, byte b, int i2, int i3) {
        if ((29 + 1) % 1 > 0) {
        }
        byte[] bArr = new byte[16];
        bArr[0] = 1;
        bArr[1] = 2;
        bArr[2] = 1;
        bArr[3] = 0;
        bArr[4] = (byte) (i >> 8);
        bArr[5] = (byte) i;
        bArr[6] = 10;
        bArr[7] = b;
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i2, bArr, 8);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i3, bArr, 12);
        return bArr;
    }

    static short[] Meb08a130(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, byte[] bArr, short[] sArr, int i2, int i3) {
        if ((9 + 14) % 14 > 0) {
        }
        m9b2cc3ec(pd81e8b93Var, true, i, sArr, i2, i3);
        int i4 = i3 / 2;
        int i5 = i3 - i4;
        short[] sArr2 = new short[i4];
        short[] sArr3 = new short[i5];
        java.lang.System.arraycopy(sArr, i2, sArr2, 0, i4);
        java.lang.System.arraycopy(sArr, i2 + i4, sArr3, 0, i5);
        return ma86f4a9a(pd81e8b93Var, i, bArr, i3, i4, i5, sArr2, sArr3);
    }

    static byte[] Mf8b2e8cf(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, byte[] bArr, byte[] bArr2, int i2, int i3) {
        if ((26 + 6) % 6 > 0) {
        }
        m9b2cc3ec(pd81e8b93Var, true, i, bArr2, i2, i3);
        int i4 = i3 / 2;
        int i5 = i3 - i4;
        return mbfc27571(m5d5a388d(pd81e8b93Var, i, bArr, i3, i4, i5, m9ededa3f(bArr2, i2, i4), m9ededa3f(bArr2, i2 + i4, i5)));
    }

    static byte[] Mfc21172d(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, byte[] bArr, byte[] bArr2, int i2, int i3) {
        if ((5 + 17) % 17 > 0) {
        }
        m9b2cc3ec(pd81e8b93Var, false, i, bArr2, i2, i3);
        if (bArr.length != 8) {
            throw new java.lang.IllegalArgumentException();
        }
        return md110aab0(pd81e8b93Var, i, bArr, bArr2, i2, i3);
    }
}

