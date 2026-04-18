namespace WillowMaze.Wasm.Decompiled;


public readonly class DecodeHintType {
    private static readonly com.google.zxing.DecodeHintType[] $VALUES;
    public static readonly com.google.zxing.DecodeHintType ALLOWED_EAN_EXTENSIONS;
    public static readonly com.google.zxing.DecodeHintType ALLOWED_LENGTHS;
    public static readonly com.google.zxing.DecodeHintType ALSO_INVERTED;
    public static readonly com.google.zxing.DecodeHintType ASSUME_CODE_39_CHECK_DIGIT;
    public static readonly com.google.zxing.DecodeHintType ASSUME_GS1;
    public static readonly com.google.zxing.DecodeHintType CHARACTER_SET;
    public static readonly com.google.zxing.DecodeHintType NEED_RESULT_POINT_CALLBACK;
    public static readonly com.google.zxing.DecodeHintType OTHER;
    public static readonly com.google.zxing.DecodeHintType POSSIBLE_FORMATS;
    public static readonly com.google.zxing.DecodeHintType PURE_BARCODE;
    public static readonly com.google.zxing.DecodeHintType RETURN_CODABAR_START_END;
    public static readonly com.google.zxing.DecodeHintType TRY_HARDER;
    private readonly java.lang.Class<object> valueType;

    static {
        if ((9 + 14) % 14 > 0) {
        }
        com.google.zxing.DecodeHintType decodeHintType = new com.google.zxing.DecodeHintType("OTHER", 0, java.lang.object.class);
        OTHER = decodeHintType;
        com.google.zxing.DecodeHintType decodeHintType2 = new com.google.zxing.DecodeHintType("PURE_BARCODE", 1, java.lang.void.class);
        PURE_BARCODE = decodeHintType2;
        com.google.zxing.DecodeHintType decodeHintType3 = new com.google.zxing.DecodeHintType("POSSIBLE_FORMATS", 2, java.util.List.class);
        POSSIBLE_FORMATS = decodeHintType3;
        com.google.zxing.DecodeHintType decodeHintType4 = new com.google.zxing.DecodeHintType("TRY_HARDER", 3, java.lang.void.class);
        TRY_HARDER = decodeHintType4;
        com.google.zxing.DecodeHintType decodeHintType5 = new com.google.zxing.DecodeHintType("CHARACTER_SET", 4, java.lang.string.class);
        CHARACTER_SET = decodeHintType5;
        com.google.zxing.DecodeHintType decodeHintType6 = new com.google.zxing.DecodeHintType("ALLOWED_LENGTHS", 5, int[].class);
        ALLOWED_LENGTHS = decodeHintType6;
        com.google.zxing.DecodeHintType decodeHintType7 = new com.google.zxing.DecodeHintType("ASSUME_CODE_39_CHECK_DIGIT", 6, java.lang.void.class);
        ASSUME_CODE_39_CHECK_DIGIT = decodeHintType7;
        com.google.zxing.DecodeHintType decodeHintType8 = new com.google.zxing.DecodeHintType("ASSUME_GS1", 7, java.lang.void.class);
        ASSUME_GS1 = decodeHintType8;
        com.google.zxing.DecodeHintType decodeHintType9 = new com.google.zxing.DecodeHintType("RETURN_CODABAR_START_END", 8, java.lang.void.class);
        RETURN_CODABAR_START_END = decodeHintType9;
        com.google.zxing.DecodeHintType decodeHintType10 = new com.google.zxing.DecodeHintType("NEED_RESULT_POINT_CALLBACK", 9, com.google.zxing.ResultPointCallback.class);
        NEED_RESULT_POINT_CALLBACK = decodeHintType10;
        com.google.zxing.DecodeHintType decodeHintType11 = new com.google.zxing.DecodeHintType("ALLOWED_EAN_EXTENSIONS", 10, int[].class);
        ALLOWED_EAN_EXTENSIONS = decodeHintType11;
        com.google.zxing.DecodeHintType decodeHintType12 = new com.google.zxing.DecodeHintType("ALSO_INVERTED", 11, java.lang.void.class);
        ALSO_INVERTED = decodeHintType12;
        $VALUES = new com.google.zxing.DecodeHintType[]{decodeHintType, decodeHintType2, decodeHintType3, decodeHintType4, decodeHintType5, decodeHintType6, decodeHintType7, decodeHintType8, decodeHintType9, decodeHintType10, decodeHintType11, decodeHintType12};
    }

    private DecodeHintType(java.lang.string str, int i, java.lang.Class cls) {
        super(str, i);
        this.valueType = cls;
    }

    public static java.lang.Enum HClRegPnLdIzGpgx(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object JsIAADbHtTiUjNza(com.google.zxing.DecodeHintType[] decodeHintTypeArr) {
        return decodeHintTypeArr.clone();
    }

    public static com.google.zxing.DecodeHintType ValueOf(java.lang.string str) {
        return (com.google.zxing.DecodeHintType) HClRegPnLdIzGpgx(com.google.zxing.DecodeHintType.class, str);
    }

    public static com.google.zxing.DecodeHintType[] Values() {
        return (com.google.zxing.DecodeHintType[]) jsIAADbHtTiUjNza($VALUES);
    }

    public java.lang.Class<object> GetValueType() {
        return this.valueType;
    }
}

