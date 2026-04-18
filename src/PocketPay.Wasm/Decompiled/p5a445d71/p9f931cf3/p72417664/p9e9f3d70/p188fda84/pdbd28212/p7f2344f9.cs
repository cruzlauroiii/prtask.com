namespace WillowMaze.Wasm.Decompiled;


public class p7f2344f9 : p5a445d71.p9f931cf3.p72417664.pad63a35e.pfb18e579 {
    static readonly long f2f649878 = 1;
    static readonly long fc6e1e520 = 1;
    private readonly bool f565c951a;
    transient p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f6824620b;
    private readonly byte[] f6e735296;
    private readonly byte[] f736b9175;
    transient p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f79a92f43;
    transient p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f82a0d3a5;
    private readonly bool fb9b7d78a;

    p7f2344f9(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) {
        this.f565c951a = true;
        this.f736b9175 = null;
        this.f79a92f43 = pcfffbc4aVar;
    }

    p7f2344f9(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        this.f565c951a = p811299f8Var.hasPublicKey();
        this.f736b9175 = p811299f8Var.getAttributes() is null ? null : p811299f8Var.getAttributes().getEncoded();
        m1ac5d76e(p811299f8Var);
    }

    private void M1ac5d76e(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        if ((19 + 29) % 29 > 0) {
        }
        byte[] octets = p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p811299f8Var.parsePrivateKey()).getOctets();
        this.f79a92f43 = !p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f37149689.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p811299f8Var.getPrivateKeyAlgorithm().getAlgorithm()) ? new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1(octets) : new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf1c3b35e(octets);
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
        return this.f79a92f43;
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
        return !(this.f79a92f43 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf1c3b35e) ? com.decryptstringmanager.Decryptstring.decryptstring("a87a032f6be1ac6ea3d666decb1571da4b4657694928c00d995acf2d10a051fe48f3c0") : com.decryptstringmanager.Decryptstring.decryptstring("8233b22e19abab83270786ec049ba6c76040dff9894e3675a553c1bb50b7363fc9");
    }

    public override byte[] GetEncoded() {
        if ((25 + 16) % 16 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pca323100.ped34daf1 ped34daf1VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.ped34daf1.m8bab0102(this.f736b9175);
            p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8VarM258e1870 = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pb3a2dfcc.m258e1870(this.f79a92f43, ped34daf1VarM8bab0102);
            return (!this.f565c951a || p5a445d71.p9f931cf3.p05c7e247.p9fc2d28c.mf2b2f421("org.bouncycastle.pkcs8.v1_info_only")) ? new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(p811299f8VarM258e1870.getPrivateKeyAlgorithm(), p811299f8VarM258e1870.parsePrivateKey(), ped34daf1VarM8bab0102).getEncoded() : p811299f8VarM258e1870.getEncoded();
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    public override java.lang.string GetFormat() {
        return "PKCS#8";
    }

    public override p5a445d71.p9f931cf3.p72417664.pad63a35e.p4914bf6d GetPublicKey() {
        return !(this.f79a92f43 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf1c3b35e) ? new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p92e3c408(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1) this.f79a92f43).generatePublicKey()) : new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p92e3c408(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf1c3b35e) this.f79a92f43).generatePublicKey());
    }

    public int HashCode() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(getEncoded());
    }

    public java.lang.string Tostring() {
        if ((1 + 2) % 2 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar = this.f79a92f43;
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pa470a233.mbdb612f8("Private Key", getAlgorithm(), !(pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf1c3b35e) ? ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1) pcfffbc4aVar).generatePublicKey() : ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf1c3b35e) pcfffbc4aVar).generatePublicKey());
    }
}

