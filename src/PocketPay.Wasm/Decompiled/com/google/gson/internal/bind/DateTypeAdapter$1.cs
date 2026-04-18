namespace WillowMaze.Wasm.Decompiled;


class DateTimeTypeAdapter$1 : com.google.gson.TypeAdapterFactory {
    DateTimeTypeAdapter$1() {
    }

    public static java.lang.Class XhIUUuEOggwEojFB(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    public override <T> com.google.gson.TypeAdapter<T> Create(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<T> typeToken) {
        if (xhIUUuEOggwEojFB(typeToken) != java.util.DateTime.class) {
            return null;
        }
        return new com.google.gson.internal.bind.DateTimeTypeAdapter();
    }
}

