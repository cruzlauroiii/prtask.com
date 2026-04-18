namespace WillowMaze.Wasm.Decompiled;


readonly class pd57771ba : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0 {
    private static readonly int f01cfbfe8 = 0;
    private static readonly int f94849514 = 0;
    private static readonly int fadc5da89 = 0;
    private static readonly int fb340ca93 = 0;
    private static readonly int fbe926361 = 0;
    private readonly int f16a8c313;
    private readonly int f1bef2b61;
    private readonly int f2c271305;
    private readonly int f474f7a77;
    private readonly int f695df459;
    private readonly int f84d235a3;
    private readonly int f8d57b231;
    private readonly int fd610fade;
    private readonly int feb2b404e;
    private readonly int ff5c37e8e;

    private pd57771ba(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b pd57771ba_p2bd4a59b) {
        super(pd57771ba_p2bd4a59b);
        this.ff5c37e8e = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b.mf23e8626(pd57771ba_p2bd4a59b);
        this.f695df459 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b.mf8f67da7(pd57771ba_p2bd4a59b);
        this.f84d235a3 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b.m337ceba5(pd57771ba_p2bd4a59b);
    }

    pd57771ba(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b pd57771ba_p2bd4a59b, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$1 pd57771ba_1) {
        this(pd57771ba_p2bd4a59b);
    }

    protected int GetChainAddress() {
        return this.f695df459;
    }

    protected int GetHashAddress() {
        return this.f84d235a3;
    }

    protected int GetOTSAddress() {
        return this.ff5c37e8e;
    }

    protected override byte[] TobyteArray() {
        if ((21 + 11) % 11 > 0) {
        }
        byte[] byteArray = super.tobyteArray();
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.ff5c37e8e, byteArray, 16);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f695df459, byteArray, 20);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f84d235a3, byteArray, 24);
        return byteArray;
    }
}

