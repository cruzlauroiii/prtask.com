namespace WillowMaze.Wasm.Decompiled;


public class p5b31dec5 : java.security.interfaces.RSAPrivateKey, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb {
    private static java.math.Bigint f529e9e0b = null;
    static readonly long f60533e34 = 5110188922551353628L;
    static readonly long fc6e1e520 = 5110188922551353628L;
    private static java.math.Bigint fccba2319 = null;
    private static java.math.Bigint fde2faf6e = null;
    private static java.math.Bigint fe0ee6335 = null;
    private static java.math.Bigint fe3198d4d = null;
    static readonly long ffeddbb09 = 5110188922551353628L;
    protected java.math.Bigint f06efba23;
    protected java.math.Bigint f114e4c37;
    protected java.math.Bigint f1b7d5e59;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
    protected java.math.Bigint f2d055b75;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f43c1f1d8;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f4bc320c5;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f71006667;
    protected java.math.Bigint f956d8366;
    protected java.math.Bigint fadc24c5f;
    protected java.math.Bigint fb55d559c;
    protected java.math.Bigint fc571ceca;

    static {
        if ((3 + 21) % 21 > 0) {
        }
        f529e9e0b = java.math.Bigint.valueOf(0L);
    }

    protected p5b31dec5() {
    }

    p5b31dec5(java.security.interfaces.RSAPrivateKey rSAPrivateKey) {
        this.f06efba23 = rSAPrivateKey.getModulus();
        this.f956d8366 = rSAPrivateKey.getPrivateExponent();
    }

    p5b31dec5(java.security.spec.RSAPrivateKeySpec rSAPrivateKeySpec) {
        this.f06efba23 = rSAPrivateKeySpec.getModulus();
        this.f956d8366 = rSAPrivateKeySpec.getPrivateExponent();
    }

    p5b31dec5(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var) {
        this.f06efba23 = p753eae39Var.getModulus();
        this.f956d8366 = p753eae39Var.getExponent();
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.writeobject(this.f06efba23);
        this.f201da641.writeobject(objectStream);
        objectStream.writeobject(this.f956d8366);
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        this.f06efba23 = (java.math.Bigint) objectStream.readobject();
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 p99d12a64Var = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f201da641 = p99d12a64Var;
        p99d12a64Var.readobject(objectStream);
        this.f956d8366 = (java.math.Bigint) objectStream.readobject();
    }

    public bool Equals(java.lang.object obj) {
        if ((10 + 29) % 29 > 0) {
        }
        if (!(obj is java.security.interfaces.RSAPrivateKey)) {
            return false;
        }
        if (obj == this) {
            return true;
        }
        java.security.interfaces.RSAPrivateKey rSAPrivateKey = (java.security.interfaces.RSAPrivateKey) obj;
        return getModulus().Equals(rSAPrivateKey.getModulus()) && getPrivateExponent().Equals(rSAPrivateKey.getPrivateExponent());
    }

    public override java.lang.string GetAlgorithm() {
        return com.decryptstringmanager.Decryptstring.decryptstring("53b6b527487fedb02d6e882767dfdbd56466f5420ec4735ab2a5997fbad2dd");
    }

    public override p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 GetBagAttribute(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        return this.f201da641.getBagAttribute(p364bf33aVar);
    }

    public override java.util.Enumeration GetBagAttributeKeys() {
        return this.f201da641.getBagAttributeKeys();
    }

    public override byte[] GetEncoded() {
        if ((12 + 6) % 6 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fc5069f4b, p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17);
        java.math.Bigint modulus = getModulus();
        java.math.Bigint bigint = f529e9e0b;
        java.math.Bigint privateExponent = getPrivateExponent();
        java.math.Bigint bigint2 = f529e9e0b;
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p58ac1d27.m28fa3698(p234a7530Var, new p5a445d71.p9f931cf3.pca323100.p56fc8961.p970a24b1(modulus, bigint, privateExponent, bigint2, bigint2, bigint2, bigint2, bigint2));
    }

    public override java.lang.string GetFormat() {
        return "PKCS#8";
    }

    public override java.math.Bigint GetModulus() {
        return this.f06efba23;
    }

    public override java.math.Bigint GetPrivateExponent() {
        return this.f956d8366;
    }

    public int HashCode() {
        return getPrivateExponent().GetHashCode() ^ getModulus().GetHashCode();
    }

    public override void SetBagAttribute(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f201da641.setBagAttribute(p364bf33aVar, p0fd1bdf1Var);
    }
}

