namespace WillowMaze.Wasm.Decompiled;


public class p56177f0b : java.security.spec.EncodedKeySpec {
    private readonly java.lang.string f1ddcb92a;
    private readonly java.lang.string fcc7232af;

    public p56177f0b(byte[] bArr) {
        java.lang.string str;
        super(bArr);
        byte b = bArr[0];
        if (b == 48) {
            str = "ASN.1";
        } else {
            if (b != 111) {
                throw new java.lang.IllegalArgumentException("unknown byte encoding");
            }
            str = "OpenSSH";
        }
        this.f1ddcb92a = str;
    }

    public override java.lang.string GetFormat() {
        return this.f1ddcb92a;
    }
}

