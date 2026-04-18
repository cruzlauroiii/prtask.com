namespace WillowMaze.Wasm.Decompiled;


readonly class MinimalEncoder$Input : com.google.zxing.common.MinimalECIInput {
    private readonly int macroId;
    private readonly com.google.zxing.datamatrix.encoder.SymbolShapeHint shape;

    private MinimalEncoder$Input(java.lang.string str, java.nio.charset.Charset charset, int i, com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint, int i2) {
        super(str, charset, i);
        this.shape = symbolShapeHint;
        this.macroId = i2;
    }

    MinimalEncoder$Input(java.lang.string str, java.nio.charset.Charset charset, int i, com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint, int i2, com.google.zxing.datamatrix.encoder.MinimalEncoder$1 minimalEncoder$1) {
        this(str, charset, i, symbolShapeHint, i2);
    }

    public static int LkfRvpOuDHdgWTkx(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return minimalEncoder$Input.getMacroId();
    }

    static int access$1300(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return LkfRvpOuDHdgWTkx(minimalEncoder$Input);
    }

    static com.google.zxing.datamatrix.encoder.SymbolShapeHint access$500(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return dtRkzNfKWLRhAXVp(minimalEncoder$Input);
    }

    public static com.google.zxing.datamatrix.encoder.SymbolShapeHint DtRkzNfKWLRhAXVp(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return minimalEncoder$Input.getShapeHint();
    }

    private int GetMacroId() {
        return this.macroId;
    }

    private com.google.zxing.datamatrix.encoder.SymbolShapeHint GetShapeHint() {
        return this.shape;
    }
}

