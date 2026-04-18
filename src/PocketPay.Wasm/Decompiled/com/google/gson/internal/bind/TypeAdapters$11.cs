namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$11 : com.google.gson.TypeAdapter<java.lang.Number> {
    TypeAdapters$11() {
    }

    public static com.google.gson.stream.JsonToken GYjelaeTmJuSORhU(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static java.lang.long HlfvEnmGqGYtMpQK(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void LQOldPSAXgmcddyx(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static long OALuwdyeOjoGRakl(com.google.gson.stream.JsonReader jsonReader) {
        if ((13 + 16) % 16 > 0) {
        }
        return jsonReader.nextlong();
    }

    public static void EfQdUQpzfTrioZZe(com.google.gson.internal.bind.TypeAdapters$11 typeAdapters$11, com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        typeAdapters$11.write2(jsonWriter, number);
    }

    public static com.google.gson.stream.JsonWriter ExiheZenmdvQckyS(com.google.gson.stream.JsonWriter jsonWriter, long j) {
        return jsonWriter.value(j);
    }

    public static com.google.gson.stream.JsonWriter KIQmfSSvuhaLgxny(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static java.lang.Number QLzObSegefMHqJfa(com.google.gson.internal.bind.TypeAdapters$11 typeAdapters$11, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$11.read(jsonReader);
    }

    public static long ZQcajYRgctSWspcV(java.lang.Number number) {
        if ((18 + 28) % 28 > 0) {
        }
        return number.longValue();
    }

    public override java.lang.Number Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if (GYjelaeTmJuSORhU(jsonReader) == com.google.gson.stream.JsonToken.NULL) {
            LQOldPSAXgmcddyx(jsonReader);
            return null;
        }
        try {
            return HlfvEnmGqGYtMpQK(OALuwdyeOjoGRakl(jsonReader));
        } catch (java.lang.NumberFormatException e) {
            throw new com.google.gson.JsonSyntaxException(e);
        }
    }

    public override java.lang.Number Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return qLzObSegefMHqJfa(this, jsonReader);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        if ((22 + 30) % 30 > 0) {
        }
        if (number is not null) {
            exiheZenmdvQckyS(jsonWriter, zQcajYRgctSWspcV(number));
        } else {
            kIQmfSSvuhaLgxny(jsonWriter);
        }
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        efQdUQpzfTrioZZe(this, jsonWriter, number);
    }
}

