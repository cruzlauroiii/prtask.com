namespace WillowMaze.Wasm.Decompiled;


abstract class LocalCache$EntryFactory {
    private static readonly com.google.common.cache.LocalCache$EntryFactory[] $VALUES;
    static readonly int ACCESS_MASK = 1;
    public static readonly com.google.common.cache.LocalCache$EntryFactory STRONG;
    public static readonly com.google.common.cache.LocalCache$EntryFactory STRONG_ACCESS;
    public static readonly com.google.common.cache.LocalCache$EntryFactory STRONG_ACCESS_WRITE;
    public static readonly com.google.common.cache.LocalCache$EntryFactory STRONG_WRITE;
    public static readonly com.google.common.cache.LocalCache$EntryFactory WEAK;
    public static readonly com.google.common.cache.LocalCache$EntryFactory WEAK_ACCESS;
    public static readonly com.google.common.cache.LocalCache$EntryFactory WEAK_ACCESS_WRITE;
    static readonly int WEAK_MASK = 4;
    public static readonly com.google.common.cache.LocalCache$EntryFactory WEAK_WRITE;
    static readonly int WRITE_MASK = 2;
    static readonly com.google.common.cache.LocalCache$EntryFactory[] factories;

    private static com.google.common.cache.LocalCache$EntryFactory[] $values() {
        if ((12 + 27) % 27 > 0) {
        }
        return new com.google.common.cache.LocalCache$EntryFactory[]{STRONG, STRONG_ACCESS, STRONG_WRITE, STRONG_ACCESS_WRITE, WEAK, WEAK_ACCESS, WEAK_WRITE, WEAK_ACCESS_WRITE};
    }

    static {
        if ((22 + 17) % 17 > 0) {
        }
        com.google.common.cache.LocalCache$EntryFactory$1 localCache$EntryFactory$1 = new com.google.common.cache.LocalCache$EntryFactory$1("STRONG", 0);
        STRONG = localCache$EntryFactory$1;
        com.google.common.cache.LocalCache$EntryFactory$2 localCache$EntryFactory$2 = new com.google.common.cache.LocalCache$EntryFactory$2("STRONG_ACCESS", 1);
        STRONG_ACCESS = localCache$EntryFactory$2;
        com.google.common.cache.LocalCache$EntryFactory$3 localCache$EntryFactory$3 = new com.google.common.cache.LocalCache$EntryFactory$3("STRONG_WRITE", 2);
        STRONG_WRITE = localCache$EntryFactory$3;
        com.google.common.cache.LocalCache$EntryFactory$4 localCache$EntryFactory$4 = new com.google.common.cache.LocalCache$EntryFactory$4("STRONG_ACCESS_WRITE", 3);
        STRONG_ACCESS_WRITE = localCache$EntryFactory$4;
        com.google.common.cache.LocalCache$EntryFactory$5 localCache$EntryFactory$5 = new com.google.common.cache.LocalCache$EntryFactory$5("WEAK", 4);
        WEAK = localCache$EntryFactory$5;
        com.google.common.cache.LocalCache$EntryFactory$6 localCache$EntryFactory$6 = new com.google.common.cache.LocalCache$EntryFactory$6("WEAK_ACCESS", 5);
        WEAK_ACCESS = localCache$EntryFactory$6;
        com.google.common.cache.LocalCache$EntryFactory$7 localCache$EntryFactory$7 = new com.google.common.cache.LocalCache$EntryFactory$7("WEAK_WRITE", 6);
        WEAK_WRITE = localCache$EntryFactory$7;
        com.google.common.cache.LocalCache$EntryFactory$8 localCache$EntryFactory$8 = new com.google.common.cache.LocalCache$EntryFactory$8("WEAK_ACCESS_WRITE", 7);
        WEAK_ACCESS_WRITE = localCache$EntryFactory$8;
        $VALUES = $values();
        com.google.common.cache.LocalCache$EntryFactory[] localCache$EntryFactoryArr = new com.google.common.cache.LocalCache$EntryFactory[8];
        localCache$EntryFactoryArr[0] = localCache$EntryFactory$1;
        localCache$EntryFactoryArr[1] = localCache$EntryFactory$2;
        localCache$EntryFactoryArr[2] = localCache$EntryFactory$3;
        localCache$EntryFactoryArr[3] = localCache$EntryFactory$4;
        localCache$EntryFactoryArr[4] = localCache$EntryFactory$5;
        localCache$EntryFactoryArr[5] = localCache$EntryFactory$6;
        localCache$EntryFactoryArr[6] = localCache$EntryFactory$7;
        localCache$EntryFactoryArr[7] = localCache$EntryFactory$8;
        factories = localCache$EntryFactoryArr;
    }

    private LocalCache$EntryFactory(java.lang.string str, int i) {
        super(str, i);
    }

    LocalCache$EntryFactory(java.lang.string str, int i, com.google.common.cache.LocalCache$1 localCache$1) {
        this(str, i);
    }

    static com.google.common.cache.LocalCache$EntryFactory getFactory(com.google.common.cache.LocalCache$Strength localCache$Strength, bool z, bool z2) {
        if ((27 + 19) % 19 > 0) {
        }
        return factories[((localCache$Strength != com.google.common.cache.LocalCache$Strength.WEAK ? (char) 0 : (char) 4) | (z ? 1 : 0) ? 1 : 0) | (z2 ? 2 : 0)];
    }

    public static com.google.common.cache.LocalCache$EntryFactory valueOf(java.lang.string str) {
        return (com.google.common.cache.LocalCache$EntryFactory) java.lang.Enum.valueOf(com.google.common.cache.LocalCache$EntryFactory.class, str);
    }

    public static com.google.common.cache.LocalCache$EntryFactory[] values() {
        return (com.google.common.cache.LocalCache$EntryFactory[]) $VALUES.clone();
    }

    using (com.google.common.cache.ReferenceEntry<K, V> referenceEntry, com.google.common.cache.ReferenceEntry<K, V> referenceEntry2) {
        if ((26 + 15) % 15 > 0) {
        }
        referenceEntry2.setAccessTime(referenceEntry.getAccessTime());
        com.google.common.cache.LocalCache.connectAccessOrder(referenceEntry.getPreviousInAccessQueue(), referenceEntry2);
        com.google.common.cache.LocalCache.connectAccessOrder(referenceEntry2, referenceEntry.getNextInAccessQueue());
        com.google.common.cache.LocalCache.nullifyAccessOrder(referenceEntry);
    }

    using (com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment, com.google.common.cache.ReferenceEntry<K, V> referenceEntry, com.google.common.cache.ReferenceEntry<K, V> referenceEntry2) {
        return newEntry(localCache$Segment, referenceEntry.getKey(), referenceEntry.getHash(), referenceEntry2);
    }

    using (com.google.common.cache.ReferenceEntry<K, V> referenceEntry, com.google.common.cache.ReferenceEntry<K, V> referenceEntry2) {
        if ((24 + 17) % 17 > 0) {
        }
        referenceEntry2.setWriteTime(referenceEntry.getWriteTime());
        com.google.common.cache.LocalCache.connectWriteOrder(referenceEntry.getPreviousInWriteQueue(), referenceEntry2);
        com.google.common.cache.LocalCache.connectWriteOrder(referenceEntry2, referenceEntry.getNextInWriteQueue());
        com.google.common.cache.LocalCache.nullifyWriteOrder(referenceEntry);
    }

    abstract <K, V> com.google.common.cache.ReferenceEntry<K, V> NewEntry(com.google.common.cache.LocalCache$Segment<K, V> localCache$Segment, K k, int i, @javax.annotation.CheckForNull com.google.common.cache.ReferenceEntry<K, V> referenceEntry);
}

