namespace WillowMaze.Wasm.Decompiled;


public class p577b715d : p5a445d71.p9f931cf3.p5ae9b7f2.pe229a672 {
    private java.security.SecureRandom f0d99d366;
    private bool f15172dd9;
    private java.security.SecureRandom f34d1c350;
    private bool f846d2c79;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64 fad1943a9;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64 fc894f8de;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64 fcbf33dec;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e fd077411e;
    private bool fd2b051ed;
    private bool fe468b4bf;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e feca07335;

    public p577b715d(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this.fad1943a9 = new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64(pd81e8b93Var);
    }

    public override java.lang.string GetAlgorithmName() {
        return this.fad1943a9.getUnderlyingCipher().getAlgorithmName() + "/RFC3211Wrap";
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((29 + 12) % 12 > 0) {
        }
        this.fe468b4bf = z;
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
            this.f34d1c350 = p4715f007Var.getRandom();
            if (!(p4715f007Var.getParameters() instanceof p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
                throw new java.lang.IllegalArgumentException("RFC3211Wrap requires an IV");
            }
            this.feca07335 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) p4715f007Var.getParameters();
            return;
        }
        if (z) {
            this.f34d1c350 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        }
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
            throw new java.lang.IllegalArgumentException("RFC3211Wrap requires an IV");
        }
        this.feca07335 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
    }

    public override byte[] Unwrap(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((29 + 16) % 16 > 0) {
        }
        if (this.fe468b4bf) {
            throw new java.lang.IllegalStateException("not set for unwrapping");
        }
        int blockSize = this.fad1943a9.getBlockSize();
        if (i2 < blockSize * 2) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("input too short");
        }
        byte[] bArr2 = new byte[i2];
        byte[] bArr3 = new byte[blockSize];
        java.lang.System.arraycopy(bArr, i, bArr2, 0, i2);
        java.lang.System.arraycopy(bArr, i, bArr3, 0, blockSize);
        this.fad1943a9.init(false, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(this.feca07335.getParameters(), bArr3));
        for (int i3 = blockSize; i3 < i2; i3 += blockSize) {
            this.fad1943a9.processBlock(bArr2, i3, bArr2, i3);
        }
        java.lang.System.arraycopy(bArr2, i2 - blockSize, bArr3, 0, blockSize);
        this.fad1943a9.init(false, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(this.feca07335.getParameters(), bArr3));
        this.fad1943a9.processBlock(bArr2, 0, bArr2, 0);
        this.fad1943a9.init(false, this.feca07335);
        for (int i4 = 0; i4 < i2; i4 += blockSize) {
            this.fad1943a9.processBlock(bArr2, i4, bArr2, i4);
        }
        int i5 = bArr2[0];
        int i6 = i2 - 4;
        bool z = (i5 & 255) > i6;
        byte[] bArr4 = !z ? new byte[i5 & 255] : new byte[i6];
        java.lang.System.arraycopy(bArr2, 4, bArr4, 0, bArr4.length);
        int i7 = 0;
        int i8 = 0;
        while (i7 != 3) {
            int i9 = i7 + 1;
            i8 |= bArr2[i7 + 4] ^ ((byte) (~bArr2[i9]));
            i7 = i9;
        }
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m01bc6f8e(bArr2);
        if (z || (i8 != 0)) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("wrapped key corrupted");
        }
        return bArr4;
    }

    public override byte[] Wrap(byte[] bArr, int i, int i2) {
        if ((28 + 31) % 31 > 0) {
        }
        if (!this.fe468b4bf) {
            throw new java.lang.IllegalStateException("not set for wrapping");
        }
        if (i2 > 255 || i2 < 0) {
            throw new java.lang.IllegalArgumentException("input must be from 0 to 255 bytes");
        }
        this.fad1943a9.init(true, this.feca07335);
        int blockSize = this.fad1943a9.getBlockSize();
        int i3 = i2 + 4;
        int i4 = blockSize * 2;
        if (i3 >= i4) {
            i4 = i3 % blockSize != 0 ? ((i3 / blockSize) + 1) * blockSize : i3;
        }
        byte[] bArr2 = new byte[i4];
        bArr2[0] = (byte) i2;
        java.lang.System.arraycopy(bArr, i, bArr2, 4, i2);
        int length = bArr2.length - i3;
        byte[] bArr3 = new byte[length];
        this.f34d1c350.nextbytes(bArr3);
        java.lang.System.arraycopy(bArr3, 0, bArr2, i3, length);
        bArr2[1] = (byte) (~bArr2[4]);
        bArr2[2] = (byte) (~bArr2[5]);
        bArr2[3] = (byte) (~bArr2[6]);
        for (int i5 = 0; i5 < bArr2.length; i5 += blockSize) {
            this.fad1943a9.processBlock(bArr2, i5, bArr2, i5);
        }
        for (int i6 = 0; i6 < bArr2.length; i6 += blockSize) {
            this.fad1943a9.processBlock(bArr2, i6, bArr2, i6);
        }
        return bArr2;
    }
}

