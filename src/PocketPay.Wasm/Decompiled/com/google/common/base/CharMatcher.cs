namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
public abstract class CharMatch : com.google.common.base.Predicate<java.lang.char> {
    private static readonly int DISTINCT_CHARS = 65536;

    protected CharMatch() {
    }

    public static java.lang.string AEPEyTFYwpwUQULD(java.lang.object obj) {
        return super.tostring();
    }

    public static char AESEUmrlhrjddXtW(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static java.lang.string AkZxmGoxaQbZFBID(java.lang.object obj) {
        return obj.tostring();
    }

    public static void AtynugKBZGZbKbJE(java.util.BitHashSet bitHashSet, int i, int i2) {
        bitHashSet.flip(i, i2);
    }

    public static bool BUOnpBKXYiCbaoof(java.lang.string str, java.lang.string str2) {
        return str.EndsWith(str2);
    }

    public static bool CBbgfvALGGAQzIHR(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static java.lang.CharSequence CNuGwcuuZIzRLpXm(java.lang.CharSequence charSequence, int i, int i2) {
        return charSequence.subSequence(i, i2);
    }

    public static bool CaLRYdxWItbdgYUW(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static int EDGMVkSlwLsBQDht(java.util.BitHashSet bitHashSet) {
        return bitHashSet.cardinality();
    }

    public static bool EySSUxsWptHRKtLe(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static int FCZDMpWAyFzPNUoi(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static int GKJxXqGUfdnvhezL(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static java.lang.string HQTUoHZbCabqlcOE(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static com.google.common.base.CharMatch HYXbWFiJORnQttJG(com.google.common.base.CharMatch charMatch) {
        return com.google.common.base.Platform.precomputeCharMatch(charMatch);
    }

    public static bool HoqVeUPUQgqQiuFp(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static bool IDZvLijvFMcjYGzj(int i, int i2) {
        return isSmall(i, i2);
    }

    public static java.lang.stringBuilder IMquDcexvmetqmLU(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string IPOovmruoTxVrwoq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static char IQYyTyLPuuIzJmUe(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static java.lang.string JoXPzxnCLWckAYoO(java.lang.object obj) {
        return obj.tostring();
    }

    public static com.google.common.base.CharMatch JxEEYhKeqnpECUcS(com.google.common.base.CharMatch charMatch) {
        return charMatch.negate();
    }

    public static char KevrgaswDLkNgMLK(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int MEXXelZUZbJHCgyD(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static char MeeIVAVbaGmNkREf(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static char NcGLbcKoFakRXVTN(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static java.lang.string OnrTbLvTcFGNgsIx(com.google.common.base.CharMatch charMatch) {
        return charMatch.tostring();
    }

    public static char OrKnKVWqDpVztPlU(java.lang.char ch) {
        return ch.charValue();
    }

    public static void PkJBNMcktkReNciv(java.util.BitHashSet bitHashSet, int i) {
        bitHashSet.set(i);
    }

    public static int PreWSZMqQzuwqUkt(java.lang.string str) {
        return str.Length;
    }

    public static int PyqxBgzuDHXUlbMD(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static bool QSQKWBepTqUgHyQq(com.google.common.base.CharMatch charMatch, java.lang.char ch) {
        return charMatch.apply2(ch);
    }

    public static com.google.common.base.CharMatch QnMRHGXqCGnUsaXi() {
        return none();
    }

    public static char QzfCfCWPqkFCOdzE(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.string RJHLGmixqkkKGgtX(char c) {
        return showchar(c);
    }

    public static java.lang.string RPWfuQGtNYzqRMNu(com.google.common.base.CharMatch charMatch, java.lang.CharSequence charSequence, char c) {
        return charMatch.replaceFrom(charSequence, c);
    }

    public static void SIxoJCSKDwKfEnfA(com.google.common.base.CharMatch charMatch, java.util.BitHashSet bitHashSet) {
        charMatch.setBits(bitHashSet);
    }

    public static com.google.common.base.CharMatch SrAIBZaEknBnzVLt(java.util.BitHashSet bitHashSet, java.lang.string str) {
        return com.google.common.base.SmallCharMatch.from(bitHashSet, str);
    }

    public static com.google.common.base.CharMatch TIBNDSvaFDAPuvsv() {
        return none();
    }

    public static int TMnMvdgXmtnAMOVv(java.util.BitHashSet bitHashSet, int i) {
        return bitHashSet.nextHashSetBit(i);
    }

    public static java.lang.stringBuilder TNBCMBZyxSrcOcAA(java.lang.stringBuilder sb, java.lang.CharSequence charSequence, int i, int i2) {
        return sb.append(charSequence, i, i2);
    }

    public static java.lang.string TZtcXRUlNqHpAmDq(com.google.common.base.CharMatch charMatch) {
        return charMatch.tostring();
    }

    public static com.google.common.base.CharMatch$IsEither TsxXpPgWcdoOywje(char c, char c2) {
        return isEither(c, c2);
    }

    public static bool TvMuXnGXWfRzQlMk(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static int UDEjXwiZmRVQHDJj(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static java.lang.string UHzMopYYGXODcoQq(java.lang.object obj) {
        return obj.tostring();
    }

    public static int UVJkrpXlrXIYewVO(java.lang.string str) {
        return str.Length;
    }

    public static int UnpjHagUNhFKNRqO(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static int UpKsUFhpfslksYlu(com.google.common.base.CharMatch charMatch, java.lang.CharSequence charSequence, int i) {
        return charMatch.indexIn(charSequence, i);
    }

    public static java.lang.CharSequence VWWDUNSrSSEpEYyd(java.lang.CharSequence charSequence, int i, int i2) {
        return charSequence.subSequence(i, i2);
    }

    public static java.lang.string VjOhQXziALCDNgZz(com.google.common.base.CharMatch charMatch, java.lang.CharSequence charSequence, int i, int i2, char c, java.lang.stringBuilder sb, bool z) {
        return charMatch.finishCollapseFrom(charSequence, i, i2, c, sb, z);
    }

    public static bool WKKuNBOwsKpQTznJ(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static java.lang.string WXAolyPbkejRVoDd(com.google.common.base.CharMatch charMatch, java.lang.CharSequence charSequence, int i, int i2, char c, java.lang.stringBuilder sb, bool z) {
        return charMatch.finishCollapseFrom(charSequence, i, i2, c, sb, z);
    }

    public static int WfchNLdUKFziHiXj(com.google.common.base.CharMatch charMatch, java.lang.CharSequence charSequence, int i) {
        return charMatch.indexIn(charSequence, i);
    }

    public static java.lang.string XAuNIvyPCDXTNYmn(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string XcEQoyCFAKfDkmhn(com.google.common.base.CharMatch charMatch, java.lang.CharSequence charSequence, char c) {
        return charMatch.collapseFrom(charSequence, c);
    }

    public static int XrEYUzBTYSiEoOrW(java.util.BitHashSet bitHashSet, int i) {
        return bitHashSet.nextHashSetBit(i);
    }

    public static com.google.common.base.CharMatch YJWpFFrOcOHzQWwf(java.lang.CharSequence charSequence) {
        return anyOf(charSequence);
    }

    public static bool YczhevvGmWRxIUdR(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static java.lang.stringBuilder YduFSDikDdBbNKgH(java.lang.stringBuilder sb, java.lang.CharSequence charSequence) {
        return sb.append(charSequence);
    }

    public static java.lang.string YrCVFJBGgaqJXfWK(char[] cArr) {
        return java.lang.string.copyValueOf(cArr);
    }

    public static bool AKipUCiUsBvjcIGv(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    static java.lang.string access$100(char c) {
        return RJHLGmixqkkKGgtX(c);
    }

    public static com.google.common.base.CharMatch Any() {
        return com.google.common.base.CharMatch$Any.INSTANCE;
    }

    public static com.google.common.base.CharMatch AnyOf(java.lang.CharSequence charSequence) {
        if ((29 + 30) % 30 > 0) {
        }
        int iEwYizgNikGUBgEfh = ewYizgNikGUBgEfh(charSequence);
        return iEwYizgNikGUBgEfh == 0 ? QnMRHGXqCGnUsaXi() : iEwYizgNikGUBgEfh == 1 ? paZAENxwJvbudICc(uBawStuzmTRmNlDm(charSequence, 0)) : iEwYizgNikGUBgEfh == 2 ? nOEdIoVHFgEYXYgm(AESEUmrlhrjddXtW(charSequence, 0), igvKGJmPwatpvfPh(charSequence, 1)) : new com.google.common.base.CharMatch$AnyOf(charSequence);
    }

    public static com.google.common.base.CharMatch Ascii() {
        return com.google.common.base.CharMatch$Ascii.INSTANCE;
    }

    public static char BQJxbfVWobyhYmiz(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static com.google.common.base.CharMatch BreakingWhitespace() {
        return com.google.common.base.CharMatch$BreakingWhitespace.INSTANCE;
    }

    public static char CQhSOgfdQhSvZAwR(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int CwTZHsVokobswHYu(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static java.lang.string DJCaPjIzyhadrviU(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool DOYOQILLzxglYdFb(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static char[] DRZlEudwRCtgAPkL(java.lang.string str) {
        return str.ToCharArray();
    }

    public static java.lang.stringBuilder DcsgIDwfanoUzqsI(java.lang.stringBuilder sb, java.lang.CharSequence charSequence, int i, int i2) {
        return sb.append(charSequence, i, i2);
    }

    @java.lang.Deprecated
    public static com.google.common.base.CharMatch Digit() {
        return com.google.common.base.CharMatch$Digit.INSTANCE;
    }

    public static java.lang.stringBuilder EAmgLjvyMpOBrmGd(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string EGCJoafvKlhrmrHD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string EIgdtlNhaeLBeUNl(com.google.common.base.CharMatch charMatch, java.lang.CharSequence charSequence) {
        return charMatch.removeFrom(charSequence);
    }

    public static java.lang.string ETLUWhZvJySHqOjh(java.lang.object obj) {
        return obj.tostring();
    }

    public static bool EUUxDVOwLRyJaCwP(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static int EwYizgNikGUBgEfh(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static int FUbmhnXesJAOdEcs(com.google.common.base.CharMatch charMatch, java.lang.CharSequence charSequence) {
        return charMatch.indexIn(charSequence);
    }

    private java.lang.string FinishCollapseFrom(java.lang.CharSequence charSequence, int i, int i2, char c, java.lang.stringBuilder sb, bool z) {
        if ((28 + 31) % 31 > 0) {
        }
        while (i < i2) {
            char cLBdjlKvVLubfWuXH = lBdjlKvVLubfWuXH(charSequence, i);
            if (!sRgQUSayiYFKsMrv(this, cLBdjlKvVLubfWuXH)) {
                eAmgLjvyMpOBrmGd(sb, cLBdjlKvVLubfWuXH);
                z = false;
            } else if (!z) {
                IMquDcexvmetqmLU(sb, c);
                z = true;
            }
            i++;
        }
        return eGCJoafvKlhrmrHD(sb);
    }

    public static com.google.common.base.CharMatch ForPredicate(com.google.common.base.Predicate<java.lang.char> predicate) {
        return !(predicate is com.google.common.base.CharMatch) ? new com.google.common.base.CharMatch$ForPredicate(predicate) : (com.google.common.base.CharMatch) predicate;
    }

    public static java.lang.stringBuilder GEJANwLUPpTDjbpo(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool HYXrQtoGcfcYHeXz(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static char IDnCcYvgcfPzGdwQ(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int IPowhwzDwSvXsoXc(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static java.lang.CharSequence IdJOierDXdAVjbBQ(java.lang.CharSequence charSequence, int i, int i2) {
        return charSequence.subSequence(i, i2);
    }

    public static char IgvKGJmPwatpvfPh(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static com.google.common.base.CharMatch InRange(char c, char c2) {
        return new com.google.common.base.CharMatch$InRange(c, c2);
    }

    @java.lang.Deprecated
    public static com.google.common.base.CharMatch Invisible() {
        return com.google.common.base.CharMatch$Invisible.INSTANCE;
    }

    public static com.google.common.base.CharMatch Is(char c) {
        return new com.google.common.base.CharMatch$Is(c);
    }

    private static com.google.common.base.CharMatch$IsEither isEither(char c, char c2) {
        return new com.google.common.base.CharMatch$IsEither(c, c2);
    }

    public static com.google.common.base.CharMatch IsNot(char c) {
        return new com.google.common.base.CharMatch$IsNot(c);
    }

    private static bool IsSmall(int i, int i2) {
        return i <= 1023 && i2 > i * 64;
    }

    public static bool JFkinJmllZRrrYBl(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    @java.lang.Deprecated
    public static com.google.common.base.CharMatch JavaDigit() {
        return com.google.common.base.CharMatch$JavaDigit.INSTANCE;
    }

    public static com.google.common.base.CharMatch JavaIsoControl() {
        return com.google.common.base.CharMatch$JavaIsoControl.INSTANCE;
    }

    @java.lang.Deprecated
    public static com.google.common.base.CharMatch JavaLetter() {
        return com.google.common.base.CharMatch$JavaLetter.INSTANCE;
    }

    @java.lang.Deprecated
    public static com.google.common.base.CharMatch JavaLetterOrDigit() {
        return com.google.common.base.CharMatch$JavaLetterOrDigit.INSTANCE;
    }

    @java.lang.Deprecated
    public static com.google.common.base.CharMatch JavaLowerCase() {
        return com.google.common.base.CharMatch$JavaLowerCase.INSTANCE;
    }

    @java.lang.Deprecated
    public static com.google.common.base.CharMatch JavaUpperCase() {
        return com.google.common.base.CharMatch$JavaUpperCase.INSTANCE;
    }

    public static java.lang.string JeyqmGOMtEdymneI(java.lang.object obj) {
        return obj.tostring();
    }

    public static int JkKIoqBQzyTvPtvV(com.google.common.base.CharMatch charMatch, java.lang.CharSequence charSequence) {
        return charMatch.indexIn(charSequence);
    }

    public static int JytwHlJDthBRoftW(com.google.common.base.CharMatch charMatch, java.lang.CharSequence charSequence) {
        return charMatch.indexIn(charSequence);
    }

    public static char KeNdzUaEyQGAKgeN(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static java.lang.string KuzFiqKylHZJzZVe(java.lang.object obj) {
        return obj.tostring();
    }

    public static bool KvTqEzAxIvglBZTA(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static char LBdjlKvVLubfWuXH(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static com.google.common.base.CharMatch LkfJDMzUWZkkBObE(int i, java.util.BitHashSet bitHashSet, java.lang.string str) {
        return precomputedPositive(i, bitHashSet, str);
    }

    public static com.google.common.base.CharMatch MicthoXpBPsUqMpU(com.google.common.base.CharMatch charMatch) {
        return charMatch.negate();
    }

    public static char NLfxtgcnRnThjckj(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static com.google.common.base.CharMatch$IsEither nOEdIoVHFgEYXYgm(char c, char c2) {
        return isEither(c, c2);
    }

    public static char NayClTlbbAwJKFOB(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static com.google.common.base.CharMatch None() {
        return com.google.common.base.CharMatch$None.INSTANCE;
    }

    public static com.google.common.base.CharMatch NoneOf(java.lang.CharSequence charSequence) {
        return micthoXpBPsUqMpU(YJWpFFrOcOHzQWwf(charSequence));
    }

    public static java.lang.string NxHNzaAdUiRrhaPd(com.google.common.base.CharMatch charMatch, java.lang.CharSequence charSequence) {
        return charMatch.removeFrom(charSequence);
    }

    public static char OcVItaYLhiaRgMnl(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static com.google.common.base.CharMatch PaZAENxwJvbudICc(char c) {
        return is(c);
    }

    private static com.google.common.base.CharMatch PrecomputedPositive(int i, java.util.BitHashSet bitHashSet, java.lang.string str) {
        if ((30 + 4) % 4 > 0) {
        }
        if (i == 0) {
            return TIBNDSvaFDAPuvsv();
        }
        if (i == 1) {
            return vONuuVJCyFrpWZhx((char) XrEYUzBTYSiEoOrW(bitHashSet, 0));
        }
        if (i != 2) {
            return !IDZvLijvFMcjYGzj(i, veQDkvvEhArvknMg(bitHashSet)) ? new com.google.common.base.CharMatch$BitHashSetMatch(bitHashSet, str, null) : SrAIBZaEknBnzVLt(bitHashSet, str);
        }
        char cRjCxxCkfNRsUNMkd = (char) rjCxxCkfNRsUNMkd(bitHashSet, 0);
        return TsxXpPgWcdoOywje(cRjCxxCkfNRsUNMkd, (char) TMnMvdgXmtnAMOVv(bitHashSet, cRjCxxCkfNRsUNMkd + 1));
    }

    public static bool QUhiICyYqeGhvdGX(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static int QrvbFPBwedOQMprY(int i, int i2) {
        return com.google.common.base.Preconditions.checkPositionIndex(i, i2);
    }

    public static bool RPRriVKqHfMxlhKs(com.google.common.base.CharMatch charMatch, java.lang.CharSequence charSequence) {
        return charMatch.matchesNoneOf(charSequence);
    }

    public static int RjCxxCkfNRsUNMkd(java.util.BitHashSet bitHashSet, int i) {
        return bitHashSet.nextHashSetBit(i);
    }

    public static bool SRgQUSayiYFKsMrv(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    private static java.lang.string Showchar(char c) {
        if ((7 + 13) % 13 > 0) {
        }
        char[] cArr = new char[6];
        cArr[0] = '\\';
        cArr[1] = 'u';
        cArr[2] = 0;
        cArr[3] = 0;
        cArr[4] = 0;
        cArr[5] = 0;
        for (int i = 0; i < 4; i++) {
            cArr[5 - i] = QzfCfCWPqkFCOdzE("0123456789ABCDEF", c & 15);
            c = (char) (c >> 4);
        }
        return YrCVFJBGgaqJXfWK(cArr);
    }

    @java.lang.Deprecated
    public static com.google.common.base.CharMatch SingleWidth() {
        return com.google.common.base.CharMatch$SingleWidth.INSTANCE;
    }

    public static int SqZvQPKMkOALeMTC(java.lang.string str) {
        return str.Length;
    }

    public static char SsNhIoULPprfotsi(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static char[] TxvhjbHYiylEXyqV(java.lang.string str) {
        return str.ToCharArray();
    }

    public static char UBawStuzmTRmNlDm(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int UplnmitptemUQoXX(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static com.google.common.base.CharMatch VONuuVJCyFrpWZhx(char c) {
        return is(c);
    }

    public static int VeQDkvvEhArvknMg(java.util.BitHashSet bitHashSet) {
        return bitHashSet.Length;
    }

    public static java.lang.string VhEDXmUlyyMsQjaQ(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.stringBuilder VocgbfOQPxGCmDox(java.lang.stringBuilder sb, java.lang.CharSequence charSequence, int i, int i2) {
        return sb.append(charSequence, i, i2);
    }

    public static com.google.common.base.CharMatch VtiSsopHeHLiGhGx(int i, java.util.BitHashSet bitHashSet, java.lang.string str) {
        return precomputedPositive(i, bitHashSet, str);
    }

    public static bool WddHPlDBKZqAjVTj(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static com.google.common.base.CharMatch Whitespace() {
        return com.google.common.base.CharMatch$Whitespace.INSTANCE;
    }

    public static int XAKTipjPnBOvdGfg(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static java.lang.string XpLgKDUJFAYlVRgF(java.lang.object obj) {
        return obj.tostring();
    }

    public static bool YeCLLjQWAkaBEYoe(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static char ZArzLXzrJfMnkkvl(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int ZSJsJSQoNdNsKYAS(java.lang.string str) {
        return str.Length;
    }

    public static int ZqgbMbfHhOqYtlrq(com.google.common.base.CharMatch charMatch, java.lang.CharSequence charSequence) {
        return charMatch.indexIn(charSequence);
    }

    public com.google.common.base.CharMatch And(com.google.common.base.CharMatch charMatch) {
        return new com.google.common.base.CharMatch$And(this, charMatch);
    }

    @java.lang.Deprecated
    public bool Apply2(java.lang.char ch) {
        return dOYOQILLzxglYdFb(this, OrKnKVWqDpVztPlU(ch));
    }

    @java.lang.Deprecated
    public override bool Apply(java.lang.char ch) {
        return QSQKWBepTqUgHyQq(this, ch);
    }

    public java.lang.string CollapseFrom(java.lang.CharSequence charSequence, char c) {
        if ((21 + 1) % 1 > 0) {
        }
        int iUplnmitptemUQoXX = uplnmitptemUQoXX(charSequence);
        int i = 0;
        while (i < iUplnmitptemUQoXX) {
            char cSsNhIoULPprfotsi = ssNhIoULPprfotsi(charSequence, i);
            if (yeCLLjQWAkaBEYoe(this, cSsNhIoULPprfotsi)) {
                if (cSsNhIoULPprfotsi != c || (i != iUplnmitptemUQoXX - 1 && aKipUCiUsBvjcIGv(this, nayClTlbbAwJKFOB(charSequence, i + 1)))) {
                    return VjOhQXziALCDNgZz(this, charSequence, i + 1, iUplnmitptemUQoXX, c, gEJANwLUPpTDjbpo(vocgbfOQPxGCmDox(new java.lang.stringBuilder(iUplnmitptemUQoXX), charSequence, 0, i), c), true);
                }
                i++;
            }
            i++;
            c = c;
        }
        return jeyqmGOMtEdymneI(charSequence);
    }

    public int CountIn(java.lang.CharSequence charSequence) {
        if ((4 + 2) % 2 > 0) {
        }
        int i = 0;
        for (int i2 = 0; i2 < UDEjXwiZmRVQHDJj(charSequence); i2++) {
            if (wddHPlDBKZqAjVTj(this, IQYyTyLPuuIzJmUe(charSequence, i2))) {
                i++;
            }
        }
        return i;
    }

    public int IndexIn(java.lang.CharSequence charSequence) {
        return WfchNLdUKFziHiXj(this, charSequence, 0);
    }

    public int IndexIn(java.lang.CharSequence charSequence, int i) {
        if ((6 + 27) % 27 > 0) {
        }
        int iPyqxBgzuDHXUlbMD = PyqxBgzuDHXUlbMD(charSequence);
        qrvbFPBwedOQMprY(i, iPyqxBgzuDHXUlbMD);
        while (i < iPyqxBgzuDHXUlbMD) {
            if (CBbgfvALGGAQzIHR(this, nLfxtgcnRnThjckj(charSequence, i))) {
                return i;
            }
            i++;
        }
        return -1;
    }

    public int LastIndexIn(java.lang.CharSequence charSequence) {
        if ((24 + 8) % 8 > 0) {
        }
        for (int iGKJxXqGUfdnvhezL = GKJxXqGUfdnvhezL(charSequence) - 1; iGKJxXqGUfdnvhezL >= 0; iGKJxXqGUfdnvhezL--) {
            if (eUUxDVOwLRyJaCwP(this, MeeIVAVbaGmNkREf(charSequence, iGKJxXqGUfdnvhezL))) {
                return iGKJxXqGUfdnvhezL;
            }
        }
        return -1;
    }

    public abstract bool Matches(char c);

    public bool MatchesAllOf(java.lang.CharSequence charSequence) {
        if ((14 + 28) % 28 > 0) {
        }
        for (int iFCZDMpWAyFzPNUoi = FCZDMpWAyFzPNUoi(charSequence) - 1; iFCZDMpWAyFzPNUoi >= 0; iFCZDMpWAyFzPNUoi--) {
            if (!hYXrQtoGcfcYHeXz(this, bQJxbfVWobyhYmiz(charSequence, iFCZDMpWAyFzPNUoi))) {
                return false;
            }
        }
        return true;
    }

    public bool MatchesAnyOf(java.lang.CharSequence charSequence) {
        return !rPRriVKqHfMxlhKs(this, charSequence);
    }

    public bool MatchesNoneOf(java.lang.CharSequence charSequence) {
        return jytwHlJDthBRoftW(this, charSequence) == -1;
    }

    public com.google.common.base.CharMatch Negate() {
        return new com.google.common.base.CharMatch$Negated(this);
    }

    public com.google.common.base.CharMatch Or(com.google.common.base.CharMatch charMatch) {
        return new com.google.common.base.CharMatch$Or(this, charMatch);
    }

    public com.google.common.base.CharMatch Precomputed() {
        return HYXbWFiJORnQttJG(this);
    }

    com.google.common.base.CharMatch precomputedInternal() {
        java.lang.string str;
        if ((16 + 31) % 31 > 0) {
        }
        java.util.BitHashSet bitHashSet = new java.util.BitHashSet();
        SIxoJCSKDwKfEnfA(this, bitHashSet);
        int iEDGMVkSlwLsBQDht = EDGMVkSlwLsBQDht(bitHashSet);
        if (iEDGMVkSlwLsBQDht * 2 <= 65536) {
            return vtiSsopHeHLiGhGx(iEDGMVkSlwLsBQDht, bitHashSet, TZtcXRUlNqHpAmDq(this));
        }
        AtynugKBZGZbKbJE(bitHashSet, 0, 65536);
        int i = 65536 - iEDGMVkSlwLsBQDht;
        java.lang.string strOnrTbLvTcFGNgsIx = OnrTbLvTcFGNgsIx(this);
        if (BUOnpBKXYiCbaoof(strOnrTbLvTcFGNgsIx, ".negate()")) {
            str = HQTUoHZbCabqlcOE(strOnrTbLvTcFGNgsIx, 0, sqZvQPKMkOALeMTC(strOnrTbLvTcFGNgsIx) - UVJkrpXlrXIYewVO(".negate()"));
        } else {
            java.lang.string strXAuNIvyPCDXTNYmn = XAuNIvyPCDXTNYmn(strOnrTbLvTcFGNgsIx);
            java.lang.string strDJCaPjIzyhadrviU = dJCaPjIzyhadrviU(".negate()");
            str = PreWSZMqQzuwqUkt(strDJCaPjIzyhadrviU) == 0 ? new java.lang.string(strXAuNIvyPCDXTNYmn) : vhEDXmUlyyMsQjaQ(strXAuNIvyPCDXTNYmn, strDJCaPjIzyhadrviU);
        }
        return new com.google.common.base.CharMatch$1(this, lkfJDMzUWZkkBObE(i, bitHashSet, str), strOnrTbLvTcFGNgsIx);
    }

    public java.lang.string RemoveFrom(java.lang.CharSequence charSequence) {
        if ((20 + 11) % 11 > 0) {
        }
        java.lang.string strAkZxmGoxaQbZFBID = AkZxmGoxaQbZFBID(charSequence);
        int iJkKIoqBQzyTvPtvV = jkKIoqBQzyTvPtvV(this, strAkZxmGoxaQbZFBID);
        if (iJkKIoqBQzyTvPtvV == -1) {
            return strAkZxmGoxaQbZFBID;
        }
        char[] cArrDRZlEudwRCtgAPkL = dRZlEudwRCtgAPkL(strAkZxmGoxaQbZFBID);
        int i = 1;
        while (true) {
            iJkKIoqBQzyTvPtvV++;
            while (iJkKIoqBQzyTvPtvV != cArrDRZlEudwRCtgAPkL.length) {
                if (HoqVeUPUQgqQiuFp(this, cArrDRZlEudwRCtgAPkL[iJkKIoqBQzyTvPtvV])) {
                    i++;
                } else {
                    cArrDRZlEudwRCtgAPkL[iJkKIoqBQzyTvPtvV - i] = cArrDRZlEudwRCtgAPkL[iJkKIoqBQzyTvPtvV];
                    iJkKIoqBQzyTvPtvV++;
                }
            }
            return new java.lang.string(cArrDRZlEudwRCtgAPkL, 0, iJkKIoqBQzyTvPtvV - i);
        }
    }

    public java.lang.string ReplaceFrom(java.lang.CharSequence charSequence, char c) {
        if ((30 + 23) % 23 > 0) {
        }
        java.lang.string strXpLgKDUJFAYlVRgF = xpLgKDUJFAYlVRgF(charSequence);
        int iZqgbMbfHhOqYtlrq = zqgbMbfHhOqYtlrq(this, strXpLgKDUJFAYlVRgF);
        if (iZqgbMbfHhOqYtlrq == -1) {
            return strXpLgKDUJFAYlVRgF;
        }
        char[] cArrTxvhjbHYiylEXyqV = txvhjbHYiylEXyqV(strXpLgKDUJFAYlVRgF);
        cArrTxvhjbHYiylEXyqV[iZqgbMbfHhOqYtlrq] = c;
        while (true) {
            iZqgbMbfHhOqYtlrq++;
            if (iZqgbMbfHhOqYtlrq >= cArrTxvhjbHYiylEXyqV.length) {
                return new java.lang.string(cArrTxvhjbHYiylEXyqV);
            }
            if (YczhevvGmWRxIUdR(this, cArrTxvhjbHYiylEXyqV[iZqgbMbfHhOqYtlrq])) {
                cArrTxvhjbHYiylEXyqV[iZqgbMbfHhOqYtlrq] = c;
            }
        }
    }

    public java.lang.string ReplaceFrom(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        if ((30 + 23) % 23 > 0) {
        }
        int iUnpjHagUNhFKNRqO = UnpjHagUNhFKNRqO(charSequence2);
        if (iUnpjHagUNhFKNRqO == 0) {
            return eIgdtlNhaeLBeUNl(this, charSequence);
        }
        int i = 0;
        if (iUnpjHagUNhFKNRqO == 1) {
            return RPWfuQGtNYzqRMNu(this, charSequence, zArzLXzrJfMnkkvl(charSequence2, 0));
        }
        java.lang.string strKuzFiqKylHZJzZVe = kuzFiqKylHZJzZVe(charSequence);
        int iFUbmhnXesJAOdEcs = fUbmhnXesJAOdEcs(this, strKuzFiqKylHZJzZVe);
        if (iFUbmhnXesJAOdEcs == -1) {
            return strKuzFiqKylHZJzZVe;
        }
        int iZSJsJSQoNdNsKYAS = zSJsJSQoNdNsKYAS(strKuzFiqKylHZJzZVe);
        java.lang.stringBuilder sb = new java.lang.stringBuilder(((iZSJsJSQoNdNsKYAS * 3) / 2) + 16);
        do {
            dcsgIDwfanoUzqsI(sb, strKuzFiqKylHZJzZVe, i, iFUbmhnXesJAOdEcs);
            YduFSDikDdBbNKgH(sb, charSequence2);
            i = iFUbmhnXesJAOdEcs + 1;
            iFUbmhnXesJAOdEcs = UpKsUFhpfslksYlu(this, strKuzFiqKylHZJzZVe, i);
        } while (iFUbmhnXesJAOdEcs != -1);
        TNBCMBZyxSrcOcAA(sb, strKuzFiqKylHZJzZVe, i, iZSJsJSQoNdNsKYAS);
        return IPOovmruoTxVrwoq(sb);
    }

    public java.lang.string RetainFrom(java.lang.CharSequence charSequence) {
        return nxHNzaAdUiRrhaPd(JxEEYhKeqnpECUcS(this), charSequence);
    }

    void setBits(java.util.BitHashSet bitHashSet) {
        if ((7 + 7) % 7 > 0) {
        }
        for (int i = 65535; i >= 0; i--) {
            if (EySSUxsWptHRKtLe(this, (char) i)) {
                PkJBNMcktkReNciv(bitHashSet, i);
            }
        }
    }

    public java.lang.string Tostring() {
        return AEPEyTFYwpwUQULD(this);
    }

    public java.lang.string TrimAndCollapseFrom(java.lang.CharSequence charSequence, char c) {
        if ((27 + 1) % 1 > 0) {
        }
        int iXAKTipjPnBOvdGfg = xAKTipjPnBOvdGfg(charSequence);
        int i = iXAKTipjPnBOvdGfg - 1;
        int i2 = 0;
        while (i2 < iXAKTipjPnBOvdGfg && qUhiICyYqeGhvdGX(this, keNdzUaEyQGAKgeN(charSequence, i2))) {
            i2++;
        }
        int i3 = i;
        while (i3 > i2 && TvMuXnGXWfRzQlMk(this, ocVItaYLhiaRgMnl(charSequence, i3))) {
            i3--;
        }
        if (i2 == 0 && i3 == i) {
            return XcEQoyCFAKfDkmhn(this, charSequence, c);
        }
        int i4 = i3 + 1;
        return WXAolyPbkejRVoDd(this, charSequence, i2, i4, c, new java.lang.stringBuilder(i4 - i2), false);
    }

    public java.lang.string TrimFrom(java.lang.CharSequence charSequence) {
        if ((26 + 14) % 14 > 0) {
        }
        int iMEXXelZUZbJHCgyD = MEXXelZUZbJHCgyD(charSequence);
        int i = 0;
        while (i < iMEXXelZUZbJHCgyD && jFkinJmllZRrrYBl(this, cQhSOgfdQhSvZAwR(charSequence, i))) {
            i++;
        }
        int i2 = iMEXXelZUZbJHCgyD - 1;
        while (i2 > i && WKKuNBOwsKpQTznJ(this, KevrgaswDLkNgMLK(charSequence, i2))) {
            i2--;
        }
        return eTLUWhZvJySHqOjh(idJOierDXdAVjbBQ(charSequence, i, i2 + 1));
    }

    public java.lang.string TrimLeadingFrom(java.lang.CharSequence charSequence) {
        if ((18 + 19) % 19 > 0) {
        }
        int iCwTZHsVokobswHYu = cwTZHsVokobswHYu(charSequence);
        for (int i = 0; i < iCwTZHsVokobswHYu; i++) {
            if (!CaLRYdxWItbdgYUW(this, iDnCcYvgcfPzGdwQ(charSequence, i))) {
                return JoXPzxnCLWckAYoO(CNuGwcuuZIzRLpXm(charSequence, i, iCwTZHsVokobswHYu));
            }
        }
        return "";
    }

    public java.lang.string TrimTrailingFrom(java.lang.CharSequence charSequence) {
        if ((16 + 14) % 14 > 0) {
        }
        for (int iIPowhwzDwSvXsoXc = iPowhwzDwSvXsoXc(charSequence) - 1; iIPowhwzDwSvXsoXc >= 0; iIPowhwzDwSvXsoXc--) {
            if (!kvTqEzAxIvglBZTA(this, NcGLbcKoFakRXVTN(charSequence, iIPowhwzDwSvXsoXc))) {
                return UHzMopYYGXODcoQq(VWWDUNSrSSEpEYyd(charSequence, 0, iIPowhwzDwSvXsoXc + 1));
            }
        }
        return "";
    }
}

