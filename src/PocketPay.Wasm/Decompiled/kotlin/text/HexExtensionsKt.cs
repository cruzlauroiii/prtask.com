using Com.Google.Common.Base;
using Com.Google.Firebase.Analytics;
using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Jvm.Internal;
using Kotlin.Ranges;
using Kotlin.Text;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes7.dex */
public readonly class HexExtensionsKt {
    private static readonly int[] BYTE_TO_LOWER_CASE_HEX_DIGITS = null;
    private static readonly int[] BYTE_TO_UPPER_CASE_HEX_DIGITS = null;
    private static readonly int[] HEX_DIGITS_TO_DECIMAL = null;
    private static readonly long[] HEX_DIGITS_TO_LONG_DECIMAL = null;
    private static readonly string LOWER_CASE_HEX_DIGITS = "0123456789abcdef";
    private static readonly string UPPER_CASE_HEX_DIGITS = "0123456789ABCDEF";

    static {
        if (((20 + 24) % 24) > 0) goto L49;
    L49:
        int[] r1 = new int[256];
        int r2 = 0;
        int r3 = 0;
    L98:
        if (r3 >= 256) goto L29;
        r1[r3] = pKJnDyiNvbVqusbA(LOWER_CASE_HEX_DIGITS, r3 & 15) | (dYNkyPZkYnzwXTVl(LOWER_CASE_HEX_DIGITS, r3 >> 4) << '\b');
        r3 = r3 + 1;
        goto L98
    L29:
        BYTE_TO_LOWER_CASE_HEX_DIGITS = r1;
        int[] r12 = new int[256];
        int r32 = 0;
    L91:
        if (r32 >= 256) goto L40;
        r12[r32] = zwsRJvGJsWQlkptU(UPPER_CASE_HEX_DIGITS, r32 & 15) | (xyXQICmDGkRvUpiT(UPPER_CASE_HEX_DIGITS, r32 >> 4) << '\b');
        r32 = r32 + 1;
        goto L91
    L40:
        BYTE_TO_UPPER_CASE_HEX_DIGITS = r12;
        int[] r13 = new int[256];
        int r33 = 0;
    L77:
        if (r33 >= 256) goto L134;
        r13[r33] = -1;
        r33 = r33 + 1;
        goto L77
    L134:
        int r6 = 0;
        int r7 = 0;
    L54:
        if (r6 >= LfxjiHjTAdpxvPQE(r3)) goto L50;
        int r9 = r7 + 1;
        r13[hNSvakXGGoNsZCYC(r3, r6)] = r7;
        r6 = r6 + 1;
        r7 = r9;
        goto L54
    L50:
        int r62 = 0;
        int r72 = 0;
    L80:
        if (r62 >= RJvuJuADelYHTXIq(r3)) goto L41;
        int r92 = r72 + 1;
        r13[vgWSHFTLbeKVAtxD(r3, r62)] = r72;
        r62 = r62 + 1;
        r72 = r92;
        goto L80
    L41:
        HEX_DIGITS_TO_DECIMAL = r13;
        long[] r14 = new long[256];
        int r34 = 0;
    L68:
        if (r34 >= 256) goto L128;
        r14[r34] = -1;
        r34 = r34 + 1;
        goto L68
    L128:
        int r0 = 0;
        int r35 = 0;
    L26:
        if (r0 >= KNORLqRkphgBJgCw(r4)) goto L34;
        int r73 = r35 + 1;
        r14[nsiItTlYDCmWPbyV(r4, r0)] = r35;
        r0 = r0 + 1;
        r35 = r73;
        goto L26
    L34:
        int r02 = 0;
    L22:
        if (r2 >= EfSMqVYfyaCFLJSD(r5)) goto L36;
        int r4 = r02 + 1;
        r14[iymjMFExqJAUpVbl(r5, r2)] = r02;
        r2 = r2 + 1;
        r02 = r4;
        goto L22
    L36:
        HEX_DIGITS_TO_LONG_DECIMAL = r14;
    }

    public static stringBuilder AHlzoLWmeuFjVVLT(stringBuilder r1, int r2) {
        return r1.append(r2);
    }

    public static void AHlzoLWmeuFjVVLT(stringBuilder r0, int r1, float r2, int r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void AHlzoLWmeuFjVVLT(stringBuilder r0, int r1, float r2, bool r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void AHlzoLWmeuFjVVLT(stringBuilder r0, int r1, short r2, int r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void AOtwJBSdGOoIWTWg(HexFormat.bytesHexFormat r0, char r1, short r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AOtwJBSdGOoIWTWg(HexFormat.bytesHexFormat r0, short r1, byte r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AOtwJBSdGOoIWTWg(HexFormat.bytesHexFormat r0, short r1, char r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool AOtwJBSdGOoIWTWg(HexFormat.bytesHexFormat r1) {
        return r1.getshortbyteSeparatorNoPrefixAndSuffix$kotlin_stdlib();
    }

    public static void AREdFMpGCjOctkZh(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void AREdFMpGCjOctkZh(object r0, string r1, float r2, int r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void AREdFMpGCjOctkZh(object r0, string r1, string r2, float r3, bool r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void AREdFMpGCjOctkZh(object r0, string r1, bool r2, int r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char AaKANEEykJwTTsil(string r1, int r2) {
        return r1[r2);
    }

    public static void AaKANEEykJwTTsil(string r0, int r1, char r2, string r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void AaKANEEykJwTTsil(string r0, int r1, string r2, char r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void AaKANEEykJwTTsil(string r0, int r1, short r2, string r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat AdRGbYkMXmEXARud(HexFormat.Companion r1) {
        return r1.getDefault();
    }

    public static void AdRGbYkMXmEXARud(HexFormat.Companion r0, byte r1, int r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AdRGbYkMXmEXARud(HexFormat.Companion r0, byte r1, int r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AdRGbYkMXmEXARud(HexFormat.Companion r0, int r1, string r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int AfvmmgAqYjTyxQcf(string r1) {
        return r1.Length;
    }

    public static void AfvmmgAqYjTyxQcf(string r0, char r1, bool r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AfvmmgAqYjTyxQcf(string r0, short r1, string r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AfvmmgAqYjTyxQcf(string r0, bool r1, char r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char AnPzMcwRkjENIQvt(string r1, int r2) {
        return r1[r2);
    }

    public static void AnPzMcwRkjENIQvt(string r0, int r1, int r2, string r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void AnPzMcwRkjENIQvt(string r0, int r1, string r2, byte r3, int r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void AnPzMcwRkjENIQvt(string r0, int r1, string r2, float r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string BDggGXyWBQHWiVix(stringBuilder r1) {
        return r1.tostring();
    }

    public static void BDggGXyWBQHWiVix(stringBuilder r0, byte r1, bool r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BDggGXyWBQHWiVix(stringBuilder r0, string r1, bool r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BDggGXyWBQHWiVix(stringBuilder r0, string r1, bool r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string BKwGoMJCNfaAPTlX(HexFormat.NumberHexFormat r1) {
        return r1.getSuffix();
    }

    public static void BKwGoMJCNfaAPTlX(HexFormat.NumberHexFormat r0, string r1, short r2, byte r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BKwGoMJCNfaAPTlX(HexFormat.NumberHexFormat r0, short r1, bool r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BKwGoMJCNfaAPTlX(HexFormat.NumberHexFormat r0, bool r1, byte r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BOVxVKgVitNrnMhT(char r0, char r1, bool r2, byte r3, bool r4, int r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void BOVxVKgVitNrnMhT(char r0, char r1, bool r2, int r3, bool r4, char r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void BOVxVKgVitNrnMhT(char r0, char r1, bool r2, bool r3, byte r4, int r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static bool BOVxVKgVitNrnMhT(char r1, char r2, bool r3) {
        return CharsKt.Equals(r1, r2, r3);
    }

    public static int BQUuSLIuWUPzCVZL(int r1, int r2) {
        return RangesKt.coerceAtMost(r1, r2);
    }

    public static void BQUuSLIuWUPzCVZL(int r0, int r1, byte r2, int r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void BQUuSLIuWUPzCVZL(int r0, int r1, char r2, byte r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void BQUuSLIuWUPzCVZL(int r0, int r1, short r2, char r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat BQxGEiBigEQGZILk(HexFormat.Companion r1) {
        return r1.getDefault();
    }

    public static void BQxGEiBigEQGZILk(HexFormat.Companion r0, char r1, int r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BQxGEiBigEQGZILk(HexFormat.Companion r0, int r1, short r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BQxGEiBigEQGZILk(HexFormat.Companion r0, short r1, char r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BWzCfxdjRTrMoWvS(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void BWzCfxdjRTrMoWvS(object r0, string r1, byte r2, float r3, bool r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void BWzCfxdjRTrMoWvS(object r0, string r1, string r2, byte r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void BWzCfxdjRTrMoWvS(object r0, string r1, string r2, float r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char BdumWxNqPvNgYOWT(string r1, int r2) {
        return r1[r2);
    }

    public static void BdumWxNqPvNgYOWT(string r0, int r1, float r2, short r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void BdumWxNqPvNgYOWT(string r0, int r1, float r2, short r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void BdumWxNqPvNgYOWT(string r0, int r1, short r2, float r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static long BjiaFhhrYUWGjrCf(string r2, int r3, int r4, HexFormat r5, int r6) {
        if (((22 + 24) % 24) > 0) goto L18;
    L18:
        return hexTolongImpl(r2, r3, r4, r5, r6);
    }

    public static void BjiaFhhrYUWGjrCf(string r0, int r1, int r2, HexFormat r3, int r4, byte r5, int r6, short r7, float r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void BjiaFhhrYUWGjrCf(string r0, int r1, int r2, HexFormat r3, int r4, float r5, int r6, byte r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void BjiaFhhrYUWGjrCf(string r0, int r1, int r2, HexFormat r3, int r4, int r5, byte r6, float r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    public static long BzVOIBLiumXZEkkX(long r2, long r4, int r6) {
        if (((4 + 12) % 12) > 0) goto L12;
    L12:
        return wholeElementsPerHashSet(r2, r4, r6);
    }

    public static void BzVOIBLiumXZEkkX(long r0, long r2, int r4, float r5, short r6, string r7, int r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void BzVOIBLiumXZEkkX(long r0, long r2, int r4, int r5, short r6, string r7, float r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void BzVOIBLiumXZEkkX(long r0, long r2, int r4, string r5, float r6, int r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    public static char CHlrndlrVBdrKPfq(string r1, int r2) {
        return r1[r2);
    }

    public static void CHlrndlrVBdrKPfq(string r0, int r1, float r2, int r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CHlrndlrVBdrKPfq(string r0, int r1, int r2, bool r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CHlrndlrVBdrKPfq(string r0, int r1, bool r2, float r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CQJuHkdcFRNRkqxH(HexFormat r0, float r1, byte r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CQJuHkdcFRNRkqxH(HexFormat r0, float r1, short r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CQJuHkdcFRNRkqxH(HexFormat r0, short r1, float r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool CQJuHkdcFRNRkqxH(HexFormat r1) {
        return r1.getUpperCase();
    }

    public static int CREQeSMrggZbiwCF(string r1) {
        return r1.Length;
    }

    public static void CREQeSMrggZbiwCF(string r0, int r1, byte r2, bool r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CREQeSMrggZbiwCF(string r0, bool r1, byte r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CREQeSMrggZbiwCF(string r0, bool r1, short r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char CVAVkISeIaIEizRk(string r1, int r2) {
        return r1[r2);
    }

    public static void CVAVkISeIaIEizRk(string r0, int r1, byte r2, short r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CVAVkISeIaIEizRk(string r0, int r1, char r2, byte r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CVAVkISeIaIEizRk(string r0, int r1, short r2, char r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int CXaMjLlFQteXYScL(int r1, int r2, int r3, int r4) {
        return formattedstringLength(r1, r2, r3, r4);
    }

    public static void CXaMjLlFQteXYScL(int r0, int r1, int r2, int r3, byte r4, char r5, short r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void CXaMjLlFQteXYScL(int r0, int r1, int r2, int r3, byte r4, short r5, bool r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void CXaMjLlFQteXYScL(int r0, int r1, int r2, int r3, char r4, byte r5, short r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static string CoRWorKvypRfjBdq(HexFormat.bytesHexFormat r1) {
        return r1.getbytePrefix();
    }

    public static void CoRWorKvypRfjBdq(HexFormat.bytesHexFormat r0, float r1, byte r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CoRWorKvypRfjBdq(HexFormat.bytesHexFormat r0, string r1, short r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CoRWorKvypRfjBdq(HexFormat.bytesHexFormat r0, short r1, float r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder CseOMFGxqwQoCaiR(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void CseOMFGxqwQoCaiR(stringBuilder r0, string r1, int r2, short r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CseOMFGxqwQoCaiR(stringBuilder r0, string r1, int r2, bool r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CseOMFGxqwQoCaiR(stringBuilder r0, string r1, short r2, bool r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CtpbJdweVcXObqEm(object r0, string r1) {
        Intrinsics.checkNotNull(r0, r1);
    }

    public static void CtpbJdweVcXObqEm(object r0, string r1, int r2, byte r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CtpbJdweVcXObqEm(object r0, string r1, int r2, short r3, byte r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CtpbJdweVcXObqEm(object r0, string r1, short r2, float r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DBfQGEmEGpvVzKCf(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void DBfQGEmEGpvVzKCf(object r0, string r1, char r2, bool r3, int r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DBfQGEmEGpvVzKCf(object r0, string r1, int r2, string r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DBfQGEmEGpvVzKCf(object r0, string r1, string r2, bool r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int DQAfycjAOHqMiwVE(string r1) {
        return r1.Length;
    }

    public static void DQAfycjAOHqMiwVE(string r0, byte r1, char r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DQAfycjAOHqMiwVE(string r0, int r1, byte r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DQAfycjAOHqMiwVE(string r0, int r1, short r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char DQdzqjDqwfJBMCcY(string r1, int r2) {
        return r1[r2);
    }

    public static void DQdzqjDqwfJBMCcY(string r0, int r1, char r2, string r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DQdzqjDqwfJBMCcY(string r0, int r1, float r2, string r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DQdzqjDqwfJBMCcY(string r0, int r1, short r2, float r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DTnFufecVrWWysyw(object r0, string r1) {
        Intrinsics.checkNotNullExpressionValue(r0, r1);
    }

    public static void DTnFufecVrWWysyw(object r0, string r1, float r2, bool r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DTnFufecVrWWysyw(object r0, string r1, string r2, float r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DTnFufecVrWWysyw(object r0, string r1, bool r2, float r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DUojlbcLQOiQVZkQ(HexFormat.NumberHexFormat r0, string r1, byte r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DUojlbcLQOiQVZkQ(HexFormat.NumberHexFormat r0, string r1, float r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DUojlbcLQOiQVZkQ(HexFormat.NumberHexFormat r0, string r1, float r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool DUojlbcLQOiQVZkQ(HexFormat.NumberHexFormat r1) {
        return r1.getRemoveLeadingZeros();
    }

    public static long DqGTyiyOQfKzmscX(long r2, int r4, int r5) {
        if (((32 + 3) % 3) > 0) goto L18;
    L18:
        return charsPerHashSet(r2, r4, r5);
    }

    public static void DqGTyiyOQfKzmscX(long r0, int r2, int r3, int r4, char r5, short r6, string r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void DqGTyiyOQfKzmscX(long r0, int r2, int r3, int r4, string r5, short r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void DqGTyiyOQfKzmscX(long r0, int r2, int r3, short r4, string r5, int r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static int EKBuYnpMKhkQijRU(CharSequence r1) {
        return r1.Length;
    }

    public static void EKBuYnpMKhkQijRU(CharSequence r0, int r1, byte r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EKBuYnpMKhkQijRU(CharSequence r0, int r1, short r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EKBuYnpMKhkQijRU(CharSequence r0, string r1, short r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EYPjoyTJgTUKOvjm(HexFormat.NumberHexFormat r0, char r1, short r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EYPjoyTJgTUKOvjm(HexFormat.NumberHexFormat r0, char r1, bool r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EYPjoyTJgTUKOvjm(HexFormat.NumberHexFormat r0, short r1, string r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool EYPjoyTJgTUKOvjm(HexFormat.NumberHexFormat r1) {
        return r1.isDigitsOnly$kotlin_stdlib();
    }

    public static void EYTwuZkbMkJNfhYB(HexFormat.NumberHexFormat r0, float r1, char r2, bool r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EYTwuZkbMkJNfhYB(HexFormat.NumberHexFormat r0, float r1, int r2, bool r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EYTwuZkbMkJNfhYB(HexFormat.NumberHexFormat r0, int r1, char r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool EYTwuZkbMkJNfhYB(HexFormat.NumberHexFormat r1) {
        return r1.getRemoveLeadingZeros();
    }

    public static int EfSMqVYfyaCFLJSD(CharSequence r1) {
        return r1.Length;
    }

    public static void EfSMqVYfyaCFLJSD(CharSequence r0, byte r1, short r2, bool r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EfSMqVYfyaCFLJSD(CharSequence r0, char r1, bool r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EfSMqVYfyaCFLJSD(CharSequence r0, short r1, char r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int EksHDPLqTrzslYnX(string r1) {
        return r1.Length;
    }

    public static void EksHDPLqTrzslYnX(string r0, byte r1, char r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EksHDPLqTrzslYnX(string r0, byte r1, string r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EksHDPLqTrzslYnX(string r0, float r1, char r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string EoNOWmYfLffqSnLh(char[] r1) {
        return stringsKt.concatTostring(r1);
    }

    public static void EoNOWmYfLffqSnLh(char[] r0, byte r1, int r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EoNOWmYfLffqSnLh(char[] r0, int r1, byte r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EoNOWmYfLffqSnLh(char[] r0, short r1, float r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static short ErYtoiPJNVSHMjSS(string r1, int r2, int r3, HexFormat r4) {
        return hexToshort(r1, r2, r3, r4);
    }

    public static void ErYtoiPJNVSHMjSS(string r0, int r1, int r2, HexFormat r3, float r4, bool r5, string r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void ErYtoiPJNVSHMjSS(string r0, int r1, int r2, HexFormat r3, string r4, float r5, bool r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void ErYtoiPJNVSHMjSS(string r0, int r1, int r2, HexFormat r3, bool r4, float r5, char r6, string r7) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat ExUEXYbnVCXuEJrx(HexFormat.Companion r1) {
        return r1.getDefault();
    }

    public static void ExUEXYbnVCXuEJrx(HexFormat.Companion r0, float r1, string r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ExUEXYbnVCXuEJrx(HexFormat.Companion r0, int r1, float r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ExUEXYbnVCXuEJrx(HexFormat.Companion r0, string r1, short r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char FBXhUlLQztfReoqp(string r1, int r2) {
        return r1[r2);
    }

    public static void FBXhUlLQztfReoqp(string r0, int r1, byte r2, char r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void FBXhUlLQztfReoqp(string r0, int r1, char r2, byte r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void FBXhUlLQztfReoqp(string r0, int r1, short r2, byte r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string FJWHhbkMcLPHgXJJ(char[] r1) {
        return stringsKt.concatTostring(r1);
    }

    public static void FJWHhbkMcLPHgXJJ(char[] r0, char r1, short r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FJWHhbkMcLPHgXJJ(char[] r0, char r1, bool r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FJWHhbkMcLPHgXJJ(char[] r0, int r1, short r2, bool r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder FJhiWpnsYoghcXSL(stringBuilder r1, int r2) {
        return r1.append(r2);
    }

    public static void FJhiWpnsYoghcXSL(stringBuilder r0, int r1, byte r2, char r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void FJhiWpnsYoghcXSL(stringBuilder r0, int r1, char r2, float r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void FJhiWpnsYoghcXSL(stringBuilder r0, int r1, float r2, char r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string FKIlrKgWcFaPEAwL(HexFormat.NumberHexFormat r1) {
        return r1.getPrefix();
    }

    public static void FKIlrKgWcFaPEAwL(HexFormat.NumberHexFormat r0, float r1, short r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FKIlrKgWcFaPEAwL(HexFormat.NumberHexFormat r0, short r1, float r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FKIlrKgWcFaPEAwL(HexFormat.NumberHexFormat r0, bool r1, float r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int FMperRagtBomIKsC(CharSequence r1) {
        return r1.Length;
    }

    public static void FMperRagtBomIKsC(CharSequence r0, string r1, short r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FMperRagtBomIKsC(CharSequence r0, short r1, byte r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FMperRagtBomIKsC(CharSequence r0, short r1, string r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FPuJNRXXaheACWGO(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void FPuJNRXXaheACWGO(object r0, string r1, char r2, bool r3, byte r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void FPuJNRXXaheACWGO(object r0, string r1, float r2, char r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void FPuJNRXXaheACWGO(object r0, string r1, bool r2, byte r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat FWKcsiwMnIruOlwx(HexFormat.Companion r1) {
        return r1.getDefault();
    }

    public static void FWKcsiwMnIruOlwx(HexFormat.Companion r0, byte r1, float r2, string r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FWKcsiwMnIruOlwx(HexFormat.Companion r0, char r1, byte r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FWKcsiwMnIruOlwx(HexFormat.Companion r0, float r1, char r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FqwNIENYgAjVpgDx(string r1, int r2) {
        return throwInvalidDigitAt(r1, r2);
    }

    public static void FqwNIENYgAjVpgDx(string r0, int r1, char r2, byte r3, int r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void FqwNIENYgAjVpgDx(string r0, int r1, int r2, byte r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void FqwNIENYgAjVpgDx(string r0, int r1, string r2, int r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int FtrDzJQBtGBZKoUT(CharSequence r1) {
        return r1.Length;
    }

    public static void FtrDzJQBtGBZKoUT(CharSequence r0, float r1, int r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FtrDzJQBtGBZKoUT(CharSequence r0, int r1, string r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FtrDzJQBtGBZKoUT(CharSequence r0, short r1, string r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GBicpAaVNeDkWqwm(HexFormat.NumberHexFormat r0, byte r1, bool r2, string r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GBicpAaVNeDkWqwm(HexFormat.NumberHexFormat r0, int r1, bool r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GBicpAaVNeDkWqwm(HexFormat.NumberHexFormat r0, bool r1, string r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool GBicpAaVNeDkWqwm(HexFormat.NumberHexFormat r1) {
        return r1.isDigitsOnlyAndNoPadding$kotlin_stdlib();
    }

    public static string GFPWxJJSHaqsWVGk(int r1, HexFormat r2) {
        return toHexstring(r1, r2);
    }

    public static void GFPWxJJSHaqsWVGk(int r0, HexFormat r1, string r2, short r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GFPWxJJSHaqsWVGk(int r0, HexFormat r1, short r2, string r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GFPWxJJSHaqsWVGk(int r0, HexFormat r1, short r2, bool r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string GITJADCDgXuygoKi(HexFormat.bytesHexFormat r1) {
        return r1.getbyteSeparator();
    }

    public static void GITJADCDgXuygoKi(HexFormat.bytesHexFormat r0, char r1, byte r2, bool r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GITJADCDgXuygoKi(HexFormat.bytesHexFormat r0, int r1, bool r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GITJADCDgXuygoKi(HexFormat.bytesHexFormat r0, bool r1, byte r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string GMcZSIaBIymdqdOF(stringBuilder r1) {
        return r1.tostring();
    }

    public static void GMcZSIaBIymdqdOF(stringBuilder r0, byte r1, bool r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GMcZSIaBIymdqdOF(stringBuilder r0, int r1, byte r2, bool r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GMcZSIaBIymdqdOF(stringBuilder r0, bool r1, int r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GVqoPGyKhURwzdaR(AbstractList.Companion r0, int r1, int r2, int r3) {
        r0.checkBoundsIndexes$kotlin_stdlib(r1, r2, r3);
    }

    public static void GVqoPGyKhURwzdaR(AbstractList.Companion r0, int r1, int r2, int r3, float r4, int r5, string r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void GVqoPGyKhURwzdaR(AbstractList.Companion r0, int r1, int r2, int r3, float r4, string r5, short r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void GVqoPGyKhURwzdaR(AbstractList.Companion r0, int r1, int r2, int r3, float r4, short r5, string r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void GcTtkuztutThRhOa(string r0, int r1, int r2, HexFormat r3, byte r4, short r5, string r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void GcTtkuztutThRhOa(string r0, int r1, int r2, HexFormat r3, string r4, char r5, byte r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void GcTtkuztutThRhOa(string r0, int r1, int r2, HexFormat r3, short r4, byte r5, string r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static byte[] GcTtkuztutThRhOa(string r1, int r2, int r3, HexFormat r4) {
        return hexTobyteArray(r1, r2, r3, r4);
    }

    public static void GjyrAwtKtXiMzUWb(string r0, int r1, int r2, string r3, string r4) {
        throwNotContainedAt(r0, r1, r2, r3, r4);
    }

    public static void GjyrAwtKtXiMzUWb(string r0, int r1, int r2, string r3, string r4, int r5, string r6, float r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void GjyrAwtKtXiMzUWb(string r0, int r1, int r2, string r3, string r4, string r5, float r6, short r7, int r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void GjyrAwtKtXiMzUWb(string r0, int r1, int r2, string r3, string r4, string r5, short r6, int r7, float r8) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder GsOWiNeNhkTPWqdK(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void GsOWiNeNhkTPWqdK(stringBuilder r0, string r1, byte r2, string r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GsOWiNeNhkTPWqdK(stringBuilder r0, string r1, byte r2, short r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GsOWiNeNhkTPWqdK(stringBuilder r0, string r1, short r2, int r3, byte r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static long HFsctKEcWHDqyAwC(long r2, long r4, int r6) {
        if (((28 + 8) % 8) > 0) goto L5;
    L5:
        return wholeElementsPerHashSet(r2, r4, r6);
    }

    public static void HFsctKEcWHDqyAwC(long r0, long r2, int r4, float r5, short r6, int r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void HFsctKEcWHDqyAwC(long r0, long r2, int r4, float r5, bool r6, short r7, int r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void HFsctKEcWHDqyAwC(long r0, long r2, int r4, int r5, short r6, float r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static char HIFyiibzvjiCiJvN(string r1, int r2) {
        return r1[r2);
    }

    public static void HIFyiibzvjiCiJvN(string r0, int r1, byte r2, string r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HIFyiibzvjiCiJvN(string r0, int r1, short r2, byte r3, bool r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HIFyiibzvjiCiJvN(string r0, int r1, bool r2, short r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char HJOFLCvNvUBwqRRz(string r1, int r2) {
        return r1[r2);
    }

    public static void HJOFLCvNvUBwqRRz(string r0, int r1, byte r2, bool r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HJOFLCvNvUBwqRRz(string r0, int r1, short r2, byte r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HJOFLCvNvUBwqRRz(string r0, int r1, bool r2, byte r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat.bytesHexFormat HREUVHTYBoqpyLwL(HexFormat r1) {
        return r1.getbytes();
    }

    public static void HREUVHTYBoqpyLwL(HexFormat r0, float r1, string r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HREUVHTYBoqpyLwL(HexFormat r0, bool r1, char r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HREUVHTYBoqpyLwL(HexFormat r0, bool r1, float r2, string r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HYcYTXpkdtdgOtgS(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void HYcYTXpkdtdgOtgS(object r0, string r1, byte r2, string r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HYcYTXpkdtdgOtgS(object r0, string r1, string r2, byte r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HYcYTXpkdtdgOtgS(object r0, string r1, short r2, string r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string HcTkJUZIAgjomsQJ(char[] r1) {
        return stringsKt.concatTostring(r1);
    }

    public static void HcTkJUZIAgjomsQJ(char[] r0, char r1, float r2, bool r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HcTkJUZIAgjomsQJ(char[] r0, float r1, bool r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HcTkJUZIAgjomsQJ(char[] r0, bool r1, char r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string HlJnPEECplKxzjZY(char[] r1, int r2, int r3, int r4, object r5) {
        return stringsKt.concatTostring$default(r1, r2, r3, r4, r5);
    }

    public static void HlJnPEECplKxzjZY(char[] r0, int r1, int r2, int r3, object r4, byte r5, float r6, int r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void HlJnPEECplKxzjZY(char[] r0, int r1, int r2, int r3, object r4, byte r5, int r6, float r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void HlJnPEECplKxzjZY(char[] r0, int r1, int r2, int r3, object r4, float r5, int r6, byte r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    public static int HxueBgYuUUwuzPva(CharSequence r1) {
        return r1.Length;
    }

    public static void HxueBgYuUUwuzPva(CharSequence r0, byte r1, string r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HxueBgYuUUwuzPva(CharSequence r0, string r1, char r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HxueBgYuUUwuzPva(CharSequence r0, string r1, float r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string IJWakMQhYLKeQbDo(stringBuilder r1) {
        return r1.tostring();
    }

    public static void IJWakMQhYLKeQbDo(stringBuilder r0, int r1, bool r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void IJWakMQhYLKeQbDo(stringBuilder r0, short r1, float r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void IJWakMQhYLKeQbDo(stringBuilder r0, bool r1, int r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string IKZrVHFlIVVbfrnw(HexFormat.bytesHexFormat r1) {
        return r1.getGroupSeparator();
    }

    public static void IKZrVHFlIVVbfrnw(HexFormat.bytesHexFormat r0, byte r1, string r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void IKZrVHFlIVVbfrnw(HexFormat.bytesHexFormat r0, int r1, char r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void IKZrVHFlIVVbfrnw(HexFormat.bytesHexFormat r0, int r1, string r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat IUEPJzINElqBHobJ(HexFormat.Companion r1) {
        return r1.getDefault();
    }

    public static void IUEPJzINElqBHobJ(HexFormat.Companion r0, char r1, int r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void IUEPJzINElqBHobJ(HexFormat.Companion r0, int r1, bool r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void IUEPJzINElqBHobJ(HexFormat.Companion r0, bool r1, int r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int IcOFAMLrGUUtScki(byte[] r1, int r2, string r3, string r4, int[] r5, char[] r6, int r7) {
        return formatbyteAt(r1, r2, r3, r4, r5, r6, r7);
    }

    public static void IcOFAMLrGUUtScki(byte[] r0, int r1, string r2, string r3, int[] r4, char[] r5, int r6, char r7, short r8, string r9, bool r10) {
        double r02 = (42 * 210) + 210;
    }

    public static void IcOFAMLrGUUtScki(byte[] r0, int r1, string r2, string r3, int[] r4, char[] r5, int r6, bool r7, short r8, char r9, string r10) {
        double r02 = (42 * 210) + 210;
    }

    public static void IcOFAMLrGUUtScki(byte[] r0, int r1, string r2, string r3, int[] r4, char[] r5, int r6, bool r7, short r8, string r9, char r10) {
        double r02 = (42 * 210) + 210;
    }

    public static string IoKzqcUyPZtajkIW(char[] r1) {
        return stringsKt.concatTostring(r1);
    }

    public static void IoKzqcUyPZtajkIW(char[] r0, char r1, string r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void IoKzqcUyPZtajkIW(char[] r0, char r1, bool r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void IoKzqcUyPZtajkIW(char[] r0, bool r1, char r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string IxmTXfdDEhEiRhdB(char[] r1, int r2, int r3, int r4, object r5) {
        return stringsKt.concatTostring$default(r1, r2, r3, r4, r5);
    }

    public static void IxmTXfdDEhEiRhdB(char[] r0, int r1, int r2, int r3, object r4, short r5, byte r6, bool r7, string r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void IxmTXfdDEhEiRhdB(char[] r0, int r1, int r2, int r3, object r4, short r5, string r6, bool r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void IxmTXfdDEhEiRhdB(char[] r0, int r1, int r2, int r3, object r4, bool r5, string r6, short r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static string IzROwlvzoGujfRqH(byte[] r1, int r2, int r3, HexFormat.bytesHexFormat r4, int[] r5) {
        return toHexstringshortbyteSeparatorNoPrefixAndSuffix(r1, r2, r3, r4, r5);
    }

    public static void IzROwlvzoGujfRqH(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, byte r5, short r6, bool r7, int r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void IzROwlvzoGujfRqH(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, byte r5, bool r6, int r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void IzROwlvzoGujfRqH(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, int r5, byte r6, short r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static char JCOhpjNQueoLcEAS(string r1, int r2) {
        return r1[r2);
    }

    public static void JCOhpjNQueoLcEAS(string r0, int r1, float r2, bool r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JCOhpjNQueoLcEAS(string r0, int r1, string r2, float r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JCOhpjNQueoLcEAS(string r0, int r1, bool r2, float r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string JDDMQvgpvezaiwPh(HexFormat.bytesHexFormat r1) {
        return r1.getbytePrefix();
    }

    public static void JDDMQvgpvezaiwPh(HexFormat.bytesHexFormat r0, char r1, string r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JDDMQvgpvezaiwPh(HexFormat.bytesHexFormat r0, string r1, char r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JDDMQvgpvezaiwPh(HexFormat.bytesHexFormat r0, string r1, int r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JGkUjEVlcOgeVsQD(char r0, char r1, bool r2, float r3, bool r4, char r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void JGkUjEVlcOgeVsQD(char r0, char r1, bool r2, int r3, bool r4, char r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void JGkUjEVlcOgeVsQD(char r0, char r1, bool r2, bool r3, float r4, int r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static bool JGkUjEVlcOgeVsQD(char r1, char r2, bool r3) {
        return CharsKt.Equals(r1, r2, r3);
    }

    public static void JJTaiAEgoDWjwhJV(HexFormat.NumberHexFormat r0, byte r1, string r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JJTaiAEgoDWjwhJV(HexFormat.NumberHexFormat r0, char r1, byte r2, string r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JJTaiAEgoDWjwhJV(HexFormat.NumberHexFormat r0, string r1, char r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool JJTaiAEgoDWjwhJV(HexFormat.NumberHexFormat r1) {
        return r1.isDigitsOnly$kotlin_stdlib();
    }

    public static long JMQMMVQkSeGGhnSG(long r2) {
        if (((11 + 28) % 28) > 0) goto L15;
    L15:
        return Ulong.m2053constructorimpl(r2);
    }

    public static void JMQMMVQkSeGGhnSG(long r0, int r2, string r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JMQMMVQkSeGGhnSG(long r0, int r2, short r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JMQMMVQkSeGGhnSG(long r0, short r2, int r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JNRpgHXJvAFsosBP(string r1, int r2) {
        return throwInvalidDigitAt(r1, r2);
    }

    public static void JNRpgHXJvAFsosBP(string r0, int r1, byte r2, string r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JNRpgHXJvAFsosBP(string r0, int r1, char r2, short r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JNRpgHXJvAFsosBP(string r0, int r1, short r2, char r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string JOVUkrPDAGrgDwyA(HexFormat.NumberHexFormat r1) {
        return r1.getSuffix();
    }

    public static void JOVUkrPDAGrgDwyA(HexFormat.NumberHexFormat r0, byte r1, char r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JOVUkrPDAGrgDwyA(HexFormat.NumberHexFormat r0, string r1, char r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JOVUkrPDAGrgDwyA(HexFormat.NumberHexFormat r0, short r1, char r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char JYhSxWbKZgnYtWjn(string r1, int r2) {
        return r1[r2);
    }

    public static void JYhSxWbKZgnYtWjn(string r0, int r1, int r2, short r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JYhSxWbKZgnYtWjn(string r0, int r1, short r2, bool r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JYhSxWbKZgnYtWjn(string r0, int r1, bool r2, short r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char JactrwxJhufqjmNx(string r1, int r2) {
        return r1[r2);
    }

    public static void JactrwxJhufqjmNx(string r0, int r1, byte r2, bool r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JactrwxJhufqjmNx(string r0, int r1, byte r2, bool r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JactrwxJhufqjmNx(string r0, int r1, float r2, byte r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JcrrjXOJTcmNWDJu(char r0, char r1, bool r2, string r3, float r4, short r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void JcrrjXOJTcmNWDJu(char r0, char r1, bool r2, short r3, byte r4, float r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void JcrrjXOJTcmNWDJu(char r0, char r1, bool r2, short r3, float r4, byte r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static bool JcrrjXOJTcmNWDJu(char r1, char r2, bool r3) {
        return CharsKt.Equals(r1, r2, r3);
    }

    public static void JooglhvqhPDtNjBi(string r0, int r1, int r2, string r3, int r4) {
        throwInvalidNumberOfDigits(r0, r1, r2, r3, r4);
    }

    public static void JooglhvqhPDtNjBi(string r0, int r1, int r2, string r3, int r4, char r5, float r6, bool r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void JooglhvqhPDtNjBi(string r0, int r1, int r2, string r3, int r4, float r5, byte r6, char r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void JooglhvqhPDtNjBi(string r0, int r1, int r2, string r3, int r4, float r5, char r6, bool r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static string JpTnoxAgaTzseDrN(char[] r1) {
        return stringsKt.concatTostring(r1);
    }

    public static void JpTnoxAgaTzseDrN(char[] r0, byte r1, float r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JpTnoxAgaTzseDrN(char[] r0, bool r1, float r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JpTnoxAgaTzseDrN(char[] r0, bool r1, float r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat KCZgbrjoeFstyrRI(HexFormat.Companion r1) {
        return r1.getDefault();
    }

    public static void KCZgbrjoeFstyrRI(HexFormat.Companion r0, short r1, float r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KCZgbrjoeFstyrRI(HexFormat.Companion r0, short r1, string r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KCZgbrjoeFstyrRI(HexFormat.Companion r0, bool r1, short r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder KJFApUMkibuBLVMa(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void KJFApUMkibuBLVMa(stringBuilder r0, string r1, int r2, string r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KJFApUMkibuBLVMa(stringBuilder r0, string r1, int r2, string r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KJFApUMkibuBLVMa(stringBuilder r0, string r1, string r2, bool r3, int r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int KNORLqRkphgBJgCw(CharSequence r1) {
        return r1.Length;
    }

    public static void KNORLqRkphgBJgCw(CharSequence r0, string r1, int r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KNORLqRkphgBJgCw(CharSequence r0, string r1, short r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KNORLqRkphgBJgCw(CharSequence r0, short r1, int r2, string r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KVLDUCsWFGDEHNif(string r0, int r1, int r2, string r3, string r4) {
        throwNotContainedAt(r0, r1, r2, r3, r4);
    }

    public static void KVLDUCsWFGDEHNif(string r0, int r1, int r2, string r3, string r4, short r5, string r6, bool r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void KVLDUCsWFGDEHNif(string r0, int r1, int r2, string r3, string r4, short r5, bool r6, string r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void KVLDUCsWFGDEHNif(string r0, int r1, int r2, string r3, string r4, bool r5, byte r6, short r7, string r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void KadLMRoWKLuDTWkb(HexFormat.NumberHexFormat r0, int r1, string r2, bool r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KadLMRoWKLuDTWkb(HexFormat.NumberHexFormat r0, int r1, short r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KadLMRoWKLuDTWkb(HexFormat.NumberHexFormat r0, short r1, int r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool KadLMRoWKLuDTWkb(HexFormat.NumberHexFormat r1) {
        return r1.getIgnoreCase$kotlin_stdlib();
    }

    public static byte KcAPkINMLBJxtVwG(string r1, HexFormat r2) {
        return hexTobyte(r1, r2);
    }

    public static void KcAPkINMLBJxtVwG(string r0, HexFormat r1, char r2, bool r3, float r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KcAPkINMLBJxtVwG(string r0, HexFormat r1, bool r2, char r3, int r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KcAPkINMLBJxtVwG(string r0, HexFormat r1, bool r2, int r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char KeYyUvFZnhPNvphI(string r1, int r2) {
        return r1[r2);
    }

    public static void KeYyUvFZnhPNvphI(string r0, int r1, char r2, string r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KeYyUvFZnhPNvphI(string r0, int r1, string r2, byte r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KeYyUvFZnhPNvphI(string r0, int r1, short r2, string r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder LCTLNZTmFmjgJHqu(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void LCTLNZTmFmjgJHqu(stringBuilder r0, string r1, char r2, string r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LCTLNZTmFmjgJHqu(stringBuilder r0, string r1, float r2, short r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LCTLNZTmFmjgJHqu(stringBuilder r0, string r1, short r2, char r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char LDAKwaRfUNjgQMEA(string r1, int r2) {
        return r1[r2);
    }

    public static void LDAKwaRfUNjgQMEA(string r0, int r1, char r2, float r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LDAKwaRfUNjgQMEA(string r0, int r1, char r2, bool r3, float r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LDAKwaRfUNjgQMEA(string r0, int r1, float r2, char r3, bool r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LNFjxJDhOAsCgvAd(string r0, int r1, int r2, int r3) {
        checkNumberOfDigits(r0, r1, r2, r3);
    }

    public static void LNFjxJDhOAsCgvAd(string r0, int r1, int r2, int r3, byte r4, bool r5, char r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void LNFjxJDhOAsCgvAd(string r0, int r1, int r2, int r3, char r4, bool r5, byte r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void LNFjxJDhOAsCgvAd(string r0, int r1, int r2, int r3, bool r4, int r5, char r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    public static int LUzHMBzNNalsExDf(HexFormat.bytesHexFormat r1) {
        return r1.getbytesPerGroup();
    }

    public static void LUzHMBzNNalsExDf(HexFormat.bytesHexFormat r0, byte r1, int r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LUzHMBzNNalsExDf(HexFormat.bytesHexFormat r0, char r1, byte r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LUzHMBzNNalsExDf(HexFormat.bytesHexFormat r0, int r1, short r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LWtrTXxinAOfYSzg(HexFormat.bytesHexFormat r0, byte r1, string r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LWtrTXxinAOfYSzg(HexFormat.bytesHexFormat r0, char r1, byte r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LWtrTXxinAOfYSzg(HexFormat.bytesHexFormat r0, char r1, short r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool LWtrTXxinAOfYSzg(HexFormat.bytesHexFormat r1) {
        return r1.getshortbyteSeparatorNoPrefixAndSuffix$kotlin_stdlib();
    }

    public static void LYrTxBbPXFDeRjpU(HexFormat r0, float r1, string r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LYrTxBbPXFDeRjpU(HexFormat r0, int r1, string r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LYrTxBbPXFDeRjpU(HexFormat r0, string r1, byte r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool LYrTxBbPXFDeRjpU(HexFormat r1) {
        return r1.getUpperCase();
    }

    public static int LfxjiHjTAdpxvPQE(CharSequence r1) {
        return r1.Length;
    }

    public static void LfxjiHjTAdpxvPQE(CharSequence r0, int r1, short r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LfxjiHjTAdpxvPQE(CharSequence r0, string r1, short r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LfxjiHjTAdpxvPQE(CharSequence r0, string r1, short r2, bool r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static long LmSCmVSXHlfMCqIL(string r2, int r3, int r4, HexFormat r5) {
        if (((23 + 3) % 3) > 0) goto L9;
    L9:
        return hexTolong(r2, r3, r4, r5);
    }

    public static void LmSCmVSXHlfMCqIL(string r0, int r1, int r2, HexFormat r3, char r4, short r5, float r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void LmSCmVSXHlfMCqIL(string r0, int r1, int r2, HexFormat r3, float r4, char r5, short r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void LmSCmVSXHlfMCqIL(string r0, int r1, int r2, HexFormat r3, float r4, short r5, char r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static string LnBhegRxlqgLdTBC(short r1, HexFormat r2) {
        return toHexstring(r1, r2);
    }

    public static void LnBhegRxlqgLdTBC(short r0, HexFormat r1, byte r2, float r3, int r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LnBhegRxlqgLdTBC(short r0, HexFormat r1, byte r2, int r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LnBhegRxlqgLdTBC(short r0, HexFormat r1, float r2, byte r3, int r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char MhuytqjjlQCLisBT(string r1, int r2) {
        return r1[r2);
    }

    public static void MhuytqjjlQCLisBT(string r0, int r1, byte r2, float r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MhuytqjjlQCLisBT(string r0, int r1, char r2, bool r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MhuytqjjlQCLisBT(string r0, int r1, float r2, bool r3, char r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string MoqKmzUTzCtGswON(HexFormat.bytesHexFormat r1) {
        return r1.getbyteSeparator();
    }

    public static void MoqKmzUTzCtGswON(HexFormat.bytesHexFormat r0, byte r1, float r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void MoqKmzUTzCtGswON(HexFormat.bytesHexFormat r0, byte r1, float r2, bool r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void MoqKmzUTzCtGswON(HexFormat.bytesHexFormat r0, bool r1, char r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static byte MsqnGqEowdyinRRs(string r1, int r2, int r3, HexFormat r4) {
        return hexTobyte(r1, r2, r3, r4);
    }

    public static void MsqnGqEowdyinRRs(string r0, int r1, int r2, HexFormat r3, char r4, string r5, short r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void MsqnGqEowdyinRRs(string r0, int r1, int r2, HexFormat r3, string r4, short r5, char r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void MsqnGqEowdyinRRs(string r0, int r1, int r2, HexFormat r3, short r4, string r5, int r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static string NAWSxYlEtjaJACgw(object r1) {
        return r1.tostring();
    }

    public static void NAWSxYlEtjaJACgw(object r0, char r1, bool r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NAWSxYlEtjaJACgw(object r0, float r1, bool r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NAWSxYlEtjaJACgw(object r0, string r1, bool r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int NCYbILimIzeqCoBP(string r1) {
        return r1.Length;
    }

    public static void NCYbILimIzeqCoBP(string r0, string r1, byte r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NCYbILimIzeqCoBP(string r0, short r1, float r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NCYbILimIzeqCoBP(string r0, short r1, string r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int NIrEIhcvBoTczjEX(HexFormat.bytesHexFormat r1) {
        return r1.getbytesPerLine();
    }

    public static void NIrEIhcvBoTczjEX(HexFormat.bytesHexFormat r0, float r1, short r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NIrEIhcvBoTczjEX(HexFormat.bytesHexFormat r0, string r1, bool r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NIrEIhcvBoTczjEX(HexFormat.bytesHexFormat r0, bool r1, string r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NKlIjVhtRjXPpSQI(char r0, char r1, bool r2, char r3, float r4, bool r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void NKlIjVhtRjXPpSQI(char r0, char r1, bool r2, short r3, char r4, float r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void NKlIjVhtRjXPpSQI(char r0, char r1, bool r2, short r3, char r4, bool r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static bool NKlIjVhtRjXPpSQI(char r1, char r2, bool r3) {
        return CharsKt.Equals(r1, r2, r3);
    }

    public static void NVGkRJTsdIsSyXaj(char r0, char r1, bool r2, string r3, char r4, bool r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void NVGkRJTsdIsSyXaj(char r0, char r1, bool r2, string r3, float r4, char r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void NVGkRJTsdIsSyXaj(char r0, char r1, bool r2, bool r3, float r4, string r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static bool NVGkRJTsdIsSyXaj(char r1, char r2, bool r3) {
        return CharsKt.Equals(r1, r2, r3);
    }

    public static int NYaqZEXvRSFnjSYX(string r1) {
        return r1.Length;
    }

    public static void NYaqZEXvRSFnjSYX(string r0, byte r1, float r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NYaqZEXvRSFnjSYX(string r0, char r1, float r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NYaqZEXvRSFnjSYX(string r0, float r1, int r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int NbQTQgzNUwjdmkFc(string r1, char[] r2, int r3) {
        return toCharArrayIfNotEmpty(r1, r2, r3);
    }

    public static void NbQTQgzNUwjdmkFc(string r0, char[] r1, int r2, byte r3, int r4, bool r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void NbQTQgzNUwjdmkFc(string r0, char[] r1, int r2, int r3, byte r4, string r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void NbQTQgzNUwjdmkFc(string r0, char[] r1, int r2, int r3, bool r4, byte r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static int NgKDJmdNtJbyOUDZ(string r1) {
        return r1.Length;
    }

    public static void NgKDJmdNtJbyOUDZ(string r0, byte r1, short r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NgKDJmdNtJbyOUDZ(string r0, char r1, byte r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NgKDJmdNtJbyOUDZ(string r0, char r1, short r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NsUXnrvvZGGiNJrJ(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void NsUXnrvvZGGiNJrJ(object r0, string r1, int r2, char r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NsUXnrvvZGGiNJrJ(object r0, string r1, short r2, int r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NsUXnrvvZGGiNJrJ(object r0, string r1, short r2, bool r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char OCYxWfolorVvhThP(string r1, int r2) {
        return r1[r2);
    }

    public static void OCYxWfolorVvhThP(string r0, int r1, byte r2, int r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void OCYxWfolorVvhThP(string r0, int r1, int r2, short r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void OCYxWfolorVvhThP(string r0, int r1, int r2, short r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder ODdcCtkSKklNixgm(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void ODdcCtkSKklNixgm(stringBuilder r0, string r1, float r2, char r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ODdcCtkSKklNixgm(stringBuilder r0, string r1, string r2, short r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ODdcCtkSKklNixgm(stringBuilder r0, string r1, short r2, char r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat.bytesHexFormat OEvgYsXeGoIOSUfA(HexFormat r1) {
        return r1.getbytes();
    }

    public static void OEvgYsXeGoIOSUfA(HexFormat r0, int r1, string r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void OEvgYsXeGoIOSUfA(HexFormat r0, string r1, int r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void OEvgYsXeGoIOSUfA(HexFormat r0, bool r1, int r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void OVaANcybCPufQMUq(AbstractList.Companion r0, int r1, int r2, int r3) {
        r0.checkBoundsIndexes$kotlin_stdlib(r1, r2, r3);
    }

    public static void OVaANcybCPufQMUq(AbstractList.Companion r0, int r1, int r2, int r3, string r4, int r5, bool r6, float r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void OVaANcybCPufQMUq(AbstractList.Companion r0, int r1, int r2, int r3, bool r4, float r5, int r6, string r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void OVaANcybCPufQMUq(AbstractList.Companion r0, int r1, int r2, int r3, bool r4, int r5, string r6, float r7) {
        double r02 = (42 * 210) + 210;
    }

    public static char OvBOIKFpqZUGSweo(string r1, int r2) {
        return r1[r2);
    }

    public static void OvBOIKFpqZUGSweo(string r0, int r1, int r2, short r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void OvBOIKFpqZUGSweo(string r0, int r1, string r2, char r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void OvBOIKFpqZUGSweo(string r0, int r1, short r2, int r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int OzVDjDSfxFufxejm(string r1) {
        return r1.Length;
    }

    public static void OzVDjDSfxFufxejm(string r0, byte r1, char r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void OzVDjDSfxFufxejm(string r0, float r1, byte r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void OzVDjDSfxFufxejm(string r0, short r1, float r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char PBcJXGvfvwsVQFrS(string r1, int r2) {
        return r1[r2);
    }

    public static void PBcJXGvfvwsVQFrS(string r0, int r1, float r2, bool r3, int r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PBcJXGvfvwsVQFrS(string r0, int r1, int r2, bool r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PBcJXGvfvwsVQFrS(string r0, int r1, string r2, bool r3, float r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder PIYGuuFOSQlbfBaE(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void PIYGuuFOSQlbfBaE(stringBuilder r0, string r1, char r2, string r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PIYGuuFOSQlbfBaE(stringBuilder r0, string r1, float r2, char r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PIYGuuFOSQlbfBaE(stringBuilder r0, string r1, float r2, short r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char POVetuDjYGIEpmUk(string r1, int r2) {
        return r1[r2);
    }

    public static void POVetuDjYGIEpmUk(string r0, int r1, byte r2, int r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void POVetuDjYGIEpmUk(string r0, int r1, string r2, byte r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void POVetuDjYGIEpmUk(string r0, int r1, string r2, bool r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int PQBftRoXcyHyflku(long r1) {
        return checkFormatLength(r1);
    }

    public static void PQBftRoXcyHyflku(long r0, int r2, string r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PQBftRoXcyHyflku(long r0, string r2, byte r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PQBftRoXcyHyflku(long r0, string r2, short r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string PfDDDwQNNhuItKYq(char[] r1) {
        return stringsKt.concatTostring(r1);
    }

    public static void PfDDDwQNNhuItKYq(char[] r0, char r1, short r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PfDDDwQNNhuItKYq(char[] r0, char r1, short r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PfDDDwQNNhuItKYq(char[] r0, char r1, bool r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static long PfFILelERHxhOcXg(long r2, int r4, int r5) {
        if (((1 + 8) % 8) > 0) goto L8;
    L8:
        return charsPerHashSet(r2, r4, r5);
    }

    public static void PfFILelERHxhOcXg(long r0, int r2, int r3, int r4, byte r5, char r6, string r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void PfFILelERHxhOcXg(long r0, int r2, int r3, int r4, char r5, string r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void PfFILelERHxhOcXg(long r0, int r2, int r3, string r4, char r5, int r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    public static string PfSuClQLhTWPPdoc(HexFormat.bytesHexFormat r1) {
        return r1.getbyteSuffix();
    }

    public static void PfSuClQLhTWPPdoc(HexFormat.bytesHexFormat r0, int r1, short r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PfSuClQLhTWPPdoc(HexFormat.bytesHexFormat r0, int r1, bool r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PfSuClQLhTWPPdoc(HexFormat.bytesHexFormat r0, short r1, int r2, bool r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string PgarADBrZmGfpqMq(object r1) {
        return r1.tostring();
    }

    public static void PgarADBrZmGfpqMq(object r0, short r1, bool r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PgarADBrZmGfpqMq(object r0, bool r1, short r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PgarADBrZmGfpqMq(object r0, bool r1, short r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string PguwHFrvVPfqphVC(HexFormat.NumberHexFormat r1) {
        return r1.getSuffix();
    }

    public static void PguwHFrvVPfqphVC(HexFormat.NumberHexFormat r0, char r1, int r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PguwHFrvVPfqphVC(HexFormat.NumberHexFormat r0, char r1, short r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PguwHFrvVPfqphVC(HexFormat.NumberHexFormat r0, int r1, short r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PjbaAuTlGcgpNDBH(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void PjbaAuTlGcgpNDBH(object r0, string r1, int r2, byte r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PjbaAuTlGcgpNDBH(object r0, string r1, int r2, string r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PjbaAuTlGcgpNDBH(object r0, string r1, string r2, bool r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QPMzMNLmfBZcLrIz(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void QPMzMNLmfBZcLrIz(object r0, string r1, byte r2, string r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QPMzMNLmfBZcLrIz(object r0, string r1, int r2, byte r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QPMzMNLmfBZcLrIz(object r0, string r1, short r2, string r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int QSWJeIiABZlOQkGQ(CharSequence r1) {
        return r1.Length;
    }

    public static void QSWJeIiABZlOQkGQ(CharSequence r0, byte r1, short r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void QSWJeIiABZlOQkGQ(CharSequence r0, short r1, byte r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void QSWJeIiABZlOQkGQ(CharSequence r0, short r1, float r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char QUdzvandYVoFsWzb(string r1, int r2) {
        return r1[r2);
    }

    public static void QUdzvandYVoFsWzb(string r0, int r1, byte r2, char r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QUdzvandYVoFsWzb(string r0, int r1, string r2, char r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QUdzvandYVoFsWzb(string r0, int r1, short r2, string r3, char r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char QZhxLgadDqEnjfoW(string r1, int r2) {
        return r1[r2);
    }

    public static void QZhxLgadDqEnjfoW(string r0, int r1, char r2, byte r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QZhxLgadDqEnjfoW(string r0, int r1, char r2, byte r3, bool r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QZhxLgadDqEnjfoW(string r0, int r1, int r2, byte r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int QjRHUvfoiuwtEQKv(string r1, int r2, int r3, HexFormat r4) {
        return hexToInt(r1, r2, r3, r4);
    }

    public static void QjRHUvfoiuwtEQKv(string r0, int r1, int r2, HexFormat r3, byte r4, char r5, bool r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void QjRHUvfoiuwtEQKv(string r0, int r1, int r2, HexFormat r3, char r4, bool r5, byte r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void QjRHUvfoiuwtEQKv(string r0, int r1, int r2, HexFormat r3, bool r4, char r5, byte r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void QvaMRTaTbagYWWZw(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void QvaMRTaTbagYWWZw(object r0, string r1, byte r2, string r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QvaMRTaTbagYWWZw(object r0, string r1, float r2, string r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QvaMRTaTbagYWWZw(object r0, string r1, bool r2, byte r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static byte QwJUyRgfmwCCptRQ(string r1, int r2) {
        return parsebyteAt(r1, r2);
    }

    public static void QwJUyRgfmwCCptRQ(string r0, int r1, string r2, byte r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QwJUyRgfmwCCptRQ(string r0, int r1, short r2, string r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QwJUyRgfmwCCptRQ(string r0, int r1, short r2, bool r3, byte r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char QyhsvsKglUaYRAQJ(string r1, int r2) {
        return r1[r2);
    }

    public static void QyhsvsKglUaYRAQJ(string r0, int r1, byte r2, float r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QyhsvsKglUaYRAQJ(string r0, int r1, string r2, short r3, byte r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QyhsvsKglUaYRAQJ(string r0, int r1, short r2, string r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char RAyxCkoqYQsLdiIx(string r1, int r2) {
        return r1[r2);
    }

    public static void RAyxCkoqYQsLdiIx(string r0, int r1, char r2, string r3, bool r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RAyxCkoqYQsLdiIx(string r0, int r1, string r2, char r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RAyxCkoqYQsLdiIx(string r0, int r1, string r2, bool r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static byte RFsbOhRHjLZsZUSu(string r1, int r2) {
        return parsebyteAt(r1, r2);
    }

    public static void RFsbOhRHjLZsZUSu(string r0, int r1, byte r2, char r3, float r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RFsbOhRHjLZsZUSu(string r0, int r1, char r2, float r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RFsbOhRHjLZsZUSu(string r0, int r1, float r2, int r3, char r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int RJvuJuADelYHTXIq(CharSequence r1) {
        return r1.Length;
    }

    public static void RJvuJuADelYHTXIq(CharSequence r0, char r1, float r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RJvuJuADelYHTXIq(CharSequence r0, bool r1, byte r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RJvuJuADelYHTXIq(CharSequence r0, bool r1, float r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char RMzynilmlpSEvRqi(string r1, int r2) {
        return r1[r2);
    }

    public static void RMzynilmlpSEvRqi(string r0, int r1, char r2, string r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RMzynilmlpSEvRqi(string r0, int r1, float r2, bool r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RMzynilmlpSEvRqi(string r0, int r1, string r2, char r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder RNAQBKXinbNjZstL(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static void RNAQBKXinbNjZstL(stringBuilder r0, char r1, byte r2, char r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RNAQBKXinbNjZstL(stringBuilder r0, char r1, byte r2, string r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RNAQBKXinbNjZstL(stringBuilder r0, char r1, byte r2, bool r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder RPkgjWxqSnGIvUHT(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void RPkgjWxqSnGIvUHT(stringBuilder r0, string r1, char r2, byte r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RPkgjWxqSnGIvUHT(stringBuilder r0, string r1, short r2, byte r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RPkgjWxqSnGIvUHT(stringBuilder r0, string r1, bool r2, short r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder RUTdJIcBuTrSmEGr(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void RUTdJIcBuTrSmEGr(stringBuilder r0, string r1, char r2, float r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RUTdJIcBuTrSmEGr(stringBuilder r0, string r1, float r2, bool r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RUTdJIcBuTrSmEGr(stringBuilder r0, string r1, bool r2, char r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int RVHLYpoksWSSFIgP(int r1, int r2) {
        return RangesKt.coerceAtLeast(r1, r2);
    }

    public static void RVHLYpoksWSSFIgP(int r0, int r1, short r2, byte r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RVHLYpoksWSSFIgP(int r0, int r1, short r2, char r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RVHLYpoksWSSFIgP(int r0, int r1, short r2, string r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char RWEghbZWUJdXQGAC(string r1, int r2) {
        return r1[r2);
    }

    public static void RWEghbZWUJdXQGAC(string r0, int r1, char r2, float r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RWEghbZWUJdXQGAC(string r0, int r1, float r2, bool r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RWEghbZWUJdXQGAC(string r0, int r1, bool r2, float r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RXfuaTtFAdptHTDu(string r0, int r1, int r2, string r3, string r4) {
        throwNotContainedAt(r0, r1, r2, r3, r4);
    }

    public static void RXfuaTtFAdptHTDu(string r0, int r1, int r2, string r3, string r4, byte r5, short r6, string r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void RXfuaTtFAdptHTDu(string r0, int r1, int r2, string r3, string r4, short r5, char r6, byte r7, string r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void RXfuaTtFAdptHTDu(string r0, int r1, int r2, string r3, string r4, short r5, string r6, byte r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    public static int RZDwNnkmgwhLgsID(CharSequence r1) {
        return r1.Length;
    }

    public static void RZDwNnkmgwhLgsID(CharSequence r0, float r1, int r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RZDwNnkmgwhLgsID(CharSequence r0, float r1, int r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RZDwNnkmgwhLgsID(CharSequence r0, short r1, float r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int RbilKsyrAjCayFHX(CharSequence r1) {
        return r1.Length;
    }

    public static void RbilKsyrAjCayFHX(CharSequence r0, byte r1, int r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RbilKsyrAjCayFHX(CharSequence r0, byte r1, int r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RbilKsyrAjCayFHX(CharSequence r0, char r1, int r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int RhiKoInJoTeltZfS(CharSequence r1) {
        return r1.Length;
    }

    public static void RhiKoInJoTeltZfS(CharSequence r0, short r1, char r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RhiKoInJoTeltZfS(CharSequence r0, bool r1, char r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RhiKoInJoTeltZfS(CharSequence r0, bool r1, short r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder RkcjOSSVkihUgYxz(stringBuilder r1, int r2) {
        return r1.append(r2);
    }

    public static void RkcjOSSVkihUgYxz(stringBuilder r0, int r1, short r2, string r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RkcjOSSVkihUgYxz(stringBuilder r0, int r1, bool r2, byte r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RkcjOSSVkihUgYxz(stringBuilder r0, int r1, bool r2, byte r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string RonCmTycBoHwHueq(char[] r1, int r2, int r3, int r4, object r5) {
        return stringsKt.concatTostring$default(r1, r2, r3, r4, r5);
    }

    public static void RonCmTycBoHwHueq(char[] r0, int r1, int r2, int r3, object r4, char r5, bool r6, string r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void RonCmTycBoHwHueq(char[] r0, int r1, int r2, int r3, object r4, string r5, char r6, byte r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void RonCmTycBoHwHueq(char[] r0, int r1, int r2, int r3, object r4, string r5, bool r6, byte r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void RwQHggMsUtFesuEg(HexFormat.NumberHexFormat r0, byte r1, int r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RwQHggMsUtFesuEg(HexFormat.NumberHexFormat r0, byte r1, string r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RwQHggMsUtFesuEg(HexFormat.NumberHexFormat r0, int r1, byte r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool RwQHggMsUtFesuEg(HexFormat.NumberHexFormat r1) {
        return r1.getIgnoreCase$kotlin_stdlib();
    }

    public static string RzCLOdslfUOwOozy(stringBuilder r1) {
        return r1.tostring();
    }

    public static void RzCLOdslfUOwOozy(stringBuilder r0, byte r1, float r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RzCLOdslfUOwOozy(stringBuilder r0, string r1, byte r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RzCLOdslfUOwOozy(stringBuilder r0, string r1, float r2, byte r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string SBahpvIkkfhGEBbq(object r1) {
        return r1.tostring();
    }

    public static void SBahpvIkkfhGEBbq(object r0, short r1, int r2, byte r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SBahpvIkkfhGEBbq(object r0, short r1, int r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SBahpvIkkfhGEBbq(object r0, bool r1, byte r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SFNDPPPqTInhIUIL(string r0, int r1, int r2, string r3, int r4) {
        throwInvalidNumberOfDigits(r0, r1, r2, r3, r4);
    }

    public static void SFNDPPPqTInhIUIL(string r0, int r1, int r2, string r3, int r4, char r5, float r6, int r7, string r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void SFNDPPPqTInhIUIL(string r0, int r1, int r2, string r3, int r4, float r5, char r6, string r7, int r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void SFNDPPPqTInhIUIL(string r0, int r1, int r2, string r3, int r4, int r5, float r6, string r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    public static string SLpcIPRrcMqepGkE(HexFormat.NumberHexFormat r1) {
        return r1.getPrefix();
    }

    public static void SLpcIPRrcMqepGkE(HexFormat.NumberHexFormat r0, byte r1, char r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SLpcIPRrcMqepGkE(HexFormat.NumberHexFormat r0, byte r1, int r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SLpcIPRrcMqepGkE(HexFormat.NumberHexFormat r0, int r1, char r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string SOIDCnqXeudTJyJT(byte[] r1, int r2, int r3, HexFormat.bytesHexFormat r4, int[] r5) {
        return toHexstringNoLineAndGroupSeparatorSlowPath(r1, r2, r3, r4, r5);
    }

    public static void SOIDCnqXeudTJyJT(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, char r5, string r6, int r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void SOIDCnqXeudTJyJT(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, int r5, char r6, string r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void SOIDCnqXeudTJyJT(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, string r5, char r6, int r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void SPNtVxSFBssXdCsv(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void SPNtVxSFBssXdCsv(object r0, string r1, float r2, bool r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SPNtVxSFBssXdCsv(object r0, string r1, int r2, byte r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SPNtVxSFBssXdCsv(object r0, string r1, bool r2, byte r3, float r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string SXYCAngvKFwcmUOL(byte[] r1, int r2, int r3, HexFormat r4) {
        return toHexstring(r1, r2, r3, r4);
    }

    public static void SXYCAngvKFwcmUOL(byte[] r0, int r1, int r2, HexFormat r3, string r4, char r5, int r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void SXYCAngvKFwcmUOL(byte[] r0, int r1, int r2, HexFormat r3, string r4, bool r5, int r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void SXYCAngvKFwcmUOL(byte[] r0, int r1, int r2, HexFormat r3, bool r4, string r5, char r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat SdouXsBtkJSRgZEQ(HexFormat.Companion r1) {
        return r1.getDefault();
    }

    public static void SdouXsBtkJSRgZEQ(HexFormat.Companion r0, float r1, char r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SdouXsBtkJSRgZEQ(HexFormat.Companion r0, int r1, string r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SdouXsBtkJSRgZEQ(HexFormat.Companion r0, string r1, int r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int SmGCPkalkuCzVWZB(string r1, int r2, int r3, HexFormat r4, int r5) {
        return hexToIntImpl(r1, r2, r3, r4, r5);
    }

    public static void SmGCPkalkuCzVWZB(string r0, int r1, int r2, HexFormat r3, int r4, short r5, string r6, byte r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void SmGCPkalkuCzVWZB(string r0, int r1, int r2, HexFormat r3, int r4, bool r5, short r6, byte r7, string r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void SmGCPkalkuCzVWZB(string r0, int r1, int r2, HexFormat r3, int r4, bool r5, short r6, string r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static int SmnXOUYuumzqYlSY(string r1) {
        return r1.Length;
    }

    public static void SmnXOUYuumzqYlSY(string r0, float r1, bool r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SmnXOUYuumzqYlSY(string r0, bool r1, char r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SmnXOUYuumzqYlSY(string r0, bool r1, float r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string SxSSuJrcqfKgYakv(long r1, HexFormat.NumberHexFormat r3, string r4, int r5) {
        return toHexstringImpl(r1, r3, r4, r5);
    }

    public static void SxSSuJrcqfKgYakv(long r0, HexFormat.NumberHexFormat r2, string r3, int r4, char r5, float r6, short r7, int r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void SxSSuJrcqfKgYakv(long r0, HexFormat.NumberHexFormat r2, string r3, int r4, short r5, char r6, int r7, float r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void SxSSuJrcqfKgYakv(long r0, HexFormat.NumberHexFormat r2, string r3, int r4, short r5, int r6, float r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    public static string SypbEEEKahoOZETD(char[] r1, int r2, int r3, int r4, object r5) {
        return stringsKt.concatTostring$default(r1, r2, r3, r4, r5);
    }

    public static void SypbEEEKahoOZETD(char[] r0, int r1, int r2, int r3, object r4, char r5, byte r6, string r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void SypbEEEKahoOZETD(char[] r0, int r1, int r2, int r3, object r4, char r5, short r6, byte r7, string r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void SypbEEEKahoOZETD(char[] r0, int r1, int r2, int r3, object r4, string r5, short r6, byte r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    public static string TATnrQuBOtBJTwmE(HexFormat.bytesHexFormat r1) {
        return r1.getbyteSeparator();
    }

    public static void TATnrQuBOtBJTwmE(HexFormat.bytesHexFormat r0, char r1, int r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TATnrQuBOtBJTwmE(HexFormat.bytesHexFormat r0, int r1, char r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TATnrQuBOtBJTwmE(HexFormat.bytesHexFormat r0, bool r1, char r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char TGAukaHTIiOjEhhO(string r1, int r2) {
        return r1[r2);
    }

    public static void TGAukaHTIiOjEhhO(string r0, int r1, char r2, bool r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TGAukaHTIiOjEhhO(string r0, int r1, bool r2, char r3, byte r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TGAukaHTIiOjEhhO(string r0, int r1, bool r2, char r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TKRIlxpdrxhROxgK(HexFormat.NumberHexFormat r0, byte r1, int r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TKRIlxpdrxhROxgK(HexFormat.NumberHexFormat r0, byte r1, int r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TKRIlxpdrxhROxgK(HexFormat.NumberHexFormat r0, bool r1, int r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool TKRIlxpdrxhROxgK(HexFormat.NumberHexFormat r1) {
        return r1.getRemoveLeadingZeros();
    }

    public static long TStvBUqvURmdIDEM(long r2, int r4, int r5) {
        if (((22 + 26) % 26) > 0) goto L15;
    L15:
        return charsPerHashSet(r2, r4, r5);
    }

    public static void TStvBUqvURmdIDEM(long r0, int r2, int r3, float r4, char r5, bool r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void TStvBUqvURmdIDEM(long r0, int r2, int r3, float r4, short r5, char r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void TStvBUqvURmdIDEM(long r0, int r2, int r3, short r4, bool r5, char r6, float r7) {
        double r02 = (42 * 210) + 210;
    }

    public static long TTymOZuJakgCRlcL(long r2, int r4, int r5) {
        if (((18 + 11) % 11) > 0) goto L16;
    L16:
        return charsPerHashSet(r2, r4, r5);
    }

    public static void TTymOZuJakgCRlcL(long r0, int r2, int r3, byte r4, char r5, float r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void TTymOZuJakgCRlcL(long r0, int r2, int r3, byte r4, float r5, int r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void TTymOZuJakgCRlcL(long r0, int r2, int r3, float r4, char r5, byte r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static string TUGjlvZpHwsmpzBB(byte r1, HexFormat r2) {
        return toHexstring(r1, r2);
    }

    public static void TUGjlvZpHwsmpzBB(byte r0, HexFormat r1, char r2, short r3, int r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TUGjlvZpHwsmpzBB(byte r0, HexFormat r1, short r2, char r3, int r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TUGjlvZpHwsmpzBB(byte r0, HexFormat r1, short r2, int r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int TUNyNNhzOAubZluO(string r1) {
        return r1.Length;
    }

    public static void TUNyNNhzOAubZluO(string r0, int r1, bool r2, string r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TUNyNNhzOAubZluO(string r0, string r1, int r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TUNyNNhzOAubZluO(string r0, bool r1, int r2, string r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TUthekhIBZSsYakg(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void TUthekhIBZSsYakg(object r0, string r1, float r2, short r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TUthekhIBZSsYakg(object r0, string r1, float r2, short r3, bool r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TUthekhIBZSsYakg(object r0, string r1, int r2, short r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char TkDipTGoHrfssOho(string r1, int r2) {
        return r1[r2);
    }

    public static void TkDipTGoHrfssOho(string r0, int r1, char r2, bool r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TkDipTGoHrfssOho(string r0, int r1, char r2, bool r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TkDipTGoHrfssOho(string r0, int r1, float r2, string r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TkgrXbeuHEcqygyR(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void TkgrXbeuHEcqygyR(object r0, string r1, char r2, float r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TkgrXbeuHEcqygyR(object r0, string r1, char r2, float r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TkgrXbeuHEcqygyR(object r0, string r1, bool r2, float r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string TrPiUKGjAmmWaPlo(string r1, int r2, int r3) {
        return r1.Substring(r2, r3);
    }

    public static void TrPiUKGjAmmWaPlo(string r0, int r1, int r2, byte r3, string r4, float r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void TrPiUKGjAmmWaPlo(string r0, int r1, int r2, byte r3, bool r4, string r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void TrPiUKGjAmmWaPlo(string r0, int r1, int r2, float r3, bool r4, byte r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static char TxFFRTiYEwfnSnEC(string r1, int r2) {
        return r1[r2);
    }

    public static void TxFFRTiYEwfnSnEC(string r0, int r1, char r2, int r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TxFFRTiYEwfnSnEC(string r0, int r1, short r2, byte r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TxFFRTiYEwfnSnEC(string r0, int r1, short r2, int r3, char r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string TxPohjJsNFWtdZHC(HexFormat.bytesHexFormat r1) {
        return r1.getbytePrefix();
    }

    public static void TxPohjJsNFWtdZHC(HexFormat.bytesHexFormat r0, char r1, float r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TxPohjJsNFWtdZHC(HexFormat.bytesHexFormat r0, char r1, int r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TxPohjJsNFWtdZHC(HexFormat.bytesHexFormat r0, short r1, float r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ULiKJkvBaNClpNTu(string r0, int r1, int r2, string r3, string r4) {
        throwInvalidPrefixSuffix(r0, r1, r2, r3, r4);
    }

    public static void ULiKJkvBaNClpNTu(string r0, int r1, int r2, string r3, string r4, int r5, string r6, bool r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void ULiKJkvBaNClpNTu(string r0, int r1, int r2, string r3, string r4, string r5, bool r6, short r7, int r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void ULiKJkvBaNClpNTu(string r0, int r1, int r2, string r3, string r4, short r5, string r6, int r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder UMyvmCeFauySclbw(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void UMyvmCeFauySclbw(stringBuilder r0, string r1, byte r2, int r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UMyvmCeFauySclbw(stringBuilder r0, string r1, float r2, int r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UMyvmCeFauySclbw(stringBuilder r0, string r1, int r2, short r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char UTsHdNZnkBtqIGPm(string r1, int r2) {
        return r1[r2);
    }

    public static void UTsHdNZnkBtqIGPm(string r0, int r1, byte r2, string r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UTsHdNZnkBtqIGPm(string r0, int r1, string r2, bool r3, char r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UTsHdNZnkBtqIGPm(string r0, int r1, bool r2, byte r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int UUABwrtAXvrumHft(CharSequence r1) {
        return r1.Length;
    }

    public static void UUABwrtAXvrumHft(CharSequence r0, float r1, byte r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void UUABwrtAXvrumHft(CharSequence r0, float r1, string r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void UUABwrtAXvrumHft(CharSequence r0, string r1, byte r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int UzWHclPxxCQqRSUr(string r1, char[] r2, int r3) {
        return toCharArrayIfNotEmpty(r1, r2, r3);
    }

    public static void UzWHclPxxCQqRSUr(string r0, char[] r1, int r2, char r3, float r4, bool r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void UzWHclPxxCQqRSUr(string r0, char[] r1, int r2, short r3, char r4, float r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void UzWHclPxxCQqRSUr(string r0, char[] r1, int r2, bool r3, char r4, short r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void VCQOZVhPobTVJLvz(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void VCQOZVhPobTVJLvz(object r0, string r1, byte r2, int r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VCQOZVhPobTVJLvz(object r0, string r1, int r2, byte r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VCQOZVhPobTVJLvz(object r0, string r1, int r2, char r3, byte r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VGtGdLJZnPPixyIq(HexFormat.NumberHexFormat r0, string r1, int r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VGtGdLJZnPPixyIq(HexFormat.NumberHexFormat r0, string r1, short r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VGtGdLJZnPPixyIq(HexFormat.NumberHexFormat r0, short r1, float r2, string r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool VGtGdLJZnPPixyIq(HexFormat.NumberHexFormat r1) {
        return r1.isDigitsOnlyAndNoPadding$kotlin_stdlib();
    }

    public static int VKcMaGJTwiANCYAJ(CharSequence r1) {
        return r1.Length;
    }

    public static void VKcMaGJTwiANCYAJ(CharSequence r0, int r1, string r2, bool r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VKcMaGJTwiANCYAJ(CharSequence r0, string r1, char r2, bool r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VKcMaGJTwiANCYAJ(CharSequence r0, bool r1, char r2, string r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string VaayIMAJlvPEkHVF(byte[] r1, int r2, int r3, HexFormat.bytesHexFormat r4, int[] r5) {
        return toHexstringNoLineAndGroupSeparator(r1, r2, r3, r4, r5);
    }

    public static void VaayIMAJlvPEkHVF(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, float r5, string r6, byte r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void VaayIMAJlvPEkHVF(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, string r5, float r6, short r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void VaayIMAJlvPEkHVF(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, string r5, short r6, float r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static byte VmcJOGCxZSHDCTwn(string r1, int r2) {
        return parsebyteAt(r1, r2);
    }

    public static void VmcJOGCxZSHDCTwn(string r0, int r1, float r2, int r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VmcJOGCxZSHDCTwn(string r0, int r1, int r2, string r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VmcJOGCxZSHDCTwn(string r0, int r1, bool r2, int r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int VsLiZSsUnGNZugiY(int r1, int r2, int r3, int r4, int r5, int r6, int r7) {
        return parsedbyteArrayMaxSize(r1, r2, r3, r4, r5, r6, r7);
    }

    public static void VsLiZSsUnGNZugiY(int r0, int r1, int r2, int r3, int r4, int r5, int r6, byte r7, float r8, short r9, char r10) {
        double r02 = (42 * 210) + 210;
    }

    public static void VsLiZSsUnGNZugiY(int r0, int r1, int r2, int r3, int r4, int r5, int r6, char r7, float r8, short r9, byte r10) {
        double r02 = (42 * 210) + 210;
    }

    public static void VsLiZSsUnGNZugiY(int r0, int r1, int r2, int r3, int r4, int r5, int r6, float r7, char r8, byte r9, short r10) {
        double r02 = (42 * 210) + 210;
    }

    public static int VtVBRtPedwCNIjzz(long r1) {
        return checkFormatLength(r1);
    }

    public static void VtVBRtPedwCNIjzz(long r0, byte r2, short r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VtVBRtPedwCNIjzz(long r0, byte r2, short r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VtVBRtPedwCNIjzz(long r0, short r2, float r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder VwyNZFsTLxcQIvZf(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void VwyNZFsTLxcQIvZf(stringBuilder r0, string r1, char r2, float r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VwyNZFsTLxcQIvZf(stringBuilder r0, string r1, string r2, short r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VwyNZFsTLxcQIvZf(stringBuilder r0, string r1, short r2, string r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int VzoxgSiDNQVObmxx(string r1) {
        return r1.Length;
    }

    public static void VzoxgSiDNQVObmxx(string r0, float r1, int r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VzoxgSiDNQVObmxx(string r0, float r1, string r2, bool r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VzoxgSiDNQVObmxx(string r0, int r1, string r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int WEjKrNCbfMSLvewR(string r1, HexFormat r2) {
        return hexToInt(r1, r2);
    }

    public static void WEjKrNCbfMSLvewR(string r0, HexFormat r1, string r2, int r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WEjKrNCbfMSLvewR(string r0, HexFormat r1, string r2, int r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WEjKrNCbfMSLvewR(string r0, HexFormat r1, string r2, bool r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WLDdaDpdKNBbdNHg(HexFormat.NumberHexFormat r0, char r1, float r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WLDdaDpdKNBbdNHg(HexFormat.NumberHexFormat r0, float r1, char r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WLDdaDpdKNBbdNHg(HexFormat.NumberHexFormat r0, int r1, float r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool WLDdaDpdKNBbdNHg(HexFormat.NumberHexFormat r1) {
        return r1.getRemoveLeadingZeros();
    }

    public static void WNuzIFOaJDERvCTd(byte[] r0, int r1, char r2, int r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WNuzIFOaJDERvCTd(byte[] r0, int r1, short r2, char r3, int r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WNuzIFOaJDERvCTd(byte[] r0, int r1, short r2, float r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static byte[] WNuzIFOaJDERvCTd(byte[] r1, int r2) {
        return Arrays.copyOf(r1, r2);
    }

    public static int WRyMeVoRLQcGOSVv(CharSequence r1) {
        return r1.Length;
    }

    public static void WRyMeVoRLQcGOSVv(CharSequence r0, char r1, short r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WRyMeVoRLQcGOSVv(CharSequence r0, short r1, bool r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WRyMeVoRLQcGOSVv(CharSequence r0, bool r1, short r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WTHdhCQVGFhfEsma(object r0, string r1) {
        Intrinsics.checkNotNullExpressionValue(r0, r1);
    }

    public static void WTHdhCQVGFhfEsma(object r0, string r1, char r2, short r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WTHdhCQVGFhfEsma(object r0, string r1, int r2, short r3, char r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WTHdhCQVGFhfEsma(object r0, string r1, short r2, char r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char WaNjCSBVDNrqriKx(string r1, int r2) {
        return r1[r2);
    }

    public static void WaNjCSBVDNrqriKx(string r0, int r1, char r2, bool r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WaNjCSBVDNrqriKx(string r0, int r1, short r2, bool r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WaNjCSBVDNrqriKx(string r0, int r1, bool r2, int r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int WfBdyMHPgRquGHRj(CharSequence r1) {
        return r1.Length;
    }

    public static void WfBdyMHPgRquGHRj(CharSequence r0, byte r1, char r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WfBdyMHPgRquGHRj(CharSequence r0, char r1, float r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WfBdyMHPgRquGHRj(CharSequence r0, int r1, float r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int WjohGvxemaXgiDYA(string r1) {
        return r1.Length;
    }

    public static void WjohGvxemaXgiDYA(string r0, string r1, short r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WjohGvxemaXgiDYA(string r0, short r1, char r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WjohGvxemaXgiDYA(string r0, short r1, bool r2, string r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int WuMxXcrfIeyAUwRV(string r1) {
        return r1.Length;
    }

    public static void WuMxXcrfIeyAUwRV(string r0, char r1, int r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WuMxXcrfIeyAUwRV(string r0, float r1, int r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WuMxXcrfIeyAUwRV(string r0, int r1, short r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder WvOiSqhFOYRwWcym(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void WvOiSqhFOYRwWcym(stringBuilder r0, string r1, byte r2, int r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WvOiSqhFOYRwWcym(stringBuilder r0, string r1, byte r2, bool r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WvOiSqhFOYRwWcym(stringBuilder r0, string r1, char r2, bool r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char WzWtZrzBpzwhNarc(string r1, int r2) {
        return r1[r2);
    }

    public static void WzWtZrzBpzwhNarc(string r0, int r1, byte r2, char r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WzWtZrzBpzwhNarc(string r0, int r1, byte r2, bool r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WzWtZrzBpzwhNarc(string r0, int r1, bool r2, byte r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void XIDKOuccGLLfQhZY(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void XIDKOuccGLLfQhZY(object r0, string r1, byte r2, bool r3, int r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void XIDKOuccGLLfQhZY(object r0, string r1, byte r2, bool r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void XIDKOuccGLLfQhZY(object r0, string r1, string r2, bool r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char XfontwISEnAdIxuL(string r1, int r2) {
        return r1[r2);
    }

    public static void XfontwISEnAdIxuL(string r0, int r1, float r2, string r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void XfontwISEnAdIxuL(string r0, int r1, float r2, short r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void XfontwISEnAdIxuL(string r0, int r1, string r2, char r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int XhnvxrVUGsLlbdco(byte[] r1, int r2, int[] r3, char[] r4, int r5) {
        return formatbyteAt(r1, r2, r3, r4, r5);
    }

    public static void XhnvxrVUGsLlbdco(byte[] r0, int r1, int[] r2, char[] r3, int r4, float r5, string r6, short r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void XhnvxrVUGsLlbdco(byte[] r0, int r1, int[] r2, char[] r3, int r4, string r5, float r6, short r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void XhnvxrVUGsLlbdco(byte[] r0, int r1, int[] r2, char[] r3, int r4, bool r5, string r6, float r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    public static string YFtZSQihBUVHHRlJ(long r1, HexFormat.NumberHexFormat r3, string r4, int r5) {
        return toHexstringImpl(r1, r3, r4, r5);
    }

    public static void YFtZSQihBUVHHRlJ(long r0, HexFormat.NumberHexFormat r2, string r3, int r4, int r5, char r6, short r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void YFtZSQihBUVHHRlJ(long r0, HexFormat.NumberHexFormat r2, string r3, int r4, short r5, int r6, char r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void YFtZSQihBUVHHRlJ(long r0, HexFormat.NumberHexFormat r2, string r3, int r4, bool r5, char r6, int r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    public static long YGiJMyMkWSuwYtEj(string r2, HexFormat r3) {
        if (((9 + 26) % 26) > 0) goto L5;
    L5:
        return hexTolong(r2, r3);
    }

    public static void YGiJMyMkWSuwYtEj(string r0, HexFormat r1, byte r2, char r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void YGiJMyMkWSuwYtEj(string r0, HexFormat r1, bool r2, byte r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void YGiJMyMkWSuwYtEj(string r0, HexFormat r1, bool r2, string r3, char r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int YGrJwcFwlGWegKaj(string r1) {
        return r1.Length;
    }

    public static void YGrJwcFwlGWegKaj(string r0, byte r1, float r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YGrJwcFwlGWegKaj(string r0, byte r1, bool r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YGrJwcFwlGWegKaj(string r0, float r1, byte r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int YMsJnHsJlbxVjQnY(long r1) {
        return long.numberOfLeadingZeros(r1);
    }

    public static void YMsJnHsJlbxVjQnY(long r0, char r2, bool r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void YMsJnHsJlbxVjQnY(long r0, bool r2, byte r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void YMsJnHsJlbxVjQnY(long r0, bool r2, char r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int YThngCGWpbgSDtBM(CharSequence r1) {
        return r1.Length;
    }

    public static void YThngCGWpbgSDtBM(CharSequence r0, char r1, int r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YThngCGWpbgSDtBM(CharSequence r0, int r1, bool r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YThngCGWpbgSDtBM(CharSequence r0, bool r1, char r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YUhWuSdBljsyMHZt(string r0, int r1, int r2, string r3, string r4) {
        throwNotContainedAt(r0, r1, r2, r3, r4);
    }

    public static void YUhWuSdBljsyMHZt(string r0, int r1, int r2, string r3, string r4, byte r5, bool r6, int r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void YUhWuSdBljsyMHZt(string r0, int r1, int r2, string r3, string r4, int r5, byte r6, bool r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void YUhWuSdBljsyMHZt(string r0, int r1, int r2, string r3, string r4, bool r5, int r6, short r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat YbxVsQAUYirOQCrv(HexFormat.Companion r1) {
        return r1.getDefault();
    }

    public static void YbxVsQAUYirOQCrv(HexFormat.Companion r0, float r1, byte r2, bool r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YbxVsQAUYirOQCrv(HexFormat.Companion r0, bool r1, float r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YbxVsQAUYirOQCrv(HexFormat.Companion r0, bool r1, short r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char YjGunKHAQguOaNOs(string r1, int r2) {
        return r1[r2);
    }

    public static void YjGunKHAQguOaNOs(string r0, int r1, string r2, float r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void YjGunKHAQguOaNOs(string r0, int r1, bool r2, float r3, byte r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void YjGunKHAQguOaNOs(string r0, int r1, bool r2, string r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int YkVvsvXNWpbALZrC(string r1) {
        return r1.Length;
    }

    public static void YkVvsvXNWpbALZrC(string r0, float r1, bool r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YkVvsvXNWpbALZrC(string r0, short r1, int r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YkVvsvXNWpbALZrC(string r0, bool r1, int r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder YtZVoiqBGfOtZgBf(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static void YtZVoiqBGfOtZgBf(stringBuilder r0, char r1, byte r2, int r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void YtZVoiqBGfOtZgBf(stringBuilder r0, char r1, int r2, bool r3, byte r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void YtZVoiqBGfOtZgBf(stringBuilder r0, char r1, bool r2, byte r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZEKhBeqmtVkewdjn(HexFormat r0, float r1, int r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZEKhBeqmtVkewdjn(HexFormat r0, float r1, string r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZEKhBeqmtVkewdjn(HexFormat r0, int r1, float r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool ZEKhBeqmtVkewdjn(HexFormat r1) {
        return r1.getUpperCase();
    }

    public static void ZHukMaiSSuDtGrgE(char r0, char r1, bool r2, char r3, float r4, int r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZHukMaiSSuDtGrgE(char r0, char r1, bool r2, char r3, bool r4, int r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZHukMaiSSuDtGrgE(char r0, char r1, bool r2, float r3, bool r4, int r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static bool ZHukMaiSSuDtGrgE(char r1, char r2, bool r3) {
        return CharsKt.Equals(r1, r2, r3);
    }

    public static void ZLHNsYtmTbDmzkYd(HexFormat.bytesHexFormat r0, short r1, byte r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZLHNsYtmTbDmzkYd(HexFormat.bytesHexFormat r0, short r1, byte r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZLHNsYtmTbDmzkYd(HexFormat.bytesHexFormat r0, bool r1, byte r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool ZLHNsYtmTbDmzkYd(HexFormat.bytesHexFormat r1) {
        return r1.getIgnoreCase$kotlin_stdlib();
    }

    public static string ZLKiscTXGHLIsqqU(HexFormat.bytesHexFormat r1) {
        return r1.getbyteSeparator();
    }

    public static void ZLKiscTXGHLIsqqU(HexFormat.bytesHexFormat r0, float r1, bool r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZLKiscTXGHLIsqqU(HexFormat.bytesHexFormat r0, int r1, bool r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZLKiscTXGHLIsqqU(HexFormat.bytesHexFormat r0, string r1, int r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZNNFdGClBDPWKEpZ(HexFormat.NumberHexFormat r0, char r1, short r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZNNFdGClBDPWKEpZ(HexFormat.NumberHexFormat r0, short r1, byte r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZNNFdGClBDPWKEpZ(HexFormat.NumberHexFormat r0, short r1, bool r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool ZNNFdGClBDPWKEpZ(HexFormat.NumberHexFormat r1) {
        return r1.getRemoveLeadingZeros();
    }

    public static byte ZNvrdSBjmpjsKPJL(string r1, int r2) {
        return parsebyteAt(r1, r2);
    }

    public static void ZNvrdSBjmpjsKPJL(string r0, int r1, char r2, bool r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZNvrdSBjmpjsKPJL(string r0, int r1, short r2, char r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZNvrdSBjmpjsKPJL(string r0, int r1, bool r2, byte r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int ZQpziSnbVmoqVEkM(string r1) {
        return r1.Length;
    }

    public static void ZQpziSnbVmoqVEkM(string r0, byte r1, float r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZQpziSnbVmoqVEkM(string r0, byte r1, string r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZQpziSnbVmoqVEkM(string r0, float r1, byte r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char ZXZBrdGddCuXTNmA(string r1, int r2) {
        return r1[r2);
    }

    public static void ZXZBrdGddCuXTNmA(string r0, int r1, byte r2, int r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZXZBrdGddCuXTNmA(string r0, int r1, bool r2, byte r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZXZBrdGddCuXTNmA(string r0, int r1, bool r2, int r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZYUDVKPoryJuiYUv(string r0, HexFormat r1, float r2, bool r3, int r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZYUDVKPoryJuiYUv(string r0, HexFormat r1, string r2, int r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZYUDVKPoryJuiYUv(string r0, HexFormat r1, bool r2, string r3, float r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static byte[] ZYUDVKPoryJuiYUv(string r1, HexFormat r2) {
        return hexTobyteArray(r1, r2);
    }

    public static void ZqmSkokpVbYqtmwh(HexFormat.bytesHexFormat r0, byte r1, float r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZqmSkokpVbYqtmwh(HexFormat.bytesHexFormat r0, bool r1, float r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZqmSkokpVbYqtmwh(HexFormat.bytesHexFormat r0, bool r1, int r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool ZqmSkokpVbYqtmwh(HexFormat.bytesHexFormat r1) {
        return r1.getIgnoreCase$kotlin_stdlib();
    }

    public static stringBuilder ZsvTxINWcLDefTPg(stringBuilder r1, int r2) {
        return r1.append(r2);
    }

    public static void ZsvTxINWcLDefTPg(stringBuilder r0, int r1, byte r2, float r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZsvTxINWcLDefTPg(stringBuilder r0, int r1, string r2, byte r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZsvTxINWcLDefTPg(stringBuilder r0, int r1, string r2, float r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int ZuPiPZoHmzaUnaJL(string r1) {
        return r1.Length;
    }

    public static void ZuPiPZoHmzaUnaJL(string r0, char r1, byte r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZuPiPZoHmzaUnaJL(string r0, float r1, byte r2, bool r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZuPiPZoHmzaUnaJL(string r0, bool r1, char r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat.NumberHexFormat ZzvJtVuyDoZONFwo(HexFormat r1) {
        return r1.getNumber();
    }

    public static void ZzvJtVuyDoZONFwo(HexFormat r0, byte r1, char r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZzvJtVuyDoZONFwo(HexFormat r0, byte r1, short r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZzvJtVuyDoZONFwo(HexFormat r0, string r1, byte r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int APbwWkUNdstmZLDJ(string r1) {
        return r1.Length;
    }

    public static void APbwWkUNdstmZLDJ(string r0, char r1, byte r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void APbwWkUNdstmZLDJ(string r0, char r1, int r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void APbwWkUNdstmZLDJ(string r0, bool r1, char r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string AWhJJWLhGAiiFmSw(HexFormat.bytesHexFormat r1) {
        return r1.getbyteSeparator();
    }

    public static void AWhJJWLhGAiiFmSw(HexFormat.bytesHexFormat r0, char r1, bool r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AWhJJWLhGAiiFmSw(HexFormat.bytesHexFormat r0, short r1, char r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AWhJJWLhGAiiFmSw(HexFormat.bytesHexFormat r0, bool r1, short r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int AWrcjlCZIRAoAEke(byte[] r1, int r2, string r3, string r4, int[] r5, char[] r6, int r7) {
        return formatbyteAt(r1, r2, r3, r4, r5, r6, r7);
    }

    public static void AWrcjlCZIRAoAEke(byte[] r0, int r1, string r2, string r3, int[] r4, char[] r5, int r6, byte r7, string r8, short r9, float r10) {
        double r02 = (42 * 210) + 210;
    }

    public static void AWrcjlCZIRAoAEke(byte[] r0, int r1, string r2, string r3, int[] r4, char[] r5, int r6, float r7, byte r8, short r9, string r10) {
        double r02 = (42 * 210) + 210;
    }

    public static void AWrcjlCZIRAoAEke(byte[] r0, int r1, string r2, string r3, int[] r4, char[] r5, int r6, short r7, string r8, byte r9, float r10) {
        double r02 = (42 * 210) + 210;
    }

    public static int AZgjvYOhCIyvBWCw(HexFormat.bytesHexFormat r1) {
        return r1.getbytesPerLine();
    }

    public static void AZgjvYOhCIyvBWCw(HexFormat.bytesHexFormat r0, char r1, bool r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AZgjvYOhCIyvBWCw(HexFormat.bytesHexFormat r0, float r1, string r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AZgjvYOhCIyvBWCw(HexFormat.bytesHexFormat r0, float r1, bool r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AcYvWxeabWMjSQHN(HexFormat.NumberHexFormat r0, char r1, string r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AcYvWxeabWMjSQHN(HexFormat.NumberHexFormat r0, char r1, short r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AcYvWxeabWMjSQHN(HexFormat.NumberHexFormat r0, float r1, char r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool AcYvWxeabWMjSQHN(HexFormat.NumberHexFormat r1) {
        return r1.isDigitsOnlyAndNoPadding$kotlin_stdlib();
    }

    public static string AiKwREdySyHijsdz(char[] r1) {
        return stringsKt.concatTostring(r1);
    }

    public static void AiKwREdySyHijsdz(char[] r0, char r1, short r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AiKwREdySyHijsdz(char[] r0, char r1, bool r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void AiKwREdySyHijsdz(char[] r0, bool r1, char r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char AigQMScuNOuhkDqR(string r1, int r2) {
        return r1[r2);
    }

    public static void AigQMScuNOuhkDqR(string r0, int r1, string r2, char r3, bool r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void AigQMScuNOuhkDqR(string r0, int r1, string r2, int r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void AigQMScuNOuhkDqR(string r0, int r1, bool r2, int r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char AjktCcLfmQvBfxAl(string r1, int r2) {
        return r1[r2);
    }

    public static void AjktCcLfmQvBfxAl(string r0, int r1, char r2, float r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void AjktCcLfmQvBfxAl(string r0, int r1, float r2, bool r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void AjktCcLfmQvBfxAl(string r0, int r1, bool r2, float r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void AlgrvQfvfIBMmxXB(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, string r4, short r5, int r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void AlgrvQfvfIBMmxXB(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, string r4, short r5, bool r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void AlgrvQfvfIBMmxXB(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, short r4, int r5, string r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static byte[] AlgrvQfvfIBMmxXB(string r1, int r2, int r3, HexFormat.bytesHexFormat r4) {
        return hexTobyteArrayNoLineAndGroupSeparator(r1, r2, r3, r4);
    }

    public static long AxliBxRuZeOLlTBK(string r2, int r3, int r4) {
        if (((14 + 9) % 9) > 0) goto L8;
    L8:
        return parselong(r2, r3, r4);
    }

    public static void AxliBxRuZeOLlTBK(string r0, int r1, int r2, int r3, short r4, string r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void AxliBxRuZeOLlTBK(string r0, int r1, int r2, string r3, short r4, int r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void AxliBxRuZeOLlTBK(string r0, int r1, int r2, short r3, char r4, string r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder BCjDuDjYTDgSsZVX(stringBuilder r1, int r2) {
        return r1.append(r2);
    }

    public static void BCjDuDjYTDgSsZVX(stringBuilder r0, int r1, char r2, bool r3, int r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void BCjDuDjYTDgSsZVX(stringBuilder r0, int r1, float r2, bool r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void BCjDuDjYTDgSsZVX(stringBuilder r0, int r1, bool r2, float r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int BLIIrkYnXJYWlqun(HexFormat.bytesHexFormat r1) {
        return r1.getbytesPerGroup();
    }

    public static void BLIIrkYnXJYWlqun(HexFormat.bytesHexFormat r0, byte r1, float r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BLIIrkYnXJYWlqun(HexFormat.bytesHexFormat r0, float r1, byte r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BLIIrkYnXJYWlqun(HexFormat.bytesHexFormat r0, string r1, float r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string BLTQFnQVNFAIBTbd(HexFormat.bytesHexFormat r1) {
        return r1.getbyteSuffix();
    }

    public static void BLTQFnQVNFAIBTbd(HexFormat.bytesHexFormat r0, string r1, byte r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BLTQFnQVNFAIBTbd(HexFormat.bytesHexFormat r0, string r1, float r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BLTQFnQVNFAIBTbd(HexFormat.bytesHexFormat r0, bool r1, float r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string BNkEEYWYVFbTrSSX(byte[] r1, HexFormat r2) {
        return toHexstring(r1, r2);
    }

    public static void BNkEEYWYVFbTrSSX(byte[] r0, HexFormat r1, byte r2, short r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void BNkEEYWYVFbTrSSX(byte[] r0, HexFormat r1, char r2, short r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void BNkEEYWYVFbTrSSX(byte[] r0, HexFormat r1, bool r2, char r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder BVGYvoOtZbZHopFb(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void BVGYvoOtZbZHopFb(stringBuilder r0, string r1, byte r2, char r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void BVGYvoOtZbZHopFb(stringBuilder r0, string r1, short r2, char r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void BVGYvoOtZbZHopFb(stringBuilder r0, string r1, short r2, int r3, char r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int BbeCIYtvGokLArzF(string r1, int r2, int r3, HexFormat r4, int r5) {
        return hexToIntImpl(r1, r2, r3, r4, r5);
    }

    public static void BbeCIYtvGokLArzF(string r0, int r1, int r2, HexFormat r3, int r4, string r5, byte r6, int r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void BbeCIYtvGokLArzF(string r0, int r1, int r2, HexFormat r3, int r4, string r5, int r6, bool r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void BbeCIYtvGokLArzF(string r0, int r1, int r2, HexFormat r3, int r4, bool r5, byte r6, string r7, int r8) {
        double r02 = (42 * 210) + 210;
    }

    public static char BeQsJrXRsTmbbgRW(string r1, int r2) {
        return r1[r2);
    }

    public static void BeQsJrXRsTmbbgRW(string r0, int r1, char r2, float r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void BeQsJrXRsTmbbgRW(string r0, int r1, float r2, char r3, bool r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void BeQsJrXRsTmbbgRW(string r0, int r1, bool r2, char r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int BfjXjMqJtkesaPgO(string r1, char[] r2, int r3) {
        return toCharArrayIfNotEmpty(r1, r2, r3);
    }

    public static void BfjXjMqJtkesaPgO(string r0, char[] r1, int r2, byte r3, float r4, char r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void BfjXjMqJtkesaPgO(string r0, char[] r1, int r2, byte r3, short r4, char r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void BfjXjMqJtkesaPgO(string r0, char[] r1, int r2, float r3, char r4, short r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static string BvWqfExxKenBgqBT(object r1) {
        return r1.tostring();
    }

    public static void BvWqfExxKenBgqBT(object r0, int r1, string r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BvWqfExxKenBgqBT(object r0, short r1, int r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void BvWqfExxKenBgqBT(object r0, short r1, string r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int CHkprrhhOGoPMRJQ(string r1) {
        return r1.Length;
    }

    public static void CHkprrhhOGoPMRJQ(string r0, float r1, string r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CHkprrhhOGoPMRJQ(string r0, int r1, float r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CHkprrhhOGoPMRJQ(string r0, bool r1, string r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int CJdkkBXKqJzIGEmE(byte[] r1, int r2, int[] r3, char[] r4, int r5) {
        return formatbyteAt(r1, r2, r3, r4, r5);
    }

    public static void CJdkkBXKqJzIGEmE(byte[] r0, int r1, int[] r2, char[] r3, int r4, char r5, byte r6, bool r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void CJdkkBXKqJzIGEmE(byte[] r0, int r1, int[] r2, char[] r3, int r4, short r5, char r6, byte r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void CJdkkBXKqJzIGEmE(byte[] r0, int r1, int[] r2, char[] r3, int r4, bool r5, short r6, char r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static char CMUKPFsQgoevCEAv(string r1, int r2) {
        return r1[r2);
    }

    public static void CMUKPFsQgoevCEAv(string r0, int r1, char r2, short r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CMUKPFsQgoevCEAv(string r0, int r1, string r2, char r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CMUKPFsQgoevCEAv(string r0, int r1, short r2, char r3, int r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static byte CWfvnMVbvVIdPlbT(string r1, int r2) {
        return parsebyteAt(r1, r2);
    }

    public static void CWfvnMVbvVIdPlbT(string r0, int r1, byte r2, float r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CWfvnMVbvVIdPlbT(string r0, int r1, byte r2, short r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CWfvnMVbvVIdPlbT(string r0, int r1, byte r2, bool r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int CgBkDUnGyEsKxmMI(string r1) {
        return r1.Length;
    }

    public static void CgBkDUnGyEsKxmMI(string r0, short r1, string r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CgBkDUnGyEsKxmMI(string r0, bool r1, byte r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CgBkDUnGyEsKxmMI(string r0, bool r1, byte r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly long CharsPerHashSet(long r4, int r6, int r7) {
        if (((21 + 10) % 10) > 0) goto L28;
    L28:
        if (r6 <= 0) goto L33;
        long r0 = r6;
        return (r4 * r0) + (((long) r7) * (r0 - 1));
    L33:
        throw new IllegalArgumentException(ftOVpOegBISTNofx("Failed requirement."));
    }

    private static readonly void CharsPerHashSet(long r0, int r2, int r3, byte r4, float r5, string r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void CharsPerHashSet(long r0, int r2, int r3, string r4, byte r5, float r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void CharsPerHashSet(long r0, int r2, int r3, bool r4, string r5, float r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly int CheckContainsAt(string r4, int r5, int r6, string r7, bool r8, string r9) {
        if (((14 + 25) % 25) > 0) goto L46;
    L46:
        string r0 = r7;
        if (HxueBgYuUUwuzPva(r0) == 0) goto L11;
        int r02 = EKBuYnpMKhkQijRU(r0);
        int r1 = 0;
    L20:
        if (r1 >= r02) goto L4;
        if (mScLFBfxyNRkupRC(AaKANEEykJwTTsil(r7, r1), rALEewmQvPxrBvxF(r4, r5 + r1), r8) == true) goto L3;
        YUhWuSdBljsyMHZt(r4, r5, r6, r7, r9);
    L3:
        r1 = r1 + 1;
        goto L20
    L4:
        return r5 + CREQeSMrggZbiwCF(r7);
    L11:
        return r5;
    }

    private static readonly void CheckContainsAt(string r0, int r1, int r2, string r3, bool r4, string r5, byte r6, float r7, short r8, string r9) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void CheckContainsAt(string r0, int r1, int r2, string r3, bool r4, string r5, string r6, float r7, short r8, byte r9) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void CheckContainsAt(string r0, int r1, int r2, string r3, bool r4, string r5, short r6, byte r7, float r8, string r9) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly int CheckFormatLength(long r3) {
        if (((24 + 5) % 5) > 0) goto L18;
    L18:
        if (0 > r3) goto L3;
        if (r3 > 2147483647L) goto L3;
        return (int) r3;
    L3:
        throw new IllegalArgumentException(zUSZJvWgMWXXZGsW(uNsrUgjCbgGJZnnc(new stringBuilder("The resulting string length is too big: "), wzLndtSOJANbvHsP(JMQMMVQkSeGGhnSG(r3)))));
    }

    private static readonly void CheckFormatLength(long r0, byte r2, int r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void CheckFormatLength(long r0, char r2, int r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void CheckFormatLength(long r0, string r2, byte r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly int CheckNewLineAt(string r3, int r4, int r5) {
        if (((20 + 4) % 4) > 0) goto L53;
    L53:
        if (ovBADjbPynKnHeIE(r3, r4) != '\r') goto L9;
        int r0 = r4 + 1;
        if (r0 < r5) goto L19;
    L12:
        return r0;
    L19:
        if (uuqxmKVyUvbyAfrH(r3, r0) != '\n') goto L12;
        return r4 + 2;
    L9:
        if (nwprLZqijQolnWOi(r3, r4) != '\n') goto L29;
        return r4 + 1;
    L29:
        throw new NumberFormatException(GMcZSIaBIymdqdOF(hRCBVrLZqOZmnbSp(kFHHiezALQmzWpHY(RkcjOSSVkihUgYxz(new stringBuilder("Expected a new line at index "), r4), ", but was "), iHVtPgXukrpaafmG(r3, r4))));
    }

    private static readonly void CheckNewLineAt(string r0, int r1, int r2, float r3, char r4, short r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void CheckNewLineAt(string r0, int r1, int r2, string r3, short r4, char r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void CheckNewLineAt(string r0, int r1, int r2, short r3, char r4, string r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void CheckNumberOfDigits(string r2, int r3, int r4, int r5) {
        if (((19 + 2) % 2) > 0) goto L11;
    L11:
        int r0 = r4 - r3;
        if (r0 < 1) goto L3;
        if (r0 > r5) goto L30;
        return;
    L30:
        yydoXwXDmysmhZBt(r2, r3, (r0 + r3) - r5);
        return;
    L3:
        JooglhvqhPDtNjBi(r2, r3, r4, "at least", 1);
    }

    private static readonly void CheckNumberOfDigits(string r0, int r1, int r2, int r3, char r4, bool r5, short r6, float r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void CheckNumberOfDigits(string r0, int r1, int r2, int r3, float r4, char r5, short r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void CheckNumberOfDigits(string r0, int r1, int r2, int r3, bool r4, char r5, short r6, float r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void CheckPrefixSuffixNumberOfDigits(string r5, int r6, int r7, string r8, string r9, bool r10, int r11) {
        if (((17 + 21) % 21) > 0) goto L37;
    L37:
        if (((r7 - r6) - cgBkDUnGyEsKxmMI(r8)) > dMcSjwRXbVYwzcwI(r9)) goto L6;
        ULiKJkvBaNClpNTu(r5, r6, r7, r8, r9);
    L6:
        string r0 = r8;
        int r2 = 0;
        if (QSWJeIiABZlOQkGQ(r0) == 0) goto L40;
        int r02 = WRyMeVoRLQcGOSVv(r0);
        int r1 = 0;
    L68:
        if (r1 >= r02) goto L83;
        if (NVGkRJTsdIsSyXaj(TkDipTGoHrfssOho(r8, r1), nnkcHXzIoftCQLXv(r5, r6 + r1), r10) == true) goto L50;
        mUsLryApxEUoYxYH(r5, r6, r7, r8, "prefix");
    L50:
        r1 = r1 + 1;
        goto L68
    L83:
        r6 = r6 + NgKDJmdNtJbyOUDZ(r8);
    L40:
        int r82 = r7 - zSMhuLPBBRkSfRNR(r9);
        string r03 = r9;
        if (uLNctbIGZrZmqWqH(r03) == 0) goto L54;
        int r04 = RbilKsyrAjCayFHX(r03);
    L15:
        if (r2 >= r04) goto L3;
        if (ZHukMaiSSuDtGrgE(QyhsvsKglUaYRAQJ(r9, r2), QZhxLgadDqEnjfoW(r5, r82 + r2), r10) == true) goto L44;
        tWpDvrpINyFptmdT(r5, r82, r7, r9, "suffix");
    L44:
        r2 = r2 + 1;
        goto L15
    L3:
        tHtDVnmehsmwZMlu(r9);
    L54:
        mYKjiApfpgllWpMN(r5, r6, r82, r11);
    }

    private static readonly void CheckPrefixSuffixNumberOfDigits(string r0, int r1, int r2, string r3, string r4, bool r5, int r6, float r7, int r8, char r9, short r10) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void CheckPrefixSuffixNumberOfDigits(string r0, int r1, int r2, string r3, string r4, bool r5, int r6, int r7, char r8, short r9, float r10) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void CheckPrefixSuffixNumberOfDigits(string r0, int r1, int r2, string r3, string r4, bool r5, int r6, short r7, int r8, char r9, float r10) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void CheckZeroDigits(string r2, int r3, int r4) {
        if (((32 + 7) % 7) > 0) goto L33;
    L33:
        if (r3 >= r4) goto L30;
        if (KeYyUvFZnhPNvphI(r2, r3) != '0') goto L37;
        r3 = r3 + 1;
        goto L33
    L37:
        throw new NumberFormatException(dzMeHeGQMeuZQQOB(lYLnrqqEnqqokBRy(lOLKfvdpCsqiIajk(WvOiSqhFOYRwWcym(wnLaXneiCsHmYtKk(new stringBuilder("Expected the hexadecimal digit '0' at index "), r3), ", but was '"), WaNjCSBVDNrqriKx(r2, r3)), "'.\nThe result won't fit the type being parsed.")));
    }

    private static readonly void CheckZeroDigits(string r0, int r1, int r2, char r3, int r4, bool r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void CheckZeroDigits(string r0, int r1, int r2, char r3, bool r4, float r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void CheckZeroDigits(string r0, int r1, int r2, bool r3, char r4, float r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static string CondGWbiEcJIJgsA(HexFormat.NumberHexFormat r1) {
        return r1.getPrefix();
    }

    public static void CondGWbiEcJIJgsA(HexFormat.NumberHexFormat r0, char r1, int r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CondGWbiEcJIJgsA(HexFormat.NumberHexFormat r0, string r1, char r2, bool r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void CondGWbiEcJIJgsA(HexFormat.NumberHexFormat r0, bool r1, string r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder CutiiupaxGdMzVyd(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void CutiiupaxGdMzVyd(stringBuilder r0, string r1, byte r2, short r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CutiiupaxGdMzVyd(stringBuilder r0, string r1, bool r2, short r3, byte r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void CutiiupaxGdMzVyd(stringBuilder r0, string r1, bool r2, short r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int DDzlBHztoMENosYm(int r1) {
        return int.numberOfLeadingZeros(r1);
    }

    public static void DDzlBHztoMENosYm(int r0, byte r1, bool r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DDzlBHztoMENosYm(int r0, short r1, byte r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DDzlBHztoMENosYm(int r0, short r1, string r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DKObJGxWYdRNlCjV(object r0, string r1) {
        Intrinsics.checkNotNullExpressionValue(r0, r1);
    }

    public static void DKObJGxWYdRNlCjV(object r0, string r1, float r2, char r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DKObJGxWYdRNlCjV(object r0, string r1, float r2, string r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DKObJGxWYdRNlCjV(object r0, string r1, string r2, char r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int DMcSjwRXbVYwzcwI(string r1) {
        return r1.Length;
    }

    public static void DMcSjwRXbVYwzcwI(string r0, byte r1, int r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DMcSjwRXbVYwzcwI(string r0, byte r1, int r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DMcSjwRXbVYwzcwI(string r0, char r1, short r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char DYNkyPZkYnzwXTVl(string r1, int r2) {
        return r1[r2);
    }

    public static void DYNkyPZkYnzwXTVl(string r0, int r1, byte r2, char r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DYNkyPZkYnzwXTVl(string r0, int r1, byte r2, string r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void DYNkyPZkYnzwXTVl(string r0, int r1, short r2, byte r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat.NumberHexFormat DbOwhsuxeykBMlEP(HexFormat r1) {
        return r1.getNumber();
    }

    public static void DbOwhsuxeykBMlEP(HexFormat r0, byte r1, float r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DbOwhsuxeykBMlEP(HexFormat r0, byte r1, float r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DbOwhsuxeykBMlEP(HexFormat r0, short r1, byte r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly int DecimalFromHexDigitAt(string r2, int r3) {
        if (((16 + 14) % 14) > 0) goto L32;
    L32:
        char r0 = wIBcSCRuyByGOMiu(r2, r3);
        if ((r0 >>> '\b') == 0) goto L18;
    L3:
        kpZCVYmflkGhhYfm(r2, r3);
        throw new KotlinNothingValueException();
    L18:
        int r02 = HEX_DIGITS_TO_DECIMAL[r0];
        if (r02 < 0) goto L3;
        return r02;
    }

    private static readonly void DecimalFromHexDigitAt(string r0, int r1, int r2, string r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void DecimalFromHexDigitAt(string r0, int r1, string r2, int r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void DecimalFromHexDigitAt(string r0, int r1, bool r2, byte r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int DhRdSacvZfvGGQEB(string r1, int r2, int r3) {
        return parseInt(r1, r2, r3);
    }

    public static void DhRdSacvZfvGGQEB(string r0, int r1, int r2, byte r3, bool r4, float r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void DhRdSacvZfvGGQEB(string r0, int r1, int r2, float r3, bool r4, string r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void DhRdSacvZfvGGQEB(string r0, int r1, int r2, string r3, byte r4, float r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static int DmKKgOKsJWedNIHi(string r1) {
        return r1.Length;
    }

    public static void DmKKgOKsJWedNIHi(string r0, string r1, short r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DmKKgOKsJWedNIHi(string r0, short r1, float r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DmKKgOKsJWedNIHi(string r0, short r1, bool r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int DobWVTpwQcOszyWw(string r1, int r2, int r3) {
        return checkNewLineAt(r1, r2, r3);
    }

    public static void DobWVTpwQcOszyWw(string r0, int r1, int r2, string r3, byte r4, bool r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void DobWVTpwQcOszyWw(string r0, int r1, int r2, string r3, char r4, byte r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void DobWVTpwQcOszyWw(string r0, int r1, int r2, string r3, bool r4, char r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static int DuNwpziaDgTHFFEs(string r1, int r2, int r3) {
        return parseInt(r1, r2, r3);
    }

    public static void DuNwpziaDgTHFFEs(string r0, int r1, int r2, byte r3, float r4, int r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void DuNwpziaDgTHFFEs(string r0, int r1, int r2, byte r3, int r4, float r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void DuNwpziaDgTHFFEs(string r0, int r1, int r2, float r3, int r4, byte r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static string DvdnhgrFDxnrdEtV(char[] r1, int r2, int r3, int r4, object r5) {
        return stringsKt.concatTostring$default(r1, r2, r3, r4, r5);
    }

    public static void DvdnhgrFDxnrdEtV(char[] r0, int r1, int r2, int r3, object r4, byte r5, short r6, bool r7, string r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void DvdnhgrFDxnrdEtV(char[] r0, int r1, int r2, int r3, object r4, string r5, short r6, byte r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void DvdnhgrFDxnrdEtV(char[] r0, int r1, int r2, int r3, object r4, short r5, bool r6, string r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void DxyGBcUUUBdRCBBG(string r0, int r1, int r2, HexFormat r3, string r4, bool r5, byte r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void DxyGBcUUUBdRCBBG(string r0, int r1, int r2, HexFormat r3, short r4, string r5, byte r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void DxyGBcUUUBdRCBBG(string r0, int r1, int r2, HexFormat r3, short r4, bool r5, string r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    public static byte[] DxyGBcUUUBdRCBBG(string r1, int r2, int r3, HexFormat r4) {
        return hexTobyteArray(r1, r2, r3, r4);
    }

    public static string DzMeHeGQMeuZQQOB(stringBuilder r1) {
        return r1.tostring();
    }

    public static void DzMeHeGQMeuZQQOB(stringBuilder r0, int r1, byte r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DzMeHeGQMeuZQQOB(stringBuilder r0, string r1, int r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void DzMeHeGQMeuZQQOB(stringBuilder r0, short r1, string r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EAXvnKXFmNPJrrUb(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void EAXvnKXFmNPJrrUb(object r0, string r1, char r2, byte r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EAXvnKXFmNPJrrUb(object r0, string r1, bool r2, byte r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EAXvnKXFmNPJrrUb(object r0, string r1, bool r2, char r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int EDnvgzAekSXLHbSt(int r1, int r2) {
        return RangesKt.coerceAtMost(r1, r2);
    }

    public static void EDnvgzAekSXLHbSt(int r0, int r1, byte r2, short r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EDnvgzAekSXLHbSt(int r0, int r1, short r2, bool r3, byte r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EDnvgzAekSXLHbSt(int r0, int r1, bool r2, float r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EFRqdhCfohxWYvlK(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, char r4, byte r5, bool r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void EFRqdhCfohxWYvlK(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, char r4, bool r5, short r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void EFRqdhCfohxWYvlK(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, short r4, byte r5, char r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static byte[] EFRqdhCfohxWYvlK(string r1, int r2, int r3, HexFormat.bytesHexFormat r4) {
        return hexTobyteArrayNoLineAndGroupSeparatorSlowPath(r1, r2, r3, r4);
    }

    public static stringBuilder EGnexkNIAKjeGykT(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void EGnexkNIAKjeGykT(stringBuilder r0, string r1, byte r2, string r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EGnexkNIAKjeGykT(stringBuilder r0, string r1, float r2, byte r3, bool r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EGnexkNIAKjeGykT(stringBuilder r0, string r1, bool r2, float r3, byte r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder EJisYAAuPtMzKlTU(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void EJisYAAuPtMzKlTU(stringBuilder r0, string r1, float r2, int r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EJisYAAuPtMzKlTU(stringBuilder r0, string r1, int r2, string r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EJisYAAuPtMzKlTU(stringBuilder r0, string r1, int r2, string r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int EKilyHJAoCrvprUe(string r1) {
        return r1.Length;
    }

    public static void EKilyHJAoCrvprUe(string r0, string r1, bool r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EKilyHJAoCrvprUe(string r0, string r1, bool r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EKilyHJAoCrvprUe(string r0, bool r1, float r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string EMSERhBldVzDewPq(char[] r1) {
        return stringsKt.concatTostring(r1);
    }

    public static void EMSERhBldVzDewPq(char[] r0, short r1, char r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EMSERhBldVzDewPq(char[] r0, short r1, int r2, bool r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EMSERhBldVzDewPq(char[] r0, bool r1, short r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char EXkfueOWHFeaYjcH(string r1, int r2) {
        return r1[r2);
    }

    public static void EXkfueOWHFeaYjcH(string r0, int r1, string r2, bool r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EXkfueOWHFeaYjcH(string r0, int r1, string r2, bool r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EXkfueOWHFeaYjcH(string r0, int r1, bool r2, char r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int EYQPQZQycvBraPkZ(string r1) {
        return r1.Length;
    }

    public static void EYQPQZQycvBraPkZ(string r0, byte r1, short r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EYQPQZQycvBraPkZ(string r0, bool r1, byte r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void EYQPQZQycvBraPkZ(string r0, bool r1, int r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char EbkVgCgFpTIPtRvA(string r1, int r2) {
        return r1[r2);
    }

    public static void EbkVgCgFpTIPtRvA(string r0, int r1, string r2, bool r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EbkVgCgFpTIPtRvA(string r0, int r1, short r2, float r3, bool r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void EbkVgCgFpTIPtRvA(string r0, int r1, short r2, bool r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string EkGFNnUbZFQYlvcN(string r1, int r2, int r3) {
        return r1.Substring(r2, r3);
    }

    public static void EkGFNnUbZFQYlvcN(string r0, int r1, int r2, byte r3, string r4, char r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void EkGFNnUbZFQYlvcN(string r0, int r1, int r2, byte r3, short r4, string r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void EkGFNnUbZFQYlvcN(string r0, int r1, int r2, short r3, byte r4, string r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static string FFOLSjKQpOteltNG(long r1, HexFormat r3) {
        return toHexstring(r1, r3);
    }

    public static void FFOLSjKQpOteltNG(long r0, HexFormat r2, byte r3, char r4, float r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void FFOLSjKQpOteltNG(long r0, HexFormat r2, byte r3, short r4, float r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void FFOLSjKQpOteltNG(long r0, HexFormat r2, float r3, char r4, short r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static int FFYqWUrjsSvySONY(byte[] r1, int r2, string r3, string r4, int[] r5, char[] r6, int r7) {
        return formatbyteAt(r1, r2, r3, r4, r5, r6, r7);
    }

    public static void FFYqWUrjsSvySONY(byte[] r0, int r1, string r2, string r3, int[] r4, char[] r5, int r6, float r7, int r8, char r9, bool r10) {
        double r02 = (42 * 210) + 210;
    }

    public static void FFYqWUrjsSvySONY(byte[] r0, int r1, string r2, string r3, int[] r4, char[] r5, int r6, int r7, char r8, bool r9, float r10) {
        double r02 = (42 * 210) + 210;
    }

    public static void FFYqWUrjsSvySONY(byte[] r0, int r1, string r2, string r3, int[] r4, char[] r5, int r6, int r7, bool r8, float r9, char r10) {
        double r02 = (42 * 210) + 210;
    }

    public static int FGftdCvgzjqUWwEZ(string r1) {
        return r1.Length;
    }

    public static void FGftdCvgzjqUWwEZ(string r0, string r1, bool r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FGftdCvgzjqUWwEZ(string r0, bool r1, byte r2, string r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FGftdCvgzjqUWwEZ(string r0, bool r1, string r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int FJpqaFMBkHGIgNUP(string r1) {
        return r1.Length;
    }

    public static void FJpqaFMBkHGIgNUP(string r0, short r1, char r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FJpqaFMBkHGIgNUP(string r0, short r1, char r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FJpqaFMBkHGIgNUP(string r0, short r1, int r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int FKHBIVEasOHsQKaK(CharSequence r1) {
        return r1.Length;
    }

    public static void FKHBIVEasOHsQKaK(CharSequence r0, char r1, float r2, short r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FKHBIVEasOHsQKaK(CharSequence r0, short r1, bool r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FKHBIVEasOHsQKaK(CharSequence r0, bool r1, short r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FSqgZaHPYyeuqFhw(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void FSqgZaHPYyeuqFhw(object r0, string r1, float r2, short r3, bool r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void FSqgZaHPYyeuqFhw(object r0, string r1, float r2, bool r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void FSqgZaHPYyeuqFhw(object r0, string r1, int r2, bool r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static long FoYeSiiLkbbDzadU(string r2, int r3, int r4, HexFormat r5) {
        if (((7 + 27) % 27) > 0) goto L18;
    L18:
        return hexTolong(r2, r3, r4, r5);
    }

    public static void FoYeSiiLkbbDzadU(string r0, int r1, int r2, HexFormat r3, string r4, byte r5, char r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void FoYeSiiLkbbDzadU(string r0, int r1, int r2, HexFormat r3, string r4, short r5, byte r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void FoYeSiiLkbbDzadU(string r0, int r1, int r2, HexFormat r3, string r4, short r5, char r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly int FormatbyteAt(byte[] r0, int r1, string r2, string r3, int[] r4, char[] r5, int r6) {
        return NbQTQgzNUwjdmkFc(r3, r5, cJdkkBXKqJzIGEmE(r0, r1, r4, r5, gvNcaSoeYaBVAzwB(r2, r5, r6)));
    }

    private static readonly int FormatbyteAt(byte[] r0, int r1, int[] r2, char[] r3, int r4) {
        int r02 = r2[r0[r1] & 255];
        r3[r4] = (char) (r02 >> 8);
        r3[r4 + 1] = (char) (r02 & 255);
        return r4 + 2;
    }

    private static readonly void FormatbyteAt(byte[] r0, int r1, string r2, string r3, int[] r4, char[] r5, int r6, byte r7, short r8, int r9, char r10) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void FormatbyteAt(byte[] r0, int r1, string r2, string r3, int[] r4, char[] r5, int r6, int r7, short r8, byte r9, char r10) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void FormatbyteAt(byte[] r0, int r1, string r2, string r3, int[] r4, char[] r5, int r6, short r7, byte r8, int r9, char r10) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void FormatbyteAt(byte[] r0, int r1, int[] r2, char[] r3, int r4, float r5, bool r6, string r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void FormatbyteAt(byte[] r0, int r1, int[] r2, char[] r3, int r4, string r5, char r6, bool r7, float r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void FormatbyteAt(byte[] r0, int r1, int[] r2, char[] r3, int r4, string r5, float r6, char r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly int FormattedstringLength(int r4, int r5, int r6, int r7) {
        if (((7 + 22) % 22) > 0) goto L23;
    L23:
        if (r4 <= 0) goto L20;
        long r52 = r5;
        return mBfGsmeGBJezOTbQ((((long) r4) * (((((long) r6) + 2) + ((long) r7)) + r52)) - r52);
    L20:
        throw new IllegalArgumentException(SBahpvIkkfhGEBbq("Failed requirement."));
    }

    public static readonly int FormattedstringLength(int r5, int r6, int r7, int r8, int r9, int r10, int r11) {
        if (((10 + 21) % 21) > 0) goto L24;
    L24:
        if (r5 <= 0) goto L3;
        int r0 = r5 - 1;
        int r1 = r0 / r6;
        int r2 = (r6 - 1) / r7;
        int r3 = r5 % r6;
        if (r3 == 0) goto L63;
        r6 = r3;
    L63:
        int r22 = (r2 * r1) + ((r6 - 1) / r7);
        return wFtpGWWNOBDqbTRh(((((long) r1) + (((long) r22) * ((long) r8))) + (((long) ((r0 - r1) - r22)) * ((long) r9))) + (((long) r5) * ((((long) r10) + 2) + ((long) r11))));
    L3:
        throw new IllegalArgumentException(PgarADBrZmGfpqMq("Failed requirement."));
    }

    public static readonly void FormattedstringLength(int r0, int r1, int r2, int r3, int r4, int r5, int r6, char r7, short r8, string r9, bool r10) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void FormattedstringLength(int r0, int r1, int r2, int r3, int r4, int r5, int r6, char r7, bool r8, string r9, short r10) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void FormattedstringLength(int r0, int r1, int r2, int r3, int r4, int r5, int r6, bool r7, char r8, short r9, string r10) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void FormattedstringLength(int r0, int r1, int r2, int r3, short r4, int r5, char r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void FormattedstringLength(int r0, int r1, int r2, int r3, bool r4, int r5, char r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void FormattedstringLength(int r0, int r1, int r2, int r3, bool r4, short r5, int r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static string FtOVpOegBISTNofx(object r1) {
        return r1.tostring();
    }

    public static void FtOVpOegBISTNofx(object r0, int r1, short r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FtOVpOegBISTNofx(object r0, int r1, bool r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FtOVpOegBISTNofx(object r0, bool r1, string r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int FziMXgZStQnPpbWV(CharSequence r1) {
        return r1.Length;
    }

    public static void FziMXgZStQnPpbWV(CharSequence r0, byte r1, char r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FziMXgZStQnPpbWV(CharSequence r0, byte r1, float r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void FziMXgZStQnPpbWV(CharSequence r0, float r1, byte r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GAxQihVSHpYOHdom(AbstractList.Companion r0, int r1, int r2, int r3) {
        r0.checkBoundsIndexes$kotlin_stdlib(r1, r2, r3);
    }

    public static void GAxQihVSHpYOHdom(AbstractList.Companion r0, int r1, int r2, int r3, byte r4, string r5, bool r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void GAxQihVSHpYOHdom(AbstractList.Companion r0, int r1, int r2, int r3, string r4, short r5, bool r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void GAxQihVSHpYOHdom(AbstractList.Companion r0, int r1, int r2, int r3, short r4, string r5, bool r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    public static char GOozGoDRNYSEGsqV(string r1, int r2) {
        return r1[r2);
    }

    public static void GOozGoDRNYSEGsqV(string r0, int r1, float r2, int r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GOozGoDRNYSEGsqV(string r0, int r1, float r2, string r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GOozGoDRNYSEGsqV(string r0, int r1, float r2, short r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char GXxCmBdkNwnYMvrY(string r1, int r2) {
        return r1[r2);
    }

    public static void GXxCmBdkNwnYMvrY(string r0, int r1, int r2, string r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GXxCmBdkNwnYMvrY(string r0, int r1, int r2, string r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GXxCmBdkNwnYMvrY(string r0, int r1, string r2, short r3, float r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void GetBYTETOLOWERCASEHEXDIGITS(int r0, char r1, float r2, short r3) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void GetBYTETOLOWERCASEHEXDIGITS(short r0, char r1, float r2, int r3) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void GetBYTETOLOWERCASEHEXDIGITS(short r0, float r1, int r2, char r3) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly int[] GetBYTETOLOWERCASEHEXDIGITS() {
        return BYTE_TO_LOWER_CASE_HEX_DIGITS;
    }

    public static /* synthetic */ void getBYTE_TO_LOWER_CASE_HEX_DIGITS$annotations() {
    }

    public static /* synthetic */ void getBYTE_TO_LOWER_CASE_HEX_DIGITS$annotations(string r0, byte r1, int r2, short r3) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void getBYTE_TO_LOWER_CASE_HEX_DIGITS$annotations(string r0, int r1, byte r2, short r3) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void getBYTE_TO_LOWER_CASE_HEX_DIGITS$annotations(short r0, byte r1, string r2, int r3) {
        double r02 = (42 * 210) + 210;
    }

    public static string GiQrmRswTlxejgts(object r1) {
        return r1.tostring();
    }

    public static void GiQrmRswTlxejgts(object r0, int r1, short r2, bool r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GiQrmRswTlxejgts(object r0, bool r1, char r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void GiQrmRswTlxejgts(object r0, bool r1, short r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder GnKGWlqTdMtNfpjB(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void GnKGWlqTdMtNfpjB(stringBuilder r0, string r1, byte r2, char r3, float r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GnKGWlqTdMtNfpjB(stringBuilder r0, string r1, char r2, float r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GnKGWlqTdMtNfpjB(stringBuilder r0, string r1, int r2, byte r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int GvNcaSoeYaBVAzwB(string r1, char[] r2, int r3) {
        return toCharArrayIfNotEmpty(r1, r2, r3);
    }

    public static void GvNcaSoeYaBVAzwB(string r0, char[] r1, int r2, char r3, bool r4, int r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void GvNcaSoeYaBVAzwB(string r0, char[] r1, int r2, int r3, char r4, string r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void GvNcaSoeYaBVAzwB(string r0, char[] r1, int r2, bool r3, int r4, char r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static short GwNmkXfHCpcOUuQj(string r1, int r2, int r3, HexFormat r4) {
        return hexToshort(r1, r2, r3, r4);
    }

    public static void GwNmkXfHCpcOUuQj(string r0, int r1, int r2, HexFormat r3, char r4, byte r5, bool r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void GwNmkXfHCpcOUuQj(string r0, int r1, int r2, HexFormat r3, bool r4, byte r5, char r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void GwNmkXfHCpcOUuQj(string r0, int r1, int r2, HexFormat r3, bool r4, char r5, byte r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static char GxQqkbNmyzgYNkAL(string r1, int r2) {
        return r1[r2);
    }

    public static void GxQqkbNmyzgYNkAL(string r0, int r1, int r2, string r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GxQqkbNmyzgYNkAL(string r0, int r1, string r2, bool r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void GxQqkbNmyzgYNkAL(string r0, int r1, bool r2, int r3, byte r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HGmkAAZRczLhXnOf(char r0, char r1, bool r2, byte r3, float r4, int r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void HGmkAAZRczLhXnOf(char r0, char r1, bool r2, byte r3, string r4, int r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void HGmkAAZRczLhXnOf(char r0, char r1, bool r2, int r3, float r4, byte r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static bool HGmkAAZRczLhXnOf(char r1, char r2, bool r3) {
        return CharsKt.Equals(r1, r2, r3);
    }

    public static char HNSvakXGGoNsZCYC(CharSequence r1, int r2) {
        return r1[r2);
    }

    public static void HNSvakXGGoNsZCYC(CharSequence r0, int r1, byte r2, short r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HNSvakXGGoNsZCYC(CharSequence r0, int r1, byte r2, short r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HNSvakXGGoNsZCYC(CharSequence r0, int r1, byte r2, bool r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int HOIdaBdLqjhgwZnt(string r1) {
        return r1.Length;
    }

    public static void HOIdaBdLqjhgwZnt(string r0, byte r1, bool r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HOIdaBdLqjhgwZnt(string r0, char r1, float r2, byte r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HOIdaBdLqjhgwZnt(string r0, float r1, bool r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder HRCBVrLZqOZmnbSp(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static void HRCBVrLZqOZmnbSp(stringBuilder r0, char r1, int r2, char r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HRCBVrLZqOZmnbSp(stringBuilder r0, char r1, int r2, string r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HRCBVrLZqOZmnbSp(stringBuilder r0, char r1, int r2, bool r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void HbaehbShZOwBGCVB(AbstractList.Companion r0, int r1, int r2, int r3) {
        r0.checkBoundsIndexes$kotlin_stdlib(r1, r2, r3);
    }

    public static void HbaehbShZOwBGCVB(AbstractList.Companion r0, int r1, int r2, int r3, byte r4, char r5, string r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void HbaehbShZOwBGCVB(AbstractList.Companion r0, int r1, int r2, int r3, char r4, short r5, string r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void HbaehbShZOwBGCVB(AbstractList.Companion r0, int r1, int r2, int r3, short r4, string r5, char r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void HemuzfiUuThTGPHu(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, char r4, int r5, float r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void HemuzfiUuThTGPHu(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, float r4, int r5, bool r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void HemuzfiUuThTGPHu(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, bool r4, float r5, char r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static byte[] HemuzfiUuThTGPHu(string r1, int r2, int r3, HexFormat.bytesHexFormat r4) {
        return hexTobyteArraySlowPath(r1, r2, r3, r4);
    }

    private static readonly byte HexTobyte(string r1, int r2, int r3, HexFormat r4) {
        return (byte) bbeCIYtvGokLArzF(r1, r2, r3, r4, 2);
    }

    public static readonly byte HexTobyte(string r2, HexFormat r3) {
        if (((5 + 31) % 31) > 0) goto L21;
    L21:
        DBfQGEmEGpvVzKCf(r2, "<this>");
        FPuJNRXXaheACWGO(r3, "format");
        return ohkiWNsZQdDylobL(r2, 0, EksHDPLqTrzslYnX(r2), r3);
    }

    private static readonly void HexTobyte(string r0, int r1, int r2, HexFormat r3, byte r4, float r5, string r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void HexTobyte(string r0, int r1, int r2, HexFormat r3, byte r4, string r5, short r6, float r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void HexTobyte(string r0, int r1, int r2, HexFormat r3, float r4, string r5, short r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void HexTobyte(string r0, HexFormat r1, char r2, byte r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void HexTobyte(string r0, HexFormat r1, int r2, byte r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void HexTobyte(string r0, HexFormat r1, int r2, short r3, char r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    static /* synthetic */ byte hexTobyte$default(string r0, int r1, int r2, HexFormat r3, int r4, object r5) {
        if ((r4 & 1) == 0) goto L21;
        r1 = 0;
    L21:
        if ((r4 & 2) == 0) goto L18;
        r2 = jilFidvCPztrWIhZ(r0);
    L18:
        if ((r4 & 4) != 0) goto L13;
    L16:
        return MsqnGqEowdyinRRs(r0, r1, r2, r3);
    L13:
        r3 = xKNHwSXskdIzIfJN(HexFormat.Companion);
        goto L16
    }

    public static /* synthetic */ byte hexTobyte$default(string r0, HexFormat r1, int r2, object r3) {
        if ((r2 & 1) != 0) goto L7;
    L5:
        return KcAPkINMLBJxtVwG(r0, r1);
    L7:
        r1 = FWKcsiwMnIruOlwx(HexFormat.Companion);
        goto L5
    }

    static /* synthetic */ void hexTobyte$default(string r0, int r1, int r2, HexFormat r3, int r4, object r5, byte r6, int r7, float r8, bool r9) {
        double r02 = (42 * 210) + 210;
    }

    static /* synthetic */ void hexTobyte$default(string r0, int r1, int r2, HexFormat r3, int r4, object r5, byte r6, bool r7, int r8, float r9) {
        double r02 = (42 * 210) + 210;
    }

    static /* synthetic */ void hexTobyte$default(string r0, int r1, int r2, HexFormat r3, int r4, object r5, int r6, float r7, bool r8, byte r9) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void hexTobyte$default(string r0, HexFormat r1, int r2, object r3, int r4, string r5, short r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void hexTobyte$default(string r0, HexFormat r1, int r2, object r3, string r4, int r5, char r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void hexTobyte$default(string r0, HexFormat r1, int r2, object r3, short r4, char r5, string r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void HexTobyteArray(string r0, int r1, int r2, HexFormat r3, float r4, byte r5, string r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void HexTobyteArray(string r0, int r1, int r2, HexFormat r3, bool r4, byte r5, string r6, float r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void HexTobyteArray(string r0, int r1, int r2, HexFormat r3, bool r4, string r5, byte r6, float r7) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void HexTobyteArray(string r0, HexFormat r1, byte r2, float r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void HexTobyteArray(string r0, HexFormat r1, byte r2, short r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void HexTobyteArray(string r0, HexFormat r1, short r2, float r3, char r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly byte[] HexTobyteArray(string r2, int r3, int r4, HexFormat r5) {
        if (((6 + 6) % 6) > 0) goto L37;
    L37:
        GVqoPGyKhURwzdaR(AbstractList.Companion, r3, r4, xbMPUjSwzfcBitCt(r2));
        if (r3 == r4) goto L9;
        HexFormat.bytesHexFormat r52 = OEvgYsXeGoIOSUfA(r5);
        if (uhXiKbjANIUILfAe(r52) == false) goto L12;
        byte[] r0 = algrvQfvfIBMmxXB(r2, r3, r4, r52);
        if (r0 is null) goto L12;
        return r0;
    L12:
        return hemuzfiUuThTGPHu(r2, r3, r4, r52);
    L9:
        return new byte[0];
    }

    public static readonly byte[] HexTobyteArray(string r2, HexFormat r3) {
        if (((26 + 13) % 13) > 0) goto L18;
    L18:
        HYcYTXpkdtdgOtgS(r2, "<this>");
        QPMzMNLmfBZcLrIz(r3, "format");
        return dxyGBcUUUBdRCBBG(r2, 0, hOIdaBdLqjhgwZnt(r2), r3);
    }

    static /* synthetic */ void hexTobyteArray$default(string r0, int r1, int r2, HexFormat r3, int r4, object r5, byte r6, bool r7, short r8, string r9) {
        double r02 = (42 * 210) + 210;
    }

    static /* synthetic */ void hexTobyteArray$default(string r0, int r1, int r2, HexFormat r3, int r4, object r5, string r6, byte r7, short r8, bool r9) {
        double r02 = (42 * 210) + 210;
    }

    static /* synthetic */ void hexTobyteArray$default(string r0, int r1, int r2, HexFormat r3, int r4, object r5, string r6, bool r7, short r8, byte r9) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void hexTobyteArray$default(string r0, HexFormat r1, int r2, object r3, string r4, float r5, short r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void hexTobyteArray$default(string r0, HexFormat r1, int r2, object r3, short r4, string r5, float r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void hexTobyteArray$default(string r0, HexFormat r1, int r2, object r3, bool r4, string r5, short r6, float r7) {
        double r02 = (42 * 210) + 210;
    }

    static /* synthetic */ byte[] hexTobyteArray$default(string r0, int r1, int r2, HexFormat r3, int r4, object r5) {
        if ((r4 & 1) == 0) goto L24;
        r1 = 0;
    L24:
        if ((r4 & 2) == 0) goto L7;
        r2 = DQAfycjAOHqMiwVE(r0);
    L7:
        if ((r4 & 4) == 0) goto L16;
        r3 = scPoRdVUBkdDypVL(HexFormat.Companion);
    L16:
        return GcTtkuztutThRhOa(r0, r1, r2, r3);
    }

    public static /* synthetic */ byte[] hexTobyteArray$default(string r0, HexFormat r1, int r2, object r3) {
        if ((r2 & 1) == 0) goto L9;
        r1 = wSbmtqOpKrvWMdsD(HexFormat.Companion);
    L9:
        return ZYUDVKPoryJuiYUv(r0, r1);
    }

    private static readonly void HexTobyteArrayNoLineAndGroupSeparator(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, char r4, string r5, float r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void HexTobyteArrayNoLineAndGroupSeparator(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, float r4, char r5, byte r6, string r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void HexTobyteArrayNoLineAndGroupSeparator(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, float r4, string r5, byte r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly byte[] HexTobyteArrayNoLineAndGroupSeparator(string r1, int r2, int r3, HexFormat.bytesHexFormat r4) {
        if (LWtrTXxinAOfYSzg(r4) == true) goto L7;
        return eFRqdhCfohxWYvlK(r1, r2, r3, r4);
    L7:
        return vsJtCQDZzmyLvZeF(r1, r2, r3, r4);
    }

    private static readonly void HexTobyteArrayNoLineAndGroupSeparatorSlowPath(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, char r4, short r5, byte r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void HexTobyteArrayNoLineAndGroupSeparatorSlowPath(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, char r4, short r5, int r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void HexTobyteArrayNoLineAndGroupSeparatorSlowPath(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, short r4, byte r5, char r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly byte[] HexTobyteArrayNoLineAndGroupSeparatorSlowPath(string r12, int r13, int r14, HexFormat.bytesHexFormat r15) {
        if (((27 + 28) % 28) > 0) goto L33;
    L33:
        string r0 = CoRWorKvypRfjBdq(r15);
        string r1 = mCyVKgIAZajvPeeo(r15);
        string r2 = ooSndHOYSVSatPtb(r15);
        long r6 = iKJTwZgOGzNUeMtw(r2);
        long r4 = ((((long) cHkprrhhOGoPMRJQ(r0)) + 2) + ((long) qqmNqUrLaJNYLoLd(r1))) + r6;
        long r8 = r14 - r13;
        int r3 = (int) ((r8 + r6) / r4);
        if (((((long) r3) * r4) - r6) == r8) goto L103;
        return null;
    L103:
        bool r152 = ZLHNsYtmTbDmzkYd(r15);
        byte[] r42 = new byte[r3];
        string r5 = r0;
        int r7 = 0;
        if (RhiKoInJoTeltZfS(r5) == 0) goto L121;
        int r52 = xqNSVTwrWmoGczJt(r5);
        int r62 = 0;
    L153:
        if (r62 >= r52) goto L129;
        if (JcrrjXOJTcmNWDJu(osoIChDjxHZVIMBV(r0, r62), mAHtvRLmZUtCoEGE(r12, r13 + r62), r152) == true) goto L89;
        RXfuaTtFAdptHTDu(r12, r13, r14, r0, "byte prefix");
    L89:
        r62 = r62 + 1;
        goto L153
    L129:
        r13 = r13 + jYCvKfpfzcUnXRug(r0);
    L121:
        string r02 = RzCLOdslfUOwOozy(UMyvmCeFauySclbw(PIYGuuFOSQlbfBaE(zmaXBRXvlHKVoYOP(new stringBuilder(), r1), r2), r0));
        int r32 = r3 - 1;
        int r22 = 0;
    L93:
        if (r22 >= r32) goto L99;
        r42[r22] = VmcJOGCxZSHDCTwn(r12, r13);
        r13 = r13 + 2;
        string r53 = r02;
        if (VKcMaGJTwiANCYAJ(r53) == 0) goto L65;
        int r54 = RZDwNnkmgwhLgsID(r53);
        int r63 = 0;
    L7:
        if (r63 >= r54) goto L20;
        if (hGmkAAZRczLhXnOf(PBcJXGvfvwsVQFrS(r02, r63), nsSdXYYpKdjwNcuW(r12, r13 + r63), r152) == true) goto L16;
        GjyrAwtKtXiMzUWb(r12, r13, r14, r02, "byte suffix + byte separator + byte prefix");
    L16:
        r63 = r63 + 1;
        goto L7
    L20:
        r13 = r13 + fGftdCvgzjqUWwEZ(r02);
    L65:
        r22 = r22 + 1;
        goto L93
    L99:
        r42[r32] = RFsbOhRHjLZsZUSu(r12, r13);
        int r132 = r13 + 2;
        string r03 = r1;
        if (FMperRagtBomIKsC(r03) != 0) goto L125;
        return r42;
    L125:
        int r04 = UUABwrtAXvrumHft(r03);
    L4:
        if (r7 >= r04) goto L12;
        if (rQGZeGCZbZSrbgxR(zBTCWaabuJOHTdBm(r1, r7), aigQMScuNOuhkDqR(r12, r132 + r7), r152) == true) goto L106;
        viYfKfoIzIPhmInJ(r12, r132, r14, r1, "byte suffix");
    L106:
        r7 = r7 + 1;
        goto L4
    L12:
        xurvknhWkyfjqmdn(r1);
        return r42;
    }

    private static readonly void HexTobyteArrayshortbyteSeparatorNoPrefixAndSuffix(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, byte r4, char r5, float r6, string r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void HexTobyteArrayshortbyteSeparatorNoPrefixAndSuffix(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, byte r4, char r5, string r6, float r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void HexTobyteArrayshortbyteSeparatorNoPrefixAndSuffix(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, char r4, float r5, string r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly byte[] HexTobyteArrayshortbyteSeparatorNoPrefixAndSuffix(string r11, int r12, int r13, HexFormat.bytesHexFormat r14) {
        if (((24 + 22) % 22) > 0) goto L65;
    L65:
        int r0 = viwPJgfKARCWJIPO(zabEZTDMrUFSIxTp(r14));
        int r1 = 1;
        if (r0 > 1) goto L54;
        int r122 = r13 - r12;
        int r3 = 2;
        int r4 = 0;
        if (r0 != 0) goto L60;
        if ((r122 & 1) == 0) goto L73;
        return null;
    L73:
        int r123 = r122 >> 1;
        byte[] r132 = new byte[r123];
        int r142 = 0;
    L101:
        if (r4 >= r123) goto L113;
        r132[r4] = QwJUyRgfmwCCptRQ(r11, r142);
        r142 = r142 + 2;
        r4 = r4 + 1;
        goto L101
    L113:
        return r132;
    L60:
        if ((r122 % 3) == 2) goto L12;
        return null;
    L12:
        int r124 = (r122 / 3) + 1;
        byte[] r02 = new byte[r124];
        char r2 = CHlrndlrVBdrKPfq(aWhJJWLhGAiiFmSw(r14), 0);
        r02[0] = cWfvnMVbvVIdPlbT(r11, 0);
    L84:
        if (r1 >= r124) goto L81;
        if (ntCzLYHWgYiNiimL(r11, r3) == r2) goto L111;
        string r5 = hiogQqiOfrfPsGys(r14);
        bool r6 = ZqmSkokpVbYqtmwh(r14);
        string r7 = r5;
        if (YThngCGWpbgSDtBM(r7) == 0) goto L111;
        int r72 = mGHUKVyvIILECFWa(r7);
        int r8 = 0;
    L32:
        if (r8 >= r72) goto L87;
        if (qntUneALDkTnBdLn(gOozGoDRNYSEGsqV(r5, r8), OCYxWfolorVvhThP(r11, r3 + r8), r6) == true) goto L16;
        ibmXCGHzweJwkegR(r11, r3, r13, r5, "byte separator");
    L16:
        r8 = r8 + 1;
        goto L32
    L87:
        rsMrMqGvFkopOiVe(r5);
    L111:
        r02[r1] = ZNvrdSBjmpjsKPJL(r11, r3 + 1);
        r3 = r3 + 3;
        r1 = r1 + 1;
        goto L84
    L81:
        return r02;
    L54:
        throw new IllegalArgumentException(xjrNsyDhOKnyElWw("Failed requirement."));
    }

    private static readonly void HexTobyteArraySlowPath(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, short r4, bool r5, float r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void HexTobyteArraySlowPath(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, bool r4, byte r5, float r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void HexTobyteArraySlowPath(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, bool r4, float r5, short r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly byte[] HexTobyteArraySlowPath(string r18, int r19, int r20, HexFormat.bytesHexFormat r21) {
        if (((13 + 18) % 18) > 0) goto L202;
    L202:
        int r3 = NIrEIhcvBoTczjEX(r21);
        int r4 = LUzHMBzNNalsExDf(r21);
        string r9 = nJOyshyJttJxgmDl(r21);
        string r10 = bLTQFnQVNFAIBTbd(r21);
        string r11 = MoqKmzUTzCtGswON(r21);
        string r12 = IKZrVHFlIVVbfrnw(r21);
        bool r13 = pIoeuACpdtLNceLO(r21);
        int r2 = VsLiZSsUnGNZugiY(r20 - r19, r3, r4, tWnuBUIckBAigynb(r12), WjohGvxemaXgiDYA(r11), jTTCAjrlBCJTPIGr(r9), kpuWOUPjNbDuZasQ(r10));
        byte[] r5 = new byte[r2];
        int r7 = r19;
        int r8 = 0;
        int r14 = 0;
        int r15 = 0;
    L85:
        if (r7 >= r20) goto L9;
        if (r14 == r3) goto L222;
        if (r15 == r4) goto L56;
        int r16 = r3;
        int r17 = r4;
        if (r15 != 0) goto L144;
    L38:
        r14 = r14 + 1;
        r15 = r15 + 1;
        string r32 = r9;
        if (qqJKehkDEXnPbqHN(r32) == 0) goto L3;
        int r33 = xaKPxCzCNzamoWCN(r32);
        int r42 = 0;
    L199:
        if (r42 >= r33) goto L65;
        int r192 = r33;
        if (NKlIjVhtRjXPpSQI(ebkVgCgFpTIPtRvA(r9, r42), BdumWxNqPvNgYOWT(r18, r7 + r42), r13) == false) goto L149;
    L136:
        r42 = r42 + 1;
        r33 = r192;
        goto L199
    L149:
        qJTTHuuieRfIkINU(r18, r7, r20, r9, "byte prefix");
        goto L136
    L65:
        r7 = r7 + zldRZQTMNZDnklGc(r9);
    L3:
        if ((r20 - 2) < r7) goto L171;
    L205:
        int r34 = r8 + 1;
        r5[r8] = nxKEFjLYlwyPrOol(r18, r7);
        r7 = r7 + 2;
        string r43 = r10;
        if (fKHBIVEasOHsQKaK(r43) == 0) goto L187;
        int r44 = lhFRScaXjMZgIKVs(r43);
        int r6 = 0;
    L130:
        if (r6 >= r44) goto L117;
        int r193 = r34;
        if (JGkUjEVlcOgeVsQD(LDAKwaRfUNjgQMEA(r10, r6), iohsUFgrJyNzatMD(r18, r7 + r6), r13) == false) goto L151;
    L156:
        r6 = r6 + 1;
        r34 = r193;
        goto L130
    L151:
        xMBaHIdHPoaqMnTx(r18, r7, r20, r10, "byte suffix");
        goto L156
    L117:
        int r194 = r34;
        r7 = r7 + vZHWbqaKMNcjOAzt(r10);
    L162:
        r8 = r194;
        r3 = r16;
        r4 = r17;
        goto L85
    L187:
        r194 = r34;
        goto L162
    L171:
        SFNDPPPqTInhIUIL(r18, r7, r20, "exactly", 2);
        goto L205
    L144:
        string r35 = r11;
        if (FtrDzJQBtGBZKoUT(r35) == 0) goto L38;
        int r36 = ulKtdPgDgUNHylni(r35);
        int r45 = 0;
    L145:
        if (r45 >= r36) goto L213;
        int r195 = r36;
        if (BOVxVKgVitNrnMhT(RMzynilmlpSEvRqi(r11, r45), UTsHdNZnkBtqIGPm(r18, r7 + r45), r13) == false) goto L28;
    L188:
        r45 = r45 + 1;
        r36 = r195;
        goto L145
    L28:
        KVLDUCsWFGDEHNif(r18, r7, r20, r11, "byte separator");
        goto L188
    L213:
        r7 = r7 + eKilyHJAoCrvprUe(r11);
        goto L38
    L56:
        string r152 = r12;
        if (fziMXgZStQnPpbWV(r152) != 0) goto L216;
        r16 = r3;
        r17 = r4;
    L193:
        r15 = 0;
        goto L38
    L216:
        int r153 = WfBdyMHPgRquGHRj(r152);
        int r62 = 0;
    L177:
        if (r62 >= r153) goto L215;
        int r162 = r3;
        int r172 = r4;
        if (ogVIzsITEAWHrVxj(XfontwISEnAdIxuL(r12, r62), YjGunKHAQguOaNOs(r18, r7 + r62), r13) == false) goto L6;
    L219:
        r62 = r62 + 1;
        r3 = r162;
        r4 = r172;
        goto L177
    L6:
        sZyiboydofgDZMhO(r18, r7, r20, r12, "group separator");
        goto L219
    L215:
        r16 = r3;
        r17 = r4;
        r7 = r7 + ZQpziSnbVmoqVEkM(r12);
        goto L193
    L222:
        r7 = dobWVTpwQcOszyWw(r18, r7, r20);
        r16 = r3;
        r17 = r4;
        r14 = 0;
        goto L193
    L9:
        if (r8 != r2) goto L140;
        return r5;
    L140:
        byte[] r0 = WNuzIFOaJDERvCTd(r5, r8);
        DTnFufecVrWWysyw(r0, "copyOf(...)");
        return r0;
    }

    private static readonly int HexToInt(string r1, int r2, int r3, HexFormat r4) {
        return oAjMtvFlLVXZraqt(r1, r2, r3, r4, 8);
    }

    public static readonly int HexToInt(string r2, HexFormat r3) {
        if (((25 + 11) % 11) > 0) goto L22;
    L22:
        eAXvnKXFmNPJrrUb(r2, "<this>");
        NsUXnrvvZGGiNJrJ(r3, "format");
        return QjRHUvfoiuwtEQKv(r2, 0, vTTCBCSkDDHjzSmB(r2), r3);
    }

    private static readonly void HexToInt(string r0, int r1, int r2, HexFormat r3, char r4, byte r5, bool r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void HexToInt(string r0, int r1, int r2, HexFormat r3, char r4, bool r5, byte r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void HexToInt(string r0, int r1, int r2, HexFormat r3, bool r4, byte r5, int r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void HexToInt(string r0, HexFormat r1, byte r2, char r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void HexToInt(string r0, HexFormat r1, char r2, float r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void HexToInt(string r0, HexFormat r1, char r2, short r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    static /* synthetic */ int hexToInt$default(string r0, int r1, int r2, HexFormat r3, int r4, object r5) {
        if ((r4 & 1) == 0) goto L6;
        r1 = 0;
    L6:
        if ((r4 & 2) == 0) goto L18;
        r2 = ikViaBLvKbPCzIkO(r0);
    L18:
        if ((r4 & 4) != 0) goto L15;
    L3:
        return rYUASldAbIfYjOUG(r0, r1, r2, r3);
    L15:
        r3 = qRDkVDmzTVMCBZpB(HexFormat.Companion);
        goto L3
    }

    public static /* synthetic */ int hexToInt$default(string r0, HexFormat r1, int r2, object r3) {
        if ((r2 & 1) != 0) goto L3;
    L14:
        return WEjKrNCbfMSLvewR(r0, r1);
    L3:
        r1 = pQUStFtHztMonWfn(HexFormat.Companion);
        goto L14
    }

    static /* synthetic */ void hexToInt$default(string r0, int r1, int r2, HexFormat r3, int r4, object r5, char r6, byte r7, string r8, float r9) {
        double r02 = (42 * 210) + 210;
    }

    static /* synthetic */ void hexToInt$default(string r0, int r1, int r2, HexFormat r3, int r4, object r5, char r6, string r7, byte r8, float r9) {
        double r02 = (42 * 210) + 210;
    }

    static /* synthetic */ void hexToInt$default(string r0, int r1, int r2, HexFormat r3, int r4, object r5, float r6, byte r7, char r8, string r9) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void hexToInt$default(string r0, HexFormat r1, int r2, object r3, byte r4, float r5, string r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void hexToInt$default(string r0, HexFormat r1, int r2, object r3, float r4, string r5, int r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void hexToInt$default(string r0, HexFormat r1, int r2, object r3, string r4, byte r5, float r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly int HexToIntImpl(string r7, int r8, int r9, HexFormat r10, int r11) {
        if (((19 + 9) % 9) > 0) goto L13;
    L13:
        gAxQihVSHpYOHdom(AbstractList.Companion, r8, r9, zcMVNKLFSUbeHWVZ(r7));
        HexFormat.NumberHexFormat r102 = tOZMaKvXfTFqbJLM(r10);
        if (EYPjoyTJgTUKOvjm(r102) == true) goto L41;
        string r3 = condGWbiEcJIJgsA(r102);
        string r4 = JOVUkrPDAGrgDwyA(r102);
        mCZHpzqnBewyyNbW(r7, r8, r9, r3, r4, RwQHggMsUtFesuEg(r102), r11);
        return duNwpziaDgTHFFEs(r7, r8 + lnWeyXDtbEhPKzNG(r3), r9 - itHlYCYhjHozPRiu(r4));
    L41:
        jRbXjESvKnNOfAXN(r7, r8, r9, r11);
        return dhRdSacvZfvGGQEB(r7, r8, r9);
    }

    private static readonly void HexToIntImpl(string r0, int r1, int r2, HexFormat r3, int r4, int r5, string r6, char r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void HexToIntImpl(string r0, int r1, int r2, HexFormat r3, int r4, int r5, short r6, char r7, string r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void HexToIntImpl(string r0, int r1, int r2, HexFormat r3, int r4, string r5, char r6, int r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly long HexTolong(string r1, int r2, int r3, HexFormat r4) {
        QvaMRTaTbagYWWZw(r1, "<this>");
        PjbaAuTlGcgpNDBH(r4, "format");
        return BjiaFhhrYUWGjrCf(r1, r2, r3, r4, 16);
    }

    public static readonly long HexTolong(string r2, HexFormat r3) {
        if (((22 + 6) % 6) > 0) goto L10;
    L10:
        sKRflcAcHCoFEGNb(r2, "<this>");
        kGkGggjGXVmoJaeB(r3, "format");
        return LmSCmVSXHlfMCqIL(r2, 0, YGrJwcFwlGWegKaj(r2), r3);
    }

    public static readonly void HexTolong(string r0, int r1, int r2, HexFormat r3, byte r4, float r5, bool r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void HexTolong(string r0, int r1, int r2, HexFormat r3, byte r4, bool r5, float r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void HexTolong(string r0, int r1, int r2, HexFormat r3, bool r4, byte r5, float r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void HexTolong(string r0, HexFormat r1, int r2, byte r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void HexTolong(string r0, HexFormat r1, int r2, short r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void HexTolong(string r0, HexFormat r1, bool r2, short r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ long hexTolong$default(string r0, int r1, int r2, HexFormat r3, int r4, object r5) {
        if ((r4 & 1) == 0) goto L23;
        r1 = 0;
    L23:
        if ((r4 & 2) == 0) goto L20;
        r2 = dmKKgOKsJWedNIHi(r0);
    L20:
        if ((r4 & 4) != 0) goto L13;
    L10:
        return foYeSiiLkbbDzadU(r0, r1, r2, r3);
    L13:
        r3 = jezlTUeBBtaxlYAP(HexFormat.Companion);
        goto L10
    }

    public static /* synthetic */ long hexTolong$default(string r0, HexFormat r1, int r2, object r3) {
        if ((r2 & 1) == 0) goto L14;
        r1 = YbxVsQAUYirOQCrv(HexFormat.Companion);
    L14:
        return YGiJMyMkWSuwYtEj(r0, r1);
    }

    public static /* synthetic */ void hexTolong$default(string r0, int r1, int r2, HexFormat r3, int r4, object r5, byte r6, string r7, int r8, bool r9) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void hexTolong$default(string r0, int r1, int r2, HexFormat r3, int r4, object r5, bool r6, byte r7, int r8, string r9) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void hexTolong$default(string r0, int r1, int r2, HexFormat r3, int r4, object r5, bool r6, int r7, byte r8, string r9) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void hexTolong$default(string r0, HexFormat r1, int r2, object r3, byte r4, short r5, int r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void hexTolong$default(string r0, HexFormat r1, int r2, object r3, int r4, byte r5, bool r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void hexTolong$default(string r0, HexFormat r1, int r2, object r3, bool r4, byte r5, short r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly long HexTolongImpl(string r7, int r8, int r9, HexFormat r10, int r11) {
        if (((2 + 29) % 29) > 0) goto L27;
    L27:
        OVaANcybCPufQMUq(AbstractList.Companion, r8, r9, NCYbILimIzeqCoBP(r7));
        HexFormat.NumberHexFormat r102 = sbXvmpAvKjbbzvgx(r10);
        if (JJTaiAEgoDWjwhJV(r102) == false) goto L12;
        LNFjxJDhOAsCgvAd(r7, r8, r9, r11);
        return axliBxRuZeOLlTBK(r7, r8, r9);
    L12:
        string r3 = FKIlrKgWcFaPEAwL(r102);
        string r4 = BKwGoMJCNfaAPTlX(r102);
        nwWRYcbYZAayppUK(r7, r8, r9, r3, r4, KadLMRoWKLuDTWkb(r102), r11);
        return vRWkQOSSEtPEGXoK(r7, r8 + aPbwWkUNdstmZLDJ(r3), r9 - TUNyNNhzOAubZluO(r4));
    }

    private static readonly void HexTolongImpl(string r0, int r1, int r2, HexFormat r3, int r4, float r5, char r6, string r7, int r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void HexTolongImpl(string r0, int r1, int r2, HexFormat r3, int r4, float r5, string r6, char r7, int r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void HexTolongImpl(string r0, int r1, int r2, HexFormat r3, int r4, int r5, float r6, char r7, string r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly short HexToshort(string r1, int r2, int r3, HexFormat r4) {
        return (short) SmGCPkalkuCzVWZB(r1, r2, r3, r4, 4);
    }

    public static readonly short HexToshort(string r2, HexFormat r3) {
        if (((20 + 15) % 15) > 0) goto L10;
    L10:
        AREdFMpGCjOctkZh(r2, "<this>");
        qhhEGBWwDLYIEsJS(r3, "format");
        return gwNmkXfHCpcOUuQj(r2, 0, eYQPQZQycvBraPkZ(r2), r3);
    }

    private static readonly void HexToshort(string r0, int r1, int r2, HexFormat r3, float r4, short r5, bool r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void HexToshort(string r0, int r1, int r2, HexFormat r3, short r4, char r5, float r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void HexToshort(string r0, int r1, int r2, HexFormat r3, bool r4, char r5, short r6, float r7) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void HexToshort(string r0, HexFormat r1, char r2, short r3, float r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void HexToshort(string r0, HexFormat r1, float r2, int r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void HexToshort(string r0, HexFormat r1, float r2, short r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    static /* synthetic */ short hexToshort$default(string r0, int r1, int r2, HexFormat r3, int r4, object r5) {
        if ((r4 & 1) == 0) goto L5;
        r1 = 0;
    L5:
        if ((r4 & 2) == 0) goto L21;
        r2 = WuMxXcrfIeyAUwRV(r0);
    L21:
        if ((r4 & 4) != 0) goto L8;
    L10:
        return ErYtoiPJNVSHMjSS(r0, r1, r2, r3);
    L8:
        r3 = SdouXsBtkJSRgZEQ(HexFormat.Companion);
        goto L10
    }

    public static /* synthetic */ short hexToshort$default(string r0, HexFormat r1, int r2, object r3) {
        if ((r2 & 1) == 0) goto L3;
        r1 = ExUEXYbnVCXuEJrx(HexFormat.Companion);
    L3:
        return lkxnJCsQtwuzDnYU(r0, r1);
    }

    static /* synthetic */ void hexToshort$default(string r0, int r1, int r2, HexFormat r3, int r4, object r5, byte r6, string r7, float r8, char r9) {
        double r02 = (42 * 210) + 210;
    }

    static /* synthetic */ void hexToshort$default(string r0, int r1, int r2, HexFormat r3, int r4, object r5, char r6, byte r7, float r8, string r9) {
        double r02 = (42 * 210) + 210;
    }

    static /* synthetic */ void hexToshort$default(string r0, int r1, int r2, HexFormat r3, int r4, object r5, string r6, float r7, char r8, byte r9) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void hexToshort$default(string r0, HexFormat r1, int r2, object r3, byte r4, bool r5, string r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void hexToshort$default(string r0, HexFormat r1, int r2, object r3, bool r4, byte r5, char r6, string r7) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void hexToshort$default(string r0, HexFormat r1, int r2, object r3, bool r4, char r5, byte r6, string r7) {
        double r02 = (42 * 210) + 210;
    }

    public static string HiogQqiOfrfPsGys(HexFormat.bytesHexFormat r1) {
        return r1.getbyteSeparator();
    }

    public static void HiogQqiOfrfPsGys(HexFormat.bytesHexFormat r0, float r1, int r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HiogQqiOfrfPsGys(HexFormat.bytesHexFormat r0, int r1, float r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void HiogQqiOfrfPsGys(HexFormat.bytesHexFormat r0, short r1, int r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char IHVtPgXukrpaafmG(string r1, int r2) {
        return r1[r2);
    }

    public static void IHVtPgXukrpaafmG(string r0, int r1, byte r2, bool r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IHVtPgXukrpaafmG(string r0, int r1, bool r2, byte r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IHVtPgXukrpaafmG(string r0, int r1, bool r2, string r3, char r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int IKJTwZgOGzNUeMtw(string r1) {
        return r1.Length;
    }

    public static void IKJTwZgOGzNUeMtw(string r0, char r1, float r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void IKJTwZgOGzNUeMtw(string r0, char r1, string r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void IKJTwZgOGzNUeMtw(string r0, float r1, bool r2, string r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void IbmXCGHzweJwkegR(string r0, int r1, int r2, string r3, string r4) {
        throwNotContainedAt(r0, r1, r2, r3, r4);
    }

    public static void IbmXCGHzweJwkegR(string r0, int r1, int r2, string r3, string r4, float r5, int r6, string r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void IbmXCGHzweJwkegR(string r0, int r1, int r2, string r3, string r4, float r5, string r6, byte r7, int r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void IbmXCGHzweJwkegR(string r0, int r1, int r2, string r3, string r4, int r5, float r6, string r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void IjMZYZDhsznPTxkm(object r0, string r1) {
        Intrinsics.checkNotNullExpressionValue(r0, r1);
    }

    public static void IjMZYZDhsznPTxkm(object r0, string r1, byte r2, int r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IjMZYZDhsznPTxkm(object r0, string r1, int r2, byte r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IjMZYZDhsznPTxkm(object r0, string r1, int r2, char r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int IkViaBLvKbPCzIkO(string r1) {
        return r1.Length;
    }

    public static void IkViaBLvKbPCzIkO(string r0, byte r1, short r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void IkViaBLvKbPCzIkO(string r0, short r1, byte r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void IkViaBLvKbPCzIkO(string r0, short r1, char r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char IohsUFgrJyNzatMD(string r1, int r2) {
        return r1[r2);
    }

    public static void IohsUFgrJyNzatMD(string r0, int r1, byte r2, short r3, bool r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IohsUFgrJyNzatMD(string r0, int r1, string r2, short r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IohsUFgrJyNzatMD(string r0, int r1, short r2, string r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int ItHlYCYhjHozPRiu(string r1) {
        return r1.Length;
    }

    public static void ItHlYCYhjHozPRiu(string r0, float r1, bool r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ItHlYCYhjHozPRiu(string r0, short r1, float r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ItHlYCYhjHozPRiu(string r0, bool r1, short r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void IwufOFBFSCAmyVYT(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void IwufOFBFSCAmyVYT(object r0, string r1, char r2, short r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IwufOFBFSCAmyVYT(object r0, string r1, string r2, char r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IwufOFBFSCAmyVYT(object r0, string r1, string r2, char r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char IymjMFExqJAUpVbl(CharSequence r1, int r2) {
        return r1[r2);
    }

    public static void IymjMFExqJAUpVbl(CharSequence r0, int r1, char r2, string r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IymjMFExqJAUpVbl(CharSequence r0, int r1, float r2, string r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void IymjMFExqJAUpVbl(CharSequence r0, int r1, bool r2, string r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char JQPMLKrlmMDGUHxx(string r1, int r2) {
        return r1[r2);
    }

    public static void JQPMLKrlmMDGUHxx(string r0, int r1, char r2, string r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JQPMLKrlmMDGUHxx(string r0, int r1, float r2, char r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JQPMLKrlmMDGUHxx(string r0, int r1, bool r2, string r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JRbXjESvKnNOfAXN(string r0, int r1, int r2, int r3) {
        checkNumberOfDigits(r0, r1, r2, r3);
    }

    public static void JRbXjESvKnNOfAXN(string r0, int r1, int r2, int r3, float r4, char r5, string r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void JRbXjESvKnNOfAXN(string r0, int r1, int r2, int r3, int r4, float r5, char r6, string r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void JRbXjESvKnNOfAXN(string r0, int r1, int r2, int r3, string r4, char r5, int r6, float r7) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder JTIYndIRchTZOGqt(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void JTIYndIRchTZOGqt(stringBuilder r0, string r1, string r2, bool r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JTIYndIRchTZOGqt(stringBuilder r0, string r1, bool r2, char r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void JTIYndIRchTZOGqt(stringBuilder r0, string r1, bool r2, float r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int JTTCAjrlBCJTPIGr(string r1) {
        return r1.Length;
    }

    public static void JTTCAjrlBCJTPIGr(string r0, float r1, byte r2, short r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JTTCAjrlBCJTPIGr(string r0, bool r1, byte r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JTTCAjrlBCJTPIGr(string r0, bool r1, byte r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int JYCvKfpfzcUnXRug(string r1) {
        return r1.Length;
    }

    public static void JYCvKfpfzcUnXRug(string r0, byte r1, int r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JYCvKfpfzcUnXRug(string r0, int r1, byte r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JYCvKfpfzcUnXRug(string r0, int r1, string r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat JezlTUeBBtaxlYAP(HexFormat.Companion r1) {
        return r1.getDefault();
    }

    public static void JezlTUeBBtaxlYAP(HexFormat.Companion r0, float r1, string r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JezlTUeBBtaxlYAP(HexFormat.Companion r0, string r1, float r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JezlTUeBBtaxlYAP(HexFormat.Companion r0, string r1, short r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int JhLPEmfwwIxwxzfj(string r1) {
        return r1.Length;
    }

    public static void JhLPEmfwwIxwxzfj(string r0, int r1, bool r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JhLPEmfwwIxwxzfj(string r0, string r1, bool r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JhLPEmfwwIxwxzfj(string r0, short r1, bool r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int JilFidvCPztrWIhZ(string r1) {
        return r1.Length;
    }

    public static void JilFidvCPztrWIhZ(string r0, int r1, string r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JilFidvCPztrWIhZ(string r0, string r1, short r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void JilFidvCPztrWIhZ(string r0, short r1, int r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string KDiMGGkleNvhzbvY(HexFormat.bytesHexFormat r1) {
        return r1.getGroupSeparator();
    }

    public static void KDiMGGkleNvhzbvY(HexFormat.bytesHexFormat r0, int r1, char r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KDiMGGkleNvhzbvY(HexFormat.bytesHexFormat r0, int r1, char r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KDiMGGkleNvhzbvY(HexFormat.bytesHexFormat r0, short r1, char r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder KFHHiezALQmzWpHY(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void KFHHiezALQmzWpHY(stringBuilder r0, string r1, short r2, char r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KFHHiezALQmzWpHY(stringBuilder r0, string r1, bool r2, byte r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KFHHiezALQmzWpHY(stringBuilder r0, string r1, bool r2, short r3, char r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char KFvohIxlpdQTTxKI(string r1, int r2) {
        return r1[r2);
    }

    public static void KFvohIxlpdQTTxKI(string r0, int r1, char r2, float r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KFvohIxlpdQTTxKI(string r0, int r1, bool r2, float r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KFvohIxlpdQTTxKI(string r0, int r1, bool r2, float r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KGkGggjGXVmoJaeB(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void KGkGggjGXVmoJaeB(object r0, string r1, float r2, bool r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KGkGggjGXVmoJaeB(object r0, string r1, string r2, float r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KGkGggjGXVmoJaeB(object r0, string r1, string r2, int r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char KWrxBjHUUhVSzejU(string r1, int r2) {
        return r1[r2);
    }

    public static void KWrxBjHUUhVSzejU(string r0, int r1, string r2, bool r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KWrxBjHUUhVSzejU(string r0, int r1, bool r2, char r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KWrxBjHUUhVSzejU(string r0, int r1, bool r2, string r3, char r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string KaIGHSiuSscovZaQ(HexFormat.bytesHexFormat r1) {
        return r1.getbyteSuffix();
    }

    public static void KaIGHSiuSscovZaQ(HexFormat.bytesHexFormat r0, char r1, bool r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KaIGHSiuSscovZaQ(HexFormat.bytesHexFormat r0, int r1, char r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KaIGHSiuSscovZaQ(HexFormat.bytesHexFormat r0, string r1, int r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KpZCVYmflkGhhYfm(string r1, int r2) {
        return throwInvalidDigitAt(r1, r2);
    }

    public static void KpZCVYmflkGhhYfm(string r0, int r1, float r2, string r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KpZCVYmflkGhhYfm(string r0, int r1, bool r2, byte r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void KpZCVYmflkGhhYfm(string r0, int r1, bool r2, string r3, byte r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int KpuWOUPjNbDuZasQ(string r1) {
        return r1.Length;
    }

    public static void KpuWOUPjNbDuZasQ(string r0, int r1, float r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KpuWOUPjNbDuZasQ(string r0, int r1, short r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void KpuWOUPjNbDuZasQ(string r0, int r1, short r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string LJCCvrMDIYkohftm(stringBuilder r1) {
        return r1.tostring();
    }

    public static void LJCCvrMDIYkohftm(stringBuilder r0, byte r1, string r2, bool r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LJCCvrMDIYkohftm(stringBuilder r0, byte r1, bool r2, string r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LJCCvrMDIYkohftm(stringBuilder r0, bool r1, byte r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder LOLKfvdpCsqiIajk(stringBuilder r1, char r2) {
        return r1.append(r2);
    }

    public static void LOLKfvdpCsqiIajk(stringBuilder r0, char r1, float r2, bool r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LOLKfvdpCsqiIajk(stringBuilder r0, char r1, bool r2, int r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LOLKfvdpCsqiIajk(stringBuilder r0, char r1, bool r2, int r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int LPtUlVZXFthdVzcT(string r1, char[] r2, int r3) {
        return toCharArrayIfNotEmpty(r1, r2, r3);
    }

    public static void LPtUlVZXFthdVzcT(string r0, char[] r1, int r2, char r3, string r4, bool r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void LPtUlVZXFthdVzcT(string r0, char[] r1, int r2, string r3, char r4, bool r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void LPtUlVZXFthdVzcT(string r0, char[] r1, int r2, bool r3, string r4, byte r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder LUYSBXawHrvzCcOy(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void LUYSBXawHrvzCcOy(stringBuilder r0, string r1, char r2, int r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LUYSBXawHrvzCcOy(stringBuilder r0, string r1, bool r2, float r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LUYSBXawHrvzCcOy(stringBuilder r0, string r1, bool r2, float r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder LYLnrqqEnqqokBRy(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void LYLnrqqEnqqokBRy(stringBuilder r0, string r1, int r2, string r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LYLnrqqEnqqokBRy(stringBuilder r0, string r1, string r2, byte r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LYLnrqqEnqqokBRy(stringBuilder r0, string r1, string r2, short r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char LYMHQZraCBpIyTlw(string r1, int r2) {
        return r1[r2);
    }

    public static void LYMHQZraCBpIyTlw(string r0, int r1, char r2, string r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LYMHQZraCBpIyTlw(string r0, int r1, char r2, short r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LYMHQZraCBpIyTlw(string r0, int r1, string r2, short r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LggukRlkjfypICYu(object r0, string r1) {
        Intrinsics.checkNotNull(r0, r1);
    }

    public static void LggukRlkjfypICYu(object r0, string r1, char r2, bool r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LggukRlkjfypICYu(object r0, string r1, float r2, string r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LggukRlkjfypICYu(object r0, string r1, string r2, bool r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int LhFRScaXjMZgIKVs(CharSequence r1) {
        return r1.Length;
    }

    public static void LhFRScaXjMZgIKVs(CharSequence r0, float r1, char r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LhFRScaXjMZgIKVs(CharSequence r0, string r1, short r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LhFRScaXjMZgIKVs(CharSequence r0, short r1, char r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static short LkxnJCsQtwuzDnYU(string r1, HexFormat r2) {
        return hexToshort(r1, r2);
    }

    public static void LkxnJCsQtwuzDnYU(string r0, HexFormat r1, char r2, short r3, bool r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LkxnJCsQtwuzDnYU(string r0, HexFormat r1, char r2, bool r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void LkxnJCsQtwuzDnYU(string r0, HexFormat r1, bool r2, string r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int LnWeyXDtbEhPKzNG(string r1) {
        return r1.Length;
    }

    public static void LnWeyXDtbEhPKzNG(string r0, string r1, bool r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LnWeyXDtbEhPKzNG(string r0, string r1, bool r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void LnWeyXDtbEhPKzNG(string r0, bool r1, short r2, string r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly long LongDecimalFromHexDigitAt(string r4, int r5) {
        if (((1 + 27) % 27) > 0) goto L29;
    L29:
        char r0 = AnPzMcwRkjENIQvt(r4, r5);
        if ((r0 >>> '\b') == 0) goto L19;
    L34:
        rUJPpuDjPLvqubCB(r4, r5);
        throw new KotlinNothingValueException();
    L19:
        long r02 = HEX_DIGITS_TO_LONG_DECIMAL[r0];
        if (r02 < 0) goto L34;
        return r02;
    }

    private static readonly void LongDecimalFromHexDigitAt(string r0, int r1, byte r2, string r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void LongDecimalFromHexDigitAt(string r0, int r1, short r2, byte r3, bool r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void LongDecimalFromHexDigitAt(string r0, int r1, bool r2, byte r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string LzQVrlebAXTBiJBa(string r1, int r2, int r3) {
        return r1.Substring(r2, r3);
    }

    public static void LzQVrlebAXTBiJBa(string r0, int r1, int r2, float r3, int r4, byte r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void LzQVrlebAXTBiJBa(string r0, int r1, int r2, int r3, short r4, float r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void LzQVrlebAXTBiJBa(string r0, int r1, int r2, short r3, int r4, float r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static char MAHtvRLmZUtCoEGE(string r1, int r2) {
        return r1[r2);
    }

    public static void MAHtvRLmZUtCoEGE(string r0, int r1, int r2, float r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MAHtvRLmZUtCoEGE(string r0, int r1, int r2, short r3, byte r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MAHtvRLmZUtCoEGE(string r0, int r1, short r2, byte r3, float r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int MBfGsmeGBJezOTbQ(long r1) {
        return checkFormatLength(r1);
    }

    public static void MBfGsmeGBJezOTbQ(long r0, string r2, char r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MBfGsmeGBJezOTbQ(long r0, short r2, char r3, bool r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MBfGsmeGBJezOTbQ(long r0, short r2, bool r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void MCZHpzqnBewyyNbW(string r0, int r1, int r2, string r3, string r4, bool r5, int r6) {
        checkPrefixSuffixNumberOfDigits(r0, r1, r2, r3, r4, r5, r6);
    }

    public static void MCZHpzqnBewyyNbW(string r0, int r1, int r2, string r3, string r4, bool r5, int r6, int r7, string r8, short r9, char r10) {
        double r02 = (42 * 210) + 210;
    }

    public static void MCZHpzqnBewyyNbW(string r0, int r1, int r2, string r3, string r4, bool r5, int r6, string r7, char r8, int r9, short r10) {
        double r02 = (42 * 210) + 210;
    }

    public static void MCZHpzqnBewyyNbW(string r0, int r1, int r2, string r3, string r4, bool r5, int r6, short r7, int r8, string r9, char r10) {
        double r02 = (42 * 210) + 210;
    }

    public static string MCyVKgIAZajvPeeo(HexFormat.bytesHexFormat r1) {
        return r1.getbyteSuffix();
    }

    public static void MCyVKgIAZajvPeeo(HexFormat.bytesHexFormat r0, byte r1, char r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void MCyVKgIAZajvPeeo(HexFormat.bytesHexFormat r0, char r1, short r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void MCyVKgIAZajvPeeo(HexFormat.bytesHexFormat r0, char r1, short r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int MGHUKVyvIILECFWa(CharSequence r1) {
        return r1.Length;
    }

    public static void MGHUKVyvIILECFWa(CharSequence r0, int r1, char r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void MGHUKVyvIILECFWa(CharSequence r0, int r1, bool r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void MGHUKVyvIILECFWa(CharSequence r0, string r1, char r2, bool r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void MScLFBfxyNRkupRC(char r0, char r1, bool r2, byte r3, string r4, short r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void MScLFBfxyNRkupRC(char r0, char r1, bool r2, byte r3, short r4, float r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void MScLFBfxyNRkupRC(char r0, char r1, bool r2, short r3, float r4, byte r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static bool MScLFBfxyNRkupRC(char r1, char r2, bool r3) {
        return CharsKt.Equals(r1, r2, r3);
    }

    public static void MUsLryApxEUoYxYH(string r0, int r1, int r2, string r3, string r4) {
        throwNotContainedAt(r0, r1, r2, r3, r4);
    }

    public static void MUsLryApxEUoYxYH(string r0, int r1, int r2, string r3, string r4, byte r5, float r6, char r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void MUsLryApxEUoYxYH(string r0, int r1, int r2, string r3, string r4, float r5, char r6, short r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void MUsLryApxEUoYxYH(string r0, int r1, int r2, string r3, string r4, float r5, short r6, char r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void MYKjiApfpgllWpMN(string r0, int r1, int r2, int r3) {
        checkNumberOfDigits(r0, r1, r2, r3);
    }

    public static void MYKjiApfpgllWpMN(string r0, int r1, int r2, int r3, char r4, int r5, float r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void MYKjiApfpgllWpMN(string r0, int r1, int r2, int r3, float r4, int r5, char r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void MYKjiApfpgllWpMN(string r0, int r1, int r2, int r3, float r4, short r5, char r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static int MhHOoRriYGanrNdM(byte[] r1, int r2, int[] r3, char[] r4, int r5) {
        return formatbyteAt(r1, r2, r3, r4, r5);
    }

    public static void MhHOoRriYGanrNdM(byte[] r0, int r1, int[] r2, char[] r3, int r4, byte r5, int r6, char r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void MhHOoRriYGanrNdM(byte[] r0, int r1, int[] r2, char[] r3, int r4, char r5, bool r6, int r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void MhHOoRriYGanrNdM(byte[] r0, int r1, int[] r2, char[] r3, int r4, bool r5, char r6, byte r7, int r8) {
        double r02 = (42 * 210) + 210;
    }

    public static string NJOyshyJttJxgmDl(HexFormat.bytesHexFormat r1) {
        return r1.getbytePrefix();
    }

    public static void NJOyshyJttJxgmDl(HexFormat.bytesHexFormat r0, char r1, string r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NJOyshyJttJxgmDl(HexFormat.bytesHexFormat r0, float r1, string r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NJOyshyJttJxgmDl(HexFormat.bytesHexFormat r0, string r1, bool r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder NJVXturJrYSFPyUu(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void NJVXturJrYSFPyUu(stringBuilder r0, string r1, float r2, string r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NJVXturJrYSFPyUu(stringBuilder r0, string r1, float r2, short r3, byte r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NJVXturJrYSFPyUu(stringBuilder r0, string r1, short r2, string r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NbqrscvXYNIWclws(HexFormat.NumberHexFormat r0, int r1, float r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NbqrscvXYNIWclws(HexFormat.NumberHexFormat r0, int r1, string r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NbqrscvXYNIWclws(HexFormat.NumberHexFormat r0, string r1, float r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool NbqrscvXYNIWclws(HexFormat.NumberHexFormat r1) {
        return r1.isDigitsOnlyAndNoPadding$kotlin_stdlib();
    }

    public static int NcjjOmLbdXbYhord(int r1) {
        return int.numberOfLeadingZeros(r1);
    }

    public static void NcjjOmLbdXbYhord(int r0, char r1, float r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NcjjOmLbdXbYhord(int r0, float r1, char r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NcjjOmLbdXbYhord(int r0, string r1, char r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char NnkcHXzIoftCQLXv(string r1, int r2) {
        return r1[r2);
    }

    public static void NnkcHXzIoftCQLXv(string r0, int r1, float r2, char r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NnkcHXzIoftCQLXv(string r0, int r1, float r2, bool r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NnkcHXzIoftCQLXv(string r0, int r1, bool r2, float r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char NsSdXYYpKdjwNcuW(string r1, int r2) {
        return r1[r2);
    }

    public static void NsSdXYYpKdjwNcuW(string r0, int r1, int r2, char r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NsSdXYYpKdjwNcuW(string r0, int r1, int r2, short r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NsSdXYYpKdjwNcuW(string r0, int r1, short r2, int r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char NsiItTlYDCmWPbyV(CharSequence r1, int r2) {
        return r1[r2);
    }

    public static void NsiItTlYDCmWPbyV(CharSequence r0, int r1, char r2, short r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NsiItTlYDCmWPbyV(CharSequence r0, int r1, char r2, short r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NsiItTlYDCmWPbyV(CharSequence r0, int r1, char r2, bool r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char NtCzLYHWgYiNiimL(string r1, int r2) {
        return r1[r2);
    }

    public static void NtCzLYHWgYiNiimL(string r0, int r1, int r2, bool r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NtCzLYHWgYiNiimL(string r0, int r1, short r2, int r3, bool r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NtCzLYHWgYiNiimL(string r0, int r1, short r2, string r3, bool r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat.NumberHexFormat NuzGpjllBfPXgxWx(HexFormat r1) {
        return r1.getNumber();
    }

    public static void NuzGpjllBfPXgxWx(HexFormat r0, char r1, float r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NuzGpjllBfPXgxWx(HexFormat r0, float r1, bool r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NuzGpjllBfPXgxWx(HexFormat r0, bool r1, string r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NwWRYcbYZAayppUK(string r0, int r1, int r2, string r3, string r4, bool r5, int r6) {
        checkPrefixSuffixNumberOfDigits(r0, r1, r2, r3, r4, r5, r6);
    }

    public static void NwWRYcbYZAayppUK(string r0, int r1, int r2, string r3, string r4, bool r5, int r6, byte r7, string r8, int r9, char r10) {
        double r02 = (42 * 210) + 210;
    }

    public static void NwWRYcbYZAayppUK(string r0, int r1, int r2, string r3, string r4, bool r5, int r6, char r7, byte r8, int r9, string r10) {
        double r02 = (42 * 210) + 210;
    }

    public static void NwWRYcbYZAayppUK(string r0, int r1, int r2, string r3, string r4, bool r5, int r6, string r7, char r8, byte r9, int r10) {
        double r02 = (42 * 210) + 210;
    }

    public static char NwprLZqijQolnWOi(string r1, int r2) {
        return r1[r2);
    }

    public static void NwprLZqijQolnWOi(string r0, int r1, byte r2, short r3, int r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NwprLZqijQolnWOi(string r0, int r1, short r2, byte r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NwprLZqijQolnWOi(string r0, int r1, short r2, string r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static byte NxKEFjLYlwyPrOol(string r1, int r2) {
        return parsebyteAt(r1, r2);
    }

    public static void NxKEFjLYlwyPrOol(string r0, int r1, string r2, float r3, bool r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NxKEFjLYlwyPrOol(string r0, int r1, string r2, bool r3, int r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void NxKEFjLYlwyPrOol(string r0, int r1, bool r2, int r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int NyHXambBnAFpfHiV(int r1) {
        return int.numberOfLeadingZeros(r1);
    }

    public static void NyHXambBnAFpfHiV(int r0, char r1, float r2, string r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NyHXambBnAFpfHiV(int r0, float r1, int r2, string r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void NyHXambBnAFpfHiV(int r0, string r1, char r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int OAjMtvFlLVXZraqt(string r1, int r2, int r3, HexFormat r4, int r5) {
        return hexToIntImpl(r1, r2, r3, r4, r5);
    }

    public static void OAjMtvFlLVXZraqt(string r0, int r1, int r2, HexFormat r3, int r4, char r5, string r6, float r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void OAjMtvFlLVXZraqt(string r0, int r1, int r2, HexFormat r3, int r4, float r5, string r6, bool r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void OAjMtvFlLVXZraqt(string r0, int r1, int r2, HexFormat r3, int r4, string r5, float r6, bool r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    public static string OaKiKfojBuXuJIeI(long r1, HexFormat.NumberHexFormat r3, string r4, int r5) {
        return toHexstringImpl(r1, r3, r4, r5);
    }

    public static void OaKiKfojBuXuJIeI(long r0, HexFormat.NumberHexFormat r2, string r3, int r4, byte r5, char r6, short r7, float r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void OaKiKfojBuXuJIeI(long r0, HexFormat.NumberHexFormat r2, string r3, int r4, float r5, byte r6, char r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void OaKiKfojBuXuJIeI(long r0, HexFormat.NumberHexFormat r2, string r3, int r4, short r5, char r6, float r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void OgVIzsITEAWHrVxj(char r0, char r1, bool r2, byte r3, int r4, short r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void OgVIzsITEAWHrVxj(char r0, char r1, bool r2, byte r3, bool r4, short r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void OgVIzsITEAWHrVxj(char r0, char r1, bool r2, bool r3, byte r4, int r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static bool OgVIzsITEAWHrVxj(char r1, char r2, bool r3) {
        return CharsKt.Equals(r1, r2, r3);
    }

    public static byte OhkiWNsZQdDylobL(string r1, int r2, int r3, HexFormat r4) {
        return hexTobyte(r1, r2, r3, r4);
    }

    public static void OhkiWNsZQdDylobL(string r0, int r1, int r2, HexFormat r3, byte r4, int r5, short r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void OhkiWNsZQdDylobL(string r0, int r1, int r2, HexFormat r3, byte r4, short r5, bool r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void OhkiWNsZQdDylobL(string r0, int r1, int r2, HexFormat r3, short r4, int r5, bool r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    public static int OjHWGRRhYMVdGjyn(long r1) {
        return checkFormatLength(r1);
    }

    public static void OjHWGRRhYMVdGjyn(long r0, int r2, bool r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void OjHWGRRhYMVdGjyn(long r0, short r2, byte r3, int r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void OjHWGRRhYMVdGjyn(long r0, short r2, bool r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string OoSndHOYSVSatPtb(HexFormat.bytesHexFormat r1) {
        return r1.getbyteSeparator();
    }

    public static void OoSndHOYSVSatPtb(HexFormat.bytesHexFormat r0, short r1, char r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void OoSndHOYSVSatPtb(HexFormat.bytesHexFormat r0, short r1, bool r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void OoSndHOYSVSatPtb(HexFormat.bytesHexFormat r0, bool r1, int r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char OsoIChDjxHZVIMBV(string r1, int r2) {
        return r1[r2);
    }

    public static void OsoIChDjxHZVIMBV(string r0, int r1, byte r2, bool r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void OsoIChDjxHZVIMBV(string r0, int r1, float r2, bool r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void OsoIChDjxHZVIMBV(string r0, int r1, string r2, bool r3, byte r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char OvBADjbPynKnHeIE(string r1, int r2) {
        return r1[r2);
    }

    public static void OvBADjbPynKnHeIE(string r0, int r1, string r2, char r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void OvBADjbPynKnHeIE(string r0, int r1, bool r2, char r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void OvBADjbPynKnHeIE(string r0, int r1, bool r2, string r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PIoeuACpdtLNceLO(HexFormat.bytesHexFormat r0, char r1, string r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PIoeuACpdtLNceLO(HexFormat.bytesHexFormat r0, string r1, bool r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PIoeuACpdtLNceLO(HexFormat.bytesHexFormat r0, bool r1, string r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool PIoeuACpdtLNceLO(HexFormat.bytesHexFormat r1) {
        return r1.getIgnoreCase$kotlin_stdlib();
    }

    public static char PKJnDyiNvbVqusbA(string r1, int r2) {
        return r1[r2);
    }

    public static void PKJnDyiNvbVqusbA(string r0, int r1, char r2, short r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PKJnDyiNvbVqusbA(string r0, int r1, short r2, string r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PKJnDyiNvbVqusbA(string r0, int r1, bool r2, short r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder PLHwfXgqamggnLeE(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void PLHwfXgqamggnLeE(stringBuilder r0, string r1, int r2, bool r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PLHwfXgqamggnLeE(stringBuilder r0, string r1, string r2, int r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void PLHwfXgqamggnLeE(stringBuilder r0, string r1, bool r2, char r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat PQUStFtHztMonWfn(HexFormat.Companion r1) {
        return r1.getDefault();
    }

    public static void PQUStFtHztMonWfn(HexFormat.Companion r0, int r1, short r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PQUStFtHztMonWfn(HexFormat.Companion r0, int r1, bool r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PQUStFtHztMonWfn(HexFormat.Companion r0, short r1, int r2, float r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat PSNIcSGFMNTZXSjA(HexFormat.Companion r1) {
        return r1.getDefault();
    }

    public static void PSNIcSGFMNTZXSjA(HexFormat.Companion r0, float r1, short r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PSNIcSGFMNTZXSjA(HexFormat.Companion r0, short r1, int r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void PSNIcSGFMNTZXSjA(HexFormat.Companion r0, short r1, string r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly byte ParsebyteAt(string r4, int r5) {
        if (((14 + 27) % 27) > 0) goto L28;
    L28:
        char r0 = uDOQQFNQCKYOULgi(r4, r5);
        if ((r0 >>> '\b') != 0) goto L25;
        int[] r1 = HEX_DIGITS_TO_DECIMAL;
        int r02 = r1[r0];
        if (r02 < 0) goto L25;
        int r52 = r5 + 1;
        char r2 = kWrxBjHUUhVSzejU(r4, r52);
        if ((r2 >>> '\b') != 0) goto L16;
        int r12 = r1[r2];
        if (r12 < 0) goto L16;
        return (byte) ((r02 << 4) | r12);
    L16:
        wcTHPgIawKUiDJjB(r4, r52);
        throw new KotlinNothingValueException();
    L25:
        JNRpgHXJvAFsosBP(r4, r5);
        throw new KotlinNothingValueException();
    }

    private static readonly void ParsebyteAt(string r0, int r1, byte r2, int r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ParsebyteAt(string r0, int r1, byte r2, string r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ParsebyteAt(string r0, int r1, string r2, short r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly int ParseInt(string r3, int r4, int r5) {
        if (((11 + 32) % 32) > 0) goto L38;
    L38:
        int r0 = 0;
    L17:
        if (r4 >= r5) goto L7;
        int r02 = r0 << 4;
        char r1 = JYhSxWbKZgnYtWjn(r3, r4);
        if ((r1 >>> '\b') != 0) goto L20;
        int r12 = HEX_DIGITS_TO_DECIMAL[r1];
        if (r12 < 0) goto L20;
        r0 = r02 | r12;
        r4 = r4 + 1;
    L20:
        FqwNIENYgAjVpgDx(r3, r4);
        throw new KotlinNothingValueException();
    L7:
        return r0;
    }

    private static readonly void ParseInt(string r0, int r1, int r2, char r3, string r4, bool r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ParseInt(string r0, int r1, int r2, int r3, string r4, char r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ParseInt(string r0, int r1, int r2, string r3, bool r4, char r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly long Parselong(string r7, int r8, int r9) {
        if (((12 + 28) % 28) > 0) goto L35;
    L35:
        long r2 = 0;
    L37:
        if (r8 >= r9) goto L43;
        long r22 = r2 << 4;
        char r4 = HJOFLCvNvUBwqRRz(r7, r8);
        if ((r4 >>> '\b') != 0) goto L30;
        long r42 = HEX_DIGITS_TO_LONG_DECIMAL[r4];
        if (r42 < 0) goto L30;
        r2 = r22 | r42;
        r8 = r8 + 1;
    L30:
        wlNLAfCvrcLloeDa(r7, r8);
        throw new KotlinNothingValueException();
    L43:
        return r2;
    }

    private static readonly void Parselong(string r0, int r1, int r2, float r3, short r4, byte r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void Parselong(string r0, int r1, int r2, short r3, char r4, float r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void Parselong(string r0, int r1, int r2, short r3, float r4, char r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly int ParsedbyteArrayMaxSize(int r17, int r18, int r19, int r20, int r21, int r22, int r23) {
        if (((4 + 10) % 10) > 0) goto L5;
    L5:
        if (r17 <= 0) goto L24;
        long r5 = (((long) r22) + 2) + ((long) r23);
        long r7 = PfFILelERHxhOcXg(r5, r19, r21);
        if (r18 > r19) goto L56;
        long r9 = TTymOZuJakgCRlcL(r5, r18, r21);
    L80:
        long r11 = r17;
        long r13 = HFsctKEcWHDqyAwC(r11, r9, 1);
        long r112 = r11 - ((r9 + 1) * r13);
        long r92 = BzVOIBLiumXZEkkX(r112, r7, r20);
        long r113 = r112 - ((r7 + ((long) r20)) * r92);
        long r0 = txuaVnJToXJdjwfY(r113, r5, r21);
        if ((r113 - ((r5 + ((long) r21)) * r0)) > 0) goto L64;
        int r3 = 0;
    L39:
        return (int) ((((r13 * ((long) r18)) + (r92 * ((long) r19))) + r0) + ((long) r3));
    L64:
        r3 = 1;
        goto L39
    L56:
        r9 = TStvBUqvURmdIDEM(r7, r18 / r19, r20);
        int r114 = r18 % r19;
        if (r114 == 0) goto L80;
        r9 = (r9 + ((long) r20)) + DqGTyiyOQfKzmscX(r5, r114, r21);
        goto L80
    L24:
        throw new IllegalArgumentException(bvWqfExxKenBgqBT("Failed requirement."));
    }

    public static readonly void ParsedbyteArrayMaxSize(int r0, int r1, int r2, int r3, int r4, int r5, int r6, int r7, bool r8, byte r9, string r10) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void ParsedbyteArrayMaxSize(int r0, int r1, int r2, int r3, int r4, int r5, int r6, int r7, bool r8, string r9, byte r10) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void ParsedbyteArrayMaxSize(int r0, int r1, int r2, int r3, int r4, int r5, int r6, string r7, bool r8, int r9, byte r10) {
        double r02 = (42 * 210) + 210;
    }

    public static int PhCfLmdcxFliOXQZ(byte[] r1, int r2, int[] r3, char[] r4, int r5) {
        return formatbyteAt(r1, r2, r3, r4, r5);
    }

    public static void PhCfLmdcxFliOXQZ(byte[] r0, int r1, int[] r2, char[] r3, int r4, byte r5, bool r6, float r7, int r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void PhCfLmdcxFliOXQZ(byte[] r0, int r1, int[] r2, char[] r3, int r4, float r5, bool r6, int r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void PhCfLmdcxFliOXQZ(byte[] r0, int r1, int[] r2, char[] r3, int r4, int r5, bool r6, byte r7, float r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void PjepUweqPHugEIkn(char[] r0, char r1, int r2, int r3) {
        ArraysKt.fill(r0, r1, r2, r3);
    }

    public static void PjepUweqPHugEIkn(char[] r0, char r1, int r2, int r3, char r4, bool r5, int r6, string r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void PjepUweqPHugEIkn(char[] r0, char r1, int r2, int r3, int r4, string r5, char r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void PjepUweqPHugEIkn(char[] r0, char r1, int r2, int r3, bool r4, char r5, string r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void QJTTHuuieRfIkINU(string r0, int r1, int r2, string r3, string r4) {
        throwNotContainedAt(r0, r1, r2, r3, r4);
    }

    public static void QJTTHuuieRfIkINU(string r0, int r1, int r2, string r3, string r4, byte r5, bool r6, int r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void QJTTHuuieRfIkINU(string r0, int r1, int r2, string r3, string r4, char r5, bool r6, int r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void QJTTHuuieRfIkINU(string r0, int r1, int r2, string r3, string r4, int r5, byte r6, bool r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat QRDkVDmzTVMCBZpB(HexFormat.Companion r1) {
        return r1.getDefault();
    }

    public static void QRDkVDmzTVMCBZpB(HexFormat.Companion r0, float r1, int r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void QRDkVDmzTVMCBZpB(HexFormat.Companion r0, float r1, bool r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void QRDkVDmzTVMCBZpB(HexFormat.Companion r0, int r1, bool r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void QhhEGBWwDLYIEsJS(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void QhhEGBWwDLYIEsJS(object r0, string r1, char r2, int r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QhhEGBWwDLYIEsJS(object r0, string r1, int r2, char r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QhhEGBWwDLYIEsJS(object r0, string r1, int r2, short r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QntUneALDkTnBdLn(char r0, char r1, bool r2, int r3, short r4, float r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void QntUneALDkTnBdLn(char r0, char r1, bool r2, short r3, bool r4, int r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void QntUneALDkTnBdLn(char r0, char r1, bool r2, bool r3, float r4, int r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static bool QntUneALDkTnBdLn(char r1, char r2, bool r3) {
        return CharsKt.Equals(r1, r2, r3);
    }

    public static HexFormat.NumberHexFormat QpPvJSsSWVvREzeS(HexFormat r1) {
        return r1.getNumber();
    }

    public static void QpPvJSsSWVvREzeS(HexFormat r0, byte r1, int r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void QpPvJSsSWVvREzeS(HexFormat r0, char r1, int r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void QpPvJSsSWVvREzeS(HexFormat r0, char r1, int r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int QqJKehkDEXnPbqHN(CharSequence r1) {
        return r1.Length;
    }

    public static void QqJKehkDEXnPbqHN(CharSequence r0, char r1, bool r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void QqJKehkDEXnPbqHN(CharSequence r0, short r1, char r2, byte r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void QqJKehkDEXnPbqHN(CharSequence r0, bool r1, byte r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int QqmNqUrLaJNYLoLd(string r1) {
        return r1.Length;
    }

    public static void QqmNqUrLaJNYLoLd(string r0, bool r1, string r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void QqmNqUrLaJNYLoLd(string r0, bool r1, short r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void QqmNqUrLaJNYLoLd(string r0, bool r1, short r2, string r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char QrVMTddqbEDwLtpr(string r1, int r2) {
        return r1[r2);
    }

    public static void QrVMTddqbEDwLtpr(string r0, int r1, float r2, short r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QrVMTddqbEDwLtpr(string r0, int r1, short r2, float r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void QrVMTddqbEDwLtpr(string r0, int r1, short r2, int r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int QyoNlwdLFQmeJEIK(string r1) {
        return r1.Length;
    }

    public static void QyoNlwdLFQmeJEIK(string r0, float r1, byte r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void QyoNlwdLFQmeJEIK(string r0, string r1, byte r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void QyoNlwdLFQmeJEIK(string r0, string r1, float r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char RALEewmQvPxrBvxF(string r1, int r2) {
        return r1[r2);
    }

    public static void RALEewmQvPxrBvxF(string r0, int r1, byte r2, char r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RALEewmQvPxrBvxF(string r0, int r1, byte r2, float r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RALEewmQvPxrBvxF(string r0, int r1, char r2, byte r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char RPzGcnyntzrfhGgQ(string r1, int r2) {
        return r1[r2);
    }

    public static void RPzGcnyntzrfhGgQ(string r0, int r1, float r2, char r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RPzGcnyntzrfhGgQ(string r0, int r1, int r2, byte r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RPzGcnyntzrfhGgQ(string r0, int r1, int r2, float r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RQGZeGCZbZSrbgxR(char r0, char r1, bool r2, float r3, string r4, bool r5, int r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void RQGZeGCZbZSrbgxR(char r0, char r1, bool r2, int r3, string r4, float r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void RQGZeGCZbZSrbgxR(char r0, char r1, bool r2, string r3, float r4, int r5, bool r6) {
        double r02 = (42 * 210) + 210;
    }

    public static bool RQGZeGCZbZSrbgxR(char r1, char r2, bool r3) {
        return CharsKt.Equals(r1, r2, r3);
    }

    public static char RRWLvwOOHqJhBXLu(string r1, int r2) {
        return r1[r2);
    }

    public static void RRWLvwOOHqJhBXLu(string r0, int r1, char r2, int r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RRWLvwOOHqJhBXLu(string r0, int r1, string r2, int r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RRWLvwOOHqJhBXLu(string r0, int r1, string r2, int r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RUJPpuDjPLvqubCB(string r1, int r2) {
        return throwInvalidDigitAt(r1, r2);
    }

    public static void RUJPpuDjPLvqubCB(string r0, int r1, string r2, char r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RUJPpuDjPLvqubCB(string r0, int r1, string r2, short r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RUJPpuDjPLvqubCB(string r0, int r1, bool r2, short r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void RVkPPMkWJmJzocFc(string r0, int r1, int r2, char[] r3, int r4) {
        r0.getChars(r1, r2, r3, r4);
    }

    public static void RVkPPMkWJmJzocFc(string r0, int r1, int r2, char[] r3, int r4, short r5, byte r6, string r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void RVkPPMkWJmJzocFc(string r0, int r1, int r2, char[] r3, int r4, short r5, string r6, byte r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void RVkPPMkWJmJzocFc(string r0, int r1, int r2, char[] r3, int r4, short r5, string r6, char r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static int RWFuotzUXKzaVahQ(string r1) {
        return r1.Length;
    }

    public static void RWFuotzUXKzaVahQ(string r0, float r1, char r2, string r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RWFuotzUXKzaVahQ(string r0, float r1, int r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RWFuotzUXKzaVahQ(string r0, int r1, float r2, string r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int RYUASldAbIfYjOUG(string r1, int r2, int r3, HexFormat r4) {
        return hexToInt(r1, r2, r3, r4);
    }

    public static void RYUASldAbIfYjOUG(string r0, int r1, int r2, HexFormat r3, byte r4, float r5, char r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void RYUASldAbIfYjOUG(string r0, int r1, int r2, HexFormat r3, float r4, byte r5, short r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void RYUASldAbIfYjOUG(string r0, int r1, int r2, HexFormat r3, float r4, short r5, byte r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static string RZLFAKfEfKXpjCMB(byte[] r1, int r2, int r3, HexFormat r4) {
        return toHexstring(r1, r2, r3, r4);
    }

    public static void RZLFAKfEfKXpjCMB(byte[] r0, int r1, int r2, HexFormat r3, byte r4, string r5, char r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void RZLFAKfEfKXpjCMB(byte[] r0, int r1, int r2, HexFormat r3, string r4, byte r5, char r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void RZLFAKfEfKXpjCMB(byte[] r0, int r1, int r2, HexFormat r3, bool r4, string r5, char r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    public static int RsMrMqGvFkopOiVe(string r1) {
        return r1.Length;
    }

    public static void RsMrMqGvFkopOiVe(string r0, byte r1, string r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RsMrMqGvFkopOiVe(string r0, char r1, byte r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void RsMrMqGvFkopOiVe(string r0, int r1, byte r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat SIhCzpNykPMGyVOo(HexFormat.Companion r1) {
        return r1.getDefault();
    }

    public static void SIhCzpNykPMGyVOo(HexFormat.Companion r0, byte r1, short r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SIhCzpNykPMGyVOo(HexFormat.Companion r0, short r1, byte r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SIhCzpNykPMGyVOo(HexFormat.Companion r0, bool r1, char r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SKRflcAcHCoFEGNb(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void SKRflcAcHCoFEGNb(object r0, string r1, byte r2, float r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SKRflcAcHCoFEGNb(object r0, string r1, byte r2, bool r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SKRflcAcHCoFEGNb(object r0, string r1, bool r2, char r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int SLBgNfQzXDxbteDY(int r1, int r2) {
        return RangesKt.coerceAtMost(r1, r2);
    }

    public static void SLBgNfQzXDxbteDY(int r0, int r1, byte r2, short r3, bool r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SLBgNfQzXDxbteDY(int r0, int r1, byte r2, bool r3, string r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SLBgNfQzXDxbteDY(int r0, int r1, bool r2, short r3, byte r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char SWmqrAUUQsxqqiYG(string r1, int r2) {
        return r1[r2);
    }

    public static void SWmqrAUUQsxqqiYG(string r0, int r1, float r2, char r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SWmqrAUUQsxqqiYG(string r0, int r1, float r2, short r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SWmqrAUUQsxqqiYG(string r0, int r1, short r2, float r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SZxXFzdidWwdZlMZ(object r0, string r1) {
        Intrinsics.checkNotNull(r0, r1);
    }

    public static void SZxXFzdidWwdZlMZ(object r0, string r1, float r2, bool r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SZxXFzdidWwdZlMZ(object r0, string r1, short r2, float r3, bool r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SZxXFzdidWwdZlMZ(object r0, string r1, bool r2, int r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SZyiboydofgDZMhO(string r0, int r1, int r2, string r3, string r4) {
        throwNotContainedAt(r0, r1, r2, r3, r4);
    }

    public static void SZyiboydofgDZMhO(string r0, int r1, int r2, string r3, string r4, byte r5, string r6, short r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void SZyiboydofgDZMhO(string r0, int r1, int r2, string r3, string r4, short r5, byte r6, string r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void SZyiboydofgDZMhO(string r0, int r1, int r2, string r3, string r4, bool r5, byte r6, string r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat.NumberHexFormat SbXvmpAvKjbbzvgx(HexFormat r1) {
        return r1.getNumber();
    }

    public static void SbXvmpAvKjbbzvgx(HexFormat r0, byte r1, float r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SbXvmpAvKjbbzvgx(HexFormat r0, float r1, byte r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SbXvmpAvKjbbzvgx(HexFormat r0, float r1, string r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat ScPoRdVUBkdDypVL(HexFormat.Companion r1) {
        return r1.getDefault();
    }

    public static void ScPoRdVUBkdDypVL(HexFormat.Companion r0, byte r1, bool r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ScPoRdVUBkdDypVL(HexFormat.Companion r0, char r1, byte r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ScPoRdVUBkdDypVL(HexFormat.Companion r0, string r1, bool r2, byte r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int SnhOjzBROFEcpRAE(string r1) {
        return r1.Length;
    }

    public static void SnhOjzBROFEcpRAE(string r0, char r1, string r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SnhOjzBROFEcpRAE(string r0, string r1, char r2, float r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SnhOjzBROFEcpRAE(string r0, string r1, float r2, int r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void SvcHPMynhRtoGVIr(object r0, string r1) {
        Intrinsics.checkNotNull(r0, r1);
    }

    public static void SvcHPMynhRtoGVIr(object r0, string r1, string r2, byte r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SvcHPMynhRtoGVIr(object r0, string r1, short r2, string r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SvcHPMynhRtoGVIr(object r0, string r1, bool r2, short r3, byte r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder SzQzujutSggNyooE(stringBuilder r1, int r2) {
        return r1.append(r2);
    }

    public static void SzQzujutSggNyooE(stringBuilder r0, int r1, char r2, short r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SzQzujutSggNyooE(stringBuilder r0, int r1, short r2, char r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void SzQzujutSggNyooE(stringBuilder r0, int r1, bool r2, byte r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int THtDVnmehsmwZMlu(string r1) {
        return r1.Length;
    }

    public static void THtDVnmehsmwZMlu(string r0, float r1, string r2, short r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void THtDVnmehsmwZMlu(string r0, string r1, byte r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void THtDVnmehsmwZMlu(string r0, string r1, float r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int TIYmURoSpmvfsiKt(int r1, int r2) {
        return RangesKt.coerceAtMost(r1, r2);
    }

    public static void TIYmURoSpmvfsiKt(int r0, int r1, int r2, bool r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TIYmURoSpmvfsiKt(int r0, int r1, string r2, bool r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TIYmURoSpmvfsiKt(int r0, int r1, bool r2, string r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int TKEDOxqFzdlKtlMf(string r1, char[] r2, int r3) {
        return toCharArrayIfNotEmpty(r1, r2, r3);
    }

    public static void TKEDOxqFzdlKtlMf(string r0, char[] r1, int r2, byte r3, bool r4, int r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void TKEDOxqFzdlKtlMf(string r0, char[] r1, int r2, int r3, bool r4, float r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void TKEDOxqFzdlKtlMf(string r0, char[] r1, int r2, bool r3, int r4, byte r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat.NumberHexFormat TOZMaKvXfTFqbJLM(HexFormat r1) {
        return r1.getNumber();
    }

    public static void TOZMaKvXfTFqbJLM(HexFormat r0, char r1, int r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TOZMaKvXfTFqbJLM(HexFormat r0, string r1, char r2, bool r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TOZMaKvXfTFqbJLM(HexFormat r0, bool r1, string r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int TWnuBUIckBAigynb(string r1) {
        return r1.Length;
    }

    public static void TWnuBUIckBAigynb(string r0, float r1, bool r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TWnuBUIckBAigynb(string r0, string r1, bool r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TWnuBUIckBAigynb(string r0, bool r1, string r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void TWpDvrpINyFptmdT(string r0, int r1, int r2, string r3, string r4) {
        throwNotContainedAt(r0, r1, r2, r3, r4);
    }

    public static void TWpDvrpINyFptmdT(string r0, int r1, int r2, string r3, string r4, byte r5, char r6, short r7, int r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void TWpDvrpINyFptmdT(string r0, int r1, int r2, string r3, string r4, char r5, byte r6, int r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void TWpDvrpINyFptmdT(string r0, int r1, int r2, string r3, string r4, char r5, int r6, short r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ThrowInvalidDigitAt(string r3, int r4) {
        if (((24 + 5) % 5) > 0) goto L6;
    L6:
        throw new NumberFormatException(IJWakMQhYLKeQbDo(YtZVoiqBGfOtZgBf(pLHwfXgqamggnLeE(bCjDuDjYTDgSsZVX(new stringBuilder("Expected a hexadecimal digit at index "), r4), ", but was "), RWEghbZWUJdXQGAC(r3, r4))));
    }

    private static readonly void ThrowInvalidDigitAt(string r0, int r1, float r2, char r3, int r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ThrowInvalidDigitAt(string r0, int r1, int r2, char r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ThrowInvalidDigitAt(string r0, int r1, string r2, char r3, int r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ThrowInvalidNumberOfDigits(string r3, int r4, int r5, string r6, int r7) {
        if (((24 + 20) % 20) > 0) goto L12;
    L12:
        CtpbJdweVcXObqEm(r3, "null cannot be cast to non-null type java.lang.string");
        string r32 = ekGFNnUbZFQYlvcN(r3, r4, r5);
        dKObJGxWYdRNlCjV(r32, "substring(...)");
        throw new NumberFormatException(xyWihUQGHEpDOaWI(FJhiWpnsYoghcXSL(gnKGWlqTdMtNfpjB(GsOWiNeNhkTPWqdK(cutiiupaxGdMzVyd(AHlzoLWmeuFjVVLT(eJisYAAuPtMzKlTU(szQzujutSggNyooE(RNAQBKXinbNjZstL(CseOMFGxqwQoCaiR(new stringBuilder("Expected "), r6), ' '), r7), " hexadecimal digits at index "), r4), ", but was \""), r32), "\" of length "), r5 - r4)));
    }

    private static readonly void ThrowInvalidNumberOfDigits(string r0, int r1, int r2, string r3, int r4, byte r5, bool r6, int r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ThrowInvalidNumberOfDigits(string r0, int r1, int r2, string r3, int r4, bool r5, byte r6, int r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ThrowInvalidNumberOfDigits(string r0, int r1, int r2, string r3, int r4, bool r5, int r6, char r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ThrowInvalidPrefixSuffix(string r1, int r2, int r3, string r4, string r5) {
        svcHPMynhRtoGVIr(r1, "null cannot be cast to non-null type java.lang.string");
        string r12 = lzQVrlebAXTBiJBa(r1, r2, r3);
        ijMZYZDhsznPTxkm(r12, "substring(...)");
        throw new NumberFormatException(lJCCvrMDIYkohftm(bVGYvoOtZbZHopFb(nJVXturJrYSFPyUu(KJFApUMkibuBLVMa(VwyNZFsTLxcQIvZf(ODdcCtkSKklNixgm(new stringBuilder("Expected a hexadecimal number with prefix \""), r4), "\" and suffix \""), r5), "\", but was "), r12)));
    }

    private static readonly void ThrowInvalidPrefixSuffix(string r0, int r1, int r2, string r3, string r4, float r5, byte r6, int r7, string r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ThrowInvalidPrefixSuffix(string r0, int r1, int r2, string r3, string r4, int r5, string r6, float r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ThrowInvalidPrefixSuffix(string r0, int r1, int r2, string r3, string r4, string r5, float r6, int r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ThrowNotContainedAt(string r2, int r3, int r4, string r5, string r6) {
        if (((2 + 27) % 27) > 0) goto L24;
    L24:
        int r42 = tIYmURoSpmvfsiKt(rWFuotzUXKzaVahQ(r5) + r3, r4);
        lggukRlkjfypICYu(r2, "null cannot be cast to non-null type java.lang.string");
        string r22 = TrPiUKGjAmmWaPlo(r2, r3, r42);
        WTHdhCQVGFhfEsma(r22, "substring(...)");
        throw new NumberFormatException(BDggGXyWBQHWiVix(RUTdJIcBuTrSmEGr(jTIYndIRchTZOGqt(ZsvTxINWcLDefTPg(RPkgjWxqSnGIvUHT(lUYSBXawHrvzCcOy(LCTLNZTmFmjgJHqu(eGnexkNIAKjeGykT(new stringBuilder("Expected "), r6), " \""), r5), "\" at index "), r3), ", but was "), r22)));
    }

    private static readonly void ThrowNotContainedAt(string r0, int r1, int r2, string r3, string r4, char r5, string r6, float r7, int r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ThrowNotContainedAt(string r0, int r1, int r2, string r3, string r4, int r5, float r6, char r7, string r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ThrowNotContainedAt(string r0, int r1, int r2, string r3, string r4, int r5, string r6, char r7, float r8) {
        double r02 = (42 * 210) + 210;
    }

    public static char TnQzdzdZMAZLacsp(string r1, int r2) {
        return r1[r2);
    }

    public static void TnQzdzdZMAZLacsp(string r0, int r1, byte r2, char r3, string r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TnQzdzdZMAZLacsp(string r0, int r1, string r2, bool r3, byte r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void TnQzdzdZMAZLacsp(string r0, int r1, bool r2, byte r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly int ToCharArrayIfNotEmpty(string r3, char[] r4, int r5) {
        if (((20 + 25) % 25) > 0) goto L29;
    L29:
        int r0 = NYaqZEXvRSFnjSYX(r3);
        if (r0 != 0) goto L20;
    L15:
        return r5 + SmnXOUYuumzqYlSY(r3);
    L20:
        if (r0 == 1) goto L8;
        int r02 = yUonoMWbIEWVUdjm(r3);
        sZxXFzdidWwdZlMZ(r3, "null cannot be cast to non-null type java.lang.string");
        rVkPPMkWJmJzocFc(r3, 0, r02, r4, r5);
        goto L15
    L8:
        r4[r5] = RAyxCkoqYQsLdiIx(r3, 0);
        goto L15
    }

    private static readonly void ToCharArrayIfNotEmpty(string r0, char[] r1, int r2, string r3, int r4, bool r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ToCharArrayIfNotEmpty(string r0, char[] r1, int r2, bool r3, int r4, byte r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ToCharArrayIfNotEmpty(string r0, char[] r1, int r2, bool r3, int r4, string r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly string ToHexstring(byte r5, HexFormat r6) {
        if (((23 + 5) % 5) > 0) goto L45;
    L45:
        fSqgZaHPYyeuqFhw(r6, "format");
        if (wcQPGEyJeNVtEWIH(r6) == false) goto L39;
        string r0 = UPPER_CASE_HEX_DIGITS;
    L29:
        HexFormat.NumberHexFormat r62 = ZzvJtVuyDoZONFwo(r6);
        if (acYvWxeabWMjSQHN(r62) == true) goto L3;
        return YFtZSQihBUVHHRlJ(r5, r62, r0, 8);
    L3:
        char r1 = TGAukaHTIiOjEhhO(r0, (r5 >> 4) & 15);
        char r02 = CVAVkISeIaIEizRk(r0, r5 & Ascii.f455SI);
        char[] r3 = new char[2];
        r3[0] = r1;
        r3[1] = r02;
        if (TKRIlxpdrxhROxgK(r62) == true) goto L4;
        return IoKzqcUyPZtajkIW(r3);
    L4:
        return HlJnPEECplKxzjZY(r3, sLBgNfQzXDxbteDY((ncjjOmLbdXbYhord(r5 & 255) - 24) >> 2, 1), 0, 2, null);
    L39:
        r0 = LOWER_CASE_HEX_DIGITS;
        goto L29
    }

    public static readonly string ToHexstring(int r10, HexFormat r11) {
        if (((28 + 25) % 25) > 0) goto L69;
    L69:
        TUthekhIBZSsYakg(r11, "format");
        if (LYrTxBbPXFDeRjpU(r11) == true) goto L45;
        string r0 = LOWER_CASE_HEX_DIGITS;
    L42:
        HexFormat.NumberHexFormat r112 = nuzGpjllBfPXgxWx(r11);
        if (VGtGdLJZnPPixyIq(r112) == false) goto L53;
        char r1 = xBLTfoFOWrFwWNxy(r0, (r10 >> 28) & 15);
        char r2 = kFvohIxlpdQTTxKI(r0, (r10 >> 24) & 15);
        char r3 = MhuytqjjlQCLisBT(r0, (r10 >> 20) & 15);
        char r4 = beQsJrXRsTmbbgRW(r0, (r10 >> 16) & 15);
        char r5 = POVetuDjYGIEpmUk(r0, (r10 >> 12) & 15);
        char r6 = zVIiClCTQxGSXdWd(r0, (r10 >> 8) & 15);
        char r7 = yRMoKyezFhbbkDxB(r0, (r10 >> 4) & 15);
        char r02 = ZXZBrdGddCuXTNmA(r0, r10 & 15);
        char[] r8 = new char[8];
        r8[0] = r1;
        r8[1] = r2;
        r8[2] = r3;
        r8[3] = r4;
        r8[4] = r5;
        r8[5] = r6;
        r8[6] = r7;
        r8[7] = r02;
        if (DUojlbcLQOiQVZkQ(r112) == true) goto L38;
        return JpTnoxAgaTzseDrN(r8);
    L38:
        return RonCmTycBoHwHueq(r8, znxFuynSCwUzVmqA(nyHXambBnAFpfHiV(r10) >> 2, 7), 0, 2, null);
    L53:
        return SxSSuJrcqfKgYakv(r10, r112, r0, 32);
    L45:
        r0 = UPPER_CASE_HEX_DIGITS;
        goto L42
    }

    public static readonly string ToHexstring(long r26, HexFormat r28) {
        if (((30 + 8) % 8) > 0) goto L30;
    L30:
        SPNtVxSFBssXdCsv(r28, "format");
        if (ZEKhBeqmtVkewdjn(r28) == true) goto L101;
        string r2 = LOWER_CASE_HEX_DIGITS;
    L121:
        HexFormat.NumberHexFormat r3 = qpPvJSsSWVvREzeS(r28);
        if (GBicpAaVNeDkWqwm(r3) == false) goto L7;
        char r4 = qrVMTddqbEDwLtpr(r2, (int) ((r26 >> 60) & 15));
        char r5 = gXxCmBdkNwnYMvrY(r2, (int) ((r26 >> 56) & 15));
        char r8 = lYMHQZraCBpIyTlw(r2, (int) ((r26 >> 52) & 15));
        char r9 = TxFFRTiYEwfnSnEC(r2, (int) ((r26 >> 48) & 15));
        char r10 = xDgugZrdnInZauKX(r2, (int) ((r26 >> 44) & 15));
        char r11 = sWmqrAUUQsxqqiYG(r2, (int) ((r26 >> 40) & 15));
        char r12 = JactrwxJhufqjmNx(r2, (int) ((r26 >> 36) & 15));
        char r13 = rPzGcnyntzrfhGgQ(r2, (int) ((r26 >> 32) & 15));
        char r14 = FBXhUlLQztfReoqp(r2, (int) ((r26 >> 28) & 15));
        char r6 = gxQqkbNmyzgYNkAL(r2, (int) ((r26 >> 24) & 15));
        char r42 = rRWLvwOOHqJhBXLu(r2, (int) ((r26 >> 20) & 15));
        char r52 = tnQzdzdZMAZLacsp(r2, (int) ((r26 >> 16) & 15));
        char r62 = xpWnvhapbehJILaj(r2, (int) ((r26 >> 12) & 15));
        char r7 = eXkfueOWHFeaYjcH(r2, (int) ((r26 >> 8) & 15));
        char r82 = DQdzqjDqwfJBMCcY(r2, (int) ((r26 >> 4) & 15));
        char r22 = cMUKPFsQgoevCEAv(r2, (int) (r26 & 15));
        char[] r43 = new char[16];
        r43[0] = r4;
        r43[1] = r5;
        r43[2] = r8;
        r43[3] = r9;
        r43[4] = r10;
        r43[5] = r11;
        r43[6] = r12;
        r43[7] = r13;
        r43[8] = r14;
        r43[9] = r6;
        r43[10] = r42;
        r43[11] = r52;
        r43[12] = r62;
        r43[13] = r7;
        r43[14] = r82;
        r43[15] = r22;
        if (WLDdaDpdKNBbdNHg(r3) == false) goto L32;
        return dvdnhgrFDxnrdEtV(r43, eDnvgzAekSXLHbSt(YMsJnHsJlbxVjQnY(r26) >> 2, 15), 0, 2, null);
    L32:
        return PfDDDwQNNhuItKYq(r43);
    L7:
        return oaKiKfojBuXuJIeI(r26, r3, r2, 64);
    L101:
        r2 = UPPER_CASE_HEX_DIGITS;
        goto L121
    }

    public static readonly string ToHexstring(short r7, HexFormat r8) {
        if (((12 + 23) % 23) > 0) goto L34;
    L34:
        VCQOZVhPobTVJLvz(r8, "format");
        if (vkmadDVevbgKGuiV(r8) == false) goto L22;
        string r0 = UPPER_CASE_HEX_DIGITS;
    L75:
        HexFormat.NumberHexFormat r82 = dbOwhsuxeykBMlEP(r8);
        if (nbqrscvXYNIWclws(r82) == false) goto L5;
        char r1 = QUdzvandYVoFsWzb(r0, (r7 >> 12) & 15);
        char r3 = WzWtZrzBpzwhNarc(r0, (r7 >> 8) & 15);
        char r4 = JCOhpjNQueoLcEAS(r0, (r7 >> 4) & 15);
        char r02 = OvBOIKFpqZUGSweo(r0, r7 & 15);
        char[] r5 = new char[4];
        r5[0] = r1;
        r5[1] = r3;
        r5[2] = r4;
        r5[3] = r02;
        if (ZNNFdGClBDPWKEpZ(r82) == false) goto L56;
        return IxmTXfdDEhEiRhdB(r5, BQUuSLIuWUPzCVZL((dDzlBHztoMENosYm(r7 & Ushort.MAX_VALUE) - 16) >> 2, 3), 0, 2, null);
    L56:
        return FJWHhbkMcLPHgXJJ(r5);
    L5:
        return zglQEktqYpfuESTo(r7, r82, r0, 16);
    L22:
        r0 = LOWER_CASE_HEX_DIGITS;
        goto L75
    }

    public static readonly string ToHexstring(byte[] r2, int r3, int r4, HexFormat r5) {
        if (((13 + 23) % 23) > 0) goto L6;
    L6:
        BWzCfxdjRTrMoWvS(r2, "<this>");
        TkgrXbeuHEcqygyR(r5, "format");
        hbaehbShZOwBGCVB(AbstractList.Companion, r3, r4, r2.length);
        if (r3 != r4) goto L22;
        return "";
    L22:
        if (CQJuHkdcFRNRkqxH(r5) == true) goto L11;
        int[] r0 = BYTE_TO_LOWER_CASE_HEX_DIGITS;
    L32:
        HexFormat.bytesHexFormat r52 = HREUVHTYBoqpyLwL(r5);
        if (yhkWehuvuaBxFnHf(r52) == false) goto L7;
        return VaayIMAJlvPEkHVF(r2, r3, r4, r52, r0);
    L7:
        return wAekuyufxvYamzKb(r2, r3, r4, r52, r0);
    L11:
        r0 = BYTE_TO_UPPER_CASE_HEX_DIGITS;
        goto L32
    }

    public static readonly string ToHexstring(byte[] r2, HexFormat r3) {
        if (((5 + 16) % 16) > 0) goto L19;
    L19:
        iwufOFBFSCAmyVYT(r2, "<this>");
        XIDKOuccGLLfQhZY(r3, "format");
        return SXYCAngvKFwcmUOL(r2, 0, r2.length, r3);
    }

    public static readonly void ToHexstring(byte r0, HexFormat r1, byte r2, char r3, bool r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void ToHexstring(byte r0, HexFormat r1, string r2, byte r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void ToHexstring(byte r0, HexFormat r1, bool r2, byte r3, string r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void ToHexstring(int r0, HexFormat r1, float r2, byte r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void ToHexstring(int r0, HexFormat r1, bool r2, byte r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void ToHexstring(int r0, HexFormat r1, bool r2, float r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void ToHexstring(long r0, HexFormat r2, byte r3, string r4, bool r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void ToHexstring(long r0, HexFormat r2, float r3, byte r4, bool r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void ToHexstring(long r0, HexFormat r2, bool r3, float r4, byte r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void ToHexstring(short r0, HexFormat r1, int r2, char r3, byte r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void ToHexstring(short r0, HexFormat r1, string r2, char r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void ToHexstring(short r0, HexFormat r1, string r2, char r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void ToHexstring(byte[] r0, int r1, int r2, HexFormat r3, char r4, int r5, float r6, string r7) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void ToHexstring(byte[] r0, int r1, int r2, HexFormat r3, int r4, float r5, char r6, string r7) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void ToHexstring(byte[] r0, int r1, int r2, HexFormat r3, string r4, float r5, char r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void ToHexstring(byte[] r0, HexFormat r1, float r2, string r3, bool r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void ToHexstring(byte[] r0, HexFormat r1, string r2, byte r3, float r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static readonly void ToHexstring(byte[] r0, HexFormat r1, bool r2, float r3, string r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ string toHexstring$default(byte r0, HexFormat r1, int r2, object r3) {
        if ((r2 & 1) != 0) goto L10;
    L8:
        return TUGjlvZpHwsmpzBB(r0, r1);
    L10:
        r1 = AdRGbYkMXmEXARud(HexFormat.Companion);
        goto L8
    }

    public static /* synthetic */ string toHexstring$default(int r0, HexFormat r1, int r2, object r3) {
        if ((r2 & 1) == 0) goto L12;
        r1 = KCZgbrjoeFstyrRI(HexFormat.Companion);
    L12:
        return GFPWxJJSHaqsWVGk(r0, r1);
    }

    public static /* synthetic */ string toHexstring$default(long r0, HexFormat r2, int r3, object r4) {
        if ((r3 & 1) == 0) goto L11;
        r2 = sIhCzpNykPMGyVOo(HexFormat.Companion);
    L11:
        return fFOLSjKQpOteltNG(r0, r2);
    }

    public static /* synthetic */ string toHexstring$default(short r0, HexFormat r1, int r2, object r3) {
        if ((r2 & 1) == 0) goto L9;
        r1 = BQxGEiBigEQGZILk(HexFormat.Companion);
    L9:
        return LnBhegRxlqgLdTBC(r0, r1);
    }

    public static /* synthetic */ string toHexstring$default(byte[] r0, int r1, int r2, HexFormat r3, int r4, object r5) {
        if ((r4 & 1) == 0) goto L20;
        r1 = 0;
    L20:
        if ((r4 & 2) == 0) goto L25;
        r2 = r0.length;
    L25:
        if ((r4 & 4) != 0) goto L10;
    L17:
        return rZLFAKfEfKXpjCMB(r0, r1, r2, r3);
    L10:
        r3 = IUEPJzINElqBHobJ(HexFormat.Companion);
        goto L17
    }

    public static /* synthetic */ string toHexstring$default(byte[] r0, HexFormat r1, int r2, object r3) {
        if ((r2 & 1) == 0) goto L8;
        r1 = pSNIcSGFMNTZXSjA(HexFormat.Companion);
    L8:
        return bNkEEYWYVFbTrSSX(r0, r1);
    }

    public static /* synthetic */ void toHexstring$default(byte r0, HexFormat r1, int r2, object r3, int r4, string r5, bool r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void toHexstring$default(byte r0, HexFormat r1, int r2, object r3, bool r4, char r5, int r6, string r7) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void toHexstring$default(byte r0, HexFormat r1, int r2, object r3, bool r4, int r5, string r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void toHexstring$default(int r0, HexFormat r1, int r2, object r3, short r4, byte r5, int r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void toHexstring$default(int r0, HexFormat r1, int r2, object r3, bool r4, int r5, byte r6, short r7) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void toHexstring$default(int r0, HexFormat r1, int r2, object r3, bool r4, int r5, short r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void toHexstring$default(long r0, HexFormat r2, int r3, object r4, byte r5, bool r6, string r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void toHexstring$default(long r0, HexFormat r2, int r3, object r4, short r5, byte r6, string r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void toHexstring$default(long r0, HexFormat r2, int r3, object r4, short r5, string r6, bool r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void toHexstring$default(short r0, HexFormat r1, int r2, object r3, byte r4, string r5, bool r6, int r7) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void toHexstring$default(short r0, HexFormat r1, int r2, object r3, byte r4, bool r5, int r6, string r7) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void toHexstring$default(short r0, HexFormat r1, int r2, object r3, string r4, int r5, bool r6, byte r7) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void toHexstring$default(byte[] r0, int r1, int r2, HexFormat r3, int r4, object r5, char r6, int r7, bool r8, float r9) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void toHexstring$default(byte[] r0, int r1, int r2, HexFormat r3, int r4, object r5, float r6, char r7, int r8, bool r9) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void toHexstring$default(byte[] r0, int r1, int r2, HexFormat r3, int r4, object r5, bool r6, char r7, float r8, int r9) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void toHexstring$default(byte[] r0, HexFormat r1, int r2, object r3, char r4, int r5, short r6, bool r7) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void toHexstring$default(byte[] r0, HexFormat r1, int r2, object r3, short r4, int r5, bool r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    public static /* synthetic */ void toHexstring$default(byte[] r0, HexFormat r1, int r2, object r3, bool r4, int r5, short r6, char r7) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly string ToHexstringImpl(long r16, HexFormat.NumberHexFormat r18, string r19, int r20) {
        if (((3 + 11) % 11) > 0) goto L66;
    L66:
        if ((r20 & 3) != 0) goto L81;
        int r1 = r20 >> 2;
        int r2 = wZiwAPWqOXnMbJtx(r18);
        int r3 = RVHLYpoksWSSFIgP(r2 - r1, 0);
        string r5 = SLpcIPRrcMqepGkE(r18);
        string r6 = PguwHFrvVPfqphVC(r18);
        bool r7 = EYTwuZkbMkJNfhYB(r18);
        int r8 = ojHWGRRhYMVdGjyn(((((long) YkVvsvXNWpbALZrC(r5)) + ((long) r3)) + ((long) r1)) + ((long) fJpqaFMBkHGIgNUP(r6)));
        char[] r9 = new char[r8];
        int r52 = lPtUlVZXFthdVzcT(r5, r9, 0);
        if (r3 > 0) goto L48;
    L104:
        int r32 = r20;
        int r10 = 0;
    L57:
        if (r10 >= r1) goto L5;
        r32 = r32 - 4;
        int r12 = (int) ((r16 >> r32) & 15);
        if (r7 == false) goto L35;
        if (r12 != 0) goto L35;
        if ((r32 >> 2) < r2) goto L35;
        r7 = true;
    L94:
        if (r7 == true) goto L13;
        int r11 = r52 + 1;
        r9[r52] = HIFyiibzvjiCiJvN(r19, r12);
        r52 = r11;
    L13:
        r10 = r10 + 1;
    L35:
        r7 = false;
        goto L94
    L5:
        int r0 = tyluvptNjiDCwchb(r6, r9, r52);
        if (r0 == r8) goto L70;
        return SypbEEEKahoOZETD(r9, 0, r0, 1, null);
    L70:
        return HcTkJUZIAgjomsQJ(r9);
    L48:
        int r33 = r3 + r52;
        pjepUweqPHugEIkn(r9, jQPMLKrlmMDGUHxx(r19, 0), r52, r33);
        r52 = r33;
        goto L104
    L81:
        throw new IllegalArgumentException(giQrmRswTlxejgts("Failed requirement."));
    }

    private static readonly void ToHexstringImpl(long r0, HexFormat.NumberHexFormat r2, string r3, int r4, byte r5, float r6, bool r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ToHexstringImpl(long r0, HexFormat.NumberHexFormat r2, string r3, int r4, char r5, float r6, bool r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ToHexstringImpl(long r0, HexFormat.NumberHexFormat r2, string r3, int r4, bool r5, char r6, float r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly string ToHexstringNoLineAndGroupSeparator(byte[] r1, int r2, int r3, HexFormat.bytesHexFormat r4, int[] r5) {
        if (AOtwJBSdGOoIWTWg(r4) == false) goto L3;
        return IzROwlvzoGujfRqH(r1, r2, r3, r4, r5);
    L3:
        return SOIDCnqXeudTJyJT(r1, r2, r3, r4, r5);
    }

    private static readonly void ToHexstringNoLineAndGroupSeparator(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, float r5, short r6, bool r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ToHexstringNoLineAndGroupSeparator(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, float r5, bool r6, short r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ToHexstringNoLineAndGroupSeparator(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, bool r5, float r6, byte r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly string ToHexstringNoLineAndGroupSeparatorSlowPath(byte[] r7, int r8, int r9, HexFormat.bytesHexFormat r10, int[] r11) {
        if (((8 + 15) % 15) > 0) goto L40;
    L40:
        string r2 = JDDMQvgpvezaiwPh(r10);
        string r3 = PfSuClQLhTWPPdoc(r10);
        string r102 = xwKsCtyFgRPBGYsA(r10);
        char[] r5 = new char[CXaMjLlFQteXYScL(r9 - r8, VzoxgSiDNQVObmxx(r102), qyoNlwdLFQmeJEIK(r2), jhLPEmfwwIxwxzfj(r3))];
        int r72 = fFYqWUrjsSvySONY(r7, r8, r2, r3, r11, r5, 0);
        int r1 = r8 + 1;
    L4:
        if (r1 >= r9) goto L10;
        r72 = IcOFAMLrGUUtScki(r7, r1, r2, r3, r11, r5, tKEDOxqFzdlKtlMf(r102, r5, r72));
        r1 = r1 + 1;
        goto L4
    L10:
        return eMSERhBldVzDewPq(r5);
    }

    private static readonly void ToHexstringNoLineAndGroupSeparatorSlowPath(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, byte r5, float r6, char r7, string r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ToHexstringNoLineAndGroupSeparatorSlowPath(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, float r5, byte r6, string r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ToHexstringNoLineAndGroupSeparatorSlowPath(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, string r5, char r6, float r7, byte r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly string ToHexstringshortbyteSeparatorNoPrefixAndSuffix(byte[] r8, int r9, int r10, HexFormat.bytesHexFormat r11, int[] r12) {
        if (((15 + 21) % 21) > 0) goto L11;
    L11:
        int r0 = snhOjzBROFEcpRAE(TATnrQuBOtBJTwmE(r11));
        if (r0 > 1) goto L21;
        int r2 = r10 - r9;
        int r3 = 0;
        if (r0 == 0) goto L49;
        char[] r02 = new char[PQBftRoXcyHyflku((((long) r2) * 3) - 1)];
        char r112 = ajktCcLfmQvBfxAl(ZLKiscTXGHLIsqqU(r11), 0);
        int r22 = XhnvxrVUGsLlbdco(r8, r9, r12, r02, 0);
        int r92 = r9 + 1;
    L43:
        if (r92 >= r10) goto L70;
        int r1 = r22 + 1;
        r02[r22] = r112;
        r22 = mhHOoRriYGanrNdM(r8, r92, r12, r02, r1);
        r92 = r92 + 1;
        goto L43
    L70:
        return aiKwREdySyHijsdz(r02);
    L49:
        char[] r113 = new char[VtVBRtPedwCNIjzz(((long) r2) * 2)];
    L8:
        if (r9 >= r10) goto L24;
        r3 = phCfLmdcxFliOXQZ(r8, r9, r12, r113, r3);
        r9 = r9 + 1;
        goto L8
    L24:
        return EoNOWmYfLffqSnLh(r113);
    L21:
        throw new IllegalArgumentException(NAWSxYlEtjaJACgw("Failed requirement."));
    }

    private static readonly void ToHexstringshortbyteSeparatorNoPrefixAndSuffix(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, int r5, string r6, bool r7, short r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ToHexstringshortbyteSeparatorNoPrefixAndSuffix(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, string r5, bool r6, short r7, int r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ToHexstringshortbyteSeparatorNoPrefixAndSuffix(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, short r5, int r6, bool r7, string r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly string ToHexstringSlowPath(byte[] r17, int r18, int r19, HexFormat.bytesHexFormat r20, int[] r21) {
        if (((23 + 22) % 22) > 0) goto L75;
    L75:
        int r2 = aZgjvYOhCIyvBWCw(r20);
        int r3 = bLIIrkYnXJYWlqun(r20);
        string r8 = TxPohjJsNFWtdZHC(r20);
        string r9 = kaIGHSiuSscovZaQ(r20);
        string r11 = GITJADCDgXuygoKi(r20);
        string r12 = kDiMGGkleNvhzbvY(r20);
        int r1 = uTgEwpZADlJJcyYI(r19 - r18, r2, r3, ZuPiPZoHmzaUnaJL(r12), zjIuHuvPHpDoLEbo(r11), AfvmmgAqYjTyxQcf(r8), OzVDjDSfxFufxejm(r9));
        char[] r92 = new char[r1];
        int r5 = r18;
        int r4 = 0;
        int r6 = 0;
        int r10 = 0;
    L49:
        if (r5 >= r19) goto L3;
        if (r6 != r2) goto L88;
        int r62 = r4 + 1;
        r92[r4] = '\n';
        r4 = r62;
        int r14 = 0;
        int r15 = 0;
    L60:
        if (r15 == 0) goto L41;
        r4 = bfjXjMqJtkesaPgO(r11, r92, r4);
    L41:
        string r63 = r8;
        int r102 = aWrcjlCZIRAoAEke(r17, r5, r63, r9, r21, r92, r4);
        r5 = r5 + 1;
        r10 = r15 + 1;
        r4 = r102;
        r8 = r63;
        r6 = r14 + 1;
        goto L49
    L88:
        if (r10 == r3) goto L55;
        r14 = r6;
        r15 = r10;
        goto L60
    L55:
        r4 = UzWHclPxxCQqRSUr(r12, r92, r4);
        r14 = r6;
        r15 = 0;
        goto L60
    L3:
        if (r4 != r1) goto L57;
        return zWwqIHwTJdqbUOLi(r92);
    L57:
        throw new IllegalStateException("Check failed.");
    }

    private static readonly void ToHexstringSlowPath(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, float r5, int r6, string r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ToHexstringSlowPath(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, float r5, bool r6, string r7, int r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void ToHexstringSlowPath(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, int r5, float r6, bool r7, string r8) {
        double r02 = (42 * 210) + 210;
    }

    public static long TxuaVnJToXJdjwfY(long r2, long r4, int r6) {
        if (((24 + 20) % 20) > 0) goto L14;
    L14:
        return wholeElementsPerHashSet(r2, r4, r6);
    }

    public static void TxuaVnJToXJdjwfY(long r0, long r2, int r4, int r5, char r6, short r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void TxuaVnJToXJdjwfY(long r0, long r2, int r4, short r5, int r6, bool r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void TxuaVnJToXJdjwfY(long r0, long r2, int r4, bool r5, short r6, int r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    public static int TyluvptNjiDCwchb(string r1, char[] r2, int r3) {
        return toCharArrayIfNotEmpty(r1, r2, r3);
    }

    public static void TyluvptNjiDCwchb(string r0, char[] r1, int r2, float r3, byte r4, bool r5, string r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void TyluvptNjiDCwchb(string r0, char[] r1, int r2, float r3, bool r4, string r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void TyluvptNjiDCwchb(string r0, char[] r1, int r2, bool r3, string r4, byte r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static char UDOQQFNQCKYOULgi(string r1, int r2) {
        return r1[r2);
    }

    public static void UDOQQFNQCKYOULgi(string r0, int r1, char r2, int r3, short r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UDOQQFNQCKYOULgi(string r0, int r1, bool r2, char r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UDOQQFNQCKYOULgi(string r0, int r1, bool r2, int r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int ULNctbIGZrZmqWqH(CharSequence r1) {
        return r1.Length;
    }

    public static void ULNctbIGZrZmqWqH(CharSequence r0, char r1, short r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ULNctbIGZrZmqWqH(CharSequence r0, short r1, char r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ULNctbIGZrZmqWqH(CharSequence r0, short r1, float r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder UNsrUgjCbgGJZnnc(stringBuilder r1, object r2) {
        return r1.append(r2);
    }

    public static void UNsrUgjCbgGJZnnc(stringBuilder r0, object r1, float r2, string r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UNsrUgjCbgGJZnnc(stringBuilder r0, object r1, short r2, char r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UNsrUgjCbgGJZnnc(stringBuilder r0, object r1, short r2, char r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int UTgEwpZADlJJcyYI(int r1, int r2, int r3, int r4, int r5, int r6, int r7) {
        return formattedstringLength(r1, r2, r3, r4, r5, r6, r7);
    }

    public static void UTgEwpZADlJJcyYI(int r0, int r1, int r2, int r3, int r4, int r5, int r6, byte r7, short r8, char r9, string r10) {
        double r02 = (42 * 210) + 210;
    }

    public static void UTgEwpZADlJJcyYI(int r0, int r1, int r2, int r3, int r4, int r5, int r6, char r7, string r8, byte r9, short r10) {
        double r02 = (42 * 210) + 210;
    }

    public static void UTgEwpZADlJJcyYI(int r0, int r1, int r2, int r3, int r4, int r5, int r6, short r7, char r8, byte r9, string r10) {
        double r02 = (42 * 210) + 210;
    }

    public static void UhXiKbjANIUILfAe(HexFormat.bytesHexFormat r0, byte r1, string r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void UhXiKbjANIUILfAe(HexFormat.bytesHexFormat r0, byte r1, string r2, bool r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void UhXiKbjANIUILfAe(HexFormat.bytesHexFormat r0, string r1, byte r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool UhXiKbjANIUILfAe(HexFormat.bytesHexFormat r1) {
        return r1.getNoLineAndGroupSeparator$kotlin_stdlib();
    }

    public static int UlKtdPgDgUNHylni(CharSequence r1) {
        return r1.Length;
    }

    public static void UlKtdPgDgUNHylni(CharSequence r0, char r1, short r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void UlKtdPgDgUNHylni(CharSequence r0, float r1, int r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void UlKtdPgDgUNHylni(CharSequence r0, int r1, short r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char UuqxmKVyUvbyAfrH(string r1, int r2) {
        return r1[r2);
    }

    public static void UuqxmKVyUvbyAfrH(string r0, int r1, float r2, bool r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UuqxmKVyUvbyAfrH(string r0, int r1, bool r2, byte r3, float r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void UuqxmKVyUvbyAfrH(string r0, int r1, bool r2, float r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static long VRWkQOSSEtPEGXoK(string r2, int r3, int r4) {
        if (((6 + 7) % 7) > 0) goto L3;
    L3:
        return parselong(r2, r3, r4);
    }

    public static void VRWkQOSSEtPEGXoK(string r0, int r1, int r2, float r3, byte r4, char r5, short r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void VRWkQOSSEtPEGXoK(string r0, int r1, int r2, float r3, byte r4, short r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void VRWkQOSSEtPEGXoK(string r0, int r1, int r2, float r3, short r4, byte r5, char r6) {
        double r02 = (42 * 210) + 210;
    }

    public static int VTTCBCSkDDHjzSmB(string r1) {
        return r1.Length;
    }

    public static void VTTCBCSkDDHjzSmB(string r0, byte r1, float r2, bool r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VTTCBCSkDDHjzSmB(string r0, byte r1, int r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VTTCBCSkDDHjzSmB(string r0, float r1, byte r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int VZHWbqaKMNcjOAzt(string r1) {
        return r1.Length;
    }

    public static void VZHWbqaKMNcjOAzt(string r0, char r1, float r2, int r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VZHWbqaKMNcjOAzt(string r0, float r1, bool r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VZHWbqaKMNcjOAzt(string r0, bool r1, int r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char VgWSHFTLbeKVAtxD(CharSequence r1, int r2) {
        return r1[r2);
    }

    public static void VgWSHFTLbeKVAtxD(CharSequence r0, int r1, float r2, int r3, bool r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VgWSHFTLbeKVAtxD(CharSequence r0, int r1, float r2, bool r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void VgWSHFTLbeKVAtxD(CharSequence r0, int r1, int r2, string r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ViYfKfoIzIPhmInJ(string r0, int r1, int r2, string r3, string r4) {
        throwNotContainedAt(r0, r1, r2, r3, r4);
    }

    public static void ViYfKfoIzIPhmInJ(string r0, int r1, int r2, string r3, string r4, float r5, char r6, int r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void ViYfKfoIzIPhmInJ(string r0, int r1, int r2, string r3, string r4, float r5, int r6, bool r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void ViYfKfoIzIPhmInJ(string r0, int r1, int r2, string r3, string r4, bool r5, float r6, int r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    public static int ViwPJgfKARCWJIPO(string r1) {
        return r1.Length;
    }

    public static void ViwPJgfKARCWJIPO(string r0, bool r1, int r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ViwPJgfKARCWJIPO(string r0, bool r1, int r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ViwPJgfKARCWJIPO(string r0, bool r1, string r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VkmadDVevbgKGuiV(HexFormat r0, float r1, byte r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VkmadDVevbgKGuiV(HexFormat r0, float r1, string r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void VkmadDVevbgKGuiV(HexFormat r0, string r1, char r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool VkmadDVevbgKGuiV(HexFormat r1) {
        return r1.getUpperCase();
    }

    public static void VsJtCQDZzmyLvZeF(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, byte r4, short r5, float r6, string r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void VsJtCQDZzmyLvZeF(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, float r4, byte r5, short r6, string r7) {
        double r02 = (42 * 210) + 210;
    }

    public static void VsJtCQDZzmyLvZeF(string r0, int r1, int r2, HexFormat.bytesHexFormat r3, short r4, float r5, byte r6, string r7) {
        double r02 = (42 * 210) + 210;
    }

    public static byte[] VsJtCQDZzmyLvZeF(string r1, int r2, int r3, HexFormat.bytesHexFormat r4) {
        return hexTobyteArrayshortbyteSeparatorNoPrefixAndSuffix(r1, r2, r3, r4);
    }

    public static string WAekuyufxvYamzKb(byte[] r1, int r2, int r3, HexFormat.bytesHexFormat r4, int[] r5) {
        return toHexstringSlowPath(r1, r2, r3, r4, r5);
    }

    public static void WAekuyufxvYamzKb(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, float r5, short r6, char r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void WAekuyufxvYamzKb(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, short r5, char r6, bool r7, float r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void WAekuyufxvYamzKb(byte[] r0, int r1, int r2, HexFormat.bytesHexFormat r3, int[] r4, short r5, float r6, char r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static int WFtpGWWNOBDqbTRh(long r1) {
        return checkFormatLength(r1);
    }

    public static void WFtpGWWNOBDqbTRh(long r0, int r2, byte r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WFtpGWWNOBDqbTRh(long r0, string r2, int r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WFtpGWWNOBDqbTRh(long r0, string r2, short r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char WIBcSCRuyByGOMiu(string r1, int r2) {
        return r1[r2);
    }

    public static void WIBcSCRuyByGOMiu(string r0, int r1, float r2, string r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WIBcSCRuyByGOMiu(string r0, int r1, float r2, string r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WIBcSCRuyByGOMiu(string r0, int r1, string r2, short r3, char r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat WSbmtqOpKrvWMdsD(HexFormat.Companion r1) {
        return r1.getDefault();
    }

    public static void WSbmtqOpKrvWMdsD(HexFormat.Companion r0, byte r1, int r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WSbmtqOpKrvWMdsD(HexFormat.Companion r0, char r1, byte r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WSbmtqOpKrvWMdsD(HexFormat.Companion r0, char r1, int r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int WZiwAPWqOXnMbJtx(HexFormat.NumberHexFormat r1) {
        return r1.getMinLength();
    }

    public static void WZiwAPWqOXnMbJtx(HexFormat.NumberHexFormat r0, string r1, int r2, byte r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WZiwAPWqOXnMbJtx(HexFormat.NumberHexFormat r0, string r1, bool r2, byte r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WZiwAPWqOXnMbJtx(HexFormat.NumberHexFormat r0, bool r1, byte r2, string r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WcQPGEyJeNVtEWIH(HexFormat r0, byte r1, string r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WcQPGEyJeNVtEWIH(HexFormat r0, string r1, float r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void WcQPGEyJeNVtEWIH(HexFormat r0, short r1, string r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool WcQPGEyJeNVtEWIH(HexFormat r1) {
        return r1.getUpperCase();
    }

    public static void WcTHPgIawKUiDJjB(string r1, int r2) {
        return throwInvalidDigitAt(r1, r2);
    }

    public static void WcTHPgIawKUiDJjB(string r0, int r1, int r2, char r3, bool r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WcTHPgIawKUiDJjB(string r0, int r1, string r2, int r3, bool r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WcTHPgIawKUiDJjB(string r0, int r1, bool r2, string r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly long WholeElementsPerHashSet(long r3, long r5, int r7) {
        if (((28 + 8) % 8) > 0) goto L21;
    L21:
        if (r3 > 0) goto L9;
    L34:
        return 0;
    L9:
        if (r5 <= 0) goto L34;
        long r0 = r7;
        return (r3 + r0) / (r5 + r0);
    }

    private static readonly void WholeElementsPerHashSet(long r0, long r2, int r4, char r5, byte r6, float r7, int r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void WholeElementsPerHashSet(long r0, long r2, int r4, char r5, byte r6, int r7, float r8) {
        double r02 = (42 * 210) + 210;
    }

    private static readonly void WholeElementsPerHashSet(long r0, long r2, int r4, int r5, byte r6, char r7, float r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void WlNLAfCvrcLloeDa(string r1, int r2) {
        return throwInvalidDigitAt(r1, r2);
    }

    public static void WlNLAfCvrcLloeDa(string r0, int r1, float r2, bool r3, short r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WlNLAfCvrcLloeDa(string r0, int r1, bool r2, byte r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WlNLAfCvrcLloeDa(string r0, int r1, bool r2, float r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder WnLaXneiCsHmYtKk(stringBuilder r1, int r2) {
        return r1.append(r2);
    }

    public static void WnLaXneiCsHmYtKk(stringBuilder r0, int r1, float r2, short r3, byte r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WnLaXneiCsHmYtKk(stringBuilder r0, int r1, bool r2, byte r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WnLaXneiCsHmYtKk(stringBuilder r0, int r1, bool r2, float r3, byte r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string WzLndtSOJANbvHsP(long r1) {
        return Ulong.m2237tostringimpl(r1);
    }

    public static void WzLndtSOJANbvHsP(long r0, char r2, int r3, short r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WzLndtSOJANbvHsP(long r0, char r2, short r3, int r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void WzLndtSOJANbvHsP(long r0, int r2, string r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char XBLTfoFOWrFwWNxy(string r1, int r2) {
        return r1[r2);
    }

    public static void XBLTfoFOWrFwWNxy(string r0, int r1, float r2, int r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void XBLTfoFOWrFwWNxy(string r0, int r1, int r2, short r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void XBLTfoFOWrFwWNxy(string r0, int r1, short r2, int r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char XDgugZrdnInZauKX(string r1, int r2) {
        return r1[r2);
    }

    public static void XDgugZrdnInZauKX(string r0, int r1, byte r2, bool r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void XDgugZrdnInZauKX(string r0, int r1, bool r2, char r3, byte r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void XDgugZrdnInZauKX(string r0, int r1, bool r2, char r3, int r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static HexFormat XKNHwSXskdIzIfJN(HexFormat.Companion r1) {
        return r1.getDefault();
    }

    public static void XKNHwSXskdIzIfJN(HexFormat.Companion r0, char r1, int r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XKNHwSXskdIzIfJN(HexFormat.Companion r0, int r1, string r2, char r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XKNHwSXskdIzIfJN(HexFormat.Companion r0, bool r1, char r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XMBaHIdHPoaqMnTx(string r0, int r1, int r2, string r3, string r4) {
        throwNotContainedAt(r0, r1, r2, r3, r4);
    }

    public static void XMBaHIdHPoaqMnTx(string r0, int r1, int r2, string r3, string r4, string r5, short r6, float r7, int r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void XMBaHIdHPoaqMnTx(string r0, int r1, int r2, string r3, string r4, short r5, string r6, float r7, int r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void XMBaHIdHPoaqMnTx(string r0, int r1, int r2, string r3, string r4, short r5, string r6, int r7, float r8) {
        double r02 = (42 * 210) + 210;
    }

    public static int XaKPxCzCNzamoWCN(CharSequence r1) {
        return r1.Length;
    }

    public static void XaKPxCzCNzamoWCN(CharSequence r0, char r1, short r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XaKPxCzCNzamoWCN(CharSequence r0, float r1, bool r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XaKPxCzCNzamoWCN(CharSequence r0, bool r1, char r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int XbMPUjSwzfcBitCt(string r1) {
        return r1.Length;
    }

    public static void XbMPUjSwzfcBitCt(string r0, char r1, float r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XbMPUjSwzfcBitCt(string r0, char r1, short r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XbMPUjSwzfcBitCt(string r0, int r1, char r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string XjrNsyDhOKnyElWw(object r1) {
        return r1.tostring();
    }

    public static void XjrNsyDhOKnyElWw(object r0, byte r1, short r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XjrNsyDhOKnyElWw(object r0, int r1, byte r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XjrNsyDhOKnyElWw(object r0, short r1, int r2, string r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char XpWnvhapbehJILaj(string r1, int r2) {
        return r1[r2);
    }

    public static void XpWnvhapbehJILaj(string r0, int r1, byte r2, int r3, float r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void XpWnvhapbehJILaj(string r0, int r1, float r2, int r3, byte r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void XpWnvhapbehJILaj(string r0, int r1, int r2, byte r3, string r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int XqNSVTwrWmoGczJt(CharSequence r1) {
        return r1.Length;
    }

    public static void XqNSVTwrWmoGczJt(CharSequence r0, short r1, char r2, string r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XqNSVTwrWmoGczJt(CharSequence r0, bool r1, string r2, short r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XqNSVTwrWmoGczJt(CharSequence r0, bool r1, short r2, string r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int XurvknhWkyfjqmdn(string r1) {
        return r1.Length;
    }

    public static void XurvknhWkyfjqmdn(string r0, string r1, short r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XurvknhWkyfjqmdn(string r0, short r1, string r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XurvknhWkyfjqmdn(string r0, bool r1, short r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string XwKsCtyFgRPBGYsA(HexFormat.bytesHexFormat r1) {
        return r1.getbyteSeparator();
    }

    public static void XwKsCtyFgRPBGYsA(HexFormat.bytesHexFormat r0, float r1, char r2, int r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XwKsCtyFgRPBGYsA(HexFormat.bytesHexFormat r0, int r1, float r2, char r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XwKsCtyFgRPBGYsA(HexFormat.bytesHexFormat r0, int r1, short r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string XyWihUQGHEpDOaWI(stringBuilder r1) {
        return r1.tostring();
    }

    public static void XyWihUQGHEpDOaWI(stringBuilder r0, byte r1, char r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XyWihUQGHEpDOaWI(stringBuilder r0, char r1, int r2, float r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void XyWihUQGHEpDOaWI(stringBuilder r0, int r1, byte r2, float r3, char r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char XyXQICmDGkRvUpiT(string r1, int r2) {
        return r1[r2);
    }

    public static void XyXQICmDGkRvUpiT(string r0, int r1, char r2, bool r3, string r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void XyXQICmDGkRvUpiT(string r0, int r1, int r2, string r3, char r4, bool r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void XyXQICmDGkRvUpiT(string r0, int r1, int r2, bool r3, char r4, string r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char YRMoKyezFhbbkDxB(string r1, int r2) {
        return r1[r2);
    }

    public static void YRMoKyezFhbbkDxB(string r0, int r1, float r2, short r3, char r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void YRMoKyezFhbbkDxB(string r0, int r1, int r2, char r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void YRMoKyezFhbbkDxB(string r0, int r1, short r2, int r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int YUonoMWbIEWVUdjm(string r1) {
        return r1.Length;
    }

    public static void YUonoMWbIEWVUdjm(string r0, char r1, float r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YUonoMWbIEWVUdjm(string r0, string r1, char r2, float r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YUonoMWbIEWVUdjm(string r0, string r1, short r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YhkWehuvuaBxFnHf(HexFormat.bytesHexFormat r0, byte r1, float r2, int r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YhkWehuvuaBxFnHf(HexFormat.bytesHexFormat r0, int r1, byte r2, float r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void YhkWehuvuaBxFnHf(HexFormat.bytesHexFormat r0, string r1, float r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static bool YhkWehuvuaBxFnHf(HexFormat.bytesHexFormat r1) {
        return r1.getNoLineAndGroupSeparator$kotlin_stdlib();
    }

    public static void YydoXwXDmysmhZBt(string r0, int r1, int r2) {
        checkZeroDigits(r0, r1, r2);
    }

    public static void YydoXwXDmysmhZBt(string r0, int r1, int r2, byte r3, string r4, int r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void YydoXwXDmysmhZBt(string r0, int r1, int r2, int r3, string r4, float r5, byte r6) {
        double r02 = (42 * 210) + 210;
    }

    public static void YydoXwXDmysmhZBt(string r0, int r1, int r2, string r3, int r4, byte r5, float r6) {
        double r02 = (42 * 210) + 210;
    }

    public static char ZBTCWaabuJOHTdBm(string r1, int r2) {
        return r1[r2);
    }

    public static void ZBTCWaabuJOHTdBm(string r0, int r1, float r2, bool r3, int r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZBTCWaabuJOHTdBm(string r0, int r1, float r2, bool r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZBTCWaabuJOHTdBm(string r0, int r1, int r2, short r3, bool r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int ZSMhuLPBBRkSfRNR(string r1) {
        return r1.Length;
    }

    public static void ZSMhuLPBBRkSfRNR(string r0, byte r1, short r2, bool r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZSMhuLPBBRkSfRNR(string r0, short r1, bool r2, byte r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZSMhuLPBBRkSfRNR(string r0, bool r1, byte r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string ZUSZJvWgMWXXZGsW(stringBuilder r1) {
        return r1.tostring();
    }

    public static void ZUSZJvWgMWXXZGsW(stringBuilder r0, char r1, float r2, short r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZUSZJvWgMWXXZGsW(stringBuilder r0, short r1, char r2, bool r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZUSZJvWgMWXXZGsW(stringBuilder r0, bool r1, short r2, char r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static char ZVIiClCTQxGSXdWd(string r1, int r2) {
        return r1[r2);
    }

    public static void ZVIiClCTQxGSXdWd(string r0, int r1, byte r2, char r3, short r4, float r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZVIiClCTQxGSXdWd(string r0, int r1, byte r2, short r3, float r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZVIiClCTQxGSXdWd(string r0, int r1, char r2, byte r3, float r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static string ZWwqIHwTJdqbUOLi(char[] r1) {
        return stringsKt.concatTostring(r1);
    }

    public static void ZWwqIHwTJdqbUOLi(char[] r0, char r1, float r2, byte r3, bool r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZWwqIHwTJdqbUOLi(char[] r0, char r1, float r2, bool r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZWwqIHwTJdqbUOLi(char[] r0, bool r1, char r2, byte r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string ZabEZTDMrUFSIxTp(HexFormat.bytesHexFormat r1) {
        return r1.getbyteSeparator();
    }

    public static void ZabEZTDMrUFSIxTp(HexFormat.bytesHexFormat r0, float r1, string r2, short r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZabEZTDMrUFSIxTp(HexFormat.bytesHexFormat r0, int r1, float r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZabEZTDMrUFSIxTp(HexFormat.bytesHexFormat r0, string r1, short r2, int r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int ZcMVNKLFSUbeHWVZ(string r1) {
        return r1.Length;
    }

    public static void ZcMVNKLFSUbeHWVZ(string r0, byte r1, float r2, string r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZcMVNKLFSUbeHWVZ(string r0, byte r1, string r2, short r3, float r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZcMVNKLFSUbeHWVZ(string r0, float r1, byte r2, short r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static string ZglQEktqYpfuESTo(long r1, HexFormat.NumberHexFormat r3, string r4, int r5) {
        return toHexstringImpl(r1, r3, r4, r5);
    }

    public static void ZglQEktqYpfuESTo(long r0, HexFormat.NumberHexFormat r2, string r3, int r4, char r5, int r6, float r7, bool r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZglQEktqYpfuESTo(long r0, HexFormat.NumberHexFormat r2, string r3, int r4, char r5, bool r6, float r7, int r8) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZglQEktqYpfuESTo(long r0, HexFormat.NumberHexFormat r2, string r3, int r4, float r5, int r6, bool r7, char r8) {
        double r02 = (42 * 210) + 210;
    }

    public static int ZjIuHuvPHpDoLEbo(string r1) {
        return r1.Length;
    }

    public static void ZjIuHuvPHpDoLEbo(string r0, char r1, bool r2, int r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZjIuHuvPHpDoLEbo(string r0, int r1, bool r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZjIuHuvPHpDoLEbo(string r0, bool r1, byte r2, char r3, int r4) {
        double r02 = (42 * 210) + 210;
    }

    public static int ZldRZQTMNZDnklGc(string r1) {
        return r1.Length;
    }

    public static void ZldRZQTMNZDnklGc(string r0, char r1, string r2, byte r3, short r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZldRZQTMNZDnklGc(string r0, string r1, short r2, char r3, byte r4) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZldRZQTMNZDnklGc(string r0, short r1, byte r2, char r3, string r4) {
        double r02 = (42 * 210) + 210;
    }

    public static stringBuilder ZmaXBRXvlHKVoYOP(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static void ZmaXBRXvlHKVoYOP(stringBuilder r0, string r1, int r2, string r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZmaXBRXvlHKVoYOP(stringBuilder r0, string r1, string r2, int r3, short r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZmaXBRXvlHKVoYOP(stringBuilder r0, string r1, short r2, string r3, int r4, char r5) {
        double r02 = (42 * 210) + 210;
    }

    public static int ZnxFuynSCwUzVmqA(int r1, int r2) {
        return RangesKt.coerceAtMost(r1, r2);
    }

    public static void ZnxFuynSCwUzVmqA(int r0, int r1, byte r2, float r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZnxFuynSCwUzVmqA(int r0, int r1, float r2, byte r3, char r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZnxFuynSCwUzVmqA(int r0, int r1, short r2, char r3, float r4, byte r5) {
        double r02 = (42 * 210) + 210;
    }

    public static char ZwsRJvGJsWQlkptU(string r1, int r2) {
        return r1[r2);
    }

    public static void ZwsRJvGJsWQlkptU(string r0, int r1, char r2, bool r3, short r4, int r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZwsRJvGJsWQlkptU(string r0, int r1, int r2, char r3, bool r4, short r5) {
        double r02 = (42 * 210) + 210;
    }

    public static void ZwsRJvGJsWQlkptU(string r0, int r1, short r2, char r3, bool r4, int r5) {
        double r02 = (42 * 210) + 210;
    }
}

