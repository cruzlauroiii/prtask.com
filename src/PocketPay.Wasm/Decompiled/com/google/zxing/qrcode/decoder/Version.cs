namespace WillowMaze.Wasm.Decompiled;


public readonly class Version {
    private readonly int[] alignmentRegexCenters;
    private readonly com.google.zxing.qrcode.decoder.Version$ECBlocks[] ecBlocks;
    private readonly int totalCodewords;
    private readonly int versionNumber;
    private static readonly int[] VERSION_DECODE_INFO = {31892, 34236, 39577, 42195, 48118, 51042, 55367, 58893, 63784, 68472, 70749, 76311, 79154, 84390, 87683, 92361, 96236, 102084, 102881, 110507, 110734, 117786, 119615, 126325, 127568, 133589, 136944, 141498, 145311, 150283, 152622, 158308, 161089, 167017};
    private static readonly com.google.zxing.qrcode.decoder.Version[] VERSIONS = CyQatKpejubnMtXw();

    private Version(int i, int[] iArr, com.google.zxing.qrcode.decoder.Version$ECBlocks... version$ECBlocksArr) {
        if ((31 + 15) % 15 > 0) {
        }
        this.versionNumber = i;
        this.alignmentRegexCenters = iArr;
        this.ecBlocks = version$ECBlocksArr;
        int iQCDLPwscqgJPQIfi = QCDLPwscqgJPQIfi(version$ECBlocksArr[0]);
        int iPjaeVChwerUBjXUa = 0;
        for (com.google.zxing.qrcode.decoder.Version$ECB version$ECB : JWfFMEpgFndrwIdw(version$ECBlocksArr[0])) {
            iPjaeVChwerUBjXUa += pjaeVChwerUBjXUa(version$ECB) * (UAyhuiblPSWMaqIb(version$ECB) + iQCDLPwscqgJPQIfi);
        }
        this.totalCodewords = iPjaeVChwerUBjXUa;
    }

    public static void BgMBvkUeavarUXvm(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, int i3, int i4) {
        bitMatrix.setRegion(i, i2, i3, i4);
    }

    public static com.google.zxing.qrcode.decoder.Version[] CyQatKpejubnMtXw() {
        return buildVersions();
    }

    public static com.google.zxing.qrcode.decoder.Version GXonRRClJWVyFIPH(int i) {
        return getVersionForNumber(i);
    }

    public static com.google.zxing.qrcode.decoder.Version$ECB[] JWfFMEpgFndrwIdw(com.google.zxing.qrcode.decoder.Version$ECBlocks version$ECBlocks) {
        return version$ECBlocks.getECBlocks();
    }

    public static int QCDLPwscqgJPQIfi(com.google.zxing.qrcode.decoder.Version$ECBlocks version$ECBlocks) {
        return version$ECBlocks.getECCodewordsPerBlock();
    }

    public static com.google.zxing.qrcode.decoder.Version QbMyfUkoogDrudqs(int i) {
        return getVersionForNumber(i);
    }

    public static int UAyhuiblPSWMaqIb(com.google.zxing.qrcode.decoder.Version$ECB version$ECB) {
        return version$ECB.getDataCodewords();
    }

    public static void UbBJhqYcoJpeejll(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, int i3, int i4) {
        bitMatrix.setRegion(i, i2, i3, i4);
    }

    public static com.google.zxing.FormatException BueQKKZWycGzQviU() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    private static com.google.zxing.qrcode.decoder.Version[] BuildVersions() {
        if ((12 + 23) % 23 > 0) {
        }
        int[] iArr = new int[0];
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr[0] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 19);
        version$ECBlocksArr[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(7, version$ECBArr);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr2 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr2[0] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 16);
        version$ECBlocksArr[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(10, version$ECBArr2);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr3 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr3[0] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 13);
        version$ECBlocksArr[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(13, version$ECBArr3);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr4 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr4[0] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 9);
        version$ECBlocksArr[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(17, version$ECBArr4);
        com.google.zxing.qrcode.decoder.Version version = new com.google.zxing.qrcode.decoder.Version(1, iArr, version$ECBlocksArr);
        int[] iArr2 = {6, 18};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr2 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr5 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr5[0] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 34);
        version$ECBlocksArr2[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(10, version$ECBArr5);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr6 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr6[0] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 28);
        version$ECBlocksArr2[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(16, version$ECBArr6);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr7 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr7[0] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 22);
        version$ECBlocksArr2[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(22, version$ECBArr7);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr8 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr8[0] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 16);
        version$ECBlocksArr2[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr8);
        com.google.zxing.qrcode.decoder.Version version2 = new com.google.zxing.qrcode.decoder.Version(2, iArr2, version$ECBlocksArr2);
        int[] iArr3 = {6, 22};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr3 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr9 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr9[0] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 55);
        version$ECBlocksArr3[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(15, version$ECBArr9);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr10 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr10[0] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 44);
        version$ECBlocksArr3[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(26, version$ECBArr10);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr11 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr11[0] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 17);
        version$ECBlocksArr3[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(18, version$ECBArr11);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr12 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr12[0] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 13);
        version$ECBlocksArr3[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(22, version$ECBArr12);
        com.google.zxing.qrcode.decoder.Version version3 = new com.google.zxing.qrcode.decoder.Version(3, iArr3, version$ECBlocksArr3);
        int[] iArr4 = {6, 26};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr4 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr13 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr13[0] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 80);
        version$ECBlocksArr4[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(20, version$ECBArr13);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr14 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr14[0] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 32);
        version$ECBlocksArr4[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(18, version$ECBArr14);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr15 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr15[0] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 24);
        version$ECBlocksArr4[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(26, version$ECBArr15);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr16 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr16[0] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 9);
        version$ECBlocksArr4[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(16, version$ECBArr16);
        com.google.zxing.qrcode.decoder.Version version4 = new com.google.zxing.qrcode.decoder.Version(4, iArr4, version$ECBlocksArr4);
        int[] iArr5 = {6, 30};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr5 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr17 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr17[0] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 108);
        version$ECBlocksArr5[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(26, version$ECBArr17);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr18 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr18[0] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 43);
        version$ECBlocksArr5[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(24, version$ECBArr18);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr19 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr19[0] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 15);
        version$ECBArr19[1] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 16);
        version$ECBlocksArr5[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(18, version$ECBArr19);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr20 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr20[0] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 11);
        version$ECBArr20[1] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 12);
        version$ECBlocksArr5[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(22, version$ECBArr20);
        com.google.zxing.qrcode.decoder.Version version5 = new com.google.zxing.qrcode.decoder.Version(5, iArr5, version$ECBlocksArr5);
        int[] iArr6 = {6, 34};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr6 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr21 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr21[0] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 68);
        version$ECBlocksArr6[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(18, version$ECBArr21);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr22 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr22[0] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 27);
        version$ECBlocksArr6[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(16, version$ECBArr22);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr23 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr23[0] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 19);
        version$ECBlocksArr6[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(24, version$ECBArr23);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr24 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr24[0] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 15);
        version$ECBlocksArr6[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr24);
        com.google.zxing.qrcode.decoder.Version version6 = new com.google.zxing.qrcode.decoder.Version(6, iArr6, version$ECBlocksArr6);
        int[] iArr7 = {6, 22, 38};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr7 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr25 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr25[0] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 78);
        version$ECBlocksArr7[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(20, version$ECBArr25);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr26 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr26[0] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 31);
        version$ECBlocksArr7[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(18, version$ECBArr26);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr27 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr27[0] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 14);
        version$ECBArr27[1] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 15);
        version$ECBlocksArr7[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(18, version$ECBArr27);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr28 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr28[0] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 13);
        version$ECBArr28[1] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 14);
        version$ECBlocksArr7[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(26, version$ECBArr28);
        com.google.zxing.qrcode.decoder.Version version7 = new com.google.zxing.qrcode.decoder.Version(7, iArr7, version$ECBlocksArr7);
        int[] iArr8 = {6, 24, 42};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr8 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr29 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr29[0] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 97);
        version$ECBlocksArr8[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(24, version$ECBArr29);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr30 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr30[0] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 38);
        version$ECBArr30[1] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 39);
        version$ECBlocksArr8[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(22, version$ECBArr30);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr31 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr31[0] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 18);
        version$ECBArr31[1] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 19);
        version$ECBlocksArr8[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(22, version$ECBArr31);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr32 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr32[0] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 14);
        version$ECBArr32[1] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 15);
        version$ECBlocksArr8[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(26, version$ECBArr32);
        com.google.zxing.qrcode.decoder.Version version8 = new com.google.zxing.qrcode.decoder.Version(8, iArr8, version$ECBlocksArr8);
        int[] iArr9 = {6, 26, 46};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr9 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr33 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr33[0] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 116);
        version$ECBlocksArr9[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr33);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr34 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr34[0] = new com.google.zxing.qrcode.decoder.Version$ECB(3, 36);
        version$ECBArr34[1] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 37);
        version$ECBlocksArr9[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(22, version$ECBArr34);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr35 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr35[0] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 16);
        version$ECBArr35[1] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 17);
        version$ECBlocksArr9[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(20, version$ECBArr35);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr36 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr36[0] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 12);
        version$ECBArr36[1] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 13);
        version$ECBlocksArr9[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(24, version$ECBArr36);
        com.google.zxing.qrcode.decoder.Version version9 = new com.google.zxing.qrcode.decoder.Version(9, iArr9, version$ECBlocksArr9);
        int[] iArr10 = {6, 28, 50};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr10 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr37 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr37[0] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 68);
        version$ECBArr37[1] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 69);
        version$ECBlocksArr10[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(18, version$ECBArr37);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr38 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr38[0] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 43);
        version$ECBArr38[1] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 44);
        version$ECBlocksArr10[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(26, version$ECBArr38);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr39 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr39[0] = new com.google.zxing.qrcode.decoder.Version$ECB(6, 19);
        version$ECBArr39[1] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 20);
        version$ECBlocksArr10[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(24, version$ECBArr39);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr40 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr40[0] = new com.google.zxing.qrcode.decoder.Version$ECB(6, 15);
        version$ECBArr40[1] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 16);
        version$ECBlocksArr10[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr40);
        com.google.zxing.qrcode.decoder.Version version10 = new com.google.zxing.qrcode.decoder.Version(10, iArr10, version$ECBlocksArr10);
        int[] iArr11 = {6, 30, 54};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr11 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr41 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr41[0] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 81);
        version$ECBlocksArr11[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(20, version$ECBArr41);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr42 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr42[0] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 50);
        version$ECBArr42[1] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 51);
        version$ECBlocksArr11[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr42);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr43 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr43[0] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 22);
        version$ECBArr43[1] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 23);
        version$ECBlocksArr11[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr43);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr44 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr44[0] = new com.google.zxing.qrcode.decoder.Version$ECB(3, 12);
        version$ECBArr44[1] = new com.google.zxing.qrcode.decoder.Version$ECB(8, 13);
        version$ECBlocksArr11[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(24, version$ECBArr44);
        com.google.zxing.qrcode.decoder.Version version11 = new com.google.zxing.qrcode.decoder.Version(11, iArr11, version$ECBlocksArr11);
        int[] iArr12 = {6, 32, 58};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr12 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr45 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr45[0] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 92);
        version$ECBArr45[1] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 93);
        version$ECBlocksArr12[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(24, version$ECBArr45);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr46 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr46[0] = new com.google.zxing.qrcode.decoder.Version$ECB(6, 36);
        version$ECBArr46[1] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 37);
        version$ECBlocksArr12[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(22, version$ECBArr46);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr47 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr47[0] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 20);
        version$ECBArr47[1] = new com.google.zxing.qrcode.decoder.Version$ECB(6, 21);
        version$ECBlocksArr12[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(26, version$ECBArr47);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr48 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr48[0] = new com.google.zxing.qrcode.decoder.Version$ECB(7, 14);
        version$ECBArr48[1] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 15);
        version$ECBlocksArr12[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr48);
        com.google.zxing.qrcode.decoder.Version version12 = new com.google.zxing.qrcode.decoder.Version(12, iArr12, version$ECBlocksArr12);
        int[] iArr13 = {6, 34, 62};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr13 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr49 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr49[0] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 107);
        version$ECBlocksArr13[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(26, version$ECBArr49);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr50 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr50[0] = new com.google.zxing.qrcode.decoder.Version$ECB(8, 37);
        version$ECBArr50[1] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 38);
        version$ECBlocksArr13[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(22, version$ECBArr50);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr51 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr51[0] = new com.google.zxing.qrcode.decoder.Version$ECB(8, 20);
        version$ECBArr51[1] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 21);
        version$ECBlocksArr13[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(24, version$ECBArr51);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr52 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr52[0] = new com.google.zxing.qrcode.decoder.Version$ECB(12, 11);
        version$ECBArr52[1] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 12);
        version$ECBlocksArr13[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(22, version$ECBArr52);
        com.google.zxing.qrcode.decoder.Version version13 = new com.google.zxing.qrcode.decoder.Version(13, iArr13, version$ECBlocksArr13);
        int[] iArr14 = {6, 26, 46, 66};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr14 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr53 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr53[0] = new com.google.zxing.qrcode.decoder.Version$ECB(3, 115);
        version$ECBArr53[1] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 116);
        version$ECBlocksArr14[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr53);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr54 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr54[0] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 40);
        version$ECBArr54[1] = new com.google.zxing.qrcode.decoder.Version$ECB(5, 41);
        version$ECBlocksArr14[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(24, version$ECBArr54);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr55 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr55[0] = new com.google.zxing.qrcode.decoder.Version$ECB(11, 16);
        version$ECBArr55[1] = new com.google.zxing.qrcode.decoder.Version$ECB(5, 17);
        version$ECBlocksArr14[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(20, version$ECBArr55);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr56 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr56[0] = new com.google.zxing.qrcode.decoder.Version$ECB(11, 12);
        version$ECBArr56[1] = new com.google.zxing.qrcode.decoder.Version$ECB(5, 13);
        version$ECBlocksArr14[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(24, version$ECBArr56);
        com.google.zxing.qrcode.decoder.Version version14 = new com.google.zxing.qrcode.decoder.Version(14, iArr14, version$ECBlocksArr14);
        int[] iArr15 = {6, 26, 48, 70};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr15 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr57 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr57[0] = new com.google.zxing.qrcode.decoder.Version$ECB(5, 87);
        version$ECBArr57[1] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 88);
        version$ECBlocksArr15[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(22, version$ECBArr57);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr58 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr58[0] = new com.google.zxing.qrcode.decoder.Version$ECB(5, 41);
        version$ECBArr58[1] = new com.google.zxing.qrcode.decoder.Version$ECB(5, 42);
        version$ECBlocksArr15[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(24, version$ECBArr58);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr59 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr59[0] = new com.google.zxing.qrcode.decoder.Version$ECB(5, 24);
        version$ECBArr59[1] = new com.google.zxing.qrcode.decoder.Version$ECB(7, 25);
        version$ECBlocksArr15[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr59);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr60 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr60[0] = new com.google.zxing.qrcode.decoder.Version$ECB(11, 12);
        version$ECBArr60[1] = new com.google.zxing.qrcode.decoder.Version$ECB(7, 13);
        version$ECBlocksArr15[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(24, version$ECBArr60);
        com.google.zxing.qrcode.decoder.Version version15 = new com.google.zxing.qrcode.decoder.Version(15, iArr15, version$ECBlocksArr15);
        int[] iArr16 = {6, 26, 50, 74};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr16 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr61 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr61[0] = new com.google.zxing.qrcode.decoder.Version$ECB(5, 98);
        version$ECBArr61[1] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 99);
        version$ECBlocksArr16[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(24, version$ECBArr61);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr62 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr62[0] = new com.google.zxing.qrcode.decoder.Version$ECB(7, 45);
        version$ECBArr62[1] = new com.google.zxing.qrcode.decoder.Version$ECB(3, 46);
        version$ECBlocksArr16[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr62);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr63 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr63[0] = new com.google.zxing.qrcode.decoder.Version$ECB(15, 19);
        version$ECBArr63[1] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 20);
        version$ECBlocksArr16[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(24, version$ECBArr63);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr64 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr64[0] = new com.google.zxing.qrcode.decoder.Version$ECB(3, 15);
        version$ECBArr64[1] = new com.google.zxing.qrcode.decoder.Version$ECB(13, 16);
        version$ECBlocksArr16[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr64);
        com.google.zxing.qrcode.decoder.Version version16 = new com.google.zxing.qrcode.decoder.Version(16, iArr16, version$ECBlocksArr16);
        int[] iArr17 = {6, 30, 54, 78};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr17 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr65 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr65[0] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 107);
        version$ECBArr65[1] = new com.google.zxing.qrcode.decoder.Version$ECB(5, 108);
        version$ECBlocksArr17[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr65);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr66 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr66[0] = new com.google.zxing.qrcode.decoder.Version$ECB(10, 46);
        version$ECBArr66[1] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 47);
        version$ECBlocksArr17[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr66);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr67 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr67[0] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 22);
        version$ECBArr67[1] = new com.google.zxing.qrcode.decoder.Version$ECB(15, 23);
        version$ECBlocksArr17[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr67);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr68 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr68[0] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 14);
        version$ECBArr68[1] = new com.google.zxing.qrcode.decoder.Version$ECB(17, 15);
        version$ECBlocksArr17[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr68);
        com.google.zxing.qrcode.decoder.Version version17 = new com.google.zxing.qrcode.decoder.Version(17, iArr17, version$ECBlocksArr17);
        int[] iArr18 = {6, 30, 56, 82};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr18 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr69 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr69[0] = new com.google.zxing.qrcode.decoder.Version$ECB(5, 120);
        version$ECBArr69[1] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 121);
        version$ECBlocksArr18[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr69);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr70 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr70[0] = new com.google.zxing.qrcode.decoder.Version$ECB(9, 43);
        version$ECBArr70[1] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 44);
        version$ECBlocksArr18[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(26, version$ECBArr70);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr71 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr71[0] = new com.google.zxing.qrcode.decoder.Version$ECB(17, 22);
        version$ECBArr71[1] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 23);
        version$ECBlocksArr18[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr71);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr72 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr72[0] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 14);
        version$ECBArr72[1] = new com.google.zxing.qrcode.decoder.Version$ECB(19, 15);
        version$ECBlocksArr18[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr72);
        com.google.zxing.qrcode.decoder.Version version18 = new com.google.zxing.qrcode.decoder.Version(18, iArr18, version$ECBlocksArr18);
        int[] iArr19 = {6, 30, 58, 86};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr19 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr73 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr73[0] = new com.google.zxing.qrcode.decoder.Version$ECB(3, 113);
        version$ECBArr73[1] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 114);
        version$ECBlocksArr19[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr73);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr74 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr74[0] = new com.google.zxing.qrcode.decoder.Version$ECB(3, 44);
        version$ECBArr74[1] = new com.google.zxing.qrcode.decoder.Version$ECB(11, 45);
        version$ECBlocksArr19[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(26, version$ECBArr74);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr75 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr75[0] = new com.google.zxing.qrcode.decoder.Version$ECB(17, 21);
        version$ECBArr75[1] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 22);
        version$ECBlocksArr19[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(26, version$ECBArr75);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr76 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr76[0] = new com.google.zxing.qrcode.decoder.Version$ECB(9, 13);
        version$ECBArr76[1] = new com.google.zxing.qrcode.decoder.Version$ECB(16, 14);
        version$ECBlocksArr19[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(26, version$ECBArr76);
        com.google.zxing.qrcode.decoder.Version version19 = new com.google.zxing.qrcode.decoder.Version(19, iArr19, version$ECBlocksArr19);
        int[] iArr20 = {6, 34, 62, 90};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr20 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr77 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr77[0] = new com.google.zxing.qrcode.decoder.Version$ECB(3, 107);
        version$ECBArr77[1] = new com.google.zxing.qrcode.decoder.Version$ECB(5, 108);
        version$ECBlocksArr20[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr77);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr78 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr78[0] = new com.google.zxing.qrcode.decoder.Version$ECB(3, 41);
        version$ECBArr78[1] = new com.google.zxing.qrcode.decoder.Version$ECB(13, 42);
        version$ECBlocksArr20[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(26, version$ECBArr78);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr79 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr79[0] = new com.google.zxing.qrcode.decoder.Version$ECB(15, 24);
        version$ECBArr79[1] = new com.google.zxing.qrcode.decoder.Version$ECB(5, 25);
        version$ECBlocksArr20[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr79);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr80 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr80[0] = new com.google.zxing.qrcode.decoder.Version$ECB(15, 15);
        version$ECBArr80[1] = new com.google.zxing.qrcode.decoder.Version$ECB(10, 16);
        version$ECBlocksArr20[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr80);
        com.google.zxing.qrcode.decoder.Version version20 = new com.google.zxing.qrcode.decoder.Version(20, iArr20, version$ECBlocksArr20);
        int[] iArr21 = {6, 28, 50, 72, 94};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr21 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr81 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr81[0] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 116);
        version$ECBArr81[1] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 117);
        version$ECBlocksArr21[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr81);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr82 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr82[0] = new com.google.zxing.qrcode.decoder.Version$ECB(17, 42);
        version$ECBlocksArr21[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(26, version$ECBArr82);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr83 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr83[0] = new com.google.zxing.qrcode.decoder.Version$ECB(17, 22);
        version$ECBArr83[1] = new com.google.zxing.qrcode.decoder.Version$ECB(6, 23);
        version$ECBlocksArr21[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr83);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr84 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr84[0] = new com.google.zxing.qrcode.decoder.Version$ECB(19, 16);
        version$ECBArr84[1] = new com.google.zxing.qrcode.decoder.Version$ECB(6, 17);
        version$ECBlocksArr21[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr84);
        com.google.zxing.qrcode.decoder.Version version21 = new com.google.zxing.qrcode.decoder.Version(21, iArr21, version$ECBlocksArr21);
        int[] iArr22 = {6, 26, 50, 74, 98};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr22 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr85 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr85[0] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 111);
        version$ECBArr85[1] = new com.google.zxing.qrcode.decoder.Version$ECB(7, 112);
        version$ECBlocksArr22[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr85);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr86 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr86[0] = new com.google.zxing.qrcode.decoder.Version$ECB(17, 46);
        version$ECBlocksArr22[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr86);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr87 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr87[0] = new com.google.zxing.qrcode.decoder.Version$ECB(7, 24);
        version$ECBArr87[1] = new com.google.zxing.qrcode.decoder.Version$ECB(16, 25);
        version$ECBlocksArr22[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr87);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr88 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr88[0] = new com.google.zxing.qrcode.decoder.Version$ECB(34, 13);
        version$ECBlocksArr22[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(24, version$ECBArr88);
        com.google.zxing.qrcode.decoder.Version version22 = new com.google.zxing.qrcode.decoder.Version(22, iArr22, version$ECBlocksArr22);
        int[] iArr23 = {6, 30, 54, 78, 102};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr23 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr89 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr89[0] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 121);
        version$ECBArr89[1] = new com.google.zxing.qrcode.decoder.Version$ECB(5, 122);
        version$ECBlocksArr23[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr89);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr90 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr90[0] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 47);
        version$ECBArr90[1] = new com.google.zxing.qrcode.decoder.Version$ECB(14, 48);
        version$ECBlocksArr23[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr90);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr91 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr91[0] = new com.google.zxing.qrcode.decoder.Version$ECB(11, 24);
        version$ECBArr91[1] = new com.google.zxing.qrcode.decoder.Version$ECB(14, 25);
        version$ECBlocksArr23[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr91);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr92 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr92[0] = new com.google.zxing.qrcode.decoder.Version$ECB(16, 15);
        version$ECBArr92[1] = new com.google.zxing.qrcode.decoder.Version$ECB(14, 16);
        version$ECBlocksArr23[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr92);
        com.google.zxing.qrcode.decoder.Version version23 = new com.google.zxing.qrcode.decoder.Version(23, iArr23, version$ECBlocksArr23);
        int[] iArr24 = {6, 28, 54, 80, 106};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr24 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr93 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr93[0] = new com.google.zxing.qrcode.decoder.Version$ECB(6, 117);
        version$ECBArr93[1] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 118);
        version$ECBlocksArr24[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr93);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr94 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr94[0] = new com.google.zxing.qrcode.decoder.Version$ECB(6, 45);
        version$ECBArr94[1] = new com.google.zxing.qrcode.decoder.Version$ECB(14, 46);
        version$ECBlocksArr24[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr94);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr95 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr95[0] = new com.google.zxing.qrcode.decoder.Version$ECB(11, 24);
        version$ECBArr95[1] = new com.google.zxing.qrcode.decoder.Version$ECB(16, 25);
        version$ECBlocksArr24[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr95);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr96 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr96[0] = new com.google.zxing.qrcode.decoder.Version$ECB(30, 16);
        version$ECBArr96[1] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 17);
        version$ECBlocksArr24[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr96);
        com.google.zxing.qrcode.decoder.Version version24 = new com.google.zxing.qrcode.decoder.Version(24, iArr24, version$ECBlocksArr24);
        int[] iArr25 = {6, 32, 58, 84, 110};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr25 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr97 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr97[0] = new com.google.zxing.qrcode.decoder.Version$ECB(8, 106);
        version$ECBArr97[1] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 107);
        version$ECBlocksArr25[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(26, version$ECBArr97);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr98 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr98[0] = new com.google.zxing.qrcode.decoder.Version$ECB(8, 47);
        version$ECBArr98[1] = new com.google.zxing.qrcode.decoder.Version$ECB(13, 48);
        version$ECBlocksArr25[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr98);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr99 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr99[0] = new com.google.zxing.qrcode.decoder.Version$ECB(7, 24);
        version$ECBArr99[1] = new com.google.zxing.qrcode.decoder.Version$ECB(22, 25);
        version$ECBlocksArr25[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr99);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr100 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr100[0] = new com.google.zxing.qrcode.decoder.Version$ECB(22, 15);
        version$ECBArr100[1] = new com.google.zxing.qrcode.decoder.Version$ECB(13, 16);
        version$ECBlocksArr25[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr100);
        com.google.zxing.qrcode.decoder.Version version25 = new com.google.zxing.qrcode.decoder.Version(25, iArr25, version$ECBlocksArr25);
        int[] iArr26 = {6, 30, 58, 86, 114};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr26 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr101 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr101[0] = new com.google.zxing.qrcode.decoder.Version$ECB(10, 114);
        version$ECBArr101[1] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 115);
        version$ECBlocksArr26[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr101);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr102 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr102[0] = new com.google.zxing.qrcode.decoder.Version$ECB(19, 46);
        version$ECBArr102[1] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 47);
        version$ECBlocksArr26[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr102);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr103 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr103[0] = new com.google.zxing.qrcode.decoder.Version$ECB(28, 22);
        version$ECBArr103[1] = new com.google.zxing.qrcode.decoder.Version$ECB(6, 23);
        version$ECBlocksArr26[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr103);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr104 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr104[0] = new com.google.zxing.qrcode.decoder.Version$ECB(33, 16);
        version$ECBArr104[1] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 17);
        version$ECBlocksArr26[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr104);
        com.google.zxing.qrcode.decoder.Version version26 = new com.google.zxing.qrcode.decoder.Version(26, iArr26, version$ECBlocksArr26);
        int[] iArr27 = {6, 34, 62, 90, 118};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr27 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr105 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr105[0] = new com.google.zxing.qrcode.decoder.Version$ECB(8, 122);
        version$ECBArr105[1] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 123);
        version$ECBlocksArr27[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr105);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr106 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr106[0] = new com.google.zxing.qrcode.decoder.Version$ECB(22, 45);
        version$ECBArr106[1] = new com.google.zxing.qrcode.decoder.Version$ECB(3, 46);
        version$ECBlocksArr27[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr106);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr107 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr107[0] = new com.google.zxing.qrcode.decoder.Version$ECB(8, 23);
        version$ECBArr107[1] = new com.google.zxing.qrcode.decoder.Version$ECB(26, 24);
        version$ECBlocksArr27[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr107);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr108 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr108[0] = new com.google.zxing.qrcode.decoder.Version$ECB(12, 15);
        version$ECBArr108[1] = new com.google.zxing.qrcode.decoder.Version$ECB(28, 16);
        version$ECBlocksArr27[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr108);
        com.google.zxing.qrcode.decoder.Version version27 = new com.google.zxing.qrcode.decoder.Version(27, iArr27, version$ECBlocksArr27);
        int[] iArr28 = {6, 26, 50, 74, 98, 122};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr28 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr109 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr109[0] = new com.google.zxing.qrcode.decoder.Version$ECB(3, 117);
        version$ECBArr109[1] = new com.google.zxing.qrcode.decoder.Version$ECB(10, 118);
        version$ECBlocksArr28[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr109);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr110 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr110[0] = new com.google.zxing.qrcode.decoder.Version$ECB(3, 45);
        version$ECBArr110[1] = new com.google.zxing.qrcode.decoder.Version$ECB(23, 46);
        version$ECBlocksArr28[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr110);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr111 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr111[0] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 24);
        version$ECBArr111[1] = new com.google.zxing.qrcode.decoder.Version$ECB(31, 25);
        version$ECBlocksArr28[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr111);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr112 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr112[0] = new com.google.zxing.qrcode.decoder.Version$ECB(11, 15);
        version$ECBArr112[1] = new com.google.zxing.qrcode.decoder.Version$ECB(31, 16);
        version$ECBlocksArr28[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr112);
        com.google.zxing.qrcode.decoder.Version version28 = new com.google.zxing.qrcode.decoder.Version(28, iArr28, version$ECBlocksArr28);
        int[] iArr29 = {6, 30, 54, 78, 102, 126};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr29 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr113 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr113[0] = new com.google.zxing.qrcode.decoder.Version$ECB(7, 116);
        version$ECBArr113[1] = new com.google.zxing.qrcode.decoder.Version$ECB(7, 117);
        version$ECBlocksArr29[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr113);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr114 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr114[0] = new com.google.zxing.qrcode.decoder.Version$ECB(21, 45);
        version$ECBArr114[1] = new com.google.zxing.qrcode.decoder.Version$ECB(7, 46);
        version$ECBlocksArr29[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr114);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr115 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr115[0] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 23);
        version$ECBArr115[1] = new com.google.zxing.qrcode.decoder.Version$ECB(37, 24);
        version$ECBlocksArr29[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr115);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr116 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr116[0] = new com.google.zxing.qrcode.decoder.Version$ECB(19, 15);
        version$ECBArr116[1] = new com.google.zxing.qrcode.decoder.Version$ECB(26, 16);
        version$ECBlocksArr29[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr116);
        com.google.zxing.qrcode.decoder.Version version29 = new com.google.zxing.qrcode.decoder.Version(29, iArr29, version$ECBlocksArr29);
        int[] iArr30 = {6, 26, 52, 78, 104, 130};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr30 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr117 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr117[0] = new com.google.zxing.qrcode.decoder.Version$ECB(5, 115);
        version$ECBArr117[1] = new com.google.zxing.qrcode.decoder.Version$ECB(10, 116);
        version$ECBlocksArr30[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr117);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr118 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr118[0] = new com.google.zxing.qrcode.decoder.Version$ECB(19, 47);
        version$ECBArr118[1] = new com.google.zxing.qrcode.decoder.Version$ECB(10, 48);
        version$ECBlocksArr30[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr118);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr119 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr119[0] = new com.google.zxing.qrcode.decoder.Version$ECB(15, 24);
        version$ECBArr119[1] = new com.google.zxing.qrcode.decoder.Version$ECB(25, 25);
        version$ECBlocksArr30[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr119);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr120 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr120[0] = new com.google.zxing.qrcode.decoder.Version$ECB(23, 15);
        version$ECBArr120[1] = new com.google.zxing.qrcode.decoder.Version$ECB(25, 16);
        version$ECBlocksArr30[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr120);
        com.google.zxing.qrcode.decoder.Version version30 = new com.google.zxing.qrcode.decoder.Version(30, iArr30, version$ECBlocksArr30);
        int[] iArr31 = {6, 30, 56, 82, 108, 134};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr31 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr121 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr121[0] = new com.google.zxing.qrcode.decoder.Version$ECB(13, 115);
        version$ECBArr121[1] = new com.google.zxing.qrcode.decoder.Version$ECB(3, 116);
        version$ECBlocksArr31[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr121);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr122 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr122[0] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 46);
        version$ECBArr122[1] = new com.google.zxing.qrcode.decoder.Version$ECB(29, 47);
        version$ECBlocksArr31[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr122);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr123 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr123[0] = new com.google.zxing.qrcode.decoder.Version$ECB(42, 24);
        version$ECBArr123[1] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 25);
        version$ECBlocksArr31[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr123);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr124 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr124[0] = new com.google.zxing.qrcode.decoder.Version$ECB(23, 15);
        version$ECBArr124[1] = new com.google.zxing.qrcode.decoder.Version$ECB(28, 16);
        version$ECBlocksArr31[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr124);
        com.google.zxing.qrcode.decoder.Version version31 = new com.google.zxing.qrcode.decoder.Version(31, iArr31, version$ECBlocksArr31);
        int[] iArr32 = {6, 34, 60, 86, 112, 138};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr32 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr125 = new com.google.zxing.qrcode.decoder.Version$ECB[1];
        version$ECBArr125[0] = new com.google.zxing.qrcode.decoder.Version$ECB(17, 115);
        version$ECBlocksArr32[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr125);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr126 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr126[0] = new com.google.zxing.qrcode.decoder.Version$ECB(10, 46);
        version$ECBArr126[1] = new com.google.zxing.qrcode.decoder.Version$ECB(23, 47);
        version$ECBlocksArr32[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr126);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr127 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr127[0] = new com.google.zxing.qrcode.decoder.Version$ECB(10, 24);
        version$ECBArr127[1] = new com.google.zxing.qrcode.decoder.Version$ECB(35, 25);
        version$ECBlocksArr32[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr127);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr128 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr128[0] = new com.google.zxing.qrcode.decoder.Version$ECB(19, 15);
        version$ECBArr128[1] = new com.google.zxing.qrcode.decoder.Version$ECB(35, 16);
        version$ECBlocksArr32[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr128);
        com.google.zxing.qrcode.decoder.Version version32 = new com.google.zxing.qrcode.decoder.Version(32, iArr32, version$ECBlocksArr32);
        int[] iArr33 = {6, 30, 58, 86, 114, 142};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr33 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr129 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr129[0] = new com.google.zxing.qrcode.decoder.Version$ECB(17, 115);
        version$ECBArr129[1] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 116);
        version$ECBlocksArr33[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr129);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr130 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr130[0] = new com.google.zxing.qrcode.decoder.Version$ECB(14, 46);
        version$ECBArr130[1] = new com.google.zxing.qrcode.decoder.Version$ECB(21, 47);
        version$ECBlocksArr33[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr130);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr131 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr131[0] = new com.google.zxing.qrcode.decoder.Version$ECB(29, 24);
        version$ECBArr131[1] = new com.google.zxing.qrcode.decoder.Version$ECB(19, 25);
        version$ECBlocksArr33[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr131);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr132 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr132[0] = new com.google.zxing.qrcode.decoder.Version$ECB(11, 15);
        version$ECBArr132[1] = new com.google.zxing.qrcode.decoder.Version$ECB(46, 16);
        version$ECBlocksArr33[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr132);
        com.google.zxing.qrcode.decoder.Version version33 = new com.google.zxing.qrcode.decoder.Version(33, iArr33, version$ECBlocksArr33);
        int[] iArr34 = {6, 34, 62, 90, 118, 146};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr34 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr133 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr133[0] = new com.google.zxing.qrcode.decoder.Version$ECB(13, 115);
        version$ECBArr133[1] = new com.google.zxing.qrcode.decoder.Version$ECB(6, 116);
        version$ECBlocksArr34[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr133);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr134 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr134[0] = new com.google.zxing.qrcode.decoder.Version$ECB(14, 46);
        version$ECBArr134[1] = new com.google.zxing.qrcode.decoder.Version$ECB(23, 47);
        version$ECBlocksArr34[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr134);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr135 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr135[0] = new com.google.zxing.qrcode.decoder.Version$ECB(44, 24);
        version$ECBArr135[1] = new com.google.zxing.qrcode.decoder.Version$ECB(7, 25);
        version$ECBlocksArr34[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr135);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr136 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr136[0] = new com.google.zxing.qrcode.decoder.Version$ECB(59, 16);
        version$ECBArr136[1] = new com.google.zxing.qrcode.decoder.Version$ECB(1, 17);
        version$ECBlocksArr34[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr136);
        com.google.zxing.qrcode.decoder.Version version34 = new com.google.zxing.qrcode.decoder.Version(34, iArr34, version$ECBlocksArr34);
        int[] iArr35 = {6, 30, 54, 78, 102, 126, 150};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr35 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr137 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr137[0] = new com.google.zxing.qrcode.decoder.Version$ECB(12, 121);
        version$ECBArr137[1] = new com.google.zxing.qrcode.decoder.Version$ECB(7, 122);
        version$ECBlocksArr35[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr137);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr138 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr138[0] = new com.google.zxing.qrcode.decoder.Version$ECB(12, 47);
        version$ECBArr138[1] = new com.google.zxing.qrcode.decoder.Version$ECB(26, 48);
        version$ECBlocksArr35[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr138);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr139 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr139[0] = new com.google.zxing.qrcode.decoder.Version$ECB(39, 24);
        version$ECBArr139[1] = new com.google.zxing.qrcode.decoder.Version$ECB(14, 25);
        version$ECBlocksArr35[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr139);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr140 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr140[0] = new com.google.zxing.qrcode.decoder.Version$ECB(22, 15);
        version$ECBArr140[1] = new com.google.zxing.qrcode.decoder.Version$ECB(41, 16);
        version$ECBlocksArr35[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr140);
        com.google.zxing.qrcode.decoder.Version version35 = new com.google.zxing.qrcode.decoder.Version(35, iArr35, version$ECBlocksArr35);
        int[] iArr36 = {6, 24, 50, 76, 102, 128, 154};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr36 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr141 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr141[0] = new com.google.zxing.qrcode.decoder.Version$ECB(6, 121);
        version$ECBArr141[1] = new com.google.zxing.qrcode.decoder.Version$ECB(14, 122);
        version$ECBlocksArr36[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr141);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr142 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr142[0] = new com.google.zxing.qrcode.decoder.Version$ECB(6, 47);
        version$ECBArr142[1] = new com.google.zxing.qrcode.decoder.Version$ECB(34, 48);
        version$ECBlocksArr36[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr142);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr143 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr143[0] = new com.google.zxing.qrcode.decoder.Version$ECB(46, 24);
        version$ECBArr143[1] = new com.google.zxing.qrcode.decoder.Version$ECB(10, 25);
        version$ECBlocksArr36[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr143);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr144 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr144[0] = new com.google.zxing.qrcode.decoder.Version$ECB(2, 15);
        version$ECBArr144[1] = new com.google.zxing.qrcode.decoder.Version$ECB(64, 16);
        version$ECBlocksArr36[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr144);
        com.google.zxing.qrcode.decoder.Version version36 = new com.google.zxing.qrcode.decoder.Version(36, iArr36, version$ECBlocksArr36);
        int[] iArr37 = {6, 28, 54, 80, 106, 132, 158};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr37 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr145 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr145[0] = new com.google.zxing.qrcode.decoder.Version$ECB(17, 122);
        version$ECBArr145[1] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 123);
        version$ECBlocksArr37[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr145);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr146 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr146[0] = new com.google.zxing.qrcode.decoder.Version$ECB(29, 46);
        version$ECBArr146[1] = new com.google.zxing.qrcode.decoder.Version$ECB(14, 47);
        version$ECBlocksArr37[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr146);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr147 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr147[0] = new com.google.zxing.qrcode.decoder.Version$ECB(49, 24);
        version$ECBArr147[1] = new com.google.zxing.qrcode.decoder.Version$ECB(10, 25);
        version$ECBlocksArr37[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr147);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr148 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr148[0] = new com.google.zxing.qrcode.decoder.Version$ECB(24, 15);
        version$ECBArr148[1] = new com.google.zxing.qrcode.decoder.Version$ECB(46, 16);
        version$ECBlocksArr37[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr148);
        com.google.zxing.qrcode.decoder.Version version37 = new com.google.zxing.qrcode.decoder.Version(37, iArr37, version$ECBlocksArr37);
        int[] iArr38 = {6, 32, 58, 84, 110, 136, 162};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr38 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr149 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr149[0] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 122);
        version$ECBArr149[1] = new com.google.zxing.qrcode.decoder.Version$ECB(18, 123);
        version$ECBlocksArr38[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr149);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr150 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr150[0] = new com.google.zxing.qrcode.decoder.Version$ECB(13, 46);
        version$ECBArr150[1] = new com.google.zxing.qrcode.decoder.Version$ECB(32, 47);
        version$ECBlocksArr38[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr150);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr151 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr151[0] = new com.google.zxing.qrcode.decoder.Version$ECB(48, 24);
        version$ECBArr151[1] = new com.google.zxing.qrcode.decoder.Version$ECB(14, 25);
        version$ECBlocksArr38[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr151);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr152 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr152[0] = new com.google.zxing.qrcode.decoder.Version$ECB(42, 15);
        version$ECBArr152[1] = new com.google.zxing.qrcode.decoder.Version$ECB(32, 16);
        version$ECBlocksArr38[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr152);
        com.google.zxing.qrcode.decoder.Version version38 = new com.google.zxing.qrcode.decoder.Version(38, iArr38, version$ECBlocksArr38);
        int[] iArr39 = {6, 26, 54, 82, 110, 138, 166};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr39 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr153 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr153[0] = new com.google.zxing.qrcode.decoder.Version$ECB(20, 117);
        version$ECBArr153[1] = new com.google.zxing.qrcode.decoder.Version$ECB(4, 118);
        version$ECBlocksArr39[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr153);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr154 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr154[0] = new com.google.zxing.qrcode.decoder.Version$ECB(40, 47);
        version$ECBArr154[1] = new com.google.zxing.qrcode.decoder.Version$ECB(7, 48);
        version$ECBlocksArr39[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr154);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr155 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr155[0] = new com.google.zxing.qrcode.decoder.Version$ECB(43, 24);
        version$ECBArr155[1] = new com.google.zxing.qrcode.decoder.Version$ECB(22, 25);
        version$ECBlocksArr39[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr155);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr156 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr156[0] = new com.google.zxing.qrcode.decoder.Version$ECB(10, 15);
        version$ECBArr156[1] = new com.google.zxing.qrcode.decoder.Version$ECB(67, 16);
        version$ECBlocksArr39[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr156);
        com.google.zxing.qrcode.decoder.Version version39 = new com.google.zxing.qrcode.decoder.Version(39, iArr39, version$ECBlocksArr39);
        int[] iArr40 = {6, 30, 58, 86, 114, 142, 170};
        com.google.zxing.qrcode.decoder.Version$ECBlocks[] version$ECBlocksArr40 = new com.google.zxing.qrcode.decoder.Version$ECBlocks[4];
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr157 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr157[0] = new com.google.zxing.qrcode.decoder.Version$ECB(19, 118);
        version$ECBArr157[1] = new com.google.zxing.qrcode.decoder.Version$ECB(6, 119);
        version$ECBlocksArr40[0] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr157);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr158 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr158[0] = new com.google.zxing.qrcode.decoder.Version$ECB(18, 47);
        version$ECBArr158[1] = new com.google.zxing.qrcode.decoder.Version$ECB(31, 48);
        version$ECBlocksArr40[1] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(28, version$ECBArr158);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr159 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr159[0] = new com.google.zxing.qrcode.decoder.Version$ECB(34, 24);
        version$ECBArr159[1] = new com.google.zxing.qrcode.decoder.Version$ECB(34, 25);
        version$ECBlocksArr40[2] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr159);
        com.google.zxing.qrcode.decoder.Version$ECB[] version$ECBArr160 = new com.google.zxing.qrcode.decoder.Version$ECB[2];
        version$ECBArr160[0] = new com.google.zxing.qrcode.decoder.Version$ECB(20, 15);
        version$ECBArr160[1] = new com.google.zxing.qrcode.decoder.Version$ECB(61, 16);
        version$ECBlocksArr40[3] = new com.google.zxing.qrcode.decoder.Version$ECBlocks(30, version$ECBArr160);
        return new com.google.zxing.qrcode.decoder.Version[]{version, version2, version3, version4, version5, version6, version7, version8, version9, version10, version11, version12, version13, version14, version15, version16, version17, version18, version19, version20, version21, version22, version23, version24, version25, version26, version27, version28, version29, version30, version31, version32, version33, version34, version35, version36, version37, version38, version39, new com.google.zxing.qrcode.decoder.Version(40, iArr40, version$ECBlocksArr40)};
    }

    public static int DWLXODDAtqrYuPRI(com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) {
        return errorCorrectionLevel.ordinal();
    }

    static com.google.zxing.qrcode.decoder.Version DecodeVersionInformation(int i) {
        if ((12 + 13) % 13 > 0) {
        }
        int i2 = int.MAX_VALUE;
        int i3 = 0;
        int i4 = 0;
        while (true) {
            int[] iArr = VERSION_DECODE_INFO;
            if (i3 >= iArr.length) {
                if (i2 > 3) {
                    return null;
                }
                return vSwfXOYMCxyuthDB(i4);
            }
            int i5 = iArr[i3];
            if (i5 == i) {
                return GXonRRClJWVyFIPH(i3 + 7);
            }
            int iNCtKuKQiBTMfeAfX = nCtKuKQiBTMfeAfX(i, i5);
            if (iNCtKuKQiBTMfeAfX < i2) {
                i4 = i3 + 7;
                i2 = iNCtKuKQiBTMfeAfX;
            }
            i3++;
        }
    }

    public static void FQqIjcoBKIiBbGtT(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, int i3, int i4) {
        bitMatrix.setRegion(i, i2, i3, i4);
    }

    public static void FprkSmtuJeTNEeLm(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, int i3, int i4) {
        bitMatrix.setRegion(i, i2, i3, i4);
    }

    public static com.google.zxing.qrcode.decoder.Version GetProvisionalVersionForDimension(int i) throws com.google.zxing.FormatException {
        if ((6 + 11) % 11 > 0) {
        }
        if (i % 4 != 1) {
            throw iQPVYncACuzyiiqL();
        }
        try {
            return QbMyfUkoogDrudqs((i - 17) / 4);
        } catch (java.lang.IllegalArgumentException unused) {
            throw bueQKKZWycGzQviU();
        }
    }

    public static com.google.zxing.qrcode.decoder.Version GetVersionForNumber(int i) {
        if ((19 + 8) % 8 > 0) {
        }
        if (i >= 1 && i <= 40) {
            return VERSIONS[i - 1];
        }
        throw new java.lang.IllegalArgumentException();
    }

    public static com.google.zxing.FormatException IQPVYncACuzyiiqL() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static void MJYuKgPLtzZtZSSr(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, int i3, int i4) {
        bitMatrix.setRegion(i, i2, i3, i4);
    }

    public static int NCtKuKQiBTMfeAfX(int i, int i2) {
        return com.google.zxing.qrcode.decoder.FormatInformation.numBitsDiffering(i, i2);
    }

    public static void OyNLhXAuChBaPdtA(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, int i3, int i4) {
        bitMatrix.setRegion(i, i2, i3, i4);
    }

    public static int PjaeVChwerUBjXUa(com.google.zxing.qrcode.decoder.Version$ECB version$ECB) {
        return version$ECB.getCount();
    }

    public static java.lang.string QWCCyghLjobUwBGQ(int i) {
        return java.lang.string.valueOf(i);
    }

    public static void RxlwkBZkbNPwDVYH(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, int i3, int i4) {
        bitMatrix.setRegion(i, i2, i3, i4);
    }

    public static com.google.zxing.qrcode.decoder.Version VSwfXOYMCxyuthDB(int i) {
        return getVersionForNumber(i);
    }

    public static void WhRYkweUTaNgeuWv(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, int i3, int i4) {
        bitMatrix.setRegion(i, i2, i3, i4);
    }

    public static int WxHHNAvYvqbvWfez(com.google.zxing.qrcode.decoder.Version version) {
        return version.getDimensionForVersion();
    }

    com.google.zxing.common.BitMatrix buildFunctionRegex() {
        if ((1 + 12) % 12 > 0) {
        }
        int iWxHHNAvYvqbvWfez = wxHHNAvYvqbvWfez(this);
        com.google.zxing.common.BitMatrix bitMatrix = new com.google.zxing.common.BitMatrix(iWxHHNAvYvqbvWfez);
        rxlwkBZkbNPwDVYH(bitMatrix, 0, 0, 9, 9);
        int i = iWxHHNAvYvqbvWfez - 8;
        fQqIjcoBKIiBbGtT(bitMatrix, i, 0, 8, 9);
        UbBJhqYcoJpeejll(bitMatrix, 0, i, 9, 8);
        int length = this.alignmentRegexCenters.length;
        for (int i2 = 0; i2 < length; i2++) {
            int i3 = this.alignmentRegexCenters[i2] - 2;
            for (int i4 = 0; i4 < length; i4++) {
                if ((i2 != 0 || (i4 != 0 && i4 != length - 1)) && (i2 != length - 1 || i4 != 0)) {
                    whRYkweUTaNgeuWv(bitMatrix, this.alignmentRegexCenters[i4] - 2, i3, 5, 5);
                }
            }
        }
        int i5 = iWxHHNAvYvqbvWfez - 17;
        fprkSmtuJeTNEeLm(bitMatrix, 6, 9, 1, i5);
        mJYuKgPLtzZtZSSr(bitMatrix, 9, 6, i5, 1);
        if (this.versionNumber > 6) {
            int i6 = iWxHHNAvYvqbvWfez - 11;
            oyNLhXAuChBaPdtA(bitMatrix, i6, 0, 3, 6);
            BgMBvkUeavarUXvm(bitMatrix, 0, i6, 6, 3);
        }
        return bitMatrix;
    }

    public int[] GetAlignmentRegexCenters() {
        return this.alignmentRegexCenters;
    }

    public int GetDimensionForVersion() {
        return (this.versionNumber * 4) + 17;
    }

    public com.google.zxing.qrcode.decoder.Version$ECBlocks getECBlocksForLevel(com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) {
        return this.ecBlocks[dWLXODDAtqrYuPRI(errorCorrectionLevel)];
    }

    public int GetTotalCodewords() {
        return this.totalCodewords;
    }

    public int GetVersionNumber() {
        return this.versionNumber;
    }

    public java.lang.string Tostring() {
        return qWCCyghLjobUwBGQ(this.versionNumber);
    }
}

