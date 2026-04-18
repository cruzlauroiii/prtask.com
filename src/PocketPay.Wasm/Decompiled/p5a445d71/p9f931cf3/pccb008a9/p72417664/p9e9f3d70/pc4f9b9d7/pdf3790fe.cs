namespace WillowMaze.Wasm.Decompiled;


public class pdf3790fe : p5a445d71.p9f931cf3.pccb008a9.p72417664.pad63a35e.pe6aa8a38 {
    private static readonly long f7f889e62 = 1;
    private static readonly long f8e324c62 = 1;
    private static readonly long fb2d8a9cb = 1;
    private static readonly long fc6e1e520 = 1;
    private static readonly long fe39cac03 = 1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3 f0a7b250b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3 f17095ac0;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3 f21ffce5b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3 fa3c2becb;

    public pdf3790fe(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        me37f0136(p3cdccfc9Var);
    }

    public pdf3790fe(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3 p6c7d76f3Var) {
        this.f21ffce5b = p6c7d76f3Var;
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
        this.f21ffce5b = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3) p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2.me28b94be(p3cdccfc9Var);
    }

    public bool Equals(java.lang.object obj) {
        if (obj is null || !(obj is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pc4f9b9d7.pdf3790fe)) {
            return false;
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(this.f21ffce5b.getPubData(), ((p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pc4f9b9d7.pdf3790fe) obj).f21ffce5b.getPubData());
    }

    public override readonly java.lang.string GetAlgorithm() {
        return "NH";
    }

    public override byte[] GetEncoded() {
        try {
            return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.p9c713f1f.m07deeeb8(this.f21ffce5b).getEncoded();
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    public override java.lang.string GetFormat() {
        return "X.509";
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 getKeyParams() {
        return this.f21ffce5b;
    }

    public override byte[] GetPublicData() {
        return this.f21ffce5b.getPubData();
    }

    public int HashCode() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f21ffce5b.getPubData());
    }
}

