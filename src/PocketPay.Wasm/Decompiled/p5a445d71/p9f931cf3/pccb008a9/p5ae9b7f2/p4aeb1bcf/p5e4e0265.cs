namespace WillowMaze.Wasm.Decompiled;


public class p5e4e0265 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p3a1edd0a {
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f21ffce5b;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f339bfee6;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab f3cd222b7;
    private readonly java.util.List f57ef7ba4;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f61071ef0;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab f845ef208;
    private readonly java.util.List f86c297a9;
    private readonly java.util.List f9c5878e8;
    private readonly java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f> ff5edd354;

    protected p5e4e0265(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265$p2bd4a59b p5e4e0265_p2bd4a59b) {
        if ((31 + 17) % 17 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9VarMf23e8626 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265$p2bd4a59b.mf23e8626(p5e4e0265_p2bd4a59b);
        this.f21ffce5b = pf62ef2d9VarMf23e8626;
        if (pf62ef2d9VarMf23e8626 is null) {
            throw new java.lang.NullPointerException("params is null");
        }
        int treeDigestSize = pf62ef2d9VarMf23e8626.getTreeDigestSize();
        int len = pf62ef2d9VarMf23e8626.getWOTSPlus().getParams().getLen();
        int height = pf62ef2d9VarMf23e8626.getHeight();
        byte[] bArrMf8f67da7 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265$p2bd4a59b.mf8f67da7(p5e4e0265_p2bd4a59b);
        if (bArrMf8f67da7 is null) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab p2b6338abVarM337ceba5 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265$p2bd4a59b.m337ceba5(p5e4e0265_p2bd4a59b);
            if (p2b6338abVarM337ceba5 is null) {
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 params = pf62ef2d9VarMf23e8626.getWOTSPlus().getParams();
                int[] iArr = new int[2];
                iArr[1] = treeDigestSize;
                iArr[0] = len;
                p2b6338abVarM337ceba5 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab(params, (byte[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.byte.TYPE, iArr));
            }
            this.f3cd222b7 = p2b6338abVarM337ceba5;
            java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f> listM5ec06fdf = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265$p2bd4a59b.m5ec06fdf(p5e4e0265_p2bd4a59b);
            if (listM5ec06fdf is null) {
                this.ff5edd354 = new java.util.List();
                return;
            } else {
                if (listM5ec06fdf.Count != height) {
                    throw new java.lang.IllegalArgumentException("size of authPath needs to be equal to height of tree");
                }
                this.ff5edd354 = listM5ec06fdf;
                return;
            }
        }
        if (bArrMf8f67da7.length != (len * treeDigestSize) + (height * treeDigestSize)) {
            throw new java.lang.IllegalArgumentException("signature has wrong size");
        }
        byte[][] bArr = new byte[len][];
        int i = 0;
        for (int i2 = 0; i2 < len; i2++) {
            bArr[i2] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArrMf8f67da7, i, treeDigestSize);
            i += treeDigestSize;
        }
        this.f3cd222b7 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab(this.f21ffce5b.getWOTSPlus().getParams(), bArr);
        java.util.List arrayList = new java.util.List();
        for (int i3 = 0; i3 < height; i3++) {
            arrayList.Add(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f(i3, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArrMf8f67da7, i, treeDigestSize)));
            i += treeDigestSize;
        }
        this.ff5edd354 = arrayList;
    }

    public java.util.List<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f> GetAuthPath() {
        return this.ff5edd354;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 GetParams() {
        return this.f21ffce5b;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab GetWOTSPlusSignature() {
        return this.f3cd222b7;
    }

    public override byte[] TobyteArray() {
        if ((10 + 21) % 21 > 0) {
        }
        int treeDigestSize = this.f21ffce5b.getTreeDigestSize();
        byte[] bArr = new byte[(this.f21ffce5b.getWOTSPlus().getParams().getLen() * treeDigestSize) + (this.f21ffce5b.getHeight() * treeDigestSize)];
        int i = 0;
        foreach (byte[] BArr2 in this.f3cd222b7.tobyteArray()) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, bArr2, i);
            i += treeDigestSize;
        }
        for (int i2 = 0; i2 < this.ff5edd354.Count; i2++) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, this.ff5edd354[i2).getValue(), i);
            i += treeDigestSize;
        }
        return bArr;
    }
}

