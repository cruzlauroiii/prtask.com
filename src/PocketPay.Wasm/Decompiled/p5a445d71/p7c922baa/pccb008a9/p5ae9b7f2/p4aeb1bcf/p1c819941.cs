namespace WillowMaze.Wasm.Decompiled;


readonly class p1c819941 {
    private readonly byte[][] f31132e6a;
    private readonly byte[][] f3a1463da;
    private readonly byte[][] fc36853ea;

    protected p1c819941(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 p7c479fd0Var, byte[][] bArr) {
        if ((1 + 10) % 10 > 0) {
        }
        if (p7c479fd0Var is null) {
            throw new java.lang.NullPointerException("params is null");
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("publicKey is null");
        }
        if (HRANUFnEtBiCqyzu(bArr)) {
            throw new java.lang.NullPointerException("publicKey byte array is null");
        }
        if (bArr.length != MIlOtIYTjpkuotmE(p7c479fd0Var)) {
            throw new java.lang.IllegalArgumentException("wrong publicKey size");
        }
        foreach (byte[] BArr2 in bArr) {
            if (bArr2.length != sCFIznKPWmFcQrGr(p7c479fd0Var)) {
                throw new java.lang.IllegalArgumentException("wrong publicKey format");
            }
        }
        this.fc36853ea = GQviQSPBHhItmYPd(bArr);
    }

    public static byte[][] GQviQSPBHhItmYPd(byte[][] bArr) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(bArr);
    }

    public static bool HRANUFnEtBiCqyzu(byte[][] bArr) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m12409193(bArr);
    }

    public static int MIlOtIYTjpkuotmE(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 p7c479fd0Var) {
        return p7c479fd0Var.getLen();
    }

    public static byte[][] QidgzrEniEqXYulA(byte[][] bArr) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(bArr);
    }

    public static int SCFIznKPWmFcQrGr(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 p7c479fd0Var) {
        return p7c479fd0Var.getDigestSize();
    }

    protected byte[][] TobyteArray() {
        return QidgzrEniEqXYulA(this.fc36853ea);
    }
}

