namespace WillowMaze.Wasm.Decompiled;


protected class p8e77ec20$p2bd4a59b : org.bouncycastle.pqc.crypto.xmss.XMSSAddress$Builder<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b> {
    private int f0c55e7c8;
    private int f3804c674;
    private int f56b2084a;
    private int f71a91324;
    private int f7c08101b;
    private int f91f33b01;
    private int fb7caf947;

    protected p8e77ec20$p2bd4a59b() {
        super(2);
        this.f71a91324 = 0;
        this.f3804c674 = 0;
    }

    static int Mf23e8626(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b) {
        return p8e77ec20_p2bd4a59b.f71a91324;
    }

    static int Mf8f67da7(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b) {
        return p8e77ec20_p2bd4a59b.f3804c674;
    }

    protected p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0 Build() {
        if ((24 + 32) % 32 > 0) {
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20(this, null);
    }

    protected p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b getThis() {
        return m3738getThis();
    }

    protected p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b m3738getThis() {
        return this;
    }

    protected p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b withTreeHeight(int i) {
        this.f71a91324 = i;
        return this;
    }

    protected p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b withTreeIndex(int i) {
        this.f3804c674 = i;
        return this;
    }
}

