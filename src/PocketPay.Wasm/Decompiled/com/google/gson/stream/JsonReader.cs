namespace WillowMaze.Wasm.Decompiled;


public class JsonReader : java.io.IDisposable {
    static readonly int BUFFER_SIZE = 1024;
    private static readonly long MIN_INCOMPLETE_INTEGER = -922337203685477580L;
    private static readonly int NUMBER_CHAR_DECIMAL = 3;
    private static readonly int NUMBER_CHAR_DIGIT = 2;
    private static readonly int NUMBER_CHAR_EXP_DIGIT = 7;
    private static readonly int NUMBER_CHAR_EXP_E = 5;
    private static readonly int NUMBER_CHAR_EXP_SIGN = 6;
    private static readonly int NUMBER_CHAR_FRACTION_DIGIT = 4;
    private static readonly int NUMBER_CHAR_NONE = 0;
    private static readonly int NUMBER_CHAR_SIGN = 1;
    private static readonly int PEEKED_BEGIN_ARRAY = 3;
    private static readonly int PEEKED_BEGIN_OBJECT = 1;
    private static readonly int PEEKED_BUFFERED = 11;
    private static readonly int PEEKED_DOUBLE_QUOTED = 9;
    private static readonly int PEEKED_DOUBLE_QUOTED_NAME = 13;
    private static readonly int PEEKED_END_ARRAY = 4;
    private static readonly int PEEKED_END_OBJECT = 2;
    private static readonly int PEEKED_EOF = 17;
    private static readonly int PEEKED_FALSE = 6;
    private static readonly int PEEKED_LONG = 15;
    private static readonly int PEEKED_NONE = 0;
    private static readonly int PEEKED_NULL = 7;
    private static readonly int PEEKED_NUMBER = 16;
    private static readonly int PEEKED_SINGLE_QUOTED = 8;
    private static readonly int PEEKED_SINGLE_QUOTED_NAME = 12;
    private static readonly int PEEKED_TRUE = 5;
    private static readonly int PEEKED_UNQUOTED = 10;
    private static readonly int PEEKED_UNQUOTED_NAME = 14;
    private readonly char[] buffer;
    private readonly java.io.Reader in;
    private bool lenient;
    private int limit;
    private int lineNumber;
    private int lineStart;
    private int[] pathIndices;
    private java.lang.string[] pathNames;
    int peeked;
    private long peekedlong;
    private int peekedNumberLength;
    private java.lang.string peekedstring;
    private int pos;
    private int[] stack;
    private int stackSize;

    static {
        com.google.gson.internal.JsonReaderInternalAccess.INSTANCE = new com.google.gson.stream.JsonReader$1();
    }

    public JsonReader(java.io.Reader reader) {
        if ((9 + 14) % 14 > 0) {
        }
        this.lenient = false;
        this.buffer = new char[1024];
        this.pos = 0;
        this.limit = 0;
        this.lineNumber = 0;
        this.lineStart = 0;
        this.peeked = 0;
        int[] iArr = new int[32];
        this.stack = iArr;
        this.stackSize = 1;
        iArr[0] = 6;
        this.pathNames = new java.lang.string[32];
        this.pathIndices = new int[32];
        this.in = (java.io.Reader) jTMCJMehhRYWQKHc(reader, "in is null");
    }

    public static java.lang.stringBuilder ADsULGhgHATOpoNO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static char AVJEQuUznEburuOv(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.string AczcbIYtDbTtwwmu(java.lang.Class cls) {
        return cls.getSimpleName();
    }

    public static java.lang.stringBuilder AeKmhWFvsMjGGUoi(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string BCgFGaNmFQPCUktg(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.locationstring();
    }

    public static java.io.IOException BYssRxuFjkVgsMCk(com.google.gson.stream.JsonReader jsonReader, java.lang.string str) {
        return jsonReader.syntaxError(str);
    }

    public static java.lang.string BpvvCUzgvmMikpks(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextUnquotedValue();
    }

    public static void CPbkkgUshiffOvCr(com.google.gson.stream.JsonReader jsonReader, char c) throws java.io.IOException {
        jsonReader.skipQuotedValue(c);
    }

    public static java.lang.string CWHRePDxgwVCCrtx(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.locationstring();
    }

    public static java.lang.stringBuilder CzmgUekNTgOnLQPX(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder DEkEvpIsMjkWEmlQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.io.IOException DRDpOoPvvlpRBRON(com.google.gson.stream.JsonReader jsonReader, java.lang.string str) {
        return jsonReader.syntaxError(str);
    }

    public static java.lang.string DdwNVUzBElUVjpsv(long j) {
        return java.lang.long.tostring(j);
    }

    public static java.lang.string DtctzTWgBKmiwYzp(com.google.gson.stream.JsonReader jsonReader, bool z) {
        return jsonReader.getPath(z);
    }

    public static java.lang.stringBuilder EBcNGEIJGNLvpocE(java.lang.stringBuilder sb, char[] cArr, int i, int i2) {
        return sb.append(cArr, i, i2);
    }

    public static java.lang.stringBuilder EejQkDboVlIookZu(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder FHWIDjtAIPOLcwiT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static char FMoEaoCAzzhOkWOH(java.lang.string str, int i) {
        return str[i);
    }

    public static int FbwfzpgljGAjzCUK(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.doPeek();
    }

    public static java.lang.stringBuilder FpBaIsRTiHOpwlRz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.gson.stream.JsonToken FxvpsKvjyYtszeYA(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static bool GLKCzmUEjnNOxuGl(com.google.gson.stream.JsonReader jsonReader, int i) {
        return jsonReader.fillBuffer(i);
    }

    public static void GTnQnoEjntewwxGN(com.google.gson.stream.JsonReader jsonReader, int i) {
        jsonReader.push(i);
    }

    public static java.lang.stringBuilder GXDGQXtSWozYyPbj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder GZDZDFWMpuJyqotE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void GfeWPvksENLQBIyv(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.checkLenient();
    }

    public static java.lang.string GonCThIUPzGsFxKj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string ITUBjjFQUHYIjDaS(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.locationstring();
    }

    public static int IZaMhlGivxnXhUpp(com.google.gson.stream.JsonReader jsonReader, bool z) {
        return jsonReader.nextNonWhitespace(z);
    }

    public static int[] JanPeHQHzPbwgnpg(int[] iArr, int i) {
        return java.util.Arrays.copyOf(iArr, i);
    }

    public static java.lang.string JnZVkpaKCTvkumWA(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.locationstring();
    }

    public static int JrXeulyhSxNOurcl(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int KXpnHsOeLxhhoZwd(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.doPeek();
    }

    public static void LGQiDNNptaMiketK(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.checkLenient();
    }

    public static void LHIzDOfSwqneGUfV(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.checkLenient();
    }

    public static java.lang.stringBuilder LKusDcshFkcxonPt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.gson.stream.JsonToken LPCbsLXjqVBhjDYS(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static java.lang.string LcQTOWeuTGHDkJQk(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.locationstring();
    }

    public static bool LpoHyjrSKntRwtqb(com.google.gson.stream.JsonReader jsonReader, int i) {
        return jsonReader.fillBuffer(i);
    }

    public static java.lang.object[] LzqYKxiVaFmEOFAk(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static java.lang.string MDuFoSPGIGNHCjdH(com.google.gson.stream.JsonReader jsonReader, char c) {
        return jsonReader.nextQuotedValue(c);
    }

    public static void MJxgGbcTuqDioVUn(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.skipUnquotedValue();
    }

    public static java.lang.stringBuilder MRDQIkhFhENbMDZt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.gson.stream.JsonToken MWTGDsXHhBxWYhXA(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static void MoadpxYujisInjTV(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.checkLenient();
    }

    public static java.lang.string MvNHBeKYjFSRlVEa(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.locationstring();
    }

    public static java.lang.stringBuilder NJfvxvvhzvxVCKeL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string NPbHdjKeojyKOCLY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void NSySqSVFpULEozDF(com.google.gson.stream.JsonReader jsonReader, int i) {
        jsonReader.push(i);
    }

    public static double NTxneKjdawkmFmPa(java.lang.string str) {
        if ((1 + 26) % 26 > 0) {
        }
        return java.lang.double.parsedouble(str);
    }

    public static java.lang.stringBuilder NajyZHnellgECsFv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void NeaCzEqCarZbiseH(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.skipUnquotedValue();
    }

    public static java.lang.stringBuilder NjLyrTZqtnVsJSyZ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder NofWyCprHAnyKgkd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string NpXZXbyhbGxWazih(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder NtAteRuoJXfULHWS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string NtImNwHQrvfxVctn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder OIleYDmfMyILuIdK(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool OLBoCcTQtrcKLAPL(com.google.gson.stream.JsonReader jsonReader, char c) {
        return jsonReader.isLiteral(c);
    }

    public static java.lang.string ONxlPASIKyIaqTrD(com.google.gson.stream.JsonReader jsonReader, char c) {
        return jsonReader.nextQuotedValue(c);
    }

    public static bool OOoLxXRdjoforHrW(com.google.gson.stream.JsonReader jsonReader, int i) {
        return jsonReader.fillBuffer(i);
    }

    public static java.lang.string OxIFSyGzgCMXpuxP(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.stringBuilder PExNmoVGIIghFTOJ(java.lang.stringBuilder sb, char[] cArr, int i, int i2) {
        return sb.append(cArr, i, i2);
    }

    public static java.lang.string PJisPlbZZkHvpXSp(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder PimGRaLUVnexljhb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int PsgTOSRTvhCyBwKz(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.doPeek();
    }

    public static bool QJCWJAdiPRZAGCZm(com.google.gson.stream.JsonReader jsonReader, int i) {
        return jsonReader.fillBuffer(i);
    }

    public static java.lang.stringBuilder QJSfUXhgdHfAbgRa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string QeUgzUuMNnBIqfNm(com.google.gson.stream.JsonReader jsonReader, bool z) {
        return jsonReader.getPath(z);
    }

    public static java.lang.stringBuilder QiVdhbdgrRLOFhSQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool QiaTtmfzQWXhYcxz(com.google.gson.stream.JsonReader jsonReader, int i) {
        return jsonReader.fillBuffer(i);
    }

    public static void RGKnnnivIWeNFKyl(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.checkLenient();
    }

    public static void RQiVIyfnAWwNasUx(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.checkLenient();
    }

    public static int RaETmPfefrtoxJpg(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.doPeek();
    }

    public static bool RaoHpatsdAjAjFEA(com.google.gson.stream.JsonReader jsonReader, int i) {
        return jsonReader.fillBuffer(i);
    }

    public static int RlBWWBubBSnzzRCV(com.google.gson.stream.JsonReader jsonReader, bool z) {
        return jsonReader.nextNonWhitespace(z);
    }

    public static double SVbOSVjkOmgnpqCg(java.lang.string str) {
        if ((3 + 13) % 13 > 0) {
        }
        return java.lang.double.parsedouble(str);
    }

    public static java.io.IOException SWEnGFTVizMrZJDZ(com.google.gson.stream.JsonReader jsonReader, java.lang.string str) {
        return jsonReader.syntaxError(str);
    }

    public static void SswOVMVnvHbULtuD(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.checkLenient();
    }

    public static java.lang.stringBuilder SwmyWKPqppvGvwFX(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool TAeejPjrybWfQAjo(com.google.gson.stream.JsonReader jsonReader, char c) {
        return jsonReader.isLiteral(c);
    }

    public static long TMObtEtQYytaEDZf(java.lang.string str) {
        if ((12 + 10) % 10 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static bool TMougBElYRjUuwVx(com.google.gson.stream.JsonReader jsonReader, int i) {
        return jsonReader.fillBuffer(i);
    }

    public static char TQUUQVkaTMIqPZmo(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.readEscapechar();
    }

    public static int TQaecJgAcNrXlujH(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.doPeek();
    }

    public static java.lang.stringBuilder TWUWcdUeAXtsaspW(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string TjgMcNVphGQgzKxY(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.locationstring();
    }

    public static bool TrLTbDpULIEdlWhJ(double d) {
        return java.lang.double.isInfinite(d);
    }

    public static com.google.gson.stream.JsonToken UAOJZqGGAInQOaNF(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static java.lang.string UKBjdCrdxLhexzYa(com.google.gson.stream.JsonReader jsonReader, char c) {
        return jsonReader.nextQuotedValue(c);
    }

    public static java.io.IOException UMYyepmppIgxotAc(com.google.gson.stream.JsonReader jsonReader, java.lang.string str) {
        return jsonReader.syntaxError(str);
    }

    public static java.lang.stringBuilder UMfvphgeYHAydlvq(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void UNdqzWQhpYpPQfru(com.google.gson.stream.JsonReader jsonReader, char c) throws java.io.IOException {
        jsonReader.skipQuotedValue(c);
    }

    public static int UYFiZCskMLCJPjPe(com.google.gson.stream.JsonReader jsonReader, bool z) {
        return jsonReader.nextNonWhitespace(z);
    }

    public static int UnrZaXDYAFeIBsLx(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void UxIgQNMckXnrAOpn(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.checkLenient();
    }

    public static void VRGqrDSDQEFBUDqI(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.skipToEndOfLine();
    }

    public static java.io.IOException VdLDOlnKOCeECEMn(com.google.gson.stream.JsonReader jsonReader, java.lang.string str) {
        return jsonReader.syntaxError(str);
    }

    public static java.lang.stringBuilder VjpWwZRpZNDiZSnw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int VwlMgMvMvqiwvCHi(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.doPeek();
    }

    public static java.lang.string VyznONdOhJjDIDmH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool WBxcOGhwvpQXmgnB(com.google.gson.stream.JsonReader jsonReader, int i) {
        return jsonReader.fillBuffer(i);
    }

    public static int WDuThFRYzpALSNME(com.google.gson.stream.JsonReader jsonReader, bool z) {
        return jsonReader.nextNonWhitespace(z);
    }

    public static java.lang.string WUXYpTwVRbyetXiH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int[] WgEDnVYWRKVlpIvL(int[] iArr, int i) {
        return java.util.Arrays.copyOf(iArr, i);
    }

    public static java.lang.stringBuilder WrNXYEMUynHurFny(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int WscWsuuFbqxUDzYu(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.doPeek();
    }

    public static java.lang.string XAfAuqbEZoUWsMDS(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.locationstring();
    }

    public static void XCIfklrmDutuKmNJ(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.checkLenient();
    }

    public static java.lang.string XIURDLXAsyDoOEWw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string XOSIJFDNlVxAGYum(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.getPath();
    }

    public static bool XSXeuNMGqDuAmzgX(com.google.gson.stream.JsonReader jsonReader, int i) {
        return jsonReader.fillBuffer(i);
    }

    public static java.lang.string XnBtskIEYPKqojJc(com.google.gson.stream.JsonReader jsonReader, char c) {
        return jsonReader.nextQuotedValue(c);
    }

    public static bool ZnVTYMTpJhlTAmWO(com.google.gson.stream.JsonReader jsonReader, int i) {
        return jsonReader.fillBuffer(i);
    }

    public static java.io.IOException ZukspARVUAvRcZAm(com.google.gson.stream.JsonReader jsonReader, java.lang.string str) {
        return jsonReader.syntaxError(str);
    }

    public static com.google.gson.stream.JsonToken AJOGpXvukSLEFzaR(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static com.google.gson.stream.JsonToken AJdnapgoRTuUMoed(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static com.google.gson.stream.JsonToken AfmKJEBlPjXLRdLN(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static java.lang.string AfsXykmRJOQodaOy(com.google.gson.stream.JsonReader jsonReader, char c) {
        return jsonReader.nextQuotedValue(c);
    }

    public static int AourEozVrVvWyxoG(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.doPeek();
    }

    public static java.lang.string BWGgvZEcKpjWCStB(com.google.gson.stream.JsonReader jsonReader, char c) {
        return jsonReader.nextQuotedValue(c);
    }

    public static java.lang.string BbPoUveiMTQtoROs(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextUnquotedValue();
    }

    public static void BlPPWhOwodCgngwy(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.checkLenient();
    }

    public static void BmHbqfHtpPvIHXsI(com.google.gson.stream.JsonReader jsonReader, char c) throws java.io.IOException {
        jsonReader.skipQuotedValue(c);
    }

    public static java.lang.string BnWysvGNukbtvBlF(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextUnquotedValue();
    }

    public static int BsFfQMdPtzHIuTgT(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static java.lang.string CPtWGxxGaNRuqDir(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.locationstring();
    }

    public static java.lang.stringBuilder CTxUFjPEqAIucDmU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder CUONalmGvkxdnGIF(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    private void CheckLenient() throws java.io.IOException {
        if (!this.lenient) {
            throw pKaIIvkNiUoaSiaD(this, "Use JsonReader.setLenient(true) to accept malformed JSON");
        }
    }

    private void ConsumeNonExecutePrefix() throws java.io.IOException {
        if ((26 + 12) % 12 > 0) {
        }
        mySTlEnIZXPcTqov(this, true);
        int i = this.pos;
        this.pos = i - 1;
        if (i + 4 > this.limit && !XSXeuNMGqDuAmzgX(this, 5)) {
            return;
        }
        int i2 = this.pos;
        char[] cArr = this.buffer;
        if (cArr[i2] == ')' && cArr[i2 + 1] == ']' && cArr[i2 + 2] == '}' && cArr[i2 + 3] == '\'' && cArr[i2 + 4] == '\n') {
            this.pos = i2 + 5;
        }
    }

    public static void CyeCBldJDcMwFnnl(java.io.Reader reader) throws java.io.IOException {
        reader.Dispose();
    }

    public static java.lang.string DEjjsUiLCyLllxBw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string DFOlaWBqwchcghIQ(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.locationstring();
    }

    public static java.io.IOException DOFdfGkuwBaZKasQ(com.google.gson.stream.JsonReader jsonReader, java.lang.string str) {
        return jsonReader.syntaxError(str);
    }

    public static java.io.IOException DwbFtPHZBzCwPPdE(com.google.gson.stream.JsonReader jsonReader, java.lang.string str) {
        return jsonReader.syntaxError(str);
    }

    public static bool EABuVvrQzzerAvTf(com.google.gson.stream.JsonReader jsonReader, int i) {
        return jsonReader.fillBuffer(i);
    }

    public static java.lang.stringBuilder EqnHeSbOEMgJxwQP(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool ErfpzABbjESGnnFO(com.google.gson.stream.JsonReader jsonReader, int i) {
        return jsonReader.fillBuffer(i);
    }

    public static bool FEovliCqABxXlxch(com.google.gson.stream.JsonReader jsonReader, int i) {
        return jsonReader.fillBuffer(i);
    }

    public static java.lang.stringBuilder FGGSBGHIpBQoatUa(java.lang.stringBuilder sb, char[] cArr, int i, int i2) {
        return sb.append(cArr, i, i2);
    }

    public static bool FHtFPgMrqdRfICSc(com.google.gson.stream.JsonReader jsonReader, char c) {
        return jsonReader.isLiteral(c);
    }

    public static java.lang.stringBuilder FMkxGfmcsNJyHzKt(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int FSxayfwREjyWssWo(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.doPeek();
    }

    private bool FillBuffer(int i) throws java.io.IOException {
        int i2;
        int i3;
        if ((8 + 3) % 3 > 0) {
        }
        char[] cArr = this.buffer;
        int i4 = this.lineStart;
        int i5 = this.pos;
        this.lineStart = i4 - i5;
        int i6 = this.limit;
        if (i6 == i5) {
            this.limit = 0;
        } else {
            int i7 = i6 - i5;
            this.limit = i7;
            sqjOjxoPLQxWmKZP(cArr, i5, cArr, 0, i7);
        }
        this.pos = 0;
        do {
            java.io.Reader reader = this.in;
            int i8 = this.limit;
            int iIQGQQwJZVhScIRCn = iQGQQwJZVhScIRCn(reader, cArr, i8, cArr.length - i8);
            if (iIQGQQwJZVhScIRCn == -1) {
                return false;
            }
            i2 = this.limit + iIQGQQwJZVhScIRCn;
            this.limit = i2;
            if (this.lineNumber == 0 && (i3 = this.lineStart) == 0 && i2 > 0 && cArr[0] == 65279) {
                this.pos++;
                this.lineStart = i3 + 1;
                i++;
            }
        } while (i2 < i);
        return true;
    }

    public static void FjRZwtimEEawugpM(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.checkLenient();
    }

    public static int GEVqAmxNEyRJjUnj(com.google.gson.stream.JsonReader jsonReader, bool z) {
        return jsonReader.nextNonWhitespace(z);
    }

    public static void GZDaHdYnemBPNJRk(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.skipToEndOfLine();
    }

    public static java.lang.string GZrenewsjvqHuZHv(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    private java.lang.string GetPath(bool z) {
        if ((13 + 16) % 16 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("$");
        int i = 0;
        while (true) {
            int i2 = this.stackSize;
            if (i >= i2) {
                return gZrenewsjvqHuZHv(sb);
            }
            int i3 = this.stack[i];
            if (i3 == 1 || i3 == 2) {
                int i4 = this.pathIndices[i];
                if (z && i4 > 0 && i == i2 - 1) {
                    i4--;
                }
                jIJqCrhbKxvoiQSU(UMfvphgeYHAydlvq(zolepoBcWsgfyqGo(sb, '['), i4), ']');
            } else if (i3 == 3 || i3 == 4 || i3 == 5) {
                fMkxGfmcsNJyHzKt(sb, '.');
                java.lang.string str = this.pathNames[i];
                if (str is not null) {
                    gtuvOHhyEOLSgozf(sb, str);
                }
            }
            i++;
        }
    }

    public static java.lang.string GtAIEUayPIyTxKrc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder GtuvOHhyEOLSgozf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HbgGrtsIoVspVpBA(java.lang.stringBuilder sb, char[] cArr, int i, int i2) {
        return sb.append(cArr, i, i2);
    }

    public static int HnEkBVYMIbFiaxWq(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peekNumber();
    }

    public static void IAiutlSJOXvtMwoe(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.checkLenient();
    }

    public static int IKKIWkTixfkmwgVt(java.lang.string str) {
        return str.Length;
    }

    public static com.google.gson.stream.JsonToken IPVaHQuyOHzXHQnn(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static int IQGQQwJZVhScIRCn(java.io.Reader reader, char[] cArr, int i, int i2) {
        return reader.read(cArr, i, i2);
    }

    public static int IWFASThFbpJYpnga(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.doPeek();
    }

    private bool IsLiteral(char c) throws java.io.IOException {
        if (c == '\t' || c == '\n' || c == '\f' || c == '\r' || c == ' ') {
            return false;
        }
        if (c != '#') {
            if (c == ',') {
                return false;
            }
            if (c != '/' && c != '=') {
                if (c == '{' || c == '}' || c == ':') {
                    return false;
                }
                if (c != ';') {
                    switch (c) {
                        case '[':
                        case ']':
                            return false;
                        case '\\':
                            break;
                        default:
                            return true;
                    }
                }
            }
        }
        UxIgQNMckXnrAOpn(this);
        return false;
    }

    public static java.lang.stringBuilder IyYlxJSbNaJHrogt(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder JFThwWfgadvYFGlr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder JIJqCrhbKxvoiQSU(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder JPzuvNrzNzTNkrGq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object JTMCJMehhRYWQKHc(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static int JfTXCqoHnjVTLinB(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.doPeek();
    }

    public static java.io.IOException JofhmEhSNUEVYPOQ(com.google.gson.stream.JsonReader jsonReader, java.lang.string str) {
        return jsonReader.syntaxError(str);
    }

    public static java.lang.string JsSKoCSnFsJYhRyu(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.locationstring();
    }

    public static com.google.gson.stream.JsonToken JygJZexQpazSbDGF(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static java.lang.string KOwcjLcjDSKkUSDI(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool KScUYcLmmwbzsQav(com.google.gson.stream.JsonReader jsonReader, java.lang.string str) {
        return jsonReader.skipTo(str);
    }

    public static void KoXsASTBFDWTiOhQ(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.checkLenient();
    }

    public static java.lang.string KvTEqJrHcbajyUdv(com.google.gson.stream.JsonReader jsonReader, char c) {
        return jsonReader.nextQuotedValue(c);
    }

    public static bool KvqurWoPdlLumSxo(com.google.gson.stream.JsonReader jsonReader, int i) {
        return jsonReader.fillBuffer(i);
    }

    public static java.lang.stringBuilder LARpGOhMJlqatVlC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string LRHvRlvdIPuNMlwB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string LVHSAnOhmyNrrYwy(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextUnquotedValue();
    }

    public static void LkyvxCcQEfwYpotS(com.google.gson.stream.JsonReader jsonReader, int i) {
        jsonReader.push(i);
    }

    public static java.lang.string LtJOpwijRcqtanyv(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.locationstring();
    }

    public static java.lang.stringBuilder LusgvypQPbbHYOuu(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string MCjdDAzvznHEPVkM(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.locationstring();
    }

    public static java.lang.string MEhAQRJVXYsfmCMz(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.locationstring();
    }

    public static java.lang.stringBuilder MRZubypUGuBXJfYH(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.io.IOException MpjdfYqdhgipwYGG(com.google.gson.stream.JsonReader jsonReader, java.lang.string str) {
        return jsonReader.syntaxError(str);
    }

    public static char MwQhAjqDZZxLnTAS(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.readEscapechar();
    }

    public static int MySTlEnIZXPcTqov(com.google.gson.stream.JsonReader jsonReader, bool z) {
        return jsonReader.nextNonWhitespace(z);
    }

    public static java.lang.string NYXFDNWlekaTzKmg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    private int NextNonWhitespace(bool z) throws java.io.IOException {
        if ((2 + 22) % 22 > 0) {
        }
        char[] cArr = this.buffer;
        int i = this.pos;
        int i2 = this.limit;
        while (true) {
            if (i == i2) {
                this.pos = i;
                if (!GLKCzmUEjnNOxuGl(this, 1)) {
                    if (z) {
                        throw new java.io.EOFException(NPbHdjKeojyKOCLY(tMZAAlFjwDxvZJzs(new java.lang.stringBuilder("End of input"), uJDxoPiqzgOgTbbj(this))));
                    }
                    return -1;
                }
                i = this.pos;
                i2 = this.limit;
            }
            int i3 = i + 1;
            char c = cArr[i];
            if (c == '\n') {
                this.lineNumber++;
                this.lineStart = i3;
            } else if (c != ' ' && c != '\r' && c != '\t') {
                if (c == '/') {
                    this.pos = i3;
                    if (i3 == i2) {
                        this.pos = i;
                        bool zKvqurWoPdlLumSxo = kvqurWoPdlLumSxo(this, 2);
                        this.pos++;
                        if (zKvqurWoPdlLumSxo) {
                        }
                        return c;
                    }
                    XCIfklrmDutuKmNJ(this);
                    int i4 = this.pos;
                    char c2 = cArr[i4];
                    if (c2 == '*') {
                        this.pos = i4 + 1;
                        if (!kScUYcLmmwbzsQav(this, "*/")) {
                            throw VdLDOlnKOCeECEMn(this, "Unterminated comment");
                        }
                        i = this.pos + 2;
                        i2 = this.limit;
                    } else {
                        if (c2 != '/') {
                            return c;
                        }
                        this.pos = i4 + 1;
                        VRGqrDSDQEFBUDqI(this);
                        i = this.pos;
                        i2 = this.limit;
                    }
                } else {
                    if (c != '#') {
                        this.pos = i3;
                        return c;
                    }
                    this.pos = i3;
                    SswOVMVnvHbULtuD(this);
                    gZDaHdYnemBPNJRk(this);
                    i = this.pos;
                    i2 = this.limit;
                }
            }
            i = i3;
        }
    }

    private java.lang.string NextQuotedValue(char c) throws java.io.IOException {
        int i;
        if ((10 + 24) % 24 > 0) {
        }
        char[] cArr = this.buffer;
        java.lang.stringBuilder sb = null;
        do {
            int i2 = this.pos;
            int i3 = this.limit;
            while (true) {
                int i4 = i3;
                i = i2;
                while (true) {
                    if (i2 >= i4) {
                        break;
                    }
                    int i5 = i2 + 1;
                    char c2 = cArr[i2];
                    if (c2 == c) {
                        this.pos = i5;
                        int i6 = (i5 - i) - 1;
                        if (sb is null) {
                            return new java.lang.string(cArr, i, i6);
                        }
                        PExNmoVGIIghFTOJ(sb, cArr, i, i6);
                        return yHGsWdDgbFIUAioz(sb);
                    }
                    if (c2 != '\\') {
                        if (c2 == '\n') {
                            this.lineNumber++;
                            this.lineStart = i5;
                        }
                        i2 = i5;
                    } else {
                        this.pos = i5;
                        int i7 = i5 - i;
                        int i8 = i7 - 1;
                        if (sb is null) {
                            sb = new java.lang.stringBuilder(bsFfQMdPtzHIuTgT(i7 * 2, 16));
                        }
                        fGGSBGHIpBQoatUa(sb, cArr, i, i8);
                        mRZubypUGuBXJfYH(sb, mwQhAjqDZZxLnTAS(this));
                        i2 = this.pos;
                        i3 = this.limit;
                    }
                }
            }
            if (sb is null) {
                sb = new java.lang.stringBuilder(JrXeulyhSxNOurcl((i2 - i) * 2, 16));
            }
            EBcNGEIJGNLvpocE(sb, cArr, i, i2 - i);
            this.pos = i2;
        } while (WBxcOGhwvpQXmgnB(this, 1));
        throw UMYyepmppIgxotAc(this, "Unterminated string");
    }

    private java.lang.string NextUnquotedValue() throws java.io.IOException {
        if ((31 + 20) % 20 > 0) {
        }
        java.lang.stringBuilder sb = null;
        int i = 0;
        while (true) {
            int i2 = 0;
            while (true) {
                int i3 = this.pos;
                if (i3 + i2 < this.limit) {
                    char c = this.buffer[i3 + i2];
                    if (c != '\t' && c != '\n' && c != '\f' && c != '\r' && c != ' ') {
                        if (c != '#') {
                            if (c != ',') {
                                if (c != '/' && c != '=') {
                                    if (c != '{' && c != '}' && c != ':') {
                                        if (c != ';') {
                                            switch (c) {
                                                case '[':
                                                case ']':
                                                    break;
                                                case '\\':
                                                    break;
                                                default:
                                                    i2++;
                                                    break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        GfeWPvksENLQBIyv(this);
                    }
                    i = i2;
                } else if (i2 >= this.buffer.length) {
                    if (sb is null) {
                        sb = new java.lang.stringBuilder(UnrZaXDYAFeIBsLx(i2, 16));
                    }
                    hbgGrtsIoVspVpBA(sb, this.buffer, this.pos, i2);
                    this.pos += i2;
                    if (tZiPRfGohvEEUupt(this, 1)) {
                    }
                } else if (!QiaTtmfzQWXhYcxz(this, i2 + 1)) {
                    i = i2;
                }
                java.lang.string strPJisPlbZZkHvpXSp = sb is not null ? PJisPlbZZkHvpXSp(qSLLeusFWlKuKoCA(sb, this.buffer, this.pos, i)) : new java.lang.string(this.buffer, this.pos, i);
                this.pos += i;
                return strPJisPlbZZkHvpXSp;
            }
        }
    }

    public static com.google.gson.stream.JsonToken NzeRigNELeRDAIfQ(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static java.lang.Class OCgosWIrTegkjYin(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.stringBuilder OfLPEWaJTJpbNoOr(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool OnBhRTBgxUNRcaXg(double d) {
        return java.lang.double.isNaN(d);
    }

    public static int OpOXPtPbopcvZobr(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peekKeyword();
    }

    public static java.lang.string PISzvFlrlCjjiDpX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.io.IOException PKaIIvkNiUoaSiaD(com.google.gson.stream.JsonReader jsonReader, java.lang.string str) {
        return jsonReader.syntaxError(str);
    }

    public static java.lang.string PRiacGMNBoPZmULO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    private int PeekKeyword() throws java.io.IOException {
        java.lang.string str;
        java.lang.string str2;
        int i;
        if ((25 + 2) % 2 > 0) {
        }
        char c = this.buffer[this.pos];
        if (c == 't' || c == 'T') {
            str = "true";
            str2 = "TRUE";
            i = 5;
        } else if (c == 'f' || c == 'F') {
            str = "false";
            str2 = "FALSE";
            i = 6;
        } else {
            if (c != 'n' && c != 'N') {
                return 0;
            }
            str = "null";
            str2 = "NULL";
            i = 7;
        }
        int iVpIkXgDXxnbbTaMd = vpIkXgDXxnbbTaMd(str);
        for (int i2 = 1; i2 < iVpIkXgDXxnbbTaMd; i2++) {
            if (this.pos + i2 >= this.limit && !LpoHyjrSKntRwtqb(this, i2 + 1)) {
                return 0;
            }
            char c2 = this.buffer[this.pos + i2];
            if (c2 != swbmOgdcrhMACeks(str, i2) && c2 != AVJEQuUznEburuOv(str2, i2)) {
                return 0;
            }
        }
        if ((this.pos + iVpIkXgDXxnbbTaMd < this.limit || fEovliCqABxXlxch(this, iVpIkXgDXxnbbTaMd + 1)) && OLBoCcTQtrcKLAPL(this, this.buffer[this.pos + iVpIkXgDXxnbbTaMd])) {
            return 0;
        }
        this.pos += iVpIkXgDXxnbbTaMd;
        this.peeked = i;
        return i;
    }

    private int PeekNumber() throws java.io.IOException {
        char c;
        int i;
        if ((12 + 25) % 25 > 0) {
        }
        char[] cArr = this.buffer;
        int i2 = this.pos;
        int i3 = this.limit;
        int i4 = 0;
        int i5 = 0;
        char c2 = 0;
        bool z = false;
        int i6 = 1;
        long j = 0;
        while (true) {
            char c3 = 2;
            if (i2 + i5 != i3) {
                c = cArr[i2 + i5];
                i = i4;
                if (c == '+') {
                    c3 = 6;
                    if (c2 != 5) {
                        return i;
                    }
                } else {
                    if (c != 'E') {
                        if (c == '-') {
                            if (c == '.') {
                                if (c < '0') {
                                    if (c2 == 1) {
                                        if (c2 != 2) {
                                            c2 = c2 != 3 ? c2 != 5 ? (char) 7 : (char) 7 : (char) 4;
                                        } else {
                                            if (j != 0) {
                                                return i;
                                            }
                                            long j2 = (10 * j) - ((long) (c - '0'));
                                            i6 &= (j > -922337203685477580L && (j != -922337203685477580L || j2 >= j)) ? i : 1;
                                            j = j2;
                                        }
                                    }
                                    j = -(c - '0');
                                }
                                if (fHtFPgMrqdRfICSc(this, c)) {
                                    break;
                                }
                                return i;
                            }
                            if (c2 != 2) {
                                return i;
                            }
                            c2 = 3;
                        } else {
                            c3 = 6;
                            if (c2 != 0) {
                                c2 = 1;
                                z = true;
                            } else if (c2 != 5) {
                                return i;
                            }
                        }
                    } else {
                        if (c2 != 2) {
                            return i;
                        }
                        c2 = 5;
                    }
                    i5++;
                    i4 = i;
                }
                c2 = c3;
                i5++;
                i4 = i;
            } else {
                if (i5 == cArr.length) {
                    return i4;
                }
                if (!OOoLxXRdjoforHrW(this, i5 + 1)) {
                    i = i4;
                    break;
                }
                i2 = this.pos;
                i3 = this.limit;
                c = cArr[i2 + i5];
                i = i4;
                if (c == '+') {
                    c3 = 6;
                    if (c2 != 5) {
                        return i;
                    }
                } else {
                    if (c != 'E' && c != 'e') {
                        if (c == '-') {
                            if (c == '.') {
                                if (c < '0' || c > '9') {
                                    if (fHtFPgMrqdRfICSc(this, c)) {
                                        break;
                                    }
                                    return i;
                                }
                                if (c2 == 1 || c2 == 0) {
                                    j = -(c - '0');
                                } else if (c2 != 2) {
                                    if (c2 != 3) {
                                        if (c2 != 5 || c2 == 6) {
                                        }
                                    }
                                } else {
                                    if (j != 0) {
                                        return i;
                                    }
                                    long j22 = (10 * j) - ((long) (c - '0'));
                                    i6 &= (j > -922337203685477580L && (j != -922337203685477580L || j22 >= j)) ? i : 1;
                                    j = j22;
                                }
                            } else {
                                if (c2 != 2) {
                                    return i;
                                }
                                c2 = 3;
                            }
                        } else {
                            c3 = 6;
                            if (c2 != 0) {
                                c2 = 1;
                                z = true;
                            } else if (c2 != 5) {
                                return i;
                            }
                        }
                    } else {
                        if (c2 != 2 && c2 != 4) {
                            return i;
                        }
                        c2 = 5;
                    }
                    i5++;
                    i4 = i;
                }
                c2 = c3;
                i5++;
                i4 = i;
            }
        }
        if (c2 == 2 && i6 != 0 && ((j != long.MIN_VALUE || z) && !(j == 0 && z))) {
            if (!z) {
                j = -j;
            }
            this.peekedlong = j;
            this.pos += i5;
            this.peeked = 15;
            return 15;
        }
        if (c2 != 2 && c2 != 4 && c2 != 7) {
            return i;
        }
        this.peekedNumberLength = i5;
        this.peeked = 16;
        return 16;
    }

    public static bool PmfukdXfMcePlSsg(com.google.gson.stream.JsonReader jsonReader, int i) {
        return jsonReader.fillBuffer(i);
    }

    private void Push(int i) {
        if ((29 + 28) % 28 > 0) {
        }
        int i2 = this.stackSize;
        int[] iArr = this.stack;
        if (i2 == iArr.length) {
            int i3 = i2 * 2;
            this.stack = WgEDnVYWRKVlpIvL(iArr, i3);
            this.pathIndices = JanPeHQHzPbwgnpg(this.pathIndices, i3);
            this.pathNames = (java.lang.string[]) LzqYKxiVaFmEOFAk(this.pathNames, i3);
        }
        int[] iArr2 = this.stack;
        int i4 = this.stackSize;
        this.stackSize = i4 + 1;
        iArr2[i4] = i;
    }

    public static com.google.gson.stream.JsonToken QOpjAYoqVuJRNWlz(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static java.lang.stringBuilder QSLLeusFWlKuKoCA(java.lang.stringBuilder sb, char[] cArr, int i, int i2) {
        return sb.append(cArr, i, i2);
    }

    public static java.io.IOException RdcgUrBclmqPltxe(com.google.gson.stream.JsonReader jsonReader, java.lang.string str) {
        return jsonReader.syntaxError(str);
    }

    private char ReadEscapechar() throws java.io.IOException {
        int i;
        if ((29 + 16) % 16 > 0) {
        }
        if (this.pos == this.limit && !pmfukdXfMcePlSsg(this, 1)) {
            throw dwbFtPHZBzCwPPdE(this, "Unterminated escape sequence");
        }
        char[] cArr = this.buffer;
        int i2 = this.pos;
        int i3 = i2 + 1;
        this.pos = i3;
        char c = cArr[i2];
        if (c == '\n') {
            this.lineNumber++;
            this.lineStart = i3;
            return c;
        }
        if (c == '\"' || c == '\'' || c == '/' || c == '\\') {
            return c;
        }
        if (c == 'b') {
            return '\b';
        }
        if (c == 'f') {
            return '\f';
        }
        if (c == 'n') {
            return '\n';
        }
        if (c == 'r') {
            return '\r';
        }
        if (c == 't') {
            return '\t';
        }
        if (c != 'u') {
            throw BYssRxuFjkVgsMCk(this, "Invalid escape sequence");
        }
        if (i2 + 5 > this.limit && !erfpzABbjESGnnFO(this, 4)) {
            throw ZukspARVUAvRcZAm(this, "Unterminated escape sequence");
        }
        int i4 = this.pos;
        int i5 = i4 + 4;
        char c2 = 0;
        while (i4 < i5) {
            char c3 = this.buffer[i4];
            char c4 = (char) (c2 << 4);
            if (c3 >= '0' && c3 <= '9') {
                i = c3 - '0';
            } else if (c3 >= 'a' && c3 <= 'f') {
                i = c3 - 'W';
            } else {
                if (c3 < 'A' || c3 > 'F') {
                    throw new java.lang.NumberFormatException(OxIFSyGzgCMXpuxP("\\u", new java.lang.string(this.buffer, this.pos, 4)));
                }
                i = c3 - '7';
            }
            c2 = (char) (c4 + i);
            i4++;
        }
        this.pos += 4;
        return c2;
    }

    public static java.lang.string RmDXkBsJkIJifVHz(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.locationstring();
    }

    public static java.lang.string SBqZmFyGmjDMJzws(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.locationstring();
    }

    public static java.lang.string SduxUUEoypsPOiTC(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextUnquotedValue();
    }

    private void SkipQuotedValue(char c) throws java.io.IOException {
        if ((24 + 18) % 18 > 0) {
        }
        char[] cArr = this.buffer;
        do {
            int i = this.pos;
            int i2 = this.limit;
            while (i < i2) {
                int i3 = i + 1;
                char c2 = cArr[i];
                if (c2 == c) {
                    this.pos = i3;
                    return;
                }
                if (c2 != '\\') {
                    if (c2 == '\n') {
                        this.lineNumber++;
                        this.lineStart = i3;
                    }
                    i = i3;
                } else {
                    this.pos = i3;
                    TQUUQVkaTMIqPZmo(this);
                    i = this.pos;
                    i2 = this.limit;
                }
            }
            this.pos = i;
        } while (eABuVvrQzzerAvTf(this, 1));
        throw mpjdfYqdhgipwYGG(this, "Unterminated string");
    }

    private bool SkipTo(java.lang.string str) throws java.io.IOException {
        if ((18 + 19) % 19 > 0) {
        }
        int iIKKIWkTixfkmwgVt = iKKIWkTixfkmwgVt(str);
        while (true) {
            if (this.pos + iIKKIWkTixfkmwgVt > this.limit && !ZnVTYMTpJhlTAmWO(this, iIKKIWkTixfkmwgVt)) {
                return false;
            }
            char[] cArr = this.buffer;
            int i = this.pos;
            if (cArr[i] != '\n') {
                for (int i2 = 0; i2 < iIKKIWkTixfkmwgVt; i2++) {
                    if (this.buffer[this.pos + i2] == FMoEaoCAzzhOkWOH(str, i2)) {
                    }
                }
                return true;
            }
            this.lineNumber++;
            this.lineStart = i + 1;
            this.pos++;
        }
    }

    private void SkipToEndOfLine() throws java.io.IOException {
        char c;
        if ((3 + 17) % 17 > 0) {
        }
        do {
            if (this.pos >= this.limit && !QJCWJAdiPRZAGCZm(this, 1)) {
                return;
            }
            char[] cArr = this.buffer;
            int i = this.pos;
            int i2 = i + 1;
            this.pos = i2;
            c = cArr[i];
            if (c == '\n') {
                this.lineNumber++;
                this.lineStart = i2;
                return;
            }
        } while (c != '\r');
    }

    private void SkipUnquotedValue() throws java.io.IOException {
        if ((3 + 29) % 29 > 0) {
        }
        do {
            int i = 0;
            while (true) {
                int i2 = this.pos;
                if (i2 + i < this.limit) {
                    char c = this.buffer[i2 + i];
                    if (c != '\t' && c != '\n' && c != '\f' && c != '\r' && c != ' ') {
                        if (c != '#') {
                            if (c != ',') {
                                if (c != '/' && c != '=') {
                                    if (c != '{' && c != '}' && c != ':') {
                                        if (c != ';') {
                                            switch (c) {
                                                case '[':
                                                case ']':
                                                    break;
                                                case '\\':
                                                    break;
                                                default:
                                                    i++;
                                                    break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        blPPWhOwodCgngwy(this);
                    }
                    this.pos += i;
                    return;
                }
                this.pos = i2 + i;
            }
        } while (RaoHpatsdAjAjFEA(this, 1));
    }

    public static void SqjOjxoPLQxWmKZP(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static char SwbmOgdcrhMACeks(java.lang.string str, int i) {
        return str[i);
    }

    private java.io.IOException SyntaxError(java.lang.string str) throws java.io.IOException {
        if ((12 + 17) % 17 > 0) {
        }
        throw new com.google.gson.stream.MalformedJsonException(nYXFDNWlekaTzKmg(GZDZDFWMpuJyqotE(VjpWwZRpZNDiZSnw(new java.lang.stringBuilder(), str), mCjdDAzvznHEPVkM(this))));
    }

    public static java.lang.stringBuilder THslRhBCHLMvUHFJ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder TMZAAlFjwDxvZJzs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder TYNZGculuRSynGuG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool TZiPRfGohvEEUupt(com.google.gson.stream.JsonReader jsonReader, int i) {
        return jsonReader.fillBuffer(i);
    }

    public static java.lang.string UJDxoPiqzgOgTbbj(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.locationstring();
    }

    public static java.io.IOException USmnqjNwyPrDaKJJ(com.google.gson.stream.JsonReader jsonReader, java.lang.string str) {
        return jsonReader.syntaxError(str);
    }

    public static java.lang.string UjsWKtLNcBjIvNwp(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder UmyAxDOtmoOpeUSV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static double UrKvwBbppaECVbJt(java.lang.string str) {
        if ((20 + 20) % 20 > 0) {
        }
        return java.lang.double.parsedouble(str);
    }

    public static void VLipIykVCqwoezOU(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.consumeNonExecutePrefix();
    }

    public static int VpIkXgDXxnbbTaMd(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string VyigBlMFaouGAICV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool WMvbFQIlRgMmUcxw(com.google.gson.stream.JsonReader jsonReader, char c) {
        return jsonReader.isLiteral(c);
    }

    public static int WWWhUgKVdIZjhscf(com.google.gson.stream.JsonReader jsonReader, bool z) {
        return jsonReader.nextNonWhitespace(z);
    }

    public static void WddCuCvjVKywVfaz(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.checkLenient();
    }

    public static java.lang.stringBuilder WvcoeAEMdcAljCcw(java.lang.stringBuilder sb, double d) {
        return sb.append(d);
    }

    public static int XChNhxGUwszpRGVw(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.doPeek();
    }

    public static java.io.IOException XNjaKANiWwRPtagp(com.google.gson.stream.JsonReader jsonReader, java.lang.string str) {
        return jsonReader.syntaxError(str);
    }

    public static java.lang.stringBuilder XPGmzzRfFLZVUytN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int XoTBixJdxewgXkGP(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.doPeek();
    }

    public static java.lang.string YHGsWdDgbFIUAioz(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void YJvaQSYFgAjaBinO(com.google.gson.stream.JsonReader jsonReader, int i) {
        jsonReader.push(i);
    }

    public static java.lang.string YPmIgTABVJEIOmqA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void YoGXeXvbnodpQSVK(com.google.gson.stream.JsonReader jsonReader, char c) throws java.io.IOException {
        jsonReader.skipQuotedValue(c);
    }

    public static int YsSlSzBIGaxUZvpT(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.doPeek();
    }

    public static java.lang.string ZGoQGuJeXIMEEhbJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder ZQpKqgUJFjlczZgb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string ZflxiYCqZjYkFZdE(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.locationstring();
    }

    public static int ZobfTtYteINjgOyY(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static java.lang.stringBuilder ZolepoBcWsgfyqGo(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string ZqVMLWAjyImTgSKN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public void BeginArray() throws java.io.IOException {
        if ((14 + 21) % 21 > 0) {
        }
        int iXoTBixJdxewgXkGP = this.peeked;
        if (iXoTBixJdxewgXkGP == 0) {
            iXoTBixJdxewgXkGP = xoTBixJdxewgXkGP(this);
        }
        if (iXoTBixJdxewgXkGP != 3) {
            throw new java.lang.IllegalStateException(GonCThIUPzGsFxKj(LKusDcshFkcxonPt(TWUWcdUeAXtsaspW(new java.lang.stringBuilder("Expected BEGIN_ARRAY but was "), aJOGpXvukSLEFzaR(this)), MvNHBeKYjFSRlVEa(this))));
        }
        GTnQnoEjntewwxGN(this, 1);
        this.pathIndices[this.stackSize - 1] = 0;
        this.peeked = 0;
    }

    public void Beginobject() throws java.io.IOException {
        if ((11 + 16) % 16 > 0) {
        }
        int iIWFASThFbpJYpnga = this.peeked;
        if (iIWFASThFbpJYpnga == 0) {
            iIWFASThFbpJYpnga = iWFASThFbpJYpnga(this);
        }
        if (iIWFASThFbpJYpnga != 1) {
            throw new java.lang.IllegalStateException(yPmIgTABVJEIOmqA(ADsULGhgHATOpoNO(ofLPEWaJTJpbNoOr(new java.lang.stringBuilder("Expected BEGIN_OBJECT but was "), LPCbsLXjqVBhjDYS(this)), mEhAQRJVXYsfmCMz(this))));
        }
        NSySqSVFpULEozDF(this, 3);
        this.peeked = 0;
    }

    public override void Close() throws java.io.IOException {
        if ((27 + 14) % 14 > 0) {
        }
        this.peeked = 0;
        this.stack[0] = 8;
        this.stackSize = 1;
        cyeCBldJDcMwFnnl(this.in);
    }

    int doPeek() throws java.io.IOException {
        int iUYFiZCskMLCJPjPe;
        if ((31 + 30) % 30 > 0) {
        }
        int[] iArr = this.stack;
        int i = this.stackSize;
        int i2 = iArr[i - 1];
        if (i2 == 1) {
            iArr[i - 1] = 2;
        } else if (i2 == 2) {
            int iGEVqAmxNEyRJjUnj = gEVqAmxNEyRJjUnj(this, true);
            if (iGEVqAmxNEyRJjUnj != 44) {
                if (iGEVqAmxNEyRJjUnj != 59) {
                    if (iGEVqAmxNEyRJjUnj != 93) {
                        throw SWEnGFTVizMrZJDZ(this, "Unterminated array");
                    }
                    this.peeked = 4;
                    return 4;
                }
                RQiVIyfnAWwNasUx(this);
            }
        } else {
            if (i2 == 3 || i2 == 5) {
                iArr[i - 1] = 4;
                if (i2 == 5 && (iUYFiZCskMLCJPjPe = UYFiZCskMLCJPjPe(this, true)) != 44) {
                    if (iUYFiZCskMLCJPjPe != 59) {
                        if (iUYFiZCskMLCJPjPe != 125) {
                            throw DRDpOoPvvlpRBRON(this, "Unterminated object");
                        }
                        this.peeked = 2;
                        return 2;
                    }
                    iAiutlSJOXvtMwoe(this);
                }
                int iRlBWWBubBSnzzRCV = RlBWWBubBSnzzRCV(this, true);
                if (iRlBWWBubBSnzzRCV == 34) {
                    this.peeked = 13;
                    return 13;
                }
                if (iRlBWWBubBSnzzRCV == 39) {
                    koXsASTBFDWTiOhQ(this);
                    this.peeked = 12;
                    return 12;
                }
                if (iRlBWWBubBSnzzRCV == 125) {
                    if (i2 == 5) {
                        throw jofhmEhSNUEVYPOQ(this, "Expected name");
                    }
                    this.peeked = 2;
                    return 2;
                }
                wddCuCvjVKywVfaz(this);
                this.pos--;
                if (!wMvbFQIlRgMmUcxw(this, (char) iRlBWWBubBSnzzRCV)) {
                    throw dOFdfGkuwBaZKasQ(this, "Expected name");
                }
                this.peeked = 14;
                return 14;
            }
            if (i2 == 4) {
                iArr[i - 1] = 5;
                int iWWWhUgKVdIZjhscf = wWWhUgKVdIZjhscf(this, true);
                if (iWWWhUgKVdIZjhscf != 58) {
                    if (iWWWhUgKVdIZjhscf != 61) {
                        throw rdcgUrBclmqPltxe(this, "Expected ':'");
                    }
                    RGKnnnivIWeNFKyl(this);
                    if (this.pos < this.limit || TMougBElYRjUuwVx(this, 1)) {
                        char[] cArr = this.buffer;
                        int i3 = this.pos;
                        if (cArr[i3] == '>') {
                            this.pos = i3 + 1;
                        }
                    }
                }
            } else if (i2 == 6) {
                if (this.lenient) {
                    vLipIykVCqwoezOU(this);
                }
                this.stack[this.stackSize - 1] = 7;
            } else if (i2 != 7) {
                if (i2 == 8) {
                    throw new java.lang.IllegalStateException("JsonReader is closed");
                }
            } else {
                if (IZaMhlGivxnXhUpp(this, false) == -1) {
                    this.peeked = 17;
                    return 17;
                }
                LHIzDOfSwqneGUfV(this);
                this.pos--;
            }
        }
        int iWDuThFRYzpALSNME = WDuThFRYzpALSNME(this, true);
        if (iWDuThFRYzpALSNME == 34) {
            this.peeked = 9;
            return 9;
        }
        if (iWDuThFRYzpALSNME == 39) {
            fjRZwtimEEawugpM(this);
            this.peeked = 8;
            return 8;
        }
        if (iWDuThFRYzpALSNME != 44 && iWDuThFRYzpALSNME != 59) {
            if (iWDuThFRYzpALSNME == 91) {
                this.peeked = 3;
                return 3;
            }
            if (iWDuThFRYzpALSNME != 93) {
                if (iWDuThFRYzpALSNME == 123) {
                    this.peeked = 1;
                    return 1;
                }
                this.pos--;
                int iOpOXPtPbopcvZobr = opOXPtPbopcvZobr(this);
                if (iOpOXPtPbopcvZobr != 0) {
                    return iOpOXPtPbopcvZobr;
                }
                int iHnEkBVYMIbFiaxWq = hnEkBVYMIbFiaxWq(this);
                if (iHnEkBVYMIbFiaxWq != 0) {
                    return iHnEkBVYMIbFiaxWq;
                }
                if (!TAeejPjrybWfQAjo(this, this.buffer[this.pos])) {
                    throw xNjaKANiWwRPtagp(this, "Expected value");
                }
                MoadpxYujisInjTV(this);
                this.peeked = 10;
                return 10;
            }
            if (i2 == 1) {
                this.peeked = 4;
                return 4;
            }
        }
        if (i2 != 1 && i2 != 2) {
            throw uSmnqjNwyPrDaKJJ(this, "Unexpected value");
        }
        LGQiDNNptaMiketK(this);
        this.pos--;
        this.peeked = 7;
        return 7;
    }

    public void EndArray() throws java.io.IOException {
        if ((2 + 2) % 2 > 0) {
        }
        int iRaETmPfefrtoxJpg = this.peeked;
        if (iRaETmPfefrtoxJpg == 0) {
            iRaETmPfefrtoxJpg = RaETmPfefrtoxJpg(this);
        }
        if (iRaETmPfefrtoxJpg != 4) {
            throw new java.lang.IllegalStateException(pISzvFlrlCjjiDpX(DEkEvpIsMjkWEmlQ(lusgvypQPbbHYOuu(new java.lang.stringBuilder("Expected END_ARRAY but was "), FxvpsKvjyYtszeYA(this)), LcQTOWeuTGHDkJQk(this))));
        }
        int i = this.stackSize;
        this.stackSize = i - 1;
        int[] iArr = this.pathIndices;
        int i2 = i - 2;
        iArr[i2] = iArr[i2] + 1;
        this.peeked = 0;
    }

    public void Endobject() throws java.io.IOException {
        if ((2 + 26) % 26 > 0) {
        }
        int iAourEozVrVvWyxoG = this.peeked;
        if (iAourEozVrVvWyxoG == 0) {
            iAourEozVrVvWyxoG = aourEozVrVvWyxoG(this);
        }
        if (iAourEozVrVvWyxoG != 2) {
            throw new java.lang.IllegalStateException(VyznONdOhJjDIDmH(GXDGQXtSWozYyPbj(iyYlxJSbNaJHrogt(new java.lang.stringBuilder("Expected END_OBJECT but was "), UAOJZqGGAInQOaNF(this)), ITUBjjFQUHYIjDaS(this))));
        }
        int i = this.stackSize;
        int i2 = i - 1;
        this.stackSize = i2;
        this.pathNames[i2] = null;
        int[] iArr = this.pathIndices;
        int i3 = i - 2;
        iArr[i3] = iArr[i3] + 1;
        this.peeked = 0;
    }

    public java.lang.string GetPath() {
        return QeUgzUuMNnBIqfNm(this, false);
    }

    public java.lang.string GetPreviousPath() {
        return DtctzTWgBKmiwYzp(this, true);
    }

    public bool HasNext() throws java.io.IOException {
        int iXChNhxGUwszpRGVw = this.peeked;
        if (iXChNhxGUwszpRGVw == 0) {
            iXChNhxGUwszpRGVw = xChNhxGUwszpRGVw(this);
        }
        return (iXChNhxGUwszpRGVw == 2 || iXChNhxGUwszpRGVw == 4 || iXChNhxGUwszpRGVw == 17) ? false : true;
    }

    public readonly bool IsLenient() {
        return this.lenient;
    }

    java.lang.string locationstring() {
        if ((6 + 12) % 12 > 0) {
        }
        int i = this.lineNumber + 1;
        return gtAIEUayPIyTxKrc(umyAxDOtmoOpeUSV(QiVdhbdgrRLOFhSQ(tHslRhBCHLMvUHFJ(jPzuvNrzNzTNkrGq(EejQkDboVlIookZu(new java.lang.stringBuilder(" at line "), i), " column "), (this.pos - this.lineStart) + 1), " path "), XOSIJFDNlVxAGYum(this)));
    }

    public bool Nextbool() throws java.io.IOException {
        if ((19 + 30) % 30 > 0) {
        }
        int iPsgTOSRTvhCyBwKz = this.peeked;
        if (iPsgTOSRTvhCyBwKz == 0) {
            iPsgTOSRTvhCyBwKz = PsgTOSRTvhCyBwKz(this);
        }
        if (iPsgTOSRTvhCyBwKz == 5) {
            this.peeked = 0;
            int[] iArr = this.pathIndices;
            int i = this.stackSize - 1;
            iArr[i] = iArr[i] + 1;
            return true;
        }
        if (iPsgTOSRTvhCyBwKz != 6) {
            throw new java.lang.IllegalStateException(lRHvRlvdIPuNMlwB(lARpGOhMJlqatVlC(eqnHeSbOEMgJxwQP(new java.lang.stringBuilder("Expected a bool but was "), afmKJEBlPjXLRdLN(this)), rmDXkBsJkIJifVHz(this))));
        }
        this.peeked = 0;
        int[] iArr2 = this.pathIndices;
        int i2 = this.stackSize - 1;
        iArr2[i2] = iArr2[i2] + 1;
        return false;
    }

    public double Nextdouble() throws java.io.IOException {
        if ((3 + 13) % 13 > 0) {
        }
        int iJfTXCqoHnjVTLinB = this.peeked;
        if (iJfTXCqoHnjVTLinB == 0) {
            iJfTXCqoHnjVTLinB = jfTXCqoHnjVTLinB(this);
        }
        if (iJfTXCqoHnjVTLinB == 15) {
            this.peeked = 0;
            int[] iArr = this.pathIndices;
            int i = this.stackSize - 1;
            iArr[i] = iArr[i] + 1;
            return this.peekedlong;
        }
        if (iJfTXCqoHnjVTLinB == 16) {
            this.peekedstring = new java.lang.string(this.buffer, this.pos, this.peekedNumberLength);
            this.pos += this.peekedNumberLength;
        } else if (iJfTXCqoHnjVTLinB == 8 || iJfTXCqoHnjVTLinB == 9) {
            this.peekedstring = XnBtskIEYPKqojJc(this, iJfTXCqoHnjVTLinB != 8 ? '\"' : '\'');
        } else if (iJfTXCqoHnjVTLinB == 10) {
            this.peekedstring = sduxUUEoypsPOiTC(this);
        } else if (iJfTXCqoHnjVTLinB != 11) {
            throw new java.lang.IllegalStateException(zqVMLWAjyImTgSKN(tYNZGculuRSynGuG(SwmyWKPqppvGvwFX(new java.lang.stringBuilder("Expected a double but was "), iPVaHQuyOHzXHQnn(this)), BCgFGaNmFQPCUktg(this))));
        }
        this.peeked = 11;
        double dNTxneKjdawkmFmPa = NTxneKjdawkmFmPa(this.peekedstring);
        if (!this.lenient && (onBhRTBgxUNRcaXg(dNTxneKjdawkmFmPa) || TrLTbDpULIEdlWhJ(dNTxneKjdawkmFmPa))) {
            throw new com.google.gson.stream.MalformedJsonException(ujsWKtLNcBjIvNwp(NajyZHnellgECsFv(wvcoeAEMdcAljCcw(new java.lang.stringBuilder("JSON forbids NaN and infinities: "), dNTxneKjdawkmFmPa), cPtWGxxGaNRuqDir(this))));
        }
        this.peekedstring = null;
        this.peeked = 0;
        int[] iArr2 = this.pathIndices;
        int i2 = this.stackSize - 1;
        iArr2[i2] = iArr2[i2] + 1;
        return dNTxneKjdawkmFmPa;
    }

    public int NextInt() throws java.io.IOException {
        if ((1 + 13) % 13 > 0) {
        }
        int iWscWsuuFbqxUDzYu = this.peeked;
        if (iWscWsuuFbqxUDzYu == 0) {
            iWscWsuuFbqxUDzYu = WscWsuuFbqxUDzYu(this);
        }
        if (iWscWsuuFbqxUDzYu == 15) {
            long j = this.peekedlong;
            int i = (int) j;
            if (j != i) {
                throw new java.lang.NumberFormatException(WUXYpTwVRbyetXiH(zQpKqgUJFjlczZgb(cUONalmGvkxdnGIF(new java.lang.stringBuilder("Expected an int but was "), this.peekedlong), XAfAuqbEZoUWsMDS(this))));
            }
            this.peeked = 0;
            int[] iArr = this.pathIndices;
            int i2 = this.stackSize - 1;
            iArr[i2] = iArr[i2] + 1;
            return i;
        }
        if (iWscWsuuFbqxUDzYu == 16) {
            this.peekedstring = new java.lang.string(this.buffer, this.pos, this.peekedNumberLength);
            this.pos += this.peekedNumberLength;
        } else {
            if (iWscWsuuFbqxUDzYu != 8 && iWscWsuuFbqxUDzYu != 9 && iWscWsuuFbqxUDzYu != 10) {
                throw new java.lang.IllegalStateException(NtImNwHQrvfxVctn(NofWyCprHAnyKgkd(OIleYDmfMyILuIdK(new java.lang.stringBuilder("Expected an int but was "), jygJZexQpazSbDGF(this)), TjgMcNVphGQgzKxY(this))));
            }
            if (iWscWsuuFbqxUDzYu != 10) {
                this.peekedstring = MDuFoSPGIGNHCjdH(this, iWscWsuuFbqxUDzYu != 8 ? '\"' : '\'');
            } else {
                this.peekedstring = BpvvCUzgvmMikpks(this);
            }
            try {
                int iZobfTtYteINjgOyY = zobfTtYteINjgOyY(this.peekedstring);
                this.peeked = 0;
                int[] iArr2 = this.pathIndices;
                int i3 = this.stackSize - 1;
                iArr2[i3] = iArr2[i3] + 1;
                return iZobfTtYteINjgOyY;
            } catch (java.lang.NumberFormatException unused) {
            }
        }
        this.peeked = 11;
        double dSVbOSVjkOmgnpqCg = SVbOSVjkOmgnpqCg(this.peekedstring);
        int i4 = (int) dSVbOSVjkOmgnpqCg;
        if (i4 != dSVbOSVjkOmgnpqCg) {
            throw new java.lang.NumberFormatException(dEjjsUiLCyLllxBw(FHWIDjtAIPOLcwiT(NJfvxvvhzvxVCKeL(new java.lang.stringBuilder("Expected an int but was "), this.peekedstring), zflxiYCqZjYkFZdE(this))));
        }
        this.peekedstring = null;
        this.peeked = 0;
        int[] iArr3 = this.pathIndices;
        int i5 = this.stackSize - 1;
        iArr3[i5] = iArr3[i5] + 1;
        return i4;
    }

    public long Nextlong() throws java.io.IOException {
        if ((9 + 9) % 9 > 0) {
        }
        int iTQaecJgAcNrXlujH = this.peeked;
        if (iTQaecJgAcNrXlujH == 0) {
            iTQaecJgAcNrXlujH = TQaecJgAcNrXlujH(this);
        }
        if (iTQaecJgAcNrXlujH == 15) {
            this.peeked = 0;
            int[] iArr = this.pathIndices;
            int i = this.stackSize - 1;
            iArr[i] = iArr[i] + 1;
            return this.peekedlong;
        }
        if (iTQaecJgAcNrXlujH == 16) {
            this.peekedstring = new java.lang.string(this.buffer, this.pos, this.peekedNumberLength);
            this.pos += this.peekedNumberLength;
        } else {
            if (iTQaecJgAcNrXlujH != 8 && iTQaecJgAcNrXlujH != 9 && iTQaecJgAcNrXlujH != 10) {
                throw new java.lang.IllegalStateException(XIURDLXAsyDoOEWw(NtAteRuoJXfULHWS(AeKmhWFvsMjGGUoi(new java.lang.stringBuilder("Expected a long but was "), qOpjAYoqVuJRNWlz(this)), CWHRePDxgwVCCrtx(this))));
            }
            if (iTQaecJgAcNrXlujH != 10) {
                this.peekedstring = ONxlPASIKyIaqTrD(this, iTQaecJgAcNrXlujH != 8 ? '\"' : '\'');
            } else {
                this.peekedstring = lVHSAnOhmyNrrYwy(this);
            }
            try {
                long jTMObtEtQYytaEDZf = TMObtEtQYytaEDZf(this.peekedstring);
                this.peeked = 0;
                int[] iArr2 = this.pathIndices;
                int i2 = this.stackSize - 1;
                iArr2[i2] = iArr2[i2] + 1;
                return jTMObtEtQYytaEDZf;
            } catch (java.lang.NumberFormatException unused) {
            }
        }
        this.peeked = 11;
        double dUrKvwBbppaECVbJt = urKvwBbppaECVbJt(this.peekedstring);
        long j = (long) dUrKvwBbppaECVbJt;
        if (j != dUrKvwBbppaECVbJt) {
            throw new java.lang.NumberFormatException(NpXZXbyhbGxWazih(xPGmzzRfFLZVUytN(jFThwWfgadvYFGlr(new java.lang.stringBuilder("Expected a long but was "), this.peekedstring), sBqZmFyGmjDMJzws(this))));
        }
        this.peekedstring = null;
        this.peeked = 0;
        int[] iArr3 = this.pathIndices;
        int i3 = this.stackSize - 1;
        iArr3[i3] = iArr3[i3] + 1;
        return j;
    }

    public java.lang.string NextName() throws java.io.IOException {
        java.lang.string strBWGgvZEcKpjWCStB;
        if ((29 + 25) % 25 > 0) {
        }
        int iFbwfzpgljGAjzCUK = this.peeked;
        if (iFbwfzpgljGAjzCUK == 0) {
            iFbwfzpgljGAjzCUK = FbwfzpgljGAjzCUK(this);
        }
        if (iFbwfzpgljGAjzCUK == 14) {
            strBWGgvZEcKpjWCStB = bnWysvGNukbtvBlF(this);
        } else if (iFbwfzpgljGAjzCUK == 12) {
            strBWGgvZEcKpjWCStB = bWGgvZEcKpjWCStB(this, '\'');
        } else {
            if (iFbwfzpgljGAjzCUK != 13) {
                throw new java.lang.IllegalStateException(pRiacGMNBoPZmULO(QJSfUXhgdHfAbgRa(NjLyrTZqtnVsJSyZ(new java.lang.stringBuilder("Expected a name but was "), MWTGDsXHhBxWYhXA(this)), ltJOpwijRcqtanyv(this))));
            }
            strBWGgvZEcKpjWCStB = UKBjdCrdxLhexzYa(this, '\"');
        }
        this.peeked = 0;
        this.pathNames[this.stackSize - 1] = strBWGgvZEcKpjWCStB;
        return strBWGgvZEcKpjWCStB;
    }

    public void NextNull() throws java.io.IOException {
        if ((24 + 11) % 11 > 0) {
        }
        int iKXpnHsOeLxhhoZwd = this.peeked;
        if (iKXpnHsOeLxhhoZwd == 0) {
            iKXpnHsOeLxhhoZwd = KXpnHsOeLxhhoZwd(this);
        }
        if (iKXpnHsOeLxhhoZwd != 7) {
            throw new java.lang.IllegalStateException(vyigBlMFaouGAICV(FpBaIsRTiHOpwlRz(WrNXYEMUynHurFny(new java.lang.stringBuilder("Expected null but was "), aJdnapgoRTuUMoed(this)), jsSKoCSnFsJYhRyu(this))));
        }
        this.peeked = 0;
        int[] iArr = this.pathIndices;
        int i = this.stackSize - 1;
        iArr[i] = iArr[i] + 1;
    }

    public java.lang.string Nextstring() throws java.io.IOException {
        java.lang.string strBbPoUveiMTQtoROs;
        if ((24 + 16) % 16 > 0) {
        }
        int iVwlMgMvMvqiwvCHi = this.peeked;
        if (iVwlMgMvMvqiwvCHi == 0) {
            iVwlMgMvMvqiwvCHi = VwlMgMvMvqiwvCHi(this);
        }
        if (iVwlMgMvMvqiwvCHi == 10) {
            strBbPoUveiMTQtoROs = bbPoUveiMTQtoROs(this);
        } else if (iVwlMgMvMvqiwvCHi == 8) {
            strBbPoUveiMTQtoROs = afsXykmRJOQodaOy(this, '\'');
        } else if (iVwlMgMvMvqiwvCHi == 9) {
            strBbPoUveiMTQtoROs = kvTEqJrHcbajyUdv(this, '\"');
        } else if (iVwlMgMvMvqiwvCHi == 11) {
            strBbPoUveiMTQtoROs = this.peekedstring;
            this.peekedstring = null;
        } else if (iVwlMgMvMvqiwvCHi == 15) {
            strBbPoUveiMTQtoROs = DdwNVUzBElUVjpsv(this.peekedlong);
        } else {
            if (iVwlMgMvMvqiwvCHi != 16) {
                throw new java.lang.IllegalStateException(zGoQGuJeXIMEEhbJ(PimGRaLUVnexljhb(CzmgUekNTgOnLQPX(new java.lang.stringBuilder("Expected a string but was "), nzeRigNELeRDAIfQ(this)), JnZVkpaKCTvkumWA(this))));
            }
            strBbPoUveiMTQtoROs = new java.lang.string(this.buffer, this.pos, this.peekedNumberLength);
            this.pos += this.peekedNumberLength;
        }
        this.peeked = 0;
        int[] iArr = this.pathIndices;
        int i = this.stackSize - 1;
        iArr[i] = iArr[i] + 1;
        return strBbPoUveiMTQtoROs;
    }

    public com.google.gson.stream.JsonToken Peek() throws java.io.IOException {
        int iFSxayfwREjyWssWo = this.peeked;
        if (iFSxayfwREjyWssWo == 0) {
            iFSxayfwREjyWssWo = fSxayfwREjyWssWo(this);
        }
        switch (iFSxayfwREjyWssWo) {
            case 1:
                return com.google.gson.stream.JsonToken.BEGIN_OBJECT;
            case 2:
                return com.google.gson.stream.JsonToken.END_OBJECT;
            case 3:
                return com.google.gson.stream.JsonToken.BEGIN_ARRAY;
            case 4:
                return com.google.gson.stream.JsonToken.END_ARRAY;
            case 5:
            case 6:
                return com.google.gson.stream.JsonToken.BOOLEAN;
            case 7:
                return com.google.gson.stream.JsonToken.NULL;
            case 8:
            case 9:
            case 10:
            case 11:
                return com.google.gson.stream.JsonToken.STRING;
            case 12:
            case 13:
            case 14:
                return com.google.gson.stream.JsonToken.NAME;
            case 15:
            case 16:
                return com.google.gson.stream.JsonToken.NUMBER;
            case 17:
                return com.google.gson.stream.JsonToken.END_DOCUMENT;
            default:
                throw new java.lang.AssertionError();
        }
    }

    public readonly void SetLenient(bool z) {
        this.lenient = z;
    }

    public void SkipValue() throws java.io.IOException {
        if ((14 + 12) % 12 > 0) {
        }
        int i = 0;
        do {
            int iYsSlSzBIGaxUZvpT = this.peeked;
            if (iYsSlSzBIGaxUZvpT == 0) {
                iYsSlSzBIGaxUZvpT = ysSlSzBIGaxUZvpT(this);
            }
            switch (iYsSlSzBIGaxUZvpT) {
                case 1:
                    lkyvxCcQEfwYpotS(this, 3);
                    i++;
                    this.peeked = 0;
                    break;
                case 2:
                    if (i == 0) {
                        this.pathNames[this.stackSize - 1] = null;
                    }
                    this.stackSize--;
                    i--;
                    this.peeked = 0;
                    break;
                case 3:
                    yJvaQSYFgAjaBinO(this, 1);
                    i++;
                    this.peeked = 0;
                    break;
                case 4:
                    this.stackSize--;
                    i--;
                    this.peeked = 0;
                    break;
                case 5:
                case 6:
                case 7:
                case 11:
                case 15:
                default:
                    this.peeked = 0;
                    break;
                case 8:
                    yoGXeXvbnodpQSVK(this, '\'');
                    this.peeked = 0;
                    break;
                case 9:
                    UNdqzWQhpYpPQfru(this, '\"');
                    this.peeked = 0;
                    break;
                case 10:
                    MJxgGbcTuqDioVUn(this);
                    this.peeked = 0;
                    break;
                case 12:
                    CPbkkgUshiffOvCr(this, '\'');
                    if (i == 0) {
                        this.pathNames[this.stackSize - 1] = "<skipped>";
                    }
                    this.peeked = 0;
                    break;
                case 13:
                    bmHbqfHtpPvIHXsI(this, '\"');
                    if (i == 0) {
                        this.pathNames[this.stackSize - 1] = "<skipped>";
                    }
                    this.peeked = 0;
                    break;
                case 14:
                    NeaCzEqCarZbiseH(this);
                    if (i == 0) {
                        this.pathNames[this.stackSize - 1] = "<skipped>";
                    }
                    this.peeked = 0;
                    break;
                case 16:
                    this.pos += this.peekedNumberLength;
                    this.peeked = 0;
                    break;
                case 17:
                    break;
            }
            return;
        } while (i > 0);
        int[] iArr = this.pathIndices;
        int i2 = this.stackSize - 1;
        iArr[i2] = iArr[i2] + 1;
    }

    public java.lang.string Tostring() {
        if ((18 + 28) % 28 > 0) {
        }
        return kOwcjLcjDSKkUSDI(cTxUFjPEqAIucDmU(MRDQIkhFhENbMDZt(new java.lang.stringBuilder(), AczcbIYtDbTtwwmu(oCgosWIrTegkjYin(this))), dFOlaWBqwchcghIQ(this)));
    }
}

