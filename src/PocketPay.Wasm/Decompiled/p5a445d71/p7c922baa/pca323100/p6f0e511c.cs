namespace WillowMaze.Wasm.Decompiled;


public class p6f0e511c : p5a445d71.p7c922baa.pca323100.p11b04310 {
    public p6f0e511c(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) throws java.io.IOException {
        super(xPSXzMuTfEROgRId(OujDnjMKyDEQpxxZ(p0fd1bdf1Var), WrCxnQqUCYtsVhWr("2f8f40394ed15eb96a330a9f8153b94efeb64d49618f2d3143f0b62929f8bf")));
    }

    public p6f0e511c(byte[] bArr) {
        super(bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 OujDnjMKyDEQpxxZ(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static void SauuwosjZYlCByCD(p5a445d71.p7c922baa.pca323100.pc7a8f162 pc7a8f162Var, int i, byte[] bArr) {
        pc7a8f162Var.writeEncoded(i, bArr);
    }

    public static void UNwvWhtGCUANppNn(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncoded(i, bArr);
    }

    public static java.lang.string WrCxnQqUCYtsVhWr(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static int AOtaJNTFNRAmEEzJ(int i) {
        return p5a445d71.p7c922baa.pca323100.pd8bcfa1c.m9a4ee51a(i);
    }

    static void M97a57645(p5a445d71.p7c922baa.pca323100.pc7a8f162 pc7a8f162Var, byte[] bArr) throws java.io.IOException {
        SauuwosjZYlCByCD(pc7a8f162Var, 4, bArr);
    }

    public static byte[] XPSXzMuTfEROgRId(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var, java.lang.string str) {
        return p301c7ed4Var.getEncoded(str);
    }

    void encode(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        UNwvWhtGCUANppNn(p8bf0ff80Var, 4, this.fb45cffe0);
    }

    int encodedLength() {
        return aOtaJNTFNRAmEEzJ(this.fb45cffe0.length) + 1 + this.fb45cffe0.length;
    }

    bool isConstructed() {
        return false;
    }
}

