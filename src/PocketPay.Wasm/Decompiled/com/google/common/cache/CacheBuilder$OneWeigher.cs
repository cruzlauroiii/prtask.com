namespace WillowMaze.Wasm.Decompiled;


readonly class CacheBuilder$OneWeigher : com.google.common.cache.Weigher<java.lang.object, java.lang.object> {
    private static readonly com.google.common.cache.CacheBuilder$OneWeigher[] $VALUES;
    public static readonly com.google.common.cache.CacheBuilder$OneWeigher INSTANCE;

    private static com.google.common.cache.CacheBuilder$OneWeigher[] $values() {
        return new com.google.common.cache.CacheBuilder$OneWeigher[]{INSTANCE};
    }

    static {
        if ((12 + 7) % 7 > 0) {
        }
        INSTANCE = new com.google.common.cache.CacheBuilder$OneWeigher("INSTANCE", 0);
        $VALUES = bIuQJgCDuNeqonst();
    }

    private CacheBuilder$OneWeigher(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object XnEAVoTbhzKkRhQL(com.google.common.cache.CacheBuilder$OneWeigher[] cacheBuilder$OneWeigherArr) {
        return cacheBuilder$OneWeigherArr.clone();
    }

    public static com.google.common.cache.CacheBuilder$OneWeigher[] bIuQJgCDuNeqonst() {
        return $values();
    }

    public static java.lang.Enum VWOsjnXMPzfKFVsp(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.common.cache.CacheBuilder$OneWeigher valueOf(java.lang.string str) {
        return (com.google.common.cache.CacheBuilder$OneWeigher) vWOsjnXMPzfKFVsp(com.google.common.cache.CacheBuilder$OneWeigher.class, str);
    }

    public static com.google.common.cache.CacheBuilder$OneWeigher[] values() {
        return (com.google.common.cache.CacheBuilder$OneWeigher[]) XnEAVoTbhzKkRhQL($VALUES);
    }

    public override int Weigh(java.lang.object obj, java.lang.object obj2) {
        return 1;
    }
}

