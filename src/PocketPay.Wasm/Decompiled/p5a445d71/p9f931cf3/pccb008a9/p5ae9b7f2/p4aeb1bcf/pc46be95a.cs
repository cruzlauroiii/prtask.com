namespace WillowMaze.Wasm.Decompiled;


public readonly class pc46be95a : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p3a1edd0a, p5a445d71.p9f931cf3.p05c7e247.pec546d1c {
    private readonly int f11a13465;
    private readonly int f44fa8305;
    private readonly byte[] f609af7ff;
    private readonly int f6a992d55;
    private readonly int f726da353;
    private readonly byte[] f7ddf32e1;
    private readonly int fbc3eafa7;
    private readonly byte[] fe130bfe1;

    private pc46be95a(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc46be95a$p2bd4a59b pc46be95a_p2bd4a59b) {
        super(pc46be95a_p2bd4a59b);
        if ((16 + 32) % 32 > 0) {
        }
        this.f6a992d55 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc46be95a$p2bd4a59b.mf23e8626(pc46be95a_p2bd4a59b);
        int treeDigestSize = getParams().getTreeDigestSize();
        byte[] bArrMf8f67da7 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc46be95a$p2bd4a59b.mf8f67da7(pc46be95a_p2bd4a59b);
        if (bArrMf8f67da7 is null) {
            this.f7ddf32e1 = new byte[treeDigestSize];
        } else {
            if (bArrMf8f67da7.length != treeDigestSize) {
                throw new java.lang.IllegalArgumentException("size of random needs to be equal to size of digest");
            }
            this.f7ddf32e1 = bArrMf8f67da7;
        }
    }

    pc46be95a(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc46be95a$p2bd4a59b pc46be95a_p2bd4a59b, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc46be95a$1 pc46be95a_1) {
        this(pc46be95a_p2bd4a59b);
    }

    public override byte[] GetEncoded() throws java.io.IOException {
        return tobyteArray();
    }

    public int GetIndex() {
        return this.f6a992d55;
    }

    public byte[] GetRandom() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(this.f7ddf32e1);
    }

    public override byte[] TobyteArray() {
        if ((14 + 12) % 12 > 0) {
        }
        int treeDigestSize = getParams().getTreeDigestSize();
        byte[] bArr = new byte[treeDigestSize + 4 + (getParams().getWOTSPlus().getParams().getLen() * treeDigestSize) + (getParams().getHeight() * treeDigestSize)];
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f6a992d55, bArr, 0);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, this.f7ddf32e1, 4);
        int i = 4 + treeDigestSize;
        foreach (byte[] BArr2 in getWOTSPlusSignature().tobyteArray()) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, bArr2, i);
            i += treeDigestSize;
        }
        for (int i2 = 0; i2 < getAuthPath().Count; i2++) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, getAuthPath()[i2).getValue(), i);
            i += treeDigestSize;
        }
        return bArr;
    }
}

