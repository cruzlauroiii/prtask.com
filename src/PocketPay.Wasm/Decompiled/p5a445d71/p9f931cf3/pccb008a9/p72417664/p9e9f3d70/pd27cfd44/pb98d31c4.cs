namespace WillowMaze.Wasm.Decompiled;


public class pb98d31c4 : java.security.PublicKey, p5a445d71.p9f931cf3.pccb008a9.p72417664.pad63a35e.pd60317de {
    private static readonly long fb0495f28 = -5617456225328969766L;
    private static readonly long fc6e1e520 = -5617456225328969766L;
    private static readonly long fd29c5737 = -5617456225328969766L;
    private static readonly long fdc0f512b = -5617456225328969766L;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pcc0037e2 f33c67437;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pcc0037e2 f5e736440;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pcc0037e2 f99fe4a6d;

    public pb98d31c4(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        me37f0136(p3cdccfc9Var);
    }

    public pb98d31c4(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pcc0037e2 pcc0037e2Var) {
        this.f99fe4a6d = pcc0037e2Var;
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        objectStream.writeobject(getEncoded());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        objectStream.defaultReadobject();
        me37f0136(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102((byte[]) objectStream.readobject()));
    }

    private void Me37f0136(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        this.f99fe4a6d = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pcc0037e2) p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2.me28b94be(p3cdccfc9Var);
    }

    public bool Equals(java.lang.object obj) {
        if ((30 + 11) % 11 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.pb98d31c4) {
            try {
                return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(this.f99fe4a6d.getEncoded(), ((p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.pb98d31c4) obj).f99fe4a6d.getEncoded());
            } catch (java.io.IOException unused) {
            }
        }
        return false;
    }

    public override readonly java.lang.string GetAlgorithm() {
        return "LMS";
    }

    public override byte[] GetEncoded() {
        try {
            return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.p9c713f1f.m07deeeb8(this.f99fe4a6d).getEncoded();
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    public override java.lang.string GetFormat() {
        return "X.509";
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 getKeyParams() {
        return this.f99fe4a6d;
    }

    public override int GetLevels() {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pcc0037e2 pcc0037e2Var = this.f99fe4a6d;
        if (pcc0037e2Var is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6) {
            return 1;
        }
        return ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b) pcc0037e2Var).getL();
    }

    public int HashCode() {
        try {
            return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f99fe4a6d.getEncoded());
        } catch (java.io.IOException unused) {
            return -1;
        }
    }
}

