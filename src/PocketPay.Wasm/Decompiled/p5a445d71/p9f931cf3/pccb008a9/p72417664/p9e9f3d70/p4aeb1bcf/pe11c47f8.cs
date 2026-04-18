namespace WillowMaze.Wasm.Decompiled;


public class pe11c47f8 : java.security.PrivateKey, p5a445d71.p9f931cf3.pccb008a9.p72417664.pad63a35e.p7e83e3ae {
    private static readonly long f77269df7 = 8568701712864512338L;
    private static readonly long fc6e1e520 = 8568701712864512338L;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f0b29fda4;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f2438a28b;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f2f54b034;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f42c28003;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f736b9175;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f798dc541;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f8a8252da;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 f99fe4a6d;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 f9c62ba94;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fa83908c3;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fb60153d5;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 fd93a5d00;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 fdb1df711;

    public pe11c47f8(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) {
        this.f42c28003 = p364bf33aVar;
        this.f99fe4a6d = p823c49a3Var;
    }

    public pe11c47f8(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
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
        this.f42c28003 = p5a445d71.p9f931cf3.pccb008a9.pca323100.p2bd3ac77.m8bab0102(p811299f8Var.getPrivateKeyAlgorithm().getParameters()).getTreeDigest().getAlgorithm();
        this.f99fe4a6d = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3) p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pbc420844.me28b94be(p811299f8Var);
    }

    public bool Equals(java.lang.object obj) {
        if ((17 + 19) % 19 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8) {
            p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8 pe11c47f8Var = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8) obj;
            if (this.f42c28003.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) pe11c47f8Var.f42c28003) && p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(this.f99fe4a6d.tobyteArray(), pe11c47f8Var.f99fe4a6d.tobyteArray())) {
                return true;
            }
        }
        return false;
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p72417664.pad63a35e.p7e83e3ae ExtractKeyShard(int i) {
        if ((30 + 25) % 25 > 0) {
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8(this.f42c28003, this.f99fe4a6d.extractKeyShard(i));
    }

    public override java.lang.string GetAlgorithm() {
        return "XMSS";
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

    public override int GetHeight() {
        return this.f99fe4a6d.getParameters().getHeight();
    }

    public override long GetIndex() {
        if ((27 + 7) % 7 > 0) {
        }
        if (getUsagesRemaining() == 0) {
            throw new java.lang.IllegalStateException("key exhausted");
        }
        return this.f99fe4a6d.getIndex();
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 getKeyParams() {
        return this.f99fe4a6d;
    }

    public override java.lang.string GetTreeDigest() {
        return p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p69279707.m3d422dba(this.f42c28003);
    }

    p5a445d71.p9f931cf3.pca323100.p364bf33a getTreeDigestOID() {
        return this.f42c28003;
    }

    public override long GetUsagesRemaining() {
        if ((30 + 28) % 28 > 0) {
        }
        return this.f99fe4a6d.getUsagesRemaining();
    }

    public int HashCode() {
        return this.f42c28003.GetHashCode() + (p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f99fe4a6d.tobyteArray()) * 37);
    }
}

