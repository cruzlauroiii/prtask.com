namespace WillowMaze.Wasm.Decompiled;


public class p2af4446c : p5a445d71.p9f931cf3.pca323100.p29d19857 {
    public p2af4446c(byte b, int i) {
        super(b, i);
    }

    public p2af4446c(int i) {
        super(WzWgNbRGfInXRJrL(i), LEOfLhZeSaNOhtvV(i));
    }

    public p2af4446c(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) throws java.io.IOException {
        super(xLZczxARzMKjiUrw(fUBtBEueyvwzalFE(p0fd1bdf1Var), foDsTzrbkxdscYJr("2ac80c0e64a44ef5274b58a2c1d61fab562597a37178fd0d3327af1037207b")), 0);
    }

    public p2af4446c(byte[] bArr) {
        this(bArr, 0);
    }

    public p2af4446c(byte[] bArr, int i) {
        super(bArr, i);
    }

    p2af4446c(byte[] bArr, bool z) {
        super(bArr, z);
    }

    public static void CczCKuLIJcWhndIa(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncodingDL(z, i, bArr);
    }

    public static void KrhwvXqoCyuTGBOW(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, int i, byte b, byte[] bArr, int i2, int i3) throws java.io.IOException {
        p8bf0ff80Var.writeEncodingDL(z, i, b, bArr, i2, i3);
    }

    public static int LEOfLhZeSaNOhtvV(int i) {
        return getPadBits(i);
    }

    public static int TcnDEVJrenbDufwp(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p8bf0ff80.m3dc1a5b5(z, i);
    }

    public static byte[] WzWgNbRGfInXRJrL(int i) {
        return getbytes(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 FUBtBEueyvwzalFE(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static java.lang.string FoDsTzrbkxdscYJr(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    static p5a445d71.p9f931cf3.pca323100.p2af4446c M88d96f3a(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        if ((2 + 21) % 21 > 0) {
        }
        return new p5a445d71.p9f931cf3.pca323100.p2af4446c(nwiGHuDOlPrYFVOG(p11b04310Var), true);
    }

    static void M97a57645(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, byte b, byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((21 + 11) % 11 > 0) {
        }
        KrhwvXqoCyuTGBOW(p8bf0ff80Var, z, 3, b, bArr, i, i2);
    }

    static void M97a57645(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((25 + 9) % 9 > 0) {
        }
        mEPMzXWeRPEobQca(p8bf0ff80Var, z, 3, bArr, i, i2);
    }

    public static void MEPMzXWeRPEobQca(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, int i, byte[] bArr, int i2, int i3) throws java.io.IOException {
        p8bf0ff80Var.writeEncodingDL(z, i, bArr, i2, i3);
    }

    static int Me64db885(bool z, int i) {
        return TcnDEVJrenbDufwp(z, i);
    }

    public static byte[] NwiGHuDOlPrYFVOG(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static int SVkPSPokjfjLKPuF(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p8bf0ff80.m3dc1a5b5(z, i);
    }

    public static byte[] XLZczxARzMKjiUrw(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, java.lang.string str) {
        return p301c7ed4Var.getEncoded(str);
    }

    void encode(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        CczCKuLIJcWhndIa(p8bf0ff80Var, z, 3, this.f98bf7d8c);
    }

    bool encodeConstructed() {
        return false;
    }

    int encodedLength(bool z) {
        return sVkPSPokjfjLKPuF(z, this.f98bf7d8c.length);
    }

    p5a445d71.p9f931cf3.pca323100.p301c7ed4 toDLobject() {
        return this;
    }
}

