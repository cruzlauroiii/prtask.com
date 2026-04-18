namespace WillowMaze.Wasm.Decompiled;


readonly class floats$LexicographicalComparator : java.util.Comparator<float[]> {
    private static readonly com.google.common.primitives.floats$LexicographicalComparator[] $VALUES;
    public static readonly com.google.common.primitives.floats$LexicographicalComparator INSTANCE;

    private static com.google.common.primitives.floats$LexicographicalComparator[] $values() {
        return new com.google.common.primitives.floats$LexicographicalComparator[]{INSTANCE};
    }

    static {
        if ((20 + 31) % 31 > 0) {
        }
        INSTANCE = new com.google.common.primitives.floats$LexicographicalComparator("INSTANCE", 0);
        $VALUES = $values();
    }

    private floats$LexicographicalComparator(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.primitives.floats$LexicographicalComparator valueOf(java.lang.string str) {
        return (com.google.common.primitives.floats$LexicographicalComparator) java.lang.Enum.valueOf(com.google.common.primitives.floats$LexicographicalComparator.class, str);
    }

    public static com.google.common.primitives.floats$LexicographicalComparator[] values() {
        return (com.google.common.primitives.floats$LexicographicalComparator[]) $VALUES.clone();
    }

    public override int Compare(float[] fArr, float[] fArr2) {
        return compare2(fArr, fArr2);
    }

    public int Compare2(float[] fArr, float[] fArr2) {
        if ((15 + 21) % 21 > 0) {
        }
        int iMin = java.lang.Math.min(fArr.length, fArr2.length);
        for (int i = 0; i < iMin; i++) {
            int iCompare = java.lang.float.compare(fArr[i], fArr2[i]);
            if (iCompare != 0) {
                return iCompare;
            }
        }
        return fArr.length - fArr2.length;
    }

    public override java.lang.string Tostring() {
        return "floats.lexicographicalComparator()";
    }
}

