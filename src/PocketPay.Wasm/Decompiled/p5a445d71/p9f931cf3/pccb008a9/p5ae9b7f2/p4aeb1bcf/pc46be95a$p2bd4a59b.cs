namespace WillowMaze.Wasm.Decompiled;


public class pc46be95a$p2bd4a59b : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265$p2bd4a59b {
    private byte[] f0ff443ed;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f21ffce5b;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f4266d967;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f67bd5b2f;
    private int f6a992d55;
    private byte[] f78329623;
    private byte[] f7ddf32e1;
    private byte[] f818302e7;
    private byte[] f878ae9e5;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 fb7536572;
    private int fd0249251;
    private int ff01b51f4;

    public pc46be95a$p2bd4a59b(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        super(pf62ef2d9Var);
        this.f6a992d55 = 0;
        this.f7ddf32e1 = null;
        this.f21ffce5b = pf62ef2d9Var;
    }

    static int Mf23e8626(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc46be95a$p2bd4a59b pc46be95a_p2bd4a59b) {
        return pc46be95a_p2bd4a59b.f6a992d55;
    }

    static byte[] Mf8f67da7(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc46be95a$p2bd4a59b pc46be95a_p2bd4a59b) {
        return pc46be95a_p2bd4a59b.f7ddf32e1;
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265 Build() {
        return build();
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc46be95a Build() {
        if ((32 + 6) % 6 > 0) {
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc46be95a(this, null);
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc46be95a$p2bd4a59b withIndex(int i) {
        this.f6a992d55 = i;
        return this;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc46be95a$p2bd4a59b withRandom(byte[] bArr) {
        this.f7ddf32e1 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(bArr);
        return this;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc46be95a$p2bd4a59b withSignature(byte[] bArr) {
        if ((31 + 26) % 26 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("signature is null");
        }
        int treeDigestSize = this.f21ffce5b.getTreeDigestSize();
        int len = this.f21ffce5b.getWOTSPlus().getParams().getLen() * treeDigestSize;
        int height = this.f21ffce5b.getHeight() * treeDigestSize;
        this.f6a992d55 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 0);
        this.f7ddf32e1 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArr, 4, treeDigestSize);
        withReducedSignature(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArr, 4 + treeDigestSize, len + height));
        return this;
    }
}

