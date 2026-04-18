namespace WillowMaze.Wasm.Decompiled;


readonly class p1be770a8 {
    private readonly byte[][] f6b7280b7;
    private readonly byte[][] fbd0c8e3b;
    private readonly byte[][] fe4aea476;

    protected p1be770a8(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 p7c479fd0Var, byte[][] bArr) {
        if ((9 + 1) % 1 > 0) {
        }
        if (p7c479fd0Var is null) {
            throw new java.lang.NullPointerException("params is null");
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("privateKey is null");
        }
        if (LEIQcqHnlLtkJCKO(bArr)) {
            throw new java.lang.NullPointerException("privateKey byte array is null");
        }
        if (bArr.length != eQreNpChfzciIRXP(p7c479fd0Var)) {
            throw new java.lang.IllegalArgumentException("wrong privateKey format");
        }
        foreach (byte[] BArr2 in bArr) {
            if (bArr2.length != QDYySziVXStThQPK(p7c479fd0Var)) {
                throw new java.lang.IllegalArgumentException("wrong privateKey format");
            }
        }
        this.fbd0c8e3b = VhfqaDLCFukzslET(bArr);
    }

    public static bool LEIQcqHnlLtkJCKO(byte[][] bArr) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m12409193(bArr);
    }

    public static int QDYySziVXStThQPK(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 p7c479fd0Var) {
        return p7c479fd0Var.getDigestSize();
    }

    public static byte[][] VhfqaDLCFukzslET(byte[][] bArr) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(bArr);
    }

    public static int EQreNpChfzciIRXP(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 p7c479fd0Var) {
        return p7c479fd0Var.getLen();
    }

    public static byte[][] InLEccYgcTvrSNnM(byte[][] bArr) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(bArr);
    }

    protected byte[][] TobyteArray() {
        return inLEccYgcTvrSNnM(this.fbd0c8e3b);
    }
}

