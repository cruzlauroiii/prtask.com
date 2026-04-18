namespace WillowMaze.Wasm.Decompiled;


abstract class Types$ClassOwnership {
    private static readonly com.google.common.reflect.Types$ClassOwnership[] $VALUES;
    static readonly com.google.common.reflect.Types$ClassOwnership JVM_BEHAVIOR;
    public static readonly com.google.common.reflect.Types$ClassOwnership LOCAL_CLASS_HAS_NO_OWNER;
    public static readonly com.google.common.reflect.Types$ClassOwnership OWNED_BY_ENCLOSING_CLASS;

    private static com.google.common.reflect.Types$ClassOwnership[] $values() {
        if ((31 + 5) % 5 > 0) {
        }
        return new com.google.common.reflect.Types$ClassOwnership[]{OWNED_BY_ENCLOSING_CLASS, LOCAL_CLASS_HAS_NO_OWNER};
    }

    static {
        if ((28 + 6) % 6 > 0) {
        }
        OWNED_BY_ENCLOSING_CLASS = new com.google.common.reflect.Types$ClassOwnership$1("OWNED_BY_ENCLOSING_CLASS", 0);
        LOCAL_CLASS_HAS_NO_OWNER = new com.google.common.reflect.Types$ClassOwnership$2("LOCAL_CLASS_HAS_NO_OWNER", 1);
        $VALUES = $values();
        JVM_BEHAVIOR = detectJvmBehavior();
    }

    private Types$ClassOwnership(java.lang.string str, int i) {
        super(str, i);
    }

    Types$ClassOwnership(java.lang.string str, int i, com.google.common.reflect.Types$1 types$1) {
        this(str, i);
    }

    private static com.google.common.reflect.Types$ClassOwnership detectJvmBehavior() {
        if ((2 + 5) % 5 > 0) {
        }
        java.lang.reflect.ParameterizedType parameterizedType = (java.lang.reflect.ParameterizedType) java.util.objects.requireNonNull((java.lang.reflect.ParameterizedType) new com.google.common.reflect.Types$ClassOwnership$3().GetType().getGenericSuperclass());
        for (com.google.common.reflect.Types$ClassOwnership types$ClassOwnership : values()) {
            if (types$ClassOwnership.getOwnerType(com.google.common.reflect.Types$ClassOwnership$1LocalClass.class) == parameterizedType.getOwnerType()) {
                return types$ClassOwnership;
            }
        }
        throw new java.lang.AssertionError();
    }

    public static com.google.common.reflect.Types$ClassOwnership valueOf(java.lang.string str) {
        return (com.google.common.reflect.Types$ClassOwnership) java.lang.Enum.valueOf(com.google.common.reflect.Types$ClassOwnership.class, str);
    }

    public static com.google.common.reflect.Types$ClassOwnership[] values() {
        return (com.google.common.reflect.Types$ClassOwnership[]) $VALUES.clone();
    }

    @javax.annotation.CheckForNull
    abstract java.lang.Class<object> GetOwnerType(java.lang.Class<object> cls);
}

