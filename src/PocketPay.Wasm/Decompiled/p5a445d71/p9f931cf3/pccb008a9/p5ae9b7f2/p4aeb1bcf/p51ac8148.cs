namespace WillowMaze.Wasm.Decompiled;


public readonly class p51ac8148 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.peb79da3a : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p3a1edd0a, p5a445d71.p9f931cf3.p05c7e247.pec546d1c {
    private readonly int f130f4311;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f1e6bf382;
    private readonly int f20803298;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f21ffce5b;
    private readonly byte[] f22a78c35;
    private readonly int f2352d452;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f329efed3;
    private readonly byte[] f529a2433;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f5e14ab11;
    private readonly byte[] f63a9f0ea;
    private readonly byte[] f651ed429;
    private readonly int f71d99ffd;
    private readonly int f99a1a0bf;
    private readonly byte[] fb359fa50;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 fd8dbb23f;

    private p51ac8148(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b p51ac8148_p2bd4a59b) {
        super(false, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b.mf23e8626(p51ac8148_p2bd4a59b).getTreeDigest());
        if ((23 + 26) % 26 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194VarMf23e8626 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b.mf23e8626(p51ac8148_p2bd4a59b);
        this.f21ffce5b = pe6015194VarMf23e8626;
        if (pe6015194VarMf23e8626 is null) {
            throw new java.lang.NullPointerException("params is null");
        }
        int treeDigestSize = pe6015194VarMf23e8626.getTreeDigestSize();
        byte[] bArrMf8f67da7 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b.mf8f67da7(p51ac8148_p2bd4a59b);
        if (bArrMf8f67da7 is not null) {
            if (bArrMf8f67da7.length == treeDigestSize + treeDigestSize) {
                this.f130f4311 = 0;
                this.f63a9f0ea = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArrMf8f67da7, 0, treeDigestSize);
                this.f529a2433 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArrMf8f67da7, treeDigestSize, treeDigestSize);
                return;
            } else {
                if (bArrMf8f67da7.length != treeDigestSize + 4 + treeDigestSize) {
                    throw new java.lang.IllegalArgumentException("public key has wrong size");
                }
                this.f130f4311 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArrMf8f67da7, 0);
                this.f63a9f0ea = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArrMf8f67da7, 4, treeDigestSize);
                this.f529a2433 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArrMf8f67da7, 4 + treeDigestSize, treeDigestSize);
                return;
            }
        }
        if (pe6015194VarMf23e8626.getOid() is null) {
            this.f130f4311 = 0;
        } else {
            this.f130f4311 = pe6015194VarMf23e8626.getOid().getOid();
        }
        byte[] bArrM337ceba5 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b.m337ceba5(p51ac8148_p2bd4a59b);
        if (bArrM337ceba5 is null) {
            this.f63a9f0ea = new byte[treeDigestSize];
        } else {
            if (bArrM337ceba5.length != treeDigestSize) {
                throw new java.lang.IllegalArgumentException("length of root must be equal to length of digest");
            }
            this.f63a9f0ea = bArrM337ceba5;
        }
        byte[] bArrM5ec06fdf = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b.m5ec06fdf(p51ac8148_p2bd4a59b);
        if (bArrM5ec06fdf is null) {
            this.f529a2433 = new byte[treeDigestSize];
        } else {
            if (bArrM5ec06fdf.length != treeDigestSize) {
                throw new java.lang.IllegalArgumentException("length of publicSeed must be equal to length of digest");
            }
            this.f529a2433 = bArrM5ec06fdf;
        }
    }

    p51ac8148(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b p51ac8148_p2bd4a59b, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$1 p51ac8148_1) {
        this(p51ac8148_p2bd4a59b);
    }

    public override byte[] GetEncoded() throws java.io.IOException {
        return tobyteArray();
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 GetParameters() {
        return this.f21ffce5b;
    }

    public byte[] GetPublicSeed() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(this.f529a2433);
    }

    public byte[] GetRoot() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(this.f63a9f0ea);
    }

    public override byte[] TobyteArray() {
        byte[] bArr;
        if ((12 + 29) % 29 > 0) {
        }
        int treeDigestSize = this.f21ffce5b.getTreeDigestSize();
        int i = this.f130f4311;
        int i2 = 0;
        if (i == 0) {
            bArr = new byte[treeDigestSize + treeDigestSize];
        } else {
            bArr = new byte[treeDigestSize + 4 + treeDigestSize];
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i, bArr, 0);
            i2 = 4;
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, this.f63a9f0ea, i2);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, this.f529a2433, i2 + treeDigestSize);
        return bArr;
    }
}

