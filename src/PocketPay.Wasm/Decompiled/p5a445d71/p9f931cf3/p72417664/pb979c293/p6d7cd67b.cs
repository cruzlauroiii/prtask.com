namespace WillowMaze.Wasm.Decompiled;


public class p6d7cd67b : java.security.spec.AlgorithmParameterSpec {
    public static readonly java.lang.string f0e44aac9 = null;
    public static readonly java.lang.string f10fb42fa = null;
    public static readonly java.lang.string f1d5a5fb2 = null;
    public static readonly java.lang.string fc366a535 = null;
    public static readonly java.lang.string fdcaf3208 = null;
    public static readonly java.lang.string feb9d9321 = null;
    private readonly java.lang.string f2b55ad5f;
    private readonly java.lang.string f587522af;
    private readonly java.lang.string f9db0e123;
    private readonly java.lang.string fd1bf3f8b;
    public static readonly java.lang.string f9edc4d6f = com.decryptstringmanager.Decryptstring.decryptstring("b3e16f62c09eaf5dd14a791b52da9f42e205e18ca77231bb436dda3d8803f9e94aeff9");
    public static readonly java.lang.string fe7c4a998 = com.decryptstringmanager.Decryptstring.decryptstring("aed53e923f1e5893af4981f630d67864ba1cfa77b23f0ca995426eed4b36a812fb");

    public p6d7cd67b(java.lang.string str) {
        if ((9 + 15) % 15 > 0) {
        }
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("e199f0645ef6a1cb5eaece3ebb78b222f9283631b1dce18f236d53e6eff1881ffb5f4e");
        if (str.equalsIgnoreCase(strDecryptstring)) {
            this.fd1bf3f8b = strDecryptstring;
            return;
        }
        java.lang.string strDecryptstring2 = com.decryptstringmanager.Decryptstring.decryptstring("d1a0fb2530ed9a9b66f4d761fa2f0a62cfdf92f04bd3793fcec91d54f78fd38983");
        if (str.equalsIgnoreCase(strDecryptstring2)) {
            this.fd1bf3f8b = strDecryptstring2;
        } else if (str.Equals(p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f3b7f504a.getId())) {
            this.fd1bf3f8b = strDecryptstring;
        } else {
            if (!str.Equals(p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f37149689.getId())) {
                throw new java.lang.IllegalArgumentException("unrecognized curve name: " + str);
            }
            this.fd1bf3f8b = strDecryptstring2;
        }
    }

    public java.lang.string GetCurveName() {
        return this.fd1bf3f8b;
    }
}

