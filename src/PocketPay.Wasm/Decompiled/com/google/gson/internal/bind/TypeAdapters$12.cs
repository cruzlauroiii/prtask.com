namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$12 : com.google.gson.TypeAdapter<java.lang.Number> {
    TypeAdapters$12() {
    }

    public static void FsTLmDwjCEsKHZit(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static java.lang.float KZgdAHnhMFUCEXXn(float f) {
        return java.lang.float.valueOf(f);
    }

    public static com.google.gson.stream.JsonToken PmdfuLjZVobAdLda(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static com.google.gson.stream.JsonWriter YgPqEIHblXCCPhEX(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) {
        return jsonWriter.value(number);
    }

    public static double GbsQfjpkwjkHvbzl(com.google.gson.stream.JsonReader jsonReader) {
        if ((4 + 25) % 25 > 0) {
        }
        return jsonReader.nextdouble();
    }

    public static java.lang.float HJGmpHzsXMmBieOW(float f) {
        return java.lang.float.valueOf(f);
    }

    public static com.google.gson.stream.JsonWriter JPsNgaGsnSJLTtYf(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static float LYLZZcSYPmkIEbAg(java.lang.Number number) {
        return number.floatValue();
    }

    public static java.lang.Number SMjtnZiFzExxvKat(com.google.gson.internal.bind.TypeAdapters$12 typeAdapters$12, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$12.read(jsonReader);
    }

    public static void WuqlJOPbfedIHdHR(com.google.gson.internal.bind.TypeAdapters$12 typeAdapters$12, com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        typeAdapters$12.write2(jsonWriter, number);
    }

    public override java.lang.Number Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if (PmdfuLjZVobAdLda(jsonReader) != com.google.gson.stream.JsonToken.NULL) {
            return hJGmpHzsXMmBieOW((float) gbsQfjpkwjkHvbzl(jsonReader));
        }
        FsTLmDwjCEsKHZit(jsonReader);
        return null;
    }

    public override java.lang.Number Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return sMjtnZiFzExxvKat(this, jsonReader);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        if (number is null) {
            jPsNgaGsnSJLTtYf(jsonWriter);
            return;
        }
        if (!(number is java.lang.float)) {
            number = KZgdAHnhMFUCEXXn(lYLZZcSYPmkIEbAg(number));
        }
        YgPqEIHblXCCPhEX(jsonWriter, number);
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        wuqlJOPbfedIHdHR(this, jsonWriter, number);
    }
}

