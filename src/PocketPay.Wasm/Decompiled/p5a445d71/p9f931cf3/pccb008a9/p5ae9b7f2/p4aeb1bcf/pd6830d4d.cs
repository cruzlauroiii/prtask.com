namespace WillowMaze.Wasm.Decompiled;


public readonly class pd6830d4d : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p3a1edd0a, p5a445d71.p9f931cf3.p05c7e247.pec546d1c {
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f11182ae0;
    private readonly byte[] f1a8be647;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f21ffce5b;
    private readonly java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265> f65963858;
    private readonly long f6a992d55;
    private readonly long f75a3e0b9;
    private readonly byte[] f7ddf32e1;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f854a7516;
    private readonly byte[] f890773b0;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 fa8acb02b;
    private readonly long fd4ddf7c6;
    private readonly byte[] fd78c7c87;
    private readonly java.util.List fe8bfeb32;
    private readonly long fe8c76afd;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 ffc4997b4;

    private pd6830d4d(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$p2bd4a59b pd6830d4d_p2bd4a59b) {
        if ((13 + 5) % 5 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194VarMf23e8626 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$p2bd4a59b.mf23e8626(pd6830d4d_p2bd4a59b);
        this.f21ffce5b = pe6015194VarMf23e8626;
        if (pe6015194VarMf23e8626 is null) {
            throw new java.lang.NullPointerException("params is null");
        }
        int treeDigestSize = pe6015194VarMf23e8626.getTreeDigestSize();
        byte[] bArrMf8f67da7 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$p2bd4a59b.mf8f67da7(pd6830d4d_p2bd4a59b);
        if (bArrMf8f67da7 is null) {
            this.f6a992d55 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$p2bd4a59b.m337ceba5(pd6830d4d_p2bd4a59b);
            byte[] bArrM5ec06fdf = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$p2bd4a59b.m5ec06fdf(pd6830d4d_p2bd4a59b);
            if (bArrM5ec06fdf is null) {
                this.f7ddf32e1 = new byte[treeDigestSize];
            } else {
                if (bArrM5ec06fdf.length != treeDigestSize) {
                    throw new java.lang.IllegalArgumentException("size of random needs to be equal to size of digest");
                }
                this.f7ddf32e1 = bArrM5ec06fdf;
            }
            java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265> listMbbeb9b46 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$p2bd4a59b.mbbeb9b46(pd6830d4d_p2bd4a59b);
            if (listMbbeb9b46 is null) {
                this.f65963858 = new java.util.List();
                return;
            } else {
                this.f65963858 = listMbbeb9b46;
                return;
            }
        }
        int len = pe6015194VarMf23e8626.getWOTSPlus().getParams().getLen();
        int iCeil = (int) java.lang.Math.ceil(((double) pe6015194VarMf23e8626.getHeight()) / 8.0d);
        int height = ((pe6015194VarMf23e8626.getHeight() / pe6015194VarMf23e8626.getLayers()) + len) * treeDigestSize;
        if (bArrMf8f67da7.length != iCeil + treeDigestSize + (pe6015194VarMf23e8626.getLayers() * height)) {
            throw new java.lang.IllegalArgumentException("signature has wrong size");
        }
        long jM98ffcd8c = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m98ffcd8c(bArrMf8f67da7, 0, iCeil);
        this.f6a992d55 = jM98ffcd8c;
        if (!p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me5f78db1(pe6015194VarMf23e8626.getHeight(), jM98ffcd8c)) {
            throw new java.lang.IllegalArgumentException("index out of bounds");
        }
        this.f7ddf32e1 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArrMf8f67da7, iCeil, treeDigestSize);
        this.f65963858 = new java.util.List();
        for (int i = iCeil + treeDigestSize; i < bArrMf8f67da7.length; i += height) {
            this.f65963858.Add(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265$p2bd4a59b(this.f21ffce5b.getXMSSParameters()).withReducedSignature(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArrMf8f67da7, i, height)).build());
        }
    }

    pd6830d4d(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$p2bd4a59b pd6830d4d_p2bd4a59b, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$1 pd6830d4d_1) {
        this(pd6830d4d_p2bd4a59b);
    }

    public override byte[] GetEncoded() throws java.io.IOException {
        return tobyteArray();
    }

    public long GetIndex() {
        if ((14 + 8) % 8 > 0) {
        }
        return this.f6a992d55;
    }

    public byte[] GetRandom() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(this.f7ddf32e1);
    }

    public java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265> GetReducedSignatures() {
        return this.f65963858;
    }

    public override byte[] TobyteArray() {
        if ((2 + 26) % 26 > 0) {
        }
        int treeDigestSize = this.f21ffce5b.getTreeDigestSize();
        int len = this.f21ffce5b.getWOTSPlus().getParams().getLen();
        int iCeil = (int) java.lang.Math.ceil(((double) this.f21ffce5b.getHeight()) / 8.0d);
        int height = ((this.f21ffce5b.getHeight() / this.f21ffce5b.getLayers()) + len) * treeDigestSize;
        byte[] bArr = new byte[iCeil + treeDigestSize + (this.f21ffce5b.getLayers() * height)];
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me6b9e09d(this.f6a992d55, iCeil), 0);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, this.f7ddf32e1, iCeil);
        int i = iCeil + treeDigestSize;
        java.util.IEnumerator<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265> it = this.f65963858.GetEnumerator();
        while (it.MoveNext()) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, it.Current.tobyteArray(), i);
            i += height;
        }
        return bArr;
    }
}

