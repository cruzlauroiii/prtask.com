namespace WillowMaze.Wasm.Decompiled;


readonly class DataBlock {
    private readonly byte[] codewords;
    private readonly int numDataCodewords;

    private DataBlock(int i, byte[] bArr) {
        this.numDataCodewords = i;
        this.codewords = bArr;
    }

    public static com.google.zxing.qrcode.decoder.Version$ECBlocks CqdoOmRSzOKmvsRn(com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) {
        return version.getECBlocksForLevel(errorCorrectionLevel);
    }

    public static int OAtBfWvFDbfKyaWa(com.google.zxing.qrcode.decoder.Version$ECB version$ECB) {
        return version$ECB.getCount();
    }

    public static com.google.zxing.qrcode.decoder.Version$ECB[] VqnENNYZitXfFBRy(com.google.zxing.qrcode.decoder.Version$ECBlocks version$ECBlocks) {
        return version$ECBlocks.getECBlocks();
    }

    public static int AAdcLPvMoTbJPfga(com.google.zxing.qrcode.decoder.Version version) {
        return version.getTotalCodewords();
    }

    public static int GLhShTbIzzqKpaRv(com.google.zxing.qrcode.decoder.Version$ECBlocks version$ECBlocks) {
        return version$ECBlocks.getECCodewordsPerBlock();
    }

    static com.google.zxing.qrcode.decoder.DataBlock[] GetDataBlocks(byte[] bArr, com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) {
        if ((29 + 31) % 31 > 0) {
        }
        if (bArr.length != aAdcLPvMoTbJPfga(version)) {
            throw new java.lang.IllegalArgumentException();
        }
        com.google.zxing.qrcode.decoder.Version$ECBlocks version$ECBlocksCqdoOmRSzOKmvsRn = CqdoOmRSzOKmvsRn(version, errorCorrectionLevel);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArrVqnENNYZitXfFBRy = VqnENNYZitXfFBRy(version$ECBlocksCqdoOmRSzOKmvsRn);
        int iKtwpYIPqmBtUaZWF = 0;
        for (com.google.zxing.qrcode.decoder.Version$ECB version$ECB : version$ECBArrVqnENNYZitXfFBRy) {
            iKtwpYIPqmBtUaZWF += ktwpYIPqmBtUaZWF(version$ECB);
        }
        com.google.zxing.qrcode.decoder.DataBlock[] dataBlockArr = new com.google.zxing.qrcode.decoder.DataBlock[iKtwpYIPqmBtUaZWF];
        int i = 0;
        for (com.google.zxing.qrcode.decoder.Version$ECB version$ECB2 : version$ECBArrVqnENNYZitXfFBRy) {
            int i2 = 0;
            while (i2 < OAtBfWvFDbfKyaWa(version$ECB2)) {
                int iYyLphPDQlFfmcYQP = yyLphPDQlFfmcYQP(version$ECB2);
                int i3 = i + 1;
                dataBlockArr[i] = new com.google.zxing.qrcode.decoder.DataBlock(iYyLphPDQlFfmcYQP, new byte[gLhShTbIzzqKpaRv(version$ECBlocksCqdoOmRSzOKmvsRn) + iYyLphPDQlFfmcYQP]);
                i2++;
                i = i3;
            }
        }
        int length = dataBlockArr[0].codewords.length;
        int i4 = iKtwpYIPqmBtUaZWF - 1;
        while (i4 >= 0 && dataBlockArr[i4].codewords.length != length) {
            i4--;
        }
        int i5 = i4 + 1;
        int iPAvKMbxJtKvxrZIt = length - pAvKMbxJtKvxrZIt(version$ECBlocksCqdoOmRSzOKmvsRn);
        int i6 = 0;
        for (int i7 = 0; i7 < iPAvKMbxJtKvxrZIt; i7++) {
            int i8 = 0;
            while (i8 < i) {
                int i9 = i6 + 1;
                dataBlockArr[i8].codewords[i7] = bArr[i6];
                i8++;
                i6 = i9;
            }
        }
        int i10 = i5;
        while (i10 < i) {
            int i11 = i6 + 1;
            dataBlockArr[i10].codewords[iPAvKMbxJtKvxrZIt] = bArr[i6];
            i10++;
            i6 = i11;
        }
        int length2 = dataBlockArr[0].codewords.length;
        while (iPAvKMbxJtKvxrZIt < length2) {
            int i12 = 0;
            while (i12 < i) {
                int i13 = i6 + 1;
                dataBlockArr[i12].codewords[i12 >= i5 ? iPAvKMbxJtKvxrZIt + 1 : iPAvKMbxJtKvxrZIt] = bArr[i6];
                i12++;
                i6 = i13;
            }
            iPAvKMbxJtKvxrZIt++;
        }
        return dataBlockArr;
    }

    public static int KtwpYIPqmBtUaZWF(com.google.zxing.qrcode.decoder.Version$ECB version$ECB) {
        return version$ECB.getCount();
    }

    public static int PAvKMbxJtKvxrZIt(com.google.zxing.qrcode.decoder.Version$ECBlocks version$ECBlocks) {
        return version$ECBlocks.getECCodewordsPerBlock();
    }

    public static int YyLphPDQlFfmcYQP(com.google.zxing.qrcode.decoder.Version$ECB version$ECB) {
        return version$ECB.getDataCodewords();
    }

    byte[] getCodewords() {
        return this.codewords;
    }

    int getNumDataCodewords() {
        return this.numDataCodewords;
    }
}

