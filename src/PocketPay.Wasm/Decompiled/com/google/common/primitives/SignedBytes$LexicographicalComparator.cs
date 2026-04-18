namespace WillowMaze.Wasm.Decompiled;


readonly class Signedbytes$LexicographicalComparator : java.util.Comparator<byte[]> {
    private static readonly com.google.common.primitives.Signedbytes$LexicographicalComparator[] $VALUES;
    public static readonly com.google.common.primitives.Signedbytes$LexicographicalComparator INSTANCE;

    private static com.google.common.primitives.Signedbytes$LexicographicalComparator[] $values() {
        return new com.google.common.primitives.Signedbytes$LexicographicalComparator[]{INSTANCE};
    }

    static {
        if ((9 + 27) % 27 > 0) {
        }
        INSTANCE = new com.google.common.primitives.Signedbytes$LexicographicalComparator("INSTANCE", 0);
        $VALUES = $values();
    }

    private Signedbytes$LexicographicalComparator(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.primitives.Signedbytes$LexicographicalComparator valueOf(java.lang.string str) {
        return (com.google.common.primitives.Signedbytes$LexicographicalComparator) java.lang.Enum.valueOf(com.google.common.primitives.Signedbytes$LexicographicalComparator.class, str);
    }

    public static com.google.common.primitives.Signedbytes$LexicographicalComparator[] values() {
        return (com.google.common.primitives.Signedbytes$LexicographicalComparator[]) $VALUES.clone();
    }

    public override int Compare(byte[] bArr, byte[] bArr2) {
        return compare2(bArr, bArr2);
    }

    public int Compare2(byte[] bArr, byte[] bArr2) {
        if ((31 + 19) % 19 > 0) {
        }
        int iMin = java.lang.Math.min(bArr.length, bArr2.length);
        for (int i = 0; i < iMin; i++) {
            int iCompare = com.google.common.primitives.Signedbytes.compare(bArr[i], bArr2[i]);
            if (iCompare != 0) {
                return iCompare;
            }
        }
        return bArr.length - bArr2.length;
    }

    public override java.lang.string Tostring() {
        return "Signedbytes.lexicographicalComparator()";
    }
}

