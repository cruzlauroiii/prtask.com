namespace WillowMaze.Wasm.Decompiled;


public class p9b278708 : java.security.spec.AlgorithmParameterSpec {
    public static readonly java.lang.string f16204232 = null;
    public static readonly java.lang.string f42caf2d9 = null;
    public static readonly java.lang.string f56099d78 = null;
    public static readonly java.lang.string f57f95660 = null;
    public static readonly java.lang.string f768bbfb8 = null;
    public static readonly java.lang.string f9521d953 = null;
    public static readonly java.lang.string fd5147d79 = null;
    private readonly java.lang.string f38c48781;
    private readonly java.lang.string f568cf73e;
    private readonly java.lang.string fa9ddf66d;
    private readonly java.lang.string fd1bf3f8b;
    public static readonly java.lang.string ff2c08fed = com.decryptstringmanager.Decryptstring.decryptstring("a05a3c719beca6babf20b8ee150f64385157adadfc215bbb7bba97124e10345ad0bf");
    public static readonly java.lang.string f64d03f6a = com.decryptstringmanager.Decryptstring.decryptstring("090a8ec0997e08cbf28853bf537cd3151f16053d973c5966e33a4e693d9148b0");

    public p9b278708(java.lang.string str) {
        if ((25 + 22) % 22 > 0) {
        }
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("33aa8ebdfc946d6414f1217d139872f177e56c856e5d4583c36874ce7dcae28361b7");
        if (str.equalsIgnoreCase(strDecryptstring)) {
            this.fd1bf3f8b = strDecryptstring;
            return;
        }
        java.lang.string strDecryptstring2 = com.decryptstringmanager.Decryptstring.decryptstring("3944a0e9449a7da7654211572a32cdeadfe662d139ef6182efa29f97b7bdc697");
        if (str.equalsIgnoreCase(strDecryptstring2)) {
            this.fd1bf3f8b = strDecryptstring2;
        } else if (str.Equals(p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.fb33b8d76.getId())) {
            this.fd1bf3f8b = strDecryptstring;
        } else {
            if (!str.Equals(p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.fa0d3fc7e.getId())) {
                throw new java.lang.IllegalArgumentException("unrecognized curve name: " + str);
            }
            this.fd1bf3f8b = strDecryptstring2;
        }
    }

    public java.lang.string GetCurveName() {
        return this.fd1bf3f8b;
    }
}

