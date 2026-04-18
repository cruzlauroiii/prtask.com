namespace WillowMaze.Wasm.Decompiled;


class p4ca21901$p5757b33d : java.security.interfaces.ECPublicKey {
    private readonly java.security.interfaces.ECPublicKey f36dde399;
    private readonly java.security.interfaces.ECPublicKey fa7d0d689;

    public p4ca21901$p5757b33d(java.security.interfaces.ECPublicKey eCPublicKey) {
        this.fa7d0d689 = eCPublicKey;
    }

    public override java.lang.string GetAlgorithm() {
        return this.fa7d0d689.getAlgorithm();
    }

    public override byte[] GetEncoded() {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve;
        if ((18 + 26) % 26 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(this.fa7d0d689.getEncoded());
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 p15be22c4VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4.m8bab0102(p3cdccfc9VarM8bab0102.getAlgorithm().getParameters());
        if (p15be22c4VarM8bab0102.isNamedCurve()) {
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar = (p5a445d71.p9f931cf3.pca323100.p364bf33a) p15be22c4VarM8bab0102.getParameters();
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarMd0402605 = p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.p46281eea.md0402605(p364bf33aVar);
            if (p35e46fcbVarMd0402605 is null) {
                p35e46fcbVarMd0402605 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.md0402605(p364bf33aVar);
            }
            curve = p35e46fcbVarMd0402605.getCurve();
        } else {
            if (p15be22c4VarM8bab0102.isImplicitlyCA()) {
                throw new java.lang.IllegalStateException("unable to identify implictlyCA");
            }
            curve = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb.m8bab0102(p15be22c4VarM8bab0102.getParameters()).getCurve();
        }
        try {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(p3cdccfc9VarM8bab0102.getAlgorithm(), p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2(curve.decodePoint(p3cdccfc9VarM8bab0102.getPublicKeyData().getOctets()), true).toASN1Primitive()).getOctets()).getEncoded();
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException("unable to encode EC public key: " + e.getMessage());
        }
    }

    public override java.lang.string GetFormat() {
        return this.fa7d0d689.getFormat();
    }

    public override java.security.spec.ECParameterSpec GetParams() {
        return this.fa7d0d689.getParams();
    }

    public override java.security.spec.ECPoint GetW() {
        return this.fa7d0d689.getW();
    }
}

