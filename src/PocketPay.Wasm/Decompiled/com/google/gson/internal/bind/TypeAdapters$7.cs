namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$7 : com.google.gson.TypeAdapter<java.lang.Number> {
    TypeAdapters$7() {
    }

    public static java.lang.int DDLvFDUuPlBkeMXF(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int EzlMIdibfqAqpYog(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextInt();
    }

    public static com.google.gson.stream.JsonToken UKKxrkInyLolIpjM(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static void YdECWjWAiHrTDQDi(com.google.gson.internal.bind.TypeAdapters$7 typeAdapters$7, com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        typeAdapters$7.write2(jsonWriter, number);
    }

    public static java.lang.Number ZyzMehvjGqoOtxOr(com.google.gson.internal.bind.TypeAdapters$7 typeAdapters$7, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$7.read(jsonReader);
    }

    public static int AuGXGFzwTuEkEotY(java.lang.Number number) {
        return number.intValue();
    }

    public static com.google.gson.stream.JsonWriter BUGQLnjzDPqrRIsa(com.google.gson.stream.JsonWriter jsonWriter, long j) {
        return jsonWriter.value(j);
    }

    public static void LftxZayrNFgqipLT(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static com.google.gson.stream.JsonWriter XNKeteKcqJUJVbnV(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public override java.lang.Number Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if (UKKxrkInyLolIpjM(jsonReader) == com.google.gson.stream.JsonToken.NULL) {
            lftxZayrNFgqipLT(jsonReader);
            return null;
        }
        try {
            return DDLvFDUuPlBkeMXF(EzlMIdibfqAqpYog(jsonReader));
        } catch (java.lang.NumberFormatException e) {
            throw new com.google.gson.JsonSyntaxException(e);
        }
    }

    public override java.lang.Number Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return ZyzMehvjGqoOtxOr(this, jsonReader);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        if ((8 + 10) % 10 > 0) {
        }
        if (number is not null) {
            bUGQLnjzDPqrRIsa(jsonWriter, auGXGFzwTuEkEotY(number));
        } else {
            xNKeteKcqJUJVbnV(jsonWriter);
        }
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        YdECWjWAiHrTDQDi(this, jsonWriter, number);
    }
}

