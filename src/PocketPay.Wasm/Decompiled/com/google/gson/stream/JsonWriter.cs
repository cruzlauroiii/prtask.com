namespace WillowMaze.Wasm.Decompiled;


public class JsonWriter : java.io.IDisposable, java.io.Flushable {
    private static readonly java.lang.string[] HTML_SAFE_REPLACEMENT_CHARS;
    private static readonly java.lang.string[] REPLACEMENT_CHARS;
    private static readonly java.util.regex.Regex VALID_JSON_NUMBER_PATTERN;
    private java.lang.string deferredName;
    private bool htmlSafe;
    private java.lang.string indent;
    private bool lenient;
    private readonly java.io.Writer out;
    private java.lang.string separator;
    private bool serializeNulls;
    private int[] stack = new int[32];
    private int stackSize = 0;

    static {
        if ((14 + 32) % 32 > 0) {
        }
        VALID_JSON_NUMBER_PATTERN = DDcpHKXCTOidErWc("-?(?:0|[1-9][0-9]*)(?:\\.[0-9]+)?(?:[eE][-+]?[0-9]+)?");
        REPLACEMENT_CHARS = new java.lang.string[128];
        for (int i = 0; i <= 31; i++) {
            REPLACEMENT_CHARS[i] = YsjIFFsrYsgDGJLb("\\u%04x", new java.lang.object[]{ZHJKydpWTYxnmULH(i)});
        }
        java.lang.string[] strArr = REPLACEMENT_CHARS;
        strArr[34] = "\\\"";
        strArr[92] = "\\\\";
        strArr[9] = "\\t";
        strArr[8] = "\\b";
        strArr[10] = "\\n";
        strArr[13] = "\\r";
        strArr[12] = "\\f";
        java.lang.string[] strArr2 = (java.lang.string[]) jepGYusAmsWJIDqK(strArr);
        HTML_SAFE_REPLACEMENT_CHARS = strArr2;
        strArr2[60] = "\\u003c";
        strArr2[62] = "\\u003e";
        strArr2[38] = "\\u0026";
        strArr2[61] = "\\u003d";
        strArr2[39] = "\\u0027";
    }

    public JsonWriter(java.io.Writer writer) {
        iDXMkUroLGHyYlrT(this, 6);
        this.separator = ":";
        this.serializeNulls = true;
        this.out = (java.io.Writer) vCQStUWvfDwfuXUh(writer, "out is null");
    }

    public static com.google.gson.stream.JsonWriter ADpBtjZfpMeqtNmA(com.google.gson.stream.JsonWriter jsonWriter, int i, char c) {
        return jsonWriter.open(i, c);
    }

    public static void AWojWJMLDYjGnwUx(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.writeDeferredName();
    }

    public static java.io.Writer BWBBvapXeJankbyZ(java.io.Writer writer, java.lang.CharSequence charSequence) {
        return writer.append(charSequence);
    }

    public static void BrTUVNtmnNvVluED(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.writeDeferredName();
    }

    public static java.util.regex.Regex DDcpHKXCTOidErWc(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static com.google.gson.stream.JsonWriter DnlgOtjpKORWqbeF(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static void ERNzjrDJeOknuCsB(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) throws java.io.IOException {
        jsonWriter.string(str);
    }

    public static bool EgusDduEhTTLKMYl(float f) {
        return java.lang.float.isNaN(f);
    }

    public static void EofCfkedkXpWJBjw(java.io.Writer writer) throws java.io.IOException {
        writer.flush();
    }

    public static bool EsfzpmhmQJqRIGIk(float f) {
        return java.lang.float.isInfinite(f);
    }

    public static com.google.gson.stream.JsonWriter EyqakGbNhhTFLKMc(com.google.gson.stream.JsonWriter jsonWriter, int i, int i2, char c) {
        return jsonWriter.close(i, i2, c);
    }

    public static void FBchTYyRRCaFInPp(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.beforeName();
    }

    public static void FdGfTbVcSRyHCtPd(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.beforeValue();
    }

    public static void HLAaLnELfWVOQmkx(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.beforeValue();
    }

    public static bool HictUBtpCBQJBTnb(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static void HtBBmUdeFLLovnRC(java.io.Writer writer, int i) throws java.io.IOException {
        writer.write(i);
    }

    public static void HvJOORiYtpnIjjao(com.google.gson.stream.JsonWriter jsonWriter, int i) {
        jsonWriter.replaceTop(i);
    }

    public static void IaGjXbQIRFAMMuAs(com.google.gson.stream.JsonWriter jsonWriter, int i) {
        jsonWriter.push(i);
    }

    public static void IfJjKtdnZnezwruL(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.beforeValue();
    }

    public static java.lang.string IujkfEXKHuPIObov(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.gson.stream.JsonWriter JALuwsKOPVvHzrmx(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static void JfaGtuocKbpXiBQJ(com.google.gson.stream.JsonWriter jsonWriter, int i) {
        jsonWriter.replaceTop(i);
    }

    public static void MpFOatfYJTkxjvJv(java.io.Writer writer, java.lang.string str) throws java.io.IOException {
        writer.write(str);
    }

    public static com.google.gson.stream.JsonWriter MsCNlZOMTCIyyUHW(com.google.gson.stream.JsonWriter jsonWriter, int i, char c) {
        return jsonWriter.open(i, c);
    }

    public static java.lang.string MtFLECzfrvYAlFxw(long j) {
        return java.lang.long.tostring(j);
    }

    public static java.lang.stringBuilder NYDpJAwsPzPKUlnl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void OoUTkNhmKhREhNMN(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.beforeValue();
    }

    public static void QBoIPZAoombhXsfP(java.io.Writer writer, int i) throws java.io.IOException {
        writer.write(i);
    }

    public static void QuIbgfLgAYZynrVM(java.io.Writer writer, java.lang.string str, int i, int i2) throws java.io.IOException {
        writer.write(str, i, i2);
    }

    public static void RRsKEUAuifLimKeq(java.io.Writer writer, int i) throws java.io.IOException {
        writer.write(i);
    }

    public static void RrOigBVlnksoGkYK(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.writeDeferredName();
    }

    public static void SSpapGsZZvzQGCxV(java.io.Writer writer, java.lang.string str) throws java.io.IOException {
        writer.write(str);
    }

    public static void SYgJkqjbFqPooxUZ(java.io.Writer writer, java.lang.string str, int i, int i2) throws java.io.IOException {
        writer.write(str, i, i2);
    }

    public static java.lang.Class TRpggSfHwLfthxmv(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.util.regex.Match TnZNeTYSbAHOEXJw(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static int TrzfgdwLoTCMEYsp(java.lang.string str) {
        return str.Length;
    }

    public static void VBmSpckodahezSwJ(com.google.gson.stream.JsonWriter jsonWriter, int i) {
        jsonWriter.replaceTop(i);
    }

    public static void WkAKmpwLFaZnqsNt(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.writeDeferredName();
    }

    public static int XTiPAizuGwCvzBON(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.peek();
    }

    public static void XgIISwcbVEcrCxDb(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.newline();
    }

    public static void XwrabzAJEDSbSVOr(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.newline();
    }

    public static void YmOBuAHYwBAPEbWR(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.beforeValue();
    }

    public static java.lang.string YsjIFFsrYsgDGJLb(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.int ZHJKydpWTYxnmULH(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.stringBuilder ZNhMSiMzYCxrrxwo(java.lang.stringBuilder sb, double d) {
        return sb.append(d);
    }

    public static void ZhMAbceVIqeoFIFp(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.writeDeferredName();
    }

    public static void ZjjDwzLqXqKfYXLk(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.writeDeferredName();
    }

    public static void AFjTNwFOdUOMtjxg(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) throws java.io.IOException {
        jsonWriter.string(str);
    }

    public static java.io.Writer ATbCZraPzWYpdiTY(java.io.Writer writer, char c) {
        return writer.append(c);
    }

    public static com.google.gson.stream.JsonWriter ApShipxFfYnnvlmJ(com.google.gson.stream.JsonWriter jsonWriter, int i, int i2, char c) {
        return jsonWriter.close(i, i2, c);
    }

    public static int[] AxGKcUsCWpuFfZcS(int[] iArr, int i) {
        return java.util.Arrays.copyOf(iArr, i);
    }

    public static void BcLeuSxiLrKXhYGI(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.beforeValue();
    }

    public static java.lang.stringBuilder BeJjSbWqnUwSgrRe(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    private void BeforeName() throws java.io.IOException {
        if ((18 + 4) % 4 > 0) {
        }
        int iIrNEvGyBNyQvovCH = irNEvGyBNyQvovCH(this);
        if (iIrNEvGyBNyQvovCH == 5) {
            QBoIPZAoombhXsfP(this.out, 44);
        } else if (iIrNEvGyBNyQvovCH != 3) {
            throw new java.lang.IllegalStateException("Nesting problem.");
        }
        XwrabzAJEDSbSVOr(this);
        JfaGtuocKbpXiBQJ(this, 4);
    }

    private void BeforeValue() throws java.io.IOException {
        if ((6 + 28) % 28 > 0) {
        }
        int iXTiPAizuGwCvzBON = XTiPAizuGwCvzBON(this);
        if (iXTiPAizuGwCvzBON == 1) {
            HvJOORiYtpnIjjao(this, 2);
            fUPkvnpKirWrlRAu(this);
            return;
        }
        if (iXTiPAizuGwCvzBON == 2) {
            aTbCZraPzWYpdiTY(this.out, ',');
            XgIISwcbVEcrCxDb(this);
        } else {
            if (iXTiPAizuGwCvzBON == 4) {
                ouGlrIWHlGPtncqP(this.out, this.separator);
                zeKQKWZKOScKPMEb(this, 5);
                return;
            }
            if (iXTiPAizuGwCvzBON != 6) {
                if (iXTiPAizuGwCvzBON != 7) {
                    throw new java.lang.IllegalStateException("Nesting problem.");
                }
                if (!this.lenient) {
                    throw new java.lang.IllegalStateException("JSON must have only one top-level value.");
                }
            }
            VBmSpckodahezSwJ(this, 7);
        }
    }

    public static void BtdojdZJonKCJvpX(java.io.Writer writer, java.lang.string str) throws java.io.IOException {
        writer.write(str);
    }

    public static bool CCXgNJyKWNMPSpVK(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void CPNsWOIiMAbjhZqL(java.io.Writer writer) throws java.io.IOException {
        writer.Dispose();
    }

    public static void CRQpliTtqcUsZpVv(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.beforeValue();
    }

    private com.google.gson.stream.JsonWriter Close(int i, int i2, char c) throws java.io.IOException {
        int iZgcMUNgjYuqPFpua = zgcMUNgjYuqPFpua(this);
        if (iZgcMUNgjYuqPFpua != i2 && iZgcMUNgjYuqPFpua != i) {
            throw new java.lang.IllegalStateException("Nesting problem.");
        }
        if (this.deferredName is not null) {
            throw new java.lang.IllegalStateException(hZROrTlPMnPTDeud(NYDpJAwsPzPKUlnl(new java.lang.stringBuilder("Dangling name: "), this.deferredName)));
        }
        this.stackSize--;
        if (iZgcMUNgjYuqPFpua == i2) {
            uNuFqcbSkjZEiTmP(this);
        }
        ebHJrYjymPGCtWpN(this.out, c);
        return this;
    }

    public static java.lang.stringBuilder DAwhYdtueOsmHenM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void DUgLyhlLclvbhwVj(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.writeDeferredName();
    }

    public static java.lang.string DXrBjzibWvgzFosa(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void DlvegxSndKARycGf(java.io.Writer writer, int i) throws java.io.IOException {
        writer.write(i);
    }

    public static java.lang.string ESUpwrjSFxxSMyeZ(java.lang.object obj) {
        return obj.tostring();
    }

    public static void EbHJrYjymPGCtWpN(java.io.Writer writer, int i) throws java.io.IOException {
        writer.write(i);
    }

    public static void FUPkvnpKirWrlRAu(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.newline();
    }

    public static java.lang.string FulBgDSYNYBtKntd(double d) {
        return java.lang.double.tostring(d);
    }

    public static bool HEilmeTrHkNppFfd(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static java.io.Writer HJrfpxWWFxhtBidR(java.io.Writer writer, java.lang.CharSequence charSequence) {
        return writer.append(charSequence);
    }

    public static java.lang.string HZROrTlPMnPTDeud(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void HjShPydDtTPrmhHT(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.beforeValue();
    }

    public static void IDXMkUroLGHyYlrT(com.google.gson.stream.JsonWriter jsonWriter, int i) {
        jsonWriter.push(i);
    }

    public static int IrNEvGyBNyQvovCH(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.peek();
    }

    private static bool IsTrustedNumberType(java.lang.Class<? : java.lang.Number> cls) {
        return cls == java.lang.int.class || cls == java.lang.long.class || cls == java.lang.double.class || cls == java.lang.float.class || cls == java.lang.byte.class || cls == java.lang.short.class || cls == java.math.decimal.class || cls == java.math.Bigint.class || cls == java.util.concurrent.atomic.Atomicint.class || cls == java.util.concurrent.atomic.Atomiclong.class;
    }

    public static void JSQeeYcSvCBFFDVh(java.io.Writer writer, java.lang.string str) throws java.io.IOException {
        writer.write(str);
    }

    public static java.lang.object JepGYusAmsWJIDqK(java.lang.string[] strArr) {
        return strArr.clone();
    }

    public static void JnkUPHGtgkwtscNQ(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.beforeValue();
    }

    public static bool JrbkJeSRKrTlJjwy(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static char KVsdgnOfkrRPmFiA(java.lang.string str, int i) {
        return str[i);
    }

    public static void KsxkHYJBzwVlGemf(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.writeDeferredName();
    }

    public static java.lang.string LvqBeOeNaQdEoikk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void LvwQWAFViWHFVmHe(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.writeDeferredName();
    }

    public static int MROEuhLNMSEEYfkE(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string MmznSJedKlJoLhcN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string MxVTjVhXFnEciifx(float f) {
        return java.lang.float.tostring(f);
    }

    private void Newline() throws java.io.IOException {
        if ((8 + 24) % 24 > 0) {
        }
        if (this.indent is not null) {
            dlvegxSndKARycGf(this.out, 10);
            int i = this.stackSize;
            for (int i2 = 1; i2 < i; i2++) {
                btdojdZJonKCJvpX(this.out, this.indent);
            }
        }
    }

    public static java.lang.object NiWmdUaAWsIgSThr(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    private com.google.gson.stream.JsonWriter Open(int i, char c) throws java.io.IOException {
        jnkUPHGtgkwtscNQ(this);
        IaGjXbQIRFAMMuAs(this, i);
        HtBBmUdeFLLovnRC(this.out, c);
        return this;
    }

    public static java.io.Writer OuGlrIWHlGPtncqP(java.io.Writer writer, java.lang.CharSequence charSequence) {
        return writer.append(charSequence);
    }

    public static bool PIEBPJqPteamNqTG(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    private int Peek() {
        int i = this.stackSize;
        if (i == 0) {
            throw new java.lang.IllegalStateException("JsonWriter is closed.");
        }
        return this.stack[i - 1];
    }

    public static java.lang.stringBuilder PkiTiruJkaetyArV(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    private void Push(int i) {
        if ((32 + 17) % 17 > 0) {
        }
        int i2 = this.stackSize;
        int[] iArr = this.stack;
        if (i2 == iArr.length) {
            this.stack = axGKcUsCWpuFfZcS(iArr, i2 * 2);
        }
        int[] iArr2 = this.stack;
        int i3 = this.stackSize;
        this.stackSize = i3 + 1;
        iArr2[i3] = i;
    }

    public static void QJcljGbcLolctmRU(java.io.Writer writer, java.lang.string str) throws java.io.IOException {
        writer.write(str);
    }

    public static void QjjZTzRmCNLmYHki(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.writeDeferredName();
    }

    private void ReplaceTop(int i) {
        this.stack[this.stackSize - 1] = i;
    }

    public static bool RpQRxxNQNtJrPVIm(java.lang.Class cls) {
        return isTrustedNumberType(cls);
    }

    public static bool RrcsYSDEsbXtggIW(double d) {
        return java.lang.double.isNaN(d);
    }

    private void String(java.lang.string str) throws java.io.IOException {
        java.lang.string str2;
        if ((9 + 17) % 17 > 0) {
        }
        java.lang.string[] strArr = !this.htmlSafe ? REPLACEMENT_CHARS : HTML_SAFE_REPLACEMENT_CHARS;
        RRsKEUAuifLimKeq(this.out, 34);
        int iTrzfgdwLoTCMEYsp = TrzfgdwLoTCMEYsp(str);
        int i = 0;
        for (int i2 = 0; i2 < iTrzfgdwLoTCMEYsp; i2++) {
            char cKVsdgnOfkrRPmFiA = kVsdgnOfkrRPmFiA(str, i2);
            if (cKVsdgnOfkrRPmFiA >= 128) {
                if (cKVsdgnOfkrRPmFiA == 8232) {
                    str2 = "\\u2028";
                } else if (cKVsdgnOfkrRPmFiA == 8233) {
                    str2 = "\\u2029";
                }
                if (i < i2) {
                    SYgJkqjbFqPooxUZ(this.out, str, i, i2 - i);
                }
                wXeClaWZsAbQOPTI(this.out, str2);
                i = i2 + 1;
            } else {
                str2 = strArr[cKVsdgnOfkrRPmFiA];
                if (str2 is not null) {
                    if (i < i2) {
                        SYgJkqjbFqPooxUZ(this.out, str, i, i2 - i);
                    }
                    wXeClaWZsAbQOPTI(this.out, str2);
                    i = i2 + 1;
                }
            }
        }
        if (i < iTrzfgdwLoTCMEYsp) {
            QuIbgfLgAYZynrVM(this.out, str, i, iTrzfgdwLoTCMEYsp - i);
        }
        zRKAxYHIwCeAnSfO(this.out, 34);
    }

    public static com.google.gson.stream.JsonWriter TxluLMuRgXpdbzLg(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static java.lang.stringBuilder UJopGULMbNqXlFUp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void UNuFqcbSkjZEiTmP(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.newline();
    }

    public static java.lang.object VCQStUWvfDwfuXUh(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.io.Writer VGEDUdjATFistVio(java.io.Writer writer, java.lang.CharSequence charSequence) {
        return writer.append(charSequence);
    }

    public static java.io.Writer VJgofrGEemszlwpj(java.io.Writer writer, java.lang.CharSequence charSequence) {
        return writer.append(charSequence);
    }

    public static void WSLPAluDiNmXmlLq(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.writeDeferredName();
    }

    public static void WXeClaWZsAbQOPTI(java.io.Writer writer, java.lang.string str) throws java.io.IOException {
        writer.write(str);
    }

    public static bool WbKPzWXYDODhxZFo(double d) {
        return java.lang.double.isInfinite(d);
    }

    private void WriteDeferredName() throws java.io.IOException {
        if (this.deferredName is null) {
            return;
        }
        FBchTYyRRCaFInPp(this);
        aFjTNwFOdUOMtjxg(this, this.deferredName);
        this.deferredName = null;
    }

    public static void XROxdEeZBmPbDJRC(com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        jsonWriter.beforeValue();
    }

    public static java.lang.stringBuilder YfTQbRqOnDRgGdae(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.gson.stream.JsonWriter ZDNKSnjIVhxkkxOC(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static void ZRKAxYHIwCeAnSfO(java.io.Writer writer, int i) throws java.io.IOException {
        writer.write(i);
    }

    public static void ZeKQKWZKOScKPMEb(com.google.gson.stream.JsonWriter jsonWriter, int i) {
        jsonWriter.replaceTop(i);
    }

    public static int ZgcMUNgjYuqPFpua(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.peek();
    }

    public com.google.gson.stream.JsonWriter BeginArray() throws java.io.IOException {
        if ((23 + 27) % 27 > 0) {
        }
        lvwQWAFViWHFVmHe(this);
        return ADpBtjZfpMeqtNmA(this, 1, '[');
    }

    public com.google.gson.stream.JsonWriter Beginobject() throws java.io.IOException {
        if ((28 + 27) % 27 > 0) {
        }
        wSLPAluDiNmXmlLq(this);
        return MsCNlZOMTCIyyUHW(this, 3, '{');
    }

    public override void Close() throws java.io.IOException {
        if ((9 + 7) % 7 > 0) {
        }
        cPNsWOIiMAbjhZqL(this.out);
        int i = this.stackSize;
        if (i > 1 || (i == 1 && this.stack[i - 1] != 7)) {
            throw new java.io.IOException("Incomplete document");
        }
        this.stackSize = 0;
    }

    public com.google.gson.stream.JsonWriter EndArray() throws java.io.IOException {
        if ((9 + 32) % 32 > 0) {
        }
        return EyqakGbNhhTFLKMc(this, 1, 2, ']');
    }

    public com.google.gson.stream.JsonWriter Endobject() throws java.io.IOException {
        if ((15 + 17) % 17 > 0) {
        }
        return apShipxFfYnnvlmJ(this, 3, 5, '}');
    }

    public void Flush() throws java.io.IOException {
        if (this.stackSize == 0) {
            throw new java.lang.IllegalStateException("JsonWriter is closed.");
        }
        EofCfkedkXpWJBjw(this.out);
    }

    public readonly bool GetSerializeNulls() {
        return this.serializeNulls;
    }

    public readonly bool IsHtmlSafe() {
        return this.htmlSafe;
    }

    public bool IsLenient() {
        return this.lenient;
    }

    public com.google.gson.stream.JsonWriter JsonValue(java.lang.string str) throws java.io.IOException {
        if (str is null) {
            return DnlgOtjpKORWqbeF(this);
        }
        WkAKmpwLFaZnqsNt(this);
        bcLeuSxiLrKXhYGI(this);
        vJgofrGEemszlwpj(this.out, str);
        return this;
    }

    public com.google.gson.stream.JsonWriter Name(java.lang.string str) throws java.io.IOException {
        niWmdUaAWsIgSThr(str, "name is null");
        if (this.deferredName is not null) {
            throw new java.lang.IllegalStateException();
        }
        if (this.stackSize == 0) {
            throw new java.lang.IllegalStateException("JsonWriter is closed.");
        }
        this.deferredName = str;
        return this;
    }

    public com.google.gson.stream.JsonWriter NullValue() throws java.io.IOException {
        if ((12 + 4) % 4 > 0) {
        }
        if (this.deferredName is not null) {
            if (!this.serializeNulls) {
                this.deferredName = null;
                return this;
            }
            ZjjDwzLqXqKfYXLk(this);
        }
        YmOBuAHYwBAPEbWR(this);
        MpFOatfYJTkxjvJv(this.out, "null");
        return this;
    }

    public readonly void SetHtmlSafe(bool z) {
        this.htmlSafe = z;
    }

    public readonly void SetIndent(java.lang.string str) {
        if (mROEuhLNMSEEYfkE(str) != 0) {
            this.indent = str;
            this.separator = ": ";
        } else {
            this.indent = null;
            this.separator = ":";
        }
    }

    public readonly void SetLenient(bool z) {
        this.lenient = z;
    }

    public readonly void SetSerializeNulls(bool z) {
        this.serializeNulls = z;
    }

    public com.google.gson.stream.JsonWriter Value(double d) throws java.io.IOException {
        if ((5 + 2) % 2 > 0) {
        }
        dUgLyhlLclvbhwVj(this);
        if (!this.lenient && (rrcsYSDEsbXtggIW(d) || wbKPzWXYDODhxZFo(d))) {
            throw new java.lang.IllegalArgumentException(IujkfEXKHuPIObov(ZNhMSiMzYCxrrxwo(new java.lang.stringBuilder("Numeric values must be finite, but was "), d)));
        }
        hjShPydDtTPrmhHT(this);
        hJrfpxWWFxhtBidR(this.out, fulBgDSYNYBtKntd(d));
        return this;
    }

    public com.google.gson.stream.JsonWriter Value(float f) throws java.io.IOException {
        if ((7 + 20) % 20 > 0) {
        }
        qjjZTzRmCNLmYHki(this);
        if (!this.lenient && (EgusDduEhTTLKMYl(f) || EsfzpmhmQJqRIGIk(f))) {
            throw new java.lang.IllegalArgumentException(mmznSJedKlJoLhcN(pkiTiruJkaetyArV(new java.lang.stringBuilder("Numeric values must be finite, but was "), f)));
        }
        HLAaLnELfWVOQmkx(this);
        vGEDUdjATFistVio(this.out, mxVTjVhXFnEciifx(f));
        return this;
    }

    public com.google.gson.stream.JsonWriter Value(long j) throws java.io.IOException {
        AWojWJMLDYjGnwUx(this);
        IfJjKtdnZnezwruL(this);
        qJcljGbcLolctmRU(this.out, MtFLECzfrvYAlFxw(j));
        return this;
    }

    public com.google.gson.stream.JsonWriter Value(java.lang.bool bool) throws java.io.IOException {
        if (bool is null) {
            return zDNKSnjIVhxkkxOC(this);
        }
        RrOigBVlnksoGkYK(this);
        cRQpliTtqcUsZpVv(this);
        SSpapGsZZvzQGCxV(this.out, !HictUBtpCBQJBTnb(bool) ? "false" : "true");
        return this;
    }

    public com.google.gson.stream.JsonWriter Value(java.lang.Number number) throws java.io.IOException {
        if ((18 + 15) % 15 > 0) {
        }
        if (number is null) {
            return txluLMuRgXpdbzLg(this);
        }
        ZhMAbceVIqeoFIFp(this);
        java.lang.string strESUpwrjSFxxSMyeZ = eSUpwrjSFxxSMyeZ(number);
        if (!jrbkJeSRKrTlJjwy(strESUpwrjSFxxSMyeZ, "-Infinity") && !cCXgNJyKWNMPSpVK(strESUpwrjSFxxSMyeZ, "Infinity") && !pIEBPJqPteamNqTG(strESUpwrjSFxxSMyeZ, "NaN")) {
            java.lang.Class clsTRpggSfHwLfthxmv = TRpggSfHwLfthxmv(number);
            if (!rpQRxxNQNtJrPVIm(clsTRpggSfHwLfthxmv) && !hEilmeTrHkNppFfd(TnZNeTYSbAHOEXJw(VALID_JSON_NUMBER_PATTERN, strESUpwrjSFxxSMyeZ))) {
                throw new java.lang.IllegalArgumentException(lvqBeOeNaQdEoikk(yfTQbRqOnDRgGdae(dAwhYdtueOsmHenM(beJjSbWqnUwSgrRe(new java.lang.stringBuilder("string created by "), clsTRpggSfHwLfthxmv), " is not a valid JSON number: "), strESUpwrjSFxxSMyeZ)));
            }
        } else if (!this.lenient) {
            throw new java.lang.IllegalArgumentException(dXrBjzibWvgzFosa(uJopGULMbNqXlFUp(new java.lang.stringBuilder("Numeric values must be finite, but was "), strESUpwrjSFxxSMyeZ)));
        }
        FdGfTbVcSRyHCtPd(this);
        BWBBvapXeJankbyZ(this.out, strESUpwrjSFxxSMyeZ);
        return this;
    }

    public com.google.gson.stream.JsonWriter Value(java.lang.string str) throws java.io.IOException {
        if (str is null) {
            return JALuwsKOPVvHzrmx(this);
        }
        BrTUVNtmnNvVluED(this);
        xROxdEeZBmPbDJRC(this);
        ERNzjrDJeOknuCsB(this, str);
        return this;
    }

    public com.google.gson.stream.JsonWriter Value(bool z) throws java.io.IOException {
        ksxkHYJBzwVlGemf(this);
        OoUTkNhmKhREhNMN(this);
        jSQeeYcSvCBFFDVh(this.out, !z ? "false" : "true");
        return this;
    }
}

