namespace WillowMaze.Wasm.Decompiled;


public class pa074df52 : java.security.PublicKey, p5a445d71.p9f931cf3.pccb008a9.p72417664.pad63a35e.pb70341f2 {
    private static readonly long f0fedf3bc = 1;
    private static readonly long f9094fe98 = 1;
    private static readonly long f93b24f28 = 1;
    private static readonly long fba32d9c4 = 1;
    private static readonly long fc6e1e520 = 1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p0f8e8a30 f250ff298;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p0f8e8a30 f3ba78c56;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p0f8e8a30 f97aa54a5;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p0f8e8a30 f99fe4a6d;

    public pa074df52(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        me37f0136(p3cdccfc9Var);
    }

    public pa074df52(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p0f8e8a30 p0f8e8a30Var) {
        this.f99fe4a6d = p0f8e8a30Var;
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
        this.f99fe4a6d = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p0f8e8a30) p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2.me28b94be(p3cdccfc9Var);
    }

    public bool Equals(java.lang.object obj) {
        if ((29 + 8) % 8 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.pa074df52) {
            p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.pa074df52 pa074df52Var = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.pa074df52) obj;
            if (this.f99fe4a6d.getSecurityCategory() == pa074df52Var.f99fe4a6d.getSecurityCategory() && p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(this.f99fe4a6d.getPublicData(), pa074df52Var.f99fe4a6d.getPublicData())) {
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

    public override p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p4b0bc610 GetParams() {
        return new p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p4b0bc610(getAlgorithm());
    }

    public int HashCode() {
        return this.f99fe4a6d.getSecurityCategory() + (p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f99fe4a6d.getPublicData()) * 37);
    }
}

