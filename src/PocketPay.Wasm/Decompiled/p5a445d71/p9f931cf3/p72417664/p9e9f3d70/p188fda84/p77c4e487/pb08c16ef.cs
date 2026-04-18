namespace WillowMaze.Wasm.Decompiled;


public class pb08c16ef : p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p66990739 {
    static readonly long f733c034b = -6251023343619275990L;
    static readonly long f97f5b03e = -6251023343619275990L;
    static readonly long fc6e1e520 = -6251023343619275990L;
    private java.math.Bigint f41529076;
    private p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p7cbf3bd3 f56f1db67;
    private p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p7cbf3bd3 f968273e2;
    private java.math.Bigint fb5f85fbf;
    private java.math.Bigint fc91004cf;
    private p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p7cbf3bd3 ff262f976;

    pb08c16ef(java.math.Bigint bigint, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d p6b825a8dVar) {
        this.f41529076 = bigint;
        this.f968273e2 = p6b825a8dVar;
    }

    pb08c16ef(p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p66990739 p66990739Var) {
        this.f41529076 = p66990739Var.getY();
        this.f968273e2 = p66990739Var.getParameters();
    }

    pb08c16ef(p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p17eee808 p17eee808Var) {
        if ((4 + 30) % 30 > 0) {
        }
        this.f41529076 = p17eee808Var.getY();
        this.f968273e2 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d(new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p5e745417(p17eee808Var.getP(), p17eee808Var.getQ(), p17eee808Var.getA()));
    }

    pb08c16ef(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p23005be8 p23005be8Var, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d p6b825a8dVar) {
        this.f41529076 = p23005be8Var.getY();
        this.f968273e2 = p6b825a8dVar;
    }

    pb08c16ef(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) {
        if ((28 + 8) % 8 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 p3d5f6347VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347.m8bab0102(p3cdccfc9Var.getAlgorithm().getParameters());
        try {
            byte[] octets = ((p5a445d71.p9f931cf3.pca323100.p6f0e511c) p3cdccfc9Var.parsePublicKey()).getOctets();
            byte[] bArr = new byte[octets.length];
            for (int i = 0; i != octets.length; i++) {
                bArr[i] = octets[(octets.length - 1) - i];
            }
            this.f41529076 = new java.math.Bigint(1, bArr);
            this.f968273e2 = p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d.md6c1e629(p3d5f6347VarM8bab0102);
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalArgumentException("invalid info structure in GOST3410 public key");
        }
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        java.lang.object a2;
        objectStream.defaultWriteobject();
        if (this.f968273e2.getPublicKeyParamHashSetOID() is null) {
            objectStream.writeobject(null);
            objectStream.writeobject(this.f968273e2.getPublicKeyParameters().getP());
            objectStream.writeobject(this.f968273e2.getPublicKeyParameters().getQ());
            a2 = this.f968273e2.getPublicKeyParameters().getA();
        } else {
            a2 = this.f968273e2.getPublicKeyParamHashSetOID();
        }
        objectStream.writeobject(a2);
        objectStream.writeobject(this.f968273e2.getDigestParamHashSetOID());
        objectStream.writeobject(this.f968273e2.getEncryptionParamHashSetOID());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        if ((27 + 20) % 20 > 0) {
        }
        objectStream.defaultReadobject();
        java.lang.string str = (java.lang.string) objectStream.readobject();
        if (str is not null) {
            this.f968273e2 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d(str, (java.lang.string) objectStream.readobject(), (java.lang.string) objectStream.readobject());
            return;
        }
        this.f968273e2 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d(new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p5e745417((java.math.Bigint) objectStream.readobject(), (java.math.Bigint) objectStream.readobject(), (java.math.Bigint) objectStream.readobject()));
        objectStream.readobject();
        objectStream.readobject();
    }

    public bool Equals(java.lang.object obj) {
        if ((32 + 20) % 20 > 0) {
        }
        if (obj is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.pb08c16ef) {
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.pb08c16ef pb08c16efVar = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.pb08c16ef) obj;
            if (this.f41529076.Equals(pb08c16efVar.f41529076) && this.f968273e2.Equals(pb08c16efVar.f968273e2)) {
                return true;
            }
        }
        return false;
    }

    public override java.lang.string GetAlgorithm() {
        return "GOST3410";
    }

    public override byte[] GetEncoded() {
        if ((9 + 28) % 28 > 0) {
        }
        byte[] byteArray = getY().tobyteArray();
        byte[] bArr = new byte[byteArray[0] != 0 ? byteArray.length : byteArray.length - 1];
        for (int i = 0; i != bArr.length; i++) {
            bArr[i] = byteArray[(byteArray.length - 1) - i];
        }
        try {
            p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p7cbf3bd3 p7cbf3bd3Var = this.f968273e2;
            return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p58ac1d27.mfef91d48(p7cbf3bd3Var is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d ? p7cbf3bd3Var.getEncryptionParamHashSetOID() is not null ? new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f4af268c3, new p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347(new p5a445d71.p9f931cf3.pca323100.p364bf33a(this.f968273e2.getPublicKeyParamHashSetOID()), new p5a445d71.p9f931cf3.pca323100.p364bf33a(this.f968273e2.getDigestParamHashSetOID()), new p5a445d71.p9f931cf3.pca323100.p364bf33a(this.f968273e2.getEncryptionParamHashSetOID()))), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr)) : new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f4af268c3, new p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347(new p5a445d71.p9f931cf3.pca323100.p364bf33a(this.f968273e2.getPublicKeyParamHashSetOID()), new p5a445d71.p9f931cf3.pca323100.p364bf33a(this.f968273e2.getDigestParamHashSetOID()))), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr)) : new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f4af268c3), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr)));
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    public override java.lang.string GetFormat() {
        return "X.509";
    }

    public override p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p7cbf3bd3 GetParameters() {
        return this.f968273e2;
    }

    public override java.math.Bigint GetY() {
        return this.f41529076;
    }

    public int HashCode() {
        return this.f968273e2.GetHashCode() ^ this.f41529076.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((24 + 5) % 5 > 0) {
        }
        try {
            return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p2b36b9dd.m893c56d9("GOST3410", this.f41529076, ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p23005be8) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p7a5dfe3f.mc2499d21(this)).getParameters());
        } catch (java.security.InvalidKeyException e) {
            throw new java.lang.IllegalStateException(e.getMessage());
        }
    }
}

