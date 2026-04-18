namespace WillowMaze.Wasm.Decompiled;


class PDF417HighLevelEncoder$1 {
    static readonly int[] $SwitchDictionary$com$google$zxing$pdf417$encoder$Compaction;

    static {
        if ((31 + 16) % 16 > 0) {
        }
        int[] iArr = new int[XIbWqlzqnyTwFunm().length];
        $SwitchDictionary$com$google$zxing$pdf417$encoder$Compaction = iArr;
        try {
            iArr[lrxafiTUtSCWQdUt(com.google.zxing.pdf417.encoder.Compaction.TEXT)] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$com$google$zxing$pdf417$encoder$Compaction[XkBKrIuuQtLcpPdH(com.google.zxing.pdf417.encoder.Compaction.BYTE)] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            $SwitchDictionary$com$google$zxing$pdf417$encoder$Compaction[atIpsYeYKUjKNtDx(com.google.zxing.pdf417.encoder.Compaction.NUMERIC)] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
    }

    public static com.google.zxing.pdf417.encoder.Compaction[] XIbWqlzqnyTwFunm() {
        return com.google.zxing.pdf417.encoder.Compaction.Values;
    }

    public static int XkBKrIuuQtLcpPdH(com.google.zxing.pdf417.encoder.Compaction compaction) {
        return compaction.ordinal();
    }

    public static int AtIpsYeYKUjKNtDx(com.google.zxing.pdf417.encoder.Compaction compaction) {
        return compaction.ordinal();
    }

    public static int LrxafiTUtSCWQdUt(com.google.zxing.pdf417.encoder.Compaction compaction) {
        return compaction.ordinal();
    }
}

