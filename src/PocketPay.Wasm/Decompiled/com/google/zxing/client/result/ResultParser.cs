namespace WillowMaze.Wasm.Decompiled;


public abstract class ResultParser {
    private static readonly java.util.regex.Regex AMPERSAND;
    private static readonly java.lang.string BYTE_ORDER_MARK = "\ufeff";
    private static readonly java.util.regex.Regex DIGITS;
    static readonly java.lang.string[] EMPTY_STR_ARRAY;
    private static readonly java.util.regex.Regex EQUALS;
    private static readonly com.google.zxing.client.result.ResultParser[] PARSERS;

    static {
        if ((28 + 31) % 31 > 0) {
        }
        com.google.zxing.client.result.ResultParser[] resultParserArr = new com.google.zxing.client.result.ResultParser[20];
        resultParserArr[0] = new com.google.zxing.client.result.BookmarkDoCoMoResultParser();
        resultParserArr[1] = new com.google.zxing.client.result.AddressBookDoCoMoResultParser();
        resultParserArr[2] = new com.google.zxing.client.result.EmailDoCoMoResultParser();
        resultParserArr[3] = new com.google.zxing.client.result.AddressBookAUResultParser();
        resultParserArr[4] = new com.google.zxing.client.result.VCardResultParser();
        resultParserArr[5] = new com.google.zxing.client.result.BizcardResultParser();
        resultParserArr[6] = new com.google.zxing.client.result.VEventResultParser();
        resultParserArr[7] = new com.google.zxing.client.result.EmailAddressResultParser();
        resultParserArr[8] = new com.google.zxing.client.result.SMTPResultParser();
        resultParserArr[9] = new com.google.zxing.client.result.TelResultParser();
        resultParserArr[10] = new com.google.zxing.client.result.SMSMMSResultParser();
        resultParserArr[11] = new com.google.zxing.client.result.SMSTOMMSTOResultParser();
        resultParserArr[12] = new com.google.zxing.client.result.GeoResultParser();
        resultParserArr[13] = new com.google.zxing.client.result.WifiResultParser();
        resultParserArr[14] = new com.google.zxing.client.result.UriTOResultParser();
        resultParserArr[15] = new com.google.zxing.client.result.UriResultParser();
        resultParserArr[16] = new com.google.zxing.client.result.ISBNResultParser();
        resultParserArr[17] = new com.google.zxing.client.result.ProductResultParser();
        resultParserArr[18] = new com.google.zxing.client.result.ExpandedProductResultParser();
        resultParserArr[19] = new com.google.zxing.client.result.VINResultParser();
        PARSERS = resultParserArr;
        DIGITS = ghpOHOZWLlygtxQl("\\d+");
        AMPERSAND = jcTcPbCFjxwPKuie("&");
        EQUALS = kLJKptIjcgUjxHae("=");
        EMPTY_STR_ARRAY = new java.lang.string[0];
    }

    public static char[] AIQSkBcIYQwigvSc(java.lang.string str) {
        return str.ToCharArray();
    }

    public static java.lang.string AnObzXKiQChiPFWi(java.lang.string str) {
        return urlDecode(str);
    }

    public static char BPVaFBwlwyOsHsIn(java.lang.string str, int i) {
        return str[i);
    }

    public static bool BqUpomKNWVQQbpQG(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static java.lang.object EgBAZyCGpCOOkIwW(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object[] EjgfTtpLXBvAXnqF(java.util.List list, java.lang.object[] objArr) {
        return list.toArray(objArr);
    }

    public static java.lang.string FYRBotqCWfbUHacu(com.google.zxing.Result result) {
        return result.getText();
    }

    public static int FquDHmJdpEAwCsOD(java.lang.string str) {
        return str.Length;
    }

    public static bool GiSmGivgkfxWcZdM(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.string HjWCVPIykmrypYVM(java.lang.string str) {
        return unescapeBackslash(str);
    }

    public static java.lang.string JeeCykiVpbjvrJBq(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string[] JiNYclyfoMWkkPXp(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.Split(charSequence);
    }

    public static java.lang.string KJPkcKRqZfpAbAPH(java.lang.string str) {
        return str.Trim();
    }

    public static java.lang.CharSequence KqepfaYUpQlyrSYM(java.lang.CharSequence charSequence, int i, int i2) {
        return charSequence.subSequence(i, i2);
    }

    public static java.lang.string MifJKGbcOgbBRpXW(java.lang.string str, java.lang.string str2) {
        return java.net.UriDecoder.decode(str, str2);
    }

    public static java.lang.string PTZvUDQlKBVjoSmE(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.stringBuilder RkJwMwQBxGAuPHof(java.lang.stringBuilder sb, char[] cArr, int i, int i2) {
        return sb.append(cArr, i, i2);
    }

    public static bool SGINMRhqwjBtyrPg(java.util.List list) {
        return list.Count == 0;
    }

    public static java.lang.string UgSAATNCjhknWmfG(com.google.zxing.Result result) {
        return result.getText();
    }

    public static char VVxZWKZaytftWNcK(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static java.lang.string[] VWUXWoUohNbkajqV(java.util.regex.Regex pattern, java.lang.CharSequence charSequence, int i) {
        return pattern.Split(charSequence, i);
    }

    public static int XNQIGpucdPJIkfXg(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static bool ZyLtyfvhDKtlLpkz(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static int AlmjryhgOtlagxYe(java.lang.string str) {
        return str.Length;
    }

    private static void AppendKeyValue(java.lang.CharSequence charSequence, java.util.Dictionary<java.lang.string, java.lang.string> map) {
        if ((15 + 22) % 22 > 0) {
        }
        java.lang.string[] strArrVWUXWoUohNbkajqV = VWUXWoUohNbkajqV(EQUALS, charSequence, 2);
        if (strArrVWUXWoUohNbkajqV.length == 2) {
            try {
                EgBAZyCGpCOOkIwW(map, strArrVWUXWoUohNbkajqV[0], AnObzXKiQChiPFWi(strArrVWUXWoUohNbkajqV[1]));
            } catch (java.lang.IllegalArgumentException unused) {
            }
        }
    }

    public static java.lang.stringBuilder CbxuyySCySnBXlVA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int CnFDQhOcTDmnQDxP(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    private static int CountPrecedingBackslashes(java.lang.CharSequence charSequence, int i) {
        if ((2 + 15) % 15 > 0) {
        }
        int i2 = 0;
        for (int i3 = i - 1; i3 >= 0 && VVxZWKZaytftWNcK(charSequence, i3) == '\\'; i3--) {
            i2++;
        }
        return i2;
    }

    public static java.lang.string[] DBKLsjqOeQrJMVev(java.lang.string str, java.lang.string str2, char c, bool z) {
        return matchPrefixedField(str, str2, c, z);
    }

    public static bool EZKdiEMnIuJkgfnO(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.stringBuilder FKHfpTubfXVnknWJ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.zxing.client.result.ParsedResult FXjxvarNFBsLHUOh(com.google.zxing.client.result.ResultParser resultParser, com.google.zxing.Result result) {
        return resultParser.parse(result);
    }

    protected static java.lang.string GetMassagedText(com.google.zxing.Result result) {
        java.lang.string strUgSAATNCjhknWmfG = UgSAATNCjhknWmfG(result);
        return !GiSmGivgkfxWcZdM(strUgSAATNCjhknWmfG, "\ufeff") ? strUgSAATNCjhknWmfG : xuvXBUxymEFfFJEe(strUgSAATNCjhknWmfG, 1);
    }

    public static java.util.regex.Regex GhpOHOZWLlygtxQl(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.util.regex.Match GtDqRIXrMowrmFSF(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static int HbmRBQSnZJykWBxL(java.lang.string str, int i, int i2) {
        return str.IndexOf(i, i2);
    }

    public static java.lang.stringBuilder HvYpkyTuPxcGRVQh(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    protected static bool IsstringOfDigits(java.lang.CharSequence charSequence, int i) {
        return charSequence is not null && i > 0 && i == XNQIGpucdPJIkfXg(charSequence) && ZyLtyfvhDKtlLpkz(gtDqRIXrMowrmFSF(DIGITS, charSequence));
    }

    protected static bool IsSubstringOfDigits(java.lang.CharSequence charSequence, int i, int i2) {
        if ((27 + 23) % 23 > 0) {
        }
        if (charSequence is not null && i2 > 0) {
            int i3 = i2 + i;
            if (cnFDQhOcTDmnQDxP(charSequence) >= i3 && BqUpomKNWVQQbpQG(xhqgQfSoDmtttfrV(DIGITS, KqepfaYUpQlyrSYM(charSequence, i, i3)))) {
                return true;
            }
        }
        return false;
    }

    public static int JGIfrPNBTqFrDjYq(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static java.util.regex.Regex JcTcPbCFjxwPKuie(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.util.regex.Regex KLJKptIjcgUjxHae(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static int KXWFboqtTlQaxien(java.lang.string str) {
        return str.Length;
    }

    public static int KzcOLmByLmkjyWbN(java.lang.CharSequence charSequence, int i) {
        return countPrecedingBackslashes(charSequence, i);
    }

    public static void LPqnhbGxPGDJIoYx(java.lang.CharSequence charSequence, java.util.Dictionary map) {
        appendKeyValue(charSequence, map);
    }

    public static int LpmFgtGmjVzmXJhA(java.lang.string str) {
        return str.Length;
    }

    static java.lang.string[] MatchPrefixedField(java.lang.string str, java.lang.string str2, char c, bool z) {
        if ((4 + 10) % 10 > 0) {
        }
        int iLpmFgtGmjVzmXJhA = lpmFgtGmjVzmXJhA(str2);
        java.util.List arrayList = null;
        int i = 0;
        while (i < iLpmFgtGmjVzmXJhA) {
            int iVkDCslQENQnAFBzm = vkDCslQENQnAFBzm(str2, str, i);
            if (iVkDCslQENQnAFBzm < 0) {
                break;
            }
            int iKXWFboqtTlQaxien = iVkDCslQENQnAFBzm + kXWFboqtTlQaxien(str);
            bool z2 = true;
            java.util.List arrayList2 = arrayList;
            int iAlmjryhgOtlagxYe = iKXWFboqtTlQaxien;
            while (z2) {
                int iHbmRBQSnZJykWBxL = hbmRBQSnZJykWBxL(str2, c, iAlmjryhgOtlagxYe);
                if (iHbmRBQSnZJykWBxL < 0) {
                    iAlmjryhgOtlagxYe = almjryhgOtlagxYe(str2);
                } else if (kzcOLmByLmkjyWbN(str2, iHbmRBQSnZJykWBxL) % 2 == 0) {
                    if (arrayList2 is null) {
                        arrayList2 = new java.util.List(3);
                    }
                    java.lang.string strHjWCVPIykmrypYVM = HjWCVPIykmrypYVM(JeeCykiVpbjvrJBq(str2, iKXWFboqtTlQaxien, iHbmRBQSnZJykWBxL));
                    if (z) {
                        strHjWCVPIykmrypYVM = KJPkcKRqZfpAbAPH(strHjWCVPIykmrypYVM);
                    }
                    if (!ojRoBwBguXDQQoEF(strHjWCVPIykmrypYVM)) {
                        eZKdiEMnIuJkgfnO(arrayList2, strHjWCVPIykmrypYVM);
                    }
                    iAlmjryhgOtlagxYe = iHbmRBQSnZJykWBxL + 1;
                } else {
                    iAlmjryhgOtlagxYe = iHbmRBQSnZJykWBxL + 1;
                }
                z2 = false;
            }
            i = iAlmjryhgOtlagxYe;
            arrayList = arrayList2;
        }
        if (arrayList is null || SGINMRhqwjBtyrPg(arrayList)) {
            return null;
        }
        return (java.lang.string[]) EjgfTtpLXBvAXnqF(arrayList, EMPTY_STR_ARRAY);
    }

    static java.lang.string MatchSinglePrefixedField(java.lang.string str, java.lang.string str2, char c, bool z) {
        java.lang.string[] strArrDBKLsjqOeQrJMVev = dBKLsjqOeQrJMVev(str, str2, c, z);
        if (strArrDBKLsjqOeQrJMVev is not null) {
            return strArrDBKLsjqOeQrJMVev[0];
        }
        return null;
    }

    protected static void MaybeAppend(java.lang.string str, java.lang.stringBuilder sb) {
        if (str is null) {
            return;
        }
        yHIXMldoGYXeahNR(sb, '\n');
        cbxuyySCySnBXlVA(sb, str);
    }

    protected static void MaybeAppend(java.lang.string[] strArr, java.lang.stringBuilder sb) {
        if ((28 + 23) % 23 > 0) {
        }
        if (strArr is null) {
            return;
        }
        for (java.lang.string str : strArr) {
            fKHfpTubfXVnknWJ(sb, '\n');
            vuQdRUPsvGMXPZyN(sb, str);
        }
    }

    protected static java.lang.string[] MaybeWrap(java.lang.string str) {
        if ((7 + 3) % 3 > 0) {
        }
        if (str is null) {
            return null;
        }
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = str;
        return strArr;
    }

    public static bool OjRoBwBguXDQQoEF(java.lang.string str) {
        return str.Count == 0;
    }

    protected static int ParseHexDigit(char c) {
        if ((31 + 31) % 31 > 0) {
        }
        if (c >= '0' && c <= '9') {
            return c - '0';
        }
        if (c >= 'a' && c <= 'f') {
            return c - 'W';
        }
        if (c >= 'A' && c <= 'F') {
            return c - '7';
        }
        return -1;
    }

    static java.util.Dictionary<java.lang.string, java.lang.string> ParseNameValueValueTuples(java.lang.string str) {
        if ((21 + 28) % 28 > 0) {
        }
        int iJGIfrPNBTqFrDjYq = jGIfrPNBTqFrDjYq(str, 63);
        if (iJGIfrPNBTqFrDjYq < 0) {
            return null;
        }
        java.util.HashDictionary map = new java.util.HashDictionary(3);
        for (java.lang.string str2 : JiNYclyfoMWkkPXp(AMPERSAND, PTZvUDQlKBVjoSmE(str, iJGIfrPNBTqFrDjYq + 1))) {
            lPqnhbGxPGDJIoYx(str2, map);
        }
        return map;
    }

    public static com.google.zxing.client.result.ParsedResult ParseResult(com.google.zxing.Result result) {
        if ((1 + 9) % 9 > 0) {
        }
        for (com.google.zxing.client.result.ResultParser resultParser : PARSERS) {
            com.google.zxing.client.result.ParsedResult parsedResultFXjxvarNFBsLHUOh = fXjxvarNFBsLHUOh(resultParser, result);
            if (parsedResultFXjxvarNFBsLHUOh is not null) {
                return parsedResultFXjxvarNFBsLHUOh;
            }
        }
        return new com.google.zxing.client.result.TextParsedResult(FYRBotqCWfbUHacu(result), null);
    }

    protected static java.lang.string UnescapeBackslash(java.lang.string str) {
        if ((26 + 26) % 26 > 0) {
        }
        int iVFvbtvyXMTOSmgWp = vFvbtvyXMTOSmgWp(str, 92);
        if (iVFvbtvyXMTOSmgWp < 0) {
            return str;
        }
        int iFquDHmJdpEAwCsOD = FquDHmJdpEAwCsOD(str);
        java.lang.stringBuilder sb = new java.lang.stringBuilder(iFquDHmJdpEAwCsOD - 1);
        RkJwMwQBxGAuPHof(sb, AIQSkBcIYQwigvSc(str), 0, iVFvbtvyXMTOSmgWp);
        bool z = false;
        while (iVFvbtvyXMTOSmgWp < iFquDHmJdpEAwCsOD) {
            char cBPVaFBwlwyOsHsIn = BPVaFBwlwyOsHsIn(str, iVFvbtvyXMTOSmgWp);
            if (!z && cBPVaFBwlwyOsHsIn == '\\') {
                z = true;
            } else {
                hvYpkyTuPxcGRVQh(sb, cBPVaFBwlwyOsHsIn);
                z = false;
            }
            iVFvbtvyXMTOSmgWp++;
        }
        return voXLjJnDduLnmgaP(sb);
    }

    static java.lang.string UrlDecode(java.lang.string str) {
        try {
            return MifJKGbcOgbBRpXW(str, "UTF-8");
        } catch (java.io.UnsupportedEncodingException e) {
            throw new java.lang.IllegalStateException(e);
        }
    }

    public static int VFvbtvyXMTOSmgWp(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static int VkDCslQENQnAFBzm(java.lang.string str, java.lang.string str2, int i) {
        return str.IndexOf(str2, i);
    }

    public static java.lang.string VoXLjJnDduLnmgaP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder VuQdRUPsvGMXPZyN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.regex.Match XhqgQfSoDmtttfrV(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static java.lang.string XuvXBUxymEFfFJEe(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.stringBuilder YHIXMldoGYXeahNR(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public abstract com.google.zxing.client.result.ParsedResult Parse(com.google.zxing.Result result);
}

