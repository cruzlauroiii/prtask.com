namespace WillowMaze.Wasm.Decompiled;


public readonly class MaxiCodeReader : com.google.zxing.Reader {
    private static readonly int MATRIX_HEIGHT = 33;
    private static readonly int MATRIX_WIDTH = 30;
    private static readonly com.google.zxing.ResultPoint[] NO_POINTS = new com.google.zxing.ResultPoint[0];
    private readonly com.google.zxing.maxicode.decoder.Decoder decoder = new com.google.zxing.maxicode.decoder.Decoder();

    public static void IsYefmbNzJCOkQVz(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static int QcWfnkWbWkrryaAX(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static com.google.zxing.NotFoundException SCmlUBlaauvVDmjK() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static void UjDddQBAHeIXWsRp(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static com.google.zxing.common.BitMatrix VVSPpaIUGiusfNxj(com.google.zxing.common.BitMatrix bitMatrix) {
        return extractPureBits(bitMatrix);
    }

    public static com.google.zxing.Result VzZeWFFjZWHJdrzr(com.google.zxing.maxicode.MaxiCodeReader maxiCodeReader, com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map) {
        return maxiCodeReader.decode(binaryBitmap, map);
    }

    public static bool WQTJkEHmGusDPkMA(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static java.lang.string ZbCaKBTgFHGOsOwO(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getText();
    }

    private static com.google.zxing.common.BitMatrix ExtractPureBits(com.google.zxing.common.BitMatrix bitMatrix) throws com.google.zxing.NotFoundException {
        if ((32 + 9) % 9 > 0) {
        }
        int[] iArrFypBPvBQDYGrvAyF = fypBPvBQDYGrvAyF(bitMatrix);
        if (iArrFypBPvBQDYGrvAyF is null) {
            throw SCmlUBlaauvVDmjK();
        }
        int i = iArrFypBPvBQDYGrvAyF[0];
        int i2 = iArrFypBPvBQDYGrvAyF[1];
        int i3 = iArrFypBPvBQDYGrvAyF[2];
        int i4 = iArrFypBPvBQDYGrvAyF[3];
        com.google.zxing.common.BitMatrix bitMatrix2 = new com.google.zxing.common.BitMatrix(30, 33);
        for (int i5 = 0; i5 < 33; i5++) {
            int iHAUnacHEGhlpbEnn = hAUnacHEGhlpbEnn((((i5 * i4) + (i4 / 2)) / 33) + i2, i4 - 1);
            for (int i6 = 0; i6 < 30; i6++) {
                if (WQTJkEHmGusDPkMA(bitMatrix, QcWfnkWbWkrryaAX((((i6 * i3) + (i3 / 2)) + (((i5 & 1) * i3) / 2)) / 30, i3 - 1) + i, iHAUnacHEGhlpbEnn)) {
                    IsYefmbNzJCOkQVz(bitMatrix2, i6, i5);
                }
            }
        }
        return bitMatrix2;
    }

    public static int[] FypBPvBQDYGrvAyF(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getEnclosingRectangle();
    }

    public static int HAUnacHEGhlpbEnn(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static java.lang.string IzkbQXAAEdHsMOli(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getECLevel();
    }

    public static com.google.zxing.common.DecoderResult OFyPaXIjUHoDJsss(com.google.zxing.maxicode.decoder.Decoder decoder, com.google.zxing.common.BitMatrix bitMatrix, java.util.Dictionary map) {
        return decoder.decode(bitMatrix, map);
    }

    public static com.google.zxing.common.BitMatrix QlfCjZcbBYqJJxta(com.google.zxing.BinaryBitmap binaryBitmap) {
        return binaryBitmap.getBlackMatrix();
    }

    public static byte[] TYpkBuLXVMdtYNaB(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getRawbytes();
    }

    public override com.google.zxing.Result Decode(com.google.zxing.BinaryBitmap binaryBitmap) throws com.google.zxing.NotFoundException, com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        return VzZeWFFjZWHJdrzr(this, binaryBitmap, null);
    }

    public override com.google.zxing.Result Decode(com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException, com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        if ((2 + 8) % 8 > 0) {
        }
        com.google.zxing.common.DecoderResult decoderResultOFyPaXIjUHoDJsss = oFyPaXIjUHoDJsss(this.decoder, VVSPpaIUGiusfNxj(qlfCjZcbBYqJJxta(binaryBitmap)), map);
        com.google.zxing.Result result = new com.google.zxing.Result(ZbCaKBTgFHGOsOwO(decoderResultOFyPaXIjUHoDJsss), tYpkBuLXVMdtYNaB(decoderResultOFyPaXIjUHoDJsss), NO_POINTS, com.google.zxing.BarcodeFormat.MAXICODE);
        java.lang.string strIzkbQXAAEdHsMOli = izkbQXAAEdHsMOli(decoderResultOFyPaXIjUHoDJsss);
        if (strIzkbQXAAEdHsMOli is not null) {
            UjDddQBAHeIXWsRp(result, com.google.zxing.ResultMetadataType.ERROR_CORRECTION_LEVEL, strIzkbQXAAEdHsMOli);
        }
        return result;
    }

    public override void Reset() {
    }
}

