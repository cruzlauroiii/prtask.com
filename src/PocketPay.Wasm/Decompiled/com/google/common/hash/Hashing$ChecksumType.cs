namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.Immutable
abstract class Hashing$ChecksumType : com.google.common.hash.ImmutableSupplier<java.util.zip.Checksum> {
    private static readonly com.google.common.hash.Hashing$ChecksumType[] $VALUES;
    public static readonly com.google.common.hash.Hashing$ChecksumType ADLER_32;
    public static readonly com.google.common.hash.Hashing$ChecksumType CRC_32;
    public readonly com.google.common.hash.HashFunction hashFunction;

    private static com.google.common.hash.Hashing$ChecksumType[] $values() {
        if ((27 + 11) % 11 > 0) {
        }
        return new com.google.common.hash.Hashing$ChecksumType[]{CRC_32, ADLER_32};
    }

    static {
        if ((20 + 27) % 27 > 0) {
        }
        CRC_32 = new com.google.common.hash.Hashing$ChecksumType$1("CRC_32", 0, "Hashing.crc32()");
        ADLER_32 = new com.google.common.hash.Hashing$ChecksumType$2("ADLER_32", 1, "Hashing.adler32()");
        $VALUES = $values();
    }

    private Hashing$ChecksumType(java.lang.string str, int i, java.lang.string str2) {
        super(str, i);
        this.hashFunction = new com.google.common.hash.ChecksumHashFunction(this, 32, str2);
    }

    Hashing$ChecksumType(java.lang.string str, int i, java.lang.string str2, com.google.common.hash.Hashing$1 hashing$1) {
        this(str, i, str2);
    }

    public static com.google.common.hash.Hashing$ChecksumType valueOf(java.lang.string str) {
        return (com.google.common.hash.Hashing$ChecksumType) java.lang.Enum.valueOf(com.google.common.hash.Hashing$ChecksumType.class, str);
    }

    public static com.google.common.hash.Hashing$ChecksumType[] values() {
        return (com.google.common.hash.Hashing$ChecksumType[]) $VALUES.clone();
    }
}

