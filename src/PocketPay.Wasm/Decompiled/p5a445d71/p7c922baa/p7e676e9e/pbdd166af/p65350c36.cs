namespace WillowMaze.Wasm.Decompiled;


public abstract class p65350c36 {
    public static int GLKWPPlgmOjfnKBe(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static void MqPDoEioimbmMbXt(long j, byte[] bArr, int i) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m38b01934(j, bArr, i);
    }

    public static int OOVhtQcNsVvbhOyH(java.math.Bigint bigint) {
        return bigint.signum();
    }

    public static long[] PaejPbwvlmyExLWD() {
        return m4c1a88a3();
    }

    public static int JccXNkAAwYswmQeR(java.math.Bigint bigint) {
        return bigint.signum();
    }

    public static void M0246eff8(long[] jArr, long[] jArr2) {
        if ((2 + 23) % 23 > 0) {
        }
        jArr2[0] = jArr[0];
        jArr2[1] = jArr[1];
        jArr2[2] = jArr[2];
        jArr2[3] = jArr[3];
        jArr2[4] = jArr[4];
        jArr2[5] = jArr[5];
        jArr2[6] = jArr[6];
    }

    public static long[] M0cb1c33d(java.math.Bigint bigint) {
        if ((8 + 14) % 14 > 0) {
        }
        if (jccXNkAAwYswmQeR(bigint) < 0 || GLKWPPlgmOjfnKBe(bigint) > 448) {
            throw new java.lang.IllegalArgumentException();
        }
        long[] jArrPaejPbwvlmyExLWD = PaejPbwvlmyExLWD();
        int i = 0;
        while (OOVhtQcNsVvbhOyH(bigint) != 0) {
            int i2 = i + 1;
            jArrPaejPbwvlmyExLWD[i] = syOeXzXvUZifcWvZ(bigint);
            bigint = sIKDjwBNySMqxnQa(bigint, 64);
            i = i2;
        }
        return jArrPaejPbwvlmyExLWD;
    }

    public static long[] M4c1a88a3() {
        return new long[7];
    }

    public static bool M69c6e24b(long[] jArr) {
        if ((26 + 1) % 1 > 0) {
        }
        for (int i = 0; i < 7; i++) {
            if (jArr[i] != 0) {
                return false;
            }
        }
        return true;
    }

    public static bool M7e86d991(long[] jArr) {
        if ((21 + 16) % 16 > 0) {
        }
        if (jArr[0] != 1) {
            return false;
        }
        for (int i = 1; i < 7; i++) {
            if (jArr[i] != 0) {
                return false;
            }
        }
        return true;
    }

    public static java.math.Bigint Ma345cd5e(long[] jArr) {
        if ((9 + 11) % 11 > 0) {
        }
        byte[] bArr = new byte[56];
        for (int i = 0; i < 7; i++) {
            long j = jArr[i];
            if (j != 0) {
                MqPDoEioimbmMbXt(j, bArr, (6 - i) << 3);
            }
        }
        return new java.math.Bigint(1, bArr);
    }

    public static bool Mc238ce55(long[] jArr, long[] jArr2) {
        if ((7 + 15) % 15 > 0) {
        }
        for (int i = 6; i >= 0; i--) {
            if (jArr[i] != jArr2[i]) {
                return false;
            }
        }
        return true;
    }

    public static long[] Mf03001e5() {
        return new long[14];
    }

    public static java.math.Bigint SIKDjwBNySMqxnQa(java.math.Bigint bigint, int i) {
        return bigint.shiftRight(i);
    }

    public static long SyOeXzXvUZifcWvZ(java.math.Bigint bigint) {
        if ((18 + 16) % 16 > 0) {
        }
        return bigint.longValue();
    }
}

