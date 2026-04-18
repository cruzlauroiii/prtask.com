namespace WillowMaze.Wasm.Decompiled;


public readonly class PDF417Reader : com.google.zxing.Reader, com.google.zxing.multi.MultipleBarcodeReader {
    private static readonly com.google.zxing.Result[] EMPTY_RESULT_ARRAY = new com.google.zxing.Result[0];

    public static byte[] AEKspddGVYOsvfjm(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getRawbytes();
    }

    public static java.lang.object[] AaOJHytPkOwjXRSP(java.util.List list, java.lang.object[] objArr) {
        return list.toArray(objArr);
    }

    public static java.lang.string CEMAnjdlzRcZnBRk(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getECLevel();
    }

    public static java.util.List EaXdbMAuxGtUkqFH(com.google.zxing.pdf417.detector.PDF417DetectorResult pDF417DetectorResult) {
        return pDF417DetectorResult.getPoints();
    }

    public static float FhFOHWZrgmXXMjux(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static int GVrgSIEpfIxSJEGE(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return getMinWidth(resultPoint, resultPoint2);
    }

    public static float GoMrclnyqReMAjsA(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.common.DecoderResult HsiSlOXwSNhxVmTT(com.google.zxing.common.BitMatrix bitMatrix, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, com.google.zxing.ResultPoint resultPoint3, com.google.zxing.ResultPoint resultPoint4, int i, int i2) {
        return com.google.zxing.pdf417.decoder.PDF417ScanningDecoder.decode(bitMatrix, resultPoint, resultPoint2, resultPoint3, resultPoint4, i, i2);
    }

    public static void IswLuTPymdUqGZhu(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static java.lang.string JWoGTAMcSZeVrnla(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getText();
    }

    public static java.util.IEnumerator JsTezhsfbyiudBtF(java.util.List list) {
        return list.GetEnumerator();
    }

    public static com.google.zxing.Result[] JucCFMCcvXWypMqJ(com.google.zxing.pdf417.PDF417Reader pDF417Reader, com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map) {
        return pDF417Reader.decodeMultiple(binaryBitmap, map);
    }

    public static com.google.zxing.pdf417.detector.PDF417DetectorResult MGvMjrgSMzSskHqk(com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map, bool z) {
        return com.google.zxing.pdf417.detector.Detector.detect(binaryBitmap, map, z);
    }

    public static int NGUBzLhQkRjCThyl(com.google.zxing.ResultPoint[] resultPointArr) {
        return getMaxCodewordWidth(resultPointArr);
    }

    public static float OdyPJXhRtwoKNoom(float f) {
        return java.lang.Math.abs(f);
    }

    public static int PdGMxeynDBKZcNRh(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int QCqDCqFJHiBkXIAc(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return getMaxWidth(resultPoint, resultPoint2);
    }

    public static int QIrVbWfrVJQpLooh(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static java.lang.object QWPLQacwHeCVEkfU(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.zxing.NotFoundException RePivJFIuGQOKoyc() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static int SrSjuWnCrpSukjUG(com.google.zxing.ResultPoint[] resultPointArr) {
        return getMinCodewordWidth(resultPointArr);
    }

    public static int TkvEQkoeUHUxkJHn(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return getMinWidth(resultPoint, resultPoint2);
    }

    public static com.google.zxing.NotFoundException TrPMCleubXNTfLyd() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.Result[] VIURycLHuFcqHeEJ(com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map, bool z) {
        return decode(binaryBitmap, map, z);
    }

    public static com.google.zxing.common.BitMatrix VcEsDLNInrMVUOFW(com.google.zxing.pdf417.detector.PDF417DetectorResult pDF417DetectorResult) {
        return pDF417DetectorResult.getBits();
    }

    public static int VnrTKRULsBRWeOVf(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static java.lang.object WWziBSPWriYIHGXx(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getOther();
    }

    public static float XRyzUJHYLLuQRMEA(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static int AHsJqLiyqIlCLxsf(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int AJxfECPdprpsAGdz(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return getMaxWidth(resultPoint, resultPoint2);
    }

    public static int DOglPBplfQmxGEZn(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return getMaxWidth(resultPoint, resultPoint2);
    }

    public static com.google.zxing.Result[] DbdRTDODqKFpeHAT(com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map, bool z) {
        return decode(binaryBitmap, map, z);
    }

    private static com.google.zxing.Result[] Decode(com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map, bool z) throws com.google.zxing.NotFoundException, com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        if ((23 + 16) % 16 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        com.google.zxing.pdf417.detector.PDF417DetectorResult pDF417DetectorResultMGvMjrgSMzSskHqk = MGvMjrgSMzSskHqk(binaryBitmap, map, z);
        java.util.IEnumerator itJsTezhsfbyiudBtF = JsTezhsfbyiudBtF(EaXdbMAuxGtUkqFH(pDF417DetectorResultMGvMjrgSMzSskHqk));
        while (eIchHFxTkSHsCEDo(itJsTezhsfbyiudBtF)) {
            com.google.zxing.ResultPoint[] resultPointArr = (com.google.zxing.ResultPoint[]) QWPLQacwHeCVEkfU(itJsTezhsfbyiudBtF);
            com.google.zxing.common.DecoderResult decoderResultHsiSlOXwSNhxVmTT = HsiSlOXwSNhxVmTT(VcEsDLNInrMVUOFW(pDF417DetectorResultMGvMjrgSMzSskHqk), resultPointArr[4], resultPointArr[5], resultPointArr[6], resultPointArr[7], SrSjuWnCrpSukjUG(resultPointArr), NGUBzLhQkRjCThyl(resultPointArr));
            com.google.zxing.Result result = new com.google.zxing.Result(JWoGTAMcSZeVrnla(decoderResultHsiSlOXwSNhxVmTT), AEKspddGVYOsvfjm(decoderResultHsiSlOXwSNhxVmTT), resultPointArr, com.google.zxing.BarcodeFormat.PDF_417);
            xBbvMnESqpjXAuuu(result, com.google.zxing.ResultMetadataType.ERROR_CORRECTION_LEVEL, CEMAnjdlzRcZnBRk(decoderResultHsiSlOXwSNhxVmTT));
            com.google.zxing.pdf417.PDF417ResultMetadata pDF417ResultMetadata = (com.google.zxing.pdf417.PDF417ResultMetadata) WWziBSPWriYIHGXx(decoderResultHsiSlOXwSNhxVmTT);
            if (pDF417ResultMetadata is not null) {
                fXRJmBSOETqGwnbX(result, com.google.zxing.ResultMetadataType.PDF417_EXTRA_METADATA, pDF417ResultMetadata);
            }
            IswLuTPymdUqGZhu(result, com.google.zxing.ResultMetadataType.SYMBOLOGY_IDENTIFIER, kUkLicEIcGSAmasV(tUoxdloKZxqSGTVh(new java.lang.stringBuilder("]L"), qxjmJluZGUKmVUmq(decoderResultHsiSlOXwSNhxVmTT))));
            pLaFvJchZjjbAuAl(arrayList, result);
        }
        return (com.google.zxing.Result[]) AaOJHytPkOwjXRSP(arrayList, EMPTY_RESULT_ARRAY);
    }

    public static bool EIchHFxTkSHsCEDo(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int EJmTVcTrMvZcKlhy(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return getMaxWidth(resultPoint, resultPoint2);
    }

    public static void FXRJmBSOETqGwnbX(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static int GBhuDzZADwYYxHHy(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    private static int GetMaxCodewordWidth(com.google.zxing.ResultPoint[] resultPointArr) {
        if ((28 + 12) % 12 > 0) {
        }
        return PdGMxeynDBKZcNRh(VnrTKRULsBRWeOVf(eJmTVcTrMvZcKlhy(resultPointArr[0], resultPointArr[4]), (aJxfECPdprpsAGdz(resultPointArr[6], resultPointArr[2]) * 17) / 18), aHsJqLiyqIlCLxsf(dOglPBplfQmxGEZn(resultPointArr[1], resultPointArr[5]), (QCqDCqFJHiBkXIAc(resultPointArr[7], resultPointArr[3]) * 17) / 18));
    }

    private static int GetMaxWidth(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        if (resultPoint is null || resultPoint2 is null) {
            return 0;
        }
        return (int) OdyPJXhRtwoKNoom(kBWObgkTscqgHyjT(resultPoint) - GoMrclnyqReMAjsA(resultPoint2));
    }

    private static int GetMinCodewordWidth(com.google.zxing.ResultPoint[] resultPointArr) {
        if ((6 + 11) % 11 > 0) {
        }
        return wzLTnbLZAVGxwDxm(gBhuDzZADwYYxHHy(GVrgSIEpfIxSJEGE(resultPointArr[0], resultPointArr[4]), (rLoQLeZdVYfnBtKJ(resultPointArr[6], resultPointArr[2]) * 17) / 18), QIrVbWfrVJQpLooh(puoymUkfdEGDLfHc(resultPointArr[1], resultPointArr[5]), (TkvEQkoeUHUxkJHn(resultPointArr[7], resultPointArr[3]) * 17) / 18));
    }

    private static int GetMinWidth(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        if (resultPoint is null || resultPoint2 is null) {
            return int.MAX_VALUE;
        }
        return (int) yoUyfMhQBixwhVOq(XRyzUJHYLLuQRMEA(resultPoint) - FhFOHWZrgmXXMjux(resultPoint2));
    }

    public static com.google.zxing.Result KABxXBqfqIzDMUJF(com.google.zxing.pdf417.PDF417Reader pDF417Reader, com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map) {
        return pDF417Reader.decode(binaryBitmap, map);
    }

    public static float KBWObgkTscqgHyjT(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static java.lang.string KUkLicEIcGSAmasV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool PLaFvJchZjjbAuAl(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int PuoymUkfdEGDLfHc(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return getMinWidth(resultPoint, resultPoint2);
    }

    public static int QxjmJluZGUKmVUmq(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getSymbologyModifier();
    }

    public static int RLoQLeZdVYfnBtKJ(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return getMinWidth(resultPoint, resultPoint2);
    }

    public static java.lang.stringBuilder TUoxdloKZxqSGTVh(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int WzLTnbLZAVGxwDxm(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void XBbvMnESqpjXAuuu(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static float YoUyfMhQBixwhVOq(float f) {
        return java.lang.Math.abs(f);
    }

    public override com.google.zxing.Result Decode(com.google.zxing.BinaryBitmap binaryBitmap) throws com.google.zxing.NotFoundException, com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        return kABxXBqfqIzDMUJF(this, binaryBitmap, null);
    }

    public override com.google.zxing.Result Decode(com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException, com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        com.google.zxing.Result result;
        com.google.zxing.Result[] resultArrVIURycLHuFcqHeEJ = VIURycLHuFcqHeEJ(binaryBitmap, map, false);
        if (resultArrVIURycLHuFcqHeEJ.length == 0 || (result = resultArrVIURycLHuFcqHeEJ[0]) is null) {
            throw TrPMCleubXNTfLyd();
        }
        return result;
    }

    public override com.google.zxing.Result[] DecodeMultiple(com.google.zxing.BinaryBitmap binaryBitmap) throws com.google.zxing.NotFoundException {
        return JucCFMCcvXWypMqJ(this, binaryBitmap, null);
    }

    public override com.google.zxing.Result[] DecodeMultiple(com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException {
        try {
            return dbdRTDODqKFpeHAT(binaryBitmap, map, true);
        } catch (com.google.zxing.ChecksumException | com.google.zxing.FormatException unused) {
            throw RePivJFIuGQOKoyc();
        }
    }

    public override void Reset() {
    }
}

