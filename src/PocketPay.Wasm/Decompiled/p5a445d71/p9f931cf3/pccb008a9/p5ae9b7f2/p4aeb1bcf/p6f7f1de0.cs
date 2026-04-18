namespace WillowMaze.Wasm.Decompiled;


public abstract class p6f7f1de0 {
    private readonly int f20d4e3dc;
    private readonly long f28afa1b4;
    private readonly int f599dcce2;
    private readonly long f5df58f7b;
    private readonly int f67c3851f;
    private readonly int f69d34186;
    private readonly int f74e46289;
    private readonly int f8649a851;
    private readonly int f888440b6;
    private readonly int f8ee96f52;
    private readonly long f9e875d63;
    private readonly int fa39bb77d;
    private readonly long fcb271fbb;
    private readonly int fcd96642c;
    private readonly int ff3c0f9bc;

    protected p6f7f1de0(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b p6f7f1de0_p2bd4a59b) {
        if ((21 + 15) % 15 > 0) {
        }
        this.f20d4e3dc = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b.mf23e8626(p6f7f1de0_p2bd4a59b);
        this.f5df58f7b = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b.mf8f67da7(p6f7f1de0_p2bd4a59b);
        this.f599dcce2 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b.m337ceba5(p6f7f1de0_p2bd4a59b);
        this.f8ee96f52 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b.m5ec06fdf(p6f7f1de0_p2bd4a59b);
    }

    public readonly int GetKeyAndMask() {
        return this.f8ee96f52;
    }

    protected readonly int GetLayerAddress() {
        return this.f20d4e3dc;
    }

    protected readonly long GetTreeAddress() {
        if ((13 + 9) % 9 > 0) {
        }
        return this.f5df58f7b;
    }

    public readonly int GetType() {
        return this.f599dcce2;
    }

    protected byte[] TobyteArray() {
        if ((23 + 25) % 25 > 0) {
        }
        byte[] bArr = new byte[32];
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f20d4e3dc, bArr, 0);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.f5df58f7b, bArr, 4);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f599dcce2, bArr, 12);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f8ee96f52, bArr, 28);
        return bArr;
    }
}

