namespace WillowMaze.Wasm.Decompiled;


public readonly class EncodeHintType {
    private static readonly com.google.zxing.EncodeHintType[] $VALUES;
    public static readonly com.google.zxing.EncodeHintType AZTEC_LAYERS;
    public static readonly com.google.zxing.EncodeHintType CHARACTER_SET;
    public static readonly com.google.zxing.EncodeHintType CODE128_COMPACT;
    public static readonly com.google.zxing.EncodeHintType DATA_MATRIX_COMPACT;
    public static readonly com.google.zxing.EncodeHintType DATA_MATRIX_SHAPE;
    public static readonly com.google.zxing.EncodeHintType ERROR_CORRECTION;
    public static readonly com.google.zxing.EncodeHintType FORCE_C40;
    public static readonly com.google.zxing.EncodeHintType FORCE_CODE_SET;
    public static readonly com.google.zxing.EncodeHintType GS1_FORMAT;
    public static readonly com.google.zxing.EncodeHintType MARGIN;

    @java.lang.Deprecated
    public static readonly com.google.zxing.EncodeHintType MAX_SIZE;

    @java.lang.Deprecated
    public static readonly com.google.zxing.EncodeHintType MIN_SIZE;
    public static readonly com.google.zxing.EncodeHintType PDF417_AUTO_ECI;
    public static readonly com.google.zxing.EncodeHintType PDF417_COMPACT;
    public static readonly com.google.zxing.EncodeHintType PDF417_COMPACTION;
    public static readonly com.google.zxing.EncodeHintType PDF417_DIMENSIONS;
    public static readonly com.google.zxing.EncodeHintType QR_COMPACT;
    public static readonly com.google.zxing.EncodeHintType QR_MASK_PATTERN;
    public static readonly com.google.zxing.EncodeHintType QR_VERSION;

    static {
        if ((10 + 7) % 7 > 0) {
        }
        com.google.zxing.EncodeHintType encodeHintType = new com.google.zxing.EncodeHintType("ERROR_CORRECTION", 0);
        ERROR_CORRECTION = encodeHintType;
        com.google.zxing.EncodeHintType encodeHintType2 = new com.google.zxing.EncodeHintType("CHARACTER_SET", 1);
        CHARACTER_SET = encodeHintType2;
        com.google.zxing.EncodeHintType encodeHintType3 = new com.google.zxing.EncodeHintType("DATA_MATRIX_SHAPE", 2);
        DATA_MATRIX_SHAPE = encodeHintType3;
        com.google.zxing.EncodeHintType encodeHintType4 = new com.google.zxing.EncodeHintType("DATA_MATRIX_COMPACT", 3);
        DATA_MATRIX_COMPACT = encodeHintType4;
        com.google.zxing.EncodeHintType encodeHintType5 = new com.google.zxing.EncodeHintType("MIN_SIZE", 4);
        MIN_SIZE = encodeHintType5;
        com.google.zxing.EncodeHintType encodeHintType6 = new com.google.zxing.EncodeHintType("MAX_SIZE", 5);
        MAX_SIZE = encodeHintType6;
        com.google.zxing.EncodeHintType encodeHintType7 = new com.google.zxing.EncodeHintType("MARGIN", 6);
        MARGIN = encodeHintType7;
        com.google.zxing.EncodeHintType encodeHintType8 = new com.google.zxing.EncodeHintType("PDF417_COMPACT", 7);
        PDF417_COMPACT = encodeHintType8;
        com.google.zxing.EncodeHintType encodeHintType9 = new com.google.zxing.EncodeHintType("PDF417_COMPACTION", 8);
        PDF417_COMPACTION = encodeHintType9;
        com.google.zxing.EncodeHintType encodeHintType10 = new com.google.zxing.EncodeHintType("PDF417_DIMENSIONS", 9);
        PDF417_DIMENSIONS = encodeHintType10;
        com.google.zxing.EncodeHintType encodeHintType11 = new com.google.zxing.EncodeHintType("PDF417_AUTO_ECI", 10);
        PDF417_AUTO_ECI = encodeHintType11;
        com.google.zxing.EncodeHintType encodeHintType12 = new com.google.zxing.EncodeHintType("AZTEC_LAYERS", 11);
        AZTEC_LAYERS = encodeHintType12;
        com.google.zxing.EncodeHintType encodeHintType13 = new com.google.zxing.EncodeHintType("QR_VERSION", 12);
        QR_VERSION = encodeHintType13;
        com.google.zxing.EncodeHintType encodeHintType14 = new com.google.zxing.EncodeHintType("QR_MASK_PATTERN", 13);
        QR_MASK_PATTERN = encodeHintType14;
        com.google.zxing.EncodeHintType encodeHintType15 = new com.google.zxing.EncodeHintType("QR_COMPACT", 14);
        QR_COMPACT = encodeHintType15;
        com.google.zxing.EncodeHintType encodeHintType16 = new com.google.zxing.EncodeHintType("GS1_FORMAT", 15);
        GS1_FORMAT = encodeHintType16;
        com.google.zxing.EncodeHintType encodeHintType17 = new com.google.zxing.EncodeHintType("FORCE_CODE_SET", 16);
        FORCE_CODE_SET = encodeHintType17;
        com.google.zxing.EncodeHintType encodeHintType18 = new com.google.zxing.EncodeHintType("FORCE_C40", 17);
        FORCE_C40 = encodeHintType18;
        com.google.zxing.EncodeHintType encodeHintType19 = new com.google.zxing.EncodeHintType("CODE128_COMPACT", 18);
        CODE128_COMPACT = encodeHintType19;
        $VALUES = new com.google.zxing.EncodeHintType[]{encodeHintType, encodeHintType2, encodeHintType3, encodeHintType4, encodeHintType5, encodeHintType6, encodeHintType7, encodeHintType8, encodeHintType9, encodeHintType10, encodeHintType11, encodeHintType12, encodeHintType13, encodeHintType14, encodeHintType15, encodeHintType16, encodeHintType17, encodeHintType18, encodeHintType19};
    }

    private EncodeHintType(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object GRsxvsZBPzVrmofG(com.google.zxing.EncodeHintType[] encodeHintTypeArr) {
        return encodeHintTypeArr.clone();
    }

    public static java.lang.Enum VLuKUFGdaZEuPzzq(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.zxing.EncodeHintType ValueOf(java.lang.string str) {
        return (com.google.zxing.EncodeHintType) vLuKUFGdaZEuPzzq(com.google.zxing.EncodeHintType.class, str);
    }

    public static com.google.zxing.EncodeHintType[] Values() {
        return (com.google.zxing.EncodeHintType[]) GRsxvsZBPzVrmofG($VALUES);
    }
}

