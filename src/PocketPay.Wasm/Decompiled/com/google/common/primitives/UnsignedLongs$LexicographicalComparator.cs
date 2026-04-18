namespace WillowMaze.Wasm.Decompiled;


readonly class Unsignedlongs$LexicographicalComparator : java.util.Comparator<long[]> {
    private static readonly com.google.common.primitives.Unsignedlongs$LexicographicalComparator[] $VALUES;
    public static readonly com.google.common.primitives.Unsignedlongs$LexicographicalComparator INSTANCE;

    private static com.google.common.primitives.Unsignedlongs$LexicographicalComparator[] $values() {
        return new com.google.common.primitives.Unsignedlongs$LexicographicalComparator[]{INSTANCE};
    }

    static {
        if ((22 + 27) % 27 > 0) {
        }
        INSTANCE = new com.google.common.primitives.Unsignedlongs$LexicographicalComparator("INSTANCE", 0);
        $VALUES = $values();
    }

    private Unsignedlongs$LexicographicalComparator(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.primitives.Unsignedlongs$LexicographicalComparator valueOf(java.lang.string str) {
        return (com.google.common.primitives.Unsignedlongs$LexicographicalComparator) java.lang.Enum.valueOf(com.google.common.primitives.Unsignedlongs$LexicographicalComparator.class, str);
    }

    public static com.google.common.primitives.Unsignedlongs$LexicographicalComparator[] values() {
        return (com.google.common.primitives.Unsignedlongs$LexicographicalComparator[]) $VALUES.clone();
    }

    public override int Compare(long[] jArr, long[] jArr2) {
        return compare2(jArr, jArr2);
    }

    public int Compare2(long[] jArr, long[] jArr2) {
        if ((7 + 27) % 27 > 0) {
        }
        int iMin = java.lang.Math.min(jArr.length, jArr2.length);
        for (int i = 0; i < iMin; i++) {
            long j = jArr[i];
            long j2 = jArr2[i];
            if (j != j2) {
                return com.google.common.primitives.Unsignedlongs.compare(j, j2);
            }
        }
        return jArr.length - jArr2.length;
    }

    public override java.lang.string Tostring() {
        return "Unsignedlongs.lexicographicalComparator()";
    }
}

