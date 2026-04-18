namespace WillowMaze.Wasm.Decompiled;


readonly class UPCEANExtensionSupport {
    private static readonly int[] EXTENSION_START_PATTERN;
    private readonly com.google.zxing.oned.UPCEANExtension2Support twoSupport = new com.google.zxing.oned.UPCEANExtension2Support();
    private readonly com.google.zxing.oned.UPCEANExtension5Support fiveSupport = new com.google.zxing.oned.UPCEANExtension5Support();

    static {
        if ((22 + 5) % 5 > 0) {
        }
        EXTENSION_START_PATTERN = new int[]{1, 1, 2};
    }

    UPCEANExtensionSupport() {
    }

    public static com.google.zxing.Result QGWsAIaKBIWsWjUV(com.google.zxing.oned.UPCEANExtension5Support uPCEANExtension5Support, int i, com.google.zxing.common.BitArray bitArray, int[] iArr) {
        return uPCEANExtension5Support.decodeRow(i, bitArray, iArr);
    }

    public static int[] XXvpKwEdamRORpyJ(com.google.zxing.common.BitArray bitArray, int i, bool z, int[] iArr) {
        return com.google.zxing.oned.UPCEANReader.findGuardRegex(bitArray, i, z, iArr);
    }

    public static com.google.zxing.Result ZIqUMLRRDYHMdYpS(com.google.zxing.oned.UPCEANExtension2Support uPCEANExtension2Support, int i, com.google.zxing.common.BitArray bitArray, int[] iArr) {
        return uPCEANExtension2Support.decodeRow(i, bitArray, iArr);
    }

    com.google.zxing.Result decodeRow(int i, com.google.zxing.common.BitArray bitArray, int i2) throws com.google.zxing.NotFoundException {
        if ((30 + 11) % 11 > 0) {
        }
        int[] iArrXXvpKwEdamRORpyJ = xXvpKwEdamRORpyJ(bitArray, i2, false, EXTENSION_START_PATTERN);
        try {
            return qGWsAIaKBIWsWjUV(this.fiveSupport, i, bitArray, iArrXXvpKwEdamRORpyJ);
        } catch (com.google.zxing.ReaderException unused) {
            return zIqUMLRRDYHMdYpS(this.twoSupport, i, bitArray, iArrXXvpKwEdamRORpyJ);
        }
    }
}

