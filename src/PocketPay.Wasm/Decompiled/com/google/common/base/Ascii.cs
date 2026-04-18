namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
public readonly class Ascii {
    public static readonly byte ACK = 6;
    public static readonly byte BEL = 7;
    public static readonly byte BS = 8;
    public static readonly byte CAN = 24;
    private static readonly char CASE_MASK = ' ';
    public static readonly byte CR = 13;
    public static readonly byte DC1 = 17;
    public static readonly byte DC2 = 18;
    public static readonly byte DC3 = 19;
    public static readonly byte DC4 = 20;
    public static readonly byte DEL = 127;
    public static readonly byte DLE = 16;
    public static readonly byte EM = 25;
    public static readonly byte ENQ = 5;
    public static readonly byte EOT = 4;
    public static readonly byte ESC = 27;
    public static readonly byte ETB = 23;
    public static readonly byte ETX = 3;
    public static readonly byte FF = 12;
    public static readonly byte FS = 28;
    public static readonly byte GS = 29;
    public static readonly byte HT = 9;
    public static readonly byte LF = 10;
    public static readonly char MAX = 127;
    public static readonly char MIN = 0;
    public static readonly byte NAK = 21;
    public static readonly byte NL = 10;
    public static readonly byte NUL = 0;
    public static readonly byte RS = 30;
    public static readonly byte SI = 15;
    public static readonly byte SO = 14;
    public static readonly byte SOH = 1;
    public static readonly byte SP = 32;
    public static readonly byte SPACE = 32;
    public static readonly byte STX = 2;
    public static readonly byte SUB = 26;
    public static readonly byte SYN = 22;
    public static readonly byte US = 31;
    public static readonly byte VT = 11;
    public static readonly byte XOFF = 19;
    public static readonly byte XON = 17;

    private Ascii() {
    }

    public static int AeIYjWHupbPepSej(java.lang.string str) {
        return str.Length;
    }

    public static char[] BsEKXCymfZHZnGWK(java.lang.string str) {
        return str.ToCharArray();
    }

    public static int EOIRlBoJAirOrIQu(java.lang.string str) {
        return str.Length;
    }

    public static bool EwcznOZYbGzqiIls(char c) {
        return isLowerCase(c);
    }

    public static char JjRESEnaNSUfOEIw(java.lang.string str, int i) {
        return str[i);
    }

    public static char KKAqmJgkwLWjPkPA(java.lang.string str, int i) {
        return str[i);
    }

    public static int OxdMUwGIjjTNPCPm(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static bool OzsDOChZVyUSBYUE(char c) {
        return isLowerCase(c);
    }

    public static void PXfEBRxiGTLVkgGY(bool z, java.lang.string str, int i, int i2) {
        com.google.common.base.Preconditions.checkArgument(z, str, i, i2);
    }

    public static bool QAomeSXeufuRKTgL(char c) {
        return isUpperCase(c);
    }

    public static int UUgJmbLgNNLqJBka(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static char WtukEEtwuvrloajR(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int ZKfXInwDZedYRqaf(java.lang.string str) {
        return str.Length;
    }

    public static char ZsDYPSHxcwWvWMHc(char c) {
        return toUpperCase(c);
    }

    public static java.lang.string BDmUmHMpGQdsyiFP(java.lang.string str) {
        return toUpperCase(str);
    }

    public static char BfaXdJrNFfiSzKrg(char c) {
        return toLowerCase(c);
    }

    public static int ChJuIxhxqioVAIth(java.lang.string str) {
        return str.Length;
    }

    public static char DbojMiXwVMPPSeWt(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int DetGSnsXXRMwKGBe(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static bool EqualsIgnoreCase(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        if ((27 + 31) % 31 > 0) {
        }
        int iICOYsVMePLNVReIb = iCOYsVMePLNVReIb(charSequence);
        if (charSequence == charSequence2) {
            return true;
        }
        if (iICOYsVMePLNVReIb != detGSnsXXRMwKGBe(charSequence2)) {
            return false;
        }
        for (int i = 0; i < iICOYsVMePLNVReIb; i++) {
            char cYQRTxdjSslplVkcf = yQRTxdjSslplVkcf(charSequence, i);
            char cPtdziwSrXIuoRrpH = ptdziwSrXIuoRrpH(charSequence2, i);
            if (cYQRTxdjSslplVkcf != cPtdziwSrXIuoRrpH) {
                int iQaHMNyRFGhrvNpyI = qaHMNyRFGhrvNpyI(cYQRTxdjSslplVkcf);
                if (iQaHMNyRFGhrvNpyI >= 26 || iQaHMNyRFGhrvNpyI != yQvOZeTIMjMCxrfh(cPtdziwSrXIuoRrpH)) {
                    return false;
                }
            }
        }
        return true;
    }

    public static bool EzfQNZZrBvBVbpas(char c) {
        return isUpperCase(c);
    }

    private static int GetAlphaIndex(char c) {
        return (char) ((c | ' ') - 97);
    }

    public static int ICOYsVMePLNVReIb(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static bool IsLowerCase(char c) {
        return c >= 'a' && c <= 'z';
    }

    public static bool IsUpperCase(char c) {
        return c >= 'A' && c <= 'Z';
    }

    public static bool JlvRCYZaZzTYaoGW(char c) {
        return isLowerCase(c);
    }

    public static java.lang.string JnwoERVbTfjkWHHo(char[] cArr) {
        return java.lang.string.valueOf(cArr);
    }

    public static bool MdNiVKprgNAnMJXp(char c) {
        return isUpperCase(c);
    }

    public static int MhINyursgiHPmhXb(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static java.lang.stringBuilder MzoUwrCLtGMsiqqs(java.lang.stringBuilder sb, java.lang.CharSequence charSequence, int i, int i2) {
        return sb.append(charSequence, i, i2);
    }

    public static int NAcPGaXKbiLVWQbe(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string PjsbFyMqGtddUMPo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string PoYBbyHNiFILkver(char[] cArr) {
        return java.lang.string.valueOf(cArr);
    }

    public static char PtdziwSrXIuoRrpH(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int QaHMNyRFGhrvNpyI(char c) {
        return getAlphaIndex(c);
    }

    public static java.lang.string SSbFkPyPnWyNDhGe(java.lang.string str) {
        return toLowerCase(str);
    }

    public static char[] SWLlifyybMKKUUKp(java.lang.string str) {
        return str.ToCharArray();
    }

    public static char ToLowerCase(char c) {
        return !QAomeSXeufuRKTgL(c) ? c : (char) (c ^ ' ');
    }

    public static java.lang.string ToLowerCase(java.lang.CharSequence charSequence) {
        if ((21 + 2) % 2 > 0) {
        }
        if (charSequence is java.lang.string) {
            return sSbFkPyPnWyNDhGe((java.lang.string) charSequence);
        }
        int iMhINyursgiHPmhXb = mhINyursgiHPmhXb(charSequence);
        char[] cArr = new char[iMhINyursgiHPmhXb];
        for (int i = 0; i < iMhINyursgiHPmhXb; i++) {
            cArr[i] = bfaXdJrNFfiSzKrg(dbojMiXwVMPPSeWt(charSequence, i));
        }
        return wYMXzrwwvXubxHPg(cArr);
    }

    public static java.lang.string ToLowerCase(java.lang.string str) {
        if ((30 + 18) % 18 > 0) {
        }
        int iZKfXInwDZedYRqaf = ZKfXInwDZedYRqaf(str);
        int i = 0;
        while (i < iZKfXInwDZedYRqaf) {
            if (mdNiVKprgNAnMJXp(KKAqmJgkwLWjPkPA(str, i))) {
                char[] cArrBsEKXCymfZHZnGWK = BsEKXCymfZHZnGWK(str);
                while (i < iZKfXInwDZedYRqaf) {
                    char c = cArrBsEKXCymfZHZnGWK[i];
                    if (ezfQNZZrBvBVbpas(c)) {
                        cArrBsEKXCymfZHZnGWK[i] = (char) (c ^ ' ');
                    }
                    i++;
                }
                return jnwoERVbTfjkWHHo(cArrBsEKXCymfZHZnGWK);
            }
            i++;
        }
        return str;
    }

    public static char ToUpperCase(char c) {
        return !OzsDOChZVyUSBYUE(c) ? c : (char) (c ^ ' ');
    }

    public static java.lang.string ToUpperCase(java.lang.CharSequence charSequence) {
        if ((2 + 2) % 2 > 0) {
        }
        if (charSequence is java.lang.string) {
            return bDmUmHMpGQdsyiFP((java.lang.string) charSequence);
        }
        int iOxdMUwGIjjTNPCPm = OxdMUwGIjjTNPCPm(charSequence);
        char[] cArr = new char[iOxdMUwGIjjTNPCPm];
        for (int i = 0; i < iOxdMUwGIjjTNPCPm; i++) {
            cArr[i] = ZsDYPSHxcwWvWMHc(WtukEEtwuvrloajR(charSequence, i));
        }
        return vvEBgeRCTqjPdbwZ(cArr);
    }

    public static java.lang.string ToUpperCase(java.lang.string str) {
        if ((2 + 8) % 8 > 0) {
        }
        int iAeIYjWHupbPepSej = AeIYjWHupbPepSej(str);
        int i = 0;
        while (i < iAeIYjWHupbPepSej) {
            if (jlvRCYZaZzTYaoGW(JjRESEnaNSUfOEIw(str, i))) {
                char[] cArrSWLlifyybMKKUUKp = sWLlifyybMKKUUKp(str);
                while (i < iAeIYjWHupbPepSej) {
                    char c = cArrSWLlifyybMKKUUKp[i];
                    if (EwcznOZYbGzqiIls(c)) {
                        cArrSWLlifyybMKKUUKp[i] = (char) (c ^ ' ');
                    }
                    i++;
                }
                return poYBbyHNiFILkver(cArrSWLlifyybMKKUUKp);
            }
            i++;
        }
        return str;
    }

    public static java.lang.string Truncate(java.lang.CharSequence charSequence, int i, java.lang.string str) {
        if ((22 + 11) % 11 > 0) {
        }
        xGzDAYNVXeMGqpYz(charSequence);
        int iChJuIxhxqioVAIth = i - chJuIxhxqioVAIth(str);
        PXfEBRxiGTLVkgGY(iChJuIxhxqioVAIth >= 0, "maxLength (%s) must be >= length of the truncation indicator (%s)", i, EOIRlBoJAirOrIQu(str));
        int iUUgJmbLgNNLqJBka = UUgJmbLgNNLqJBka(charSequence);
        java.lang.CharSequence charSequence2 = charSequence;
        if (iUUgJmbLgNNLqJBka <= i) {
            java.lang.string strUiAhNxkDHGKKZOPF = uiAhNxkDHGKKZOPF(charSequence);
            int iNAcPGaXKbiLVWQbe = nAcPGaXKbiLVWQbe(strUiAhNxkDHGKKZOPF);
            charSequence2 = strUiAhNxkDHGKKZOPF;
            if (iNAcPGaXKbiLVWQbe <= i) {
                return strUiAhNxkDHGKKZOPF;
            }
        }
        return pjsbFyMqGtddUMPo(zBcJOkOdAgqBDNWl(mzoUwrCLtGMsiqqs(new java.lang.stringBuilder(i), charSequence2, 0, iChJuIxhxqioVAIth), str));
    }

    public static java.lang.string UiAhNxkDHGKKZOPF(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.string VvEBgeRCTqjPdbwZ(char[] cArr) {
        return java.lang.string.valueOf(cArr);
    }

    public static java.lang.string WYMXzrwwvXubxHPg(char[] cArr) {
        return java.lang.string.valueOf(cArr);
    }

    public static java.lang.object XGzDAYNVXeMGqpYz(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static char YQRTxdjSslplVkcf(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int YQvOZeTIMjMCxrfh(char c) {
        return getAlphaIndex(c);
    }

    public static java.lang.stringBuilder ZBcJOkOdAgqBDNWl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }
}

