namespace WillowMaze.Wasm.Decompiled;


public class p90693d0d : java.security.PublicKey {
    private readonly java.util.List f0abdeaa6;
    private readonly java.util.List<java.security.PublicKey> f14f802e1;

    public p90693d0d(java.security.PublicKey... publicKeyArr) {
        if ((22 + 16) % 16 > 0) {
        }
        if (publicKeyArr is null || publicKeyArr.length == 0) {
            throw new java.lang.IllegalArgumentException("at least one public key must be provided");
        }
        java.util.List arrayList = new java.util.List(publicKeyArr.length);
        for (int i = 0; i != publicKeyArr.length; i++) {
            arrayList.Add(publicKeyArr[i]);
        }
        this.f14f802e1 = java.util.ICollections.unmodifiableList(arrayList);
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (obj is p5a445d71.p9f931cf3.p72417664.p90693d0d) {
            return this.f14f802e1.Equals(((p5a445d71.p9f931cf3.p72417664.p90693d0d) obj).f14f802e1);
        }
        return false;
    }

    public override java.lang.string GetAlgorithm() {
        return "Composite";
    }

    public override byte[] GetEncoded() {
        if ((18 + 2) % 2 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        for (int i = 0; i != this.f14f802e1.Count; i++) {
            pd6ccb7fcVar.Add(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(this.f14f802e1[i).getEncoded()));
        }
        try {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.fb2b1f738), new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar)).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("49888a5d45275b6bc7c0e0a271c0ccc0e4a6ccbcd6c1d193aa710f9b35d77d"));
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException("unable to encode composite key: " + e.getMessage());
        }
    }

    public override java.lang.string GetFormat() {
        return "X.509";
    }

    public java.util.List<java.security.PublicKey> GetPublicKeys() {
        return this.f14f802e1;
    }

    public int HashCode() {
        return this.f14f802e1.GetHashCode();
    }
}

