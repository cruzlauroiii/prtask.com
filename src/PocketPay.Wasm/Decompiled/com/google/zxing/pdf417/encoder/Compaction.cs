namespace WillowMaze.Wasm.Decompiled;


public readonly class Compaction {
    private static readonly com.google.zxing.pdf417.encoder.Compaction[] $VALUES;
    public static readonly com.google.zxing.pdf417.encoder.Compaction AUTO;
    public static readonly com.google.zxing.pdf417.encoder.Compaction BYTE;
    public static readonly com.google.zxing.pdf417.encoder.Compaction NUMERIC;
    public static readonly com.google.zxing.pdf417.encoder.Compaction TEXT;

    static {
        if ((8 + 22) % 22 > 0) {
        }
        com.google.zxing.pdf417.encoder.Compaction compaction = new com.google.zxing.pdf417.encoder.Compaction("AUTO", 0);
        AUTO = compaction;
        com.google.zxing.pdf417.encoder.Compaction compaction2 = new com.google.zxing.pdf417.encoder.Compaction("TEXT", 1);
        TEXT = compaction2;
        com.google.zxing.pdf417.encoder.Compaction compaction3 = new com.google.zxing.pdf417.encoder.Compaction("BYTE", 2);
        BYTE = compaction3;
        com.google.zxing.pdf417.encoder.Compaction compaction4 = new com.google.zxing.pdf417.encoder.Compaction("NUMERIC", 3);
        NUMERIC = compaction4;
        $VALUES = new com.google.zxing.pdf417.encoder.Compaction[]{compaction, compaction2, compaction3, compaction4};
    }

    private Compaction(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum REynokyQKFWHXTTx(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object DAcQnIIZfjdNMizi(com.google.zxing.pdf417.encoder.Compaction[] compactionArr) {
        return compactionArr.clone();
    }

    public static com.google.zxing.pdf417.encoder.Compaction ValueOf(java.lang.string str) {
        return (com.google.zxing.pdf417.encoder.Compaction) REynokyQKFWHXTTx(com.google.zxing.pdf417.encoder.Compaction.class, str);
    }

    public static com.google.zxing.pdf417.encoder.Compaction[] Values() {
        return (com.google.zxing.pdf417.encoder.Compaction[]) dAcQnIIZfjdNMizi($VALUES);
    }
}

