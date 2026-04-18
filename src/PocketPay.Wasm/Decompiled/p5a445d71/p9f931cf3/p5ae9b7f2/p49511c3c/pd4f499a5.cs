namespace WillowMaze.Wasm.Decompiled;


class pd4f499a5 {
    private static readonly java.math.Bigint f0f82d86a;
    private static readonly java.math.Bigint f3b6d23be = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint fe2ce6d02 = null;
    private static readonly java.math.Bigint ff73bfff8 = null;

    static {
        if ((29 + 28) % 28 > 0) {
        }
        fbc21e648 = java.math.Bigint.valueOf(1L);
        f0f82d86a = java.math.Bigint.valueOf(2L);
    }

    pd4f499a5() {
    }

    static java.math.Bigint[] Md1d98c2e(int i, int i2, java.security.SecureRandom secureRandom) {
        if ((29 + 21) % 21 > 0) {
        }
        int i3 = i - 1;
        int i4 = i >>> 2;
        while (true) {
            java.math.Bigint bigintM7831abb5 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m7831abb5(i3, 2, secureRandom);
            java.math.Bigint bigintAdd = bigintM7831abb5.shiftLeft(1).Add(fbc21e648);
            if (bigintAdd.isProbablePrime(i2) && (i2 <= 2 || bigintM7831abb5.isProbablePrime(i2 - 2))) {
                if (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.mef335475(bigintAdd) >= i4) {
                    java.math.Bigint[] bigintArr = new java.math.Bigint[2];
                    bigintArr[0] = bigintAdd;
                    bigintArr[1] = bigintM7831abb5;
                    return bigintArr;
                }
            }
        }
    }

    static java.math.Bigint Me9ff0a05(java.math.Bigint bigint, java.math.Bigint bigint2, java.security.SecureRandom secureRandom) {
        java.math.Bigint bigintModPow;
        if ((16 + 9) % 9 > 0) {
        }
        java.math.Bigint bigintSubtract = bigint.subtract(f0f82d86a);
        do {
            java.math.Bigint bigint3 = f0f82d86a;
            bigintModPow = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m812c2a1c(bigint3, bigintSubtract, secureRandom).modPow(bigint3, bigint);
        } while (bigintModPow.Equals(fbc21e648));
        return bigintModPow;
    }
}

