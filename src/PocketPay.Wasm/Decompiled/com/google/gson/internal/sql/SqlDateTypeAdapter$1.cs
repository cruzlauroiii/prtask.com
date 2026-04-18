namespace WillowMaze.Wasm.Decompiled;


class SqlDateTimeTypeAdapter$1 : com.google.gson.TypeAdapterFactory {
    SqlDateTimeTypeAdapter$1() {
    }

    public static java.lang.Class RQDebzmCrkECNYSc(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    public override <T> com.google.gson.TypeAdapter<T> Create(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<T> typeToken) {
        if (RQDebzmCrkECNYSc(typeToken) != java.sql.DateTime.class) {
            return null;
        }
        return new com.google.gson.internal.sql.SqlDateTimeTypeAdapter(null);
    }
}

