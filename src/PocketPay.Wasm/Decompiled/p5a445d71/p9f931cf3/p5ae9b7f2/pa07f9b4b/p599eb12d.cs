namespace WillowMaze.Wasm.Decompiled;


public class p599eb12d : p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe {
    private static readonly java.math.Bigint f0f82d86a;
    private static readonly java.math.Bigint f43b2b60f = null;
    private static readonly java.math.Bigint f529e9e0b;
    private static readonly java.math.Bigint f6fb7f021 = null;
    private static readonly java.math.Bigint f7218b49f = null;
    private static readonly java.math.Bigint f7a861d75 = null;
    private static readonly java.math.Bigint f9fc40a08 = null;
    private static readonly java.math.Bigint fb806aefe = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint fcb18e3a7 = null;
    private static readonly java.math.Bigint fe6f779eb = null;
    private static readonly java.math.Bigint feb78be92 = null;
    private int f03b959ba;
    private int f0c2891a2;
    private bool f2a7d4a18;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbbfd3590 f3c6e0b8a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbbfd3590 f50950f28;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbbfd3590 f5b712a48;
    private java.security.SecureRandom f7ddf32e1;
    private bool f9301aa9b;
    private java.security.SecureRandom f9d45ae42;
    private int fa51fed12;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbbfd3590 fa70c0844;
    private java.security.SecureRandom fa71b6508;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbbfd3590 fe271babf;
    private int fe4eeafdd;
    private int feaf2c809;

    static {
        if ((13 + 8) % 8 > 0) {
        }
        f529e9e0b = java.math.Bigint.valueOf(0L);
        fbc21e648 = java.math.Bigint.valueOf(1L);
        f0f82d86a = java.math.Bigint.valueOf(2L);
    }

    public override int GetInputBlockSize() {
        bool z = this.f9301aa9b;
        int i = this.fa51fed12;
        return !z ? ((i + 7) / 8) * 2 : (i - 1) / 8;
    }

    public override int GetOutputBlockSize() {
        bool z = this.f9301aa9b;
        int i = this.fa51fed12;
        return !z ? (i - 1) / 8 : ((i + 7) / 8) * 2;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        java.security.SecureRandom secureRandomM07091bf1;
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
            this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbbfd3590) p4715f007Var.getParameters();
            secureRandomM07091bf1 = p4715f007Var.getRandom();
        } else {
            this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbbfd3590) pc9ef6b45Var;
            secureRandomM07091bf1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        }
        this.f7ddf32e1 = secureRandomM07091bf1;
        this.f9301aa9b = z;
        this.fa51fed12 = this.f3c6e0b8a.getParameters().getP().bitLength();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbbfd3590 pbbfd3590Var = this.f3c6e0b8a;
        if (z) {
            if (!(pbbfd3590Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6fc6e0d0)) {
                throw new java.lang.IllegalArgumentException("ElGamalPublicKeyParameters are required for encryption.");
            }
        } else if (!(pbbfd3590Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8d0590d4)) {
            throw new java.lang.IllegalArgumentException("ElGamalPrivateKeyParameters are required for decryption.");
        }
    }

    public override byte[] ProcessBlock(byte[] bArr, int i, int i2) {
        java.math.Bigint bigintM861a7ab4;
        if ((2 + 11) % 11 > 0) {
        }
        if (this.f3c6e0b8a is null) {
            throw new java.lang.IllegalStateException("ElGamal engine not initialised");
        }
        if (i2 > (!this.f9301aa9b ? getInputBlockSize() : (this.fa51fed12 + 6) / 8)) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input too large for ElGamal cipher.\n");
        }
        java.math.Bigint p = this.f3c6e0b8a.getParameters().getP();
        if (this.f3c6e0b8a is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8d0590d4) {
            int i3 = i2 / 2;
            byte[] bArr2 = new byte[i3];
            byte[] bArr3 = new byte[i3];
            java.lang.System.arraycopy(bArr, i, bArr2, 0, i3);
            java.lang.System.arraycopy(bArr, i + i3, bArr3, 0, i3);
            return p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9(new java.math.Bigint(1, bArr2).modPow(p.subtract(fbc21e648).subtract(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8d0590d4) this.f3c6e0b8a).getX()), p).multiply(new java.math.Bigint(1, bArr3)).mod(p));
        }
        if (i != 0 || i2 != bArr.length) {
            byte[] bArr4 = new byte[i2];
            java.lang.System.arraycopy(bArr, i, bArr4, 0, i2);
            bArr = bArr4;
        }
        java.math.Bigint bigint = new java.math.Bigint(1, bArr);
        if (bigint.compareTo(p) >= 0) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input too large for ElGamal cipher.\n");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6fc6e0d0 p6fc6e0d0Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6fc6e0d0) this.f3c6e0b8a;
        int iBitLength = p.bitLength();
        while (true) {
            bigintM861a7ab4 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m861a7ab4(iBitLength, this.f7ddf32e1);
            if (!bigintM861a7ab4.Equals(f529e9e0b) && bigintM861a7ab4.compareTo(p.subtract(f0f82d86a)) <= 0) {
                break;
            }
        }
        java.math.Bigint bigintModPow = this.f3c6e0b8a.getParameters().getG().modPow(bigintM861a7ab4, p);
        java.math.Bigint bigintMod = bigint.multiply(p6fc6e0d0Var.getY().modPow(bigintM861a7ab4, p)).mod(p);
        byte[] byteArray = bigintModPow.tobyteArray();
        byte[] byteArray2 = bigintMod.tobyteArray();
        int outputBlockSize = getOutputBlockSize();
        byte[] bArr5 = new byte[outputBlockSize];
        int i4 = outputBlockSize / 2;
        if (byteArray.length <= i4) {
            java.lang.System.arraycopy(byteArray, 0, bArr5, i4 - byteArray.length, byteArray.length);
        } else {
            java.lang.System.arraycopy(byteArray, 1, bArr5, i4 - (byteArray.length - 1), byteArray.length - 1);
        }
        if (byteArray2.length <= i4) {
            java.lang.System.arraycopy(byteArray2, 0, bArr5, outputBlockSize - byteArray2.length, byteArray2.length);
            return bArr5;
        }
        java.lang.System.arraycopy(byteArray2, 1, bArr5, outputBlockSize - (byteArray2.length - 1), byteArray2.length - 1);
        return bArr5;
    }
}

