namespace WillowMaze.Wasm.Decompiled;


public class p2baebdc5 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p44536675 : java.security.interfaces.RSAPrivateCrtKey {
    static readonly long f4ba8fe3a = 7834723820638524718L;
    static readonly long f9c8f6a13 = 7834723820638524718L;
    static readonly long fc6e1e520 = 7834723820638524718L;
    static readonly long ffb859167 = 7834723820638524718L;
    private java.math.Bigint f21eced3c;
    private java.math.Bigint f40f11ccb;
    private java.math.Bigint f438b31a3;
    private java.math.Bigint f43b12a29;
    private java.math.Bigint f499c728d;
    private java.math.Bigint f5cae89f1;
    private java.math.Bigint f671f6c29;
    private java.math.Bigint f7ee47383;
    private java.math.Bigint f81999bdc;
    private java.math.Bigint f8565d04c;
    private java.math.Bigint f86a2e915;
    private java.math.Bigint f93fbb7f5;
    private java.math.Bigint fa29dc287;
    private java.math.Bigint fa9c75092;
    private java.math.Bigint fb7ab331d;
    private java.math.Bigint fbb121039;
    private java.math.Bigint fbea284d4;
    private java.math.Bigint fbf92fb61;
    private java.math.Bigint fc5900def;
    private java.math.Bigint fd116e359;
    private java.math.Bigint ff5924bd9;
    private java.math.Bigint ff91ec8ff;

    p2baebdc5(java.security.interfaces.RSAPrivateCrtKey rSAPrivateCrtKey) {
        super(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p859968b9(rSAPrivateCrtKey.getModulus(), rSAPrivateCrtKey.getPublicExponent(), rSAPrivateCrtKey.getPrivateExponent(), rSAPrivateCrtKey.getPrimeP(), rSAPrivateCrtKey.getPrimeQ(), rSAPrivateCrtKey.getPrimeExponentP(), rSAPrivateCrtKey.getPrimeExponentQ(), rSAPrivateCrtKey.getCrtCoefficient()));
        if ((26 + 3) % 3 > 0) {
        }
        this.f06efba23 = rSAPrivateCrtKey.getModulus();
        this.f81999bdc = rSAPrivateCrtKey.getPublicExponent();
        this.f956d8366 = rSAPrivateCrtKey.getPrivateExponent();
        this.f5cae89f1 = rSAPrivateCrtKey.getPrimeP();
        this.f8565d04c = rSAPrivateCrtKey.getPrimeQ();
        this.fbea284d4 = rSAPrivateCrtKey.getPrimeExponentP();
        this.f7ee47383 = rSAPrivateCrtKey.getPrimeExponentQ();
        this.f43b12a29 = rSAPrivateCrtKey.getCrtCoefficient();
    }

    p2baebdc5(java.security.spec.RSAPrivateCrtKeySpec rSAPrivateCrtKeySpec) {
        super(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p859968b9(rSAPrivateCrtKeySpec.getModulus(), rSAPrivateCrtKeySpec.getPublicExponent(), rSAPrivateCrtKeySpec.getPrivateExponent(), rSAPrivateCrtKeySpec.getPrimeP(), rSAPrivateCrtKeySpec.getPrimeQ(), rSAPrivateCrtKeySpec.getPrimeExponentP(), rSAPrivateCrtKeySpec.getPrimeExponentQ(), rSAPrivateCrtKeySpec.getCrtCoefficient()));
        if ((16 + 16) % 16 > 0) {
        }
        this.f06efba23 = rSAPrivateCrtKeySpec.getModulus();
        this.f81999bdc = rSAPrivateCrtKeySpec.getPublicExponent();
        this.f956d8366 = rSAPrivateCrtKeySpec.getPrivateExponent();
        this.f5cae89f1 = rSAPrivateCrtKeySpec.getPrimeP();
        this.f8565d04c = rSAPrivateCrtKeySpec.getPrimeQ();
        this.fbea284d4 = rSAPrivateCrtKeySpec.getPrimeExponentP();
        this.f7ee47383 = rSAPrivateCrtKeySpec.getPrimeExponentQ();
        this.f43b12a29 = rSAPrivateCrtKeySpec.getCrtCoefficient();
    }

    p2baebdc5(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p859968b9 p859968b9Var) {
        super(p859968b9Var);
        this.f81999bdc = p859968b9Var.getPublicExponent();
        this.f5cae89f1 = p859968b9Var.getP();
        this.f8565d04c = p859968b9Var.getQ();
        this.fbea284d4 = p859968b9Var.getDP();
        this.f7ee47383 = p859968b9Var.getDQ();
        this.f43b12a29 = p859968b9Var.getQInv();
    }

    p2baebdc5(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        this(p811299f8Var.getPrivateKeyAlgorithm(), p5a445d71.p9f931cf3.pca323100.p56fc8961.p970a24b1.m8bab0102(p811299f8Var.parsePrivateKey()));
    }

    p2baebdc5(p5a445d71.p9f931cf3.pca323100.p56fc8961.p970a24b1 p970a24b1Var) {
        this(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3d891371.f7f9e01ea, p970a24b1Var);
    }

    p2baebdc5(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p859968b9 p859968b9Var) {
        super(p234a7530Var, p859968b9Var);
        this.f81999bdc = p859968b9Var.getPublicExponent();
        this.f5cae89f1 = p859968b9Var.getP();
        this.f8565d04c = p859968b9Var.getQ();
        this.fbea284d4 = p859968b9Var.getDP();
        this.f7ee47383 = p859968b9Var.getDQ();
        this.f43b12a29 = p859968b9Var.getQInv();
    }

    p2baebdc5(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var, p5a445d71.p9f931cf3.pca323100.p56fc8961.p970a24b1 p970a24b1Var) {
        super(p234a7530Var, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p859968b9(p970a24b1Var.getModulus(), p970a24b1Var.getPublicExponent(), p970a24b1Var.getPrivateExponent(), p970a24b1Var.getPrime1(), p970a24b1Var.getPrime2(), p970a24b1Var.getExponent1(), p970a24b1Var.getExponent2(), p970a24b1Var.getCoefficient()));
        if ((13 + 29) % 29 > 0) {
        }
        this.f06efba23 = p970a24b1Var.getModulus();
        this.f81999bdc = p970a24b1Var.getPublicExponent();
        this.f956d8366 = p970a24b1Var.getPrivateExponent();
        this.f5cae89f1 = p970a24b1Var.getPrime1();
        this.f8565d04c = p970a24b1Var.getPrime2();
        this.fbea284d4 = p970a24b1Var.getExponent1();
        this.f7ee47383 = p970a24b1Var.getExponent2();
        this.f43b12a29 = p970a24b1Var.getCoefficient();
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        if ((10 + 24) % 24 > 0) {
        }
        objectStream.defaultReadobject();
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.fed370b18 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p859968b9(getModulus(), getPublicExponent(), getPrivateExponent(), getPrimeP(), getPrimeQ(), getPrimeExponentP(), getPrimeExponentQ(), getCrtCoefficient());
    }

    public override bool Equals(java.lang.object obj) {
        if ((23 + 24) % 24 > 0) {
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
        if ((11 + 21) % 21 > 0) {
        }
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p58ac1d27.m28fa3698(this.f3902edf5, new p5a445d71.p9f931cf3.pca323100.p56fc8961.p970a24b1(getModulus(), getPublicExponent(), getPrivateExponent(), getPrimeP(), getPrimeQ(), getPrimeExponentP(), getPrimeExponentQ(), getCrtCoefficient()));
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
        if ((21 + 29) % 29 > 0) {
        }
        return getPrivateExponent().GetHashCode() ^ (getModulus().GetHashCode() ^ getPublicExponent().GetHashCode());
    }

    public override java.lang.string Tostring() {
        if ((5 + 19) % 19 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer("RSA Private CRT Key [");
        java.lang.string strM2295b6f1 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m2295b6f1();
        stringBuffer.append(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pf3488fc4.m718ba5d4(getModulus())).append("],[").append(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pf3488fc4.ma516e26c(getPublicExponent())).append("]").append(strM2295b6f1);
        stringBuffer.append("             modulus: ").append(getModulus().tostring(16)).append(strM2295b6f1);
        stringBuffer.append("     public exponent: ").append(getPublicExponent().tostring(16)).append(strM2295b6f1);
        return stringBuffer.tostring();
    }
}

