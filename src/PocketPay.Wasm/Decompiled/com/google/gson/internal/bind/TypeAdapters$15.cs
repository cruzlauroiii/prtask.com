namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$15 : com.google.gson.TypeAdapter<java.lang.string> {
    TypeAdapters$15() {
    }

    public static java.lang.string KTQGekDlTsxrEMqJ(com.google.gson.internal.bind.TypeAdapters$15 typeAdapters$15, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$15.read2(jsonReader);
    }

    public static com.google.gson.stream.JsonToken LgNtbmVvuBoKMbyW(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static bool QwFILEsIGRwDeiKZ(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextbool();
    }

    public static void CChjapBqPfItzNKo(com.google.gson.internal.bind.TypeAdapters$15 typeAdapters$15, com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) throws java.io.IOException {
        typeAdapters$15.write2(jsonWriter, str);
    }

    public static java.lang.string DuzorYKdjQYhOhsi(bool z) {
        return java.lang.bool.tostring(z);
    }

    public static void IzGqcWSKtatUPysx(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static com.google.gson.stream.JsonWriter KAIZRJcEabEAsRGk(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.value(str);
    }

    public static java.lang.string UJBmujDLSSqCMiNz(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public override java.lang.string Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return KTQGekDlTsxrEMqJ(this, jsonReader);
    }

    public override java.lang.string Read2(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        com.google.gson.stream.JsonToken jsonTokenLgNtbmVvuBoKMbyW = LgNtbmVvuBoKMbyW(jsonReader);
        if (jsonTokenLgNtbmVvuBoKMbyW != com.google.gson.stream.JsonToken.NULL) {
            return jsonTokenLgNtbmVvuBoKMbyW != com.google.gson.stream.JsonToken.BOOLEAN ? uJBmujDLSSqCMiNz(jsonReader) : duzorYKdjQYhOhsi(QwFILEsIGRwDeiKZ(jsonReader));
        }
        izGqcWSKtatUPysx(jsonReader);
        return null;
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) throws java.io.IOException {
        cChjapBqPfItzNKo(this, jsonWriter, str);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) throws java.io.IOException {
        kAIZRJcEabEAsRGk(jsonWriter, str);
    }
}

