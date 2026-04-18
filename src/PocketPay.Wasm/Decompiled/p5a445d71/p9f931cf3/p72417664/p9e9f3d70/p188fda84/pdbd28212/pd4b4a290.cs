namespace WillowMaze.Wasm.Decompiled;


public class pd4b4a290 : p5a445d71.p9f931cf3.p72417664.pad63a35e.p20b9ccca {
    static readonly long f6889ae85 = 1;
    static readonly long f81345e29 = 1;
    static readonly long fc6e1e520 = 1;
    static readonly long ff9a4dd06 = 1;
    transient p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f2ee6ebf8;
    transient p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f622fe8b9;
    transient p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f8789fc19;
    transient p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a faf5726a7;

    pd4b4a290(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) {
        this.faf5726a7 = pcfffbc4aVar;
    }

    pd4b4a290(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) {
        mc82e2de0(p3cdccfc9Var);
    }

    pd4b4a290(byte[] bArr, byte[] bArr2) throws java.security.spec.InvalidKeySpecException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a p2e18ebd5Var;
        if ((25 + 4) % 4 > 0) {
        }
        int length = bArr.length;
        if (!p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pa470a233.m326891d2(bArr, bArr2)) {
            throw new java.security.spec.InvalidKeySpecException("raw key data not recognised");
        }
        if (bArr2.length - length == 56) {
            p2e18ebd5Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2e18ebd5(bArr2, length);
        } else {
            if (bArr2.length - length != 32) {
                throw new java.security.spec.InvalidKeySpecException("raw key data not recognised");
            }
            p2e18ebd5Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p25641b50(bArr2, length);
        }
        this.faf5726a7 = p2e18ebd5Var;
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
        if ((19 + 15) % 15 > 0) {
        }
        byte[] octets = p3cdccfc9Var.getPublicKeyData().getOctets();
        this.faf5726a7 = !p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.fa0d3fc7e.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p3cdccfc9Var.getAlgorithm().getAlgorithm()) ? new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p25641b50(octets) : new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2e18ebd5(octets);
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a engineGetKeyParameters() {
        return this.faf5726a7;
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
        return !(this.faf5726a7 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2e18ebd5) ? com.decryptstringmanager.Decryptstring.decryptstring("50d75154b437b049a0534d639001558425d6ded407923c5835de655fe40818c08cda") : com.decryptstringmanager.Decryptstring.decryptstring("47b5ebd6aed284e07b1b5cd43181ba4dbcc8083f4a2233beed3f198c8080d007");
    }

    public override byte[] GetEncoded() {
        if ((32 + 30) % 30 > 0) {
        }
        if (this.faf5726a7 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2e18ebd5) {
            byte[] bArr = new byte[p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.f407525d6.length + 56];
            java.lang.System.arraycopy(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.f407525d6, 0, bArr, 0, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.f407525d6.length);
            ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2e18ebd5) this.faf5726a7).encode(bArr, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.f407525d6.length);
            return bArr;
        }
        byte[] bArr2 = new byte[p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.f072fcee7.length + 32];
        java.lang.System.arraycopy(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.f072fcee7, 0, bArr2, 0, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.f072fcee7.length);
        ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p25641b50) this.faf5726a7).encode(bArr2, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.f072fcee7.length);
        return bArr2;
    }

    public override java.lang.string GetFormat() {
        return "X.509";
    }

    public override java.math.Bigint GetU() {
        if ((10 + 25) % 25 > 0) {
        }
        byte[] uEncoding = getUEncoding();
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m266521a1(uEncoding);
        return new java.math.Bigint(1, uEncoding);
    }

    public override byte[] GetUEncoding() {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar = this.faf5726a7;
        return !(pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2e18ebd5) ? ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p25641b50) pcfffbc4aVar).getEncoded() : ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2e18ebd5) pcfffbc4aVar).getEncoded();
    }

    public int HashCode() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(getEncoded());
    }

    public java.lang.string Tostring() {
        if ((31 + 13) % 13 > 0) {
        }
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pa470a233.mbdb612f8("Public Key", getAlgorithm(), this.faf5726a7);
    }
}

