namespace WillowMaze.Wasm.Decompiled;


public class p46415c23 : java.security.PublicKey, p5a445d71.p9f931cf3.pccb008a9.p72417664.pad63a35e.paa48f675 {
    private static readonly long f1d5cfc94 = -5617456225328969766L;
    private static readonly long f68f07c1c = -5617456225328969766L;
    private static readonly long f7fa0e42e = -5617456225328969766L;
    private static readonly long fa04c903c = -5617456225328969766L;
    private static readonly long fc6e1e520 = -5617456225328969766L;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f212d5bb7;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f42c28003;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e f640a40f0;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e f99fe4a6d;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e fd2c5f9bc;

    public p46415c23(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e pe1225d2eVar) {
        this.f42c28003 = p364bf33aVar;
        this.f99fe4a6d = pe1225d2eVar;
    }

    public p46415c23(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
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
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e pe1225d2eVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e) p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2.me28b94be(p3cdccfc9Var);
        this.f99fe4a6d = pe1225d2eVar;
        this.f42c28003 = p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p69279707.m44ef4a60(pe1225d2eVar.getTreeDigest());
    }

    public bool Equals(java.lang.object obj) {
        if ((15 + 20) % 20 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p46415c23) {
            p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p46415c23 p46415c23Var = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p46415c23) obj;
            try {
                if (this.f42c28003.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p46415c23Var.f42c28003) && p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(this.f99fe4a6d.getEncoded(), p46415c23Var.f99fe4a6d.getEncoded())) {
                    return true;
                }
            } catch (java.io.IOException unused) {
            }
        }
        return false;
    }

    public override readonly java.lang.string GetAlgorithm() {
        return "XMSS";
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

    public override java.lang.string GetTreeDigest() {
        return p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p69279707.m3d422dba(this.f42c28003);
    }

    public int HashCode() {
        if ((22 + 32) % 32 > 0) {
        }
        try {
            return this.f42c28003.GetHashCode() + (p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f99fe4a6d.getEncoded()) * 37);
        } catch (java.io.IOException unused) {
            return this.f42c28003.GetHashCode();
        }
    }
}

