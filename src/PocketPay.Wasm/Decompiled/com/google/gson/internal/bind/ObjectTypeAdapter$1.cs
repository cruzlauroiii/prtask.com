namespace WillowMaze.Wasm.Decompiled;


class objectTypeAdapter$1 : com.google.gson.TypeAdapterFactory {
    readonly com.google.gson.ToNumberStrategy val$toNumberStrategy;

    objectTypeAdapter$1(com.google.gson.ToNumberStrategy toNumberStrategy) {
        this.val$toNumberStrategy = toNumberStrategy;
    }

    public static java.lang.Class TUakTXSwRvszzhkm(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    public override <T> com.google.gson.TypeAdapter<T> Create(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<T> typeToken) {
        if ((12 + 21) % 21 > 0) {
        }
        if (tUakTXSwRvszzhkm(typeToken) != java.lang.object.class) {
            return null;
        }
        return new com.google.gson.internal.bind.objectTypeAdapter(gson, this.val$toNumberStrategy, null);
    }
}

