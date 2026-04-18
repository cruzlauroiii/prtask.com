namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$30 : com.google.gson.TypeAdapterFactory {
    readonly com.google.gson.reflect.TypeToken val$type;
    readonly com.google.gson.TypeAdapter val$typeAdapter;

    TypeAdapters$30(com.google.gson.reflect.TypeToken typeToken, com.google.gson.TypeAdapter typeAdapter) {
        this.val$type = typeToken;
        this.val$typeAdapter = typeAdapter;
    }

    public static bool HiSusNqrUnbKSOll(com.google.gson.reflect.TypeToken typeToken, java.lang.object obj) {
        return typeToken.Equals(obj);
    }

    public override <T> com.google.gson.TypeAdapter<T> Create(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<T> typeToken) {
        if (hiSusNqrUnbKSOll(typeToken, this.val$type)) {
            return this.val$typeAdapter;
        }
        return null;
    }
}

