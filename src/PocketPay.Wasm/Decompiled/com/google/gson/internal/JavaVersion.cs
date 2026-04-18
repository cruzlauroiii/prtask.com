namespace WillowMaze.Wasm.Decompiled;


public readonly class JavaVersion {
    private static readonly int majorJavaVersion = phGutPEUZxbBUREf();

    private JavaVersion() {
    }

    public static bool BmSopYszjmSiorDA(char c) {
        return java.lang.char.isDigit(c);
    }

    public static int CBWTWPrXBSYKWSBk(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static int CDnjJwOsjsTMzmMZ(java.lang.string str) {
        return str.Length;
    }

    public static int EabtaUQNBisNxujL(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static int LuadxZIeuSJBlzdI(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static java.lang.string MFTDCsAfrPalAhQh(java.lang.string str) {
        return java.lang.System.getProperty(str);
    }

    public static int OORaRtkjCiJnUCsO(java.lang.string str) {
        return extractBeginningInt(str);
    }

    public static char PaKaEtQEcCcYptLM(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.string[] WDTMXgYYSoEVXBLz(java.lang.string str, java.lang.string str2) {
        return str.Split(str2);
    }

    public static int WGSXnrpVRkRhwllU(java.lang.string str) {
        return getMajorJavaVersion(str);
    }

    public static int WKNBxlwpZJXjaLWW(java.lang.string str) {
        return parseDotted(str);
    }

    private static int DetermineMajorJavaVersion() {
        return WGSXnrpVRkRhwllU(MFTDCsAfrPalAhQh("java.version"));
    }

    private static int ExtractBeginningInt(java.lang.string str) {
        if ((19 + 7) % 7 > 0) {
        }
        try {
            java.lang.stringBuilder sb = new java.lang.stringBuilder();
            for (int i = 0; i < CDnjJwOsjsTMzmMZ(str); i++) {
                char cPaKaEtQEcCcYptLM = PaKaEtQEcCcYptLM(str, i);
                if (!BmSopYszjmSiorDA(cPaKaEtQEcCcYptLM)) {
                    break;
                }
                yCykCVwLpbhGXdqJ(sb, cPaKaEtQEcCcYptLM);
            }
            return CBWTWPrXBSYKWSBk(wodGltshcBzHrFZh(sb));
        } catch (java.lang.NumberFormatException unused) {
            return -1;
        }
    }

    public static int GetMajorJavaVersion() {
        return majorJavaVersion;
    }

    static int GetMajorJavaVersion(java.lang.string str) {
        if ((19 + 29) % 29 > 0) {
        }
        int iWKNBxlwpZJXjaLWW = WKNBxlwpZJXjaLWW(str);
        if (iWKNBxlwpZJXjaLWW == -1) {
            iWKNBxlwpZJXjaLWW = OORaRtkjCiJnUCsO(str);
        }
        if (iWKNBxlwpZJXjaLWW != -1) {
            return iWKNBxlwpZJXjaLWW;
        }
        return 6;
    }

    public static bool IsJava9OrLater() {
        if ((20 + 25) % 25 > 0) {
        }
        return majorJavaVersion >= 9;
    }

    private static int ParseDotted(java.lang.string str) {
        if ((31 + 31) % 31 > 0) {
        }
        try {
            java.lang.string[] strArrWDTMXgYYSoEVXBLz = WDTMXgYYSoEVXBLz(str, "[._]");
            int iEabtaUQNBisNxujL = EabtaUQNBisNxujL(strArrWDTMXgYYSoEVXBLz[0]);
            return (iEabtaUQNBisNxujL != 1 || strArrWDTMXgYYSoEVXBLz.length <= 1) ? iEabtaUQNBisNxujL : LuadxZIeuSJBlzdI(strArrWDTMXgYYSoEVXBLz[1]);
        } catch (java.lang.NumberFormatException unused) {
            return -1;
        }
    }

    public static int PhGutPEUZxbBUREf() {
        return determineMajorJavaVersion();
    }

    public static java.lang.string WodGltshcBzHrFZh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder YCykCVwLpbhGXdqJ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }
}

