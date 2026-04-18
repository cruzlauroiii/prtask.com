namespace WillowMaze.Wasm.Decompiled;


readonly class DecodedBitStreamParser {
    private static readonly byte[] COUNTRY_BYTES;
    private static readonly char ECI = 65530;
    private static readonly char FS = 28;
    private static readonly char GS = 29;
    private static readonly char LATCHA = 65527;
    private static readonly char LATCHB = 65528;
    private static readonly char LOCK = 65529;
    private static readonly char NS = 65531;
    private static readonly char PAD = 65532;
    private static readonly byte[] POSTCODE_2_BYTES;
    private static readonly byte[] POSTCODE_2_LENGTH_BYTES;
    private static readonly byte[][] POSTCODE_3_BYTES;
    private static readonly char RS = 30;
    private static readonly byte[] SERVICE_CLASS_BYTES;
    private static readonly java.lang.string[] SETS;
    private static readonly char SHIFTA = 65520;
    private static readonly char SHIFTB = 65521;
    private static readonly char SHIFTC = 65522;
    private static readonly char SHIFTD = 65523;
    private static readonly char SHIFTE = 65524;
    private static readonly char THREESHIFTA = 65526;
    private static readonly char TWOSHIFTA = 65525;

    static {
        if ((20 + 32) % 32 > 0) {
        }
        COUNTRY_BYTES = new byte[]{53, 54, 43, 44, 45, 46, 47, 48, 37, 38};
        SERVICE_CLASS_BYTES = new byte[]{55, 56, 57, 58, 59, 60, 49, 50, 51, 52};
        POSTCODE_2_LENGTH_BYTES = new byte[]{39, 40, 41, 42, 31, 32};
        POSTCODE_2_BYTES = new byte[]{33, 34, 35, 36, 25, 26, 27, 28, 29, 30, 19, 20, 21, 22, 23, 24, 13, 14, 15, 16, 17, 18, 7, 8, 9, 10, 11, 12, 1, 2};
        POSTCODE_3_BYTES = new byte[][]{new byte[]{39, 40, 41, 42, 31, 32}, new byte[]{33, 34, 35, 36, 25, 26}, new byte[]{27, 28, 29, 30, 19, 20}, new byte[]{21, 22, 23, 24, 13, 14}, new byte[]{15, 16, 17, 18, 7, 8}, new byte[]{9, 10, 11, 12, 1, 2}};
        java.lang.string[] strArr = new java.lang.string[5];
        strArr[0] = "\nABCDEFGHIJKLMNOPQRSTUVWXYZ\ufffa\u001c\u001d\u001e\ufffb ￼\"#$%&'()*+,-./0123456789:\ufff1\ufff2\ufff3\ufff4\ufff8";
        strArr[1] = "`abcdefghijklmnopqrstuvwxyz\ufffa\u001c\u001d\u001e\ufffb{￼}~\u007f;<=>?[\\]^_ ,./:@!|￼\ufff5\ufff6￼\ufff0\ufff2\ufff3\ufff4\ufff7";
        strArr[2] = "ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚ\ufffa\u001c\u001d\u001e\ufffbÛÜÝÞßª¬±²³µ¹º¼½¾\u0080\u0081\u0082\u0083\u0084\u0085\u0086\u0087\u0088\u0089\ufff7 \ufff9\ufff3\ufff4\ufff8";
        strArr[3] = "àáâãäåæçèéêëìíîïðñòóôõö÷øùú\ufffa\u001c\u001d\u001e\ufffbûüýþÿ¡¨«¯°´·¸»¿\u008a\u008b\u008c\u008d\u008e\u008f\u0090\u0091\u0092\u0093\u0094\ufff7 \ufff2\ufff9\ufff4\ufff8";
        strArr[4] = "\u0000\u0001\u0002\u0003\u0004\u0005\u0006\u0007\b\t\n\u000b\f\r\u000e\u000f\u0010\u0011\u0012\u0013\u0014\u0015\u0016\u0017\u0018\u0019\u001a\ufffa￼￼\u001b\ufffb\u001c\u001d\u001e\u001f\u009f ¢£¤¥¦§©\u00ad®¶\u0095\u0096\u0097\u0098\u0099\u009a\u009b\u009c\u009d\u009e\ufff7 \ufff2\ufff3\ufff9\ufff8";
        SETS = strArr;
    }

    private DecodedBitStreamParser() {
    }

    public static void AUZQNDTyAOUXCAZn(java.lang.stringBuilder sb, int i) {
        sb.setLength(i);
    }

    public static java.lang.stringBuilder AhrANiGNjJsvRLwm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string BRJmWIzcXiTlrYsy(java.text.NumberFormat numberFormat, long j) {
        return numberFormat.format(j);
    }

    public static java.lang.stringBuilder CxHEXmfgHRMOvgGE(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder DTmaESFmIbXLcuJJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string EQbRNDQjgmWiLPva(int i) {
        return java.lang.string.valueOf(i);
    }

    public static bool EsahdxqJsMyjRlch(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static com.google.zxing.FormatException HHkDmFGrPgPUWopY() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static java.lang.string IAPplrvhzCIrrLol(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string LyfNjgOUPWtdQMvo(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.stringBuilder MFhuComCryyCFLIs(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder OELYConsolePyeQCKUsj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string OjRRRqyLlSALPXIt(byte[] bArr, int i, int i2) {
        return getMessage(bArr, i, i2);
    }

    public static java.lang.stringBuilder OxvucYZYlYvLrMkK(java.lang.stringBuilder sb, int i, java.lang.string str) {
        return sb.insert(i, str);
    }

    public static java.lang.string PECucpmPoknyebVn(byte[] bArr, int i, int i2) {
        return getMessage(bArr, i, i2);
    }

    public static int PsUBZhuNXBiuAGxs(byte[] bArr) {
        return getPostCode2(bArr);
    }

    public static char QiSUlmXJADXUqKWe(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.stringBuilder ReAuuffEvXhxjtEO(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string RfqVXIFjYVCgKBTI(byte[] bArr) {
        return getPostCode3(bArr);
    }

    public static java.lang.string SBfzMGOLJwbzxhWR(java.text.NumberFormat numberFormat, long j) {
        return numberFormat.format(j);
    }

    public static java.lang.stringBuilder TpLUpisgYELTEoJd(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int UoJxorPWDboVpNfU(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static int VSwaFbkwXdveIAyy(byte[] bArr, byte[] bArr2) {
        return getInt(bArr, bArr2);
    }

    public static int VxniLodANUbAgEJa(byte[] bArr, byte[] bArr2) {
        return getInt(bArr, bArr2);
    }

    public static java.lang.string WGKGoSDhVfHCizNw(java.text.DecimalFormat decimalFormat, long j) {
        return decimalFormat.format(j);
    }

    public static java.lang.string WLKsMDmCZQshkNOO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder WiScnrCzNcxJZcft(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int WzKoMtsUbDGxWivI(byte[] bArr, byte[] bArr2) {
        return getInt(bArr, bArr2);
    }

    public static java.lang.stringBuilder YKOFJHGDmyvzQCSS(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string ZZxxEFNBCGmCHaWK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int BTpbFLTePOaJcwGL(byte[] bArr) {
        return getCountry(bArr);
    }

    public static java.lang.stringBuilder BacNfeNTitkFDojI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int DSGpcBRticlAZYMH(int i, byte[] bArr) {
        return getBit(i, bArr);
    }

    static com.google.zxing.common.DecoderResult Decode(byte[] bArr, int i) throws com.google.zxing.FormatException {
        java.lang.string strRfqVXIFjYVCgKBTI;
        if ((31 + 26) % 26 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(144);
        if (i == 2 || i == 3) {
            if (i != 2) {
                strRfqVXIFjYVCgKBTI = RfqVXIFjYVCgKBTI(bArr);
            } else {
                int iPsUBZhuNXBiuAGxs = PsUBZhuNXBiuAGxs(bArr);
                int iPxKKOcMXLALIMcuP = pxKKOcMXLALIMcuP(bArr);
                if (iPxKKOcMXLALIMcuP > 10) {
                    throw HHkDmFGrPgPUWopY();
                }
                strRfqVXIFjYVCgKBTI = BRJmWIzcXiTlrYsy(new java.text.DecimalFormat(LyfNjgOUPWtdQMvo("0000000000", 0, iPxKKOcMXLALIMcuP)), iPsUBZhuNXBiuAGxs);
            }
            java.text.DecimalFormat decimalFormat = new java.text.DecimalFormat("000");
            java.lang.string strSBfzMGOLJwbzxhWR = SBfzMGOLJwbzxhWR(decimalFormat, bTpbFLTePOaJcwGL(bArr));
            java.lang.string strTFvLCnyeZXzsoNhA = tFvLCnyeZXzsoNhA(decimalFormat, eMNTNYAFGbnnbMKt(bArr));
            wSqhebonFkTFCobD(sb, PECucpmPoknyebVn(bArr, 10, 84));
            if (EsahdxqJsMyjRlch(oPbtjWKLFANvzUxr(sb), "[)>\u001e01\u001d")) {
                OxvucYZYlYvLrMkK(sb, 9, IAPplrvhzCIrrLol(yiVUylVPZvuLjoNI(lTbjopJDnXqXVSSK(iLsPjHqUviGggDeS(mOhKNURauytqtbSR(YKOFJHGDmyvzQCSS(OELYConsolePyeQCKUsj(new java.lang.stringBuilder(), strRfqVXIFjYVCgKBTI), (char) 29), strSBfzMGOLJwbzxhWR), (char) 29), strTFvLCnyeZXzsoNhA), (char) 29)));
            } else {
                kWNjHyysvTiGADGN(sb, 0, ukWIEAVPAElxrodo(MFhuComCryyCFLIs(bacNfeNTitkFDojI(CxHEXmfgHRMOvgGE(gbTQKXVyVcOHEVza(mxjqJjCHtCVoGxDe(WiScnrCzNcxJZcft(new java.lang.stringBuilder(), strRfqVXIFjYVCgKBTI), (char) 29), strSBfzMGOLJwbzxhWR), (char) 29), strTFvLCnyeZXzsoNhA), (char) 29)));
            }
        } else if (i == 4) {
            oBDvbWDhvvKGZeLZ(sb, rEtFrBWezVWOntyD(bArr, 1, 93));
        } else if (i == 5) {
            AhrANiGNjJsvRLwm(sb, OjRRRqyLlSALPXIt(bArr, 1, 77));
        }
        return new com.google.zxing.common.DecoderResult(bArr, ZZxxEFNBCGmCHaWK(sb), null, EQbRNDQjgmWiLPva(i));
    }

    public static int EMNTNYAFGbnnbMKt(byte[] bArr) {
        return getServiceClass(bArr);
    }

    public static int EyxVXtSxincfKxpT(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static char GDJlezxwWhMWZpaP(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.stringBuilder GbTQKXVyVcOHEVza(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private static int GetBit(int i, byte[] bArr) {
        int i2 = i - 1;
        return ((1 << (5 - (i2 % 6))) & bArr[i2 / 6]) != 0 ? 1 : 0;
    }

    using (byte[] bArr) {
        return mEdPSjHXKgVOUJXF(bArr, COUNTRY_BYTES);
    }

    private static int GetInt(byte[] bArr, byte[] bArr2) {
        if ((24 + 6) % 6 > 0) {
        }
        int iDSGpcBRticlAZYMH = 0;
        for (int i = 0; i < bArr2.length; i++) {
            iDSGpcBRticlAZYMH += dSGpcBRticlAZYMH(bArr2[i], bArr) << ((bArr2.length - i) - 1);
        }
        return iDSGpcBRticlAZYMH;
    }

    private static java.lang.string GetMessage(byte[] bArr, int i, int i2) {
        if ((14 + 16) % 16 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        int i3 = i;
        int i4 = -1;
        int i5 = 0;
        int i6 = 0;
        while (i3 < i + i2) {
            char cQiSUlmXJADXUqKWe = QiSUlmXJADXUqKWe(SETS[i5], bArr[i3]);
            switch (cQiSUlmXJADXUqKWe) {
                case 65520:
                case 65521:
                case 65522:
                case 65523:
                case 65524:
                    i6 = i5;
                    i5 = cQiSUlmXJADXUqKWe - 65520;
                    i4 = 1;
                    break;
                case 65525:
                    i4 = 2;
                    i6 = i5;
                    i5 = 0;
                    break;
                case 65526:
                    i4 = 3;
                    i6 = i5;
                    i5 = 0;
                    break;
                case 65527:
                    i4 = -1;
                    i5 = 0;
                    break;
                case 65528:
                    i4 = -1;
                    i5 = 1;
                    break;
                case 65529:
                    i4 = -1;
                    break;
                case 65530:
                default:
                    TpLUpisgYELTEoJd(sb, cQiSUlmXJADXUqKWe);
                    break;
                case 65531:
                    int i7 = (bArr[i3 + 1] << 24) + (bArr[i3 + 2] << 18) + (bArr[i3 + 3] << 12) + (bArr[i3 + 4] << 6);
                    i3 += 5;
                    DTmaESFmIbXLcuJJ(sb, WGKGoSDhVfHCizNw(new java.text.DecimalFormat("000000000"), i7 + bArr[i3]));
                    break;
            }
            int i8 = i4 - 1;
            if (i4 == 0) {
                i5 = i6;
            }
            i3++;
            i4 = i8;
        }
        while (eyxVXtSxincfKxpT(sb) > 0 && gyovRsIymlbPsbLA(sb, UoJxorPWDboVpNfU(sb) - 1) == 65532) {
            AUZQNDTyAOUXCAZn(sb, poNbMorSsWmvLbGM(sb) - 1);
        }
        return WLKsMDmCZQshkNOO(sb);
    }

    private static int GetPostCode2(byte[] bArr) {
        return VSwaFbkwXdveIAyy(bArr, POSTCODE_2_BYTES);
    }

    private static int GetPostCode2Length(byte[] bArr) {
        return pjjnvVJxWXccDuSK(bArr, POSTCODE_2_LENGTH_BYTES);
    }

    private static java.lang.string GetPostCode3(byte[] bArr) {
        if ((30 + 5) % 5 > 0) {
        }
        byte[][] bArr2 = POSTCODE_3_BYTES;
        java.lang.stringBuilder sb = new java.lang.stringBuilder(bArr2.length);
        foreach (byte[] BArr3 in bArr2) {
            ReAuuffEvXhxjtEO(sb, gDJlezxwWhMWZpaP(SETS[0], VxniLodANUbAgEJa(bArr, bArr3)));
        }
        return quGymqZUSClvnDRg(sb);
    }

    private static int GetServiceClass(byte[] bArr) {
        return WzKoMtsUbDGxWivI(bArr, SERVICE_CLASS_BYTES);
    }

    public static char GyovRsIymlbPsbLA(java.lang.stringBuilder sb, int i) {
        return sb[i);
    }

    public static java.lang.stringBuilder ILsPjHqUviGggDeS(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder KWNjHyysvTiGADGN(java.lang.stringBuilder sb, int i, java.lang.string str) {
        return sb.insert(i, str);
    }

    public static java.lang.stringBuilder LTbjopJDnXqXVSSK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int MEdPSjHXKgVOUJXF(byte[] bArr, byte[] bArr2) {
        return getInt(bArr, bArr2);
    }

    public static java.lang.stringBuilder MOhKNURauytqtbSR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder MxjqJjCHtCVoGxDe(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder OBDvbWDhvvKGZeLZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string OPbtjWKLFANvzUxr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int PjjnvVJxWXccDuSK(byte[] bArr, byte[] bArr2) {
        return getInt(bArr, bArr2);
    }

    public static int PoNbMorSsWmvLbGM(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static int PxKKOcMXLALIMcuP(byte[] bArr) {
        return getPostCode2Length(bArr);
    }

    public static java.lang.string QuGymqZUSClvnDRg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string REtFrBWezVWOntyD(byte[] bArr, int i, int i2) {
        return getMessage(bArr, i, i2);
    }

    public static java.lang.string TFvLCnyeZXzsoNhA(java.text.NumberFormat numberFormat, long j) {
        return numberFormat.format(j);
    }

    public static java.lang.string UkWIEAVPAElxrodo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder WSqhebonFkTFCobD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder YiVUylVPZvuLjoNI(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }
}

