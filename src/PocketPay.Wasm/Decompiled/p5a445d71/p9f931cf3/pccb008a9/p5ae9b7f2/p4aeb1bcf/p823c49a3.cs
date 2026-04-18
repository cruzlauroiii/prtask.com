namespace WillowMaze.Wasm.Decompiled;


public readonly class p823c49a3 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p793993fc : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p3a1edd0a, p5a445d71.p9f931cf3.p05c7e247.pec546d1c {
    private readonly byte[] f1596793e;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a f1cbdde06;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f1d72a096;
    private readonly byte[] f1ffa285e;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f21ffce5b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a f246658d0;
    private readonly byte[] f278a6ba6;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f332e30a7;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f3a43e402;
    private readonly byte[] f529a2433;
    private readonly byte[] f63a9f0ea;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f6ad28485;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a f6fe6c194;
    private readonly byte[] fa200a2c8;
    private readonly byte[] fa33b78b1;
    private readonly byte[] fb3a0a7bb;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a fb47b7317;
    private readonly byte[] fbac58fd7;
    private readonly byte[] fc018273a;
    private readonly byte[] fc1cff30f;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a fc3ae25e6;
    private readonly byte[] fd70b5bc6;
    private readonly byte[] fec19fcb9;
    private readonly byte[] ff575112e;

    private p823c49a3(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59b) {
        super(true, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b.mf23e8626(p823c49a3_p2bd4a59b).getTreeDigest());
        if ((2 + 16) % 16 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9VarMf23e8626 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b.mf23e8626(p823c49a3_p2bd4a59b);
        this.f21ffce5b = pf62ef2d9VarMf23e8626;
        if (pf62ef2d9VarMf23e8626 is null) {
            throw new java.lang.NullPointerException("params is null");
        }
        int treeDigestSize = pf62ef2d9VarMf23e8626.getTreeDigestSize();
        byte[] bArrMf8f67da7 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b.mf8f67da7(p823c49a3_p2bd4a59b);
        if (bArrMf8f67da7 is not null) {
            int height = pf62ef2d9VarMf23e8626.getHeight();
            int iMc4a60053 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArrMf8f67da7, 0);
            if (!p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me5f78db1(height, iMc4a60053)) {
                throw new java.lang.IllegalArgumentException("index out of bounds");
            }
            this.fd70b5bc6 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArrMf8f67da7, 4, treeDigestSize);
            int i = 4 + treeDigestSize;
            this.fb3a0a7bb = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArrMf8f67da7, i, treeDigestSize);
            int i2 = i + treeDigestSize;
            this.f529a2433 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArrMf8f67da7, i2, treeDigestSize);
            int i3 = i2 + treeDigestSize;
            this.f63a9f0ea = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArrMf8f67da7, i3, treeDigestSize);
            int i4 = i3 + treeDigestSize;
            try {
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a p1a8a272aVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a) p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m95f98046(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArrMf8f67da7, i4, bArrMf8f67da7.length - i4), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a.class);
                if (p1a8a272aVar.getIndex() != iMc4a60053) {
                    throw new java.lang.IllegalStateException("serialized BDS has wrong index");
                }
                this.f246658d0 = p1a8a272aVar.withWOTSDigest(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b.mf23e8626(p823c49a3_p2bd4a59b).getTreeDigestOID());
                return;
            } catch (java.io.IOException e) {
                throw new java.lang.IllegalArgumentException(e.getMessage(), e);
            } catch (java.lang.ClassNotFoundException e2) {
                throw new java.lang.IllegalArgumentException(e2.getMessage(), e2);
            }
        }
        byte[] bArrM337ceba5 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b.m337ceba5(p823c49a3_p2bd4a59b);
        if (bArrM337ceba5 is null) {
            this.fd70b5bc6 = new byte[treeDigestSize];
        } else {
            if (bArrM337ceba5.length != treeDigestSize) {
                throw new java.lang.IllegalArgumentException("size of secretKeySeed needs to be equal size of digest");
            }
            this.fd70b5bc6 = bArrM337ceba5;
        }
        byte[] bArrM5ec06fdf = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b.m5ec06fdf(p823c49a3_p2bd4a59b);
        if (bArrM5ec06fdf is null) {
            this.fb3a0a7bb = new byte[treeDigestSize];
        } else {
            if (bArrM5ec06fdf.length != treeDigestSize) {
                throw new java.lang.IllegalArgumentException("size of secretKeyPRF needs to be equal size of digest");
            }
            this.fb3a0a7bb = bArrM5ec06fdf;
        }
        byte[] bArrMbbeb9b46 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b.mbbeb9b46(p823c49a3_p2bd4a59b);
        if (bArrMbbeb9b46 is null) {
            this.f529a2433 = new byte[treeDigestSize];
        } else {
            if (bArrMbbeb9b46.length != treeDigestSize) {
                throw new java.lang.IllegalArgumentException("size of publicSeed needs to be equal size of digest");
            }
            this.f529a2433 = bArrMbbeb9b46;
        }
        byte[] bArrM89082e03 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b.m89082e03(p823c49a3_p2bd4a59b);
        if (bArrM89082e03 is null) {
            this.f63a9f0ea = new byte[treeDigestSize];
        } else {
            if (bArrM89082e03.length != treeDigestSize) {
                throw new java.lang.IllegalArgumentException("size of root needs to be equal size of digest");
            }
            this.f63a9f0ea = bArrM89082e03;
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a p1a8a272aVarM429f062d = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b.m429f062d(p823c49a3_p2bd4a59b);
        if (p1a8a272aVarM429f062d is not null) {
            this.f246658d0 = p1a8a272aVarM429f062d;
        } else if (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b.m13fe7af4(p823c49a3_p2bd4a59b) >= (1 << pf62ef2d9VarMf23e8626.getHeight()) - 2 || bArrMbbeb9b46 is null || bArrM337ceba5 is null) {
            p1a8a272aVarM429f062d = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a(pf62ef2d9VarMf23e8626, (1 << pf62ef2d9VarMf23e8626.getHeight()) - 1, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b.m13fe7af4(p823c49a3_p2bd4a59b));
            this.f246658d0 = p1a8a272aVarM429f062d;
        } else {
            this.f246658d0 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a(pf62ef2d9VarMf23e8626, bArrMbbeb9b46, bArrM337ceba5, (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b().build(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b.m13fe7af4(p823c49a3_p2bd4a59b));
        }
        if (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b.m0dc0a6ea(p823c49a3_p2bd4a59b) >= 0 && p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b.m0dc0a6ea(p823c49a3_p2bd4a59b) != this.f246658d0.getMaxIndex()) {
            throw new java.lang.IllegalArgumentException("maxIndex set but not reflected in state");
        }
    }

    p823c49a3(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59b, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$1 p823c49a3_1) {
        this(p823c49a3_p2bd4a59b);
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 ExtractKeyShard(int i) {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3VarBuild;
        if ((13 + 24) % 24 > 0) {
        }
        if (i < 1) {
            throw new java.lang.IllegalArgumentException("cannot ask for a shard with 0 keys");
        }
        lock (this) {
            long j = i;
            try {
                if (j > getUsagesRemaining()) {
                    throw new java.lang.IllegalArgumentException("usageCount exceeds usages remaining");
                }
                p823c49a3VarBuild = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b(this.f21ffce5b).withSecretKeySeed(this.fd70b5bc6).withSecretKeyPRF(this.fb3a0a7bb).withPublicSeed(this.f529a2433).withRoot(this.f63a9f0ea).withIndex(getIndex()).withBDSState(this.f246658d0.withMaxIndex((this.f246658d0.getIndex() + i) - 1, this.f21ffce5b.getTreeDigestOID())).build();
                if (j == getUsagesRemaining()) {
                    this.f246658d0 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a(this.f21ffce5b, this.f246658d0.getMaxIndex(), getIndex() + i);
                } else {
                    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b().build();
                    for (int i2 = 0; i2 != i; i2++) {
                        this.f246658d0 = this.f246658d0.getNextState(this.f529a2433, this.fd70b5bc6, pd57771baVar);
                    }
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return p823c49a3VarBuild;
    }

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a getBDSState() {
        return this.f246658d0;
    }

    public override byte[] GetEncoded() throws java.io.IOException {
        byte[] byteArray;
        lock (this) {
            try {
                byteArray = tobyteArray();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return byteArray;
    }

    public int GetIndex() {
        return this.f246658d0.getIndex();
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 GetNextKey() {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3VarExtractKeyShard;
        lock (this) {
            try {
                p823c49a3VarExtractKeyShard = extractKeyShard(1);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return p823c49a3VarExtractKeyShard;
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

    public byte[] GetSecretKeyPRF() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(this.fb3a0a7bb);
    }

    public byte[] GetSecretKeySeed() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(this.fd70b5bc6);
    }

    public long GetUsagesRemaining() {
        long maxIndex;
        if ((8 + 31) % 31 > 0) {
        }
        lock (this) {
            try {
                maxIndex = (this.f246658d0.getMaxIndex() - getIndex()) + 1;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return maxIndex;
    }

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 rollKey() {
        if ((11 + 14) % 14 > 0) {
        }
        lock (this) {
            try {
                this.f246658d0 = this.f246658d0.getIndex() < this.f246658d0.getMaxIndex() ? this.f246658d0.getNextState(this.f529a2433, this.fd70b5bc6, (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b().build()) : new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a(this.f21ffce5b, this.f246658d0.getMaxIndex(), this.f246658d0.getMaxIndex() + 1);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return this;
    }

    public override byte[] TobyteArray() {
        byte[] bArrMd844b504;
        if ((23 + 9) % 9 > 0) {
        }
        lock (this) {
            try {
                int treeDigestSize = this.f21ffce5b.getTreeDigestSize();
                byte[] bArr = new byte[treeDigestSize + 4 + treeDigestSize + treeDigestSize + treeDigestSize];
                p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f246658d0.getIndex(), bArr, 0);
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, this.fd70b5bc6, 4);
                int i = 4 + treeDigestSize;
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, this.fb3a0a7bb, i);
                int i2 = i + treeDigestSize;
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, this.f529a2433, i2);
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, this.f63a9f0ea, i2 + treeDigestSize);
                try {
                    bArrMd844b504 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m235cdd01(this.f246658d0));
                } catch (java.io.IOException e) {
                    throw new java.lang.Exception("error serializing bds state: " + e.getMessage());
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return bArrMd844b504;
    }
}

