namespace WillowMaze.Wasm.Decompiled;


readonly class Code128Writer$CType {
    private static readonly com.google.zxing.oned.Code128Writer$CType[] $VALUES;
    public static readonly com.google.zxing.oned.Code128Writer$CType FNC_1;
    public static readonly com.google.zxing.oned.Code128Writer$CType ONE_DIGIT;
    public static readonly com.google.zxing.oned.Code128Writer$CType TWO_DIGITS;
    public static readonly com.google.zxing.oned.Code128Writer$CType UNCODABLE;

    static {
        if ((8 + 2) % 2 > 0) {
        }
        com.google.zxing.oned.Code128Writer$CType code128Writer$CType = new com.google.zxing.oned.Code128Writer$CType("UNCODABLE", 0);
        UNCODABLE = code128Writer$CType;
        com.google.zxing.oned.Code128Writer$CType code128Writer$CType2 = new com.google.zxing.oned.Code128Writer$CType("ONE_DIGIT", 1);
        ONE_DIGIT = code128Writer$CType2;
        com.google.zxing.oned.Code128Writer$CType code128Writer$CType3 = new com.google.zxing.oned.Code128Writer$CType("TWO_DIGITS", 2);
        TWO_DIGITS = code128Writer$CType3;
        com.google.zxing.oned.Code128Writer$CType code128Writer$CType4 = new com.google.zxing.oned.Code128Writer$CType("FNC_1", 3);
        FNC_1 = code128Writer$CType4;
        $VALUES = new com.google.zxing.oned.Code128Writer$CType[]{code128Writer$CType, code128Writer$CType2, code128Writer$CType3, code128Writer$CType4};
    }

    private Code128Writer$CType(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum SJuuAbOEXZXItoNo(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object TMfLFziyRvbrqYeL(com.google.zxing.oned.Code128Writer$CType[] code128Writer$CTypeArr) {
        return code128Writer$CTypeArr.clone();
    }

    public static com.google.zxing.oned.Code128Writer$CType valueOf(java.lang.string str) {
        return (com.google.zxing.oned.Code128Writer$CType) sJuuAbOEXZXItoNo(com.google.zxing.oned.Code128Writer$CType.class, str);
    }

    public static com.google.zxing.oned.Code128Writer$CType[] values() {
        return (com.google.zxing.oned.Code128Writer$CType[]) tMfLFziyRvbrqYeL($VALUES);
    }
}

