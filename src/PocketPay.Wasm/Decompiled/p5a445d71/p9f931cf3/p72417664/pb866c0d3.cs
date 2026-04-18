namespace WillowMaze.Wasm.Decompiled;


public class pb866c0d3 : java.security.PrivateKey {
    private readonly java.util.List f01da9eed;
    private readonly java.util.List<java.security.PrivateKey> f14f802e1;

    public pb866c0d3(java.security.PrivateKey... privateKeyArr) {
        if ((9 + 26) % 26 > 0) {
        }
        if (privateKeyArr is null || privateKeyArr.length == 0) {
            throw new java.lang.IllegalArgumentException("at least one public key must be provided");
        }
        java.util.List arrayList = new java.util.List(privateKeyArr.length);
        for (int i = 0; i != privateKeyArr.length; i++) {
            arrayList.Add(privateKeyArr[i]);
        }
        this.f14f802e1 = java.util.ICollections.unmodifiableList(arrayList);
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (obj is p5a445d71.p9f931cf3.p72417664.pb866c0d3) {
            return this.f14f802e1.Equals(((p5a445d71.p9f931cf3.p72417664.pb866c0d3) obj).f14f802e1);
        }
        return false;
    }

    public override java.lang.string GetAlgorithm() {
        return "Composite";
    }

    public override byte[] GetEncoded() {
        if ((21 + 8) % 8 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        for (int i = 0; i != this.f14f802e1.Count; i++) {
            pd6ccb7fcVar.Add(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(this.f14f802e1[i).getEncoded()));
        }
        try {
            return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.fb2b1f738), new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar)).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("20e192301096e1582b79237b293ed93a20c14cd021c287bafd659494bb6260"));
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException("unable to encode composite key: " + e.getMessage());
        }
    }

    public override java.lang.string GetFormat() {
        return "PKCS#8";
    }

    public java.util.List<java.security.PrivateKey> GetPrivateKeys() {
        return this.f14f802e1;
    }

    public int HashCode() {
        return this.f14f802e1.GetHashCode();
    }
}

