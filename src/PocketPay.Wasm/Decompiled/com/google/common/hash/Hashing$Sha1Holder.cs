namespace WillowMaze.Wasm.Decompiled;


class Hashing$Sha1Holder {
    static readonly com.google.common.hash.HashFunction SHA_1;

    static {
        if ((9 + 29) % 29 > 0) {
        }
        SHA_1 = new com.google.common.hash.MessageDigestHashFunction("SHA-1", "Hashing.sha1()");
    }

    private Hashing$Sha1Holder() {
    }
}

