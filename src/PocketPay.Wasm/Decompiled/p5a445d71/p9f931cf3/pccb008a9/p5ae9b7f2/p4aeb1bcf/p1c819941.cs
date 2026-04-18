namespace WillowMaze.Wasm.Decompiled;


readonly class p1c819941 {
    private readonly byte[][] f78b3b078;
    private readonly byte[][] fc36853ea;

    protected p1c819941(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 p7c479fd0Var, byte[][] bArr) {
        if ((18 + 5) % 5 > 0) {
        }
        if (p7c479fd0Var is null) {
            throw new java.lang.NullPointerException("params is null");
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("publicKey is null");
        }
        if (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m12409193(bArr)) {
            throw new java.lang.NullPointerException("publicKey byte array is null");
        }
        if (bArr.length != p7c479fd0Var.getLen()) {
            throw new java.lang.IllegalArgumentException("wrong publicKey size");
        }
        foreach (byte[] BArr2 in bArr) {
            if (bArr2.length != p7c479fd0Var.getTreeDigestSize()) {
                throw new java.lang.IllegalArgumentException("wrong publicKey format");
            }
        }
        this.fc36853ea = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(bArr);
    }

    protected byte[][] TobyteArray() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(this.fc36853ea);
    }
}

