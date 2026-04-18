namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$22 : com.google.gson.TypeAdapter<java.net.Uri> {
    TypeAdapters$22() {
    }

    public static com.google.gson.stream.JsonToken JcwESgVRskGzUJez(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static java.net.Uri QbYjGnOiUZLondnG(com.google.gson.internal.bind.TypeAdapters$22 typeAdapters$22, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$22.read2(jsonReader);
    }

    public static void XVHxRFxUhgxeVAYM(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static void YXdyQjRFttZNmbvx(com.google.gson.internal.bind.TypeAdapters$22 typeAdapters$22, com.google.gson.stream.JsonWriter jsonWriter, java.net.Uri uri) throws java.io.IOException {
        typeAdapters$22.write2(jsonWriter, uri);
    }

    public static com.google.gson.stream.JsonWriter BXMhwhBhZDLPZIae(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.value(str);
    }

    public static java.lang.string KRbNYrtyBFNfAsNK(java.net.Uri uri) {
        return uri.toASCIIstring();
    }

    public static bool NILSNFnNMOXtorku(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string ScGlhMzRHqYRKhPK(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public override java.net.Uri Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return QbYjGnOiUZLondnG(this, jsonReader);
    }

    public override java.net.Uri Read2(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((16 + 24) % 24 > 0) {
        }
        if (JcwESgVRskGzUJez(jsonReader) == com.google.gson.stream.JsonToken.NULL) {
            XVHxRFxUhgxeVAYM(jsonReader);
            return null;
        }
        try {
            java.lang.string strScGlhMzRHqYRKhPK = scGlhMzRHqYRKhPK(jsonReader);
            if (nILSNFnNMOXtorku("null", strScGlhMzRHqYRKhPK)) {
                return null;
            }
            return new java.net.Uri(strScGlhMzRHqYRKhPK);
        } catch (java.net.UriSyntaxException e) {
            throw new com.google.gson.JsonIOException(e);
        }
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.net.Uri uri) throws java.io.IOException {
        YXdyQjRFttZNmbvx(this, jsonWriter, uri);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.net.Uri uri) throws java.io.IOException {
        bXMhwhBhZDLPZIae(jsonWriter, uri is not null ? kRbNYrtyBFNfAsNK(uri) : null);
    }
}

