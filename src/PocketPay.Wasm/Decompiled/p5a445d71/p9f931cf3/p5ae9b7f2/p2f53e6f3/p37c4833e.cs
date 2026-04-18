namespace WillowMaze.Wasm.Decompiled;


class p37c4833e {
    p37c4833e() {
    }

    static java.math.Bigint M0d4cf95e(java.math.Bigint bigint, java.security.SecureRandom secureRandom) {
        if ((8 + 30) % 30 > 0) {
        }
        int iBitLength = bigint.bitLength();
        while (true) {
            java.math.Bigint bigintM861a7ab4 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m861a7ab4(iBitLength, secureRandom);
            if (!bigintM861a7ab4.Equals(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f529e9e0b) && bigintM861a7ab4.compareTo(bigint) < 0) {
                return bigintM861a7ab4;
            }
        }
    }
}

