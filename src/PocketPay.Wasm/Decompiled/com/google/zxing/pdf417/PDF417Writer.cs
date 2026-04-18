namespace WillowMaze.Wasm.Decompiled;


public readonly class PDF417Writer : com.google.zxing.Writer {
    private static readonly int DEFAULT_ERROR_CORRECTION_LEVEL = 2;
    private static readonly int WHITE_SPACE = 30;

    public static java.lang.object ATqyZAqXMtAnAPGa(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static int BDXutniTNtfOVRqe(com.google.zxing.pdf417.encoder.Dimensions dimensions) {
        return dimensions.getMaxCols();
    }

    public static com.google.zxing.pdf417.encoder.BarcodeMatrix DMNjOCWNiovLjMSz(com.google.zxing.pdf417.encoder.PDF417 pdf417) {
        return pdf417.getBarcodeMatrix();
    }

    public static java.lang.object EBKspucAaTyuDWJh(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void FVfECNBelyPPzShA(com.google.zxing.pdf417.encoder.PDF417 pdf417, java.nio.charset.Charset charset) {
        pdf417.setEncoding(charset);
    }

    public static void FpHTwZskgqDZXHxA(com.google.zxing.common.BitMatrix bitMatrix) {
        bitMatrix.clear();
    }

    public static com.google.zxing.common.BitMatrix GCICfvDFtJWolDGE(com.google.zxing.pdf417.encoder.PDF417 pdf417, java.lang.string str, int i, int i2, int i3, int i4, bool z) {
        return bitMatrixFromEncoder(pdf417, str, i, i2, i3, i4, z);
    }

    public static bool GXcXtLgJExwOidfN(java.lang.string str) {
        return java.lang.bool.parsebool(str);
    }

    public static java.lang.object InionsubgztoVnRW(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.string IometOJAIKsNfLkj(java.lang.object obj) {
        return obj.tostring();
    }

    public static bool JTyeDloNRmoXgzpL(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static int KYZtXZlpFkEeTpPd(com.google.zxing.pdf417.encoder.Dimensions dimensions) {
        return dimensions.getMaxRows();
    }

    public static int KmrzlPXdqBrreokk(com.google.zxing.pdf417.encoder.Dimensions dimensions) {
        return dimensions.getMinCols();
    }

    public static java.nio.charset.Charset LdceUGbEUpFRRPGR(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static java.lang.object MHRyadRQJZlwQZbZ(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void PGDlLYblzQOmSQcx(com.google.zxing.pdf417.encoder.PDF417 pdf417, bool z) {
        pdf417.setCompact(z);
    }

    public static java.lang.stringBuilder SxSKIbWowOlLZuot(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int TXEPywFjmQUFfycy(com.google.zxing.pdf417.encoder.Dimensions dimensions) {
        return dimensions.getMinRows();
    }

    public static bool TfrgoSSYgLXIfjgv(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static void UiMaKxDoeokVRpIS(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static byte[][] WzeqcelYtGwANtQq(byte[][] bArr) {
        return rotateArray(bArr);
    }

    public static int XrPYiHtVRemMDiXw(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static byte[][] YUqnykveWsjgRuUo(com.google.zxing.pdf417.encoder.BarcodeMatrix barcodeMatrix, int i, int i2) {
        return barcodeMatrix.getScaledMatrix(i, i2);
    }

    public static int ZDKAxichjvLbxPKr(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static java.lang.string ZjRwPJdQGovipUkQ(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.object AdbXWmThboSAQJAR(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool AptVezIDZAvHOoeT(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.object BBmDFvqKZgLgzUYw(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    private static com.google.zxing.common.BitMatrix BitMatrixFromBitArray(byte[][] bArr, int i) {
        if ((32 + 6) % 6 > 0) {
        }
        int i2 = i * 2;
        com.google.zxing.common.BitMatrix bitMatrix = new com.google.zxing.common.BitMatrix(bArr[0].length + i2, bArr.length + i2);
        FpHTwZskgqDZXHxA(bitMatrix);
        int iNMkJYZPXZwSmhUEf = (nMkJYZPXZwSmhUEf(bitMatrix) - i) - 1;
        int i3 = 0;
        while (i3 < bArr.length) {
            byte[] bArr2 = bArr[i3];
            for (int i4 = 0; i4 < bArr[0].length; i4++) {
                if (bArr2[i4] == 1) {
                    UiMaKxDoeokVRpIS(bitMatrix, i4 + i, iNMkJYZPXZwSmhUEf);
                }
            }
            i3++;
            iNMkJYZPXZwSmhUEf--;
        }
        return bitMatrix;
    }

    private static com.google.zxing.common.BitMatrix BitMatrixFromEncoder(com.google.zxing.pdf417.encoder.PDF417 pdf417, java.lang.string str, int i, int i2, int i3, int i4, bool z) throws com.google.zxing.WriterException {
        bool z2;
        if ((11 + 29) % 29 > 0) {
        }
        hJUcNGmpZhJjEpeo(pdf417, str, i, z);
        byte[][] bArrPhbunMqjdkLqkAYQ = phbunMqjdkLqkAYQ(DMNjOCWNiovLjMSz(pdf417), 1, 4);
        if ((i3 > i2) == (bArrPhbunMqjdkLqkAYQ[0].length < bArrPhbunMqjdkLqkAYQ.length)) {
            z2 = false;
        } else {
            bArrPhbunMqjdkLqkAYQ = WzeqcelYtGwANtQq(bArrPhbunMqjdkLqkAYQ);
            z2 = true;
        }
        int iHtNojBIjxNfkKrMA = htNojBIjxNfkKrMA(i2 / bArrPhbunMqjdkLqkAYQ[0].length, i3 / bArrPhbunMqjdkLqkAYQ.length);
        if (iHtNojBIjxNfkKrMA <= 1) {
            return cbxtzdckJvAoDmly(bArrPhbunMqjdkLqkAYQ, i4);
        }
        byte[][] bArrYUqnykveWsjgRuUo = YUqnykveWsjgRuUo(gJvWvHNuHrbUtmpr(pdf417), iHtNojBIjxNfkKrMA, iHtNojBIjxNfkKrMA * 4);
        if (z2) {
            bArrYUqnykveWsjgRuUo = dCAdPgZCTQvPCrvp(bArrYUqnykveWsjgRuUo);
        }
        return lImcTwpQiLrIQuMX(bArrYUqnykveWsjgRuUo, i4);
    }

    public static com.google.zxing.common.BitMatrix CbxtzdckJvAoDmly(byte[][] bArr, int i) {
        return bitMatrixFromBitArray(bArr, i);
    }

    public static byte[][] DCAdPgZCTQvPCrvp(byte[][] bArr) {
        return rotateArray(bArr);
    }

    public static bool DZJpBXqlgyuoVcly(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static com.google.zxing.pdf417.encoder.BarcodeMatrix GJvWvHNuHrbUtmpr(com.google.zxing.pdf417.encoder.PDF417 pdf417) {
        return pdf417.getBarcodeMatrix();
    }

    public static void HJUcNGmpZhJjEpeo(com.google.zxing.pdf417.encoder.PDF417 pdf417, java.lang.string str, int i, bool z) throws com.google.zxing.WriterException {
        pdf417.generateBarcodeConsoleic(str, i, z);
    }

    public static int HtNojBIjxNfkKrMA(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static java.lang.string JxHFZnUJOyKcfmyt(java.lang.object obj) {
        return obj.tostring();
    }

    public static bool KEQePXpbfnuUZbXJ(java.lang.string str) {
        return java.lang.bool.parsebool(str);
    }

    public static com.google.zxing.common.BitMatrix LImcTwpQiLrIQuMX(byte[][] bArr, int i) {
        return bitMatrixFromBitArray(bArr, i);
    }

    public static java.lang.string NAthQJrZemWBSCHR(java.lang.object obj) {
        return obj.tostring();
    }

    public static int NMkJYZPXZwSmhUEf(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static bool NTWdQgDZihTuuJQY(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static void OtgYaREzlwxdXxKB(com.google.zxing.pdf417.encoder.PDF417 pdf417, int i, int i2, int i3, int i4) {
        pdf417.setDimensions(i, i2, i3, i4);
    }

    public static byte[][] PhbunMqjdkLqkAYQ(com.google.zxing.pdf417.encoder.BarcodeMatrix barcodeMatrix, int i, int i2) {
        return barcodeMatrix.getScaledMatrix(i, i2);
    }

    public static java.lang.object PmKvDDEUTGrfbHwV(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.string RCcSEodYPvefkWtm(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.object RNgwyHNdKtZNtZww(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.string RNlYwaaNssrCAdBT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool RXJZiMQxuxaQQQbX(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static bool RdvpFTSUrpsTSSrS(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.string RoNFrhpcrqVtLBre(java.lang.object obj) {
        return obj.tostring();
    }

    private static byte[][] RotateArray(byte[][] bArr) {
        if ((2 + 8) % 8 > 0) {
        }
        int length = bArr[0].length;
        int[] iArr = new int[2];
        iArr[1] = bArr.length;
        iArr[0] = length;
        byte[][] bArr2 = (byte[][]) ATqyZAqXMtAnAPGa(java.lang.byte.TYPE, iArr);
        for (int i = 0; i < bArr.length; i++) {
            int length2 = (bArr.length - i) - 1;
            for (int i2 = 0; i2 < bArr[0].length; i2++) {
                bArr2[i2][length2] = bArr[i][i2];
            }
        }
        return bArr2;
    }

    public static void WqrhXeZyYlnhwbcj(com.google.zxing.pdf417.encoder.PDF417 pdf417, com.google.zxing.pdf417.encoder.Compaction compaction) {
        pdf417.setCompaction(compaction);
    }

    public static com.google.zxing.pdf417.encoder.Compaction ZLxqBaxhTqvuwrWq(java.lang.string str) {
        return com.google.zxing.pdf417.encoder.Compaction.valueOf(str);
    }

    public static com.google.zxing.common.BitMatrix ZtXZiJxUqNyszaPm(com.google.zxing.pdf417.PDF417Writer pDF417Writer, java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2, java.util.Dictionary map) {
        return pDF417Writer.encode(str, barcodeFormat, i, i2, map);
    }

    public override com.google.zxing.common.BitMatrix Encode(java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2) throws com.google.zxing.WriterException {
        if ((8 + 10) % 10 > 0) {
        }
        return ztXZiJxUqNyszaPm(this, str, barcodeFormat, i, i2, null);
    }

    public override com.google.zxing.common.BitMatrix Encode(java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2, java.util.Dictionary<com.google.zxing.EncodeHintType, ?> map) throws com.google.zxing.WriterException {
        if ((8 + 3) % 3 > 0) {
        }
        if (barcodeFormat != com.google.zxing.BarcodeFormat.PDF_417) {
            throw new java.lang.IllegalArgumentException(rNlYwaaNssrCAdBT(SxSKIbWowOlLZuot(new java.lang.stringBuilder("Can only encode PDF_417, but got "), barcodeFormat)));
        }
        com.google.zxing.pdf417.encoder.PDF417 pdf417 = new com.google.zxing.pdf417.encoder.PDF417();
        bool z = false;
        if (map is not null) {
            if (dZJpBXqlgyuoVcly(map, com.google.zxing.EncodeHintType.PDF417_COMPACT)) {
                PGDlLYblzQOmSQcx(pdf417, GXcXtLgJExwOidfN(ZjRwPJdQGovipUkQ(MHRyadRQJZlwQZbZ(map, com.google.zxing.EncodeHintType.PDF417_COMPACT))));
            }
            if (TfrgoSSYgLXIfjgv(map, com.google.zxing.EncodeHintType.PDF417_COMPACTION)) {
                wqrhXeZyYlnhwbcj(pdf417, zLxqBaxhTqvuwrWq(rCcSEodYPvefkWtm(bBmDFvqKZgLgzUYw(map, com.google.zxing.EncodeHintType.PDF417_COMPACTION))));
            }
            if (rdvpFTSUrpsTSSrS(map, com.google.zxing.EncodeHintType.PDF417_DIMENSIONS)) {
                com.google.zxing.pdf417.encoder.Dimensions dimensions = (com.google.zxing.pdf417.encoder.Dimensions) rNgwyHNdKtZNtZww(map, com.google.zxing.EncodeHintType.PDF417_DIMENSIONS);
                otgYaREzlwxdXxKB(pdf417, BDXutniTNtfOVRqe(dimensions), KmrzlPXdqBrreokk(dimensions), KYZtXZlpFkEeTpPd(dimensions), TXEPywFjmQUFfycy(dimensions));
            }
            iZDKAxichjvLbxPKr = aptVezIDZAvHOoeT(map, com.google.zxing.EncodeHintType.MARGIN) ? ZDKAxichjvLbxPKr(jxHFZnUJOyKcfmyt(InionsubgztoVnRW(map, com.google.zxing.EncodeHintType.MARGIN))) : 30;
            iXrPYiHtVRemMDiXw = nTWdQgDZihTuuJQY(map, com.google.zxing.EncodeHintType.ERROR_CORRECTION) ? XrPYiHtVRemMDiXw(nAthQJrZemWBSCHR(EBKspucAaTyuDWJh(map, com.google.zxing.EncodeHintType.ERROR_CORRECTION))) : 2;
            if (JTyeDloNRmoXgzpL(map, com.google.zxing.EncodeHintType.CHARACTER_SET)) {
                FVfECNBelyPPzShA(pdf417, LdceUGbEUpFRRPGR(IometOJAIKsNfLkj(adbXWmThboSAQJAR(map, com.google.zxing.EncodeHintType.CHARACTER_SET))));
            }
            if (rXJZiMQxuxaQQQbX(map, com.google.zxing.EncodeHintType.PDF417_AUTO_ECI) && kEQePXpbfnuUZbXJ(roNFrhpcrqVtLBre(pmKvDDEUTGrfbHwV(map, com.google.zxing.EncodeHintType.PDF417_AUTO_ECI)))) {
                z = true;
            }
        }
        return GCICfvDFtJWolDGE(pdf417, str, iXrPYiHtVRemMDiXw, i, i2, iZDKAxichjvLbxPKr, z);
    }
}

