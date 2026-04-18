namespace WillowMaze.Wasm.Decompiled;


public class p52f19097 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f09aeb038;
    private java.math.Bigint f2e469222;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f3c6e0b8a;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f4d5ebfbe;
    private java.math.Bigint f5b595ba5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f666a5552;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f8edaa94d;
    private java.math.Bigint faf47e31e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a fbc5dbbd8;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a fd86a5f59;
    private java.math.Bigint fe530f0bd;
    private java.math.Bigint ff1bbb1b6;

    public p52f19097(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.fc10f7796 = pe5cfc515Var;
    }

    private static java.math.Bigint M1389ace5(byte[] bArr) {
        if ((1 + 9) % 9 > 0) {
        }
        int length = bArr.length;
        byte[] bArr2 = new byte[length];
        for (int i = 0; i != length; i++) {
            bArr2[i] = bArr[(bArr.length - i) - 1];
        }
        return new java.math.Bigint(1, bArr2);
    }

    private byte[] Mcda6f6a8(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        if ((31 + 26) % 26 > 0) {
        }
        java.math.Bigint bigint = p53a5793fVar.getAffineXCoord().toBigint();
        java.math.Bigint bigint2 = p53a5793fVar.getAffineYCoord().toBigint();
        int i = bigint.tobyteArray().length <= 33 ? 32 : 64;
        int i2 = i * 2;
        byte[] bArr = new byte[i2];
        byte[] bArrMec6269b9 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9(i, bigint);
        byte[] bArrMec6269b92 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9(i, bigint2);
        for (int i3 = 0; i3 != i; i3++) {
            bArr[i3] = bArrMec6269b9[(i - i3) - 1];
        }
        for (int i4 = 0; i4 != i; i4++) {
            bArr[i + i4] = bArrMec6269b92[(i - i4) - 1];
        }
        this.fc10f7796.update(bArr, 0, i2);
        byte[] bArr2 = new byte[this.fc10f7796.getDigestSize()];
        this.fc10f7796.doFinal(bArr2, 0);
        return bArr2;
    }

    public byte[] CalculateAgreement(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((6 + 19) % 19 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) pc9ef6b45Var;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = this.f3c6e0b8a.getParameters();
        if (!parameters.Equals(pd16c2d8eVar.getParameters())) {
            throw new java.lang.IllegalStateException("ECVKO public key has wrong domain parameters");
        }
        java.math.Bigint bigintMod = parameters.getH().multiply(this.fe530f0bd).multiply(this.f3c6e0b8a.getD()).mod(parameters.getN());
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarMcff1d00d = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.mcff1d00d(parameters.getCurve(), pd16c2d8eVar.getQ());
        if (p53a5793fVarMcff1d00d.isInfinity()) {
            throw new java.lang.IllegalStateException("Infinity is not a valid public key for ECDHC");
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNormalize = p53a5793fVarMcff1d00d.multiply(bigintMod).normalize();
        if (p53a5793fVarNormalize.isInfinity()) {
            throw new java.lang.IllegalStateException("Infinity is not a valid agreement value for ECVKO");
        }
        return mcda6f6a8(p53a5793fVarNormalize);
    }

    public int GetFieldSize() {
        return (this.f3c6e0b8a.getParameters().getCurve().getFieldSize() + 7) / 8;
    }

    public void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p473e31bf p473e31bfVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p473e31bf) pc9ef6b45Var;
        this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) p473e31bfVar.getParameters();
        this.fe530f0bd = m1389ace5(p473e31bfVar.getUKM());
    }
}

