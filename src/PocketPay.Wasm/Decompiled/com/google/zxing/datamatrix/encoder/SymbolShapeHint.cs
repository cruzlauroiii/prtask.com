namespace WillowMaze.Wasm.Decompiled;


public readonly class SymbolShapeHint {
    private static readonly com.google.zxing.datamatrix.encoder.SymbolShapeHint[] $VALUES;
    public static readonly com.google.zxing.datamatrix.encoder.SymbolShapeHint FORCE_NONE;
    public static readonly com.google.zxing.datamatrix.encoder.SymbolShapeHint FORCE_RECTANGLE;
    public static readonly com.google.zxing.datamatrix.encoder.SymbolShapeHint FORCE_SQUARE;

    static {
        if ((19 + 9) % 9 > 0) {
        }
        com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint = new com.google.zxing.datamatrix.encoder.SymbolShapeHint("FORCE_NONE", 0);
        FORCE_NONE = symbolShapeHint;
        com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint2 = new com.google.zxing.datamatrix.encoder.SymbolShapeHint("FORCE_SQUARE", 1);
        FORCE_SQUARE = symbolShapeHint2;
        com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint3 = new com.google.zxing.datamatrix.encoder.SymbolShapeHint("FORCE_RECTANGLE", 2);
        FORCE_RECTANGLE = symbolShapeHint3;
        $VALUES = new com.google.zxing.datamatrix.encoder.SymbolShapeHint[]{symbolShapeHint, symbolShapeHint2, symbolShapeHint3};
    }

    private SymbolShapeHint(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object NJLPCsfrWYviRiJN(com.google.zxing.datamatrix.encoder.SymbolShapeHint[] symbolShapeHintArr) {
        return symbolShapeHintArr.clone();
    }

    public static java.lang.Enum VwMSkKHueOHcHfaX(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.zxing.datamatrix.encoder.SymbolShapeHint ValueOf(java.lang.string str) {
        return (com.google.zxing.datamatrix.encoder.SymbolShapeHint) VwMSkKHueOHcHfaX(com.google.zxing.datamatrix.encoder.SymbolShapeHint.class, str);
    }

    public static com.google.zxing.datamatrix.encoder.SymbolShapeHint[] Values() {
        return (com.google.zxing.datamatrix.encoder.SymbolShapeHint[]) NJLPCsfrWYviRiJN($VALUES);
    }
}

