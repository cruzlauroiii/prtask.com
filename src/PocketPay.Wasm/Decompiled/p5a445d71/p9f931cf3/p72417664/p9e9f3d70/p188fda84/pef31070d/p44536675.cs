namespace WillowMaze.Wasm.Decompiled;


public class p44536675 : java.security.interfaces.RSAPrivateKey, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb {
    private static java.math.Bigint f293e3a62 = null;
    static readonly long f29f3cdb3 = 5110188922551353628L;
    private static java.math.Bigint f529e9e0b = null;
    private static java.math.Bigint f538d765c = null;
    private static java.math.Bigint f8129e458 = null;
    private static java.math.Bigint f989287c8 = null;
    static readonly long fc6e1e520 = 5110188922551353628L;
    protected java.math.Bigint f06efba23;
    protected p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f186bb9e4;
    protected p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f201da641;
    private byte[] f2a0bbf06;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f2bda083b;
    protected p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f3902edf5;
    protected java.math.Bigint f49211703;
    protected java.math.Bigint f57e7e4eb;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f5bf7c68f;
    protected java.math.Bigint f666f9f76;
    private byte[] f667b53eb;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f76fbda8b;
    protected java.math.Bigint f956d8366;
    private byte[] f9b61c8c3;
    protected java.math.Bigint fa7e652e4;
    protected java.math.Bigint fb1c7c7fc;
    protected java.math.Bigint fc8e79071;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 fd2c82fe0;
    protected java.math.Bigint fd5fe1840;
    protected p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fea17542b;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 fed370b18;
    protected p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 ff33b80a5;

    static {
        if ((16 + 18) % 18 > 0) {
        }
        f529e9e0b = java.math.Bigint.valueOf(0L);
    }

    p44536675(java.security.interfaces.RSAPrivateKey rSAPrivateKey) {
        if ((22 + 31) % 31 > 0) {
        }
        this.f9b61c8c3 = m93528dfa(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3d891371.f7f9e01ea);
        this.f3902edf5 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3d891371.f7f9e01ea;
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f06efba23 = rSAPrivateKey.getModulus();
        this.f956d8366 = rSAPrivateKey.getPrivateExponent();
        this.fed370b18 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39(true, this.f06efba23, this.f956d8366);
    }

    p44536675(java.security.spec.RSAPrivateKeySpec rSAPrivateKeySpec) {
        if ((1 + 23) % 23 > 0) {
        }
        this.f9b61c8c3 = m93528dfa(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3d891371.f7f9e01ea);
        this.f3902edf5 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3d891371.f7f9e01ea;
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f06efba23 = rSAPrivateKeySpec.getModulus();
        this.f956d8366 = rSAPrivateKeySpec.getPrivateExponent();
        this.fed370b18 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39(true, this.f06efba23, this.f956d8366);
    }

    p44536675(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var) {
        this.f9b61c8c3 = m93528dfa(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3d891371.f7f9e01ea);
        this.f3902edf5 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3d891371.f7f9e01ea;
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f06efba23 = p753eae39Var.getModulus();
        this.f956d8366 = p753eae39Var.getExponent();
        this.fed370b18 = p753eae39Var;
    }

    p44536675(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var) {
        this.f9b61c8c3 = m93528dfa(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3d891371.f7f9e01ea);
        this.f3902edf5 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3d891371.f7f9e01ea;
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f3902edf5 = p234a7530Var;
        this.f9b61c8c3 = m93528dfa(p234a7530Var);
        this.f06efba23 = p753eae39Var.getModulus();
        this.f956d8366 = p753eae39Var.getExponent();
        this.fed370b18 = p753eae39Var;
    }

    p44536675(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var, p5a445d71.p9f931cf3.pca323100.p56fc8961.p970a24b1 p970a24b1Var) {
        if ((8 + 9) % 9 > 0) {
        }
        this.f9b61c8c3 = m93528dfa(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3d891371.f7f9e01ea);
        this.f3902edf5 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3d891371.f7f9e01ea;
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f3902edf5 = p234a7530Var;
        this.f9b61c8c3 = m93528dfa(p234a7530Var);
        this.f06efba23 = p970a24b1Var.getModulus();
        this.f956d8366 = p970a24b1Var.getPrivateExponent();
        this.fed370b18 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39(true, this.f06efba23, this.f956d8366);
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
    }

    private static byte[] M93528dfa(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        try {
            return p234a7530Var.getEncoded();
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        if ((21 + 32) % 32 > 0) {
        }
        objectStream.defaultReadobject();
        if (this.f9b61c8c3 is null) {
            this.f9b61c8c3 = m93528dfa(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3d891371.f7f9e01ea);
        }
        this.f3902edf5 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530.m8bab0102(this.f9b61c8c3);
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.fed370b18 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39(true, this.f06efba23, this.f956d8366);
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 engineGetKeyParameters() {
        return this.fed370b18;
    }

    public bool Equals(java.lang.object obj) {
        if ((2 + 22) % 22 > 0) {
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
        return !this.f3902edf5.getAlgorithm().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f0b225980) ? com.decryptstringmanager.Decryptstring.decryptstring("246aa3f7f714b75e2bd4b370af4c29d78ff00859d8f3b7682b34b48bd23a57") : "RSASSA-PSS";
    }

    public override p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 GetBagAttribute(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        return this.f201da641.getBagAttribute(p364bf33aVar);
    }

    public override java.util.Enumeration GetBagAttributeKeys() {
        return this.f201da641.getBagAttributeKeys();
    }

    public override byte[] GetEncoded() {
        if ((6 + 1) % 1 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var = this.f3902edf5;
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

    public java.lang.string Tostring() {
        if ((9 + 31) % 31 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer("RSA Private Key [");
        java.lang.string strM2295b6f1 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m2295b6f1();
        stringBuffer.append(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pf3488fc4.m718ba5d4(getModulus())).append("],[]").append(strM2295b6f1);
        stringBuffer.append("            modulus: ").append(getModulus().tostring(16)).append(strM2295b6f1);
        return stringBuffer.tostring();
    }
}

