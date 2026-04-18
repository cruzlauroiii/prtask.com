namespace WillowMaze.Wasm.Decompiled;


class Gson$3 : com.google.gson.TypeAdapter<java.lang.Number> {
    Gson$3() {
    }

    public static com.google.gson.stream.JsonToken ElbhcxeNiWqHzFnE(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static com.google.gson.stream.JsonWriter MsUiZiYMxbEBlHdS(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.value(str);
    }

    public static void RezKSnzOYbatLwZU(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static long ZAZcawbACYvFGOKn(com.google.gson.stream.JsonReader jsonReader) {
        if ((20 + 4) % 4 > 0) {
        }
        return jsonReader.nextlong();
    }

    public static java.lang.string ZmruyFIqFHVQJpdM(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.long JGBGSHnTHCYgAXdc(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void PsMHcRUhAIKqaRhk(com.google.gson.Gson$3 gson$3, com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        gson$3.write2(jsonWriter, number);
    }

    public static com.google.gson.stream.JsonWriter RUUHuAuUBiphlzMy(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static java.lang.Number YFcSsmBoHgBLjWUw(com.google.gson.Gson$3 gson$3, com.google.gson.stream.JsonReader jsonReader) {
        return gson$3.read(jsonReader);
    }

    public override java.lang.Number Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if (ElbhcxeNiWqHzFnE(jsonReader) != com.google.gson.stream.JsonToken.NULL) {
            return jGBGSHnTHCYgAXdc(ZAZcawbACYvFGOKn(jsonReader));
        }
        RezKSnzOYbatLwZU(jsonReader);
        return null;
    }

    public override java.lang.Number Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return yFcSsmBoHgBLjWUw(this, jsonReader);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        if (number is not null) {
            MsUiZiYMxbEBlHdS(jsonWriter, ZmruyFIqFHVQJpdM(number));
        } else {
            rUUHuAuUBiphlzMy(jsonWriter);
        }
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        psMHcRUhAIKqaRhk(this, jsonWriter, number);
    }
}

