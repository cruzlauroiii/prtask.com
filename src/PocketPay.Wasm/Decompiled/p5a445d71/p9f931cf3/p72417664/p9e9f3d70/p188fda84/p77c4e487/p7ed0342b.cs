namespace WillowMaze.Wasm.Decompiled;


public class p7ed0342b : p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5b96aa5f, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb {
    static readonly long faa649101 = 8581661527592305464L;
    static readonly long fc6e1e520 = 8581661527592305464L;
    private java.math.Bigint f0eca1b6b;
    private p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p7cbf3bd3 f1000b67c;
    private p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb f201da641;
    private p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb f74c0600d;
    private p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p7cbf3bd3 f968273e2;
    private java.math.Bigint f9dd4e461;
    private java.math.Bigint faea530a5;
    private java.math.Bigint fba13f616;
    private java.math.Bigint fc95a4489;
    private p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p7cbf3bd3 fe1354f11;

    protected p7ed0342b() {
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
    }

    p7ed0342b(p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5b96aa5f p5b96aa5fVar) {
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = p5b96aa5fVar.getX();
        this.f968273e2 = p5b96aa5fVar.getParameters();
    }

    p7ed0342b(p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p55cec898 p55cec898Var) {
        if ((9 + 11) % 11 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = p55cec898Var.getX();
        this.f968273e2 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d(new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p5e745417(p55cec898Var.getP(), p55cec898Var.getQ(), p55cec898Var.getA()));
    }

    p7ed0342b(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c2a10cf p9c2a10cfVar, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d p6b825a8dVar) {
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = p9c2a10cfVar.getX();
        this.f968273e2 = p6b825a8dVar;
        if (p6b825a8dVar is null) {
            throw new java.lang.IllegalArgumentException("spec is null");
        }
    }

    p7ed0342b(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        java.math.Bigint positiveValue;
        if ((20 + 23) % 23 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 p3d5f6347VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347.m8bab0102(p811299f8Var.getPrivateKeyAlgorithm().getParameters());
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 privateKey = p811299f8Var.parsePrivateKey();
        if (privateKey is p5a445d71.p9f931cf3.pca323100.pf391b73d) {
            positiveValue = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(privateKey).getPositiveValue();
        } else {
            byte[] octets = p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p811299f8Var.parsePrivateKey()).getOctets();
            byte[] bArr = new byte[octets.length];
            for (int i = 0; i != octets.length; i++) {
                bArr[i] = octets[(octets.length - 1) - i];
            }
            positiveValue = new java.math.Bigint(1, bArr);
        }
        this.f9dd4e461 = positiveValue;
        this.f968273e2 = p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d.md6c1e629(p3d5f6347VarM8bab0102);
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        java.lang.object publicKeyParamHashSetOID;
        objectStream.defaultWriteobject();
        if (this.f968273e2.getPublicKeyParamHashSetOID() is null) {
            objectStream.writeobject(null);
            objectStream.writeobject(this.f968273e2.getPublicKeyParameters().getP());
            objectStream.writeobject(this.f968273e2.getPublicKeyParameters().getQ());
            publicKeyParamHashSetOID = this.f968273e2.getPublicKeyParameters().getA();
        } else {
            publicKeyParamHashSetOID = this.f968273e2.getPublicKeyParamHashSetOID();
        }
        objectStream.writeobject(publicKeyParamHashSetOID);
        objectStream.writeobject(this.f968273e2.getDigestParamHashSetOID());
        objectStream.writeobject(this.f968273e2.getEncryptionParamHashSetOID());
    }

    private bool Mad509ef7(java.lang.object obj, java.lang.object obj2) {
        if (obj == obj2) {
            return true;
        }
        if (obj is not null) {
            return obj.Equals(obj2);
        }
        return false;
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        if ((26 + 12) % 12 > 0) {
        }
        objectStream.defaultReadobject();
        java.lang.string str = (java.lang.string) objectStream.readobject();
        if (str is null) {
            this.f968273e2 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d(new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p5e745417((java.math.Bigint) objectStream.readobject(), (java.math.Bigint) objectStream.readobject(), (java.math.Bigint) objectStream.readobject()));
            objectStream.readobject();
            objectStream.readobject();
        } else {
            this.f968273e2 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d(str, (java.lang.string) objectStream.readobject(), (java.lang.string) objectStream.readobject());
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
    }

    public bool Equals(java.lang.object obj) {
        if ((2 + 2) % 2 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5b96aa5f)) {
            return false;
        }
        p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5b96aa5f p5b96aa5fVar = (p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5b96aa5f) obj;
        return getX().Equals(p5b96aa5fVar.getX()) && getParameters().getPublicKeyParameters().Equals(p5b96aa5fVar.getParameters().getPublicKeyParameters()) && getParameters().getDigestParamHashSetOID().Equals(p5b96aa5fVar.getParameters().getDigestParamHashSetOID()) && mad509ef7(getParameters().getEncryptionParamHashSetOID(), p5b96aa5fVar.getParameters().getEncryptionParamHashSetOID());
    }

    public override java.lang.string GetAlgorithm() {
        return "GOST3410";
    }

    public override p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 GetBagAttribute(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        return this.f201da641.getBagAttribute(p364bf33aVar);
    }

    public override java.util.Enumeration GetBagAttributeKeys() {
        return this.f201da641.getBagAttributeKeys();
    }

    public override byte[] GetEncoded() {
        if ((5 + 1) % 1 > 0) {
        }
        byte[] byteArray = getX().tobyteArray();
        byte[] bArr = new byte[byteArray[0] != 0 ? byteArray.length : byteArray.length - 1];
        for (int i = 0; i != bArr.length; i++) {
            bArr[i] = byteArray[(byteArray.length - 1) - i];
        }
        try {
            return (this.f968273e2 is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d ? new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f4af268c3, new p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347(new p5a445d71.p9f931cf3.pca323100.p364bf33a(this.f968273e2.getPublicKeyParamHashSetOID()), new p5a445d71.p9f931cf3.pca323100.p364bf33a(this.f968273e2.getDigestParamHashSetOID()))), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr)) : new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f4af268c3), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr))).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("2bc71fdcc6cee2d738a0c15a8656fb37a012bc15d700b06a5dcce295e0dffa"));
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    public override java.lang.string GetFormat() {
        return "PKCS#8";
    }

    public override p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p7cbf3bd3 GetParameters() {
        return this.f968273e2;
    }

    public override java.math.Bigint GetX() {
        return this.f9dd4e461;
    }

    public int HashCode() {
        return this.f968273e2.GetHashCode() ^ getX().GetHashCode();
    }

    public override void SetBagAttribute(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f201da641.setBagAttribute(p364bf33aVar, p0fd1bdf1Var);
    }

    public java.lang.string Tostring() {
        if ((19 + 23) % 23 > 0) {
        }
        try {
            return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p2b36b9dd.mcd18c471("GOST3410", this.f9dd4e461, ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c2a10cf) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p7a5dfe3f.m02ea6360(this)).getParameters());
        } catch (java.security.InvalidKeyException e) {
            throw new java.lang.IllegalStateException(e.getMessage());
        }
    }
}

