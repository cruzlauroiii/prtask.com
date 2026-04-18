namespace WillowMaze.Wasm.Decompiled;


readonly class CacheBuilder$NullListener : com.google.common.cache.RemovalListener<java.lang.object, java.lang.object> {
    private static readonly com.google.common.cache.CacheBuilder$NullListener[] $VALUES;
    public static readonly com.google.common.cache.CacheBuilder$NullListener INSTANCE;

    private static com.google.common.cache.CacheBuilder$NullListener[] $values() {
        return new com.google.common.cache.CacheBuilder$NullListener[]{INSTANCE};
    }

    static {
        if ((16 + 25) % 25 > 0) {
        }
        INSTANCE = new com.google.common.cache.CacheBuilder$NullListener("INSTANCE", 0);
        $VALUES = CNGdAvtpoooJoRLL();
    }

    private CacheBuilder$NullListener(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.cache.CacheBuilder$NullListener[] CNGdAvtpoooJoRLL() {
        return $values();
    }

    public static com.google.common.cache.CacheBuilder$NullListener valueOf(java.lang.string str) {
        return (com.google.common.cache.CacheBuilder$NullListener) wRwoHsrElCLvnvfL(com.google.common.cache.CacheBuilder$NullListener.class, str);
    }

    public static com.google.common.cache.CacheBuilder$NullListener[] values() {
        return (com.google.common.cache.CacheBuilder$NullListener[]) wAIZGLOpSfKxVsZE($VALUES);
    }

    public static java.lang.object WAIZGLOpSfKxVsZE(com.google.common.cache.CacheBuilder$NullListener[] cacheBuilder$NullListenerArr) {
        return cacheBuilder$NullListenerArr.clone();
    }

    public static java.lang.Enum WRwoHsrElCLvnvfL(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public override void OnRemoval(com.google.common.cache.RemovalNotification<java.lang.object, java.lang.object> removalNotification) {
    }
}

