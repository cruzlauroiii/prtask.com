namespace WillowMaze.Wasm.Decompiled;


public class pfc9dc6a3 : java.security.PublicKey, p5a445d71.p9f931cf3.pccb008a9.p72417664.pad63a35e.p0db5a41a {
    private static readonly long f163ecb00 = 3230324130542413475L;
    private static readonly long fc6e1e520 = 3230324130542413475L;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f42c28003;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f573c6a6a;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148 f69f4f81a;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148 f90192ebb;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f90c88374;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148 f99fe4a6d;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148 fdae0f61f;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148 fe7d503e9;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a ffcfddd3f;

    public pfc9dc6a3(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148 p51ac8148Var) {
        this.f42c28003 = p364bf33aVar;
        this.f99fe4a6d = p51ac8148Var;
    }

    public pfc9dc6a3(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
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
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148 p51ac8148Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148) p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2.me28b94be(p3cdccfc9Var);
        this.f99fe4a6d = p51ac8148Var;
        this.f42c28003 = p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p69279707.m44ef4a60(p51ac8148Var.getTreeDigest());
    }

    public bool Equals(java.lang.object obj) {
        if ((10 + 18) % 18 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pfc9dc6a3) {
            p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pfc9dc6a3 pfc9dc6a3Var = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pfc9dc6a3) obj;
            if (this.f42c28003.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) pfc9dc6a3Var.f42c28003) && p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(this.f99fe4a6d.tobyteArray(), pfc9dc6a3Var.f99fe4a6d.tobyteArray())) {
                return true;
            }
        }
        return false;
    }

    public override readonly java.lang.string GetAlgorithm() {
        return "XMSSMT";
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

    public override int GetHeight() {
        return this.f99fe4a6d.getParameters().getHeight();
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 getKeyParams() {
        return this.f99fe4a6d;
    }

    public override int GetLayers() {
        return this.f99fe4a6d.getParameters().getLayers();
    }

    public override java.lang.string GetTreeDigest() {
        return p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p69279707.m3d422dba(this.f42c28003);
    }

    public int HashCode() {
        return this.f42c28003.GetHashCode() + (p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f99fe4a6d.tobyteArray()) * 37);
    }
}

