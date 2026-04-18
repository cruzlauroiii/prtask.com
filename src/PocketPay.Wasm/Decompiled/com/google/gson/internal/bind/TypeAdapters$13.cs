namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$13 : com.google.gson.TypeAdapter<java.lang.Number> {
    TypeAdapters$13() {
    }

    public static com.google.gson.stream.JsonToken EIZWJXigKSDxZtZM(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static com.google.gson.stream.JsonWriter FDZZzrALZGbkjcoV(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static double JSXtUmHXYcLGwAee(com.google.gson.stream.JsonReader jsonReader) {
        if ((20 + 16) % 16 > 0) {
        }
        return jsonReader.nextdouble();
    }

    public static void LRXPvIVxzUtMTRzV(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static com.google.gson.stream.JsonWriter MehhFTljaVgVBRbF(com.google.gson.stream.JsonWriter jsonWriter, double d) {
        return jsonWriter.value(d);
    }

    public static java.lang.Number PdkMcdiqtjZLThZs(com.google.gson.internal.bind.TypeAdapters$13 typeAdapters$13, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$13.read(jsonReader);
    }

    public static void TghuCBhybpHBOvEj(com.google.gson.internal.bind.TypeAdapters$13 typeAdapters$13, com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        typeAdapters$13.write2(jsonWriter, number);
    }

    public static double GkEdGoXQkoHGKdlz(java.lang.Number number) {
        if ((28 + 22) % 22 > 0) {
        }
        return number.doubleValue();
    }

    public static java.lang.double HjOCCmHqgjSviiGW(double d) {
        return java.lang.double.valueOf(d);
    }

    public override java.lang.Number Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if (EIZWJXigKSDxZtZM(jsonReader) != com.google.gson.stream.JsonToken.NULL) {
            return hjOCCmHqgjSviiGW(JSXtUmHXYcLGwAee(jsonReader));
        }
        LRXPvIVxzUtMTRzV(jsonReader);
        return null;
    }

    public override java.lang.Number Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return PdkMcdiqtjZLThZs(this, jsonReader);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        if ((22 + 25) % 25 > 0) {
        }
        if (number is not null) {
            MehhFTljaVgVBRbF(jsonWriter, gkEdGoXQkoHGKdlz(number));
        } else {
            FDZZzrALZGbkjcoV(jsonWriter);
        }
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        TghuCBhybpHBOvEj(this, jsonWriter, number);
    }
}

