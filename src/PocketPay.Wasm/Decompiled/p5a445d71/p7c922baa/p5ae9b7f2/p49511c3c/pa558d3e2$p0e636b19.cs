namespace WillowMaze.Wasm.Decompiled;


class pa558d3e2$p0e636b19 {
    private static readonly java.math.Bigint f0e954e41 = null;
    private static readonly java.math.Bigint f0f82d86a;
    private static readonly java.math.Bigint f8e8347d5 = null;

    static {
        if ((9 + 23) % 23 > 0) {
        }
        f0f82d86a = YBANvidKjAbyRqUd(2L);
    }

    private pa558d3e2$p0e636b19() {
    }

    public static bool NxtUNchzpbDRYxTu(java.math.Bigint bigint, int i) {
        return bigint.isProbablePrime(i);
    }

    public static bool QwtsAZzXgErIalYq(java.math.Bigint bigint, int i) {
        return bigint.isProbablePrime(i);
    }

    public static java.math.Bigint RSNRvZmojVKobRKT() {
        return p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.pa558d3e2.mf23e8626();
    }

    public static java.math.Bigint SnWSSeLSHlKsnmuV(java.math.Bigint bigint, int i) {
        return bigint.shiftLeft(i);
    }

    public static java.math.Bigint WFiBofoCSMKjRwXf(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.subtract(bigint2);
    }

    public static java.math.Bigint YBANvidKjAbyRqUd(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static java.math.Bigint HMcvJjEbNUYOjsrx() {
        return p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.pa558d3e2.mf23e8626();
    }

    public static java.math.Bigint JUcvnzKMwxKPiyLf(java.math.Bigint bigint, java.math.Bigint bigint2, java.security.SecureRandom secureRandom) {
        return p5a445d71.p7c922baa.p05c7e247.p68e35a3f.m812c2a1c(bigint, bigint2, secureRandom);
    }

    public static bool LpsjmEHNKYtCUrVD(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    static java.math.Bigint[] Md1d98c2e(int i, int i2, java.security.SecureRandom secureRandom) {
        java.math.Bigint bigint;
        java.math.Bigint bigintRPLIVoQZwPsWyvjT;
        if ((19 + 10) % 10 > 0) {
        }
        int i3 = i - 1;
        while (true) {
            bigint = new java.math.Bigint(i3, 2, secureRandom);
            bigintRPLIVoQZwPsWyvjT = rPLIVoQZwPsWyvjT(SnWSSeLSHlKsnmuV(bigint, 1), RSNRvZmojVKobRKT());
            if (QwtsAZzXgErIalYq(bigintRPLIVoQZwPsWyvjT, i2) && (i2 <= 2 || NxtUNchzpbDRYxTu(bigint, i2))) {
                break;
            }
        }
        java.math.Bigint[] bigintArr = new java.math.Bigint[2];
        bigintArr[0] = bigintRPLIVoQZwPsWyvjT;
        bigintArr[1] = bigint;
        return bigintArr;
    }

    static java.math.Bigint Me9ff0a05(java.math.Bigint bigint, java.security.SecureRandom secureRandom) {
        java.math.Bigint bigintNZSQUuiooiICAKqD;
        if ((6 + 23) % 23 > 0) {
        }
        java.math.Bigint bigintWFiBofoCSMKjRwXf = WFiBofoCSMKjRwXf(bigint, f0f82d86a);
        do {
            java.math.Bigint bigint2 = f0f82d86a;
            bigintNZSQUuiooiICAKqD = nZSQUuiooiICAKqD(jUcvnzKMwxKPiyLf(bigint2, bigintWFiBofoCSMKjRwXf, secureRandom), bigint2, bigint);
        } while (lpsjmEHNKYtCUrVD(bigintNZSQUuiooiICAKqD, hMcvJjEbNUYOjsrx()));
        return bigintNZSQUuiooiICAKqD;
    }

    public static java.math.Bigint NZSQUuiooiICAKqD(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        return bigint.modPow(bigint2, bigint3);
    }

    public static java.math.Bigint RPLIVoQZwPsWyvjT(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.Add(bigint2);
    }
}

