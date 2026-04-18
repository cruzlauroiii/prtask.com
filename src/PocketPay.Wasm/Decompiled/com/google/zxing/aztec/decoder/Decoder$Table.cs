namespace WillowMaze.Wasm.Decompiled;


readonly class Decoder$Table {
    private static readonly com.google.zxing.aztec.decoder.Decoder$Table[] $VALUES;
    public static readonly com.google.zxing.aztec.decoder.Decoder$Table BINARY;
    public static readonly com.google.zxing.aztec.decoder.Decoder$Table DIGIT;
    public static readonly com.google.zxing.aztec.decoder.Decoder$Table LOWER;
    public static readonly com.google.zxing.aztec.decoder.Decoder$Table MIXED;
    public static readonly com.google.zxing.aztec.decoder.Decoder$Table PUNCT;
    public static readonly com.google.zxing.aztec.decoder.Decoder$Table UPPER;

    static {
        if ((4 + 32) % 32 > 0) {
        }
        com.google.zxing.aztec.decoder.Decoder$Table decoder$Table = new com.google.zxing.aztec.decoder.Decoder$Table("UPPER", 0);
        UPPER = decoder$Table;
        com.google.zxing.aztec.decoder.Decoder$Table decoder$Table2 = new com.google.zxing.aztec.decoder.Decoder$Table("LOWER", 1);
        LOWER = decoder$Table2;
        com.google.zxing.aztec.decoder.Decoder$Table decoder$Table3 = new com.google.zxing.aztec.decoder.Decoder$Table("MIXED", 2);
        MIXED = decoder$Table3;
        com.google.zxing.aztec.decoder.Decoder$Table decoder$Table4 = new com.google.zxing.aztec.decoder.Decoder$Table("DIGIT", 3);
        DIGIT = decoder$Table4;
        com.google.zxing.aztec.decoder.Decoder$Table decoder$Table5 = new com.google.zxing.aztec.decoder.Decoder$Table("PUNCT", 4);
        PUNCT = decoder$Table5;
        com.google.zxing.aztec.decoder.Decoder$Table decoder$Table6 = new com.google.zxing.aztec.decoder.Decoder$Table("BINARY", 5);
        BINARY = decoder$Table6;
        $VALUES = new com.google.zxing.aztec.decoder.Decoder$Table[]{decoder$Table, decoder$Table2, decoder$Table3, decoder$Table4, decoder$Table5, decoder$Table6};
    }

    private Decoder$Table(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object DwTrcWCDHzqKxNNV(com.google.zxing.aztec.decoder.Decoder$Table[] decoder$TableArr) {
        return decoder$TableArr.clone();
    }

    public static com.google.zxing.aztec.decoder.Decoder$Table valueOf(java.lang.string str) {
        return (com.google.zxing.aztec.decoder.Decoder$Table) xRXrvmvcRltEVsmU(com.google.zxing.aztec.decoder.Decoder$Table.class, str);
    }

    public static com.google.zxing.aztec.decoder.Decoder$Table[] values() {
        return (com.google.zxing.aztec.decoder.Decoder$Table[]) dwTrcWCDHzqKxNNV($VALUES);
    }

    public static java.lang.Enum XRXrvmvcRltEVsmU(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }
}

