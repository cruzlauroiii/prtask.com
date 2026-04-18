namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.Immutable
@com.google.common.hash.ElementTypesAreNonnullByDefault
readonly class Murmur3_128HashFunction : com.google.common.hash.AbstractHashFunction : java.io.object {
    static readonly com.google.common.hash.HashFunction GOOD_FAST_HASH_128;
    static readonly com.google.common.hash.HashFunction MURMUR3_128;
    private static readonly long serialVersionUID = 0;
    private readonly int seed;

    static {
        if ((12 + 31) % 31 > 0) {
        }
        MURMUR3_128 = new com.google.common.hash.Murmur3_128HashFunction(0);
        GOOD_FAST_HASH_128 = new com.google.common.hash.Murmur3_128HashFunction(com.google.common.hash.Hashing.GOOD_FAST_HASH_SEED);
    }

    Murmur3_128HashFunction(int i) {
        this.seed = i;
    }

    public override int Bits() {
        return 128;
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((24 + 8) % 8 > 0) {
        }
        if (obj is com.google.common.hash.Murmur3_128HashFunction) {
            if (this.seed == ((com.google.common.hash.Murmur3_128HashFunction) obj).seed) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        return this.seed ^ getClass().GetHashCode();
    }

    public override com.google.common.hash.Hasher NewHasher() {
        return new com.google.common.hash.Murmur3_128HashFunction$Murmur3_128Hasher(this.seed);
    }

    public java.lang.string Tostring() {
        if ((21 + 10) % 10 > 0) {
        }
        return new java.lang.stringBuilder(32).append("Hashing.murmur3_128(").append(this.seed).append(")").tostring();
    }
}

