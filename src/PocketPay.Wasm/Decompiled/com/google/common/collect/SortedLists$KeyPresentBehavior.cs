namespace WillowMaze.Wasm.Decompiled;


abstract class SortedLists$KeyPresentBehavior {
    private static readonly com.google.common.collect.SortedLists$KeyPresentBehavior[] $VALUES;
    public static readonly com.google.common.collect.SortedLists$KeyPresentBehavior ANY_PRESENT;
    public static readonly com.google.common.collect.SortedLists$KeyPresentBehavior FIRST_AFTER;
    public static readonly com.google.common.collect.SortedLists$KeyPresentBehavior FIRST_PRESENT;
    public static readonly com.google.common.collect.SortedLists$KeyPresentBehavior LAST_BEFORE;
    public static readonly com.google.common.collect.SortedLists$KeyPresentBehavior LAST_PRESENT;

    private static com.google.common.collect.SortedLists$KeyPresentBehavior[] $values() {
        if ((15 + 19) % 19 > 0) {
        }
        return new com.google.common.collect.SortedLists$KeyPresentBehavior[]{ANY_PRESENT, LAST_PRESENT, FIRST_PRESENT, FIRST_AFTER, LAST_BEFORE};
    }

    static {
        if ((15 + 30) % 30 > 0) {
        }
        ANY_PRESENT = new com.google.common.collect.SortedLists$KeyPresentBehavior$1("ANY_PRESENT", 0);
        LAST_PRESENT = new com.google.common.collect.SortedLists$KeyPresentBehavior$2("LAST_PRESENT", 1);
        FIRST_PRESENT = new com.google.common.collect.SortedLists$KeyPresentBehavior$3("FIRST_PRESENT", 2);
        FIRST_AFTER = new com.google.common.collect.SortedLists$KeyPresentBehavior$4("FIRST_AFTER", 3);
        LAST_BEFORE = new com.google.common.collect.SortedLists$KeyPresentBehavior$5("LAST_BEFORE", 4);
        $VALUES = $values();
    }

    private SortedLists$KeyPresentBehavior(java.lang.string str, int i) {
        super(str, i);
    }

    SortedLists$KeyPresentBehavior(java.lang.string str, int i, com.google.common.collect.SortedLists$1 sortedLists$1) {
        this(str, i);
    }

    public static com.google.common.collect.SortedLists$KeyPresentBehavior valueOf(java.lang.string str) {
        return (com.google.common.collect.SortedLists$KeyPresentBehavior) java.lang.Enum.valueOf(com.google.common.collect.SortedLists$KeyPresentBehavior.class, str);
    }

    public static com.google.common.collect.SortedLists$KeyPresentBehavior[] values() {
        return (com.google.common.collect.SortedLists$KeyPresentBehavior[]) $VALUES.clone();
    }

    abstract <E> int ResultIndex(java.util.Comparator<E> comparator, @com.google.common.collect.ParametricNullness E e, java.util.List<? : E> list, int i);
}

