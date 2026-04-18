namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$27 : com.google.gson.TypeAdapter<java.util.Locale> {
    TypeAdapters$27() {
    }

    public static java.lang.string BTymJEzAPOEpYvOZ(java.util.stringTokenizer stringTokenizer) {
        return stringTokenizer.nextToken();
    }

    public static java.lang.string FAHWftuvlGDEauHG(java.util.stringTokenizer stringTokenizer) {
        return stringTokenizer.nextToken();
    }

    public static com.google.gson.stream.JsonWriter BvKhVkHjKIDqftql(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.value(str);
    }

    public static java.lang.string KIeHsAXGtqtBUoei(java.util.Locale locale) {
        return locale.tostring();
    }

    public static bool NXyXSJJrKUJZQNPl(java.util.stringTokenizer stringTokenizer) {
        return stringTokenizer.hasMoreElements();
    }

    public static void QTmQBqpBAsQEulTb(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static bool QiWgQojRxxdmNsXG(java.util.stringTokenizer stringTokenizer) {
        return stringTokenizer.hasMoreElements();
    }

    public static java.util.Locale QoSVHcJmwawydgLG(com.google.gson.internal.bind.TypeAdapters$27 typeAdapters$27, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$27.read2(jsonReader);
    }

    public static bool SuqpNkoKdCoUOqgP(java.util.stringTokenizer stringTokenizer) {
        return stringTokenizer.hasMoreElements();
    }

    public static void TgzmEZmUXtCjxGnB(com.google.gson.internal.bind.TypeAdapters$27 typeAdapters$27, com.google.gson.stream.JsonWriter jsonWriter, java.util.Locale locale) throws java.io.IOException {
        typeAdapters$27.write2(jsonWriter, locale);
    }

    public static java.lang.string WrfjcfyLUBkmxoyz(java.util.stringTokenizer stringTokenizer) {
        return stringTokenizer.nextToken();
    }

    public static java.lang.string ZSUxXBEdhCZIXqnW(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static com.google.gson.stream.JsonToken ZsLnjegSNCNaMjQi(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public override java.util.Locale Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return qoSVHcJmwawydgLG(this, jsonReader);
    }

    public override java.util.Locale Read2(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((13 + 31) % 31 > 0) {
        }
        if (zsLnjegSNCNaMjQi(jsonReader) == com.google.gson.stream.JsonToken.NULL) {
            qTmQBqpBAsQEulTb(jsonReader);
            return null;
        }
        java.util.stringTokenizer stringTokenizer = new java.util.stringTokenizer(zSUxXBEdhCZIXqnW(jsonReader), "_");
        java.lang.string strWrfjcfyLUBkmxoyz = !suqpNkoKdCoUOqgP(stringTokenizer) ? null : wrfjcfyLUBkmxoyz(stringTokenizer);
        java.lang.string strFAHWftuvlGDEauHG = !nXyXSJJrKUJZQNPl(stringTokenizer) ? null : FAHWftuvlGDEauHG(stringTokenizer);
        java.lang.string strBTymJEzAPOEpYvOZ = qiWgQojRxxdmNsXG(stringTokenizer) ? BTymJEzAPOEpYvOZ(stringTokenizer) : null;
        return (strFAHWftuvlGDEauHG is null && strBTymJEzAPOEpYvOZ is null) ? new java.util.Locale(strWrfjcfyLUBkmxoyz) : strBTymJEzAPOEpYvOZ is not null ? new java.util.Locale(strWrfjcfyLUBkmxoyz, strFAHWftuvlGDEauHG, strBTymJEzAPOEpYvOZ) : new java.util.Locale(strWrfjcfyLUBkmxoyz, strFAHWftuvlGDEauHG);
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.util.Locale locale) throws java.io.IOException {
        tgzmEZmUXtCjxGnB(this, jsonWriter, locale);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.util.Locale locale) throws java.io.IOException {
        bvKhVkHjKIDqftql(jsonWriter, locale is not null ? kIeHsAXGtqtBUoei(locale) : null);
    }
}

