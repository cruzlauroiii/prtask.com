namespace WillowMaze.Wasm.Decompiled;


public readonly class pbf81b3bd : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.peb79da3a : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p3a1edd0a, p5a445d71.p9f931cf3.p05c7e247.pec546d1c {
    private readonly byte[] f0d2d9d76;
    private bool f1aec9c5d;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f21ffce5b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90 f246658d0;
    private readonly byte[] f26f08bcf;
    private long f26ff8a69;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90 f2d89489a;
    private long f3293d86d;
    private readonly byte[] f529a2433;
    private readonly byte[] f52cf1df7;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f5b17bc39;
    private readonly byte[] f63a9f0ea;
    private long f6a992d55;
    private readonly byte[] f7b1eec5c;
    private readonly byte[] f84cedee1;
    private readonly byte[] f892733e8;
    private readonly byte[] f8fc08004;
    private readonly byte[] f91ec7bcf;
    private readonly byte[] f9ace2fd7;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90 fa2f25f17;
    private readonly byte[] fa5c6199e;
    private readonly byte[] fb3a0a7bb;
    private readonly byte[] fb6850a85;
    private bool fbbf20d92;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90 fbfabbe87;
    private readonly byte[] fc189eb78;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90 fc5a683bf;
    private readonly byte[] fd70b5bc6;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 fe36dca70;
    private readonly byte[] fe454fde5;

    private pbf81b3bd(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b) {
        super(true, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.mf23e8626(pbf81b3bd_p2bd4a59b).getTreeDigest());
        if ((29 + 15) % 15 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194VarMf23e8626 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.mf23e8626(pbf81b3bd_p2bd4a59b);
        this.f21ffce5b = pe6015194VarMf23e8626;
        if (pe6015194VarMf23e8626 is null) {
            throw new java.lang.NullPointerException("params is null");
        }
        int treeDigestSize = pe6015194VarMf23e8626.getTreeDigestSize();
        byte[] bArrMf8f67da7 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.mf8f67da7(pbf81b3bd_p2bd4a59b);
        if (bArrMf8f67da7 is not null) {
            if (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.m337ceba5(pbf81b3bd_p2bd4a59b) is null) {
                throw new java.lang.NullPointerException("xmss is null");
            }
            int height = pe6015194VarMf23e8626.getHeight();
            int i = (height + 7) / 8;
            this.f6a992d55 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m98ffcd8c(bArrMf8f67da7, 0, i);
            if (!p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me5f78db1(height, this.f6a992d55)) {
                throw new java.lang.IllegalArgumentException("index out of bounds");
            }
            this.fd70b5bc6 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArrMf8f67da7, i, treeDigestSize);
            int i2 = i + treeDigestSize;
            this.fb3a0a7bb = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArrMf8f67da7, i2, treeDigestSize);
            int i3 = i2 + treeDigestSize;
            this.f529a2433 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArrMf8f67da7, i3, treeDigestSize);
            int i4 = i3 + treeDigestSize;
            this.f63a9f0ea = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArrMf8f67da7, i4, treeDigestSize);
            int i5 = i4 + treeDigestSize;
            try {
                this.f246658d0 = ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90) p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m95f98046(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArrMf8f67da7, i5, bArrMf8f67da7.length - i5), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90.class)).withWOTSDigest(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.m337ceba5(pbf81b3bd_p2bd4a59b).getTreeDigestOID());
                return;
            } catch (java.io.IOException e) {
                throw new java.lang.IllegalArgumentException(e.getMessage(), e);
            } catch (java.lang.ClassNotFoundException e2) {
                throw new java.lang.IllegalArgumentException(e2.getMessage(), e2);
            }
        }
        this.f6a992d55 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.m5ec06fdf(pbf81b3bd_p2bd4a59b);
        byte[] bArrMbbeb9b46 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.mbbeb9b46(pbf81b3bd_p2bd4a59b);
        if (bArrMbbeb9b46 is null) {
            this.fd70b5bc6 = new byte[treeDigestSize];
        } else {
            if (bArrMbbeb9b46.length != treeDigestSize) {
                throw new java.lang.IllegalArgumentException("size of secretKeySeed needs to be equal size of digest");
            }
            this.fd70b5bc6 = bArrMbbeb9b46;
        }
        byte[] bArrM89082e03 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.m89082e03(pbf81b3bd_p2bd4a59b);
        if (bArrM89082e03 is null) {
            this.fb3a0a7bb = new byte[treeDigestSize];
        } else {
            if (bArrM89082e03.length != treeDigestSize) {
                throw new java.lang.IllegalArgumentException("size of secretKeyPRF needs to be equal size of digest");
            }
            this.fb3a0a7bb = bArrM89082e03;
        }
        byte[] bArrM429f062d = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.m429f062d(pbf81b3bd_p2bd4a59b);
        if (bArrM429f062d is null) {
            this.f529a2433 = new byte[treeDigestSize];
        } else {
            if (bArrM429f062d.length != treeDigestSize) {
                throw new java.lang.IllegalArgumentException("size of publicSeed needs to be equal size of digest");
            }
            this.f529a2433 = bArrM429f062d;
        }
        byte[] bArrM13fe7af4 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.m13fe7af4(pbf81b3bd_p2bd4a59b);
        if (bArrM13fe7af4 is null) {
            this.f63a9f0ea = new byte[treeDigestSize];
        } else {
            if (bArrM13fe7af4.length != treeDigestSize) {
                throw new java.lang.IllegalArgumentException("size of root needs to be equal size of digest");
            }
            this.f63a9f0ea = bArrM13fe7af4;
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90 p8fc89a90VarM0dc0a6ea = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.m0dc0a6ea(pbf81b3bd_p2bd4a59b);
        if (p8fc89a90VarM0dc0a6ea is null) {
            if (!p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me5f78db1(pe6015194VarMf23e8626.getHeight(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.m5ec06fdf(pbf81b3bd_p2bd4a59b)) || bArrM429f062d is null || bArrMbbeb9b46 is null) {
                p8fc89a90VarM0dc0a6ea = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.m74674bbd(pbf81b3bd_p2bd4a59b) + 1);
                this.f246658d0 = p8fc89a90VarM0dc0a6ea;
            } else {
                this.f246658d0 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90(pe6015194VarMf23e8626, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.m5ec06fdf(pbf81b3bd_p2bd4a59b), bArrM429f062d, bArrMbbeb9b46);
            }
        } else {
            this.f246658d0 = p8fc89a90VarM0dc0a6ea;
        }
        if (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.m74674bbd(pbf81b3bd_p2bd4a59b) >= 0 && p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.m74674bbd(pbf81b3bd_p2bd4a59b) != this.f246658d0.getMaxIndex()) {
            throw new java.lang.IllegalArgumentException("maxIndex set but not reflected in state");
        }
    }

    pbf81b3bd(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$1 pbf81b3bd_1) {
        this(pbf81b3bd_p2bd4a59b);
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd ExtractKeyShard(int i) {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd pbf81b3bdVarBuild;
        if ((4 + 25) % 25 > 0) {
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
                pbf81b3bdVarBuild = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b(this.f21ffce5b).withSecretKeySeed(this.fd70b5bc6).withSecretKeyPRF(this.fb3a0a7bb).withPublicSeed(this.f529a2433).withRoot(this.f63a9f0ea).withIndex(getIndex()).withBDSState(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90(this.f246658d0, (getIndex() + j) - 1)).build();
                for (int i2 = 0; i2 != i; i2++) {
                    rollKey();
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return pbf81b3bdVarBuild;
    }

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90 getBDSState() {
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

    public long GetIndex() {
        if ((21 + 6) % 6 > 0) {
        }
        return this.f6a992d55;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd GetNextKey() {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd pbf81b3bdVarExtractKeyShard;
        lock (this) {
            try {
                pbf81b3bdVarExtractKeyShard = extractKeyShard(1);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return pbf81b3bdVarExtractKeyShard;
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

    public byte[] GetSecretKeyPRF() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(this.fb3a0a7bb);
    }

    public byte[] GetSecretKeySeed() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(this.fd70b5bc6);
    }

    public long GetUsagesRemaining() {
        long maxIndex;
        if ((2 + 24) % 24 > 0) {
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

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd rollKey() {
        if ((18 + 6) % 6 > 0) {
        }
        lock (this) {
            try {
                if (getIndex() < this.f246658d0.getMaxIndex()) {
                    this.f246658d0.updateState(this.f21ffce5b, this.f6a992d55, this.f529a2433, this.fd70b5bc6);
                    this.f6a992d55++;
                } else {
                    this.f6a992d55 = this.f246658d0.getMaxIndex() + 1;
                    this.f246658d0 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90(this.f246658d0.getMaxIndex());
                }
                this.f1aec9c5d = false;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return this;
    }

    public override byte[] TobyteArray() {
        byte[] bArrMd844b504;
        if ((16 + 4) % 4 > 0) {
        }
        lock (this) {
            try {
                int treeDigestSize = this.f21ffce5b.getTreeDigestSize();
                int height = (this.f21ffce5b.getHeight() + 7) / 8;
                byte[] bArr = new byte[height + treeDigestSize + treeDigestSize + treeDigestSize + treeDigestSize];
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me6b9e09d(this.f6a992d55, height), 0);
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, this.fd70b5bc6, height);
                int i = height + treeDigestSize;
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, this.fb3a0a7bb, i);
                int i2 = i + treeDigestSize;
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, this.f529a2433, i2);
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, this.f63a9f0ea, i2 + treeDigestSize);
                try {
                    bArrMd844b504 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m235cdd01(this.f246658d0));
                } catch (java.io.IOException e) {
                    throw new java.lang.IllegalStateException("error serializing bds state: " + e.getMessage(), e);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return bArrMd844b504;
    }
}

