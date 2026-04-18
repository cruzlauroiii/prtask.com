namespace WillowMaze.Wasm.Decompiled;


public class pe3f477cc : p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d {
    java.security.SecureRandom f0d73ecb9;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 f3c6e0b8a;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 f521282b1;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 f6a4d3e1e;
    java.security.SecureRandom f7ddf32e1;
    java.security.SecureRandom f99486d04;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 fbe0b2d83;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 fd3b0f207;

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 CreateBasePointMultiplier() {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p90de1a81();
    }

    public override java.math.Bigint[] GenerateSignature(byte[] bArr) {
        if ((12 + 22) % 22 > 0) {
        }
        java.math.Bigint bigint = new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m4d9c2073(bArr));
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = this.f3c6e0b8a.getParameters();
        java.math.Bigint n = parameters.getN();
        java.math.Bigint d = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) this.f3c6e0b8a).getD();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 p267d2b96VarCreateBasePointMultiplier = createBasePointMultiplier();
        while (true) {
            java.math.Bigint bigintM861a7ab4 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m861a7ab4(n.bitLength(), this.f7ddf32e1);
            if (!bigintM861a7ab4.Equals(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f529e9e0b)) {
                java.math.Bigint bigintMod = p267d2b96VarCreateBasePointMultiplier.multiply(parameters.getG(), bigintM861a7ab4).normalize().getAffineXCoord().toBigint().mod(n);
                if (bigintMod.Equals(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f529e9e0b)) {
                    continue;
                } else {
                    java.math.Bigint bigintMod2 = bigintM861a7ab4.multiply(bigint).Add(d.multiply(bigintMod)).mod(n);
                    if (!bigintMod2.Equals(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f529e9e0b)) {
                        java.math.Bigint[] bigintArr = new java.math.Bigint[2];
                        bigintArr[0] = bigintMod;
                        bigintArr[1] = bigintMod2;
                        return bigintArr;
                    }
                }
            }
        }
    }

    public override java.math.Bigint GetOrder() {
        return this.f3c6e0b8a.getParameters().getN();
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
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
        if ((19 + 30) % 30 > 0) {
        }
        java.math.Bigint bigint3 = new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m4d9c2073(bArr));
        java.math.Bigint n = this.f3c6e0b8a.getParameters().getN();
        if (bigint.compareTo(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648) < 0 || bigint.compareTo(n) >= 0 || bigint2.compareTo(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648) < 0 || bigint2.compareTo(n) >= 0) {
            return false;
        }
        java.math.Bigint bigintMe90945d8 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.me90945d8(n, bigint3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNormalize = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.m226e8dbb(this.f3c6e0b8a.getParameters().getG(), bigint2.multiply(bigintMe90945d8).mod(n), ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) this.f3c6e0b8a).getQ(), n.subtract(bigint).multiply(bigintMe90945d8).mod(n)).normalize();
        if (p53a5793fVarNormalize.isInfinity()) {
            return false;
        }
        return p53a5793fVarNormalize.getAffineXCoord().toBigint().mod(n).Equals(bigint);
    }
}

