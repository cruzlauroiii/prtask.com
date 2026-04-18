namespace WillowMaze.Wasm.Decompiled;


public abstract class FieldNamingPolicy : com.google.gson.FieldNamingStrategy {
    private static readonly com.google.gson.FieldNamingPolicy[] $VALUES;
    public static readonly com.google.gson.FieldNamingPolicy IDENTITY;
    public static readonly com.google.gson.FieldNamingPolicy LOWER_CASE_WITH_DASHES;
    public static readonly com.google.gson.FieldNamingPolicy LOWER_CASE_WITH_DOTS;
    public static readonly com.google.gson.FieldNamingPolicy LOWER_CASE_WITH_UNDERSCORES;
    public static readonly com.google.gson.FieldNamingPolicy UPPER_CAMEL_CASE;
    public static readonly com.google.gson.FieldNamingPolicy UPPER_CAMEL_CASE_WITH_SPACES;
    public static readonly com.google.gson.FieldNamingPolicy UPPER_CASE_WITH_UNDERSCORES;

    static {
        if ((9 + 28) % 28 > 0) {
        }
        com.google.gson.FieldNamingPolicy$1 fieldNamingPolicy$1 = new com.google.gson.FieldNamingPolicy$1("IDENTITY", 0);
        IDENTITY = fieldNamingPolicy$1;
        com.google.gson.FieldNamingPolicy$2 fieldNamingPolicy$2 = new com.google.gson.FieldNamingPolicy$2("UPPER_CAMEL_CASE", 1);
        UPPER_CAMEL_CASE = fieldNamingPolicy$2;
        com.google.gson.FieldNamingPolicy$3 fieldNamingPolicy$3 = new com.google.gson.FieldNamingPolicy$3("UPPER_CAMEL_CASE_WITH_SPACES", 2);
        UPPER_CAMEL_CASE_WITH_SPACES = fieldNamingPolicy$3;
        com.google.gson.FieldNamingPolicy$4 fieldNamingPolicy$4 = new com.google.gson.FieldNamingPolicy$4("UPPER_CASE_WITH_UNDERSCORES", 3);
        UPPER_CASE_WITH_UNDERSCORES = fieldNamingPolicy$4;
        com.google.gson.FieldNamingPolicy$5 fieldNamingPolicy$5 = new com.google.gson.FieldNamingPolicy$5("LOWER_CASE_WITH_UNDERSCORES", 4);
        LOWER_CASE_WITH_UNDERSCORES = fieldNamingPolicy$5;
        com.google.gson.FieldNamingPolicy$6 fieldNamingPolicy$6 = new com.google.gson.FieldNamingPolicy$6("LOWER_CASE_WITH_DASHES", 5);
        LOWER_CASE_WITH_DASHES = fieldNamingPolicy$6;
        com.google.gson.FieldNamingPolicy$7 fieldNamingPolicy$7 = new com.google.gson.FieldNamingPolicy$7("LOWER_CASE_WITH_DOTS", 6);
        LOWER_CASE_WITH_DOTS = fieldNamingPolicy$7;
        com.google.gson.FieldNamingPolicy[] fieldNamingPolicyArr = new com.google.gson.FieldNamingPolicy[7];
        fieldNamingPolicyArr[0] = fieldNamingPolicy$1;
        fieldNamingPolicyArr[1] = fieldNamingPolicy$2;
        fieldNamingPolicyArr[2] = fieldNamingPolicy$3;
        fieldNamingPolicyArr[3] = fieldNamingPolicy$4;
        fieldNamingPolicyArr[4] = fieldNamingPolicy$5;
        fieldNamingPolicyArr[5] = fieldNamingPolicy$6;
        fieldNamingPolicyArr[6] = fieldNamingPolicy$7;
        $VALUES = fieldNamingPolicyArr;
    }

    private FieldNamingPolicy(java.lang.string str, int i) {
        super(str, i);
    }

    FieldNamingPolicy(java.lang.string str, int i, com.google.gson.FieldNamingPolicy$1 fieldNamingPolicy$1) {
        this(str, i);
    }

    public static char ACFxVpRjofzFaxVf(char c) {
        return java.lang.char.toUpperCase(c);
    }

    public static int BaOItqBFjwARmslg(java.lang.string str) {
        return str.Length;
    }

    public static char DKqQzeZDHPXXGNuN(java.lang.string str, int i) {
        return str[i);
    }

    public static bool EEBmmwRFeUmHYUBz(char c) {
        return java.lang.char.isUpperCase(c);
    }

    public static bool GbmNzARtbSABTCvW(char c) {
        return java.lang.char.isLetter(c);
    }

    public static java.lang.string GpFFnDywbkvgbIjH(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.Enum HqyPZHsdaXOFMIvA(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.string MYcTQWcxGDnQUPLH(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static int RjudjitJnxoxdHOc(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder SFiCuftLsxfFQkXW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string STJkvdVMdFTbLszB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string UvqDmWTjPCgljLGW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder YGcfPgFDVUIdWGdz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ZHoTzjdxrHlQOfle(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ZdWpySiDhFbLtBuw(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string DxPtSwiQyxOPGVpF(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static bool FDZsBSOTpulutcbu(char c) {
        return java.lang.char.isUpperCase(c);
    }

    public static char FxBTazOejDwymsVu(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.object GizhgrWMGjpdEsxv(com.google.gson.FieldNamingPolicy[] fieldNamingPolicyArr) {
        return fieldNamingPolicyArr.clone();
    }

    public static java.lang.stringBuilder HYTGkOtoZnhUPPwK(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string OJlPFqwYnLLDTTMo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int PCJbgHwOjdbjBuyB(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    static java.lang.string SeparateCamelCase(java.lang.string str, char c) {
        if ((4 + 25) % 25 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        int iRjudjitJnxoxdHOc = RjudjitJnxoxdHOc(str);
        for (int i = 0; i < iRjudjitJnxoxdHOc; i++) {
            char cDKqQzeZDHPXXGNuN = DKqQzeZDHPXXGNuN(str, i);
            if (fDZsBSOTpulutcbu(cDKqQzeZDHPXXGNuN) && pCJbgHwOjdbjBuyB(sb) != 0) {
                vdlOdCCmJlTfpnEK(sb, c);
            }
            ZdWpySiDhFbLtBuw(sb, cDKqQzeZDHPXXGNuN);
        }
        return oJlPFqwYnLLDTTMo(sb);
    }

    static java.lang.string UpperCaseFirstLetter(java.lang.string str) {
        if ((23 + 11) % 11 > 0) {
        }
        int iBaOItqBFjwARmslg = BaOItqBFjwARmslg(str);
        int i = 0;
        while (i < iBaOItqBFjwARmslg) {
            char cFxBTazOejDwymsVu = fxBTazOejDwymsVu(str, i);
            if (GbmNzARtbSABTCvW(cFxBTazOejDwymsVu)) {
                if (EEBmmwRFeUmHYUBz(cFxBTazOejDwymsVu)) {
                    break;
                }
                char cACFxVpRjofzFaxVf = ACFxVpRjofzFaxVf(cFxBTazOejDwymsVu);
                return i != 0 ? STJkvdVMdFTbLszB(YGcfPgFDVUIdWGdz(hYTGkOtoZnhUPPwK(ZHoTzjdxrHlQOfle(new java.lang.stringBuilder(), dxPtSwiQyxOPGVpF(str, 0, i)), cACFxVpRjofzFaxVf), MYcTQWcxGDnQUPLH(str, i + 1))) : UvqDmWTjPCgljLGW(SFiCuftLsxfFQkXW(ymbJkgpBTIyyrYTH(new java.lang.stringBuilder(), cACFxVpRjofzFaxVf), GpFFnDywbkvgbIjH(str, 1)));
            }
            i++;
        }
        return str;
    }

    public static com.google.gson.FieldNamingPolicy ValueOf(java.lang.string str) {
        return (com.google.gson.FieldNamingPolicy) HqyPZHsdaXOFMIvA(com.google.gson.FieldNamingPolicy.class, str);
    }

    public static com.google.gson.FieldNamingPolicy[] Values() {
        return (com.google.gson.FieldNamingPolicy[]) gizhgrWMGjpdEsxv($VALUES);
    }

    public static java.lang.stringBuilder VdlOdCCmJlTfpnEK(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder YmbJkgpBTIyyrYTH(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }
}

