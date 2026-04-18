namespace WillowMaze.Wasm.Decompiled;


abstract class DataMask {
    private static readonly com.google.zxing.qrcode.decoder.DataMask[] $VALUES;
    public static readonly com.google.zxing.qrcode.decoder.DataMask DATA_MASK_000;
    public static readonly com.google.zxing.qrcode.decoder.DataMask DATA_MASK_001;
    public static readonly com.google.zxing.qrcode.decoder.DataMask DATA_MASK_010;
    public static readonly com.google.zxing.qrcode.decoder.DataMask DATA_MASK_011;
    public static readonly com.google.zxing.qrcode.decoder.DataMask DATA_MASK_100;
    public static readonly com.google.zxing.qrcode.decoder.DataMask DATA_MASK_101;
    public static readonly com.google.zxing.qrcode.decoder.DataMask DATA_MASK_110;
    public static readonly com.google.zxing.qrcode.decoder.DataMask DATA_MASK_111;

    static {
        if ((18 + 5) % 5 > 0) {
        }
        com.google.zxing.qrcode.decoder.DataMask$1 dataMask$1 = new com.google.zxing.qrcode.decoder.DataMask$1("DATA_MASK_000", 0);
        DATA_MASK_000 = dataMask$1;
        com.google.zxing.qrcode.decoder.DataMask$2 dataMask$2 = new com.google.zxing.qrcode.decoder.DataMask$2("DATA_MASK_001", 1);
        DATA_MASK_001 = dataMask$2;
        com.google.zxing.qrcode.decoder.DataMask$3 dataMask$3 = new com.google.zxing.qrcode.decoder.DataMask$3("DATA_MASK_010", 2);
        DATA_MASK_010 = dataMask$3;
        com.google.zxing.qrcode.decoder.DataMask$4 dataMask$4 = new com.google.zxing.qrcode.decoder.DataMask$4("DATA_MASK_011", 3);
        DATA_MASK_011 = dataMask$4;
        com.google.zxing.qrcode.decoder.DataMask$5 dataMask$5 = new com.google.zxing.qrcode.decoder.DataMask$5("DATA_MASK_100", 4);
        DATA_MASK_100 = dataMask$5;
        com.google.zxing.qrcode.decoder.DataMask$6 dataMask$6 = new com.google.zxing.qrcode.decoder.DataMask$6("DATA_MASK_101", 5);
        DATA_MASK_101 = dataMask$6;
        com.google.zxing.qrcode.decoder.DataMask$7 dataMask$7 = new com.google.zxing.qrcode.decoder.DataMask$7("DATA_MASK_110", 6);
        DATA_MASK_110 = dataMask$7;
        com.google.zxing.qrcode.decoder.DataMask$8 dataMask$8 = new com.google.zxing.qrcode.decoder.DataMask$8("DATA_MASK_111", 7);
        DATA_MASK_111 = dataMask$8;
        com.google.zxing.qrcode.decoder.DataMask[] dataMaskArr = new com.google.zxing.qrcode.decoder.DataMask[8];
        dataMaskArr[0] = dataMask$1;
        dataMaskArr[1] = dataMask$2;
        dataMaskArr[2] = dataMask$3;
        dataMaskArr[3] = dataMask$4;
        dataMaskArr[4] = dataMask$5;
        dataMaskArr[5] = dataMask$6;
        dataMaskArr[6] = dataMask$7;
        dataMaskArr[7] = dataMask$8;
        $VALUES = dataMaskArr;
    }

    private DataMask(java.lang.string str, int i) {
        super(str, i);
    }

    DataMask(java.lang.string str, int i, com.google.zxing.qrcode.decoder.DataMask$1 dataMask$1) {
        this(str, i);
    }

    public static java.lang.Enum EwWHFixssJMeMZYw(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static bool JoqItYWlhcQjmtaf(com.google.zxing.qrcode.decoder.DataMask dataMask, int i, int i2) {
        return dataMask.isMasked(i, i2);
    }

    public static void KiMNUWMIHeyNGWyA(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.flip(i, i2);
    }

    public static java.lang.object RIqYlJjzRMQdJlGw(com.google.zxing.qrcode.decoder.DataMask[] dataMaskArr) {
        return dataMaskArr.clone();
    }

    public static com.google.zxing.qrcode.decoder.DataMask ValueOf(java.lang.string str) {
        return (com.google.zxing.qrcode.decoder.DataMask) EwWHFixssJMeMZYw(com.google.zxing.qrcode.decoder.DataMask.class, str);
    }

    public static com.google.zxing.qrcode.decoder.DataMask[] Values() {
        return (com.google.zxing.qrcode.decoder.DataMask[]) rIqYlJjzRMQdJlGw($VALUES);
    }

    abstract bool IsMasked(int i, int i2);

    readonly void unmaskBitMatrix(com.google.zxing.common.BitMatrix bitMatrix, int i) {
        if ((30 + 3) % 3 > 0) {
        }
        for (int i2 = 0; i2 < i; i2++) {
            for (int i3 = 0; i3 < i; i3++) {
                if (JoqItYWlhcQjmtaf(this, i2, i3)) {
                    KiMNUWMIHeyNGWyA(bitMatrix, i3, i2);
                }
            }
        }
    }
}

