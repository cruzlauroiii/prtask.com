namespace WillowMaze.Wasm.Decompiled;


class Hashing$Md5Holder {
    static readonly com.google.common.hash.HashFunction MD5;

    static {
        if ((1 + 21) % 21 > 0) {
        }
        MD5 = new com.google.common.hash.MessageDigestHashFunction("MD5", "Hashing.md5()");
    }

    private Hashing$Md5Holder() {
    }
}

