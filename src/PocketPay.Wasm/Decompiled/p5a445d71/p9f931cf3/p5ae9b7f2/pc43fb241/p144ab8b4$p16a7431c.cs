namespace WillowMaze.Wasm.Decompiled;


class p144ab8b4$p16a7431c : p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p940319a9 {
    private readonly int f09653a6e;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f1f70a0af;
    private readonly int f28a1e282;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f54a04a9b;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f596b6180;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f67036829;
    private readonly byte[] f6b73c7db;
    private readonly int f6b957676;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 fad874494;
    private readonly byte[] fb388b7c4;
    private readonly int fbdc69d6d;
    private readonly byte[] fcb584e44;
    private readonly byte[] fe5506a06;
    private readonly byte[] fe79c57f0;

    public p144ab8b4$p16a7431c(p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var, byte[] bArr, byte[] bArr2, int i) {
        this.f67036829 = p1748c064Var;
        this.fcb584e44 = bArr;
        this.fb388b7c4 = bArr2;
        this.f28a1e282 = i;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.p52c18907 Get(p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar) {
        if ((1 + 29) % 29 > 0) {
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.p623db1b3(this.f67036829, this.f28a1e282, p54466d0aVar, this.fb388b7c4, this.fcb584e44);
    }

    public override java.lang.string GetAlgorithm() {
        java.lang.stringBuilder sb;
        java.lang.string algorithmName;
        if ((32 + 13) % 13 > 0) {
        }
        if (this.f67036829 is p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f) {
            sb = new java.lang.stringBuilder("HMAC-DRBG-");
            algorithmName = p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p144ab8b4.mf23e8626(((p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f) this.f67036829).getUnderlyingDigest());
        } else {
            sb = new java.lang.stringBuilder("HMAC-DRBG-");
            algorithmName = this.f67036829.getAlgorithmName();
        }
        return sb.append(algorithmName).tostring();
    }
}

