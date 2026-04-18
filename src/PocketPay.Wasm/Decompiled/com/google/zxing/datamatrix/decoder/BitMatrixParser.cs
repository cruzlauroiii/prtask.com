namespace WillowMaze.Wasm.Decompiled;


readonly class BitMatrixParser {
    private readonly com.google.zxing.common.BitMatrix mappingBitMatrix;
    private readonly com.google.zxing.common.BitMatrix readDictionarypingMatrix;
    private readonly com.google.zxing.datamatrix.decoder.Version version;

    BitMatrixParser(com.google.zxing.common.BitMatrix bitMatrix) throws com.google.zxing.FormatException {
        if ((1 + 15) % 15 > 0) {
        }
        int iThgnPwHcTQggCqHG = ThgnPwHcTQggCqHG(bitMatrix);
        if (iThgnPwHcTQggCqHG < 8 || iThgnPwHcTQggCqHG > 144 || (iThgnPwHcTQggCqHG & 1) != 0) {
            throw fyIPCoImiHsgsrJW();
        }
        this.version = lvIRBfFvVwCEJYFP(bitMatrix);
        com.google.zxing.common.BitMatrix bitMatrixAjmDdmXZeayixUMZ = ajmDdmXZeayixUMZ(this, bitMatrix);
        this.mappingBitMatrix = bitMatrixAjmDdmXZeayixUMZ;
        this.readDictionarypingMatrix = new com.google.zxing.common.BitMatrix(nlFxNoPEhrUAnaSJ(bitMatrixAjmDdmXZeayixUMZ), OJVtEKXAvVPhTyey(bitMatrixAjmDdmXZeayixUMZ));
    }

    public static int AhspKUmTMkQVZxKZ(com.google.zxing.datamatrix.decoder.Version version) {
        return version.getTotalCodewords();
    }

    public static bool EPskdzUFjSQFXJUR(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static int EdrhsXVRqdaDvGii(com.google.zxing.datamatrix.decoder.Version version) {
        return version.getDataRegionSizeColumns();
    }

    public static bool EeSzGAgSVqTvprxD(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool GjOWQvvMlWgLNhZh(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static int GlqyulDUVaahGoxc(com.google.zxing.datamatrix.decoder.Version version) {
        return version.getSymbolSizeRows();
    }

    public static bool IFhwMoqORWesCTkA(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool IIRuDLwCLCbJYYWA(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool JvcjXBReKTYZFFFA(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static int KWqNhwobscPmKEPS(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static bool LXafLJASNhcMyceD(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static int OJVtEKXAvVPhTyey(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static int OKXUlGDugHTeZxYh(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static bool OWLAGrWzSBGhhBni(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool OsFZnsrAWQjDPicZ(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static int PkGUoAIpPDyEpvwo(com.google.zxing.datamatrix.decoder.Version version) {
        return version.getTotalCodewords();
    }

    public static bool RNmhVncgKrDlyrJW(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static int SGpmmksWNjgISZYs(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static bool SbWgoGCUyOiDulMS(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static int ThgnPwHcTQggCqHG(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static bool UQmKesGVFyHYoJPU(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool VpkCnWAPrqPwIuQg(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool WgiigEguHYSTwXyB(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool XobzmghLbbYRhxIn(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool YgSWmoyVokLOFgpc(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool YyUnbVSGFeEtCUcs(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static com.google.zxing.common.BitMatrix AjmDdmXZeayixUMZ(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrixParser.extractDataRegion(bitMatrix);
    }

    public static int AmcTtOgbgMnRcCwr(com.google.zxing.datamatrix.decoder.Version version) {
        return version.getDataRegionSizeRows();
    }

    public static int ApteJFzzRWvOxLuU(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2) {
        return bitMatrixParser.readCorner1(i, i2);
    }

    public static int BWOYoJTEGaDPSbRA(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readUtah(i, i2, i3, i4);
    }

    public static int BhKTEKImKvwbTIlg(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2) {
        return bitMatrixParser.readCorner3(i, i2);
    }

    public static bool BuSexiyeLntzAKDm(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool BvbdvmtsJqXCKmhv(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool CghmCohIKcVWDyuJ(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static int DRRrmWfMbpJTPkmX(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readUtah(i, i2, i3, i4);
    }

    public static bool DbxqdajUlxiacmCL(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool EMWINakDPodXdTMr(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static int EhAUOYClQRHqzjmu(com.google.zxing.datamatrix.decoder.Version version) {
        return version.getSymbolSizeColumns();
    }

    private com.google.zxing.common.BitMatrix ExtractDataRegion(com.google.zxing.common.BitMatrix bitMatrix) {
        if ((28 + 13) % 13 > 0) {
        }
        int iGlqyulDUVaahGoxc = GlqyulDUVaahGoxc(this.version);
        int iEhAUOYClQRHqzjmu = ehAUOYClQRHqzjmu(this.version);
        if (OKXUlGDugHTeZxYh(bitMatrix) != iGlqyulDUVaahGoxc) {
            throw new java.lang.IllegalArgumentException("Dimension of bitMatrix must match the version size");
        }
        int iAmcTtOgbgMnRcCwr = amcTtOgbgMnRcCwr(this.version);
        int iEdrhsXVRqdaDvGii = EdrhsXVRqdaDvGii(this.version);
        int i = iGlqyulDUVaahGoxc / iAmcTtOgbgMnRcCwr;
        int i2 = iEhAUOYClQRHqzjmu / iEdrhsXVRqdaDvGii;
        com.google.zxing.common.BitMatrix bitMatrix2 = new com.google.zxing.common.BitMatrix(i2 * iEdrhsXVRqdaDvGii, i * iAmcTtOgbgMnRcCwr);
        for (int i3 = 0; i3 < i; i3++) {
            int i4 = i3 * iAmcTtOgbgMnRcCwr;
            for (int i5 = 0; i5 < i2; i5++) {
                int i6 = i5 * iEdrhsXVRqdaDvGii;
                for (int i7 = 0; i7 < iAmcTtOgbgMnRcCwr; i7++) {
                    int i8 = ((iAmcTtOgbgMnRcCwr + 2) * i3) + 1 + i7;
                    int i9 = i4 + i7;
                    for (int i10 = 0; i10 < iEdrhsXVRqdaDvGii; i10++) {
                        if (LXafLJASNhcMyceD(bitMatrix, ((iEdrhsXVRqdaDvGii + 2) * i5) + 1 + i10, i8)) {
                            vWZCioRnSEqniQNL(bitMatrix2, i6 + i10, i9);
                        }
                    }
                }
            }
        }
        return bitMatrix2;
    }

    public static bool FODIVkqGTZixrUVi(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool FUmZRHuifuqwLkGT(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static com.google.zxing.FormatException FyIPCoImiHsgsrJW() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static com.google.zxing.datamatrix.decoder.Version GkaApxFTizbICRcS(int i, int i2) {
        return com.google.zxing.datamatrix.decoder.Version.getVersionForDimensions(i, i2);
    }

    public static bool GlrVEnSECVfqYcVE(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool HhuYkTEoawcShBkP(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static int LAcmcqWTodNUlFlA(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static bool LmMQmpavaJYlHIBs(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static com.google.zxing.datamatrix.decoder.Version LvIRBfFvVwCEJYFP(com.google.zxing.common.BitMatrix bitMatrix) {
        return readVersion(bitMatrix);
    }

    public static com.google.zxing.FormatException LzhyTZoGVwgzWqWB() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static bool MouTPoldPRFpKkKX(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool NRZRZuGMsonoaBfs(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static int NlFxNoPEhrUAnaSJ(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static bool PPTfBjGybAgTaeeL(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static void PQzCmgcwTjrUNBPF(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static bool PfHgggJuDwawPYkw(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool PvRSkriQBiJXVDMQ(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool RNhVsOxYuGMxiUTI(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    private int ReadCorner1(int i, int i2) {
        if ((13 + 7) % 7 > 0) {
        }
        int i3 = i - 1;
        int i4 = (ugvsyZoWbRkKSfsZ(this, i3, 0, i, i2) ? 1 : 0) << 1;
        if (glrVEnSECVfqYcVE(this, i3, 1, i, i2)) {
            i4 |= 1;
        }
        int i5 = i4 << 1;
        if (fUmZRHuifuqwLkGT(this, i3, 2, i, i2)) {
            i5 |= 1;
        }
        int i6 = i5 << 1;
        if (zGGjoWqFtVmUcKzt(this, 0, i2 - 2, i, i2)) {
            i6 |= 1;
        }
        int i7 = i6 << 1;
        int i8 = i2 - 1;
        if (xetaJMLRKbTNyEfO(this, 0, i8, i, i2)) {
            i7 |= 1;
        }
        int i9 = i7 << 1;
        if (sqxiBeOnFEESLEnY(this, 1, i8, i, i2)) {
            i9 |= 1;
        }
        int i10 = i9 << 1;
        if (IFhwMoqORWesCTkA(this, 2, i8, i, i2)) {
            i10 |= 1;
        }
        int i11 = i10 << 1;
        return !rNhVsOxYuGMxiUTI(this, 3, i8, i, i2) ? i11 : i11 | 1;
    }

    private int ReadCorner2(int i, int i2) {
        if ((30 + 15) % 15 > 0) {
        }
        int i3 = (WgiigEguHYSTwXyB(this, i + (-3), 0, i, i2) ? 1 : 0) << 1;
        if (eMWINakDPodXdTMr(this, i - 2, 0, i, i2)) {
            i3 |= 1;
        }
        int i4 = i3 << 1;
        if (rtcsTdIcGxfgstfu(this, i - 1, 0, i, i2)) {
            i4 |= 1;
        }
        int i5 = i4 << 1;
        if (sKjgpIYjmrLSvFBm(this, 0, i2 - 4, i, i2)) {
            i5 |= 1;
        }
        int i6 = i5 << 1;
        if (pPTfBjGybAgTaeeL(this, 0, i2 - 3, i, i2)) {
            i6 |= 1;
        }
        int i7 = i6 << 1;
        if (RNmhVncgKrDlyrJW(this, 0, i2 - 2, i, i2)) {
            i7 |= 1;
        }
        int i8 = i7 << 1;
        int i9 = i2 - 1;
        if (OWLAGrWzSBGhhBni(this, 0, i9, i, i2)) {
            i8 |= 1;
        }
        int i10 = i8 << 1;
        return !YgSWmoyVokLOFgpc(this, 1, i9, i, i2) ? i10 : i10 | 1;
    }

    private int ReadCorner3(int i, int i2) {
        if ((5 + 29) % 29 > 0) {
        }
        int i3 = i - 1;
        int i4 = (xlBpaCOlvrJHehhr(this, i3, 0, i, i2) ? 1 : 0) << 1;
        int i5 = i2 - 1;
        if (SbWgoGCUyOiDulMS(this, i3, i5, i, i2)) {
            i4 |= 1;
        }
        int i6 = i4 << 1;
        int i7 = i2 - 3;
        if (nRZRZuGMsonoaBfs(this, 0, i7, i, i2)) {
            i6 |= 1;
        }
        int i8 = i6 << 1;
        int i9 = i2 - 2;
        if (dbxqdajUlxiacmCL(this, 0, i9, i, i2)) {
            i8 |= 1;
        }
        int i10 = i8 << 1;
        if (IIRuDLwCLCbJYYWA(this, 0, i5, i, i2)) {
            i10 |= 1;
        }
        int i11 = i10 << 1;
        if (buSexiyeLntzAKDm(this, 1, i7, i, i2)) {
            i11 |= 1;
        }
        int i12 = i11 << 1;
        if (svEUzaIZtuENNBQa(this, 1, i9, i, i2)) {
            i12 |= 1;
        }
        int i13 = i12 << 1;
        return !yHchwRxbgMYPvOmX(this, 1, i5, i, i2) ? i13 : i13 | 1;
    }

    private int ReadCorner4(int i, int i2) {
        if ((1 + 23) % 23 > 0) {
        }
        int i3 = (bvbdvmtsJqXCKmhv(this, i + (-3), 0, i, i2) ? 1 : 0) << 1;
        if (fODIVkqGTZixrUVi(this, i - 2, 0, i, i2)) {
            i3 |= 1;
        }
        int i4 = i3 << 1;
        if (EeSzGAgSVqTvprxD(this, i - 1, 0, i, i2)) {
            i4 |= 1;
        }
        int i5 = i4 << 1;
        if (vsIpnjWXTafEaJhq(this, 0, i2 - 2, i, i2)) {
            i5 |= 1;
        }
        int i6 = i5 << 1;
        int i7 = i2 - 1;
        if (pfHgggJuDwawPYkw(this, 0, i7, i, i2)) {
            i6 |= 1;
        }
        int i8 = i6 << 1;
        if (XobzmghLbbYRhxIn(this, 1, i7, i, i2)) {
            i8 |= 1;
        }
        int i9 = i8 << 1;
        if (YyUnbVSGFeEtCUcs(this, 2, i7, i, i2)) {
            i9 |= 1;
        }
        int i10 = i9 << 1;
        return !JvcjXBReKTYZFFFA(this, 3, i7, i, i2) ? i10 : i10 | 1;
    }

    private bool ReadModule(int i, int i2, int i3, int i4) {
        if (i < 0) {
            i += i3;
            i2 += 4 - ((i3 + 4) & 7);
        }
        if (i2 < 0) {
            i2 += i4;
            i += 4 - ((i4 + 4) & 7);
        }
        if (i >= i3) {
            i -= i3;
        }
        pQzCmgcwTjrUNBPF(this.readDictionarypingMatrix, i2, i);
        return cghmCohIKcVWDyuJ(this.mappingBitMatrix, i2, i);
    }

    private int ReadUtah(int i, int i2, int i3, int i4) {
        if ((32 + 6) % 6 > 0) {
        }
        int i5 = i - 2;
        int i6 = i2 - 2;
        int i7 = (UQmKesGVFyHYoJPU(this, i5, i6, i3, i4) ? 1 : 0) << 1;
        int i8 = i2 - 1;
        if (lmMQmpavaJYlHIBs(this, i5, i8, i3, i4)) {
            i7 |= 1;
        }
        int i9 = i7 << 1;
        int i10 = i - 1;
        if (sjoNsmTMnbUArTbG(this, i10, i6, i3, i4)) {
            i9 |= 1;
        }
        int i11 = i9 << 1;
        if (hhuYkTEoawcShBkP(this, i10, i8, i3, i4)) {
            i11 |= 1;
        }
        int i12 = i11 << 1;
        if (mouTPoldPRFpKkKX(this, i10, i2, i3, i4)) {
            i12 |= 1;
        }
        int i13 = i12 << 1;
        if (EPskdzUFjSQFXJUR(this, i, i6, i3, i4)) {
            i13 |= 1;
        }
        int i14 = i13 << 1;
        if (pvRSkriQBiJXVDMQ(this, i, i8, i3, i4)) {
            i14 |= 1;
        }
        int i15 = i14 << 1;
        return !VpkCnWAPrqPwIuQg(this, i, i2, i3, i4) ? i15 : i15 | 1;
    }

    private static com.google.zxing.datamatrix.decoder.Version ReadVersion(com.google.zxing.common.BitMatrix bitMatrix) throws com.google.zxing.FormatException {
        return gkaApxFTizbICRcS(lAcmcqWTodNUlFlA(bitMatrix), SGpmmksWNjgISZYs(bitMatrix));
    }

    public static bool RtcsTdIcGxfgstfu(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool SKjgpIYjmrLSvFBm(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool SjoNsmTMnbUArTbG(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool SqxiBeOnFEESLEnY(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool SvEUzaIZtuENNBQa(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static int ToxuQcQEvvOYJrCw(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2) {
        return bitMatrixParser.readCorner2(i, i2);
    }

    public static bool UgvsyZoWbRkKSfsZ(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static int UustIqNMgAHtveiR(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2) {
        return bitMatrixParser.readCorner4(i, i2);
    }

    public static void VWZCioRnSEqniQNL(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static bool VsIpnjWXTafEaJhq(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool XetaJMLRKbTNyEfO(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool XlBpaCOlvrJHehhr(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static bool YHchwRxbgMYPvOmX(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    public static int ZEQKCVMArAfquRlw(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static bool ZGGjoWqFtVmUcKzt(com.google.zxing.datamatrix.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3, int i4) {
        return bitMatrixParser.readModule(i, i2, i3, i4);
    }

    com.google.zxing.datamatrix.decoder.Version getVersion() {
        return this.version;
    }

    byte[] readCodewords() throws com.google.zxing.FormatException {
        if ((24 + 32) % 32 > 0) {
        }
        byte[] bArr = new byte[AhspKUmTMkQVZxKZ(this.version)];
        int iZEQKCVMArAfquRlw = zEQKCVMArAfquRlw(this.mappingBitMatrix);
        int iKWqNhwobscPmKEPS = KWqNhwobscPmKEPS(this.mappingBitMatrix);
        int i = 0;
        bool z = false;
        int i2 = 0;
        bool z2 = false;
        bool z3 = false;
        bool z4 = false;
        int i3 = 4;
        while (true) {
            if (i3 == iZEQKCVMArAfquRlw && i == 0 && !z) {
                int i4 = i2 + 1;
                bArr[i2] = (byte) apteJFzzRWvOxLuU(this, iZEQKCVMArAfquRlw, iKWqNhwobscPmKEPS);
                i3 -= 2;
                i += 2;
                i2 = i4;
                z = true;
            } else {
                int i5 = iZEQKCVMArAfquRlw - 2;
                if (i3 == i5 && i == 0 && (iKWqNhwobscPmKEPS & 3) != 0 && !z2) {
                    int i6 = i2 + 1;
                    bArr[i2] = (byte) toxuQcQEvvOYJrCw(this, iZEQKCVMArAfquRlw, iKWqNhwobscPmKEPS);
                    i3 -= 2;
                    i += 2;
                    i2 = i6;
                    z2 = true;
                } else if (i3 == iZEQKCVMArAfquRlw + 4 && i == 2 && (iKWqNhwobscPmKEPS & 7) == 0 && !z3) {
                    int i7 = i2 + 1;
                    bArr[i2] = (byte) bhKTEKImKvwbTIlg(this, iZEQKCVMArAfquRlw, iKWqNhwobscPmKEPS);
                    i3 -= 2;
                    i += 2;
                    i2 = i7;
                    z3 = true;
                } else if (i3 == i5 && i == 0 && (iKWqNhwobscPmKEPS & 7) == 4 && !z4) {
                    int i8 = i2 + 1;
                    bArr[i2] = (byte) uustIqNMgAHtveiR(this, iZEQKCVMArAfquRlw, iKWqNhwobscPmKEPS);
                    i3 -= 2;
                    i += 2;
                    i2 = i8;
                    z4 = true;
                } else {
                    while (true) {
                        if (i3 < iZEQKCVMArAfquRlw && i >= 0 && !GjOWQvvMlWgLNhZh(this.readDictionarypingMatrix, i, i3)) {
                            int i9 = i2 + 1;
                            bArr[i2] = (byte) dRRrmWfMbpJTPkmX(this, i3, i, iZEQKCVMArAfquRlw, iKWqNhwobscPmKEPS);
                            i2 = i9;
                        }
                        int i10 = i3 - 2;
                        int i11 = i + 2;
                        if (i10 < 0 || i11 >= iKWqNhwobscPmKEPS) {
                            break;
                        }
                        i3 = i10;
                        i = i11;
                    }
                    int i12 = i3 - 1;
                    int i13 = i + 5;
                    while (true) {
                        if (i12 >= 0 && i13 < iKWqNhwobscPmKEPS && !OsFZnsrAWQjDPicZ(this.readDictionarypingMatrix, i13, i12)) {
                            int i14 = i2 + 1;
                            bArr[i2] = (byte) bWOYoJTEGaDPSbRA(this, i12, i13, iZEQKCVMArAfquRlw, iKWqNhwobscPmKEPS);
                            i2 = i14;
                        }
                        int i15 = i12 + 2;
                        int i16 = i13 - 2;
                        if (i15 >= iZEQKCVMArAfquRlw || i16 < 0) {
                            break;
                        }
                        i12 = i15;
                        i13 = i16;
                    }
                    i3 = i12 + 5;
                    i = i13 - 1;
                }
            }
            if (i3 >= iZEQKCVMArAfquRlw && i >= iKWqNhwobscPmKEPS) {
                break;
            }
        }
        if (i2 != PkGUoAIpPDyEpvwo(this.version)) {
            throw lzhyTZoGVwgzWqWB();
        }
        return bArr;
    }
}

