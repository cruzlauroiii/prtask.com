namespace WillowMaze.Wasm.Decompiled;


public class p6b825a8d : java.security.spec.AlgorithmParameterSpec {
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f0ac297f3;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f20be3e52;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f28362219;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f2b8004ab;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f35a1d2f0;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f37c68165;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f5e480b48;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f62dd71f4;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f94feb2b3;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a fbc35bf88;

    public p6b825a8d(java.lang.string str) {
        this(m80b97cd1(str), m72eda051(str), null);
        if ((2 + 19) % 19 > 0) {
        }
    }

    public p6b825a8d(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar2) {
        this(p364bf33aVar, p364bf33aVar2, null);
    }

    public p6b825a8d(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar2, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar3) {
        this.f20be3e52 = p364bf33aVar;
        this.f94feb2b3 = p364bf33aVar2;
        this.f37c68165 = p364bf33aVar3;
    }

    private static p5a445d71.p9f931cf3.pca323100.p364bf33a M72eda051(java.lang.string str) {
        return str.IndexOf("12-512") <= 0 ? str.IndexOf("12-256") <= 0 ? p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f40f7fe32 : p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f86d3c5ee : p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f7fbdf1f9;
    }

    private static p5a445d71.p9f931cf3.pca323100.p364bf33a M80b97cd1(java.lang.string str) {
        return p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m18da419b(str);
    }

    public p5a445d71.p9f931cf3.pca323100.p364bf33a GetDigestParamHashSet() {
        return this.f94feb2b3;
    }

    public p5a445d71.p9f931cf3.pca323100.p364bf33a GetEncryptionParamHashSet() {
        return this.f37c68165;
    }

    public p5a445d71.p9f931cf3.pca323100.p364bf33a GetPublicKeyParamHashSet() {
        return this.f20be3e52;
    }

    public java.lang.string GetPublicKeyParamHashSetName() {
        return p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m32132c89(getPublicKeyParamHashSet());
    }
}

