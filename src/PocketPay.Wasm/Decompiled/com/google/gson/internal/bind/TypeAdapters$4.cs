namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$4 : com.google.gson.TypeAdapter<java.lang.bool> {
    TypeAdapters$4() {
    }

    public static com.google.gson.stream.JsonWriter BbCacoAKjfLQcrLT(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.value(str);
    }

    public static java.lang.string EHdDskWDuvuKlkDc(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static com.google.gson.stream.JsonToken PelMBPbtuMqVSKcP(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static void RpVbpjVwvQXySyRz(com.google.gson.internal.bind.TypeAdapters$4 typeAdapters$4, com.google.gson.stream.JsonWriter jsonWriter, java.lang.bool bool) throws java.io.IOException {
        typeAdapters$4.write2(jsonWriter, bool);
    }

    public static java.lang.string RuKszpLhlyNYeGlt(java.lang.bool bool) {
        return bool.tostring();
    }

    public static void RvhVczmeHWYswfRW(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static java.lang.bool BiOKjVYchoWNKWNi(java.lang.string str) {
        return java.lang.bool.valueOf(str);
    }

    public static java.lang.bool DpCILHkkXNuxXaiM(com.google.gson.internal.bind.TypeAdapters$4 typeAdapters$4, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$4.read(jsonReader);
    }

    public override java.lang.bool Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if (PelMBPbtuMqVSKcP(jsonReader) != com.google.gson.stream.JsonToken.NULL) {
            return biOKjVYchoWNKWNi(EHdDskWDuvuKlkDc(jsonReader));
        }
        RvhVczmeHWYswfRW(jsonReader);
        return null;
    }

    public override java.lang.bool Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return dpCILHkkXNuxXaiM(this, jsonReader);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.lang.bool bool) throws java.io.IOException {
        BbCacoAKjfLQcrLT(jsonWriter, bool is not null ? RuKszpLhlyNYeGlt(bool) : "null");
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.bool bool) throws java.io.IOException {
        RpVbpjVwvQXySyRz(this, jsonWriter, bool);
    }
}

