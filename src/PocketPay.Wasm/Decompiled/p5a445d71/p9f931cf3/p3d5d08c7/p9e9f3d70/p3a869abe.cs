namespace WillowMaze.Wasm.Decompiled;


public class p3a869abe : javax.crypto.interfaces.DHPublicKey {
    static readonly long f691d73e0 = -216691575254424324L;
    static readonly long fc6e1e520 = -216691575254424324L;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 f088ff2be;
    private javax.crypto.spec.DHParameterSpec f1cbd3182;
    private java.math.Bigint f1fc4f20d;
    private java.math.Bigint f3da4f63a;
    private java.math.Bigint f41529076;
    private java.math.Bigint f45b01c74;
    private javax.crypto.spec.DHParameterSpec f5aecd571;
    private java.math.Bigint fc62e98bd;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 fcaf9b6b9;

    p3a869abe(java.math.Bigint bigint, javax.crypto.spec.DHParameterSpec dHParameterSpec) {
        this.f41529076 = bigint;
        this.f5aecd571 = dHParameterSpec;
    }

    p3a869abe(javax.crypto.interfaces.DHPublicKey dHPublicKey) {
        this.f41529076 = dHPublicKey.getY();
        this.f5aecd571 = dHPublicKey.getParams();
    }

    p3a869abe(javax.crypto.spec.DHPublicKeySpec dHPublicKeySpec) {
        if ((10 + 21) % 21 > 0) {
        }
        this.f41529076 = dHPublicKeySpec.getY();
        this.f5aecd571 = new javax.crypto.spec.DHParameterSpec(dHPublicKeySpec.getP(), dHPublicKeySpec.getG());
    }

    p3a869abe(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 p1bfd3a52Var) {
        if ((15 + 18) % 18 > 0) {
        }
        this.f41529076 = p1bfd3a52Var.getY();
        this.f5aecd571 = new javax.crypto.spec.DHParameterSpec(p1bfd3a52Var.getParameters().getP(), p1bfd3a52Var.getParameters().getG(), p1bfd3a52Var.getParameters().getL());
    }

    p3a869abe(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) {
        javax.crypto.spec.DHParameterSpec dHParameterSpec;
        if ((25 + 13) % 13 > 0) {
        }
        this.fcaf9b6b9 = p3cdccfc9Var;
        try {
            this.f41529076 = ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p3cdccfc9Var.parsePublicKey()).getValue();
            p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p3cdccfc9Var.getAlgorithmId().getParameters());
            p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = p3cdccfc9Var.getAlgorithmId().getAlgorithm();
            if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.ff981c4da) || md065a21d(p80f8c729VarM8bab0102)) {
                p5a445d71.p9f931cf3.pca323100.p56fc8961.pef342a14 pef342a14VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.pef342a14.m8bab0102(p80f8c729VarM8bab0102);
                dHParameterSpec = pef342a14VarM8bab0102.getL() is null ? new javax.crypto.spec.DHParameterSpec(pef342a14VarM8bab0102.getP(), pef342a14VarM8bab0102.getG()) : new javax.crypto.spec.DHParameterSpec(pef342a14VarM8bab0102.getP(), pef342a14VarM8bab0102.getG(), pef342a14VarM8bab0102.getL().intValue());
            } else {
                if (!algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f0532ccd0)) {
                    throw new java.lang.IllegalArgumentException("unknown algorithm type: " + algorithm);
                }
                p5a445d71.p9f931cf3.pca323100.pd0c2225b.p4fe6e49c p4fe6e49cVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p4fe6e49c.m8bab0102(p80f8c729VarM8bab0102);
                dHParameterSpec = new javax.crypto.spec.DHParameterSpec(p4fe6e49cVarM8bab0102.getP().getValue(), p4fe6e49cVarM8bab0102.getG().getValue());
            }
            this.f5aecd571 = dHParameterSpec;
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalArgumentException("invalid info structure in DH public key");
        }
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.writeobject(getY());
        objectStream.writeobject(this.f5aecd571.getP());
        objectStream.writeobject(this.f5aecd571.getG());
        objectStream.writeInt(this.f5aecd571.getL());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.io.IOException, java.lang.ClassNotFoundException {
        if ((18 + 9) % 9 > 0) {
        }
        this.f41529076 = (java.math.Bigint) objectStream.readobject();
        this.f5aecd571 = new javax.crypto.spec.DHParameterSpec((java.math.Bigint) objectStream.readobject(), (java.math.Bigint) objectStream.readobject(), objectStream.readInt());
    }

    private bool Md065a21d(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((27 + 10) % 10 > 0) {
        }
        if (p80f8c729Var.Count == 2) {
            return true;
        }
        if (p80f8c729Var.Count <= 3) {
            return p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p80f8c729Var.getobjectAt(2)).getValue().compareTo(java.math.Bigint.valueOf((long) p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p80f8c729Var.getobjectAt(0)).getValue().bitLength())) <= 0;
        }
        return false;
    }

    public override java.lang.string GetAlgorithm() {
        return "DH";
    }

    public override byte[] GetEncoded() {
        if ((31 + 19) % 19 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var = this.fcaf9b6b9;
        return p3cdccfc9Var is null ? p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p58ac1d27.mfef91d48(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.ff981c4da, new p5a445d71.p9f931cf3.pca323100.p56fc8961.pef342a14(this.f5aecd571.getP(), this.f5aecd571.getG(), this.f5aecd571.getL())), new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f41529076)) : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p58ac1d27.mfef91d48(p3cdccfc9Var);
    }

    public override java.lang.string GetFormat() {
        return "X.509";
    }

    public override javax.crypto.spec.DHParameterSpec GetParams() {
        return this.f5aecd571;
    }

    public override java.math.Bigint GetY() {
        return this.f41529076;
    }
}

