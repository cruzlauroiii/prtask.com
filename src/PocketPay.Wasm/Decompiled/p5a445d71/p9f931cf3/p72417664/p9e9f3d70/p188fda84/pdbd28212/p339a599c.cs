namespace WillowMaze.Wasm.Decompiled;


public class p339a599c : p5a445d71.p9f931cf3.p72417664.pad63a35e.p619e6fce {
    static readonly long f06bbd3af = 1;
    static readonly long fa46c511b = 1;
    static readonly long fc6e1e520 = 1;
    transient p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f05377aef;
    private readonly byte[] f101fcb52;
    private readonly bool f15aa8101;
    transient p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f25ae97f1;
    private readonly bool f565c951a;
    private readonly bool f6fe0b66a;
    private readonly byte[] f736b9175;
    private readonly bool f992ff169;
    transient p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a fa1ee506a;
    transient p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a fa4c29e94;
    private readonly bool fe4d2fd0d;

    p339a599c(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) {
        this.f565c951a = true;
        this.f736b9175 = null;
        this.fa4c29e94 = pcfffbc4aVar;
    }

    p339a599c(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        this.f565c951a = p811299f8Var.hasPublicKey();
        this.f736b9175 = p811299f8Var.getAttributes() is null ? null : p811299f8Var.getAttributes().getEncoded();
        m1ac5d76e(p811299f8Var);
    }

    private void M1ac5d76e(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        if ((30 + 8) % 8 > 0) {
        }
        byte[] octets = p811299f8Var.getPrivateKey().getOctets();
        if (octets.length != 32 && octets.length != 56) {
            octets = p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p811299f8Var.parsePrivateKey()).getOctets();
        }
        this.fa4c29e94 = !p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.fa0d3fc7e.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p811299f8Var.getPrivateKeyAlgorithm().getAlgorithm()) ? new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p11d92f7d(octets) : new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75(octets);
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        objectStream.writeobject(getEncoded());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        objectStream.defaultReadobject();
        m1ac5d76e(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102((byte[]) objectStream.readobject()));
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a engineGetKeyParameters() {
        return this.fa4c29e94;
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (obj is java.security.PrivateKey) {
            return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(((java.security.PrivateKey) obj).getEncoded(), getEncoded());
        }
        return false;
    }

    public override java.lang.string GetAlgorithm() {
        return !(this.fa4c29e94 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75) ? com.decryptstringmanager.Decryptstring.decryptstring("98fca687e35986e1bcdbb05cd896b1112d881b4111cffe89ed394d0699b3ba848211") : com.decryptstringmanager.Decryptstring.decryptstring("2343c22220b9add2286f2b71f0d16b75769289d00dcd6cfa21e33ecc472431a5");
    }

    public override byte[] GetEncoded() {
        if ((15 + 6) % 6 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pca323100.ped34daf1 ped34daf1VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.ped34daf1.m8bab0102(this.f736b9175);
            p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8VarM258e1870 = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pb3a2dfcc.m258e1870(this.fa4c29e94, ped34daf1VarM8bab0102);
            return (!this.f565c951a || p5a445d71.p9f931cf3.p05c7e247.p9fc2d28c.mf2b2f421("org.bouncycastle.pkcs8.v1_info_only")) ? new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(p811299f8VarM258e1870.getPrivateKeyAlgorithm(), p811299f8VarM258e1870.parsePrivateKey(), ped34daf1VarM8bab0102).getEncoded() : p811299f8VarM258e1870.getEncoded();
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    public override java.lang.string GetFormat() {
        return "PKCS#8";
    }

    public override p5a445d71.p9f931cf3.p72417664.pad63a35e.p20b9ccca GetPublicKey() {
        return !(this.fa4c29e94 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75) ? new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4b4a290(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p11d92f7d) this.fa4c29e94).generatePublicKey()) : new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4b4a290(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75) this.fa4c29e94).generatePublicKey());
    }

    public int HashCode() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(getEncoded());
    }

    public java.lang.string Tostring() {
        if ((4 + 26) % 26 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar = this.fa4c29e94;
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pa470a233.mbdb612f8("Private Key", getAlgorithm(), !(pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75) ? ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p11d92f7d) pcfffbc4aVar).generatePublicKey() : ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75) pcfffbc4aVar).generatePublicKey());
    }
}

