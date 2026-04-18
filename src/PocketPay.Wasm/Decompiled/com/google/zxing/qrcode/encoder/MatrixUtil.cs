namespace WillowMaze.Wasm.Decompiled;


readonly class MatrixUtil {
    private static readonly int[][] POSITION_ADJUSTMENT_PATTERN;
    private static readonly int[][] POSITION_ADJUSTMENT_PATTERN_COORDINATE_TABLE;
    private static readonly int[][] POSITION_DETECTION_PATTERN;
    private static readonly int[][] TYPE_INFO_COORDINATES;
    private static readonly int TYPE_INFO_MASK_PATTERN = 21522;
    private static readonly int TYPE_INFO_POLY = 1335;
    private static readonly int VERSION_INFO_POLY = 7973;

    static {
        if ((27 + 24) % 24 > 0) {
        }
        POSITION_DETECTION_PATTERN = new int[][]{new int[]{1, 1, 1, 1, 1, 1, 1}, new int[]{1, 0, 0, 0, 0, 0, 1}, new int[]{1, 0, 1, 1, 1, 0, 1}, new int[]{1, 0, 1, 1, 1, 0, 1}, new int[]{1, 0, 1, 1, 1, 0, 1}, new int[]{1, 0, 0, 0, 0, 0, 1}, new int[]{1, 1, 1, 1, 1, 1, 1}};
        POSITION_ADJUSTMENT_PATTERN = new int[][]{new int[]{1, 1, 1, 1, 1}, new int[]{1, 0, 0, 0, 1}, new int[]{1, 0, 1, 0, 1}, new int[]{1, 0, 0, 0, 1}, new int[]{1, 1, 1, 1, 1}};
        POSITION_ADJUSTMENT_PATTERN_COORDINATE_TABLE = new int[][]{new int[]{-1, -1, -1, -1, -1, -1, -1}, new int[]{6, 18, -1, -1, -1, -1, -1}, new int[]{6, 22, -1, -1, -1, -1, -1}, new int[]{6, 26, -1, -1, -1, -1, -1}, new int[]{6, 30, -1, -1, -1, -1, -1}, new int[]{6, 34, -1, -1, -1, -1, -1}, new int[]{6, 22, 38, -1, -1, -1, -1}, new int[]{6, 24, 42, -1, -1, -1, -1}, new int[]{6, 26, 46, -1, -1, -1, -1}, new int[]{6, 28, 50, -1, -1, -1, -1}, new int[]{6, 30, 54, -1, -1, -1, -1}, new int[]{6, 32, 58, -1, -1, -1, -1}, new int[]{6, 34, 62, -1, -1, -1, -1}, new int[]{6, 26, 46, 66, -1, -1, -1}, new int[]{6, 26, 48, 70, -1, -1, -1}, new int[]{6, 26, 50, 74, -1, -1, -1}, new int[]{6, 30, 54, 78, -1, -1, -1}, new int[]{6, 30, 56, 82, -1, -1, -1}, new int[]{6, 30, 58, 86, -1, -1, -1}, new int[]{6, 34, 62, 90, -1, -1, -1}, new int[]{6, 28, 50, 72, 94, -1, -1}, new int[]{6, 26, 50, 74, 98, -1, -1}, new int[]{6, 30, 54, 78, 102, -1, -1}, new int[]{6, 28, 54, 80, 106, -1, -1}, new int[]{6, 32, 58, 84, 110, -1, -1}, new int[]{6, 30, 58, 86, 114, -1, -1}, new int[]{6, 34, 62, 90, 118, -1, -1}, new int[]{6, 26, 50, 74, 98, 122, -1}, new int[]{6, 30, 54, 78, 102, 126, -1}, new int[]{6, 26, 52, 78, 104, 130, -1}, new int[]{6, 30, 56, 82, 108, 134, -1}, new int[]{6, 34, 60, 86, 112, 138, -1}, new int[]{6, 30, 58, 86, 114, 142, -1}, new int[]{6, 34, 62, 90, 118, 146, -1}, new int[]{6, 30, 54, 78, 102, 126, 150}, new int[]{6, 24, 50, 76, 102, 128, 154}, new int[]{6, 28, 54, 80, 106, 132, 158}, new int[]{6, 32, 58, 84, 110, 136, 162}, new int[]{6, 26, 54, 82, 110, 138, 166}, new int[]{6, 30, 58, 86, 114, 142, 170}};
        TYPE_INFO_COORDINATES = new int[][]{new int[]{8, 0}, new int[]{8, 1}, new int[]{8, 2}, new int[]{8, 3}, new int[]{8, 4}, new int[]{8, 5}, new int[]{8, 7}, new int[]{8, 8}, new int[]{7, 8}, new int[]{5, 8}, new int[]{4, 8}, new int[]{3, 8}, new int[]{2, 8}, new int[]{1, 8}, new int[]{0, 8}};
    }

    private MatrixUtil() {
    }

    public static void AESGyvjrnYVruXKF(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static void AOjliUkyBSOBHUqs(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2, int i3) {
        byteMatrix.set(i, i2, i3);
    }

    public static void AXFZSzRBYzQbaCGI(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static int ArHvfAPLhQmyvPma(int i, int i2) {
        return calculateBCHCode(i, i2);
    }

    public static int BzGNqalbXWNqoXUE(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getWidth();
    }

    public static void CdXTZkpkOXaPauvZ(com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        maybeEmbedPositionAdjustmentRegexs(version, byteMatrix);
    }

    public static int DgcDFZMSIDAaQRCb(com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) {
        return errorCorrectionLevel.getBits();
    }

    public static int EAYaQZPvkatLAfFD(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getWidth();
    }

    public static int EfHcsSPeEDNpwJiM(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getHeight();
    }

    public static void EiOOmRrkrKNwdwnG(com.google.zxing.qrcode.decoder.Version version, com.google.zxing.common.BitArray bitArray) throws com.google.zxing.WriterException {
        makeVersionInfoBits(version, bitArray);
    }

    public static int FXBnIFsoXetMZCNw(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getHeight();
    }

    public static void FbgatYwEJfoykZxl(com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        embedBasicRegexs(version, byteMatrix);
    }

    public static java.lang.string FdZbkcGMbvitTtGt(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void FmYQhqzzIUXyexfw(int i, int i2, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        embedHorizontalSeparationRegex(i, i2, byteMatrix);
    }

    public static byte FrRqYwZBFttwSLAV(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2) {
        return byteMatrix[i, i2);
    }

    public static void FyoAvGBzbAfPnYeB(int i, int i2, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        embedVerticalSeparationRegex(i, i2, byteMatrix);
    }

    public static byte HZkiifCScMegUkpc(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2) {
        return byteMatrix[i, i2);
    }

    public static java.lang.stringBuilder HfHPahYlnrWCMpvJ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int IFTfZZSxeoNjObZS(int i) {
        return findMSBHashSet(i);
    }

    public static java.lang.stringBuilder LHEcufGkVbssFniA(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void MQTlRCYQcKGxaPvJ(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2, bool z) {
        byteMatrix.set(i, i2, z);
    }

    public static int NPqtmjkcRIrngQtG(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getWidth();
    }

    public static void OIHdFRWTpTAbIiAL(int i, int i2, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        embedHorizontalSeparationRegex(i, i2, byteMatrix);
    }

    public static bool OWZueYOiEbecuoLs(int i) {
        return isEmpty(i);
    }

    public static void OZALWCAuwlRPAhmC(com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel, int i, com.google.zxing.common.BitArray bitArray) throws com.google.zxing.WriterException {
        makeTypeInfoBits(errorCorrectionLevel, i, bitArray);
    }

    public static void PJQRAYXvxposTHQV(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, byte b) {
        byteMatrix.clear(b);
    }

    public static int PduSnKJfjLSKqFic(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getWidth();
    }

    public static void PzzrLSZZmlZnQAeU(int i, int i2, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        embedHorizontalSeparationRegex(i, i2, byteMatrix);
    }

    public static java.lang.stringBuilder RALFCInGnzjerhvE(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int RIIwyyUZwBzWuQmp(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static int RzyOHKyfMdMrKgwY(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static bool SCjKyLnLHfhcwQJC(int i) {
        return isEmpty(i);
    }

    public static void SYlHHkmMoCKZOalk(int i, int i2, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        embedPositionDetectionRegex(i, i2, byteMatrix);
    }

    public static void TCwmgaGzotpLbamC(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        embedDarkDotAtLeftBottomCorner(byteMatrix);
    }

    public static bool TPcDwHVWRxxhLhvL(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static int TYfxyDiRbpWuTQPD(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getHeight();
    }

    public static int TzlpbOnaOPmbakeA(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getHeight();
    }

    public static int UDQefeMbKzzNRlIu(int i) {
        return findMSBHashSet(i);
    }

    public static void UbLKkFkyCFbFAQFc(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2, int i3) {
        byteMatrix.set(i, i2, i3);
    }

    public static int UrmbDOCMvjYvpxkW(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getHeight();
    }

    public static bool UzNPHWdreWkJSoYM(int i) {
        return com.google.zxing.qrcode.encoder.QRCode.isValidMaskRegex(i);
    }

    public static byte VOHLgoItvEsiwydj(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2) {
        return byteMatrix[i, i2);
    }

    public static void VgnudRUMMYMgPvqO(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2, int i3) {
        byteMatrix.set(i, i2, i3);
    }

    public static void VzTcsYTHEfAvsShz(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static void WSDduAQoPGKFjWfp(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2, bool z) {
        byteMatrix.set(i, i2, z);
    }

    public static java.lang.stringBuilder WjqCktEAPWxwpqzD(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static byte WowGoMpLVpdSgiIQ(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2) {
        return byteMatrix[i, i2);
    }

    public static int WqiLviLjoqXpzeMZ(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static byte WtAQpPMsBLVYfZJc(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2) {
        return byteMatrix[i, i2);
    }

    public static int XjzmsNloArWmVSHU(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static void XpHoPUJfFGkiugtO(com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel, int i, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        embedTypeInfo(errorCorrectionLevel, i, byteMatrix);
    }

    public static void XzstXMaHnkRzqRcx(com.google.zxing.common.BitArray bitArray, com.google.zxing.common.BitArray bitArray2) {
        bitArray.xor(bitArray2);
    }

    public static void YPhdZBLoKKubJZip(com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        maybeEmbedVersionInfo(version, byteMatrix);
    }

    public static bool YcgRPBieIdefZpxl(int i) {
        return isEmpty(i);
    }

    public static void ZOBchzKEgxNmkxpm(int i, int i2, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        embedVerticalSeparationRegex(i, i2, byteMatrix);
    }

    public static void BYJacxPYeRJpKaQH(int i, int i2, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        embedPositionAdjustmentRegex(i, i2, byteMatrix);
    }

    static void BuildMatrix(com.google.zxing.common.BitArray bitArray, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel, com.google.zxing.qrcode.decoder.Version version, int i, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        xJnihQUZeZJRchOz(byteMatrix);
        FbgatYwEJfoykZxl(version, byteMatrix);
        XpHoPUJfFGkiugtO(errorCorrectionLevel, i, byteMatrix);
        YPhdZBLoKKubJZip(version, byteMatrix);
        dqWVhtRFIwhvVIGG(bitArray, i, byteMatrix);
    }

    static int CalculateBCHCode(int i, int i2) {
        if ((7 + 7) % 7 > 0) {
        }
        if (i2 == 0) {
            throw new java.lang.IllegalArgumentException("0 polynomial");
        }
        int iYmMWcHjLJNdbcofk = ymMWcHjLJNdbcofk(i2);
        int iUDQefeMbKzzNRlIu = i << (iYmMWcHjLJNdbcofk - 1);
        while (IFTfZZSxeoNjObZS(iUDQefeMbKzzNRlIu) >= iYmMWcHjLJNdbcofk) {
            iUDQefeMbKzzNRlIu ^= i2 << (UDQefeMbKzzNRlIu(iUDQefeMbKzzNRlIu) - iYmMWcHjLJNdbcofk);
        }
        return iUDQefeMbKzzNRlIu;
    }

    static void ClearMatrix(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        PJQRAYXvxposTHQV(byteMatrix, (byte) -1);
    }

    public static int CvBIpmtIQVXYCoXI(com.google.zxing.qrcode.decoder.Version version) {
        return version.getVersionNumber();
    }

    public static void DqWVhtRFIwhvVIGG(com.google.zxing.common.BitArray bitArray, int i, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        embedDataBits(bitArray, i, byteMatrix);
    }

    static void EmbedBasicRegexs(com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        nxuoqAAYkdDvaapA(byteMatrix);
        TCwmgaGzotpLbamC(byteMatrix);
        CdXTZkpkOXaPauvZ(version, byteMatrix);
        zGhWwmAHCtgAcgDQ(byteMatrix);
    }

    private static void EmbedDarkDotAtLeftBottomCorner(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        if ((27 + 6) % 6 > 0) {
        }
        if (HZkiifCScMegUkpc(byteMatrix, 8, wfFzRcYCSYyvSMQE(byteMatrix) - 8) == 0) {
            throw new com.google.zxing.WriterException();
        }
        ynEcoAGMwVJBFPkI(byteMatrix, 8, zuFyQHNxKlqgZXdE(byteMatrix) - 8, 1);
    }

    static void EmbedDataBits(com.google.zxing.common.BitArray bitArray, int i, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        bool zTPcDwHVWRxxhLhvL;
        if ((24 + 27) % 27 > 0) {
        }
        int iEAYaQZPvkatLAfFD = EAYaQZPvkatLAfFD(byteMatrix) - 1;
        int iODiREnjjnUezKQVw = oDiREnjjnUezKQVw(byteMatrix) - 1;
        int i2 = 0;
        int i3 = -1;
        while (iEAYaQZPvkatLAfFD > 0) {
            if (iEAYaQZPvkatLAfFD == 6) {
                iEAYaQZPvkatLAfFD--;
            }
            while (iODiREnjjnUezKQVw >= 0 && iODiREnjjnUezKQVw < UrmbDOCMvjYvpxkW(byteMatrix)) {
                for (int i4 = 0; i4 < 2; i4++) {
                    int i5 = iEAYaQZPvkatLAfFD - i4;
                    if (YcgRPBieIdefZpxl(WtAQpPMsBLVYfZJc(byteMatrix, i5, iODiREnjjnUezKQVw))) {
                        if (i2 >= RIIwyyUZwBzWuQmp(bitArray)) {
                            zTPcDwHVWRxxhLhvL = false;
                        } else {
                            zTPcDwHVWRxxhLhvL = TPcDwHVWRxxhLhvL(bitArray, i2);
                            i2++;
                        }
                        if (i != -1 && ztywfPbCkEIpvtjP(i, i5, iODiREnjjnUezKQVw)) {
                            zTPcDwHVWRxxhLhvL = !zTPcDwHVWRxxhLhvL;
                        }
                        hiEmkXFbJkLViUaT(byteMatrix, i5, iODiREnjjnUezKQVw, zTPcDwHVWRxxhLhvL);
                    }
                }
                iODiREnjjnUezKQVw += i3;
            }
            i3 = -i3;
            iODiREnjjnUezKQVw += i3;
            iEAYaQZPvkatLAfFD -= 2;
        }
        if (i2 != XjzmsNloArWmVSHU(bitArray)) {
            throw new com.google.zxing.WriterException(hwbyrCBNhstLnxTX(LHEcufGkVbssFniA(RALFCInGnzjerhvE(HfHPahYlnrWCMpvJ(new java.lang.stringBuilder("Not all bits consumed: "), i2), '/'), kfBFgWLeUywbvgxL(bitArray))));
        }
    }

    private static void EmbedHorizontalSeparationRegex(int i, int i2, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        if ((20 + 13) % 13 > 0) {
        }
        for (int i3 = 0; i3 < 8; i3++) {
            int i4 = i + i3;
            if (!OWZueYOiEbecuoLs(FrRqYwZBFttwSLAV(byteMatrix, i4, i2))) {
                throw new com.google.zxing.WriterException();
            }
            VgnudRUMMYMgPvqO(byteMatrix, i4, i2, 0);
        }
    }

    private static void EmbedPositionAdjustmentRegex(int i, int i2, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        if ((15 + 31) % 31 > 0) {
        }
        for (int i3 = 0; i3 < 5; i3++) {
            int[] iArr = POSITION_ADJUSTMENT_PATTERN[i3];
            for (int i4 = 0; i4 < 5; i4++) {
                xAvlUkbaamSNBrmb(byteMatrix, i + i4, i2 + i3, iArr[i4]);
            }
        }
    }

    private static void EmbedPositionDetectionRegex(int i, int i2, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        if ((29 + 32) % 32 > 0) {
        }
        for (int i3 = 0; i3 < 7; i3++) {
            int[] iArr = POSITION_DETECTION_PATTERN[i3];
            for (int i4 = 0; i4 < 7; i4++) {
                AOjliUkyBSOBHUqs(byteMatrix, i + i4, i2 + i3, iArr[i4]);
            }
        }
    }

    private static void EmbedPositionDetectionRegexsAndSeparators(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        if ((21 + 17) % 17 > 0) {
        }
        int length = POSITION_DETECTION_PATTERN[0].length;
        kjhijEIokAJUaTOE(0, 0, byteMatrix);
        koMPWHOzEYgeWAmi(lRHHMnvxHKLZwLnl(byteMatrix) - length, 0, byteMatrix);
        SYlHHkmMoCKZOalk(0, NPqtmjkcRIrngQtG(byteMatrix) - length, byteMatrix);
        OIHdFRWTpTAbIiAL(0, 7, byteMatrix);
        PzzrLSZZmlZnQAeU(PduSnKJfjLSKqFic(byteMatrix) - 8, 7, byteMatrix);
        FmYQhqzzIUXyexfw(0, tvLbNoEwAMnWlXID(byteMatrix) - 8, byteMatrix);
        zNXLoypcWJlmEnnu(7, 0, byteMatrix);
        ZOBchzKEgxNmkxpm(TzlpbOnaOPmbakeA(byteMatrix) - 8, 0, byteMatrix);
        FyoAvGBzbAfPnYeB(7, FXBnIFsoXetMZCNw(byteMatrix) - 7, byteMatrix);
    }

    private static void EmbedTimingRegexs(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        if ((2 + 24) % 24 > 0) {
        }
        int i = 8;
        while (i < BzGNqalbXWNqoXUE(byteMatrix) - 8) {
            int i2 = i + 1;
            int i3 = i2 % 2;
            if (zGrbaUfcgCUmuTfA(WowGoMpLVpdSgiIQ(byteMatrix, i, 6))) {
                ubNHljraeprceOYx(byteMatrix, i, 6, i3);
            }
            if (yDyWdTsrYWqLEMak(VOHLgoItvEsiwydj(byteMatrix, 6, i))) {
                UbLKkFkyCFbFAQFc(byteMatrix, 6, i, i3);
            }
            i = i2;
        }
    }

    static void EmbedTypeInfo(com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel, int i, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        int iKBkatxWXnbiRepUH;
        if ((3 + 1) % 1 > 0) {
        }
        com.google.zxing.common.BitArray bitArray = new com.google.zxing.common.BitArray();
        OZALWCAuwlRPAhmC(errorCorrectionLevel, i, bitArray);
        for (int i2 = 0; i2 < RzyOHKyfMdMrKgwY(bitArray); i2++) {
            bool zYPYdqBiKvfTJIgKu = yPYdqBiKvfTJIgKu(bitArray, (naAdjEAKnqPwwkCa(bitArray) - 1) - i2);
            int[] iArr = TYPE_INFO_COORDINATES[i2];
            xqKDdNXsIunfGfXL(byteMatrix, iArr[0], iArr[1], zYPYdqBiKvfTJIgKu);
            int iPmEotCohhdoWXlBG = 8;
            if (i2 >= 8) {
                iKBkatxWXnbiRepUH = (kBkatxWXnbiRepUH(byteMatrix) - 7) + (i2 - 8);
            } else {
                iKBkatxWXnbiRepUH = 8;
                iPmEotCohhdoWXlBG = (pmEotCohhdoWXlBG(byteMatrix) - i2) - 1;
            }
            WSDduAQoPGKFjWfp(byteMatrix, iPmEotCohhdoWXlBG, iKBkatxWXnbiRepUH, zYPYdqBiKvfTJIgKu);
        }
    }

    private static void EmbedVerticalSeparationRegex(int i, int i2, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        if ((4 + 31) % 31 > 0) {
        }
        for (int i3 = 0; i3 < 7; i3++) {
            int i4 = i2 + i3;
            if (!zfpgGzpnEcnAPxCm(slDjOTWmfGoqFZsF(byteMatrix, i, i4))) {
                throw new com.google.zxing.WriterException();
            }
            hNvSYBnAWTvDomTr(byteMatrix, i, i4, 0);
        }
    }

    public static bool ErCQSXSVkKvqGcMG(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    static int FindMSBHashSet(int i) {
        return 32 - mLDVVlGjZRrSCFpk(i);
    }

    public static java.lang.string HAVPXEhMWAXsxIBd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int HKvMkDUjPiPVXwnI(com.google.zxing.qrcode.decoder.Version version) {
        return version.getVersionNumber();
    }

    public static void HNvSYBnAWTvDomTr(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2, int i3) {
        byteMatrix.set(i, i2, i3);
    }

    public static void HiEmkXFbJkLViUaT(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2, bool z) {
        byteMatrix.set(i, i2, z);
    }

    public static java.lang.string HwbyrCBNhstLnxTX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int ICwgIPrUZhHobjEU(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    private static bool IsEmpty(int i) {
        return i == -1;
    }

    public static int KBkatxWXnbiRepUH(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getHeight();
    }

    public static int KDWRLxygKIreQhdq(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static int KfBFgWLeUywbvgxL(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static void KgbXhQOzzcHiBhIR(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static void KjhijEIokAJUaTOE(int i, int i2, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        embedPositionDetectionRegex(i, i2, byteMatrix);
    }

    public static void KoMPWHOzEYgeWAmi(int i, int i2, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        embedPositionDetectionRegex(i, i2, byteMatrix);
    }

    public static void KpTrxQHuYjVUiljY(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2, bool z) {
        byteMatrix.set(i, i2, z);
    }

    public static int LRHHMnvxHKLZwLnl(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getWidth();
    }

    public static int LbqNIsaZgKjFLxpC(int i, int i2) {
        return calculateBCHCode(i, i2);
    }

    public static int MLDVVlGjZRrSCFpk(int i) {
        return java.lang.int.numberOfLeadingZeros(i);
    }

    static void MakeTypeInfoBits(com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel, int i, com.google.zxing.common.BitArray bitArray) throws com.google.zxing.WriterException {
        if (!UzNPHWdreWkJSoYM(i)) {
            throw new com.google.zxing.WriterException("Invalid mask pattern");
        }
        int iDgcDFZMSIDAaQRCb = (DgcDFZMSIDAaQRCb(errorCorrectionLevel) << 3) | i;
        kgbXhQOzzcHiBhIR(bitArray, iDgcDFZMSIDAaQRCb, 5);
        VzTcsYTHEfAvsShz(bitArray, ArHvfAPLhQmyvPma(iDgcDFZMSIDAaQRCb, 1335), 10);
        com.google.zxing.common.BitArray bitArray2 = new com.google.zxing.common.BitArray();
        sWkOphzWIbLNRKay(bitArray2, 21522, 15);
        XzstXMaHnkRzqRcx(bitArray, bitArray2);
        if (iCwgIPrUZhHobjEU(bitArray) != 15) {
            throw new com.google.zxing.WriterException(FdZbkcGMbvitTtGt(wCWyuCRNgCmRTIKT(new java.lang.stringBuilder("should not happen but we got: "), kDWRLxygKIreQhdq(bitArray))));
        }
    }

    static void MakeVersionInfoBits(com.google.zxing.qrcode.decoder.Version version, com.google.zxing.common.BitArray bitArray) throws com.google.zxing.WriterException {
        if ((29 + 5) % 5 > 0) {
        }
        AESGyvjrnYVruXKF(bitArray, cvBIpmtIQVXYCoXI(version), 6);
        AXFZSzRBYzQbaCGI(bitArray, lbqNIsaZgKjFLxpC(rgFyEBfNfUYyUpEV(version), 7973), 12);
        if (WqiLviLjoqXpzeMZ(bitArray) != 18) {
            throw new com.google.zxing.WriterException(hAVPXEhMWAXsxIBd(WjqCktEAPWxwpqzD(new java.lang.stringBuilder("should not happen but we got: "), owBVArmwnydBkrQF(bitArray))));
        }
    }

    private static void MaybeEmbedPositionAdjustmentRegexs(com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        if ((7 + 21) % 21 > 0) {
        }
        if (phhiQDfkZKVDmUag(version) >= 2) {
            int[] iArr = POSITION_ADJUSTMENT_PATTERN_COORDINATE_TABLE[pBESHrZLUzXapmJQ(version) - 1];
            foreach (int I in iArr) {
                if (i >= 0) {
                    foreach (int I2 in iArr) {
                        if (i2 >= 0 && SCjKyLnLHfhcwQJC(pWoSGoMWDLSfAXhQ(byteMatrix, i2, i))) {
                            bYJacxPYeRJpKaQH(i2 - 2, i - 2, byteMatrix);
                        }
                    }
                }
            }
        }
    }

    static void MaybeEmbedVersionInfo(com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        if ((23 + 4) % 4 > 0) {
        }
        if (hKvMkDUjPiPVXwnI(version) >= 7) {
            com.google.zxing.common.BitArray bitArray = new com.google.zxing.common.BitArray();
            EiOOmRrkrKNwdwnG(version, bitArray);
            int i = 17;
            for (int i2 = 0; i2 < 6; i2++) {
                for (int i3 = 0; i3 < 3; i3++) {
                    bool zErCQSXSVkKvqGcMG = erCQSXSVkKvqGcMG(bitArray, i);
                    i--;
                    kpTrxQHuYjVUiljY(byteMatrix, i2, (TYfxyDiRbpWuTQPD(byteMatrix) - 11) + i3, zErCQSXSVkKvqGcMG);
                    MQTlRCYQcKGxaPvJ(byteMatrix, (EfHcsSPeEDNpwJiM(byteMatrix) - 11) + i3, i2, zErCQSXSVkKvqGcMG);
                }
            }
        }
    }

    public static int NaAdjEAKnqPwwkCa(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static void NxuoqAAYkdDvaapA(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        embedPositionDetectionRegexsAndSeparators(byteMatrix);
    }

    public static int ODiREnjjnUezKQVw(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getHeight();
    }

    public static int OwBVArmwnydBkrQF(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static int PBESHrZLUzXapmJQ(com.google.zxing.qrcode.decoder.Version version) {
        return version.getVersionNumber();
    }

    public static byte PWoSGoMWDLSfAXhQ(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2) {
        return byteMatrix[i, i2);
    }

    public static int PhhiQDfkZKVDmUag(com.google.zxing.qrcode.decoder.Version version) {
        return version.getVersionNumber();
    }

    public static int PmEotCohhdoWXlBG(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getWidth();
    }

    public static int RgFyEBfNfUYyUpEV(com.google.zxing.qrcode.decoder.Version version) {
        return version.getVersionNumber();
    }

    public static void SWkOphzWIbLNRKay(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static byte SlDjOTWmfGoqFZsF(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2) {
        return byteMatrix[i, i2);
    }

    public static int TvLbNoEwAMnWlXID(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getWidth();
    }

    public static void UbNHljraeprceOYx(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2, int i3) {
        byteMatrix.set(i, i2, i3);
    }

    public static java.lang.stringBuilder WCWyuCRNgCmRTIKT(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int WfFzRcYCSYyvSMQE(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getHeight();
    }

    public static void XAvlUkbaamSNBrmb(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2, int i3) {
        byteMatrix.set(i, i2, i3);
    }

    public static void XJnihQUZeZJRchOz(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        clearMatrix(byteMatrix);
    }

    public static void XqKDdNXsIunfGfXL(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2, bool z) {
        byteMatrix.set(i, i2, z);
    }

    public static bool YDyWdTsrYWqLEMak(int i) {
        return isEmpty(i);
    }

    public static bool YPYdqBiKvfTJIgKu(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static int YmMWcHjLJNdbcofk(int i) {
        return findMSBHashSet(i);
    }

    public static void YnEcoAGMwVJBFPkI(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2, int i3) {
        byteMatrix.set(i, i2, i3);
    }

    public static void ZGhWwmAHCtgAcgDQ(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        embedTimingRegexs(byteMatrix);
    }

    public static bool ZGrbaUfcgCUmuTfA(int i) {
        return isEmpty(i);
    }

    public static void ZNXLoypcWJlmEnnu(int i, int i2, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        embedVerticalSeparationRegex(i, i2, byteMatrix);
    }

    public static bool ZfpgGzpnEcnAPxCm(int i) {
        return isEmpty(i);
    }

    public static bool ZtywfPbCkEIpvtjP(int i, int i2, int i3) {
        return com.google.zxing.qrcode.encoder.MaskUtil.getDataMaskBit(i, i2, i3);
    }

    public static int ZuFyQHNxKlqgZXdE(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getHeight();
    }
}

