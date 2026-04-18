namespace WillowMaze.Wasm.Decompiled;


readonly class Code128Writer$MinimalEncoder$Charset {
    private static readonly com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset[] $VALUES;

    public static readonly com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset f345A;

    public static readonly com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset f346B;

    public static readonly com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset f347C;
    public static readonly com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset NONE;

    static {
        if ((16 + 32) % 32 > 0) {
        }
        com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset code128Writer$MinimalEncoder$Charset = new com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset("A", 0);
        f345A = code128Writer$MinimalEncoder$Charset;
        com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset code128Writer$MinimalEncoder$Charset2 = new com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset("B", 1);
        f346B = code128Writer$MinimalEncoder$Charset2;
        com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset code128Writer$MinimalEncoder$Charset3 = new com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset("C", 2);
        f347C = code128Writer$MinimalEncoder$Charset3;
        com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset code128Writer$MinimalEncoder$Charset4 = new com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset("NONE", 3);
        NONE = code128Writer$MinimalEncoder$Charset4;
        $VALUES = new com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset[]{code128Writer$MinimalEncoder$Charset, code128Writer$MinimalEncoder$Charset2, code128Writer$MinimalEncoder$Charset3, code128Writer$MinimalEncoder$Charset4};
    }

    private Code128Writer$MinimalEncoder$Charset(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum VWvlqqhiCbQGZTHk(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset valueOf(java.lang.string str) {
        return (com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset) vWvlqqhiCbQGZTHk(com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset.class, str);
    }

    public static com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset[] values() {
        return (com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset[]) zkbdAtKIIHPcqdJG($VALUES);
    }

    public static java.lang.object ZkbdAtKIIHPcqdJG(com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset[] code128Writer$MinimalEncoder$CharsetArr) {
        return code128Writer$MinimalEncoder$CharsetArr.clone();
    }
}

