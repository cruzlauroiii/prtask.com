namespace WillowMaze.Wasm.Decompiled;


public class pb3bc2bab : p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 {
    private static readonly int f5ec91c43 = 8;
    private static readonly int fe02f566f = 8;
    private long f041709f4;
    private long f20c89c64;
    private int f6ef20537;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p40c98d93 f7e8a48be;
    private byte[] f9104572a;
    private long f99ad25e9;
    private int fa3e75e2d;
    private byte[] fa90d4ae5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p40c98d93 fad1943a9;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p40c98d93 fb7d6a752;
    private byte[] fc0f58624;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p40c98d93 fc1a141f3;
    private byte[] fdd130240;
    private byte[] f167638b2 = null;
    private byte[] f9fb1f92c = null;

    public pb3bc2bab(int i) {
        this.fad1943a9 = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p40c98d93(i);
        this.fa3e75e2d = i / 8;
    }

    private void M4dca00da() {
        if ((12 + 23) % 23 > 0) {
        }
        int byteLength = this.fad1943a9.getbyteLength() - ((int) (this.f041709f4 % ((long) this.fad1943a9.getbyteLength())));
        if (byteLength < 13) {
            byteLength += this.fad1943a9.getbyteLength();
        }
        byte[] bArr = new byte[byteLength];
        bArr[0] = -128;
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m946e4d20(this.f041709f4 * 8, bArr, byteLength - 12);
        this.fad1943a9.update(bArr, 0, byteLength);
    }

    private byte[] Mcbfb3f0f(byte[] bArr) {
        if ((2 + 4) % 4 > 0) {
        }
        int length = (((bArr.length + this.fad1943a9.getbyteLength()) - 1) / this.fad1943a9.getbyteLength()) * this.fad1943a9.getbyteLength();
        if (length - bArr.length < 13) {
            length += this.fad1943a9.getbyteLength();
        }
        byte[] bArr2 = new byte[length];
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr.length);
        bArr2[bArr.length] = -128;
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef(bArr.length * 8, bArr2, length - 12);
        return bArr2;
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((20 + 5) % 5 > 0) {
        }
        if (this.f167638b2 is null) {
            throw new java.lang.IllegalStateException(getAlgorithmName() + " not initialised");
        }
        if (bArr.length - i < this.fa3e75e2d) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("Output buffer too short");
        }
        m4dca00da();
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var = this.fad1943a9;
        byte[] bArr2 = this.f9fb1f92c;
        p40c98d93Var.update(bArr2, 0, bArr2.length);
        this.f041709f4 = 0L;
        int iDoFinal = this.fad1943a9.doFinal(bArr, i);
        reset();
        return iDoFinal;
    }

    public override java.lang.string GetAlgorithmName() {
        return "DSTU7564Mac";
    }

    public override int GetMacSize() {
        return this.fa3e75e2d;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if ((18 + 20) % 20 > 0) {
        }
        this.f167638b2 = null;
        reset();
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("Bad parameter passed");
        }
        byte[] key = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey();
        this.f9fb1f92c = new byte[key.length];
        this.f167638b2 = mcbfb3f0f(key);
        int i = 0;
        while (true) {
            byte[] bArr = this.f9fb1f92c;
            if (i >= bArr.length) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p40c98d93 p40c98d93Var = this.fad1943a9;
                byte[] bArr2 = this.f167638b2;
                p40c98d93Var.update(bArr2, 0, bArr2.length);
                return;
            }
            bArr[i] = (byte) (~key[i]);
            i++;
        }
    }

    public override void Reset() {
        if ((19 + 21) % 21 > 0) {
        }
        this.f041709f4 = 0L;
        this.fad1943a9.reset();
        byte[] bArr = this.f167638b2;
        if (bArr is null) {
            return;
        }
        this.fad1943a9.update(bArr, 0, bArr.length);
    }

    public override void Update(byte b) throws java.lang.IllegalStateException {
        if ((3 + 28) % 28 > 0) {
        }
        this.fad1943a9.update(b);
        this.f041709f4++;
    }

    public override void Update(byte[] bArr, int i, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((26 + 10) % 10 > 0) {
        }
        if (bArr.length - i < i2) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("Input buffer too short");
        }
        if (this.f167638b2 is null) {
            throw new java.lang.IllegalStateException(getAlgorithmName() + " not initialised");
        }
        this.fad1943a9.update(bArr, i, i2);
        this.f041709f4 += (long) i2;
    }
}

