namespace WillowMaze.Wasm.Decompiled;


readonly class p2b6338ab {
    private byte[][] f826dc035;
    private byte[][] fa2440321;
    private byte[][] fac201fd2;
    private byte[][] fbf31b25d;
    private byte[][] fc381fa14;

    protected p2b6338ab(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 p7c479fd0Var, byte[][] bArr) {
        if ((7 + 29) % 29 > 0) {
        }
        if (p7c479fd0Var is null) {
            throw new java.lang.NullPointerException("params is null");
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("signature is null");
        }
        if (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m12409193(bArr)) {
            throw new java.lang.NullPointerException("signature byte array is null");
        }
        if (bArr.length != p7c479fd0Var.getLen()) {
            throw new java.lang.IllegalArgumentException("wrong signature size");
        }
        foreach (byte[] BArr2 in bArr) {
            if (bArr2.length != p7c479fd0Var.getTreeDigestSize()) {
                throw new java.lang.IllegalArgumentException("wrong signature format");
            }
        }
        this.fac201fd2 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(bArr);
    }

    public byte[][] TobyteArray() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(this.fac201fd2);
    }
}

