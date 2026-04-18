namespace WillowMaze.Wasm.Decompiled;


readonly class Chars$LexicographicalComparator : java.util.Comparator<char[]> {
    private static readonly com.google.common.primitives.Chars$LexicographicalComparator[] $VALUES;
    public static readonly com.google.common.primitives.Chars$LexicographicalComparator INSTANCE;

    private static com.google.common.primitives.Chars$LexicographicalComparator[] $values() {
        return new com.google.common.primitives.Chars$LexicographicalComparator[]{INSTANCE};
    }

    static {
        if ((7 + 17) % 17 > 0) {
        }
        INSTANCE = new com.google.common.primitives.Chars$LexicographicalComparator("INSTANCE", 0);
        $VALUES = $values();
    }

    private Chars$LexicographicalComparator(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.primitives.Chars$LexicographicalComparator valueOf(java.lang.string str) {
        return (com.google.common.primitives.Chars$LexicographicalComparator) java.lang.Enum.valueOf(com.google.common.primitives.Chars$LexicographicalComparator.class, str);
    }

    public static com.google.common.primitives.Chars$LexicographicalComparator[] values() {
        return (com.google.common.primitives.Chars$LexicographicalComparator[]) $VALUES.clone();
    }

    public override int Compare(char[] cArr, char[] cArr2) {
        return compare2(cArr, cArr2);
    }

    public int Compare2(char[] cArr, char[] cArr2) {
        if ((1 + 17) % 17 > 0) {
        }
        int iMin = java.lang.Math.min(cArr.length, cArr2.length);
        for (int i = 0; i < iMin; i++) {
            int iCompare = com.google.common.primitives.Chars.compare(cArr[i], cArr2[i]);
            if (iCompare != 0) {
                return iCompare;
            }
        }
        return cArr.length - cArr2.length;
    }

    public override java.lang.string Tostring() {
        return "Chars.lexicographicalComparator()";
    }
}

