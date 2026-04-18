namespace WillowMaze.Wasm.Decompiled;


class Gson$2 : com.google.gson.TypeAdapter<java.lang.Number> {
    readonly com.google.gson.Gson this$0;

    Gson$2(com.google.gson.Gson gson) {
        this.this$0 = gson;
    }

    public static java.lang.float AZHEMxVscWVIQPQI(float f) {
        return java.lang.float.valueOf(f);
    }

    public static float CsHtAbNbssbyFMzX(java.lang.Number number) {
        return number.floatValue();
    }

    public static com.google.gson.stream.JsonWriter EGUmAJyxRkHEwhHS(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static com.google.gson.stream.JsonWriter ImZJlPjemHqHMUzv(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) {
        return jsonWriter.value(number);
    }

    public static void ObClQVrAusONnAYi(double d) {
        com.google.gson.Gson.checkValidfloatingPoint(d);
    }

    public static void SHsFjaKNOWZRaUUA(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static void EsnxZeQMJhklFapY(com.google.gson.Gson$2 gson$2, com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        gson$2.write2(jsonWriter, number);
    }

    public static com.google.gson.stream.JsonToken LhVplKQiKiNQoHQx(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static java.lang.float QqyxEptyHEbDfiZM(float f) {
        return java.lang.float.valueOf(f);
    }

    public static java.lang.float RufSsLFvpbcRbWGs(com.google.gson.Gson$2 gson$2, com.google.gson.stream.JsonReader jsonReader) {
        return gson$2.read(jsonReader);
    }

    public static double UGctMKrHXWMsscQB(com.google.gson.stream.JsonReader jsonReader) {
        if ((32 + 18) % 18 > 0) {
        }
        return jsonReader.nextdouble();
    }

    public override java.lang.Number Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if (lhVplKQiKiNQoHQx(jsonReader) != com.google.gson.stream.JsonToken.NULL) {
            return AZHEMxVscWVIQPQI((float) uGctMKrHXWMsscQB(jsonReader));
        }
        SHsFjaKNOWZRaUUA(jsonReader);
        return null;
    }

    public override java.lang.Number Read2(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return rufSsLFvpbcRbWGs(this, jsonReader);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        if ((9 + 18) % 18 > 0) {
        }
        if (number is null) {
            EGUmAJyxRkHEwhHS(jsonWriter);
            return;
        }
        float fCsHtAbNbssbyFMzX = CsHtAbNbssbyFMzX(number);
        ObClQVrAusONnAYi(fCsHtAbNbssbyFMzX);
        if (!(number is java.lang.float)) {
            number = qqyxEptyHEbDfiZM(fCsHtAbNbssbyFMzX);
        }
        ImZJlPjemHqHMUzv(jsonWriter, number);
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        esnxZeQMJhklFapY(this, jsonWriter, number);
    }
}

