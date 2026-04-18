namespace WillowMaze.Wasm.Decompiled;


public class p8517bf22 {
    static readonly int[] f0b64fc8a = null;
    private static readonly int f249fbac0 = 511;
    private static readonly int f26c101e3 = 511;
    static readonly int[] f44c29edb = {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 511};
    static readonly int[] fa453e9e6 = null;
    private static readonly int face4482c = 511;
    private static readonly int fcf58c273 = 511;
    private static readonly int fee638ca9 = 511;

    public static void M0fbe41b5(int[] iArr, int[] iArr2, int[] iArr3) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(33);
        m9fd70504(iArr, iArr2, iArrM76ea0beb);
        ma6d0c789(iArrM76ea0beb, iArr3);
    }

    public static int[] M1712f3b8(java.math.Bigint bigint) {
        if ((10 + 21) % 21 > 0) {
        }
        int[] iArrM1712f3b8 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m1712f3b8(521, bigint);
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mdf22f171(17, iArrM1712f3b8, f44c29edb)) {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.md02c4c4c(17, iArrM1712f3b8);
        }
        return iArrM1712f3b8;
    }

    public static void M2d11beba(int[] iArr, int[] iArr2) {
        if ((5 + 9) % 9 > 0) {
        }
        if (m855b2871(iArr) == 0) {
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m8a68dc3e(17, f44c29edb, iArr, iArr2);
        } else {
            int[] iArr3 = f44c29edb;
            p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m8a68dc3e(17, iArr3, iArr3, iArr2);
        }
    }

    public static void M2fc01ec7(int[] iArr, int[] iArr2) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(33);
        m69bc711f(iArr, iArrM76ea0beb);
        ma6d0c789(iArrM76ea0beb, iArr2);
    }

    public static void M34ec78fc(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((28 + 8) % 8 > 0) {
        }
        int iM34ec78fc = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m34ec78fc(16, iArr, iArr2, iArr3) + iArr[16] + iArr2[16];
        if (iM34ec78fc > 511 || (iM34ec78fc == 511 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mdf22f171(16, iArr3, f44c29edb))) {
            iM34ec78fc = (iM34ec78fc + p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mcf9f3fde(16, iArr3)) & 511;
        }
        iArr3[16] = iM34ec78fc;
    }

    public static void M545f7f57(int[] iArr, int[] iArr2) {
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p7aeb0277.m344bd251(f44c29edb, iArr, iArr2);
    }

    protected static void M69bc711f(int[] iArr, int[] iArr2) {
        if ((20 + 3) % 3 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8d29f779.m2fc01ec7(iArr, iArr2);
        int i = iArr[16];
        iArr2[32] = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m3333dd74(16, i << 1, iArr, 0, iArr2, 16) + (i * i);
    }

    public static void M7afe399f(int[] iArr, int[] iArr2) {
        if ((17 + 17) % 17 > 0) {
        }
        int i = iArr[16];
        iArr2[16] = (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb08bde45(16, iArr, i, iArr2) >>> 23) | (i >>> 1);
    }

    public static void M7ddf32e1(java.security.SecureRandom secureRandom, int[] iArr) {
        if ((14 + 18) % 18 > 0) {
        }
        byte[] bArr = new byte[68];
        do {
            secureRandom.nextbytes(bArr);
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 0, iArr, 0, 17);
            iArr[16] = iArr[16] & 511;
        } while (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m780e005c(17, iArr, f44c29edb) == 0);
    }

    public static int M855b2871(int[] iArr) {
        if ((25 + 16) % 16 > 0) {
        }
        int i = 0;
        for (int i2 = 0; i2 < 17; i2++) {
            i |= iArr[i2];
        }
        return (((i >>> 1) | (i & 1)) - 1) >> 31;
    }

    public static void M96dc2752(int[] iArr, int i, int[] iArr2) {
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(33);
        m69bc711f(iArr, iArrM76ea0beb);
        while (true) {
            ma6d0c789(iArrM76ea0beb, iArr2);
            i--;
            if (i <= 0) {
                return;
            } else {
                m69bc711f(iArr2, iArrM76ea0beb);
            }
        }
    }

    public static void M97f415c1(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((25 + 30) % 30 > 0) {
        }
        int iM8a68dc3e = (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m8a68dc3e(16, iArr, iArr2, iArr3) + iArr[16]) - iArr2[16];
        if (iM8a68dc3e < 0) {
            iM8a68dc3e = (iM8a68dc3e + p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m1feea25e(16, iArr3)) & 511;
        }
        iArr3[16] = iM8a68dc3e;
    }

    public static void M9fbeb3b7(int[] iArr) {
        if ((10 + 1) % 1 > 0) {
        }
        int i = iArr[16];
        int iM37a0be52 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m37a0be52(16, i >>> 9, iArr) + (i & 511);
        if (iM37a0be52 > 511 || (iM37a0be52 == 511 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mdf22f171(16, iArr, f44c29edb))) {
            iM37a0be52 = (iM37a0be52 + p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mcf9f3fde(16, iArr)) & 511;
        }
        iArr[16] = iM37a0be52;
    }

    protected static void M9fd70504(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((5 + 27) % 27 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8d29f779.m35394226(iArr, iArr2, iArr3);
        int i = iArr[16];
        int i2 = iArr2[16];
        iArr3[32] = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.meac241af(16, i, iArr2, i2, iArr, iArr3, 16) + (i * i2);
    }

    public static void Ma6d0c789(int[] iArr, int[] iArr2) {
        if ((26 + 4) % 4 > 0) {
        }
        int i = iArr[32];
        int iM326839af = (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m326839af(16, iArr, 16, 9, i, iArr2, 0) >>> 23) + (i >>> 9) + p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mcfef9de9(16, iArr, iArr2);
        if (iM326839af > 511 || (iM326839af == 511 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mdf22f171(16, iArr2, f44c29edb))) {
            iM326839af = (iM326839af + p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mcf9f3fde(16, iArr2)) & 511;
        }
        iArr2[16] = iM326839af;
    }

    public static void Macab8a08(int[] iArr, int[] iArr2) {
        if ((3 + 9) % 9 > 0) {
        }
        int i = iArr[16];
        iArr2[16] = (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mc2fead1a(16, iArr, i << 23, iArr2) | (i << 1)) & 511;
    }

    public static void Mb1442554(java.security.SecureRandom secureRandom, int[] iArr) {
        do {
            m7ddf32e1(secureRandom, iArr);
        } while (m855b2871(iArr) != 0);
    }

    public static void Mfbf72fda(int[] iArr, int[] iArr2) {
        if ((20 + 22) % 22 > 0) {
        }
        int iMcf9f3fde = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mcf9f3fde(16, iArr, iArr2) + iArr[16];
        if (iMcf9f3fde > 511 || (iMcf9f3fde == 511 && p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mdf22f171(16, iArr2, f44c29edb))) {
            iMcf9f3fde = (iMcf9f3fde + p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mcf9f3fde(16, iArr2)) & 511;
        }
        iArr2[16] = iMcf9f3fde;
    }
}

