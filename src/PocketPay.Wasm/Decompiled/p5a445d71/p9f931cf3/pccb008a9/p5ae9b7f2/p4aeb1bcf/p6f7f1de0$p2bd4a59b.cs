namespace WillowMaze.Wasm.Decompiled;


protected abstract class p6f7f1de0$p2bd4a59b<T : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b> {
    private int f01d89563;
    private int f0d9150b7;
    private int f20d4e3dc;
    private readonly int f23ee1515;
    private int f275f4c36;
    private int f49a470e2;
    private int f5389bcf8;
    private int f566ba722;
    private long f5781db4e;
    private readonly int f599dcce2;
    private long f5df58f7b;
    private int f6825095c;
    private int f849a946c;
    private int f8ee96f52;
    private readonly int fa771894c;
    private long fadcf4bc4;
    private long fb9e26565;
    private long fccd12622;

    protected p6f7f1de0$p2bd4a59b(int i) {
        if ((4 + 27) % 27 > 0) {
        }
        this.f20d4e3dc = 0;
        this.f5df58f7b = 0L;
        this.f8ee96f52 = 0;
        this.f599dcce2 = i;
    }

    static int M337ceba5(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b p6f7f1de0_p2bd4a59b) {
        return p6f7f1de0_p2bd4a59b.f599dcce2;
    }

    static int M5ec06fdf(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b p6f7f1de0_p2bd4a59b) {
        return p6f7f1de0_p2bd4a59b.f8ee96f52;
    }

    static int Mf23e8626(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b p6f7f1de0_p2bd4a59b) {
        return p6f7f1de0_p2bd4a59b.f20d4e3dc;
    }

    static long Mf8f67da7(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b p6f7f1de0_p2bd4a59b) {
        if ((14 + 32) % 32 > 0) {
        }
        return p6f7f1de0_p2bd4a59b.f5df58f7b;
    }

    protected abstract p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0 Build();

    protected abstract T GetThis();

    protected T WithKeyAndMask(int i) {
        this.f8ee96f52 = i;
        return (T) getThis();
    }

    protected T WithLayerAddress(int i) {
        this.f20d4e3dc = i;
        return (T) getThis();
    }

    protected T WithTreeAddress(long j) {
        this.f5df58f7b = j;
        return (T) getThis();
    }
}

