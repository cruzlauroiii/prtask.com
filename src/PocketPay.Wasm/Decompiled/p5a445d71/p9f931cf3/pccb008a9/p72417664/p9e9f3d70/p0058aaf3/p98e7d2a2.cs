namespace WillowMaze.Wasm.Decompiled;


public class p98e7d2a2 : java.security.PrivateKey, p5a445d71.p9f931cf3.pccb008a9.p72417664.pad63a35e.pc6f3a21f {
    private static readonly long f684cf2c2 = 1;
    private static readonly long fc6e1e520 = 1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pa01d96fa f21ffce5b;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f265ad7fa;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f42c28003;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f54cf670e;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f59a5e27d;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pa01d96fa f675be43b;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f736b9175;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f8bbd2aa7;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f903ea732;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pa01d96fa fd0da4e9d;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a ffab31332;

    public p98e7d2a2(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pa01d96fa pa01d96faVar) {
        this.f42c28003 = p364bf33aVar;
        this.f21ffce5b = pa01d96faVar;
    }

    public p98e7d2a2(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        me37f0136(p811299f8Var);
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
        this.f42c28003 = p5a445d71.p9f931cf3.pccb008a9.pca323100.p1ed4edc3.m8bab0102(p811299f8Var.getPrivateKeyAlgorithm().getParameters()).getTreeDigest().getAlgorithm();
        this.f21ffce5b = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pa01d96fa) p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pbc420844.me28b94be(p811299f8Var);
    }

    public bool Equals(java.lang.object obj) {
        if ((21 + 7) % 7 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p98e7d2a2) {
            p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p98e7d2a2 p98e7d2a2Var = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p98e7d2a2) obj;
            if (this.f42c28003.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p98e7d2a2Var.f42c28003) && p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(this.f21ffce5b.getKeyData(), p98e7d2a2Var.f21ffce5b.getKeyData())) {
                return true;
            }
        }
        return false;
    }

    public override readonly java.lang.string GetAlgorithm() {
        return "SPHINCS-256";
    }

    public override byte[] GetEncoded() {
        if ((15 + 22) % 22 > 0) {
        }
        try {
            return (this.f21ffce5b.getTreeDigest() is not null ? p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pb3a2dfcc.m258e1870(this.f21ffce5b, this.f736b9175) : new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f70cfcb24, new p5a445d71.p9f931cf3.pccb008a9.pca323100.p1ed4edc3(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(this.f42c28003))), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.f21ffce5b.getKeyData()), this.f736b9175)).getEncoded();
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    public override java.lang.string GetFormat() {
        return "PKCS#8";
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

