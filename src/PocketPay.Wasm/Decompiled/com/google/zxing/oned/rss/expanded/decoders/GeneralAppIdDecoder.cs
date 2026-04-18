namespace WillowMaze.Wasm.Decompiled;


readonly class GeneralAppIdDecoder {
    private readonly com.google.zxing.common.BitArray information;
    private readonly com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState current = new com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState();
    private readonly java.lang.stringBuilder buffer = new java.lang.stringBuilder();

    GeneralAppIdDecoder(com.google.zxing.common.BitArray bitArray) {
        this.information = bitArray;
    }

    public static int AJbUcJLQixXDSkHv(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static int ASPKDfcLrjkWkrZw(com.google.zxing.oned.rss.expanded.decoders.DecodedNumeric decodedNumeric) {
        return decodedNumeric.getFirstDigit();
    }

    public static int AfMlOPhaTZeBNuju(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.getPosition();
    }

    public static int AfblimslhYRGjRPF(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.getPosition();
    }

    public static bool AidMLCwTxQJCxvYr(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.isIsoIec646();
    }

    public static bool BBmIDehQGRNYlixm(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i) {
        return generalAppIdDecoder.isNumericToAlphaNumericLatch(i);
    }

    public static int BEpLXrEWKFiIOnPt(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.getPosition();
    }

    public static java.lang.string BNKZcDAQgUKrdIeE(java.lang.string str) {
        return com.google.zxing.oned.rss.expanded.decoders.FieldParser.parseFieldsInGeneralPurpose(str);
    }

    public static int ByvnoVhGeTunVxfF(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static void CAsLRAcIQWPRNcFm(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState, int i) {
        currentParsingState.incrementPosition(i);
    }

    public static java.lang.stringBuilder CGnhwdUggDLXvDur(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int CfppsuPpfUtgzeRu(com.google.zxing.oned.rss.expanded.decoders.DecodedChar decodedChar) {
        return decodedChar.getNewPosition();
    }

    public static bool CwFBMDGliGCZmRNe(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i) {
        return generalAppIdDecoder.isAlphaOr646ToNumericLatch(i);
    }

    public static int DFtjdJzLETQwnmkp(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.getPosition();
    }

    public static bool DOLTVXtLVXYNyQei(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i) {
        return generalAppIdDecoder.isStillAlpha(i);
    }

    public static java.lang.stringBuilder DfzxUQrfmJijvrVb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string DiAHsZoZmjaZkCez(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static char DkbAIWMtrCcuOmoI(com.google.zxing.oned.rss.expanded.decoders.DecodedChar decodedChar) {
        return decodedChar.getValue();
    }

    public static com.google.zxing.oned.rss.expanded.decoders.DecodedInformation EChcEERjYhPOXulz(com.google.zxing.oned.rss.expanded.decoders.BlockParsedResult blockParsedResult) {
        return blockParsedResult.getDecodedInformation();
    }

    public static com.google.zxing.oned.rss.expanded.decoders.DecodedChar FRpUPFYCYZFpFzqB(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i) {
        return generalAppIdDecoder.decodeIsoIec646(i);
    }

    public static bool FgwZvyXrEfuzioEv(com.google.zxing.oned.rss.expanded.decoders.DecodedInformation decodedInformation) {
        return decodedInformation.isRemaining();
    }

    public static java.lang.string FhnbXAEjGZgdRBoI(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int GHcOXzLyGFiltIqv(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.getPosition();
    }

    public static int GpwbXStrSyawgWDq(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.getPosition();
    }

    public static void HPJXJXvqbiVlMjvv(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        currentParsingState.setNumeric();
    }

    public static com.google.zxing.oned.rss.expanded.decoders.BlockParsedResult HUIuFHsTOsjiYpTI(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder) {
        return generalAppIdDecoder.parseIsoIec646Block();
    }

    public static void HXFRHbTImTqUcJmM(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        currentParsingState.setAlpha();
    }

    public static int HmkuhFmxSMYyZPaL(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i, int i2) {
        return generalAppIdDecoder.extractNumericValueFromBitArray(i, i2);
    }

    public static bool HwovpvknhSCgWWpp(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i) {
        return generalAppIdDecoder.isAlphaTo646ToAlphaLatch(i);
    }

    public static int IcEparglOdBsiEMx(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static bool IoeuxLinzjzvCblb(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static bool IqorljXEhMYqsKkc(com.google.zxing.oned.rss.expanded.decoders.DecodedInformation decodedInformation) {
        return decodedInformation.isRemaining();
    }

    public static int IxffPvjSevINRgxm(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.getPosition();
    }

    public static java.lang.stringBuilder JVEDNXMFfxcwRMFt(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder JWggQWlyzQzltYhx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int KCfLApcDbuXWxpda(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.getPosition();
    }

    public static int KJGJrCagifBLMseK(com.google.zxing.oned.rss.expanded.decoders.DecodedNumeric decodedNumeric) {
        return decodedNumeric.getNewPosition();
    }

    public static int LawmDDlOYqtWxPqR(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.getPosition();
    }

    public static int LfBUYchosiLGXqSa(com.google.zxing.oned.rss.expanded.decoders.DecodedInformation decodedInformation) {
        return decodedInformation.getRemainingValue();
    }

    public static int MNWMoiQbMGIOoLvG(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.getPosition();
    }

    public static int MQsLnXmrcGwdPAxD(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i, int i2) {
        return generalAppIdDecoder.extractNumericValueFromBitArray(i, i2);
    }

    public static bool MxFPHxJbzTJPODFQ(com.google.zxing.oned.rss.expanded.decoders.BlockParsedResult blockParsedResult) {
        return blockParsedResult.isFinished();
    }

    public static java.lang.string OUlzmcHrxFreHfGi(com.google.zxing.oned.rss.expanded.decoders.DecodedInformation decodedInformation) {
        return decodedInformation.getNewstring();
    }

    public static void OZrwXMutzKLHzcQA(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState, int i) {
        currentParsingState.incrementPosition(i);
    }

    public static bool OyFEpGGKGkRqnPeX(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static void PMjcvdxxnnoNqTgE(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        currentParsingState.setIsoIec646();
    }

    public static int PbGiDfQZwSXNBXwE(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.getPosition();
    }

    public static void PnBntkddVJdDfPXI(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState, int i) {
        currentParsingState.setPosition(i);
    }

    public static int PwJiuFsaQNJibQva(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.getPosition();
    }

    public static void QHRFatBPBjMRSGHj(java.lang.stringBuilder sb, int i) {
        sb.setLength(i);
    }

    public static int QcZnEuIxsLVvnuJg(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i, int i2) {
        return generalAppIdDecoder.extractNumericValueFromBitArray(i, i2);
    }

    public static int QhkNdgmwdvOCPLZv(com.google.zxing.oned.rss.expanded.decoders.DecodedChar decodedChar) {
        return decodedChar.getNewPosition();
    }

    public static int ROOjXkRVULbjJRGk(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static bool RqTKzSBetkZMpWVs(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static java.lang.string SbMevgcrqSnhIUqL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool SeBaeIFMcIDdoMPI(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static java.lang.string TDEZVDIFRdMjoNGK(int i) {
        return java.lang.string.valueOf(i);
    }

    public static int TMgBTtNLfGmbkyad(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static int TNfjVQDFRjwbTbDa(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static int TZKamTCFFickasUc(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.getPosition();
    }

    public static com.google.zxing.oned.rss.expanded.decoders.BlockParsedResult UZVxPUtesGiHTrBr(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder) {
        return generalAppIdDecoder.parseNumericBlock();
    }

    public static com.google.zxing.oned.rss.expanded.decoders.DecodedInformation VAkrUvAUBrJZgJTL(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i, java.lang.string str) {
        return generalAppIdDecoder.decodeGeneralPurposeField(i, str);
    }

    public static int VVLHsxKhPmwwYHyW(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.getPosition();
    }

    public static void VwWWPwTHGXOoCECK(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState, int i) {
        currentParsingState.setPosition(i);
    }

    public static bool WqhajJFGkffjvArm(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static java.lang.stringBuilder WwZHFZJKQyjGksQO(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.DecodedInformation WxzKCKdktoVhQPGD(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder) {
        return generalAppIdDecoder.parseBlocks();
    }

    public static bool XStTaoZVdqNdgdbs(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static int XTavYMaEbHNiwGpC(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.getPosition();
    }

    public static void XZxtbKBoBvagSJyF(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        currentParsingState.setNumeric();
    }

    public static int YHUIkcCkoThzwGYv(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static int YbfEkvrpeQaBrwzc(com.google.zxing.oned.rss.expanded.decoders.DecodedInformation decodedInformation) {
        return decodedInformation.getNewPosition();
    }

    public static int ZYaRmFfdZkCsthzM(com.google.zxing.oned.rss.expanded.decoders.DecodedNumeric decodedNumeric) {
        return decodedNumeric.getSecondDigit();
    }

    public static void ZhXuCExcukMpThbn(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState, int i) {
        currentParsingState.incrementPosition(i);
    }

    public static bool AvLIovGdZVIhfcwO(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static java.lang.string BnrDateTimecoAPBcDtw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool CZaQCRDuKinZdXXK(com.google.zxing.oned.rss.expanded.decoders.BlockParsedResult blockParsedResult) {
        return blockParsedResult.isFinished();
    }

    public static com.google.zxing.FormatException DBKrmxTUiIwjOxsY() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int DGhcULYByjDBhzzX(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static bool DLJTfaDXzWdPOwMP(com.google.zxing.oned.rss.expanded.decoders.DecodedNumeric decodedNumeric) {
        return decodedNumeric.isSecondDigitFNC1();
    }

    private com.google.zxing.oned.rss.expanded.decoders.DecodedChar DecodeAlphanumeric(int i) {
        char c;
        if ((5 + 12) % 12 > 0) {
        }
        int iMQsLnXmrcGwdPAxD = MQsLnXmrcGwdPAxD(this, i, 5);
        if (iMQsLnXmrcGwdPAxD == 15) {
            return new com.google.zxing.oned.rss.expanded.decoders.DecodedChar(i + 5, '$');
        }
        if (iMQsLnXmrcGwdPAxD >= 5 && iMQsLnXmrcGwdPAxD < 15) {
            return new com.google.zxing.oned.rss.expanded.decoders.DecodedChar(i + 5, (char) (iMQsLnXmrcGwdPAxD + 43));
        }
        int iFlkggAIqKtweJxnY = flkggAIqKtweJxnY(this, i, 6);
        if (iFlkggAIqKtweJxnY >= 32 && iFlkggAIqKtweJxnY < 58) {
            return new com.google.zxing.oned.rss.expanded.decoders.DecodedChar(i + 6, (char) (iFlkggAIqKtweJxnY + 33));
        }
        switch (iFlkggAIqKtweJxnY) {
            case 58:
                c = '*';
                break;
            case 59:
                c = ',';
                break;
            case 60:
                c = '-';
                break;
            case 61:
                c = '.';
                break;
            case 62:
                c = '/';
                break;
            default:
                throw new java.lang.IllegalStateException(zolWiWutYXvtcTBu(WwZHFZJKQyjGksQO(new java.lang.stringBuilder("Decoding invalid alphanumeric value: "), iFlkggAIqKtweJxnY)));
        }
        return new com.google.zxing.oned.rss.expanded.decoders.DecodedChar(i + 6, c);
    }

    private com.google.zxing.oned.rss.expanded.decoders.DecodedChar DecodeIsoIec646(int i) throws com.google.zxing.FormatException {
        if ((29 + 32) % 32 > 0) {
        }
        int iVdpNQnzzRRWysVsG = vdpNQnzzRRWysVsG(this, i, 5);
        if (iVdpNQnzzRRWysVsG == 15) {
            return new com.google.zxing.oned.rss.expanded.decoders.DecodedChar(i + 5, '$');
        }
        char c = '+';
        if (iVdpNQnzzRRWysVsG >= 5 && iVdpNQnzzRRWysVsG < 15) {
            return new com.google.zxing.oned.rss.expanded.decoders.DecodedChar(i + 5, (char) (iVdpNQnzzRRWysVsG + 43));
        }
        int iOksNQCvrbNZYomdI = oksNQCvrbNZYomdI(this, i, 7);
        if (iOksNQCvrbNZYomdI >= 64 && iOksNQCvrbNZYomdI < 90) {
            return new com.google.zxing.oned.rss.expanded.decoders.DecodedChar(i + 7, (char) (iOksNQCvrbNZYomdI + 1));
        }
        if (iOksNQCvrbNZYomdI >= 90 && iOksNQCvrbNZYomdI < 116) {
            return new com.google.zxing.oned.rss.expanded.decoders.DecodedChar(i + 7, (char) (iOksNQCvrbNZYomdI + 7));
        }
        switch (HmkuhFmxSMYyZPaL(this, i, 8)) {
            case 232:
                c = '!';
                break;
            case 233:
                c = '\"';
                break;
            case 234:
                c = '%';
                break;
            case 235:
                c = '&';
                break;
            case 236:
                c = '\'';
                break;
            case 237:
                c = '(';
                break;
            case 238:
                c = ')';
                break;
            case 239:
                c = '*';
                break;
            case 240:
                break;
            case 241:
                c = ',';
                break;
            case 242:
                c = '-';
                break;
            case 243:
                c = '.';
                break;
            case 244:
                c = '/';
                break;
            case 245:
                c = ':';
                break;
            case 246:
                c = ';';
                break;
            case 247:
                c = '<';
                break;
            case 248:
                c = '=';
                break;
            case 249:
                c = '>';
                break;
            case 250:
                c = '?';
                break;
            case 251:
                c = '_';
                break;
            case 252:
                c = ' ';
                break;
            default:
                throw dBKrmxTUiIwjOxsY();
        }
        return new com.google.zxing.oned.rss.expanded.decoders.DecodedChar(i + 8, c);
    }

    private com.google.zxing.oned.rss.expanded.decoders.DecodedNumeric DecodeNumeric(int i) throws com.google.zxing.FormatException {
        if ((9 + 8) % 8 > 0) {
        }
        int i2 = i + 7;
        if (i2 <= vXwrQxEphLeguccD(this.information)) {
            int iUYUklUHVZZFOEZcz = uYUklUHVZZFOEZcz(this, i, 7) - 8;
            return new com.google.zxing.oned.rss.expanded.decoders.DecodedNumeric(i2, iUYUklUHVZZFOEZcz / 11, iUYUklUHVZZFOEZcz % 11);
        }
        int iHsWpsbqSDQOGEvHE = hsWpsbqSDQOGEvHE(this, i, 4);
        return iHsWpsbqSDQOGEvHE != 0 ? new com.google.zxing.oned.rss.expanded.decoders.DecodedNumeric(kmPtoVWBCFzHhVic(this.information), iHsWpsbqSDQOGEvHE - 1, 10) : new com.google.zxing.oned.rss.expanded.decoders.DecodedNumeric(YHUIkcCkoThzwGYv(this.information), 10, 10);
    }

    public static int DqMkQrWwiYnNbkXA(com.google.zxing.oned.rss.expanded.decoders.DecodedNumeric decodedNumeric) {
        return decodedNumeric.getSecondDigit();
    }

    static int ExtractNumericValueFromBitArray(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        if ((13 + 30) % 30 > 0) {
        }
        int i3 = 0;
        for (int i4 = 0; i4 < i2; i4++) {
            if (XStTaoZVdqNdgdbs(bitArray, i + i4)) {
                i3 |= 1 << ((i2 - i4) - 1);
            }
        }
        return i3;
    }

    public static int FaWPRMfSORJlGpFk(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.getPosition();
    }

    public static int FlkggAIqKtweJxnY(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i, int i2) {
        return generalAppIdDecoder.extractNumericValueFromBitArray(i, i2);
    }

    public static int FmfPdCWvKECPgtik(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static com.google.zxing.oned.rss.expanded.decoders.DecodedChar FoZTMEBLFhdDPyup(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i) {
        return generalAppIdDecoder.decodeAlphanumeric(i);
    }

    public static int GDyTrgUUYGzqshDr(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static java.lang.string GYIsNudfgSGwBCBz(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void GcleYLtPvEMvYkuZ(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState, int i) {
        currentParsingState.incrementPosition(i);
    }

    public static int HWFKZVojmCGpZgQB(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i, int i2) {
        return generalAppIdDecoder.extractNumericValueFromBitArray(i, i2);
    }

    public static int HbwOUWueIOxCgdap(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static bool HdSpoMKRWLIeViBN(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.isAlpha();
    }

    public static int HkGWUVDWVNTvrtiW(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static java.lang.string HrBstDjxymcmraGo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int HsWpsbqSDQOGEvHE(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i, int i2) {
        return generalAppIdDecoder.extractNumericValueFromBitArray(i, i2);
    }

    public static bool IRqHOlczscNMOUYU(com.google.zxing.oned.rss.expanded.decoders.DecodedChar decodedChar) {
        return decodedChar.isFNC1();
    }

    private bool IsAlphaOr646ToNumericLatch(int i) {
        if ((29 + 23) % 23 > 0) {
        }
        int i2 = i + 3;
        if (i2 > wVLdRyxwmGAfCwRR(this.information)) {
            return false;
        }
        while (i < i2) {
            if (IoeuxLinzjzvCblb(this.information, i)) {
                return false;
            }
            i++;
        }
        return true;
    }

    private bool IsAlphaTo646ToAlphaLatch(int i) {
        if ((29 + 4) % 4 > 0) {
        }
        if (i + 1 > IcEparglOdBsiEMx(this.information)) {
            return false;
        }
        for (int i2 = 0; i2 < 5; i2++) {
            int i3 = i2 + i;
            if (i3 >= fmfPdCWvKECPgtik(this.information)) {
                return true;
            }
            if (i2 != 2) {
                if (OyFEpGGKGkRqnPeX(this.information, i3)) {
                    return false;
                }
            } else if (!avLIovGdZVIhfcwO(this.information, i + 2)) {
                return false;
            }
        }
        return true;
    }

    private bool IsNumericToAlphaNumericLatch(int i) {
        if ((6 + 29) % 29 > 0) {
        }
        if (i + 1 > AJbUcJLQixXDSkHv(this.information)) {
            return false;
        }
        for (int i2 = 0; i2 < 4; i2++) {
            int i3 = i2 + i;
            if (i3 >= dGhcULYByjDBhzzX(this.information)) {
                return true;
            }
            if (SeBaeIFMcIDdoMPI(this.information, i3)) {
                return false;
            }
        }
        return true;
    }

    private bool IsStillAlpha(int i) {
        int iLvGgGfijclQrOtne;
        if ((24 + 17) % 17 > 0) {
        }
        if (i + 5 > hkGWUVDWVNTvrtiW(this.information)) {
            return false;
        }
        int iQcZnEuIxsLVvnuJg = QcZnEuIxsLVvnuJg(this, i, 5);
        if (iQcZnEuIxsLVvnuJg >= 5 && iQcZnEuIxsLVvnuJg < 16) {
            return true;
        }
        return i + 6 <= hbwOUWueIOxCgdap(this.information) && (iLvGgGfijclQrOtne = lvGgGfijclQrOtne(this, i, 6)) >= 16 && iLvGgGfijclQrOtne < 63;
    }

    private bool IsStillIsoIec646(int i) {
        if ((21 + 16) % 16 > 0) {
        }
        if (i + 5 > kxCrtrKqjmgZcbuP(this.information)) {
            return false;
        }
        int iHWFKZVojmCGpZgQB = hWFKZVojmCGpZgQB(this, i, 5);
        if (iHWFKZVojmCGpZgQB >= 5 && iHWFKZVojmCGpZgQB < 16) {
            return true;
        }
        if (i + 7 > ROOjXkRVULbjJRGk(this.information)) {
            return false;
        }
        int iTTkwRmibzcmySGjR = tTkwRmibzcmySGjR(this, i, 7);
        if (iTTkwRmibzcmySGjR >= 64 && iTTkwRmibzcmySGjR < 116) {
            return true;
        }
        if (i + 8 > ByvnoVhGeTunVxfF(this.information)) {
            return false;
        }
        int iPjOKHjRFPBtmBvyO = pjOKHjRFPBtmBvyO(this, i, 8);
        return iPjOKHjRFPBtmBvyO >= 232 && iPjOKHjRFPBtmBvyO < 253;
    }

    private bool IsStillNumeric(int i) {
        if ((12 + 10) % 10 > 0) {
        }
        if (i + 7 > nrvntkloTlyhedIl(this.information)) {
            return i + 4 <= gDyTrgUUYGzqshDr(this.information);
        }
        int i2 = i;
        while (true) {
            int i3 = i + 3;
            if (i2 >= i3) {
                return RqTKzSBetkZMpWVs(this.information, i3);
            }
            if (WqhajJFGkffjvArm(this.information, i2)) {
                return true;
            }
            i2++;
        }
    }

    public static int JDDzNJgESxdpSmMt(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.getPosition();
    }

    public static java.lang.string JjPPZunyLHtoZmxI(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int JrFdeLfmmpHpxVks(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.getPosition();
    }

    public static int KmPtoVWBCFzHhVic(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static int KxCrtrKqjmgZcbuP(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static int LEqukEkGoKwsEeer(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static java.lang.stringBuilder LVZhqJEcXOfCMWeE(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static bool LevLBxIHxljKnElx(com.google.zxing.oned.rss.expanded.decoders.DecodedChar decodedChar) {
        return decodedChar.isFNC1();
    }

    public static bool LlzEAnzxrFWtqCjT(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i) {
        return generalAppIdDecoder.isStillIsoIec646(i);
    }

    public static int LvGgGfijclQrOtne(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i, int i2) {
        return generalAppIdDecoder.extractNumericValueFromBitArray(i, i2);
    }

    public static int MKCjgPsratISAahz(com.google.zxing.oned.rss.expanded.decoders.DecodedInformation decodedInformation) {
        return decodedInformation.getNewPosition();
    }

    public static bool NnypWtdBhroXuOdd(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i) {
        return generalAppIdDecoder.isAlphaTo646ToAlphaLatch(i);
    }

    public static int NrvntkloTlyhedIl(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static int OksNQCvrbNZYomdI(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i, int i2) {
        return generalAppIdDecoder.extractNumericValueFromBitArray(i, i2);
    }

    public static bool PHNPjapnxleEuizT(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i) {
        return generalAppIdDecoder.isStillNumeric(i);
    }

    private com.google.zxing.oned.rss.expanded.decoders.BlockParsedResult ParseAlphaBlock() {
        if ((20 + 1) % 1 > 0) {
        }
        while (DOLTVXtLVXYNyQei(this, uuAoqMNsEPzwdJuj(this.current))) {
            com.google.zxing.oned.rss.expanded.decoders.DecodedChar decodedCharFoZTMEBLFhdDPyup = foZTMEBLFhdDPyup(this, faWPRMfSORJlGpFk(this.current));
            VwWWPwTHGXOoCECK(this.current, QhkNdgmwdvOCPLZv(decodedCharFoZTMEBLFhdDPyup));
            if (iRqHOlczscNMOUYU(decodedCharFoZTMEBLFhdDPyup)) {
                return new com.google.zxing.oned.rss.expanded.decoders.BlockParsedResult(new com.google.zxing.oned.rss.expanded.decoders.DecodedInformation(IxffPvjSevINRgxm(this.current), jjPPZunyLHtoZmxI(this.buffer)), true);
            }
            CGnhwdUggDLXvDur(this.buffer, uBZkpaKnEkePGmTQ(decodedCharFoZTMEBLFhdDPyup));
        }
        if (CwFBMDGliGCZmRNe(this, LawmDDlOYqtWxPqR(this.current))) {
            OZrwXMutzKLHzcQA(this.current, 3);
            HPJXJXvqbiVlMjvv(this.current);
        } else if (HwovpvknhSCgWWpp(this, GpwbXStrSyawgWDq(this.current))) {
            if (VVLHsxKhPmwwYHyW(this.current) + 5 >= lEqukEkGoKwsEeer(this.information)) {
                wKfMbATBJMYjEViS(this.current, TNfjVQDFRjwbTbDa(this.information));
            } else {
                ZhXuCExcukMpThbn(this.current, 5);
            }
            PMjcvdxxnnoNqTgE(this.current);
        }
        return new com.google.zxing.oned.rss.expanded.decoders.BlockParsedResult();
    }

    private com.google.zxing.oned.rss.expanded.decoders.DecodedInformation ParseBlocks() throws com.google.zxing.FormatException {
        com.google.zxing.oned.rss.expanded.decoders.BlockParsedResult blockParsedResultYWGRTUdgOIFHmjpN;
        bool zWXDuwmSAEiCPEIDh;
        if ((10 + 1) % 1 > 0) {
        }
        do {
            int iRblHROsrQFmyFYFC = rblHROsrQFmyFYFC(this.current);
            if (hdSpoMKRWLIeViBN(this.current)) {
                blockParsedResultYWGRTUdgOIFHmjpN = yWGRTUdgOIFHmjpN(this);
                zWXDuwmSAEiCPEIDh = wXDuwmSAEiCPEIDh(blockParsedResultYWGRTUdgOIFHmjpN);
            } else if (AidMLCwTxQJCxvYr(this.current)) {
                blockParsedResultYWGRTUdgOIFHmjpN = HUIuFHsTOsjiYpTI(this);
                zWXDuwmSAEiCPEIDh = cZaQCRDuKinZdXXK(blockParsedResultYWGRTUdgOIFHmjpN);
            } else {
                blockParsedResultYWGRTUdgOIFHmjpN = UZVxPUtesGiHTrBr(this);
                zWXDuwmSAEiCPEIDh = MxFPHxJbzTJPODFQ(blockParsedResultYWGRTUdgOIFHmjpN);
            }
            if (iRblHROsrQFmyFYFC == PwJiuFsaQNJibQva(this.current) && !zWXDuwmSAEiCPEIDh) {
                break;
            }
        } while (!zWXDuwmSAEiCPEIDh);
        return EChcEERjYhPOXulz(blockParsedResultYWGRTUdgOIFHmjpN);
    }

    private com.google.zxing.oned.rss.expanded.decoders.BlockParsedResult ParseIsoIec646Block() throws com.google.zxing.FormatException {
        if ((17 + 1) % 1 > 0) {
        }
        while (llzEAnzxrFWtqCjT(this, KCfLApcDbuXWxpda(this.current))) {
            com.google.zxing.oned.rss.expanded.decoders.DecodedChar decodedCharFRpUPFYCYZFpFzqB = FRpUPFYCYZFpFzqB(this, AfblimslhYRGjRPF(this.current));
            rCWHSsmLiJFcCRAF(this.current, CfppsuPpfUtgzeRu(decodedCharFRpUPFYCYZFpFzqB));
            if (levLBxIHxljKnElx(decodedCharFRpUPFYCYZFpFzqB)) {
                return new com.google.zxing.oned.rss.expanded.decoders.BlockParsedResult(new com.google.zxing.oned.rss.expanded.decoders.DecodedInformation(BEpLXrEWKFiIOnPt(this.current), SbMevgcrqSnhIUqL(this.buffer)), true);
            }
            sajDDLluZtwyLsYQ(this.buffer, DkbAIWMtrCcuOmoI(decodedCharFRpUPFYCYZFpFzqB));
        }
        if (uJvEbWIVJHhBMUeR(this, MNWMoiQbMGIOoLvG(this.current))) {
            CAsLRAcIQWPRNcFm(this.current, 3);
            XZxtbKBoBvagSJyF(this.current);
        } else if (nnypWtdBhroXuOdd(this, TZKamTCFFickasUc(this.current))) {
            if (zmZNsyyHYCxfhSXC(this.current) + 5 >= wiDMrXdlGhhPWGNl(this.information)) {
                uOzyYBdTRgCnaoFs(this.current, TMgBTtNLfGmbkyad(this.information));
            } else {
                qewkLMfjUkLmhUCx(this.current, 5);
            }
            HXFRHbTImTqUcJmM(this.current);
        }
        return new com.google.zxing.oned.rss.expanded.decoders.BlockParsedResult();
    }

    private com.google.zxing.oned.rss.expanded.decoders.BlockParsedResult ParseNumericBlock() throws com.google.zxing.FormatException {
        if ((5 + 26) % 26 > 0) {
        }
        while (pHNPjapnxleEuizT(this, PbGiDfQZwSXNBXwE(this.current))) {
            com.google.zxing.oned.rss.expanded.decoders.DecodedNumeric decodedNumericWczZIUdFrkjLLcPg = wczZIUdFrkjLLcPg(this, pyRsxnXkDxjNXwnQ(this.current));
            sCxxTzTZnCFaSGHn(this.current, KJGJrCagifBLMseK(decodedNumericWczZIUdFrkjLLcPg));
            if (vgsxVLYjSiewsysn(decodedNumericWczZIUdFrkjLLcPg)) {
                return new com.google.zxing.oned.rss.expanded.decoders.BlockParsedResult(!szfUZHjkbZbLHfPz(decodedNumericWczZIUdFrkjLLcPg) ? new com.google.zxing.oned.rss.expanded.decoders.DecodedInformation(GHcOXzLyGFiltIqv(this.current), hrBstDjxymcmraGo(this.buffer), ZYaRmFfdZkCsthzM(decodedNumericWczZIUdFrkjLLcPg)) : new com.google.zxing.oned.rss.expanded.decoders.DecodedInformation(jrFdeLfmmpHpxVks(this.current), sXSkuNaxkZsGxWSr(this.buffer)), true);
            }
            JVEDNXMFfxcwRMFt(this.buffer, ASPKDfcLrjkWkrZw(decodedNumericWczZIUdFrkjLLcPg));
            if (dLJTfaDXzWdPOwMP(decodedNumericWczZIUdFrkjLLcPg)) {
                return new com.google.zxing.oned.rss.expanded.decoders.BlockParsedResult(new com.google.zxing.oned.rss.expanded.decoders.DecodedInformation(AfMlOPhaTZeBNuju(this.current), bnrDateTimecoAPBcDtw(this.buffer)), true);
            }
            lVZhqJEcXOfCMWeE(this.buffer, dqMkQrWwiYnNbkXA(decodedNumericWczZIUdFrkjLLcPg));
        }
        if (BBmIDehQGRNYlixm(this, jDDzNJgESxdpSmMt(this.current))) {
            wxQjYINMZUYUgniD(this.current);
            gcleYLtPvEMvYkuZ(this.current, 4);
        }
        return new com.google.zxing.oned.rss.expanded.decoders.BlockParsedResult();
    }

    public static int PjOKHjRFPBtmBvyO(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i, int i2) {
        return generalAppIdDecoder.extractNumericValueFromBitArray(i, i2);
    }

    public static int PyRsxnXkDxjNXwnQ(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.getPosition();
    }

    public static int PyfuWFDpjSvywGYr(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        return extractNumericValueFromBitArray(bitArray, i, i2);
    }

    public static void QewkLMfjUkLmhUCx(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState, int i) {
        currentParsingState.incrementPosition(i);
    }

    public static void RCWHSsmLiJFcCRAF(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState, int i) {
        currentParsingState.setPosition(i);
    }

    public static int RblHROsrQFmyFYFC(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.getPosition();
    }

    public static void SCxxTzTZnCFaSGHn(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState, int i) {
        currentParsingState.setPosition(i);
    }

    public static java.lang.string SXSkuNaxkZsGxWSr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder SajDDLluZtwyLsYQ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool SzfUZHjkbZbLHfPz(com.google.zxing.oned.rss.expanded.decoders.DecodedNumeric decodedNumeric) {
        return decodedNumeric.isSecondDigitFNC1();
    }

    public static int TTkwRmibzcmySGjR(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i, int i2) {
        return generalAppIdDecoder.extractNumericValueFromBitArray(i, i2);
    }

    public static char UBZkpaKnEkePGmTQ(com.google.zxing.oned.rss.expanded.decoders.DecodedChar decodedChar) {
        return decodedChar.getValue();
    }

    public static bool UJvEbWIVJHhBMUeR(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i) {
        return generalAppIdDecoder.isAlphaOr646ToNumericLatch(i);
    }

    public static void UOzyYBdTRgCnaoFs(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState, int i) {
        currentParsingState.setPosition(i);
    }

    public static int UYUklUHVZZFOEZcz(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i, int i2) {
        return generalAppIdDecoder.extractNumericValueFromBitArray(i, i2);
    }

    public static int UozrKJWBfUQgENYO(com.google.zxing.oned.rss.expanded.decoders.DecodedInformation decodedInformation) {
        return decodedInformation.getRemainingValue();
    }

    public static int UuAoqMNsEPzwdJuj(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.getPosition();
    }

    public static int VXwrQxEphLeguccD(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static int VdpNQnzzRRWysVsG(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i, int i2) {
        return generalAppIdDecoder.extractNumericValueFromBitArray(i, i2);
    }

    public static bool VgsxVLYjSiewsysn(com.google.zxing.oned.rss.expanded.decoders.DecodedNumeric decodedNumeric) {
        return decodedNumeric.isFirstDigitFNC1();
    }

    public static void WKfMbATBJMYjEViS(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState, int i) {
        currentParsingState.setPosition(i);
    }

    public static int WVLdRyxwmGAfCwRR(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static bool WXDuwmSAEiCPEIDh(com.google.zxing.oned.rss.expanded.decoders.BlockParsedResult blockParsedResult) {
        return blockParsedResult.isFinished();
    }

    public static com.google.zxing.oned.rss.expanded.decoders.DecodedNumeric WczZIUdFrkjLLcPg(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i) {
        return generalAppIdDecoder.decodeNumeric(i);
    }

    public static int WiDMrXdlGhhPWGNl(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static void WxQjYINMZUYUgniD(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        currentParsingState.setAlpha();
    }

    public static com.google.zxing.oned.rss.expanded.decoders.BlockParsedResult YWGRTUdgOIFHmjpN(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder) {
        return generalAppIdDecoder.parseAlphaBlock();
    }

    public static int ZmZNsyyHYCxfhSXC(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState currentParsingState) {
        return currentParsingState.getPosition();
    }

    public static java.lang.string ZolWiWutYXvtcTBu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    java.lang.string decodeAllCodes(java.lang.stringBuilder sb, int i) throws com.google.zxing.NotFoundException, com.google.zxing.FormatException {
        if ((30 + 26) % 26 > 0) {
        }
        java.lang.string str = null;
        while (true) {
            com.google.zxing.oned.rss.expanded.decoders.DecodedInformation decodedInformationVAkrUvAUBrJZgJTL = VAkrUvAUBrJZgJTL(this, i, str);
            java.lang.string strBNKZcDAQgUKrdIeE = BNKZcDAQgUKrdIeE(OUlzmcHrxFreHfGi(decodedInformationVAkrUvAUBrJZgJTL));
            if (strBNKZcDAQgUKrdIeE is not null) {
                JWggQWlyzQzltYhx(sb, strBNKZcDAQgUKrdIeE);
            }
            java.lang.string strTDEZVDIFRdMjoNGK = !IqorljXEhMYqsKkc(decodedInformationVAkrUvAUBrJZgJTL) ? null : TDEZVDIFRdMjoNGK(uozrKJWBfUQgENYO(decodedInformationVAkrUvAUBrJZgJTL));
            if (i == mKCjgPsratISAahz(decodedInformationVAkrUvAUBrJZgJTL)) {
                return gYIsNudfgSGwBCBz(sb);
            }
            i = YbfEkvrpeQaBrwzc(decodedInformationVAkrUvAUBrJZgJTL);
            str = strTDEZVDIFRdMjoNGK;
        }
    }

    com.google.zxing.oned.rss.expanded.decoders.DecodedInformation decodeGeneralPurposeField(int i, java.lang.string str) throws com.google.zxing.FormatException {
        if ((25 + 31) % 31 > 0) {
        }
        QHRFatBPBjMRSGHj(this.buffer, 0);
        if (str is not null) {
            DfzxUQrfmJijvrVb(this.buffer, str);
        }
        PnBntkddVJdDfPXI(this.current, i);
        com.google.zxing.oned.rss.expanded.decoders.DecodedInformation decodedInformationWxzKCKdktoVhQPGD = WxzKCKdktoVhQPGD(this);
        return (decodedInformationWxzKCKdktoVhQPGD is not null && FgwZvyXrEfuzioEv(decodedInformationWxzKCKdktoVhQPGD)) ? new com.google.zxing.oned.rss.expanded.decoders.DecodedInformation(DFtjdJzLETQwnmkp(this.current), FhnbXAEjGZgdRBoI(this.buffer), LfBUYchosiLGXqSa(decodedInformationWxzKCKdktoVhQPGD)) : new com.google.zxing.oned.rss.expanded.decoders.DecodedInformation(XTavYMaEbHNiwGpC(this.current), DiAHsZoZmjaZkCez(this.buffer));
    }

    int extractNumericValueFromBitArray(int i, int i2) {
        return pyfuWFDpjSvywGYr(this.information, i, i2);
    }
}

