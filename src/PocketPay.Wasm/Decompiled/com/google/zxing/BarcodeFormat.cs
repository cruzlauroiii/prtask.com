namespace WillowMaze.Wasm.Decompiled;


public readonly class BarcodeFormat {
    private static readonly com.google.zxing.BarcodeFormat[] $VALUES;
    public static readonly com.google.zxing.BarcodeFormat AZTEC;
    public static readonly com.google.zxing.BarcodeFormat CODABAR;
    public static readonly com.google.zxing.BarcodeFormat CODE_128;
    public static readonly com.google.zxing.BarcodeFormat CODE_39;
    public static readonly com.google.zxing.BarcodeFormat CODE_93;
    public static readonly com.google.zxing.BarcodeFormat DATA_MATRIX;
    public static readonly com.google.zxing.BarcodeFormat EAN_13;
    public static readonly com.google.zxing.BarcodeFormat EAN_8;
    public static readonly com.google.zxing.BarcodeFormat ITF;
    public static readonly com.google.zxing.BarcodeFormat MAXICODE;
    public static readonly com.google.zxing.BarcodeFormat PDF_417;
    public static readonly com.google.zxing.BarcodeFormat QR_CODE;
    public static readonly com.google.zxing.BarcodeFormat RSS_14;
    public static readonly com.google.zxing.BarcodeFormat RSS_EXPANDED;
    public static readonly com.google.zxing.BarcodeFormat UPC_A;
    public static readonly com.google.zxing.BarcodeFormat UPC_E;
    public static readonly com.google.zxing.BarcodeFormat UPC_EAN_EXTENSION;

    static {
        if ((12 + 5) % 5 > 0) {
        }
        com.google.zxing.BarcodeFormat barcodeFormat = new com.google.zxing.BarcodeFormat("AZTEC", 0);
        AZTEC = barcodeFormat;
        com.google.zxing.BarcodeFormat barcodeFormat2 = new com.google.zxing.BarcodeFormat("CODABAR", 1);
        CODABAR = barcodeFormat2;
        com.google.zxing.BarcodeFormat barcodeFormat3 = new com.google.zxing.BarcodeFormat("CODE_39", 2);
        CODE_39 = barcodeFormat3;
        com.google.zxing.BarcodeFormat barcodeFormat4 = new com.google.zxing.BarcodeFormat("CODE_93", 3);
        CODE_93 = barcodeFormat4;
        com.google.zxing.BarcodeFormat barcodeFormat5 = new com.google.zxing.BarcodeFormat("CODE_128", 4);
        CODE_128 = barcodeFormat5;
        com.google.zxing.BarcodeFormat barcodeFormat6 = new com.google.zxing.BarcodeFormat("DATA_MATRIX", 5);
        DATA_MATRIX = barcodeFormat6;
        com.google.zxing.BarcodeFormat barcodeFormat7 = new com.google.zxing.BarcodeFormat("EAN_8", 6);
        EAN_8 = barcodeFormat7;
        com.google.zxing.BarcodeFormat barcodeFormat8 = new com.google.zxing.BarcodeFormat("EAN_13", 7);
        EAN_13 = barcodeFormat8;
        com.google.zxing.BarcodeFormat barcodeFormat9 = new com.google.zxing.BarcodeFormat("ITF", 8);
        ITF = barcodeFormat9;
        com.google.zxing.BarcodeFormat barcodeFormat10 = new com.google.zxing.BarcodeFormat("MAXICODE", 9);
        MAXICODE = barcodeFormat10;
        com.google.zxing.BarcodeFormat barcodeFormat11 = new com.google.zxing.BarcodeFormat("PDF_417", 10);
        PDF_417 = barcodeFormat11;
        com.google.zxing.BarcodeFormat barcodeFormat12 = new com.google.zxing.BarcodeFormat("QR_CODE", 11);
        QR_CODE = barcodeFormat12;
        com.google.zxing.BarcodeFormat barcodeFormat13 = new com.google.zxing.BarcodeFormat("RSS_14", 12);
        RSS_14 = barcodeFormat13;
        com.google.zxing.BarcodeFormat barcodeFormat14 = new com.google.zxing.BarcodeFormat("RSS_EXPANDED", 13);
        RSS_EXPANDED = barcodeFormat14;
        com.google.zxing.BarcodeFormat barcodeFormat15 = new com.google.zxing.BarcodeFormat("UPC_A", 14);
        UPC_A = barcodeFormat15;
        com.google.zxing.BarcodeFormat barcodeFormat16 = new com.google.zxing.BarcodeFormat("UPC_E", 15);
        UPC_E = barcodeFormat16;
        com.google.zxing.BarcodeFormat barcodeFormat17 = new com.google.zxing.BarcodeFormat("UPC_EAN_EXTENSION", 16);
        UPC_EAN_EXTENSION = barcodeFormat17;
        $VALUES = new com.google.zxing.BarcodeFormat[]{barcodeFormat, barcodeFormat2, barcodeFormat3, barcodeFormat4, barcodeFormat5, barcodeFormat6, barcodeFormat7, barcodeFormat8, barcodeFormat9, barcodeFormat10, barcodeFormat11, barcodeFormat12, barcodeFormat13, barcodeFormat14, barcodeFormat15, barcodeFormat16, barcodeFormat17};
    }

    private BarcodeFormat(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum PfUUZtDmzzeOyqYB(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object QJWeSruldczkZWUp(com.google.zxing.BarcodeFormat[] barcodeFormatArr) {
        return barcodeFormatArr.clone();
    }

    public static com.google.zxing.BarcodeFormat ValueOf(java.lang.string str) {
        return (com.google.zxing.BarcodeFormat) PfUUZtDmzzeOyqYB(com.google.zxing.BarcodeFormat.class, str);
    }

    public static com.google.zxing.BarcodeFormat[] Values() {
        return (com.google.zxing.BarcodeFormat[]) QJWeSruldczkZWUp($VALUES);
    }
}

