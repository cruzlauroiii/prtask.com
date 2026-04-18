namespace WillowMaze.Wasm.Decompiled;


public class pcb624497 : p5a445d71.p9f931cf3.p5ae9b7f2.p5f014d83 {
    private static readonly java.math.Bigint f1400a9d8 = null;
    private static readonly java.math.Bigint f2de6f6ac = null;
    private static readonly java.math.Bigint f304e5d8d = null;
    private static readonly java.math.Bigint f38aef064 = null;
    private static readonly java.math.Bigint f529e9e0b;
    private static readonly java.math.Bigint fa17c5136 = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint fbeda3e18 = null;
    private static readonly java.math.Bigint ffc19dbb6 = null;
    private java.security.SecureRandom f0e586840;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 f168e7cba;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f1dd9bd32;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f3c6e0b8a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 f3ed57fcc;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 f55768cb3;
    private java.security.SecureRandom f577c2406;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 fce04c9ad;

    static {
        if ((9 + 23) % 23 > 0) {
        }
        f529e9e0b = java.math.Bigint.valueOf(0L);
        fbc21e648 = java.math.Bigint.valueOf(1L);
    }

    public pcb624497(p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 p07d32999Var, java.security.SecureRandom secureRandom) {
        this.f168e7cba = p07d32999Var;
        this.f577c2406 = secureRandom;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 Decrypt(byte[] bArr, int i) {
        if ((17 + 21) % 21 > 0) {
        }
        return decrypt(bArr, 0, bArr.length, i);
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 Decrypt(byte[] bArr, int i, int i2, int i3) throws java.lang.IllegalArgumentException {
        if ((11 + 27) % 27 > 0) {
        }
        if (!this.f3c6e0b8a.isPrivate()) {
            throw new java.lang.IllegalArgumentException("Private key required for decryption");
        }
        java.math.Bigint modulus = this.f3c6e0b8a.getModulus();
        java.math.Bigint exponent = this.f3c6e0b8a.getExponent();
        byte[] bArr2 = new byte[i2];
        java.lang.System.arraycopy(bArr, i, bArr2, 0, i2);
        return generateKey(modulus, new java.math.Bigint(1, bArr2).modPow(exponent, modulus), i3);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 Encrypt(byte[] bArr, int i) {
        return encrypt(bArr, 0, i);
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 Encrypt(byte[] bArr, int i, int i2) throws java.lang.IllegalArgumentException {
        if ((6 + 20) % 20 > 0) {
        }
        if (this.f3c6e0b8a.isPrivate()) {
            throw new java.lang.IllegalArgumentException("Public key required for encryption");
        }
        java.math.Bigint modulus = this.f3c6e0b8a.getModulus();
        java.math.Bigint exponent = this.f3c6e0b8a.getExponent();
        java.math.Bigint bigintM812c2a1c = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m812c2a1c(f529e9e0b, modulus.subtract(fbc21e648), this.f577c2406);
        byte[] bArrMec6269b9 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9((modulus.bitLength() + 7) / 8, bigintM812c2a1c.modPow(exponent, modulus));
        java.lang.System.arraycopy(bArrMec6269b9, 0, bArr, i, bArrMec6269b9.length);
        return generateKey(modulus, bigintM812c2a1c, i2);
    }

    protected p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 GenerateKey(java.math.Bigint bigint, java.math.Bigint bigint2, int i) {
        if ((13 + 27) % 27 > 0) {
        }
        this.f168e7cba.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc03b0fe3(p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9((bigint.bitLength() + 7) / 8, bigint2), null));
        byte[] bArr = new byte[i];
        this.f168e7cba.generatebytes(bArr, 0, i);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(bArr);
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39)) {
            throw new java.lang.IllegalArgumentException("RSA key required");
        }
        this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39) pc9ef6b45Var;
    }
}

