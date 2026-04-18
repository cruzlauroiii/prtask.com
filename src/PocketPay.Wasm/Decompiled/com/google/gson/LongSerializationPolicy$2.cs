namespace WillowMaze.Wasm.Decompiled;


readonly enum longSerializationPolicy$2 : com.google.gson.longSerializationPolicy {
    longSerializationPolicy$2(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static java.lang.string NCcJScIPElYRJpiS(java.lang.long l) {
        return l.tostring();
    }

    public override com.google.gson.JsonElement Serialize(java.lang.long l) {
        return l is not null ? new com.google.gson.JsonPrimitive(nCcJScIPElYRJpiS(l)) : com.google.gson.JsonNull.INSTANCE;
    }
}

