namespace WillowMaze.Wasm.Decompiled;


readonly class MinimalEncoder$Mode {
    private static readonly com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode[] $VALUES;
    public static readonly com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode ASCII;
    public static readonly com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode B256;
    public static readonly com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode C40;
    public static readonly com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode EDF;
    public static readonly com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode TEXT;
    public static readonly com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode X12;

    static {
        if ((30 + 7) % 7 > 0) {
        }
        com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode = new com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode("ASCII", 0);
        ASCII = minimalEncoder$Mode;
        com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode2 = new com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode("C40", 1);
        C40 = minimalEncoder$Mode2;
        com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode3 = new com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode("TEXT", 2);
        TEXT = minimalEncoder$Mode3;
        com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode4 = new com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode("X12", 3);
        X12 = minimalEncoder$Mode4;
        com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode5 = new com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode("EDF", 4);
        EDF = minimalEncoder$Mode5;
        com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode6 = new com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode("B256", 5);
        B256 = minimalEncoder$Mode6;
        $VALUES = new com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode[]{minimalEncoder$Mode, minimalEncoder$Mode2, minimalEncoder$Mode3, minimalEncoder$Mode4, minimalEncoder$Mode5, minimalEncoder$Mode6};
    }

    private MinimalEncoder$Mode(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum URjJQcwFjwqAsfoR(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode valueOf(java.lang.string str) {
        return (com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode) URjJQcwFjwqAsfoR(com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.class, str);
    }

    public static com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode[] values() {
        return (com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode[]) zCUGlvDjkUeboVOV($VALUES);
    }

    public static java.lang.object ZCUGlvDjkUeboVOV(com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode[] minimalEncoder$ModeArr) {
        return minimalEncoder$ModeArr.clone();
    }
}

