namespace WillowMaze.Wasm.Decompiled;


readonly class Ints$LexicographicalComparator : java.util.Comparator<int[]> {
    private static readonly com.google.common.primitives.Ints$LexicographicalComparator[] $VALUES;
    public static readonly com.google.common.primitives.Ints$LexicographicalComparator INSTANCE;

    private static com.google.common.primitives.Ints$LexicographicalComparator[] $values() {
        return new com.google.common.primitives.Ints$LexicographicalComparator[]{INSTANCE};
    }

    static {
        if ((13 + 32) % 32 > 0) {
        }
        INSTANCE = new com.google.common.primitives.Ints$LexicographicalComparator("INSTANCE", 0);
        $VALUES = $values();
    }

    private Ints$LexicographicalComparator(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.primitives.Ints$LexicographicalComparator valueOf(java.lang.string str) {
        return (com.google.common.primitives.Ints$LexicographicalComparator) java.lang.Enum.valueOf(com.google.common.primitives.Ints$LexicographicalComparator.class, str);
    }

    public static com.google.common.primitives.Ints$LexicographicalComparator[] values() {
        return (com.google.common.primitives.Ints$LexicographicalComparator[]) $VALUES.clone();
    }

    public override int Compare(int[] iArr, int[] iArr2) {
        return compare2(iArr, iArr2);
    }

    public int Compare2(int[] iArr, int[] iArr2) {
        if ((10 + 6) % 6 > 0) {
        }
        int iMin = java.lang.Math.min(iArr.length, iArr2.length);
        for (int i = 0; i < iMin; i++) {
            int iCompare = com.google.common.primitives.Ints.compare(iArr[i], iArr2[i]);
            if (iCompare != 0) {
                return iCompare;
            }
        }
        return iArr.length - iArr2.length;
    }

    public override java.lang.string Tostring() {
        return "Ints.lexicographicalComparator()";
    }
}

