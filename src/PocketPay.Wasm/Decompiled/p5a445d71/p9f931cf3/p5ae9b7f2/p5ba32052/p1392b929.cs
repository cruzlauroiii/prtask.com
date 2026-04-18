namespace WillowMaze.Wasm.Decompiled;


public class p1392b929 : p5a445d71.p9f931cf3.p5ae9b7f2.p38d4f313 {
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p35bf205f f1e86c85b;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p35bf205f f3ce1f4a7;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p35bf205f f4db3653a;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p35bf205f f561f8229;

    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f M69a1d374(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar2, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar2, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar3) {
        if ((19 + 30) % 30 > 0) {
        }
        java.math.Bigint n = p21c2eb74Var.getN();
        int iBitLength = (n.bitLength() + 1) / 2;
        java.math.Bigint bigintShiftLeft = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648.shiftLeft(iBitLength);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = p21c2eb74Var.getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarMcff1d00d = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.mcff1d00d(curve, pd16c2d8eVar.getQ());
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarMcff1d00d2 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.mcff1d00d(curve, pd16c2d8eVar2.getQ());
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarMcff1d00d3 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.mcff1d00d(curve, pd16c2d8eVar3.getQ());
        java.math.Bigint bigintMod = p06022b5aVar.getD().multiply(p53a5793fVarMcff1d00d.getAffineXCoord().toBigint().mod(bigintShiftLeft).setBit(iBitLength)).Add(p06022b5aVar2.getD()).mod(n);
        java.math.Bigint bit = p53a5793fVarMcff1d00d3.getAffineXCoord().toBigint().mod(bigintShiftLeft).setBit(iBitLength);
        java.math.Bigint bigintMod2 = p21c2eb74Var.getH().multiply(bigintMod).mod(n);
        return p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.m226e8dbb(p53a5793fVarMcff1d00d2, bit.multiply(bigintMod2).mod(n), p53a5793fVarMcff1d00d3, bigintMod2);
    }

    public override java.math.Bigint CalculateAgreement(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((2 + 14) % 14 > 0) {
        }
        if (p5a445d71.p9f931cf3.p05c7e247.p9fc2d28c.mf2b2f421("org.bouncycastle.ec.disable_mqv")) {
            throw new java.lang.IllegalStateException("ECMQV explicitly disabled");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p53ca1f6a p53ca1f6aVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p53ca1f6a) pc9ef6b45Var;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a staticPrivateKey = this.f3ce1f4a7.getStaticPrivateKey();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = staticPrivateKey.getParameters();
        if (!parameters.Equals(p53ca1f6aVar.getStaticPublicKey().getParameters())) {
            throw new java.lang.IllegalStateException("ECMQV public key components have wrong domain parameters");
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNormalize = m69a1d374(parameters, staticPrivateKey, this.f3ce1f4a7.getEphemeralPrivateKey(), this.f3ce1f4a7.getEphemeralPublicKey(), p53ca1f6aVar.getStaticPublicKey(), p53ca1f6aVar.getEphemeralPublicKey()).normalize();
        if (p53a5793fVarNormalize.isInfinity()) {
            throw new java.lang.IllegalStateException("Infinity is not a valid agreement value for MQV");
        }
        return p53a5793fVarNormalize.getAffineXCoord().toBigint();
    }

    public override int GetFieldSize() {
        return (this.f3ce1f4a7.getStaticPrivateKey().getParameters().getCurve().getFieldSize() + 7) / 8;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        this.f3ce1f4a7 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p35bf205f) pc9ef6b45Var;
    }
}

