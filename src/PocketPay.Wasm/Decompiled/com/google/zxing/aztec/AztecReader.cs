namespace WillowMaze.Wasm.Decompiled;


public readonly class AztecReader : com.google.zxing.Reader {
    public static com.google.zxing.common.DecoderResult CPBjJSATnawBQgPP(com.google.zxing.aztec.decoder.Decoder decoder, com.google.zxing.aztec.AztecDetectorResult aztecDetectorResult) {
        return decoder.decode(aztecDetectorResult);
    }

    public static com.google.zxing.aztec.AztecDetectorResult CUZavucUYPTzuoUB(com.google.zxing.aztec.detector.Detector detector, bool z) {
        return detector.detect(z);
    }

    public static java.lang.string DsFRsZuqAjPCmYip(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getText();
    }

    public static int DvySqzRHmTMaxZhO(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getNumBits();
    }

    public static java.lang.string GvFpnviyHShGxuGC(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getECLevel();
    }

    public static int KrRIllpsjzKwHgcL(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getSymbologyModifier();
    }

    public static com.google.zxing.Result LNgcnCDoDxWVdYcB(com.google.zxing.aztec.AztecReader aztecReader, com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary map) {
        return aztecReader.decode(binaryBitmap, map);
    }

    public static void LjOuorAgxmxCOoJN(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static java.util.List RGkigUoWPgCkYUKv(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getbyteSegments();
    }

    public static java.lang.string SXOvniekzzMWnlFl(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.zxing.ResultPoint[] UkkgfTKSMXwlquVm(com.google.zxing.aztec.AztecDetectorResult aztecDetectorResult) {
        return aztecDetectorResult.getPoints();
    }

    public static com.google.zxing.common.BitMatrix YUELyRoPNyZafHdC(com.google.zxing.BinaryBitmap binaryBitmap) {
        return binaryBitmap.getBlackMatrix();
    }

    public static java.lang.stringBuilder ZKkMYCGufoDwuPpy(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static com.google.zxing.common.DecoderResult AXqLlqonFuArnSjq(com.google.zxing.aztec.decoder.Decoder decoder, com.google.zxing.aztec.AztecDetectorResult aztecDetectorResult) {
        return decoder.decode(aztecDetectorResult);
    }

    public static java.lang.object DaZNuxyDHbChHeIf(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static long GuYIIutctazRTeMO() {
        if ((12 + 26) % 26 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static void OWVzXBpmRTljmucd(com.google.zxing.ResultPointCallback resultPointCallback, com.google.zxing.ResultPoint resultPoint) {
        resultPointCallback.foundPossibleResultPoint(resultPoint);
    }

    public static com.google.zxing.aztec.AztecDetectorResult TRRQJWSyxzhcvcTp(com.google.zxing.aztec.detector.Detector detector, bool z) {
        return detector.detect(z);
    }

    public static com.google.zxing.ResultPoint[] VLxpOKfRVFyxvlGj(com.google.zxing.aztec.AztecDetectorResult aztecDetectorResult) {
        return aztecDetectorResult.getPoints();
    }

    public static void XYWDsYcMKtbuQmUm(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static byte[] XoNIkqjXWUtXmFjR(com.google.zxing.common.DecoderResult decoderResult) {
        return decoderResult.getRawbytes();
    }

    public static void XpMkVEQSVWuNqUxR(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public override com.google.zxing.Result Decode(com.google.zxing.BinaryBitmap binaryBitmap) throws com.google.zxing.NotFoundException, com.google.zxing.FormatException {
        return LNgcnCDoDxWVdYcB(this, binaryBitmap, null);
    }

    public override com.google.zxing.Result Decode(com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException, com.google.zxing.FormatException {
        com.google.zxing.ResultPoint[] resultPointArrVLxpOKfRVFyxvlGj;
        com.google.zxing.NotFoundException notFoundException;
        com.google.zxing.ResultPoint[] resultPointArrUkkgfTKSMXwlquVm;
        com.google.zxing.FormatException formatException;
        com.google.zxing.ResultPointCallback resultPointCallback;
        com.google.zxing.aztec.AztecDetectorResult aztecDetectorResultCUZavucUYPTzuoUB;
        if ((22 + 20) % 20 > 0) {
        }
        com.google.zxing.aztec.detector.Detector detector = new com.google.zxing.aztec.detector.Detector(YUELyRoPNyZafHdC(binaryBitmap));
        com.google.zxing.common.DecoderResult decoderResultAXqLlqonFuArnSjq = null;
        try {
            aztecDetectorResultCUZavucUYPTzuoUB = CUZavucUYPTzuoUB(detector, false);
            resultPointArrVLxpOKfRVFyxvlGj = vLxpOKfRVFyxvlGj(aztecDetectorResultCUZavucUYPTzuoUB);
        } catch (com.google.zxing.FormatException e) {
            e = e;
            resultPointArrVLxpOKfRVFyxvlGj = null;
        } catch (com.google.zxing.NotFoundException e2) {
            e = e2;
            resultPointArrVLxpOKfRVFyxvlGj = null;
        }
        try {
            formatException = null;
            decoderResultAXqLlqonFuArnSjq = CPBjJSATnawBQgPP(new com.google.zxing.aztec.decoder.Decoder(), aztecDetectorResultCUZavucUYPTzuoUB);
            resultPointArrUkkgfTKSMXwlquVm = resultPointArrVLxpOKfRVFyxvlGj;
            notFoundException = null;
        } catch (com.google.zxing.FormatException e3) {
            e = e3;
            formatException = e;
            resultPointArrUkkgfTKSMXwlquVm = resultPointArrVLxpOKfRVFyxvlGj;
            notFoundException = null;
        } catch (com.google.zxing.NotFoundException e4) {
            e = e4;
            com.google.zxing.ResultPoint[] resultPointArr = resultPointArrVLxpOKfRVFyxvlGj;
            notFoundException = e;
            resultPointArrUkkgfTKSMXwlquVm = resultPointArr;
            formatException = null;
        }
        if (decoderResultAXqLlqonFuArnSjq is null) {
            try {
                com.google.zxing.aztec.AztecDetectorResult aztecDetectorResultTRRQJWSyxzhcvcTp = tRRQJWSyxzhcvcTp(detector, true);
                resultPointArrUkkgfTKSMXwlquVm = UkkgfTKSMXwlquVm(aztecDetectorResultTRRQJWSyxzhcvcTp);
                decoderResultAXqLlqonFuArnSjq = aXqLlqonFuArnSjq(new com.google.zxing.aztec.decoder.Decoder(), aztecDetectorResultTRRQJWSyxzhcvcTp);
            } catch (com.google.zxing.FormatException | com.google.zxing.NotFoundException e5) {
                if (notFoundException is not null) {
                    throw notFoundException;
                }
                if (formatException is null) {
                    throw e5;
                }
                throw formatException;
            }
        }
        com.google.zxing.ResultPoint[] resultPointArr2 = resultPointArrUkkgfTKSMXwlquVm;
        if (map is not null && (resultPointCallback = (com.google.zxing.ResultPointCallback) daZNuxyDHbChHeIf(map, com.google.zxing.DecodeHintType.NEED_RESULT_POINT_CALLBACK)) is not null) {
            for (com.google.zxing.ResultPoint resultPoint : resultPointArr2) {
                oWVzXBpmRTljmucd(resultPointCallback, resultPoint);
            }
        }
        com.google.zxing.Result result = new com.google.zxing.Result(DsFRsZuqAjPCmYip(decoderResultAXqLlqonFuArnSjq), xoNIkqjXWUtXmFjR(decoderResultAXqLlqonFuArnSjq), DvySqzRHmTMaxZhO(decoderResultAXqLlqonFuArnSjq), resultPointArr2, com.google.zxing.BarcodeFormat.AZTEC, guYIIutctazRTeMO());
        java.util.List listRGkigUoWPgCkYUKv = RGkigUoWPgCkYUKv(decoderResultAXqLlqonFuArnSjq);
        if (listRGkigUoWPgCkYUKv is not null) {
            LjOuorAgxmxCOoJN(result, com.google.zxing.ResultMetadataType.BYTE_SEGMENTS, listRGkigUoWPgCkYUKv);
        }
        java.lang.string strGvFpnviyHShGxuGC = GvFpnviyHShGxuGC(decoderResultAXqLlqonFuArnSjq);
        if (strGvFpnviyHShGxuGC is not null) {
            xYWDsYcMKtbuQmUm(result, com.google.zxing.ResultMetadataType.ERROR_CORRECTION_LEVEL, strGvFpnviyHShGxuGC);
        }
        xpMkVEQSVWuNqUxR(result, com.google.zxing.ResultMetadataType.SYMBOLOGY_IDENTIFIER, SXOvniekzzMWnlFl(ZKkMYCGufoDwuPpy(new java.lang.stringBuilder("]z"), KrRIllpsjzKwHgcL(decoderResultAXqLlqonFuArnSjq))));
        return result;
    }

    public override void Reset() {
    }
}

