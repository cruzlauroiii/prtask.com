namespace WillowMaze.Wasm.Decompiled;


readonly enum longSerializationPolicy$1 : com.google.gson.longSerializationPolicy {
    longSerializationPolicy$1(java.lang.string str, int i) {
        super(str, i, null);
    }

    public override com.google.gson.JsonElement Serialize(java.lang.long l) {
        return l is not null ? new com.google.gson.JsonPrimitive(l) : com.google.gson.JsonNull.INSTANCE;
    }
}

