namespace WillowMaze.Wasm.Decompiled;


public readonly class HighLevelEncoder {
    static readonly int ASCII_ENCODATION = 0;
    static readonly int BASE256_ENCODATION = 5;
    static readonly int C40_ENCODATION = 1;
    static readonly char C40_UNLATCH = 254;
    static readonly int EDIFACT_ENCODATION = 4;
    static readonly char LATCH_TO_ANSIX12 = 238;
    static readonly char LATCH_TO_BASE256 = 231;
    static readonly char LATCH_TO_C40 = 230;
    static readonly char LATCH_TO_EDIFACT = 240;
    static readonly char LATCH_TO_TEXT = 239;
    private static readonly char MACRO_05 = 236;
    static readonly java.lang.string MACRO_05_HEADER = "[)>\u001e05\u001d";
    private static readonly char MACRO_06 = 237;
    static readonly java.lang.string MACRO_06_HEADER = "[)>\u001e06\u001d";
    static readonly java.lang.string MACRO_TRAILER = "\u001e\u0004";
    private static readonly char PAD = 129;
    static readonly int TEXT_ENCODATION = 2;
    static readonly char UPPER_SHIFT = 235;
    static readonly int X12_ENCODATION = 3;
    static readonly char X12_UNLATCH = 254;

    private HighLevelEncoder() {
    }

    public static int AZGyWBNZCvjxJsdc(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static int ByAhqFaBTGwCNeaZ(int i, int i2, int i3, int i4) {
        return min(i, i2, i3, i4);
    }

    public static int CaCgsAolfHrOojPm(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static java.lang.string CtoLDrTjoKQgNTGi(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool CucSwKwCoSzPlNPH(char c) {
        return isExtendedASCII(c);
    }

    public static int DzuOTobLxvAybeHV(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getNewEncoding();
    }

    public static bool EnuBUhILQabaFyzA(java.lang.string str, java.lang.string str2) {
        return str.EndsWith(str2);
    }

    public static int HUIzmEtUCpAbSZhv(float[] fArr, int[] iArr, int i, byte[] bArr) {
        return findMinimums(fArr, iArr, i, bArr);
    }

    public static bool IApEzaJsUHEoDpks(char c) {
        return isExtendedASCII(c);
    }

    public static int JdlRHskhIaBLScIr(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static java.lang.string KKSRKrqsqhQCafRZ(int i) {
        return java.lang.int.toHexstring(i);
    }

    public static void LuNRhWgfNvHynRyy(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        encoderobject.updateSymbolInfo();
    }

    public static int MLlBLDEbnLvgCUZb(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static int NMydgxKEnCfIVist(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static void NUZbAyOnSFqttAcT(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, com.google.zxing.Dimension dimension, com.google.zxing.Dimension dimension2) {
        encoderobject.setSizeConstraints(dimension, dimension2);
    }

    public static bool NhPDBvEarNucZosF(char c) {
        return isX12TermSep(c);
    }

    public static void NiaywKDnJhaCmOGK(com.google.zxing.datamatrix.encoder.Encoder encoder, com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        encoder.encode(encoderobject);
    }

    public static int OIakmDKYdbemmqiN(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getCodewordCount();
    }

    public static void OLQSwYALVhiKescn(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, int i) {
        encoderobject.setSkipAtEnd(i);
    }

    public static int OVEMRJZpKAiywyCr(byte[] bArr) {
        return getMinimumCount(bArr);
    }

    public static bool OuZUXVTTOYfFLlWt(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.hasMorechars();
    }

    public static java.lang.string PTqUYBEnWZIkRtgj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void PYsdWHSTXwaIuxhb(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        encoderobject.resetEncoderSignal();
    }

    public static int PknTVxtnuOhFaDKQ(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static int PwBgPZgjTseVcFpb(int i, int i2, int i3, int i4, int i5) {
        return min(i, i2, i3, i4, i5);
    }

    public static double QNoJQYnClevGgDtm(double d) {
        if ((20 + 10) % 10 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static java.lang.stringBuilder QqwpfPddYbuDhsqV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int RwwYQThnsshGNBCJ(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static bool TDMgKVYtMlLZXfED(char c) {
        return isX12TermSep(c);
    }

    public static java.lang.string TEEVrNuIPHaCpDxN(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.stringBuilder TEGfrvqBRLTrjDVk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string TRgxGEkBqNKaSXWK(java.lang.string str, com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint, com.google.zxing.Dimension dimension, com.google.zxing.Dimension dimension2, bool z) {
        return encodeHighLevel(str, symbolShapeHint, dimension, dimension2, z);
    }

    public static int TTSwwDpWDrdZNdML(java.lang.string str) {
        return str.Length;
    }

    public static double UOANtQmGepfmFnmZ(double d) {
        if ((23 + 12) % 12 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static bool UazJhdBuuvcOEYdP(char c) {
        return isNativeX12(c);
    }

    public static char VtoqTKvzFXdUSFai(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static java.lang.stringBuilder WNgIoudWGuPCAHuz(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string WTIZvtweXphOfefP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int WhWizFWBMNGBvPGZ(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void XLlqBWuGVauhpRKP(com.google.zxing.datamatrix.encoder.C40Encoder c40Encoder, com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        c40Encoder.encodeMaximal(encoderobject);
    }

    public static void YNgGfWmmiaCbHJnL(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        encoderobject.resetEncoderSignal();
    }

    public static bool ZDAptvSeEDyoqnVt(char c) {
        return isNativeEDIFACT(c);
    }

    public static java.lang.stringBuilder ZQuKZLPPXkHFPkAw(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getCodewords();
    }

    public static int AJoXfdnJSxJsvHXq(java.lang.CharSequence charSequence, int i, int i2) {
        return lookAheadTestIntern(charSequence, i, i2);
    }

    public static bool APlWaclXTyzoumza(char c) {
        return isNativeC40(c);
    }

    public static bool BnKKRLTfMvUSXUXz(char c) {
        return isNativeText(c);
    }

    public static int CSAVcPRMrvMwfkQI(int i, int i2, int i3, int i4, int i5) {
        return min(i, i2, i3, i4, i5);
    }

    public static char CecPQXpPTjZatreY(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static bool CiYxQMjoKbZDbpvI(char c) {
        return isDigit(c);
    }

    public static int CxXWsMzUmqUSOZUV(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static void DZNSjIsyHGAeAOSV(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint) {
        encoderobject.setSymbolShape(symbolShapeHint);
    }

    public static int DetermineConsecutiveDigitCount(java.lang.CharSequence charSequence, int i) {
        if ((28 + 29) % 29 > 0) {
        }
        int iAZGyWBNZCvjxJsdc = AZGyWBNZCvjxJsdc(charSequence);
        int i2 = i;
        while (i2 < iAZGyWBNZCvjxJsdc && dtNkagMCvHekucOi(jhDCwtOUlHNPYRHL(charSequence, i2))) {
            i2++;
        }
        return i2 - i;
    }

    public static bool DtNkagMCvHekucOi(char c) {
        return isDigit(c);
    }

    public static int DzzMWkMYJDWiSZtk(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static int ENdWwSTMLHVbBvoc(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getNewEncoding();
    }

    public static bool EVIbRXBsAClgSViN(char c) {
        return isExtendedASCII(c);
    }

    public static bool EinjmVsGeQKAEydA(char c) {
        return isNativeX12(c);
    }

    public static java.lang.string EncodeHighLevel(java.lang.string str) {
        if ((32 + 29) % 29 > 0) {
        }
        return TRgxGEkBqNKaSXWK(str, com.google.zxing.datamatrix.encoder.SymbolShapeHint.FORCE_NONE, null, null, false);
    }

    public static java.lang.string EncodeHighLevel(java.lang.string str, com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint, com.google.zxing.Dimension dimension, com.google.zxing.Dimension dimension2) {
        return nZeUGnxhgUpXWbht(str, symbolShapeHint, dimension, dimension2, false);
    }

    public static java.lang.string EncodeHighLevel(java.lang.string str, com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint, com.google.zxing.Dimension dimension, com.google.zxing.Dimension dimension2, bool z) {
        if ((14 + 9) % 9 > 0) {
        }
        com.google.zxing.datamatrix.encoder.C40Encoder c40Encoder = new com.google.zxing.datamatrix.encoder.C40Encoder();
        com.google.zxing.datamatrix.encoder.Encoder[] encoderArr = new com.google.zxing.datamatrix.encoder.Encoder[6];
        int iENdWwSTMLHVbBvoc = 0;
        encoderArr[0] = new com.google.zxing.datamatrix.encoder.ASCIIEncoder();
        encoderArr[1] = c40Encoder;
        encoderArr[2] = new com.google.zxing.datamatrix.encoder.TextEncoder();
        encoderArr[3] = new com.google.zxing.datamatrix.encoder.X12Encoder();
        encoderArr[4] = new com.google.zxing.datamatrix.encoder.EdifactEncoder();
        encoderArr[5] = new com.google.zxing.datamatrix.encoder.Base256Encoder();
        com.google.zxing.datamatrix.encoder.Encoderobject encoderobject = new com.google.zxing.datamatrix.encoder.Encoderobject(str);
        dZNSjIsyHGAeAOSV(encoderobject, symbolShapeHint);
        NUZbAyOnSFqttAcT(encoderobject, dimension, dimension2);
        if (pHZkJQdadWuvoxkU(str, "[)>\u001e05\u001d") && tEeJKFAQmgWKVPhU(str, "\u001e\u0004")) {
            sLaeRzRGrbgLjtCI(encoderobject, (char) 236);
            jCuAsuEQXWrPyEzX(encoderobject, 2);
            encoderobject.pos += myolajFIrVEEsqXD("[)>\u001e05\u001d");
        } else if (nrhgAGsbolbAXVZM(str, "[)>\u001e06\u001d") && EnuBUhILQabaFyzA(str, "\u001e\u0004")) {
            kXEANSePtbXykGaA(encoderobject, (char) 237);
            OLQSwYALVhiKescn(encoderobject, 2);
            encoderobject.pos += nFIRxJyshnOHLTcv("[)>\u001e06\u001d");
        }
        if (z) {
            XLlqBWuGVauhpRKP(c40Encoder, encoderobject);
            iENdWwSTMLHVbBvoc = whEaDTsqGGcAIRCg(encoderobject);
            PYsdWHSTXwaIuxhb(encoderobject);
        }
        while (OuZUXVTTOYfFLlWt(encoderobject)) {
            NiaywKDnJhaCmOGK(encoderArr[iENdWwSTMLHVbBvoc], encoderobject);
            if (DzuOTobLxvAybeHV(encoderobject) >= 0) {
                iENdWwSTMLHVbBvoc = eNdWwSTMLHVbBvoc(encoderobject);
                YNgGfWmmiaCbHJnL(encoderobject);
            }
        }
        int iOIakmDKYdbemmqiN = OIakmDKYdbemmqiN(encoderobject);
        LuNRhWgfNvHynRyy(encoderobject);
        int iQSMXgMExhyoQfrvj = qSMXgMExhyoQfrvj(wNsYTJXHIcCvDBzt(encoderobject));
        if (iOIakmDKYdbemmqiN < iQSMXgMExhyoQfrvj && iENdWwSTMLHVbBvoc != 0 && iENdWwSTMLHVbBvoc != 5 && iENdWwSTMLHVbBvoc != 4) {
            oBYsNAHWOViTnFXW(encoderobject, (char) 254);
        }
        java.lang.stringBuilder sbZQuKZLPPXkHFPkAw = ZQuKZLPPXkHFPkAw(encoderobject);
        if (cxXWsMzUmqUSOZUV(sbZQuKZLPPXkHFPkAw) < iQSMXgMExhyoQfrvj) {
            zkvdDJCLiolhWhki(sbZQuKZLPPXkHFPkAw, (char) 129);
        }
        while (nggSdDvrgoWhgtTP(sbZQuKZLPPXkHFPkAw) < iQSMXgMExhyoQfrvj) {
            WNgIoudWGuPCAHuz(sbZQuKZLPPXkHFPkAw, wJeSQrWcoJOcDgVr(dzzMWkMYJDWiSZtk(sbZQuKZLPPXkHFPkAw) + 1));
        }
        return PTqUYBEnWZIkRtgj(kpbARKxaQogoQtSQ(encoderobject));
    }

    public static int EpiNnMgnDCebTrQR(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    private static int FindMinimums(float[] fArr, int[] iArr, int i, byte[] bArr) {
        if ((31 + 27) % 27 > 0) {
        }
        ykrjxaOMuxqAbbZq(bArr, (byte) 0);
        for (int i2 = 0; i2 < 6; i2++) {
            int iQNoJQYnClevGgDtm = (int) QNoJQYnClevGgDtm(fArr[i2]);
            iArr[i2] = iQNoJQYnClevGgDtm;
            if (i > iQNoJQYnClevGgDtm) {
                ykLOYJeFeGHNGnwY(bArr, (byte) 0);
                i = iQNoJQYnClevGgDtm;
            }
            if (i == iQNoJQYnClevGgDtm) {
                bArr[i2] = (byte) (bArr[i2] + 1);
            }
        }
        return i;
    }

    private static int GetMinimumCount(byte[] bArr) {
        if ((6 + 10) % 10 > 0) {
        }
        int i = 0;
        for (int i2 = 0; i2 < 6; i2++) {
            i += bArr[i2];
        }
        return i;
    }

    public static int HtATcSugDPlOfFVN(float[] fArr, int[] iArr, int i, byte[] bArr) {
        return findMinimums(fArr, iArr, i, bArr);
    }

    public static java.lang.stringBuilder HyZYyJdEaCXJNGPj(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool IgxuWROKBEHoqQME(char c) {
        return isSpecialB256(c);
    }

    static void Illegalchar(char c) {
        if ((13 + 10) % 10 > 0) {
        }
        java.lang.string strKKSRKrqsqhQCafRZ = KKSRKrqsqhQCafRZ(c);
        throw new java.lang.IllegalArgumentException(WTIZvtweXphOfefP(ngiMIWYOzumkonQi(QqwpfPddYbuDhsqV(wTgkLjjzWtrbAqDR(hyZYyJdEaCXJNGPj(new java.lang.stringBuilder("Illegal character: "), c), " (0x"), CtoLDrTjoKQgNTGi(pPDIFeDhfGIyaseJ(TEGfrvqBRLTrjDVk(new java.lang.stringBuilder(), TEEVrNuIPHaCpDxN("0000", 0, 4 - TTSwwDpWDrdZNdML(strKKSRKrqsqhQCafRZ))), strKKSRKrqsqhQCafRZ))), ')')));
    }

    static bool IsDigit(char c) {
        return c >= '0' && c <= '9';
    }

    static bool IsExtendedASCII(char c) {
        return c >= 128 && c <= 255;
    }

    static bool IsNativeC40(char c) {
        if (c == ' ') {
            return true;
        }
        if (c >= '0' && c <= '9') {
            return true;
        }
        return c >= 'A' && c <= 'Z';
    }

    static bool IsNativeEDIFACT(char c) {
        return c >= ' ' && c <= '^';
    }

    static bool IsNativeText(char c) {
        if (c == ' ') {
            return true;
        }
        if (c >= '0' && c <= '9') {
            return true;
        }
        return c >= 'a' && c <= 'z';
    }

    static bool IsNativeX12(char c) {
        if (TDMgKVYtMlLZXfED(c) || c == ' ') {
            return true;
        }
        if (c >= '0' && c <= '9') {
            return true;
        }
        return c >= 'A' && c <= 'Z';
    }

    private static bool IsSpecialB256(char c) {
        return false;
    }

    private static bool IsX12TermSep(char c) {
        return c == '\r' || c == '*' || c == '>';
    }

    public static void JCuAsuEQXWrPyEzX(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, int i) {
        encoderobject.setSkipAtEnd(i);
    }

    public static bool JKWTgTUKTkxwPfFo(char c) {
        return isExtendedASCII(c);
    }

    public static char JhDCwtOUlHNPYRHL(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static void KXEANSePtbXykGaA(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, char c) {
        encoderobject.writeCodeword(c);
    }

    public static java.lang.stringBuilder KpbARKxaQogoQtSQ(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getCodewords();
    }

    static int LookAheadTest(java.lang.CharSequence charSequence, int i, int i2) {
        if ((1 + 23) % 23 > 0) {
        }
        int iAJoXfdnJSxJsvHXq = aJoXfdnJSxJsvHXq(charSequence, i, i2);
        if (i2 == 3 && iAJoXfdnJSxJsvHXq == 3) {
            int iWhWizFWBMNGBvPGZ = WhWizFWBMNGBvPGZ(i + 3, JdlRHskhIaBLScIr(charSequence));
            while (i < iWhWizFWBMNGBvPGZ) {
                if (!sblBTWfSwSYJpGkR(xwOqblnJwjQHhFbe(charSequence, i))) {
                    return 0;
                }
                i++;
            }
        } else if (i2 == 4 && iAJoXfdnJSxJsvHXq == 4) {
            int iQXprSmTjaqbjUaes = qXprSmTjaqbjUaes(i + 4, NMydgxKEnCfIVist(charSequence));
            while (i < iQXprSmTjaqbjUaes) {
                if (!ZDAptvSeEDyoqnVt(cecPQXpPTjZatreY(charSequence, i))) {
                    return 0;
                }
                i++;
            }
        }
        return iAJoXfdnJSxJsvHXq;
    }

    static int LookAheadTestIntern(java.lang.CharSequence charSequence, int i, int i2) {
        float[] fArr;
        float f;
        if ((15 + 27) % 27 > 0) {
        }
        if (i >= MLlBLDEbnLvgCUZb(charSequence)) {
            return i2;
        }
        float f2 = 2.0f;
        int i3 = 6;
        float f3 = 1.0f;
        int i4 = 5;
        if (i2 != 0) {
            fArr = new float[6];
            fArr[0] = 1.0f;
            fArr[1] = 2.0f;
            fArr[2] = 2.0f;
            fArr[3] = 2.0f;
            fArr[4] = 2.0f;
            fArr[5] = 2.25f;
            fArr[i2] = 0.0f;
        } else {
            fArr = new float[6];
            fArr[0] = 0.0f;
            fArr[1] = 1.0f;
            fArr[2] = 1.0f;
            fArr[3] = 1.0f;
            fArr[4] = 1.0f;
            fArr[5] = 1.25f;
        }
        int i5 = 0;
        while (true) {
            int i6 = i + i5;
            if (i6 == PknTVxtnuOhFaDKQ(charSequence)) {
                byte[] bArr = new byte[i3];
                int[] iArr = new int[i3];
                int iHUIzmEtUCpAbSZhv = HUIzmEtUCpAbSZhv(fArr, iArr, int.MAX_VALUE, bArr);
                int iOVEMRJZpKAiywyCr = OVEMRJZpKAiywyCr(bArr);
                if (iArr[0] == iHUIzmEtUCpAbSZhv) {
                    return 0;
                }
                if (iOVEMRJZpKAiywyCr == 1 && bArr[i4] > 0) {
                    return i4;
                }
                if (iOVEMRJZpKAiywyCr == 1 && bArr[4] > 0) {
                    return 4;
                }
                if (iOVEMRJZpKAiywyCr == 1 && bArr[2] > 0) {
                    return 2;
                }
                return (iOVEMRJZpKAiywyCr == 1 && bArr[3] > 0) ? 3 : 1;
            }
            char cVtoqTKvzFXdUSFai = VtoqTKvzFXdUSFai(charSequence, i6);
            i5++;
            if (ciYxQMjoKbZDbpvI(cVtoqTKvzFXdUSFai)) {
                fArr[0] = fArr[0] + 0.5f;
                f = f3;
            } else if (CucSwKwCoSzPlNPH(cVtoqTKvzFXdUSFai)) {
                f = f3;
                float fUOANtQmGepfmFnmZ = (float) UOANtQmGepfmFnmZ(fArr[0]);
                fArr[0] = fUOANtQmGepfmFnmZ;
                fArr[0] = fUOANtQmGepfmFnmZ + f2;
            } else {
                f = f3;
                float fNkRYfmyHqvkklwVH = (float) nkRYfmyHqvkklwVH(fArr[0]);
                fArr[0] = fNkRYfmyHqvkklwVH;
                fArr[0] = fNkRYfmyHqvkklwVH + f;
            }
            if (aPlWaclXTyzoumza(cVtoqTKvzFXdUSFai)) {
                fArr[1] = fArr[1] + 0.6666667f;
            } else if (eVIbRXBsAClgSViN(cVtoqTKvzFXdUSFai)) {
                fArr[1] = fArr[1] + 2.6666667f;
            } else {
                fArr[1] = fArr[1] + 1.3333334f;
            }
            if (bnKKRLTfMvUSXUXz(cVtoqTKvzFXdUSFai)) {
                fArr[2] = fArr[2] + 0.6666667f;
            } else if (jKWTgTUKTkxwPfFo(cVtoqTKvzFXdUSFai)) {
                fArr[2] = fArr[2] + 2.6666667f;
            } else {
                fArr[2] = fArr[2] + 1.3333334f;
            }
            if (einjmVsGeQKAEydA(cVtoqTKvzFXdUSFai)) {
                fArr[3] = fArr[3] + 0.6666667f;
            } else if (IApEzaJsUHEoDpks(cVtoqTKvzFXdUSFai)) {
                fArr[3] = fArr[3] + 4.3333335f;
            } else {
                fArr[3] = fArr[3] + 3.3333333f;
            }
            if (rSKviVdPeSgLumDe(cVtoqTKvzFXdUSFai)) {
                fArr[4] = fArr[4] + 0.75f;
            } else if (yFwNQabEzAUpIASl(cVtoqTKvzFXdUSFai)) {
                fArr[4] = fArr[4] + 4.25f;
            } else {
                fArr[4] = fArr[4] + 3.25f;
            }
            if (igxuWROKBEHoqQME(cVtoqTKvzFXdUSFai)) {
                fArr[i4] = fArr[i4] + 4.0f;
            } else {
                fArr[i4] = fArr[i4] + f;
            }
            if (i5 >= 4) {
                int[] iArr2 = new int[i3];
                htATcSugDPlOfFVN(fArr, iArr2, int.MAX_VALUE, new byte[i3]);
                if (iArr2[0] < PwBgPZgjTseVcFpb(iArr2[i4], iArr2[1], iArr2[2], iArr2[3], iArr2[4])) {
                    return 0;
                }
                int i7 = iArr2[i4];
                if (i7 < iArr2[0] || i7 + 1 < ByAhqFaBTGwCNeaZ(iArr2[1], iArr2[2], iArr2[3], iArr2[4])) {
                    return i4;
                }
                if (iArr2[4] + 1 < cSAVcPRMrvMwfkQI(iArr2[i4], iArr2[1], iArr2[2], iArr2[3], iArr2[0])) {
                    return 4;
                }
                if (iArr2[2] + 1 < uvPTCklMzlEmDMCI(iArr2[i4], iArr2[1], iArr2[4], iArr2[3], iArr2[0])) {
                    return 2;
                }
                if (iArr2[3] + 1 < uOyTIjhJsedeFDpu(iArr2[i4], iArr2[1], iArr2[4], iArr2[2], iArr2[0])) {
                    return 3;
                }
                if (iArr2[1] + 1 < qaJAncJinpQSOQwC(iArr2[0], iArr2[i4], iArr2[4], iArr2[2])) {
                    int i8 = iArr2[1];
                    int i9 = iArr2[3];
                    if (i8 < i9) {
                        return 1;
                    }
                    if (i8 == i9) {
                        for (int i10 = i + i5 + 1; i10 < nNoaTyTyTlMbDbJU(charSequence); i10++) {
                            char cMyBthAKhECIVAPSF = myBthAKhECIVAPSF(charSequence, i10);
                            if (NhPDBvEarNucZosF(cMyBthAKhECIVAPSF)) {
                                return 3;
                            }
                            if (!UazJhdBuuvcOEYdP(cMyBthAKhECIVAPSF)) {
                                break;
                            }
                        }
                        return 1;
                    }
                }
            }
            f3 = f;
            i4 = i4;
            f2 = 2.0f;
            i3 = 6;
        }
    }

    private static int Min(int i, int i2, int i3, int i4) {
        return RwwYQThnsshGNBCJ(i, CaCgsAolfHrOojPm(i2, rNKpjXEiUiOyrXMZ(i3, i4)));
    }

    private static int Min(int i, int i2, int i3, int i4, int i5) {
        return epiNnMgnDCebTrQR(ozkRFAqFMwalqPDV(i, i2, i3, i4), i5);
    }

    public static char MyBthAKhECIVAPSF(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int MyolajFIrVEEsqXD(java.lang.string str) {
        return str.Length;
    }

    public static int NFIRxJyshnOHLTcv(java.lang.string str) {
        return str.Length;
    }

    public static int NNoaTyTyTlMbDbJU(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static java.lang.string NZeUGnxhgUpXWbht(java.lang.string str, com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint, com.google.zxing.Dimension dimension, com.google.zxing.Dimension dimension2, bool z) {
        return encodeHighLevel(str, symbolShapeHint, dimension, dimension2, z);
    }

    public static int NggSdDvrgoWhgtTP(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static java.lang.stringBuilder NgiMIWYOzumkonQi(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static double NkRYfmyHqvkklwVH(double d) {
        if ((26 + 11) % 11 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static bool NrhgAGsbolbAXVZM(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static void OBYsNAHWOViTnFXW(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, char c) {
        encoderobject.writeCodeword(c);
    }

    public static int OzkRFAqFMwalqPDV(int i, int i2, int i3, int i4) {
        return min(i, i2, i3, i4);
    }

    public static bool PHZkJQdadWuvoxkU(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.stringBuilder PPDIFeDhfGIyaseJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int QSMXgMExhyoQfrvj(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getDataCapacity();
    }

    public static int QXprSmTjaqbjUaes(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int QaJAncJinpQSOQwC(int i, int i2, int i3, int i4) {
        return min(i, i2, i3, i4);
    }

    public static int RNKpjXEiUiOyrXMZ(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static bool RSKviVdPeSgLumDe(char c) {
        return isNativeEDIFACT(c);
    }

    private static char Randomize253State(int i) {
        if ((21 + 16) % 16 > 0) {
        }
        int i2 = (i * 149) % 253;
        int i3 = i2 + 130;
        if (i3 > 254) {
            i3 = i2 - 124;
        }
        return (char) i3;
    }

    public static void SLaeRzRGrbgLjtCI(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject, char c) {
        encoderobject.writeCodeword(c);
    }

    public static bool SblBTWfSwSYJpGkR(char c) {
        return isNativeX12(c);
    }

    public static bool TEeJKFAQmgWKVPhU(java.lang.string str, java.lang.string str2) {
        return str.EndsWith(str2);
    }

    public static int UOyTIjhJsedeFDpu(int i, int i2, int i3, int i4, int i5) {
        return min(i, i2, i3, i4, i5);
    }

    public static int UvPTCklMzlEmDMCI(int i, int i2, int i3, int i4, int i5) {
        return min(i, i2, i3, i4, i5);
    }

    public static char WJeSQrWcoJOcDgVr(int i) {
        return randomize253State(i);
    }

    public static com.google.zxing.datamatrix.encoder.SymbolInfo WNsYTJXHIcCvDBzt(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getSymbolInfo();
    }

    public static java.lang.stringBuilder WTgkLjjzWtrbAqDR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int WhEaDTsqGGcAIRCg(com.google.zxing.datamatrix.encoder.Encoderobject encoderobject) {
        return encoderobject.getNewEncoding();
    }

    public static char XwOqblnJwjQHhFbe(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static bool YFwNQabEzAUpIASl(char c) {
        return isExtendedASCII(c);
    }

    public static void YkLOYJeFeGHNGnwY(byte[] bArr, byte b) {
        java.util.Arrays.fill(bArr, b);
    }

    public static void YkrjxaOMuxqAbbZq(byte[] bArr, byte b) {
        java.util.Arrays.fill(bArr, b);
    }

    public static java.lang.stringBuilder ZkvdDJCLiolhWhki(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }
}

