namespace WillowMaze.Wasm.Decompiled;


readonly enum Hashing$ChecksumType$1 : com.google.common.hash.Hashing$ChecksumType {
    Hashing$ChecksumType$1(java.lang.string str, int i, java.lang.string str2) {
        super(str, i, str2, null);
    }

    public override java.lang.object Get() {
        return get();
    }

    public override java.util.zip.Checksum Get() {
        return new java.util.zip.CRC32();
    }
}

