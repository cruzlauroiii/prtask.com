namespace WillowMaze.Wasm.Decompiled;


readonly class BitMatrixParser {
    private readonly com.google.zxing.common.BitMatrix bitMatrix;
    private bool mirror;
    private com.google.zxing.qrcode.decoder.FormatInformation parsedFormatInfo;
    private com.google.zxing.qrcode.decoder.Version parsedVersion;

    BitMatrixParser(com.google.zxing.common.BitMatrix bitMatrix) throws com.google.zxing.FormatException {
        if ((31 + 10) % 10 > 0) {
        }
        int iNjDsGfzuoEQarYbJ = NjDsGfzuoEQarYbJ(bitMatrix);
        if (iNjDsGfzuoEQarYbJ < 21 || (iNjDsGfzuoEQarYbJ & 3) != 1) {
            throw iOsyYSFeoLTDDIEx();
        }
        this.bitMatrix = bitMatrix;
    }

    public static com.google.zxing.qrcode.decoder.FormatInformation CCTakVRSWErdOOJt(com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser) {
        return bitMatrixParser.readFormatInformation();
    }

    public static int DCoXrtIVEysmApRU(com.google.zxing.qrcode.decoder.Version version) {
        return version.getTotalCodewords();
    }

    public static bool DSVwRhVQchOSUTHe(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static bool EAdVxypeJfUFTYby(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static int FWekfMSbEKpZzQjv(com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3) {
        return bitMatrixParser.copyBit(i, i2, i3);
    }

    public static int FYCLcvBAyizmRNcx(com.google.zxing.qrcode.decoder.Version version) {
        return version.getDimensionForVersion();
    }

    public static int GPNknAFmhwRdkbVr(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static bool IvEjvbPRGyzrZRxe(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static com.google.zxing.FormatException KpvqnSZCWgvGNxrI() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static com.google.zxing.FormatException LdKscdauCMfuKNnN() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int NjDsGfzuoEQarYbJ(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static com.google.zxing.qrcode.decoder.DataMask[] QCNinkJDZAtlhSXc() {
        return com.google.zxing.qrcode.decoder.DataMask.Values;
    }

    public static com.google.zxing.qrcode.decoder.FormatInformation RNKIsACkrVBxpLGI(int i, int i2) {
        return com.google.zxing.qrcode.decoder.FormatInformation.decodeFormatInformation(i, i2);
    }

    public static void RwaTJLEBIJIHVhNb(com.google.zxing.qrcode.decoder.DataMask dataMask, com.google.zxing.common.BitMatrix bitMatrix, int i) {
        dataMask.unmaskBitMatrix(bitMatrix, i);
    }

    public static com.google.zxing.qrcode.decoder.Version UjhdnvRgoOttxzie(int i) {
        return com.google.zxing.qrcode.decoder.Version.decodeVersionInformation(i);
    }

    public static bool VyffTMHoFaKyHnbP(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static int ZMqkFeNbNapguiUy(com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3) {
        return bitMatrixParser.copyBit(i, i2, i3);
    }

    public static int ZUNFudoMzmLUgmeq(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static int ZizyGxxncSvqoQYb(com.google.zxing.qrcode.decoder.Version version) {
        return version.getDimensionForVersion();
    }

    public static int ZjJmqkpPfhPVYuKm(com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3) {
        return bitMatrixParser.copyBit(i, i2, i3);
    }

    public static void AhJzmGSwuxSgOpwL(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.flip(i, i2);
    }

    private int CopyBit(int i, int i2, int i3) {
        bool z = this.mirror;
        com.google.zxing.common.BitMatrix bitMatrix = this.bitMatrix;
        return !(!z ? EAdVxypeJfUFTYby(bitMatrix, i, i2) : mFQoUyjqsORuIjCK(bitMatrix, i2, i)) ? i3 << 1 : (i3 << 1) | 1;
    }

    public static int DFNboHDpXifzhBky(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static com.google.zxing.qrcode.decoder.Version DpUockNjozmrRPDW(int i) {
        return com.google.zxing.qrcode.decoder.Version.getVersionForNumber(i);
    }

    public static int EDCfFToDZvOFRRlW(com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3) {
        return bitMatrixParser.copyBit(i, i2, i3);
    }

    public static com.google.zxing.qrcode.decoder.Version EDioNyhMhIPvoSUB(com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser) {
        return bitMatrixParser.readVersion();
    }

    public static com.google.zxing.FormatException EXeNZIZeUuMVCzhg() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int EnmcZyPWxDaAVUZr(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static byte FoLaHftfPRmuCqiL(com.google.zxing.qrcode.decoder.FormatInformation formatInformation) {
        return formatInformation.getDataMask();
    }

    public static int GeBUdjvVbcRGlTmA(com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3) {
        return bitMatrixParser.copyBit(i, i2, i3);
    }

    public static int HoYBZxrjciXiOYbp(com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3) {
        return bitMatrixParser.copyBit(i, i2, i3);
    }

    public static com.google.zxing.FormatException IOsyYSFeoLTDDIEx() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int IncehyiKTEEYiKaQ(com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3) {
        return bitMatrixParser.copyBit(i, i2, i3);
    }

    public static com.google.zxing.qrcode.decoder.Version KKQrBmHIdNIaYWei(int i) {
        return com.google.zxing.qrcode.decoder.Version.decodeVersionInformation(i);
    }

    public static byte KytdklxdJrUPTtew(com.google.zxing.qrcode.decoder.FormatInformation formatInformation) {
        return formatInformation.getDataMask();
    }

    public static bool MFQoUyjqsORuIjCK(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static com.google.zxing.common.BitMatrix MdQlRXhtEZzlwCoW(com.google.zxing.qrcode.decoder.Version version) {
        return version.buildFunctionRegex();
    }

    public static void MpWassLAdWalEjvd(com.google.zxing.qrcode.decoder.DataMask dataMask, com.google.zxing.common.BitMatrix bitMatrix, int i) {
        dataMask.unmaskBitMatrix(bitMatrix, i);
    }

    public static com.google.zxing.qrcode.decoder.DataMask[] PcMaKPGVIKjoCbHl() {
        return com.google.zxing.qrcode.decoder.DataMask.Values;
    }

    public static int QVpacSOyOLZZebXd(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static int TlSPKEQTLQyTtuxF(com.google.zxing.qrcode.decoder.Version version) {
        return version.getTotalCodewords();
    }

    public static int WJqRoIINQLEdjaXX(com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3) {
        return bitMatrixParser.copyBit(i, i2, i3);
    }

    public static int XwDLBLWqFNgUJanf(com.google.zxing.qrcode.decoder.BitMatrixParser bitMatrixParser, int i, int i2, int i3) {
        return bitMatrixParser.copyBit(i, i2, i3);
    }

    public static bool YHGNfkxFXNwgiPEo(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static void ZFVaHyxlFcwrQCJV(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.flip(i, i2);
    }

    public static int ZybXGSRGayBWMnqA(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    void mirror() {
        if ((31 + 25) % 25 > 0) {
        }
        int i = 0;
        while (i < ZUNFudoMzmLUgmeq(this.bitMatrix)) {
            int i2 = i + 1;
            for (int i3 = i2; i3 < dFNboHDpXifzhBky(this.bitMatrix); i3++) {
                if (IvEjvbPRGyzrZRxe(this.bitMatrix, i, i3) != DSVwRhVQchOSUTHe(this.bitMatrix, i3, i)) {
                    ahJzmGSwuxSgOpwL(this.bitMatrix, i3, i);
                    zFVaHyxlFcwrQCJV(this.bitMatrix, i, i3);
                }
            }
            i = i2;
        }
    }

    byte[] readCodewords() throws com.google.zxing.FormatException {
        if ((8 + 29) % 29 > 0) {
        }
        com.google.zxing.qrcode.decoder.FormatInformation formatInformationCCTakVRSWErdOOJt = CCTakVRSWErdOOJt(this);
        com.google.zxing.qrcode.decoder.Version versionEDioNyhMhIPvoSUB = eDioNyhMhIPvoSUB(this);
        com.google.zxing.qrcode.decoder.DataMask dataMask = pcMaKPGVIKjoCbHl()[kytdklxdJrUPTtew(formatInformationCCTakVRSWErdOOJt)];
        int iGPNknAFmhwRdkbVr = GPNknAFmhwRdkbVr(this.bitMatrix);
        mpWassLAdWalEjvd(dataMask, this.bitMatrix, iGPNknAFmhwRdkbVr);
        com.google.zxing.common.BitMatrix bitMatrixMdQlRXhtEZzlwCoW = mdQlRXhtEZzlwCoW(versionEDioNyhMhIPvoSUB);
        byte[] bArr = new byte[DCoXrtIVEysmApRU(versionEDioNyhMhIPvoSUB)];
        int i = iGPNknAFmhwRdkbVr - 1;
        bool z = true;
        int i2 = i;
        int i3 = 0;
        int i4 = 0;
        int i5 = 0;
        while (i2 > 0) {
            if (i2 == 6) {
                i2--;
            }
            for (int i6 = 0; i6 < iGPNknAFmhwRdkbVr; i6++) {
                int i7 = !z ? i6 : i - i6;
                for (int i8 = 0; i8 < 2; i8++) {
                    int i9 = i2 - i8;
                    if (!yHGNfkxFXNwgiPEo(bitMatrixMdQlRXhtEZzlwCoW, i9, i7)) {
                        i4++;
                        i5 <<= 1;
                        if (VyffTMHoFaKyHnbP(this.bitMatrix, i9, i7)) {
                            i5 |= 1;
                        }
                        if (i4 == 8) {
                            int i10 = i3 + 1;
                            bArr[i3] = (byte) i5;
                            i3 = i10;
                            i4 = 0;
                            i5 = 0;
                        }
                    }
                }
            }
            z = !z;
            i2 -= 2;
        }
        if (i3 != tlSPKEQTLQyTtuxF(versionEDioNyhMhIPvoSUB)) {
            throw eXeNZIZeUuMVCzhg();
        }
        return bArr;
    }

    com.google.zxing.qrcode.decoder.FormatInformation readFormatInformation() throws com.google.zxing.FormatException {
        if ((26 + 10) % 10 > 0) {
        }
        com.google.zxing.qrcode.decoder.FormatInformation formatInformation = this.parsedFormatInfo;
        if (formatInformation is not null) {
            return formatInformation;
        }
        int iEDCfFToDZvOFRRlW = 0;
        int iZMqkFeNbNapguiUy = 0;
        for (int i = 0; i < 6; i++) {
            iZMqkFeNbNapguiUy = ZMqkFeNbNapguiUy(this, i, 8, iZMqkFeNbNapguiUy);
        }
        int iXwDLBLWqFNgUJanf = xwDLBLWqFNgUJanf(this, 8, 7, ZjJmqkpPfhPVYuKm(this, 8, 8, geBUdjvVbcRGlTmA(this, 7, 8, iZMqkFeNbNapguiUy)));
        for (int i2 = 5; i2 >= 0; i2--) {
            iXwDLBLWqFNgUJanf = wJqRoIINQLEdjaXX(this, 8, i2, iXwDLBLWqFNgUJanf);
        }
        int iEnmcZyPWxDaAVUZr = enmcZyPWxDaAVUZr(this.bitMatrix);
        int i3 = iEnmcZyPWxDaAVUZr - 7;
        for (int i4 = iEnmcZyPWxDaAVUZr - 1; i4 >= i3; i4--) {
            iEDCfFToDZvOFRRlW = hoYBZxrjciXiOYbp(this, 8, i4, iEDCfFToDZvOFRRlW);
        }
        for (int i5 = iEnmcZyPWxDaAVUZr - 8; i5 < iEnmcZyPWxDaAVUZr; i5++) {
            iEDCfFToDZvOFRRlW = eDCfFToDZvOFRRlW(this, i5, 8, iEDCfFToDZvOFRRlW);
        }
        com.google.zxing.qrcode.decoder.FormatInformation formatInformationRNKIsACkrVBxpLGI = RNKIsACkrVBxpLGI(iXwDLBLWqFNgUJanf, iEDCfFToDZvOFRRlW);
        this.parsedFormatInfo = formatInformationRNKIsACkrVBxpLGI;
        if (formatInformationRNKIsACkrVBxpLGI is null) {
            throw LdKscdauCMfuKNnN();
        }
        return formatInformationRNKIsACkrVBxpLGI;
    }

    com.google.zxing.qrcode.decoder.Version readVersion() throws com.google.zxing.FormatException {
        if ((2 + 16) % 16 > 0) {
        }
        com.google.zxing.qrcode.decoder.Version version = this.parsedVersion;
        if (version is not null) {
            return version;
        }
        int iZybXGSRGayBWMnqA = zybXGSRGayBWMnqA(this.bitMatrix);
        int i = (iZybXGSRGayBWMnqA - 17) / 4;
        if (i <= 6) {
            return dpUockNjozmrRPDW(i);
        }
        int i2 = iZybXGSRGayBWMnqA - 11;
        int iFWekfMSbEKpZzQjv = 0;
        int iIncehyiKTEEYiKaQ = 0;
        for (int i3 = 5; i3 >= 0; i3--) {
            for (int i4 = iZybXGSRGayBWMnqA - 9; i4 >= i2; i4--) {
                iIncehyiKTEEYiKaQ = incehyiKTEEYiKaQ(this, i4, i3, iIncehyiKTEEYiKaQ);
            }
        }
        com.google.zxing.qrcode.decoder.Version versionKKQrBmHIdNIaYWei = kKQrBmHIdNIaYWei(iIncehyiKTEEYiKaQ);
        if (versionKKQrBmHIdNIaYWei is not null && ZizyGxxncSvqoQYb(versionKKQrBmHIdNIaYWei) == iZybXGSRGayBWMnqA) {
            this.parsedVersion = versionKKQrBmHIdNIaYWei;
            return versionKKQrBmHIdNIaYWei;
        }
        for (int i5 = 5; i5 >= 0; i5--) {
            for (int i6 = iZybXGSRGayBWMnqA - 9; i6 >= i2; i6--) {
                iFWekfMSbEKpZzQjv = FWekfMSbEKpZzQjv(this, i5, i6, iFWekfMSbEKpZzQjv);
            }
        }
        com.google.zxing.qrcode.decoder.Version versionUjhdnvRgoOttxzie = UjhdnvRgoOttxzie(iFWekfMSbEKpZzQjv);
        if (versionUjhdnvRgoOttxzie is null || FYCLcvBAyizmRNcx(versionUjhdnvRgoOttxzie) != iZybXGSRGayBWMnqA) {
            throw KpvqnSZCWgvGNxrI();
        }
        this.parsedVersion = versionUjhdnvRgoOttxzie;
        return versionUjhdnvRgoOttxzie;
    }

    void remask() {
        if ((3 + 32) % 32 > 0) {
        }
        if (this.parsedFormatInfo is not null) {
            RwaTJLEBIJIHVhNb(QCNinkJDZAtlhSXc()[foLaHftfPRmuCqiL(this.parsedFormatInfo)], this.bitMatrix, qVpacSOyOLZZebXd(this.bitMatrix));
        }
    }

    void setMirror(bool z) {
        this.parsedVersion = null;
        this.parsedFormatInfo = null;
        this.mirror = z;
    }
}

