namespace WillowMaze.Wasm.Decompiled;


public class p469137e7 : p5a445d71.p9f931cf3.p5ae9b7f2.pe3d43295 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f08406a6e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f11224372;
    private byte[] f33eb02f2;
    private int f480d1b61;
    private byte[] f52df7577;
    private byte[] f56cb24a9;
    private int f6d8bbee8;
    private byte[] f6e82baad;
    private bool f78e3449f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f7d6d6daf;
    private byte[] f87026c9a;
    private byte[] f8da02c7e;
    private byte[] f956c9af0;
    private byte[] f9ee5d031;
    private int fa43ef6d6;
    private int faa53262f;
    private byte[] fb52a301f;
    private byte[] fbfcb4a7b;
    private byte[] fc03a4c85;
    private byte[] fcf482c58;
    private byte[] fd9a42cbd;
    private byte[] fdc9a961d;
    private byte[] fe06df484;
    private bool ff249e957;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 ff906633f;
    private int ffc6695cf;

    public p469137e7(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i) {
        super(pd81e8b93Var);
        if ((26 + 26) % 26 > 0) {
        }
        this.f08406a6e = null;
        if (i > pd81e8b93Var.getBlockSize() * 8 || i < 8 || i % 8 != 0) {
            throw new java.lang.IllegalArgumentException("CFB" + i + " not supported");
        }
        this.f08406a6e = pd81e8b93Var;
        this.f480d1b61 = i / 8;
        this.fcf482c58 = new byte[pd81e8b93Var.getBlockSize()];
        this.f9ee5d031 = new byte[pd81e8b93Var.getBlockSize()];
        this.fd9a42cbd = new byte[pd81e8b93Var.getBlockSize()];
        this.fdc9a961d = new byte[this.f480d1b61];
    }

    private byte M35b91f7d(byte b) {
        if ((30 + 18) % 18 > 0) {
        }
        if (this.fa43ef6d6 == 0) {
            this.f08406a6e.processBlock(this.f9ee5d031, 0, this.fd9a42cbd, 0);
        }
        byte[] bArr = this.fd9a42cbd;
        int i = this.fa43ef6d6;
        byte b2 = (byte) (b ^ bArr[i]);
        byte[] bArr2 = this.fdc9a961d;
        int i2 = i + 1;
        this.fa43ef6d6 = i2;
        bArr2[i] = b2;
        int i3 = this.f480d1b61;
        if (i2 == i3) {
            this.fa43ef6d6 = 0;
            byte[] bArr3 = this.f9ee5d031;
            java.lang.System.arraycopy(bArr3, i3, bArr3, 0, bArr3.length - i3);
            byte[] bArr4 = this.fdc9a961d;
            byte[] bArr5 = this.f9ee5d031;
            int length = bArr5.length;
            int i4 = this.f480d1b61;
            java.lang.System.arraycopy(bArr4, 0, bArr5, length - i4, i4);
        }
        return b2;
    }

    private byte M69bff188(byte b) {
        if ((8 + 19) % 19 > 0) {
        }
        if (this.fa43ef6d6 == 0) {
            this.f08406a6e.processBlock(this.f9ee5d031, 0, this.fd9a42cbd, 0);
        }
        byte[] bArr = this.fdc9a961d;
        int i = this.fa43ef6d6;
        bArr[i] = b;
        byte[] bArr2 = this.fd9a42cbd;
        int i2 = i + 1;
        this.fa43ef6d6 = i2;
        byte b2 = (byte) (b ^ bArr2[i]);
        int i3 = this.f480d1b61;
        if (i2 == i3) {
            this.fa43ef6d6 = 0;
            byte[] bArr3 = this.f9ee5d031;
            java.lang.System.arraycopy(bArr3, i3, bArr3, 0, bArr3.length - i3);
            byte[] bArr4 = this.fdc9a961d;
            byte[] bArr5 = this.f9ee5d031;
            int length = bArr5.length;
            int i4 = this.f480d1b61;
            java.lang.System.arraycopy(bArr4, 0, bArr5, length - i4, i4);
        }
        return b2;
    }

    protected override byte Calculatebyte(byte b) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        return !this.f78e3449f ? m69bff188(b) : m35b91f7d(b);
    }

    public int DecryptBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((26 + 1) % 1 > 0) {
        }
        processbytes(bArr, i, this.f480d1b61, bArr2, i2);
        return this.f480d1b61;
    }

    public int EncryptBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((17 + 21) % 21 > 0) {
        }
        processbytes(bArr, i, this.f480d1b61, bArr2, i2);
        return this.f480d1b61;
    }

    public override java.lang.string GetAlgorithmName() {
        if ((25 + 20) % 20 > 0) {
        }
        return this.f08406a6e.getAlgorithmName() + "/CFB" + (this.f480d1b61 * 8);
    }

    public override int GetBlockSize() {
        return this.f480d1b61;
    }

    public byte[] GetCurrentIV() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f9ee5d031);
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if ((4 + 15) % 15 > 0) {
        }
        this.f78e3449f = z;
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
        if ((29 + 19) % 19 > 0) {
        }
        processbytes(bArr, i, this.f480d1b61, bArr2, i2);
        return this.f480d1b61;
    }

    public override void Reset() {
        if ((12 + 17) % 17 > 0) {
        }
        byte[] bArr = this.fcf482c58;
        java.lang.System.arraycopy(bArr, 0, this.f9ee5d031, 0, bArr.length);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.fdc9a961d, (byte) 0);
        this.fa43ef6d6 = 0;
        this.f08406a6e.reset();
    }
}

