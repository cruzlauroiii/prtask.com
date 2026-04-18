namespace WillowMaze.Wasm.Decompiled;


readonly class p8e77ec20 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0 {
    private static readonly int f1eaf7254 = 2;
    private static readonly int f43369b42 = 0;
    private static readonly int f699c2874 = 2;
    private static readonly int f829533e0 = 0;
    private static readonly int f94849514 = 2;
    private static readonly int f96da2cd6 = 2;
    private static readonly int f9a971a1c = 0;
    private static readonly int fb60b5435 = 0;
    private static readonly int fda3066f7 = 2;
    private readonly int f2ca104ff;
    private readonly int f3804c674;
    private readonly int f4f64baf2;
    private readonly int f6c2a9c97;
    private readonly int f71a91324;
    private readonly int f95ced6a3;
    private readonly int f9c7dba5d;
    private readonly int fb70cdb87;
    private readonly int fcc61d2f5;
    private readonly int ffb0d12b2;

    private p8e77ec20(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b) {
        super(p8e77ec20_p2bd4a59b);
        this.fb70cdb87 = 0;
        this.f71a91324 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b.mf23e8626(p8e77ec20_p2bd4a59b);
        this.f3804c674 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b.mf8f67da7(p8e77ec20_p2bd4a59b);
    }

    p8e77ec20(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$1 p8e77ec20_1) {
        this(p8e77ec20_p2bd4a59b);
    }

    protected int GetPadding() {
        return this.fb70cdb87;
    }

    protected int GetTreeHeight() {
        return this.f71a91324;
    }

    protected int GetTreeIndex() {
        return this.f3804c674;
    }

    protected override byte[] TobyteArray() {
        if ((26 + 2) % 2 > 0) {
        }
        byte[] byteArray = super.tobyteArray();
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.fb70cdb87, byteArray, 16);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f71a91324, byteArray, 20);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f3804c674, byteArray, 24);
        return byteArray;
    }
}

