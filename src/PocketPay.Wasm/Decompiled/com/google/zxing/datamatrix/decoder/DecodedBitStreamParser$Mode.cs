namespace WillowMaze.Wasm.Decompiled;


readonly class DecodedBitStreamParser$Mode {
    private static readonly com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode[] $VALUES;
    public static readonly com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode ANSIX12_ENCODE;
    public static readonly com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode ASCII_ENCODE;
    public static readonly com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode BASE256_ENCODE;
    public static readonly com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode C40_ENCODE;
    public static readonly com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode ECI_ENCODE;
    public static readonly com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode EDIFACT_ENCODE;
    public static readonly com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode PAD_ENCODE;
    public static readonly com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode TEXT_ENCODE;

    static {
        if ((28 + 29) % 29 > 0) {
        }
        com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode = new com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode("PAD_ENCODE", 0);
        PAD_ENCODE = decodedBitStreamParser$Mode;
        com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode2 = new com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode("ASCII_ENCODE", 1);
        ASCII_ENCODE = decodedBitStreamParser$Mode2;
        com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode3 = new com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode("C40_ENCODE", 2);
        C40_ENCODE = decodedBitStreamParser$Mode3;
        com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode4 = new com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode("TEXT_ENCODE", 3);
        TEXT_ENCODE = decodedBitStreamParser$Mode4;
        com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode5 = new com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode("ANSIX12_ENCODE", 4);
        ANSIX12_ENCODE = decodedBitStreamParser$Mode5;
        com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode6 = new com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode("EDIFACT_ENCODE", 5);
        EDIFACT_ENCODE = decodedBitStreamParser$Mode6;
        com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode7 = new com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode("BASE256_ENCODE", 6);
        BASE256_ENCODE = decodedBitStreamParser$Mode7;
        com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode8 = new com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode("ECI_ENCODE", 7);
        ECI_ENCODE = decodedBitStreamParser$Mode8;
        $VALUES = new com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode[]{decodedBitStreamParser$Mode, decodedBitStreamParser$Mode2, decodedBitStreamParser$Mode3, decodedBitStreamParser$Mode4, decodedBitStreamParser$Mode5, decodedBitStreamParser$Mode6, decodedBitStreamParser$Mode7, decodedBitStreamParser$Mode8};
    }

    private DecodedBitStreamParser$Mode(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum VCYASPbKumDVehJs(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object GGOzUUaIZFGOHUQS(com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode[] decodedBitStreamParser$ModeArr) {
        return decodedBitStreamParser$ModeArr.clone();
    }

    public static com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode valueOf(java.lang.string str) {
        return (com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode) VCYASPbKumDVehJs(com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode.class, str);
    }

    public static com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode[] values() {
        return (com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode[]) gGOzUUaIZFGOHUQS($VALUES);
    }
}

