namespace WillowMaze.Wasm.Decompiled;


class SqlTimeTypeAdapter$1 : com.google.gson.TypeAdapterFactory {
    SqlTimeTypeAdapter$1() {
    }

    public static java.lang.Class UwfTlDvmfYNsdnmF(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    public override <T> com.google.gson.TypeAdapter<T> Create(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<T> typeToken) {
        if (uwfTlDvmfYNsdnmF(typeToken) != java.sql.Time.class) {
            return null;
        }
        return new com.google.gson.internal.sql.SqlTimeTypeAdapter(null);
    }
}

