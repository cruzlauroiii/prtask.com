namespace WillowMaze.Wasm.Decompiled;


public class p6f0e511c : p5a445d71.p9f931cf3.pca323100.p11b04310 {
    public p6f0e511c(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) throws java.io.IOException {
        super(VhlLMllYJybwQcvz(ByNrfGhXjpxobYzQ(p0fd1bdf1Var), yAMQjBhHekBrylYO("2c792e35e9ea19faa747057914f3bd9fee3c746873d22d7cc463a7785a9e46")));
    }

    public p6f0e511c(byte[] bArr) {
        super(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 ByNrfGhXjpxobYzQ(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static void OOnxKvzVAOsrrgsx(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, int i, byte[] bArr, int i2, int i3) throws java.io.IOException {
        p8bf0ff80Var.writeEncodingDL(z, i, bArr, i2, i3);
    }

    public static void TOjegLpdyEPGaVKj(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncodingDL(z, i, bArr);
    }

    public static byte[] VhlLMllYJybwQcvz(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, java.lang.string str) {
        return p301c7ed4Var.getEncoded(str);
    }

    static void M97a57645(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((21 + 16) % 16 > 0) {
        }
        OOnxKvzVAOsrrgsx(p8bf0ff80Var, z, 4, bArr, i, i2);
    }

    static int Me64db885(bool z, int i) {
        return neZSoxqOAvfKpyci(z, i);
    }

    public static int NeZSoxqOAvfKpyci(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p8bf0ff80.m3dc1a5b5(z, i);
    }

    public static int OSQXduFRqNiiFobV(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p8bf0ff80.m3dc1a5b5(z, i);
    }

    public static java.lang.string YAMQjBhHekBrylYO(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    void encode(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        TOjegLpdyEPGaVKj(p8bf0ff80Var, z, 4, this.fb45cffe0);
    }

    bool encodeConstructed() {
        return false;
    }

    int encodedLength(bool z) {
        return oSQXduFRqNiiFobV(z, this.fb45cffe0.length);
    }

    p5a445d71.p9f931cf3.pca323100.p301c7ed4 toDERobject() {
        return this;
    }

    p5a445d71.p9f931cf3.pca323100.p301c7ed4 toDLobject() {
        return this;
    }
}

