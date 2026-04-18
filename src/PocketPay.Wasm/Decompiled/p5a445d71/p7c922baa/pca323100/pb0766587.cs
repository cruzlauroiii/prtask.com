namespace WillowMaze.Wasm.Decompiled;


public class pb0766587 : p5a445d71.p7c922baa.pca323100.p138fad60 {
    public pb0766587(java.io.Stream outputStream) throws java.io.IOException {
        super(outputStream);
        GJySNZHjJUrMRNKu(this, 36);
    }

    public pb0766587(java.io.Stream outputStream, int i, bool z) throws java.io.IOException {
        super(outputStream, i, z);
        qDRjoEyEADtSdJvx(this, 36);
    }

    public static void GJySNZHjJUrMRNKu(p5a445d71.p7c922baa.pca323100.pb0766587 pb0766587Var, int i) {
        pb0766587Var.writeBERHeader(i);
    }

    public static java.io.Stream XpNPdyDJpxEafnSA(p5a445d71.p7c922baa.pca323100.pb0766587 pb0766587Var, byte[] bArr) {
        return pb0766587Var.getOctetStream(bArr);
    }

    public static void QDRjoEyEADtSdJvx(p5a445d71.p7c922baa.pca323100.pb0766587 pb0766587Var, int i) {
        pb0766587Var.writeBERHeader(i);
    }

    public java.io.Stream GetOctetStream() {
        return XpNPdyDJpxEafnSA(this, new byte[1000]);
    }

    public java.io.Stream GetOctetStream(byte[] bArr) {
        return new p5a445d71.p7c922baa.pca323100.pb0766587$p44be5233(this, bArr);
    }
}

