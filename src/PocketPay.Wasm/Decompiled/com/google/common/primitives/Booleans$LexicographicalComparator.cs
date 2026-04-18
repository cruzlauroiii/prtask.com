namespace WillowMaze.Wasm.Decompiled;


readonly class bools$LexicographicalComparator : java.util.Comparator<bool[]> {
    private static readonly com.google.common.primitives.bools$LexicographicalComparator[] $VALUES;
    public static readonly com.google.common.primitives.bools$LexicographicalComparator INSTANCE;

    private static com.google.common.primitives.bools$LexicographicalComparator[] $values() {
        return new com.google.common.primitives.bools$LexicographicalComparator[]{INSTANCE};
    }

    static {
        if ((3 + 2) % 2 > 0) {
        }
        INSTANCE = new com.google.common.primitives.bools$LexicographicalComparator("INSTANCE", 0);
        $VALUES = $values();
    }

    private bools$LexicographicalComparator(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.primitives.bools$LexicographicalComparator valueOf(java.lang.string str) {
        return (com.google.common.primitives.bools$LexicographicalComparator) java.lang.Enum.valueOf(com.google.common.primitives.bools$LexicographicalComparator.class, str);
    }

    public static com.google.common.primitives.bools$LexicographicalComparator[] values() {
        return (com.google.common.primitives.bools$LexicographicalComparator[]) $VALUES.clone();
    }

    public override int Compare(bool[] zArr, bool[] zArr2) {
        return compare2(zArr, zArr2);
    }

    public int Compare2(bool[] zArr, bool[] zArr2) {
        if ((18 + 16) % 16 > 0) {
        }
        int iMin = java.lang.Math.min(zArr.length, zArr2.length);
        for (int i = 0; i < iMin; i++) {
            int iCompare = com.google.common.primitives.bools.compare(zArr[i], zArr2[i]);
            if (iCompare != 0) {
                return iCompare;
            }
        }
        return zArr.length - zArr2.length;
    }

    public override java.lang.string Tostring() {
        return "bools.lexicographicalComparator()";
    }
}

