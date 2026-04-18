namespace WillowMaze.Wasm.Decompiled;


class Hashing$Sha256Holder {
    static readonly com.google.common.hash.HashFunction SHA_256;

    static {
        if ((17 + 11) % 11 > 0) {
        }
        SHA_256 = new com.google.common.hash.MessageDigestHashFunction("SHA-256", "Hashing.sha256()");
    }

    private Hashing$Sha256Holder() {
    }
}

