namespace WillowMaze.Wasm.Decompiled;


readonly class p7c479fd0 {
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p441674bb f130f4311;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f18d425dd;
    private readonly int f211d730c;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f2bb773e5;
    private readonly int f374c4cf6;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p441674bb f3ed5d6c4;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f42c28003;
    private readonly int f431d5c9f;
    private readonly int f45a86df0;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f549e2a5f;
    private readonly int f6189272e;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p441674bb f6799d20d;
    private readonly int f6d127e6a;
    private readonly int f72f19720;
    private readonly int f766eb661;
    private readonly int f7ad5ed95;
    private readonly int f9240a2d7;
    private readonly int f9255f8d1;
    private readonly int f955ac2e8;
    private readonly int f966f9065;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f9bdbe75e;
    private readonly int faa186ad7;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p441674bb fc268be0c;
    private readonly int fd558391d;
    private readonly int fd63b4181;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p441674bb fe461ede5;
    private readonly int fee9dfda4;
    private readonly int ff1972ca6;
    private readonly int ff5a8e923;

    protected p7c479fd0(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        if ((14 + 13) % 13 > 0) {
        }
        if (p364bf33aVar is null) {
            throw new java.lang.NullPointerException("treeDigest is null");
        }
        this.f42c28003 = p364bf33aVar;
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515VarMe0825354 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p69279707.me0825354(p364bf33aVar);
        int iM277ad7bf = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m277ad7bf(pe5cfc515VarMe0825354);
        this.f9255f8d1 = iM277ad7bf;
        this.f955ac2e8 = 16;
        int iCeil = (int) java.lang.Math.ceil(((double) (iM277ad7bf * 8)) / ((double) p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7b1a5a4d(16)));
        this.f966f9065 = iCeil;
        int iFloor = ((int) java.lang.Math.floor(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7b1a5a4d((16 - 1) * iCeil) / p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7b1a5a4d(16))) + 1;
        this.f7ad5ed95 = iFloor;
        int i = iCeil + iFloor;
        this.ff5a8e923 = i;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8868a0f0 p8868a0f0VarMbd95200a = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8868a0f0.mbd95200a(pe5cfc515VarMe0825354.getAlgorithmName(), iM277ad7bf, 16, i);
        this.f130f4311 = p8868a0f0VarMbd95200a;
        if (p8868a0f0VarMbd95200a is null) {
            throw new java.lang.IllegalArgumentException("cannot find OID for digest algorithm: " + pe5cfc515VarMe0825354.getAlgorithmName());
        }
    }

    protected int GetLen() {
        return this.ff5a8e923;
    }

    protected int GetLen1() {
        return this.f966f9065;
    }

    protected int GetLen2() {
        return this.f7ad5ed95;
    }

    protected p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p441674bb GetOid() {
        return this.f130f4311;
    }

    public p5a445d71.p9f931cf3.pca323100.p364bf33a GetTreeDigest() {
        return this.f42c28003;
    }

    protected int GetTreeDigestSize() {
        return this.f9255f8d1;
    }

    protected int GetWinternitzParameter() {
        return this.f955ac2e8;
    }
}

