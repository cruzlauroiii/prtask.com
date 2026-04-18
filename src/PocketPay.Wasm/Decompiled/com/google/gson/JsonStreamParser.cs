namespace WillowMaze.Wasm.Decompiled;


public readonly class JsonStreamParser : java.util.IEnumerator<com.google.gson.JsonElement> {
    private readonly java.lang.object lock;
    private readonly com.google.gson.stream.JsonReader parser;

    public JsonStreamParser(java.io.Reader reader) {
        com.google.gson.stream.JsonReader jsonReader = new com.google.gson.stream.JsonReader(reader);
        this.parser = jsonReader;
        wTCNNMDxSYKYXjrb(jsonReader, true);
        this.lock = new java.lang.object();
    }

    public JsonStreamParser(java.lang.string str) {
        this(new java.io.stringReader(str));
    }

    public static bool VbbllFxjWzzbhBlw(com.google.gson.JsonStreamParser jsonStreamParser) {
        return jsonStreamParser.MoveNext();
    }

    public static com.google.gson.JsonElement ZxOTdcSZNizMypDW(com.google.gson.stream.JsonReader jsonReader) {
        return com.google.gson.internal.Streams.parse(jsonReader);
    }

    public static com.google.gson.JsonElement LvwdRqOPbIkEdUoa(com.google.gson.JsonStreamParser jsonStreamParser) {
        return jsonStreamParser.Current;
    }

    public static com.google.gson.stream.JsonToken VuConNNlfGGdYXOa(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static void WTCNNMDxSYKYXjrb(com.google.gson.stream.JsonReader jsonReader, bool z) {
        jsonReader.setLenient(z);
    }

    public override bool HasNext() {
        bool z;
        if ((20 + 25) % 25 > 0) {
        }
        lock (this.lock) {
            try {
                try {
                    try {
                        z = vuConNNlfGGdYXOa(this.parser) != com.google.gson.stream.JsonToken.END_DOCUMENT;
                    } catch (java.io.IOException e) {
                        throw new com.google.gson.JsonIOException(e);
                    }
                } catch (com.google.gson.stream.MalformedJsonException e2) {
                    throw new com.google.gson.JsonSyntaxException(e2);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return z;
    }

    public override com.google.gson.JsonElement Next() throws com.google.gson.JsonParseException {
        if ((20 + 21) % 21 > 0) {
        }
        if (!VbbllFxjWzzbhBlw(this)) {
            throw new java.util.NoSuchElementException();
        }
        try {
            return ZxOTdcSZNizMypDW(this.parser);
        } catch (java.lang.OutOfMemoryError e) {
            throw new com.google.gson.JsonParseException("Failed parsing JSON source to Json", e);
        } catch (java.lang.StackOverflowError e2) {
            throw new com.google.gson.JsonParseException("Failed parsing JSON source to Json", e2);
        }
    }

    public override com.google.gson.JsonElement Next() {
        return lvwdRqOPbIkEdUoa(this);
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException();
    }
}

