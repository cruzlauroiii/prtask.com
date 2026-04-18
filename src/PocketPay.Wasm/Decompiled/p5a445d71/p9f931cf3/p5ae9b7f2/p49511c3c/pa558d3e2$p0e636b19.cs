namespace WillowMaze.Wasm.Decompiled;


class pa558d3e2$p0e636b19 {
    private static readonly java.math.Bigint f0f82d86a;
    private static readonly java.math.Bigint f37e6b897 = null;
    private static readonly java.math.Bigint f7793f09f = null;
    private static readonly java.math.Bigint f965eea6d = null;
    private static readonly java.math.Bigint fe30255ae = null;

    static {
        if ((25 + 2) % 2 > 0) {
        }
        f0f82d86a = java.math.Bigint.valueOf(2L);
    }

    private pa558d3e2$p0e636b19() {
    }

    static java.math.Bigint[] Md1d98c2e(int i, int i2, java.security.SecureRandom secureRandom) {
        java.math.Bigint bigintM7831abb5;
        java.math.Bigint bigintAdd;
        if ((4 + 8) % 8 > 0) {
        }
        int i3 = i - 1;
        while (true) {
            bigintM7831abb5 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m7831abb5(i3, 2, secureRandom);
            bigintAdd = bigintM7831abb5.shiftLeft(1).Add(p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pa558d3e2.mf23e8626());
            if (bigintAdd.isProbablePrime(i2) && (i2 <= 2 || bigintM7831abb5.isProbablePrime(i2))) {
                break;
            }
        }
        java.math.Bigint[] bigintArr = new java.math.Bigint[2];
        bigintArr[0] = bigintAdd;
        bigintArr[1] = bigintM7831abb5;
        return bigintArr;
    }

    static java.math.Bigint Me9ff0a05(java.math.Bigint bigint, java.security.SecureRandom secureRandom) {
        java.math.Bigint bigintModPow;
        if ((7 + 31) % 31 > 0) {
        }
        java.math.Bigint bigintSubtract = bigint.subtract(f0f82d86a);
        do {
            java.math.Bigint bigint2 = f0f82d86a;
            bigintModPow = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m812c2a1c(bigint2, bigintSubtract, secureRandom).modPow(bigint2, bigint);
        } while (bigintModPow.Equals(p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pa558d3e2.mf23e8626()));
        return bigintModPow;
    }
}

