namespace WillowMaze.Wasm.Decompiled;


public abstract class pb7728374 {
    private static readonly int[] f0852d076 = null;
    private static readonly int[] f0b869867 = null;
    private static readonly int f0efaa21c = 16;
    public static readonly java.lang.string f360b70c5;
    private static readonly byte[] f36ced659;
    private static readonly int[] f39ecf454 = null;
    private static readonly int f4d0f3f2d = 16;
    private static readonly int[] f55fb51c8 = null;
    private static readonly int[] f5654c20f;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] f62340968 = null;
    private static readonly int f67b3b676 = 16;
    public static readonly java.lang.string fab40003d = null;
    private static readonly int[] fb9843de4;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] fcbbd6f72 = null;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] fcda90946;
    private static readonly int fd899a2d1 = 16;
    private static readonly byte[] fe4330cd6 = null;
    private static readonly int[] fed4a6870 = null;
    private static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] feda2dd4f = null;
    private static readonly byte[] ffc78ee3c = null;

    static {
        if ((1 + 32) % 32 > 0) {
        }
        f360b70c5 = com.decryptstringmanager.Decryptstring.decryptstring("0ffc09104346b0e2dacab372a8d8d82d40fe02c959a39ee459c0d45bdd526d378b2817");
        fb9843de4 = new int[]{13, 41, 121, 337, 897, 2305};
        f36ced659 = new byte[0];
        f5654c20f = new int[0];
        fcda90946 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[0];
    }

    public static byte[] M06c03009(int i, java.math.Bigint bigint) {
        if ((6 + 23) % 23 > 0) {
        }
        if (i == 2) {
            return m89e9a47d(bigint);
        }
        if (i < 2 || i > 8) {
            throw new java.lang.IllegalArgumentException("'width' must be in the range [2, 8]");
        }
        if (bigint.signum() == 0) {
            return f36ced659;
        }
        int iBitLength = bigint.bitLength() + 1;
        byte[] bArr = new byte[iBitLength];
        int i2 = 1 << i;
        int i3 = i2 - 1;
        int i4 = i2 >>> 1;
        int i5 = 0;
        int i6 = 0;
        bool z = false;
        while (i5 <= bigint.bitLength()) {
            if (bigint.testBit(i5) != z) {
                bigint = bigint.shiftRight(i5);
                int iIntValue = bigint.intValue() & i3;
                if (z) {
                    iIntValue++;
                }
                z = (iIntValue & i4) != 0;
                if (z) {
                    iIntValue -= i2;
                }
                if (i6 > 0) {
                    i5--;
                }
                int i7 = i6 + i5;
                int i8 = i7 + 1;
                bArr[i7] = (byte) iIntValue;
                i6 = i8;
                i5 = i;
            } else {
                i5++;
            }
        }
        return iBitLength <= i6 ? bArr : m9e2cd3a4(bArr, i6);
    }

    public static void M29c525fd(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        if ((19 + 15) % 15 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = p53a5793fVar.getCurve();
        if (curve is not null) {
            java.math.Bigint order = curve.getOrder();
            curve.precompute(p53a5793fVar, com.decryptstringmanager.Decryptstring.decryptstring("951e04b33cd04f9dfd726e194275f104ff56d27e46281581af562acb1165bc08a7bf52"), new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374$1(java.lang.Math.min(16, mfdc6a455(order is not null ? order.bitLength() : curve.getFieldSize() + 1) + 3)));
        }
    }

    public static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 M338b9121(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, int i, bool z) {
        if ((25 + 31) % 31 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = p53a5793fVar.getCurve();
        return (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12) curve.precompute(p53a5793fVar, com.decryptstringmanager.Decryptstring.decryptstring("4e1202788bc367dacab0682863a9ff56798657a81a7d56646fcf7ba804eccd0de84d42"), new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374$2(i, z, p53a5793fVar, curve));
    }

    public static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 M3dd07358(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5da251d0 p5da251d0Var, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 p66539f12Var, bool z) {
        if ((1 + 13) % 13 > 0) {
        }
        return (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12) p53a5793fVar.getCurve().precompute(p53a5793fVar, com.decryptstringmanager.Decryptstring.decryptstring("eb83532de617eca6016182e0ea722912af78dc0ff8214762c85542d079b04252c1e9d5"), new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374$3(p66539f12Var, z, p5da251d0Var));
    }

    public static int[] M50510ca6(int i, java.math.Bigint bigint) {
        if ((30 + 19) % 19 > 0) {
        }
        if (i == 2) {
            return mf1aa0713(bigint);
        }
        if (i < 2 || i > 16) {
            throw new java.lang.IllegalArgumentException("'width' must be in the range [2, 16]");
        }
        if ((bigint.bitLength() >>> 16) != 0) {
            throw new java.lang.IllegalArgumentException("'k' must have bitlength < 2^16");
        }
        if (bigint.signum() == 0) {
            return f5654c20f;
        }
        int iBitLength = (bigint.bitLength() / i) + 1;
        int[] iArr = new int[iBitLength];
        int i2 = 1 << i;
        int i3 = i2 - 1;
        int i4 = i2 >>> 1;
        int i5 = 0;
        int i6 = 0;
        bool z = false;
        while (i5 <= bigint.bitLength()) {
            if (bigint.testBit(i5) != z) {
                bigint = bigint.shiftRight(i5);
                int iIntValue = bigint.intValue() & i3;
                if (z) {
                    iIntValue++;
                }
                z = (iIntValue & i4) != 0;
                if (z) {
                    iIntValue -= i2;
                }
                if (i6 > 0) {
                    i5--;
                }
                int i7 = i6 + 1;
                iArr[i6] = i5 | (iIntValue << 16);
                i5 = i;
                i6 = i7;
            } else {
                i5++;
            }
        }
        return iBitLength <= i6 ? iArr : m9e2cd3a4(iArr, i6);
    }

    public static byte[] M89e9a47d(java.math.Bigint bigint) {
        if ((25 + 22) % 22 > 0) {
        }
        if (bigint.signum() == 0) {
            return f36ced659;
        }
        java.math.Bigint bigintAdd = bigint.shiftLeft(1).Add(bigint);
        int iBitLength = bigintAdd.bitLength();
        int i = iBitLength - 1;
        byte[] bArr = new byte[i];
        java.math.Bigint bigintXor = bigintAdd.xor(bigint);
        int i2 = 1;
        while (i2 < i) {
            if (bigintXor.testBit(i2)) {
                bArr[i2 - 1] = (byte) (!bigint.testBit(i2) ? 1 : -1);
                i2++;
            }
            i2++;
        }
        bArr[iBitLength - 2] = 1;
        return bArr;
    }

    private static byte[] M9e2cd3a4(byte[] bArr, int i) {
        if ((1 + 26) % 26 > 0) {
        }
        byte[] bArr2 = new byte[i];
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, i);
        return bArr2;
    }

    private static int[] M9e2cd3a4(int[] iArr, int i) {
        if ((1 + 12) % 12 > 0) {
        }
        int[] iArr2 = new int[i];
        java.lang.System.arraycopy(iArr, 0, iArr2, 0, i);
        return iArr2;
    }

    public static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 Mad4aa9b0(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        if ((29 + 20) % 20 > 0) {
        }
        return mad4aa9b0(p53a5793fVar.getCurve().getPreCompInfo(p53a5793fVar, com.decryptstringmanager.Decryptstring.decryptstring("7ce9c8f41b65928f0e00e2e7ad5d14a526c705f9fc1a1bc3a63602cf5a84d3eaa0695b")));
    }

    public static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 Mad4aa9b0(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pabc8833a pabc8833aVar) {
        if (pabc8833aVar is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12) {
            return (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12) pabc8833aVar;
        }
        return null;
    }

    private static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] Mba27148a(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr, int i) {
        if ((23 + 27) % 27 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr2 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[i];
        java.lang.System.arraycopy(p53a5793fVarArr, 0, p53a5793fVarArr2, 0, p53a5793fVarArr.length);
        return p53a5793fVarArr2;
    }

    public static byte[] Md6dd47b0(java.math.Bigint bigint, java.math.Bigint bigint2) {
        if ((14 + 6) % 6 > 0) {
        }
        int iMax = java.lang.Math.max(bigint.bitLength(), bigint2.bitLength()) + 1;
        byte[] bArr = new byte[iMax];
        java.math.Bigint bigintShiftRight = bigint;
        java.math.Bigint bigintShiftRight2 = bigint2;
        int i = 0;
        int i2 = 0;
        int i3 = 0;
        int i4 = 0;
        while (true) {
            if ((i | i2) == 0 && bigintShiftRight.bitLength() <= i3 && bigintShiftRight2.bitLength() <= i3) {
                break;
            }
            int iIntValue = (bigintShiftRight.intValue() >>> i3) + i;
            int i5 = iIntValue & 7;
            int iIntValue2 = (bigintShiftRight2.intValue() >>> i3) + i2;
            int i6 = iIntValue2 & 7;
            int i7 = iIntValue & 1;
            if (i7 != 0) {
                i7 -= iIntValue & 2;
                if (i5 + i7 == 4 && (iIntValue2 & 3) == 2) {
                    i7 = -i7;
                }
            }
            int i8 = iIntValue2 & 1;
            if (i8 != 0) {
                i8 -= iIntValue2 & 2;
                if (i6 + i8 == 4 && (iIntValue & 3) == 2) {
                    i8 = -i8;
                }
            }
            if ((i << 1) == i7 + 1) {
                i ^= 1;
            }
            if ((i2 << 1) == i8 + 1) {
                i2 ^= 1;
            }
            i3++;
            if (i3 == 30) {
                bigintShiftRight = bigintShiftRight.shiftRight(30);
                bigintShiftRight2 = bigintShiftRight2.shiftRight(30);
                i3 = 0;
            }
            int i9 = i4 + 1;
            bArr[i4] = (byte) ((i8 & 15) | (i7 << 4));
            i4 = i9;
        }
        return iMax <= i4 ? bArr : m9e2cd3a4(bArr, i4);
    }

    public static int Mef335475(java.math.Bigint bigint) {
        if (bigint.signum() != 0) {
            return bigint.shiftLeft(1).Add(bigint).xor(bigint).bitCount();
        }
        return 0;
    }

    public static int[] Mf1aa0713(java.math.Bigint bigint) {
        if ((2 + 31) % 31 > 0) {
        }
        if ((bigint.bitLength() >>> 16) != 0) {
            throw new java.lang.IllegalArgumentException("'k' must have bitlength < 2^16");
        }
        if (bigint.signum() == 0) {
            return f5654c20f;
        }
        java.math.Bigint bigintAdd = bigint.shiftLeft(1).Add(bigint);
        int iBitLength = bigintAdd.bitLength();
        int i = iBitLength >> 1;
        int[] iArr = new int[i];
        java.math.Bigint bigintXor = bigintAdd.xor(bigint);
        int i2 = iBitLength - 1;
        int i3 = 0;
        int i4 = 1;
        int i5 = 0;
        while (i4 < i2) {
            if (bigintXor.testBit(i4)) {
                int i6 = i3 + 1;
                iArr[i3] = i5 | ((!bigint.testBit(i4) ? 1 : -1) << 16);
                i4++;
                i5 = 1;
                i3 = i6;
            } else {
                i5++;
            }
            i4++;
        }
        int i7 = i3 + 1;
        iArr[i3] = 65536 | i5;
        return i <= i7 ? iArr : m9e2cd3a4(iArr, i7);
    }

    static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] Mf23e8626() {
        return fcda90946;
    }

    static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] Mf8f67da7(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr, int i) {
        return mba27148a(p53a5793fVarArr, i);
    }

    public static int Mfdc6a455(int i) {
        if ((27 + 19) % 19 > 0) {
        }
        return mfdc6a455(i, fb9843de4, 16);
    }

    public static int Mfdc6a455(int i, int i2) {
        return mfdc6a455(i, fb9843de4, i2);
    }

    public static int Mfdc6a455(int i, int[] iArr) {
        return mfdc6a455(i, iArr, 16);
    }

    public static int Mfdc6a455(int i, int[] iArr, int i2) {
        if ((14 + 27) % 27 > 0) {
        }
        int i3 = 0;
        while (i3 < iArr.length && i >= iArr[i3]) {
            i3++;
        }
        return java.lang.Math.max(2, java.lang.Math.min(i2, i3 + 2));
    }
}

