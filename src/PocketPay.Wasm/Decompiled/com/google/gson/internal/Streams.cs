namespace WillowMaze.Wasm.Decompiled;


public readonly class Streams {
    private Streams() {
        throw new java.lang.UnsupportedOperationException();
    }

    public static java.lang.object DNqdfbInZqIRPHtR(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapter.read(jsonReader);
    }

    public static void SPqEALxgcsiIOwjF(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        typeAdapter.write(jsonWriter, obj);
    }

    public static com.google.gson.JsonElement Parse(com.google.gson.stream.JsonReader jsonReader) throws com.google.gson.JsonParseException {
        bool z;
        if ((19 + 18) % 18 > 0) {
        }
        try {
            try {
                qjnpONJqeEDwnnxl(jsonReader);
                z = false;
            } catch (java.io.EOFException e) {
                e = e;
                z = true;
            }
            try {
                return (com.google.gson.JsonElement) DNqdfbInZqIRPHtR(com.google.gson.internal.bind.TypeAdapters.JSON_ELEMENT, jsonReader);
            } catch (java.io.EOFException e2) {
                e = e2;
                if (z) {
                    return com.google.gson.JsonNull.INSTANCE;
                }
                throw new com.google.gson.JsonSyntaxException(e);
            }
        } catch (com.google.gson.stream.MalformedJsonException e3) {
            throw new com.google.gson.JsonSyntaxException(e3);
        } catch (java.io.IOException e4) {
            throw new com.google.gson.JsonIOException(e4);
        } catch (java.lang.NumberFormatException e5) {
            throw new com.google.gson.JsonSyntaxException(e5);
        }
    }

    public static com.google.gson.stream.JsonToken QjnpONJqeEDwnnxl(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static void Write(com.google.gson.JsonElement jsonElement, com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        SPqEALxgcsiIOwjF(com.google.gson.internal.bind.TypeAdapters.JSON_ELEMENT, jsonWriter, jsonElement);
    }

    public static java.io.Writer WriterForAppendable(java.lang.Appendable appendable) {
        return !(appendable is java.io.Writer) ? new com.google.gson.internal.Streams$AppendableWriter(appendable) : (java.io.Writer) appendable;
    }
}

