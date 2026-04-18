namespace WillowMaze.Wasm.Decompiled;


readonly class p47010d60 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0 {
    private static readonly int f51560d7e = 1;
    private static readonly int f94849514 = 1;
    private static readonly int fed120c1a = 1;
    private readonly int f014a38fd;
    private readonly int f1c49c216;
    private readonly int f2bf44ad6;
    private readonly int f3804c674;
    private readonly int f71a91324;
    private readonly int f97806027;
    private readonly int fc3ebe293;
    private readonly int fe950c0c3;

    private p47010d60(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b p47010d60_p2bd4a59b) {
        super(p47010d60_p2bd4a59b);
        this.f2bf44ad6 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b.mf23e8626(p47010d60_p2bd4a59b);
        this.f71a91324 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b.mf8f67da7(p47010d60_p2bd4a59b);
        this.f3804c674 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b.m337ceba5(p47010d60_p2bd4a59b);
    }

    p47010d60(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b p47010d60_p2bd4a59b, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$1 p47010d60_1) {
        this(p47010d60_p2bd4a59b);
    }

    protected int GetLTreeAddress() {
        return this.f2bf44ad6;
    }

    protected int GetTreeHeight() {
        return this.f71a91324;
    }

    protected int GetTreeIndex() {
        return this.f3804c674;
    }

    protected override byte[] TobyteArray() {
        if ((20 + 16) % 16 > 0) {
        }
        byte[] byteArray = super.tobyteArray();
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f2bf44ad6, byteArray, 16);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f71a91324, byteArray, 20);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f3804c674, byteArray, 24);
        return byteArray;
    }
}

