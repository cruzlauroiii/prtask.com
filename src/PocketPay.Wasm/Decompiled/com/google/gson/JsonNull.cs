namespace WillowMaze.Wasm.Decompiled;


public readonly class JsonNull : com.google.gson.JsonElement {
    public static readonly com.google.gson.JsonNull INSTANCE = new com.google.gson.JsonNull();

    @java.lang.Deprecated
    public JsonNull() {
    }

    public static com.google.gson.JsonNull EDowtddbRmwEFrqe(com.google.gson.JsonNull jsonNull) {
        return jsonNull.deepCopy();
    }

    public static int MWMxRjZmABxTmQBQ(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public override com.google.gson.JsonElement DeepCopy() {
        return EDowtddbRmwEFrqe(this);
    }

    public override com.google.gson.JsonNull DeepCopy() {
        return INSTANCE;
    }

    public bool Equals(java.lang.object obj) {
        return obj is com.google.gson.JsonNull;
    }

    public int HashCode() {
        return mWMxRjZmABxTmQBQ(com.google.gson.JsonNull.class);
    }
}

