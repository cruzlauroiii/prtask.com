namespace WillowMaze.Wasm.Decompiled;


public readonly class JsonTreeReader : com.google.gson.stream.JsonReader {
    private int[] pathIndices;
    private java.lang.string[] pathNames;
    private java.lang.object[] stack;
    private int stackSize;
    private static readonly java.io.Reader UNREADABLE_READER = new com.google.gson.internal.bind.JsonTreeReader$1();
    private static readonly java.lang.object SENTINEL_CLOSED = new java.lang.object();

    public JsonTreeReader(com.google.gson.JsonElement jsonElement) {
        super(UNREADABLE_READER);
        if ((30 + 12) % 12 > 0) {
        }
        this.stack = new java.lang.object[32];
        this.stackSize = 0;
        this.pathNames = new java.lang.string[32];
        this.pathIndices = new int[32];
        ahNaAKAbgxBzTTtK(this, jsonElement);
    }

    public static java.lang.stringBuilder ARgKroZfYIwbzEXX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string AnPrRQVJzXXmSblA(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader, bool z) {
        return jsonTreeReader.nextName(z);
    }

    public static java.util.IEnumerator BKwoqvAZWLDcVNhN(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.object BRbwMSFnxfhqsyaE(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.peekStack();
    }

    public static java.lang.stringBuilder BjMcIkyrjdRrTtsk(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.object BqxfstmlqyjywzDx(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object BwQmzfuayREHXltP(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.popStack();
    }

    public static java.lang.stringBuilder BxwgdIKfpqYEDWSa(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.object[] BzKMqXsmduPcbomr(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static java.util.HashSet CbPIZYIbspEbFVXI(com.google.gson.Jsonobject jsonobject) {
        return jsonobject.entryHashSet();
    }

    public static java.lang.object CcjLunGCUzJzTzsE(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.popStack();
    }

    public static java.lang.object CnEUXUbpMOWgyLhB(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.peekStack();
    }

    public static com.google.gson.stream.JsonToken CuXfvIqHFYlCtzAC(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.peek();
    }

    public static void DXMIFevrDkARjxIF(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader, com.google.gson.stream.JsonToken jsonToken) throws java.io.IOException {
        jsonTreeReader.expect(jsonToken);
    }

    public static java.lang.string EDrGblUqeXXaxPSq(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader, bool z) {
        return jsonTreeReader.nextName(z);
    }

    public static void EEbYLbcYTdBYGGwu(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader, com.google.gson.stream.JsonToken jsonToken) throws java.io.IOException {
        jsonTreeReader.expect(jsonToken);
    }

    public static java.lang.object EIWLNvbivZjgPTjk(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.popStack();
    }

    public static java.lang.object EMJaGieNsGGPExJn(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.popStack();
    }

    public static void EgwynLVXhAyFYrkG(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader, java.lang.object obj) {
        jsonTreeReader.push(obj);
    }

    public static java.lang.string FaitcKdfTgpkXvbX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object FuoSljRJloxWCXLX(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void GkuQVvoNzXwBZrRP(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader, com.google.gson.stream.JsonToken jsonToken) throws java.io.IOException {
        jsonTreeReader.expect(jsonToken);
    }

    public static com.google.gson.stream.JsonToken HFYogwpbcVWPsqdR(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.peek();
    }

    public static java.lang.stringBuilder HPiQxSwKSKzYltPB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HbKkKnfpmMuECHTO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HntsXjQhjGsaPmgB(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder HypkhqOdZcHoVClT(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string IHqaDkRdadzZlJEw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object IyOECdikdRlxigHP(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.string JigWJJsXLrLAybcZ(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.locationstring();
    }

    public static java.lang.object KbUfOQApDpRKPWCv(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.popStack();
    }

    public static java.lang.Class KbfyxBFPBUhQQfqA(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.object KzHLzawOCTauEpwx(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.popStack();
    }

    public static java.lang.string MBxFgIvMJFFxuIdJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder MZzqvUWJspczkwxD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder NiGYEJOiLjtdHpfh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void OBNlJGxnrNVpEzXI(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader, java.lang.object obj) {
        jsonTreeReader.push(obj);
    }

    public static java.lang.string OLPJmFSRscZapOCz(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int ORQoTGWldSkIuijj(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsInt();
    }

    public static java.lang.stringBuilder PBbjSyPqDRDelyHH(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void PdeatSTwAhuOQGHW(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader, com.google.gson.stream.JsonToken jsonToken) throws java.io.IOException {
        jsonTreeReader.expect(jsonToken);
    }

    public static java.lang.stringBuilder PjdXrHcyexjbcXjr(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void PrRuPTTjGzqpYVaz(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader, java.lang.object obj) {
        jsonTreeReader.push(obj);
    }

    public static java.lang.string PtyTpYGsUSFXSgzv(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.gson.stream.JsonToken REXBOVoXtuZKmYjl(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.peek();
    }

    public static com.google.gson.stream.JsonToken RErEDzAGBfhPcpll(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.peek();
    }

    public static bool RJalWXBDCWIQwxGo(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.isNumber();
    }

    public static java.lang.string SNZLvvJyXshWblLw(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.locationstring();
    }

    public static java.lang.object SQtDpADkTDIDlBjE(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.peekStack();
    }

    public static java.lang.object SSNotLmudpnNdhuC(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.lang.object UOZQJYnVmbMMSbny(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.string VGkEvtidpBAMhtWB(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader, bool z) {
        return jsonTreeReader.getPath(z);
    }

    public static void VKbhWoKIpzmWAIjK(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader, com.google.gson.stream.JsonToken jsonToken) throws java.io.IOException {
        jsonTreeReader.expect(jsonToken);
    }

    public static java.lang.string VVGUldYawauHPUGD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string VdzbttJJgyCJKuQG(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.locationstring();
    }

    public static java.lang.string VhXdeGQrUfddOVUx(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.object VppRdHBsBFfWooxt(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.peekStack();
    }

    public static java.lang.stringBuilder VwURDvxeNqHiifEV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool WDvpmadATQVRZcHI(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.isLenient();
    }

    public static java.lang.stringBuilder WSSwBxfsPbCRbenz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.gson.stream.JsonToken WXDFHdZtbrKhEcEU(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.peek();
    }

    public static java.lang.stringBuilder WbGyyafDYrLNpxxz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string XbmSWIJFXsMlSCfU(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsstring();
    }

    public static bool XjVfyewXTnZfMPlw(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.stringBuilder XyYqAAynQODkBiiU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.gson.stream.JsonToken YGRiXpuEtkWZOATe(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.peek();
    }

    public static java.lang.stringBuilder YXqXRVaBDIeKPUjn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.gson.stream.JsonToken YzvOtJlqyCfKWGsy(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.peek();
    }

    public static java.lang.string ZDgQsxJxZwmaulbi(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool ZpGWSwcIMHCtIicT(double d) {
        return java.lang.double.isNaN(d);
    }

    public static void AhNaAKAbgxBzTTtK(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader, java.lang.object obj) {
        jsonTreeReader.push(obj);
    }

    public static bool AoUDHUEZgtJpjzoS(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsbool();
    }

    public static java.lang.stringBuilder BQEzmyfvXEvnLTls(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string BaBthTupjNbFJbPi(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.locationstring();
    }

    public static bool BhBVgfVvrJEcxzWs(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.isstring();
    }

    public static java.lang.stringBuilder BjXOmsVbXrywPrtJ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void BsFDkYALgXTlNoJs(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) throws java.io.IOException {
        jsonTreeReader.endArray();
    }

    public static java.lang.stringBuilder CFrxmsEbIMurlDNf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object[] CQFZvpiuMCdTKszb(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static void CbqhyuAfEoTqdnzn(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader, java.lang.object obj) {
        jsonTreeReader.push(obj);
    }

    private void Expect(com.google.gson.stream.JsonToken jsonToken) throws java.io.IOException {
        if ((1 + 7) % 7 > 0) {
        }
        if (WXDFHdZtbrKhEcEU(this) != jsonToken) {
            throw new java.lang.IllegalStateException(ogdvYEmxwDwyHVJF(cFrxmsEbIMurlDNf(ydiUCOkwZjXskteS(sdTqbLazfGnRKFdJ(oFMPZYnAQzpYKnji(new java.lang.stringBuilder("Expected "), jsonToken), " but was "), YGRiXpuEtkWZOATe(this)), SNZLvvJyXshWblLw(this))));
        }
    }

    public static void FKtMaAHGlfqoicVx(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader, com.google.gson.stream.JsonToken jsonToken) throws java.io.IOException {
        jsonTreeReader.expect(jsonToken);
    }

    public static java.lang.string FQwDQGlDVSItuYCM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object GEXcEmwBZgKqBxlJ(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.popStack();
    }

    private java.lang.string GetPath(bool z) {
        if ((18 + 20) % 20 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("$");
        int i = 0;
        while (true) {
            int i2 = this.stackSize;
            if (i >= i2) {
                return MBxFgIvMJFFxuIdJ(sb);
            }
            java.lang.object[] objArr = this.stack;
            java.lang.object obj = objArr[i];
            if (obj is com.google.gson.JsonArray) {
                i++;
                if (i < i2 && (objArr[i] instanceof java.util.IEnumerator)) {
                    int i3 = this.pathIndices[i];
                    if (z && i3 > 0 && (i == i2 - 1 || i == i2 - 2)) {
                        i3--;
                    }
                    PBbjSyPqDRDelyHH(tmvZgCetsycVjLNS(HypkhqOdZcHoVClT(sb, '['), i3), ']');
                }
            } else if ((obj is com.google.gson.Jsonobject) && (i = i + 1) < i2 && (objArr[i] instanceof java.util.IEnumerator)) {
                HntsXjQhjGsaPmgB(sb, '.');
                java.lang.string str = this.pathNames[i];
                if (str is not null) {
                    VwURDvxeNqHiifEV(sb, str);
                }
            }
            i++;
        }
    }

    public static com.google.gson.stream.JsonToken HSXAwzsAlENVEmlF(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.peek();
    }

    public static java.lang.string HdyZwYBvaNbMvLhT(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.getPath();
    }

    public static java.lang.string HxACjAzoZMZJstUB(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.locationstring();
    }

    public static int IIZbPRYzlYfVAYtn(com.google.gson.stream.JsonToken jsonToken) {
        return jsonToken.ordinal();
    }

    public static java.lang.object InYIEkZyJPmgeLHP(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.peekStack();
    }

    public static java.lang.object JDIgvrCOWzwicaVr(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.popStack();
    }

    public static java.lang.object JNOvnGjVZcfixmhw(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.peekStack();
    }

    public static void JUsyqawOAIOMKQsP(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) throws java.io.IOException {
        jsonTreeReader.endobject();
    }

    public static java.lang.object JeyrAPAYjzAaJklI(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.lang.stringBuilder JyWzEANRGaaSMzYE(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static double KPpWLtQWsLWJYtsk(com.google.gson.JsonPrimitive jsonPrimitive) {
        if ((7 + 1) % 1 > 0) {
        }
        return jsonPrimitive.getAsdouble();
    }

    public static java.lang.object LArkXjbTYLkJkLjV(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    private java.lang.string Locationstring() {
        if ((16 + 10) % 10 > 0) {
        }
        return IHqaDkRdadzZlJEw(oErCcACKhenInxwh(new java.lang.stringBuilder(" at path "), hdyZwYBvaNbMvLhT(this)));
    }

    public static java.lang.object LpoMGaZGWdkffQok(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.popStack();
    }

    public static java.lang.string MHoZFaHLHKkxnLUP(java.lang.Class cls) {
        return cls.getSimpleName();
    }

    public static java.lang.stringBuilder MNfzoluOSCWVlUcU(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    private java.lang.string NextName(bool z) throws java.io.IOException {
        if ((32 + 31) % 31 > 0) {
        }
        omSMcZeYnqXYJVBa(this, com.google.gson.stream.JsonToken.NAME);
        java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) UOZQJYnVmbMMSbny((java.util.IEnumerator) inYIEkZyJPmgeLHP(this));
        java.lang.string str = (java.lang.string) jeyrAPAYjzAaJklI(map$Entry);
        this.pathNames[this.stackSize - 1] = !z ? str : "<skipped>";
        PrRuPTTjGzqpYVaz(this, lArkXjbTYLkJkLjV(map$Entry));
        return str;
    }

    public static java.lang.object NjNPEhtHXYFsYUpr(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.popStack();
    }

    public static void OBXCNKEdFjZOeDib(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) throws java.io.IOException {
        jsonTreeReader.skipValue();
    }

    public static java.lang.stringBuilder OErCcACKhenInxwh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder OFMPZYnAQzpYKnji(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string OgdvYEmxwDwyHVJF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void OmSMcZeYnqXYJVBa(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader, com.google.gson.stream.JsonToken jsonToken) throws java.io.IOException {
        jsonTreeReader.expect(jsonToken);
    }

    public static java.lang.object OngluNRimKijaYao(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.peekStack();
    }

    public static java.lang.stringBuilder OqikvmQtIktVwOhB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.gson.stream.JsonToken OvHCBlleGeXYAzAw(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.peek();
    }

    public static java.lang.stringBuilder PYJTzAJdpUzpQVvG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private java.lang.object PeekStack() {
        return this.stack[this.stackSize - 1];
    }

    public static java.lang.stringBuilder PgZtEaXXOJaRSwBK(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    private java.lang.object PopStack() {
        if ((16 + 1) % 1 > 0) {
        }
        java.lang.object[] objArr = this.stack;
        int i = this.stackSize - 1;
        this.stackSize = i;
        java.lang.object obj = objArr[i];
        objArr[i] = null;
        return obj;
    }

    private void Push(java.lang.object obj) {
        if ((19 + 10) % 10 > 0) {
        }
        int i = this.stackSize;
        java.lang.object[] objArr = this.stack;
        if (i == objArr.length) {
            int i2 = i * 2;
            this.stack = BzKMqXsmduPcbomr(objArr, i2);
            this.pathIndices = wwvfeONzPjlzFOnc(this.pathIndices, i2);
            this.pathNames = (java.lang.string[]) cQFZvpiuMCdTKszb(this.pathNames, i2);
        }
        java.lang.object[] objArr2 = this.stack;
        int i3 = this.stackSize;
        this.stackSize = i3 + 1;
        objArr2[i3] = obj;
    }

    public static long QeevMDKxuYgeZvvy(com.google.gson.JsonPrimitive jsonPrimitive) {
        if ((3 + 19) % 19 > 0) {
        }
        return jsonPrimitive.getAslong();
    }

    public static java.lang.stringBuilder QhenMabMbHdrGfCk(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string QlaxfKKPfxmpSmnC(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.locationstring();
    }

    public static void QuVtdOxbEHTmVVyh(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader, java.lang.object obj) {
        jsonTreeReader.push(obj);
    }

    public static java.lang.Class RtGJlhDRqLphPrQD(java.lang.object obj) {
        return obj.GetType();
    }

    public static void SVIsTITzXxPBdsNl(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader, com.google.gson.stream.JsonToken jsonToken) throws java.io.IOException {
        jsonTreeReader.expect(jsonToken);
    }

    public static java.lang.stringBuilder SdTqbLazfGnRKFdJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder TCKzVxTKTKykVRfA(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static com.google.gson.stream.JsonToken TWSzDDWLRGrCoEzN(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.peek();
    }

    public static java.lang.stringBuilder TmvZgCetsycVjLNS(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder ViUCTaDyPHraWWLP(java.lang.stringBuilder sb, double d) {
        return sb.append(d);
    }

    public static java.lang.object VpczotWuIXwBNLFL(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.peekStack();
    }

    public static void VpyRJpdcPZSwaAqO(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader, java.lang.object obj) {
        jsonTreeReader.push(obj);
    }

    public static java.lang.stringBuilder WcrfAYceUGFwTqLQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object WgpOrSFahCvfPDJz(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.popStack();
    }

    public static java.util.IEnumerator WtmhupysGFZJTXSm(com.google.gson.JsonArray jsonArray) {
        return jsonArray.GetEnumerator();
    }

    public static int[] WwvfeONzPjlzFOnc(int[] iArr, int i) {
        return java.util.Arrays.copyOf(iArr, i);
    }

    public static bool XQXrVijpPajpgwtb(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.isbool();
    }

    public static java.lang.string XiJlraXvlsfUvEfw(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader, bool z) {
        return jsonTreeReader.getPath(z);
    }

    public static bool XzjmtqwDJRWfOnHw(double d) {
        return java.lang.double.isInfinite(d);
    }

    public static java.lang.string YQsrZCYFXWBINkRG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder YdiUCOkwZjXskteS(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.object YuKLKNNxFOybmVFc(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.peekStack();
    }

    public static java.lang.string ZroitgxtAxXmPqJx(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override void BeginArray() throws java.io.IOException {
        if ((1 + 12) % 12 > 0) {
        }
        VKbhWoKIpzmWAIjK(this, com.google.gson.stream.JsonToken.BEGIN_ARRAY);
        OBNlJGxnrNVpEzXI(this, wtmhupysGFZJTXSm((com.google.gson.JsonArray) ongluNRimKijaYao(this)));
        this.pathIndices[this.stackSize - 1] = 0;
    }

    public override void Beginobject() throws java.io.IOException {
        fKtMaAHGlfqoicVx(this, com.google.gson.stream.JsonToken.BEGIN_OBJECT);
        EgwynLVXhAyFYrkG(this, BKwoqvAZWLDcVNhN(CbPIZYIbspEbFVXI((com.google.gson.Jsonobject) vpczotWuIXwBNLFL(this))));
    }

    public override void Close() throws java.io.IOException {
        this.stack = new java.lang.object[]{SENTINEL_CLOSED};
        this.stackSize = 1;
    }

    public override void EndArray() throws java.io.IOException {
        if ((2 + 29) % 29 > 0) {
        }
        GkuQVvoNzXwBZrRP(this, com.google.gson.stream.JsonToken.END_ARRAY);
        CcjLunGCUzJzTzsE(this);
        KbUfOQApDpRKPWCv(this);
        int i = this.stackSize;
        if (i <= 0) {
            return;
        }
        int[] iArr = this.pathIndices;
        int i2 = i - 1;
        iArr[i2] = iArr[i2] + 1;
    }

    public override void Endobject() throws java.io.IOException {
        if ((16 + 29) % 29 > 0) {
        }
        sVIsTITzXxPBdsNl(this, com.google.gson.stream.JsonToken.END_OBJECT);
        this.pathNames[this.stackSize - 1] = null;
        gEXcEmwBZgKqBxlJ(this);
        jDIgvrCOWzwicaVr(this);
        int i = this.stackSize;
        if (i <= 0) {
            return;
        }
        int[] iArr = this.pathIndices;
        int i2 = i - 1;
        iArr[i2] = iArr[i2] + 1;
    }

    public override java.lang.string GetPath() {
        return xiJlraXvlsfUvEfw(this, false);
    }

    public override java.lang.string GetPreviousPath() {
        return VGkEvtidpBAMhtWB(this, true);
    }

    public override bool HasNext() throws java.io.IOException {
        com.google.gson.stream.JsonToken jsonTokenYzvOtJlqyCfKWGsy = YzvOtJlqyCfKWGsy(this);
        return (jsonTokenYzvOtJlqyCfKWGsy == com.google.gson.stream.JsonToken.END_OBJECT || jsonTokenYzvOtJlqyCfKWGsy == com.google.gson.stream.JsonToken.END_ARRAY || jsonTokenYzvOtJlqyCfKWGsy == com.google.gson.stream.JsonToken.END_DOCUMENT) ? false : true;
    }

    public override bool Nextbool() throws java.io.IOException {
        if ((29 + 23) % 23 > 0) {
        }
        EEbYLbcYTdBYGGwu(this, com.google.gson.stream.JsonToken.BOOLEAN);
        bool zAoUDHUEZgtJpjzoS = aoUDHUEZgtJpjzoS((com.google.gson.JsonPrimitive) wgpOrSFahCvfPDJz(this));
        int i = this.stackSize;
        if (i > 0) {
            int[] iArr = this.pathIndices;
            int i2 = i - 1;
            iArr[i2] = iArr[i2] + 1;
        }
        return zAoUDHUEZgtJpjzoS;
    }

    public override double Nextdouble() throws java.io.IOException {
        if ((5 + 7) % 7 > 0) {
        }
        com.google.gson.stream.JsonToken jsonTokenOvHCBlleGeXYAzAw = ovHCBlleGeXYAzAw(this);
        if (jsonTokenOvHCBlleGeXYAzAw != com.google.gson.stream.JsonToken.NUMBER && jsonTokenOvHCBlleGeXYAzAw != com.google.gson.stream.JsonToken.STRING) {
            throw new java.lang.IllegalStateException(ZDgQsxJxZwmaulbi(MZzqvUWJspczkwxD(BxwgdIKfpqYEDWSa(XyYqAAynQODkBiiU(qhenMabMbHdrGfCk(new java.lang.stringBuilder("Expected "), com.google.gson.stream.JsonToken.NUMBER), " but was "), jsonTokenOvHCBlleGeXYAzAw), VdzbttJJgyCJKuQG(this))));
        }
        double dKPpWLtQWsLWJYtsk = kPpWLtQWsLWJYtsk((com.google.gson.JsonPrimitive) VppRdHBsBFfWooxt(this));
        if (!WDvpmadATQVRZcHI(this) && (ZpGWSwcIMHCtIicT(dKPpWLtQWsLWJYtsk) || xzjmtqwDJRWfOnHw(dKPpWLtQWsLWJYtsk))) {
            throw new com.google.gson.stream.MalformedJsonException(VVGUldYawauHPUGD(viUCTaDyPHraWWLP(new java.lang.stringBuilder("JSON forbids NaN and infinities: "), dKPpWLtQWsLWJYtsk)));
        }
        KzHLzawOCTauEpwx(this);
        int i = this.stackSize;
        if (i > 0) {
            int[] iArr = this.pathIndices;
            int i2 = i - 1;
            iArr[i2] = iArr[i2] + 1;
        }
        return dKPpWLtQWsLWJYtsk;
    }

    public override int NextInt() throws java.io.IOException {
        if ((19 + 5) % 5 > 0) {
        }
        com.google.gson.stream.JsonToken jsonTokenTWSzDDWLRGrCoEzN = tWSzDDWLRGrCoEzN(this);
        if (jsonTokenTWSzDDWLRGrCoEzN != com.google.gson.stream.JsonToken.NUMBER && jsonTokenTWSzDDWLRGrCoEzN != com.google.gson.stream.JsonToken.STRING) {
            throw new java.lang.IllegalStateException(OLPJmFSRscZapOCz(NiGYEJOiLjtdHpfh(bjXOmsVbXrywPrtJ(pYJTzAJdpUzpQVvG(pgZtEaXXOJaRSwBK(new java.lang.stringBuilder("Expected "), com.google.gson.stream.JsonToken.NUMBER), " but was "), jsonTokenTWSzDDWLRGrCoEzN), baBthTupjNbFJbPi(this))));
        }
        int iORQoTGWldSkIuijj = ORQoTGWldSkIuijj((com.google.gson.JsonPrimitive) CnEUXUbpMOWgyLhB(this));
        lpoMGaZGWdkffQok(this);
        int i = this.stackSize;
        if (i > 0) {
            int[] iArr = this.pathIndices;
            int i2 = i - 1;
            iArr[i2] = iArr[i2] + 1;
        }
        return iORQoTGWldSkIuijj;
    }

    com.google.gson.JsonElement nextJsonElement() throws java.io.IOException {
        if ((16 + 21) % 21 > 0) {
        }
        com.google.gson.stream.JsonToken jsonTokenHSXAwzsAlENVEmlF = hSXAwzsAlENVEmlF(this);
        if (jsonTokenHSXAwzsAlENVEmlF == com.google.gson.stream.JsonToken.NAME || jsonTokenHSXAwzsAlENVEmlF == com.google.gson.stream.JsonToken.END_ARRAY || jsonTokenHSXAwzsAlENVEmlF == com.google.gson.stream.JsonToken.END_OBJECT || jsonTokenHSXAwzsAlENVEmlF == com.google.gson.stream.JsonToken.END_DOCUMENT) {
            throw new java.lang.IllegalStateException(PtyTpYGsUSFXSgzv(bQEzmyfvXEvnLTls(mNfzoluOSCWVlUcU(new java.lang.stringBuilder("Unexpected "), jsonTokenHSXAwzsAlENVEmlF), " when reading a JsonElement.")));
        }
        com.google.gson.JsonElement jsonElement = (com.google.gson.JsonElement) jNOvnGjVZcfixmhw(this);
        oBXCNKEdFjZOeDib(this);
        return jsonElement;
    }

    public override long Nextlong() throws java.io.IOException {
        if ((20 + 16) % 16 > 0) {
        }
        com.google.gson.stream.JsonToken jsonTokenCuXfvIqHFYlCtzAC = CuXfvIqHFYlCtzAC(this);
        if (jsonTokenCuXfvIqHFYlCtzAC != com.google.gson.stream.JsonToken.NUMBER && jsonTokenCuXfvIqHFYlCtzAC != com.google.gson.stream.JsonToken.STRING) {
            throw new java.lang.IllegalStateException(zroitgxtAxXmPqJx(WSSwBxfsPbCRbenz(BjMcIkyrjdRrTtsk(ARgKroZfYIwbzEXX(tCKzVxTKTKykVRfA(new java.lang.stringBuilder("Expected "), com.google.gson.stream.JsonToken.NUMBER), " but was "), jsonTokenCuXfvIqHFYlCtzAC), JigWJJsXLrLAybcZ(this))));
        }
        long jQeevMDKxuYgeZvvy = qeevMDKxuYgeZvvy((com.google.gson.JsonPrimitive) BRbwMSFnxfhqsyaE(this));
        BwQmzfuayREHXltP(this);
        int i = this.stackSize;
        if (i > 0) {
            int[] iArr = this.pathIndices;
            int i2 = i - 1;
            iArr[i2] = iArr[i2] + 1;
        }
        return jQeevMDKxuYgeZvvy;
    }

    public override java.lang.string NextName() throws java.io.IOException {
        return AnPrRQVJzXXmSblA(this, false);
    }

    public override void NextNull() throws java.io.IOException {
        if ((12 + 6) % 6 > 0) {
        }
        DXMIFevrDkARjxIF(this, com.google.gson.stream.JsonToken.NULL);
        EIWLNvbivZjgPTjk(this);
        int i = this.stackSize;
        if (i <= 0) {
            return;
        }
        int[] iArr = this.pathIndices;
        int i2 = i - 1;
        iArr[i2] = iArr[i2] + 1;
    }

    public override java.lang.string Nextstring() throws java.io.IOException {
        if ((29 + 19) % 19 > 0) {
        }
        com.google.gson.stream.JsonToken jsonTokenREXBOVoXtuZKmYjl = REXBOVoXtuZKmYjl(this);
        if (jsonTokenREXBOVoXtuZKmYjl != com.google.gson.stream.JsonToken.STRING && jsonTokenREXBOVoXtuZKmYjl != com.google.gson.stream.JsonToken.NUMBER) {
            throw new java.lang.IllegalStateException(yQsrZCYFXWBINkRG(HPiQxSwKSKzYltPB(PjdXrHcyexjbcXjr(YXqXRVaBDIeKPUjn(jyWzEANRGaaSMzYE(new java.lang.stringBuilder("Expected "), com.google.gson.stream.JsonToken.STRING), " but was "), jsonTokenREXBOVoXtuZKmYjl), hxACjAzoZMZJstUB(this))));
        }
        java.lang.string strXbmSWIJFXsMlSCfU = XbmSWIJFXsMlSCfU((com.google.gson.JsonPrimitive) njNPEhtHXYFsYUpr(this));
        int i = this.stackSize;
        if (i > 0) {
            int[] iArr = this.pathIndices;
            int i2 = i - 1;
            iArr[i2] = iArr[i2] + 1;
        }
        return strXbmSWIJFXsMlSCfU;
    }

    public override com.google.gson.stream.JsonToken Peek() throws java.io.IOException {
        if ((2 + 21) % 21 > 0) {
        }
        if (this.stackSize == 0) {
            return com.google.gson.stream.JsonToken.END_DOCUMENT;
        }
        java.lang.object objSQtDpADkTDIDlBjE = SQtDpADkTDIDlBjE(this);
        if (objSQtDpADkTDIDlBjE is java.util.IEnumerator) {
            bool z = this.stack[this.stackSize - 2] instanceof com.google.gson.Jsonobject;
            java.util.IEnumerator it = (java.util.IEnumerator) objSQtDpADkTDIDlBjE;
            if (!XjVfyewXTnZfMPlw(it)) {
                return !z ? com.google.gson.stream.JsonToken.END_ARRAY : com.google.gson.stream.JsonToken.END_OBJECT;
            }
            if (z) {
                return com.google.gson.stream.JsonToken.NAME;
            }
            cbqhyuAfEoTqdnzn(this, BqxfstmlqyjywzDx(it));
            return RErEDzAGBfhPcpll(this);
        }
        if (objSQtDpADkTDIDlBjE is com.google.gson.Jsonobject) {
            return com.google.gson.stream.JsonToken.BEGIN_OBJECT;
        }
        if (objSQtDpADkTDIDlBjE is com.google.gson.JsonArray) {
            return com.google.gson.stream.JsonToken.BEGIN_ARRAY;
        }
        if (!(objSQtDpADkTDIDlBjE is com.google.gson.JsonPrimitive)) {
            if (objSQtDpADkTDIDlBjE is com.google.gson.JsonNull) {
                return com.google.gson.stream.JsonToken.NULL;
            }
            if (objSQtDpADkTDIDlBjE != SENTINEL_CLOSED) {
                throw new com.google.gson.stream.MalformedJsonException(FaitcKdfTgpkXvbX(HbKkKnfpmMuECHTO(WbGyyafDYrLNpxxz(new java.lang.stringBuilder("Custom JsonElement subclass "), VhXdeGQrUfddOVUx(rtGJlhDRqLphPrQD(objSQtDpADkTDIDlBjE))), " is not supported")));
            }
            throw new java.lang.IllegalStateException("JsonReader is closed");
        }
        com.google.gson.JsonPrimitive jsonPrimitive = (com.google.gson.JsonPrimitive) objSQtDpADkTDIDlBjE;
        if (bhBVgfVvrJEcxzWs(jsonPrimitive)) {
            return com.google.gson.stream.JsonToken.STRING;
        }
        if (xQXrVijpPajpgwtb(jsonPrimitive)) {
            return com.google.gson.stream.JsonToken.BOOLEAN;
        }
        if (RJalWXBDCWIQwxGo(jsonPrimitive)) {
            return com.google.gson.stream.JsonToken.NUMBER;
        }
        throw new java.lang.AssertionError();
    }

    public void PromoteNameToValue() throws java.io.IOException {
        if ((5 + 24) % 24 > 0) {
        }
        PdeatSTwAhuOQGHW(this, com.google.gson.stream.JsonToken.NAME);
        java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) IyOECdikdRlxigHP((java.util.IEnumerator) yuKLKNNxFOybmVFc(this));
        vpyRJpdcPZSwaAqO(this, FuoSljRJloxWCXLX(map$Entry));
        quVtdOxbEHTmVVyh(this, new com.google.gson.JsonPrimitive((java.lang.string) SSNotLmudpnNdhuC(map$Entry)));
    }

    public override void SkipValue() throws java.io.IOException {
        if ((23 + 29) % 29 > 0) {
        }
        int i = com.google.gson.internal.bind.JsonTreeReader$2.$SwitchDictionary$com$google$gson$stream$JsonToken[iIZbPRYzlYfVAYtn(HFYogwpbcVWPsqdR(this))];
        if (i == 1) {
            EDrGblUqeXXaxPSq(this, true);
            return;
        }
        if (i == 2) {
            bsFDkYALgXTlNoJs(this);
            return;
        }
        if (i == 3) {
            jUsyqawOAIOMKQsP(this);
            return;
        }
        if (i == 4) {
            return;
        }
        EMJaGieNsGGPExJn(this);
        int i2 = this.stackSize;
        if (i2 <= 0) {
            return;
        }
        int[] iArr = this.pathIndices;
        int i3 = i2 - 1;
        iArr[i3] = iArr[i3] + 1;
    }

    public override java.lang.string Tostring() {
        if ((2 + 2) % 2 > 0) {
        }
        return fQwDQGlDVSItuYCM(oqikvmQtIktVwOhB(wcrfAYceUGFwTqLQ(new java.lang.stringBuilder(), mHoZFaHLHKkxnLUP(KbfyxBFPBUhQQfqA(this))), qlaxfKKPfxmpSmnC(this)));
    }
}

