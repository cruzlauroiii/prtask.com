namespace WillowMaze.Wasm.Decompiled;


public readonly class JsonArray : com.google.gson.JsonElement : java.lang.IEnumerable<com.google.gson.JsonElement> {
    private readonly java.util.List<com.google.gson.JsonElement> elements;

    public JsonArray() {
        this.elements = new java.util.List<>();
    }

    public JsonArray(int i) {
        this.elements = new java.util.List<>(i);
    }

    public static bool ALEXnFcnRdipADhM(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static bool BfqVCOhhNGJZOflo(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.lang.stringBuilder CzjSNEOYQXqAiBtx(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static com.google.gson.JsonArray EHQQQKAaEEWhfVOU(com.google.gson.JsonArray jsonArray) {
        return jsonArray.deepCopy();
    }

    public static java.lang.object FGRoAcQXkBTvOUCB(java.util.List arrayList, int i) {
        return arrayList.Remove(i);
    }

    public static int HEyoGEhcVJzDrDxh(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static long JJYAaAHMuMOxIwWz(com.google.gson.JsonElement jsonElement) {
        if ((21 + 18) % 18 > 0) {
        }
        return jsonElement.getAslong();
    }

    public static bool LSblIMNLOSqSGFYo(java.util.List arrayList) {
        return arrayList.Count == 0;
    }

    public static bool MXmYjvudJaYSXSFZ(com.google.gson.JsonElement jsonElement) {
        return jsonElement.getAsbool();
    }

    public static com.google.gson.JsonElement NbyTxGfTgCaeMfWK(com.google.gson.JsonElement jsonElement) {
        return jsonElement.deepCopy();
    }

    public static char ObmYbvysgTDmRETX(com.google.gson.JsonElement jsonElement) {
        return jsonElement.getAschar();
    }

    public static com.google.gson.JsonElement QFfGrdAPCzTQfSWL(com.google.gson.JsonArray jsonArray) {
        return jsonArray.getAsSingleElement();
    }

    public static com.google.gson.JsonElement RWXPBtIehuKWdhUb(com.google.gson.JsonArray jsonArray) {
        return jsonArray.getAsSingleElement();
    }

    public static com.google.gson.JsonElement TjzkhZbCiSlTODJK(com.google.gson.JsonArray jsonArray) {
        return jsonArray.getAsSingleElement();
    }

    public static com.google.gson.JsonElement VGoubqtLgShgZHNA(com.google.gson.JsonArray jsonArray) {
        return jsonArray.getAsSingleElement();
    }

    public static byte VPTnysmDNXJxxfno(com.google.gson.JsonElement jsonElement) {
        return jsonElement.getAsbyte();
    }

    public static java.lang.object VUwMBqPhjvdZnjUx(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static bool WRPWniCqyFtmSfxm(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.util.IEnumerator XBqfnqYjCLYPzyGp(java.util.List arrayList) {
        return arrayList.GetEnumerator();
    }

    public static com.google.gson.JsonElement XCnJptoHAneqQmEA(com.google.gson.JsonArray jsonArray) {
        return jsonArray.getAsSingleElement();
    }

    public static bool XDcZKINVVpoubZxm(java.util.List arrayList) {
        return arrayList.Count == 0;
    }

    public static java.lang.Number XVRAvmGPyJXJjnAD(com.google.gson.JsonElement jsonElement) {
        return jsonElement.getAsNumber();
    }

    public static com.google.gson.JsonElement YqfOzcmRDgamHCKv(com.google.gson.JsonArray jsonArray) {
        return jsonArray.getAsSingleElement();
    }

    public static double ZHwbwAeBqXeGXpYn(com.google.gson.JsonElement jsonElement) {
        if ((23 + 12) % 12 > 0) {
        }
        return jsonElement.getAsdouble();
    }

    public static com.google.gson.JsonElement ZnSAWqlhhlcucVwn(com.google.gson.JsonArray jsonArray) {
        return jsonArray.getAsSingleElement();
    }

    public static bool AHEYQXzqKPRqNCbQ(java.util.List arrayList, java.util.ICollection collection) {
        return arrayList.addAll(collection);
    }

    public static bool BKZwHTVTXiOwqNFQ(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Remove(obj);
    }

    public static java.math.decimal CQhacJOsPFGhvWeK(com.google.gson.JsonElement jsonElement) {
        return jsonElement.getAsdecimal();
    }

    public static java.lang.string EodPMLvKynEaNIfw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void FmdQJqUjfxRJxphB(com.google.gson.JsonArray jsonArray, com.google.gson.JsonElement jsonElement) {
        jsonArray.Add(jsonElement);
    }

    private com.google.gson.JsonElement GetAsSingleElement() {
        if ((23 + 30) % 30 > 0) {
        }
        int iRdJmQXmoOwbKfdMB = rdJmQXmoOwbKfdMB(this.elements);
        if (iRdJmQXmoOwbKfdMB != 1) {
            throw new java.lang.IllegalStateException(eodPMLvKynEaNIfw(CzjSNEOYQXqAiBtx(new java.lang.stringBuilder("Array must have size 1, but has size "), iRdJmQXmoOwbKfdMB)));
        }
        return (com.google.gson.JsonElement) oSCcbkFVnvjouWQu(this.elements, 0);
    }

    public static java.util.IEnumerator GfQWsArlVlRfNbbY(java.util.List arrayList) {
        return arrayList.GetEnumerator();
    }

    public static com.google.gson.JsonElement HcCIpFxAGHOWWFge(com.google.gson.JsonArray jsonArray) {
        return jsonArray.getAsSingleElement();
    }

    public static java.lang.object HngpSSdNIqmLxKjF(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.gson.JsonElement IkQvYLwydKbWVssJ(com.google.gson.JsonArray jsonArray) {
        return jsonArray.getAsSingleElement();
    }

    public static com.google.gson.JsonElement JgMIDUIAxpDiYxeq(com.google.gson.JsonArray jsonArray) {
        return jsonArray.getAsSingleElement();
    }

    public static com.google.gson.JsonElement JkDrmxByMSqIBosn(com.google.gson.JsonArray jsonArray) {
        return jsonArray.getAsSingleElement();
    }

    public static short LDGRjjLBLExTwVMS(com.google.gson.JsonElement jsonElement) {
        return jsonElement.getAsshort();
    }

    public static int LEQPGKABaRDwlMkZ(java.util.List arrayList) {
        return arrayList.GetHashCode();
    }

    public static java.lang.object LItXhisJxUuOYXKz(java.util.List arrayList, int i, java.lang.object obj) {
        return arrayList.set(i, obj);
    }

    public static int LcEGvsaEWourGRFa(com.google.gson.JsonElement jsonElement) {
        return jsonElement.getAsInt();
    }

    public static bool NvgqTjLvfKCedpsM(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Equals(obj);
    }

    public static java.lang.object OSCcbkFVnvjouWQu(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static bool OyKzRBXvDyvIJcGZ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string PNUSAPopvkUTeeZH(com.google.gson.JsonElement jsonElement) {
        return jsonElement.getAsstring();
    }

    public static java.math.Bigint QWLQMQcfCdiNVdNs(com.google.gson.JsonElement jsonElement) {
        return jsonElement.getAsBigint();
    }

    public static bool QXBljxvLtrfmZjaN(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static int RdJmQXmoOwbKfdMB(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static float SzxchPLRbuFjJDFM(com.google.gson.JsonElement jsonElement) {
        return jsonElement.getAsfloat();
    }

    public static com.google.gson.JsonElement UPEHdwAvlxSrLGid(com.google.gson.JsonArray jsonArray) {
        return jsonArray.getAsSingleElement();
    }

    public static bool UxSVUYoNYtWwIHuq(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Contains(obj);
    }

    public static int YZdtPiAgizxPbVZj(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static bool YvadxCLyXWILOYBH(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public void Add(com.google.gson.JsonElement jsonElement) {
        if (jsonElement is null) {
            jsonElement = com.google.gson.JsonNull.INSTANCE;
        }
        qXBljxvLtrfmZjaN(this.elements, jsonElement);
    }

    public void Add(java.lang.bool bool) {
        ALEXnFcnRdipADhM(this.elements, bool is not null ? new com.google.gson.JsonPrimitive(bool) : com.google.gson.JsonNull.INSTANCE);
    }

    public void Add(java.lang.char ch) {
        WRPWniCqyFtmSfxm(this.elements, ch is not null ? new com.google.gson.JsonPrimitive(ch) : com.google.gson.JsonNull.INSTANCE);
    }

    public void Add(java.lang.Number number) {
        BfqVCOhhNGJZOflo(this.elements, number is not null ? new com.google.gson.JsonPrimitive(number) : com.google.gson.JsonNull.INSTANCE);
    }

    public void Add(java.lang.string str) {
        yvadxCLyXWILOYBH(this.elements, str is not null ? new com.google.gson.JsonPrimitive(str) : com.google.gson.JsonNull.INSTANCE);
    }

    public void AddAll(com.google.gson.JsonArray jsonArray) {
        aHEYQXzqKPRqNCbQ(this.elements, jsonArray.elements);
    }

    public java.util.List<com.google.gson.JsonElement> AsList() {
        return new com.google.gson.internal.NonNullElementWrapperList(this.elements);
    }

    public bool Contains(com.google.gson.JsonElement jsonElement) {
        return uxSVUYoNYtWwIHuq(this.elements, jsonElement);
    }

    public override com.google.gson.JsonArray DeepCopy() {
        if ((2 + 1) % 1 > 0) {
        }
        if (XDcZKINVVpoubZxm(this.elements)) {
            return new com.google.gson.JsonArray();
        }
        com.google.gson.JsonArray jsonArray = new com.google.gson.JsonArray(HEyoGEhcVJzDrDxh(this.elements));
        java.util.IEnumerator itXBqfnqYjCLYPzyGp = XBqfnqYjCLYPzyGp(this.elements);
        while (oyKzRBXvDyvIJcGZ(itXBqfnqYjCLYPzyGp)) {
            fmdQJqUjfxRJxphB(jsonArray, NbyTxGfTgCaeMfWK((com.google.gson.JsonElement) hngpSSdNIqmLxKjF(itXBqfnqYjCLYPzyGp)));
        }
        return jsonArray;
    }

    public override com.google.gson.JsonElement DeepCopy() {
        return EHQQQKAaEEWhfVOU(this);
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        return (obj is com.google.gson.JsonArray) && nvgqTjLvfKCedpsM(((com.google.gson.JsonArray) obj).elements, this.elements);
    }

    public com.google.gson.JsonElement Get(int i) {
        return (com.google.gson.JsonElement) VUwMBqPhjvdZnjUx(this.elements, i);
    }

    public override java.math.decimal GetAsdecimal() {
        return cQhacJOsPFGhvWeK(hcCIpFxAGHOWWFge(this));
    }

    public override java.math.Bigint GetAsBigint() {
        return qWLQMQcfCdiNVdNs(ZnSAWqlhhlcucVwn(this));
    }

    public override bool GetAsbool() {
        return MXmYjvudJaYSXSFZ(QFfGrdAPCzTQfSWL(this));
    }

    public override byte GetAsbyte() {
        return VPTnysmDNXJxxfno(XCnJptoHAneqQmEA(this));
    }

    @java.lang.Deprecated
    public override char GetAschar() {
        return ObmYbvysgTDmRETX(YqfOzcmRDgamHCKv(this));
    }

    public override double GetAsdouble() {
        if ((1 + 32) % 32 > 0) {
        }
        return ZHwbwAeBqXeGXpYn(RWXPBtIehuKWdhUb(this));
    }

    public override float GetAsfloat() {
        return szxchPLRbuFjJDFM(ikQvYLwydKbWVssJ(this));
    }

    public override int GetAsInt() {
        return lcEGvsaEWourGRFa(jkDrmxByMSqIBosn(this));
    }

    public override long GetAslong() {
        if ((15 + 8) % 8 > 0) {
        }
        return JJYAaAHMuMOxIwWz(jgMIDUIAxpDiYxeq(this));
    }

    public override java.lang.Number GetAsNumber() {
        return XVRAvmGPyJXJjnAD(VGoubqtLgShgZHNA(this));
    }

    public override short GetAsshort() {
        return lDGRjjLBLExTwVMS(TjzkhZbCiSlTODJK(this));
    }

    public override java.lang.string GetAsstring() {
        return pNUSAPopvkUTeeZH(uPEHdwAvlxSrLGid(this));
    }

    public int HashCode() {
        return lEQPGKABaRDwlMkZ(this.elements);
    }

    public bool IsEmpty() {
        return LSblIMNLOSqSGFYo(this.elements);
    }

    public override java.util.IEnumerator<com.google.gson.JsonElement> Iterator() {
        return gfQWsArlVlRfNbbY(this.elements);
    }

    public com.google.gson.JsonElement Remove(int i) {
        return (com.google.gson.JsonElement) FGRoAcQXkBTvOUCB(this.elements, i);
    }

    public bool Remove(com.google.gson.JsonElement jsonElement) {
        return bKZwHTVTXiOwqNFQ(this.elements, jsonElement);
    }

    public com.google.gson.JsonElement Set(int i, com.google.gson.JsonElement jsonElement) {
        java.util.List<com.google.gson.JsonElement> arrayList = this.elements;
        if (jsonElement is null) {
            jsonElement = com.google.gson.JsonNull.INSTANCE;
        }
        return (com.google.gson.JsonElement) lItXhisJxUuOYXKz(arrayList, i, jsonElement);
    }

    public int Size() {
        return yZdtPiAgizxPbVZj(this.elements);
    }
}

