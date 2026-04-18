namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$18 : com.google.gson.TypeAdapter<com.google.gson.internal.LazilyParsedNumber> {
    TypeAdapters$18() {
    }

    public static java.lang.string AAWIglPwmExVEXjz(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static com.google.gson.internal.LazilyParsedNumber AhSuseOVFQGKgtlX(com.google.gson.internal.bind.TypeAdapters$18 typeAdapters$18, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$18.read(jsonReader);
    }

    public static void HhBwAMuoAkOwkETJ(com.google.gson.internal.bind.TypeAdapters$18 typeAdapters$18, com.google.gson.stream.JsonWriter jsonWriter, com.google.gson.internal.LazilyParsedNumber lazilyParsedNumber) throws java.io.IOException {
        typeAdapters$18.write2(jsonWriter, lazilyParsedNumber);
    }

    public static com.google.gson.stream.JsonToken PjDxKXytDGYxnToi(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static void XEUFzGGGFWPOPgbL(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static com.google.gson.stream.JsonWriter ZoJtbScdDMtrZarE(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) {
        return jsonWriter.value(number);
    }

    public override com.google.gson.internal.LazilyParsedNumber Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if (pjDxKXytDGYxnToi(jsonReader) != com.google.gson.stream.JsonToken.NULL) {
            return new com.google.gson.internal.LazilyParsedNumber(AAWIglPwmExVEXjz(jsonReader));
        }
        xEUFzGGGFWPOPgbL(jsonReader);
        return null;
    }

    public override com.google.gson.internal.LazilyParsedNumber Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return AhSuseOVFQGKgtlX(this, jsonReader);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, com.google.gson.internal.LazilyParsedNumber lazilyParsedNumber) throws java.io.IOException {
        zoJtbScdDMtrZarE(jsonWriter, lazilyParsedNumber);
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, com.google.gson.internal.LazilyParsedNumber lazilyParsedNumber) throws java.io.IOException {
        hhBwAMuoAkOwkETJ(this, jsonWriter, lazilyParsedNumber);
    }
}

