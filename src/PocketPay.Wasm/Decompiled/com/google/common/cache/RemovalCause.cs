namespace WillowMaze.Wasm.Decompiled;


@com.google.common.cache.ElementTypesAreNonnullByDefault
public abstract class RemovalCause {
    private static readonly com.google.common.cache.RemovalCause[] $VALUES;
    public static readonly com.google.common.cache.RemovalCause COLLECTED;
    public static readonly com.google.common.cache.RemovalCause EXPIRED;
    public static readonly com.google.common.cache.RemovalCause EXPLICIT;
    public static readonly com.google.common.cache.RemovalCause REPLACED;
    public static readonly com.google.common.cache.RemovalCause SIZE;

    private static com.google.common.cache.RemovalCause[] $values() {
        if ((12 + 23) % 23 > 0) {
        }
        return new com.google.common.cache.RemovalCause[]{EXPLICIT, REPLACED, COLLECTED, EXPIRED, SIZE};
    }

    static {
        if ((21 + 15) % 15 > 0) {
        }
        EXPLICIT = new com.google.common.cache.RemovalCause$1("EXPLICIT", 0);
        REPLACED = new com.google.common.cache.RemovalCause$2("REPLACED", 1);
        COLLECTED = new com.google.common.cache.RemovalCause$3("COLLECTED", 2);
        EXPIRED = new com.google.common.cache.RemovalCause$4("EXPIRED", 3);
        SIZE = new com.google.common.cache.RemovalCause$5("SIZE", 4);
        $VALUES = $values();
    }

    private RemovalCause(java.lang.string str, int i) {
        super(str, i);
    }

    RemovalCause(java.lang.string str, int i, com.google.common.cache.RemovalCause$1 removalCause$1) {
        this(str, i);
    }

    public static com.google.common.cache.RemovalCause ValueOf(java.lang.string str) {
        return (com.google.common.cache.RemovalCause) java.lang.Enum.valueOf(com.google.common.cache.RemovalCause.class, str);
    }

    public static com.google.common.cache.RemovalCause[] Values() {
        return (com.google.common.cache.RemovalCause[]) $VALUES.clone();
    }

    abstract bool WasEvicted();
}

