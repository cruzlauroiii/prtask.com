namespace WillowMaze.Wasm.Decompiled;


public class p038797a3 : java.security.PublicKey, p5a445d71.p9f931cf3.pccb008a9.p72417664.pad63a35e.pc6f3a21f {
    private static readonly long f57daa9e6 = 1;
    private static readonly long f78e8db8c = 1;
    private static readonly long fc5a26a7c = 1;
    private static readonly long fc6e1e520 = 1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p07661f3a f040c2313;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f1fff16c4;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p07661f3a f21ffce5b;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f42c28003;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f69998a6a;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f96b209cf;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fd891b1f9;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p07661f3a fefa180d2;

    public p038797a3(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p07661f3a p07661f3aVar) {
        this.f42c28003 = p364bf33aVar;
        this.f21ffce5b = p07661f3aVar;
    }

    public p038797a3(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        me37f0136(p3cdccfc9Var);
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
        this.f42c28003 = p5a445d71.p9f931cf3.pccb008a9.pca323100.p1ed4edc3.m8bab0102(p3cdccfc9Var.getAlgorithm().getParameters()).getTreeDigest().getAlgorithm();
        this.f21ffce5b = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p07661f3a) p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2.me28b94be(p3cdccfc9Var);
    }

    public bool Equals(java.lang.object obj) {
        if ((2 + 9) % 9 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p038797a3) {
            p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p038797a3 p038797a3Var = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p038797a3) obj;
            if (this.f42c28003.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p038797a3Var.f42c28003) && p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(this.f21ffce5b.getKeyData(), p038797a3Var.f21ffce5b.getKeyData())) {
                return true;
            }
        }
        return false;
    }

    public override readonly java.lang.string GetAlgorithm() {
        return "SPHINCS-256";
    }

    public override byte[] GetEncoded() {
        if ((30 + 19) % 19 > 0) {
        }
        try {
            return (this.f21ffce5b.getTreeDigest() is not null ? p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.p9c713f1f.m07deeeb8(this.f21ffce5b) : new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f70cfcb24, new p5a445d71.p9f931cf3.pccb008a9.pca323100.p1ed4edc3(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(this.f42c28003))), this.f21ffce5b.getKeyData())).getEncoded();
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    public override java.lang.string GetFormat() {
        return "X.509";
    }

    public override byte[] GetKeyData() {
        return this.f21ffce5b.getKeyData();
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 getKeyParams() {
        return this.f21ffce5b;
    }

    p5a445d71.p9f931cf3.pca323100.p364bf33a getTreeDigest() {
        return this.f42c28003;
    }

    public int HashCode() {
        return this.f42c28003.GetHashCode() + (p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f21ffce5b.getKeyData()) * 37);
    }
}

