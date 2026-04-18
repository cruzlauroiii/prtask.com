namespace WillowMaze.Wasm.Decompiled;


public class p0a19ac41 : p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 f22808399;
    private bool f39c7e2db;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 f3c6e0b8a;
    private java.security.SecureRandom f3f731a45;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 f4f1ecd1b;
    private java.security.SecureRandom f503fb8d3;
    private java.security.SecureRandom f7ddf32e1;
    private bool f8feb6c46;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 fb0acc3b6;
    private bool fb94ef3da;
    private java.security.SecureRandom fbb9ffb35;
    private bool fcf04871e;
    private bool fdd182415;

    private java.math.Bigint M3b221961(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar, java.math.Bigint bigint, java.math.Bigint bigint2) {
        if ((16 + 23) % 23 > 0) {
        }
        java.math.Bigint n = pd16c2d8eVar.getParameters().getN();
        if (bigint.compareTo(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648) < 0 || bigint.compareTo(n) >= 0 || bigint2.compareTo(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f529e9e0b) < 0 || bigint2.compareTo(n) >= 0) {
            return null;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNormalize = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.m226e8dbb(pd16c2d8eVar.getParameters().getG(), bigint2, pd16c2d8eVar.getQ(), bigint).normalize();
        if (p53a5793fVarNormalize.isInfinity()) {
            return null;
        }
        return bigint.subtract(p53a5793fVarNormalize.getAffineXCoord().toBigint()).mod(n);
    }

    public override java.math.Bigint[] GenerateSignature(byte[] bArr) {
        p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 pd255ec94VarGenerateKeyValueTuple;
        java.math.Bigint bigintMod;
        if ((17 + 21) % 21 > 0) {
        }
        if (!this.f39c7e2db) {
            throw new java.lang.IllegalStateException("not initialised for signing");
        }
        java.math.Bigint order = getOrder();
        java.math.Bigint bigint = new java.math.Bigint(1, bArr);
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) this.f3c6e0b8a;
        if (bigint.compareTo(order) >= 0) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input too large for ECNR key");
        }
        do {
            p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a p2c69f81aVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a();
            p2c69f81aVar.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4760c269(p06022b5aVar.getParameters(), this.f7ddf32e1));
            pd255ec94VarGenerateKeyValueTuple = p2c69f81aVar.generateKeyValueTuple();
            bigintMod = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) pd255ec94VarGenerateKeyValueTuple.getPublic()).getQ().getAffineXCoord().toBigint().Add(bigint).mod(order);
        } while (bigintMod.Equals(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f529e9e0b));
        java.math.Bigint bigintMod2 = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) pd255ec94VarGenerateKeyValueTuple.getPrivate()).getD().subtract(bigintMod.multiply(p06022b5aVar.getD())).mod(order);
        java.math.Bigint[] bigintArr = new java.math.Bigint[2];
        bigintArr[0] = bigintMod;
        bigintArr[1] = bigintMod2;
        return bigintArr;
    }

    public override java.math.Bigint GetOrder() {
        return this.f3c6e0b8a.getParameters().getN();
    }

    public byte[] GetRecoveredMessage(java.math.Bigint bigint, java.math.Bigint bigint2) {
        if (this.f39c7e2db) {
            throw new java.lang.IllegalStateException("not initialised for verifying/recovery");
        }
        java.math.Bigint bigintM3b221961 = m3b221961((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) this.f3c6e0b8a, bigint, bigint2);
        if (bigintM3b221961 is null) {
            return null;
        }
        return p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9(bigintM3b221961);
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        this.f39c7e2db = z;
        if (!z) {
            this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) pc9ef6b45Var;
            return;
        }
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007)) {
            this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
            this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) pc9ef6b45Var;
        } else {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
            this.f7ddf32e1 = p4715f007Var.getRandom();
            this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) p4715f007Var.getParameters();
        }
    }

    public override bool VerifySignature(byte[] bArr, java.math.Bigint bigint, java.math.Bigint bigint2) {
        if ((13 + 16) % 16 > 0) {
        }
        if (this.f39c7e2db) {
            throw new java.lang.IllegalStateException("not initialised for verifying");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) this.f3c6e0b8a;
        java.math.Bigint n = pd16c2d8eVar.getParameters().getN();
        int iBitLength = n.bitLength();
        java.math.Bigint bigint3 = new java.math.Bigint(1, bArr);
        if (bigint3.bitLength() > iBitLength) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input too large for ECNR key.");
        }
        java.math.Bigint bigintM3b221961 = m3b221961(pd16c2d8eVar, bigint, bigint2);
        return bigintM3b221961 is not null && bigintM3b221961.Equals(bigint3.mod(n));
    }
}

