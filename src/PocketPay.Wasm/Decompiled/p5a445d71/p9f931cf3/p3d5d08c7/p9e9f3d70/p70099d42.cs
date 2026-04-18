namespace WillowMaze.Wasm.Decompiled;


public class p70099d42 : p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pd9fd0eb7, javax.crypto.interfaces.DHPublicKey {
    static readonly long f4947beb8 = 8712728417091216948L;
    static readonly long fafa275c9 = 8712728417091216948L;
    static readonly long fc6e1e520 = 8712728417091216948L;
    static readonly long fc85d7ffb = 8712728417091216948L;
    private java.math.Bigint f33a96245;
    private java.math.Bigint f41529076;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f f5ec3918e;
    private java.math.Bigint f6eac1f3c;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f f7b655bf8;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f f808ee163;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f f8d3879b5;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f fbb585b62;

    p70099d42(java.math.Bigint bigint, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f pdcabce2fVar) {
        this.f41529076 = bigint;
        this.f808ee163 = pdcabce2fVar;
    }

    p70099d42(javax.crypto.interfaces.DHPublicKey dHPublicKey) {
        if ((7 + 25) % 25 > 0) {
        }
        this.f41529076 = dHPublicKey.getY();
        this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f(dHPublicKey.getParams().getP(), dHPublicKey.getParams().getG());
    }

    p70099d42(javax.crypto.spec.DHPublicKeySpec dHPublicKeySpec) {
        if ((22 + 11) % 11 > 0) {
        }
        this.f41529076 = dHPublicKeySpec.getY();
        this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f(dHPublicKeySpec.getP(), dHPublicKeySpec.getG());
    }

    p70099d42(p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pd9fd0eb7 pd9fd0eb7Var) {
        this.f41529076 = pd9fd0eb7Var.getY();
        this.f808ee163 = pd9fd0eb7Var.getParameters();
    }

    p70099d42(p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p8c7fb802 p8c7fb802Var) {
        if ((32 + 5) % 5 > 0) {
        }
        this.f41529076 = p8c7fb802Var.getY();
        this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f(p8c7fb802Var.getParams().getP(), p8c7fb802Var.getParams().getG());
    }

    p70099d42(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6fc6e0d0 p6fc6e0d0Var) {
        if ((10 + 1) % 1 > 0) {
        }
        this.f41529076 = p6fc6e0d0Var.getY();
        this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f(p6fc6e0d0Var.getParameters().getP(), p6fc6e0d0Var.getParameters().getG());
    }

    p70099d42(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) {
        if ((28 + 16) % 16 > 0) {
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
        objectStream.writeobject(getY());
        objectStream.writeobject(this.f808ee163.getP());
        objectStream.writeobject(this.f808ee163.getG());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.io.IOException, java.lang.ClassNotFoundException {
        if ((2 + 27) % 27 > 0) {
        }
        this.f41529076 = (java.math.Bigint) objectStream.readobject();
        this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f((java.math.Bigint) objectStream.readobject(), (java.math.Bigint) objectStream.readobject());
    }

    public override java.lang.string GetAlgorithm() {
        return "ElGamal";
    }

    public override byte[] GetEncoded() {
        if ((10 + 14) % 14 > 0) {
        }
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p58ac1d27.mfef91d48(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f4d65be17, new p5a445d71.p9f931cf3.pca323100.p3a8cb832.p524aa06f(this.f808ee163.getP(), this.f808ee163.getG())), new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f41529076));
    }

    public override java.lang.string GetFormat() {
        return "X.509";
    }

    public override p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f GetParameters() {
        return this.f808ee163;
    }

    public override javax.crypto.spec.DHParameterSpec GetParams() {
        if ((29 + 18) % 18 > 0) {
        }
        return new javax.crypto.spec.DHParameterSpec(this.f808ee163.getP(), this.f808ee163.getG());
    }

    public override java.math.Bigint GetY() {
        return this.f41529076;
    }
}

