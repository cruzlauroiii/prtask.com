namespace WillowMaze.Wasm.Decompiled;


public abstract class OneDReader : com.google.zxing.Reader {
    public static int AUSAAcDUgCkeUQcV(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static float AWBByvQONulEWTDV(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.common.BitArray AgmIxGLyfmheMgUa(com.google.zxing.BinaryBitmap binaryBitmap, int i, com.google.zxing.common.BitArray bitArray) {
        return binaryBitmap.getBlackRow(i, bitArray);
    }

    public static float AydyUCFTAZWdJWJh(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static java.lang.int BOjyVvoZDfBYCvtL(int i) {
        return java.lang.int.valueOf(i);
    }

    public static float CRDWNgLhHNNBVARh(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static bool EnywEVxfGLuCfrwQ(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static com.google.zxing.NotFoundException EuXHfTzARzBVKAff() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static bool FhgstcVSZPBQWTzz(com.google.zxing.BinaryBitmap binaryBitmap) {
        return binaryBitmap.isRotateSupported();
    }

    public static java.lang.object JqzElbHgoANOmVUw(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool JrCWbGRrJvMCnWSW(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static bool LKGccVuvLkaXuRCy(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static com.google.zxing.Result MBaIpbKcsJXCLOqa(com.google.zxing.oned.OneDReader oneDReader, com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map) {
        return oneDReader.doDecode(binaryBitmap, map);
    }

    public static java.lang.int NJYGXNydQzNQLRiZ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.zxing.NotFoundException NwlWfQIuCEIwQGph() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static bool PLchmGIvprrfRhew(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static int PNVQntAvVZqigCdX(com.google.zxing.BinaryBitmap binaryBitmap) {
        return binaryBitmap.getWidth();
    }

    public static int PXfewgSILnaMoJRT(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static void QOJJtAeDCwMOjFyq(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static float RvWZoefxXjWBachk(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static bool TfLPoytabAdIOeHm(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static void UWktIwUwaBFFWjnb(int[] iArr, int i, int i2, int i3) {
        java.util.Arrays.fill(iArr, i, i2, i3);
    }

    public static void VfxrlDEBDzDnAuYv(java.util.Dictionary map, java.util.Dictionary map2) {
        map.putAll(map2);
    }

    public static void WIcatTswUUMrCvlX(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static com.google.zxing.NotFoundException WnGhPRhrsRsltXUf() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.Result XuenBleiDmeDtMQl(com.google.zxing.oned.OneDReader oneDReader, com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map) {
        return oneDReader.decode(binaryBitmap, map);
    }

    public static bool ZfwmAKPebxZjvjHn(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static bool CTOQGTBJzsWRECVX(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    private com.google.zxing.Result DoDecode(com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException {
        java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map2;
        int i;
        if ((27 + 21) % 21 > 0) {
        }
        java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map3 = map;
        int iPNVQntAvVZqigCdX = PNVQntAvVZqigCdX(binaryBitmap);
        int iLSkqyDZVOtJobuhu = lSkqyDZVOtJobuhu(binaryBitmap);
        com.google.zxing.common.BitArray bitArray = new com.google.zxing.common.BitArray(iPNVQntAvVZqigCdX);
        int i2 = 1;
        bool z = map3 is not null && EnywEVxfGLuCfrwQ(map3, com.google.zxing.DecodeHintType.TRY_HARDER);
        int iAUSAAcDUgCkeUQcV = AUSAAcDUgCkeUQcV(1, iLSkqyDZVOtJobuhu >> (!z ? 5 : 8));
        int i3 = !z ? 15 : iLSkqyDZVOtJobuhu;
        int i4 = iLSkqyDZVOtJobuhu / 2;
        int i5 = 0;
        while (i5 < i3) {
            int i6 = i5 + 1;
            int i7 = i6 / 2;
            if ((i5 & 1) != 0) {
                i7 = -i7;
            }
            int i8 = (i7 * iAUSAAcDUgCkeUQcV) + i4;
            if (i8 < 0 || i8 >= iLSkqyDZVOtJobuhu) {
                break;
            }
            try {
                bitArray = AgmIxGLyfmheMgUa(binaryBitmap, i8, bitArray);
                int i9 = 0;
                while (i9 < 2) {
                    if (i9 == i2) {
                        iWetnXGPUHkqJJzP(bitArray);
                        if (map3 is not null && cTOQGTBJzsWRECVX(map3, com.google.zxing.DecodeHintType.NEED_RESULT_POINT_CALLBACK)) {
                            java.util.EnumDictionary enumDictionary = new java.util.EnumDictionary(com.google.zxing.DecodeHintType.class);
                            VfxrlDEBDzDnAuYv(enumDictionary, map3);
                            sRxjALKfuXKCrDWH(enumDictionary, com.google.zxing.DecodeHintType.NEED_RESULT_POINT_CALLBACK);
                            map3 = enumDictionary;
                        }
                    }
                    try {
                        com.google.zxing.Result resultYkTRYWxTBzobqPiu = ykTRYWxTBzobqPiu(this, i8, bitArray, map3);
                        if (i9 == i2) {
                            try {
                                WIcatTswUUMrCvlX(resultYkTRYWxTBzobqPiu, com.google.zxing.ResultMetadataType.ORIENTATION, NJYGXNydQzNQLRiZ(180));
                                com.google.zxing.ResultPoint[] resultPointArrTYqSvhyXQjyaNctl = tYqSvhyXQjyaNctl(resultYkTRYWxTBzobqPiu);
                                if (resultPointArrTYqSvhyXQjyaNctl is not null) {
                                    i = i2;
                                    float f = iPNVQntAvVZqigCdX;
                                    try {
                                        map2 = map3;
                                    } catch (com.google.zxing.ReaderException unused) {
                                        map2 = map3;
                                    }
                                    try {
                                    } catch (com.google.zxing.ReaderException unused2) {
                                        i9++;
                                        map3 = map2;
                                        i2 = i;
                                        iPNVQntAvVZqigCdX = iPNVQntAvVZqigCdX;
                                    }
                                    try {
                                        resultPointArrTYqSvhyXQjyaNctl[0] = new com.google.zxing.ResultPoint((f - AydyUCFTAZWdJWJh(resultPointArrTYqSvhyXQjyaNctl[0])) - 1.0f, fGjsqnksbTzuoKiF(resultPointArrTYqSvhyXQjyaNctl[0]));
                                        resultPointArrTYqSvhyXQjyaNctl[i] = new com.google.zxing.ResultPoint((f - RvWZoefxXjWBachk(resultPointArrTYqSvhyXQjyaNctl[i])) - 1.0f, CRDWNgLhHNNBVARh(resultPointArrTYqSvhyXQjyaNctl[i]));
                                    } catch (com.google.zxing.ReaderException unused3) {
                                        i9++;
                                        map3 = map2;
                                        i2 = i;
                                        iPNVQntAvVZqigCdX = iPNVQntAvVZqigCdX;
                                    }
                                }
                            } catch (com.google.zxing.ReaderException unused4) {
                                map2 = map3;
                                i = i2;
                            }
                        }
                        return resultYkTRYWxTBzobqPiu;
                    } catch (com.google.zxing.ReaderException unused5) {
                        map2 = map3;
                        i = i2;
                    }
                }
            } catch (com.google.zxing.NotFoundException unused6) {
            }
            i5 = i6;
            i2 = i2;
            iPNVQntAvVZqigCdX = iPNVQntAvVZqigCdX;
        }
        throw NwlWfQIuCEIwQGph();
    }

    public static float FGjsqnksbTzuoKiF(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static com.google.zxing.Result HEbWoEJmjPNYLJpd(com.google.zxing.oned.OneDReader oneDReader, com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map) {
        return oneDReader.doDecode(binaryBitmap, map);
    }

    public static void IWetnXGPUHkqJJzP(com.google.zxing.common.BitArray bitArray) {
        bitArray.reverse();
    }

    public static java.util.Dictionary LRwwpJmohtSmbdcr(com.google.zxing.Result result) {
        return result.getResultMetadata();
    }

    public static int LSkqyDZVOtJobuhu(com.google.zxing.BinaryBitmap binaryBitmap) {
        return binaryBitmap.getHeight();
    }

    public static com.google.zxing.NotFoundException OkpAUnQlWNvJuRLf() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    protected static float PatternMatchVariance(int[] iArr, int[] iArr2, float f) {
        if ((28 + 21) % 21 > 0) {
        }
        int length = iArr.length;
        int i = 0;
        int i2 = 0;
        for (int i3 = 0; i3 < length; i3++) {
            i += iArr[i3];
            i2 += iArr2[i3];
        }
        if (i < i2) {
            return float.POSITIVE_INFINITY;
        }
        float f2 = i;
        float f3 = f2 / i2;
        float f4 = f * f3;
        float f5 = 0.0f;
        for (int i4 = 0; i4 < length; i4++) {
            float f6 = iArr2[i4] * f3;
            float f7 = iArr[i4];
            float f8 = f7 <= f6 ? f6 - f7 : f7 - f6;
            if (f8 > f4) {
                return float.POSITIVE_INFINITY;
            }
            f5 += f8;
        }
        return f5 / f2;
    }

    public static bool PnopZGZVPAYrAaWI(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    protected static void RecordRegex(com.google.zxing.common.BitArray bitArray, int i, int[] iArr) throws com.google.zxing.NotFoundException {
        if ((7 + 21) % 21 > 0) {
        }
        int length = iArr.length;
        int i2 = 0;
        UWktIwUwaBFFWjnb(iArr, 0, length, 0);
        int iPXfewgSILnaMoJRT = PXfewgSILnaMoJRT(bitArray);
        if (i >= iPXfewgSILnaMoJRT) {
            throw okpAUnQlWNvJuRLf();
        }
        bool z = !pnopZGZVPAYrAaWI(bitArray, i);
        while (i < iPXfewgSILnaMoJRT) {
            if (TfLPoytabAdIOeHm(bitArray, i) == z) {
                i2++;
                if (i2 == length) {
                    break;
                }
                iArr[i2] = 1;
                z = !z;
            } else {
                iArr[i2] = iArr[i2] + 1;
            }
            i++;
        }
        if (i2 == length) {
            return;
        }
        if (i2 != length - 1 || i != iPXfewgSILnaMoJRT) {
            throw EuXHfTzARzBVKAff();
        }
    }

    protected static void RecordRegexInReverse(com.google.zxing.common.BitArray bitArray, int i, int[] iArr) throws com.google.zxing.NotFoundException {
        if ((6 + 8) % 8 > 0) {
        }
        int length = iArr.length;
        bool zLKGccVuvLkaXuRCy = LKGccVuvLkaXuRCy(bitArray, i);
        while (i > 0 && length >= 0) {
            i--;
            if (ZfwmAKPebxZjvjHn(bitArray, i) != zLKGccVuvLkaXuRCy) {
                length--;
                zLKGccVuvLkaXuRCy = !zLKGccVuvLkaXuRCy;
            }
        }
        if (length >= 0) {
            throw WnGhPRhrsRsltXUf();
        }
        utyvYcBrvRhrgaRv(bitArray, i + 1, iArr);
    }

    public static java.lang.object SRxjALKfuXKCrDWH(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static int SdJchehFpjtxyriv(com.google.zxing.BinaryBitmap binaryBitmap) {
        return binaryBitmap.getHeight();
    }

    public static com.google.zxing.BinaryBitmap TThYKIxoMMoHyuYm(com.google.zxing.BinaryBitmap binaryBitmap) {
        return binaryBitmap.rotateCounterClockwise();
    }

    public static com.google.zxing.ResultPoint[] TUGVyuLewJbbaywq(com.google.zxing.Result result) {
        return result.getResultPoints();
    }

    public static com.google.zxing.ResultPoint[] TYqSvhyXQjyaNctl(com.google.zxing.Result result) {
        return result.getResultPoints();
    }

    public static int UsxNhEgWlSSOHVKH(java.lang.int num) {
        return num.intValue();
    }

    public static void UtyvYcBrvRhrgaRv(com.google.zxing.common.BitArray bitArray, int i, int[] iArr) throws com.google.zxing.NotFoundException {
        recordRegex(bitArray, i, iArr);
    }

    public static com.google.zxing.Result YkTRYWxTBzobqPiu(com.google.zxing.oned.OneDReader oneDReader, int i, com.google.zxing.common.BitArray bitArray, java.util.Dictionary map) {
        return oneDReader.decodeRow(i, bitArray, map);
    }

    public static float ZRArxRynuUgxEKkR(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public override com.google.zxing.Result Decode(com.google.zxing.BinaryBitmap binaryBitmap) throws com.google.zxing.NotFoundException, com.google.zxing.FormatException {
        return XuenBleiDmeDtMQl(this, binaryBitmap, null);
    }

    public override com.google.zxing.Result Decode(com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException, com.google.zxing.FormatException {
        if ((7 + 5) % 5 > 0) {
        }
        try {
            return MBaIpbKcsJXCLOqa(this, binaryBitmap, map);
        } catch (com.google.zxing.NotFoundException e) {
            if (map is null || !PLchmGIvprrfRhew(map, com.google.zxing.DecodeHintType.TRY_HARDER) || !FhgstcVSZPBQWTzz(binaryBitmap)) {
                throw e;
            }
            com.google.zxing.BinaryBitmap binaryBitmapTThYKIxoMMoHyuYm = tThYKIxoMMoHyuYm(binaryBitmap);
            com.google.zxing.Result resultHEbWoEJmjPNYLJpd = hEbWoEJmjPNYLJpd(this, binaryBitmapTThYKIxoMMoHyuYm, map);
            java.util.Dictionary mapLRwwpJmohtSmbdcr = lRwwpJmohtSmbdcr(resultHEbWoEJmjPNYLJpd);
            int iUsxNhEgWlSSOHVKH = 270;
            if (mapLRwwpJmohtSmbdcr is not null && JrCWbGRrJvMCnWSW(mapLRwwpJmohtSmbdcr, com.google.zxing.ResultMetadataType.ORIENTATION)) {
                iUsxNhEgWlSSOHVKH = (usxNhEgWlSSOHVKH((java.lang.int) JqzElbHgoANOmVUw(mapLRwwpJmohtSmbdcr, com.google.zxing.ResultMetadataType.ORIENTATION)) + 270) % 360;
            }
            QOJJtAeDCwMOjFyq(resultHEbWoEJmjPNYLJpd, com.google.zxing.ResultMetadataType.ORIENTATION, BOjyVvoZDfBYCvtL(iUsxNhEgWlSSOHVKH));
            com.google.zxing.ResultPoint[] resultPointArrTUGVyuLewJbbaywq = tUGVyuLewJbbaywq(resultHEbWoEJmjPNYLJpd);
            if (resultPointArrTUGVyuLewJbbaywq is not null) {
                int iSdJchehFpjtxyriv = sdJchehFpjtxyriv(binaryBitmapTThYKIxoMMoHyuYm);
                for (int i = 0; i < resultPointArrTUGVyuLewJbbaywq.length; i++) {
                    resultPointArrTUGVyuLewJbbaywq[i] = new com.google.zxing.ResultPoint((iSdJchehFpjtxyriv - zRArxRynuUgxEKkR(resultPointArrTUGVyuLewJbbaywq[i])) - 1.0f, AWBByvQONulEWTDV(resultPointArrTUGVyuLewJbbaywq[i]));
                }
            }
            return resultHEbWoEJmjPNYLJpd;
        }
    }

    public abstract com.google.zxing.Result DecodeRow(int i, com.google.zxing.common.BitArray bitArray, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException, com.google.zxing.ChecksumException, com.google.zxing.FormatException;

    public override void Reset() {
    }
}

