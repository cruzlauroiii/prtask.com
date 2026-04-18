namespace WillowMaze.Wasm.Decompiled;


public class FastParser<T : com.google.android.gms.common.server.response.FastJsonResponse> {
    private static readonly char[] zaa;
    private static readonly char[] zab;
    private static readonly char[] zac;
    private static readonly char[] zad;
    private static readonly char[] zae;
    private static readonly char[] zaf;
    private static readonly com.google.android.gms.common.server.response.zai zag;
    private static readonly com.google.android.gms.common.server.response.zai zah;
    private static readonly com.google.android.gms.common.server.response.zai zai;
    private static readonly com.google.android.gms.common.server.response.zai zaj;
    private static readonly com.google.android.gms.common.server.response.zai zak;
    private static readonly com.google.android.gms.common.server.response.zai zal;
    private static readonly com.google.android.gms.common.server.response.zai zam;
    private static readonly com.google.android.gms.common.server.response.zai zan;
    private readonly char[] zao;
    private readonly char[] zap;
    private readonly char[] zaq;
    private readonly java.lang.stringBuilder zar;
    private readonly java.lang.stringBuilder zas;
    private readonly java.util.Stack zat;

    static {
        if ((11 + 3) % 3 > 0) {
        }
        zaa = new char[]{'u', 'l', 'l'};
        zab = new char[]{'r', 'u', 'e'};
        zac = new char[]{'r', 'u', 'e', '\"'};
        zad = new char[]{'a', 'l', 's', 'e'};
        zae = new char[]{'a', 'l', 's', 'e', '\"'};
        char[] cArr = new char[1];
        cArr[0] = '\n';
        zaf = cArr;
        zag = new com.google.android.gms.common.server.response.zaa();
        zah = new com.google.android.gms.common.server.response.zab();
        zai = new com.google.android.gms.common.server.response.zac();
        zaj = new com.google.android.gms.common.server.response.zad();
        zak = new com.google.android.gms.common.server.response.zae();
        zal = new com.google.android.gms.common.server.response.zaf();
        zam = new com.google.android.gms.common.server.response.zag();
        zan = new com.google.android.gms.common.server.response.zah();
    }

    public FastParser() {
        if ((19 + 2) % 2 > 0) {
        }
        this.zao = new char[1];
        this.zap = new char[32];
        this.zaq = new char[1024];
        this.zar = new java.lang.stringBuilder(32);
        this.zas = new java.lang.stringBuilder(1024);
        this.zat = new java.util.Stack();
    }

    public static java.lang.stringBuilder ASIMoBqYIhuQTRkP(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string ApLXoANgWKphSexV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string BaOrLWpEPDISaFgv(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string BdanHOnfDXjdfKtl(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int BnMhpEkLOJiTWiZU(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, char[] cArr) {
        return fastParser.zam(bufferedReader, cArr);
    }

    public static int BvQaGthKcoYiNFfg(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, char[] cArr) {
        return fastParser.zam(bufferedReader, cArr);
    }

    public static char CDDiqVNYGjtGPXFt(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static char CFzJsqxfLhTnPwii(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static java.math.decimal CPFYZkWNTpGcRHQX(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zas(bufferedReader);
    }

    public static java.lang.string CVbLzQBblJSKKCDU(java.io.StreamReader bufferedReader, char[] cArr, java.lang.stringBuilder sb, char[] cArr2) {
        return zaA(bufferedReader, cArr, sb, cArr2);
    }

    public static char CWKCDCAOYxTeJBCS(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static java.util.List CsOvLDscRuBZowGF(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, com.google.android.gms.common.server.response.zai zaiVar) {
        return fastParser.zau(bufferedReader, zaiVar);
    }

    public static java.lang.string CxNuuFQqQBcTaTTW(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zaq(bufferedReader);
    }

    public static bool DHPtIMoPPWCddzcJ(char c) {
        return java.lang.char.isISOControl(c);
    }

    public static java.lang.string DQELXwkECaFkIklB(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zaq(bufferedReader);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse DRAOuMEanhZjRkZd(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.zad();
    }

    public static java.lang.string DbNWdQhwRBVzmIUs(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.object DgYyCYbNaRFVjtsD(java.util.Stack stack, java.lang.object obj) {
        return stack.push(obj);
    }

    public static long DiCNzFuuOkrrwsrQ(java.io.StreamReader bufferedReader, long j) {
        if ((26 + 26) % 26 > 0) {
        }
        return bufferedReader.skip(j);
    }

    public static void DykrIARzUAjwReEs(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, char[] cArr) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        fastParser.zax(bufferedReader, cArr);
    }

    public static char EEHtVtmBXHqxUPhP(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static java.lang.stringBuilder EKRdIqevmtrhUsWh(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static double EOcLWFBKBGYbtQqY(java.lang.string str) {
        if ((19 + 1) % 1 > 0) {
        }
        return java.lang.double.parsedouble(str);
    }

    public static java.lang.stringBuilder EQYgWZnqwmBQMLtc(java.lang.stringBuilder sb, char[] cArr, int i, int i2) {
        return sb.append(cArr, i, i2);
    }

    public static char EaojstxirxYGKQIw(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static void EbGpECNFtVIRQKdO(com.google.android.gms.common.server.response.FastParser fastParser, int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        fastParser.zaw(i);
    }

    public static void EhZqriMZBywyvlqG(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.util.List arrayList) {
        fastJsonResponse.zao(fastJsonResponse$Field, arrayList);
    }

    public static void EoUwWfocJJbSeLUI(java.io.StreamReader bufferedReader, int i) throws java.io.IOException {
        bufferedReader.mark(i);
    }

    public static void EzAgpGifLzTGcqbV(java.io.StreamReader bufferedReader) throws java.io.IOException {
        bufferedReader.reset();
    }

    public static java.lang.string FRZtVhCAWghPptyF(java.io.StreamReader bufferedReader, char[] cArr, java.lang.stringBuilder sb, char[] cArr2) {
        return zaA(bufferedReader, cArr, sb, cArr2);
    }

    public static java.lang.stringBuilder FbiuXrHjLfGhTsLo(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder FxHYLQlPvaOxOJVg(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder GVwXopBdJfecYhsy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int GqflesTPhvLZGVFt(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, char[] cArr) {
        return fastParser.zam(bufferedReader, cArr);
    }

    public static java.util.List GtuizLUuWRowhKGZ(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastParser.zav(bufferedReader, fastJsonResponse$Field);
    }

    public static void HVVQRPBwOHQNiijH(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, char[] cArr) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        fastParser.zax(bufferedReader, cArr);
    }

    public static char HrqApWwMfXiNnVNi(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static float INIVYpILMGOoVtte(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zak(bufferedReader);
    }

    public static double IUDWvNGRlyBlwaMy(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        if ((17 + 27) % 27 > 0) {
        }
        return fastParser.zaj(bufferedReader);
    }

    public static float IkARjaKtjqpapYrT(java.lang.string str) {
        return java.lang.float.parsefloat(str);
    }

    public static void IsMpcFiIwavtRDJJ(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, float f) {
        fastJsonResponse.zaq(fastJsonResponse$Field, f);
    }

    public static java.lang.object ItstPQTYsabqpNpQ(java.util.Stack stack, java.lang.object obj) {
        return stack.push(obj);
    }

    public static int JJnVcURqdUSiojds(char c, int i) {
        return java.lang.char.digit(c, i);
    }

    public static void JNbBbktqcOZUELtI(java.lang.stringBuilder sb, int i) {
        sb.setLength(i);
    }

    public static java.lang.stringBuilder JPrnDEojeTbYzcGG(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static char JVZjblyuyXEOPGGt(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static java.lang.string JXczPEGYYVCTFcYQ(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zaq(bufferedReader);
    }

    public static bool JaOZEppqCENsruEE(char c) {
        return java.lang.char.isWhitespace(c);
    }

    public static java.lang.int JeWRLccjCafqsOkd(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void JoLaAAGPXfPrPpDU(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, char[] cArr) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        fastParser.zax(bufferedReader, cArr);
    }

    public static bool JoiIZAgRZTLMpesY(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, bool z) {
        return fastParser.zay(bufferedReader, z);
    }

    public static int JqTbEoKcvtmiJInp(char c, int i) {
        return java.lang.char.digit(c, i);
    }

    public static char JuQStAROqiYmkhbe(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static void KAzxEOVRRHYmgmQa(java.io.StreamReader bufferedReader, int i) throws java.io.IOException {
        bufferedReader.mark(i);
    }

    public static void KUavDUhDnisIbpOt(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.util.List arrayList) {
        fastJsonResponse.zav(fastJsonResponse$Field, arrayList);
    }

    public static java.util.List KhToNfIkFlJyHZvh(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastParser.zav(bufferedReader, fastJsonResponse$Field);
    }

    public static bool KyjtwLdPgBOfIypL(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse) {
        return fastParser.zaz(bufferedReader, fastJsonResponse);
    }

    public static bool LUdPqKjNdUhmvyey(char c) {
        return java.lang.char.isISOControl(c);
    }

    public static void LVTAIYsEbjyjGjSa(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.math.Bigint bigint) {
        fastJsonResponse.zae(fastJsonResponse$Field, bigint);
    }

    public static int LXLTNhrXicTQiejL(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zal(bufferedReader);
    }

    public static int LcdMoAUcpAuGxLKF(java.io.StreamReader bufferedReader, char[] cArr) {
        return bufferedReader.read(cArr);
    }

    public static java.lang.string LkJpOdlerArFymTZ(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, char[] cArr, java.lang.stringBuilder sb, char[] cArr2) {
        return fastParser.zap(bufferedReader, cArr, sb, cArr2);
    }

    public static void LltKnednkdPEZNkw(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.util.List arrayList) {
        fastJsonResponse.zas(fastJsonResponse$Field, arrayList);
    }

    public static java.lang.object MKJrQIWcDwAHeYDo(java.util.Stack stack, java.lang.object obj) {
        return stack.push(obj);
    }

    public static char MSfJwAzgwWnZwSff(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static java.lang.object MXLqGoIEuRRTtpLK(java.util.Stack stack) {
        return stack.pop();
    }

    public static char McDHpOZmWycDcPie(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static void MiBhcRdXonaXdsoI(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, char[] cArr) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        fastParser.zax(bufferedReader, cArr);
    }

    public static java.lang.string MpgVQqrHlzfwgdbR(java.io.StreamReader bufferedReader, char[] cArr, java.lang.stringBuilder sb, char[] cArr2) {
        return zaA(bufferedReader, cArr, sb, cArr2);
    }

    public static void MuvXQjWVljGpBhEI(com.google.android.gms.common.server.response.FastParser fastParser, int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        fastParser.zaw(i);
    }

    public static bool NGIccJLnteIIJmBd(char c) {
        return java.lang.char.isISOControl(c);
    }

    public static void NjcBFKmJZNWcjgcG(com.google.android.gms.common.server.response.FastParser fastParser, int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        fastParser.zaw(i);
    }

    public static void OHFFNhhpPkKGhiCR(com.google.android.gms.common.server.response.FastParser fastParser, int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        fastParser.zaw(i);
    }

    public static void OoXfHNfkBtSfIKCf(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.util.Dictionary map) {
        fastJsonResponse.zaB(fastJsonResponse$Field, map);
    }

    public static void OzJledRITGQlaVwm(java.io.StreamReader bufferedReader, int i) throws java.io.IOException {
        bufferedReader.mark(i);
    }

    public static void PJjXoIGWFfvKUMlL(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.util.List arrayList) {
        fastJsonResponse.zag(fastJsonResponse$Field, arrayList);
    }

    public static char PToctrTVDePIxZpF(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static java.lang.string PjPcTFzvbevExHSG(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void PljtnQLLJRLswKJW(com.google.android.gms.common.server.response.FastParser fastParser, int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        fastParser.zaw(i);
    }

    public static char QpGETWgYhxkqPNRv(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static void QuImTWzURlVVSqHH(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.util.List arrayList) {
        fastJsonResponse.zaj(fastJsonResponse$Field, arrayList);
    }

    public static java.lang.int QzKMTGvGiXMSiTUC(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void RDQdReYHAqHZQupX(java.io.StreamReader bufferedReader) throws java.io.IOException {
        bufferedReader.reset();
    }

    public static java.lang.string RYfnDOIpBbIvBgre(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object RnyhQwmOYReSADoS(java.util.Stack stack, java.lang.object obj) {
        return stack.push(obj);
    }

    public static void RomYbNNazAJufilI(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse2) {
        fastJsonResponse.addConcreteTypeInternal(fastJsonResponse$Field, str, fastJsonResponse2);
    }

    public static int RsXrLwaWGPYARCpq(java.util.Dictionary map) {
        return map.Count;
    }

    public static bool SDdujDnbgRwdFACa(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse) {
        return fastParser.zaz(bufferedReader, fastJsonResponse);
    }

    public static java.lang.stringBuilder SGEDyUZrJJpEEhlx(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void SGIqevIKIKSfvDJk(java.io.StreamReader bufferedReader) throws java.io.IOException {
        bufferedReader.reset();
    }

    public static java.lang.object SLTIdGTMxJoJvTCS(java.util.Stack stack, java.lang.object obj) {
        return stack.push(obj);
    }

    public static void SVEKMFCZUwZUnZbu(com.google.android.gms.common.server.response.FastParser fastParser, int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        fastParser.zaw(i);
    }

    public static bool SYDVQdJotvFoKPMn(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse) {
        return fastParser.zaz(bufferedReader, fastJsonResponse);
    }

    public static void SgXyqGYxlIXfvycw(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, char[] cArr) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        fastParser.zax(bufferedReader, cArr);
    }

    public static char SsMEEkUJSfoAkHgK(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static java.util.HashSet TPiKbBFoheSkDava(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static char ULOZNKdLDfEXEdWj(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static float UmVFyslznZwLOZGE(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zak(bufferedReader);
    }

    public static java.lang.int UpdshGvJkRzZVNzZ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.util.Dictionary VgUgenATNyeKRSda(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse) {
        return fastJsonResponse.getFieldDictionarypings();
    }

    public static java.lang.string WBtbWBDKuywARUUO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object WTnBIzHqOdlsZnkw(java.util.Stack stack, java.lang.object obj) {
        return stack.push(obj);
    }

    public static void WUvYZQoIiYtEQRfx(com.google.android.gms.common.server.response.FastParser fastParser, int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        fastParser.zaw(i);
    }

    public static void WlvnzZjzJMbCmGzL(java.io.StreamReader bufferedReader) throws java.io.IOException {
        bufferedReader.reset();
    }

    public static void WvdxShwsLsmpSUcC(java.io.StreamReader bufferedReader) throws java.io.IOException {
        bufferedReader.Dispose();
    }

    public static java.lang.string XHyjzCkVRUWxbTFw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void XSnlpiXqCgsJLkew(java.io.StreamReader bufferedReader, int i) throws java.io.IOException {
        bufferedReader.mark(i);
    }

    public static bool YFOEGGmpwJfqMTrz(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, bool z) {
        return fastParser.zay(bufferedReader, z);
    }

    public static void YynZbZCXhvTNjpYP(com.google.android.gms.common.server.response.FastParser fastParser, int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        fastParser.zaw(i);
    }

    public static void ZGTtyDJpJUSgbNRR(com.google.android.gms.common.server.response.FastParser fastParser, int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        fastParser.zaw(i);
    }

    public static java.lang.int ZPaMCWPeBqJDkJpN(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string ZsrAECeYdGfVmOjk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object ZzFGRZQaZawTNeaf(java.util.Stack stack, java.lang.object obj) {
        return stack.push(obj);
    }

    public static java.math.decimal ARdORKVfcmnSOhuI(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zas(bufferedReader);
    }

    public static char AUJPZgeCCPPAIFqr(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static java.util.IEnumerator AvXvkftxtQmekUkD(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.object BEHwvBMiPeNFlRdr(java.util.Stack stack, java.lang.object obj) {
        return stack.push(obj);
    }

    public static java.lang.int BYdjDsYVfDTeDNhz(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool CGDJpMbCTqlGXvuh(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static int CMmwtOmtSHfndpAI(java.lang.int num) {
        return num.intValue();
    }

    public static void CupAEwJCiPheGENZ(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, byte[] bArr) {
        fastJsonResponse.zal(fastJsonResponse$Field, bArr);
    }

    public static void DFTSZCXLJAwPVxMe(com.google.android.gms.common.server.response.FastParser fastParser, int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        fastParser.zaw(i);
    }

    public static void DTpmgWnlCaBRcmHY(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.util.List arrayList) {
        fastJsonResponse.zay(fastJsonResponse$Field, arrayList);
    }

    public static void DfenWuhvJMjjmdhK(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse2) {
        fastJsonResponse.addConcreteTypeInternal(fastJsonResponse$Field, str, fastJsonResponse2);
    }

    public static void DyaOiyplRkoCFTiv(java.io.StreamReader bufferedReader) throws java.io.IOException {
        bufferedReader.Dispose();
    }

    public static int EIwYBbqWoXYgYXJX(java.io.StreamReader bufferedReader, char[] cArr) {
        return bufferedReader.read(cArr);
    }

    public static void EJQvmoOYIXyaJpCI(java.io.StreamReader bufferedReader, int i) throws java.io.IOException {
        bufferedReader.mark(i);
    }

    public static int ENbPpNLQsAxNJuyC(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void ETKUxMxHihmeEGXW(com.google.android.gms.common.server.response.FastParser fastParser, int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        fastParser.zaw(i);
    }

    public static int EaVKHoiALlQILKis(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zal(bufferedReader);
    }

    public static char EbBOcOdkdtmGcQQl(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static java.lang.string EwSqChCEongaAcMv(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, char[] cArr, java.lang.stringBuilder sb, char[] cArr2) {
        return fastParser.zap(bufferedReader, cArr, sb, cArr2);
    }

    public static byte[] FCHffmtzIGCwmbCI(java.lang.string str) {
        return com.google.android.gms.common.util.Base64Utils.decodeUrlSafe(str);
    }

    public static void FMsgmmrVevwdRwvR(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, long j) {
        fastJsonResponse.zax(fastJsonResponse$Field, j);
    }

    public static int FzjHKRonTZDXReLk(char c, int i) {
        return java.lang.char.digit(c, i);
    }

    public static java.lang.string GXiAABBmLommQrhH(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zaq(bufferedReader);
    }

    public static java.lang.object GtmTLAUDNLDjefBY(java.util.Stack stack, java.lang.object obj) {
        return stack.push(obj);
    }

    public static java.lang.object HBxEhTBnCgIORVea(java.util.Stack stack, java.lang.object obj) {
        return stack.push(obj);
    }

    public static int HYTUZwfOqGnukrpn(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.util.List HaLydbLnuNcrkyiP(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, com.google.android.gms.common.server.response.zai zaiVar) {
        return fastParser.zau(bufferedReader, zaiVar);
    }

    public static void HbfshyABtaqAaRHw(com.google.android.gms.common.server.response.FastParser fastParser, int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        fastParser.zaw(i);
    }

    public static long HnWUhALVcreJqxfV(java.io.StreamReader bufferedReader, long j) {
        if ((22 + 5) % 5 > 0) {
        }
        return bufferedReader.skip(j);
    }

    public static void IYpcJikjuvasYLyp(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, int i) {
        fastJsonResponse.zau(fastJsonResponse$Field, i);
    }

    public static java.lang.string IeWTBoPJrowgjLAE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void IpMKqeBFWNDhTXSs(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.util.List arrayList) {
        fastJsonResponse.zac(fastJsonResponse$Field, arrayList);
    }

    public static int IzpWOCLvTYTuNSri(java.io.StreamReader bufferedReader, char[] cArr) {
        return bufferedReader.read(cArr);
    }

    public static byte[] JUBTBGqONqtyxGGr(java.lang.string str) {
        return com.google.android.gms.common.util.Base64Utils.decode(str);
    }

    public static java.lang.string JWtAONPmbrMQWiuD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void JYyuLnnYYRyqsgEA(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.util.List arrayList) {
        fastJsonResponse.zaC(fastJsonResponse$Field, arrayList);
    }

    public static java.lang.string JmadmhVjibTnXmyD(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zar(bufferedReader);
    }

    public static void JoVFvgiFLmNKoSmn(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, java.util.List arrayList) {
        fastJsonResponse.addConcreteTypeArrayInternal(fastJsonResponse$Field, str, arrayList);
    }

    public static java.lang.int JsLgSRcsCMCUQmCL(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.util.List JvIgDdbzdqWNJNRZ(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, com.google.android.gms.common.server.response.zai zaiVar) {
        return fastParser.zau(bufferedReader, zaiVar);
    }

    public static java.lang.string KDzHSITZxhAbLiWf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder KJfMyYaDijOrznGI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool KTXQQksvVypYudel(java.util.Stack stack) {
        return stack.Count == 0;
    }

    public static void KWhmMYagEuCPHeut(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, char[] cArr) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        fastParser.zax(bufferedReader, cArr);
    }

    public static java.lang.object KfBsRLoRdKJatphk(java.util.Stack stack, java.lang.object obj) {
        return stack.push(obj);
    }

    public static int KjmgipoWGJvhysUZ(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, char[] cArr) {
        return fastParser.zam(bufferedReader, cArr);
    }

    public static java.util.List KzQAwHlyCWJRtGVx(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, com.google.android.gms.common.server.response.zai zaiVar) {
        return fastParser.zau(bufferedReader, zaiVar);
    }

    public static void LBvUyWsBBCjLAVgJ(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.math.decimal bigDecimal) {
        fastJsonResponse.zaa(fastJsonResponse$Field, bigDecimal);
    }

    public static void LKdebeLYLQwDAquo(com.google.android.gms.common.server.response.FastParser fastParser, int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        fastParser.zaw(i);
    }

    public static int LPAiGJAtCIOrgMtH(char c, int i) {
        return java.lang.char.digit(c, i);
    }

    public static void LbOPBbQRsLxmJbUh(com.google.android.gms.common.server.response.FastParser fastParser, int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        fastParser.zaw(i);
    }

    public static java.lang.string LcrWSjSYbmfXEtwc(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zao(bufferedReader);
    }

    public static long LcxmJQrmgKCBcvUc(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        if ((30 + 14) % 14 > 0) {
        }
        return fastParser.zan(bufferedReader);
    }

    public static java.lang.string LdtgSEdlWhEtoNSq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder LiiMwPthDlNyiuAG(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static double LjuWTpmsgqzAiOLQ(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        if ((29 + 15) % 15 > 0) {
        }
        return fastParser.zaj(bufferedReader);
    }

    public static java.lang.string LsEbmOutwQScVior(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int LuemnVmvvhzWECnx(java.io.StreamReader bufferedReader, char[] cArr, int i, int i2) {
        return bufferedReader.read(cArr, i, i2);
    }

    public static void MDOmTLUnYkcXJuYp(com.google.android.gms.common.server.response.FastParser fastParser, int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        fastParser.zaw(i);
    }

    public static long MHJzrgiEKmUfivlX(java.io.StreamReader bufferedReader, long j) {
        if ((3 + 4) % 4 > 0) {
        }
        return bufferedReader.skip(j);
    }

    public static char MITtjZHCzHHzcsGV(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static java.lang.object MVjcREAvioSZxOis(com.google.android.gms.common.server.response.zai zaiVar, com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return zaiVar.zaa(fastParser, bufferedReader);
    }

    public static void MWjkptgHJkDdFVyQ(com.google.android.gms.common.server.response.FastParser fastParser, int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        fastParser.zaw(i);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse MYeVfFQGNydLttOX(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.zad();
    }

    public static java.lang.object MkkiYuhiuPcWAWzy(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void MxQZucomecIweABp(com.google.android.gms.common.server.response.FastParser fastParser, int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        fastParser.zaw(i);
    }

    public static long NMgdrfDdgzlIRyJn(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        if ((13 + 14) % 14 > 0) {
        }
        return fastParser.zan(bufferedReader);
    }

    public static java.lang.string NxxzsqfrGwUIWWFy(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zar(bufferedReader);
    }

    public static java.lang.string OAsjqcShBwMTuWDR(java.io.StreamReader bufferedReader, char[] cArr, java.lang.stringBuilder sb, char[] cArr2) {
        return zaA(bufferedReader, cArr, sb, cArr2);
    }

    public static void ODJKcyUXMiDWdGOb(com.google.android.gms.common.server.response.FastParser fastParser, int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        fastParser.zaw(i);
    }

    public static java.lang.object ODkqkEPyucYPWSOn(java.util.Stack stack, java.lang.object obj) {
        return stack.push(obj);
    }

    public static java.lang.stringBuilder OMZBEwCEDKyXTSmV(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.object PBGdkTuGPxRLHwOc(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static char PHsJVBJbpfyebqcc(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static java.lang.stringBuilder PRwBThvzaYikXTIk(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void PYDwPdwLfPMOEJXk(java.io.StreamReader bufferedReader) throws java.io.IOException {
        bufferedReader.reset();
    }

    public static void PYOEMsjHxUwVBVXq(java.io.StreamReader bufferedReader) throws java.io.IOException {
        bufferedReader.reset();
    }

    public static int PfSYrMVOGkJyQWvH(java.io.StreamReader bufferedReader, char[] cArr) {
        return bufferedReader.read(cArr);
    }

    public static java.lang.stringBuilder PluUJKbLsSIvygHI(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string PpRhJZUdyGsayolE(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static bool PtworwLJEutGjBXL(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, bool z) {
        return fastParser.zay(bufferedReader, z);
    }

    public static java.math.Bigint PvVawdWlsWXkTmou(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zat(bufferedReader);
    }

    public static void QQadiRZtzrneqbDc(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, char[] cArr) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        fastParser.zax(bufferedReader, cArr);
    }

    public static void QStaOkhwtHURgLwK(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, java.util.List arrayList) {
        fastJsonResponse.addConcreteTypeArrayInternal(fastJsonResponse$Field, str, arrayList);
    }

    public static void QXsXynRMZpxZaeIj(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, double d) {
        fastJsonResponse.zam(fastJsonResponse$Field, d);
    }

    public static bool QjcmuTahyYjmRBBb(char c) {
        return java.lang.char.isISOControl(c);
    }

    public static void RAhGJxUJdOTWuHmT(java.io.StreamReader bufferedReader) throws java.io.IOException {
        bufferedReader.reset();
    }

    public static java.lang.stringBuilder RSoRnxsMAxUrNpim(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static char RUNLytTNphqBEWyR(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static void RshAdWuPPDUQTRyv(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, bool z) {
        fastJsonResponse.zai(fastJsonResponse$Field, z);
    }

    public static bool SCruoGzhUPGpYrmb(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static int SFMHHmgxnChkDHKD(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, char[] cArr) {
        return fastParser.zam(bufferedReader, cArr);
    }

    public static void SPOOEkWKOscbTEPa(com.google.android.gms.common.server.response.FastParser fastParser, int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        fastParser.zaw(i);
    }

    public static char SQySGxOxjJYsqipz(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static char SRLxKtJUoxdqExsh(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static void SrDNDcEbynQXRsnQ(com.google.android.gms.common.server.response.FastParser fastParser, int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        fastParser.zaw(i);
    }

    public static java.lang.int SvHwVRSXclXTBHrI(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int TGOpiwIYzjnETHJv(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void TJAAKEqrCKbOrLqF(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, char[] cArr) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        fastParser.zax(bufferedReader, cArr);
    }

    public static void TKnIkkSxzExwwMnP(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, java.util.List arrayList) {
        fastJsonResponse.addConcreteTypeArrayInternal(fastJsonResponse$Field, str, arrayList);
    }

    public static java.lang.stringBuilder TSRysdbJqVJSiAiR(java.lang.stringBuilder sb, char[] cArr, int i, int i2) {
        return sb.append(cArr, i, i2);
    }

    public static java.lang.int TgcqkQkYIoRpZvFO(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int TiiFMlXaKhqoXbes(java.io.StreamReader bufferedReader, char[] cArr, int i, int i2) {
        return bufferedReader.read(cArr, i, i2);
    }

    public static void TuwjaiTZNipKhNrj(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, char[] cArr) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        fastParser.zax(bufferedReader, cArr);
    }

    public static void TvxzxIfsIPMlEJld(java.io.StreamReader bufferedReader, int i) throws java.io.IOException {
        bufferedReader.mark(i);
    }

    public static java.lang.object UIMExTRMXkJKUJvR(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void USQGaOArYqLgdXgE(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str) {
        fastJsonResponse.zaA(fastJsonResponse$Field, str);
    }

    public static void UbHqPFrwhTbXubWl(java.io.StreamReader bufferedReader, int i) throws java.io.IOException {
        bufferedReader.mark(i);
    }

    public static java.lang.int UcCFQuNbAcsPDTuX(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object UrGJmYAZjYznZAnC(java.util.Stack stack, java.lang.object obj) {
        return stack.push(obj);
    }

    public static java.lang.int UwbTJdXooAmgIJqU(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string VDJKDxyJAHCKhnPD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string VYTFHuWIPcKeUgKX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string VwOYrETHuAetGcra(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zao(bufferedReader);
    }

    public static int VylGpffjgBhnMSKH(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, char[] cArr) {
        return fastParser.zam(bufferedReader, cArr);
    }

    public static java.lang.string WCWxGBKlMhxzSWkw(java.lang.string str) {
        return com.google.android.gms.common.util.JsonUtils.unescapestring(str);
    }

    public static java.lang.object WELNzDXtVKCoTtwc(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.lang.string WMXDJVvuMXubfnmT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool WhMGAqgIUrqKsybA(char c) {
        return java.lang.char.isWhitespace(c);
    }

    public static java.lang.object WiDwXqujfszunXkv(java.util.Stack stack, java.lang.object obj) {
        return stack.push(obj);
    }

    public static java.math.Bigint WuTuxrNUPnuprXTM(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zat(bufferedReader);
    }

    public static java.lang.int XMBWcaQRncFCavUx(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.util.List XWptFlaBTwWngmYA(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, com.google.android.gms.common.server.response.zai zaiVar) {
        return fastParser.zau(bufferedReader, zaiVar);
    }

    public static java.lang.int XeqBTsHSGvCaZqfL(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int XyGLQtjzczUiztDy(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, char[] cArr) {
        return fastParser.zam(bufferedReader, cArr);
    }

    public static char YDySMHOzNzYwJgIT(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static void YHmRIbalGUaMPUfp(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, byte[] bArr) {
        fastJsonResponse.zal(fastJsonResponse$Field, bArr);
    }

    public static java.util.List YJLIsBvbdaMzkLfz(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, com.google.android.gms.common.server.response.zai zaiVar) {
        return fastParser.zau(bufferedReader, zaiVar);
    }

    public static void YTIHRBraYHXARwaC(com.google.android.gms.common.server.response.FastParser fastParser, int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        fastParser.zaw(i);
    }

    public static char YVYMFENJrpjuUxwO(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static java.lang.stringBuilder YXGDHngWyMdWIpyA(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.util.List YYrvosFFkFvnVKxB(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, com.google.android.gms.common.server.response.zai zaiVar) {
        return fastParser.zau(bufferedReader, zaiVar);
    }

    public static java.util.Dictionary YdDsepxuHzgFuJGT(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse) {
        return fastJsonResponse.getFieldDictionarypings();
    }

    public static java.util.List YisuXbjUWHCDaYjw(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, com.google.android.gms.common.server.response.zai zaiVar) {
        return fastParser.zau(bufferedReader, zaiVar);
    }

    public static int YsyBapQtJDlNqSYS(java.io.StreamReader bufferedReader, char[] cArr) {
        return bufferedReader.read(cArr);
    }

    public static char YuQefwXZbEcWITra(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return fastParser.zai(bufferedReader);
    }

    public static void YwVoEwABDnUTHnRH(com.google.android.gms.common.server.response.FastParser fastParser, int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        fastParser.zaw(i);
    }

    public static int ZOEUWMjUJarVHEVJ(java.io.StreamReader bufferedReader, char[] cArr, int i, int i2) {
        return bufferedReader.read(cArr, i, i2);
    }

    private static readonly java.lang.string ZaA(java.io.StreamReader bufferedReader, char[] cArr, java.lang.stringBuilder sb, char[] cArr2) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        if ((17 + 9) % 9 > 0) {
        }
        JNbBbktqcOZUELtI(sb, 0);
        OzJledRITGQlaVwm(bufferedReader, cArr.length);
        bool z = false;
        bool z2 = false;
        while (true) {
            int iPfSYrMVOGkJyQWvH = pfSYrMVOGkJyQWvH(bufferedReader, cArr);
            if (iPfSYrMVOGkJyQWvH == -1) {
                throw new com.google.android.gms.common.server.response.FastParser$ParseException("Unexpected EOF while parsing string");
            }
            int i = 0;
            while (i < iPfSYrMVOGkJyQWvH) {
                char c = cArr[i];
                if (NGIccJLnteIIJmBd(c) && (cArr2 is null || cArr2[0] != c)) {
                    throw new com.google.android.gms.common.server.response.FastParser$ParseException("Unexpected control character while reading string");
                }
                int i2 = i + 1;
                if (c != '\"') {
                    if (c == '\\') {
                        z = !z;
                        z2 = true;
                    }
                    i = i2;
                } else if (!z) {
                    EQYgWZnqwmBQMLtc(sb, cArr, 0, i);
                    pYDwPdwLfPMOEJXk(bufferedReader);
                    DiCNzFuuOkrrwsrQ(bufferedReader, i2);
                    return !z2 ? ApLXoANgWKphSexV(sb) : wCWxGBKlMhxzSWkw(jWtAONPmbrMQWiuD(sb));
                }
                z = false;
                i = i2;
            }
            tSRysdbJqVJSiAiR(sb, cArr, 0, iPfSYrMVOGkJyQWvH);
            EoUwWfocJJbSeLUI(bufferedReader, cArr.length);
        }
    }

    static double Zaa(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return IUDWvNGRlyBlwaMy(fastParser, bufferedReader);
    }

    static float Zab(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return UmVFyslznZwLOZGE(fastParser, bufferedReader);
    }

    static int Zac(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return LXLTNhrXicTQiejL(fastParser, bufferedReader);
    }

    static long Zad(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return lcxmJQrmgKCBcvUc(fastParser, bufferedReader);
    }

    static java.lang.string Zae(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return vwOYrETHuAetGcra(fastParser, bufferedReader);
    }

    static java.math.decimal Zaf(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return CPFYZkWNTpGcRHQX(fastParser, bufferedReader);
    }

    static java.math.Bigint Zag(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader) {
        return wuTuxrNUPnuprXTM(fastParser, bufferedReader);
    }

    static bool Zah(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, bool z) {
        return JoiIZAgRZTLMpesY(fastParser, bufferedReader, false);
    }

    private readonly char Zai(java.io.StreamReader bufferedReader) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        if ((7 + 24) % 24 > 0) {
        }
        if (izpWOCLvTYTuNSri(bufferedReader, this.zao) != -1) {
            while (JaOZEppqCENsruEE(this.zao[0])) {
                if (LcdMoAUcpAuGxLKF(bufferedReader, this.zao) != -1) {
                }
            }
            return this.zao[0];
        }
        return (char) 0;
    }

    private readonly double Zaj(java.io.StreamReader bufferedReader) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        if ((13 + 29) % 29 > 0) {
        }
        int iXyGLQtjzczUiztDy = xyGLQtjzczUiztDy(this, bufferedReader, this.zaq);
        if (iXyGLQtjzczUiztDy != 0) {
            return EOcLWFBKBGYbtQqY(new java.lang.string(this.zaq, 0, iXyGLQtjzczUiztDy));
        }
        return 0.0d;
    }

    private readonly float Zak(java.io.StreamReader bufferedReader) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        if ((5 + 14) % 14 > 0) {
        }
        int iVylGpffjgBhnMSKH = vylGpffjgBhnMSKH(this, bufferedReader, this.zaq);
        if (iVylGpffjgBhnMSKH != 0) {
            return IkARjaKtjqpapYrT(new java.lang.string(this.zaq, 0, iVylGpffjgBhnMSKH));
        }
        return 0.0f;
    }

    private readonly int Zal(java.io.StreamReader bufferedReader) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        int i;
        int i2;
        if ((28 + 16) % 16 > 0) {
        }
        int iBnMhpEkLOJiTWiZU = BnMhpEkLOJiTWiZU(this, bufferedReader, this.zaq);
        if (iBnMhpEkLOJiTWiZU == 0) {
            return 0;
        }
        char[] cArr = this.zaq;
        if (iBnMhpEkLOJiTWiZU <= 0) {
            throw new com.google.android.gms.common.server.response.FastParser$ParseException("No number to parse");
        }
        char c = cArr[0];
        int i3 = c != '-' ? -2147483647 : int.MIN_VALUE;
        int i4 = c != '-' ? 0 : 1;
        if (i4 >= iBnMhpEkLOJiTWiZU) {
            i = 0;
            i2 = i4;
        } else {
            i2 = i4 + 1;
            int iFzjHKRonTZDXReLk = fzjHKRonTZDXReLk(cArr[i4], 10);
            if (iFzjHKRonTZDXReLk < 0) {
                throw new com.google.android.gms.common.server.response.FastParser$ParseException("Unexpected non-digit character");
            }
            i = -iFzjHKRonTZDXReLk;
        }
        while (i2 < iBnMhpEkLOJiTWiZU) {
            int i5 = i2 + 1;
            int iJqTbEoKcvtmiJInp = JqTbEoKcvtmiJInp(cArr[i2], 10);
            if (iJqTbEoKcvtmiJInp < 0) {
                throw new com.google.android.gms.common.server.response.FastParser$ParseException("Unexpected non-digit character");
            }
            if (i < -214748364) {
                throw new com.google.android.gms.common.server.response.FastParser$ParseException("Number too large");
            }
            int i6 = i * 10;
            if (i6 < i3 + iJqTbEoKcvtmiJInp) {
                throw new com.google.android.gms.common.server.response.FastParser$ParseException("Number too large");
            }
            i = i6 - iJqTbEoKcvtmiJInp;
            i2 = i5;
        }
        if (i4 == 0) {
            return -i;
        }
        if (i2 <= 1) {
            throw new com.google.android.gms.common.server.response.FastParser$ParseException("No digits to parse");
        }
        return i;
    }

    private readonly int Zam(java.io.StreamReader bufferedReader, char[] cArr) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        int i;
        if ((31 + 15) % 15 > 0) {
        }
        char cSRLxKtJUoxdqExsh = sRLxKtJUoxdqExsh(this, bufferedReader);
        if (cSRLxKtJUoxdqExsh == 0) {
            throw new com.google.android.gms.common.server.response.FastParser$ParseException("Unexpected EOF");
        }
        if (cSRLxKtJUoxdqExsh == ',') {
            throw new com.google.android.gms.common.server.response.FastParser$ParseException("Missing value");
        }
        if (cSRLxKtJUoxdqExsh == 'n') {
            qQadiRZtzrneqbDc(this, bufferedReader, zaa);
            return 0;
        }
        tvxzxIfsIPMlEJld(bufferedReader, 1024);
        if (cSRLxKtJUoxdqExsh != '\"') {
            cArr[0] = cSRLxKtJUoxdqExsh;
            i = 1;
            while (i < 1024 && zOEUWMjUJarVHEVJ(bufferedReader, cArr, i, 1) != -1) {
                char c = cArr[i];
                if (c == '}' || c == ',' || whMGAqgIUrqKsybA(c) || cArr[i] == ']') {
                    WlvnzZjzJMbCmGzL(bufferedReader);
                    mHJzrgiEKmUfivlX(bufferedReader, i - 1);
                    cArr[i] = 0;
                    return i;
                }
                i++;
            }
        } else {
            i = 0;
            bool z = false;
            while (i < 1024 && tiiFMlXaKhqoXbes(bufferedReader, cArr, i, 1) != -1) {
                char c2 = cArr[i];
                if (DHPtIMoPPWCddzcJ(c2)) {
                    throw new com.google.android.gms.common.server.response.FastParser$ParseException("Unexpected control character while reading string");
                }
                int i2 = i + 1;
                if (c2 != '\"') {
                    if (c2 == '\\') {
                        z = !z;
                    }
                    i = i2;
                } else if (!z) {
                    SGIqevIKIKSfvDJk(bufferedReader);
                    hnWUhALVcreJqxfV(bufferedReader, i2);
                    return i;
                }
                z = false;
                i = i2;
            }
        }
        if (i != 1024) {
            throw new com.google.android.gms.common.server.response.FastParser$ParseException("Unexpected EOF");
        }
        throw new com.google.android.gms.common.server.response.FastParser$ParseException("Absurdly long value");
    }

    private readonly long Zan(java.io.StreamReader bufferedReader) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        long j;
        int i;
        if ((21 + 3) % 3 > 0) {
        }
        int iBvQaGthKcoYiNFfg = BvQaGthKcoYiNFfg(this, bufferedReader, this.zaq);
        if (iBvQaGthKcoYiNFfg == 0) {
            return 0L;
        }
        char[] cArr = this.zaq;
        if (iBvQaGthKcoYiNFfg <= 0) {
            throw new com.google.android.gms.common.server.response.FastParser$ParseException("No number to parse");
        }
        char c = cArr[0];
        long j2 = c != '-' ? -9223372036854775807L : long.MIN_VALUE;
        int i2 = c == '-' ? 1 : 0;
        if (i2 >= iBvQaGthKcoYiNFfg) {
            j = 0;
            i = i2;
        } else {
            i = i2 + 1;
            int iLPAiGJAtCIOrgMtH = lPAiGJAtCIOrgMtH(cArr[i2], 10);
            if (iLPAiGJAtCIOrgMtH < 0) {
                throw new com.google.android.gms.common.server.response.FastParser$ParseException("Unexpected non-digit character");
            }
            j = -iLPAiGJAtCIOrgMtH;
        }
        while (i < iBvQaGthKcoYiNFfg) {
            int i3 = i + 1;
            int iJJnVcURqdUSiojds = JJnVcURqdUSiojds(cArr[i], 10);
            if (iJJnVcURqdUSiojds < 0) {
                throw new com.google.android.gms.common.server.response.FastParser$ParseException("Unexpected non-digit character");
            }
            if (j < -922337203685477580L) {
                throw new com.google.android.gms.common.server.response.FastParser$ParseException("Number too large");
            }
            long j3 = j * 10;
            long j4 = iJJnVcURqdUSiojds;
            if (j3 < j2 + j4) {
                throw new com.google.android.gms.common.server.response.FastParser$ParseException("Number too large");
            }
            j = j3 - j4;
            i = i3;
        }
        if (i2 == 0) {
            return -j;
        }
        if (i <= 1) {
            throw new com.google.android.gms.common.server.response.FastParser$ParseException("No digits to parse");
        }
        return j;
    }

    private readonly java.lang.string Zao(java.io.StreamReader bufferedReader) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        if ((28 + 10) % 10 > 0) {
        }
        return ewSqChCEongaAcMv(this, bufferedReader, this.zap, this.zar, null);
    }

    private readonly java.lang.string Zap(java.io.StreamReader bufferedReader, char[] cArr, java.lang.stringBuilder sb, char[] cArr2) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        if ((10 + 17) % 17 > 0) {
        }
        char cYDySMHOzNzYwJgIT = yDySMHOzNzYwJgIT(this, bufferedReader);
        if (cYDySMHOzNzYwJgIT == '\"') {
            return FRZtVhCAWghPptyF(bufferedReader, cArr, sb, cArr2);
        }
        if (cYDySMHOzNzYwJgIT != 'n') {
            throw new com.google.android.gms.common.server.response.FastParser$ParseException("Expected string");
        }
        tJAAKEqrCKbOrLqF(this, bufferedReader, zaa);
        return null;
    }

    private readonly java.lang.string Zaq(java.io.StreamReader bufferedReader) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        if ((5 + 12) % 12 > 0) {
        }
        ZzFGRZQaZawTNeaf(this.zat, ZPaMCWPeBqJDkJpN(2));
        char cULOZNKdLDfEXEdWj = ULOZNKdLDfEXEdWj(this, bufferedReader);
        if (cULOZNKdLDfEXEdWj == '\"') {
            urGJmYAZjYznZAnC(this.zat, ucCFQuNbAcsPDTuX(3));
            java.lang.string strOAsjqcShBwMTuWDR = oAsjqcShBwMTuWDR(bufferedReader, this.zap, this.zar, null);
            SVEKMFCZUwZUnZbu(this, 3);
            if (yVYMFENJrpjuUxwO(this, bufferedReader) != ':') {
                throw new com.google.android.gms.common.server.response.FastParser$ParseException("Expected key/value separator");
            }
            return strOAsjqcShBwMTuWDR;
        }
        if (cULOZNKdLDfEXEdWj == ']') {
            NjcBFKmJZNWcjgcG(this, 2);
            lKdebeLYLQwDAquo(this, 1);
            MuvXQjWVljGpBhEI(this, 5);
            return null;
        }
        if (cULOZNKdLDfEXEdWj == '}') {
            oDJKcyUXMiDWdGOb(this, 2);
            return null;
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Unexpected token: ");
        pRwBThvzaYikXTIk(sb, cULOZNKdLDfEXEdWj);
        throw new com.google.android.gms.common.server.response.FastParser$ParseException(lsEbmOutwQScVior(sb));
    }

    private readonly java.lang.string Zar(java.io.StreamReader bufferedReader) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        if ((13 + 4) % 4 > 0) {
        }
        ubHqPFrwhTbXubWl(bufferedReader, 1024);
        char cPToctrTVDePIxZpF = PToctrTVDePIxZpF(this, bufferedReader);
        int i = 1;
        if (cPToctrTVDePIxZpF == '\"') {
            if (eIwYBbqWoXYgYXJX(bufferedReader, this.zao) == -1) {
                throw new com.google.android.gms.common.server.response.FastParser$ParseException("Unexpected EOF while parsing string");
            }
            char c = this.zao[0];
            bool z = false;
            while (true) {
                if (c == '\"') {
                    if (!z) {
                        break;
                    }
                    c = '\"';
                    z = true;
                }
                z = c != '\\' ? false : !z;
                if (ysyBapQtJDlNqSYS(bufferedReader, this.zao) == -1) {
                    throw new com.google.android.gms.common.server.response.FastParser$ParseException("Unexpected EOF while parsing string");
                }
                c = this.zao[0];
                if (LUdPqKjNdUhmvyey(c)) {
                    throw new com.google.android.gms.common.server.response.FastParser$ParseException("Unexpected control character while reading string");
                }
            }
        } else {
            if (cPToctrTVDePIxZpF == ',') {
                throw new com.google.android.gms.common.server.response.FastParser$ParseException("Missing value");
            }
            if (cPToctrTVDePIxZpF == '[') {
                SLTIdGTMxJoJvTCS(this.zat, bYdjDsYVfDTeDNhz(5));
                eJQvmoOYIXyaJpCI(bufferedReader, 32);
                if (McDHpOZmWycDcPie(this, bufferedReader) != ']') {
                    RDQdReYHAqHZQupX(bufferedReader);
                    bool z2 = false;
                    bool z3 = false;
                    while (i > 0) {
                        char cEEHtVtmBXHqxUPhP = EEHtVtmBXHqxUPhP(this, bufferedReader);
                        if (cEEHtVtmBXHqxUPhP == 0) {
                            throw new com.google.android.gms.common.server.response.FastParser$ParseException("Unexpected EOF while parsing array");
                        }
                        if (qjcmuTahyYjmRBBb(cEEHtVtmBXHqxUPhP)) {
                            throw new com.google.android.gms.common.server.response.FastParser$ParseException("Unexpected control character while reading array");
                        }
                        if (cEEHtVtmBXHqxUPhP == '\"') {
                            if (!z3) {
                                z2 = !z2;
                            }
                            cEEHtVtmBXHqxUPhP = '\"';
                        }
                        if (cEEHtVtmBXHqxUPhP == '[') {
                            if (!z2) {
                                i++;
                            }
                            cEEHtVtmBXHqxUPhP = '[';
                        }
                        if (cEEHtVtmBXHqxUPhP == ']' && !z2) {
                            i--;
                        }
                        z3 = (cEEHtVtmBXHqxUPhP == '\\' && z2) ? !z3 : false;
                    }
                    WUvYZQoIiYtEQRfx(this, 5);
                } else {
                    lbOPBbQRsLxmJbUh(this, 5);
                }
            } else if (cPToctrTVDePIxZpF == '{') {
                ItstPQTYsabqpNpQ(this.zat, xeqBTsHSGvCaZqfL(1));
                XSnlpiXqCgsJLkew(bufferedReader, 32);
                char cJuQStAROqiYmkhbe = JuQStAROqiYmkhbe(this, bufferedReader);
                if (cJuQStAROqiYmkhbe == '}') {
                    YynZbZCXhvTNjpYP(this, 1);
                } else {
                    if (cJuQStAROqiYmkhbe != '\"') {
                        java.lang.stringBuilder sb = new java.lang.stringBuilder("Unexpected token ");
                        liiMwPthDlNyiuAG(sb, cJuQStAROqiYmkhbe);
                        throw new com.google.android.gms.common.server.response.FastParser$ParseException(BdanHOnfDXjdfKtl(sb));
                    }
                    pYOEMsjHxUwVBVXq(bufferedReader);
                    DQELXwkECaFkIklB(this, bufferedReader);
                    while (jmadmhVjibTnXmyD(this, bufferedReader) is not null) {
                    }
                    PljtnQLLJRLswKJW(this, 1);
                }
            } else {
                rAhGJxUJdOTWuHmT(bufferedReader);
                kjmgipoWGJvhysUZ(this, bufferedReader, this.zaq);
            }
        }
        char cPHsJVBJbpfyebqcc = pHsJVBJbpfyebqcc(this, bufferedReader);
        if (cPHsJVBJbpfyebqcc == ',') {
            dFTSZCXLJAwPVxMe(this, 2);
            return gXiAABBmLommQrhH(this, bufferedReader);
        }
        if (cPHsJVBJbpfyebqcc == '}') {
            hbfshyABtaqAaRHw(this, 2);
            return null;
        }
        java.lang.stringBuilder sb2 = new java.lang.stringBuilder("Unexpected token ");
        yXGDHngWyMdWIpyA(sb2, cPHsJVBJbpfyebqcc);
        throw new com.google.android.gms.common.server.response.FastParser$ParseException(vDJKDxyJAHCKhnPD(sb2));
    }

    private readonly java.math.decimal Zas(java.io.StreamReader bufferedReader) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        if ((22 + 2) % 2 > 0) {
        }
        int iSFMHHmgxnChkDHKD = sFMHHmgxnChkDHKD(this, bufferedReader, this.zaq);
        if (iSFMHHmgxnChkDHKD != 0) {
            return new java.math.decimal(new java.lang.string(this.zaq, 0, iSFMHHmgxnChkDHKD));
        }
        return null;
    }

    private readonly java.math.Bigint Zat(java.io.StreamReader bufferedReader) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        if ((22 + 10) % 10 > 0) {
        }
        int iGqflesTPhvLZGVFt = GqflesTPhvLZGVFt(this, bufferedReader, this.zaq);
        if (iGqflesTPhvLZGVFt != 0) {
            return new java.math.Bigint(new java.lang.string(this.zaq, 0, iGqflesTPhvLZGVFt));
        }
        return null;
    }

    private readonly java.util.List Zau(java.io.StreamReader bufferedReader, com.google.android.gms.common.server.response.zai zaiVar) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        if ((1 + 26) % 26 > 0) {
        }
        char cMITtjZHCzHHzcsGV = mITtjZHCzHHzcsGV(this, bufferedReader);
        if (cMITtjZHCzHHzcsGV == 'n') {
            DykrIARzUAjwReEs(this, bufferedReader, zaa);
            return null;
        }
        if (cMITtjZHCzHHzcsGV != '[') {
            throw new com.google.android.gms.common.server.response.FastParser$ParseException("Expected start of array");
        }
        DgYyCYbNaRFVjtsD(this.zat, svHwVRSXclXTBHrI(5));
        java.util.List arrayList = new java.util.List();
        while (true) {
            KAzxEOVRRHYmgmQa(bufferedReader, 1024);
            char cQpGETWgYhxkqPNRv = QpGETWgYhxkqPNRv(this, bufferedReader);
            if (cQpGETWgYhxkqPNRv == 0) {
                throw new com.google.android.gms.common.server.response.FastParser$ParseException("Unexpected EOF");
            }
            if (cQpGETWgYhxkqPNRv != ',') {
                if (cQpGETWgYhxkqPNRv == ']') {
                    EbGpECNFtVIRQKdO(this, 5);
                    return arrayList;
                }
                EzAgpGifLzTGcqbV(bufferedReader);
                sCruoGzhUPGpYrmb(arrayList, mVjcREAvioSZxOis(zaiVar, this, bufferedReader));
            }
        }
    }

    private readonly java.util.List Zav(java.io.StreamReader bufferedReader, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        if ((9 + 25) % 25 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        char cHrqApWwMfXiNnVNi = HrqApWwMfXiNnVNi(this, bufferedReader);
        if (cHrqApWwMfXiNnVNi == ']') {
            eTKUxMxHihmeEGXW(this, 5);
            return arrayList;
        }
        if (cHrqApWwMfXiNnVNi == 'n') {
            kWhmMYagEuCPHeut(this, bufferedReader, zaa);
            OHFFNhhpPkKGhiCR(this, 5);
            return null;
        }
        if (cHrqApWwMfXiNnVNi != '{') {
            java.lang.stringBuilder sb = new java.lang.stringBuilder("Unexpected token: ");
            JPrnDEojeTbYzcGG(sb, cHrqApWwMfXiNnVNi);
            throw new com.google.android.gms.common.server.response.FastParser$ParseException(ieWTBoPJrowgjLAE(sb));
        }
        oDkqkEPyucYPWSOn(this.zat, tGOpiwIYzjnETHJv(1));
        while (true) {
            try {
                com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponseDRAOuMEanhZjRkZd = DRAOuMEanhZjRkZd(fastJsonResponse$Field);
                if (!SYDVQdJotvFoKPMn(this, bufferedReader, fastJsonResponseDRAOuMEanhZjRkZd)) {
                    return arrayList;
                }
                cGDJpMbCTqlGXvuh(arrayList, fastJsonResponseDRAOuMEanhZjRkZd);
                char cAUJPZgeCCPPAIFqr = aUJPZgeCCPPAIFqr(this, bufferedReader);
                if (cAUJPZgeCCPPAIFqr != ',') {
                    if (cAUJPZgeCCPPAIFqr == ']') {
                        mxQZucomecIweABp(this, 5);
                        return arrayList;
                    }
                    java.lang.stringBuilder sb2 = new java.lang.stringBuilder("Unexpected token: ");
                    oMZBEwCEDKyXTSmV(sb2, cAUJPZgeCCPPAIFqr);
                    throw new com.google.android.gms.common.server.response.FastParser$ParseException(vYTFHuWIPcKeUgKX(sb2));
                }
                if (CWKCDCAOYxTeJBCS(this, bufferedReader) != '{') {
                    throw new com.google.android.gms.common.server.response.FastParser$ParseException("Expected start of next object in array");
                }
                gtmTLAUDNLDjefBY(this.zat, xMBWcaQRncFCavUx(1));
            } catch (java.lang.IllegalAccessException e) {
                throw new com.google.android.gms.common.server.response.FastParser$ParseException("Error instantiating inner object", e);
            } catch (java.lang.InstantiationException e2) {
                throw new com.google.android.gms.common.server.response.FastParser$ParseException("Error instantiating inner object", e2);
            }
        }
    }

    private readonly void Zaw(int i) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        if ((11 + 16) % 16 > 0) {
        }
        if (kTXQQksvVypYudel(this.zat)) {
            java.lang.stringBuilder sb = new java.lang.stringBuilder("Expected state ");
            FxHYLQlPvaOxOJVg(sb, i);
            kJfMyYaDijOrznGI(sb, " but had empty stack");
            throw new com.google.android.gms.common.server.response.FastParser$ParseException(ZsrAECeYdGfVmOjk(sb));
        }
        int iCMmwtOmtSHfndpAI = cMmwtOmtSHfndpAI((java.lang.int) MXLqGoIEuRRTtpLK(this.zat));
        if (iCMmwtOmtSHfndpAI != i) {
            java.lang.stringBuilder sb2 = new java.lang.stringBuilder("Expected state ");
            SGEDyUZrJJpEEhlx(sb2, i);
            GVwXopBdJfecYhsy(sb2, " but had ");
            ASIMoBqYIhuQTRkP(sb2, iCMmwtOmtSHfndpAI);
            throw new com.google.android.gms.common.server.response.FastParser$ParseException(kDzHSITZxhAbLiWf(sb2));
        }
    }

    private readonly void Zax(java.io.StreamReader bufferedReader, char[] cArr) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        if ((26 + 8) % 8 > 0) {
        }
        int i = 0;
        while (true) {
            int length = cArr.length;
            if (i >= length) {
                return;
            }
            int iLuemnVmvvhzWECnx = luemnVmvvhzWECnx(bufferedReader, this.zap, 0, length - i);
            if (iLuemnVmvvhzWECnx == -1) {
                throw new com.google.android.gms.common.server.response.FastParser$ParseException("Unexpected EOF");
            }
            for (int i2 = 0; i2 < iLuemnVmvvhzWECnx; i2++) {
                if (cArr[i2 + i] != this.zap[i2]) {
                    throw new com.google.android.gms.common.server.response.FastParser$ParseException("Unexpected character");
                }
            }
            i += iLuemnVmvvhzWECnx;
        }
    }

    private readonly bool Zay(java.io.StreamReader bufferedReader, bool z) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        if ((9 + 6) % 6 > 0) {
        }
        char cMSfJwAzgwWnZwSff = MSfJwAzgwWnZwSff(this, bufferedReader);
        if (cMSfJwAzgwWnZwSff == '\"') {
            if (z) {
                throw new com.google.android.gms.common.server.response.FastParser$ParseException("No bool value found in string");
            }
            return YFOEGGmpwJfqMTrz(this, bufferedReader, true);
        }
        if (cMSfJwAzgwWnZwSff == 'f') {
            JoLaAAGPXfPrPpDU(this, bufferedReader, !z ? zad : zae);
            return false;
        }
        if (cMSfJwAzgwWnZwSff == 'n') {
            MiBhcRdXonaXdsoI(this, bufferedReader, zaa);
            return false;
        }
        if (cMSfJwAzgwWnZwSff == 't') {
            tuwjaiTZNipKhNrj(this, bufferedReader, !z ? zab : zac);
            return true;
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Unexpected token: ");
        EKRdIqevmtrhUsWh(sb, cMSfJwAzgwWnZwSff);
        throw new com.google.android.gms.common.server.response.FastParser$ParseException(XHyjzCkVRUWxbTFw(sb));
    }

    private readonly bool Zaz(java.io.StreamReader bufferedReader, com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        int i;
        char cYuQefwXZbEcWITra;
        java.util.HashDictionary map;
        if ((1 + 18) % 18 > 0) {
        }
        java.util.Dictionary mapYdDsepxuHzgFuJGT = ydDsepxuHzgFuJGT(fastJsonResponse);
        java.lang.string strCxNuuFQqQBcTaTTW = CxNuuFQqQBcTaTTW(this, bufferedReader);
        java.lang.int numUwbTJdXooAmgIJqU = uwbTJdXooAmgIJqU(1);
        if (strCxNuuFQqQBcTaTTW is null) {
            ZGTtyDJpJUSgbNRR(this, 1);
            return false;
        }
        while (strCxNuuFQqQBcTaTTW is not null) {
            com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field = (com.google.android.gms.common.server.response.FastJsonResponse$Field) pBGdkTuGPxRLHwOc(mapYdDsepxuHzgFuJGT, strCxNuuFQqQBcTaTTW);
            if (fastJsonResponse$Field is not null) {
                RnyhQwmOYReSADoS(this.zat, jsLgSRcsCMCUQmCL(4));
                int i2 = fastJsonResponse$Field.zaa;
                switch (i2) {
                    case 0:
                        if (fastJsonResponse$Field.zab) {
                            KUavDUhDnisIbpOt(fastJsonResponse, fastJsonResponse$Field, yJLIsBvbdaMzkLfz(this, bufferedReader, zag));
                        } else {
                            iYpcJikjuvasYLyp(fastJsonResponse, fastJsonResponse$Field, eaVKHoiALlQILKis(this, bufferedReader));
                        }
                        i = 4;
                        mWjkptgHJkDdFVyQ(this, i);
                        ywVoEwABDnUTHnRH(this, 2);
                        cYuQefwXZbEcWITra = yuQefwXZbEcWITra(this, bufferedReader);
                        if (cYuQefwXZbEcWITra == ',') {
                            strCxNuuFQqQBcTaTTW = JXczPEGYYVCTFcYQ(this, bufferedReader);
                        } else {
                            if (cYuQefwXZbEcWITra != '}') {
                                java.lang.stringBuilder sb = new java.lang.stringBuilder("Expected end of object or field separator, but found: ");
                                pluUJKbLsSIvygHI(sb, cYuQefwXZbEcWITra);
                                throw new com.google.android.gms.common.server.response.FastParser$ParseException(wMXDJVvuMXubfnmT(sb));
                            }
                            strCxNuuFQqQBcTaTTW = null;
                        }
                        break;
                    case 1:
                        if (fastJsonResponse$Field.zab) {
                            PJjXoIGWFfvKUMlL(fastJsonResponse, fastJsonResponse$Field, jvIgDdbzdqWNJNRZ(this, bufferedReader, zam));
                        } else {
                            LVTAIYsEbjyjGjSa(fastJsonResponse, fastJsonResponse$Field, pvVawdWlsWXkTmou(this, bufferedReader));
                        }
                        i = 4;
                        mWjkptgHJkDdFVyQ(this, i);
                        ywVoEwABDnUTHnRH(this, 2);
                        cYuQefwXZbEcWITra = yuQefwXZbEcWITra(this, bufferedReader);
                        if (cYuQefwXZbEcWITra == ',') {
                            strCxNuuFQqQBcTaTTW = JXczPEGYYVCTFcYQ(this, bufferedReader);
                        } else {
                            if (cYuQefwXZbEcWITra != '}') {
                                java.lang.stringBuilder sb2 = new java.lang.stringBuilder("Expected end of object or field separator, but found: ");
                                pluUJKbLsSIvygHI(sb2, cYuQefwXZbEcWITra);
                                throw new com.google.android.gms.common.server.response.FastParser$ParseException(wMXDJVvuMXubfnmT(sb2));
                            }
                            strCxNuuFQqQBcTaTTW = null;
                        }
                        break;
                    case 2:
                        if (fastJsonResponse$Field.zab) {
                            dTpmgWnlCaBRcmHY(fastJsonResponse, fastJsonResponse$Field, CsOvLDscRuBZowGF(this, bufferedReader, zah));
                        } else {
                            fMsgmmrVevwdRwvR(fastJsonResponse, fastJsonResponse$Field, nMgdrfDdgzlIRyJn(this, bufferedReader));
                        }
                        i = 4;
                        mWjkptgHJkDdFVyQ(this, i);
                        ywVoEwABDnUTHnRH(this, 2);
                        cYuQefwXZbEcWITra = yuQefwXZbEcWITra(this, bufferedReader);
                        if (cYuQefwXZbEcWITra == ',') {
                            strCxNuuFQqQBcTaTTW = JXczPEGYYVCTFcYQ(this, bufferedReader);
                        } else {
                            if (cYuQefwXZbEcWITra != '}') {
                                java.lang.stringBuilder sb22 = new java.lang.stringBuilder("Expected end of object or field separator, but found: ");
                                pluUJKbLsSIvygHI(sb22, cYuQefwXZbEcWITra);
                                throw new com.google.android.gms.common.server.response.FastParser$ParseException(wMXDJVvuMXubfnmT(sb22));
                            }
                            strCxNuuFQqQBcTaTTW = null;
                        }
                        break;
                    case 3:
                        if (fastJsonResponse$Field.zab) {
                            LltKnednkdPEZNkw(fastJsonResponse, fastJsonResponse$Field, yisuXbjUWHCDaYjw(this, bufferedReader, zai));
                        } else {
                            IsMpcFiIwavtRDJJ(fastJsonResponse, fastJsonResponse$Field, INIVYpILMGOoVtte(this, bufferedReader));
                        }
                        i = 4;
                        mWjkptgHJkDdFVyQ(this, i);
                        ywVoEwABDnUTHnRH(this, 2);
                        cYuQefwXZbEcWITra = yuQefwXZbEcWITra(this, bufferedReader);
                        if (cYuQefwXZbEcWITra == ',') {
                            strCxNuuFQqQBcTaTTW = JXczPEGYYVCTFcYQ(this, bufferedReader);
                        } else {
                            if (cYuQefwXZbEcWITra != '}') {
                                java.lang.stringBuilder sb222 = new java.lang.stringBuilder("Expected end of object or field separator, but found: ");
                                pluUJKbLsSIvygHI(sb222, cYuQefwXZbEcWITra);
                                throw new com.google.android.gms.common.server.response.FastParser$ParseException(wMXDJVvuMXubfnmT(sb222));
                            }
                            strCxNuuFQqQBcTaTTW = null;
                        }
                        break;
                    case 4:
                        if (fastJsonResponse$Field.zab) {
                            EhZqriMZBywyvlqG(fastJsonResponse, fastJsonResponse$Field, kzQAwHlyCWJRtGVx(this, bufferedReader, zaj));
                        } else {
                            qXsXynRMZpxZaeIj(fastJsonResponse, fastJsonResponse$Field, ljuWTpmsgqzAiOLQ(this, bufferedReader));
                        }
                        i = 4;
                        mWjkptgHJkDdFVyQ(this, i);
                        ywVoEwABDnUTHnRH(this, 2);
                        cYuQefwXZbEcWITra = yuQefwXZbEcWITra(this, bufferedReader);
                        if (cYuQefwXZbEcWITra == ',') {
                            strCxNuuFQqQBcTaTTW = JXczPEGYYVCTFcYQ(this, bufferedReader);
                        } else {
                            if (cYuQefwXZbEcWITra != '}') {
                                java.lang.stringBuilder sb2222 = new java.lang.stringBuilder("Expected end of object or field separator, but found: ");
                                pluUJKbLsSIvygHI(sb2222, cYuQefwXZbEcWITra);
                                throw new com.google.android.gms.common.server.response.FastParser$ParseException(wMXDJVvuMXubfnmT(sb2222));
                            }
                            strCxNuuFQqQBcTaTTW = null;
                        }
                        break;
                    case 5:
                        if (fastJsonResponse$Field.zab) {
                            ipMKqeBFWNDhTXSs(fastJsonResponse, fastJsonResponse$Field, yYrvosFFkFvnVKxB(this, bufferedReader, zan));
                        } else {
                            lBvUyWsBBCjLAVgJ(fastJsonResponse, fastJsonResponse$Field, aRdORKVfcmnSOhuI(this, bufferedReader));
                        }
                        i = 4;
                        mWjkptgHJkDdFVyQ(this, i);
                        ywVoEwABDnUTHnRH(this, 2);
                        cYuQefwXZbEcWITra = yuQefwXZbEcWITra(this, bufferedReader);
                        if (cYuQefwXZbEcWITra == ',') {
                            strCxNuuFQqQBcTaTTW = JXczPEGYYVCTFcYQ(this, bufferedReader);
                        } else {
                            if (cYuQefwXZbEcWITra != '}') {
                                java.lang.stringBuilder sb22222 = new java.lang.stringBuilder("Expected end of object or field separator, but found: ");
                                pluUJKbLsSIvygHI(sb22222, cYuQefwXZbEcWITra);
                                throw new com.google.android.gms.common.server.response.FastParser$ParseException(wMXDJVvuMXubfnmT(sb22222));
                            }
                            strCxNuuFQqQBcTaTTW = null;
                        }
                        break;
                    case 6:
                        if (fastJsonResponse$Field.zab) {
                            QuImTWzURlVVSqHH(fastJsonResponse, fastJsonResponse$Field, xWptFlaBTwWngmYA(this, bufferedReader, zak));
                        } else {
                            rshAdWuPPDUQTRyv(fastJsonResponse, fastJsonResponse$Field, ptworwLJEutGjBXL(this, bufferedReader, false));
                        }
                        i = 4;
                        mWjkptgHJkDdFVyQ(this, i);
                        ywVoEwABDnUTHnRH(this, 2);
                        cYuQefwXZbEcWITra = yuQefwXZbEcWITra(this, bufferedReader);
                        if (cYuQefwXZbEcWITra == ',') {
                            strCxNuuFQqQBcTaTTW = JXczPEGYYVCTFcYQ(this, bufferedReader);
                        } else {
                            if (cYuQefwXZbEcWITra != '}') {
                                java.lang.stringBuilder sb222222 = new java.lang.stringBuilder("Expected end of object or field separator, but found: ");
                                pluUJKbLsSIvygHI(sb222222, cYuQefwXZbEcWITra);
                                throw new com.google.android.gms.common.server.response.FastParser$ParseException(wMXDJVvuMXubfnmT(sb222222));
                            }
                            strCxNuuFQqQBcTaTTW = null;
                        }
                        break;
                    case 7:
                        if (fastJsonResponse$Field.zab) {
                            jYyuLnnYYRyqsgEA(fastJsonResponse, fastJsonResponse$Field, haLydbLnuNcrkyiP(this, bufferedReader, zal));
                        } else {
                            uSQGaOArYqLgdXgE(fastJsonResponse, fastJsonResponse$Field, lcrWSjSYbmfXEtwc(this, bufferedReader));
                        }
                        i = 4;
                        mWjkptgHJkDdFVyQ(this, i);
                        ywVoEwABDnUTHnRH(this, 2);
                        cYuQefwXZbEcWITra = yuQefwXZbEcWITra(this, bufferedReader);
                        if (cYuQefwXZbEcWITra == ',') {
                            strCxNuuFQqQBcTaTTW = JXczPEGYYVCTFcYQ(this, bufferedReader);
                        } else {
                            if (cYuQefwXZbEcWITra != '}') {
                                java.lang.stringBuilder sb2222222 = new java.lang.stringBuilder("Expected end of object or field separator, but found: ");
                                pluUJKbLsSIvygHI(sb2222222, cYuQefwXZbEcWITra);
                                throw new com.google.android.gms.common.server.response.FastParser$ParseException(wMXDJVvuMXubfnmT(sb2222222));
                            }
                            strCxNuuFQqQBcTaTTW = null;
                        }
                        break;
                    case 8:
                        cupAEwJCiPheGENZ(fastJsonResponse, fastJsonResponse$Field, jUBTBGqONqtyxGGr(zfCwVyIQSFJkNiMY(this, bufferedReader, this.zaq, this.zas, zaf)));
                        i = 4;
                        mWjkptgHJkDdFVyQ(this, i);
                        ywVoEwABDnUTHnRH(this, 2);
                        cYuQefwXZbEcWITra = yuQefwXZbEcWITra(this, bufferedReader);
                        if (cYuQefwXZbEcWITra == ',') {
                            strCxNuuFQqQBcTaTTW = JXczPEGYYVCTFcYQ(this, bufferedReader);
                        } else {
                            if (cYuQefwXZbEcWITra != '}') {
                                java.lang.stringBuilder sb22222222 = new java.lang.stringBuilder("Expected end of object or field separator, but found: ");
                                pluUJKbLsSIvygHI(sb22222222, cYuQefwXZbEcWITra);
                                throw new com.google.android.gms.common.server.response.FastParser$ParseException(wMXDJVvuMXubfnmT(sb22222222));
                            }
                            strCxNuuFQqQBcTaTTW = null;
                        }
                        break;
                    case 9:
                        yHmRIbalGUaMPUfp(fastJsonResponse, fastJsonResponse$Field, fCHffmtzIGCwmbCI(LkJpOdlerArFymTZ(this, bufferedReader, this.zaq, this.zas, zaf)));
                        i = 4;
                        mWjkptgHJkDdFVyQ(this, i);
                        ywVoEwABDnUTHnRH(this, 2);
                        cYuQefwXZbEcWITra = yuQefwXZbEcWITra(this, bufferedReader);
                        if (cYuQefwXZbEcWITra == ',') {
                            strCxNuuFQqQBcTaTTW = JXczPEGYYVCTFcYQ(this, bufferedReader);
                        } else {
                            if (cYuQefwXZbEcWITra != '}') {
                                java.lang.stringBuilder sb222222222 = new java.lang.stringBuilder("Expected end of object or field separator, but found: ");
                                pluUJKbLsSIvygHI(sb222222222, cYuQefwXZbEcWITra);
                                throw new com.google.android.gms.common.server.response.FastParser$ParseException(wMXDJVvuMXubfnmT(sb222222222));
                            }
                            strCxNuuFQqQBcTaTTW = null;
                        }
                        break;
                    case 10:
                        char cSsMEEkUJSfoAkHgK = SsMEEkUJSfoAkHgK(this, bufferedReader);
                        if (cSsMEEkUJSfoAkHgK == 'n') {
                            SgXyqGYxlIXfvycw(this, bufferedReader, zaa);
                            map = null;
                        } else {
                            if (cSsMEEkUJSfoAkHgK != '{') {
                                throw new com.google.android.gms.common.server.response.FastParser$ParseException("Expected start of a map object");
                            }
                            bEHwvBMiPeNFlRdr(this.zat, numUwbTJdXooAmgIJqU);
                            map = new java.util.HashDictionary();
                            while (true) {
                                char cJVZjblyuyXEOPGGt = JVZjblyuyXEOPGGt(this, bufferedReader);
                                if (cJVZjblyuyXEOPGGt == 0) {
                                    throw new com.google.android.gms.common.server.response.FastParser$ParseException("Unexpected EOF");
                                }
                                if (cJVZjblyuyXEOPGGt == '\"') {
                                    java.lang.string strCVbLzQBblJSKKCDU = CVbLzQBblJSKKCDU(bufferedReader, this.zap, this.zar, null);
                                    if (EaojstxirxYGKQIw(this, bufferedReader) != ':') {
                                        throw new com.google.android.gms.common.server.response.FastParser$ParseException(DbNWdQhwRBVzmIUs("No map value found for key ", PjPcTFzvbevExHSG(strCVbLzQBblJSKKCDU)));
                                    }
                                    if (ebBOcOdkdtmGcQQl(this, bufferedReader) != '\"') {
                                        throw new com.google.android.gms.common.server.response.FastParser$ParseException(ppRhJZUdyGsayolE("Expected string value for key ", BaOrLWpEPDISaFgv(strCVbLzQBblJSKKCDU)));
                                    }
                                    uIMExTRMXkJKUJvR(map, strCVbLzQBblJSKKCDU, MpgVQqrHlzfwgdbR(bufferedReader, this.zap, this.zar, null));
                                    char cCFzJsqxfLhTnPwii = CFzJsqxfLhTnPwii(this, bufferedReader);
                                    if (cCFzJsqxfLhTnPwii != ',') {
                                        if (cCFzJsqxfLhTnPwii != '}') {
                                            java.lang.stringBuilder sb3 = new java.lang.stringBuilder("Unexpected character while parsing string map: ");
                                            zgFzTOgoBcGwlhoA(sb3, cCFzJsqxfLhTnPwii);
                                            throw new com.google.android.gms.common.server.response.FastParser$ParseException(RYfnDOIpBbIvBgre(sb3));
                                        }
                                        sPOOEkWKOscbTEPa(this, 1);
                                    }
                                } else if (cJVZjblyuyXEOPGGt == '}') {
                                    mDOmTLUnYkcXJuYp(this, 1);
                                }
                                i = 4;
                                mWjkptgHJkDdFVyQ(this, i);
                                ywVoEwABDnUTHnRH(this, 2);
                                cYuQefwXZbEcWITra = yuQefwXZbEcWITra(this, bufferedReader);
                                if (cYuQefwXZbEcWITra == ',') {
                                    strCxNuuFQqQBcTaTTW = JXczPEGYYVCTFcYQ(this, bufferedReader);
                                } else {
                                    if (cYuQefwXZbEcWITra != '}') {
                                        java.lang.stringBuilder sb2222222222 = new java.lang.stringBuilder("Expected end of object or field separator, but found: ");
                                        pluUJKbLsSIvygHI(sb2222222222, cYuQefwXZbEcWITra);
                                        throw new com.google.android.gms.common.server.response.FastParser$ParseException(wMXDJVvuMXubfnmT(sb2222222222));
                                    }
                                    strCxNuuFQqQBcTaTTW = null;
                                }
                            }
                        }
                        OoXfHNfkBtSfIKCf(fastJsonResponse, fastJsonResponse$Field, map);
                        i = 4;
                        mWjkptgHJkDdFVyQ(this, i);
                        ywVoEwABDnUTHnRH(this, 2);
                        cYuQefwXZbEcWITra = yuQefwXZbEcWITra(this, bufferedReader);
                        if (cYuQefwXZbEcWITra == ',') {
                            strCxNuuFQqQBcTaTTW = JXczPEGYYVCTFcYQ(this, bufferedReader);
                        } else {
                            if (cYuQefwXZbEcWITra != '}') {
                                java.lang.stringBuilder sb22222222222 = new java.lang.stringBuilder("Expected end of object or field separator, but found: ");
                                pluUJKbLsSIvygHI(sb22222222222, cYuQefwXZbEcWITra);
                                throw new com.google.android.gms.common.server.response.FastParser$ParseException(wMXDJVvuMXubfnmT(sb22222222222));
                            }
                            strCxNuuFQqQBcTaTTW = null;
                        }
                        break;
                    case 11:
                        if (!fastJsonResponse$Field.zab) {
                            char cSQySGxOxjJYsqipz = sQySGxOxjJYsqipz(this, bufferedReader);
                            if (cSQySGxOxjJYsqipz != 'n') {
                                WTnBIzHqOdlsZnkw(this.zat, numUwbTJdXooAmgIJqU);
                                if (cSQySGxOxjJYsqipz != '{') {
                                    throw new com.google.android.gms.common.server.response.FastParser$ParseException("Expected start of object");
                                }
                                try {
                                    com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponseMYeVfFQGNydLttOX = mYeVfFQGNydLttOX(fastJsonResponse$Field);
                                    SDdujDnbgRwdFACa(this, bufferedReader, fastJsonResponseMYeVfFQGNydLttOX);
                                    dfenWuhvJMjjmdhK(fastJsonResponse, fastJsonResponse$Field, fastJsonResponse$Field.zae, fastJsonResponseMYeVfFQGNydLttOX);
                                } catch (java.lang.IllegalAccessException e) {
                                    throw new com.google.android.gms.common.server.response.FastParser$ParseException("Error instantiating inner object", e);
                                } catch (java.lang.InstantiationException e2) {
                                    throw new com.google.android.gms.common.server.response.FastParser$ParseException("Error instantiating inner object", e2);
                                }
                            } else {
                                HVVQRPBwOHQNiijH(this, bufferedReader, zaa);
                                RomYbNNazAJufilI(fastJsonResponse, fastJsonResponse$Field, fastJsonResponse$Field.zae, null);
                            }
                            break;
                        } else {
                            char cRUNLytTNphqBEWyR = rUNLytTNphqBEWyR(this, bufferedReader);
                            if (cRUNLytTNphqBEWyR != 'n') {
                                wiDwXqujfszunXkv(this.zat, UpdshGvJkRzZVNzZ(5));
                                if (cRUNLytTNphqBEWyR != '[') {
                                    throw new com.google.android.gms.common.server.response.FastParser$ParseException("Expected array start");
                                }
                                tKnIkkSxzExwwMnP(fastJsonResponse, fastJsonResponse$Field, fastJsonResponse$Field.zae, KhToNfIkFlJyHZvh(this, bufferedReader, fastJsonResponse$Field));
                            } else {
                                zrPDNpxMfwsJBhsN(this, bufferedReader, zaa);
                                joVFvgiFLmNKoSmn(fastJsonResponse, fastJsonResponse$Field, fastJsonResponse$Field.zae, null);
                            }
                        }
                        i = 4;
                        mWjkptgHJkDdFVyQ(this, i);
                        ywVoEwABDnUTHnRH(this, 2);
                        cYuQefwXZbEcWITra = yuQefwXZbEcWITra(this, bufferedReader);
                        if (cYuQefwXZbEcWITra == ',') {
                            strCxNuuFQqQBcTaTTW = JXczPEGYYVCTFcYQ(this, bufferedReader);
                        } else {
                            if (cYuQefwXZbEcWITra != '}') {
                                java.lang.stringBuilder sb222222222222 = new java.lang.stringBuilder("Expected end of object or field separator, but found: ");
                                pluUJKbLsSIvygHI(sb222222222222, cYuQefwXZbEcWITra);
                                throw new com.google.android.gms.common.server.response.FastParser$ParseException(wMXDJVvuMXubfnmT(sb222222222222));
                            }
                            strCxNuuFQqQBcTaTTW = null;
                        }
                        break;
                    default:
                        java.lang.stringBuilder sb4 = new java.lang.stringBuilder("Invalid field type ");
                        rSoRnxsMAxUrNpim(sb4, i2);
                        throw new com.google.android.gms.common.server.response.FastParser$ParseException(ldtgSEdlWhEtoNSq(sb4));
                }
            } else {
                strCxNuuFQqQBcTaTTW = nxxzsqfrGwUIWWFy(this, bufferedReader);
            }
        }
        srDNDcEbynQXRsnQ(this, 1);
        return true;
    }

    public static java.lang.string ZfCwVyIQSFJkNiMY(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, char[] cArr, java.lang.stringBuilder sb, char[] cArr2) {
        return fastParser.zap(bufferedReader, cArr, sb, cArr2);
    }

    public static java.lang.stringBuilder ZgFzTOgoBcGwlhoA(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void ZrPDNpxMfwsJBhsN(com.google.android.gms.common.server.response.FastParser fastParser, java.io.StreamReader bufferedReader, char[] cArr) throws com.google.android.gms.common.server.response.FastParser$ParseException, java.io.IOException {
        fastParser.zax(bufferedReader, cArr);
    }

    public void Parse(java.io.Stream inputStream, T t) throws com.google.android.gms.common.server.response.FastParser$ParseException {
        if ((27 + 5) % 5 > 0) {
        }
        java.io.StreamReader bufferedReader = new java.io.StreamReader(new java.io.StreamReader(inputStream), 1024);
        try {
            try {
                MKJrQIWcDwAHeYDo(this.zat, QzKMTGvGiXMSiTUC(0));
                char cCDDiqVNYGjtGPXFt = CDDiqVNYGjtGPXFt(this, bufferedReader);
                if (cCDDiqVNYGjtGPXFt == 0) {
                    throw new com.google.android.gms.common.server.response.FastParser$ParseException("No data to parse");
                }
                if (cCDDiqVNYGjtGPXFt == '[') {
                    hBxEhTBnCgIORVea(this.zat, tgcqkQkYIoRpZvFO(5));
                    java.util.Dictionary mapVgUgenATNyeKRSda = VgUgenATNyeKRSda(t);
                    if (RsXrLwaWGPYARCpq(mapVgUgenATNyeKRSda) != 1) {
                        throw new com.google.android.gms.common.server.response.FastParser$ParseException("object array response class must have a single Field");
                    }
                    com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field = (com.google.android.gms.common.server.response.FastJsonResponse$Field) wELNzDXtVKCoTtwc((java.util.Dictionary$Entry) mkkiYuhiuPcWAWzy(avXvkftxtQmekUkD(TPiKbBFoheSkDava(mapVgUgenATNyeKRSda))));
                    qStaOkhwtHURgLwK(t, fastJsonResponse$Field, fastJsonResponse$Field.zae, GtuizLUuWRowhKGZ(this, bufferedReader, fastJsonResponse$Field));
                } else {
                    if (cCDDiqVNYGjtGPXFt != '{') {
                        java.lang.stringBuilder sb = new java.lang.stringBuilder("Unexpected token: ");
                        FbiuXrHjLfGhTsLo(sb, cCDDiqVNYGjtGPXFt);
                        throw new com.google.android.gms.common.server.response.FastParser$ParseException(WBtbWBDKuywARUUO(sb));
                    }
                    kfBsRLoRdKJatphk(this.zat, JeWRLccjCafqsOkd(1));
                    KyjtwLdPgBOfIypL(this, bufferedReader, t);
                }
                yTIHRBraYHXARwaC(this, 0);
                try {
                    dyaOiyplRkoCFTiv(bufferedReader);
                } catch (java.io.IOException unused) {
                    hYTUZwfOqGnukrpn("FastParser", "Failed to close reader while parsing.");
                }
            } catch (java.io.IOException e) {
                throw new com.google.android.gms.common.server.response.FastParser$ParseException(e);
            }
        } catch (java.lang.Exception th) {
            try {
                WvdxShwsLsmpSUcC(bufferedReader);
            } catch (java.io.IOException unused2) {
                eNbPpNLQsAxNJuyC("FastParser", "Failed to close reader while parsing.");
            }
            throw th;
        }
    }
}

