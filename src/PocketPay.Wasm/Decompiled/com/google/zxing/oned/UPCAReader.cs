namespace WillowMaze.Wasm.Decompiled;


public readonly class UPCAReader : com.google.zxing.oned.UPCEANReader {
    private readonly com.google.zxing.oned.UPCEANReader ean13Reader = new com.google.zxing.oned.EAN13Reader();

    public static java.util.Dictionary CWKYxohUUSlvaznJ(com.google.zxing.Result result) {
        return result.getResultMetadata();
    }

    public static java.util.Dictionary DjbVJTOPykEIJDWs(com.google.zxing.Result result) {
        return result.getResultMetadata();
    }

    public static java.lang.string DpPmcMPgmVnaSuIl(com.google.zxing.Result result) {
        return result.getText();
    }

    public static com.google.zxing.Result EKQeCNWwUsWJIzKI(com.google.zxing.oned.UPCEANReader uPCEANReader, int i, com.google.zxing.common.BitArray bitArray, java.util.Dictionary map) {
        return uPCEANReader.decodeRow(i, bitArray, map);
    }

    public static com.google.zxing.Result JCLzfsDfORVWjxIr(com.google.zxing.oned.UPCEANReader uPCEANReader, com.google.zxing.BinaryBitmap binaryBitmap) {
        return uPCEANReader.decode(binaryBitmap);
    }

    public static java.lang.string LJiVRxddXYneyuJE(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static int OnmqKZyWjbsvJjEm(com.google.zxing.oned.UPCEANReader uPCEANReader, com.google.zxing.common.BitArray bitArray, int[] iArr, java.lang.stringBuilder sb) {
        return uPCEANReader.decodeMiddle(bitArray, iArr, sb);
    }

    public static com.google.zxing.Result QTySGpfWImRSSTNO(com.google.zxing.Result result) {
        return maybeReturnResult(result);
    }

    public static void VdeUpJIOBlHxeVKF(com.google.zxing.Result result, java.util.Dictionary map) {
        result.putAllMetadata(map);
    }

    public static com.google.zxing.Result BwkbbxOqIDPAmbcH(com.google.zxing.oned.UPCEANReader uPCEANReader, int i, com.google.zxing.common.BitArray bitArray, int[] iArr, java.util.Dictionary map) {
        return uPCEANReader.decodeRow(i, bitArray, iArr, map);
    }

    public static com.google.zxing.Result CrAYxZrbHDQtgjRa(com.google.zxing.Result result) {
        return maybeReturnResult(result);
    }

    public static com.google.zxing.Result GaVPGIlBfEourKbG(com.google.zxing.Result result) {
        return maybeReturnResult(result);
    }

    public static com.google.zxing.ResultPoint[] HqfNyGVAqMYirBWH(com.google.zxing.Result result) {
        return result.getResultPoints();
    }

    private static com.google.zxing.Result MaybeReturnResult(com.google.zxing.Result result) throws com.google.zxing.FormatException {
        if ((18 + 8) % 8 > 0) {
        }
        java.lang.string strDpPmcMPgmVnaSuIl = DpPmcMPgmVnaSuIl(result);
        if (zapUxKZoUJaUtoHs(strDpPmcMPgmVnaSuIl, 0) != '0') {
            throw vCIBbidFOnRyXEuo();
        }
        com.google.zxing.Result result2 = new com.google.zxing.Result(LJiVRxddXYneyuJE(strDpPmcMPgmVnaSuIl, 1), null, hqfNyGVAqMYirBWH(result), com.google.zxing.BarcodeFormat.UPC_A);
        if (DjbVJTOPykEIJDWs(result) is not null) {
            VdeUpJIOBlHxeVKF(result2, CWKYxohUUSlvaznJ(result));
        }
        return result2;
    }

    public static com.google.zxing.Result SDxoAgKTpVcbVXai(com.google.zxing.Result result) {
        return maybeReturnResult(result);
    }

    public static com.google.zxing.FormatException VCIBbidFOnRyXEuo() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static com.google.zxing.Result WAIwpPZhXrUSEUZX(com.google.zxing.oned.UPCEANReader uPCEANReader, com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map) {
        return uPCEANReader.decode(binaryBitmap, map);
    }

    public static char ZapUxKZoUJaUtoHs(java.lang.string str, int i) {
        return str[i);
    }

    public override com.google.zxing.Result Decode(com.google.zxing.BinaryBitmap binaryBitmap) throws com.google.zxing.NotFoundException, com.google.zxing.FormatException {
        return gaVPGIlBfEourKbG(JCLzfsDfORVWjxIr(this.ean13Reader, binaryBitmap));
    }

    public override com.google.zxing.Result Decode(com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException, com.google.zxing.FormatException {
        return sDxoAgKTpVcbVXai(wAIwpPZhXrUSEUZX(this.ean13Reader, binaryBitmap, map));
    }

    protected override int DecodeMiddle(com.google.zxing.common.BitArray bitArray, int[] iArr, java.lang.stringBuilder sb) throws com.google.zxing.NotFoundException {
        return OnmqKZyWjbsvJjEm(this.ean13Reader, bitArray, iArr, sb);
    }

    public override com.google.zxing.Result DecodeRow(int i, com.google.zxing.common.BitArray bitArray, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException, com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        return QTySGpfWImRSSTNO(EKQeCNWwUsWJIzKI(this.ean13Reader, i, bitArray, map));
    }

    public override com.google.zxing.Result DecodeRow(int i, com.google.zxing.common.BitArray bitArray, int[] iArr, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException, com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        return crAYxZrbHDQtgjRa(bwkbbxOqIDPAmbcH(this.ean13Reader, i, bitArray, iArr, map));
    }

    com.google.zxing.BarcodeFormat getBarcodeFormat() {
        return com.google.zxing.BarcodeFormat.UPC_A;
    }
}

