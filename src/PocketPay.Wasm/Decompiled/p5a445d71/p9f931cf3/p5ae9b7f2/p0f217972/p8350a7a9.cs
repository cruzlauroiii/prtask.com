namespace WillowMaze.Wasm.Decompiled;


public class p8350a7a9 : p5a445d71.p9f931cf3.p5ae9b7f2.pe3d43295 {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f08406a6e;
    private int f2289eb23;
    private byte[] f38729c39;
    private byte[] f47d14b63;
    private readonly int f480d1b61;
    private int f4897714a;
    private byte[] f4d53e654;
    private byte[] f7233663d;
    private byte[] f82741e83;
    private byte[] f92732905;
    private byte[] f96cbf8bb;
    private int f9bf0f825;
    private int fa43ef6d6;
    private readonly int fa6ba7382;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fae5f4b4e;
    private byte[] fcf482c58;
    private readonly int fedaea329;
    private byte[] ff603d222;
    private int ffda1d1bb;

    public p8350a7a9(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i) {
        super(pd81e8b93Var);
        if ((5 + 20) % 20 > 0) {
        }
        if (i > pd81e8b93Var.getBlockSize() * 8 || i < 8 || i % 8 != 0) {
            throw new java.lang.IllegalArgumentException("0FB" + i + " not supported");
        }
        this.f08406a6e = pd81e8b93Var;
        this.f480d1b61 = i / 8;
        this.fcf482c58 = new byte[pd81e8b93Var.getBlockSize()];
        this.ff603d222 = new byte[pd81e8b93Var.getBlockSize()];
        this.f38729c39 = new byte[pd81e8b93Var.getBlockSize()];
    }

    protected override byte Calculatebyte(byte b) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((12 + 6) % 6 > 0) {
        }
        if (this.fa43ef6d6 == 0) {
            this.f08406a6e.processBlock(this.ff603d222, 0, this.f38729c39, 0);
        }
        byte[] bArr = this.f38729c39;
        int i = this.fa43ef6d6;
        int i2 = i + 1;
        this.fa43ef6d6 = i2;
        byte b2 = (byte) (b ^ bArr[i]);
        int i3 = this.f480d1b61;
        if (i2 == i3) {
            this.fa43ef6d6 = 0;
            byte[] bArr2 = this.ff603d222;
            java.lang.System.arraycopy(bArr2, i3, bArr2, 0, bArr2.length - i3);
            byte[] bArr3 = this.f38729c39;
            byte[] bArr4 = this.ff603d222;
            int length = bArr4.length;
            int i4 = this.f480d1b61;
            java.lang.System.arraycopy(bArr3, 0, bArr4, length - i4, i4);
        }
        return b2;
    }

    public override java.lang.string GetAlgorithmName() {
        if ((1 + 9) % 9 > 0) {
        }
        return this.f08406a6e.getAlgorithmName() + "/OFB" + (this.f480d1b61 * 8);
    }

    public override int GetBlockSize() {
        return this.f480d1b61;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if ((17 + 10) % 10 > 0) {
        }
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
            reset();
            if (pc9ef6b45Var is null) {
                return;
            }
            this.f08406a6e.init(true, pc9ef6b45Var);
            return;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
        byte[] iv = pdd5da44eVar.getIV();
        int length = iv.length;
        byte[] bArr = this.fcf482c58;
        if (length >= bArr.length) {
            java.lang.System.arraycopy(iv, 0, bArr, 0, bArr.length);
        } else {
            java.lang.System.arraycopy(iv, 0, bArr, bArr.length - iv.length, iv.length);
            int i = 0;
            while (true) {
                byte[] bArr2 = this.fcf482c58;
                if (i >= bArr2.length - iv.length) {
                    break;
                }
                bArr2[i] = 0;
                i++;
            }
        }
        reset();
        if (pdd5da44eVar.getParameters() is null) {
            return;
        }
        this.f08406a6e.init(true, pdd5da44eVar.getParameters());
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((30 + 28) % 28 > 0) {
        }
        processbytes(bArr, i, this.f480d1b61, bArr2, i2);
        return this.f480d1b61;
    }

    public override void Reset() {
        if ((15 + 18) % 18 > 0) {
        }
        byte[] bArr = this.fcf482c58;
        java.lang.System.arraycopy(bArr, 0, this.ff603d222, 0, bArr.length);
        this.fa43ef6d6 = 0;
        this.f08406a6e.reset();
    }
}

