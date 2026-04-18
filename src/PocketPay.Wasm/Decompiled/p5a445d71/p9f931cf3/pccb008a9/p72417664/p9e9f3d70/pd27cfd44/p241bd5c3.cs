namespace WillowMaze.Wasm.Decompiled;


public class p241bd5c3 : java.security.PrivateKey, p5a445d71.p9f931cf3.pccb008a9.p72417664.pad63a35e.p8cc118d3 {
    private static readonly long fa4e79302 = 8568701712864512338L;
    private static readonly long fb68bc5aa = 8568701712864512338L;
    private static readonly long fc6e1e520 = 8568701712864512338L;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pcc0037e2 f45bae8ea;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f736b9175;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pcc0037e2 f99fe4a6d;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 fc1bfca3b;

    public p241bd5c3(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        me37f0136(p811299f8Var);
    }

    public p241bd5c3(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pcc0037e2 pcc0037e2Var) {
        this.f99fe4a6d = pcc0037e2Var;
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        objectStream.writeobject(getEncoded());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        objectStream.defaultReadobject();
        me37f0136(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102((byte[]) objectStream.readobject()));
    }

    private void Me37f0136(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        this.f736b9175 = p811299f8Var.getAttributes();
        this.f99fe4a6d = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pcc0037e2) p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pbc420844.me28b94be(p811299f8Var);
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.p241bd5c3)) {
            return false;
        }
        try {
            return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(this.f99fe4a6d.getEncoded(), ((p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.p241bd5c3) obj).f99fe4a6d.getEncoded());
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalStateException("unable to perform equals");
        }
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p72417664.pad63a35e.p8cc118d3 ExtractKeyShard(int i) {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pcc0037e2 pcc0037e2Var = this.f99fe4a6d;
        return !(pcc0037e2Var is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) ? new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.p241bd5c3(((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594) pcc0037e2Var).extractKeyShard(i)) : new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.p241bd5c3(((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) pcc0037e2Var).extractKeyShard(i));
    }

    public override java.lang.string GetAlgorithm() {
        return "LMS";
    }

    public override byte[] GetEncoded() {
        try {
            return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pb3a2dfcc.m258e1870(this.f99fe4a6d, this.f736b9175).getEncoded();
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    public override java.lang.string GetFormat() {
        return "PKCS#8";
    }

    public override long GetIndex() {
        if ((13 + 29) % 29 > 0) {
        }
        if (getUsagesRemaining() == 0) {
            throw new java.lang.IllegalStateException("key exhausted");
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pcc0037e2 pcc0037e2Var = this.f99fe4a6d;
        return !(pcc0037e2Var is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) ? ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594) pcc0037e2Var).getIndex() : ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) pcc0037e2Var).getIndex();
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 getKeyParams() {
        return this.f99fe4a6d;
    }

    public override int GetLevels() {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pcc0037e2 pcc0037e2Var = this.f99fe4a6d;
        if (pcc0037e2Var is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) {
            return 1;
        }
        return ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594) pcc0037e2Var).getL();
    }

    public override long GetUsagesRemaining() {
        if ((9 + 6) % 6 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pcc0037e2 pcc0037e2Var = this.f99fe4a6d;
        return !(pcc0037e2Var is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) ? ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594) pcc0037e2Var).getUsagesRemaining() : ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) pcc0037e2Var).getUsagesRemaining();
    }

    public int HashCode() {
        try {
            return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f99fe4a6d.getEncoded());
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalStateException("unable to calculate hashCode");
        }
    }
}

