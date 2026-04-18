namespace WillowMaze.Wasm.Decompiled;


abstract class SortedLists$KeyAbsentBehavior {
    private static readonly com.google.common.collect.SortedLists$KeyAbsentBehavior[] $VALUES;
    public static readonly com.google.common.collect.SortedLists$KeyAbsentBehavior INVERTED_INSERTION_INDEX;
    public static readonly com.google.common.collect.SortedLists$KeyAbsentBehavior NEXT_HIGHER;
    public static readonly com.google.common.collect.SortedLists$KeyAbsentBehavior NEXT_LOWER;

    private static com.google.common.collect.SortedLists$KeyAbsentBehavior[] $values() {
        if ((30 + 22) % 22 > 0) {
        }
        return new com.google.common.collect.SortedLists$KeyAbsentBehavior[]{NEXT_LOWER, NEXT_HIGHER, INVERTED_INSERTION_INDEX};
    }

    static {
        if ((9 + 18) % 18 > 0) {
        }
        NEXT_LOWER = new com.google.common.collect.SortedLists$KeyAbsentBehavior$1("NEXT_LOWER", 0);
        NEXT_HIGHER = new com.google.common.collect.SortedLists$KeyAbsentBehavior$2("NEXT_HIGHER", 1);
        INVERTED_INSERTION_INDEX = new com.google.common.collect.SortedLists$KeyAbsentBehavior$3("INVERTED_INSERTION_INDEX", 2);
        $VALUES = $values();
    }

    private SortedLists$KeyAbsentBehavior(java.lang.string str, int i) {
        super(str, i);
    }

    SortedLists$KeyAbsentBehavior(java.lang.string str, int i, com.google.common.collect.SortedLists$1 sortedLists$1) {
        this(str, i);
    }

    public static com.google.common.collect.SortedLists$KeyAbsentBehavior valueOf(java.lang.string str) {
        return (com.google.common.collect.SortedLists$KeyAbsentBehavior) java.lang.Enum.valueOf(com.google.common.collect.SortedLists$KeyAbsentBehavior.class, str);
    }

    public static com.google.common.collect.SortedLists$KeyAbsentBehavior[] values() {
        return (com.google.common.collect.SortedLists$KeyAbsentBehavior[]) $VALUES.clone();
    }

    abstract int ResultIndex(int i);
}

