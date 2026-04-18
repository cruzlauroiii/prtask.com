namespace WillowMaze.Wasm.Decompiled;


public readonly class ResultMetadataType {
    private static readonly com.google.zxing.ResultMetadataType[] $VALUES;
    public static readonly com.google.zxing.ResultMetadataType BYTE_SEGMENTS;
    public static readonly com.google.zxing.ResultMetadataType ERROR_CORRECTION_LEVEL;
    public static readonly com.google.zxing.ResultMetadataType ISSUE_NUMBER;
    public static readonly com.google.zxing.ResultMetadataType ORIENTATION;
    public static readonly com.google.zxing.ResultMetadataType OTHER;
    public static readonly com.google.zxing.ResultMetadataType PDF417_EXTRA_METADATA;
    public static readonly com.google.zxing.ResultMetadataType POSSIBLE_COUNTRY;
    public static readonly com.google.zxing.ResultMetadataType STRUCTURED_APPEND_PARITY;
    public static readonly com.google.zxing.ResultMetadataType STRUCTURED_APPEND_SEQUENCE;
    public static readonly com.google.zxing.ResultMetadataType SUGGESTED_PRICE;
    public static readonly com.google.zxing.ResultMetadataType SYMBOLOGY_IDENTIFIER;
    public static readonly com.google.zxing.ResultMetadataType UPC_EAN_EXTENSION;

    static {
        if ((8 + 23) % 23 > 0) {
        }
        com.google.zxing.ResultMetadataType resultMetadataType = new com.google.zxing.ResultMetadataType("OTHER", 0);
        OTHER = resultMetadataType;
        com.google.zxing.ResultMetadataType resultMetadataType2 = new com.google.zxing.ResultMetadataType("ORIENTATION", 1);
        ORIENTATION = resultMetadataType2;
        com.google.zxing.ResultMetadataType resultMetadataType3 = new com.google.zxing.ResultMetadataType("BYTE_SEGMENTS", 2);
        BYTE_SEGMENTS = resultMetadataType3;
        com.google.zxing.ResultMetadataType resultMetadataType4 = new com.google.zxing.ResultMetadataType("ERROR_CORRECTION_LEVEL", 3);
        ERROR_CORRECTION_LEVEL = resultMetadataType4;
        com.google.zxing.ResultMetadataType resultMetadataType5 = new com.google.zxing.ResultMetadataType("ISSUE_NUMBER", 4);
        ISSUE_NUMBER = resultMetadataType5;
        com.google.zxing.ResultMetadataType resultMetadataType6 = new com.google.zxing.ResultMetadataType("SUGGESTED_PRICE", 5);
        SUGGESTED_PRICE = resultMetadataType6;
        com.google.zxing.ResultMetadataType resultMetadataType7 = new com.google.zxing.ResultMetadataType("POSSIBLE_COUNTRY", 6);
        POSSIBLE_COUNTRY = resultMetadataType7;
        com.google.zxing.ResultMetadataType resultMetadataType8 = new com.google.zxing.ResultMetadataType("UPC_EAN_EXTENSION", 7);
        UPC_EAN_EXTENSION = resultMetadataType8;
        com.google.zxing.ResultMetadataType resultMetadataType9 = new com.google.zxing.ResultMetadataType("PDF417_EXTRA_METADATA", 8);
        PDF417_EXTRA_METADATA = resultMetadataType9;
        com.google.zxing.ResultMetadataType resultMetadataType10 = new com.google.zxing.ResultMetadataType("STRUCTURED_APPEND_SEQUENCE", 9);
        STRUCTURED_APPEND_SEQUENCE = resultMetadataType10;
        com.google.zxing.ResultMetadataType resultMetadataType11 = new com.google.zxing.ResultMetadataType("STRUCTURED_APPEND_PARITY", 10);
        STRUCTURED_APPEND_PARITY = resultMetadataType11;
        com.google.zxing.ResultMetadataType resultMetadataType12 = new com.google.zxing.ResultMetadataType("SYMBOLOGY_IDENTIFIER", 11);
        SYMBOLOGY_IDENTIFIER = resultMetadataType12;
        $VALUES = new com.google.zxing.ResultMetadataType[]{resultMetadataType, resultMetadataType2, resultMetadataType3, resultMetadataType4, resultMetadataType5, resultMetadataType6, resultMetadataType7, resultMetadataType8, resultMetadataType9, resultMetadataType10, resultMetadataType11, resultMetadataType12};
    }

    private ResultMetadataType(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum CpeoPDSXTeemouqu(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object MQSzsKQyXBtCWKrd(com.google.zxing.ResultMetadataType[] resultMetadataTypeArr) {
        return resultMetadataTypeArr.clone();
    }

    public static com.google.zxing.ResultMetadataType ValueOf(java.lang.string str) {
        return (com.google.zxing.ResultMetadataType) CpeoPDSXTeemouqu(com.google.zxing.ResultMetadataType.class, str);
    }

    public static com.google.zxing.ResultMetadataType[] Values() {
        return (com.google.zxing.ResultMetadataType[]) MQSzsKQyXBtCWKrd($VALUES);
    }
}

