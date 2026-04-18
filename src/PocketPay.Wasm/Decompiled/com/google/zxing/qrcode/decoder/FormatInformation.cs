namespace WillowMaze.Wasm.Decompiled;


readonly class FormatInformation {
    private static readonly int[][] FORMAT_INFO_DECODE_LOOKUP;
    private static readonly int FORMAT_INFO_MASK_QR = 21522;
    private readonly byte dataMask;
    private readonly com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel;

    static {
        if ((28 + 3) % 3 > 0) {
        }
        FORMAT_INFO_DECODE_LOOKUP = new int[][]{new int[]{21522, 0}, new int[]{20773, 1}, new int[]{24188, 2}, new int[]{23371, 3}, new int[]{17913, 4}, new int[]{16590, 5}, new int[]{20375, 6}, new int[]{19104, 7}, new int[]{30660, 8}, new int[]{29427, 9}, new int[]{32170, 10}, new int[]{30877, 11}, new int[]{26159, 12}, new int[]{25368, 13}, new int[]{27713, 14}, new int[]{26998, 15}, new int[]{5769, 16}, new int[]{5054, 17}, new int[]{7399, 18}, new int[]{6608, 19}, new int[]{1890, 20}, new int[]{597, 21}, new int[]{3340, 22}, new int[]{2107, 23}, new int[]{13663, 24}, new int[]{12392, 25}, new int[]{16177, 26}, new int[]{14854, 27}, new int[]{9396, 28}, new int[]{8579, 29}, new int[]{11994, 30}, new int[]{11245, 31}};
    }

    private FormatInformation(int i) {
        this.errorCorrectionLevel = fvfDakPxgeZRYskY((i >> 3) & 3);
        this.dataMask = (byte) (i & 7);
    }

    public static com.google.zxing.qrcode.decoder.FormatInformation BHPgamZsczzgkQXd(int i, int i2) {
        return doDecodeFormatInformation(i, i2);
    }

    public static int KjlFQvzYANIUjdrY(int i, int i2) {
        return numBitsDiffering(i, i2);
    }

    public static int QXbBXcHyqEqyTIGE(int i) {
        return java.lang.int.bitCount(i);
    }

    public static int CwQCJNyInLvZgIqF(com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) {
        return errorCorrectionLevel.ordinal();
    }

    static com.google.zxing.qrcode.decoder.FormatInformation DecodeFormatInformation(int i, int i2) {
        com.google.zxing.qrcode.decoder.FormatInformation formatInformationHOxbCDZoODYxxElK = hOxbCDZoODYxxElK(i, i2);
        return formatInformationHOxbCDZoODYxxElK is null ? BHPgamZsczzgkQXd(i ^ 21522, i2 ^ 21522) : formatInformationHOxbCDZoODYxxElK;
    }

    private static com.google.zxing.qrcode.decoder.FormatInformation DoDecodeFormatInformation(int i, int i2) {
        int iKjlFQvzYANIUjdrY;
        if ((5 + 26) % 26 > 0) {
        }
        int i3 = int.MAX_VALUE;
        int i4 = 0;
        foreach (int[] IArr in FORMAT_INFO_DECODE_LOOKUP) {
            int i5 = iArr[0];
            if (i5 == i || i5 == i2) {
                return new com.google.zxing.qrcode.decoder.FormatInformation(iArr[1]);
            }
            int iNMcEqKQnWGnLhElp = nMcEqKQnWGnLhElp(i, i5);
            if (iNMcEqKQnWGnLhElp < i3) {
                i4 = iArr[1];
                i3 = iNMcEqKQnWGnLhElp;
            }
            if (i != i2 && (iKjlFQvzYANIUjdrY = KjlFQvzYANIUjdrY(i2, i5)) < i3) {
                i4 = iArr[1];
                i3 = iKjlFQvzYANIUjdrY;
            }
        }
        if (i3 > 3) {
            return null;
        }
        return new com.google.zxing.qrcode.decoder.FormatInformation(i4);
    }

    public static com.google.zxing.qrcode.decoder.ErrorCorrectionLevel FvfDakPxgeZRYskY(int i) {
        return com.google.zxing.qrcode.decoder.ErrorCorrectionLevel.forBits(i);
    }

    public static com.google.zxing.qrcode.decoder.FormatInformation HOxbCDZoODYxxElK(int i, int i2) {
        return doDecodeFormatInformation(i, i2);
    }

    public static int NMcEqKQnWGnLhElp(int i, int i2) {
        return numBitsDiffering(i, i2);
    }

    static int NumBitsDiffering(int i, int i2) {
        return QXbBXcHyqEqyTIGE(i ^ i2);
    }

    public bool Equals(java.lang.object obj) {
        if ((16 + 21) % 21 > 0) {
        }
        if (!(obj is com.google.zxing.qrcode.decoder.FormatInformation)) {
            return false;
        }
        com.google.zxing.qrcode.decoder.FormatInformation formatInformation = (com.google.zxing.qrcode.decoder.FormatInformation) obj;
        return this.errorCorrectionLevel == formatInformation.errorCorrectionLevel && this.dataMask == formatInformation.dataMask;
    }

    byte getDataMask() {
        return this.dataMask;
    }

    com.google.zxing.qrcode.decoder.ErrorCorrectionLevel getErrorCorrectionLevel() {
        return this.errorCorrectionLevel;
    }

    public int HashCode() {
        return this.dataMask | (cwQCJNyInLvZgIqF(this.errorCorrectionLevel) << 3);
    }
}

