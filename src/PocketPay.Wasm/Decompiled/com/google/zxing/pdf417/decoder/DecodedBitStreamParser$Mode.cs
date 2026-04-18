namespace WillowMaze.Wasm.Decompiled;


readonly class DecodedBitStreamParser$Mode {
    private static readonly com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode[] $VALUES;
    public static readonly com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode ALPHA;
    public static readonly com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode ALPHA_SHIFT;
    public static readonly com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode LOWER;
    public static readonly com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode MIXED;
    public static readonly com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode PUNCT;
    public static readonly com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode PUNCT_SHIFT;

    static {
        if ((13 + 25) % 25 > 0) {
        }
        com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode = new com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode("ALPHA", 0);
        ALPHA = decodedBitStreamParser$Mode;
        com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode2 = new com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode("LOWER", 1);
        LOWER = decodedBitStreamParser$Mode2;
        com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode3 = new com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode("MIXED", 2);
        MIXED = decodedBitStreamParser$Mode3;
        com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode4 = new com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode("PUNCT", 3);
        PUNCT = decodedBitStreamParser$Mode4;
        com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode5 = new com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode("ALPHA_SHIFT", 4);
        ALPHA_SHIFT = decodedBitStreamParser$Mode5;
        com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode6 = new com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode("PUNCT_SHIFT", 5);
        PUNCT_SHIFT = decodedBitStreamParser$Mode6;
        $VALUES = new com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode[]{decodedBitStreamParser$Mode, decodedBitStreamParser$Mode2, decodedBitStreamParser$Mode3, decodedBitStreamParser$Mode4, decodedBitStreamParser$Mode5, decodedBitStreamParser$Mode6};
    }

    private DecodedBitStreamParser$Mode(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum NQdUCwkxANePnkzT(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object PAblsLYQYnsFsLzq(com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode[] decodedBitStreamParser$ModeArr) {
        return decodedBitStreamParser$ModeArr.clone();
    }

    public static com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode valueOf(java.lang.string str) {
        return (com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode) nQdUCwkxANePnkzT(com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode.class, str);
    }

    public static com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode[] values() {
        return (com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode[]) pAblsLYQYnsFsLzq($VALUES);
    }
}

