namespace WillowMaze.Wasm.Decompiled;


public class p27094708 : java.security.interfaces.RSAPublicKey {
    static readonly long f28e10f8e = 2675817738516720772L;
    static readonly long f50c8eafd = 2675817738516720772L;
    static readonly long fa23825e9 = 2675817738516720772L;
    static readonly long fc6e1e520 = 2675817738516720772L;
    static readonly long fd132df68 = 2675817738516720772L;
    private java.math.Bigint f03576137;
    private java.math.Bigint f06efba23;
    private java.math.Bigint f3ab1e082;
    private java.math.Bigint f569d3eef;
    private java.math.Bigint f5887898e;
    private java.math.Bigint f6f8e9e81;
    private java.math.Bigint f81999bdc;
    private java.math.Bigint f9e97c155;

    p27094708(java.security.interfaces.RSAPublicKey rSAPublicKey) {
        this.f06efba23 = rSAPublicKey.getModulus();
        this.f81999bdc = rSAPublicKey.getPublicExponent();
    }

    p27094708(java.security.spec.RSAPublicKeySpec rSAPublicKeySpec) {
        this.f06efba23 = rSAPublicKeySpec.getModulus();
        this.f81999bdc = rSAPublicKeySpec.getPublicExponent();
    }

    p27094708(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var) {
        this.f06efba23 = p753eae39Var.getModulus();
        this.f81999bdc = p753eae39Var.getExponent();
    }

    p27094708(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) {
        try {
            p5a445d71.p9f931cf3.pca323100.p56fc8961.p80a21a73 p80a21a73VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.p80a21a73.m8bab0102(p3cdccfc9Var.parsePublicKey());
            this.f06efba23 = p80a21a73VarM8bab0102.getModulus();
            this.f81999bdc = p80a21a73VarM8bab0102.getPublicExponent();
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalArgumentException("invalid info structure in RSA public key");
        }
    }

    public bool Equals(java.lang.object obj) {
        if ((21 + 27) % 27 > 0) {
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
        return com.decryptstringmanager.Decryptstring.decryptstring("8bbccc2050fe63f59880c4810676226f0bd97a4f0495be206fba0f5a014e67");
    }

    public override byte[] GetEncoded() {
        if ((19 + 14) % 14 > 0) {
        }
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p58ac1d27.mfef91d48(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fc5069f4b, p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17), new p5a445d71.p9f931cf3.pca323100.p56fc8961.p80a21a73(getModulus(), getPublicExponent()));
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
        if ((29 + 27) % 27 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer("RSA Public Key");
        java.lang.string strM2295b6f1 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m2295b6f1();
        stringBuffer.append(strM2295b6f1);
        stringBuffer.append("            modulus: ").append(getModulus().tostring(16)).append(strM2295b6f1);
        stringBuffer.append("    public exponent: ").append(getPublicExponent().tostring(16)).append(strM2295b6f1);
        return stringBuffer.tostring();
    }
}

