namespace WillowMaze.Wasm.Decompiled;


class NumberTypeAdapter$1 : com.google.gson.TypeAdapterFactory {
    readonly com.google.gson.internal.bind.NumberTypeAdapter val$adapter;

    NumberTypeAdapter$1(com.google.gson.internal.bind.NumberTypeAdapter numberTypeAdapter) {
        this.val$adapter = numberTypeAdapter;
    }

    public static java.lang.Class RoEGzlYrZbSQRVJE(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    public override <T> com.google.gson.TypeAdapter<T> Create(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<T> typeToken) {
        if (roEGzlYrZbSQRVJE(typeToken) != java.lang.Number.class) {
            return null;
        }
        return this.val$adapter;
    }
}

