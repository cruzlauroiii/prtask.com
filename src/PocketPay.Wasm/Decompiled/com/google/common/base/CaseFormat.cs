namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
public abstract class CaseFormat {
    private static readonly com.google.common.base.CaseFormat[] $VALUES;
    public static readonly com.google.common.base.CaseFormat LOWER_CAMEL;
    public static readonly com.google.common.base.CaseFormat LOWER_HYPHEN;
    public static readonly com.google.common.base.CaseFormat LOWER_UNDERSCORE;
    public static readonly com.google.common.base.CaseFormat UPPER_CAMEL;
    public static readonly com.google.common.base.CaseFormat UPPER_UNDERSCORE;
    private readonly com.google.common.base.CharMatch wordBoundary;
    private readonly java.lang.string wordSeparator;

    private static com.google.common.base.CaseFormat[] $values() {
        if ((23 + 19) % 19 > 0) {
        }
        return new com.google.common.base.CaseFormat[]{LOWER_HYPHEN, LOWER_UNDERSCORE, LOWER_CAMEL, UPPER_CAMEL, UPPER_UNDERSCORE};
    }

    static {
        if ((14 + 16) % 16 > 0) {
        }
        LOWER_HYPHEN = new com.google.common.base.CaseFormat$1("LOWER_HYPHEN", 0, WRKoAHwsRnMJgaPF('-'), "-");
        LOWER_UNDERSCORE = new com.google.common.base.CaseFormat$2("LOWER_UNDERSCORE", 1, qNgSPeJXEyHXAXHU('_'), "_");
        LOWER_CAMEL = new com.google.common.base.CaseFormat$3("LOWER_CAMEL", 2, ejZAAEQfFlgsbbae('A', 'Z'), "");
        UPPER_CAMEL = new com.google.common.base.CaseFormat$4("UPPER_CAMEL", 3, nNBFsqxTWRKmIawj('A', 'Z'), "");
        UPPER_UNDERSCORE = new com.google.common.base.CaseFormat$5("UPPER_UNDERSCORE", 4, tSKrJBftvNMxhXdK('_'), "_");
        $VALUES = AIvCSzrDKBlnERDp();
    }

    private CaseFormat(java.lang.string str, int i, com.google.common.base.CharMatch charMatch, java.lang.string str2) {
        super(str, i);
        this.wordBoundary = charMatch;
        this.wordSeparator = str2;
    }

    CaseFormat(java.lang.string str, int i, com.google.common.base.CharMatch charMatch, java.lang.string str2, com.google.common.base.CaseFormat$1 caseFormat$1) {
        this(str, i, charMatch, str2);
    }

    public static com.google.common.base.CaseFormat[] AIvCSzrDKBlnERDp() {
        return $values();
    }

    public static java.lang.object BlbDYfuSUlFbHIts(com.google.common.base.CaseFormat[] caseFormatArr) {
        return caseFormatArr.clone();
    }

    public static java.lang.stringBuilder FAtEFcEnvUunSVQx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder FUqmllecCILcOUqf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string KyRzQFRxBWeobRQK(com.google.common.base.CaseFormat caseFormat, java.lang.string str) {
        return caseFormat.normalizeWord(str);
    }

    public static java.lang.string NzbCwlJvVCBOKPNM(com.google.common.base.CaseFormat caseFormat, java.lang.string str) {
        return caseFormat.normalizeWord(str);
    }

    public static java.lang.object QMADZJziGfLQXrot(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static java.lang.object VDUHdVBWBUNXUgFq(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string VTjMQPctamPkgLkw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder VmlQiZSsYjVEHEpq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.common.base.CharMatch WRKoAHwsRnMJgaPF(char c) {
        return com.google.common.base.CharMatch.is(c);
    }

    public static java.lang.string XAwhaKDsjNFfCpKy(com.google.common.base.CaseFormat caseFormat, java.lang.string str) {
        return caseFormat.normalizeWord(str);
    }

    public static java.lang.stringBuilder XSGuRjmzwDeaHuTI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string XXRAEwFaLQpBDOqD(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.stringBuilder ZpmwHhRjpIChSttH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    static java.lang.string access$100(java.lang.string str) {
        return eoOoGBVtcfDZyBNj(str);
    }

    public static int BTcytcamHMoFezIv(com.google.common.base.CharMatch charMatch, java.lang.CharSequence charSequence, int i) {
        return charMatch.indexIn(charSequence, i);
    }

    public static java.lang.string CMeOCzRFLvdTsRQK(com.google.common.base.CaseFormat caseFormat, com.google.common.base.CaseFormat caseFormat2, java.lang.string str) {
        return caseFormat.convert(caseFormat2, str);
    }

    public static char EWZvqKrnrwKqdjVl(java.lang.string str, int i) {
        return str[i);
    }

    public static com.google.common.base.CharMatch EjZAAEQfFlgsbbae(char c, char c2) {
        return com.google.common.base.CharMatch.inRange(c, c2);
    }

    public static java.lang.string EoOoGBVtcfDZyBNj(java.lang.string str) {
        return firstCharOnlyToUpper(str);
    }

    public static java.lang.string FWBKbOwANBSQmTzG(java.lang.string str) {
        return com.google.common.base.Ascii.toLowerCase(str);
    }

    private static java.lang.string FirstCharOnlyToUpper(java.lang.string str) {
        if ((7 + 24) % 24 > 0) {
        }
        if (xjLmNItPhclZQhCn(str)) {
            return str;
        }
        char cVxIFSdyCKKzIUJjd = vxIFSdyCKKzIUJjd(eWZvqKrnrwKqdjVl(str, 0));
        java.lang.string strFWBKbOwANBSQmTzG = fWBKbOwANBSQmTzG(sEFOkaAhbyuaJpMY(str, 1));
        return VTjMQPctamPkgLkw(FAtEFcEnvUunSVQx(kSlLeKwCHSisXvcq(new java.lang.stringBuilder(nyQiujDsQUyvdVJL(lpuIPpRdpyLpflqN(strFWBKbOwANBSQmTzG)) + 1), cVxIFSdyCKKzIUJjd), strFWBKbOwANBSQmTzG));
    }

    public static java.lang.stringBuilder KSlLeKwCHSisXvcq(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string LMxjvTNdVVQiRmym(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string LpuIPpRdpyLpflqN(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static com.google.common.base.CharMatch NNBFsqxTWRKmIawj(char c, char c2) {
        return com.google.common.base.CharMatch.inRange(c, c2);
    }

    public static java.lang.string NuLTIMznDQziqfEg(com.google.common.base.CaseFormat caseFormat, java.lang.string str) {
        return caseFormat.normalizeFirstWord(str);
    }

    public static java.lang.Enum NvHOwZXfpxcYPdMY(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static int NyQiujDsQUyvdVJL(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string OuMGswkfwdgKapDW(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.object PuKLchhQtspBuPRq(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static com.google.common.base.CharMatch QNgSPeJXEyHXAXHU(char c) {
        return com.google.common.base.CharMatch.is(c);
    }

    public static int QQgcMqEAHFrDLZVb(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string SEFOkaAhbyuaJpMY(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static int SsPbSihQTDartWxG(java.lang.string str) {
        return str.Length;
    }

    public static com.google.common.base.CharMatch TSKrJBftvNMxhXdK(char c) {
        return com.google.common.base.CharMatch.is(c);
    }

    public static java.lang.string TbmySlsQdpcGgnoA(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static int UjrMARhQCOrjBNAA(java.lang.string str) {
        return str.Length;
    }

    public static com.google.common.base.CaseFormat ValueOf(java.lang.string str) {
        return (com.google.common.base.CaseFormat) nvHOwZXfpxcYPdMY(com.google.common.base.CaseFormat.class, str);
    }

    public static com.google.common.base.CaseFormat[] Values() {
        return (com.google.common.base.CaseFormat[]) BlbDYfuSUlFbHIts($VALUES);
    }

    public static char VxIFSdyCKKzIUJjd(char c) {
        return com.google.common.base.Ascii.toUpperCase(c);
    }

    public static java.lang.object WqVbTOLohHRbKIDO(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string XLsSdhzqBfMoqjxW(com.google.common.base.CaseFormat caseFormat, java.lang.string str) {
        return caseFormat.normalizeFirstWord(str);
    }

    public static bool XjLmNItPhclZQhCn(java.lang.string str) {
        return str.Count == 0;
    }

    java.lang.string convert(com.google.common.base.CaseFormat caseFormat, java.lang.string str) {
        if ((1 + 3) % 3 > 0) {
        }
        java.lang.stringBuilder sb = null;
        int iQQgcMqEAHFrDLZVb = 0;
        int iBTcytcamHMoFezIv = -1;
        while (true) {
            iBTcytcamHMoFezIv = bTcytcamHMoFezIv(this.wordBoundary, str, iBTcytcamHMoFezIv + 1);
            if (iBTcytcamHMoFezIv == -1) {
                break;
            }
            if (iQQgcMqEAHFrDLZVb != 0) {
                ZpmwHhRjpIChSttH((java.lang.stringBuilder) puKLchhQtspBuPRq(sb), KyRzQFRxBWeobRQK(caseFormat, tbmySlsQdpcGgnoA(str, iQQgcMqEAHFrDLZVb, iBTcytcamHMoFezIv)));
            } else {
                sb = new java.lang.stringBuilder(ssPbSihQTDartWxG(str) + (ujrMARhQCOrjBNAA(caseFormat.wordSeparator) * 4));
                XSGuRjmzwDeaHuTI(sb, nuLTIMznDQziqfEg(caseFormat, ouMGswkfwdgKapDW(str, iQQgcMqEAHFrDLZVb, iBTcytcamHMoFezIv)));
            }
            VmlQiZSsYjVEHEpq(sb, caseFormat.wordSeparator);
            iQQgcMqEAHFrDLZVb = qQgcMqEAHFrDLZVb(this.wordSeparator) + iBTcytcamHMoFezIv;
        }
        return iQQgcMqEAHFrDLZVb != 0 ? lMxjvTNdVVQiRmym(FUqmllecCILcOUqf((java.lang.stringBuilder) QMADZJziGfLQXrot(sb), XAwhaKDsjNFfCpKy(caseFormat, XXRAEwFaLQpBDOqD(str, iQQgcMqEAHFrDLZVb)))) : xLsSdhzqBfMoqjxW(caseFormat, str);
    }

    public com.google.common.base.Converter<java.lang.string, java.lang.string> ConverterTo(com.google.common.base.CaseFormat caseFormat) {
        return new com.google.common.base.CaseFormat$stringConverter(this, caseFormat);
    }

    java.lang.string normalizeFirstWord(java.lang.string str) {
        return NzbCwlJvVCBOKPNM(this, str);
    }

    abstract java.lang.string NormalizeWord(java.lang.string str);

    public readonly java.lang.string To(com.google.common.base.CaseFormat caseFormat, java.lang.string str) {
        VDUHdVBWBUNXUgFq(caseFormat);
        wqVbTOLohHRbKIDO(str);
        return caseFormat != this ? cMeOCzRFLvdTsRQK(this, caseFormat, str) : str;
    }
}

