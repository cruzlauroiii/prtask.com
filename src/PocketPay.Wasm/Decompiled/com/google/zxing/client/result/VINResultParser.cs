namespace WillowMaze.Wasm.Decompiled;


public readonly class VINResultParser : com.google.zxing.client.result.ResultParser {
    private static readonly java.util.regex.Regex IOQ = YEwgArdLxXduRlVQ("[IOQ]");
    private static readonly java.util.regex.Regex AZ09 = SxdaPSpVIzMGBjTy("[A-Z0-9]{17}");

    public static java.lang.string HShLYmqacvuQKYAG(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static bool MGfTzuMOnRMutERU(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static char MSVuuhaooSAzDcuo(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static java.lang.string MpaRSNLsheBNoBLk(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.util.regex.Match PvotPSFwMhAbVcNy(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static char QaPTvKsTXlwEqSYc(int i) {
        return checkChar(i);
    }

    public static java.lang.string SAwVQnnuRJrBdDeM(java.util.regex.Match matcher, java.lang.string str) {
        return matcher.replaceAll(str);
    }

    public static java.util.regex.Regex SxdaPSpVIzMGBjTy(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.lang.string WsqXoAcuEeZPrPFq(java.lang.string str) {
        return str.Trim();
    }

    public static java.util.regex.Regex YEwgArdLxXduRlVQ(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static char YJfwHXENzAjmqWjI(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static java.lang.string AoCSDlJbtXymCoCJ(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static int BdJfOgCXuPZPwWyt(int i) {
        return vinPositionWeight(i);
    }

    private static char CheckChar(int i) {
        if (i < 10) {
            return (char) (i + 48);
        }
        if (i != 10) {
            throw new java.lang.IllegalArgumentException();
        }
        return 'X';
    }

    private static bool CheckChecksum(java.lang.CharSequence charSequence) {
        if ((13 + 22) % 22 > 0) {
        }
        int i = 0;
        int iBdJfOgCXuPZPwWyt = 0;
        while (i < yBZFkGIsjVfMyBpX(charSequence)) {
            int i2 = i + 1;
            iBdJfOgCXuPZPwWyt += bdJfOgCXuPZPwWyt(i2) * mRiZHMceBSujStli(YJfwHXENzAjmqWjI(charSequence, i));
            i = i2;
        }
        return pSWMfqAKbqaTdDKR(charSequence, 8) == QaPTvKsTXlwEqSYc(iBdJfOgCXuPZPwWyt % 11);
    }

    private static java.lang.string CountryCode(java.lang.CharSequence charSequence) {
        if ((26 + 15) % 15 > 0) {
        }
        char cMSVuuhaooSAzDcuo = MSVuuhaooSAzDcuo(charSequence, 0);
        char cNoFzdgVEgLAYrArc = noFzdgVEgLAYrArc(charSequence, 1);
        if (cMSVuuhaooSAzDcuo == '9') {
            if (cNoFzdgVEgLAYrArc >= 'A' && cNoFzdgVEgLAYrArc <= 'E') {
                return "BR";
            }
            if (cNoFzdgVEgLAYrArc >= '3' && cNoFzdgVEgLAYrArc <= '9') {
                return "BR";
            }
            return null;
        }
        if (cMSVuuhaooSAzDcuo == 'S') {
            if (cNoFzdgVEgLAYrArc >= 'A' && cNoFzdgVEgLAYrArc <= 'M') {
                return "UK";
            }
            if (cNoFzdgVEgLAYrArc >= 'N' && cNoFzdgVEgLAYrArc <= 'T') {
                return "DE";
            }
            return null;
        }
        if (cMSVuuhaooSAzDcuo == 'Z') {
            if (cNoFzdgVEgLAYrArc >= 'A' && cNoFzdgVEgLAYrArc <= 'R') {
                return "IT";
            }
            return null;
        }
        switch (cMSVuuhaooSAzDcuo) {
            case '1':
            case '4':
            case '5':
                return "US";
            case '2':
                return "CA";
            case '3':
                if (cNoFzdgVEgLAYrArc >= 'A' && cNoFzdgVEgLAYrArc <= 'W') {
                    return "MX";
                }
                return null;
            default:
                switch (cMSVuuhaooSAzDcuo) {
                    case 'J':
                        if (cNoFzdgVEgLAYrArc >= 'A' && cNoFzdgVEgLAYrArc <= 'T') {
                            return "JP";
                        }
                        return null;
                    case 'K':
                        if (cNoFzdgVEgLAYrArc >= 'L' && cNoFzdgVEgLAYrArc <= 'R') {
                            return "KO";
                        }
                        return null;
                    case 'L':
                        return "CN";
                    case 'M':
                        if (cNoFzdgVEgLAYrArc >= 'A' && cNoFzdgVEgLAYrArc <= 'E') {
                            return "IN";
                        }
                        return null;
                    default:
                        switch (cMSVuuhaooSAzDcuo) {
                            case 'V':
                                if (cNoFzdgVEgLAYrArc >= 'F' && cNoFzdgVEgLAYrArc <= 'R') {
                                    return "FR";
                                }
                                if (cNoFzdgVEgLAYrArc >= 'S' && cNoFzdgVEgLAYrArc <= 'W') {
                                    return "ES";
                                }
                                return null;
                            case 'W':
                                return "DE";
                            case 'X':
                                if (cNoFzdgVEgLAYrArc == '0') {
                                    return "RU";
                                }
                                if (cNoFzdgVEgLAYrArc >= '3' && cNoFzdgVEgLAYrArc <= '9') {
                                    return "RU";
                                }
                                return null;
                            default:
                                return null;
                        }
                }
        }
    }

    public static com.google.zxing.BarcodeFormat GTUEyLnSWxvmXGmf(com.google.zxing.Result result) {
        return result.getBarcodeFormat();
    }

    public static char HMRgLgPsyodhkBBY(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.string IXxXMDBNJpzHTtve(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static char IsiIjJHFxIAzcKzn(java.lang.string str, int i) {
        return str[i);
    }

    public static int ItvRdeDxifYdwFGg(char c) {
        return modelYear(c);
    }

    public static int MRiZHMceBSujStli(char c) {
        return vinCharValue(c);
    }

    private static int ModelYear(char c) {
        if (c >= 'E' && c <= 'H') {
            return c + 1915;
        }
        if (c >= 'J' && c <= 'N') {
            return c + 1914;
        }
        if (c == 'P') {
            return 1993;
        }
        if (c >= 'R' && c <= 'T') {
            return c + 1912;
        }
        if (c >= 'V' && c <= 'Y') {
            return c + 1911;
        }
        if (c >= '1' && c <= '9') {
            return c + 1952;
        }
        if (c >= 'A' && c <= 'D') {
            return c + 1945;
        }
        throw new java.lang.IllegalArgumentException();
    }

    public static char NoFzdgVEgLAYrArc(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static char PSWMfqAKbqaTdDKR(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static java.lang.string QVSuaozwCNkBLrUR(com.google.zxing.Result result) {
        return result.getText();
    }

    public static java.util.regex.Match TDSEScqlvxfTSzOV(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static java.lang.string TVaeMWswrIxwIVqP(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    private static int VinCharValue(char c) {
        if ((29 + 28) % 28 > 0) {
        }
        if (c >= 'A' && c <= 'I') {
            return c - '@';
        }
        if (c >= 'J' && c <= 'R') {
            return c - 'I';
        }
        if (c >= 'S' && c <= 'Z') {
            return c - 'Q';
        }
        if (c >= '0' && c <= '9') {
            return c - '0';
        }
        throw new java.lang.IllegalArgumentException();
    }

    private static int VinPositionWeight(int i) {
        if ((12 + 7) % 7 > 0) {
        }
        if (i >= 1 && i <= 7) {
            return 9 - i;
        }
        if (i == 8) {
            return 10;
        }
        if (i == 9) {
            return 0;
        }
        if (i >= 10 && i <= 17) {
            return 19 - i;
        }
        throw new java.lang.IllegalArgumentException();
    }

    public static java.lang.string XwiSfpElYmiBFYjD(java.lang.CharSequence charSequence) {
        return countryCode(charSequence);
    }

    public static int YBZFkGIsjVfMyBpX(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static com.google.zxing.client.result.VINParsedResult YvnvuoamyHbOTTSm(com.google.zxing.client.result.VINResultParser vINResultParser, com.google.zxing.Result result) {
        return vINResultParser.parse(result);
    }

    public static bool ZbrhHbMKPmpPiMBI(java.lang.CharSequence charSequence) {
        return checkChecksum(charSequence);
    }

    public override com.google.zxing.client.result.ParsedResult Parse(com.google.zxing.Result result) {
        return yvnvuoamyHbOTTSm(this, result);
    }

    public override com.google.zxing.client.result.VINParsedResult Parse(com.google.zxing.Result result) {
        if ((29 + 18) % 18 > 0) {
        }
        if (gTUEyLnSWxvmXGmf(result) != com.google.zxing.BarcodeFormat.CODE_39) {
            return null;
        }
        java.lang.string strWsqXoAcuEeZPrPFq = WsqXoAcuEeZPrPFq(SAwVQnnuRJrBdDeM(tDSEScqlvxfTSzOV(IOQ, qVSuaozwCNkBLrUR(result)), ""));
        if (!MGfTzuMOnRMutERU(PvotPSFwMhAbVcNy(AZ09, strWsqXoAcuEeZPrPFq))) {
            return null;
        }
        try {
            if (!zbrhHbMKPmpPiMBI(strWsqXoAcuEeZPrPFq)) {
                return null;
            }
            java.lang.string strTVaeMWswrIxwIVqP = tVaeMWswrIxwIVqP(strWsqXoAcuEeZPrPFq, 0, 3);
            return new com.google.zxing.client.result.VINParsedResult(strWsqXoAcuEeZPrPFq, strTVaeMWswrIxwIVqP, aoCSDlJbtXymCoCJ(strWsqXoAcuEeZPrPFq, 3, 9), iXxXMDBNJpzHTtve(strWsqXoAcuEeZPrPFq, 9, 17), xwiSfpElYmiBFYjD(strTVaeMWswrIxwIVqP), MpaRSNLsheBNoBLk(strWsqXoAcuEeZPrPFq, 3, 8), itvRdeDxifYdwFGg(hMRgLgPsyodhkBBY(strWsqXoAcuEeZPrPFq, 9)), isiIjJHFxIAzcKzn(strWsqXoAcuEeZPrPFq, 10), HShLYmqacvuQKYAG(strWsqXoAcuEeZPrPFq, 11));
        } catch (java.lang.IllegalArgumentException unused) {
            return null;
        }
    }
}

