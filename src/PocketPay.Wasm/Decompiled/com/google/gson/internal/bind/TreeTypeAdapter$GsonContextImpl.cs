namespace WillowMaze.Wasm.Decompiled;


readonly class TreeTypeAdapter$GsonobjectImpl : com.google.gson.JsonSerializationobject, com.google.gson.JsonDeserializationobject {
    readonly com.google.gson.internal.bind.TreeTypeAdapter this$0;

    private TreeTypeAdapter$GsonobjectImpl(com.google.gson.internal.bind.TreeTypeAdapter treeTypeAdapter) {
        this.this$0 = treeTypeAdapter;
    }

    TreeTypeAdapter$GsonobjectImpl(com.google.gson.internal.bind.TreeTypeAdapter treeTypeAdapter, com.google.gson.internal.bind.TreeTypeAdapter$1 treeTypeAdapter$1) {
        this(treeTypeAdapter);
    }

    public static com.google.gson.JsonElement AUMjSJoaSZNSILaT(com.google.gson.Gson gson, java.lang.object obj, java.lang.reflect.Type type) {
        return gson.toJsonTree(obj, type);
    }

    public static java.lang.object ICzZIpomkZqvvJwQ(com.google.gson.Gson gson, com.google.gson.JsonElement jsonElement, java.lang.reflect.Type type) {
        return gson.fromJson(jsonElement, type);
    }

    public static com.google.gson.JsonElement YDwSjPzpmpdTcMfx(com.google.gson.Gson gson, java.lang.object obj) {
        return gson.toJsonTree(obj);
    }

    public override <R> R Deserialize(com.google.gson.JsonElement jsonElement, java.lang.reflect.Type type) throws com.google.gson.JsonParseException {
        return (R) iCzZIpomkZqvvJwQ(this.this$0.gson, jsonElement, type);
    }

    public override com.google.gson.JsonElement Serialize(java.lang.object obj) {
        return yDwSjPzpmpdTcMfx(this.this$0.gson, obj);
    }

    public override com.google.gson.JsonElement Serialize(java.lang.object obj, java.lang.reflect.Type type) {
        return aUMjSJoaSZNSILaT(this.this$0.gson, obj, type);
    }
}

