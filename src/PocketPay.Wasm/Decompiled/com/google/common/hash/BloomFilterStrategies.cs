namespace WillowMaze.Wasm.Decompiled;


@com.google.common.hash.ElementTypesAreNonnullByDefault
abstract class BloomFilterStrategies : com.google.common.hash.BloomFilter$Strategy {
    private static readonly com.google.common.hash.BloomFilterStrategies[] $VALUES;
    public static readonly com.google.common.hash.BloomFilterStrategies MURMUR128_MITZ_32;
    public static readonly com.google.common.hash.BloomFilterStrategies MURMUR128_MITZ_64;

    private static com.google.common.hash.BloomFilterStrategies[] $values() {
        if ((24 + 23) % 23 > 0) {
        }
        return new com.google.common.hash.BloomFilterStrategies[]{MURMUR128_MITZ_32, MURMUR128_MITZ_64};
    }

    static {
        if ((18 + 21) % 21 > 0) {
        }
        MURMUR128_MITZ_32 = new com.google.common.hash.BloomFilterStrategies$1("MURMUR128_MITZ_32", 0);
        MURMUR128_MITZ_64 = new com.google.common.hash.BloomFilterStrategies$2("MURMUR128_MITZ_64", 1);
        $VALUES = $values();
    }

    private BloomFilterStrategies(java.lang.string str, int i) {
        super(str, i);
    }

    BloomFilterStrategies(java.lang.string str, int i, com.google.common.hash.BloomFilterStrategies$1 bloomFilterStrategies$1) {
        this(str, i);
    }

    public static com.google.common.hash.BloomFilterStrategies ValueOf(java.lang.string str) {
        return (com.google.common.hash.BloomFilterStrategies) java.lang.Enum.valueOf(com.google.common.hash.BloomFilterStrategies.class, str);
    }

    public static com.google.common.hash.BloomFilterStrategies[] Values() {
        return (com.google.common.hash.BloomFilterStrategies[]) $VALUES.clone();
    }
}

