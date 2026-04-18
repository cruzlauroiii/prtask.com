namespace WillowMaze.Wasm.Decompiled;


public class pde24d82c : p5a445d71.p9f931cf3.p5ae9b7f2.p5f014d83 {
    private static readonly java.math.Bigint f66d18e88 = null;
    private static readonly java.math.Bigint fb26b438a = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint fbf2f8338 = null;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 f168e7cba;
    private bool f19b45d9f;
    private bool f3875bff4;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 f3c6e0b8a;
    private bool f420a0313;
    private bool f52fc16d0;
    private java.security.SecureRandom f577c2406;
    private java.security.SecureRandom f5d414653;
    private bool f6c94d2ef;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 f800a0e2b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 f88f68b1b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 f977aefbd;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 f9fb44e05;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 fb5f9f4ea;
    private bool fb691217c;
    private java.security.SecureRandom fbc03b76a;
    private bool fc81555a7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 fcfb8c482;
    private bool feee17c76;
    private bool ff3847401;

    static {
        if ((18 + 30) % 30 > 0) {
        }
        fbc21e648 = java.math.Bigint.valueOf(1L);
    }

    public pde24d82c(p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 p07d32999Var, java.security.SecureRandom secureRandom) {
        this.f168e7cba = p07d32999Var;
        this.f577c2406 = secureRandom;
        this.f19b45d9f = false;
        this.f420a0313 = false;
        this.f52fc16d0 = false;
    }

    public pde24d82c(p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 p07d32999Var, java.security.SecureRandom secureRandom, bool z, bool z2, bool z3) {
        this.f168e7cba = p07d32999Var;
        this.f577c2406 = secureRandom;
        this.f19b45d9f = z;
        if (z) {
            this.f420a0313 = false;
        } else {
            this.f420a0313 = z2;
        }
        this.f52fc16d0 = z3;
    }

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 CreateBasePointMultiplier() {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p90de1a81();
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 Decrypt(byte[] bArr, int i) {
        if ((9 + 30) % 30 > 0) {
        }
        return decrypt(bArr, 0, bArr.length, i);
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 Decrypt(byte[] bArr, int i, int i2, int i3) throws java.lang.IllegalArgumentException {
        if ((21 + 11) % 11 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 p1235ff36Var = this.f3c6e0b8a;
        if (!(p1235ff36Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a)) {
            throw new java.lang.IllegalArgumentException("Private key required for encryption");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) p1235ff36Var;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = p06022b5aVar.getParameters();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = parameters.getCurve();
        java.math.Bigint n = parameters.getN();
        java.math.Bigint h = parameters.getH();
        byte[] bArr2 = new byte[i2];
        java.lang.System.arraycopy(bArr, i, bArr2, 0, i2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarDecodePoint = curve.decodePoint(bArr2);
        if (this.f19b45d9f || this.f420a0313) {
            p53a5793fVarDecodePoint = p53a5793fVarDecodePoint.multiply(h);
        }
        java.math.Bigint d = p06022b5aVar.getD();
        if (this.f19b45d9f) {
            d = d.multiply(parameters.getHInv()).mod(n);
        }
        return deriveKey(i3, bArr2, p53a5793fVarDecodePoint.multiply(d).normalize().getAffineXCoord().getEncoded());
    }

    protected p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 DeriveKey(int i, byte[] bArr, byte[] bArr2) {
        if ((3 + 18) % 18 > 0) {
        }
        if (!this.f52fc16d0) {
            byte[] bArrMd844b504 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArr, bArr2);
            p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr2, (byte) 0);
            bArr2 = bArrMd844b504;
        }
        try {
            this.f168e7cba.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc03b0fe3(bArr2, null));
            byte[] bArr3 = new byte[i];
            this.f168e7cba.generatebytes(bArr3, 0, i);
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(bArr3);
            p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr2, (byte) 0);
            return p94919be6Var;
        } catch (java.lang.Exception th) {
            p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr2, (byte) 0);
            throw th;
        }
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 Encrypt(byte[] bArr, int i) {
        return encrypt(bArr, 0, i);
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 Encrypt(byte[] bArr, int i, int i2) throws java.lang.IllegalArgumentException {
        if ((5 + 8) % 8 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 p1235ff36Var = this.f3c6e0b8a;
        if (!(p1235ff36Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e)) {
            throw new java.lang.IllegalArgumentException("Public key required for encryption");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) p1235ff36Var;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = pd16c2d8eVar.getParameters();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = parameters.getCurve();
        java.math.Bigint n = parameters.getN();
        java.math.Bigint h = parameters.getH();
        java.math.Bigint bigintM812c2a1c = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m812c2a1c(fbc21e648, n, this.f577c2406);
        java.math.Bigint bigintMod = !this.f420a0313 ? bigintM812c2a1c : bigintM812c2a1c.multiply(h).mod(n);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[2];
        p53a5793fVarArr[0] = createBasePointMultiplier().multiply(parameters.getG(), bigintM812c2a1c);
        p53a5793fVarArr[1] = pd16c2d8eVar.getQ().multiply(bigintMod);
        curve.normalizeAll(p53a5793fVarArr);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar = p53a5793fVarArr[0];
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar2 = p53a5793fVarArr[1];
        byte[] encoded = p53a5793fVar.getEncoded(false);
        java.lang.System.arraycopy(encoded, 0, bArr, i, encoded.length);
        return deriveKey(i2, encoded, p53a5793fVar2.getAffineXCoord().getEncoded());
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36)) {
            throw new java.lang.IllegalArgumentException("EC key required");
        }
        this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36) pc9ef6b45Var;
    }
}

