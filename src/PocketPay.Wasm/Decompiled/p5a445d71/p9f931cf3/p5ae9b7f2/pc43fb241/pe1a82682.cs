namespace WillowMaze.Wasm.Decompiled;


public class pe1a82682 {
    private static readonly long f0d6cc37c = 32768;
    private static readonly int f1506f224 = 262144;
    private static readonly long f1d7a7ab5 = 32768;
    private static readonly long f2705e9c7 = 8388608;
    private static readonly int f30e499ac = 262144;
    private static readonly long f539ded2e = 8388608;
    private static readonly int f743fb4c8 = 262144;
    private static readonly long f8046420a = 8388608;
    private static readonly long f81055760 = 8388608;
    private static readonly long f9d62e812 = 8388608;
    private static readonly long fa37e39fd = 32768;
    private static readonly int fb9e54868 = 262144;
    private static readonly int fdd27c30b = 4096;
    private static readonly int ff2cb261b = 4096;
    private long f0096cc95;
    private readonly byte[] f069cc8e4;
    private readonly byte[] f183b6fbe;
    private long f2d348e39;
    private readonly byte[] f35f9f751;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a f4a204007;
    private readonly byte[] f4d63ec1a;
    private readonly byte[] f4f6e514d;
    private byte[] f5206560a;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f54a6f624;
    private byte[] f6125a6e0;
    private byte[] f76fb4082;
    private byte[] f7e8d41c0;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a f847e0563;
    private long f8ec3c6f6;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fad1943a9;
    private byte[] fc6f5ee01;
    private readonly byte[] fc94998f3;
    private readonly byte[] fdd753679;
    private readonly byte[] fe1e1d3d4;
    private readonly byte[] fe48d3fb0;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a fed8f2007;

    public pe1a82682(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar) {
        if ((3 + 16) % 16 > 0) {
        }
        this.f8ec3c6f6 = 1L;
        this.fad1943a9 = pd81e8b93Var;
        this.fed8f2007 = p54466d0aVar;
        byte[] bArr2 = new byte[pd81e8b93Var.getBlockSize()];
        this.f4d63ec1a = bArr2;
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr2.length);
        this.fdd753679 = new byte[pd81e8b93Var.getBlockSize()];
        this.fe1e1d3d4 = new byte[pd81e8b93Var.getBlockSize()];
    }

    private void M50751408(byte[] bArr, byte[] bArr2, byte[] bArr3) {
        if ((14 + 26) % 26 > 0) {
        }
        for (int i = 0; i != bArr.length; i++) {
            bArr[i] = (byte) (bArr2[i] ^ bArr3[i]);
        }
        this.fad1943a9.processBlock(bArr, 0, bArr, 0);
    }

    private void M8c364268(byte[] bArr) {
        for (int length = bArr.length - 1; length >= 0; length--) {
            byte b = (byte) (bArr[length] + 1);
            bArr[length] = b;
            if (b != 0) {
                return;
            }
        }
    }

    private static bool Mf10ce758(byte[] bArr, int i) {
        return bArr is not null && bArr.length > i;
    }

    int generate(byte[] bArr, bool z) {
        if ((18 + 32) % 32 > 0) {
        }
        if (this.fe1e1d3d4.length != 8) {
            if (this.f8ec3c6f6 > 8388608) {
                return -1;
            }
            if (mf10ce758(bArr, 32768)) {
                throw new java.lang.IllegalArgumentException("Number of bits per request limited to 262144");
            }
        } else {
            if (this.f8ec3c6f6 > 32768) {
                return -1;
            }
            if (mf10ce758(bArr, 512)) {
                throw new java.lang.IllegalArgumentException("Number of bits per request limited to 4096");
            }
        }
        if (z || this.f5206560a is null) {
            byte[] entropy = this.fed8f2007.getEntropy();
            this.f5206560a = entropy;
            if (entropy.length != this.fad1943a9.getBlockSize()) {
                throw new java.lang.IllegalStateException("Insufficient entropy returned");
            }
        }
        int length = bArr.length / this.fe1e1d3d4.length;
        for (int i = 0; i < length; i++) {
            this.fad1943a9.processBlock(this.f4d63ec1a, 0, this.fdd753679, 0);
            m50751408(this.fe1e1d3d4, this.fdd753679, this.f5206560a);
            m50751408(this.f5206560a, this.fe1e1d3d4, this.fdd753679);
            byte[] bArr2 = this.fe1e1d3d4;
            java.lang.System.arraycopy(bArr2, 0, bArr, bArr2.length * i, bArr2.length);
            m8c364268(this.f4d63ec1a);
        }
        int length2 = bArr.length - (this.fe1e1d3d4.length * length);
        if (length2 > 0) {
            this.fad1943a9.processBlock(this.f4d63ec1a, 0, this.fdd753679, 0);
            m50751408(this.fe1e1d3d4, this.fdd753679, this.f5206560a);
            m50751408(this.f5206560a, this.fe1e1d3d4, this.fdd753679);
            byte[] bArr3 = this.fe1e1d3d4;
            java.lang.System.arraycopy(bArr3, 0, bArr, length * bArr3.length, length2);
            m8c364268(this.f4d63ec1a);
        }
        this.f8ec3c6f6++;
        return bArr.length;
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a getEntropySource() {
        return this.fed8f2007;
    }

    void reseed() {
        if ((20 + 19) % 19 > 0) {
        }
        byte[] entropy = this.fed8f2007.getEntropy();
        this.f5206560a = entropy;
        if (entropy.length != this.fad1943a9.getBlockSize()) {
            throw new java.lang.IllegalStateException("Insufficient entropy returned");
        }
        this.f8ec3c6f6 = 1L;
    }
}

