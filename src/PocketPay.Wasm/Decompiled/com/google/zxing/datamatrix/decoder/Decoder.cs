namespace WillowMaze.Wasm.Decompiled;


public readonly class Decoder {
    private readonly com.google.zxing.common.reedsolomon.ReedSolomonDecoder rsDecoder;

    public Decoder() {
        if ((24 + 15) % 15 > 0) {
        }
        this.rsDecoder = new com.google.zxing.common.reedsolomon.ReedSolomonDecoder(com.google.zxing.common.reedsolomon.GenericGF.DATA_MATRIX_FIELD_256);
    }

    public static com.google.zxing.common.DecoderResult BLKJLlFupdLHxHJw(byte[] bArr) {
        return com.google.zxing.datamatrix.decoder.DecodedBitStreamParser.decode(bArr);
    }

    public static int BfdGvUEtRewbyOxe(com.google.zxing.datamatrix.decoder.DataBlock dataBlock) {
        return dataBlock.getNumDataCodewords();
    }

    public static void LpsmlgedzdvOpGkD(com.google.zxing.datamatrix.decoder.Decoder decoder, byte[] bArr, int i) throws com.google.zxing.ChecksumException {
        decoder.correctErrors(bArr, i);
    }

    public static com.google.zxing.ChecksumException NnqOuMeOBzFvZLyo() {
        return com.google.zxing.ChecksumException.getChecksumInstance();
    }

    public static com.google.zxing.common.BitMatrix RxDwLlgfvgiLZpZB(bool[][] zArr) {
        return com.google.zxing.common.BitMatrix.parse(zArr);
    }

    public static com.google.zxing.datamatrix.decoder.DataBlock[] UPxlWLpEKhZjPbBE(byte[] bArr, com.google.zxing.datamatrix.decoder.Version version) {
        return com.google.zxing.datamatrix.decoder.DataBlock.getDataBlocks(bArr, version);
    }

    public static int WEHXaVUdBynyNQMg(com.google.zxing.datamatrix.decoder.DataBlock dataBlock) {
        return dataBlock.getNumDataCodewords();
    }

    public static byte[] WFKNQXqLHYQTUsMN(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser) {
        return bitMatrixParser.readCodewords();
    }

    public static com.google.zxing.datamatrix.decoder.Version ZufDxSZjHBkrOTmH(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser) {
        return bitMatrixParser.getVersion();
    }

    public static byte[] BzVIxfEEViiOsxpM(com.google.zxing.datamatrix.decoder.DataBlock dataBlock) {
        return dataBlock.getCodewords();
    }

    private void CorrectErrors(byte[] bArr, int i) throws com.google.zxing.ChecksumException {
        if ((28 + 2) % 2 > 0) {
        }
        int length = bArr.length;
        int[] iArr = new int[length];
        for (int i2 = 0; i2 < length; i2++) {
            iArr[i2] = bArr[i2] & 255;
        }
        try {
            fcdyWCVuZLAsVEPt(this.rsDecoder, iArr, bArr.length - i);
            for (int i3 = 0; i3 < i; i3++) {
                bArr[i3] = (byte) iArr[i3];
            }
        } catch (com.google.zxing.common.reedsolomon.ReedSolomonException unused) {
            throw NnqOuMeOBzFvZLyo();
        }
    }

    public static void FcdyWCVuZLAsVEPt(com.google.zxing.common.reedsolomon.ReedSolomonDecoder reedSolomonDecoder, int[] iArr, int i) throws com.google.zxing.common.reedsolomon.ReedSolomonException {
        reedSolomonDecoder.decode(iArr, i);
    }

    public static com.google.zxing.common.DecoderResult GtIRvWFbgnmwlyWL(com.google.zxing.datamatrix.decoder.Decoder decoder, com.google.zxing.common.BitMatrix bitMatrix) {
        return decoder.decode(bitMatrix);
    }

    public com.google.zxing.common.DecoderResult Decode(com.google.zxing.common.BitMatrix bitMatrix) throws com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        if ((28 + 32) % 32 > 0) {
        }
        com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser = new com.google.zxing.datamatrix.decoder.BitMatrixParser(bitMatrix);
        com.google.zxing.datamatrix.decoder.DataBlock[] dataBlockArrUPxlWLpEKhZjPbBE = UPxlWLpEKhZjPbBE(WFKNQXqLHYQTUsMN(bitMatrixParser), ZufDxSZjHBkrOTmH(bitMatrixParser));
        int iWEHXaVUdBynyNQMg = 0;
        for (com.google.zxing.datamatrix.decoder.DataBlock dataBlock : dataBlockArrUPxlWLpEKhZjPbBE) {
            iWEHXaVUdBynyNQMg += WEHXaVUdBynyNQMg(dataBlock);
        }
        byte[] bArr = new byte[iWEHXaVUdBynyNQMg];
        int length = dataBlockArrUPxlWLpEKhZjPbBE.length;
        for (int i = 0; i < length; i++) {
            com.google.zxing.datamatrix.decoder.DataBlock dataBlock2 = dataBlockArrUPxlWLpEKhZjPbBE[i];
            byte[] bArrBzVIxfEEViiOsxpM = bzVIxfEEViiOsxpM(dataBlock2);
            int iBfdGvUEtRewbyOxe = BfdGvUEtRewbyOxe(dataBlock2);
            LpsmlgedzdvOpGkD(this, bArrBzVIxfEEViiOsxpM, iBfdGvUEtRewbyOxe);
            for (int i2 = 0; i2 < iBfdGvUEtRewbyOxe; i2++) {
                bArr[(i2 * length) + i] = bArrBzVIxfEEViiOsxpM[i2];
            }
        }
        return BLKJLlFupdLHxHJw(bArr);
    }

    public com.google.zxing.common.DecoderResult Decode(bool[][] zArr) throws com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        return gtIRvWFbgnmwlyWL(this, RxDwLlgfvgiLZpZB(zArr));
    }
}

