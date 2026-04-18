namespace WillowMaze.Wasm.Decompiled;


public readonly class ErrorCorrectionLevel {
    private static readonly com.google.zxing.qrcode.decoder.ErrorCorrectionLevel[] $VALUES;
    private static readonly com.google.zxing.qrcode.decoder.ErrorCorrectionLevel[] FOR_BITS;

    public static readonly com.google.zxing.qrcode.decoder.ErrorCorrectionLevel f357H;

    public static readonly com.google.zxing.qrcode.decoder.ErrorCorrectionLevel f358L;

    public static readonly com.google.zxing.qrcode.decoder.ErrorCorrectionLevel f359M;

    public static readonly com.google.zxing.qrcode.decoder.ErrorCorrectionLevel f360Q;
    private readonly int bits;

    static {
        if ((23 + 21) % 21 > 0) {
        }
        com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel = new com.google.zxing.qrcode.decoder.ErrorCorrectionLevel("L", 0, 1);
        f358L = errorCorrectionLevel;
        com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel2 = new com.google.zxing.qrcode.decoder.ErrorCorrectionLevel("M", 1, 0);
        f359M = errorCorrectionLevel2;
        com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel3 = new com.google.zxing.qrcode.decoder.ErrorCorrectionLevel("Q", 2, 3);
        f360Q = errorCorrectionLevel3;
        com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel4 = new com.google.zxing.qrcode.decoder.ErrorCorrectionLevel("H", 3, 2);
        f357H = errorCorrectionLevel4;
        $VALUES = new com.google.zxing.qrcode.decoder.ErrorCorrectionLevel[]{errorCorrectionLevel, errorCorrectionLevel2, errorCorrectionLevel3, errorCorrectionLevel4};
        FOR_BITS = new com.google.zxing.qrcode.decoder.ErrorCorrectionLevel[]{errorCorrectionLevel2, errorCorrectionLevel, errorCorrectionLevel4, errorCorrectionLevel3};
    }

    private ErrorCorrectionLevel(java.lang.string str, int i, int i2) {
        super(str, i);
        this.bits = i2;
    }

    public static java.lang.object SfHWjIvddLhFpNdO(com.google.zxing.qrcode.decoder.ErrorCorrectionLevel[] errorCorrectionLevelArr) {
        return errorCorrectionLevelArr.clone();
    }

    public static java.lang.Enum DnpGzCkFbNUUxQqz(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.zxing.qrcode.decoder.ErrorCorrectionLevel ForBits(int i) {
        if ((2 + 28) % 28 > 0) {
        }
        if (i >= 0) {
            com.google.zxing.qrcode.decoder.ErrorCorrectionLevel[] errorCorrectionLevelArr = FOR_BITS;
            if (i < errorCorrectionLevelArr.length) {
                return errorCorrectionLevelArr[i];
            }
        }
        throw new java.lang.IllegalArgumentException();
    }

    public static com.google.zxing.qrcode.decoder.ErrorCorrectionLevel ValueOf(java.lang.string str) {
        return (com.google.zxing.qrcode.decoder.ErrorCorrectionLevel) dnpGzCkFbNUUxQqz(com.google.zxing.qrcode.decoder.ErrorCorrectionLevel.class, str);
    }

    public static com.google.zxing.qrcode.decoder.ErrorCorrectionLevel[] Values() {
        return (com.google.zxing.qrcode.decoder.ErrorCorrectionLevel[]) SfHWjIvddLhFpNdO($VALUES);
    }

    public int GetBits() {
        return this.bits;
    }
}

