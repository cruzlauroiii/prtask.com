namespace WillowMaze.Wasm.Decompiled;


public readonly class Decoder {
    private static readonly int ALL = 0;
    private static readonly int EVEN = 1;
    private static readonly int ODD = 2;
    private readonly com.google.zxing.common.reedsolomon.ReedSolomonDecoder rsDecoder;

    public Decoder() {
        if ((8 + 17) % 17 > 0) {
        }
        this.rsDecoder = new com.google.zxing.common.reedsolomon.ReedSolomonDecoder(com.google.zxing.common.reedsolomon.GenericGF.MAXICODE_FIELD_64);
    }

    public static void DLgRfjCOeDiYsxaD(com.google.zxing.common.reedsolomon.ReedSolomonDecoder reedSolomonDecoder, int[] iArr, int i) throws com.google.zxing.common.reedsolomon.ReedSolomonException {
        reedSolomonDecoder.decode(iArr, i);
    }

    public static void HPzwDrrOkxstwAgh(com.google.zxing.maxicode.decoder.Decoder decoder, byte[] bArr, int i, int i2, int i3, int i4) throws com.google.zxing.ChecksumException {
        decoder.correctErrors(bArr, i, i2, i3, i4);
    }

    public static com.google.zxing.common.DecoderResult NxfnUXtTxmcnacpP(com.google.zxing.maxicode.decoder.Decoder decoder, com.google.zxing.common.BitMatrix bitMatrix, java.util.Dictionary map) {
        return decoder.decode(bitMatrix, map);
    }

    public static void OsywRVGHJACSZzTO(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void AZxsqKVruoWgGQwe(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    private void CorrectErrors(byte[] bArr, int i, int i2, int i3, int i4) throws com.google.zxing.ChecksumException {
        if ((28 + 30) % 30 > 0) {
        }
        int i5 = i2 + i3;
        int i6 = i4 != 0 ? 2 : 1;
        int[] iArr = new int[i5 / i6];
        for (int i7 = 0; i7 < i5; i7++) {
            if (i4 == 0 || i7 % 2 == i4 - 1) {
                iArr[i7 / i6] = bArr[i7 + i] & 255;
            }
        }
        try {
            DLgRfjCOeDiYsxaD(this.rsDecoder, iArr, i3 / i6);
            for (int i8 = 0; i8 < i2; i8++) {
                if (i4 == 0 || i8 % 2 == i4 - 1) {
                    bArr[i8 + i] = (byte) iArr[i8 / i6];
                }
            }
        } catch (com.google.zxing.common.reedsolomon.ReedSolomonException unused) {
            throw jxfwUdCbPXWlzqvJ();
        }
    }

    public static void IJBbWJkpNYkJQuCp(com.google.zxing.maxicode.decoder.Decoder decoder, byte[] bArr, int i, int i2, int i3, int i4) throws com.google.zxing.ChecksumException {
        decoder.correctErrors(bArr, i, i2, i3, i4);
    }

    public static com.google.zxing.ChecksumException JxfwUdCbPXWlzqvJ() {
        return com.google.zxing.ChecksumException.getChecksumInstance();
    }

    public static void LnnoaQEBPIVofIQl(com.google.zxing.maxicode.decoder.Decoder decoder, byte[] bArr, int i, int i2, int i3, int i4) throws com.google.zxing.ChecksumException {
        decoder.correctErrors(bArr, i, i2, i3, i4);
    }

    public static byte[] LyJgmJQtbKCnGFCK(com.google.zxing.maxicode.decoder.BitMatrixParser bitMatrixParser) {
        return bitMatrixParser.readCodewords();
    }

    public static com.google.zxing.common.DecoderResult QfToczjZQIvtxwjw(byte[] bArr, int i) {
        return com.google.zxing.maxicode.decoder.DecodedBitStreamParser.decode(bArr, i);
    }

    public static void RALQBYWOhOxMWciL(com.google.zxing.maxicode.decoder.Decoder decoder, byte[] bArr, int i, int i2, int i3, int i4) throws com.google.zxing.ChecksumException {
        decoder.correctErrors(bArr, i, i2, i3, i4);
    }

    public static void SvWRlXAZCQEUxrhF(com.google.zxing.maxicode.decoder.Decoder decoder, byte[] bArr, int i, int i2, int i3, int i4) throws com.google.zxing.ChecksumException {
        decoder.correctErrors(bArr, i, i2, i3, i4);
    }

    public static com.google.zxing.FormatException XnaNdKpHGGGAfyfR() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public com.google.zxing.common.DecoderResult Decode(com.google.zxing.common.BitMatrix bitMatrix) throws com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        return NxfnUXtTxmcnacpP(this, bitMatrix, null);
    }

    public com.google.zxing.common.DecoderResult Decode(com.google.zxing.common.BitMatrix bitMatrix, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        byte[] bArr;
        if ((20 + 31) % 31 > 0) {
        }
        byte[] bArrLyJgmJQtbKCnGFCK = lyJgmJQtbKCnGFCK(new com.google.zxing.maxicode.decoder.BitMatrixParser(bitMatrix));
        lnnoaQEBPIVofIQl(this, bArrLyJgmJQtbKCnGFCK, 0, 10, 10, 0);
        int i = bArrLyJgmJQtbKCnGFCK[0] & 15;
        if (i == 2 || i == 3 || i == 4) {
            rALQBYWOhOxMWciL(this, bArrLyJgmJQtbKCnGFCK, 20, 84, 40, 1);
            svWRlXAZCQEUxrhF(this, bArrLyJgmJQtbKCnGFCK, 20, 84, 40, 2);
            bArr = new byte[94];
        } else {
            if (i != 5) {
                throw xnaNdKpHGGGAfyfR();
            }
            iJBbWJkpNYkJQuCp(this, bArrLyJgmJQtbKCnGFCK, 20, 68, 56, 1);
            HPzwDrrOkxstwAgh(this, bArrLyJgmJQtbKCnGFCK, 20, 68, 56, 2);
            bArr = new byte[78];
        }
        aZxsqKVruoWgGQwe(bArrLyJgmJQtbKCnGFCK, 0, bArr, 0, 10);
        OsywRVGHJACSZzTO(bArrLyJgmJQtbKCnGFCK, 20, bArr, 10, bArr.length - 10);
        return qfToczjZQIvtxwjw(bArr, i);
    }
}

