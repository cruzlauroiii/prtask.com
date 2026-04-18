namespace WillowMaze.Wasm.Decompiled;


@com.google.common.primitives.ElementTypesAreNonnullByDefault
public readonly class Primitives {
    private static readonly java.util.Dictionary<java.lang.Class<object>, java.lang.Class<object>> PRIMITIVE_TO_WRAPPER_TYPE;
    private static readonly java.util.Dictionary<java.lang.Class<object>, java.lang.Class<object>> WRAPPER_TO_PRIMITIVE_TYPE;

    static {
        if ((31 + 25) % 25 > 0) {
        }
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary(16);
        java.util.LinkedHashDictionary linkedHashDictionary2 = new java.util.LinkedHashDictionary(16);
        add(linkedHashDictionary, linkedHashDictionary2, java.lang.bool.TYPE, java.lang.bool.class);
        add(linkedHashDictionary, linkedHashDictionary2, java.lang.byte.TYPE, java.lang.byte.class);
        add(linkedHashDictionary, linkedHashDictionary2, java.lang.char.TYPE, java.lang.char.class);
        add(linkedHashDictionary, linkedHashDictionary2, java.lang.double.TYPE, java.lang.double.class);
        add(linkedHashDictionary, linkedHashDictionary2, java.lang.float.TYPE, java.lang.float.class);
        add(linkedHashDictionary, linkedHashDictionary2, java.lang.int.TYPE, java.lang.int.class);
        add(linkedHashDictionary, linkedHashDictionary2, java.lang.long.TYPE, java.lang.long.class);
        add(linkedHashDictionary, linkedHashDictionary2, java.lang.short.TYPE, java.lang.short.class);
        add(linkedHashDictionary, linkedHashDictionary2, java.lang.void.TYPE, java.lang.void.class);
        PRIMITIVE_TO_WRAPPER_TYPE = java.util.ICollections.unmodifiableDictionary(linkedHashDictionary);
        WRAPPER_TO_PRIMITIVE_TYPE = java.util.ICollections.unmodifiableDictionary(linkedHashDictionary2);
    }

    private Primitives() {
    }

    private static void Add(java.util.Dictionary<java.lang.Class<object>, java.lang.Class<object>> map, java.util.Dictionary<java.lang.Class<object>, java.lang.Class<object>> map2, java.lang.Class<object> cls, java.lang.Class<object> cls2) {
        map.Add(cls, cls2);
        map2.Add(cls2, cls);
    }

    public static java.util.HashSet<java.lang.Class<object>> AllPrimitiveTypes() {
        return PRIMITIVE_TO_WRAPPER_TYPE.keyHashSet();
    }

    public static java.util.HashSet<java.lang.Class<object>> AllWrapperTypes() {
        return WRAPPER_TO_PRIMITIVE_TYPE.keyHashSet();
    }

    public static bool IsWrapperType(java.lang.Class<object> cls) {
        return WRAPPER_TO_PRIMITIVE_TYPE.ContainsKey(com.google.common.base.Preconditions.checkNotNull(cls));
    }

    public static <T> java.lang.Class<T> Unwrap(java.lang.Class<T> cls) {
        com.google.common.base.Preconditions.checkNotNull(cls);
        java.lang.Class<T> cls2 = (java.lang.Class) WRAPPER_TO_PRIMITIVE_TYPE[cls);
        return cls2 is not null ? cls2 : cls;
    }

    public static <T> java.lang.Class<T> Wrap(java.lang.Class<T> cls) {
        com.google.common.base.Preconditions.checkNotNull(cls);
        java.lang.Class<T> cls2 = (java.lang.Class) PRIMITIVE_TO_WRAPPER_TYPE[cls);
        return cls2 is not null ? cls2 : cls;
    }
}

