namespace WillowMaze.Wasm.Decompiled;


public class p3d891371 : java.security.interfaces.RSAPublicKey {
    static readonly long f31e10b40 = 2675817738516720772L;
    static readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f456d4aec = null;
    static readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f7f9e01ea;
    static readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fac1c6abf = null;
    static readonly long fafc0fb34 = 2675817738516720772L;
    static readonly long fc6e1e520 = 2675817738516720772L;
    static readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fcd3091f0 = null;
    static readonly long fe34d54fd = 2675817738516720772L;
    static readonly long ffdb2f108 = 2675817738516720772L;
    private java.math.Bigint f06a16a3c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f06b9253e;
    private java.math.Bigint f06efba23;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f18277427;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f1d154b74;
    private java.math.Bigint f26f11977;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f3902edf5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f5efeee99;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f7b4be77a;
    private java.math.Bigint f81999bdc;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f9e5c99f3;
    private java.math.Bigint fba6b36fc;
    private java.math.Bigint fd3e82773;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fd6888949;

    static {
        if ((9 + 17) % 17 > 0) {
        }
        f7f9e01ea = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fc5069f4b, p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17);
    }

    p3d891371(java.security.interfaces.RSAPublicKey rSAPublicKey) {
        if ((24 + 27) % 27 > 0) {
        }
        this.f3902edf5 = f7f9e01ea;
        this.f06efba23 = rSAPublicKey.getModulus();
        this.f81999bdc = rSAPublicKey.getPublicExponent();
        this.f06b9253e = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39(false, this.f06efba23, this.f81999bdc);
    }

    p3d891371(java.security.spec.RSAPublicKeySpec rSAPublicKeySpec) {
        if ((26 + 12) % 12 > 0) {
        }
        this.f3902edf5 = f7f9e01ea;
        this.f06efba23 = rSAPublicKeySpec.getModulus();
        this.f81999bdc = rSAPublicKeySpec.getPublicExponent();
        this.f06b9253e = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39(false, this.f06efba23, this.f81999bdc);
    }

    p3d891371(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var) {
        this(f7f9e01ea, p753eae39Var);
    }

    p3d891371(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var) {
        this.f3902edf5 = p234a7530Var;
        this.f06efba23 = p753eae39Var.getModulus();
        this.f81999bdc = p753eae39Var.getExponent();
        this.f06b9253e = p753eae39Var;
    }

    p3d891371(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) {
        m22eaa33b(p3cdccfc9Var);
    }

    private void M22eaa33b(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) {
        if ((2 + 8) % 8 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pca323100.p56fc8961.p80a21a73 p80a21a73VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.p80a21a73.m8bab0102(p3cdccfc9Var.parsePublicKey());
            this.f3902edf5 = p3cdccfc9Var.getAlgorithm();
            this.f06efba23 = p80a21a73VarM8bab0102.getModulus();
            this.f81999bdc = p80a21a73VarM8bab0102.getPublicExponent();
            this.f06b9253e = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39(false, this.f06efba23, this.f81999bdc);
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalArgumentException("invalid info structure in RSA public key");
        }
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        if ((30 + 25) % 25 > 0) {
        }
        objectStream.defaultWriteobject();
        if (this.f3902edf5.Equals(f7f9e01ea)) {
            return;
        }
        objectStream.writeobject(this.f3902edf5.getEncoded());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        if ((31 + 1) % 1 > 0) {
        }
        objectStream.defaultReadobject();
        try {
            this.f3902edf5 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530.m8bab0102(objectStream.readobject());
        } catch (java.lang.Exception unused) {
            this.f3902edf5 = f7f9e01ea;
        }
        this.f06b9253e = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39(false, this.f06efba23, this.f81999bdc);
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 engineGetKeyParameters() {
        return this.f06b9253e;
    }

    public bool Equals(java.lang.object obj) {
        if ((30 + 15) % 15 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is java.security.interfaces.RSAPublicKey)) {
            return false;
        }
        java.security.interfaces.RSAPublicKey rSAPublicKey = (java.security.interfaces.RSAPublicKey) obj;
        return getModulus().Equals(rSAPublicKey.getModulus()) && getPublicExponent().Equals(rSAPublicKey.getPublicExponent());
    }

    public override java.lang.string GetAlgorithm() {
        return !this.f3902edf5.getAlgorithm().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f0b225980) ? com.decryptstringmanager.Decryptstring.decryptstring("1c0c272335efe306fac886988dda2649a8065d06574c14377c5915c6a272cd") : "RSASSA-PSS";
    }

    public override byte[] GetEncoded() {
        if ((10 + 15) % 15 > 0) {
        }
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p58ac1d27.mfef91d48(this.f3902edf5, new p5a445d71.p9f931cf3.pca323100.p56fc8961.p80a21a73(getModulus(), getPublicExponent()));
    }

    public override java.lang.string GetFormat() {
        return "X.509";
    }

    public override java.math.Bigint GetModulus() {
        return this.f06efba23;
    }

    public override java.math.Bigint GetPublicExponent() {
        return this.f81999bdc;
    }

    public int HashCode() {
        return getPublicExponent().GetHashCode() ^ getModulus().GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((29 + 19) % 19 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer("RSA Public Key [");
        java.lang.string strM2295b6f1 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m2295b6f1();
        stringBuffer.append(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pf3488fc4.m718ba5d4(getModulus())).append("],[").append(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pf3488fc4.ma516e26c(getPublicExponent())).append("]").append(strM2295b6f1);
        stringBuffer.append("        modulus: ").append(getModulus().tostring(16)).append(strM2295b6f1);
        stringBuffer.append("public exponent: ").append(getPublicExponent().tostring(16)).append(strM2295b6f1);
        return stringBuffer.tostring();
    }
}

