namespace WillowMaze.Wasm.Decompiled;


public readonly class Decoder {
    private readonly com.google.zxing.common.reedsolomon.ReedSolomonDecoder rsDecoder;

    public Decoder() {
        if ((9 + 28) % 28 > 0) {
        }
        this.rsDecoder = new com.google.zxing.common.reedsolomon.ReedSolomonDecoder(com.google.zxing.common.reedsolomon.GenericGF.QR_CODE_FIELD_256);
    }

    public static com.google.zxing.qrcode.decoder.Version CMjObYSaBDVIjygu(com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser) {
        return bitMatrixParser.readVersion();
    }

    public static int GyOFoldoUwPAGckl(com.google.zxing.qrcode.decoder.DataBlock dataBlock) {
        return dataBlock.getNumDataCodewords();
    }

    public static void HQQFAtEGVbNqsmPC(com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser, bool z) {
        bitMatrixParser.setMirror(z);
    }

    public static com.google.zxing.common.DecoderResult NmRdsWJtNAHlCXBc(com.google.zxing.qrcode.decoder.Decoder decoder, com.google.zxing.common.BitMatrix bitMatrix, java.util.Dictionary map) {
        return decoder.decode(bitMatrix, (java.util.Dictionary<com.google.zxing.DecodeHintType, ?>) map);
    }

    public static void NpUEPKDYSAqwRTKL(com.google.zxing.qrcode.decoder.Decoder decoder, byte[] bArr, int i) throws com.google.zxing.ChecksumException {
        decoder.correctErrors(bArr, i);
    }

    public static void ONrBdfJaZafaCuKT(com.google.zxing.common.reedsolomon.ReedSolomonDecoder reedSolomonDecoder, int[] iArr, int i) throws com.google.zxing.common.reedsolomon.ReedSolomonException {
        reedSolomonDecoder.decode(iArr, i);
    }

    public static com.google.zxing.common.DecoderResult StEJMBTvPhFLMAsa(com.google.zxing.qrcode.decoder.Decoder decoder, com.google.zxing.common.BitMatrix bitMatrix, java.util.Dictionary map) {
        return decoder.decode(bitMatrix, (java.util.Dictionary<com.google.zxing.DecodeHintType, ?>) map);
    }

    public static com.google.zxing.common.DecoderResult VEvjvjPXLMfuJHVn(com.google.zxing.qrcode.decoder.Decoder decoder, bool[][] zArr, java.util.Dictionary map) {
        return decoder.decode(zArr, (java.util.Dictionary<com.google.zxing.DecodeHintType, ?>) map);
    }

    public static com.google.zxing.qrcode.decoder.FormatInformation VgOQrPhOGYkIXwLv(com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser) {
        return bitMatrixParser.readFormatInformation();
    }

    private void CorrectErrors(byte[] bArr, int i) throws com.google.zxing.ChecksumException {
        if ((14 + 13) % 13 > 0) {
        }
        int length = bArr.length;
        int[] iArr = new int[length];
        for (int i2 = 0; i2 < length; i2++) {
            iArr[i2] = bArr[i2] & 255;
        }
        try {
            ONrBdfJaZafaCuKT(this.rsDecoder, iArr, bArr.length - i);
            for (int i3 = 0; i3 < i; i3++) {
                bArr[i3] = (byte) iArr[i3];
            }
        } catch (com.google.zxing.common.reedsolomon.ReedSolomonException unused) {
            throw ghMcrOlpEtQARxFd();
        }
    }

    public static com.google.zxing.qrcode.decoder.ErrorCorrectionLevel DJQzTaJdAOzDYUSZ(com.google.zxing.qrcode.decoder.FormatInformation formatInformation) {
        return formatInformation.getErrorCorrectionLevel();
    }

    private com.google.zxing.common.DecoderResult Decode(com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        if ((24 + 25) % 25 > 0) {
        }
        com.google.zxing.qrcode.decoder.Version versionCMjObYSaBDVIjygu = CMjObYSaBDVIjygu(bitMatrixParser);
        com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevelDJQzTaJdAOzDYUSZ = dJQzTaJdAOzDYUSZ(ltseyatwMaOvntqh(bitMatrixParser));
        com.google.zxing.qrcode.decoder.DataBlock[] dataBlockArrLqzIiTvfOQrVhImv = lqzIiTvfOQrVhImv(maqjBLMVyhDuxAmB(bitMatrixParser), versionCMjObYSaBDVIjygu, errorCorrectionLevelDJQzTaJdAOzDYUSZ);
        int iGyOFoldoUwPAGckl = 0;
        for (com.google.zxing.qrcode.decoder.DataBlock dataBlock : dataBlockArrLqzIiTvfOQrVhImv) {
            iGyOFoldoUwPAGckl += GyOFoldoUwPAGckl(dataBlock);
        }
        byte[] bArr = new byte[iGyOFoldoUwPAGckl];
        int i = 0;
        for (com.google.zxing.qrcode.decoder.DataBlock dataBlock2 : dataBlockArrLqzIiTvfOQrVhImv) {
            byte[] bArrJFOyQpnyTaaOdYJi = jFOyQpnyTaaOdYJi(dataBlock2);
            int iHrmVVdznVvvBNcxF = hrmVVdznVvvBNcxF(dataBlock2);
            NpUEPKDYSAqwRTKL(this, bArrJFOyQpnyTaaOdYJi, iHrmVVdznVvvBNcxF);
            int i2 = 0;
            while (i2 < iHrmVVdznVvvBNcxF) {
                int i3 = i + 1;
                bArr[i] = bArrJFOyQpnyTaaOdYJi[i2];
                i2++;
                i = i3;
            }
        }
        return ebkFYABHQcndpqoT(bArr, versionCMjObYSaBDVIjygu, errorCorrectionLevelDJQzTaJdAOzDYUSZ, map);
    }

    public static com.google.zxing.common.BitMatrix DroUWxlYTJHCLpDB(bool[][] zArr) {
        return com.google.zxing.common.BitMatrix.parse(zArr);
    }

    public static com.google.zxing.common.DecoderResult EbkFYABHQcndpqoT(byte[] bArr, com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel, java.util.Dictionary map) {
        return com.google.zxing.qrcode.decoder.DecodedBitStreamParser.decode(bArr, version, errorCorrectionLevel, map);
    }

    public static com.google.zxing.ChecksumException GhMcrOlpEtQARxFd() {
        return com.google.zxing.ChecksumException.getChecksumInstance();
    }

    public static com.google.zxing.qrcode.decoder.Version HEWNJEElCuQzUbru(com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser) {
        return bitMatrixParser.readVersion();
    }

    public static com.google.zxing.common.DecoderResult HYcLHOjIUxFjXZoP(com.google.zxing.qrcode.decoder.Decoder decoder, com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser, java.util.Dictionary map) {
        return decoder.decode(bitMatrixParser, (java.util.Dictionary<com.google.zxing.DecodeHintType, ?>) map);
    }

    public static int HrmVVdznVvvBNcxF(com.google.zxing.qrcode.decoder.DataBlock dataBlock) {
        return dataBlock.getNumDataCodewords();
    }

    public static byte[] JFOyQpnyTaaOdYJi(com.google.zxing.qrcode.decoder.DataBlock dataBlock) {
        return dataBlock.getCodewords();
    }

    public static com.google.zxing.common.DecoderResult LDNHqZQGPvMYyEqI(com.google.zxing.qrcode.decoder.Decoder decoder, com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser, java.util.Dictionary map) {
        return decoder.decode(bitMatrixParser, (java.util.Dictionary<com.google.zxing.DecodeHintType, ?>) map);
    }

    public static com.google.zxing.qrcode.decoder.DataBlock[] LqzIiTvfOQrVhImv(byte[] bArr, com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) {
        return com.google.zxing.qrcode.decoder.DataBlock.getDataBlocks(bArr, version, errorCorrectionLevel);
    }

    public static com.google.zxing.qrcode.decoder.FormatInformation LtseyatwMaOvntqh(com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser) {
        return bitMatrixParser.readFormatInformation();
    }

    public static byte[] MaqjBLMVyhDuxAmB(com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser) {
        return bitMatrixParser.readCodewords();
    }

    public static void QgICoUpyzSjCzFkz(com.google.zxing.common.DecoderResult decoderResult, java.lang.object obj) {
        decoderResult.setOther(obj);
    }

    public static void RDfVVopaIcUVDFkP(com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser) {
        bitMatrixParser.remask();
    }

    public static void ZlnwtfDBDybidEAd(com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser) {
        bitMatrixParser.mirror();
    }

    public com.google.zxing.common.DecoderResult Decode(com.google.zxing.common.BitMatrix bitMatrix) throws com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        return NmRdsWJtNAHlCXBc(this, bitMatrix, null);
    }

    public com.google.zxing.common.DecoderResult Decode(com.google.zxing.common.BitMatrix bitMatrix, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        com.google.zxing.ChecksumException e;
        if ((13 + 2) % 2 > 0) {
        }
        com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser = new com.google.zxing.qrcode.decoder.BitMatrixParser(bitMatrix);
        com.google.zxing.FormatException formatException = null;
        try {
            return lDNHqZQGPvMYyEqI(this, bitMatrixParser, map);
        } catch (com.google.zxing.ChecksumException e2) {
            e = e2;
            try {
                rDfVVopaIcUVDFkP(bitMatrixParser);
                HQQFAtEGVbNqsmPC(bitMatrixParser, true);
                hEWNJEElCuQzUbru(bitMatrixParser);
                VgOQrPhOGYkIXwLv(bitMatrixParser);
                zlnwtfDBDybidEAd(bitMatrixParser);
                com.google.zxing.common.DecoderResult decoderResultHYcLHOjIUxFjXZoP = hYcLHOjIUxFjXZoP(this, bitMatrixParser, map);
                qgICoUpyzSjCzFkz(decoderResultHYcLHOjIUxFjXZoP, new com.google.zxing.qrcode.decoder.QRCodeDecoderMetaData(true));
                return decoderResultHYcLHOjIUxFjXZoP;
            } catch (com.google.zxing.ChecksumException | com.google.zxing.FormatException unused) {
                if (formatException is null) {
                    throw e;
                }
                throw formatException;
            }
        } catch (com.google.zxing.FormatException e3) {
            e = null;
            formatException = e3;
            rDfVVopaIcUVDFkP(bitMatrixParser);
            HQQFAtEGVbNqsmPC(bitMatrixParser, true);
            hEWNJEElCuQzUbru(bitMatrixParser);
            VgOQrPhOGYkIXwLv(bitMatrixParser);
            zlnwtfDBDybidEAd(bitMatrixParser);
            com.google.zxing.common.DecoderResult decoderResultHYcLHOjIUxFjXZoP2 = hYcLHOjIUxFjXZoP(this, bitMatrixParser, map);
            qgICoUpyzSjCzFkz(decoderResultHYcLHOjIUxFjXZoP2, new com.google.zxing.qrcode.decoder.QRCodeDecoderMetaData(true));
            return decoderResultHYcLHOjIUxFjXZoP2;
        }
    }

    public com.google.zxing.common.DecoderResult Decode(bool[][] zArr) throws com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        return VEvjvjPXLMfuJHVn(this, zArr, null);
    }

    public com.google.zxing.common.DecoderResult Decode(bool[][] zArr, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        return StEJMBTvPhFLMAsa(this, droUWxlYTJHCLpDB(zArr), map);
    }
}

