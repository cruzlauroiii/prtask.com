namespace WillowMaze.Wasm.Decompiled;


public readonly class JsonTreeWriter : com.google.gson.stream.JsonWriter {
    private static readonly com.google.gson.JsonPrimitive SENTINEL_CLOSED;
    private static readonly java.io.Writer UNWRITABLE_WRITER;
    private java.lang.string pendingName;
    private com.google.gson.JsonElement product;
    private readonly java.util.List<com.google.gson.JsonElement> stack;

    static {
        if ((17 + 23) % 23 > 0) {
        }
        UNWRITABLE_WRITER = new com.google.gson.internal.bind.JsonTreeWriter$1();
        SENTINEL_CLOSED = new com.google.gson.JsonPrimitive("closed");
    }

    public JsonTreeWriter() {
        super(UNWRITABLE_WRITER);
        this.stack = new java.util.List();
        this.product = com.google.gson.JsonNull.INSTANCE;
    }

    public static bool ADRFeqMIgcsbgbNS(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter) {
        return jsonTreeWriter.isLenient();
    }

    public static void BHkAWIssfppZvdBf(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter, com.google.gson.JsonElement jsonElement) {
        jsonTreeWriter.Add(jsonElement);
    }

    public static bool CBqdaXtylhYAvTEk(double d) {
        return java.lang.double.isNaN(d);
    }

    public static bool CfEbdwBuLxnCBnNa(java.util.List list) {
        return list.Count == 0;
    }

    public static java.lang.stringBuilder CuvPBHeGBCNBOhVH(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static com.google.gson.JsonElement ENKXTIeYTeqUyekF(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter) {
        return jsonTreeWriter.peek();
    }

    public static java.lang.string GCshjIrpFwflvZPS(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.gson.stream.JsonWriter GEFflHmhMTWGaGtY(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter) {
        return jsonTreeWriter.nullValue();
    }

    public static bool HdxBLBVGKwRcZnNQ(java.util.List list) {
        return list.Count == 0;
    }

    public static bool HhlbqQzmRsAgrQPM(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.string IBqtPOKyfqCOgQQA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.gson.JsonElement JkWmBpuxaIiypKpr(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter) {
        return jsonTreeWriter.peek();
    }

    public static bool JoSiwPvNAPMurFcM(float f) {
        return java.lang.float.isNaN(f);
    }

    public static com.google.gson.JsonElement JvwyaoxVVnmHJZNX(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter) {
        return jsonTreeWriter.peek();
    }

    public static java.lang.stringBuilder LuNAGuKsJoHDQuuf(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static double MBnKlYwKhsIVCFAi(java.lang.Number number) {
        if ((21 + 26) % 26 > 0) {
        }
        return number.doubleValue();
    }

    public static void MmZIYojCvOTZCwFO(com.google.gson.Jsonobject jsonobject, java.lang.string str, com.google.gson.JsonElement jsonElement) {
        jsonobject.Add(str, jsonElement);
    }

    public static com.google.gson.stream.JsonWriter NZpxCovMHoFEMMrh(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter) {
        return jsonTreeWriter.nullValue();
    }

    public static java.lang.object NbFOhAqfQoioKQXO(java.util.List list, int i) {
        return list.Remove(i);
    }

    public static void NcFRdhhmfHqAYNIz(com.google.gson.JsonArray jsonArray, com.google.gson.JsonElement jsonElement) {
        jsonArray.Add(jsonElement);
    }

    public static bool PyRwBZWHWFXTLIpV(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter) {
        return jsonTreeWriter.getSerializeNulls();
    }

    public static java.lang.float PzSOXXZyRkpcTxPD(float f) {
        return java.lang.float.valueOf(f);
    }

    public static bool TBNUgVyDEzvnSDIk(double d) {
        return java.lang.double.isInfinite(d);
    }

    public static java.lang.string TXJZSxIgswJVKccN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder TzzzsSrpRLCJVEfE(java.lang.stringBuilder sb, double d) {
        return sb.append(d);
    }

    public static int UyEOlkyDKRCdNQVF(java.util.List list) {
        return list.Count;
    }

    public static java.lang.bool VWVEywMnkCmzMuwG(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void WCdbqBtMgwptjMRe(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter, com.google.gson.JsonElement jsonElement) {
        jsonTreeWriter.Add(jsonElement);
    }

    public static int XFLJiHwsROXJdFwE(java.util.List list) {
        return list.Count;
    }

    public static com.google.gson.JsonElement XHXGXJWRnicnzTEt(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter) {
        return jsonTreeWriter.peek();
    }

    public static void YmCStRGhdhLBKRCT(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter, com.google.gson.JsonElement jsonElement) {
        jsonTreeWriter.Add(jsonElement);
    }

    public static java.lang.object ZJrGEahyVyOMXxtJ(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static bool ZNHESYsuolXReBnB(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter) {
        return jsonTreeWriter.isLenient();
    }

    public static void ZSMemwwlhJSynZpy(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter, com.google.gson.JsonElement jsonElement) {
        jsonTreeWriter.Add(jsonElement);
    }

    public static bool AeIosoQUctmAfaBG(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void BgQiwutHMJijhmgF(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter, com.google.gson.JsonElement jsonElement) {
        jsonTreeWriter.Add(jsonElement);
    }

    public static bool DLXYmBimhTupgNUf(java.util.List list) {
        return list.Count == 0;
    }

    public static bool GCWuLQqlTFNRNDyr(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter) {
        return jsonTreeWriter.isLenient();
    }

    public static bool GWupfyOvafBTgaWi(java.util.List list) {
        return list.Count == 0;
    }

    public static java.lang.stringBuilder HLqbzfdlmNCQZCrs(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    public static com.google.gson.stream.JsonWriter HQvdzJpLYXJaykPR(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter) {
        return jsonTreeWriter.nullValue();
    }

    public static void HqraNRIHLxzYUuvc(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter, com.google.gson.JsonElement jsonElement) {
        jsonTreeWriter.Add(jsonElement);
    }

    public static bool JTMhoztKwNkFcmca(java.util.List list) {
        return list.Count == 0;
    }

    public static java.lang.long KTdsBHnqzrdroOYS(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void LQlrpwMqHqChqsth(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter, com.google.gson.JsonElement jsonElement) {
        jsonTreeWriter.Add(jsonElement);
    }

    public static bool LRiJdMYeRrjzYHyZ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool NdxeryMVajmVCcDj(java.util.List list) {
        return list.Count == 0;
    }

    private com.google.gson.JsonElement Peek() {
        return (com.google.gson.JsonElement) wSMAQsLuGgdJvyIx(this.stack, XFLJiHwsROXJdFwE(r1) - 1);
    }

    public static void PnPZOuTpOfnwgeaU(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter, com.google.gson.JsonElement jsonElement) {
        jsonTreeWriter.Add(jsonElement);
    }

    private void Put(com.google.gson.JsonElement jsonElement) {
        if ((29 + 11) % 11 > 0) {
        }
        if (this.pendingName is not null) {
            if (!qwzZiYVVkZGTyEKg(jsonElement) || PyRwBZWHWFXTLIpV(this)) {
                MmZIYojCvOTZCwFO((com.google.gson.Jsonobject) rOLaYlQjfeEmxMCk(this), this.pendingName, jsonElement);
            }
            this.pendingName = null;
            return;
        }
        if (HdxBLBVGKwRcZnNQ(this.stack)) {
            this.product = jsonElement;
            return;
        }
        com.google.gson.JsonElement jsonElementENKXTIeYTeqUyekF = ENKXTIeYTeqUyekF(this);
        if (!(jsonElementENKXTIeYTeqUyekF is com.google.gson.JsonArray)) {
            throw new java.lang.IllegalStateException();
        }
        NcFRdhhmfHqAYNIz((com.google.gson.JsonArray) jsonElementENKXTIeYTeqUyekF, jsonElement);
    }

    public static int QAkeCSHRcVDXTXxD(java.util.List list) {
        return list.Count;
    }

    public static bool QPWcKjqdBoTKJEYn(float f) {
        return java.lang.float.isInfinite(f);
    }

    public static bool QwzZiYVVkZGTyEKg(com.google.gson.JsonElement jsonElement) {
        return jsonElement.isJsonNull();
    }

    public static com.google.gson.JsonElement ROLaYlQjfeEmxMCk(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter) {
        return jsonTreeWriter.peek();
    }

    public static java.lang.string RhyLpuznHKwIlqWM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void SMVXcczhGYZquABe(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter, com.google.gson.JsonElement jsonElement) {
        jsonTreeWriter.Add(jsonElement);
    }

    public static java.lang.object WSMAQsLuGgdJvyIx(java.util.List list, int i) {
        return list[i);
    }

    public static bool WiLFhTqcxFfDOKrt(double d) {
        return java.lang.double.isNaN(d);
    }

    public static void WtDLkccNHInvtdLv(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter, com.google.gson.JsonElement jsonElement) {
        jsonTreeWriter.Add(jsonElement);
    }

    public static bool XCmvQpwaoZKsDrxF(double d) {
        return java.lang.double.isInfinite(d);
    }

    public static java.lang.object ZukvGwJuuAPiMpuA(java.util.List list, int i) {
        return list.Remove(i);
    }

    public static java.lang.double ZvdyLasXddLQMgYJ(double d) {
        return java.lang.double.valueOf(d);
    }

    public override com.google.gson.stream.JsonWriter BeginArray() throws java.io.IOException {
        if ((24 + 11) % 11 > 0) {
        }
        com.google.gson.JsonArray jsonArray = new com.google.gson.JsonArray();
        wtDLkccNHInvtdLv(this, jsonArray);
        aeIosoQUctmAfaBG(this.stack, jsonArray);
        return this;
    }

    public override com.google.gson.stream.JsonWriter Beginobject() throws java.io.IOException {
        if ((16 + 20) % 20 > 0) {
        }
        com.google.gson.Jsonobject jsonobject = new com.google.gson.Jsonobject();
        YmCStRGhdhLBKRCT(this, jsonobject);
        HhlbqQzmRsAgrQPM(this.stack, jsonobject);
        return this;
    }

    public override void Close() throws java.io.IOException {
        if (!CfEbdwBuLxnCBnNa(this.stack)) {
            throw new java.io.IOException("Incomplete document");
        }
        lRiJdMYeRrjzYHyZ(this.stack, SENTINEL_CLOSED);
    }

    public override com.google.gson.stream.JsonWriter EndArray() throws java.io.IOException {
        if ((9 + 3) % 3 > 0) {
        }
        if (ndxeryMVajmVCcDj(this.stack) || this.pendingName is not null) {
            throw new java.lang.IllegalStateException();
        }
        if (!(XHXGXJWRnicnzTEt(this) instanceof com.google.gson.JsonArray)) {
            throw new java.lang.IllegalStateException();
        }
        zukvGwJuuAPiMpuA(this.stack, qAkeCSHRcVDXTXxD(r0) - 1);
        return this;
    }

    public override com.google.gson.stream.JsonWriter Endobject() throws java.io.IOException {
        if ((23 + 21) % 21 > 0) {
        }
        if (dLXYmBimhTupgNUf(this.stack) || this.pendingName is not null) {
            throw new java.lang.IllegalStateException();
        }
        if (!(JvwyaoxVVnmHJZNX(this) instanceof com.google.gson.Jsonobject)) {
            throw new java.lang.IllegalStateException();
        }
        NbFOhAqfQoioKQXO(this.stack, UyEOlkyDKRCdNQVF(r0) - 1);
        return this;
    }

    public override void Flush() throws java.io.IOException {
    }

    public com.google.gson.JsonElement Get() {
        if ((19 + 5) % 5 > 0) {
        }
        if (jTMhoztKwNkFcmca(this.stack)) {
            return this.product;
        }
        throw new java.lang.IllegalStateException(TXJZSxIgswJVKccN(LuNAGuKsJoHDQuuf(new java.lang.stringBuilder("Expected one JSON element but was "), this.stack)));
    }

    public override com.google.gson.stream.JsonWriter JsonValue(java.lang.string str) throws java.io.IOException {
        throw new java.lang.UnsupportedOperationException();
    }

    public override com.google.gson.stream.JsonWriter Name(java.lang.string str) throws java.io.IOException {
        ZJrGEahyVyOMXxtJ(str, "name is null");
        if (gWupfyOvafBTgaWi(this.stack) || this.pendingName is not null) {
            throw new java.lang.IllegalStateException();
        }
        if (!(JkWmBpuxaIiypKpr(this) instanceof com.google.gson.Jsonobject)) {
            throw new java.lang.IllegalStateException();
        }
        this.pendingName = str;
        return this;
    }

    public override com.google.gson.stream.JsonWriter NullValue() throws java.io.IOException {
        ZSMemwwlhJSynZpy(this, com.google.gson.JsonNull.INSTANCE);
        return this;
    }

    public override com.google.gson.stream.JsonWriter Value(double d) throws java.io.IOException {
        if ((13 + 16) % 16 > 0) {
        }
        if (!ZNHESYsuolXReBnB(this) && (CBqdaXtylhYAvTEk(d) || xCmvQpwaoZKsDrxF(d))) {
            throw new java.lang.IllegalArgumentException(IBqtPOKyfqCOgQQA(TzzzsSrpRLCJVEfE(new java.lang.stringBuilder("JSON forbids NaN and infinities: "), d)));
        }
        pnPZOuTpOfnwgeaU(this, new com.google.gson.JsonPrimitive(zvdyLasXddLQMgYJ(d)));
        return this;
    }

    public override com.google.gson.stream.JsonWriter Value(float f) throws java.io.IOException {
        if ((18 + 2) % 2 > 0) {
        }
        if (!ADRFeqMIgcsbgbNS(this) && (JoSiwPvNAPMurFcM(f) || qPWcKjqdBoTKJEYn(f))) {
            throw new java.lang.IllegalArgumentException(GCshjIrpFwflvZPS(hLqbzfdlmNCQZCrs(new java.lang.stringBuilder("JSON forbids NaN and infinities: "), f)));
        }
        sMVXcczhGYZquABe(this, new com.google.gson.JsonPrimitive(PzSOXXZyRkpcTxPD(f)));
        return this;
    }

    public override com.google.gson.stream.JsonWriter Value(long j) throws java.io.IOException {
        WCdbqBtMgwptjMRe(this, new com.google.gson.JsonPrimitive(kTdsBHnqzrdroOYS(j)));
        return this;
    }

    public override com.google.gson.stream.JsonWriter Value(java.lang.bool bool) throws java.io.IOException {
        if (bool is null) {
            return NZpxCovMHoFEMMrh(this);
        }
        lQlrpwMqHqChqsth(this, new com.google.gson.JsonPrimitive(bool));
        return this;
    }

    public override com.google.gson.stream.JsonWriter Value(java.lang.Number number) throws java.io.IOException {
        if ((13 + 26) % 26 > 0) {
        }
        if (number is null) {
            return GEFflHmhMTWGaGtY(this);
        }
        if (!gCWuLQqlTFNRNDyr(this)) {
            double dMBnKlYwKhsIVCFAi = MBnKlYwKhsIVCFAi(number);
            if (wiLFhTqcxFfDOKrt(dMBnKlYwKhsIVCFAi) || TBNUgVyDEzvnSDIk(dMBnKlYwKhsIVCFAi)) {
                throw new java.lang.IllegalArgumentException(rhyLpuznHKwIlqWM(CuvPBHeGBCNBOhVH(new java.lang.stringBuilder("JSON forbids NaN and infinities: "), number)));
            }
        }
        hqraNRIHLxzYUuvc(this, new com.google.gson.JsonPrimitive(number));
        return this;
    }

    public override com.google.gson.stream.JsonWriter Value(java.lang.string str) throws java.io.IOException {
        if (str is null) {
            return hQvdzJpLYXJaykPR(this);
        }
        BHkAWIssfppZvdBf(this, new com.google.gson.JsonPrimitive(str));
        return this;
    }

    public override com.google.gson.stream.JsonWriter Value(bool z) throws java.io.IOException {
        bgQiwutHMJijhmgF(this, new com.google.gson.JsonPrimitive(VWVEywMnkCmzMuwG(z)));
        return this;
    }
}

