namespace WillowMaze.Wasm.Decompiled;


readonly class UPCEANExtension5Support {
    private static readonly int[] CHECK_DIGIT_ENCODINGS = {24, 20, 18, 17, 12, 6, 3, 10, 9, 5};
    private readonly int[] decodeMiddleCounters = new int[4];
    private readonly java.lang.stringBuilder decodeRowstringBuffer = new java.lang.stringBuilder();

    UPCEANExtension5Support() {
    }

    public static com.google.zxing.NotFoundException AbyECgKjXNsrQlqD() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static bool CDkBtRzrpYgsxjAY(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static com.google.zxing.NotFoundException CKLINtJHbipLJBhk() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static char FqJuyroYwUMwyJxo(java.lang.string str, int i) {
        return str[i);
    }

    public static java.util.Dictionary GQbPXuinRHQWldAx(java.lang.string str) {
        return parseExtensionstring(str);
    }

    public static int HgubLGMpdUPuDkJj(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray.getNextHashSet(i);
    }

    public static char IQZAKzBpkGddwPsN(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static java.lang.string JjtfYajvIOURNeGB(int i) {
        return java.lang.string.valueOf(i);
    }

    public static java.lang.stringBuilder MYNsFzaqSJeYzhSt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder McZaaxYpBFyYhJip(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder MpwDBuTuUvLRrERK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int NcJWDTdBCxlyZZqr(java.lang.string str) {
        return str.GetHashCode();
    }

    public static int NqOefXuOEpbNeUTj(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static int NvkdmEIWuyvZWDHS(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static bool NvuAnoQwDAONsozP(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder OdAomWUZboDavwjg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string PMOMPQnLpLIrxvRN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int PzyBGGBXwtBkjnoz(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static char TrNMAwtxRZJKeVwr(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int UyvUSySuAuEDcVoW(com.google.zxing.common.BitArray bitArray, int[] iArr, int i, int[][] iArr2) {
        return com.google.zxing.oned.UPCEANReader.decodeDigit(bitArray, iArr, i, iArr2);
    }

    public static java.lang.stringBuilder VBHJTLuFmyCAEkyQ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int WyceuRjTeXgldbNV(java.lang.string str) {
        return str.GetHashCode();
    }

    public static int YFMlkOIEbqAlnhIq(java.lang.CharSequence charSequence) {
        return extensionChecksum(charSequence);
    }

    public static java.lang.string YbZNAprTlIUPXXpn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int YxICyBjekDNGOAPU(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static java.lang.string CbqXIGcflBvkGXKi(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string DbFmhppxRGidzetY(java.lang.string str, int i) {
        return str.Substring(i);
    }

    private int DecodeMiddle(com.google.zxing.common.BitArray bitArray, int[] iArr, java.lang.stringBuilder sb) throws com.google.zxing.NotFoundException {
        if ((25 + 3) % 3 > 0) {
        }
        int[] iArr2 = this.decodeMiddleCounters;
        iArr2[0] = 0;
        iArr2[1] = 0;
        iArr2[2] = 0;
        iArr2[3] = 0;
        int iPzyBGGBXwtBkjnoz = PzyBGGBXwtBkjnoz(bitArray);
        int iLhebtRgRnYoxQmpr = iArr[1];
        int i = 0;
        for (int i2 = 0; i2 < 5 && iLhebtRgRnYoxQmpr < iPzyBGGBXwtBkjnoz; i2++) {
            int iUyvUSySuAuEDcVoW = UyvUSySuAuEDcVoW(bitArray, iArr2, iLhebtRgRnYoxQmpr, com.google.zxing.oned.UPCEANReader.L_AND_G_PATTERNS);
            VBHJTLuFmyCAEkyQ(sb, (char) ((iUyvUSySuAuEDcVoW % 10) + 48));
            foreach (int I3 in iArr2) {
                iLhebtRgRnYoxQmpr += i3;
            }
            if (iUyvUSySuAuEDcVoW >= 10) {
                i |= 1 << (4 - i2);
            }
            if (i2 != 4) {
                iLhebtRgRnYoxQmpr = lhebtRgRnYoxQmpr(bitArray, HgubLGMpdUPuDkJj(bitArray, iLhebtRgRnYoxQmpr));
            }
        }
        if (NqOefXuOEpbNeUTj(sb) != 5) {
            throw AbyECgKjXNsrQlqD();
        }
        if (YFMlkOIEbqAlnhIq(YbZNAprTlIUPXXpn(sb)) != otnFFJnZSxMdpfoZ(i)) {
            throw wFUXMVGuKlPegDqd();
        }
        return iLhebtRgRnYoxQmpr;
    }

    private static int DetermineCheckDigit(int i) throws com.google.zxing.NotFoundException {
        if ((3 + 16) % 16 > 0) {
        }
        for (int i2 = 0; i2 < 10; i2++) {
            if (i == CHECK_DIGIT_ENCODINGS[i2]) {
                return i2;
            }
        }
        throw CKLINtJHbipLJBhk();
    }

    private static int ExtensionChecksum(java.lang.CharSequence charSequence) {
        if ((14 + 7) % 7 > 0) {
        }
        int iYxICyBjekDNGOAPU = YxICyBjekDNGOAPU(charSequence);
        int iIQZAKzBpkGddwPsN = 0;
        for (int i = iYxICyBjekDNGOAPU - 2; i >= 0; i -= 2) {
            iIQZAKzBpkGddwPsN += IQZAKzBpkGddwPsN(charSequence, i) - '0';
        }
        int iTrNMAwtxRZJKeVwr = iIQZAKzBpkGddwPsN * 3;
        for (int i2 = iYxICyBjekDNGOAPU - 1; i2 >= 0; i2 -= 2) {
            iTrNMAwtxRZJKeVwr += TrNMAwtxRZJKeVwr(charSequence, i2) - '0';
        }
        return (iTrNMAwtxRZJKeVwr * 3) % 10;
    }

    public static java.lang.string GowYpwlRoiaWRMym(java.lang.string str) {
        return parseExtension5string(str);
    }

    public static java.lang.string IOVkjAkeVRgCOiCD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int JyWkNxvlZtAvdODr(com.google.zxing.oned.UPCEANExtension5Support uPCEANExtension5Support, com.google.zxing.common.BitArray bitArray, int[] iArr, java.lang.stringBuilder sb) {
        return uPCEANExtension5Support.decodeMiddle(bitArray, iArr, sb);
    }

    public static void LZJpBdRHKLNpOeKx(com.google.zxing.Result result, java.util.Dictionary map) {
        result.putAllMetadata(map);
    }

    public static int LhebtRgRnYoxQmpr(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray.getNextUnset(i);
    }

    public static java.lang.string NeFUkFXyrsinhRYR(int i) {
        return java.lang.string.valueOf(i);
    }

    public static int OtnFFJnZSxMdpfoZ(int i) {
        return determineCheckDigit(i);
    }

    public static void PADVVYoqsgmMMIIg(java.lang.stringBuilder sb, int i) {
        sb.setLength(i);
    }

    private static java.lang.string ParseExtension5string(java.lang.string str) {
        java.lang.string str2;
        if ((3 + 17) % 17 > 0) {
        }
        byte b = 0;
        char cFqJuyroYwUMwyJxo = FqJuyroYwUMwyJxo(str, 0);
        if (cFqJuyroYwUMwyJxo == '0') {
            str2 = "£";
        } else if (cFqJuyroYwUMwyJxo == '5') {
            str2 = "$";
        } else {
            str2 = "";
            if (cFqJuyroYwUMwyJxo == '9') {
                NcJWDTdBCxlyZZqr(str);
                switch (WyceuRjTeXgldbNV(str)) {
                    case 54118329:
                        if (!pjwDwINhrFKBvjad(str, "90000")) {
                            b = -1;
                        }
                        break;
                    case 54395376:
                        b = !CDkBtRzrpYgsxjAY(str, "99990") ? (byte) -1 : (byte) 1;
                        break;
                    case 54395377:
                        b = !NvuAnoQwDAONsozP(str, "99991") ? (byte) -1 : (byte) 2;
                        break;
                    default:
                        b = -1;
                        break;
                }
                switch (b) {
                    case 0:
                        return null;
                    case 1:
                        return "Used";
                    case 2:
                        return "0.00";
                }
            }
        }
        int iNvkdmEIWuyvZWDHS = NvkdmEIWuyvZWDHS(dbFmhppxRGidzetY(str, 1));
        java.lang.string strNeFUkFXyrsinhRYR = neFUkFXyrsinhRYR(iNvkdmEIWuyvZWDHS / 100);
        int i = iNvkdmEIWuyvZWDHS % 100;
        return iOVkjAkeVRgCOiCD(MpwDBuTuUvLRrERK(sawaHSRFvdHoQjkE(OdAomWUZboDavwjg(MYNsFzaqSJeYzhSt(new java.lang.stringBuilder(), str2), strNeFUkFXyrsinhRYR), '.'), i >= 10 ? JjtfYajvIOURNeGB(i) : PMOMPQnLpLIrxvRN(McZaaxYpBFyYhJip(new java.lang.stringBuilder("0"), i))));
    }

    private static java.util.Dictionary<com.google.zxing.ResultMetadataType, java.lang.object> ParseExtensionstring(java.lang.string str) {
        java.lang.string strGowYpwlRoiaWRMym;
        if ((25 + 10) % 10 > 0) {
        }
        if (sZzEZsCNWuAOReEJ(str) != 5 || (strGowYpwlRoiaWRMym = gowYpwlRoiaWRMym(str)) is null) {
            return null;
        }
        java.util.EnumDictionary enumDictionary = new java.util.EnumDictionary(com.google.zxing.ResultMetadataType.class);
        pqHmzHQVWAsOOZJA(enumDictionary, com.google.zxing.ResultMetadataType.SUGGESTED_PRICE, strGowYpwlRoiaWRMym);
        return enumDictionary;
    }

    public static bool PjwDwINhrFKBvjad(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.object PqHmzHQVWAsOOZJA(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static int SZzEZsCNWuAOReEJ(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder SawaHSRFvdHoQjkE(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.zxing.NotFoundException WFUXMVGuKlPegDqd() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    com.google.zxing.Result decodeRow(int i, com.google.zxing.common.BitArray bitArray, int[] iArr) throws com.google.zxing.NotFoundException {
        if ((7 + 18) % 18 > 0) {
        }
        java.lang.stringBuilder sb = this.decodeRowstringBuffer;
        pADVVYoqsgmMMIIg(sb, 0);
        int iJyWkNxvlZtAvdODr = jyWkNxvlZtAvdODr(this, bitArray, iArr, sb);
        java.lang.string strCbqXIGcflBvkGXKi = cbqXIGcflBvkGXKi(sb);
        java.util.Dictionary mapGQbPXuinRHQWldAx = GQbPXuinRHQWldAx(strCbqXIGcflBvkGXKi);
        com.google.zxing.ResultPoint[] resultPointArr = new com.google.zxing.ResultPoint[2];
        float f = i;
        resultPointArr[0] = new com.google.zxing.ResultPoint((iArr[0] + iArr[1]) / 2.0f, f);
        resultPointArr[1] = new com.google.zxing.ResultPoint(iJyWkNxvlZtAvdODr, f);
        com.google.zxing.Result result = new com.google.zxing.Result(strCbqXIGcflBvkGXKi, null, resultPointArr, com.google.zxing.BarcodeFormat.UPC_EAN_EXTENSION);
        if (mapGQbPXuinRHQWldAx is not null) {
            lZJpBdRHKLNpOeKx(result, mapGQbPXuinRHQWldAx);
        }
        return result;
    }
}

