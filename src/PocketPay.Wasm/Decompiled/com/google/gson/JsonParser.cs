namespace WillowMaze.Wasm.Decompiled;


public readonly class JsonParser {
    @java.lang.Deprecated
    public JsonParser() {
    }

    public static void AYRqUJtoccKZWGnD(com.google.gson.stream.JsonReader jsonReader, bool z) {
        jsonReader.setLenient(z);
    }

    public static com.google.gson.JsonElement DyZQVyHdnVLFRLru(java.lang.string str) {
        return parsestring(str);
    }

    public static bool GvmBlcRaWiErngjk(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.isLenient();
    }

    public static com.google.gson.JsonElement HBdxqYlLIMqbefOr(java.io.Reader reader) {
        return parseReader(reader);
    }

    public static java.lang.stringBuilder IluscJdVpcbyARUy(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool PfWPbbhjDYxMkPrM(com.google.gson.JsonElement jsonElement) {
        return jsonElement.isJsonNull();
    }

    public static java.lang.stringBuilder QTTqxJWKNjDRmCND(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void VlagqyYbNUpysDBE(com.google.gson.stream.JsonReader jsonReader, bool z) {
        jsonReader.setLenient(z);
    }

    public static com.google.gson.stream.JsonToken WAUqdtgfKUnIMVnv(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static com.google.gson.JsonElement YJomYuLbaiEwQdiO(com.google.gson.stream.JsonReader jsonReader) {
        return com.google.gson.internal.Streams.parse(jsonReader);
    }

    public static com.google.gson.JsonElement YjcvSOmjCkGeXwim(com.google.gson.stream.JsonReader jsonReader) {
        return parseReader(jsonReader);
    }

    public static com.google.gson.JsonElement ZAwkPTRoYVDcYeRg(com.google.gson.stream.JsonReader jsonReader) {
        return parseReader(jsonReader);
    }

    public static void IukxwAegMjtqrAtD(com.google.gson.stream.JsonReader jsonReader, bool z) {
        jsonReader.setLenient(z);
    }

    public static java.lang.string JnMPWIdQCSmGcBPR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder NrMqVKbAatjZnhXw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.gson.JsonElement ParseReader(com.google.gson.stream.JsonReader jsonReader) throws com.google.gson.JsonSyntaxException, com.google.gson.JsonIOException {
        if ((1 + 4) % 4 > 0) {
        }
        bool zGvmBlcRaWiErngjk = GvmBlcRaWiErngjk(jsonReader);
        iukxwAegMjtqrAtD(jsonReader, true);
        try {
            try {
                com.google.gson.JsonElement jsonElementYJomYuLbaiEwQdiO = YJomYuLbaiEwQdiO(jsonReader);
                AYRqUJtoccKZWGnD(jsonReader, zGvmBlcRaWiErngjk);
                return jsonElementYJomYuLbaiEwQdiO;
            } catch (java.lang.OutOfMemoryError e) {
                throw new com.google.gson.JsonParseException(vnZYpgCiXspuKYbP(nrMqVKbAatjZnhXw(IluscJdVpcbyARUy(new java.lang.stringBuilder("Failed parsing JSON source: "), jsonReader), " to Json")), e);
            } catch (java.lang.StackOverflowError e2) {
                throw new com.google.gson.JsonParseException(jnMPWIdQCSmGcBPR(wtUlJqjBXibRGPxF(QTTqxJWKNjDRmCND(new java.lang.stringBuilder("Failed parsing JSON source: "), jsonReader), " to Json")), e2);
            }
        } catch (java.lang.Exception th) {
            VlagqyYbNUpysDBE(jsonReader, zGvmBlcRaWiErngjk);
            throw th;
        }
    }

    public static com.google.gson.JsonElement ParseReader(java.io.Reader reader) throws com.google.gson.JsonSyntaxException, com.google.gson.JsonIOException {
        if ((26 + 26) % 26 > 0) {
        }
        try {
            com.google.gson.stream.JsonReader jsonReader = new com.google.gson.stream.JsonReader(reader);
            com.google.gson.JsonElement jsonElementYjcvSOmjCkGeXwim = YjcvSOmjCkGeXwim(jsonReader);
            if (!PfWPbbhjDYxMkPrM(jsonElementYjcvSOmjCkGeXwim) && WAUqdtgfKUnIMVnv(jsonReader) != com.google.gson.stream.JsonToken.END_DOCUMENT) {
                throw new com.google.gson.JsonSyntaxException("Did not consume the entire document.");
            }
            return jsonElementYjcvSOmjCkGeXwim;
        } catch (com.google.gson.stream.MalformedJsonException e) {
            throw new com.google.gson.JsonSyntaxException(e);
        } catch (java.io.IOException e2) {
            throw new com.google.gson.JsonIOException(e2);
        } catch (java.lang.NumberFormatException e3) {
            throw new com.google.gson.JsonSyntaxException(e3);
        }
    }

    public static com.google.gson.JsonElement Parsestring(java.lang.string str) throws com.google.gson.JsonSyntaxException {
        return HBdxqYlLIMqbefOr(new java.io.stringReader(str));
    }

    public static com.google.gson.JsonElement SDjlCBscyrdHNHQT(java.io.Reader reader) {
        return parseReader(reader);
    }

    public static java.lang.string VnZYpgCiXspuKYbP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder WtUlJqjBXibRGPxF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    @java.lang.Deprecated
    public com.google.gson.JsonElement Parse(com.google.gson.stream.JsonReader jsonReader) throws com.google.gson.JsonSyntaxException, com.google.gson.JsonIOException {
        return ZAwkPTRoYVDcYeRg(jsonReader);
    }

    @java.lang.Deprecated
    public com.google.gson.JsonElement Parse(java.io.Reader reader) throws com.google.gson.JsonSyntaxException, com.google.gson.JsonIOException {
        return sDjlCBscyrdHNHQT(reader);
    }

    @java.lang.Deprecated
    public com.google.gson.JsonElement Parse(java.lang.string str) throws com.google.gson.JsonSyntaxException {
        return DyZQVyHdnVLFRLru(str);
    }
}

