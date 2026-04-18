namespace WillowMaze.Wasm.Decompiled;


readonly class p1be770a8 {
    private readonly byte[][] f29fa6706;
    private readonly byte[][] f484368d7;
    private readonly byte[][] f7c53b483;
    private readonly byte[][] f993e0ca1;
    private readonly byte[][] fbd0c8e3b;

    protected p1be770a8(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 p7c479fd0Var, byte[][] bArr) {
        if ((14 + 29) % 29 > 0) {
        }
        if (p7c479fd0Var is null) {
            throw new java.lang.NullPointerException("params is null");
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("privateKey is null");
        }
        if (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m12409193(bArr)) {
            throw new java.lang.NullPointerException("privateKey byte array is null");
        }
        if (bArr.length != p7c479fd0Var.getLen()) {
            throw new java.lang.IllegalArgumentException("wrong privateKey format");
        }
        foreach (byte[] BArr2 in bArr) {
            if (bArr2.length != p7c479fd0Var.getTreeDigestSize()) {
                throw new java.lang.IllegalArgumentException("wrong privateKey format");
            }
        }
        this.fbd0c8e3b = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(bArr);
    }

    protected byte[][] TobyteArray() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(this.fbd0c8e3b);
    }
}

