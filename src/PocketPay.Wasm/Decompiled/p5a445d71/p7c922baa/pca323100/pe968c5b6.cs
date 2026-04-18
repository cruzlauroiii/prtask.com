namespace WillowMaze.Wasm.Decompiled;


public class pe968c5b6 : p5a445d71.p7c922baa.pca323100.p5f73a1b8 {
    private readonly java.io.byteArrayStream f1ec60ab4;
    private readonly java.io.byteArrayStream fa2845f39;
    private readonly java.io.byteArrayStream fb8a798fc;

    public pe968c5b6(java.io.Stream outputStream) throws java.io.IOException {
        super(outputStream);
        this.fa2845f39 = new java.io.byteArrayStream();
    }

    public pe968c5b6(java.io.Stream outputStream, int i, bool z) throws java.io.IOException {
        super(outputStream, i, z);
        this.fa2845f39 = new java.io.byteArrayStream();
    }

    public static byte[] YggSZjAnJJrcmFJo(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static void NRuQjoaVQrGVbeJF(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var, p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        p301c7ed4Var.encode(p8bf0ff80Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 OyuqwakLDHFPrCgs(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static void TGnzKscHPnbQKIvM(p5a445d71.p7c922baa.pca323100.pe968c5b6 pe968c5b6Var, int i, byte[] bArr) {
        pe968c5b6Var.writeDEREncoded(i, bArr);
    }

    public void Addobject(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) throws java.io.IOException {
        nRuQjoaVQrGVbeJF(oyuqwakLDHFPrCgs(p0fd1bdf1Var), new p5a445d71.p7c922baa.pca323100.pc7a8f162(this.fa2845f39));
    }

    public void Close() throws java.io.IOException {
        if ((27 + 5) % 5 > 0) {
        }
        tGnzKscHPnbQKIvM(this, 48, YggSZjAnJJrcmFJo(this.fa2845f39));
    }

    public override java.io.Stream GetRawStream() {
        return this.fa2845f39;
    }
}

