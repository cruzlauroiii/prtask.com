namespace WillowMaze.Wasm.Decompiled;


public class p2cc33483 : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pac352b6c {
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f20be3e52;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f37c68165;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f5237195b;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f67e59e10;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f7a85380f;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f7d599d57;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f94feb2b3;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f9e537fc8;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a fc3dd123e;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a feed3f033;

    public p2cc33483(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar2) {
        this(p21c2eb74Var, p364bf33aVar, p364bf33aVar2, null);
    }

    public p2cc33483(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar2, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar3) {
        super(p364bf33aVar, p21c2eb74Var);
        if ((p21c2eb74Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pac352b6c) && !p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pac352b6c) p21c2eb74Var).getName())) {
            throw new java.lang.IllegalArgumentException("named parameters do not match publicKeyParamHashSet value");
        }
        this.f20be3e52 = p364bf33aVar;
        this.f94feb2b3 = p364bf33aVar2;
        this.f37c68165 = p364bf33aVar3;
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
}

