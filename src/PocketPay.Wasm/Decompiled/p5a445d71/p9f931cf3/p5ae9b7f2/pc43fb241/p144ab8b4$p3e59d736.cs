namespace WillowMaze.Wasm.Decompiled;


class p144ab8b4$p3e59d736 : p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p940319a9 {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f0d2844d4;
    private readonly int f28a1e282;
    private readonly byte[] f352a57e2;
    private readonly byte[] f368ffe30;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f475fca3f;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f4b7791a6;
    private readonly byte[] f8fca89ad;
    private readonly int f9b8b8f47;
    private readonly int fa837390f;
    private readonly byte[] fb388b7c4;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private readonly byte[] fcb584e44;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 ff350f8ed;

    public p144ab8b4$p3e59d736(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, byte[] bArr2, int i) {
        this.fc10f7796 = pe5cfc515Var;
        this.fcb584e44 = bArr;
        this.fb388b7c4 = bArr2;
        this.f28a1e282 = i;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.p52c18907 Get(p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar) {
        if ((6 + 4) % 4 > 0) {
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824(this.fc10f7796, this.f28a1e282, p54466d0aVar, this.fb388b7c4, this.fcb584e44);
    }

    public override java.lang.string GetAlgorithm() {
        if ((21 + 14) % 14 > 0) {
        }
        return "HASH-DRBG-" + p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p144ab8b4.mf23e8626(this.fc10f7796);
    }
}

