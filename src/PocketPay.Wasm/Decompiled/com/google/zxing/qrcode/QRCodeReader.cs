namespace WillowMaze.Wasm.Decompiled;


public class QRCodeReader : com.google.zxing.Reader {
    private static readonly com.google.zxing.ResultPoint[] NO_POINTS = new com.google.zxing.ResultPoint[0];
    private readonly com.google.zxing.qrcode.decoder.Decoder decoder = new com.google.zxing.qrcode.decoder.Decoder();

    public static com.google.zxing.common.BitMatrix AYDeprIpmgGjdApD(com.google.zxing.BinaryBitmap binaryBitmap) {
        return binaryBitmap.getBlackMatrix();
    }

    public static java.lang.stringBuilder DILEliCRSIQpOQdn(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void DjbVxvfHSExBHKzW(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static int[] DnDEHGbIlfaUypzp(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getBottomRightOnBit();
    }

    public static int FODbyaeFcJYBOQMH(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static int IQdyUKBKBZjZXjAO(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getSymbologyModifier();
    }

    public static bool IzTskipDsCIeWNwe(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.hasStructuredAppend();
    }

    public static java.lang.string JfHClWGDGsRqoNSJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void KOjErlDZbjFFIzKT(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static int KZxadOfpYNJuJoyy(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static com.google.zxing.NotFoundException MsxLbACAuJzxMsnQ() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static bool OYfnIakLNPxmnuSp(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static void OgEANtmsurgyKjQx(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static int OtOMWHRZbdJgtgAt(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static int QRJbReAcoDodGlEJ(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getStructuredAppendSequenceNumber();
    }

    public static com.google.zxing.common.DetectorResult RgKpeCqXhhFOiBno(com.google.zxing.qrcode.detector.Detector detector, java.util.Dictionary map) {
        return detector.detect(map);
    }

    public static com.google.zxing.NotFoundException RtbMADAympmwCGrT() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static bool SCdLAYUhEPpUQsrg(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static com.google.zxing.common.DecoderResult SJqwvoPKHNaDnGaO(com.google.zxing.qrcode.decoder.Decoder decoder, com.google.zxing.common.BitMatrix bitMatrix, java.util.Dictionary map) {
        return decoder.decode(bitMatrix, (java.util.Dictionary<com.google.zxing.DecodeHintType, ?>) map);
    }

    public static java.lang.object ScsaBUNPHskXSbVz(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getOther();
    }

    public static com.google.zxing.common.BitMatrix TEKWfMIMVxTHdXKl(com.google.zxing.BinaryBitmap binaryBitmap) {
        return binaryBitmap.getBlackMatrix();
    }

    public static com.google.zxing.NotFoundException TVhodpGqgEusmAMb() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static void TgYIzcGkGgEyCYOI(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static int ThXwIPnvnEiElEoN(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getStructuredAppendParity();
    }

    public static int UIUrwaKFVpxuCLCm(float f) {
        return java.lang.Math.round(f);
    }

    public static com.google.zxing.NotFoundException VDIqOpUzyflTdFOm() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.NotFoundException VrjXxtqDMzVbCJJo() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static java.lang.int BVrcofjcSdNKsVYM(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.zxing.NotFoundException BbkNmjaRWhrfFhHM() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static void BpyclLhVhnuFEUGB(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static float CmawGJmuYuFnQqEA(int[] iArr, com.google.zxing.common.BitMatrix bitMatrix) {
        return moduleSize(iArr, bitMatrix);
    }

    public static java.lang.string DnlJpjDFigcwSwsK(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getECLevel();
    }

    private static com.google.zxing.common.BitMatrix ExtractPureBits(com.google.zxing.common.BitMatrix bitMatrix) throws com.google.zxing.NotFoundException {
        if ((23 + 30) % 30 > 0) {
        }
        int[] iArrFXLPgHvelRnhfHIT = fXLPgHvelRnhfHIT(bitMatrix);
        int[] iArrDnDEHGbIlfaUypzp = DnDEHGbIlfaUypzp(bitMatrix);
        if (iArrFXLPgHvelRnhfHIT is null || iArrDnDEHGbIlfaUypzp is null) {
            throw VrjXxtqDMzVbCJJo();
        }
        float fCmawGJmuYuFnQqEA = cmawGJmuYuFnQqEA(iArrFXLPgHvelRnhfHIT, bitMatrix);
        int i = iArrFXLPgHvelRnhfHIT[1];
        int i2 = iArrDnDEHGbIlfaUypzp[1];
        int i3 = iArrFXLPgHvelRnhfHIT[0];
        int i4 = iArrDnDEHGbIlfaUypzp[0];
        if (i3 >= i4 || i >= i2) {
            throw hNiBsoxaEnAACUjO();
        }
        int i5 = i2 - i;
        if (i5 != i4 - i3) {
            i4 = i3 + i5;
            if (i4 >= KZxadOfpYNJuJoyy(bitMatrix)) {
                throw TVhodpGqgEusmAMb();
            }
        }
        int iUIUrwaKFVpxuCLCm = UIUrwaKFVpxuCLCm(((i4 - i3) + 1) / fCmawGJmuYuFnQqEA);
        int iIjQOAHEBKZNDcdxa = ijQOAHEBKZNDcdxa((i5 + 1) / fCmawGJmuYuFnQqEA);
        if (iUIUrwaKFVpxuCLCm <= 0 || iIjQOAHEBKZNDcdxa <= 0) {
            throw RtbMADAympmwCGrT();
        }
        if (iIjQOAHEBKZNDcdxa != iUIUrwaKFVpxuCLCm) {
            throw bbkNmjaRWhrfFhHM();
        }
        int i6 = (int) (fCmawGJmuYuFnQqEA / 2.0f);
        int i7 = i + i6;
        int i8 = i3 + i6;
        int i9 = (((int) ((iUIUrwaKFVpxuCLCm - 1) * fCmawGJmuYuFnQqEA)) + i8) - i4;
        if (i9 > 0) {
            if (i9 > i6) {
                throw VDIqOpUzyflTdFOm();
            }
            i8 -= i9;
        }
        int i10 = (((int) ((iIjQOAHEBKZNDcdxa - 1) * fCmawGJmuYuFnQqEA)) + i7) - i2;
        if (i10 > 0) {
            if (i10 > i6) {
                throw zfJKkjnPFoSfCwnU();
            }
            i7 -= i10;
        }
        com.google.zxing.common.BitMatrix bitMatrix2 = new com.google.zxing.common.BitMatrix(iUIUrwaKFVpxuCLCm, iIjQOAHEBKZNDcdxa);
        for (int i11 = 0; i11 < iIjQOAHEBKZNDcdxa; i11++) {
            int i12 = ((int) (i11 * fCmawGJmuYuFnQqEA)) + i7;
            for (int i13 = 0; i13 < iUIUrwaKFVpxuCLCm; i13++) {
                if (OYfnIakLNPxmnuSp(bitMatrix, ((int) (i13 * fCmawGJmuYuFnQqEA)) + i8, i12)) {
                    bpyclLhVhnuFEUGB(bitMatrix2, i13, i11);
                }
            }
        }
        return bitMatrix2;
    }

    public static int[] FXLPgHvelRnhfHIT(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getTopLeftOnBit();
    }

    public static void GDkEciIXMhYgzdvV(com.google.zxing.qrcode.decoder.QRCodeDecoderMetaData qRCodeDecoderMetaData, com.google.zxing.ResultPoint[] resultPointArr) {
        qRCodeDecoderMetaData.applyMirroredCorrection(resultPointArr);
    }

    public static com.google.zxing.NotFoundException HNiBsoxaEnAACUjO() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static java.util.List HuOgDBYuOoPBQIEx(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getbyteSegments();
    }

    public static bool IaObVkhZLYSOfhMg(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static int IjQOAHEBKZNDcdxa(float f) {
        return java.lang.Math.round(f);
    }

    public static com.google.zxing.ResultPoint[] JQoNYHOgvCWLPGuS(com.google.zxing.common.DetectorResult detectorResult) {
        return detectorResult.getPoints();
    }

    public static void MXymTdHwYCEwqIai(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    private static float ModuleSize(int[] iArr, com.google.zxing.common.BitMatrix bitMatrix) throws com.google.zxing.NotFoundException {
        if ((1 + 29) % 29 > 0) {
        }
        int iOtOMWHRZbdJgtgAt = OtOMWHRZbdJgtgAt(bitMatrix);
        int iFODbyaeFcJYBOQMH = FODbyaeFcJYBOQMH(bitMatrix);
        int i = iArr[0];
        bool z = true;
        int i2 = iArr[1];
        int i3 = 0;
        while (i < iFODbyaeFcJYBOQMH && i2 < iOtOMWHRZbdJgtgAt) {
            if (z != SCdLAYUhEPpUQsrg(bitMatrix, i, i2)) {
                i3++;
                if (i3 == 5) {
                    break;
                }
                z = !z;
            }
            i++;
            i2++;
        }
        if (i == iFODbyaeFcJYBOQMH || i2 == iOtOMWHRZbdJgtgAt) {
            throw MsxLbACAuJzxMsnQ();
        }
        return (i - iArr[0]) / 7.0f;
    }

    public static com.google.zxing.common.DecoderResult NjtBpdIHpsFmikUt(com.google.zxing.qrcode.decoder.Decoder decoder, com.google.zxing.common.BitMatrix bitMatrix, java.util.Dictionary map) {
        return decoder.decode(bitMatrix, (java.util.Dictionary<com.google.zxing.DecodeHintType, ?>) map);
    }

    public static java.lang.int OCpDcgEcJNRWrtfY(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.zxing.common.BitMatrix OPEKzoZcDtcYrdlT(com.google.zxing.common.DetectorResult detectorResult) {
        return detectorResult.getBits();
    }

    public static com.google.zxing.common.BitMatrix QxoGLdEpOhiEdtsR(com.google.zxing.common.BitMatrix bitMatrix) {
        return extractPureBits(bitMatrix);
    }

    public static byte[] TJDFkHFdxscImEjZ(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getRawbytes();
    }

    public static com.google.zxing.Result TuDmnuhkGwJvuqMe(com.google.zxing.qrcode.QRCodeReader qRCodeReader, com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map) {
        return qRCodeReader.decode(binaryBitmap, map);
    }

    public static java.lang.string VkKJhHpZzXcXHUEF(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getText();
    }

    public static java.lang.object VulfPsaFTrrTftGF(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getOther();
    }

    public static com.google.zxing.NotFoundException ZfJKkjnPFoSfCwnU() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public override com.google.zxing.Result Decode(com.google.zxing.BinaryBitmap binaryBitmap) throws com.google.zxing.NotFoundException, com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        return tuDmnuhkGwJvuqMe(this, binaryBitmap, null);
    }

    public override readonly com.google.zxing.Result Decode(com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException, com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        com.google.zxing.common.DecoderResult decoderResultNjtBpdIHpsFmikUt;
        com.google.zxing.ResultPoint[] resultPointArrJQoNYHOgvCWLPGuS;
        if ((8 + 16) % 16 > 0) {
        }
        if (map is not null && iaObVkhZLYSOfhMg(map, com.google.zxing.DecodeHintType.PURE_BARCODE)) {
            decoderResultNjtBpdIHpsFmikUt = SJqwvoPKHNaDnGaO(this.decoder, qxoGLdEpOhiEdtsR(AYDeprIpmgGjdApD(binaryBitmap)), map);
            resultPointArrJQoNYHOgvCWLPGuS = NO_POINTS;
        } else {
            com.google.zxing.common.DetectorResult detectorResultRgKpeCqXhhFOiBno = RgKpeCqXhhFOiBno(new com.google.zxing.qrcode.detector.Detector(TEKWfMIMVxTHdXKl(binaryBitmap)), map);
            decoderResultNjtBpdIHpsFmikUt = njtBpdIHpsFmikUt(this.decoder, oPEKzoZcDtcYrdlT(detectorResultRgKpeCqXhhFOiBno), map);
            resultPointArrJQoNYHOgvCWLPGuS = jQoNYHOgvCWLPGuS(detectorResultRgKpeCqXhhFOiBno);
        }
        if (vulfPsaFTrrTftGF(decoderResultNjtBpdIHpsFmikUt) instanceof com.google.zxing.qrcode.decoder.QRCodeDecoderMetaData) {
            gDkEciIXMhYgzdvV((com.google.zxing.qrcode.decoder.QRCodeDecoderMetaData) ScsaBUNPHskXSbVz(decoderResultNjtBpdIHpsFmikUt), resultPointArrJQoNYHOgvCWLPGuS);
        }
        com.google.zxing.Result result = new com.google.zxing.Result(vkKJhHpZzXcXHUEF(decoderResultNjtBpdIHpsFmikUt), tJDFkHFdxscImEjZ(decoderResultNjtBpdIHpsFmikUt), resultPointArrJQoNYHOgvCWLPGuS, com.google.zxing.BarcodeFormat.QR_CODE);
        java.util.List listHuOgDBYuOoPBQIEx = huOgDBYuOoPBQIEx(decoderResultNjtBpdIHpsFmikUt);
        if (listHuOgDBYuOoPBQIEx is not null) {
            mXymTdHwYCEwqIai(result, com.google.zxing.ResultMetadataType.BYTE_SEGMENTS, listHuOgDBYuOoPBQIEx);
        }
        java.lang.string strDnlJpjDFigcwSwsK = dnlJpjDFigcwSwsK(decoderResultNjtBpdIHpsFmikUt);
        if (strDnlJpjDFigcwSwsK is not null) {
            TgYIzcGkGgEyCYOI(result, com.google.zxing.ResultMetadataType.ERROR_CORRECTION_LEVEL, strDnlJpjDFigcwSwsK);
        }
        if (IzTskipDsCIeWNwe(decoderResultNjtBpdIHpsFmikUt)) {
            OgEANtmsurgyKjQx(result, com.google.zxing.ResultMetadataType.STRUCTURED_APPEND_SEQUENCE, bVrcofjcSdNKsVYM(QRJbReAcoDodGlEJ(decoderResultNjtBpdIHpsFmikUt)));
            DjbVxvfHSExBHKzW(result, com.google.zxing.ResultMetadataType.STRUCTURED_APPEND_PARITY, oCpDcgEcJNRWrtfY(ThXwIPnvnEiElEoN(decoderResultNjtBpdIHpsFmikUt)));
        }
        KOjErlDZbjFFIzKT(result, com.google.zxing.ResultMetadataType.SYMBOLOGY_IDENTIFIER, JfHClWGDGsRqoNSJ(DILEliCRSIQpOQdn(new java.lang.stringBuilder("]Q"), IQdyUKBKBZjZXjAO(decoderResultNjtBpdIHpsFmikUt))));
        return result;
    }

    protected readonly com.google.zxing.qrcode.decoder.Decoder GetDecoder() {
        return this.decoder;
    }

    public override void Reset() {
    }
}

