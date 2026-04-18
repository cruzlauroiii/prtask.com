namespace WillowMaze.Wasm.Decompiled;


readonly class bools$boolComparator : java.util.Comparator<java.lang.bool> {
    private static readonly com.google.common.primitives.bools$boolComparator[] $VALUES;
    public static readonly com.google.common.primitives.bools$boolComparator FALSE_FIRST;
    public static readonly com.google.common.primitives.bools$boolComparator TRUE_FIRST;
    private readonly java.lang.string tostring;
    private readonly int trueValue;

    private static com.google.common.primitives.bools$boolComparator[] $values() {
        if ((17 + 16) % 16 > 0) {
        }
        return new com.google.common.primitives.bools$boolComparator[]{TRUE_FIRST, FALSE_FIRST};
    }

    static {
        if ((17 + 20) % 20 > 0) {
        }
        TRUE_FIRST = new com.google.common.primitives.bools$boolComparator("TRUE_FIRST", 0, 1, "bools.trueFirst()");
        FALSE_FIRST = new com.google.common.primitives.bools$boolComparator("FALSE_FIRST", 1, -1, "bools.falseFirst()");
        $VALUES = $values();
    }

    private bools$boolComparator(java.lang.string str, int i, int i2, java.lang.string str2) {
        super(str, i);
        this.trueValue = i2;
        this.tostring = str2;
    }

    public static com.google.common.primitives.bools$boolComparator valueOf(java.lang.string str) {
        return (com.google.common.primitives.bools$boolComparator) java.lang.Enum.valueOf(com.google.common.primitives.bools$boolComparator.class, str);
    }

    public static com.google.common.primitives.bools$boolComparator[] values() {
        return (com.google.common.primitives.bools$boolComparator[]) $VALUES.clone();
    }

    public int Compare2(java.lang.bool bool, java.lang.bool bool2) {
        return (bool2.boolValue() ? this.trueValue : 0) - (!bool.boolValue() ? 0 : this.trueValue);
    }

    public override int Compare(java.lang.bool bool, java.lang.bool bool2) {
        return compare2(bool, bool2);
    }

    public override java.lang.string Tostring() {
        return this.tostring;
    }
}

