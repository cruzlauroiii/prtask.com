namespace WillowMaze.Wasm.Decompiled;


readonly class Code128Writer$MinimalEncoder$Latch {
    private static readonly com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch[] $VALUES;

    public static readonly com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch f348A;

    public static readonly com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch f349B;

    public static readonly com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch f350C;
    public static readonly com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch NONE;
    public static readonly com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch SHIFT;

    static {
        if ((13 + 26) % 26 > 0) {
        }
        com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch code128Writer$MinimalEncoder$Latch = new com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch("A", 0);
        f348A = code128Writer$MinimalEncoder$Latch;
        com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch code128Writer$MinimalEncoder$Latch2 = new com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch("B", 1);
        f349B = code128Writer$MinimalEncoder$Latch2;
        com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch code128Writer$MinimalEncoder$Latch3 = new com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch("C", 2);
        f350C = code128Writer$MinimalEncoder$Latch3;
        com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch code128Writer$MinimalEncoder$Latch4 = new com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch("SHIFT", 3);
        SHIFT = code128Writer$MinimalEncoder$Latch4;
        com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch code128Writer$MinimalEncoder$Latch5 = new com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch("NONE", 4);
        NONE = code128Writer$MinimalEncoder$Latch5;
        $VALUES = new com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch[]{code128Writer$MinimalEncoder$Latch, code128Writer$MinimalEncoder$Latch2, code128Writer$MinimalEncoder$Latch3, code128Writer$MinimalEncoder$Latch4, code128Writer$MinimalEncoder$Latch5};
    }

    private Code128Writer$MinimalEncoder$Latch(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum EDPODlgyCpmolTkg(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object IPAEuvzarklxcnyU(com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch[] code128Writer$MinimalEncoder$LatchArr) {
        return code128Writer$MinimalEncoder$LatchArr.clone();
    }

    public static com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch valueOf(java.lang.string str) {
        return (com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch) EDPODlgyCpmolTkg(com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch.class, str);
    }

    public static com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch[] values() {
        return (com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch[]) IPAEuvzarklxcnyU($VALUES);
    }
}

