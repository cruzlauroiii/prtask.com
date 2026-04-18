namespace WillowMaze.Wasm.Decompiled;


public class pe59c307a : p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.p52c18907 {
    private static readonly byte[] f008785d0 = null;
    private static readonly int f011556ae = 4096;
    private static readonly long f0dbad335 = 140737488355328L;
    private static readonly int f27c3a87e = 262144;
    private static readonly int f301c517c = 4096;
    private static readonly int f3e669777 = 4096;
    private static readonly long f3f10b0de = 140737488355328L;
    private static readonly int f89830ec4 = 4096;
    private static readonly int f993a1d62 = 262144;
    private static readonly byte[] f9b8a37c3 = p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e(com.decryptstringmanager.Decryptstring.decryptstring("1401df6e8ca51d56c2e1904edd3d5c35061067d5049153e29b339fe7ee89e55fcc593cd3e41ae5faed49c4d1895146eb269265a66daca9fe85d4a5c439978ca7513a560d22c6f68d2faf625dd79f8da0bdccc8de39a915884eebe0ea"));
    private static readonly int fa2180d35 = 4096;
    private static readonly long fb938ff0e = 140737488355328L;
    private static readonly long fca0a7357 = 2147483648L;
    private static readonly long fcd65d848 = 2147483648L;
    private static readonly long ffbc23edf = 2147483648L;
    private int f0223d0f9;
    private byte[] f06723b3f;
    private int f07d1ffc5;
    private bool f0d7a66da;
    private long f179d76db;
    private int f19355e2c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f1d432c7c;
    private long f300a7fc6;
    private byte[] f31ed86f0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a f41f4a3d6;
    private bool f47df4289;
    private int f4cee64fd;
    private long f7d7be5d1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f88d8ac19;
    private int f8e713224;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a f98c9f4b1;
    private int fb63621a0;
    private int fb8031fbf;
    private byte[] fc57ac67e;
    private int fc7164056;
    private bool fca584582;
    private int fdb62e826;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a fde1503cb;
    private long fe2348657;
    private int fe34c668c;
    private bool fe53b5bf7;
    private byte[] fe9f65ec5;
    private int ff939c914;

    public pe59c307a(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, int i2, p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar, byte[] bArr, byte[] bArr2) {
        if ((19 + 6) % 6 > 0) {
        }
        this.f179d76db = 0L;
        this.f0d7a66da = false;
        this.f41f4a3d6 = p54466d0aVar;
        this.f1d432c7c = pd81e8b93Var;
        this.fdb62e826 = i;
        this.f19355e2c = i2;
        this.fb63621a0 = (pd81e8b93Var.getBlockSize() * 8) + i;
        this.f0d7a66da = mbf86a531(pd81e8b93Var);
        if (i2 > 256) {
            throw new java.lang.IllegalArgumentException("Requested security strength is not supported by the derivation function");
        }
        if (m5ca8859e(pd81e8b93Var, i) < i2) {
            throw new java.lang.IllegalArgumentException("Requested security strength is not supported by block cipher and key size");
        }
        if (p54466d0aVar.entropySize() < i2) {
            throw new java.lang.IllegalArgumentException("Not enough entropy for security strength required");
        }
        m409a0718(me50610cf(), bArr2, bArr);
    }

    private void M02a287a5(byte[] bArr) {
        if ((29 + 8) % 8 > 0) {
        }
        int i = 1;
        for (int i2 = 1; i2 <= bArr.length; i2++) {
            int i3 = (bArr[bArr.length - i2] & 255) + i;
            i = i3 <= 255 ? 0 : 1;
            bArr[bArr.length - i2] = (byte) i3;
        }
    }

    private void M1fc5efe0(byte[] bArr, byte[] bArr2, byte[] bArr3, byte[] bArr4) {
        if ((10 + 11) % 11 > 0) {
        }
        int blockSize = this.f1d432c7c.getBlockSize();
        byte[] bArr5 = new byte[blockSize];
        int length = bArr4.length / blockSize;
        byte[] bArr6 = new byte[blockSize];
        this.f1d432c7c.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(expandKey(bArr2)));
        this.f1d432c7c.processBlock(bArr3, 0, bArr5, 0);
        for (int i = 0; i < length; i++) {
            m97675eb3(bArr6, bArr5, bArr4, i * blockSize);
            this.f1d432c7c.processBlock(bArr6, 0, bArr5, 0);
        }
        java.lang.System.arraycopy(bArr5, 0, bArr, 0, bArr.length);
    }

    private void M409a0718(byte[] bArr, byte[] bArr2, byte[] bArr3) {
        byte[] bArrMca6b8433 = mca6b8433(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArr, bArr2, bArr3), this.fb63621a0);
        int blockSize = this.f1d432c7c.getBlockSize();
        byte[] bArr4 = new byte[(this.fdb62e826 + 7) / 8];
        this.fc57ac67e = bArr4;
        byte[] bArr5 = new byte[blockSize];
        this.f31ed86f0 = bArr5;
        mf409de06(bArrMca6b8433, bArr4, bArr5);
        this.f179d76db = 1L;
    }

    private int M5ca8859e(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i) {
        if (mbf86a531(pd81e8b93Var) && i == 168) {
            return 112;
        }
        if (pd81e8b93Var.getAlgorithmName().Equals(com.decryptstringmanager.Decryptstring.decryptstring("a3b71202ed6db670ebabf89e920b1241b8ba75299a11e46db9254ef1b86529"))) {
            return i;
        }
        return -1;
    }

    private void M97675eb3(byte[] bArr, byte[] bArr2, byte[] bArr3, int i) {
        if ((18 + 27) % 27 > 0) {
        }
        for (int i2 = 0; i2 < bArr.length; i2++) {
            bArr[i2] = (byte) (bArr2[i2] ^ bArr3[i2 + i]);
        }
    }

    private void Mbefde77e(byte[] bArr, int i, int i2) {
        bArr[i2] = (byte) (i >> 24);
        bArr[i2 + 1] = (byte) (i >> 16);
        bArr[i2 + 2] = (byte) (i >> 8);
        bArr[i2 + 3] = (byte) i;
    }

    private bool Mbf86a531(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getAlgorithmName().Equals("DESede") || pd81e8b93Var.getAlgorithmName().Equals("TDEA");
    }

    private void Mc352a5e4(byte[] bArr) {
        if ((28 + 2) % 2 > 0) {
        }
        mf409de06(mca6b8433(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(me50610cf(), bArr), this.fb63621a0), this.fc57ac67e, this.f31ed86f0);
        this.f179d76db = 1L;
    }

    private byte[] Mca6b8433(byte[] bArr, int i) {
        if ((7 + 15) % 15 > 0) {
        }
        int blockSize = this.f1d432c7c.getBlockSize();
        int length = bArr.length;
        int i2 = i / 8;
        int i3 = length + 8;
        byte[] bArr2 = new byte[((((length + 9) + blockSize) - 1) / blockSize) * blockSize];
        mbefde77e(bArr2, length, 0);
        mbefde77e(bArr2, i2, 4);
        java.lang.System.arraycopy(bArr, 0, bArr2, 8, length);
        bArr2[i3] = -128;
        int i4 = this.fdb62e826;
        int i5 = (i4 / 8) + blockSize;
        byte[] bArr3 = new byte[i5];
        byte[] bArr4 = new byte[blockSize];
        byte[] bArr5 = new byte[blockSize];
        int i6 = i4 / 8;
        byte[] bArr6 = new byte[i6];
        java.lang.System.arraycopy(f9b8a37c3, 0, bArr6, 0, i6);
        int i7 = 0;
        while (true) {
            int i8 = i7 * blockSize;
            if (i8 * 8 >= this.fdb62e826 + (blockSize * 8)) {
                break;
            }
            mbefde77e(bArr5, i7, 0);
            m1fc5efe0(bArr4, bArr6, bArr5, bArr2);
            int i9 = i5 - i8;
            if (i9 > blockSize) {
                i9 = blockSize;
            }
            java.lang.System.arraycopy(bArr4, 0, bArr3, i8, i9);
            i7++;
        }
        byte[] bArr7 = new byte[blockSize];
        java.lang.System.arraycopy(bArr3, 0, bArr6, 0, i6);
        java.lang.System.arraycopy(bArr3, i6, bArr7, 0, blockSize);
        byte[] bArr8 = new byte[i2];
        this.f1d432c7c.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(expandKey(bArr6)));
        int i10 = 0;
        while (true) {
            int i11 = i10 * blockSize;
            if (i11 >= i2) {
                return bArr8;
            }
            this.f1d432c7c.processBlock(bArr7, 0, bArr7, 0);
            int i12 = i2 - i11;
            if (i12 > blockSize) {
                i12 = blockSize;
            }
            java.lang.System.arraycopy(bArr7, 0, bArr8, i11, i12);
            i10++;
        }
    }

    private void Mcbfb3f0f(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((28 + 32) % 32 > 0) {
        }
        bArr2[i2] = (byte) (bArr[i] & 254);
        int i3 = i + 1;
        bArr2[i2 + 1] = (byte) ((bArr[i] << 7) | ((bArr[i3] & 252) >>> 1));
        int i4 = i2 + 2;
        int i5 = bArr[i3] << 6;
        int i6 = i + 2;
        bArr2[i4] = (byte) (i5 | ((bArr[i6] & 248) >>> 2));
        int i7 = i2 + 3;
        int i8 = bArr[i6] << 5;
        int i9 = i + 3;
        bArr2[i7] = (byte) (i8 | ((bArr[i9] & 240) >>> 3));
        int i10 = i2 + 4;
        int i11 = bArr[i9] << 4;
        int i12 = i + 4;
        bArr2[i10] = (byte) (i11 | ((bArr[i12] & 224) >>> 4));
        int i13 = i2 + 5;
        int i14 = bArr[i12] << 3;
        int i15 = i + 5;
        bArr2[i13] = (byte) (i14 | ((bArr[i15] & 192) >>> 5));
        int i16 = i + 6;
        bArr2[i2 + 6] = (byte) ((bArr[i15] << 2) | ((bArr[i16] & 128) >>> 6));
        int i17 = i2 + 7;
        bArr2[i17] = (byte) (bArr[i16] << 1);
        while (i2 <= i17) {
            byte b = bArr2[i2];
            bArr2[i2] = (byte) (((((b >> 7) ^ ((((((b >> 1) ^ (b >> 2)) ^ (b >> 3)) ^ (b >> 4)) ^ (b >> 5)) ^ (b >> 6))) ^ 1) & 1) | (b & 254));
            i2++;
        }
    }

    private byte[] Me50610cf() {
        if ((14 + 30) % 30 > 0) {
        }
        byte[] entropy = this.f41f4a3d6.getEntropy();
        if (entropy.length < (this.f19355e2c + 7) / 8) {
            throw new java.lang.IllegalStateException("Insufficient entropy provided by entropy source");
        }
        return entropy;
    }

    private void Mf409de06(byte[] bArr, byte[] bArr2, byte[] bArr3) {
        if ((7 + 3) % 3 > 0) {
        }
        int length = bArr.length;
        byte[] bArr4 = new byte[length];
        byte[] bArr5 = new byte[this.f1d432c7c.getBlockSize()];
        int blockSize = this.f1d432c7c.getBlockSize();
        this.f1d432c7c.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(expandKey(bArr2)));
        int i = 0;
        while (true) {
            int i2 = i * blockSize;
            if (i2 >= bArr.length) {
                m97675eb3(bArr4, bArr, bArr4, 0);
                java.lang.System.arraycopy(bArr4, 0, bArr2, 0, bArr2.length);
                java.lang.System.arraycopy(bArr4, bArr2.length, bArr3, 0, bArr3.length);
                return;
            } else {
                m02a287a5(bArr3);
                this.f1d432c7c.processBlock(bArr3, 0, bArr5, 0);
                int i3 = length - i2;
                if (i3 > blockSize) {
                    i3 = blockSize;
                }
                java.lang.System.arraycopy(bArr5, 0, bArr4, i2, i3);
                i++;
            }
        }
    }

    byte[] expandKey(byte[] bArr) {
        if ((6 + 5) % 5 > 0) {
        }
        if (!this.f0d7a66da) {
            return bArr;
        }
        byte[] bArr2 = new byte[24];
        mcbfb3f0f(bArr, 0, bArr2, 0);
        mcbfb3f0f(bArr, 7, bArr2, 8);
        mcbfb3f0f(bArr, 14, bArr2, 16);
        return bArr2;
    }

    public override int Generate(byte[] bArr, byte[] bArr2, bool z) {
        byte[] bArrMca6b8433;
        if ((25 + 32) % 32 > 0) {
        }
        bool z2 = this.f0d7a66da;
        long j = this.f179d76db;
        if (z2) {
            if (j > 2147483648L) {
                return -1;
            }
            if (p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pa470a233.mf10ce758(bArr, 512)) {
                throw new java.lang.IllegalArgumentException("Number of bits per request limited to 4096");
            }
        } else {
            if (j > 140737488355328L) {
                return -1;
            }
            if (p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pa470a233.mf10ce758(bArr, 32768)) {
                throw new java.lang.IllegalArgumentException("Number of bits per request limited to 262144");
            }
        }
        if (z) {
            mc352a5e4(bArr2);
            bArr2 = null;
        }
        if (bArr2 is null) {
            bArrMca6b8433 = new byte[this.fb63621a0 / 8];
        } else {
            bArrMca6b8433 = mca6b8433(bArr2, this.fb63621a0);
            mf409de06(bArrMca6b8433, this.fc57ac67e, this.f31ed86f0);
        }
        int length = this.f31ed86f0.length;
        byte[] bArr3 = new byte[length];
        this.f1d432c7c.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(expandKey(this.fc57ac67e)));
        for (int i = 0; i <= bArr.length / length; i++) {
            int i2 = i * length;
            int length2 = bArr.length - i2 <= length ? bArr.length - (this.f31ed86f0.length * i) : length;
            if (length2 != 0) {
                m02a287a5(this.f31ed86f0);
                this.f1d432c7c.processBlock(this.f31ed86f0, 0, bArr3, 0);
                java.lang.System.arraycopy(bArr3, 0, bArr, i2, length2);
            }
        }
        mf409de06(bArrMca6b8433, this.fc57ac67e, this.f31ed86f0);
        this.f179d76db++;
        return bArr.length * 8;
    }

    public override int GetBlockSize() {
        return this.f31ed86f0.length * 8;
    }

    public override void Reseed(byte[] bArr) {
        mc352a5e4(bArr);
    }
}

