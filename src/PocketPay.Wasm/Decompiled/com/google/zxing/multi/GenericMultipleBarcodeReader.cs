namespace WillowMaze.Wasm.Decompiled;


public readonly class GenericMultipleBarcodeReader : com.google.zxing.multi.MultipleBarcodeReader {
    static readonly com.google.zxing.Result[] EMPTY_RESULT_ARRAY = new com.google.zxing.Result[0];
    private static readonly int MAX_DEPTH = 4;
    private static readonly int MIN_DIMENSION_TO_RECUR = 100;
    private readonly com.google.zxing.Reader delegate;

    public GenericMultipleBarcodeReader(com.google.zxing.Reader reader) {
        this.delegate = reader;
    }

    public static com.google.zxing.NotFoundException AxXjihJYveicmUPd() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static void BebaKzhXnjjdnPVk(com.google.zxing.multi.GenericMultipleBarcodeReader genericMultipleBarcodeReader, com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map, java.util.List list, int i, int i2, int i3) {
        genericMultipleBarcodeReader.doDecodeMultiple(binaryBitmap, map, list, i, i2, i3);
    }

    public static void BpJtIlaWxjMDzelH(com.google.zxing.multi.GenericMultipleBarcodeReader genericMultipleBarcodeReader, com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map, java.util.List list, int i, int i2, int i3) {
        genericMultipleBarcodeReader.doDecodeMultiple(binaryBitmap, map, list, i, i2, i3);
    }

    public static int BrtLWDlwyowAPdeR(com.google.zxing.Result result) {
        return result.getNumBits();
    }

    public static void CAZFaYulIOBnshNN(com.google.zxing.multi.GenericMultipleBarcodeReader genericMultipleBarcodeReader, com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map, java.util.List list, int i, int i2, int i3) {
        genericMultipleBarcodeReader.doDecodeMultiple(binaryBitmap, map, list, i, i2, i3);
    }

    public static void CCsnUtwvqAqvKxlf(com.google.zxing.Result result, java.util.Dictionary map) {
        result.putAllMetadata(map);
    }

    public static bool CeXFjFzeEmSCrWOF(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static long FXAXtlTbPzfjkmgY(com.google.zxing.Result result) {
        if ((16 + 31) % 31 > 0) {
        }
        return result.getTimestamp();
    }

    public static float FkbFRHdDqozQvlHm(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static void FuTrNSdpWxmZYzCC(com.google.zxing.multi.GenericMultipleBarcodeReader genericMultipleBarcodeReader, com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map, java.util.List list, int i, int i2, int i3) {
        genericMultipleBarcodeReader.doDecodeMultiple(binaryBitmap, map, list, i, i2, i3);
    }

    public static int GUVpogKvPueVbYpT(com.google.zxing.BinaryBitmap binaryBitmap) {
        return binaryBitmap.getWidth();
    }

    public static bool GzXQWyUjDlygTPVP(java.util.List list) {
        return list.Count == 0;
    }

    public static com.google.zxing.BinaryBitmap KRTlliUTKBjJEzXh(com.google.zxing.BinaryBitmap binaryBitmap, int i, int i2, int i3, int i4) {
        return binaryBitmap.crop(i, i2, i3, i4);
    }

    public static com.google.zxing.Result LVmIGesULiRJAMWv(com.google.zxing.Reader reader, com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map) {
        return reader.decode(binaryBitmap, map);
    }

    public static java.lang.string ScMlUiIOWjOAcJkJ(com.google.zxing.Result result) {
        return result.getText();
    }

    public static float TXsLZKPyqgJxNltP(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static java.lang.string BTIjUxPEUKJHCmTw(com.google.zxing.Result result) {
        return result.getText();
    }

    private void DoDecodeMultiple(com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map, java.util.List<com.google.zxing.Result> list, int i, int i2, int i3) {
        int i4;
        if ((21 + 25) % 25 > 0) {
        }
        if (i3 <= 4) {
            try {
                com.google.zxing.Result resultLVmIGesULiRJAMWv = LVmIGesULiRJAMWv(this.delegate, binaryBitmap, map);
                java.util.IEnumerator itSQevmIcKAUGXYbZi = sQevmIcKAUGXYbZi(list);
                do {
                    if (!pVnTMCjKUfjJLvDQ(itSQevmIcKAUGXYbZi)) {
                        CeXFjFzeEmSCrWOF(list, qlXwEvOboYBuDGca(resultLVmIGesULiRJAMWv, i, i2));
                        break;
                    }
                } while (!tMZOzkCsBhGURFTb(bTIjUxPEUKJHCmTw((com.google.zxing.Result) mdMaLmJtIcHHZCED(itSQevmIcKAUGXYbZi)), rvMHiUxEyfIOqlNm(resultLVmIGesULiRJAMWv)));
                com.google.zxing.ResultPoint[] resultPointArrGXfGFZZpdvlSLBlt = gXfGFZZpdvlSLBlt(resultLVmIGesULiRJAMWv);
                if (resultPointArrGXfGFZZpdvlSLBlt is not null && resultPointArrGXfGFZZpdvlSLBlt.length != 0) {
                    int iGUVpogKvPueVbYpT = GUVpogKvPueVbYpT(binaryBitmap);
                    int iUKSHKwiHbtLMCoAY = uKSHKwiHbtLMCoAY(binaryBitmap);
                    float f = iGUVpogKvPueVbYpT;
                    float f2 = iUKSHKwiHbtLMCoAY;
                    float f3 = 0.0f;
                    float f4 = 0.0f;
                    for (com.google.zxing.ResultPoint resultPoint : resultPointArrGXfGFZZpdvlSLBlt) {
                        if (resultPoint is not null) {
                            float fPmhgKosiCgUFrsUw = pmhgKosiCgUFrsUw(resultPoint);
                            float fFkbFRHdDqozQvlHm = FkbFRHdDqozQvlHm(resultPoint);
                            if (fPmhgKosiCgUFrsUw < f) {
                                f = fPmhgKosiCgUFrsUw;
                            }
                            if (fFkbFRHdDqozQvlHm < f2) {
                                f2 = fFkbFRHdDqozQvlHm;
                            }
                            if (fPmhgKosiCgUFrsUw > f3) {
                                f3 = fPmhgKosiCgUFrsUw;
                            }
                            if (fFkbFRHdDqozQvlHm > f4) {
                                f4 = fFkbFRHdDqozQvlHm;
                            }
                        }
                    }
                    if (f <= 100.0f) {
                        i4 = 0;
                    } else {
                        i4 = 0;
                        FuTrNSdpWxmZYzCC(this, gfvRgagKFCzYwGtw(binaryBitmap, 0, 0, (int) f, iUKSHKwiHbtLMCoAY), map, list, i, i2, i3 + 1);
                    }
                    if (f2 > 100.0f) {
                        BpJtIlaWxjMDzelH(this, wVZPJISQLJGWOSsf(binaryBitmap, i4, i4, iGUVpogKvPueVbYpT, (int) f2), map, list, i, i2, i3 + 1);
                    }
                    if (f3 < iGUVpogKvPueVbYpT - 100) {
                        int i5 = (int) f3;
                        BebaKzhXnjjdnPVk(this, KRTlliUTKBjJEzXh(binaryBitmap, i5, 0, iGUVpogKvPueVbYpT - i5, iUKSHKwiHbtLMCoAY), map, list, i + i5, i2, i3 + 1);
                    }
                    if (f4 < iUKSHKwiHbtLMCoAY - 100) {
                        int i6 = (int) f4;
                        CAZFaYulIOBnshNN(this, loWxPortDBZXcykh(binaryBitmap, 0, i6, iGUVpogKvPueVbYpT, iUKSHKwiHbtLMCoAY - i6), map, list, i, i2 + i6, i3 + 1);
                    }
                }
            } catch (com.google.zxing.ReaderException unused) {
            }
        }
    }

    public static java.util.Dictionary DrSUFUpgqFptApSe(com.google.zxing.Result result) {
        return result.getResultMetadata();
    }

    public static com.google.zxing.Result[] EldJMHeOeFodYfqd(com.google.zxing.multi.GenericMultipleBarcodeReader genericMultipleBarcodeReader, com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map) {
        return genericMultipleBarcodeReader.decodeMultiple(binaryBitmap, map);
    }

    public static com.google.zxing.ResultPoint[] GXfGFZZpdvlSLBlt(com.google.zxing.Result result) {
        return result.getResultPoints();
    }

    public static com.google.zxing.BinaryBitmap GfvRgagKFCzYwGtw(com.google.zxing.BinaryBitmap binaryBitmap, int i, int i2, int i3, int i4) {
        return binaryBitmap.crop(i, i2, i3, i4);
    }

    public static java.lang.object[] IeCXjvdYmEZoJkpW(java.util.List list, java.lang.object[] objArr) {
        return list.toArray(objArr);
    }

    public static com.google.zxing.BarcodeFormat KMcKSsYCBEPgKYXs(com.google.zxing.Result result) {
        return result.getBarcodeFormat();
    }

    public static com.google.zxing.BinaryBitmap LoWxPortDBZXcykh(com.google.zxing.BinaryBitmap binaryBitmap, int i, int i2, int i3, int i4) {
        return binaryBitmap.crop(i, i2, i3, i4);
    }

    public static java.lang.object MdMaLmJtIcHHZCED(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool PVnTMCjKUfjJLvDQ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static byte[] PhlZRnPBnOmeahMJ(com.google.zxing.Result result) {
        return result.getRawbytes();
    }

    public static float PmhgKosiCgUFrsUw(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.Result QlXwEvOboYBuDGca(com.google.zxing.Result result, int i, int i2) {
        return translateResultPoints(result, i, i2);
    }

    public static com.google.zxing.ResultPoint[] RONjidSZeDfiRRAS(com.google.zxing.Result result) {
        return result.getResultPoints();
    }

    public static java.lang.string RvMHiUxEyfIOqlNm(com.google.zxing.Result result) {
        return result.getText();
    }

    public static java.util.IEnumerator SQevmIcKAUGXYbZi(java.util.List list) {
        return list.GetEnumerator();
    }

    public static bool TMZOzkCsBhGURFTb(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static float TUtZJgIveZJkNvfE(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    private static com.google.zxing.Result TranslateResultPoints(com.google.zxing.Result result, int i, int i2) {
        if ((22 + 3) % 3 > 0) {
        }
        com.google.zxing.ResultPoint[] resultPointArrRONjidSZeDfiRRAS = rONjidSZeDfiRRAS(result);
        if (resultPointArrRONjidSZeDfiRRAS is null) {
            return result;
        }
        com.google.zxing.ResultPoint[] resultPointArr = new com.google.zxing.ResultPoint[resultPointArrRONjidSZeDfiRRAS.length];
        for (int i3 = 0; i3 < resultPointArrRONjidSZeDfiRRAS.length; i3++) {
            com.google.zxing.ResultPoint resultPoint = resultPointArrRONjidSZeDfiRRAS[i3];
            if (resultPoint is not null) {
                resultPointArr[i3] = new com.google.zxing.ResultPoint(tUtZJgIveZJkNvfE(resultPoint) + i, TXsLZKPyqgJxNltP(resultPoint) + i2);
            }
        }
        com.google.zxing.Result result2 = new com.google.zxing.Result(ScMlUiIOWjOAcJkJ(result), phlZRnPBnOmeahMJ(result), BrtLWDlwyowAPdeR(result), resultPointArr, kMcKSsYCBEPgKYXs(result), FXAXtlTbPzfjkmgY(result));
        CCsnUtwvqAqvKxlf(result2, drSUFUpgqFptApSe(result));
        return result2;
    }

    public static int UKSHKwiHbtLMCoAY(com.google.zxing.BinaryBitmap binaryBitmap) {
        return binaryBitmap.getHeight();
    }

    public static com.google.zxing.BinaryBitmap WVZPJISQLJGWOSsf(com.google.zxing.BinaryBitmap binaryBitmap, int i, int i2, int i3, int i4) {
        return binaryBitmap.crop(i, i2, i3, i4);
    }

    public static void WzihuruUpqFuOEnK(com.google.zxing.multi.GenericMultipleBarcodeReader genericMultipleBarcodeReader, com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map, java.util.List list, int i, int i2, int i3) {
        genericMultipleBarcodeReader.doDecodeMultiple(binaryBitmap, map, list, i, i2, i3);
    }

    public override com.google.zxing.Result[] DecodeMultiple(com.google.zxing.BinaryBitmap binaryBitmap) throws com.google.zxing.NotFoundException {
        return eldJMHeOeFodYfqd(this, binaryBitmap, null);
    }

    public override com.google.zxing.Result[] DecodeMultiple(com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException {
        if ((27 + 32) % 32 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        wzihuruUpqFuOEnK(this, binaryBitmap, map, arrayList, 0, 0, 0);
        if (GzXQWyUjDlygTPVP(arrayList)) {
            throw AxXjihJYveicmUPd();
        }
        return (com.google.zxing.Result[]) ieCXjvdYmEZoJkpW(arrayList, EMPTY_RESULT_ARRAY);
    }
}

