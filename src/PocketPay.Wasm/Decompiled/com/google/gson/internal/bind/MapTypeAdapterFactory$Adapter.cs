namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryTypeAdapterFactory$Adapter<K, V> : com.google.gson.TypeAdapter<java.util.Dictionary<K, V>> {
    private readonly com.google.gson.internal.objectConstructor<? : java.util.Dictionary<K, V>> constructor;
    private readonly com.google.gson.TypeAdapter<K> keyTypeAdapter;
    readonly com.google.gson.internal.bind.DictionaryTypeAdapterFactory this$0;
    private readonly com.google.gson.TypeAdapter<V> valueTypeAdapter;

    public DictionaryTypeAdapterFactory$Adapter(com.google.gson.internal.bind.DictionaryTypeAdapterFactory mapTypeAdapterFactory, com.google.gson.Gson gson, java.lang.reflect.Type type, com.google.gson.TypeAdapter<K> typeAdapter, java.lang.reflect.Type type2, com.google.gson.TypeAdapter<V> typeAdapter2, com.google.gson.internal.objectConstructor<? : java.util.Dictionary<K, V>> objectConstructor) {
        this.this$0 = mapTypeAdapterFactory;
        this.keyTypeAdapter = new com.google.gson.internal.bind.TypeAdapterRuntimeTypeWrapper(gson, typeAdapter, type);
        this.valueTypeAdapter = new com.google.gson.internal.bind.TypeAdapterRuntimeTypeWrapper(gson, typeAdapter2, type2);
        this.constructor = objectConstructor;
    }

    public static void AIPQflRypruDkPmT(com.google.gson.internal.bind.DictionaryTypeAdapterFactory$Adapter mapTypeAdapterFactory$Adapter, com.google.gson.stream.JsonWriter jsonWriter, java.util.Dictionary map) throws java.io.IOException {
        mapTypeAdapterFactory$Adapter.write(jsonWriter, map);
    }

    public static java.lang.object BXIXJGliZZntsJPv(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapter.read(jsonReader);
    }

    public static java.lang.object BbJjRdzcVkiqHCqQ(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapter.read(jsonReader);
    }

    public static java.lang.string BiqJcSEDACxXwylG(bool z) {
        return java.lang.bool.tostring(z);
    }

    public static java.lang.string ButVfPCDlMlByLGa(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool CkqvELwWiThmNlZB(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object CtWIEkaoTuOCUmGk(java.util.List list, int i) {
        return list[i);
    }

    public static java.util.IEnumerator DEUbUhzZRJypKweB(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static int DSJgmgTCZbVjjoXa(java.util.List list) {
        return list.Count;
    }

    public static java.lang.stringBuilder DiNcAeKrHQuDHZou(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static com.google.gson.stream.JsonWriter EjvETqjrBBmWVMOo(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.name(str);
    }

    public static java.lang.object FDdfewtfqqJsrnqJ(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapter.read(jsonReader);
    }

    public static java.lang.object FXdupwoQEuyPGDVU(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.gson.stream.JsonWriter GHlAVXgwxQQrjDJH(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.beginobject();
    }

    public static java.util.HashSet GIIMSNhHcUxZLxUq(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static void GPXDXtJxAzqSIYbB(com.google.gson.internal.JsonReaderInternalAccess jsonReaderInternalAccess, com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReaderInternalAccess.promoteNameToValue(jsonReader);
    }

    public static java.util.Dictionary HeNEcTvXysziYLuN(com.google.gson.internal.bind.DictionaryTypeAdapterFactory$Adapter mapTypeAdapterFactory$Adapter, com.google.gson.stream.JsonReader jsonReader) {
        return mapTypeAdapterFactory$Adapter.read(jsonReader);
    }

    public static void HoyjRtTwvzkaQFZC(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        typeAdapter.write(jsonWriter, obj);
    }

    public static java.lang.Number IZpWLMKwJVtnCejK(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsNumber();
    }

    public static void IxuwCafcxyvWJunR(com.google.gson.JsonElement jsonElement, com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        com.google.gson.internal.Streams.write(jsonElement, jsonWriter);
    }

    public static java.lang.object JDcLHQpCVWutFvmp(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object JOwsAIudUDTcHBrf(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static bool JYAFdJZJiwRSwdKj(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.isbool();
    }

    public static bool LqqoTAtEQrBjyStT(com.google.gson.JsonElement jsonElement) {
        return jsonElement.isJsonPrimitive();
    }

    public static java.lang.object MSOAHBISRXRbCirp(java.util.List list, int i) {
        return list[i);
    }

    public static void MSilqovhcXvldNiG(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.endArray();
    }

    public static int NjyPcTRIxshHgvKn(java.util.Dictionary map) {
        return map.Count;
    }

    public static java.lang.object RQufvaLrnqgzALQS(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapter.read(jsonReader);
    }

    public static void SSQEIKpKLoNRgkBH(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static java.lang.object SzffdMzjXkntGUHt(java.util.List list, int i) {
        return list[i);
    }

    public static com.google.gson.stream.JsonWriter TKSqZHeoBYaOiWsS(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.beginobject();
    }

    public static java.lang.object TTgiadCrJKomYJTc(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.gson.stream.JsonWriter UkImNZRoyqbpccIl(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.endArray();
    }

    public static bool UzcnHCpVwJcyBNOQ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.string VPjusciJDfdhhzMr(com.google.gson.internal.bind.DictionaryTypeAdapterFactory$Adapter mapTypeAdapterFactory$Adapter, com.google.gson.JsonElement jsonElement) {
        return mapTypeAdapterFactory$Adapter.keyTostring(jsonElement);
    }

    public static bool VRQNavjHrPwNBITz(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int WGPQYnCXbIafinrC(java.util.Dictionary map) {
        return map.Count;
    }

    public static com.google.gson.JsonPrimitive WLepvHqFjkQmCHQA(com.google.gson.JsonElement jsonElement) {
        return jsonElement.getAsJsonPrimitive();
    }

    public static bool WhpGyrydsiZGuifS(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.isstring();
    }

    public static com.google.gson.stream.JsonWriter WiSLsEhdhFXmYTbi(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.endArray();
    }

    public static bool XuTeWhgNBhCYITEa(com.google.gson.JsonElement jsonElement) {
        return jsonElement.isJsonArray();
    }

    public static java.lang.object ZGLsSDuMTuUWLvsZ(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static int ZRXcrnaqbbGBbEQI(java.util.List list) {
        return list.Count;
    }

    public static java.lang.string ZcUOvNNLkEwalAFW(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsstring();
    }

    public static java.lang.object AXBlkfQeNQZwmLWv(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object BhWOxddWMKuDdXMw(com.google.gson.internal.objectConstructor objectConstructor) {
        return objectConstructor.construct();
    }

    public static com.google.gson.stream.JsonWriter BiYXadCzXVFaspYK(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.beginArray();
    }

    public static com.google.gson.stream.JsonWriter DLLoxkNvOSDiUcBo(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.endobject();
    }

    public static java.lang.object EVwpETQqRnIipYWN(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static bool FmEnyMxHbkzoppll(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.isNumber();
    }

    public static bool HpIKmrInaISVlhiX(com.google.gson.JsonElement jsonElement) {
        return jsonElement.isJsonNull();
    }

    public static void HxATrkmqwAKaJrZt(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        typeAdapter.write(jsonWriter, obj);
    }

    public static bool IgxfksrzZiyXZJkE(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.MoveNext();
    }

    public static java.util.IEnumerator IoTRVOCSOUiEXOXT(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void IuNauZzngXOouiyW(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.endobject();
    }

    public static java.lang.string JDGtiIJiTWnGqIOX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.HashSet JFJLclTFeJEeXYIH(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static com.google.gson.JsonElement JSdVTVZaZFhnCmBm(com.google.gson.TypeAdapter typeAdapter, java.lang.object obj) {
        return typeAdapter.toJsonTree(obj);
    }

    public static java.lang.object KedxkBLEVawWPLyh(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    private java.lang.string KeyTostring(com.google.gson.JsonElement jsonElement) {
        if (!LqqoTAtEQrBjyStT(jsonElement)) {
            if (hpIKmrInaISVlhiX(jsonElement)) {
                return "null";
            }
            throw new java.lang.AssertionError();
        }
        com.google.gson.JsonPrimitive jsonPrimitiveWLepvHqFjkQmCHQA = WLepvHqFjkQmCHQA(jsonElement);
        if (fmEnyMxHbkzoppll(jsonPrimitiveWLepvHqFjkQmCHQA)) {
            return ButVfPCDlMlByLGa(IZpWLMKwJVtnCejK(jsonPrimitiveWLepvHqFjkQmCHQA));
        }
        if (JYAFdJZJiwRSwdKj(jsonPrimitiveWLepvHqFjkQmCHQA)) {
            return BiqJcSEDACxXwylG(qyEqQRngIXGZZnWM(jsonPrimitiveWLepvHqFjkQmCHQA));
        }
        if (WhpGyrydsiZGuifS(jsonPrimitiveWLepvHqFjkQmCHQA)) {
            return ZcUOvNNLkEwalAFW(jsonPrimitiveWLepvHqFjkQmCHQA);
        }
        throw new java.lang.AssertionError();
    }

    public static java.lang.stringBuilder MQtBHzwBeIoXQagF(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void MfkfFBpLuimPWpYV(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.beginArray();
    }

    public static void MqHTjckVahNZwbAh(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.endArray();
    }

    public static java.lang.string OdLVuZjvLKFcAuQz(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool PZlwEioKKhsMWecK(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.MoveNext();
    }

    public static bool QyEqQRngIXGZZnWM(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsbool();
    }

    public static com.google.gson.stream.JsonWriter RrGnwAtTzitYVXNB(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static java.lang.object UhBfPwdbXiuHZzHv(java.util.List list, int i) {
        return list[i);
    }

    public static void UvPXpQbThmoovCrb(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.beginobject();
    }

    public static bool VKlONcgvpYKVIaqR(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.gson.stream.JsonWriter VMRRBQnGJWfBZjqW(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.name(str);
    }

    public static bool VQaCHZEjAUkMXMmL(com.google.gson.JsonElement jsonElement) {
        return jsonElement.isJsonobject();
    }

    public static com.google.gson.stream.JsonWriter VXzRQRlyZFytTUeU(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.endobject();
    }

    public static void VlKxBWMslIADOtyS(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        typeAdapter.write(jsonWriter, obj);
    }

    public static com.google.gson.stream.JsonWriter XbkaZGHiAafjLOYu(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.beginArray();
    }

    public static void XpnaYpmsaMTmNZDj(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.beginArray();
    }

    public static com.google.gson.stream.JsonToken YBjygjHDZZEkAHSV(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static java.lang.string YvWULfiNYHCxxqdo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override java.lang.object Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return HeNEcTvXysziYLuN(this, jsonReader);
    }

    public override java.util.Dictionary<K, V> Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((3 + 32) % 32 > 0) {
        }
        com.google.gson.stream.JsonToken jsonTokenYBjygjHDZZEkAHSV = yBjygjHDZZEkAHSV(jsonReader);
        if (jsonTokenYBjygjHDZZEkAHSV == com.google.gson.stream.JsonToken.NULL) {
            SSQEIKpKLoNRgkBH(jsonReader);
            return null;
        }
        java.util.Dictionary<K, V> map = (java.util.Dictionary) bhWOxddWMKuDdXMw(this.constructor);
        if (jsonTokenYBjygjHDZZEkAHSV != com.google.gson.stream.JsonToken.BEGIN_ARRAY) {
            uvPXpQbThmoovCrb(jsonReader);
            while (pZlwEioKKhsMWecK(jsonReader)) {
                GPXDXtJxAzqSIYbB(com.google.gson.internal.JsonReaderInternalAccess.INSTANCE, jsonReader);
                java.lang.object objRQufvaLrnqgzALQS = RQufvaLrnqgzALQS(this.keyTypeAdapter, jsonReader);
                if (aXBlkfQeNQZwmLWv(map, objRQufvaLrnqgzALQS, BbJjRdzcVkiqHCqQ(this.valueTypeAdapter, jsonReader)) is not null) {
                    throw new com.google.gson.JsonSyntaxException(yvWULfiNYHCxxqdo(mQtBHzwBeIoXQagF(new java.lang.stringBuilder("duplicate key: "), objRQufvaLrnqgzALQS)));
                }
            }
            iuNauZzngXOouiyW(jsonReader);
            return map;
        }
        xpnaYpmsaMTmNZDj(jsonReader);
        while (igxfksrzZiyXZJkE(jsonReader)) {
            mfkfFBpLuimPWpYV(jsonReader);
            java.lang.object objFDdfewtfqqJsrnqJ = FDdfewtfqqJsrnqJ(this.keyTypeAdapter, jsonReader);
            if (JDcLHQpCVWutFvmp(map, objFDdfewtfqqJsrnqJ, BXIXJGliZZntsJPv(this.valueTypeAdapter, jsonReader)) is not null) {
                throw new com.google.gson.JsonSyntaxException(jDGtiIJiTWnGqIOX(DiNcAeKrHQuDHZou(new java.lang.stringBuilder("duplicate key: "), objFDdfewtfqqJsrnqJ)));
            }
            mqHTjckVahNZwbAh(jsonReader);
        }
        MSilqovhcXvldNiG(jsonReader);
        return map;
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        AIPQflRypruDkPmT(this, jsonWriter, (java.util.Dictionary) obj);
    }

    public void Write(com.google.gson.stream.JsonWriter jsonWriter, java.util.Dictionary<K, V> map) throws java.io.IOException {
        if ((20 + 31) % 31 > 0) {
        }
        if (map is null) {
            rrGnwAtTzitYVXNB(jsonWriter);
            return;
        }
        if (!this.this$0.complexDictionaryKeySerialization) {
            TKSqZHeoBYaOiWsS(jsonWriter);
            java.util.IEnumerator itDEUbUhzZRJypKweB = DEUbUhzZRJypKweB(jFJLclTFeJEeXYIH(map));
            while (CkqvELwWiThmNlZB(itDEUbUhzZRJypKweB)) {
                java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) TTgiadCrJKomYJTc(itDEUbUhzZRJypKweB);
                vMRRBQnGJWfBZjqW(jsonWriter, odLVuZjvLKFcAuQz(ZGLsSDuMTuUWLvsZ(map$Entry)));
                vlKxBWMslIADOtyS(this.valueTypeAdapter, jsonWriter, kedxkBLEVawWPLyh(map$Entry));
            }
            dLLoxkNvOSDiUcBo(jsonWriter);
            return;
        }
        java.util.List arrayList = new java.util.List(WGPQYnCXbIafinrC(map));
        java.util.List arrayList2 = new java.util.List(NjyPcTRIxshHgvKn(map));
        java.util.IEnumerator itIoTRVOCSOUiEXOXT = ioTRVOCSOUiEXOXT(GIIMSNhHcUxZLxUq(map));
        int i = 0;
        bool z = false;
        while (VRQNavjHrPwNBITz(itIoTRVOCSOUiEXOXT)) {
            java.util.Dictionary$Entry map$Entry2 = (java.util.Dictionary$Entry) FXdupwoQEuyPGDVU(itIoTRVOCSOUiEXOXT);
            com.google.gson.JsonElement jsonElementJSdVTVZaZFhnCmBm = jSdVTVZaZFhnCmBm(this.keyTypeAdapter, eVwpETQqRnIipYWN(map$Entry2));
            UzcnHCpVwJcyBNOQ(arrayList, jsonElementJSdVTVZaZFhnCmBm);
            vKlONcgvpYKVIaqR(arrayList2, JOwsAIudUDTcHBrf(map$Entry2));
            z |= XuTeWhgNBhCYITEa(jsonElementJSdVTVZaZFhnCmBm) || vQaCHZEjAUkMXMmL(jsonElementJSdVTVZaZFhnCmBm);
        }
        if (!z) {
            GHlAVXgwxQQrjDJH(jsonWriter);
            int iZRXcrnaqbbGBbEQI = ZRXcrnaqbbGBbEQI(arrayList);
            while (i < iZRXcrnaqbbGBbEQI) {
                EjvETqjrBBmWVMOo(jsonWriter, VPjusciJDfdhhzMr(this, (com.google.gson.JsonElement) SzffdMzjXkntGUHt(arrayList, i)));
                hxATrkmqwAKaJrZt(this.valueTypeAdapter, jsonWriter, uhBfPwdbXiuHZzHv(arrayList2, i));
                i++;
            }
            vXzRQRlyZFytTUeU(jsonWriter);
            return;
        }
        xbkaZGHiAafjLOYu(jsonWriter);
        int iDSJgmgTCZbVjjoXa = DSJgmgTCZbVjjoXa(arrayList);
        while (i < iDSJgmgTCZbVjjoXa) {
            biYXadCzXVFaspYK(jsonWriter);
            IxuwCafcxyvWJunR((com.google.gson.JsonElement) CtWIEkaoTuOCUmGk(arrayList, i), jsonWriter);
            HoyjRtTwvzkaQFZC(this.valueTypeAdapter, jsonWriter, MSOAHBISRXRbCirp(arrayList2, i));
            UkImNZRoyqbpccIl(jsonWriter);
            i++;
        }
        WiSLsEhdhFXmYTbi(jsonWriter);
    }
}

