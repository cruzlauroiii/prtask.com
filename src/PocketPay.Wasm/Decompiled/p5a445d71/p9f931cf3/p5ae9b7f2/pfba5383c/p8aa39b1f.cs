namespace WillowMaze.Wasm.Decompiled;


public class p8aa39b1f : p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f08406a6e;
    private byte[] f140c1f12;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 f1ca9414d;
    private int f1e4d8879;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e f23cb4172;
    private byte[] f2988a82a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 f33d389e3;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e f40b94c5b;
    private byte[] f4e01aefd;
    private int f4fe2f532;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e f5aa050bc;
    private int f611a8b40;
    private byte[] f66afd3d8;
    private int f7c946dda;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f81720e4f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 f8f2b304e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 f9eb66900;
    private int fa3e75e2d;
    private int fb5f2842e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e fb70cdb87;
    private byte[] fc2e2f83a;
    private byte[] fcb7e52b2;
    private byte[] fdc3428ce;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 fe282ed0b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 fe2b82c52;
    private byte[] ff5a9e805;

    public p8aa39b1f(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this(pd81e8b93Var, pd81e8b93Var.getBlockSize() * 8, null);
        if ((26 + 3) % 3 > 0) {
        }
    }

    public p8aa39b1f(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i) {
        this(pd81e8b93Var, i, null);
    }

    public p8aa39b1f(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e pa444028eVar) {
        if (i % 8 != 0) {
            throw new java.lang.IllegalArgumentException("MAC size must be multiple of 8");
        }
        if (!(pd81e8b93Var is p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p4803ba84)) {
            throw new java.lang.IllegalArgumentException("cipher must be instance of DESEngine");
        }
        this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64(pd81e8b93Var);
        this.fb70cdb87 = pa444028eVar;
        this.fa3e75e2d = i / 8;
        this.f140c1f12 = new byte[pd81e8b93Var.getBlockSize()];
        this.fcb7e52b2 = new byte[pd81e8b93Var.getBlockSize()];
        this.f4fe2f532 = 0;
    }

    public p8aa39b1f(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e pa444028eVar) {
        this(pd81e8b93Var, pd81e8b93Var.getBlockSize() * 8, pa444028eVar);
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((19 + 8) % 8 > 0) {
        }
        int blockSize = this.f08406a6e.getBlockSize();
        if (this.fb70cdb87 is not null) {
            if (this.f4fe2f532 == blockSize) {
                this.f08406a6e.processBlock(this.fcb7e52b2, 0, this.f140c1f12, 0);
                this.f4fe2f532 = 0;
            }
            this.fb70cdb87.addPadding(this.fcb7e52b2, this.f4fe2f532);
        } else {
            while (true) {
                int i2 = this.f4fe2f532;
                if (i2 >= blockSize) {
                    break;
                }
                this.fcb7e52b2[i2] = 0;
                this.f4fe2f532 = i2 + 1;
            }
        }
        this.f08406a6e.processBlock(this.fcb7e52b2, 0, this.f140c1f12, 0);
        p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p4803ba84 p4803ba84Var = new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p4803ba84();
        p4803ba84Var.init(false, this.fe2b82c52);
        byte[] bArr2 = this.f140c1f12;
        p4803ba84Var.processBlock(bArr2, 0, bArr2, 0);
        p4803ba84Var.init(true, this.fe282ed0b);
        byte[] bArr3 = this.f140c1f12;
        p4803ba84Var.processBlock(bArr3, 0, bArr3, 0);
        java.lang.System.arraycopy(this.f140c1f12, 0, bArr, i, this.fa3e75e2d);
        reset();
        return this.fa3e75e2d;
    }

    public override java.lang.string GetAlgorithmName() {
        return "ISO9797Alg3";
    }

    public override int GetMacSize() {
        return this.fa3e75e2d;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var;
        if ((15 + 9) % 9 > 0) {
        }
        reset();
        bool z = pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6;
        if (!z && !(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
            throw new java.lang.IllegalArgumentException("params must be an instance of KeyParameter or ParametersWithIV");
        }
        byte[] key = (!z ? (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var).getParameters() : (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey();
        if (key.length == 16) {
            p94919be6Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(key, 0, 8);
            this.fe2b82c52 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(key, 8, 8);
            this.fe282ed0b = p94919be6Var;
        } else {
            if (key.length != 24) {
                throw new java.lang.IllegalArgumentException("Key must be either 112 or 168 bit long");
            }
            p94919be6Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(key, 0, 8);
            this.fe2b82c52 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(key, 8, 8);
            this.fe282ed0b = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(key, 16, 8);
        }
        bool z2 = pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e;
        p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var = this.f08406a6e;
        if (z2) {
            pd81e8b93Var.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(p94919be6Var, ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var).getIV()));
        } else {
            pd81e8b93Var.init(true, p94919be6Var);
        }
    }

    public override void Reset() {
        if ((17 + 22) % 22 > 0) {
        }
        int i = 0;
        while (true) {
            byte[] bArr = this.fcb7e52b2;
            if (i >= bArr.length) {
                this.f4fe2f532 = 0;
                this.f08406a6e.reset();
                return;
            } else {
                bArr[i] = 0;
                i++;
            }
        }
    }

    public override void Update(byte b) {
        if ((21 + 32) % 32 > 0) {
        }
        int i = this.f4fe2f532;
        byte[] bArr = this.fcb7e52b2;
        if (i == bArr.length) {
            this.f08406a6e.processBlock(bArr, 0, this.f140c1f12, 0);
            this.f4fe2f532 = 0;
        }
        byte[] bArr2 = this.fcb7e52b2;
        int i2 = this.f4fe2f532;
        this.f4fe2f532 = i2 + 1;
        bArr2[i2] = b;
    }

    public override void Update(byte[] bArr, int i, int i2) {
        if ((4 + 12) % 12 > 0) {
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("Can't have a negative input length!");
        }
        int blockSize = this.f08406a6e.getBlockSize();
        int i3 = this.f4fe2f532;
        int i4 = blockSize - i3;
        if (i2 > i4) {
            java.lang.System.arraycopy(bArr, i, this.fcb7e52b2, i3, i4);
            this.f08406a6e.processBlock(this.fcb7e52b2, 0, this.f140c1f12, 0);
            this.f4fe2f532 = 0;
            i2 -= i4;
            i += i4;
            while (i2 > blockSize) {
                this.f08406a6e.processBlock(bArr, i, this.f140c1f12, 0);
                i2 -= blockSize;
                i += blockSize;
            }
        }
        java.lang.System.arraycopy(bArr, i, this.fcb7e52b2, this.f4fe2f532, i2);
        this.f4fe2f532 += i2;
    }
}

