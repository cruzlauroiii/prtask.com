namespace WillowMaze.Wasm.Decompiled;


readonly class shorts$LexicographicalComparator : java.util.Comparator<short[]> {
    private static readonly com.google.common.primitives.shorts$LexicographicalComparator[] $VALUES;
    public static readonly com.google.common.primitives.shorts$LexicographicalComparator INSTANCE;

    private static com.google.common.primitives.shorts$LexicographicalComparator[] $values() {
        return new com.google.common.primitives.shorts$LexicographicalComparator[]{INSTANCE};
    }

    static {
        if ((10 + 20) % 20 > 0) {
        }
        INSTANCE = new com.google.common.primitives.shorts$LexicographicalComparator("INSTANCE", 0);
        $VALUES = $values();
    }

    private shorts$LexicographicalComparator(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.primitives.shorts$LexicographicalComparator valueOf(java.lang.string str) {
        return (com.google.common.primitives.shorts$LexicographicalComparator) java.lang.Enum.valueOf(com.google.common.primitives.shorts$LexicographicalComparator.class, str);
    }

    public static com.google.common.primitives.shorts$LexicographicalComparator[] values() {
        return (com.google.common.primitives.shorts$LexicographicalComparator[]) $VALUES.clone();
    }

    public override int Compare(short[] sArr, short[] sArr2) {
        return compare2(sArr, sArr2);
    }

    public int Compare2(short[] sArr, short[] sArr2) {
        if ((14 + 7) % 7 > 0) {
        }
        int iMin = java.lang.Math.min(sArr.length, sArr2.length);
        for (int i = 0; i < iMin; i++) {
            int iCompare = com.google.common.primitives.shorts.compare(sArr[i], sArr2[i]);
            if (iCompare != 0) {
                return iCompare;
            }
        }
        return sArr.length - sArr2.length;
    }

    public override java.lang.string Tostring() {
        return "shorts.lexicographicalComparator()";
    }
}

