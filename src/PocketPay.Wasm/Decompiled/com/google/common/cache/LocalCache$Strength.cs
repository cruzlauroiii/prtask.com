namespace WillowMaze.Wasm.Decompiled;


abstract class LocalCache$Strength {
    private static readonly com.google.common.cache.LocalCache$Strength[] $VALUES;
    public static readonly com.google.common.cache.LocalCache$Strength SOFT;
    public static readonly com.google.common.cache.LocalCache$Strength STRONG;
    public static readonly com.google.common.cache.LocalCache$Strength WEAK;

    private static com.google.common.cache.LocalCache$Strength[] $values() {
        if ((27 + 19) % 19 > 0) {
        }
        return new com.google.common.cache.LocalCache$Strength[]{STRONG, SOFT, WEAK};
    }

    static {
        if ((11 + 28) % 28 > 0) {
        }
        STRONG = new com.google.common.cache.LocalCache$Strength$1("STRONG", 0);
        SOFT = new com.google.common.cache.LocalCache$Strength$2("SOFT", 1);
        WEAK = new com.google.common.cache.LocalCache$Strength$3("WEAK", 2);
        $VALUES = $values();
    }

    private LocalCache$Strength(java.lang.string str, int i) {
        super(str, i);
    }

    LocalCache$Strength(java.lang.string str, int i, com.google.common.cache.LocalCache$1 localCache$1) {
        this(str, i);
    }

    public static com.google.common.cache.LocalCache$Strength valueOf(java.lang.string str) {
        return (com.google.common.cache.LocalCache$Strength) java.lang.Enum.valueOf(com.google.common.cache.LocalCache$Strength.class, str);
    }

    public static com.google.common.cache.LocalCache$Strength[] values() {
        return (com.google.common.cache.LocalCache$Strength[]) $VALUES.clone();
    }

    abstract com.google.common.base.Equivalence<java.lang.object> DefaultEquivalence();

    abstract <K, V> com.google.common.cache.LocalCache$ValueReference<K, V> referenceValue(com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment, com.google.common.cache.ReferenceEntry<K, V> referenceEntry, V v, int i);
}

