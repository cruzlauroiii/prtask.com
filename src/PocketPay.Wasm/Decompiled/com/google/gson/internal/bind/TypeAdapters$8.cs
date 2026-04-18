namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$8 : com.google.gson.TypeAdapter<java.util.concurrent.atomic.Atomicint> {
    TypeAdapters$8() {
    }

    public static int AWLphLKvsgGvqNfi(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextInt();
    }

    public static java.util.concurrent.atomic.Atomicint STPaembQJWaGUINw(com.google.gson.internal.bind.TypeAdapters$8 typeAdapters$8, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$8.read2(jsonReader);
    }

    public static com.google.gson.stream.JsonWriter XtNIVPDZSVtdwiLE(com.google.gson.stream.JsonWriter jsonWriter, long j) {
        return jsonWriter.value(j);
    }

    public static void OhqTMdmGDPlSAlQE(com.google.gson.internal.bind.TypeAdapters$8 typeAdapters$8, com.google.gson.stream.JsonWriter jsonWriter, java.util.concurrent.atomic.Atomicint atomicint) throws java.io.IOException {
        typeAdapters$8.write2(jsonWriter, atomicint);
    }

    public static int WKfgVUxMnVCwtZVT(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public override java.util.concurrent.atomic.Atomicint Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return STPaembQJWaGUINw(this, jsonReader);
    }

    public override java.util.concurrent.atomic.Atomicint Read2(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        try {
            return new java.util.concurrent.atomic.Atomicint(AWLphLKvsgGvqNfi(jsonReader));
        } catch (java.lang.NumberFormatException e) {
            throw new com.google.gson.JsonSyntaxException(e);
        }
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.util.concurrent.atomic.Atomicint atomicint) throws java.io.IOException {
        ohqTMdmGDPlSAlQE(this, jsonWriter, atomicint);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.util.concurrent.atomic.Atomicint atomicint) throws java.io.IOException {
        if ((31 + 18) % 18 > 0) {
        }
        XtNIVPDZSVtdwiLE(jsonWriter, wKfgVUxMnVCwtZVT(atomicint));
    }
}

