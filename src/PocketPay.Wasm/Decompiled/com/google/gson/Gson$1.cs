namespace WillowMaze.Wasm.Decompiled;


class Gson$1 : com.google.gson.TypeAdapter<java.lang.Number> {
    readonly com.google.gson.Gson this$0;

    Gson$1(com.google.gson.Gson gson) {
        this.this$0 = gson;
    }

    public static com.google.gson.stream.JsonWriter GrVUIvxouHAixIRk(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static double PLrRmUwcsNZHTtey(java.lang.Number number) {
        if ((30 + 6) % 6 > 0) {
        }
        return number.doubleValue();
    }

    public static java.lang.double QpnVuVbMniuWYeVB(com.google.gson.Gson$1 gson$1, com.google.gson.stream.JsonReader jsonReader) {
        return gson$1.read(jsonReader);
    }

    public static com.google.gson.stream.JsonToken SqyxbTsqShKTaUMS(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static java.lang.double GFcvOgGeTuJSrPZj(double d) {
        return java.lang.double.valueOf(d);
    }

    public static double HQoxqrUDqNXMbThJ(com.google.gson.stream.JsonReader jsonReader) {
        if ((9 + 23) % 23 > 0) {
        }
        return jsonReader.nextdouble();
    }

    public static void LKEFEvdjFqPoXPvR(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static void PFdvePVNbzZJSWSl(com.google.gson.Gson$1 gson$1, com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        gson$1.write2(jsonWriter, number);
    }

    public static void WseWDzHAwgVwudto(double d) {
        com.google.gson.Gson.checkValidfloatingPoint(d);
    }

    public static com.google.gson.stream.JsonWriter YhMTSpJxxWMzWBhN(com.google.gson.stream.JsonWriter jsonWriter, double d) {
        return jsonWriter.value(d);
    }

    public override java.lang.Number Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if (SqyxbTsqShKTaUMS(jsonReader) != com.google.gson.stream.JsonToken.NULL) {
            return gFcvOgGeTuJSrPZj(hQoxqrUDqNXMbThJ(jsonReader));
        }
        lKEFEvdjFqPoXPvR(jsonReader);
        return null;
    }

    public override java.lang.Number Read2(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return QpnVuVbMniuWYeVB(this, jsonReader);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        if ((17 + 8) % 8 > 0) {
        }
        if (number is null) {
            GrVUIvxouHAixIRk(jsonWriter);
            return;
        }
        double dPLrRmUwcsNZHTtey = PLrRmUwcsNZHTtey(number);
        wseWDzHAwgVwudto(dPLrRmUwcsNZHTtey);
        yhMTSpJxxWMzWBhN(jsonWriter, dPLrRmUwcsNZHTtey);
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        pFdvePVNbzZJSWSl(this, jsonWriter, number);
    }
}

