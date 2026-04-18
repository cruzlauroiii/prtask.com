namespace WillowMaze.Wasm.Decompiled;


public class Code93Writer : com.google.zxing.oned.OneDimensionalCodeWriter {
    public static java.lang.stringBuilder AqbnSmUxrtpKmnOO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string ElQSbuWCnAzxzCup(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int FJptanaUjIoRsAFP(bool[] zArr, int i, int i2) {
        return appendRegex(zArr, i, i2);
    }

    public static java.lang.stringBuilder FLyHsZRvUrwKGfTk(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static char HTARtVxCLUeQFlOG(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.string IBPQJLsFToEbDhrW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int IMZbCtOwesfpVlaE(java.lang.string str) {
        return str.Length;
    }

    public static char IfHWLAktSkpjFeTk(java.lang.string str, int i) {
        return str[i);
    }

    public static int IvRCZcOpkbTJTVsA(bool[] zArr, int i, int i2) {
        return appendRegex(zArr, i, i2);
    }

    public static java.lang.stringBuilder LaczuVqrDkpzQlcO(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder LycCYHrkClGOZhaz(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder MlKEYaPmhXKEqZEH(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder NOiOdFrgyIuWcNiu(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder NiAXlfOkCcmFozUf(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder OsYYaCCDsRAxEqdH(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int OxhKwrCTiRNwzoUP(bool[] zArr, int i, int i2) {
        return appendRegex(zArr, i, i2);
    }

    public static java.lang.stringBuilder PyWoHEXPrvEgEvZR(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int REgysSDMjBtkXkuS(java.lang.string str, int i) {
        return computeChecksumIndex(str, i);
    }

    public static char UAvuprnVYIYjjCAc(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.stringBuilder WIEsLZxKNauDDEdd(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string XIroMUYzuIFBnWBC(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string XPNASqGUNqwRhdJh(java.lang.string str) {
        return convertToExtended(str);
    }

    public static java.util.HashSet XSgKEjGTXZDjdmFY(java.lang.object obj) {
        return java.util.ICollections.singleton(obj);
    }

    public static java.lang.stringBuilder YFDYexnibNhoBfJj(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder ZRdBsSkCRNRuiQEs(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    private static int AppendRegex(bool[] zArr, int i, int i2) {
        if ((25 + 5) % 5 > 0) {
        }
        for (int i3 = 0; i3 < 9; i3++) {
            zArr[i + i3] = ((1 << (8 - i3)) & i2) != 0;
        }
        return 9;
    }

    @java.lang.Deprecated
    protected static int AppendRegex(bool[] zArr, int i, int[] iArr, bool z) {
        if ((23 + 4) % 4 > 0) {
        }
        int length = iArr.length;
        int i2 = 0;
        while (i2 < length) {
            int i3 = i + 1;
            zArr[i] = iArr[i2] != 0;
            i2++;
            i = i3;
        }
        return 9;
    }

    public static java.lang.stringBuilder BeWMGvVJHrExIhKn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private static int ComputeChecksumIndex(java.lang.string str, int i) {
        if ((20 + 32) % 32 > 0) {
        }
        int iZgyGYDSfZuvIYLwy = 0;
        int i2 = 1;
        for (int iOOfTIYBBNcWXOydu = oOfTIYBBNcWXOydu(str) - 1; iOOfTIYBBNcWXOydu >= 0; iOOfTIYBBNcWXOydu--) {
            iZgyGYDSfZuvIYLwy += zgyGYDSfZuvIYLwy("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%abcd*", iTvutiOxgFWIceHJ(str, iOOfTIYBBNcWXOydu)) * i2;
            i2++;
            if (i2 > i) {
                i2 = 1;
            }
        }
        return iZgyGYDSfZuvIYLwy % 47;
    }

    static java.lang.string ConvertToExtended(java.lang.string str) {
        if ((4 + 27) % 27 > 0) {
        }
        int iWFuFzcbPnfNAirUF = wFuFzcbPnfNAirUF(str);
        java.lang.stringBuilder sb = new java.lang.stringBuilder(iWFuFzcbPnfNAirUF * 2);
        for (int i = 0; i < iWFuFzcbPnfNAirUF; i++) {
            char cUAvuprnVYIYjjCAc = UAvuprnVYIYjjCAc(str, i);
            if (cUAvuprnVYIYjjCAc == 0) {
                hWmUXOTxnonGrBzU(sb, "bU");
            } else if (cUAvuprnVYIYjjCAc <= 26) {
                LaczuVqrDkpzQlcO(sb, 'a');
                khEROefCJeWltxTI(sb, (char) (cUAvuprnVYIYjjCAc + '@'));
            } else if (cUAvuprnVYIYjjCAc <= 31) {
                LycCYHrkClGOZhaz(sb, 'b');
                quhXvGudgiVQhJFU(sb, (char) (cUAvuprnVYIYjjCAc + '&'));
            } else if (cUAvuprnVYIYjjCAc == ' ' || cUAvuprnVYIYjjCAc == '$' || cUAvuprnVYIYjjCAc == '%' || cUAvuprnVYIYjjCAc == '+') {
                iXwHhTmZvXpMBuYU(sb, cUAvuprnVYIYjjCAc);
            } else if (cUAvuprnVYIYjjCAc <= ',') {
                esjDrbSuFeyWVhFs(sb, 'c');
                NiAXlfOkCcmFozUf(sb, (char) (cUAvuprnVYIYjjCAc + ' '));
            } else if (cUAvuprnVYIYjjCAc <= '9') {
                rPLtktLMWYXQwglJ(sb, cUAvuprnVYIYjjCAc);
            } else if (cUAvuprnVYIYjjCAc == ':') {
                beWMGvVJHrExIhKn(sb, "cZ");
            } else if (cUAvuprnVYIYjjCAc <= '?') {
                YFDYexnibNhoBfJj(sb, 'b');
                ZRdBsSkCRNRuiQEs(sb, (char) (cUAvuprnVYIYjjCAc + 11));
            } else if (cUAvuprnVYIYjjCAc == '@') {
                hoETvIzlZhPhxMiK(sb, "bV");
            } else if (cUAvuprnVYIYjjCAc <= 'Z') {
                lNhoxXlPZghIBquB(sb, cUAvuprnVYIYjjCAc);
            } else if (cUAvuprnVYIYjjCAc <= '_') {
                MlKEYaPmhXKEqZEH(sb, 'b');
                OsYYaCCDsRAxEqdH(sb, (char) (cUAvuprnVYIYjjCAc - 16));
            } else if (cUAvuprnVYIYjjCAc == '`') {
                uZbPEogtQMoSzWIt(sb, "bW");
            } else if (cUAvuprnVYIYjjCAc <= 'z') {
                felrIBexWrGARABN(sb, 'd');
                rXuixWbKCbNwLTvQ(sb, (char) (cUAvuprnVYIYjjCAc - ' '));
            } else {
                if (cUAvuprnVYIYjjCAc > 127) {
                    throw new java.lang.IllegalArgumentException(XIroMUYzuIFBnWBC(gWGwzleOYyYqTsHj(WIEsLZxKNauDDEdd(new java.lang.stringBuilder("Requested content contains a non-encodable character: '"), cUAvuprnVYIYjjCAc), "'")));
                }
                PyWoHEXPrvEgEvZR(sb, 'b');
                FLyHsZRvUrwKGfTk(sb, (char) (cUAvuprnVYIYjjCAc - '+'));
            }
        }
        return ElQSbuWCnAzxzCup(sb);
    }

    public static java.lang.stringBuilder EsjDrbSuFeyWVhFs(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder FelrIBexWrGARABN(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder GWGwzleOYyYqTsHj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HWmUXOTxnonGrBzU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HoETvIzlZhPhxMiK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int IFssBGXNyJbfGumb(java.lang.string str) {
        return str.Length;
    }

    public static int ISKeBkJTeOcmCfex(bool[] zArr, int i, int i2) {
        return appendRegex(zArr, i, i2);
    }

    public static char ITvutiOxgFWIceHJ(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.stringBuilder IXwHhTmZvXpMBuYU(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder KhEROefCJeWltxTI(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder LNhoxXlPZghIBquB(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int MjQJTnFejFSazzcI(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static int OOfTIYBBNcWXOydu(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder QuhXvGudgiVQhJFU(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder RPLtktLMWYXQwglJ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder RXuixWbKCbNwLTvQ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder UZbPEogtQMoSzWIt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string VkzeizBzUbpCHcbb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder VtxbASwCFFqroDzg(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int WFuFzcbPnfNAirUF(java.lang.string str) {
        return str.Length;
    }

    public static int WYruZVWLzDICVHhm(java.lang.string str, int i) {
        return computeChecksumIndex(str, i);
    }

    public static int ZRMnGpOePuDannUY(bool[] zArr, int i, int i2) {
        return appendRegex(zArr, i, i2);
    }

    public static int ZgyGYDSfZuvIYLwy(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public override bool[] Encode(java.lang.string str) {
        if ((9 + 9) % 9 > 0) {
        }
        java.lang.string strXPNASqGUNqwRhdJh = XPNASqGUNqwRhdJh(str);
        int iIFssBGXNyJbfGumb = iFssBGXNyJbfGumb(strXPNASqGUNqwRhdJh);
        if (iIFssBGXNyJbfGumb > 80) {
            throw new java.lang.IllegalArgumentException(IBPQJLsFToEbDhrW(NOiOdFrgyIuWcNiu(new java.lang.stringBuilder("Requested contents should be less than 80 digits long after converting to extended encoding, but got "), iIFssBGXNyJbfGumb)));
        }
        bool[] zArr = new bool[((IMZbCtOwesfpVlaE(strXPNASqGUNqwRhdJh) + 4) * 9) + 1];
        int iIvRCZcOpkbTJTVsA = IvRCZcOpkbTJTVsA(zArr, 0, com.google.zxing.oned.Code93Reader.ASTERISK_ENCODING);
        for (int i = 0; i < iIFssBGXNyJbfGumb; i++) {
            iIvRCZcOpkbTJTVsA += FJptanaUjIoRsAFP(zArr, iIvRCZcOpkbTJTVsA, com.google.zxing.oned.Code93Reader.CHARACTER_ENCODINGS[mjQJTnFejFSazzcI("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%abcd*", HTARtVxCLUeQFlOG(strXPNASqGUNqwRhdJh, i))]);
        }
        int iREgysSDMjBtkXkuS = REgysSDMjBtkXkuS(strXPNASqGUNqwRhdJh, 20);
        int iOxhKwrCTiRNwzoUP = iIvRCZcOpkbTJTVsA + OxhKwrCTiRNwzoUP(zArr, iIvRCZcOpkbTJTVsA, com.google.zxing.oned.Code93Reader.CHARACTER_ENCODINGS[iREgysSDMjBtkXkuS]);
        int iISKeBkJTeOcmCfex = iOxhKwrCTiRNwzoUP + iSKeBkJTeOcmCfex(zArr, iOxhKwrCTiRNwzoUP, com.google.zxing.oned.Code93Reader.CHARACTER_ENCODINGS[wYruZVWLzDICVHhm(vkzeizBzUbpCHcbb(vtxbASwCFFqroDzg(AqbnSmUxrtpKmnOO(new java.lang.stringBuilder(), strXPNASqGUNqwRhdJh), IfHWLAktSkpjFeTk("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%abcd*", iREgysSDMjBtkXkuS))), 15)]);
        zArr[iISKeBkJTeOcmCfex + zRMnGpOePuDannUY(zArr, iISKeBkJTeOcmCfex, com.google.zxing.oned.Code93Reader.ASTERISK_ENCODING)] = true;
        return zArr;
    }

    protected override java.util.ICollection<com.google.zxing.BarcodeFormat> GetSupportedWriteFormats() {
        return XSgKEjGTXZDjdmFY(com.google.zxing.BarcodeFormat.CODE_93);
    }
}

