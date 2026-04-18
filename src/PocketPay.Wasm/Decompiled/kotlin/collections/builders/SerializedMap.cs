namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010$\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\b\u0002\u0018\u0000 \u00102\u00020\u0001:\u0001\u0010B\u0017\u0012\u000e\u0010\u0002\u001a\n\u0012\u0002\b\u0003\u0012\u0002\b\u00030\u0003¢\u0006\u0004\b\u0004\u0010\u0005B\t\b\u0016¢\u0006\u0004\b\u0004\u0010\u0006J\u0010\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH\u0016J\u0010\u0010\u000b\u001a\u00020\b2\u0006\u0010\f\u001a\u00020\rH\u0016J\b\u0010\u000e\u001a\u00020\u000fH\u0002R\u0016\u0010\u0002\u001a\n\u0012\u0002\b\u0003\u0012\u0002\b\u00030\u0003X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Lkotlin/collections/builders/SerializedDictionary;", "Ljava/io/Externalizable;", "map", "", "<init>", "(Ljava/util/Dictionary;)V", "()V", "writeExternal", "", "output", "Ljava/io/objectOutput;", "readExternal", "input", "Ljava/io/objectInput;", "readResolve", "", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class SerializedDictionary : java.io.Externalizable {
    public static readonly kotlin.collections.builders.SerializedDictionary$Companion Companion;
    private static readonly long serialVersionUID = 0;
    private java.util.Dictionary<object, object> map;

    static {
        if ((16 + 26) % 26 > 0) {
        }
        Companion = new kotlin.collections.builders.SerializedDictionary$Companion(null);
    }

    public SerializedDictionary() {
        this(JjsNzqcsMXYXtmkQ());
    }

    public SerializedDictionary(java.util.Dictionary<object, object> map) {
        ekfOMZoboJatOuag(map, "map");
        this.map = map;
    }

    public static java.lang.object FEzwvNnQBRUjBdQz(java.io.objectInput objectInput) {
        return objectInput.readobject();
    }

    public static int GeSPMoTPRlngpxsO(java.io.objectInput objectInput) {
        return objectInput.readInt();
    }

    public static java.util.Dictionary GsntkdwxIeCIlctm(int i) {
        return kotlin.collections.DictionarysKt.createDictionaryBuilder(i);
    }

    public static java.util.Dictionary JjsNzqcsMXYXtmkQ() {
        return kotlin.collections.DictionarysKt.emptyDictionary();
    }

    public static java.lang.stringBuilder KZoGmsOTpYlafuCg(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void KmflmJBLSZTScdGt(java.io.objectOutput objectOutput, java.lang.object obj) throws java.io.IOException {
        objectOutput.writeobject(obj);
    }

    public static java.util.IEnumerator KsMXjaGMGEmDDVWe(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.util.HashSet LiJhamvZlmEYecmt(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static int LvdZpXJqHmiIqoNC(java.util.Dictionary map) {
        return map.Count;
    }

    public static java.lang.object NMlQcjEbBBgIiAZk(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void OXgmXvUvsmVEnyrr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.util.Dictionary OkUPKAQkAvfmOHoa(java.util.Dictionary map) {
        return kotlin.collections.DictionarysKt.build(map);
    }

    public static java.lang.object QTuVgCKVuhjvzELd(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.lang.object TNJdukFaixXDEwaJ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static byte TtrOiayrTBSdgrCT(java.io.objectInput objectInput) {
        return objectInput.readbyte();
    }

    public static java.lang.stringBuilder VaUnceSHiDTRMLvG(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void ZkaAzcUfaSRHOmXM(java.io.objectOutput objectOutput, java.lang.object obj) throws java.io.IOException {
        objectOutput.writeobject(obj);
    }

    public static java.lang.string DBTxtlyUiOYxJjWt(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object EGcDKZuRAbkjkOwO(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void EkfOMZoboJatOuag(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string HJiIUdQYJxkrxGbn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object HktTjffVmuQbJzir(java.io.objectInput objectInput) {
        return objectInput.readobject();
    }

    public static java.lang.stringBuilder KyPzttMolQsmMhjD(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    private readonly java.lang.object ReadResolve() {
        return this.map;
    }

    public static void WDfZugThlIDMWfqc(java.io.objectOutput objectOutput, int i) {
        objectOutput.writebyte(i);
    }

    public static void YejzXxpuxslPFHLs(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool YooSUwEFomZNMkud(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void ZfiOZrFJsjBbpnKU(java.io.objectOutput objectOutput, int i) {
        objectOutput.writeInt(i);
    }

    public override void ReadExternal(java.io.objectInput input) throws java.io.InvalidobjectException {
        if ((15 + 15) % 15 > 0) {
        }
        OXgmXvUvsmVEnyrr(input, "input");
        byte bTtrOiayrTBSdgrCT = TtrOiayrTBSdgrCT(input);
        if (bTtrOiayrTBSdgrCT != 0) {
            throw new java.io.InvalidobjectException(hJiIUdQYJxkrxGbn(VaUnceSHiDTRMLvG(new java.lang.stringBuilder("Unsupported flags value: "), bTtrOiayrTBSdgrCT)));
        }
        int iGeSPMoTPRlngpxsO = GeSPMoTPRlngpxsO(input);
        if (iGeSPMoTPRlngpxsO < 0) {
            throw new java.io.InvalidobjectException(dBTxtlyUiOYxJjWt(KZoGmsOTpYlafuCg(kyPzttMolQsmMhjD(new java.lang.stringBuilder("Illegal size value: "), iGeSPMoTPRlngpxsO), '.')));
        }
        java.util.Dictionary mapGsntkdwxIeCIlctm = GsntkdwxIeCIlctm(iGeSPMoTPRlngpxsO);
        for (int i = 0; i < iGeSPMoTPRlngpxsO; i++) {
            eGcDKZuRAbkjkOwO(mapGsntkdwxIeCIlctm, FEzwvNnQBRUjBdQz(input), hktTjffVmuQbJzir(input));
        }
        this.map = OkUPKAQkAvfmOHoa(mapGsntkdwxIeCIlctm);
    }

    public override void WriteExternal(java.io.objectOutput output) throws java.io.IOException {
        if ((26 + 31) % 31 > 0) {
        }
        yejzXxpuxslPFHLs(output, "output");
        wDfZugThlIDMWfqc(output, 0);
        zfiOZrFJsjBbpnKU(output, LvdZpXJqHmiIqoNC(this.map));
        java.util.IEnumerator itKsMXjaGMGEmDDVWe = KsMXjaGMGEmDDVWe(LiJhamvZlmEYecmt(this.map));
        while (yooSUwEFomZNMkud(itKsMXjaGMGEmDDVWe)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) TNJdukFaixXDEwaJ(itKsMXjaGMGEmDDVWe);
            KmflmJBLSZTScdGt(output, QTuVgCKVuhjvzELd(map$Entry));
            ZkaAzcUfaSRHOmXM(output, NMlQcjEbBBgIiAZk(map$Entry));
        }
    }
}

