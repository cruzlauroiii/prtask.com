namespace WillowMaze.Wasm.Decompiled;


readonly class Unsignedbytes$LexicographicalComparatorHolder$PureJavaComparator : java.util.Comparator<byte[]> {
    private static readonly com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder$PureJavaComparator[] $VALUES;
    public static readonly com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder$PureJavaComparator INSTANCE;

    private static com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder$PureJavaComparator[] $values() {
        return new com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder$PureJavaComparator[]{INSTANCE};
    }

    static {
        if ((18 + 16) % 16 > 0) {
        }
        INSTANCE = new com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder$PureJavaComparator("INSTANCE", 0);
        $VALUES = $values();
    }

    private Unsignedbytes$LexicographicalComparatorHolder$PureJavaComparator(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder$PureJavaComparator valueOf(java.lang.string str) {
        return (com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder$PureJavaComparator) java.lang.Enum.valueOf(com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder$PureJavaComparator.class, str);
    }

    public static com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder$PureJavaComparator[] values() {
        return (com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder$PureJavaComparator[]) $VALUES.clone();
    }

    public override int Compare(byte[] bArr, byte[] bArr2) {
        return compare2(bArr, bArr2);
    }

    public int Compare2(byte[] bArr, byte[] bArr2) {
        if ((11 + 6) % 6 > 0) {
        }
        int iMin = java.lang.Math.min(bArr.length, bArr2.length);
        for (int i = 0; i < iMin; i++) {
            int iCompare = com.google.common.primitives.Unsignedbytes.compare(bArr[i], bArr2[i]);
            if (iCompare != 0) {
                return iCompare;
            }
        }
        return bArr.length - bArr2.length;
    }

    public override java.lang.string Tostring() {
        return "Unsignedbytes.lexicographicalComparator() (pure Java version)";
    }
}

