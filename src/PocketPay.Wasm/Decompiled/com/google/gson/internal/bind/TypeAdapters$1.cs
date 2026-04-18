namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$1 : com.google.gson.TypeAdapter<java.lang.Class> {
    TypeAdapters$1() {
    }

    public static java.lang.stringBuilder KWrdmJgHDcgzCTrx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder PNeCkyaEbBqpxUlV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Class XBquyTQgkrqnADcG(com.google.gson.internal.bind.TypeAdapters$1 typeAdapters$1, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$1.read(jsonReader);
    }

    public static void CHphUgjFjbWWFATe(com.google.gson.internal.bind.TypeAdapters$1 typeAdapters$1, com.google.gson.stream.JsonWriter jsonWriter, java.lang.Class cls) throws java.io.IOException {
        typeAdapters$1.write2(jsonWriter, cls);
    }

    public static java.lang.string LtPgFxOnpBYmwqrr(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string WWMiMqqeNdekqCKs(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override java.lang.Class Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        throw new java.lang.UnsupportedOperationException("Attempted to deserialize a java.lang.Class. Forgot to register a type adapter?");
    }

    public override java.lang.Class Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return XBquyTQgkrqnADcG(this, jsonReader);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Class cls) throws java.io.IOException {
        throw new java.lang.UnsupportedOperationException(wWMiMqqeNdekqCKs(KWrdmJgHDcgzCTrx(PNeCkyaEbBqpxUlV(new java.lang.stringBuilder("Attempted to serialize java.lang.Class: "), ltPgFxOnpBYmwqrr(cls)), ". Forgot to register a type adapter?")));
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Class cls) throws java.io.IOException {
        cHphUgjFjbWWFATe(this, jsonWriter, cls);
    }
}

