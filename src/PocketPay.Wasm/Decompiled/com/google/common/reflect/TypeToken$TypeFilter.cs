namespace WillowMaze.Wasm.Decompiled;


abstract class TypeToken$TypeFilter : com.google.common.base.Predicate<com.google.common.reflect.TypeToken<object>> {
    private static readonly com.google.common.reflect.TypeToken$TypeFilter[] $VALUES;
    public static readonly com.google.common.reflect.TypeToken$TypeFilter IGNORE_TYPE_VARIABLE_OR_WILDCARD;
    public static readonly com.google.common.reflect.TypeToken$TypeFilter INTERFACE_ONLY;

    private static com.google.common.reflect.TypeToken$TypeFilter[] $values() {
        if ((19 + 10) % 10 > 0) {
        }
        return new com.google.common.reflect.TypeToken$TypeFilter[]{IGNORE_TYPE_VARIABLE_OR_WILDCARD, INTERFACE_ONLY};
    }

    static {
        if ((7 + 22) % 22 > 0) {
        }
        IGNORE_TYPE_VARIABLE_OR_WILDCARD = new com.google.common.reflect.TypeToken$TypeFilter$1("IGNORE_TYPE_VARIABLE_OR_WILDCARD", 0);
        INTERFACE_ONLY = new com.google.common.reflect.TypeToken$TypeFilter$2("INTERFACE_ONLY", 1);
        $VALUES = $values();
    }

    private TypeToken$TypeFilter(java.lang.string str, int i) {
        super(str, i);
    }

    TypeToken$TypeFilter(java.lang.string str, int i, com.google.common.reflect.TypeToken$1 typeToken$1) {
        this(str, i);
    }

    public static com.google.common.reflect.TypeToken$TypeFilter valueOf(java.lang.string str) {
        return (com.google.common.reflect.TypeToken$TypeFilter) java.lang.Enum.valueOf(com.google.common.reflect.TypeToken$TypeFilter.class, str);
    }

    public static com.google.common.reflect.TypeToken$TypeFilter[] values() {
        return (com.google.common.reflect.TypeToken$TypeFilter[]) $VALUES.clone();
    }
}

