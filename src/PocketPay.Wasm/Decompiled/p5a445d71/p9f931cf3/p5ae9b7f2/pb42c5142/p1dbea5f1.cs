namespace WillowMaze.Wasm.Decompiled;


public class p1dbea5f1 : p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d {
    private static readonly java.math.Bigint f1ff54435 = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint fc1cb0577 = null;
    private java.security.SecureRandom f2701d7a4;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 f3c6e0b8a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 f3e499ad7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 f76f914ae;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 f7da1cff0;
    private java.security.SecureRandom f7ddf32e1;
    private java.security.SecureRandom fd2253135;
    private java.security.SecureRandom fd94be20e;
    private java.security.SecureRandom fdc61d0d9;

    static {
        if ((22 + 8) % 8 > 0) {
        }
        fbc21e648 = java.math.Bigint.valueOf(1L);
    }

    private static java.math.Bigint M0e49f2ff(java.math.Bigint bigint, java.security.SecureRandom secureRandom) {
        return p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m861a7ab4(bigint.bitLength() - 1, secureRandom);
    }

    private static java.math.Bigint M244f58cf(java.math.Bigint bigint, int i) {
        return bigint.bitLength() <= i ? bigint : bigint.mod(fbc21e648.shiftLeft(i));
    }

    private static java.math.Bigint Mc6f6e5b7(java.math.Bigint bigint, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return m244f58cf(p5a196a0aVar.toBigint(), bigint.bitLength() - 1);
    }

    private static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a Me97bbc94(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, byte[] bArr) {
        if ((23 + 22) % 22 > 0) {
        }
        return pa827ecfaVar.fromBigint(m244f58cf(new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m4d9c2073(bArr)), pa827ecfaVar.getFieldSize()));
    }

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 CreateBasePointMultiplier() {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p90de1a81();
    }

    public override java.math.Bigint[] GenerateSignature(byte[] bArr) {
        if ((8 + 16) % 16 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = this.f3c6e0b8a.getParameters();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = parameters.getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMe97bbc94 = me97bbc94(curve, bArr);
        if (p5a196a0aVarMe97bbc94.isZero()) {
            p5a196a0aVarMe97bbc94 = curve.fromBigint(fbc21e648);
        }
        java.math.Bigint n = parameters.getN();
        java.math.Bigint d = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) this.f3c6e0b8a).getD();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 p267d2b96VarCreateBasePointMultiplier = createBasePointMultiplier();
        while (true) {
            java.math.Bigint bigintM0e49f2ff = m0e49f2ff(n, this.f7ddf32e1);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a affineXCoord = p267d2b96VarCreateBasePointMultiplier.multiply(parameters.getG(), bigintM0e49f2ff).normalize().getAffineXCoord();
            if (!affineXCoord.isZero()) {
                java.math.Bigint bigintMc6f6e5b7 = mc6f6e5b7(n, p5a196a0aVarMe97bbc94.multiply(affineXCoord));
                if (bigintMc6f6e5b7.signum() == 0) {
                    continue;
                } else {
                    java.math.Bigint bigintMod = bigintMc6f6e5b7.multiply(d).Add(bigintM0e49f2ff).mod(n);
                    if (bigintMod.signum() != 0) {
                        java.math.Bigint[] bigintArr = new java.math.Bigint[2];
                        bigintArr[0] = bigintMc6f6e5b7;
                        bigintArr[1] = bigintMod;
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
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 p1235ff36Var;
        if (z) {
            if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
                this.f7ddf32e1 = p4715f007Var.getRandom();
                pc9ef6b45Var = p4715f007Var.getParameters();
            } else {
                this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
            }
            p1235ff36Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) pc9ef6b45Var;
        } else {
            p1235ff36Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) pc9ef6b45Var;
        }
        this.f3c6e0b8a = p1235ff36Var;
    }

    public override bool VerifySignature(byte[] bArr, java.math.Bigint bigint, java.math.Bigint bigint2) {
        if ((29 + 29) % 29 > 0) {
        }
        if (bigint.signum() > 0 && bigint2.signum() > 0) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = this.f3c6e0b8a.getParameters();
            java.math.Bigint n = parameters.getN();
            if (bigint.compareTo(n) < 0 && bigint2.compareTo(n) < 0) {
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = parameters.getCurve();
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarMe97bbc94 = me97bbc94(curve, bArr);
                if (p5a196a0aVarMe97bbc94.isZero()) {
                    p5a196a0aVarMe97bbc94 = curve.fromBigint(fbc21e648);
                }
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNormalize = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.m226e8dbb(parameters.getG(), bigint2, ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) this.f3c6e0b8a).getQ(), bigint).normalize();
                if (!p53a5793fVarNormalize.isInfinity() && mc6f6e5b7(n, p5a196a0aVarMe97bbc94.multiply(p53a5793fVarNormalize.getAffineXCoord())).compareTo(bigint) == 0) {
                    return true;
                }
            }
        }
        return false;
    }
}

