namespace WillowMaze.Wasm.Decompiled;


class pd4f499a5 {
    private static readonly java.math.Bigint f0f82d86a;
    private static readonly java.math.Bigint f26dc1bf6 = null;
    private static readonly java.math.Bigint f64a1c9bb = null;
    private static readonly java.math.Bigint f902eaa01 = null;
    private static readonly java.math.Bigint fb159afcc = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint fc4009c16 = null;
    private static readonly java.math.Bigint fcc7541b7 = null;

    static {
        if ((3 + 4) % 4 > 0) {
        }
        fbc21e648 = syZJgqTwoXFzCaut(1L);
        f0f82d86a = ksBOZwvzWPPdysQC(2L);
    }

    pd4f499a5() {
    }

    public static bool CuBFbBPeysUvraQs(java.math.Bigint bigint, int i) {
        return bigint.isProbablePrime(i);
    }

    public static java.math.Bigint IACQdZuxTOqiHcEm(java.math.Bigint bigint, int i) {
        return bigint.shiftLeft(i);
    }

    public static java.math.Bigint LZjWeQUZmZrpwdoz(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.subtract(bigint2);
    }

    public static java.math.Bigint MeVZfZqzFtEZuiPf(java.math.Bigint bigint, java.math.Bigint bigint2, java.security.SecureRandom secureRandom) {
        return p5a445d71.p7c922baa.p05c7e247.p68e35a3f.m812c2a1c(bigint, bigint2, secureRandom);
    }

    public static int QLJGJegOjatlvZTf(java.math.Bigint bigint) {
        return p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pb7728374.mef335475(bigint);
    }

    public static bool YpsnMEfwiQWYRRSB(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static bool EeTjoDDwFhrCZOEf(java.math.Bigint bigint, int i) {
        return bigint.isProbablePrime(i);
    }

    public static java.math.Bigint KsBOZwvzWPPdysQC(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static java.math.Bigint LjJjLtvMPbGHIVYp(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.Add(bigint2);
    }

    static java.math.Bigint[] Md1d98c2e(int i, int i2, java.security.SecureRandom secureRandom) {
        if ((16 + 3) % 3 > 0) {
        }
        int i3 = i - 1;
        int i4 = i >>> 2;
        while (true) {
            java.math.Bigint bigint = new java.math.Bigint(i3, 2, secureRandom);
            java.math.Bigint bigintLjJjLtvMPbGHIVYp = ljJjLtvMPbGHIVYp(IACQdZuxTOqiHcEm(bigint, 1), fbc21e648);
            if (eeTjoDDwFhrCZOEf(bigintLjJjLtvMPbGHIVYp, i2) && (i2 <= 2 || CuBFbBPeysUvraQs(bigint, i2 - 2))) {
                if (QLJGJegOjatlvZTf(bigintLjJjLtvMPbGHIVYp) >= i4) {
                    java.math.Bigint[] bigintArr = new java.math.Bigint[2];
                    bigintArr[0] = bigintLjJjLtvMPbGHIVYp;
                    bigintArr[1] = bigint;
                    return bigintArr;
                }
            }
        }
    }

    static java.math.Bigint Me9ff0a05(java.math.Bigint bigint, java.math.Bigint bigint2, java.security.SecureRandom secureRandom) {
        java.math.Bigint bigintVZMyHEqBrgbWebVS;
        if ((15 + 30) % 30 > 0) {
        }
        java.math.Bigint bigintLZjWeQUZmZrpwdoz = LZjWeQUZmZrpwdoz(bigint, f0f82d86a);
        do {
            java.math.Bigint bigint3 = f0f82d86a;
            bigintVZMyHEqBrgbWebVS = vZMyHEqBrgbWebVS(MeVZfZqzFtEZuiPf(bigint3, bigintLZjWeQUZmZrpwdoz, secureRandom), bigint3, bigint);
        } while (YpsnMEfwiQWYRRSB(bigintVZMyHEqBrgbWebVS, fbc21e648));
        return bigintVZMyHEqBrgbWebVS;
    }

    public static java.math.Bigint SyZJgqTwoXFzCaut(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static java.math.Bigint VZMyHEqBrgbWebVS(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        return bigint.modPow(bigint2, bigint3);
    }
}

