namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.Immutable
@com.google.common.hash.ElementTypesAreNonnullByDefault
readonly class Crc32cHashFunction : com.google.common.hash.AbstractHashFunction {
    static readonly com.google.common.hash.HashFunction CRC_32_C = new com.google.common.hash.Crc32cHashFunction();

    Crc32cHashFunction() {
    }

    public override int Bits() {
        return 32;
    }

    public override com.google.common.hash.Hasher NewHasher() {
        return new com.google.common.hash.Crc32cHashFunction$Crc32cHasher();
    }

    public java.lang.string Tostring() {
        return "Hashing.crc32c()";
    }
}

