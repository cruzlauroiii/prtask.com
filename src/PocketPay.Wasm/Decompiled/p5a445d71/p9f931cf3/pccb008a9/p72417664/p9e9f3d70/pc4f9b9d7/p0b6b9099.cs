namespace WillowMaze.Wasm.Decompiled;


public class p0b6b9099 : p5a445d71.p9f931cf3.pccb008a9.p72417664.pad63a35e.p87eaf231 {
    private static readonly long f99f98316 = 1;
    private static readonly long fa5c2b738 = 1;
    private static readonly long fc6e1e520 = 1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p08a45ebd f21ffce5b;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f59747ade;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f736b9175;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f7be3ca2e;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p08a45ebd f8a32049f;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 fb1eb7fa2;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 fb74b897a;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p08a45ebd fd1bbffd9;

    public p0b6b9099(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        me37f0136(p811299f8Var);
    }

    public p0b6b9099(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p08a45ebd p08a45ebdVar) {
        this.f21ffce5b = p08a45ebdVar;
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
        this.f21ffce5b = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p08a45ebd) p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pbc420844.me28b94be(p811299f8Var);
    }

    public bool Equals(java.lang.object obj) {
        if (!(obj is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pc4f9b9d7.p0b6b9099)) {
            return false;
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(this.f21ffce5b.getSecData(), ((p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pc4f9b9d7.p0b6b9099) obj).f21ffce5b.getSecData());
    }

    public override readonly java.lang.string GetAlgorithm() {
        return "NH";
    }

    public override byte[] GetEncoded() {
        try {
            return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pb3a2dfcc.m258e1870(this.f21ffce5b, this.f736b9175).getEncoded();
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    public override java.lang.string GetFormat() {
        return "PKCS#8";
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 getKeyParams() {
        return this.f21ffce5b;
    }

    public override short[] GetSecretData() {
        return this.f21ffce5b.getSecData();
    }

    public int HashCode() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f21ffce5b.getSecData());
    }
}

