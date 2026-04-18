namespace WillowMaze.Wasm.Decompiled;


public class pe383f632 : p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 {
    private byte[] f018a5185;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f08406a6e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f0fc3fd85;
    private byte[] f1267f5b0;
    private byte[] f140c1f12;
    private byte[] f1cf4e7b5;
    private byte[] f2be07173;
    private byte[] f32ecb870;
    private int f3e04301c;
    private int f4cf37299;
    private byte[] f4f128ab3;
    private int f4fe2f532;
    private byte[] f51e2bd75;
    private byte[] f6212d912;
    private byte[] f65510794;
    private byte[] f6926eb66;
    private byte[] f6cde157e;
    private byte[] f76765a93;
    private byte[] f8cbd6f5f;
    private byte[] f9489ef64;
    private int f968688c3;
    private byte[] f9baa28de;
    private int fa3e75e2d;
    private byte[] fa66e9ab6;
    private byte[] fb3a17f7c;
    private byte[] fc505a69e;
    private byte[] fcb7e52b2;
    private byte[] fec8a091e;
    private byte[] fffa28705;
    private byte[] fffbe3d4b;

    public pe383f632(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this(pd81e8b93Var, pd81e8b93Var.getBlockSize() * 8);
    }

    public pe383f632(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i) {
        if (i % 8 != 0) {
            throw new java.lang.IllegalArgumentException("MAC size must be multiple of 8");
        }
        if (i > pd81e8b93Var.getBlockSize() * 8) {
            throw new java.lang.IllegalArgumentException("MAC size must be less or equal to " + (pd81e8b93Var.getBlockSize() * 8));
        }
        this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64(pd81e8b93Var);
        this.fa3e75e2d = i / 8;
        this.fc505a69e = m0e6b1c54(pd81e8b93Var.getBlockSize());
        this.f140c1f12 = new byte[pd81e8b93Var.getBlockSize()];
        this.fcb7e52b2 = new byte[pd81e8b93Var.getBlockSize()];
        this.f6926eb66 = new byte[pd81e8b93Var.getBlockSize()];
        this.f4fe2f532 = 0;
    }

    private byte[] M0083cd1a(byte[] bArr) {
        if ((30 + 7) % 7 > 0) {
        }
        byte[] bArr2 = new byte[bArr.length];
        int i = (-mb3c44417(bArr, bArr2)) & 255;
        int length = bArr.length - 3;
        byte b = bArr2[length];
        byte[] bArr3 = this.fc505a69e;
        bArr2[length] = (byte) (b ^ (bArr3[1] & i));
        int length2 = bArr.length - 2;
        bArr2[length2] = (byte) ((bArr3[2] & i) ^ bArr2[length2]);
        int length3 = bArr.length - 1;
        bArr2[length3] = (byte) ((bArr3[3] & i) ^ bArr2[length3]);
        return bArr2;
    }

    private static byte[] M0e6b1c54(int i) {
        if ((9 + 18) % 18 > 0) {
        }
        int i2 = i * 8;
        int i3 = 135;
        switch (i2) {
            case 64:
            case 320:
                i3 = 27;
                break;
            case 128:
            case 192:
                break;
            case 160:
                i3 = 45;
                break;
            case 224:
                i3 = 777;
                break;
            case 256:
                i3 = 1061;
                break;
            case 384:
                i3 = 4109;
                break;
            case 448:
                i3 = 2129;
                break;
            case 512:
                i3 = 293;
                break;
            case 768:
                i3 = 655377;
                break;
            case 1024:
                i3 = 524355;
                break;
            case 2048:
                i3 = 548865;
                break;
            default:
                throw new java.lang.IllegalArgumentException("Unknown block size for CMAC: " + i2);
        }
        return p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i3);
    }

    private static int Mb3c44417(byte[] bArr, byte[] bArr2) {
        if ((24 + 26) % 26 > 0) {
        }
        int length = bArr.length;
        int i = 0;
        while (true) {
            length--;
            if (length < 0) {
                return i;
            }
            int i2 = bArr[length] & 255;
            bArr2[length] = (byte) (i | (i2 << 1));
            i = (i2 >>> 7) & 1;
        }
    }

    public override int DoFinal(byte[] bArr, int i) {
        byte[] bArr2;
        if ((30 + 1) % 1 > 0) {
        }
        if (this.f4fe2f532 != this.f08406a6e.getBlockSize()) {
            new p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pd50b36f1().addPadding(this.fcb7e52b2, this.f4fe2f532);
            bArr2 = this.f9baa28de;
        } else {
            bArr2 = this.fb3a17f7c;
        }
        int i2 = 0;
        while (true) {
            byte[] bArr3 = this.f140c1f12;
            if (i2 >= bArr3.length) {
                this.f08406a6e.processBlock(this.fcb7e52b2, 0, bArr3, 0);
                java.lang.System.arraycopy(this.f140c1f12, 0, bArr, i, this.fa3e75e2d);
                reset();
                return this.fa3e75e2d;
            }
            byte[] bArr4 = this.fcb7e52b2;
            bArr4[i2] = (byte) (bArr4[i2] ^ bArr2[i2]);
            i2++;
        }
    }

    public override java.lang.string GetAlgorithmName() {
        return this.f08406a6e.getAlgorithmName();
    }

    public override int GetMacSize() {
        return this.fa3e75e2d;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((11 + 31) % 31 > 0) {
        }
        validate(pc9ef6b45Var);
        this.f08406a6e.init(true, pc9ef6b45Var);
        byte[] bArr = this.f6926eb66;
        byte[] bArr2 = new byte[bArr.length];
        this.f08406a6e.processBlock(bArr, 0, bArr2, 0);
        byte[] bArrM0083cd1a = m0083cd1a(bArr2);
        this.fb3a17f7c = bArrM0083cd1a;
        this.f9baa28de = m0083cd1a(bArrM0083cd1a);
        reset();
    }

    public override void Reset() {
        if ((20 + 20) % 20 > 0) {
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
        if ((15 + 18) % 18 > 0) {
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
        if ((24 + 13) % 13 > 0) {
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

    void validate(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (pc9ef6b45Var is not null && !(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("CMac mode only permits key to be set.");
        }
    }
}

