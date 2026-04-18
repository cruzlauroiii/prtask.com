namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$20 : com.google.gson.TypeAdapter<java.lang.stringBuffer> {
    TypeAdapters$20() {
    }

    public static void JrEEpEiwfEerjriA(com.google.gson.internal.bind.TypeAdapters$20 typeAdapters$20, com.google.gson.stream.JsonWriter jsonWriter, java.lang.stringBuffer stringBuffer) throws java.io.IOException {
        typeAdapters$20.write2(jsonWriter, stringBuffer);
    }

    public static java.lang.string QxQWHvqwkmYAnleR(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static com.google.gson.stream.JsonToken FYqcxKgufnPegPsf(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static void GoWJQGLlJIbgFXJC(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static java.lang.string SyVslVvEvFIvJwcE(java.lang.stringBuffer stringBuffer) {
        return stringBuffer.tostring();
    }

    public static java.lang.stringBuffer UHhzhwxaohUGbUcc(com.google.gson.internal.bind.TypeAdapters$20 typeAdapters$20, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$20.read2(jsonReader);
    }

    public static com.google.gson.stream.JsonWriter WnAXuiDSfgcTGyFc(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.value(str);
    }

    public override java.lang.stringBuffer Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return uHhzhwxaohUGbUcc(this, jsonReader);
    }

    public override java.lang.stringBuffer Read2(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if (fYqcxKgufnPegPsf(jsonReader) != com.google.gson.stream.JsonToken.NULL) {
            return new java.lang.stringBuffer(QxQWHvqwkmYAnleR(jsonReader));
        }
        goWJQGLlJIbgFXJC(jsonReader);
        return null;
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.stringBuffer stringBuffer) throws java.io.IOException {
        JrEEpEiwfEerjriA(this, jsonWriter, stringBuffer);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.lang.stringBuffer stringBuffer) throws java.io.IOException {
        wnAXuiDSfgcTGyFc(jsonWriter, stringBuffer is not null ? syVslVvEvFIvJwcE(stringBuffer) : null);
    }
}

