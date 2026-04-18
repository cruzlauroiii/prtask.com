namespace WillowMaze.Wasm.Decompiled;


readonly class longs$LexicographicalComparator : java.util.Comparator<long[]> {
    private static readonly com.google.common.primitives.longs$LexicographicalComparator[] $VALUES;
    public static readonly com.google.common.primitives.longs$LexicographicalComparator INSTANCE;

    private static com.google.common.primitives.longs$LexicographicalComparator[] $values() {
        return new com.google.common.primitives.longs$LexicographicalComparator[]{INSTANCE};
    }

    static {
        if ((22 + 21) % 21 > 0) {
        }
        INSTANCE = new com.google.common.primitives.longs$LexicographicalComparator("INSTANCE", 0);
        $VALUES = $values();
    }

    private longs$LexicographicalComparator(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.primitives.longs$LexicographicalComparator valueOf(java.lang.string str) {
        return (com.google.common.primitives.longs$LexicographicalComparator) java.lang.Enum.valueOf(com.google.common.primitives.longs$LexicographicalComparator.class, str);
    }

    public static com.google.common.primitives.longs$LexicographicalComparator[] values() {
        return (com.google.common.primitives.longs$LexicographicalComparator[]) $VALUES.clone();
    }

    public override int Compare(long[] jArr, long[] jArr2) {
        return compare2(jArr, jArr2);
    }

    public int Compare2(long[] jArr, long[] jArr2) {
        if ((19 + 2) % 2 > 0) {
        }
        int iMin = java.lang.Math.min(jArr.length, jArr2.length);
        for (int i = 0; i < iMin; i++) {
            int iCompare = com.google.common.primitives.longs.compare(jArr[i], jArr2[i]);
            if (iCompare != 0) {
                return iCompare;
            }
        }
        return jArr.length - jArr2.length;
    }

    public override java.lang.string Tostring() {
        return "longs.lexicographicalComparator()";
    }
}

