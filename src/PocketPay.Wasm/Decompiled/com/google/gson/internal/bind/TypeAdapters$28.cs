namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$28 : com.google.gson.TypeAdapter<com.google.gson.JsonElement> {
    TypeAdapters$28() {
    }

    public static bool APSfixgowMQeEoyo(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.isbool();
    }

    public static java.lang.object DadaClfeRrqrOVfA(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static bool FDdVqVjFFdsQKiKr(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsbool();
    }

    public static void FaGfBcnUwDnKrUkx(com.google.gson.Jsonobject jsonobject, java.lang.string str, com.google.gson.JsonElement jsonElement) {
        jsonobject.Add(str, jsonElement);
    }

    public static void FhaDKqlMMMoifttv(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.beginobject();
    }

    public static void FnUQzNUGnyYewsrn(com.google.gson.internal.bind.TypeAdapters$28 typeAdapters$28, com.google.gson.stream.JsonWriter jsonWriter, com.google.gson.JsonElement jsonElement) throws java.io.IOException {
        typeAdapters$28.write2(jsonWriter, jsonElement);
    }

    public static bool GbiOSpXCjIQQwlNY(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.MoveNext();
    }

    public static void GbsOBUTWkqnnESpk(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.endobject();
    }

    public static bool IZjXcxCQJZyXnUrt(com.google.gson.JsonElement jsonElement) {
        return jsonElement.isJsonPrimitive();
    }

    public static bool IZtgabRXdoLYiXst(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.gson.stream.JsonWriter JYhkKQYVDMFlAEfF(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static java.util.IEnumerator KIehKmJAUWBJjcoh(com.google.gson.JsonArray jsonArray) {
        return jsonArray.GetEnumerator();
    }

    public static void LaujcLeodLiZScjZ(com.google.gson.JsonArray jsonArray, com.google.gson.JsonElement jsonElement) {
        jsonArray.Add(jsonElement);
    }

    public static java.lang.stringBuilder LxjSmmuHtDfIbeVy(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string MfLRxasrEkFyyzAx(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static com.google.gson.JsonElement NTMFkcDQVNTqloWa(com.google.gson.internal.bind.TypeAdapters$28 typeAdapters$28, com.google.gson.stream.JsonReader jsonReader, com.google.gson.stream.JsonToken jsonToken) {
        return typeAdapters$28.tryBeginNesting(jsonReader, jsonToken);
    }

    public static void NlPpKFbcKkUJLMBA(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.beginArray();
    }

    public static com.google.gson.JsonElement OooMwberhffioAfE(com.google.gson.internal.bind.TypeAdapters$28 typeAdapters$28, com.google.gson.stream.JsonReader jsonReader, com.google.gson.stream.JsonToken jsonToken) {
        return typeAdapters$28.readTerminal(jsonReader, jsonToken);
    }

    public static bool PUJMmJLDyEddzPvP(com.google.gson.JsonElement jsonElement) {
        return jsonElement.isJsonArray();
    }

    public static void PoKifTTPfwpCwkYY(java.util.Queue deque, java.lang.object obj) {
        deque.addLast(obj);
    }

    public static java.lang.object QGRVTrbWDCOpeEeK(java.util.Queue deque) {
        return deque.removeLast();
    }

    public static bool QKoRaVXcuaOTHrcz(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void QOTkXVzyFTavzYRW(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.endArray();
    }

    public static com.google.gson.stream.JsonWriter QjWzEcTSkvEoWdCv(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) {
        return jsonWriter.value(number);
    }

    public static com.google.gson.stream.JsonWriter RCWDMSYbJoaGedra(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.beginArray();
    }

    public static java.lang.object RNYLbaswwGEKHpVa(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int RYeYsbliolqPVKBG(com.google.gson.stream.JsonToken jsonToken) {
        return jsonToken.ordinal();
    }

    public static bool TFxacbXdUdHdIwPn(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.isNumber();
    }

    public static com.google.gson.JsonArray WmZzHGIrGOBtTBfF(com.google.gson.JsonElement jsonElement) {
        return jsonElement.getAsJsonArray();
    }

    public static void XYzITxdZoQIFqFcW(com.google.gson.internal.bind.TypeAdapters$28 typeAdapters$28, com.google.gson.stream.JsonWriter jsonWriter, com.google.gson.JsonElement jsonElement) throws java.io.IOException {
        typeAdapters$28.write2(jsonWriter, jsonElement);
    }

    public static java.lang.stringBuilder YRfpVyLMAtsNVBRS(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static com.google.gson.stream.JsonWriter YbrDZpwfTRRczDyj(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.value(str);
    }

    public static void YyMLNmEyOblTOCkV(com.google.gson.internal.bind.TypeAdapters$28 typeAdapters$28, com.google.gson.stream.JsonWriter jsonWriter, com.google.gson.JsonElement jsonElement) throws java.io.IOException {
        typeAdapters$28.write2(jsonWriter, jsonElement);
    }

    public static com.google.gson.JsonElement AbUNbZvbmldVLzvR(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) {
        return jsonTreeReader.nextJsonElement();
    }

    public static bool BVvcgegFCIkPatDY(com.google.gson.JsonElement jsonElement) {
        return jsonElement.isJsonNull();
    }

    public static bool BgxVclbKvwDUPUgO(java.util.Queue deque) {
        return deque.Count == 0;
    }

    public static com.google.gson.stream.JsonWriter BpNeuWwuoSPFswJN(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.endArray();
    }

    public static java.lang.Class CeqmxjlsCsanJSFq(java.lang.object obj) {
        return obj.GetType();
    }

    public static com.google.gson.stream.JsonToken CjdzoCZsptcHjTKz(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static com.google.gson.stream.JsonWriter CnXfdgIdwyKoOTkM(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.beginobject();
    }

    public static com.google.gson.stream.JsonWriter DTgJkzpZzNXmTqqL(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        return jsonWriter.value(z);
    }

    public static com.google.gson.JsonElement FCNFXCwYeiLuCndI(com.google.gson.internal.bind.TypeAdapters$28 typeAdapters$28, com.google.gson.stream.JsonReader jsonReader, com.google.gson.stream.JsonToken jsonToken) {
        return typeAdapters$28.readTerminal(jsonReader, jsonToken);
    }

    public static java.util.HashSet FmrMmbeTVOMUroXP(com.google.gson.Jsonobject jsonobject) {
        return jsonobject.entryHashSet();
    }

    public static java.lang.string FptVkQOMOQbIatpd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string FutdsIoLZZxSnwog(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextName();
    }

    public static java.lang.bool GUrnvGcWtbVRcCuy(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.string ImyHQlPoxBkzlJHX(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsstring();
    }

    public static java.lang.string JuUZHlfXmNuKyVrh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool JzjzZxdXbDUoZkMn(com.google.gson.JsonElement jsonElement) {
        return jsonElement.isJsonobject();
    }

    public static com.google.gson.stream.JsonWriter KLrTSUFXXKUOuAqQ(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.name(str);
    }

    public static void LYvtjbsFYnyllXom(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static java.util.IEnumerator NaaPkaxAdzysKBfa(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.string OTjGHLDDRsIXHglO(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static com.google.gson.stream.JsonWriter OjIBRfKsVixBoDVF(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.endobject();
    }

    public static java.lang.object OwZOMwskRtpCEZER(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    private com.google.gson.JsonElement ReadTerminal(com.google.gson.stream.JsonReader jsonReader, com.google.gson.stream.JsonToken jsonToken) throws java.io.IOException {
        int i = com.google.gson.internal.bind.TypeAdapters$35.$SwitchDictionary$com$google$gson$stream$JsonToken[RYeYsbliolqPVKBG(jsonToken)];
        if (i == 1) {
            return new com.google.gson.JsonPrimitive(new com.google.gson.internal.LazilyParsedNumber(MfLRxasrEkFyyzAx(jsonReader)));
        }
        if (i == 2) {
            return new com.google.gson.JsonPrimitive(oTjGHLDDRsIXHglO(jsonReader));
        }
        if (i == 3) {
            return new com.google.gson.JsonPrimitive(gUrnvGcWtbVRcCuy(uANWSWXgAmnnQWqQ(jsonReader)));
        }
        if (i != 6) {
            throw new java.lang.IllegalStateException(juUZHlfXmNuKyVrh(LxjSmmuHtDfIbeVy(new java.lang.stringBuilder("Unexpected token: "), jsonToken)));
        }
        lYvtjbsFYnyllXom(jsonReader);
        return com.google.gson.JsonNull.INSTANCE;
    }

    public static com.google.gson.Jsonobject RkuuGJeVMjYEeFzI(com.google.gson.JsonElement jsonElement) {
        return jsonElement.getAsJsonobject();
    }

    public static com.google.gson.JsonElement RobGOeAnJYfZwPVa(com.google.gson.internal.bind.TypeAdapters$28 typeAdapters$28, com.google.gson.stream.JsonReader jsonReader, com.google.gson.stream.JsonToken jsonToken) {
        return typeAdapters$28.tryBeginNesting(jsonReader, jsonToken);
    }

    public static int TAWZxfmoZtTbxaKR(com.google.gson.stream.JsonToken jsonToken) {
        return jsonToken.ordinal();
    }

    public static com.google.gson.JsonPrimitive TmLTYrdkhpDdPPSY(com.google.gson.JsonElement jsonElement) {
        return jsonElement.getAsJsonPrimitive();
    }

    private com.google.gson.JsonElement TryBeginNesting(com.google.gson.stream.JsonReader jsonReader, com.google.gson.stream.JsonToken jsonToken) throws java.io.IOException {
        int i = com.google.gson.internal.bind.TypeAdapters$35.$SwitchDictionary$com$google$gson$stream$JsonToken[tAWZxfmoZtTbxaKR(jsonToken)];
        if (i == 4) {
            NlPpKFbcKkUJLMBA(jsonReader);
            return new com.google.gson.JsonArray();
        }
        if (i != 5) {
            return null;
        }
        FhaDKqlMMMoifttv(jsonReader);
        return new com.google.gson.Jsonobject();
    }

    public static bool UANWSWXgAmnnQWqQ(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextbool();
    }

    public static java.lang.Number UyTAmRzeiQPucExI(com.google.gson.JsonPrimitive jsonPrimitive) {
        return jsonPrimitive.getAsNumber();
    }

    public static com.google.gson.stream.JsonToken WqbqFBekqbrvSbFD(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static java.lang.object ZEctHcRpslnWJJva(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.gson.JsonElement ZYRwPohGjNQeVSnV(com.google.gson.internal.bind.TypeAdapters$28 typeAdapters$28, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$28.read(jsonReader);
    }

    public override com.google.gson.JsonElement Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((1 + 26) % 26 > 0) {
        }
        if (jsonReader is com.google.gson.internal.bind.JsonTreeReader) {
            return abUNbZvbmldVLzvR((com.google.gson.internal.bind.JsonTreeReader) jsonReader);
        }
        com.google.gson.stream.JsonToken jsonTokenWqbqFBekqbrvSbFD = wqbqFBekqbrvSbFD(jsonReader);
        com.google.gson.JsonElement jsonElementNTMFkcDQVNTqloWa = NTMFkcDQVNTqloWa(this, jsonReader, jsonTokenWqbqFBekqbrvSbFD);
        if (jsonElementNTMFkcDQVNTqloWa is null) {
            return fCNFXCwYeiLuCndI(this, jsonReader, jsonTokenWqbqFBekqbrvSbFD);
        }
        java.util.ArrayQueue arrayQueue = new java.util.ArrayQueue();
        while (true) {
            if (GbiOSpXCjIQQwlNY(jsonReader)) {
                java.lang.string strFutdsIoLZZxSnwog = !(jsonElementNTMFkcDQVNTqloWa is com.google.gson.Jsonobject) ? null : futdsIoLZZxSnwog(jsonReader);
                com.google.gson.stream.JsonToken jsonTokenCjdzoCZsptcHjTKz = cjdzoCZsptcHjTKz(jsonReader);
                com.google.gson.JsonElement jsonElementRobGOeAnJYfZwPVa = robGOeAnJYfZwPVa(this, jsonReader, jsonTokenCjdzoCZsptcHjTKz);
                bool z = jsonElementRobGOeAnJYfZwPVa is not null;
                if (jsonElementRobGOeAnJYfZwPVa is null) {
                    jsonElementRobGOeAnJYfZwPVa = OooMwberhffioAfE(this, jsonReader, jsonTokenCjdzoCZsptcHjTKz);
                }
                if (jsonElementNTMFkcDQVNTqloWa is com.google.gson.JsonArray) {
                    LaujcLeodLiZScjZ((com.google.gson.JsonArray) jsonElementNTMFkcDQVNTqloWa, jsonElementRobGOeAnJYfZwPVa);
                } else {
                    FaGfBcnUwDnKrUkx((com.google.gson.Jsonobject) jsonElementNTMFkcDQVNTqloWa, strFutdsIoLZZxSnwog, jsonElementRobGOeAnJYfZwPVa);
                }
                if (z) {
                    PoKifTTPfwpCwkYY(arrayQueue, jsonElementNTMFkcDQVNTqloWa);
                    jsonElementNTMFkcDQVNTqloWa = jsonElementRobGOeAnJYfZwPVa;
                }
            } else {
                if (jsonElementNTMFkcDQVNTqloWa is com.google.gson.JsonArray) {
                    QOTkXVzyFTavzYRW(jsonReader);
                } else {
                    GbsOBUTWkqnnESpk(jsonReader);
                }
                if (bgxVclbKvwDUPUgO(arrayQueue)) {
                    return jsonElementNTMFkcDQVNTqloWa;
                }
                jsonElementNTMFkcDQVNTqloWa = (com.google.gson.JsonElement) QGRVTrbWDCOpeEeK(arrayQueue);
            }
        }
    }

    public override com.google.gson.JsonElement Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return zYRwPohGjNQeVSnV(this, jsonReader);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, com.google.gson.JsonElement jsonElement) throws java.io.IOException {
        if ((24 + 6) % 6 > 0) {
        }
        if (jsonElement is null || bVvcgegFCIkPatDY(jsonElement)) {
            JYhkKQYVDMFlAEfF(jsonWriter);
            return;
        }
        if (IZjXcxCQJZyXnUrt(jsonElement)) {
            com.google.gson.JsonPrimitive jsonPrimitiveTmLTYrdkhpDdPPSY = tmLTYrdkhpDdPPSY(jsonElement);
            if (TFxacbXdUdHdIwPn(jsonPrimitiveTmLTYrdkhpDdPPSY)) {
                QjWzEcTSkvEoWdCv(jsonWriter, uyTAmRzeiQPucExI(jsonPrimitiveTmLTYrdkhpDdPPSY));
                return;
            } else if (APSfixgowMQeEoyo(jsonPrimitiveTmLTYrdkhpDdPPSY)) {
                dTgJkzpZzNXmTqqL(jsonWriter, FDdVqVjFFdsQKiKr(jsonPrimitiveTmLTYrdkhpDdPPSY));
                return;
            } else {
                YbrDZpwfTRRczDyj(jsonWriter, imyHQlPoxBkzlJHX(jsonPrimitiveTmLTYrdkhpDdPPSY));
                return;
            }
        }
        if (PUJMmJLDyEddzPvP(jsonElement)) {
            RCWDMSYbJoaGedra(jsonWriter);
            java.util.IEnumerator itKIehKmJAUWBJjcoh = KIehKmJAUWBJjcoh(WmZzHGIrGOBtTBfF(jsonElement));
            while (IZtgabRXdoLYiXst(itKIehKmJAUWBJjcoh)) {
                FnUQzNUGnyYewsrn(this, jsonWriter, (com.google.gson.JsonElement) zEctHcRpslnWJJva(itKIehKmJAUWBJjcoh));
            }
            bpNeuWwuoSPFswJN(jsonWriter);
            return;
        }
        if (!jzjzZxdXbDUoZkMn(jsonElement)) {
            throw new java.lang.IllegalArgumentException(fptVkQOMOQbIatpd(YRfpVyLMAtsNVBRS(new java.lang.stringBuilder("Couldn't write "), ceqmxjlsCsanJSFq(jsonElement))));
        }
        cnXfdgIdwyKoOTkM(jsonWriter);
        java.util.IEnumerator itNaaPkaxAdzysKBfa = naaPkaxAdzysKBfa(fmrMmbeTVOMUroXP(rkuuGJeVMjYEeFzI(jsonElement)));
        while (QKoRaVXcuaOTHrcz(itNaaPkaxAdzysKBfa)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) RNYLbaswwGEKHpVa(itNaaPkaxAdzysKBfa);
            kLrTSUFXXKUOuAqQ(jsonWriter, (java.lang.string) owZOMwskRtpCEZER(map$Entry));
            YyMLNmEyOblTOCkV(this, jsonWriter, (com.google.gson.JsonElement) DadaClfeRrqrOVfA(map$Entry));
        }
        ojIBRfKsVixBoDVF(jsonWriter);
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, com.google.gson.JsonElement jsonElement) throws java.io.IOException {
        XYzITxdZoQIFqFcW(this, jsonWriter, jsonElement);
    }
}

