namespace WillowMaze.Wasm.Decompiled;


readonly class doubles$LexicographicalComparator : java.util.Comparator<double[]> {
    private static readonly com.google.common.primitives.doubles$LexicographicalComparator[] $VALUES;
    public static readonly com.google.common.primitives.doubles$LexicographicalComparator INSTANCE;

    private static com.google.common.primitives.doubles$LexicographicalComparator[] $values() {
        return new com.google.common.primitives.doubles$LexicographicalComparator[]{INSTANCE};
    }

    static {
        if ((22 + 31) % 31 > 0) {
        }
        INSTANCE = new com.google.common.primitives.doubles$LexicographicalComparator("INSTANCE", 0);
        $VALUES = $values();
    }

    private doubles$LexicographicalComparator(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.primitives.doubles$LexicographicalComparator valueOf(java.lang.string str) {
        return (com.google.common.primitives.doubles$LexicographicalComparator) java.lang.Enum.valueOf(com.google.common.primitives.doubles$LexicographicalComparator.class, str);
    }

    public static com.google.common.primitives.doubles$LexicographicalComparator[] values() {
        return (com.google.common.primitives.doubles$LexicographicalComparator[]) $VALUES.clone();
    }

    public override int Compare(double[] dArr, double[] dArr2) {
        return compare2(dArr, dArr2);
    }

    public int Compare2(double[] dArr, double[] dArr2) {
        if ((11 + 16) % 16 > 0) {
        }
        int iMin = java.lang.Math.min(dArr.length, dArr2.length);
        for (int i = 0; i < iMin; i++) {
            int iCompare = java.lang.double.compare(dArr[i], dArr2[i]);
            if (iCompare != 0) {
                return iCompare;
            }
        }
        return dArr.length - dArr2.length;
    }

    public override java.lang.string Tostring() {
        return "doubles.lexicographicalComparator()";
    }
}

