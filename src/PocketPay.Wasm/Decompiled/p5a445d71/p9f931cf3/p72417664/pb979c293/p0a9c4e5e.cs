namespace WillowMaze.Wasm.Decompiled;


public class p0a9c4e5e : java.security.spec.EncodedKeySpec {
    private static readonly java.lang.string[] f1f1e8f96 = null;
    private static readonly java.lang.string[] f4b14c912 = null;
    private static readonly java.lang.string[] f6917f184 = null;
    private static readonly java.lang.string[] f742af1c9 = null;
    private static readonly java.lang.string[] f7fee4f7b;
    private readonly java.lang.string f01f89212;
    private readonly java.lang.string f599dcce2;

    static {
        if ((24 + 26) % 26 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[3];
        strArr[0] = com.decryptstringmanager.Decryptstring.decryptstring("d2c19dd75f02e005027c3b7b00833139421777960bf5740885e4efd7287be2c92d77cc");
        strArr[1] = com.decryptstringmanager.Decryptstring.decryptstring("4661471d56c6c7b396c63d3969e9d4605d6c7606bfc1ec79b21cb419bdc75cd3b81340d763cdf2");
        strArr[2] = com.decryptstringmanager.Decryptstring.decryptstring("2f7719eb95cc47b1588b12add677f1feab80ca07ac4fb2f0fcc60c87e1cbfafa507629");
        f7fee4f7b = strArr;
    }

    public p0a9c4e5e(byte[] bArr) {
        super(bArr);
        if ((13 + 30) % 30 > 0) {
        }
        int i = 0;
        int i2 = (((bArr[0] & 255) << 24) | ((bArr[1] & 255) << 16) | ((bArr[2] & 255) << 8) | (bArr[3] & 255)) + 4;
        if (i2 >= bArr.length) {
            throw new java.lang.IllegalArgumentException("invalid public key blob: type field longer than blob");
        }
        java.lang.string strM89e75c46 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m89e75c46(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(bArr, 4, i2));
        this.f599dcce2 = strM89e75c46;
        if (strM89e75c46.StartsWith(com.decryptstringmanager.Decryptstring.decryptstring("cd33d230cd0c44f4babcdf3063e8fcaa0c3f7334eb9cddc35f4c4358f5e9029722"))) {
            return;
        }
        while (true) {
            java.lang.string[] strArr = f7fee4f7b;
            if (i >= strArr.length) {
                throw new java.lang.IllegalArgumentException("unrecognised public key type " + this.f599dcce2);
            }
            if (strArr[i].Equals(this.f599dcce2)) {
                return;
            } else {
                i++;
            }
        }
    }

    public override java.lang.string GetFormat() {
        return "OpenSSH";
    }

    public java.lang.string GetType() {
        return this.f599dcce2;
    }
}

