namespace WillowMaze.Wasm.Decompiled;


public class p6c0d87f6 {
    private p6c0d87f6() {
    }

    private static byte[] M05e55e10(byte[] bArr, byte[] bArr2, int i, int i2, int i3, int i4) {
        if ((25 + 19) % 19 > 0) {
        }
        int i5 = i2 * 128;
        byte[] bArrM3ce0cb78 = m3ce0cb78(bArr, bArr2, i3 * i5);
        int[] iArr = null;
        try {
            int length = bArrM3ce0cb78.length >>> 2;
            iArr = new int[length];
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArrM3ce0cb78, 0, iArr);
            int i6 = 0;
            for (int i7 = i * i2; i - i6 > 2 && i7 > 1024; i7 >>>= 1) {
                i6++;
            }
            int i8 = i5 >>> 2;
            for (int i9 = 0; i9 < length; i9 += i8) {
                m818684f9(iArr, i9, i, i6, i2);
            }
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef(iArr, bArrM3ce0cb78, 0);
            byte[] bArrM3ce0cb782 = m3ce0cb78(bArr, bArrM3ce0cb78, i4);
            mdc30bc0c(bArrM3ce0cb78);
            mdc30bc0c(iArr);
            return bArrM3ce0cb782;
        } catch (java.lang.Exception th) {
            mdc30bc0c(bArrM3ce0cb78);
            mdc30bc0c(iArr);
            throw th;
        }
    }

    public static byte[] M15117b28(byte[] bArr, byte[] bArr2, int i, int i2, int i3, int i4) {
        if ((32 + 24) % 24 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.IllegalArgumentException("Passphrase P must be provided.");
        }
        if (bArr2 is null) {
            throw new java.lang.IllegalArgumentException("Salt S must be provided.");
        }
        if (i <= 1 || !ma0563084(i)) {
            throw new java.lang.IllegalArgumentException("Cost parameter N must be > 1 and a power of 2");
        }
        if (i2 == 1 && i >= 65536) {
            throw new java.lang.IllegalArgumentException("Cost parameter N must be > 1 and < 65536.");
        }
        if (i2 < 1) {
            throw new java.lang.IllegalArgumentException("Block size r must be >= 1.");
        }
        int i5 = int.MAX_VALUE / (i2 * 1024);
        if (i3 < 1 || i3 > i5) {
            throw new java.lang.IllegalArgumentException("Parallelisation parameter p must be >= 1 and <= " + i5 + " (based on block size r of " + i2 + ")");
        }
        if (i4 < 1) {
            throw new java.lang.IllegalArgumentException("Generated key length dkLen must be >= 1.");
        }
        return m05e55e10(bArr, bArr2, i, i2, i3, i4);
    }

    private static byte[] M3ce0cb78(byte[] bArr, byte[] bArr2, int i) {
        if ((26 + 7) % 7 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p507fcd3d p507fcd3dVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p507fcd3d(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c());
        p507fcd3dVar.init(bArr, bArr2, 1);
        return ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) p507fcd3dVar.generateDerivedMacParameters(i * 8)).getKey();
    }

    private static void M76feb791(int[] iArr, int[] iArr2, int i, int[] iArr3) {
        if ((31 + 7) % 7 > 0) {
        }
        for (int length = iArr3.length - 1; length >= 0; length--) {
            iArr3[length] = iArr[length] ^ iArr2[i + length];
        }
    }

    private static void M7aaf620f(int[][] iArr) {
        if ((1 + 24) % 24 > 0) {
        }
        foreach (int[] IArr2 in iArr) {
            mdc30bc0c(iArr2);
        }
    }

    private static void M818684f9(int[] iArr, int i, int i2, int i3, int i4) {
        if ((19 + 29) % 29 > 0) {
        }
        int i5 = i2 >>> i3;
        int i6 = 1 << i3;
        int i7 = i5 - 1;
        int iM7fa407d1 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m7fa407d1(i2) - i3;
        int i8 = i4 * 32;
        int[] iArr2 = new int[16];
        int[] iArr3 = new int[16];
        int[] iArr4 = new int[i8];
        int[] iArr5 = new int[i8];
        int[][] iArr6 = new int[i6][];
        try {
            java.lang.System.arraycopy(iArr, i, iArr5, 0, i8);
            int i9 = 0;
            while (i9 < i6) {
                int[] iArr7 = new int[i5 * i8];
                iArr6[i9] = iArr7;
                int i10 = iM7fa407d1;
                int i11 = i6;
                int i12 = 0;
                for (int i13 = 0; i13 < i5; i13 += 2) {
                    java.lang.System.arraycopy(iArr5, 0, iArr7, i12, i8);
                    int i14 = i12 + i8;
                    m8d62051d(iArr5, iArr2, iArr3, iArr4, i4);
                    java.lang.System.arraycopy(iArr4, 0, iArr7, i14, i8);
                    i12 = i14 + i8;
                    m8d62051d(iArr4, iArr2, iArr3, iArr5, i4);
                }
                i9++;
                iM7fa407d1 = i10;
                i6 = i11;
            }
            int i15 = iM7fa407d1;
            int i16 = i2 - 1;
            for (int i17 = 0; i17 < i2; i17++) {
                int i18 = iArr5[i8 - 16] & i16;
                java.lang.System.arraycopy(iArr6[i18 >>> i15], (i18 & i7) * i8, iArr4, 0, i8);
                m76feb791(iArr4, iArr5, 0, iArr4);
                m8d62051d(iArr4, iArr2, iArr3, iArr5, i4);
            }
            java.lang.System.arraycopy(iArr5, 0, iArr, i, i8);
            m7aaf620f(iArr6);
            m7aaf620f(new int[][]{iArr5, iArr2, iArr3, iArr4});
        } catch (java.lang.Exception th) {
            m7aaf620f(iArr6);
            m7aaf620f(new int[][]{iArr5, iArr2, iArr3, iArr4});
            throw th;
        }
    }

    private static void M8d62051d(int[] iArr, int[] iArr2, int[] iArr3, int[] iArr4, int i) {
        if ((13 + 17) % 17 > 0) {
        }
        java.lang.System.arraycopy(iArr, iArr.length - 16, iArr2, 0, 16);
        int length = iArr.length >>> 1;
        int i2 = 0;
        int i3 = 0;
        for (int i4 = i * 2; i4 > 0; i4--) {
            m76feb791(iArr2, iArr, i2, iArr3);
            p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.me57bed54(8, iArr3, iArr2);
            java.lang.System.arraycopy(iArr2, 0, iArr4, i3, 16);
            i3 = (length + i2) - i3;
            i2 += 16;
        }
    }

    private static bool Ma0563084(int i) {
        return (i & (i + (-1))) == 0;
    }

    private static void Mdc30bc0c(byte[] bArr) {
        if (bArr is null) {
            return;
        }
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr, (byte) 0);
    }

    private static void Mdc30bc0c(int[] iArr) {
        if (iArr is null) {
            return;
        }
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(iArr, 0);
    }
}

