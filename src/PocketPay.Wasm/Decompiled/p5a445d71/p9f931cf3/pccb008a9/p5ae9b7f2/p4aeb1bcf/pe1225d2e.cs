namespace WillowMaze.Wasm.Decompiled;


public readonly class pe1225d2e : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p793993fc : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p3a1edd0a, p5a445d71.p9f931cf3.p05c7e247.pec546d1c {
    private readonly int f03fac769;
    private readonly int f130f4311;
    private readonly byte[] f1c058ba8;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f21ffce5b;
    private readonly int f368cd07f;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f3d22d07a;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f41b6440d;
    private readonly byte[] f529a2433;
    private readonly int f54310733;
    private readonly byte[] f63a9f0ea;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f823d4861;
    private readonly byte[] fd118cf9c;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 fe414286f;
    private readonly byte[] fee3bbd90;

    private pe1225d2e(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b pe1225d2e_p2bd4a59b) {
        super(false, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b.mf23e8626(pe1225d2e_p2bd4a59b).getTreeDigest());
        if ((22 + 26) % 26 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9VarMf23e8626 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b.mf23e8626(pe1225d2e_p2bd4a59b);
        this.f21ffce5b = pf62ef2d9VarMf23e8626;
        if (pf62ef2d9VarMf23e8626 is null) {
            throw new java.lang.NullPointerException("params is null");
        }
        int treeDigestSize = pf62ef2d9VarMf23e8626.getTreeDigestSize();
        byte[] bArrMf8f67da7 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b.mf8f67da7(pe1225d2e_p2bd4a59b);
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
        if (pf62ef2d9VarMf23e8626.getOid() is null) {
            this.f130f4311 = 0;
        } else {
            this.f130f4311 = pf62ef2d9VarMf23e8626.getOid().getOid();
        }
        byte[] bArrM337ceba5 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b.m337ceba5(pe1225d2e_p2bd4a59b);
        if (bArrM337ceba5 is null) {
            this.f63a9f0ea = new byte[treeDigestSize];
        } else {
            if (bArrM337ceba5.length != treeDigestSize) {
                throw new java.lang.IllegalArgumentException("length of root must be equal to length of digest");
            }
            this.f63a9f0ea = bArrM337ceba5;
        }
        byte[] bArrM5ec06fdf = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b.m5ec06fdf(pe1225d2e_p2bd4a59b);
        if (bArrM5ec06fdf is null) {
            this.f529a2433 = new byte[treeDigestSize];
        } else {
            if (bArrM5ec06fdf.length != treeDigestSize) {
                throw new java.lang.IllegalArgumentException("length of publicSeed must be equal to length of digest");
            }
            this.f529a2433 = bArrM5ec06fdf;
        }
    }

    pe1225d2e(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b pe1225d2e_p2bd4a59b, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$1 pe1225d2e_1) {
        this(pe1225d2e_p2bd4a59b);
    }

    public override byte[] GetEncoded() throws java.io.IOException {
        return tobyteArray();
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 GetParameters() {
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
        if ((6 + 19) % 19 > 0) {
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

