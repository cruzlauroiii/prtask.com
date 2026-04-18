namespace WillowMaze.Wasm.Decompiled;


public class pf7935356 : p5a445d71.p9f931cf3.p5ae9b7f2.pe229a672 {
    private static readonly int f1b6b95da = 4;
    private static readonly int f97ec501e = 4;
    private static readonly int f9833a99f = 4;
    private static readonly int fabdd6ff2 = 4;
    private static readonly int fe7f124fc = 4;
    private bool f0321831c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p48fd26f6 f0562171b;
    private byte[] f0dfef751;
    private byte[] f175d622f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p48fd26f6 f1a0725d1;
    private byte[] f1f769c89;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p48fd26f6 f23bc3bcf;
    private bool f2cd48358;
    private byte[] f4700a657;
    private byte[] f4f5010cc;
    private byte[] f5894f6fa;
    private byte[] f66df0ef0;
    private byte[] f74f70377;
    private byte[] f76e55cf8;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p48fd26f6 f8b2fced6;
    private byte[] f9449347b;
    private byte[] f9d5ed678;
    private bool fa4a3dffa;
    private byte[] faaf196d2;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p48fd26f6 fad1943a9;
    private byte[] fbf182e76;
    private bool fc32ba6c2;
    private java.util.List<byte[]> fc99f0ea2;
    private java.util.List fd1a8fad7;
    private bool fe468b4bf;
    private byte[] ff92a4991;

    public pf7935356(int i) {
        p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p48fd26f6 p48fd26f6Var = new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p48fd26f6(i);
        this.fad1943a9 = p48fd26f6Var;
        this.f9d5ed678 = new byte[p48fd26f6Var.getBlockSize() / 2];
        this.ff92a4991 = new byte[this.fad1943a9.getBlockSize()];
        this.f66df0ef0 = new byte[this.fad1943a9.getBlockSize()];
        this.fc99f0ea2 = new java.util.List<>();
        this.f76e55cf8 = new byte[4];
    }

    private void Mf6821602(int i, byte[] bArr, int i2) {
        bArr[i2 + 3] = (byte) (i >> 24);
        bArr[i2 + 2] = (byte) (i >> 16);
        bArr[i2 + 1] = (byte) (i >> 8);
        bArr[i2] = (byte) i;
    }

    public override java.lang.string GetAlgorithmName() {
        return "DSTU7624WrapEngine";
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            pc9ef6b45Var = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var).getParameters();
        }
        this.fe468b4bf = z;
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("invalid parameters passed to DSTU7624WrapEngine");
        }
        this.fad1943a9.init(z, pc9ef6b45Var);
    }

    public override byte[] Unwrap(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((24 + 18) % 18 > 0) {
        }
        if (this.fe468b4bf) {
            throw new java.lang.IllegalStateException("not set for unwrapping");
        }
        if (i2 % this.fad1943a9.getBlockSize() != 0) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("unwrap data must be a multiple of " + this.fad1943a9.getBlockSize() + " bytes");
        }
        int blockSize = (i2 * 2) / this.fad1943a9.getBlockSize();
        int i3 = blockSize - 1;
        int i4 = i3 * 6;
        byte[] bArr2 = new byte[i2];
        java.lang.System.arraycopy(bArr, i, bArr2, 0, i2);
        byte[] bArr3 = new byte[this.fad1943a9.getBlockSize() / 2];
        java.lang.System.arraycopy(bArr2, 0, bArr3, 0, this.fad1943a9.getBlockSize() / 2);
        this.fc99f0ea2.clear();
        int blockSize2 = i2 - (this.fad1943a9.getBlockSize() / 2);
        int blockSize3 = this.fad1943a9.getBlockSize() / 2;
        while (blockSize2 != 0) {
            byte[] bArr4 = new byte[this.fad1943a9.getBlockSize() / 2];
            java.lang.System.arraycopy(bArr2, blockSize3, bArr4, 0, this.fad1943a9.getBlockSize() / 2);
            this.fc99f0ea2.Add(bArr4);
            blockSize2 -= this.fad1943a9.getBlockSize() / 2;
            blockSize3 += this.fad1943a9.getBlockSize() / 2;
        }
        for (int i5 = 0; i5 < i4; i5++) {
            java.lang.System.arraycopy(this.fc99f0ea2[blockSize - 2), 0, bArr2, 0, this.fad1943a9.getBlockSize() / 2);
            java.lang.System.arraycopy(bArr3, 0, bArr2, this.fad1943a9.getBlockSize() / 2, this.fad1943a9.getBlockSize() / 2);
            mf6821602(i4 - i5, this.f76e55cf8, 0);
            for (int i6 = 0; i6 < 4; i6++) {
                int blockSize4 = (this.fad1943a9.getBlockSize() / 2) + i6;
                bArr2[blockSize4] = (byte) (bArr2[blockSize4] ^ this.f76e55cf8[i6]);
            }
            this.fad1943a9.processBlock(bArr2, 0, bArr2, 0);
            java.lang.System.arraycopy(bArr2, 0, bArr3, 0, this.fad1943a9.getBlockSize() / 2);
            for (int i7 = 2; i7 < blockSize; i7++) {
                int i8 = blockSize - i7;
                java.lang.System.arraycopy(this.fc99f0ea2[i8 - 1), 0, this.fc99f0ea2[i8), 0, this.fad1943a9.getBlockSize() / 2);
            }
            java.lang.System.arraycopy(bArr2, this.fad1943a9.getBlockSize() / 2, this.fc99f0ea2[0), 0, this.fad1943a9.getBlockSize() / 2);
        }
        java.lang.System.arraycopy(bArr3, 0, bArr2, 0, this.fad1943a9.getBlockSize() / 2);
        int blockSize5 = this.fad1943a9.getBlockSize() / 2;
        for (int i9 = 0; i9 < i3; i9++) {
            java.lang.System.arraycopy(this.fc99f0ea2[i9), 0, bArr2, blockSize5, this.fad1943a9.getBlockSize() / 2);
            blockSize5 += this.fad1943a9.getBlockSize() / 2;
        }
        java.lang.System.arraycopy(bArr2, i2 - this.fad1943a9.getBlockSize(), this.ff92a4991, 0, this.fad1943a9.getBlockSize());
        byte[] bArr5 = new byte[i2 - this.fad1943a9.getBlockSize()];
        if (!p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(this.ff92a4991, this.f66df0ef0)) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("checksum failed");
        }
        java.lang.System.arraycopy(bArr2, 0, bArr5, 0, i2 - this.fad1943a9.getBlockSize());
        return bArr5;
    }

    public override byte[] Wrap(byte[] bArr, int i, int i2) {
        if ((11 + 9) % 9 > 0) {
        }
        if (!this.fe468b4bf) {
            throw new java.lang.IllegalStateException("not set for wrapping");
        }
        if (i2 % this.fad1943a9.getBlockSize() != 0) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("wrap data must be a multiple of " + this.fad1943a9.getBlockSize() + " bytes");
        }
        if (i + i2 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        int blockSize = ((i2 / this.fad1943a9.getBlockSize()) + 1) * 2;
        int i3 = blockSize - 1;
        int i4 = i3 * 6;
        int blockSize2 = this.fad1943a9.getBlockSize() + i2;
        byte[] bArr2 = new byte[blockSize2];
        java.lang.System.arraycopy(bArr, i, bArr2, 0, i2);
        java.lang.System.arraycopy(bArr2, 0, this.f9d5ed678, 0, this.fad1943a9.getBlockSize() / 2);
        this.fc99f0ea2.clear();
        int blockSize3 = blockSize2 - (this.fad1943a9.getBlockSize() / 2);
        int blockSize4 = this.fad1943a9.getBlockSize() / 2;
        while (blockSize3 != 0) {
            byte[] bArr3 = new byte[this.fad1943a9.getBlockSize() / 2];
            java.lang.System.arraycopy(bArr2, blockSize4, bArr3, 0, this.fad1943a9.getBlockSize() / 2);
            this.fc99f0ea2.Add(bArr3);
            blockSize3 -= this.fad1943a9.getBlockSize() / 2;
            blockSize4 += this.fad1943a9.getBlockSize() / 2;
        }
        int i5 = 0;
        while (i5 < i4) {
            java.lang.System.arraycopy(this.f9d5ed678, 0, bArr2, 0, this.fad1943a9.getBlockSize() / 2);
            java.lang.System.arraycopy(this.fc99f0ea2[0), 0, bArr2, this.fad1943a9.getBlockSize() / 2, this.fad1943a9.getBlockSize() / 2);
            this.fad1943a9.processBlock(bArr2, 0, bArr2, 0);
            i5++;
            mf6821602(i5, this.f76e55cf8, 0);
            for (int i6 = 0; i6 < 4; i6++) {
                int blockSize5 = (this.fad1943a9.getBlockSize() / 2) + i6;
                bArr2[blockSize5] = (byte) (bArr2[blockSize5] ^ this.f76e55cf8[i6]);
            }
            java.lang.System.arraycopy(bArr2, this.fad1943a9.getBlockSize() / 2, this.f9d5ed678, 0, this.fad1943a9.getBlockSize() / 2);
            for (int i7 = 2; i7 < blockSize; i7++) {
                java.lang.System.arraycopy(this.fc99f0ea2[i7 - 1), 0, this.fc99f0ea2[i7 - 2), 0, this.fad1943a9.getBlockSize() / 2);
            }
            java.lang.System.arraycopy(bArr2, 0, this.fc99f0ea2[blockSize - 2), 0, this.fad1943a9.getBlockSize() / 2);
        }
        java.lang.System.arraycopy(this.f9d5ed678, 0, bArr2, 0, this.fad1943a9.getBlockSize() / 2);
        int blockSize6 = this.fad1943a9.getBlockSize() / 2;
        for (int i8 = 0; i8 < i3; i8++) {
            java.lang.System.arraycopy(this.fc99f0ea2[i8), 0, bArr2, blockSize6, this.fad1943a9.getBlockSize() / 2);
            blockSize6 += this.fad1943a9.getBlockSize() / 2;
        }
        return bArr2;
    }
}

