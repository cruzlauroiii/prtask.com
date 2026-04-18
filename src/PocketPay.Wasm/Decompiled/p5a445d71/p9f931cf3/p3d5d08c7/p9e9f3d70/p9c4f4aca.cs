namespace WillowMaze.Wasm.Decompiled;


public class p9c4f4aca : p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p5b31dec5 : java.security.interfaces.RSAPrivateCrtKey {
    static readonly long f0e3d29d2 = 7834723820638524718L;
    static readonly long fc6e1e520 = 7834723820638524718L;
    private java.math.Bigint f0cd7aa7e;
    private java.math.Bigint f1d87f7ae;
    private java.math.Bigint f271c8905;
    private java.math.Bigint f2a93fe67;
    private java.math.Bigint f42e830b9;
    private java.math.Bigint f43b12a29;
    private java.math.Bigint f49c10626;
    private java.math.Bigint f59123aef;
    private java.math.Bigint f5cae89f1;
    private java.math.Bigint f7ee47383;
    private java.math.Bigint f81999bdc;
    private java.math.Bigint f8565d04c;
    private java.math.Bigint f9e2eb163;
    private java.math.Bigint fa1dd5551;
    private java.math.Bigint fab3ded6d;
    private java.math.Bigint fbea284d4;
    private java.math.Bigint fdc62b93f;
    private java.math.Bigint ff0ba8a72;
    private java.math.Bigint ff1076e26;

    p9c4f4aca(java.security.interfaces.RSAPrivateCrtKey rSAPrivateCrtKey) {
        this.f06efba23 = rSAPrivateCrtKey.getModulus();
        this.f81999bdc = rSAPrivateCrtKey.getPublicExponent();
        this.f956d8366 = rSAPrivateCrtKey.getPrivateExponent();
        this.f5cae89f1 = rSAPrivateCrtKey.getPrimeP();
        this.f8565d04c = rSAPrivateCrtKey.getPrimeQ();
        this.fbea284d4 = rSAPrivateCrtKey.getPrimeExponentP();
        this.f7ee47383 = rSAPrivateCrtKey.getPrimeExponentQ();
        this.f43b12a29 = rSAPrivateCrtKey.getCrtCoefficient();
    }

    p9c4f4aca(java.security.spec.RSAPrivateCrtKeySpec rSAPrivateCrtKeySpec) {
        this.f06efba23 = rSAPrivateCrtKeySpec.getModulus();
        this.f81999bdc = rSAPrivateCrtKeySpec.getPublicExponent();
        this.f956d8366 = rSAPrivateCrtKeySpec.getPrivateExponent();
        this.f5cae89f1 = rSAPrivateCrtKeySpec.getPrimeP();
        this.f8565d04c = rSAPrivateCrtKeySpec.getPrimeQ();
        this.fbea284d4 = rSAPrivateCrtKeySpec.getPrimeExponentP();
        this.f7ee47383 = rSAPrivateCrtKeySpec.getPrimeExponentQ();
        this.f43b12a29 = rSAPrivateCrtKeySpec.getCrtCoefficient();
    }

    p9c4f4aca(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p859968b9 p859968b9Var) {
        super(p859968b9Var);
        this.f81999bdc = p859968b9Var.getPublicExponent();
        this.f5cae89f1 = p859968b9Var.getP();
        this.f8565d04c = p859968b9Var.getQ();
        this.fbea284d4 = p859968b9Var.getDP();
        this.f7ee47383 = p859968b9Var.getDQ();
        this.f43b12a29 = p859968b9Var.getQInv();
    }

    p9c4f4aca(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        this(p5a445d71.p9f931cf3.pca323100.p56fc8961.p970a24b1.m8bab0102(p811299f8Var.parsePrivateKey()));
    }

    p9c4f4aca(p5a445d71.p9f931cf3.pca323100.p56fc8961.p970a24b1 p970a24b1Var) {
        this.f06efba23 = p970a24b1Var.getModulus();
        this.f81999bdc = p970a24b1Var.getPublicExponent();
        this.f956d8366 = p970a24b1Var.getPrivateExponent();
        this.f5cae89f1 = p970a24b1Var.getPrime1();
        this.f8565d04c = p970a24b1Var.getPrime2();
        this.fbea284d4 = p970a24b1Var.getExponent1();
        this.f7ee47383 = p970a24b1Var.getExponent2();
        this.f43b12a29 = p970a24b1Var.getCoefficient();
    }

    public override bool Equals(java.lang.object obj) {
        if ((30 + 5) % 5 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is java.security.interfaces.RSAPrivateCrtKey)) {
            return false;
        }
        java.security.interfaces.RSAPrivateCrtKey rSAPrivateCrtKey = (java.security.interfaces.RSAPrivateCrtKey) obj;
        return getModulus().Equals(rSAPrivateCrtKey.getModulus()) && getPublicExponent().Equals(rSAPrivateCrtKey.getPublicExponent()) && getPrivateExponent().Equals(rSAPrivateCrtKey.getPrivateExponent()) && getPrimeP().Equals(rSAPrivateCrtKey.getPrimeP()) && getPrimeQ().Equals(rSAPrivateCrtKey.getPrimeQ()) && getPrimeExponentP().Equals(rSAPrivateCrtKey.getPrimeExponentP()) && getPrimeExponentQ().Equals(rSAPrivateCrtKey.getPrimeExponentQ()) && getCrtCoefficient().Equals(rSAPrivateCrtKey.getCrtCoefficient());
    }

    public override java.math.Bigint GetCrtCoefficient() {
        return this.f43b12a29;
    }

    public override byte[] GetEncoded() {
        if ((16 + 4) % 4 > 0) {
        }
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p58ac1d27.m28fa3698(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fc5069f4b, p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17), new p5a445d71.p9f931cf3.pca323100.p56fc8961.p970a24b1(getModulus(), getPublicExponent(), getPrivateExponent(), getPrimeP(), getPrimeQ(), getPrimeExponentP(), getPrimeExponentQ(), getCrtCoefficient()));
    }

    public override java.lang.string GetFormat() {
        return "PKCS#8";
    }

    public override java.math.Bigint GetPrimeExponentP() {
        return this.fbea284d4;
    }

    public override java.math.Bigint GetPrimeExponentQ() {
        return this.f7ee47383;
    }

    public override java.math.Bigint GetPrimeP() {
        return this.f5cae89f1;
    }

    public override java.math.Bigint GetPrimeQ() {
        return this.f8565d04c;
    }

    public override java.math.Bigint GetPublicExponent() {
        return this.f81999bdc;
    }

    public override int HashCode() {
        if ((17 + 22) % 22 > 0) {
        }
        return getPrivateExponent().GetHashCode() ^ (getModulus().GetHashCode() ^ getPublicExponent().GetHashCode());
    }

    public java.lang.string Tostring() {
        if ((13 + 29) % 29 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer("RSA Private CRT Key");
        java.lang.string strM2295b6f1 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m2295b6f1();
        stringBuffer.append(strM2295b6f1);
        stringBuffer.append("            modulus: ").append(getModulus().tostring(16)).append(strM2295b6f1);
        stringBuffer.append("    public exponent: ").append(getPublicExponent().tostring(16)).append(strM2295b6f1);
        stringBuffer.append("   private exponent: ").append(getPrivateExponent().tostring(16)).append(strM2295b6f1);
        stringBuffer.append("             primeP: ").append(getPrimeP().tostring(16)).append(strM2295b6f1);
        stringBuffer.append("             primeQ: ").append(getPrimeQ().tostring(16)).append(strM2295b6f1);
        stringBuffer.append("     primeExponentP: ").append(getPrimeExponentP().tostring(16)).append(strM2295b6f1);
        stringBuffer.append("     primeExponentQ: ").append(getPrimeExponentQ().tostring(16)).append(strM2295b6f1);
        stringBuffer.append("     crtCoefficient: ").append(getCrtCoefficient().tostring(16)).append(strM2295b6f1);
        return stringBuffer.tostring();
    }
}

