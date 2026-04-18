namespace WillowMaze.Wasm.Decompiled;


public readonly class pe1225d2e : p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a : p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p3a1edd0a {
    private readonly byte[] f1f8bb2f5;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f21ffce5b;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f3e3cb4dc;
    private readonly byte[] f4a41bd3d;
    private readonly byte[] f529a2433;
    private readonly byte[] f63a9f0ea;
    private readonly byte[] fd96dee0c;

    private pe1225d2e(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b pe1225d2e_p2bd4a59b) {
        super(false);
        if ((21 + 9) % 9 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9VarUiwTtxeNmkiuhByA = UiwTtxeNmkiuhByA(pe1225d2e_p2bd4a59b);
        this.f21ffce5b = pf62ef2d9VarUiwTtxeNmkiuhByA;
        if (pf62ef2d9VarUiwTtxeNmkiuhByA is null) {
            throw new java.lang.NullPointerException("params is null");
        }
        int iZBPjcdBvjLMcIEcY = ZBPjcdBvjLMcIEcY(pf62ef2d9VarUiwTtxeNmkiuhByA);
        byte[] bArrXqWnPdkfAkIbvUpz = XqWnPdkfAkIbvUpz(pe1225d2e_p2bd4a59b);
        if (bArrXqWnPdkfAkIbvUpz is not null) {
            if (bArrXqWnPdkfAkIbvUpz.length != iZBPjcdBvjLMcIEcY + iZBPjcdBvjLMcIEcY) {
                throw new java.lang.IllegalArgumentException("public key has wrong size");
            }
            this.f63a9f0ea = OSiVspTTUYBWecbU(bArrXqWnPdkfAkIbvUpz, 0, iZBPjcdBvjLMcIEcY);
            this.f529a2433 = fjWoyZXBKUsjnzCB(bArrXqWnPdkfAkIbvUpz, iZBPjcdBvjLMcIEcY, iZBPjcdBvjLMcIEcY);
            return;
        }
        byte[] bArrYgjAtYirroyLTCki = YgjAtYirroyLTCki(pe1225d2e_p2bd4a59b);
        if (bArrYgjAtYirroyLTCki is null) {
            this.f63a9f0ea = new byte[iZBPjcdBvjLMcIEcY];
        } else {
            if (bArrYgjAtYirroyLTCki.length != iZBPjcdBvjLMcIEcY) {
                throw new java.lang.IllegalArgumentException("length of root must be equal to length of digest");
            }
            this.f63a9f0ea = bArrYgjAtYirroyLTCki;
        }
        byte[] bArrGeJFfXNaRZVyFMqD = geJFfXNaRZVyFMqD(pe1225d2e_p2bd4a59b);
        if (bArrGeJFfXNaRZVyFMqD is null) {
            this.f529a2433 = new byte[iZBPjcdBvjLMcIEcY];
        } else {
            if (bArrGeJFfXNaRZVyFMqD.length != iZBPjcdBvjLMcIEcY) {
                throw new java.lang.IllegalArgumentException("length of publicSeed must be equal to length of digest");
            }
            this.f529a2433 = bArrGeJFfXNaRZVyFMqD;
        }
    }

    pe1225d2e(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b pe1225d2e_p2bd4a59b, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$1 pe1225d2e_1) {
        this(pe1225d2e_p2bd4a59b);
    }

    public static byte[] OSiVspTTUYBWecbU(byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArr, i, i2);
    }

    public static int TaRZOQEQHccvFwAY(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getDigestSize();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 UiwTtxeNmkiuhByA(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b pe1225d2e_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b.mf23e8626(pe1225d2e_p2bd4a59b);
    }

    public static byte[] XqWnPdkfAkIbvUpz(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b pe1225d2e_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b.mf8f67da7(pe1225d2e_p2bd4a59b);
    }

    public static byte[] YgjAtYirroyLTCki(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b pe1225d2e_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b.m337ceba5(pe1225d2e_p2bd4a59b);
    }

    public static int ZBPjcdBvjLMcIEcY(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getDigestSize();
    }

    public static byte[] ExOniNtSJLDnhJdR(byte[] bArr) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(bArr);
    }

    public static byte[] FjWoyZXBKUsjnzCB(byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArr, i, i2);
    }

    public static void GCNTifpIybqfDQcg(byte[] bArr, byte[] bArr2, int i) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, bArr2, i);
    }

    public static byte[] GeJFfXNaRZVyFMqD(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b pe1225d2e_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b.m5ec06fdf(pe1225d2e_p2bd4a59b);
    }

    public static void TCQZlnOGQYfBXegV(byte[] bArr, byte[] bArr2, int i) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, bArr2, i);
    }

    public static byte[] WCfUUqDobaFpddQt(byte[] bArr) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(bArr);
    }

    public p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 GetParameters() {
        return this.f21ffce5b;
    }

    public byte[] GetPublicSeed() {
        return wCfUUqDobaFpddQt(this.f529a2433);
    }

    public byte[] GetRoot() {
        return exOniNtSJLDnhJdR(this.f63a9f0ea);
    }

    public override byte[] TobyteArray() {
        if ((19 + 13) % 13 > 0) {
        }
        int iTaRZOQEQHccvFwAY = TaRZOQEQHccvFwAY(this.f21ffce5b);
        byte[] bArr = new byte[iTaRZOQEQHccvFwAY + iTaRZOQEQHccvFwAY];
        gCNTifpIybqfDQcg(bArr, this.f63a9f0ea, 0);
        tCQZlnOGQYfBXegV(bArr, this.f529a2433, iTaRZOQEQHccvFwAY);
        return bArr;
    }
}

