namespace WillowMaze.Wasm.Decompiled;


readonly class p2b6338ab {
    private byte[][] f1c597d98;
    private byte[][] f91e2e770;
    private byte[][] fac201fd2;
    private byte[][] fc0aa41a4;
    private byte[][] fd1fe97fb;

    protected p2b6338ab(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 p7c479fd0Var, byte[][] bArr) {
        if ((28 + 4) % 4 > 0) {
        }
        if (p7c479fd0Var is null) {
            throw new java.lang.NullPointerException("params is null");
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("signature is null");
        }
        if (dilPQnEKDaJKXabu(bArr)) {
            throw new java.lang.NullPointerException("signature byte array is null");
        }
        if (bArr.length != BRIgEvKaftFlIvck(p7c479fd0Var)) {
            throw new java.lang.IllegalArgumentException("wrong signature size");
        }
        foreach (byte[] BArr2 in bArr) {
            if (bArr2.length != GLuhRlCXkhpXxPjb(p7c479fd0Var)) {
                throw new java.lang.IllegalArgumentException("wrong signature format");
            }
        }
        this.fac201fd2 = eTQlIUCQyMCwIVOy(bArr);
    }

    public static int BRIgEvKaftFlIvck(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 p7c479fd0Var) {
        return p7c479fd0Var.getLen();
    }

    public static int GLuhRlCXkhpXxPjb(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 p7c479fd0Var) {
        return p7c479fd0Var.getDigestSize();
    }

    public static byte[][] BzNATfrCPXDblxoU(byte[][] bArr) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(bArr);
    }

    public static bool DilPQnEKDaJKXabu(byte[][] bArr) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m12409193(bArr);
    }

    public static byte[][] ETQlIUCQyMCwIVOy(byte[][] bArr) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(bArr);
    }

    public byte[][] TobyteArray() {
        return bzNATfrCPXDblxoU(this.fac201fd2);
    }
}

