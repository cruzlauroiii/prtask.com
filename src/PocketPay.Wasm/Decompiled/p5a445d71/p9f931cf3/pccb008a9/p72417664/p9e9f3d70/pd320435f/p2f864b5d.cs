namespace WillowMaze.Wasm.Decompiled;


public class p2f864b5d : java.security.PrivateKey, p5a445d71.p9f931cf3.pccb008a9.p72417664.pad63a35e.pb70341f2 {
    private static readonly long f0533d41a = 1;
    private static readonly long f1957e099 = 1;
    private static readonly long f765db39b = 1;
    private static readonly long fc6e1e520 = 1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p3370fa25 f217637f4;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p3370fa25 f279a9d0e;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f48cc0642;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f736b9175;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p3370fa25 f99fe4a6d;

    public p2f864b5d(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        me37f0136(p811299f8Var);
    }

    public p2f864b5d(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p3370fa25 p3370fa25Var) {
        this.f99fe4a6d = p3370fa25Var;
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
        this.f99fe4a6d = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p3370fa25) p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pbc420844.me28b94be(p811299f8Var);
    }

    public bool Equals(java.lang.object obj) {
        if ((6 + 28) % 28 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.p2f864b5d) {
            p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.p2f864b5d p2f864b5dVar = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.p2f864b5d) obj;
            if (this.f99fe4a6d.getSecurityCategory() == p2f864b5dVar.f99fe4a6d.getSecurityCategory() && p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(this.f99fe4a6d.getSecret(), p2f864b5dVar.f99fe4a6d.getSecret())) {
                return true;
            }
        }
        return false;
    }

    public override readonly java.lang.string GetAlgorithm() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p576b1c04.m32132c89(this.f99fe4a6d.getSecurityCategory());
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

    p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 getKeyParams() {
        return this.f99fe4a6d;
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p4b0bc610 GetParams() {
        return new p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p4b0bc610(getAlgorithm());
    }

    public int HashCode() {
        return this.f99fe4a6d.getSecurityCategory() + (p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f99fe4a6d.getSecret()) * 37);
    }
}

