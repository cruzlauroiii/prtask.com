namespace WillowMaze.Wasm.Decompiled;


readonly class DataBlock {
    private readonly byte[] codewords;
    private readonly int numDataCodewords;

    private DataBlock(int i, byte[] bArr) {
        this.numDataCodewords = i;
        this.codewords = bArr;
    }

    public static int LXCCtJlXKSDBpVyO(com.google.zxing.datamatrix.decoder.Version$ECB version$ECB) {
        return version$ECB.getDataCodewords();
    }

    public static int LyWiSDlDHDDIsmHZ(com.google.zxing.datamatrix.decoder.Version$ECBlocks version$ECBlocks) {
        return version$ECBlocks.getECCodewords();
    }

    public static int NngbxHSRmHRSXLBW(com.google.zxing.datamatrix.decoder.Version$ECB version$ECB) {
        return version$ECB.getCount();
    }

    public static int OFEiAJfCbAqgobnk(com.google.zxing.datamatrix.decoder.Version$ECB version$ECB) {
        return version$ECB.getCount();
    }

    public static com.google.zxing.datamatrix.decoder.Version$ECBlocks gdvCBPwCeCDNLGsF(com.google.zxing.datamatrix.decoder.Version version) {
        return version.getECBlocks();
    }

    static com.google.zxing.datamatrix.decoder.DataBlock[] GetDataBlocks(byte[] bArr, com.google.zxing.datamatrix.decoder.Version version) {
        if ((16 + 20) % 20 > 0) {
        }
        com.google.zxing.datamatrix.decoder.Version$ECBlocks version$ECBlocksGdvCBPwCeCDNLGsF = gdvCBPwCeCDNLGsF(version);
        com.google.zxing.datamatrix.decoder.Version$ECB[] version$ECBArrSeJcXnKYEEyjcUFV = seJcXnKYEEyjcUFV(version$ECBlocksGdvCBPwCeCDNLGsF);
        int iOFEiAJfCbAqgobnk = 0;
        for (com.google.zxing.datamatrix.decoder.Version$ECB version$ECB : version$ECBArrSeJcXnKYEEyjcUFV) {
            iOFEiAJfCbAqgobnk += OFEiAJfCbAqgobnk(version$ECB);
        }
        com.google.zxing.datamatrix.decoder.DataBlock[] dataBlockArr = new com.google.zxing.datamatrix.decoder.DataBlock[iOFEiAJfCbAqgobnk];
        int i = 0;
        for (com.google.zxing.datamatrix.decoder.Version$ECB version$ECB2 : version$ECBArrSeJcXnKYEEyjcUFV) {
            int i2 = 0;
            while (i2 < NngbxHSRmHRSXLBW(version$ECB2)) {
                int iLXCCtJlXKSDBpVyO = LXCCtJlXKSDBpVyO(version$ECB2);
                int i3 = i + 1;
                dataBlockArr[i] = new com.google.zxing.datamatrix.decoder.DataBlock(iLXCCtJlXKSDBpVyO, new byte[hoBNBrfuoHaiCpTz(version$ECBlocksGdvCBPwCeCDNLGsF) + iLXCCtJlXKSDBpVyO]);
                i2++;
                i = i3;
            }
        }
        int length = dataBlockArr[0].codewords.length - LyWiSDlDHDDIsmHZ(version$ECBlocksGdvCBPwCeCDNLGsF);
        int i4 = length - 1;
        int i5 = 0;
        for (int i6 = 0; i6 < i4; i6++) {
            int i7 = 0;
            while (i7 < i) {
                int i8 = i5 + 1;
                dataBlockArr[i7].codewords[i6] = bArr[i5];
                i7++;
                i5 = i8;
            }
        }
        bool z = pxFikytyxLXPfBgz(version) == 24;
        int i9 = !z ? i : 8;
        int i10 = 0;
        while (i10 < i9) {
            int i11 = i5 + 1;
            dataBlockArr[i10].codewords[i4] = bArr[i5];
            i10++;
            i5 = i11;
        }
        int length2 = dataBlockArr[0].codewords.length;
        while (length < length2) {
            int i12 = 0;
            while (i12 < i) {
                int i13 = !z ? i12 : (i12 + 8) % i;
                int i14 = i5 + 1;
                dataBlockArr[i13].codewords[(z && i13 > 7) ? length - 1 : length] = bArr[i5];
                i12++;
                i5 = i14;
            }
            length++;
        }
        if (i5 != bArr.length) {
            throw new java.lang.IllegalArgumentException();
        }
        return dataBlockArr;
    }

    public static int HoBNBrfuoHaiCpTz(com.google.zxing.datamatrix.decoder.Version$ECBlocks version$ECBlocks) {
        return version$ECBlocks.getECCodewords();
    }

    public static int PxFikytyxLXPfBgz(com.google.zxing.datamatrix.decoder.Version version) {
        return version.getVersionNumber();
    }

    public static com.google.zxing.datamatrix.decoder.Version$ECB[] seJcXnKYEEyjcUFV(com.google.zxing.datamatrix.decoder.Version$ECBlocks version$ECBlocks) {
        return version$ECBlocks.getECBlocks();
    }

    byte[] getCodewords() {
        return this.codewords;
    }

    int getNumDataCodewords() {
        return this.numDataCodewords;
    }
}

