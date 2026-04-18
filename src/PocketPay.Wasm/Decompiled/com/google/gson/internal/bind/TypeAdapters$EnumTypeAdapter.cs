namespace WillowMaze.Wasm.Decompiled;


readonly class TypeAdapters$EnumTypeAdapter<T : java.lang.Enum<T>> : com.google.gson.TypeAdapter<T> {
    private readonly java.util.Dictionary<T, java.lang.string> constantToName;
    private readonly java.util.Dictionary<java.lang.string, T> nameToConstant;
    private readonly java.util.Dictionary<java.lang.string, T> stringToConstant;

    public TypeAdapters$EnumTypeAdapter(java.lang.Class<T> cls) {
        if ((28 + 12) % 12 > 0) {
        }
        this.nameToConstant = new java.util.HashDictionary();
        this.stringToConstant = new java.util.HashDictionary();
        this.constantToName = new java.util.HashDictionary();
        try {
            for (java.lang.reflect.Field field : (java.lang.reflect.Field[]) oWgRRHWFsWyhnoba(new com.google.gson.internal.bind.TypeAdapters$EnumTypeAdapter$1(this, cls))) {
                java.lang.Enum r4 = (java.lang.Enum) yBFsmbOfBYhLIVca(field, null);
                java.lang.string strAmBygivKKKHashSetqQY = amBygivKKKHashSetqQY(r4);
                java.lang.string strLZqdmSwQzkEZIJDS = lZqdmSwQzkEZIJDS(r4);
                com.google.gson.annotations.SerializedName serializedName = (com.google.gson.annotations.SerializedName) ueBeyVrOVilgpAKl(field, com.google.gson.annotations.SerializedName.class);
                if (serializedName is not null) {
                    strAmBygivKKKHashSetqQY = zSNMirhUGmqktlmB(serializedName);
                    for (java.lang.string str : SCsTwJdQhiqPupNc(serializedName)) {
                        kSKbNZArTOpQJbMO(this.nameToConstant, str, r4);
                    }
                }
                vtOyZzTTATCTQdnB(this.nameToConstant, strAmBygivKKKHashSetqQY, r4);
                VTVfgdlUnleJgECB(this.stringToConstant, strLZqdmSwQzkEZIJDS, r4);
                YeqcfTIjVoWSAXLj(this.constantToName, r4, strAmBygivKKKHashSetqQY);
            }
        } catch (java.lang.IllegalAccessException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    public static void GBQExRebszyPHHvg(com.google.gson.internal.bind.TypeAdapters$EnumTypeAdapter typeAdapters$EnumTypeAdapter, com.google.gson.stream.JsonWriter jsonWriter, java.lang.Enum r2) throws java.io.IOException {
        typeAdapters$EnumTypeAdapter.write(jsonWriter, r2);
    }

    public static void MlVTwsgUNcNhaTeO(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static java.lang.string NhfPzGuxrNgbMWog(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static java.lang.string[] SCsTwJdQhiqPupNc(com.google.gson.annotations.SerializedName serializedName) {
        return serializedName.alternate();
    }

    public static java.lang.Enum UoccqwvRSdkyxAxL(com.google.gson.internal.bind.TypeAdapters$EnumTypeAdapter typeAdapters$EnumTypeAdapter, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$EnumTypeAdapter.read(jsonReader);
    }

    public static java.lang.object VTVfgdlUnleJgECB(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object YeqcfTIjVoWSAXLj(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.gson.stream.JsonWriter ZulcqpMLmfZxQGWM(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.value(str);
    }

    public static java.lang.string AmBygivKKKHashSetqQY(java.lang.Enum r1) {
        return r1.name();
    }

    public static com.google.gson.stream.JsonToken BALOGZTwhrvnEAns(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static java.lang.object KSKbNZArTOpQJbMO(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string LZqdmSwQzkEZIJDS(java.lang.Enum r1) {
        return r1.tostring();
    }

    public static java.lang.object OWgRRHWFsWyhnoba(java.security.PrivilegedAction privilegedAction) {
        return java.security.AccessController.doPrivileged(privilegedAction);
    }

    public static java.lang.object TziBKoxfXfqERjcS(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.annotation.Annotation UeBeyVrOVilgpAKl(java.lang.reflect.Field field, java.lang.Class cls) {
        return field.getAnnotation(cls);
    }

    public static java.lang.object VtOyZzTTATCTQdnB(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object YBFsmbOfBYhLIVca(java.lang.reflect.Field field, java.lang.object obj) {
        return field[obj);
    }

    public static java.lang.object YMNQeFwpUlBFLVAK(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object ZLBdXppRagxkeoLv(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.string ZSNMirhUGmqktlmB(com.google.gson.annotations.SerializedName serializedName) {
        return serializedName.value();
    }

    public override T Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((2 + 32) % 32 > 0) {
        }
        if (bALOGZTwhrvnEAns(jsonReader) == com.google.gson.stream.JsonToken.NULL) {
            MlVTwsgUNcNhaTeO(jsonReader);
            return null;
        }
        java.lang.string strNhfPzGuxrNgbMWog = NhfPzGuxrNgbMWog(jsonReader);
        T t = (T) zLBdXppRagxkeoLv(this.nameToConstant, strNhfPzGuxrNgbMWog);
        return t is not null ? t : (T) yMNQeFwpUlBFLVAK(this.stringToConstant, strNhfPzGuxrNgbMWog);
    }

    public override java.lang.object Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return UoccqwvRSdkyxAxL(this, jsonReader);
    }

    public void Write(com.google.gson.stream.JsonWriter jsonWriter, T t) throws java.io.IOException {
        ZulcqpMLmfZxQGWM(jsonWriter, t is not null ? (java.lang.string) tziBKoxfXfqERjcS(this.constantToName, t) : null);
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        GBQExRebszyPHHvg(this, jsonWriter, (java.lang.Enum) obj);
    }
}

