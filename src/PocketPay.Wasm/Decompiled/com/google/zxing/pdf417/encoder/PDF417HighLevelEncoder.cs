using Com.Google.Common.Base;
using Com.Google.Zxing;
using Com.Google.Zxing.Common;
using Com.Visa.Vac.P012tc.Emvconverter;
using Java.Math;
using Java.Nio.Charset;
using Java.Util;
using Kotlin.P014io.Encoding;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes2.dex */
readonly class PDF417HighLevelEncoder {
    static readonly /* synthetic */ bool $assertionsDisabled = false;
    private static readonly int BYTE_COMPACTION = 1;
    private static readonly Charset DEFAULT_ENCODING = null;
    private static readonly int ECI_CHARSET = 927;
    private static readonly int ECI_GENERAL_PURPOSE = 926;
    private static readonly int ECI_USER_DEFINED = 925;
    private static readonly int LATCH_TO_BYTE = 924;
    private static readonly int LATCH_TO_BYTE_PADDED = 901;
    private static readonly int LATCH_TO_NUMERIC = 902;
    private static readonly int LATCH_TO_TEXT = 900;
    private static readonly byte[] MIXED = null;
    private static readonly int NUMERIC_COMPACTION = 2;
    private static readonly byte[] PUNCTUATION = null;
    private static readonly int SHIFT_TO_BYTE = 913;
    private static readonly int SUBMODE_ALPHA = 0;
    private static readonly int SUBMODE_LOWER = 1;
    private static readonly int SUBMODE_MIXED = 2;
    private static readonly int SUBMODE_PUNCTUATION = 3;
    private static readonly int TEXT_COMPACTION = 0;
    private static readonly byte[] TEXT_MIXED_RAW = null;
    private static readonly byte[] TEXT_PUNCTUATION_RAW = null;

    /* JADX INFO: renamed from: com.google.zxing.pdf417.encoder.PDF417HighLevelEncoder$1 */
    static /* synthetic */ class C23431 {
        static readonly /* synthetic */ int[] $SwitchDictionary$com$google$zxing$pdf417$encoder$Compaction = null;

        static {
            if (((31 + 16) % 16) > 0) goto L24;
        L24:
            int[] r0 = new int[XIbWqlzqnyTwFunm().length];
            $SwitchDictionary$com$google$zxing$pdf417$encoder$Compaction = r0;
            r0[lrxafiTUtSCWQdUt(Compaction.TEXT)] = 1;     // Catch: NoSuchFieldError -> L27
        L30:
            $SwitchDictionary$com$google$zxing$pdf417$encoder$Compaction[XkBKrIuuQtLcpPdH(Compaction.BYTE)] = 2;     // Catch: NoSuchFieldError -> L28
        L32:
            $SwitchDictionary$com$google$zxing$pdf417$encoder$Compaction[atIpsYeYKUjKNtDx(Compaction.NUMERIC)] = 3;     // Catch: NoSuchFieldError -> L29
        }

        public static Compaction[] XIbWqlzqnyTwFunm() {
            return Compaction.Values;
        }

        public static int XkBKrIuuQtLcpPdH(Compaction r1) {
            return r1.ordinal();
        }

        public static int AtIpsYeYKUjKNtDx(Compaction r1) {
            return r1.ordinal();
        }

        public static int LrxafiTUtSCWQdUt(Compaction r1) {
            return r1.ordinal();
        }
    }

    private static readonly class NoECIInput : ECIInput {
        string input;

        private NoECIInput(string r1) {
            this.input = r1;
        }

        /* synthetic */ NoECIInput(string r1, C23431 r2) {
            this(r1);
        }

        public static CharSequence ILErhkzllUuVAUWo(string r1, int r2, int r3) {
            return r1.subSequence(r2, r3);
        }

        public static int LKWOYuYTmRWeoKCr(string r1) {
            return r1.Length;
        }

        public static char PJggPyVQFAzwqksT(string r1, int r2) {
            return r1[r2);
        }

        public static int XYfaXrkoyLMvrTqY(string r1) {
            return r1.Length;
        }

        @Override // com.google.zxing.common.ECIInput
        public char CharAt(int r1) {
            return PJggPyVQFAzwqksT(this.input, r1);
        }

        @Override // com.google.zxing.common.ECIInput
        public int GetECIValue(int r1) {
            return -1;
        }

        @Override // com.google.zxing.common.ECIInput
        public bool HaveNchars(int r1, int r2) {
            if ((r1 + r2) > LKWOYuYTmRWeoKCr(this.input)) goto L13;
            return true;
        L13:
            return false;
        }

        @Override // com.google.zxing.common.ECIInput
        public bool IsECI(int r1) {
            return false;
        }

        @Override // com.google.zxing.common.ECIInput
        public int Length() {
            return XYfaXrkoyLMvrTqY(this.input);
        }

        @Override // com.google.zxing.common.ECIInput
        public CharSequence SubSequence(int r1, int r2) {
            return ILErhkzllUuVAUWo(this.input, r1, r2);
        }

        public string Tostring() {
            return this.input;
        }
    }

    static {
        if (((31 + 20) % 20) > 0) goto L41;
    L41:
        TEXT_MIXED_RAW = new byte[]{Constants.TXN_ONLINE_DECLINE, 49, 50, 51, 52, 53, 54, 55, 56, 57, 38, Ascii.f446CR, 9, 44, 58, 35, 45, 46, 36, 47, 43, 37, 42, Base64.padSymbol, 94, 0, 32, 0, 0, 0};
        TEXT_PUNCTUATION_RAW = new byte[]{59, 60, 62, 64, 91, 92, 93, 95, 96, 126, 33, Ascii.f446CR, 9, 44, 58, 10, 45, 46, 36, 47, 34, 124, 42, 40, 41, 63, 123, 125, 39, 0};
        byte[] r1 = new byte[128];
        MIXED = r1;
        PUNCTUATION = new byte[128];
        DEFAULT_ENCODING = StandardCharsets.ISO_8859_1;
        rggrAgdQyFSeetEt(r1, (byte) -1);
        int r12 = 0;
        int r2 = 0;
    L44:
        byte[] r3 = TEXT_MIXED_RAW;
        if (r2 >= r3.length) goto L24;
        byte r32 = r3[r2];
        if (r32 <= 0) goto L65;
        MIXED[r32] = (byte) r2;
    L65:
        r2 = r2 + 1;
        goto L44
    L24:
        CBoWfgvBiWXSpBby(PUNCTUATION, (byte) -1);
    L62:
        byte[] r0 = TEXT_PUNCTUATION_RAW;
        if (r12 >= r0.length) goto L51;
        byte r02 = r0[r12];
        if (r02 <= 0) goto L57;
        PUNCTUATION[r02] = (byte) r12;
    L57:
        r12 = r12 + 1;
        goto L62
    }

    private PDF417HighLevelEncoder() {
    }

    public static stringBuilder AOBPzbJMOSkZedeb(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static byte[] AtxKGdGKkdlMXeYZ(ECIInput r1, int r2, int r3) {
        return subbytes(r1, r2, r3);
    }

    public static charHashSetECI BCmKkOsiHLFXGvrj(Charset r1) {
        return charHashSetECI.getcharHashSetECI(r1);
    }

    public static void BSQXYqhOUygSPNMQ(byte[] r0, int r1, int r2, int r3, stringBuilder r4) {
        encodeBinary(r0, r1, r2, r3, r4);
    }

    public static bool BznfGEPUeYnbOvQj(ECIInput r1, int r2) {
        return r1.isECI(r2);
    }

    public static void CBoWfgvBiWXSpBby(byte[] r0, byte r1) {
        Arrays.fill(r0, r1);
    }

    public static int CjAgobexNPmhCJoe(charHashSetECI r1) {
        return r1.getValue();
    }

    public static stringBuilder EKtmxsefDlgbuZkA(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static stringBuilder EUaCGLyiiZFqVOqu(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static stringBuilder EZGOWckyFFITsTVU(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static int EoMdxjCwxofoAWsw(ECIInput r1) {
        return r1.Length;
    }

    public static void FnCfeMfPScVprTdn(int r0, stringBuilder r1) {
        encodingECI(r0, r1);
    }

    public static stringBuilder GJGthHTLMPWkWOrt(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static stringBuilder GqpIyHvpiKyHJnxO(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static stringBuilder HBxQTGJFFiQnubQa(stringBuilder r1, int r2) {
        return r1.append(r2);
    }

    public static bool HVBZDhBDgjHRJQPq(char r1) {
        return isPunctuation(r1);
    }

    public static stringBuilder HZPWunUYfMvUVYLQ(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static stringBuilder IAKPUsThgGdtyYQG(stringBuilder r1, int r2) {
        return r1.append(r2);
    }

    public static string IaYLXaQXLFKYZtby(object r1) {
        return r1.tostring();
    }

    public static void IsvadTSPVOminbCI(ECIInput r0, int r1, int r2, stringBuilder r3) {
        encodeNumeric(r0, r1, r2, r3);
    }

    public static string IvwvdfNSOHtRWcKv(stringBuilder r1) {
        return r1.tostring();
    }

    public static stringBuilder JUwWwMizMymPrJKe(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static stringBuilder JwMwEyeqFmSkTNdY(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static Bigint KbfBVYDjRrOhIyMy(long r1) {
        return Bigint.valueOf(r1);
    }

    public static bool KsdpHDBKELjHTqba(char r1) {
        return isPunctuation(r1);
    }

    public static char KvweLyVVnaChLRTf(ECIInput r1, int r2) {
        return r1[r2);
    }

    public static stringBuilder KwRKuZhIUHCHxXkN(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static int LCNPWVmvPrzVLjRk(ECIInput r1, int r2) {
        return r1.getECIValue(r2);
    }

    public static string LRWiHlVezIAsAbDk(object r1) {
        return r1.tostring();
    }

    public static string MYrxRBDAolazSnYe(stringBuilder r1) {
        return r1.tostring();
    }

    public static int MZghPDdytwtdjoMH(int r1, int r2) {
        return Math.min(r1, r2);
    }

    public static stringBuilder MmNvhkrCXXGtJCDj(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static int NGcXYyqOxMlurUta(ECIInput r1) {
        return r1.Length;
    }

    public static char NcfbOFgsGGjjpXXr(ECIInput r1, int r2) {
        return r1[r2);
    }

    public static bool NciwhahjEHENKDPY(ECIInput r1, int r2) {
        return r1.isECI(r2);
    }

    public static int NehmVjpjFTejPMhC(stringBuilder r1) {
        return r1.Length;
    }

    public static bool NfsBugcIFWHonnvS(Bigint r1, object r2) {
        return r1.Equals(r2);
    }

    public static stringBuilder NrddXhGxDABvqPep(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static stringBuilder NrrBOkBloiTuUktV(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static stringBuilder OTVwNIsdjWYqWSFL(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static char OWtrtUUNZPdLpvMb(string r1, int r2) {
        return r1[r2);
    }

    public static char OwJcpqAiQHTmTFGW(ECIInput r1, int r2) {
        return r1[r2);
    }

    public static stringBuilder PaWQmWvxCUuHQDJm(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static void PvWCVdWStUMoXeOh(stringBuilder r0, int r1) {
        r0.setLength(r1);
    }

    public static stringBuilder QVdCbwCLgkwgQkpJ(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static char QwtKclFrXJqGWGly(string r1, int r2) {
        return r1[r2);
    }

    public static int RCVYWphCUPRpTdGN(ECIInput r1, int r2) {
        return r1.getECIValue(r2);
    }

    public static bool RkPTXCKnrjoXKsAU(char r1) {
        return isAlphaLower(r1);
    }

    public static stringBuilder RzSlpjmoKQMVujwO(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static int SLdLatrFQyCarbyr(ECIInput r1, int r2, Charset r3) {
        return determineConsecutiveBinaryCount(r1, r2, r3);
    }

    public static stringBuilder SNyAXdDxQLqDoTyl(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static char SejXmcSOWBWMwcSk(stringBuilder r1, int r2) {
        return r1[r2);
    }

    public static Bigint ShNikvHqOXpidazn(Bigint r1, Bigint r2) {
        return r1.divide(r2);
    }

    public static int SjhVgtwZIvXmITku(ECIInput r1, int r2) {
        return r1.getECIValue(r2);
    }

    public static int SyQUNykBmPwlTAUI(string r1) {
        return r1.Length;
    }

    public static stringBuilder TAcmffYRzrqJoeZd(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static char UNJfiyvohFIgJDeJ(ECIInput r1, int r2) {
        return r1[r2);
    }

    public static int UVntuXXRiNmnDllv(stringBuilder r1) {
        return r1.Length;
    }

    public static stringBuilder UybiRgDFkBRarRXK(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static stringBuilder VAidsqeXIxYHndOl(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static stringBuilder VFckPbNtzWTXhahk(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static stringBuilder VJVKOhULkBDJRWKT(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static stringBuilder VUayLzHIkDSidZri(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static stringBuilder VtjOeYkUfuGGQrqM(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static bool VwSRZTPohlRdckLb(ECIInput r1, int r2) {
        return r1.isECI(r2);
    }

    public static bool WjtVqTrFJBquJiZH(char r1) {
        return isAlphaUpper(r1);
    }

    public static int WsHhPxLVuSTuUbQp(string r1) {
        return r1.Length;
    }

    public static CharsetEncoder XGGitrKKcictfApp(Charset r1) {
        return r1.newEncoder();
    }

    public static bool XLpfzNvsktmlIFVJ(char r1) {
        return isAlphaUpper(r1);
    }

    public static bool XzeqoRjUYNtHGSqJ(CharsetEncoder r1, char r2) {
        return r1.canEncode(r2);
    }

    public static stringBuilder YPHFtuBFcISgvZGB(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static byte[] YkjAqtuFFBxpzUSQ(string r1, Charset r2) {
        return r1.getbytes(r2);
    }

    public static stringBuilder YtngChEvldfgXiGB(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static stringBuilder ZfUxoxPmoxyQttlZ(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static string ABbzlWDqzskbfZVQ(stringBuilder r1) {
        return r1.tostring();
    }

    public static char AMpklNIinNlLZmjG(ECIInput r1, int r2) {
        return r1[r2);
    }

    public static char AWuRCYkJbEIzIQQO(ECIInput r1, int r2) {
        return r1[r2);
    }

    public static bool AjwBTQoKtnJglNJg(Charset r1, object r2) {
        return r1.Equals(r2);
    }

    public static void AolxEUhUZxIiOAOE(ECIInput r0, int r1, int r2, stringBuilder r3) {
        encodeNumeric(r0, r1, r2, r3);
    }

    public static stringBuilder BXBVNxpPuxJpccKv(stringBuilder r1, object r2) {
        return r1.append(r2);
    }

    public static stringBuilder BmHjJtCbLKTfgBtR(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static stringBuilder BnXZlRnsTpnEFwDf(stringBuilder r1, int r2) {
        return r1.append(r2);
    }

    public static stringBuilder CJyvitGpnHjkAgJR(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static int CbxrpPxANPvwSJXV(ECIInput r1) {
        return r1.Length;
    }

    public static bool DDimYCoApZpoKPMK(ECIInput r1, int r2) {
        return r1.isECI(r2);
    }

    public static CharSequence DZCVRluIBALBBCLN(ECIInput r1, int r2, int r3) {
        return r1.subSequence(r2, r3);
    }

    private static int DetermineConsecutiveBinaryCount(ECIInput r6, int r7, Charset r8) {
        if (((17 + 12) % 12) > 0) goto L57;
    L57:
        if (r8 is not null) goto L11;
        CharsetEncoder r82 = null;
    L32:
        int r0 = NGcXYyqOxMlurUta(r6);
        int r1 = r7;
    L33:
        if (r1 >= r0) goto L30;
        int r2 = 0;
        int r3 = r1;
    L27:
        if (r2 >= 13) goto L54;
        if (dDimYCoApZpoKPMK(r6, r3) == true) goto L54;
        if (wAnNxCHvDNyaWHqT(tmCzzPNWCaNXmEuH(r6, r3)) == false) goto L54;
        r2 = r2 + 1;
        r3 = r1 + r2;
        if (r3 < r0) goto L27;
    L54:
        if (r2 >= 13) goto L15;
        if (r82 is null) goto L81;
        if (XzeqoRjUYNtHGSqJ(r82, ufMpnwunqYwwfRfQ(r6, r1)) == true) goto L81;
        char r62 = aMpklNIinNlLZmjG(r6, r1);
        throw new WriterException(MYrxRBDAolazSnYe(AOBPzbJMOSkZedeb(IAKPUsThgGdtyYQG(SNyAXdDxQLqDoTyl(EZGOWckyFFITsTVU(new stringBuilder("Non-encodable character detected: "), r62), " (Unicode: "), r62), ')')));
    L81:
        r1 = r1 + 1;
        goto L33
    L15:
        return r1 - r7;
    L30:
        return r1 - r7;
    L11:
        r82 = XGGitrKKcictfApp(r8);
        goto L32
    }

    private static int DetermineConsecutiveDigitCount(ECIInput r3, int r4) {
        if (((30 + 20) % 20) > 0) goto L16;
    L16:
        int r0 = cbxrpPxANPvwSJXV(r3);
        int r1 = 0;
        if (r4 < r0) goto L35;
    L6:
        return r1;
    L35:
        if (r4 >= r0) goto L6;
        if (zalDkHjroDRmWuej(r3, r4) == true) goto L6;
        if (zpfbLUnGlSidCSUa(NcfbOFgsGGjjpXXr(r3, r4)) == false) goto L6;
        r1 = r1 + 1;
        r4 = r4 + 1;
        goto L35
    }

    private static int DetermineConsecutiveTextCount(ECIInput r5, int r6) {
        if (((25 + 9) % 9) > 0) goto L9;
    L9:
        int r0 = ffPVHJPtRGkYKHwJ(r5);
        int r1 = r6;
    L30:
        if (r1 >= r0) goto L25;
        int r2 = 0;
    L4:
        if (r2 >= 13) goto L45;
        if (r1 >= r0) goto L45;
        if (rQfIVNJFSyAsOjWS(r5, r1) == true) goto L45;
        if (wyxWgShhzpgNIxEp(wwmStCmLPifxVsRa(r5, r1)) == false) goto L45;
        r2 = r2 + 1;
        r1 = r1 + 1;
    L45:
        if (r2 >= 13) goto L55;
        if (r2 > 0) goto L30;
        if (uoJxngIdexVQvnPO(r5, r1) == true) goto L25;
        if (gkqeYcQahfmqDXHX(OwJcpqAiQHTmTFGW(r5, r1)) == false) goto L25;
        r1 = r1 + 1;
        goto L30
    L55:
        return (r1 - r6) - r2;
    L25:
        return r1 - r6;
    }

    public static void EmkLyoYASqEZgsPs(int r0, stringBuilder r1) {
        encodingECI(r0, r1);
    }

    private static void EncodeBinary(byte[] r10, int r11, int r12, int r13, stringBuilder r14) {
        if (((25 + 13) % 13) > 0) goto L18;
    L18:
        if (r12 != 1) goto L70;
        if (r13 != 0) goto L70;
        sEvWlRPHBHNozomN(r14, 913);
    L105:
        if (r12 >= 6) goto L68;
        int r2 = r11;
    L50:
        if (r2 >= (r11 + r12)) goto L75;
        QVdCbwCLgkwgQkpJ(r14, (char) (r10[r2] & 255));
        r2 = r2 + 1;
        goto L50
    L75:
        return;
    L68:
        char[] r1 = new char[5];
        r2 = r11;
    L80:
        if (((r11 + r12) - r2) < 6) goto L50;
        int r3 = 0;
        long r4 = 0;
        int r6 = 0;
    L7:
        if (r6 >= 6) goto L97;
        r4 = (r4 << 8) + ((long) (r10[r2 + r6] & 255));
        r6 = r6 + 1;
    L97:
        if (r3 >= 5) goto L35;
        r1[r3] = (char) (r4 % 900);
        r4 = r4 / 900;
        r3 = r3 + 1;
        goto L97
    L35:
        int r32 = 4;
    L64:
        if (r32 < 0) goto L25;
        VUayLzHIkDSidZri(r14, r1[r32]);
        r32 = r32 - 1;
        goto L64
    L25:
        r2 = r2 + 6;
    L70:
        if ((r12 % 6) == 0) goto L24;
        UybiRgDFkBRarRXK(r14, 901);
        goto L105
    L24:
        gxQPpuKrGJcSwVxd(r14, 924);
        goto L105
    }

    static string EncodeHighLevel(string r12, Compaction r13, Charset r14, bool r15) {
        if (((30 + 13) % 13) > 0) goto L83;
    L83:
        if (r14 is not null) goto L207;
        if (r15 == true) goto L207;
        int r1 = 0;
    L237:
        if (r1 >= WsHhPxLVuSTuUbQp(r12)) goto L207;
        if (QwtKclFrXJqGWGly(r12, r1) > 255) goto L44;
        r1 = r1 + 1;
        goto L237
    L44:
        throw new WriterException(aBbzlWDqzskbfZVQ(VtjOeYkUfuGGQrqM(bnXZlRnsTpnEFwDf(RzSlpjmoKQMVujwO(cJyvitGpnHjkAgJR(new stringBuilder("Non-encodable character detected: "), OWtrtUUNZPdLpvMb(r12, r1)), " (Unicode: "), kYjiAyuKtDVwUMdF(r12, r1)), "). Consider specifying EncodeHintType.PDF417_AUTO_ECI and/or EncodeTypeHint.CHARACTER_SET.")));
    L207:
        stringBuilder r16 = new stringBuilder(SyQUNykBmPwlTAUI(r12));
        if (r15 == false) goto L176;
        ECIInput r3 = new MinimalECIInput(r12, r14, -1);
    L96:
        int r122 = nfKABHVgwGdUlQba(r3);
        int r132 = C23431.$SwitchDictionary$com$google$zxing$pdf417$encoder$Compaction[isCtbIyswTViVkDS(r13)];
        if (r132 != 1) goto L46;
        uWxlyBTZFJtxXREE(r3, 0, r122, r16, 0);
    L55:
        return IvwvdfNSOHtRWcKv(r16);
    L46:
        if (r132 != 2) goto L234;
        if (r15 == true) goto L87;
        byte[] r123 = qGMXLSqflxtDsIqY(LRWiHlVezIAsAbDk(r3), r14);
        xQaaSRnPYRiHHhSV(r123, 0, r123.length, 1, r16);
        goto L55
    L87:
        huIGpEiIibxRgpKF(r3, 0, EoMdxjCwxofoAWsw(r3), 0, r16);
        goto L55
    L234:
        if (r132 != 3) goto L217;
        MmNvhkrCXXGtJCDj(r16, 902);
        IsvadTSPVOminbCI(r3, 0, r122, r16);
        goto L55
    L217:
        int r133 = 0;
        int r6 = 0;
        int r8 = 0;
    L128:
        if (r133 >= r122) goto L55;
    L106:
        if (r133 >= r122) goto L154;
        if (fMUHbrEVKNCaGUzo(r3, r133) == false) goto L154;
        emkLyoYASqEZgsPs(RCVYWphCUPRpTdGN(r3, r133), r16);
        r133 = r133 + 1;
    L154:
        if (r133 >= r122) goto L55;
        int r9 = sJNszZpBgHlllmxk(r3, r133);
        if (r9 >= 13) goto L67;
        int r10 = okIMMtxNAVVyBhOh(r3, r133);
        if (r10 >= 5) goto L221;
        if (r9 == r122) goto L221;
        if (r15 == true) goto L225;
        Charset r92 = r14;
    L131:
        int r93 = SLdLatrFQyCarbyr(r3, r133, r92);
        if (r93 != 0) goto L89;
        r93 = 1;
    L89:
        if (r15 == false) goto L119;
        byte[] r102 = null;
    L173:
        if (r102 is null) goto L102;
    L177:
        if (r102 is not null) goto L168;
    L198:
        if (r15 == true) goto L141;
        kATurTtZtYsPZHSA(r102, 0, r102.length, r8, r16);
    L150:
        r6 = 0;
        r8 = 1;
    L62:
        r133 = r133 + r93;
        goto L128
    L141:
        pvoakSHMcpWLcDcW(r3, r133, r133 + r93, r8, r16);
        goto L150
    L168:
        if (r102.length != 1) goto L198;
    L97:
        if (r8 != 0) goto L198;
        if (r15 == false) goto L193;
        rDQFGdUPNofwbuOr(r3, r133, 1, 0, r16);
        goto L62
    L193:
        BSQXYqhOUygSPNMQ(r102, 0, 1, 0, r16);
        goto L62
    L102:
        if (r93 != 1) goto L177;
    L119:
        r102 = YkjAqtuFFBxpzUSQ(IaYLXaQXLFKYZtby(dZCVRluIBALBBCLN(r3, r133, r133 + r93)), r14);
        goto L173
    L225:
        r92 = null;
    L221:
        if (r8 != 0) goto L49;
    L59:
        r6 = xBvEbLQJTBaAziAe(r3, r133, r10, r16, r6);
        r133 = r133 + r10;
        goto L128
    L49:
        KwRKuZhIUHCHxXkN(r16, 900);
        r6 = 0;
        r8 = 0;
        goto L59
    L67:
        xmAltPWbOvmZGGxr(r16, 902);
        aolxEUhUZxIiOAOE(r3, r133, r9, r16);
        r133 = r133 + r9;
        r6 = 0;
        r8 = 2;
        goto L128
    L176:
        r3 = new NoECIInput(r12, null);
        if (r14 is not null) goto L133;
        r14 = DEFAULT_ENCODING;
        goto L96
    L133:
        if (ajwBTQoKtnJglNJg(DEFAULT_ENCODING, r14) == true) goto L96;
        charHashSetECI r124 = BCmKkOsiHLFXGvrj(r14);
        if (r124 is null) goto L96;
        xlCrttbGZlPtKjUo(CjAgobexNPmhCJoe(r124), r16);
        goto L96
    }

    private static void EncodeMultiECIBinary(ECIInput r5, int r6, int r7, int r8, stringBuilder r9) {
        if (((20 + 10) % 10) > 0) goto L7;
    L7:
        int r72 = uYIvXzTkWDVpkhcz(r7 + r6, jHSpOzTAOiDJmgXh(r5));
        int r0 = r6;
    L50:
        if (r0 >= r72) goto L8;
        if (ftBxNFHIYJkydeiZ(r5, r0) == false) goto L8;
        FnCfeMfPScVprTdn(SjhVgtwZIvXmITku(r5, r0), r9);
        r0 = r0 + 1;
    L8:
        int r1 = r0;
    L62:
        if (r1 >= r72) goto L65;
        if (BznfGEPUeYnbOvQj(r5, r1) == true) goto L65;
        r1 = r1 + 1;
    L65:
        int r2 = r1 - r0;
        if (r2 <= 0) goto L16;
        byte[] r3 = AtxKGdGKkdlMXeYZ(r5, r0, r1);
        if (r0 != r6) goto L58;
        int r02 = r8;
    L42:
        hBBKuCuIAcoPlPpV(r3, 0, r2, r02, r9);
        r0 = r1;
        goto L50
    L58:
        r02 = 1;
        goto L42
    }

    private static void EncodeNumeric(ECIInput r9, int r10, int r11, stringBuilder r12) {
        if (((3 + 12) % 12) > 0) goto L26;
    L26:
        stringBuilder r0 = new stringBuilder((r11 / 3) + 1);
        Bigint r1 = KbfBVYDjRrOhIyMy(900);
        Bigint r2 = vJMWrtgVOVoMOLwF(0);
        int r4 = 0;
    L64:
        if (r4 >= r11) goto L32;
        PvWCVdWStUMoXeOh(r0, 0);
        int r5 = MZghPDdytwtdjoMH(44, r11 - r4);
        int r7 = r10 + r4;
        Bigint r72 = new Bigint(qmyfwJpwQbZhfwlT(bXBVNxpPuxJpccKv(new stringBuilder("1"), gXvvyiFhwmgMncwJ(r9, r7, r7 + r5))));
    L36:
        VAidsqeXIxYHndOl(r0, (char) lGiJFIEwTwLELSLa(whtmXBzkIOarsqTn(r72, r1)));
        r72 = ShNikvHqOXpidazn(r72, r1);
        if (NfsBugcIFWHonnvS(r72, r2) == false) goto L36;
        int r6 = NehmVjpjFTejPMhC(r0) - 1;
    L14:
        if (r6 < 0) goto L59;
        JUwWwMizMymPrJKe(r12, miylfArepOlXFERk(r0, r6));
        r6 = r6 - 1;
        goto L14
    L59:
        r4 = r4 + r5;
        goto L64
    }

    private static int EncodeText(ECIInput r16, int r17, int r18, stringBuilder r19, int r20) {
        if (((3 + 16) % 16) > 0) goto L33;
    L33:
        stringBuilder r3 = new stringBuilder(r18);
        int r4 = 0;
        int r5 = r20;
        int r6 = 0;
    L214:
        int r7 = r17 + r6;
        if (VwSRZTPohlRdckLb(r16, r7) == true) goto L47;
        char r8 = aWuRCYkJbEIzIQQO(r16, r7);
        if (r5 == 0) goto L12;
        if (r5 == 1) goto L96;
        if (r5 != 2) goto L135;
        if (wPRFklXrgCbHsNFt(r8) == true) goto L149;
        if (sysZWxcHtNDVqtXs(r8) == false) goto L181;
        bmHjJtCbLKTfgBtR(r3, 28);
    L64:
        r5 = 0;
        goto L214
    L181:
        if (oBbIdoUpMeIqBJck(r8) == false) goto L43;
        mbzWDabZmORlGiIA(r3, 27);
    L22:
        r5 = 1;
        goto L214
    L43:
        int r72 = r7 + 1;
        if (r72 >= r18) goto L217;
        if (NciwhahjEHENKDPY(r16, r72) == true) goto L217;
        if (HVBZDhBDgjHRJQPq(KvweLyVVnaChLRTf(r16, r72)) == false) goto L217;
        lQNiuyOyLJdXDkcp(r3, 25);
        r5 = 3;
    L217:
        tYhtuQlnXooOZEtv(r3, 29);
        TAcmffYRzrqJoeZd(r3, (char) PUNCTUATION[r8]);
    L196:
        r6 = r6 + 1;
        if (r6 < r18) goto L214;
        int r0 = UVntuXXRiNmnDllv(r3);
        char r1 = 0;
    L178:
        if (r4 >= r0) goto L88;
        if ((r4 % 2) != 0) goto L224;
        r1 = hJpKoTHOdyKVXPqS(r3, r4);
    L134:
        r4 = r4 + 1;
        goto L178
    L224:
        r1 = (char) ((r1 * 30) + SejXmcSOWBWMwcSk(r3, r4));
        qZbSXUsHvtHFcOuV(r19, r1);
        goto L134
    L88:
        if ((r0 % 2) != 0) goto L152;
    L146:
        return r5;
    L152:
        NrrBOkBloiTuUktV(r19, (char) ((r1 * 30) + 29));
        goto L146
    L149:
        GqpIyHvpiKyHJnxO(r3, (char) MIXED[r8]);
        goto L196
    L135:
        if (KsdpHDBKELjHTqba(r8) == true) goto L23;
        YPHFtuBFcISgvZGB(r3, 29);
        goto L64
    L23:
        OTVwNIsdjWYqWSFL(r3, (char) PUNCTUATION[r8]);
        goto L196
    L96:
        if (RkPTXCKnrjoXKsAU(r8) == true) goto L115;
        if (XLpfzNvsktmlIFVJ(r8) == true) goto L95;
        if (lZxxUzRXwAILiVzB(r8) == false) goto L171;
        mcrwCYNOSnyuQuEw(r3, 28);
    L112:
        r5 = 2;
        goto L214
    L171:
        HZPWunUYfMvUVYLQ(r3, 29);
        ZfUxoxPmoxyQttlZ(r3, (char) PUNCTUATION[r8]);
        goto L196
    L95:
        sGrCTiRjYZpikqjl(r3, 27);
        YtngChEvldfgXiGB(r3, (char) (r8 - 'A'));
        goto L196
    L115:
        if (r8 != ' ') goto L32;
        JwMwEyeqFmSkTNdY(r3, 26);
        goto L196
    L32:
        ncqbpElpXjDVpjfL(r3, (char) (r8 - 'a'));
        goto L196
    L12:
        if (WjtVqTrFJBquJiZH(r8) == true) goto L24;
        if (fKyzMpHHQeqUFMgU(r8) == false) goto L78;
        VFckPbNtzWTXhahk(r3, 27);
        goto L22
    L78:
        if (jUmwSYCsgGuqNpTJ(r8) == false) goto L138;
        GJGthHTLMPWkWOrt(r3, 28);
        goto L112
    L138:
        iiHzALennEqPDUaY(r3, 29);
        PaWQmWvxCUuHQDJm(r3, (char) PUNCTUATION[r8]);
        goto L196
    L24:
        if (r8 != ' ') goto L31;
        NrddXhGxDABvqPep(r3, 26);
        goto L196
    L31:
        meogVXQpppoqvusV(r3, (char) (r8 - 'A'));
        goto L196
    L47:
        uVegqBgxkMHRnInM(LCNPWVmvPrzVLjRk(r16, r7), r19);
        r6 = r6 + 1;
        goto L214
    }

    private static void EncodingECI(int r2, stringBuilder r3) {
        if (((21 + 11) % 11) > 0) goto L49;
    L49:
        if (r2 < 0) goto L53;
        if (r2 >= 900) goto L53;
        EKtmxsefDlgbuZkA(r3, 927);
        zOtHDYkJOmhdIDJN(r3, (char) r2);
        return;
    L53:
        if (r2 < 810900) goto L13;
        if (r2 >= 811800) goto L6;
        kumqTBPcXxLxzGxT(r3, 925);
        VJVKOhULkBDJRWKT(r3, (char) (810900 - r2));
        return;
    L6:
        throw new WriterException(jGKjxYybguefRPzc(HBxQTGJFFiQnubQa(new stringBuilder("ECI number not in valid range from 0..811799, but was "), r2)));
    L13:
        EUaCGLyiiZFqVOqu(r3, 926);
        xRrOSHPrvjkMmHbN(r3, (char) ((r2 / 900) - 1));
        rwezSKUoRDIKxtbN(r3, (char) (r2 % 900));
    }

    public static bool FKyzMpHHQeqUFMgU(char r1) {
        return isAlphaLower(r1);
    }

    public static bool FMUHbrEVKNCaGUzo(ECIInput r1, int r2) {
        return r1.isECI(r2);
    }

    public static int FfPVHJPtRGkYKHwJ(ECIInput r1) {
        return r1.Length;
    }

    public static bool FtBxNFHIYJkydeiZ(ECIInput r1, int r2) {
        return r1.isECI(r2);
    }

    public static CharSequence GXvvyiFhwmgMncwJ(ECIInput r1, int r2, int r3) {
        return r1.subSequence(r2, r3);
    }

    public static bool GkqeYcQahfmqDXHX(char r1) {
        return isText(r1);
    }

    public static stringBuilder GxQPpuKrGJcSwVxd(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static void HBBKuCuIAcoPlPpV(byte[] r0, int r1, int r2, int r3, stringBuilder r4) {
        encodeBinary(r0, r1, r2, r3, r4);
    }

    public static char HJpKoTHOdyKVXPqS(stringBuilder r1, int r2) {
        return r1[r2);
    }

    public static void HuIGpEiIibxRgpKF(ECIInput r0, int r1, int r2, int r3, stringBuilder r4) {
        encodeMultiECIBinary(r0, r1, r2, r3, r4);
    }

    public static stringBuilder IiHzALennEqPDUaY(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    private static bool IsAlphaLower(char r1) {
        if (r1 != ' ') goto L17;
        return true;
    L17:
        if (r1 >= 'a') goto L14;
        return false;
    L14:
        if (r1 <= 'z') goto L26;
        return false;
    L26:
        return true;
    }

    private static bool IsAlphaUpper(char r1) {
        if (r1 != ' ') goto L10;
        return true;
    L10:
        if (r1 >= 'A') goto L20;
        return false;
    L20:
        if (r1 > 'Z') goto L27;
        return true;
    L27:
        return false;
    }

    public static int IsCtbIyswTViVkDS(Compaction r1) {
        return r1.ordinal();
    }

    private static bool IsDigit(char r1) {
        if (r1 >= '0') goto L15;
        return false;
    L15:
        if (r1 > '9') goto L20;
        return true;
    L20:
        return false;
    }

    private static bool IsMixed(char r1) {
        if (MIXED[r1] == (-1)) goto L5;
        return true;
    L5:
        return false;
    }

    private static bool IsPunctuation(char r1) {
        if (PUNCTUATION[r1] != (-1)) goto L15;
        return false;
    L15:
        return true;
    }

    private static bool IsText(char r1) {
        if (r1 != '\t') goto L27;
        return true;
    L27:
        if (r1 != '\n') goto L21;
        return true;
    L21:
        if (r1 != '\r') goto L3;
        return true;
    L3:
        if (r1 >= ' ') goto L10;
        return false;
    L10:
        if (r1 <= '~') goto L37;
        return false;
    L37:
        return true;
    }

    public static string JGKjxYybguefRPzc(stringBuilder r1) {
        return r1.tostring();
    }

    public static int JHSpOzTAOiDJmgXh(ECIInput r1) {
        return r1.Length;
    }

    public static bool JUmwSYCsgGuqNpTJ(char r1) {
        return isMixed(r1);
    }

    public static void KATurTtZtYsPZHSA(byte[] r0, int r1, int r2, int r3, stringBuilder r4) {
        encodeBinary(r0, r1, r2, r3, r4);
    }

    public static char KYjiAyuKtDVwUMdF(string r1, int r2) {
        return r1[r2);
    }

    public static stringBuilder KumqTBPcXxLxzGxT(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static int LGiJFIEwTwLELSLa(Bigint r1) {
        return r1.intValue();
    }

    public static stringBuilder LQNiuyOyLJdXDkcp(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static bool LZxxUzRXwAILiVzB(char r1) {
        return isMixed(r1);
    }

    public static stringBuilder MbzWDabZmORlGiIA(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static stringBuilder McrwCYNOSnyuQuEw(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static stringBuilder MeogVXQpppoqvusV(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static char MiylfArepOlXFERk(stringBuilder r1, int r2) {
        return r1[r2);
    }

    public static stringBuilder NcqbpElpXjDVpjfL(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static int NfKABHVgwGdUlQba(ECIInput r1) {
        return r1.Length;
    }

    public static bool OBbIdoUpMeIqBJck(char r1) {
        return isAlphaLower(r1);
    }

    public static int OkIMMtxNAVVyBhOh(ECIInput r1, int r2) {
        return determineConsecutiveTextCount(r1, r2);
    }

    public static void PvoakSHMcpWLcDcW(ECIInput r0, int r1, int r2, int r3, stringBuilder r4) {
        encodeMultiECIBinary(r0, r1, r2, r3, r4);
    }

    public static byte[] QGMXLSqflxtDsIqY(string r1, Charset r2) {
        return r1.getbytes(r2);
    }

    public static stringBuilder QZbSXUsHvtHFcOuV(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static string QmyfwJpwQbZhfwlT(stringBuilder r1) {
        return r1.tostring();
    }

    public static void RDQFGdUPNofwbuOr(ECIInput r0, int r1, int r2, int r3, stringBuilder r4) {
        encodeMultiECIBinary(r0, r1, r2, r3, r4);
    }

    public static bool RQfIVNJFSyAsOjWS(ECIInput r1, int r2) {
        return r1.isECI(r2);
    }

    public static void RggrAgdQyFSeetEt(byte[] r0, byte r1) {
        Arrays.fill(r0, r1);
    }

    public static stringBuilder RwezSKUoRDIKxtbN(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static stringBuilder SEvWlRPHBHNozomN(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static stringBuilder SGrCTiRjYZpikqjl(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static int SJNszZpBgHlllmxk(ECIInput r1, int r2) {
        return determineConsecutiveDigitCount(r1, r2);
    }

    static byte[] Subbytes(ECIInput r4, int r5, int r6) {
        if (((12 + 11) % 11) > 0) goto L30;
    L30:
        byte[] r0 = new byte[r6 - r5];
        int r1 = r5;
    L3:
        if (r1 >= r6) goto L9;
        r0[r1 - r5] = (byte) (UNJfiyvohFIgJDeJ(r4, r1) & 255);
        r1 = r1 + 1;
        goto L3
    L9:
        return r0;
    }

    public static bool SysZWxcHtNDVqtXs(char r1) {
        return isAlphaUpper(r1);
    }

    public static stringBuilder TYhtuQlnXooOZEtv(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static char TmCzzPNWCaNXmEuH(ECIInput r1, int r2) {
        return r1[r2);
    }

    public static void UVegqBgxkMHRnInM(int r0, stringBuilder r1) {
        encodingECI(r0, r1);
    }

    public static int UWxlyBTZFJtxXREE(ECIInput r1, int r2, int r3, stringBuilder r4, int r5) {
        return encodeText(r1, r2, r3, r4, r5);
    }

    public static int UYIvXzTkWDVpkhcz(int r1, int r2) {
        return Math.min(r1, r2);
    }

    public static char UfMpnwunqYwwfRfQ(ECIInput r1, int r2) {
        return r1[r2);
    }

    public static bool UoJxngIdexVQvnPO(ECIInput r1, int r2) {
        return r1.isECI(r2);
    }

    public static Bigint VJMWrtgVOVoMOLwF(long r1) {
        return Bigint.valueOf(r1);
    }

    public static bool WAnNxCHvDNyaWHqT(char r1) {
        return isDigit(r1);
    }

    public static bool WPRFklXrgCbHsNFt(char r1) {
        return isMixed(r1);
    }

    public static Bigint WhtmXBzkIOarsqTn(Bigint r1, Bigint r2) {
        return r1.mod(r2);
    }

    public static char WwmStCmLPifxVsRa(ECIInput r1, int r2) {
        return r1[r2);
    }

    public static bool WyxWgShhzpgNIxEp(char r1) {
        return isDigit(r1);
    }

    public static int XBvEbLQJTBaAziAe(ECIInput r1, int r2, int r3, stringBuilder r4, int r5) {
        return encodeText(r1, r2, r3, r4, r5);
    }

    public static void XQaaSRnPYRiHHhSV(byte[] r0, int r1, int r2, int r3, stringBuilder r4) {
        encodeBinary(r0, r1, r2, r3, r4);
    }

    public static stringBuilder XRrOSHPrvjkMmHbN(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static void XlCrttbGZlPtKjUo(int r0, stringBuilder r1) {
        encodingECI(r0, r1);
    }

    public static stringBuilder XmAltPWbOvmZGGxr(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static stringBuilder ZOtHDYkJOmhdIDJN(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static bool ZalDkHjroDRmWuej(ECIInput r1, int r2) {
        return r1.isECI(r2);
    }

    public static bool ZpfbLUnGlSidCSUa(char r1) {
        return isDigit(r1);
    }
}

