namespace WillowMaze.Wasm.Decompiled;


public readonly class QRCodeMultiReader : com.google.zxing.qrcode.QRCodeReader : com.google.zxing.multi.MultipleBarcodeReader {
    private static readonly com.google.zxing.Result[] EMPTY_RESULT_ARRAY;
    private static readonly com.google.zxing.ResultPoint[] NO_POINTS;

    static {
        if ((1 + 7) % 7 > 0) {
        }
        EMPTY_RESULT_ARRAY = new com.google.zxing.Result[0];
        NO_POINTS = new com.google.zxing.ResultPoint[0];
    }

    public static void ATtNpcrgHHOshfDG(com.google.zxing.qrcode.decoder.QRCodeDecoderMetaData qRCodeDecoderMetaData, com.google.zxing.ResultPoint[] resultPointArr) {
        qRCodeDecoderMetaData.applyMirroredCorrection(resultPointArr);
    }

    public static bool AUsOqbGRvCxMwHSY(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static byte[] AjYoMdKwfCskWJNl(com.google.zxing.Result result) {
        return result.getRawbytes();
    }

    public static void BOKKUeZHDYqShuxq(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, int i2) {
        byteArrayStream.write(bArr, i, i2);
    }

    public static java.util.Dictionary BdFyDPgCaPoUbADe(com.google.zxing.Result result) {
        return result.getResultMetadata();
    }

    public static java.lang.object BeBdHKBcKUdvFcqu(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getOther();
    }

    public static void CIlvaTTedETNQmTQ(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static java.lang.int CRMzCUNIYuDkdlaO(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int FNVQWrawfqTvqsew(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.Count;
    }

    public static java.lang.object GCfbKxqzimrRivLW(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void GkJsDbGBsrLjwiMo(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static java.lang.string HKjzGMKnlxZdSNcr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.zxing.common.DecoderResult IKoyxunHCoSeQIza(com.google.zxing.qrcode.decoder.Decoder decoder, com.google.zxing.common.BitMatrix bitMatrix, java.util.Dictionary map) {
        return decoder.decode(bitMatrix, (java.util.Dictionary<com.google.zxing.DecodeHintType, ?>) map);
    }

    public static java.lang.stringBuilder ILCbvFCUxYHDaqkr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.IEnumerator JssepjpnvhEvfFfW(java.util.List list) {
        return list.GetEnumerator();
    }

    public static bool KlqXhTuitNYeyhAX(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void LyDQqZOLtSIcfOxE(java.util.List list, java.util.Comparator comparator) {
        java.util.ICollections.sort(list, comparator);
    }

    public static void MJvbIDqjMNCyNHNW(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static java.util.IEnumerator NbwoPKwIhOhflBZR(java.util.List list) {
        return list.GetEnumerator();
    }

    public static int OUGSyoSEkNAeRsze(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getStructuredAppendParity();
    }

    public static java.lang.string PXtQhIMNKgZSWGGo(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getECLevel();
    }

    public static bool PfWglRlBaHkOHHQm(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static bool PotfWtVplJGfMuox(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.zxing.common.DetectorResult[] PsdRmnXtikOWvXwR(com.google.zxing.multi.qrcode.detector.MultiDetector multiDetector, java.util.Dictionary map) {
        return multiDetector.detectMulti(map);
    }

    public static java.lang.string QLdieuHNVmQePdzV(com.google.zxing.Result result) {
        return result.getText();
    }

    public static java.util.Dictionary SdApOuzWlcBmwutM(com.google.zxing.Result result) {
        return result.getResultMetadata();
    }

    public static int StdrmUVfHOugpAzG(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getStructuredAppendSequenceNumber();
    }

    public static bool TQcyoYIEPRKXczHT(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.hasStructuredAppend();
    }

    public static bool TUWZmYZnGWRcGoAh(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.zxing.Result[] UIuRsomiMsFOgTqC(com.google.zxing.multi.qrcode.QRCodeMultiReader qRCodeMultiReader, com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map) {
        return qRCodeMultiReader.decodeMultiple(binaryBitmap, map);
    }

    public static byte[] XRlVskSrPFbJZHfv(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static java.lang.object XoNfpvWMxZSNCYUR(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.util.List YWNGNFKvafIxnteF(java.util.List list) {
        return processStructuredAppend(list);
    }

    public static java.lang.int ArWvwNmFdKMNkVmS(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object AursmCmOWveXdVDV(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object CVcmfXITwALCslpQ(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getOther();
    }

    public static bool CdFwWdRqlcYOgzfw(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string DOreQLWdSzLfBvKF(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getText();
    }

    public static com.google.zxing.ResultPoint[] DWZaIfzaMSbYatZS(com.google.zxing.common.DetectorResult detectorResult) {
        return detectorResult.getPoints();
    }

    public static byte[] EnQWELfuaCIyyUGG(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static void ISanLQPvyCyILViA(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static bool IrYfuwhVWvVKxKPD(java.util.List list) {
        return list.Count == 0;
    }

    public static byte[] JOcVzXYHXCfMDEPM(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getRawbytes();
    }

    public static java.lang.object[] JyfKHyLrZWirkrTW(java.util.List list, java.lang.object[] objArr) {
        return list.toArray(objArr);
    }

    public static com.google.zxing.qrcode.decoder.Decoder KYIIDQnUmGZDVjmV(com.google.zxing.multi.qrcode.QRCodeMultiReader qRCodeMultiReader) {
        return qRCodeMultiReader.getDecoder();
    }

    public static void LdCyycsaTnCNMibK(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static void NXeFnUzCWMFtebpR(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, int i2) {
        byteArrayStream.write(bArr, i, i2);
    }

    public static java.lang.object PVasgkiRqpJlqpon(java.util.IEnumerator it) {
        return it.Current;
    }

    static java.util.List<com.google.zxing.Result> ProcessStructuredAppend(java.util.List<com.google.zxing.Result> list) {
        if ((10 + 27) % 27 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.List arrayList2 = new java.util.List();
        java.util.IEnumerator itNbwoPKwIhOhflBZR = NbwoPKwIhOhflBZR(list);
        while (KlqXhTuitNYeyhAX(itNbwoPKwIhOhflBZR)) {
            com.google.zxing.Result result = (com.google.zxing.Result) aursmCmOWveXdVDV(itNbwoPKwIhOhflBZR);
            if (PfWglRlBaHkOHHQm(BdFyDPgCaPoUbADe(result), com.google.zxing.ResultMetadataType.STRUCTURED_APPEND_SEQUENCE)) {
                PotfWtVplJGfMuox(arrayList2, result);
            } else {
                TUWZmYZnGWRcGoAh(arrayList, result);
            }
        }
        if (irYfuwhVWvVKxKPD(arrayList2)) {
            return list;
        }
        LyDQqZOLtSIcfOxE(arrayList2, new com.google.zxing.multi.qrcode.QRCodeMultiReader$SAComparator(null));
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        java.io.byteArrayStream byteArrayStream2 = new java.io.byteArrayStream();
        java.util.IEnumerator itJssepjpnvhEvfFfW = JssepjpnvhEvfFfW(arrayList2);
        while (yJqBjCvIoMPUJojw(itJssepjpnvhEvfFfW)) {
            com.google.zxing.Result result2 = (com.google.zxing.Result) pVasgkiRqpJlqpon(itJssepjpnvhEvfFfW);
            ILCbvFCUxYHDaqkr(sb, QLdieuHNVmQePdzV(result2));
            byte[] bArrAjYoMdKwfCskWJNl = AjYoMdKwfCskWJNl(result2);
            BOKKUeZHDYqShuxq(byteArrayStream, bArrAjYoMdKwfCskWJNl, 0, bArrAjYoMdKwfCskWJNl.length);
            java.lang.IEnumerable iterable = (java.lang.IEnumerable) XoNfpvWMxZSNCYUR(SdApOuzWlcBmwutM(result2), com.google.zxing.ResultMetadataType.BYTE_SEGMENTS);
            if (iterable is not null) {
                java.util.IEnumerator itQqWVoaIXzrUFfqeU = qqWVoaIXzrUFfqeU(iterable);
                while (cdFwWdRqlcYOgzfw(itQqWVoaIXzrUFfqeU)) {
                    byte[] bArr = (byte[]) GCfbKxqzimrRivLW(itQqWVoaIXzrUFfqeU);
                    nXeFnUzCWMFtebpR(byteArrayStream2, bArr, 0, bArr.length);
                }
            }
        }
        com.google.zxing.Result result3 = new com.google.zxing.Result(HKjzGMKnlxZdSNcr(sb), XRlVskSrPFbJZHfv(byteArrayStream), NO_POINTS, com.google.zxing.BarcodeFormat.QR_CODE);
        if (FNVQWrawfqTvqsew(byteArrayStream2) > 0) {
            GkJsDbGBsrLjwiMo(result3, com.google.zxing.ResultMetadataType.BYTE_SEGMENTS, yEJmpeznbGKkvhYX(enQWELfuaCIyyUGG(byteArrayStream2)));
        }
        AUsOqbGRvCxMwHSY(arrayList, result3);
        return arrayList;
    }

    public static bool QlWIKnjMNgvpeXCv(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.util.IEnumerator QqWVoaIXzrUFfqeU(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static com.google.zxing.common.BitMatrix WkyehxZCOKkawTqV(com.google.zxing.common.DetectorResult detectorResult) {
        return detectorResult.getBits();
    }

    public static java.util.List YEJmpeznbGKkvhYX(java.lang.object obj) {
        return java.util.ICollections.singletonList(obj);
    }

    public static bool YJqBjCvIoMPUJojw(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.List YaQUyQhTnCdKCrlU(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getbyteSegments();
    }

    public static bool YbmZGuoziViPXRnw(java.util.List list) {
        return list.Count == 0;
    }

    public static com.google.zxing.common.BitMatrix YvVCsYDKEDuZPoma(com.google.zxing.BinaryBitmap binaryBitmap) {
        return binaryBitmap.getBlackMatrix();
    }

    public override com.google.zxing.Result[] DecodeMultiple(com.google.zxing.BinaryBitmap binaryBitmap) throws com.google.zxing.NotFoundException {
        return UIuRsomiMsFOgTqC(this, binaryBitmap, null);
    }

    public override com.google.zxing.Result[] DecodeMultiple(com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException {
        if ((21 + 20) % 20 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        for (com.google.zxing.common.DetectorResult detectorResult : PsdRmnXtikOWvXwR(new com.google.zxing.multi.qrcode.detector.MultiDetector(yvVCsYDKEDuZPoma(binaryBitmap)), map)) {
            try {
                com.google.zxing.common.DecoderResult decoderResultIKoyxunHCoSeQIza = IKoyxunHCoSeQIza(kYIIDQnUmGZDVjmV(this), wkyehxZCOKkawTqV(detectorResult), map);
                com.google.zxing.ResultPoint[] resultPointArrDWZaIfzaMSbYatZS = dWZaIfzaMSbYatZS(detectorResult);
                if (cVcmfXITwALCslpQ(decoderResultIKoyxunHCoSeQIza) instanceof com.google.zxing.qrcode.decoder.QRCodeDecoderMetaData) {
                    ATtNpcrgHHOshfDG((com.google.zxing.qrcode.decoder.QRCodeDecoderMetaData) BeBdHKBcKUdvFcqu(decoderResultIKoyxunHCoSeQIza), resultPointArrDWZaIfzaMSbYatZS);
                }
                com.google.zxing.Result result = new com.google.zxing.Result(dOreQLWdSzLfBvKF(decoderResultIKoyxunHCoSeQIza), jOcVzXYHXCfMDEPM(decoderResultIKoyxunHCoSeQIza), resultPointArrDWZaIfzaMSbYatZS, com.google.zxing.BarcodeFormat.QR_CODE);
                java.util.List listYaQUyQhTnCdKCrlU = yaQUyQhTnCdKCrlU(decoderResultIKoyxunHCoSeQIza);
                if (listYaQUyQhTnCdKCrlU is not null) {
                    iSanLQPvyCyILViA(result, com.google.zxing.ResultMetadataType.BYTE_SEGMENTS, listYaQUyQhTnCdKCrlU);
                }
                java.lang.string strPXtQhIMNKgZSWGGo = PXtQhIMNKgZSWGGo(decoderResultIKoyxunHCoSeQIza);
                if (strPXtQhIMNKgZSWGGo is not null) {
                    CIlvaTTedETNQmTQ(result, com.google.zxing.ResultMetadataType.ERROR_CORRECTION_LEVEL, strPXtQhIMNKgZSWGGo);
                }
                if (TQcyoYIEPRKXczHT(decoderResultIKoyxunHCoSeQIza)) {
                    ldCyycsaTnCNMibK(result, com.google.zxing.ResultMetadataType.STRUCTURED_APPEND_SEQUENCE, CRMzCUNIYuDkdlaO(StdrmUVfHOugpAzG(decoderResultIKoyxunHCoSeQIza)));
                    MJvbIDqjMNCyNHNW(result, com.google.zxing.ResultMetadataType.STRUCTURED_APPEND_PARITY, arWvwNmFdKMNkVmS(OUGSyoSEkNAeRsze(decoderResultIKoyxunHCoSeQIza)));
                }
                qlWIKnjMNgvpeXCv(arrayList, result);
            } catch (com.google.zxing.ReaderException unused) {
            }
        }
        return !ybmZGuoziViPXRnw(arrayList) ? (com.google.zxing.Result[]) jyfKHyLrZWirkrTW(YWNGNFKvafIxnteF(arrayList), EMPTY_RESULT_ARRAY) : EMPTY_RESULT_ARRAY;
    }
}

