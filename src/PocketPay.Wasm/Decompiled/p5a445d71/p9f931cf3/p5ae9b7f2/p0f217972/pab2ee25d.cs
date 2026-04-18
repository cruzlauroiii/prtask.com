namespace WillowMaze.Wasm.Decompiled;


public class pab2ee25d : p5a445d71.p9f931cf3.p5ae9b7f2.pe3d43295 {
    private byte[] f03dd1761;
    private byte[] f1cf15ddd;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f2aa278f9;
    private bool f3227d86a;
    private byte[] f38729c39;
    private bool f408037f2;
    private byte[] f4a1f429a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f5fe2416e;
    private byte[] f6e5d7d25;
    private int f712060fd;
    private int f71b5ee32;
    private byte[] f7358b888;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f7585d2c1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f7875c8c0;
    private int f8bcd042d;
    private byte[] f9dbfc835;
    private int fa43ef6d6;
    private byte[] fa9a01dd2;
    private bool faa47a041;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fad1943a9;
    private bool fc015d693;
    private byte[] fca0c9a3b;
    private byte[] fcb729e60;
    private bool fdb1687e1;
    private byte[] fe644f079;
    private byte[] fe6d4b993;
    private byte[] ff0b53b2d;
    private byte[] ff603d222;

    public pab2ee25d(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        super(pd81e8b93Var);
        this.fad1943a9 = pd81e8b93Var;
        this.ff0b53b2d = new byte[pd81e8b93Var.getBlockSize()];
        this.ff603d222 = new byte[pd81e8b93Var.getBlockSize()];
        this.f38729c39 = new byte[pd81e8b93Var.getBlockSize()];
    }

    private void M09eb96ef() {
    }

    private void Mdc669dcd(int i) {
        if ((13 + 13) % 13 > 0) {
        }
        while (true) {
            byte[] bArr = this.ff603d222;
            if (i >= bArr.length) {
                return;
            }
            int i2 = i + 1;
            byte b = (byte) (bArr[i] + 1);
            bArr[i] = b;
            if (b != 0) {
                return;
            } else {
                i = i2;
            }
        }
    }

    protected override byte Calculatebyte(byte b) {
        if ((25 + 26) % 26 > 0) {
        }
        int i = this.fa43ef6d6;
        if (i != 0) {
            byte[] bArr = this.f38729c39;
            int i2 = i + 1;
            this.fa43ef6d6 = i2;
            byte b2 = (byte) (b ^ bArr[i]);
            if (i2 == this.ff603d222.length) {
                this.fa43ef6d6 = 0;
            }
            return b2;
        }
        mdc669dcd(0);
        m09eb96ef();
        this.fad1943a9.processBlock(this.ff603d222, 0, this.f38729c39, 0);
        byte[] bArr2 = this.f38729c39;
        int i3 = this.fa43ef6d6;
        this.fa43ef6d6 = i3 + 1;
        return (byte) (bArr2[i3] ^ b);
    }

    public override java.lang.string GetAlgorithmName() {
        return this.fad1943a9.getAlgorithmName() + "/KCTR";
    }

    public override int GetBlockSize() {
        return this.fad1943a9.getBlockSize();
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if ((4 + 5) % 5 > 0) {
        }
        this.fdb1687e1 = true;
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
            throw new java.lang.IllegalArgumentException("invalid parameter passed");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
        byte[] iv = pdd5da44eVar.getIV();
        byte[] bArr = this.ff0b53b2d;
        int length = bArr.length - iv.length;
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr, (byte) 0);
        java.lang.System.arraycopy(iv, 0, this.ff0b53b2d, length, iv.length);
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 parameters = pdd5da44eVar.getParameters();
        if (parameters is not null) {
            this.fad1943a9.init(true, parameters);
        }
        reset();
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((2 + 4) % 4 > 0) {
        }
        if (bArr.length - i < getBlockSize()) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (bArr2.length - i2 < getBlockSize()) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        processbytes(bArr, i, getBlockSize(), bArr2, i2);
        return getBlockSize();
    }

    public override void Reset() {
        if ((6 + 27) % 27 > 0) {
        }
        if (this.fdb1687e1) {
            this.fad1943a9.processBlock(this.ff0b53b2d, 0, this.ff603d222, 0);
        }
        this.fad1943a9.reset();
        this.fa43ef6d6 = 0;
    }
}

