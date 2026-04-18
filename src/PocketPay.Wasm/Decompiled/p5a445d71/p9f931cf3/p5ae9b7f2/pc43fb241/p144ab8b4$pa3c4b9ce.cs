namespace WillowMaze.Wasm.Decompiled;


class p144ab8b4$pa3c4b9ce : p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p940319a9 {
    private readonly byte[] f27b62e04;
    private readonly int f28a1e282;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f30ae0d36;
    private readonly byte[] f41723d65;
    private readonly byte[] f4f13d262;
    private readonly int f5b4bdad7;
    private readonly byte[] f5cb6797b;
    private readonly byte[] f65e787ff;
    private readonly byte[] f7d489666;
    private readonly int f8485f73e;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f93b4d271;
    private readonly int f9788c953;
    private readonly int fa694c87d;
    private readonly int fa975968c;
    private readonly byte[] fb388b7c4;
    private readonly byte[] fcb584e44;
    private readonly int fcca010c5;
    private readonly int ff0934e77;
    private readonly int ff6ddf8aa;

    public p144ab8b4$pa3c4b9ce(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, byte[] bArr, byte[] bArr2, int i2) {
        this.f93b4d271 = pd81e8b93Var;
        this.fa694c87d = i;
        this.fcb584e44 = bArr;
        this.fb388b7c4 = bArr2;
        this.f28a1e282 = i2;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.p52c18907 Get(p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar) {
        if ((23 + 3) % 3 > 0) {
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe59c307a(this.f93b4d271, this.fa694c87d, this.f28a1e282, p54466d0aVar, this.fb388b7c4, this.fcb584e44);
    }

    public override java.lang.string GetAlgorithm() {
        if ((16 + 31) % 31 > 0) {
        }
        return !(this.f93b4d271 is p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pc346e9ef) ? "CTR-DRBG-" + this.f93b4d271.getAlgorithmName() + this.fa694c87d : "CTR-DRBG-3KEY-TDES";
    }
}

