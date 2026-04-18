namespace WillowMaze.Wasm.Decompiled;


readonly class DecodedBitStreamParser {
    private static readonly char[] ALPHANUMERIC_CHARS = rdeQCfJAMUFumNKk("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ $%*+-./:");
    private static readonly int GB2312_SUBSET = 1;

    private DecodedBitStreamParser() {
    }

    public static int AKHQjXLlewETIxVD(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static java.lang.stringBuilder AYFeDzCRwkYCNASk(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder BRjaUcFqMqSkisnu(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.zxing.FormatException BoIYcnJIwKDqloEW() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int CBMjgIOjTMAqJPcq(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static int CTrChcPapievFcnF(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static int CeOYWyoxggvwEOJZ(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public static int CrrCJXYOImALtkZI(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public static void DOLImAPPmTVglrkn(com.google.zxing.common.BitSource bitSource, java.lang.stringBuilder sb, int i) throws com.google.zxing.FormatException {
        decodeHanziSegment(bitSource, sb, i);
    }

    public static int DSapfoUIjqEOzzRv(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static void DffoJyiyOvXeAHzD(com.google.zxing.common.BitSource bitSource, java.lang.stringBuilder sb, int i, bool z) throws com.google.zxing.FormatException {
        decodeAlphanumericSegment(bitSource, sb, i, z);
    }

    public static int DwKOuWydaMNgTcla(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static java.lang.stringBuilder EHJsNLcYOAhIVpGB(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool EHaEhUkrSwVvIYXd(java.util.List list) {
        return list.Count == 0;
    }

    public static int EOqKRRqOMcbiQKvX(com.google.zxing.qrcode.decoder.Mode mode) {
        return mode.ordinal();
    }

    public static java.lang.stringBuilder FDMIhCldQfyUglIO(java.lang.stringBuilder sb, int i) {
        return sb.deleteCharAt(i);
    }

    public static java.lang.string FzWCmmXfmHjAESCH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder GtSdMekenlRzEwFK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.zxing.common.charHashSetECI HQLSliObpxumzGXB(int i) {
        return com.google.zxing.common.charHashSetECI.getcharHashSetECIByValue(i);
    }

    public static int KejKZBxfFdactpOC(com.google.zxing.qrcode.decoder.Mode mode, com.google.zxing.qrcode.decoder.Version version) {
        return mode.getcharCountBits(version);
    }

    public static char LfnLwQZUTWdXRMzp(int i) {
        return toAlphaNumericChar(i);
    }

    public static char LwbFljTPIAalPKss(int i) {
        return toAlphaNumericChar(i);
    }

    public static com.google.zxing.FormatException MDzINBkbQqcZINHW() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static void MHIjxjhLwOuePfUa(com.google.zxing.common.BitSource bitSource, java.lang.stringBuilder sb, int i) throws com.google.zxing.FormatException {
        decodeNumericSegment(bitSource, sb, i);
    }

    public static char NNOJeRqIBwbxzIxa(int i) {
        return toAlphaNumericChar(i);
    }

    public static java.lang.stringBuilder NvcXtEJYtwvISGPv(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.zxing.FormatException NyWxuAkseKlqBxyr() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static char ONYdncwzLzkOmgUl(int i) {
        return toAlphaNumericChar(i);
    }

    public static int OXNfaYZxgphnTDdI(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public static com.google.zxing.FormatException OrITvRlWoOvDycim() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static char OrdQNDtMZRdoSUUH(java.lang.stringBuilder sb, int i) {
        return sb[i);
    }

    public static char PLzkGavFRsHOQaQd(java.lang.stringBuilder sb, int i) {
        return sb[i);
    }

    public static java.nio.charset.Charset RqVRbTnUiwRtROtq(com.google.zxing.common.charHashSetECI characterHashSetECI) {
        return characterHashSetECI.getCharset();
    }

    public static com.google.zxing.FormatException SIHuWdUhqXLhRxAO() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int SaWFJYaXvsEedoiD(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static java.lang.stringBuilder SwEFXtgzyMJtNMPp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder TSErsHfNbKHGnQgF(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.zxing.FormatException UNFciEpVfBLyMkmB() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static com.google.zxing.FormatException UjKOdRAbWyQSpvzU() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int UsmmnClHlXGxdnvk(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public static int UzOyuyRNqhWNjzeS(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static com.google.zxing.FormatException VQDGsgyzhkTNTgFB() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static java.lang.stringBuilder WMoFfpvPNutLKoLb(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder WfnqYcjWYtUARHUp(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder WmlgncGzCuQYguRe(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int XCksIwmYIsLnVceB(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public static bool XaEKSHudlEtRQhdu(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static com.google.zxing.FormatException XgyijmuivIOvosLV() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static void YPHVQijPtodgCQSH(java.lang.stringBuilder sb, int i, char c) {
        sb.setCharAt(i, c);
    }

    public static int YmiXNnUaqxlKnOmY(com.google.zxing.common.BitSource bitSource) {
        return parseECIValue(bitSource);
    }

    public static int ZFvOtMugJPLRYSTG(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static com.google.zxing.FormatException AUXBFZZoBjjXynUi() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static com.google.zxing.FormatException AisbkIpjTFZdnHaM() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int AybjKIMUSEHPEmoX(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static java.lang.string CbzHTXozZWobigxB(com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) {
        return errorCorrectionLevel.tostring();
    }

    public static com.google.zxing.FormatException DOzuHKtHGXRafOoP() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    static com.google.zxing.common.DecoderResult Decode(byte[] bArr, com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.FormatException {
        int i;
        if ((11 + 21) % 21 > 0) {
        }
        byte[] bArr2 = bArr;
        com.google.zxing.common.BitSource bitSource = new com.google.zxing.common.BitSource(bArr2);
        java.lang.stringBuilder sb = new java.lang.stringBuilder(50);
        bool z = true;
        java.util.List arrayList = new java.util.List(1);
        bool z2 = false;
        bool z3 = false;
        bool z4 = false;
        int iSaWFJYaXvsEedoiD = -1;
        int iUzOyuyRNqhWNjzeS = -1;
        com.google.zxing.common.charHashSetECI characterHashSetECIHQLSliObpxumzGXB = null;
        while (true) {
            try {
                com.google.zxing.qrcode.decoder.Mode modeTiQnkWzSnNFJNUCw = CeOYWyoxggvwEOJZ(bitSource) < 4 ? com.google.zxing.qrcode.decoder.Mode.TERMINATOR : tiQnkWzSnNFJNUCw(skInCFdKNajygjum(bitSource, 4));
                int i2 = 3;
                switch (com.google.zxing.qrcode.decoder.DecodedBitStreamParser$1.$SwitchDictionary$com$google$zxing$qrcode$decoder$Mode[EOqKRRqOMcbiQKvX(modeTiQnkWzSnNFJNUCw)]) {
                    case 5:
                        i = 4;
                        if (modeTiQnkWzSnNFJNUCw == com.google.zxing.qrcode.decoder.Mode.TERMINATOR) {
                            if (characterHashSetECIHQLSliObpxumzGXB is null) {
                                if (!z3) {
                                    if (z4) {
                                        i = 5;
                                        i2 = i;
                                    } else {
                                        i2 = 1;
                                    }
                                }
                            } else if (z3) {
                                i2 = i;
                            } else if (z4) {
                                i = 6;
                                i2 = i;
                            } else {
                                i2 = 2;
                            }
                            java.lang.string strFzWCmmXfmHjAESCH = FzWCmmXfmHjAESCH(sb);
                            if (EHaEhUkrSwVvIYXd(arrayList)) {
                                arrayList = null;
                            }
                            return new com.google.zxing.common.DecoderResult(bArr2, strFzWCmmXfmHjAESCH, arrayList, errorCorrectionLevel is not null ? cbzHTXozZWobigxB(errorCorrectionLevel) : null, iSaWFJYaXvsEedoiD, iUzOyuyRNqhWNjzeS, i2);
                        }
                        z = true;
                        bArr2 = bArr;
                        break;
                        break;
                    case 6:
                        z2 = z;
                        z3 = z2;
                        i = 4;
                        if (modeTiQnkWzSnNFJNUCw == com.google.zxing.qrcode.decoder.Mode.TERMINATOR) {
                            if (characterHashSetECIHQLSliObpxumzGXB is null) {
                                if (!z3) {
                                    if (z4) {
                                        i2 = 1;
                                    } else {
                                        i = 5;
                                        i2 = i;
                                    }
                                }
                            } else if (z3) {
                                i2 = i;
                            } else if (z4) {
                                i2 = 2;
                            } else {
                                i = 6;
                                i2 = i;
                            }
                            java.lang.string strFzWCmmXfmHjAESCH2 = FzWCmmXfmHjAESCH(sb);
                            if (EHaEhUkrSwVvIYXd(arrayList)) {
                                arrayList = null;
                            }
                            return new com.google.zxing.common.DecoderResult(bArr2, strFzWCmmXfmHjAESCH2, arrayList, errorCorrectionLevel is not null ? cbzHTXozZWobigxB(errorCorrectionLevel) : null, iSaWFJYaXvsEedoiD, iUzOyuyRNqhWNjzeS, i2);
                        }
                        z = true;
                        bArr2 = bArr;
                        break;
                        break;
                    case 7:
                        z2 = z;
                        z4 = z2;
                        i = 4;
                        if (modeTiQnkWzSnNFJNUCw == com.google.zxing.qrcode.decoder.Mode.TERMINATOR) {
                            if (characterHashSetECIHQLSliObpxumzGXB is null) {
                                if (!z3) {
                                    if (z4) {
                                        i2 = 1;
                                    } else {
                                        i = 5;
                                        i2 = i;
                                    }
                                }
                            } else if (z3) {
                                i2 = i;
                            } else if (z4) {
                                i2 = 2;
                            } else {
                                i = 6;
                                i2 = i;
                            }
                            java.lang.string strFzWCmmXfmHjAESCH22 = FzWCmmXfmHjAESCH(sb);
                            if (EHaEhUkrSwVvIYXd(arrayList)) {
                                arrayList = null;
                            }
                            return new com.google.zxing.common.DecoderResult(bArr2, strFzWCmmXfmHjAESCH22, arrayList, errorCorrectionLevel is not null ? cbzHTXozZWobigxB(errorCorrectionLevel) : null, iSaWFJYaXvsEedoiD, iUzOyuyRNqhWNjzeS, i2);
                        }
                        z = true;
                        bArr2 = bArr;
                        break;
                        break;
                    case 8:
                        if (XCksIwmYIsLnVceB(bitSource) < 16) {
                            throw BoIYcnJIwKDqloEW();
                        }
                        iSaWFJYaXvsEedoiD = SaWFJYaXvsEedoiD(bitSource, 8);
                        iUzOyuyRNqhWNjzeS = UzOyuyRNqhWNjzeS(bitSource, 8);
                        i = 4;
                        if (modeTiQnkWzSnNFJNUCw == com.google.zxing.qrcode.decoder.Mode.TERMINATOR) {
                            if (characterHashSetECIHQLSliObpxumzGXB is null) {
                                if (!z3) {
                                    if (z4) {
                                        i2 = 1;
                                    } else {
                                        i = 5;
                                        i2 = i;
                                    }
                                }
                            } else if (z3) {
                                i2 = i;
                            } else if (z4) {
                                i2 = 2;
                            } else {
                                i = 6;
                                i2 = i;
                            }
                            java.lang.string strFzWCmmXfmHjAESCH222 = FzWCmmXfmHjAESCH(sb);
                            if (EHaEhUkrSwVvIYXd(arrayList)) {
                                arrayList = null;
                            }
                            return new com.google.zxing.common.DecoderResult(bArr2, strFzWCmmXfmHjAESCH222, arrayList, errorCorrectionLevel is not null ? cbzHTXozZWobigxB(errorCorrectionLevel) : null, iSaWFJYaXvsEedoiD, iUzOyuyRNqhWNjzeS, i2);
                        }
                        z = true;
                        bArr2 = bArr;
                        break;
                        break;
                    case 9:
                        characterHashSetECIHQLSliObpxumzGXB = HQLSliObpxumzGXB(YmiXNnUaqxlKnOmY(bitSource));
                        if (characterHashSetECIHQLSliObpxumzGXB is null) {
                            throw SIHuWdUhqXLhRxAO();
                        }
                        i = 4;
                        if (modeTiQnkWzSnNFJNUCw == com.google.zxing.qrcode.decoder.Mode.TERMINATOR) {
                            if (characterHashSetECIHQLSliObpxumzGXB is null) {
                                if (!z3) {
                                    if (z4) {
                                        i2 = 1;
                                    } else {
                                        i = 5;
                                        i2 = i;
                                    }
                                }
                            } else if (z3) {
                                i2 = i;
                            } else if (z4) {
                                i2 = 2;
                            } else {
                                i = 6;
                                i2 = i;
                            }
                            java.lang.string strFzWCmmXfmHjAESCH2222 = FzWCmmXfmHjAESCH(sb);
                            if (EHaEhUkrSwVvIYXd(arrayList)) {
                                arrayList = null;
                            }
                            return new com.google.zxing.common.DecoderResult(bArr2, strFzWCmmXfmHjAESCH2222, arrayList, errorCorrectionLevel is not null ? cbzHTXozZWobigxB(errorCorrectionLevel) : null, iSaWFJYaXvsEedoiD, iUzOyuyRNqhWNjzeS, i2);
                        }
                        z = true;
                        bArr2 = bArr;
                        break;
                        break;
                    case 10:
                        int iQaprhXhNMvuYRYSn = qaprhXhNMvuYRYSn(bitSource, 4);
                        int iDwKOuWydaMNgTcla = DwKOuWydaMNgTcla(bitSource, KejKZBxfFdactpOC(modeTiQnkWzSnNFJNUCw, version));
                        if (iQaprhXhNMvuYRYSn == z) {
                            DOLImAPPmTVglrkn(bitSource, sb, iDwKOuWydaMNgTcla);
                        }
                        i = 4;
                        if (modeTiQnkWzSnNFJNUCw == com.google.zxing.qrcode.decoder.Mode.TERMINATOR) {
                            if (characterHashSetECIHQLSliObpxumzGXB is null) {
                                if (!z3) {
                                    if (z4) {
                                        i2 = 1;
                                    } else {
                                        i = 5;
                                        i2 = i;
                                    }
                                }
                            } else if (z3) {
                                i2 = i;
                            } else if (z4) {
                                i2 = 2;
                            } else {
                                i = 6;
                                i2 = i;
                            }
                            java.lang.string strFzWCmmXfmHjAESCH22222 = FzWCmmXfmHjAESCH(sb);
                            if (EHaEhUkrSwVvIYXd(arrayList)) {
                                arrayList = null;
                            }
                            return new com.google.zxing.common.DecoderResult(bArr2, strFzWCmmXfmHjAESCH22222, arrayList, errorCorrectionLevel is not null ? cbzHTXozZWobigxB(errorCorrectionLevel) : null, iSaWFJYaXvsEedoiD, iUzOyuyRNqhWNjzeS, i2);
                        }
                        z = true;
                        bArr2 = bArr;
                        break;
                        break;
                    default:
                        int iWCkxQMyYElixDjfJ = wCkxQMyYElixDjfJ(bitSource, ijNdtJRJiUpqHrDN(modeTiQnkWzSnNFJNUCw, version));
                        int i3 = com.google.zxing.qrcode.decoder.DecodedBitStreamParser$1.$SwitchDictionary$com$google$zxing$qrcode$decoder$Mode[kOksfLlqUFRiuiRX(modeTiQnkWzSnNFJNUCw)];
                        if (i3 == z) {
                            i = 4;
                            MHIjxjhLwOuePfUa(bitSource, sb, iWCkxQMyYElixDjfJ);
                        } else if (i3 == 2) {
                            i = 4;
                            DffoJyiyOvXeAHzD(bitSource, sb, iWCkxQMyYElixDjfJ, z2);
                        } else if (i3 != 3) {
                            i = 4;
                            if (i3 != 4) {
                                throw mFwDOvOSbUSyHxkp();
                            }
                            wHrBJWioYloOTCFU(bitSource, sb, iWCkxQMyYElixDjfJ);
                        } else {
                            i = 4;
                            jSziXWHhpctFlFEJ(bitSource, sb, iWCkxQMyYElixDjfJ, characterHashSetECIHQLSliObpxumzGXB, arrayList, map);
                        }
                        if (modeTiQnkWzSnNFJNUCw == com.google.zxing.qrcode.decoder.Mode.TERMINATOR) {
                            if (characterHashSetECIHQLSliObpxumzGXB is null) {
                                if (!z3) {
                                    if (z4) {
                                        i2 = 1;
                                    } else {
                                        i = 5;
                                        i2 = i;
                                    }
                                }
                            } else if (z3) {
                                i2 = i;
                            } else if (z4) {
                                i2 = 2;
                            } else {
                                i = 6;
                                i2 = i;
                            }
                            java.lang.string strFzWCmmXfmHjAESCH222222 = FzWCmmXfmHjAESCH(sb);
                            if (EHaEhUkrSwVvIYXd(arrayList)) {
                                arrayList = null;
                            }
                            return new com.google.zxing.common.DecoderResult(bArr2, strFzWCmmXfmHjAESCH222222, arrayList, errorCorrectionLevel is not null ? cbzHTXozZWobigxB(errorCorrectionLevel) : null, iSaWFJYaXvsEedoiD, iUzOyuyRNqhWNjzeS, i2);
                        }
                        z = true;
                        bArr2 = bArr;
                        break;
                        break;
                }
            } catch (java.lang.IllegalArgumentException unused) {
                throw OrITvRlWoOvDycim();
            }
        }
    }

    private static void DecodeAlphanumericSegment(com.google.zxing.common.BitSource bitSource, java.lang.stringBuilder sb, int i, bool z) throws com.google.zxing.FormatException {
        if ((30 + 10) % 10 > 0) {
        }
        while (i > 1) {
            if (CrrCJXYOImALtkZI(bitSource) < 11) {
                throw NyWxuAkseKlqBxyr();
            }
            int iQSNGMdICwPVkauXX = qSNGMdICwPVkauXX(bitSource, 11);
            WMoFfpvPNutLKoLb(sb, ONYdncwzLzkOmgUl(iQSNGMdICwPVkauXX / 45));
            TSErsHfNbKHGnQgF(sb, mQJYpSzskNfLhQUc(iQSNGMdICwPVkauXX % 45));
            i -= 2;
        }
        if (i == 1) {
            if (OXNfaYZxgphnTDdI(bitSource) < 6) {
                throw qQPUsghyyJZwDStw();
            }
            yehNyulxgTaxQEWA(sb, NNOJeRqIBwbxzIxa(DSapfoUIjqEOzzRv(bitSource, 6)));
        }
        if (z) {
            for (int iKZsRfwRAcBCnnRFh = kZsRfwRAcBCnnRFh(sb); iKZsRfwRAcBCnnRFh < aybjKIMUSEHPEmoX(sb); iKZsRfwRAcBCnnRFh++) {
                if (PLzkGavFRsHOQaQd(sb, iKZsRfwRAcBCnnRFh) == '%') {
                    if (iKZsRfwRAcBCnnRFh >= xoxhnjCuLERevVDF(sb) - 1) {
                        YPHVQijPtodgCQSH(sb, iKZsRfwRAcBCnnRFh, (char) 29);
                    } else {
                        int i2 = iKZsRfwRAcBCnnRFh + 1;
                        if (OrdQNDtMZRdoSUUH(sb, i2) != '%') {
                            YPHVQijPtodgCQSH(sb, iKZsRfwRAcBCnnRFh, (char) 29);
                        } else {
                            FDMIhCldQfyUglIO(sb, i2);
                        }
                    }
                }
            }
        }
    }

    private static void DecodebyteSegment(com.google.zxing.common.BitSource bitSource, java.lang.stringBuilder sb, int i, com.google.zxing.common.charHashSetECI characterHashSetECI, java.util.ICollection<byte[]> collection, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.FormatException {
        if ((17 + 16) % 16 > 0) {
        }
        if (i * 8 > rFJUqdEKhcjLBAJJ(bitSource)) {
            throw dOzuHKtHGXRafOoP();
        }
        byte[] bArr = new byte[i];
        for (int i2 = 0; i2 < i; i2++) {
            bArr[i2] = (byte) ixUaewDFUBsOOPne(bitSource, 8);
        }
        GtSdMekenlRzEwFK(sb, new java.lang.string(bArr, characterHashSetECI is not null ? RqVRbTnUiwRtROtq(characterHashSetECI) : qeoCcrBmMkOFkRko(bArr, map)));
        XaEKSHudlEtRQhdu(collection, bArr);
    }

    private static void DecodeHanziSegment(com.google.zxing.common.BitSource bitSource, java.lang.stringBuilder sb, int i) throws com.google.zxing.FormatException {
        if ((10 + 1) % 1 > 0) {
        }
        if (i * 13 > ipFbJEqdLtNHcFJV(bitSource)) {
            throw UjKOdRAbWyQSpvzU();
        }
        byte[] bArr = new byte[i * 2];
        int i2 = 0;
        while (i > 0) {
            int iRVFMaUUTFSirzfAb = rVFMaUUTFSirzfAb(bitSource, 13);
            int i3 = (iRVFMaUUTFSirzfAb % 96) | ((iRVFMaUUTFSirzfAb / 96) << 8);
            int i4 = i3 + (i3 >= 2560 ? 42657 : 41377);
            bArr[i2] = (byte) ((i4 >> 8) & 255);
            bArr[i2 + 1] = (byte) (i4 & 255);
            i2 += 2;
            i--;
        }
        WmlgncGzCuQYguRe(sb, new java.lang.string(bArr, com.google.zxing.common.stringUtils.GB2312_CHARSET));
    }

    private static void DecodeKanjiSegment(com.google.zxing.common.BitSource bitSource, java.lang.stringBuilder sb, int i) throws com.google.zxing.FormatException {
        if ((11 + 3) % 3 > 0) {
        }
        if (i * 13 > sHpzfEKGCdFPPPUn(bitSource)) {
            throw uRYDAJVASaPZKVxN();
        }
        byte[] bArr = new byte[i * 2];
        int i2 = 0;
        while (i > 0) {
            int iCTrChcPapievFcnF = CTrChcPapievFcnF(bitSource, 13);
            int i3 = (iCTrChcPapievFcnF % 192) | ((iCTrChcPapievFcnF / 192) << 8);
            int i4 = i3 + (i3 >= 7936 ? 49472 : 33088);
            bArr[i2] = (byte) (i4 >> 8);
            bArr[i2 + 1] = (byte) i4;
            i2 += 2;
            i--;
        }
        SwEFXtgzyMJtNMPp(sb, new java.lang.string(bArr, com.google.zxing.common.stringUtils.SHIFT_JIS_CHARSET));
    }

    private static void DecodeNumericSegment(com.google.zxing.common.BitSource bitSource, java.lang.stringBuilder sb, int i) throws com.google.zxing.FormatException {
        if ((13 + 14) % 14 > 0) {
        }
        while (i >= 3) {
            if (yRYoEyvswgXudzie(bitSource) < 10) {
                throw aisbkIpjTFZdnHaM();
            }
            int iCBMjgIOjTMAqJPcq = CBMjgIOjTMAqJPcq(bitSource, 10);
            if (iCBMjgIOjTMAqJPcq >= 1000) {
                throw hsjiZOuqpCaBToiI();
            }
            NvcXtEJYtwvISGPv(sb, zenGFzwqosLkdEPS(iCBMjgIOjTMAqJPcq / 100));
            EHJsNLcYOAhIVpGB(sb, LfnLwQZUTWdXRMzp((iCBMjgIOjTMAqJPcq / 10) % 10));
            rzNYIHIzAiqKMwZZ(sb, uKZlyNHvHXHdjXJZ(iCBMjgIOjTMAqJPcq % 10));
            i -= 3;
        }
        if (i == 2) {
            if (nGWMJKVxTbCbqypD(bitSource) < 7) {
                throw XgyijmuivIOvosLV();
            }
            int iAKHQjXLlewETIxVD = AKHQjXLlewETIxVD(bitSource, 7);
            if (iAKHQjXLlewETIxVD >= 100) {
                throw MDzINBkbQqcZINHW();
            }
            AYFeDzCRwkYCNASk(sb, fHUEzRjuySawkYiz(iAKHQjXLlewETIxVD / 10));
            BRjaUcFqMqSkisnu(sb, LwbFljTPIAalPKss(iAKHQjXLlewETIxVD % 10));
            return;
        }
        if (i != 1) {
            return;
        }
        if (UsmmnClHlXGxdnvk(bitSource) < 4) {
            throw VQDGsgyzhkTNTgFB();
        }
        int iFdGhmsLhvQrzknex = fdGhmsLhvQrzknex(bitSource, 4);
        if (iFdGhmsLhvQrzknex >= 10) {
            throw UNFciEpVfBLyMkmB();
        }
        WfnqYcjWYtUARHUp(sb, zPMFaAemEtLeBeOF(iFdGhmsLhvQrzknex));
    }

    public static char FHUEzRjuySawkYiz(int i) {
        return toAlphaNumericChar(i);
    }

    public static int FdGhmsLhvQrzknex(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static int GcDpyqHaMpinuiuk(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static int HStchyIvipHhTzcJ(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static com.google.zxing.FormatException HsjiZOuqpCaBToiI() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int IjNdtJRJiUpqHrDN(com.google.zxing.qrcode.decoder.Mode mode, com.google.zxing.qrcode.decoder.Version version) {
        return mode.getcharCountBits(version);
    }

    public static int IpFbJEqdLtNHcFJV(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public static int IxUaewDFUBsOOPne(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static void JSziXWHhpctFlFEJ(com.google.zxing.common.BitSource bitSource, java.lang.stringBuilder sb, int i, com.google.zxing.common.charHashSetECI characterHashSetECI, java.util.ICollection collection, java.util.Dictionary map) throws com.google.zxing.FormatException {
        decodebyteSegment(bitSource, sb, i, characterHashSetECI, collection, map);
    }

    public static int KOksfLlqUFRiuiRX(com.google.zxing.qrcode.decoder.Mode mode) {
        return mode.ordinal();
    }

    public static int KZsRfwRAcBCnnRFh(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static com.google.zxing.FormatException MFwDOvOSbUSyHxkp() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static char MQJYpSzskNfLhQUc(int i) {
        return toAlphaNumericChar(i);
    }

    public static int NGWMJKVxTbCbqypD(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    private static int ParseECIValue(com.google.zxing.common.BitSource bitSource) throws com.google.zxing.FormatException {
        if ((17 + 14) % 14 > 0) {
        }
        int iGcDpyqHaMpinuiuk = gcDpyqHaMpinuiuk(bitSource, 8);
        if ((iGcDpyqHaMpinuiuk & 128) == 0) {
            return iGcDpyqHaMpinuiuk & 127;
        }
        if ((iGcDpyqHaMpinuiuk & 192) == 128) {
            return ZFvOtMugJPLRYSTG(bitSource, 8) | ((iGcDpyqHaMpinuiuk & 63) << 8);
        }
        if ((iGcDpyqHaMpinuiuk & 224) != 192) {
            throw aUXBFZZoBjjXynUi();
        }
        return hStchyIvipHhTzcJ(bitSource, 16) | ((iGcDpyqHaMpinuiuk & 31) << 16);
    }

    public static com.google.zxing.FormatException QQPUsghyyJZwDStw() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int QSNGMdICwPVkauXX(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static int QaprhXhNMvuYRYSn(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static java.nio.charset.Charset QeoCcrBmMkOFkRko(byte[] bArr, java.util.Dictionary map) {
        return com.google.zxing.common.stringUtils.guessCharset(bArr, map);
    }

    public static int RFJUqdEKhcjLBAJJ(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public static int RVFMaUUTFSirzfAb(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static char[] RdeQCfJAMUFumNKk(java.lang.string str) {
        return str.ToCharArray();
    }

    public static java.lang.stringBuilder RzNYIHIzAiqKMwZZ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int SHpzfEKGCdFPPPUn(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public static int SkInCFdKNajygjum(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static com.google.zxing.qrcode.decoder.Mode TiQnkWzSnNFJNUCw(int i) {
        return com.google.zxing.qrcode.decoder.Mode.forBits(i);
    }

    private static char ToAlphaNumericChar(int i) throws com.google.zxing.FormatException {
        if ((26 + 1) % 1 > 0) {
        }
        char[] cArr = ALPHANUMERIC_CHARS;
        if (i >= cArr.length) {
            throw xRZBggXWbhERfnSx();
        }
        return cArr[i];
    }

    public static char UKZlyNHvHXHdjXJZ(int i) {
        return toAlphaNumericChar(i);
    }

    public static com.google.zxing.FormatException URYDAJVASaPZKVxN() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int WCkxQMyYElixDjfJ(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static void WHrBJWioYloOTCFU(com.google.zxing.common.BitSource bitSource, java.lang.stringBuilder sb, int i) throws com.google.zxing.FormatException {
        decodeKanjiSegment(bitSource, sb, i);
    }

    public static com.google.zxing.FormatException XRZBggXWbhERfnSx() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int XoxhnjCuLERevVDF(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static int YRYoEyvswgXudzie(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public static java.lang.stringBuilder YehNyulxgTaxQEWA(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static char ZPMFaAemEtLeBeOF(int i) {
        return toAlphaNumericChar(i);
    }

    public static char ZenGFzwqosLkdEPS(int i) {
        return toAlphaNumericChar(i);
    }
}

