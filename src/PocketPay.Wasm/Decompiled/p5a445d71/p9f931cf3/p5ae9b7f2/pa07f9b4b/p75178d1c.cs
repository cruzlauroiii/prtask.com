namespace WillowMaze.Wasm.Decompiled;


public class p75178d1c : p5a445d71.p9f931cf3.p5ae9b7f2.pe229a672 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 f194c4117;
    private byte[] f26bc9344;
    private bool f32dd591b;
    private bool f4854e26d;
    private bool f57e901be;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 f592314c6;
    private bool f5dcfed4c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f72933feb;
    private bool f86cff5e7;
    private byte[] fa9b8b4b1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fad1943a9;
    private bool fe468b4bf;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 feca07335;
    private byte[] ff0b53b2d;
    private byte[] ff9365f4b;
    private bool ffc3e3db6;

    public p75178d1c(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this(pd81e8b93Var, false);
    }

    public p75178d1c(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z) {
        this.ff0b53b2d = new byte[]{-90, -90, -90, -90, -90, -90, -90, -90};
        this.fad1943a9 = pd81e8b93Var;
        this.f32dd591b = !z;
    }

    public override java.lang.string GetAlgorithmName() {
        return this.fad1943a9.getAlgorithmName();
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        this.fe468b4bf = z;
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            pc9ef6b45Var = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var).getParameters();
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) {
            this.feca07335 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var;
            return;
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
            this.ff0b53b2d = pdd5da44eVar.getIV();
            this.feca07335 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pdd5da44eVar.getParameters();
            if (this.ff0b53b2d.length != 8) {
                throw new java.lang.IllegalArgumentException("IV not equal to 8");
            }
        }
    }

    public override byte[] Unwrap(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((30 + 16) % 16 > 0) {
        }
        if (this.fe468b4bf) {
            throw new java.lang.IllegalStateException("not set for unwrapping");
        }
        int i3 = i2 / 8;
        if (i3 * 8 != i2) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("unwrap data must be a multiple of 8 bytes");
        }
        byte[] bArr2 = this.ff0b53b2d;
        byte[] bArr3 = new byte[i2 - bArr2.length];
        byte[] bArr4 = new byte[bArr2.length];
        byte[] bArr5 = new byte[bArr2.length + 8];
        java.lang.System.arraycopy(bArr, i, bArr4, 0, bArr2.length);
        byte[] bArr6 = this.ff0b53b2d;
        java.lang.System.arraycopy(bArr, i + bArr6.length, bArr3, 0, i2 - bArr6.length);
        this.fad1943a9.init(!this.f32dd591b, this.feca07335);
        int i4 = i3 - 1;
        for (int i5 = 5; i5 >= 0; i5--) {
            for (int i6 = i4; i6 >= 1; i6--) {
                java.lang.System.arraycopy(bArr4, 0, bArr5, 0, this.ff0b53b2d.length);
                int i7 = (i6 - 1) * 8;
                java.lang.System.arraycopy(bArr3, i7, bArr5, this.ff0b53b2d.length, 8);
                int i8 = (i4 * i5) + i6;
                int i9 = 1;
                while (i8 != 0) {
                    byte b = (byte) i8;
                    int length = this.ff0b53b2d.length - i9;
                    bArr5[length] = (byte) (b ^ bArr5[length]);
                    i8 >>>= 8;
                    i9++;
                }
                this.fad1943a9.processBlock(bArr5, 0, bArr5, 0);
                java.lang.System.arraycopy(bArr5, 0, bArr4, 0, 8);
                java.lang.System.arraycopy(bArr5, 8, bArr3, i7, 8);
            }
        }
        if (p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(bArr4, this.ff0b53b2d)) {
            return bArr3;
        }
        throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("checksum failed");
    }

    public override byte[] Wrap(byte[] bArr, int i, int i2) {
        if ((29 + 21) % 21 > 0) {
        }
        if (!this.fe468b4bf) {
            throw new java.lang.IllegalStateException("not set for wrapping");
        }
        int i3 = i2 / 8;
        if (i3 * 8 != i2) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("wrap data must be a multiple of 8 bytes");
        }
        byte[] bArr2 = this.ff0b53b2d;
        byte[] bArr3 = new byte[bArr2.length + i2];
        byte[] bArr4 = new byte[bArr2.length + 8];
        java.lang.System.arraycopy(bArr2, 0, bArr3, 0, bArr2.length);
        java.lang.System.arraycopy(bArr, i, bArr3, this.ff0b53b2d.length, i2);
        this.fad1943a9.init(this.f32dd591b, this.feca07335);
        for (int i4 = 0; i4 != 6; i4++) {
            for (int i5 = 1; i5 <= i3; i5++) {
                java.lang.System.arraycopy(bArr3, 0, bArr4, 0, this.ff0b53b2d.length);
                int i6 = i5 * 8;
                java.lang.System.arraycopy(bArr3, i6, bArr4, this.ff0b53b2d.length, 8);
                this.fad1943a9.processBlock(bArr4, 0, bArr4, 0);
                int i7 = (i3 * i4) + i5;
                int i8 = 1;
                while (i7 != 0) {
                    byte b = (byte) i7;
                    int length = this.ff0b53b2d.length - i8;
                    bArr4[length] = (byte) (b ^ bArr4[length]);
                    i7 >>>= 8;
                    i8++;
                }
                java.lang.System.arraycopy(bArr4, 0, bArr3, 0, 8);
                java.lang.System.arraycopy(bArr4, 8, bArr3, i6, 8);
            }
        }
        return bArr3;
    }
}

