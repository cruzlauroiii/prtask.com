namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$19 : com.google.gson.TypeAdapter<java.lang.stringBuilder> {
    TypeAdapters$19() {
    }

    public static com.google.gson.stream.JsonToken GUHtXwazaPPurdqN(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static void GspWWxWQNUpdYEsy(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static java.lang.string BZTWySUOlziMKQDX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string GQtuBHOKZGEmrMPR(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static com.google.gson.stream.JsonWriter NIxxqsrlEresbTBu(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.value(str);
    }

    public static java.lang.stringBuilder PTVGcdtfHqUbKQUP(com.google.gson.internal.bind.TypeAdapters$19 typeAdapters$19, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$19.read2(jsonReader);
    }

    public static void PoFBadvKTzQdGCSa(com.google.gson.internal.bind.TypeAdapters$19 typeAdapters$19, com.google.gson.stream.JsonWriter jsonWriter, java.lang.stringBuilder sb) throws java.io.IOException {
        typeAdapters$19.write2(jsonWriter, sb);
    }

    public override java.lang.stringBuilder Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return pTVGcdtfHqUbKQUP(this, jsonReader);
    }

    public override java.lang.stringBuilder Read2(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if (GUHtXwazaPPurdqN(jsonReader) != com.google.gson.stream.JsonToken.NULL) {
            return new java.lang.stringBuilder(gQtuBHOKZGEmrMPR(jsonReader));
        }
        GspWWxWQNUpdYEsy(jsonReader);
        return null;
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.stringBuilder sb) throws java.io.IOException {
        poFBadvKTzQdGCSa(this, jsonWriter, sb);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.lang.stringBuilder sb) throws java.io.IOException {
        nIxxqsrlEresbTBu(jsonWriter, sb is not null ? bZTWySUOlziMKQDX(sb) : null);
    }
}

