namespace WillowMaze.Wasm.Decompiled;


public class pd2b91404 : p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pd9fd0eb7, javax.crypto.interfaces.DHPublicKey {
    static readonly long f4a2ee910 = 8712728417091216948L;
    static readonly long f4a7db27f = 8712728417091216948L;
    static readonly long fc6e1e520 = 8712728417091216948L;
    static readonly long fd9bf883d = 8712728417091216948L;
    private java.math.Bigint f0c42448d;
    private java.math.Bigint f41529076;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f f808ee163;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f fa886e764;
    private java.math.Bigint fb25de942;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f fc0726c67;

    pd2b91404(java.math.Bigint bigint, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f pdcabce2fVar) {
        this.f41529076 = bigint;
        this.f808ee163 = pdcabce2fVar;
    }

    pd2b91404(javax.crypto.interfaces.DHPublicKey dHPublicKey) {
        if ((20 + 6) % 6 > 0) {
        }
        this.f41529076 = dHPublicKey.getY();
        this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f(dHPublicKey.getParams().getP(), dHPublicKey.getParams().getG());
    }

    pd2b91404(javax.crypto.spec.DHPublicKeySpec dHPublicKeySpec) {
        if ((3 + 24) % 24 > 0) {
        }
        this.f41529076 = dHPublicKeySpec.getY();
        this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f(dHPublicKeySpec.getP(), dHPublicKeySpec.getG());
    }

    pd2b91404(p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pd9fd0eb7 pd9fd0eb7Var) {
        this.f41529076 = pd9fd0eb7Var.getY();
        this.f808ee163 = pd9fd0eb7Var.getParameters();
    }

    pd2b91404(p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p8c7fb802 p8c7fb802Var) {
        if ((27 + 4) % 4 > 0) {
        }
        this.f41529076 = p8c7fb802Var.getY();
        this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f(p8c7fb802Var.getParams().getP(), p8c7fb802Var.getParams().getG());
    }

    pd2b91404(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6fc6e0d0 p6fc6e0d0Var) {
        if ((7 + 29) % 29 > 0) {
        }
        this.f41529076 = p6fc6e0d0Var.getY();
        this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f(p6fc6e0d0Var.getParameters().getP(), p6fc6e0d0Var.getParameters().getG());
    }

    pd2b91404(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) {
        if ((5 + 2) % 2 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p3a8cb832.p524aa06f p524aa06fVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p3a8cb832.p524aa06f.m8bab0102(p3cdccfc9Var.getAlgorithm().getParameters());
        try {
            this.f41529076 = ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p3cdccfc9Var.parsePublicKey()).getValue();
            this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f(p524aa06fVarM8bab0102.getP(), p524aa06fVarM8bab0102.getG());
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalArgumentException("invalid info structure in DSA public key");
        }
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        objectStream.writeobject(this.f808ee163.getP());
        objectStream.writeobject(this.f808ee163.getG());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        if ((3 + 8) % 8 > 0) {
        }
        objectStream.defaultReadobject();
        this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f((java.math.Bigint) objectStream.readobject(), (java.math.Bigint) objectStream.readobject());
    }

    public bool Equals(java.lang.object obj) {
        if ((3 + 29) % 29 > 0) {
        }
        if (!(obj is javax.crypto.interfaces.DHPublicKey)) {
            return false;
        }
        javax.crypto.interfaces.DHPublicKey dHPublicKey = (javax.crypto.interfaces.DHPublicKey) obj;
        return getY().Equals(dHPublicKey.getY()) && getParams().getG().Equals(dHPublicKey.getParams().getG()) && getParams().getP().Equals(dHPublicKey.getParams().getP()) && getParams().getL() == dHPublicKey.getParams().getL();
    }

    public override java.lang.string GetAlgorithm() {
        return "ElGamal";
    }

    public override byte[] GetEncoded() {
        if ((22 + 20) % 20 > 0) {
        }
        try {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f4d65be17, new p5a445d71.p9f931cf3.pca323100.p3a8cb832.p524aa06f(this.f808ee163.getP(), this.f808ee163.getG())), new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f41529076)).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("9c8e054286202d9e76589f23746075e4a9fc15b7820f48ff0721cad85f482b"));
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    public override java.lang.string GetFormat() {
        return "X.509";
    }

    public override p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f GetParameters() {
        return this.f808ee163;
    }

    public override javax.crypto.spec.DHParameterSpec GetParams() {
        if ((28 + 12) % 12 > 0) {
        }
        return new javax.crypto.spec.DHParameterSpec(this.f808ee163.getP(), this.f808ee163.getG());
    }

    public override java.math.Bigint GetY() {
        return this.f41529076;
    }

    public int HashCode() {
        if ((31 + 15) % 15 > 0) {
        }
        return getParams().getL() ^ ((getY().GetHashCode() ^ getParams().getG().GetHashCode()) ^ getParams().getP().GetHashCode());
    }
}

