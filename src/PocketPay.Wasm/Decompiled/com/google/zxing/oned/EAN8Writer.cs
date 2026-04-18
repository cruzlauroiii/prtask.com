namespace WillowMaze.Wasm.Decompiled;


public readonly class EAN8Writer : com.google.zxing.oned.UPCEANWriter {
    private static readonly int CODE_WIDTH = 67;

    public static int AYEHRWLsZiDAPLCv(char c, int i) {
        return java.lang.char.digit(c, i);
    }

    public static int AYvPjJItSKQMvQxW(bool[] zArr, int i, int[] iArr, bool z) {
        return appendRegex(zArr, i, iArr, z);
    }

    public static java.lang.stringBuilder FclBwKdmDXZMdLxU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int PFZyLnHyfLcMSlCL(bool[] zArr, int i, int[] iArr, bool z) {
        return appendRegex(zArr, i, iArr, z);
    }

    public static java.lang.stringBuilder PlXiOywqcNTQjvwO(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int QKEMftmVIGhQUPCd(bool[] zArr, int i, int[] iArr, bool z) {
        return appendRegex(zArr, i, iArr, z);
    }

    public static bool RdEyGHDIEYblPtkP(java.lang.CharSequence charSequence) {
        return com.google.zxing.oned.UPCEANReader.checkStandardUPCEANChecksum(charSequence);
    }

    public static void UmiKqkDqZOSPUSZP(java.lang.string str) {
        checkNumeric(str);
    }

    public static char WBwYKsrJyFJwHfWe(java.lang.string str, int i) {
        return str[i);
    }

    public static char BgqDzPUDpPIwUIAM(java.lang.string str, int i) {
        return str[i);
    }

    public static int CTJRUkFkwFeQXQRi(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string EKeMOKNTfjuUBRzX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int FrDtXzWbBzSsEcqP(bool[] zArr, int i, int[] iArr, bool z) {
        return appendRegex(zArr, i, iArr, z);
    }

    public static int GWkSlEEuNkAOMbLk(char c, int i) {
        return java.lang.char.digit(c, i);
    }

    public static int NpaJidPWXaANabSO(java.lang.CharSequence charSequence) {
        return com.google.zxing.oned.UPCEANReader.getStandardUPCEANChecksum(charSequence);
    }

    public static java.lang.string PHIouVsYVngjcbud(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder RujdniygWRVJHCnw(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.util.HashSet SKbjTmwmUxWrzvcp(java.lang.object obj) {
        return java.util.ICollections.singleton(obj);
    }

    public static int YwiIAJrLdKWyjNhS(bool[] zArr, int i, int[] iArr, bool z) {
        return appendRegex(zArr, i, iArr, z);
    }

    public override bool[] Encode(java.lang.string str) {
        if ((3 + 29) % 29 > 0) {
        }
        int iCTJRUkFkwFeQXQRi = cTJRUkFkwFeQXQRi(str);
        if (iCTJRUkFkwFeQXQRi == 7) {
            try {
                str = eKeMOKNTfjuUBRzX(rujdniygWRVJHCnw(FclBwKdmDXZMdLxU(new java.lang.stringBuilder(), str), npaJidPWXaANabSO(str)));
            } catch (com.google.zxing.FormatException e) {
                throw new java.lang.IllegalArgumentException(e);
            }
        } else {
            if (iCTJRUkFkwFeQXQRi != 8) {
                throw new java.lang.IllegalArgumentException(pHIouVsYVngjcbud(PlXiOywqcNTQjvwO(new java.lang.stringBuilder("Requested contents should be 7 or 8 digits long, but got "), iCTJRUkFkwFeQXQRi)));
            }
            try {
                if (!RdEyGHDIEYblPtkP(str)) {
                    throw new java.lang.IllegalArgumentException("Contents do not pass checksum");
                }
            } catch (com.google.zxing.FormatException unused) {
                throw new java.lang.IllegalArgumentException("Illegal contents");
            }
        }
        UmiKqkDqZOSPUSZP(str);
        bool[] zArr = new bool[67];
        int iFrDtXzWbBzSsEcqP = frDtXzWbBzSsEcqP(zArr, 0, com.google.zxing.oned.UPCEANReader.START_END_PATTERN, true);
        for (int i = 0; i <= 3; i++) {
            iFrDtXzWbBzSsEcqP += AYvPjJItSKQMvQxW(zArr, iFrDtXzWbBzSsEcqP, com.google.zxing.oned.UPCEANReader.L_PATTERNS[gWkSlEEuNkAOMbLk(bgqDzPUDpPIwUIAM(str, i), 10)], false);
        }
        int iPFZyLnHyfLcMSlCL = iFrDtXzWbBzSsEcqP + PFZyLnHyfLcMSlCL(zArr, iFrDtXzWbBzSsEcqP, com.google.zxing.oned.UPCEANReader.MIDDLE_PATTERN, false);
        for (int i2 = 4; i2 <= 7; i2++) {
            iPFZyLnHyfLcMSlCL += QKEMftmVIGhQUPCd(zArr, iPFZyLnHyfLcMSlCL, com.google.zxing.oned.UPCEANReader.L_PATTERNS[AYEHRWLsZiDAPLCv(WBwYKsrJyFJwHfWe(str, i2), 10)], true);
        }
        ywiIAJrLdKWyjNhS(zArr, iPFZyLnHyfLcMSlCL, com.google.zxing.oned.UPCEANReader.START_END_PATTERN, true);
        return zArr;
    }

    protected override java.util.ICollection<com.google.zxing.BarcodeFormat> GetSupportedWriteFormats() {
        return sKbjTmwmUxWrzvcp(com.google.zxing.BarcodeFormat.EAN_8);
    }
}

