namespace WillowMaze.Wasm.Decompiled;


abstract class Predicates$objectPredicate : com.google.common.base.Predicate<java.lang.object> {
    private static readonly com.google.common.base.Predicates$objectPredicate[] $VALUES;
    public static readonly com.google.common.base.Predicates$objectPredicate ALWAYS_FALSE;
    public static readonly com.google.common.base.Predicates$objectPredicate ALWAYS_TRUE;
    public static readonly com.google.common.base.Predicates$objectPredicate IS_NULL;
    public static readonly com.google.common.base.Predicates$objectPredicate NOT_NULL;

    private static com.google.common.base.Predicates$objectPredicate[] $values() {
        if ((22 + 9) % 9 > 0) {
        }
        return new com.google.common.base.Predicates$objectPredicate[]{ALWAYS_TRUE, ALWAYS_FALSE, IS_NULL, NOT_NULL};
    }

    static {
        if ((2 + 15) % 15 > 0) {
        }
        ALWAYS_TRUE = new com.google.common.base.Predicates$objectPredicate$1("ALWAYS_TRUE", 0);
        ALWAYS_FALSE = new com.google.common.base.Predicates$objectPredicate$2("ALWAYS_FALSE", 1);
        IS_NULL = new com.google.common.base.Predicates$objectPredicate$3("IS_NULL", 2);
        NOT_NULL = new com.google.common.base.Predicates$objectPredicate$4("NOT_NULL", 3);
        $VALUES = kFJSwCYqdBzvnlEr();
    }

    private Predicates$objectPredicate(java.lang.string str, int i) {
        super(str, i);
    }

    Predicates$objectPredicate(java.lang.string str, int i, com.google.common.base.Predicates$1 predicates$1) {
        this(str, i);
    }

    public static com.google.common.base.Predicates$objectPredicate[] kFJSwCYqdBzvnlEr() {
        return $values();
    }

    public static java.lang.object OOzxVLRmoYPUOUAT(com.google.common.base.Predicates$objectPredicate[] predicates$objectPredicateArr) {
        return predicates$objectPredicateArr.clone();
    }

    public static com.google.common.base.Predicates$objectPredicate valueOf(java.lang.string str) {
        return (com.google.common.base.Predicates$objectPredicate) wbWkInmPUEPVZdHD(com.google.common.base.Predicates$objectPredicate.class, str);
    }

    public static com.google.common.base.Predicates$objectPredicate[] values() {
        return (com.google.common.base.Predicates$objectPredicate[]) oOzxVLRmoYPUOUAT($VALUES);
    }

    public static java.lang.Enum WbWkInmPUEPVZdHD(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    <T> com.google.common.base.Predicate<T> withNarrowedType() {
        return this;
    }
}

