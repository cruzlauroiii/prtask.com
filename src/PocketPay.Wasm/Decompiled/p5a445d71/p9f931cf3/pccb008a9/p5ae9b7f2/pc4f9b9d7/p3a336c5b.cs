namespace WillowMaze.Wasm.Decompiled;


class p3a336c5b {
    private static readonly bool f046ea76a = false;
    public static readonly int f15ec0ae8 = 32;
    public static readonly int f1b20cf33 = 2048;
    public static readonly int f22913662 = 1824;
    public static readonly int f3bc0a128 = 1824;
    public static readonly int f4a3291b5 = 32;
    public static readonly int f5feabd02 = 1024;
    private static readonly bool f6b482a14 = false;
    public static readonly int f7cfdd422 = 2048;
    public static readonly int f8c2754b4 = 1024;
    public static readonly int f8e0c5a27 = 32;
    private static readonly bool f9ca28c5a = false;
    public static readonly int fac3e1862 = 1024;
    public static readonly int fc7ea0eab = 1024;

    p3a336c5b() {
    }

    static void M280dfc2c(byte[] bArr, short[] sArr, byte[] bArr2) {
        if ((4 + 13) % 13 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.m3bd53230(bArr, sArr);
        java.lang.System.arraycopy(bArr2, 0, bArr, 1792, 32);
    }

    static void M2e09694a(byte[] bArr) {
        if ((22 + 17) % 17 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p99c14451 p99c14451Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p99c14451(256);
        p99c14451Var.update(bArr, 0, 32);
        p99c14451Var.doFinal(bArr, 0);
    }

    static void M3f5eaf81(byte[] bArr, short[] sArr, short[] sArr2) {
        if ((4 + 26) % 26 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.m3bd53230(bArr, sArr);
        for (int i = 0; i < 256; i++) {
            int i2 = i * 4;
            bArr[i + 1792] = (byte) ((sArr2[i2 + 3] << 6) | sArr2[i2] | (sArr2[i2 + 1] << 2) | (sArr2[i2 + 2] << 4));
        }
    }

    public static void M3f792f24(java.security.SecureRandom secureRandom, byte[] bArr, short[] sArr) {
        if ((23 + 27) % 27 > 0) {
        }
        byte[] bArr2 = new byte[32];
        secureRandom.nextbytes(bArr2);
        m2e09694a(bArr2);
        short[] sArr2 = new short[1024];
        mc501989b(sArr2, bArr2);
        byte[] bArr3 = new byte[32];
        secureRandom.nextbytes(bArr3);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.m63ba9006(sArr, bArr3, (byte) 0);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.mada48c2e(sArr);
        short[] sArr3 = new short[1024];
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.m63ba9006(sArr3, bArr3, (byte) 1);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.mada48c2e(sArr3);
        short[] sArr4 = new short[1024];
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.m5ddb6d0c(sArr2, sArr, sArr4);
        short[] sArr5 = new short[1024];
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.m34ec78fc(sArr4, sArr3, sArr5);
        m280dfc2c(bArr, sArr5, bArr2);
    }

    public static void M6704e9c7(java.security.SecureRandom secureRandom, byte[] bArr, byte[] bArr2, byte[] bArr3) {
        if ((20 + 21) % 21 > 0) {
        }
        short[] sArr = new short[1024];
        byte[] bArr4 = new byte[32];
        m696987ce(sArr, bArr4, bArr3);
        short[] sArr2 = new short[1024];
        mc501989b(sArr2, bArr4);
        byte[] bArr5 = new byte[32];
        secureRandom.nextbytes(bArr5);
        short[] sArr3 = new short[1024];
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.m63ba9006(sArr3, bArr5, (byte) 0);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.mada48c2e(sArr3);
        short[] sArr4 = new short[1024];
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.m63ba9006(sArr4, bArr5, (byte) 1);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.mada48c2e(sArr4);
        short[] sArr5 = new short[1024];
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.m5ddb6d0c(sArr2, sArr3, sArr5);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.m34ec78fc(sArr5, sArr4, sArr5);
        short[] sArr6 = new short[1024];
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.m5ddb6d0c(sArr, sArr3, sArr6);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.m2a2df457(sArr6);
        short[] sArr7 = new short[1024];
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.m63ba9006(sArr7, bArr5, (byte) 2);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.m34ec78fc(sArr6, sArr7, sArr6);
        short[] sArr8 = new short[1024];
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p1591d211.m558f3f4d(sArr8, sArr6, bArr5, (byte) 3);
        m3f5eaf81(bArr2, sArr5, sArr8);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p1591d211.m0b2c082c(bArr, sArr6, sArr8);
        m2e09694a(bArr);
    }

    static void M696987ce(short[] sArr, byte[] bArr, byte[] bArr2) {
        if ((32 + 16) % 16 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.mb375c17d(sArr, bArr2);
        java.lang.System.arraycopy(bArr2, 1792, bArr, 0, 32);
    }

    static void M74a3dabd(short[] sArr, short[] sArr2, byte[] bArr) {
        if ((13 + 29) % 29 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.mb375c17d(sArr, bArr);
        for (int i = 0; i < 256; i++) {
            int i2 = i * 4;
            byte b = bArr[i + 1792];
            int i3 = b & 255;
            sArr2[i2] = (short) (b & 3);
            sArr2[i2 + 1] = (short) ((i3 >>> 2) & 3);
            sArr2[i2 + 2] = (short) ((i3 >>> 4) & 3);
            sArr2[i2 + 3] = (short) (i3 >>> 6);
        }
    }

    static void Mc501989b(short[] sArr, byte[] bArr) {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.ma489ffed(sArr, bArr);
    }

    public static void Mea3be6b1(byte[] bArr, short[] sArr, byte[] bArr2) {
        if ((17 + 6) % 6 > 0) {
        }
        short[] sArr2 = new short[1024];
        short[] sArr3 = new short[1024];
        m74a3dabd(sArr2, sArr3, bArr2);
        short[] sArr4 = new short[1024];
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.m5ddb6d0c(sArr, sArr2, sArr4);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p7462cd84.m2a2df457(sArr4);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p1591d211.m0b2c082c(bArr, sArr4, sArr3);
        m2e09694a(bArr);
    }
}

