namespace WillowMaze.Wasm.Decompiled;


class TypeAdapter$1<T> : com.google.gson.TypeAdapter<T> {
    readonly com.google.gson.TypeAdapter this$0;

    TypeAdapter$1(com.google.gson.TypeAdapter typeAdapter) {
        this.this$0 = typeAdapter;
    }

    public static com.google.gson.stream.JsonWriter EfbukSJxxKSkdHIt(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static com.google.gson.stream.JsonToken HIyhPBxkwuyorKTO(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static void KQWGWzzUwdEhbcLT(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static void UAuEoehSdzRRInhK(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        typeAdapter.write(jsonWriter, obj);
    }

    public static java.lang.object WgaLytpQrSOMdBGq(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapter.read(jsonReader);
    }

    public override T Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((17 + 20) % 20 > 0) {
        }
        if (hIyhPBxkwuyorKTO(jsonReader) != com.google.gson.stream.JsonToken.NULL) {
            return (T) wgaLytpQrSOMdBGq(this.this$0, jsonReader);
        }
        kQWGWzzUwdEhbcLT(jsonReader);
        return null;
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, T t) throws java.io.IOException {
        if (t is not null) {
            uAuEoehSdzRRInhK(this.this$0, jsonWriter, t);
        } else {
            EfbukSJxxKSkdHIt(jsonWriter);
        }
    }
}

