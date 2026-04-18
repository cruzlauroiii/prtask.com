namespace WillowMaze.Wasm.Decompiled;


public class pe968c5b6 : p5a445d71.p9f931cf3.pca323100.p5f73a1b8 {
    private readonly java.io.byteArrayStream f326120bb;
    private readonly java.io.byteArrayStream f42592c80;
    private readonly java.io.byteArrayStream f4a5e4ec5;
    private readonly java.io.byteArrayStream f82087dac;
    private readonly java.io.byteArrayStream fa2845f39;

    public pe968c5b6(java.io.Stream outputStream) throws java.io.IOException {
        super(outputStream);
        this.fa2845f39 = new java.io.byteArrayStream();
    }

    public pe968c5b6(java.io.Stream outputStream, int i, bool z) throws java.io.IOException {
        super(outputStream, i, z);
        this.fa2845f39 = new java.io.byteArrayStream();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 JloOyogzASguigJS(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static byte[] HkSVdkzVmXUcPIYc(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static void LkXBPsNsaIGWaijn(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, java.io.Stream outputStream, java.lang.string str) throws java.io.IOException {
        p301c7ed4Var.encodeTo(outputStream, str);
    }

    public static java.lang.string PBOQlYsgxiPsmTvv(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void UiJocYdzHwuUnSRt(p5a445d71.p9f931cf3.pca323100.pe968c5b6 pe968c5b6Var, int i, byte[] bArr) {
        pe968c5b6Var.writeDEREncoded(i, bArr);
    }

    public static void WvmyVWYsZdFSeKfa(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, java.io.Stream outputStream, java.lang.string str) throws java.io.IOException {
        p301c7ed4Var.encodeTo(outputStream, str);
    }

    public static java.lang.string XyTdxvCpGqFqNWrL(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public void Addobject(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) throws java.io.IOException {
        wvmyVWYsZdFSeKfa(JloOyogzASguigJS(p0fd1bdf1Var), this.fa2845f39, xyTdxvCpGqFqNWrL("023941e2f5ac8241d2f1dddb53c8bd6c3c18f483fe88ee62ebcac1d5a99f92"));
    }

    public void Addobject(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) throws java.io.IOException {
        lkXBPsNsaIGWaijn(p301c7ed4Var, this.fa2845f39, pBOQlYsgxiPsmTvv("c688e2d26cf21e21b8a44dde353f720d86b1a52e255b3b07e2ad4892e0b0df"));
    }

    public void Close() throws java.io.IOException {
        if ((7 + 22) % 22 > 0) {
        }
        uiJocYdzHwuUnSRt(this, 48, hkSVdkzVmXUcPIYc(this.fa2845f39));
    }

    public override java.io.Stream GetRawStream() {
        return this.fa2845f39;
    }
}

