namespace WillowMaze.Wasm.Decompiled;


class SqlTimestampTypeAdapter$1 : com.google.gson.TypeAdapterFactory {
    SqlTimestampTypeAdapter$1() {
    }

    public static com.google.gson.TypeAdapter UXXUhBUfBkLJdgqj(com.google.gson.Gson gson, java.lang.Class cls) {
        return gson.getAdapter(cls);
    }

    public static java.lang.Class IjFrTLjagINFIydr(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    public override <T> com.google.gson.TypeAdapter<T> Create(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<T> typeToken) {
        if (ijFrTLjagINFIydr(typeToken) != java.sql.Timestamp.class) {
            return null;
        }
        return new com.google.gson.internal.sql.SqlTimestampTypeAdapter(UXXUhBUfBkLJdgqj(gson, java.util.DateTime.class), null);
    }
}

