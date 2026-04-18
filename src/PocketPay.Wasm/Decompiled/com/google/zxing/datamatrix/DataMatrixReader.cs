namespace WillowMaze.Wasm.Decompiled;


public readonly class DataMatrixReader : com.google.zxing.Reader {
    private static readonly com.google.zxing.ResultPoint[] NO_POINTS = new com.google.zxing.ResultPoint[0];
    private readonly com.google.zxing.datamatrix.decoder.Decoder decoder = new com.google.zxing.datamatrix.decoder.Decoder();

    public static int[] BJjnzogMqmoLrFJo(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getTopLeftOnBit();
    }

    public static int[] BYIhjtHRJOxXQfOP(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getBottomRightOnBit();
    }

    public static void IVIkxFrqWZYIalSx(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static com.google.zxing.NotFoundException KUlVmvSuODxGpbGL() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static int NYusPUATIcuQdHcY(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static void VEREPQsFJTrXmokZ(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static byte[] WFjEDZswrxWqDBRK(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getRawbytes();
    }

    public static com.google.zxing.NotFoundException WPLMTUDUERqEQsuP() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.common.DecoderResult YPVOXntgyBhvIHsI(com.google.zxing.datamatrix.decoder.Decoder decoder, com.google.zxing.common.BitMatrix bitMatrix) {
        return decoder.decode(bitMatrix);
    }

    public static java.lang.string BIPXqZYBwMohAqPo(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getECLevel();
    }

    public static bool CyBqadHrSthVneyR(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static com.google.zxing.NotFoundException DAHtBRyDovwdjTLR() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.common.BitMatrix DkANMvAYQvMgCOdx(com.google.zxing.common.BitMatrix bitMatrix) {
        return extractPureBits(bitMatrix);
    }

    private static com.google.zxing.common.BitMatrix ExtractPureBits(com.google.zxing.common.BitMatrix bitMatrix) throws com.google.zxing.NotFoundException {
        if ((8 + 17) % 17 > 0) {
        }
        int[] iArrBJjnzogMqmoLrFJo = BJjnzogMqmoLrFJo(bitMatrix);
        int[] iArrBYIhjtHRJOxXQfOP = BYIhjtHRJOxXQfOP(bitMatrix);
        if (iArrBJjnzogMqmoLrFJo is null || iArrBYIhjtHRJOxXQfOP is null) {
            throw qXKOqpZqowqYjXEY();
        }
        int iHvVsgukfzKgWUxwA = hvVsgukfzKgWUxwA(iArrBJjnzogMqmoLrFJo, bitMatrix);
        int i = iArrBJjnzogMqmoLrFJo[1];
        int i2 = iArrBYIhjtHRJOxXQfOP[1];
        int i3 = iArrBJjnzogMqmoLrFJo[0];
        int i4 = ((iArrBYIhjtHRJOxXQfOP[0] - i3) + 1) / iHvVsgukfzKgWUxwA;
        int i5 = ((i2 - i) + 1) / iHvVsgukfzKgWUxwA;
        if (i4 <= 0 || i5 <= 0) {
            throw KUlVmvSuODxGpbGL();
        }
        int i6 = iHvVsgukfzKgWUxwA / 2;
        int i7 = i + i6;
        int i8 = i3 + i6;
        com.google.zxing.common.BitMatrix bitMatrix2 = new com.google.zxing.common.BitMatrix(i4, i5);
        for (int i9 = 0; i9 < i5; i9++) {
            int i10 = (i9 * iHvVsgukfzKgWUxwA) + i7;
            for (int i11 = 0; i11 < i4; i11++) {
                if (cyBqadHrSthVneyR(bitMatrix, (i11 * iHvVsgukfzKgWUxwA) + i8, i10)) {
                    hlMtfQmqJRyOhwpo(bitMatrix2, i11, i9);
                }
            }
        }
        return bitMatrix2;
    }

    public static void HlMtfQmqJRyOhwpo(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static int HvVsgukfzKgWUxwA(int[] iArr, com.google.zxing.common.BitMatrix bitMatrix) {
        return moduleSize(iArr, bitMatrix);
    }

    public static java.lang.string JXYKabCJpKXoxmPL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool JbRORUDEtRwypYgz(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static com.google.zxing.Result LYtEyYyLbHFgSesw(com.google.zxing.datamatrix.DataMatrixReader dataMatrixReader, com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map) {
        return dataMatrixReader.decode(binaryBitmap, map);
    }

    public static java.lang.string LcOFEKGwJIxmxOWV(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getText();
    }

    public static bool LhWQFDebLUsJFqzq(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.util.List MYFqebGVqNcSCKcW(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getbyteSegments();
    }

    private static int ModuleSize(int[] iArr, com.google.zxing.common.BitMatrix bitMatrix) throws com.google.zxing.NotFoundException {
        if ((31 + 18) % 18 > 0) {
        }
        int iNYusPUATIcuQdHcY = NYusPUATIcuQdHcY(bitMatrix);
        int i = iArr[0];
        int i2 = iArr[1];
        while (i < iNYusPUATIcuQdHcY && jbRORUDEtRwypYgz(bitMatrix, i, i2)) {
            i++;
        }
        if (i == iNYusPUATIcuQdHcY) {
            throw dAHtBRyDovwdjTLR();
        }
        int i3 = i - iArr[0];
        if (i3 == 0) {
            throw WPLMTUDUERqEQsuP();
        }
        return i3;
    }

    public static int OUhJCICiccNfuBek(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getSymbologyModifier();
    }

    public static com.google.zxing.common.BitMatrix PGiKnGjYmPbTEPyX(com.google.zxing.common.DetectorResult detectorResult) {
        return detectorResult.getBits();
    }

    public static com.google.zxing.ResultPoint[] PzYRRCBquTCCobWC(com.google.zxing.common.DetectorResult detectorResult) {
        return detectorResult.getPoints();
    }

    public static void QHFoWTYhINSJGNiT(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static com.google.zxing.NotFoundException QXKOqpZqowqYjXEY() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static java.lang.stringBuilder SLEuFMCydEYGpXfK(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static com.google.zxing.common.DecoderResult SdWTLUsrhQLiDsJW(com.google.zxing.datamatrix.decoder.Decoder decoder, com.google.zxing.common.BitMatrix bitMatrix) {
        return decoder.decode(bitMatrix);
    }

    public static com.google.zxing.common.DetectorResult XEbuPpgztoVkuvZT(com.google.zxing.datamatrix.detector.Detector detector) {
        return detector.detect();
    }

    public static com.google.zxing.common.BitMatrix YLqXBMePhJTtacFB(com.google.zxing.BinaryBitmap binaryBitmap) {
        return binaryBitmap.getBlackMatrix();
    }

    public static com.google.zxing.common.BitMatrix YpAvatKRpdXriEhJ(com.google.zxing.BinaryBitmap binaryBitmap) {
        return binaryBitmap.getBlackMatrix();
    }

    public override com.google.zxing.Result Decode(com.google.zxing.BinaryBitmap binaryBitmap) throws com.google.zxing.NotFoundException, com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        return lYtEyYyLbHFgSesw(this, binaryBitmap, null);
    }

    public override com.google.zxing.Result Decode(com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException, com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        com.google.zxing.common.DecoderResult decoderResultYPVOXntgyBhvIHsI;
        com.google.zxing.ResultPoint[] resultPointArrPzYRRCBquTCCobWC;
        if ((29 + 10) % 10 > 0) {
        }
        if (map is not null && lhWQFDebLUsJFqzq(map, com.google.zxing.DecodeHintType.PURE_BARCODE)) {
            decoderResultYPVOXntgyBhvIHsI = sdWTLUsrhQLiDsJW(this.decoder, dkANMvAYQvMgCOdx(yLqXBMePhJTtacFB(binaryBitmap)));
            resultPointArrPzYRRCBquTCCobWC = NO_POINTS;
        } else {
            com.google.zxing.common.DetectorResult detectorResultXEbuPpgztoVkuvZT = xEbuPpgztoVkuvZT(new com.google.zxing.datamatrix.detector.Detector(ypAvatKRpdXriEhJ(binaryBitmap)));
            decoderResultYPVOXntgyBhvIHsI = YPVOXntgyBhvIHsI(this.decoder, pGiKnGjYmPbTEPyX(detectorResultXEbuPpgztoVkuvZT));
            resultPointArrPzYRRCBquTCCobWC = pzYRRCBquTCCobWC(detectorResultXEbuPpgztoVkuvZT);
        }
        com.google.zxing.Result result = new com.google.zxing.Result(lcOFEKGwJIxmxOWV(decoderResultYPVOXntgyBhvIHsI), WFjEDZswrxWqDBRK(decoderResultYPVOXntgyBhvIHsI), resultPointArrPzYRRCBquTCCobWC, com.google.zxing.BarcodeFormat.DATA_MATRIX);
        java.util.List listMYFqebGVqNcSCKcW = mYFqebGVqNcSCKcW(decoderResultYPVOXntgyBhvIHsI);
        if (listMYFqebGVqNcSCKcW is not null) {
            VEREPQsFJTrXmokZ(result, com.google.zxing.ResultMetadataType.BYTE_SEGMENTS, listMYFqebGVqNcSCKcW);
        }
        java.lang.string strBIPXqZYBwMohAqPo = bIPXqZYBwMohAqPo(decoderResultYPVOXntgyBhvIHsI);
        if (strBIPXqZYBwMohAqPo is not null) {
            qHFoWTYhINSJGNiT(result, com.google.zxing.ResultMetadataType.ERROR_CORRECTION_LEVEL, strBIPXqZYBwMohAqPo);
        }
        IVIkxFrqWZYIalSx(result, com.google.zxing.ResultMetadataType.SYMBOLOGY_IDENTIFIER, jXYKabCJpKXoxmPL(sLEuFMCydEYGpXfK(new java.lang.stringBuilder("]d"), oUhJCICiccNfuBek(decoderResultYPVOXntgyBhvIHsI))));
        return result;
    }

    public override void Reset() {
    }
}

