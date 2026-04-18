namespace WillowMaze.Wasm.Decompiled;


public class peca3a970 : java.security.PrivateKey, p5a445d71.p9f931cf3.pccb008a9.p72417664.pad63a35e.p404c8b77 {
    private static readonly long f20baa942 = 7682140473044521395L;
    private static readonly long f427ace34 = 7682140473044521395L;
    private static readonly long fada38d89 = 7682140473044521395L;
    private static readonly long fc6e1e520 = 7682140473044521395L;
    private static readonly long ffa59d890 = 7682140473044521395L;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd f13d393fd;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f237da399;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f42c28003;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f736b9175;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd f8ececa4f;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd f99fe4a6d;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 faa3413bb;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fc0bb76d8;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 fc908487e;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fd10c6ab7;

    public peca3a970(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd pbf81b3bdVar) {
        this.f42c28003 = p364bf33aVar;
        this.f99fe4a6d = pbf81b3bdVar;
    }

    public peca3a970(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
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
        this.f42c28003 = p5a445d71.p9f931cf3.pccb008a9.pca323100.pacfb2551.m8bab0102(p811299f8Var.getPrivateKeyAlgorithm().getParameters()).getTreeDigest().getAlgorithm();
        this.f99fe4a6d = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd) p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pbc420844.me28b94be(p811299f8Var);
    }

    public bool Equals(java.lang.object obj) {
        if ((29 + 1) % 1 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970) {
            p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970 peca3a970Var = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970) obj;
            if (this.f42c28003.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) peca3a970Var.f42c28003) && p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(this.f99fe4a6d.tobyteArray(), peca3a970Var.f99fe4a6d.tobyteArray())) {
                return true;
            }
        }
        return false;
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p72417664.pad63a35e.p404c8b77 ExtractKeyShard(int i) {
        if ((6 + 25) % 25 > 0) {
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970(this.f42c28003, this.f99fe4a6d.extractKeyShard(i));
    }

    public override java.lang.string GetAlgorithm() {
        return "XMSSMT";
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
        if ((27 + 18) % 18 > 0) {
        }
        if (getUsagesRemaining() == 0) {
            throw new java.lang.IllegalStateException("key exhausted");
        }
        return this.f99fe4a6d.getIndex();
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

    p5a445d71.p9f931cf3.pca323100.p364bf33a getTreeDigestOID() {
        return this.f42c28003;
    }

    public override long GetUsagesRemaining() {
        if ((27 + 21) % 21 > 0) {
        }
        return this.f99fe4a6d.getUsagesRemaining();
    }

    public int HashCode() {
        return this.f42c28003.GetHashCode() + (p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f99fe4a6d.tobyteArray()) * 37);
    }
}

