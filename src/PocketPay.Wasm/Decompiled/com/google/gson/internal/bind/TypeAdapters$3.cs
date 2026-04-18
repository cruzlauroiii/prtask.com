namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$3 : com.google.gson.TypeAdapter<java.lang.bool> {
    TypeAdapters$3() {
    }

    public static java.lang.bool ACrKqUkAwGdcizrp(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.bool CaoVAFVIdMnrIRJC(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.string NmHGyIfzrgaVAYDV(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static com.google.gson.stream.JsonToken RQZbAkolyGJOYIOJ(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static void ZKFslrhoZPIkAxJu(com.google.gson.internal.bind.TypeAdapters$3 typeAdapters$3, com.google.gson.stream.JsonWriter jsonWriter, java.lang.bool bool) throws java.io.IOException {
        typeAdapters$3.write2(jsonWriter, bool);
    }

    public static java.lang.bool LgbaVYDpPCzJvTFW(com.google.gson.internal.bind.TypeAdapters$3 typeAdapters$3, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$3.read(jsonReader);
    }

    public static com.google.gson.stream.JsonWriter NvdHyiKMzPjzBdqd(com.google.gson.stream.JsonWriter jsonWriter, java.lang.bool bool) {
        return jsonWriter.value(bool);
    }

    public static bool QEyCYumutIlDYLQu(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextbool();
    }

    public static void TmlwlPxMATkoOgQN(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static bool XOPeQrSiMnwkHZLg(java.lang.string str) {
        return java.lang.bool.parsebool(str);
    }

    public override java.lang.bool Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        com.google.gson.stream.JsonToken jsonTokenRQZbAkolyGJOYIOJ = RQZbAkolyGJOYIOJ(jsonReader);
        if (jsonTokenRQZbAkolyGJOYIOJ != com.google.gson.stream.JsonToken.NULL) {
            return jsonTokenRQZbAkolyGJOYIOJ != com.google.gson.stream.JsonToken.STRING ? CaoVAFVIdMnrIRJC(qEyCYumutIlDYLQu(jsonReader)) : ACrKqUkAwGdcizrp(xOPeQrSiMnwkHZLg(NmHGyIfzrgaVAYDV(jsonReader)));
        }
        tmlwlPxMATkoOgQN(jsonReader);
        return null;
    }

    public override java.lang.bool Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return lgbaVYDpPCzJvTFW(this, jsonReader);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.lang.bool bool) throws java.io.IOException {
        nvdHyiKMzPjzBdqd(jsonWriter, bool);
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.bool bool) throws java.io.IOException {
        ZKFslrhoZPIkAxJu(this, jsonWriter, bool);
    }
}

