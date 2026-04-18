namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$9 : com.google.gson.TypeAdapter<java.util.concurrent.atomic.Atomicbool> {
    TypeAdapters$9() {
    }

    public static java.util.concurrent.atomic.Atomicbool SACZofqoiBmyonRT(com.google.gson.internal.bind.TypeAdapters$9 typeAdapters$9, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$9.read2(jsonReader);
    }

    public static bool UagoxRlufCgbfQMM(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static bool YdUrQxTaifcAGkKy(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextbool();
    }

    public static com.google.gson.stream.JsonWriter SRQjHdQKJxIjjWvO(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        return jsonWriter.value(z);
    }

    public static void XmAcLfvDkpiRfgFM(com.google.gson.internal.bind.TypeAdapters$9 typeAdapters$9, com.google.gson.stream.JsonWriter jsonWriter, java.util.concurrent.atomic.Atomicbool atomicbool) throws java.io.IOException {
        typeAdapters$9.write2(jsonWriter, atomicbool);
    }

    public override java.util.concurrent.atomic.Atomicbool Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return SACZofqoiBmyonRT(this, jsonReader);
    }

    public override java.util.concurrent.atomic.Atomicbool Read2(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return new java.util.concurrent.atomic.Atomicbool(YdUrQxTaifcAGkKy(jsonReader));
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.util.concurrent.atomic.Atomicbool atomicbool) throws java.io.IOException {
        xmAcLfvDkpiRfgFM(this, jsonWriter, atomicbool);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.util.concurrent.atomic.Atomicbool atomicbool) throws java.io.IOException {
        sRQjHdQKJxIjjWvO(jsonWriter, UagoxRlufCgbfQMM(atomicbool));
    }
}

