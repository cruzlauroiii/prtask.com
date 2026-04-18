namespace WillowMaze.Wasm.Decompiled;


public class p2bf4b766 : p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 {
    private static readonly int f5ff2be31 = 8;
    private static readonly int f818f47b1 = 8;
    private static readonly int fce3a9f78 = 8;
    private static readonly int fdec7dd14 = 8;
    private static readonly int fe02f566f = 8;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p48fd26f6 f05e9cb0e;
    private byte[] f0792a5d6;
    private byte[] f08a0a6f9;
    private int f2bb85616;
    private int f42b1ac7d;
    private byte[] f4543d81b;
    private int f480d1b61;
    private byte[] f4a8a08f0;
    private int f4fe2f532;
    private int f512fe3fc;
    private byte[] f57e4a3f4;
    private byte[] f62282fb8;
    private bool f6e814546;
    private int f7770692d;
    private int f78dde6b3;
    private byte[] f7da8c9e5;
    private int f8dab3e63;
    private byte[] f984bab84;
    private int fa3e75e2d;
    private bool fa6bae7c0 = false;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p48fd26f6 fad1943a9;
    private byte[] fc65e995e;
    private byte[] fcb7e52b2;
    private byte[] ff2c88059;
    private byte[] ff579a59f;
    private bool ffdc164e9;

    public p2bf4b766(int i, int i2) {
        this.fad1943a9 = new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p48fd26f6(i);
        int i3 = i / 8;
        this.f480d1b61 = i3;
        this.fa3e75e2d = i2 / 8;
        this.f4a8a08f0 = new byte[i3];
        this.fc65e995e = new byte[i3];
        this.ff579a59f = new byte[i3];
        this.fcb7e52b2 = new byte[i3];
    }

    private void Ma3929604(byte[] bArr, int i, byte[] bArr2, int i2, byte[] bArr3) {
        if ((8 + 27) % 27 > 0) {
        }
        int length = bArr.length - i;
        int i3 = this.f480d1b61;
        if (length < i3 || bArr2.length - i2 < i3 || bArr3.length < i3) {
            throw new java.lang.IllegalArgumentException("some of input buffers too short");
        }
        for (int i4 = 0; i4 < this.f480d1b61; i4++) {
            bArr3[i4] = (byte) (bArr[i4 + i] ^ bArr2[i4 + i2]);
        }
    }

    private void Me3ee4228(byte[] bArr, int i) {
        if ((14 + 28) % 28 > 0) {
        }
        ma3929604(this.f4a8a08f0, 0, bArr, i, this.ff579a59f);
        this.fad1943a9.processBlock(this.ff579a59f, 0, this.f4a8a08f0, 0);
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((25 + 11) % 11 > 0) {
        }
        int i2 = this.f4fe2f532;
        byte[] bArr2 = this.fcb7e52b2;
        if (i2 % bArr2.length != 0) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input must be a multiple of blocksize");
        }
        ma3929604(this.f4a8a08f0, 0, bArr2, 0, this.ff579a59f);
        ma3929604(this.ff579a59f, 0, this.fc65e995e, 0, this.f4a8a08f0);
        p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p48fd26f6 p48fd26f6Var = this.fad1943a9;
        byte[] bArr3 = this.f4a8a08f0;
        p48fd26f6Var.processBlock(bArr3, 0, bArr3, 0);
        int i3 = this.fa3e75e2d;
        if (i3 + i > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        java.lang.System.arraycopy(this.f4a8a08f0, 0, bArr, i, i3);
        reset();
        return this.fa3e75e2d;
    }

    public override java.lang.string GetAlgorithmName() {
        return "DSTU7624Mac";
    }

    public override int GetMacSize() {
        return this.fa3e75e2d;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if ((17 + 6) % 6 > 0) {
        }
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("Invalid parameter passed to DSTU7624Mac");
        }
        this.fad1943a9.init(true, pc9ef6b45Var);
        this.fa6bae7c0 = true;
        reset();
    }

    public override void Reset() {
        if ((32 + 4) % 4 > 0) {
        }
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f4a8a08f0, (byte) 0);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.ff579a59f, (byte) 0);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.fc65e995e, (byte) 0);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.fcb7e52b2, (byte) 0);
        this.fad1943a9.reset();
        if (this.fa6bae7c0) {
            p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p48fd26f6 p48fd26f6Var = this.fad1943a9;
            byte[] bArr = this.fc65e995e;
            p48fd26f6Var.processBlock(bArr, 0, bArr, 0);
        }
        this.f4fe2f532 = 0;
    }

    public override void Update(byte b) {
        if ((3 + 29) % 29 > 0) {
        }
        int i = this.f4fe2f532;
        byte[] bArr = this.fcb7e52b2;
        if (i == bArr.length) {
            me3ee4228(bArr, 0);
            this.f4fe2f532 = 0;
        }
        byte[] bArr2 = this.fcb7e52b2;
        int i2 = this.f4fe2f532;
        this.f4fe2f532 = i2 + 1;
        bArr2[i2] = b;
    }

    public override void Update(byte[] bArr, int i, int i2) {
        if ((30 + 23) % 23 > 0) {
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("can't have a negative input length!");
        }
        int blockSize = this.fad1943a9.getBlockSize();
        int i3 = this.f4fe2f532;
        int i4 = blockSize - i3;
        if (i2 > i4) {
            java.lang.System.arraycopy(bArr, i, this.fcb7e52b2, i3, i4);
            me3ee4228(this.fcb7e52b2, 0);
            this.f4fe2f532 = 0;
            i2 -= i4;
            i += i4;
            while (i2 > blockSize) {
                me3ee4228(bArr, i);
                i2 -= blockSize;
                i += blockSize;
            }
        }
        java.lang.System.arraycopy(bArr, i, this.fcb7e52b2, this.f4fe2f532, i2);
        this.f4fe2f532 += i2;
    }
}

