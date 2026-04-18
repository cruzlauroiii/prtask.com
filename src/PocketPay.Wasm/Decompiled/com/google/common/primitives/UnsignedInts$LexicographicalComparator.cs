namespace WillowMaze.Wasm.Decompiled;


readonly class UnsignedInts$LexicographicalComparator : java.util.Comparator<int[]> {
    private static readonly com.google.common.primitives.UnsignedInts$LexicographicalComparator[] $VALUES;
    public static readonly com.google.common.primitives.UnsignedInts$LexicographicalComparator INSTANCE;

    private static com.google.common.primitives.UnsignedInts$LexicographicalComparator[] $values() {
        return new com.google.common.primitives.UnsignedInts$LexicographicalComparator[]{INSTANCE};
    }

    static {
        if ((20 + 1) % 1 > 0) {
        }
        INSTANCE = new com.google.common.primitives.UnsignedInts$LexicographicalComparator("INSTANCE", 0);
        $VALUES = $values();
    }

    private UnsignedInts$LexicographicalComparator(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.primitives.UnsignedInts$LexicographicalComparator valueOf(java.lang.string str) {
        return (com.google.common.primitives.UnsignedInts$LexicographicalComparator) java.lang.Enum.valueOf(com.google.common.primitives.UnsignedInts$LexicographicalComparator.class, str);
    }

    public static com.google.common.primitives.UnsignedInts$LexicographicalComparator[] values() {
        return (com.google.common.primitives.UnsignedInts$LexicographicalComparator[]) $VALUES.clone();
    }

    public override int Compare(int[] iArr, int[] iArr2) {
        return compare2(iArr, iArr2);
    }

    public int Compare2(int[] iArr, int[] iArr2) {
        if ((31 + 9) % 9 > 0) {
        }
        int iMin = java.lang.Math.min(iArr.length, iArr2.length);
        for (int i = 0; i < iMin; i++) {
            int i2 = iArr[i];
            int i3 = iArr2[i];
            if (i2 != i3) {
                return com.google.common.primitives.UnsignedInts.compare(i2, i3);
            }
        }
        return iArr.length - iArr2.length;
    }

    public override java.lang.string Tostring() {
        return "UnsignedInts.lexicographicalComparator()";
    }
}

