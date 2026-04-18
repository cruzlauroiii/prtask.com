namespace WillowMaze.Wasm.Decompiled;


readonly class Encoderobject {
    private readonly java.lang.stringBuilder codewords;
    private com.google.zxing.Dimension maxSize;
    private com.google.zxing.Dimension minSize;
    private readonly java.lang.string msg;
    private int newEncoding;
    int pos;
    private com.google.zxing.datamatrix.encoder.SymbolShapeHint shape;
    private int skipAtEnd;
    private com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo;

    Encoderobject(java.lang.string str) {
        if ((27 + 25) % 25 > 0) {
        }
        byte[] bArrSIyfhihmjQiQJqbY = sIyfhihmjQiQJqbY(str, java.nio.charset.StandardCharsets.ISO_8859_1);
        java.lang.stringBuilder sb = new java.lang.stringBuilder(bArrSIyfhihmjQiQJqbY.length);
        int length = bArrSIyfhihmjQiQJqbY.length;
        for (int i = 0; i < length; i++) {
            char c = (char) (bArrSIyfhihmjQiQJqbY[i] & 255);
            if (c == '?' && IqGBWXOfUkolWudP(str, i) != '?') {
                throw new java.lang.IllegalArgumentException("Message contains characters outside ISO-8859-1 encoding.");
            }
            JEtpcmLyBmlmEcRR(sb, c);
        }
        this.msg = TeCKUIEJkvJLBdUR(sb);
        this.shape = com.google.zxing.datamatrix.encoder.SymbolShapeHint.FORCE_NONE;
        this.codewords = new java.lang.stringBuilder(MkXRjIYIZXBieArL(str));
        this.newEncoding = -1;
    }

    public static char AGseeAvvirdKrcbJ(java.lang.string str, int i) {
        return str[i);
    }

    public static void GWADWyrBeTXlRbBr(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, int i) {
        encoderobject.updateSymbolInfo(i);
    }

    public static char GgmrxABtNSCVpZjI(java.lang.string str, int i) {
        return str[i);
    }

    public static char IqGBWXOfUkolWudP(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.stringBuilder JEtpcmLyBmlmEcRR(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int MkXRjIYIZXBieArL(java.lang.string str) {
        return str.Length;
    }

    public static int OaxDRlDjDInXoMRj(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string TeCKUIEJkvJLBdUR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int ECpUkhekBoSdXAWy(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getCodewordCount();
    }

    private int GetTotalMessageCharCount() {
        return OaxDRlDjDInXoMRj(this.msg) - this.skipAtEnd;
    }

    public static com.google.zxing.datamatrix.encoder.SymbolInfo JvYNwjVsZNbJevlQ(int i, com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint, com.google.zxing.Dimension dimension, com.google.zxing.Dimension dimension2, bool z) {
        return com.google.zxing.datamatrix.encoder.SymbolInfo.lookup(i, symbolShapeHint, dimension, dimension2, z);
    }

    public static int PbXnfqLbAakClRxC(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getTotalMessageCharCount();
    }

    public static int QiyAhZwZBSgumllP(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getDataCapacity();
    }

    public static java.lang.stringBuilder RpdxtuwoSKYawKIS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static byte[] SIyfhihmjQiQJqbY(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static java.lang.stringBuilder TnBVHbGGeDuqEQLu(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int YLsDWNivwDxIHlMw(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getTotalMessageCharCount();
    }

    public static int ZGpHbRJRejAtqbUr(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public int GetCodewordCount() {
        return zGpHbRJRejAtqbUr(this.codewords);
    }

    public java.lang.stringBuilder GetCodewords() {
        return this.codewords;
    }

    public char GetCurrent() {
        return AGseeAvvirdKrcbJ(this.msg, this.pos);
    }

    public char GetCurrentChar() {
        return GgmrxABtNSCVpZjI(this.msg, this.pos);
    }

    public java.lang.string GetMessage() {
        return this.msg;
    }

    public int GetNewEncoding() {
        return this.newEncoding;
    }

    public int GetRemainingchars() {
        return pbXnfqLbAakClRxC(this) - this.pos;
    }

    public com.google.zxing.datamatrix.encoder.SymbolInfo GetSymbolInfo() {
        return this.symbolInfo;
    }

    public bool HasMorechars() {
        return this.pos < yLsDWNivwDxIHlMw(this);
    }

    public void ResetEncoderSignal() {
        this.newEncoding = -1;
    }

    public void ResetSymbolInfo() {
        this.symbolInfo = null;
    }

    public void SetSizeConstraints(com.google.zxing.Dimension dimension, com.google.zxing.Dimension dimension2) {
        this.minSize = dimension;
        this.maxSize = dimension2;
    }

    public void SetSkipAtEnd(int i) {
        this.skipAtEnd = i;
    }

    public void SetSymbolShape(com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint) {
        this.shape = symbolShapeHint;
    }

    public void SignalEncoderChange(int i) {
        this.newEncoding = i;
    }

    public void UpdateSymbolInfo() {
        GWADWyrBeTXlRbBr(this, eCpUkhekBoSdXAWy(this));
    }

    public void UpdateSymbolInfo(int i) {
        if ((12 + 17) % 17 > 0) {
        }
        com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo = this.symbolInfo;
        if (symbolInfo is not null && i <= qiyAhZwZBSgumllP(symbolInfo)) {
            return;
        }
        this.symbolInfo = jvYNwjVsZNbJevlQ(i, this.shape, this.minSize, this.maxSize, true);
    }

    public void WriteCodeword(char c) {
        tnBVHbGGeDuqEQLu(this.codewords, c);
    }

    public void WriteCodewords(java.lang.string str) {
        rpdxtuwoSKYawKIS(this.codewords, str);
    }
}

