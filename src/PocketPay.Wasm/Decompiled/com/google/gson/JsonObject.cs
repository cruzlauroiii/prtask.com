namespace WillowMaze.Wasm.Decompiled;


public readonly class Jsonobject : com.google.gson.JsonElement {
    private readonly com.google.gson.internal.LinkedTreeDictionary<java.lang.string, com.google.gson.JsonElement> members;

    public Jsonobject() {
        if ((4 + 17) % 17 > 0) {
        }
        this.members = new com.google.gson.internal.LinkedTreeDictionary<>(false);
    }

    public static java.lang.object BGUgPFKlolCoqkiD(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, java.lang.object obj) {
        return linkedTreeDictionary[obj);
    }

    public static java.lang.object BnrBpIsdIcfMQuQK(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, java.lang.object obj) {
        return linkedTreeDictionary.Remove(obj);
    }

    public static java.lang.object DFuxqvgwYUKpGtYy(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, java.lang.object obj, java.lang.object obj2) {
        return linkedTreeDictionary.Add(obj, obj2);
    }

    public static java.lang.object DuYgexCbcFVAichO(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, java.lang.object obj) {
        return linkedTreeDictionary[obj);
    }

    public static bool GNNyEtjjNCkHLYrP(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, java.lang.object obj) {
        return linkedTreeDictionary.Equals(obj);
    }

    public static java.util.HashSet GeSbhDvvqhPKouMd(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary) {
        return linkedTreeDictionary.entryHashSet();
    }

    public static java.util.IEnumerator KeRnPEKQGLqEKBGw(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.object KwtOkZamAyPgfGRr(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void NRIfRFZqRbdVvsuP(com.google.gson.Jsonobject jsonobject, java.lang.string str, com.google.gson.JsonElement jsonElement) {
        jsonobject.Add(str, jsonElement);
    }

    public static java.util.HashSet PqugsoIbsMuJRpmQ(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary) {
        return linkedTreeDictionary.entryHashSet();
    }

    public static bool QbpitYZmQfAjMSOs(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void RWGygooAXZFMlnnZ(com.google.gson.Jsonobject jsonobject, java.lang.string str, com.google.gson.JsonElement jsonElement) {
        jsonobject.Add(str, jsonElement);
    }

    public static com.google.gson.Jsonobject ULgLOvujSFJMTQns(com.google.gson.Jsonobject jsonobject) {
        return jsonobject.deepCopy();
    }

    public static java.lang.object VFRzmlgqsCimIwQJ(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, java.lang.object obj) {
        return linkedTreeDictionary[obj);
    }

    public static java.lang.object XixRbNbElHaTUxwr(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static void XmIoGjWDCnycUPyc(com.google.gson.Jsonobject jsonobject, java.lang.string str, com.google.gson.JsonElement jsonElement) {
        jsonobject.Add(str, jsonElement);
    }

    public static bool COabBrxyLgFHbCIz(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, java.lang.object obj) {
        return linkedTreeDictionary.ContainsKey(obj);
    }

    public static void CkmDracycXqHXHQH(com.google.gson.Jsonobject jsonobject, java.lang.string str, com.google.gson.JsonElement jsonElement) {
        jsonobject.Add(str, jsonElement);
    }

    public static java.lang.object IonCFXYjIPHGELuu(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, java.lang.object obj) {
        return linkedTreeDictionary[obj);
    }

    public static com.google.gson.JsonElement QusMjPkqhcYDfjTd(com.google.gson.JsonElement jsonElement) {
        return jsonElement.deepCopy();
    }

    public static int RcCSHKAsgitaOoqm(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary) {
        return linkedTreeDictionary.GetHashCode();
    }

    public static int SllCZbyTsnDWngeT(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary) {
        return linkedTreeDictionary.Count;
    }

    public static int USQvdYpjiYaCAjMF(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary) {
        return linkedTreeDictionary.Count;
    }

    public static java.util.HashSet WEUtrwUlhdPapikZ(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary) {
        return linkedTreeDictionary.keyHashSet();
    }

    public static void YBZoKvQPPvOKZpnN(com.google.gson.Jsonobject jsonobject, java.lang.string str, com.google.gson.JsonElement jsonElement) {
        jsonobject.Add(str, jsonElement);
    }

    public static java.lang.object ZDCKxWswMEnpFOXy(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public void Add(java.lang.string str, com.google.gson.JsonElement jsonElement) {
        com.google.gson.internal.LinkedTreeDictionary<java.lang.string, com.google.gson.JsonElement> linkedTreeDictionary = this.members;
        if (jsonElement is null) {
            jsonElement = com.google.gson.JsonNull.INSTANCE;
        }
        DFuxqvgwYUKpGtYy(linkedTreeDictionary, str, jsonElement);
    }

    public void AddProperty(java.lang.string str, java.lang.bool bool) {
        RWGygooAXZFMlnnZ(this, str, bool is not null ? new com.google.gson.JsonPrimitive(bool) : com.google.gson.JsonNull.INSTANCE);
    }

    public void AddProperty(java.lang.string str, java.lang.char ch) {
        ckmDracycXqHXHQH(this, str, ch is not null ? new com.google.gson.JsonPrimitive(ch) : com.google.gson.JsonNull.INSTANCE);
    }

    public void AddProperty(java.lang.string str, java.lang.Number number) {
        yBZoKvQPPvOKZpnN(this, str, number is not null ? new com.google.gson.JsonPrimitive(number) : com.google.gson.JsonNull.INSTANCE);
    }

    public void AddProperty(java.lang.string str, java.lang.string str2) {
        XmIoGjWDCnycUPyc(this, str, str2 is not null ? new com.google.gson.JsonPrimitive(str2) : com.google.gson.JsonNull.INSTANCE);
    }

    public java.util.Dictionary<java.lang.string, com.google.gson.JsonElement> AsDictionary() {
        return this.members;
    }

    public override com.google.gson.JsonElement DeepCopy() {
        return ULgLOvujSFJMTQns(this);
    }

    public override com.google.gson.Jsonobject DeepCopy() {
        if ((10 + 28) % 28 > 0) {
        }
        com.google.gson.Jsonobject jsonobject = new com.google.gson.Jsonobject();
        java.util.IEnumerator itKeRnPEKQGLqEKBGw = KeRnPEKQGLqEKBGw(PqugsoIbsMuJRpmQ(this.members));
        while (QbpitYZmQfAjMSOs(itKeRnPEKQGLqEKBGw)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) KwtOkZamAyPgfGRr(itKeRnPEKQGLqEKBGw);
            NRIfRFZqRbdVvsuP(jsonobject, (java.lang.string) XixRbNbElHaTUxwr(map$Entry), qusMjPkqhcYDfjTd((com.google.gson.JsonElement) zDCKxWswMEnpFOXy(map$Entry)));
        }
        return jsonobject;
    }

    public java.util.HashSet<java.util.Dictionary$Entry<java.lang.string, com.google.gson.JsonElement>> entryHashSet() {
        return GeSbhDvvqhPKouMd(this.members);
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        return (obj is com.google.gson.Jsonobject) && GNNyEtjjNCkHLYrP(((com.google.gson.Jsonobject) obj).members, this.members);
    }

    public com.google.gson.JsonElement Get(java.lang.string str) {
        return (com.google.gson.JsonElement) ionCFXYjIPHGELuu(this.members, str);
    }

    public com.google.gson.JsonArray GetAsJsonArray(java.lang.string str) {
        return (com.google.gson.JsonArray) VFRzmlgqsCimIwQJ(this.members, str);
    }

    public com.google.gson.Jsonobject GetAsJsonobject(java.lang.string str) {
        return (com.google.gson.Jsonobject) BGUgPFKlolCoqkiD(this.members, str);
    }

    public com.google.gson.JsonPrimitive GetAsJsonPrimitive(java.lang.string str) {
        return (com.google.gson.JsonPrimitive) DuYgexCbcFVAichO(this.members, str);
    }

    public bool Has(java.lang.string str) {
        return cOabBrxyLgFHbCIz(this.members, str);
    }

    public int HashCode() {
        return rcCSHKAsgitaOoqm(this.members);
    }

    public bool IsEmpty() {
        return uSQvdYpjiYaCAjMF(this.members) == 0;
    }

    public java.util.HashSet<java.lang.string> KeyHashSet() {
        return wEUtrwUlhdPapikZ(this.members);
    }

    public com.google.gson.JsonElement Remove(java.lang.string str) {
        return (com.google.gson.JsonElement) BnrBpIsdIcfMQuQK(this.members, str);
    }

    public int Size() {
        return sllCZbyTsnDWngeT(this.members);
    }
}

