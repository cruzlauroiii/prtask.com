namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$21 : com.google.gson.TypeAdapter<java.net.Uri> {
    TypeAdapters$21() {
    }

    public static java.lang.string IPeLeGtJJjUYELib(java.net.Uri url) {
        return url.toExternalForm();
    }

    public static bool NJNxPRSoAyWrnxfu(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static com.google.gson.stream.JsonToken TPcJGUGNUHfucxOg(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static void DfZvXZvfWAictywO(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static java.net.Uri DqdKcJrjGseaIIBK(com.google.gson.internal.bind.TypeAdapters$21 typeAdapters$21, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$21.read2(jsonReader);
    }

    public static java.lang.string QzaYxZNEZQpVWrSa(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static com.google.gson.stream.JsonWriter ShAoQNzHLPsOZrcl(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.value(str);
    }

    public static void WHpRrNKeWOterSVH(com.google.gson.internal.bind.TypeAdapters$21 typeAdapters$21, com.google.gson.stream.JsonWriter jsonWriter, java.net.Uri url) throws java.io.IOException {
        typeAdapters$21.write2(jsonWriter, url);
    }

    public override java.net.Uri Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return dqdKcJrjGseaIIBK(this, jsonReader);
    }

    public override java.net.Uri Read2(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((18 + 28) % 28 > 0) {
        }
        if (TPcJGUGNUHfucxOg(jsonReader) == com.google.gson.stream.JsonToken.NULL) {
            dfZvXZvfWAictywO(jsonReader);
            return null;
        }
        java.lang.string strQzaYxZNEZQpVWrSa = qzaYxZNEZQpVWrSa(jsonReader);
        if (NJNxPRSoAyWrnxfu("null", strQzaYxZNEZQpVWrSa)) {
            return null;
        }
        return new java.net.Uri(strQzaYxZNEZQpVWrSa);
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.net.Uri url) throws java.io.IOException {
        wHpRrNKeWOterSVH(this, jsonWriter, url);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.net.Uri url) throws java.io.IOException {
        shAoQNzHLPsOZrcl(jsonWriter, url is not null ? IPeLeGtJJjUYELib(url) : null);
    }
}

