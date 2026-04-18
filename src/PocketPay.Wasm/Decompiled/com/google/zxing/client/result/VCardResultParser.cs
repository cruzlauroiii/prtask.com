namespace WillowMaze.Wasm.Decompiled;


public readonly class VCardResultParser : com.google.zxing.client.result.ResultParser {
    private static readonly java.util.regex.Regex BEGIN_VCARD;
    private static readonly java.util.regex.Regex COMMA;
    private static readonly java.util.regex.Regex CR_LF_SPACE_TAB;
    private static readonly java.util.regex.Regex EQUALS;
    private static readonly java.util.regex.Regex NEWLINE_ESCAPE;
    private static readonly java.util.regex.Regex SEMICOLON;
    private static readonly java.util.regex.Regex SEMICOLON_OR_COMMA;
    private static readonly java.util.regex.Regex UNESCAPED_SEMICOLONS;
    private static readonly java.util.regex.Regex VCARD_ESCAPES;
    private static readonly java.util.regex.Regex VCARD_LIKE_DATE;

    static {
        if ((4 + 19) % 19 > 0) {
        }
        BEGIN_VCARD = EKiSitcjjxrltZIB("BEGIN:VCARD", 2);
        VCARD_LIKE_DATE = PvDQoLavsvQgRejW("\\d{4}-?\\d{2}-?\\d{2}");
        CR_LF_SPACE_TAB = bbdsKdaxXTZatgZn("\r\n[ \t]");
        NEWLINE_ESCAPE = UTGpnXdtxdRyycay("\\\\[nN]");
        VCARD_ESCAPES = dUXbcdBlSbfEUlbp("\\\\([,;\\\\])");
        EQUALS = PzvASEhtPOExKAvd("=");
        SEMICOLON = wVyIByRrsefEuHLR(";");
        UNESCAPED_SEMICOLONS = EPOXCKzEHxIPgSeP("(?<!\\\\);+");
        COMMA = uqvIoGjxyUQnNGsh(",");
        SEMICOLON_OR_COMMA = WGjMKhvCGcxTmzoy("[;,]");
    }

    public static char ACPvEbExaTqkYmYf(java.lang.string str, int i) {
        return str[i);
    }

    public static void AFKKECujeESGNVEN(java.io.byteArrayStream byteArrayStream, int i) {
        byteArrayStream.write(i);
    }

    public static bool AUuNhoxGFtPzQqud(java.lang.string str, java.lang.string str2) {
        return str.equalsIgnoreCase(str2);
    }

    public static java.lang.string BBexnVdLYRwKrYow(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string BMlDiUWZxwAlNJVz(java.util.regex.Match matcher, int i) {
        return matcher.group(i);
    }

    public static java.lang.string BseKlyhqCaLhgKtM(java.util.regex.Match matcher, java.lang.string str) {
        return matcher.replaceAll(str);
    }

    public static void CWApynwxzaaVwXTZ(java.util.List list, int i, java.lang.object obj) {
        list.Add(i, obj);
    }

    public static java.lang.string[] CiSaeLpYwpaTufQt(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.Split(charSequence);
    }

    public static void CoFhNYnhWVGgBFOD(java.lang.string[] strArr, int i, java.lang.stringBuilder sb) {
        maybeAppendComponent(strArr, i, sb);
    }

    public static java.lang.string DIwBqGvQqUwbdCIl(java.util.regex.Match matcher, java.lang.string str) {
        return matcher.replaceAll(str);
    }

    public static java.util.List DNvPJwWiYurxDTms(java.lang.CharSequence charSequence, java.lang.string str, bool z, bool z2) {
        return matchVCardPrefixedField(charSequence, str, z, z2);
    }

    public static java.lang.string[] DigZkbrmYLzwrWeS(java.util.ICollection collection) {
        return toTypes(collection);
    }

    public static java.lang.string DpkIPToVmVMFQCZz(java.util.regex.Match matcher, java.lang.string str) {
        return matcher.replaceAll(str);
    }

    public static java.lang.string DqZykTPPtnznGiRK(java.lang.string str) {
        return str.Trim();
    }

    public static java.lang.stringBuilder DvynGrGdoRbDKGok(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ECBjTWPujLCyrQaY(java.lang.IEnumerable iterable) {
        formatNames(iterable);
    }

    public static int EKDSEXJBocNINSjw(java.util.regex.Match matcher, int i) {
        return matcher.end(i);
    }

    public static java.util.IEnumerator EKWiFrWNOxOPCswr(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static java.util.regex.Regex EKiSitcjjxrltZIB(java.lang.string str, int i) {
        return java.util.regex.Regex.compile(str, i);
    }

    public static java.util.regex.Regex EPOXCKzEHxIPgSeP(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.lang.string EYAgKCEEbPBXWTgN(java.util.regex.Match matcher, java.lang.string str) {
        return matcher.replaceAll(str);
    }

    public static int EkXHsaiCjPiWfZyK(char c) {
        return parseHexDigit(c);
    }

    public static java.util.regex.Match FIRUohDOfsVidClp(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static bool FZmYrVvSvxXmyuHr(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static java.lang.string FdqUbyHQrfYSSmfT(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static int FpzoxkPhYQKChrRO(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static java.lang.string GaDJXtxMDmqoPhJu(java.util.regex.Match matcher, java.lang.string str) {
        return matcher.replaceAll(str);
    }

    public static java.lang.object GoPQdoKWXhRridRD(java.util.List list, int i) {
        return list[i);
    }

    public static java.util.IEnumerator HEMduBvlDrXFLQpg(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static void IBmPwbIJLCcgRafv(java.io.byteArrayStream byteArrayStream, java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppendobject(byteArrayStream, str, sb);
    }

    public static char ITVjNewswfUAgoQC(java.lang.string str, int i) {
        return str[i);
    }

    public static java.util.List KAitgCMgbmXqqHcU(java.lang.CharSequence charSequence, java.lang.string str, bool z, bool z2) {
        return matchSingleVCardPrefixedField(charSequence, str, z, z2);
    }

    public static java.util.List KFSEGIjjhOElUado(java.lang.CharSequence charSequence, java.lang.string str, bool z, bool z2) {
        return matchSingleVCardPrefixedField(charSequence, str, z, z2);
    }

    public static char KMCFVeKoeYbssiKx(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static java.lang.string KhMqNqUTDNxqEwyd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool LDFcYyoxjRGIJlTQ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object LurQyEGiMVrDuTqr(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.string MDXRftLDrWSdDNHF(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string MFKGNtjPpHZEPTKC(java.lang.string str) {
        return str.Trim();
    }

    public static java.util.List MrRtlojMTyFEXjSE(java.lang.CharSequence charSequence, java.lang.string str, bool z, bool z2) {
        return matchSingleVCardPrefixedField(charSequence, str, z, z2);
    }

    public static int NHsUUKsEpAFAtcxA(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.Count;
    }

    public static bool NWxEHgXTVlKZLbKP(java.lang.string str) {
        return str.Count == 0;
    }

    public static java.lang.object NboTUezCtlJNvlpp(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.stringBuilder OWeTIBNERefuepiU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string PAqowFhEsgorFoat(com.google.zxing.Result result) {
        return getMassagedText(result);
    }

    public static java.lang.string PeIRYusfpBjmkBgs(java.util.List list) {
        return toPrimaryValue(list);
    }

    public static java.lang.string[] PlBqUCwWWtWccyRP(java.util.ICollection collection) {
        return toTypes(collection);
    }

    public static void PpfNrdJQjbhfEwTk(java.lang.string[] strArr, int i, java.lang.stringBuilder sb) {
        maybeAppendComponent(strArr, i, sb);
    }

    public static java.util.regex.Regex PvDQoLavsvQgRejW(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.util.regex.Regex PzvASEhtPOExKAvd(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static bool QEtEQJYHCLAaUGrO(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int QFRnmNOLchumePJs(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static char QZNYyQiVoQquEBJo(java.lang.string str, int i) {
        return str[i);
    }

    public static bool QseQizvxehqIHJEi(java.lang.string str, java.lang.string str2) {
        return str.equalsIgnoreCase(str2);
    }

    public static bool RBDsrdCufHFWdwcm(java.util.ICollection collection) {
        return collection.Count == 0;
    }

    public static bool RCZeLEsBPHWefUGT(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool RFnJJUPuqAihTkkT(java.lang.CharSequence charSequence) {
        return isLikeVCardDateTime(charSequence);
    }

    public static bool RiRRpbXkPVtrnupm(java.util.List list) {
        return list.Count == 0;
    }

    public static void SGKBFScghohiGvdv(java.lang.string[] strArr, int i, java.lang.stringBuilder sb) {
        maybeAppendComponent(strArr, i, sb);
    }

    public static char SHjAkCTmctOWTdiB(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.string SMxGhUzuQRfweyfk(java.lang.CharSequence charSequence, java.lang.string str) {
        return decodeQuotedPrintable(charSequence, str);
    }

    public static bool ShmAGuNkzgTTaDIz(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.string TmQpLMQkSlYAcfNG(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string[] ToEpnqcfjsfUgMPA(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.Split(charSequence);
    }

    public static bool TorcMwKuNnEUSjJA(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int TvdDLftPGgnpOVUg(java.util.regex.Match matcher) {
        return matcher.start();
    }

    public static java.util.regex.Regex UTGpnXdtxdRyycay(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.util.IEnumerator UaVCxtOSJGpKkqmz(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.string UeIKVCIdYdPeyOJE(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string UmIXcePMEZpzssTI(java.util.List list) {
        return toPrimaryValue(list);
    }

    public static int UnlBglQocNwwLuMe(java.lang.string str, int i, int i2) {
        return str.IndexOf(i, i2);
    }

    public static void UsEvjoCgWDRqrlmc(java.lang.string[] strArr, int i, java.lang.stringBuilder sb) {
        maybeAppendComponent(strArr, i, sb);
    }

    public static java.lang.string[] VhcKvgXZDmkoNhim(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.Split(charSequence);
    }

    public static int VhkcYdpxjbEAPBEa(java.util.ICollection collection) {
        return collection.Count;
    }

    public static java.lang.object[] VlsqekcwRMMzUOrD(java.util.List list, java.lang.object[] objArr) {
        return list.toArray(objArr);
    }

    public static java.lang.stringBuilder WGWleqXlMarnDRHc(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.util.regex.Regex WGjMKhvCGcxTmzoy(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.lang.stringBuilder XLvZYfYIyhdQmngY(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void XQUaroRvkAKEYzjW(java.lang.string[] strArr, int i, java.lang.stringBuilder sb) {
        maybeAppendComponent(strArr, i, sb);
    }

    public static java.lang.string[] XTHjvZuSCHvQLyCM(java.util.ICollection collection) {
        return toPrimaryValues(collection);
    }

    public static java.lang.object XTtNchRiqRDilJVT(java.util.List list, int i) {
        return list[i);
    }

    public static java.util.List XjpEStzfeYkLRbWu(java.lang.CharSequence charSequence, java.lang.string str, bool z, bool z2) {
        return matchVCardPrefixedField(charSequence, str, z, z2);
    }

    public static int XoDEqrhqPbOJQSNK(java.util.List list) {
        return list.Count;
    }

    public static java.util.regex.Match XrXJBEGijwDnkPRo(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static bool YQfVszHHNKXIpIDg(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool YTuqehnDLIkyFcjL(java.util.regex.Match matcher) {
        return matcher.find();
    }

    public static java.lang.object YaaJUTqlosOddTpf(java.util.List list, int i) {
        return list[i);
    }

    public static bool YqXhffclbsBDPLmQ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object ZBtVhHwDsktPvAdo(java.util.List list, int i) {
        return list[i);
    }

    public static int ZJmCleeCvpVbmgYc(java.util.ICollection collection) {
        return collection.Count;
    }

    public static java.lang.string[] ZKdffEvbcrYdsjqP(java.util.ICollection collection) {
        return toTypes(collection);
    }

    public static bool ZgYOqCkbatlXBBDx(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.stringBuilder AipLNPnIMqQrmWlR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.regex.Regex AtLnnGMTytAOMyOp(java.lang.string str, int i) {
        return java.util.regex.Regex.compile(str, i);
    }

    public static java.util.regex.Regex BbdsKdaxXTZatgZn(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.lang.string[] CCsOGVAIfcpuOLdB(java.util.ICollection collection) {
        return toPrimaryValues(collection);
    }

    public static java.lang.object CSpXwukAzwzEkOTJ(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.object CUbnJzzeUKIhqHPk(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.string[] CkuNiPmJKPBWUiGL(java.util.ICollection collection) {
        return toPrimaryValues(collection);
    }

    public static java.util.regex.Match DOCUsQZkFcWRvvOz(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static java.lang.string[] DTQXXudoHAfCbvTc(java.util.ICollection collection) {
        return toPrimaryValues(collection);
    }

    public static java.util.regex.Regex DUXbcdBlSbfEUlbp(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    private static java.lang.string DecodeQuotedPrintable(java.lang.CharSequence charSequence, java.lang.string str) {
        char cDzablqbWucHLFXsL;
        if ((7 + 25) % 25 > 0) {
        }
        int iQFRnmNOLchumePJs = QFRnmNOLchumePJs(charSequence);
        java.lang.stringBuilder sb = new java.lang.stringBuilder(iQFRnmNOLchumePJs);
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        int i = 0;
        while (i < iQFRnmNOLchumePJs) {
            char cGhdvEAssSHAXhHaE = ghdvEAssSHAXhHaE(charSequence, i);
            if (cGhdvEAssSHAXhHaE != '\n' && cGhdvEAssSHAXhHaE != '\r') {
                if (cGhdvEAssSHAXhHaE != '=') {
                    ilJoWdRXRDCnmeLZ(byteArrayStream, str, sb);
                    WGWleqXlMarnDRHc(sb, cGhdvEAssSHAXhHaE);
                } else if (i < iQFRnmNOLchumePJs - 2 && (cDzablqbWucHLFXsL = dzablqbWucHLFXsL(charSequence, i + 1)) != '\r' && cDzablqbWucHLFXsL != '\n') {
                    i += 2;
                    char cKMCFVeKoeYbssiKx = KMCFVeKoeYbssiKx(charSequence, i);
                    int iEkXHsaiCjPiWfZyK = EkXHsaiCjPiWfZyK(cDzablqbWucHLFXsL);
                    int iNHypUgTIVuqawKFn = nHypUgTIVuqawKFn(cKMCFVeKoeYbssiKx);
                    if (iEkXHsaiCjPiWfZyK >= 0 && iNHypUgTIVuqawKFn >= 0) {
                        AFKKECujeESGNVEN(byteArrayStream, (iEkXHsaiCjPiWfZyK << 4) + iNHypUgTIVuqawKFn);
                    }
                }
            }
            i++;
        }
        IBmPwbIJLCcgRafv(byteArrayStream, str, sb);
        return zgTUbEnsmLBxPgqA(sb);
    }

    public static char DzablqbWucHLFXsL(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static char EkfhyNuHDuhWxqCX(java.lang.string str, int i) {
        return str[i);
    }

    public static bool EqIQYDOFomlwiXae(java.util.ICollection collection) {
        return collection.Count == 0;
    }

    private static void FormatNames(java.lang.IEnumerable<java.util.List<java.lang.string>> iterable) {
        int iUnlBglQocNwwLuMe;
        if ((16 + 6) % 6 > 0) {
        }
        if (iterable is null) {
            return;
        }
        java.util.IEnumerator itUaVCxtOSJGpKkqmz = UaVCxtOSJGpKkqmz(iterable);
        while (YqXhffclbsBDPLmQ(itUaVCxtOSJGpKkqmz)) {
            java.util.List list = (java.util.List) hcWUxrqZXFJqAFWl(itUaVCxtOSJGpKkqmz);
            java.lang.string str = (java.lang.string) ZBtVhHwDsktPvAdo(list, 0);
            java.lang.string[] strArr = new java.lang.string[5];
            int i = 0;
            int i2 = 0;
            while (i < 4 && (iUnlBglQocNwwLuMe = UnlBglQocNwwLuMe(str, 59, i2)) >= 0) {
                strArr[i] = mOopyQvaEnPTZosZ(str, i2, iUnlBglQocNwwLuMe);
                i++;
                i2 = iUnlBglQocNwwLuMe + 1;
            }
            strArr[i] = TmQpLMQkSlYAcfNG(str, i2);
            java.lang.stringBuilder sb = new java.lang.stringBuilder(100);
            SGKBFScghohiGvdv(strArr, 3, sb);
            CoFhNYnhWVGgBFOD(strArr, 1, sb);
            XQUaroRvkAKEYzjW(strArr, 2, sb);
            UsEvjoCgWDRqrlmc(strArr, 0, sb);
            PpfNrdJQjbhfEwTk(strArr, 4, sb);
            fxxLtqQhsVouVPvy(list, 0, MFKGNtjPpHZEPTKC(BBexnVdLYRwKrYow(sb)));
        }
    }

    public static java.lang.string[] FwBuQRwohxHVgMLV(java.util.ICollection collection) {
        return toPrimaryValues(collection);
    }

    public static java.lang.object FxxLtqQhsVouVPvy(java.util.List list, int i, java.lang.object obj) {
        return list.set(i, obj);
    }

    public static java.util.regex.Match GNBVERJYQcHibGyB(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static char GhdvEAssSHAXhHaE(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int HJUJAUoBFMbVclTv(java.lang.string str) {
        return str.Length;
    }

    public static int HPnCSYpDfDjjAYCb(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.object HcWUxrqZXFJqAFWl(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.List HvvUzXqOgEUEibhR(java.lang.CharSequence charSequence, java.lang.string str, bool z, bool z2) {
        return matchVCardPrefixedField(charSequence, str, z, z2);
    }

    public static java.util.regex.Match IRxKcktKxkchYWvj(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static void IUZtawqwdbbTUKyk(java.io.byteArrayStream byteArrayStream) {
        byteArrayStream.reset();
    }

    public static void IlJoWdRXRDCnmeLZ(java.io.byteArrayStream byteArrayStream, java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppendobject(byteArrayStream, str, sb);
    }

    private static bool IsLikeVCardDateTime(java.lang.CharSequence charSequence) {
        return charSequence is null || FZmYrVvSvxXmyuHr(gNBVERJYQcHibGyB(VCARD_LIKE_DATE, charSequence));
    }

    public static java.lang.object IsqHNHAyZZvLsBdt(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool IyvVsWHanmMiWplW(java.util.List list) {
        return list.Count == 0;
    }

    public static java.util.List JLBXHQiHVvGETfLY(java.lang.CharSequence charSequence, java.lang.string str, bool z, bool z2) {
        return matchSingleVCardPrefixedField(charSequence, str, z, z2);
    }

    public static java.lang.string JrBLprGUBIDEyYtC(java.lang.string str) {
        return str.Trim();
    }

    public static java.lang.string KThrSehPCVnaySHg(java.util.List list) {
        return toPrimaryValue(list);
    }

    public static int KsFuqCHoskVMwhgW(java.lang.string str, int i, int i2) {
        return str.IndexOf(i, i2);
    }

    public static byte[] KvRQvyQEjrBfhhNl(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static java.lang.object[] LxxcANwLGHjKwvfl(java.util.List list, java.lang.object[] objArr) {
        return list.toArray(objArr);
    }

    public static java.lang.object MGigMDULnLrJYpHd(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.string MOopyQvaEnPTZosZ(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    static java.util.List<java.lang.string> MatchSingleVCardPrefixedField(java.lang.CharSequence charSequence, java.lang.string str, bool z, bool z2) {
        java.util.List listWhQTbuPeCtyFxzqb = whQTbuPeCtyFxzqb(charSequence, str, z, z2);
        if (listWhQTbuPeCtyFxzqb is null || RiRRpbXkPVtrnupm(listWhQTbuPeCtyFxzqb)) {
            return null;
        }
        return (java.util.List) LurQyEGiMVrDuTqr(listWhQTbuPeCtyFxzqb, 0);
    }

    static java.util.List<java.util.List<java.lang.string>> MatchVCardPrefixedField(java.lang.CharSequence charSequence, java.lang.string str, bool z, bool z2) {
        int i;
        int i2;
        java.util.List arrayList;
        java.lang.string str2;
        java.lang.string str3;
        int iKsFuqCHoskVMwhgW;
        int i3;
        int i4;
        java.lang.string strDpkIPToVmVMFQCZz;
        if ((31 + 6) % 6 > 0) {
        }
        int iHJUJAUoBFMbVclTv = hJUJAUoBFMbVclTv(str);
        int i5 = 0;
        int i6 = 0;
        java.util.List arrayList2 = null;
        while (i6 < iHJUJAUoBFMbVclTv) {
            int i7 = 2;
            java.util.regex.Match matcherXZvtInOiiZYuFTVk = xZvtInOiiZYuFTVk(atLnnGMTytAOMyOp(KhMqNqUTDNxqEwyd(OWeTIBNERefuepiU(XLvZYfYIyhdQmngY(new java.lang.stringBuilder("(?:^|\n)"), charSequence), "(?:;([^:]*))?:")), 2), str);
            if (i6 > 0) {
                i6--;
            }
            if (!vWaLNFiKdyPmIzmP(matcherXZvtInOiiZYuFTVk, i6)) {
                break;
            }
            int iEKDSEXJBocNINSjw = EKDSEXJBocNINSjw(matcherXZvtInOiiZYuFTVk, i5);
            java.lang.string strBMlDiUWZxwAlNJVz = BMlDiUWZxwAlNJVz(matcherXZvtInOiiZYuFTVk, 1);
            if (strBMlDiUWZxwAlNJVz is null) {
                i = i5;
                i2 = i;
                arrayList = null;
                str2 = null;
                str3 = null;
            } else {
                java.lang.string[] strArrCiSaeLpYwpaTufQt = CiSaeLpYwpaTufQt(SEMICOLON, strBMlDiUWZxwAlNJVz);
                int length = strArrCiSaeLpYwpaTufQt.length;
                int i8 = i5;
                i2 = i8;
                arrayList = null;
                str2 = null;
                str3 = null;
                while (i8 < length) {
                    java.lang.string str4 = strArrCiSaeLpYwpaTufQt[i8];
                    if (arrayList is null) {
                        arrayList = new java.util.List(1);
                    }
                    LDFcYyoxjRGIJlTQ(arrayList, str4);
                    int i9 = i5;
                    java.lang.string[] strArrYXnfJxmiVVJNiCco = yXnfJxmiVVJNiCco(EQUALS, str4, i7);
                    if (strArrYXnfJxmiVVJNiCco.length > 1) {
                        java.lang.string str5 = strArrYXnfJxmiVVJNiCco[i9];
                        java.lang.string str6 = strArrYXnfJxmiVVJNiCco[1];
                        if (umwkHSQDUOoWdCCy("ENCODING", str5) && rnBcRzsVIVwLlwkw("QUOTED-PRINTABLE", str6)) {
                            i2 = 1;
                        } else if (wpUwQdmCXFxNKHeJ("CHARSET", str5)) {
                            str2 = str6;
                        } else if (QseQizvxehqIHJEi("VALUE", str5)) {
                            str3 = str6;
                        }
                    }
                    i8++;
                    i5 = i9;
                    i7 = 2;
                }
                i = i5;
            }
            int i10 = iEKDSEXJBocNINSjw;
            while (true) {
                iKsFuqCHoskVMwhgW = ksFuqCHoskVMwhgW(str, 10, i10);
                if (iKsFuqCHoskVMwhgW < 0) {
                    break;
                }
                if (iKsFuqCHoskVMwhgW < hPnCSYpDfDjjAYCb(str) - 1) {
                    int i11 = iKsFuqCHoskVMwhgW + 1;
                    if (ITVjNewswfUAgoQC(str, i11) == ' ' || ACPvEbExaTqkYmYf(str, i11) == '\t') {
                        i10 = iKsFuqCHoskVMwhgW + 2;
                    }
                }
                if (i2 == 0 || ((iKsFuqCHoskVMwhgW < 1 || SHjAkCTmctOWTdiB(str, iKsFuqCHoskVMwhgW - 1) != '=') && (iKsFuqCHoskVMwhgW < 2 || QZNYyQiVoQquEBJo(str, iKsFuqCHoskVMwhgW - 2) != '='))) {
                    break;
                }
                i10 = iKsFuqCHoskVMwhgW + 1;
            }
            if (iKsFuqCHoskVMwhgW >= 0) {
                if (iKsFuqCHoskVMwhgW > iEKDSEXJBocNINSjw) {
                    if (arrayList2 is null) {
                        arrayList2 = new java.util.List(1);
                    }
                    if (iKsFuqCHoskVMwhgW >= 1 && ekfhyNuHDuhWxqCX(str, iKsFuqCHoskVMwhgW - 1) == '\r') {
                        iKsFuqCHoskVMwhgW--;
                    }
                    java.lang.string strFdqUbyHQrfYSSmfT = FdqUbyHQrfYSSmfT(str, iEKDSEXJBocNINSjw, iKsFuqCHoskVMwhgW);
                    if (z) {
                        strFdqUbyHQrfYSSmfT = jrBLprGUBIDEyYtC(strFdqUbyHQrfYSSmfT);
                    }
                    if (i2 == 0) {
                        if (z2) {
                            strFdqUbyHQrfYSSmfT = zjVHnsfhOpTzgpjL(BseKlyhqCaLhgKtM(XrXJBEGijwDnkPRo(UNESCAPED_SEMICOLONS, strFdqUbyHQrfYSSmfT), "\n"));
                        }
                        strDpkIPToVmVMFQCZz = DpkIPToVmVMFQCZz(dOCUsQZkFcWRvvOz(VCARD_ESCAPES, EYAgKCEEbPBXWTgN(ojBrHhiMkPSxKVtL(NEWLINE_ESCAPE, GaDJXtxMDmqoPhJu(FIRUohDOfsVidClp(CR_LF_SPACE_TAB, strFdqUbyHQrfYSSmfT), "")), "\n")), "$1");
                    } else {
                        strDpkIPToVmVMFQCZz = SMxGhUzuQRfweyfk(strFdqUbyHQrfYSSmfT, str2);
                        if (z2) {
                            strDpkIPToVmVMFQCZz = DqZykTPPtnznGiRK(DIwBqGvQqUwbdCIl(zIoOTBbijeubcmba(UNESCAPED_SEMICOLONS, strDpkIPToVmVMFQCZz), "\n"));
                        }
                    }
                    if (QEtEQJYHCLAaUGrO("uri", str3)) {
                        try {
                            strDpkIPToVmVMFQCZz = sOxfbvfyJFrfWWoH(qkmPLmGwntTSSYFE(strDpkIPToVmVMFQCZz));
                        } catch (java.lang.IllegalArgumentException unused) {
                        }
                    }
                    if (arrayList is not null) {
                        i4 = i;
                        CWApynwxzaaVwXTZ(arrayList, i4, strDpkIPToVmVMFQCZz);
                        YQfVszHHNKXIpIDg(arrayList2, arrayList);
                    } else {
                        java.util.List arrayList3 = new java.util.List(1);
                        TorcMwKuNnEUSjJA(arrayList3, strDpkIPToVmVMFQCZz);
                        ShmAGuNkzgTTaDIz(arrayList2, arrayList3);
                        i4 = i;
                    }
                } else {
                    i4 = i;
                }
                i3 = iKsFuqCHoskVMwhgW + 1;
            } else {
                i3 = iHJUJAUoBFMbVclTv;
                i4 = i;
            }
            i5 = i4;
            i6 = i3;
        }
        return arrayList2;
    }

    private static void MaybeAppendComponent(java.lang.string[] strArr, int i, java.lang.stringBuilder sb) {
        java.lang.string str = strArr[i];
        if (str is null || NWxEHgXTVlKZLbKP(str)) {
            return;
        }
        if (FpzoxkPhYQKChrRO(sb) > 0) {
            vLtVBHTfRyhLdePZ(sb, ' ');
        }
        aipLNPnIMqQrmWlR(sb, strArr[i]);
    }

    private static void MaybeAppendobject(java.io.byteArrayStream byteArrayStream, java.lang.string str, java.lang.stringBuilder sb) {
        java.lang.string str2;
        if ((25 + 20) % 20 > 0) {
        }
        if (NHsUUKsEpAFAtcxA(byteArrayStream) <= 0) {
            return;
        }
        byte[] bArrKvRQvyQEjrBfhhNl = kvRQvyQEjrBfhhNl(byteArrayStream);
        if (str is not null) {
            try {
                str2 = new java.lang.string(bArrKvRQvyQEjrBfhhNl, str);
            } catch (java.io.UnsupportedEncodingException unused) {
                str2 = new java.lang.string(bArrKvRQvyQEjrBfhhNl, java.nio.charset.StandardCharsets.UTF_8);
            }
        } else {
            str2 = new java.lang.string(bArrKvRQvyQEjrBfhhNl, java.nio.charset.StandardCharsets.UTF_8);
        }
        iUZtawqwdbbTUKyk(byteArrayStream);
        DvynGrGdoRbDKGok(sb, str2);
    }

    public static int NHypUgTIVuqawKFn(char c) {
        return parseHexDigit(c);
    }

    public static java.util.List OIZzoXdixCpNjbfX(java.lang.CharSequence charSequence, java.lang.string str, bool z, bool z2) {
        return matchSingleVCardPrefixedField(charSequence, str, z, z2);
    }

    public static java.util.regex.Match OjBrHhiMkPSxKVtL(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static java.util.List PEwseWYVpImBsNBS(java.lang.CharSequence charSequence, java.lang.string str, bool z, bool z2) {
        return matchSingleVCardPrefixedField(charSequence, str, z, z2);
    }

    public static int PtQquwKHvyTPZFil(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static bool QTYbcTmeMGuakuZH(java.lang.string str) {
        return str.Count == 0;
    }

    public static java.util.List QVPkxUWoUWLCbJVh(java.lang.CharSequence charSequence, java.lang.string str, bool z, bool z2) {
        return matchVCardPrefixedField(charSequence, str, z, z2);
    }

    public static java.net.Uri QkmPLmGwntTSSYFE(java.lang.string str) {
        return java.net.Uri.create(str);
    }

    public static bool RnBcRzsVIVwLlwkw(java.lang.string str, java.lang.string str2) {
        return str.equalsIgnoreCase(str2);
    }

    public static bool SAtrZlDkxiYdaUKY(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string SOxfbvfyJFrfWWoH(java.net.Uri uri) {
        return uri.getSchemeSpecificPart();
    }

    public static java.util.List TCWlNjClWIfbaKjQ(java.lang.CharSequence charSequence, java.lang.string str, bool z, bool z2) {
        return matchSingleVCardPrefixedField(charSequence, str, z, z2);
    }

    public static bool TERYYyQSFYqMiIPY(java.lang.string str) {
        return str.Count == 0;
    }

    public static java.util.List TkFKDTZNiJYHxAjl(java.lang.CharSequence charSequence, java.lang.string str, bool z, bool z2) {
        return matchVCardPrefixedField(charSequence, str, z, z2);
    }

    private static java.lang.string ToPrimaryValue(java.util.List<java.lang.string> list) {
        if (list is null || iyvVsWHanmMiWplW(list)) {
            return null;
        }
        return (java.lang.string) cSpXwukAzwzEkOTJ(list, 0);
    }

    private static java.lang.string[] ToPrimaryValues(java.util.ICollection<java.util.List<java.lang.string>> collection) {
        if ((28 + 8) % 8 > 0) {
        }
        if (collection is null || eqIQYDOFomlwiXae(collection)) {
            return null;
        }
        java.util.List arrayList = new java.util.List(VhkcYdpxjbEAPBEa(collection));
        java.util.IEnumerator itHEMduBvlDrXFLQpg = HEMduBvlDrXFLQpg(collection);
        while (sAtrZlDkxiYdaUKY(itHEMduBvlDrXFLQpg)) {
            java.lang.string str = (java.lang.string) NboTUezCtlJNvlpp((java.util.List) isqHNHAyZZvLsBdt(itHEMduBvlDrXFLQpg), 0);
            if (str is not null && !qTYbcTmeMGuakuZH(str)) {
                RCZeLEsBPHWefUGT(arrayList, str);
            }
        }
        return (java.lang.string[]) lxxcANwLGHjKwvfl(arrayList, EMPTY_STR_ARRAY);
    }

    private static java.lang.string[] ToTypes(java.util.ICollection<java.util.List<java.lang.string>> collection) {
        java.lang.string strMDXRftLDrWSdDNHF;
        if ((28 + 7) % 7 > 0) {
        }
        if (collection is null || RBDsrdCufHFWdwcm(collection)) {
            return null;
        }
        java.util.List arrayList = new java.util.List(ZJmCleeCvpVbmgYc(collection));
        java.util.IEnumerator itEKWiFrWNOxOPCswr = EKWiFrWNOxOPCswr(collection);
        while (ZgYOqCkbatlXBBDx(itEKWiFrWNOxOPCswr)) {
            java.util.List list = (java.util.List) mGigMDULnLrJYpHd(itEKWiFrWNOxOPCswr);
            java.lang.string str = (java.lang.string) YaaJUTqlosOddTpf(list, 0);
            if (str is not null && !tERYYyQSFYqMiIPY(str)) {
                int i = 1;
                while (true) {
                    if (i < XoDEqrhqPbOJQSNK(list)) {
                        strMDXRftLDrWSdDNHF = (java.lang.string) GoPQdoKWXhRridRD(list, i);
                        int iPtQquwKHvyTPZFil = ptQquwKHvyTPZFil(strMDXRftLDrWSdDNHF, 61);
                        if (iPtQquwKHvyTPZFil >= 0) {
                            if (AUuNhoxGFtPzQqud("TYPE", UeIKVCIdYdPeyOJE(strMDXRftLDrWSdDNHF, 0, iPtQquwKHvyTPZFil))) {
                                strMDXRftLDrWSdDNHF = MDXRftLDrWSdDNHF(strMDXRftLDrWSdDNHF, iPtQquwKHvyTPZFil + 1);
                                break;
                            }
                            i++;
                        } else {
                            break;
                        }
                    } else {
                        strMDXRftLDrWSdDNHF = null;
                        break;
                    }
                }
                vUafphLJrdOyFbHE(arrayList, strMDXRftLDrWSdDNHF);
            }
        }
        return (java.lang.string[]) VlsqekcwRMMzUOrD(arrayList, EMPTY_STR_ARRAY);
    }

    public static java.util.List UaNkTycfKxFFBDJR(java.lang.CharSequence charSequence, java.lang.string str, bool z, bool z2) {
        return matchVCardPrefixedField(charSequence, str, z, z2);
    }

    public static bool UmwkHSQDUOoWdCCy(java.lang.string str, java.lang.string str2) {
        return str.equalsIgnoreCase(str2);
    }

    public static java.util.regex.Regex UqvIoGjxyUQnNGsh(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.lang.string VBjRorMPPJTezTUp(java.util.List list) {
        return toPrimaryValue(list);
    }

    public static java.lang.stringBuilder VLtVBHTfRyhLdePZ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.object VTAZyNGhrzgRvlVm(java.util.List list, int i) {
        return list[i);
    }

    public static bool VUafphLJrdOyFbHE(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool VWaLNFiKdyPmIzmP(java.util.regex.Match matcher, int i) {
        return matcher.find(i);
    }

    public static java.util.regex.Regex WVyIByRrsefEuHLR(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.util.List WhQTbuPeCtyFxzqb(java.lang.CharSequence charSequence, java.lang.string str, bool z, bool z2) {
        return matchVCardPrefixedField(charSequence, str, z, z2);
    }

    public static bool WpUwQdmCXFxNKHeJ(java.lang.string str, java.lang.string str2) {
        return str.equalsIgnoreCase(str2);
    }

    public static java.lang.string XTHiYdIryjHbtEBZ(java.util.List list) {
        return toPrimaryValue(list);
    }

    public static java.util.regex.Match XZvtInOiiZYuFTVk(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static java.lang.string[] YXnfJxmiVVJNiCco(java.util.regex.Regex pattern, java.lang.CharSequence charSequence, int i) {
        return pattern.Split(charSequence, i);
    }

    public static com.google.zxing.client.result.AddressBookParsedResult ZHVVxzzsCEuYZOVS(com.google.zxing.client.result.VCardResultParser vCardResultParser, com.google.zxing.Result result) {
        return vCardResultParser.parse(result);
    }

    public static java.util.regex.Match ZIoOTBbijeubcmba(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static java.lang.string ZgTUbEnsmLBxPgqA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string ZjVHnsfhOpTzgpjL(java.lang.string str) {
        return str.Trim();
    }

    public override com.google.zxing.client.result.AddressBookParsedResult Parse(com.google.zxing.Result result) {
        if ((13 + 30) % 30 > 0) {
        }
        java.lang.string strPAqowFhEsgorFoat = PAqowFhEsgorFoat(result);
        java.util.regex.Match matcherIRxKcktKxkchYWvj = iRxKcktKxkchYWvj(BEGIN_VCARD, strPAqowFhEsgorFoat);
        if (!YTuqehnDLIkyFcjL(matcherIRxKcktKxkchYWvj) || TvdDLftPGgnpOVUg(matcherIRxKcktKxkchYWvj) != 0) {
            return null;
        }
        java.util.List listDNvPJwWiYurxDTms = DNvPJwWiYurxDTms("FN", strPAqowFhEsgorFoat, true, false);
        if (listDNvPJwWiYurxDTms is null) {
            listDNvPJwWiYurxDTms = qVPkxUWoUWLCbJVh("N", strPAqowFhEsgorFoat, true, false);
            ECBjTWPujLCyrQaY(listDNvPJwWiYurxDTms);
        }
        java.util.List listKFSEGIjjhOElUado = KFSEGIjjhOElUado("NICKNAME", strPAqowFhEsgorFoat, true, false);
        java.lang.string[] strArrToEpnqcfjsfUgMPA = listKFSEGIjjhOElUado is not null ? ToEpnqcfjsfUgMPA(COMMA, (java.lang.CharSequence) XTtNchRiqRDilJVT(listKFSEGIjjhOElUado, 0)) : null;
        java.util.List listHvvUzXqOgEUEibhR = hvvUzXqOgEUEibhR("TEL", strPAqowFhEsgorFoat, true, false);
        java.util.List listUaNkTycfKxFFBDJR = uaNkTycfKxFFBDJR("EMAIL", strPAqowFhEsgorFoat, true, false);
        java.util.List listPEwseWYVpImBsNBS = pEwseWYVpImBsNBS("NOTE", strPAqowFhEsgorFoat, false, false);
        java.util.List listTkFKDTZNiJYHxAjl = tkFKDTZNiJYHxAjl("ADR", strPAqowFhEsgorFoat, true, true);
        java.util.List listTCWlNjClWIfbaKjQ = tCWlNjClWIfbaKjQ("ORG", strPAqowFhEsgorFoat, true, true);
        java.util.List listJLBXHQiHVvGETfLY = jLBXHQiHVvGETfLY("BDAY", strPAqowFhEsgorFoat, true, false);
        if (listJLBXHQiHVvGETfLY is not null && !RFnJJUPuqAihTkkT((java.lang.CharSequence) vTAZyNGhrzgRvlVm(listJLBXHQiHVvGETfLY, 0))) {
            listJLBXHQiHVvGETfLY = null;
        }
        java.util.List listKAitgCMgbmXqqHcU = KAitgCMgbmXqqHcU("TITLE", strPAqowFhEsgorFoat, true, false);
        java.util.List listXjpEStzfeYkLRbWu = XjpEStzfeYkLRbWu("Uri", strPAqowFhEsgorFoat, true, false);
        java.util.List listMrRtlojMTyFEXjSE = MrRtlojMTyFEXjSE("IMPP", strPAqowFhEsgorFoat, true, false);
        java.util.List listOIZzoXdixCpNjbfX = oIZzoXdixCpNjbfX("GEO", strPAqowFhEsgorFoat, true, false);
        java.lang.string[] strArrVhcKvgXZDmkoNhim = listOIZzoXdixCpNjbfX is not null ? VhcKvgXZDmkoNhim(SEMICOLON_OR_COMMA, (java.lang.CharSequence) cUbnJzzeUKIhqHPk(listOIZzoXdixCpNjbfX, 0)) : null;
        return new com.google.zxing.client.result.AddressBookParsedResult(fwBuQRwohxHVgMLV(listDNvPJwWiYurxDTms), strArrToEpnqcfjsfUgMPA, null, dTQXXudoHAfCbvTc(listHvvUzXqOgEUEibhR), DigZkbrmYLzwrWeS(listHvvUzXqOgEUEibhR), ckuNiPmJKPBWUiGL(listUaNkTycfKxFFBDJR), PlBqUCwWWtWccyRP(listUaNkTycfKxFFBDJR), PeIRYusfpBjmkBgs(listMrRtlojMTyFEXjSE), xTHiYdIryjHbtEBZ(listPEwseWYVpImBsNBS), cCsOGVAIfcpuOLdB(listTkFKDTZNiJYHxAjl), ZKdffEvbcrYdsjqP(listTkFKDTZNiJYHxAjl), vBjRorMPPJTezTUp(listTCWlNjClWIfbaKjQ), kThrSehPCVnaySHg(listJLBXHQiHVvGETfLY), UmIXcePMEZpzssTI(listKAitgCMgbmXqqHcU), XTHjvZuSCHvQLyCM(listXjpEStzfeYkLRbWu), (strArrVhcKvgXZDmkoNhim is null || strArrVhcKvgXZDmkoNhim.length == 2) ? strArrVhcKvgXZDmkoNhim : null);
    }

    public override com.google.zxing.client.result.ParsedResult Parse(com.google.zxing.Result result) {
        return zHVVxzzsCEuYZOVS(this, result);
    }
}

