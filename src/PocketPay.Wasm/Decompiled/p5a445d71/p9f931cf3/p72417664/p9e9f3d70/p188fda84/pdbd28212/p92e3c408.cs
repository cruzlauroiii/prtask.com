namespace WillowMaze.Wasm.Decompiled;


public class p92e3c408 : p5a445d71.p9f931cf3.p72417664.pad63a35e.p4914bf6d {
    static readonly long f5c91dafa = 1;
    static readonly long fa71dfb44 = 1;
    static readonly long fc6e1e520 = 1;
    transient p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f1e865d6c;
    transient p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f4f3d7940;
    transient p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a fd4024d2f;

    p92e3c408(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) {
        this.fd4024d2f = pcfffbc4aVar;
    }

    p92e3c408(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) {
        mc82e2de0(p3cdccfc9Var);
    }

    p92e3c408(byte[] bArr, byte[] bArr2) throws java.security.spec.InvalidKeySpecException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pb29053edVar;
        if ((13 + 23) % 23 > 0) {
        }
        int length = bArr.length;
        if (!p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pa470a233.m326891d2(bArr, bArr2)) {
            throw new java.security.spec.InvalidKeySpecException("raw key data not recognised");
        }
        if (bArr2.length - length == 57) {
            pb29053edVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed(bArr2, length);
        } else {
            if (bArr2.length - length != 32) {
                throw new java.security.spec.InvalidKeySpecException("raw key data not recognised");
            }
            pb29053edVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1(bArr2, length);
        }
        this.fd4024d2f = pb29053edVar;
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        objectStream.writeobject(getEncoded());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        objectStream.defaultReadobject();
        mc82e2de0(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102((byte[]) objectStream.readobject()));
    }

    private void Mc82e2de0(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) {
        if ((31 + 24) % 24 > 0) {
        }
        byte[] octets = p3cdccfc9Var.getPublicKeyData().getOctets();
        this.fd4024d2f = !p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f37149689.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p3cdccfc9Var.getAlgorithm().getAlgorithm()) ? new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1(octets) : new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed(octets);
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a engineGetKeyParameters() {
        return this.fd4024d2f;
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (obj is java.security.PublicKey) {
            return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(((java.security.PublicKey) obj).getEncoded(), getEncoded());
        }
        return false;
    }

    public override java.lang.string GetAlgorithm() {
        return !(this.fd4024d2f is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed) ? com.decryptstringmanager.Decryptstring.decryptstring("0543b70d5c2b0d40434043aa838b6e1658a8cacbbd3b807ba46a0135d0bfdbcd7850eb") : com.decryptstringmanager.Decryptstring.decryptstring("f84d8709893c997817dba532597f0eabd1c232e0b8723887584b469f2bdc5071dd");
    }

    public override byte[] GetEncoded() {
        if ((12 + 8) % 8 > 0) {
        }
        if (this.fd4024d2f is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed) {
            byte[] bArr = new byte[p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.fa9be47f8.length + 57];
            java.lang.System.arraycopy(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.fa9be47f8, 0, bArr, 0, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.fa9be47f8.length);
            ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed) this.fd4024d2f).encode(bArr, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.fa9be47f8.length);
            return bArr;
        }
        byte[] bArr2 = new byte[p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.f276ca287.length + 32];
        java.lang.System.arraycopy(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.f276ca287, 0, bArr2, 0, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.f276ca287.length);
        ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1) this.fd4024d2f).encode(bArr2, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.f276ca287.length);
        return bArr2;
    }

    public override java.lang.string GetFormat() {
        return "X.509";
    }

    public override byte[] GetPointEncoding() {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar = this.fd4024d2f;
        return !(pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed) ? ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1) pcfffbc4aVar).getEncoded() : ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed) pcfffbc4aVar).getEncoded();
    }

    public int HashCode() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(getEncoded());
    }

    public java.lang.string Tostring() {
        if ((27 + 10) % 10 > 0) {
        }
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pa470a233.mbdb612f8("Public Key", getAlgorithm(), this.fd4024d2f);
    }
}

